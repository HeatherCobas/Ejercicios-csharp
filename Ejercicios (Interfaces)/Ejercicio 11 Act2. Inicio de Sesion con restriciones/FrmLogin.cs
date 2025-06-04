using System;
using System.Windows.Forms;
using CapaNegocio;
using CapaEntidad;
using Microsoft.Win32;
using System.Security.Cryptography;
using System.Text;

namespace Act.Inicio_de_Sesion
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            CargarDatosGuardados();
        }

        private void Btn_Inicio_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text.Trim();
            string contraseña = txtContraseña.Text.Trim();

            if (usuario == "" || contraseña == "")
            {
                MessageBox.Show("Por favor, ingrese el usuario y la contraseña", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            UsuarioBLL usuarioBLL = new UsuarioBLL();
            try
            {
                Usuario usuarioLogueado = usuarioBLL.IniciarSesion(usuario, contraseña);

                if (usuarioLogueado == null)
                {
                    MessageBox.Show("Usuario o contraseña incorrectos. Por favor, inténtelo de nuevo.", "Error de inicio de sesión", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                FrmMenuPrincipal frm = new FrmMenuPrincipal(usuarioLogueado);
                frm.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al intentar iniciar sesión: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            FrmRegistrarUsuario frmRegistro = new FrmRegistrarUsuario();
            frmRegistro.ShowDialog();
        }

        private void linkLabelOlvide_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string entrada = Microsoft.VisualBasic.Interaction.InputBox("Ingrese su correo o nombre de usuario:", "Recuperar contraseña", "");

            if (!string.IsNullOrEmpty(entrada))
            {
                MessageBox.Show($"Se ha enviado un enlace de recuperación a la dirección asociada con '{entrada}'.", "Recuperación", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void CargarDatosGuardados()
        {
            UsuarioBLL usuarioBLL = new UsuarioBLL();
            Usuario usuarioRecordado = usuarioBLL.ObtenerUsuarioRecordado();

            if (usuarioRecordado != null)
            {
                txtUsuario.Text = usuarioRecordado.NombreUsuario;
                checkBoxRecordar.Checked = true;
            }
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}