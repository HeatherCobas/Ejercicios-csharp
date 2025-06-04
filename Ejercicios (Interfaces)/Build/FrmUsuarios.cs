using CapaEntidad;
using CapaNegocio;
using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;

namespace Act.Inicio_de_Sesion
{
    public partial class FrmUsuarios: Form
    {
        private int? idUsuarioSeleccionado = null;
        private UsuarioBLL usuarioBLL = new UsuarioBLL();
        private RolBLL rolBLL = new RolBLL();

        public FrmUsuarios()
        {
            InitializeComponent();
            CargarUsuarios();
            CargarRoles();
        }

        private void btnSeleccionarImagen_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Imágenes|*.jpg;*.jpeg;*.png;*.bmp";
            openFileDialog1.Title = "Seleccionar imagen de perfil";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                picFotoPerfil.ImageLocation = openFileDialog1.FileName;
            }
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            string filtro = txtBuscar.Text.Trim();
            dgvUsuarios.DataSource = usuarioBLL.BuscarUsuarios(filtro);
        }

        private void dgvUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = dgvUsuarios.Rows[e.RowIndex];

                idUsuarioSeleccionado = Convert.ToInt32(fila.Cells["Id_Usuario"].Value ?? 0);
                txtUsuario.Text = fila.Cells["Nombre_Usuario"].Value?.ToString() ?? "";
                txtNombre.Text = fila.Cells["Nombre"].Value?.ToString() ?? "";
                txtApellido.Text = fila.Cells["Apellido"].Value?.ToString() ?? "";
                txtEmail.Text = fila.Cells["Email"].Value?.ToString() ?? "";
                chkActivo.Checked = Convert.ToBoolean(fila.Cells["Activo"].Value ?? false);

                picFotoPerfil.Image = Act.Inicio_de_Sesion.Properties.Resources.default_user;

                string defaultImagePath = Path.Combine(Application.StartupPath, "Resources", "default_user.png");
                if (File.Exists(defaultImagePath))
                {
                    picFotoPerfil.Image = Image.FromFile(defaultImagePath);
                }
                else
                {
                    picFotoPerfil.Image = null;
                }

                string rolUsuario = fila.Cells["NombreRol"].Value?.ToString() ?? "";
                cmbRoles.Text = rolUsuario;
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();
            txtUsuario.Focus();
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            if (dgvUsuarios.SelectedRows.Count > 0)
            {
                string rutaFotoPerfil = picFotoPerfil.ImageLocation ?? "";

                Usuario user = new Usuario()
                {
                    IdUsuario = idUsuarioSeleccionado.HasValue ? idUsuarioSeleccionado.Value : 0,
                    NombreUsuario = txtUsuario.Text.Trim(),
                    Contraseña = txtContraseña.Text.Trim(),
                    Nombre = txtNombre.Text.Trim(),
                    Apellido = txtApellido.Text.Trim(),
                    Email = txtEmail.Text.Trim(),
                    Activo = chkActivo.Checked,
                    RutaFotoPerfil = rutaFotoPerfil
                };

                string mensaje = usuarioBLL.EditarUsuario(user);
                MessageBox.Show(mensaje, "Editar Usuario", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarUsuarios();
                LimpiarFormulario();
            }
            else
            {
                MessageBox.Show("Seleccione un usuario para editar", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario
            {
                IdUsuario = idUsuarioSeleccionado.HasValue ? idUsuarioSeleccionado.Value : 0,
                NombreUsuario = txtUsuario.Text.Trim(),
                Contraseña = txtContraseña.Text.Trim(),
                Nombre = txtNombre.Text.Trim(),
                Apellido = txtApellido.Text.Trim(),
                Email = txtEmail.Text.Trim(),
                Activo = chkActivo.Checked,
                RutaFotoPerfil = picFotoPerfil.ImageLocation ?? ""
            };

            if (string.IsNullOrWhiteSpace(usuario.NombreUsuario) ||
                string.IsNullOrWhiteSpace(usuario.Contraseña) ||
                string.IsNullOrWhiteSpace(usuario.Nombre) ||
                string.IsNullOrWhiteSpace(usuario.Apellido) ||
                string.IsNullOrWhiteSpace(usuario.Email))
            {
                MessageBox.Show("Complete todos los campos obligatorios.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            usuarioBLL.GuardarUsuario(usuario);

            MessageBox.Show("Usuario guardado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LimpiarCampos();
            CargarUsuarios();
        }


        private void LimpiarCampos()
        {
            txtUsuario.Clear();
            txtContraseña.Clear();
            txtNombre.Clear();
            txtApellido.Clear();
            txtEmail.Clear();
            chkActivo.Checked = true;
            picFotoPerfil.ImageLocation = null;
            idUsuarioSeleccionado = null;
        }
        private void LimpiarFormulario()
        {
            txtUsuario.Text = "";
            txtContraseña.Text = "";
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtEmail.Text = "";
            chkActivo.Checked = true;
        }
        private void CargarUsuarios()
        {
            dgvUsuarios.AutoGenerateColumns = false;

            dgvUsuarios.Columns.Clear();

            dgvUsuarios.DataSource = usuarioBLL.ObtenerUsuarios();

            dgvUsuarios.Columns.Add("Id_Usuario", "ID");
            dgvUsuarios.Columns["Id_Usuario"].DataPropertyName = "Id_Usuario";

            dgvUsuarios.Columns.Add("Nombre_Usuario", "Usuario");
            dgvUsuarios.Columns["Nombre_Usuario"].DataPropertyName = "Nombre_Usuario";

            dgvUsuarios.Columns.Add("Nombre", "Nombre");
            dgvUsuarios.Columns["Nombre"].DataPropertyName = "Nombre";

            dgvUsuarios.Columns.Add("Apellido", "Apellido");
            dgvUsuarios.Columns["Apellido"].DataPropertyName = "Apellido";

            dgvUsuarios.Columns.Add("Email", "Correo");
            dgvUsuarios.Columns["Email"].DataPropertyName = "Email";

            dgvUsuarios.Columns.Add("Activo", "Activo");
            dgvUsuarios.Columns["Activo"].DataPropertyName = "Activo";

            dgvUsuarios.Columns.Add("RutaFotoPerfil", "Foto");
            dgvUsuarios.Columns["RutaFotoPerfil"].DataPropertyName = "RutaFotoPerfil";

            dgvUsuarios.Columns.Add("NombreRol", "Rol");
            dgvUsuarios.Columns["NombreRol"].DataPropertyName = "NombreRol";
        }


        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvUsuarios.SelectedRows.Count == 0)
            {
                MessageBox.Show("Por favor selecciona un usuario para eliminar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            DialogResult confirm = MessageBox.Show("¿Estás seguro de que deseas eliminar este usuario?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (confirm == DialogResult.Yes)
            {
                int idUsuario = Convert.ToInt32(dgvUsuarios.CurrentRow.Cells["Id_Usuario"].Value);

                UsuarioBLL usuarioBLL = new UsuarioBLL();
                string mensaje = usuarioBLL.EliminarUsuario(idUsuario);

                MessageBox.Show(mensaje, "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarUsuarios();
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CargarRoles()
        {
            cmbRoles.DataSource = rolBLL.ObtenerRoles();
            cmbRoles.DisplayMember = "NombreRol";
            cmbRoles.ValueMember = "IdRol";
        }
    }
}

//El rol no quiere aparecer en el dgv