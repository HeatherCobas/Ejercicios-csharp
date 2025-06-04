using CapaEntidad;
using CapaNegocio;
using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Act.Inicio_de_Sesion
{
    public partial class FrmMensajesSoporte : Form
    {
        private MensajeBLL mensajeBLL = new MensajeBLL();
        private int idMensajeSeleccionado = -1;

        public FrmMensajesSoporte()
        {
            InitializeComponent();
            CargarMensajespendientes();
            CargarMensajes();
        }

        private void CargarMensajespendientes()
        {
            var mensajes = mensajeBLL.ObtenerMensajesPendientes();
            dgvMensajes.DataSource = mensajes;

            if (dgvMensajes.Columns.Contains("Contestado"))
            {
                dgvMensajes.Columns["Contestado"].HeaderText = "¿Contestado?";
            }
        }

        private void dgvMensajes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = dgvMensajes.Rows[e.RowIndex];
                idMensajeSeleccionado = Convert.ToInt32(fila.Cells["IdMensaje"].Value);
                lblUsuarioValor.Text = fila.Cells["NombreUsuario"].Value.ToString();
                txtAsunto.Text = fila.Cells["Asunto"].Value.ToString();
                txtMensaje.Text = fila.Cells["Contenido"].Value.ToString();
                txtRespuesta.Text = fila.Cells["Respuesta"].Value?.ToString() ?? "";
                
                if (dgvMensajes.Columns.Contains("Contestado"))
                {
                    dgvMensajes.Columns["Contestado"].HeaderText = "¿Contestado?";
                }
            }

            //Quiero que se muestren los mensajes que ya fueron contestados
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
           //Con este btn podras actualizar una respuesta
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnResponder_Click(object sender, EventArgs e)
        {
            if (idMensajeSeleccionado == -1)
            {
                MessageBox.Show("Por favor, selecciona un mensaje para responder.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtRespuesta.Text))
            {
                MessageBox.Show("Por favor, escribe una respuesta.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Mensaje mensaje = new Mensaje()
            {
                IdMensaje = idMensajeSeleccionado,
                Respuesta = txtRespuesta.Text.Trim(),
                Contestado = true
            };

            bool actualizado = mensajeBLL.ResponderMensaje(mensaje);

            if (actualizado)
            {
                MessageBox.Show("Mensaje contestado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarCampos();
                CargarMensajespendientes();
            }
            else
            {
                MessageBox.Show("Hubo un error al responder el mensaje.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarMensajes()
        {
            var mensajes = mensajeBLL.ObtenerTodosLosMensajes();

            if (mensajes != null && mensajes.Count > 0)
            {
                dgvMensajes.DataSource = mensajes;
            }
            else
            {
                dgvMensajes.DataSource = null;
                MessageBox.Show("No hay mensajes para mostrar.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            if (dgvMensajes.Columns.Contains("Contestado"))
            {
                dgvMensajes.Columns["Contestado"].HeaderText = "¿Contestado?";
            }
        }


        private void LimpiarCampos()
        {
            idMensajeSeleccionado = -1;
            lblUsuarioValor.Text = string.Empty;
            txtAsunto.Clear();
            txtMensaje.Clear();
            txtRespuesta.Clear();
        }

    }
}