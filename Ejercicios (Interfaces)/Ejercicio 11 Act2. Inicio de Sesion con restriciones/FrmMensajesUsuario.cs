using CapaEntidad;
using CapaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Act.Inicio_de_Sesion
{
    public partial class FrmMensajesUsuario : Form
    {
        private MensajeBLL mensajeBLL = new MensajeBLL();
        private Usuario usuarioActual;


        public FrmMensajesUsuario(Usuario usuario)
        {
            InitializeComponent();

            usuarioActual = usuario;

            if (usuarioActual != null)
            {
                LblNUsuario.Text = usuarioActual.NombreUsuario;
                CargarRespuestas();
            }
            else
            {
                MessageBox.Show("No se ha proporcionado información del usuario.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtAsunto.Text) || string.IsNullOrWhiteSpace(txtContenido.Text))
            {
                MessageBox.Show("Por favor, completa el asunto y el contenido del mensaje.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Mensaje mensaje = new Mensaje()
            {
                NombreUsuario = LblNUsuario.Text.Trim(),
                Asunto = txtAsunto.Text.Trim(),
                Contenido = txtContenido.Text.Trim()
            };

            bool enviado = mensajeBLL.EnviarMensaje(mensaje);

            if (enviado)
            {
                MessageBox.Show("Mensaje enviado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Limpiar();
            }
            else
            {
                MessageBox.Show("Hubo un error al enviar el mensaje.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void Limpiar()
        {
            txtAsunto.Clear();
            txtContenido.Clear();
        }

        private void Btn_Otro_M_Click(object sender, EventArgs e)
        {
            TC_Mensaje_de_Usuario.SelectedIndex = 0;
        }

        private void RTB_Respuestas_TextChanged(object sender, EventArgs e)
        {
        }

        private void Dgv_Respuestas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = Dgv_Respuestas.Rows[e.RowIndex];

                string respuesta = fila.Cells["Respuesta"].Value?.ToString() ?? "No hay respuesta disponible.";
                RTB_Respuestas.Text = respuesta;

                if (fila.Cells["FechaRespuesta"].Value != null)
                {
                    DateTime fecha = Convert.ToDateTime(fila.Cells["FechaRespuesta"].Value);
                    lblFecha_R.Text = fecha.ToString("dd/MM/yyyy HH:mm");
                }
                else
                {
                    lblFecha_R.Text = "Sin fecha";
                }
            }
        }


        private void CargarRespuestas()
        {
            try
            {
                Dgv_Respuestas.DataSource = null;

                DataTable respuestas = mensajeBLL.ObtenerRespuestasPorUsuario(usuarioActual.IdUsuario);

                if (respuestas != null && respuestas.Rows.Count > 0)
                {
                    Dgv_Respuestas.DataSource = respuestas;
                }
                else
                {
                    MessageBox.Show("No tienes respuestas disponibles aún.",
                                   "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar las respuestas: {ex.Message}",
                               "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtBuscador_TextChanged(object sender, EventArgs e)
        {
            string filtro = txtBuscador.Text.Trim().ToLower();

            if (Dgv_Respuestas.DataSource is DataTable dt)
            {
                DataView dv = dt.DefaultView;
                dv.RowFilter = $"Asunto LIKE '%{filtro}%' OR Contenido LIKE '%{filtro}%'";
                Dgv_Respuestas.DataSource = dv.ToTable();
            }
        }


        private void lblFecha_R_Click(object sender, EventArgs e)
        {
            if (Dgv_Respuestas.CurrentRow != null)
            {
                var fila = Dgv_Respuestas.CurrentRow;

                if (fila.Cells["FechaRespuesta"].Value != null)
                {
                    DateTime fecha = Convert.ToDateTime(fila.Cells["FechaRespuesta"].Value);
                    MessageBox.Show($"Fecha de la respuesta: {fecha.ToString("dd/MM/yyyy HH:mm")}", "Fecha", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No hay fecha disponible para esta respuesta.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}