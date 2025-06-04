using CapaEntidad;
using CapaNegocio;
using System;
using System.Data;
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
            CargarMensajes();
        }

        private void CargarMensajes()
        {
            DataTable dt = mensajeBLL.ObtenerTodosMensajes();
            dgvMensajes.DataSource = dt;
            dgvMensajes.Columns["IdMensaje"].Visible = false;
            dgvMensajes.Columns["Respuesta"].Visible = false;
            dgvMensajes.Columns["FechaRespuesta"].Visible = false;
        }

        private void dgvMensajes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = dgvMensajes.Rows[e.RowIndex];
                idMensajeSeleccionado = Convert.ToInt32(fila.Cells["IdMensaje"].Value);
                lblUsuarioValor.Text = fila.Cells["Nombre_Usuario"].Value.ToString();
                txtAsunto.Text = fila.Cells["Asunto"].Value.ToString();
                txtMensaje.Text = fila.Cells["Contenido"].Value.ToString();
                txtRespuesta.Text = fila.Cells["Respuesta"].Value?.ToString() ?? "";
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            CargarMensajes();
            LimpiarCampos();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
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