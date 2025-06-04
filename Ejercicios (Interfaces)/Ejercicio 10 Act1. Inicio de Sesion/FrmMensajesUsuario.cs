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
        private int idUsuario;
        private Usuario usuarioActual;
        private string nombreUsuario;
        private MensajeBLL mensajeBLL = new MensajeBLL();

        public FrmMensajesUsuario(int idUsuario, string nombreUsuario)
        {
            InitializeComponent();
            this.idUsuario = idUsuario;
            txtUsuario.Text = nombreUsuario;
            txtUsuario.Enabled = false;
            usuarioActual = new UsuarioBLL().ObtenerUsuarioPorId(idUsuario);
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            string nombreUsuario = this.nombreUsuario;
            string asunto = txtAsunto.Text.Trim();
            string contenido = txtContenido.Text.Trim();

            if (string.IsNullOrEmpty(asunto) || string.IsNullOrEmpty(contenido))
            {
                MessageBox.Show("Por favor, complete todos los campos.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            

            if (idUsuario == -1)
            {
                MessageBox.Show("El usuario no existe en la base de datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Mensaje nuevoMensaje = new Mensaje
            {
                IdUsuario = idUsuario,
                Asunto = asunto,
                Contenido = contenido,
                FechaEnvio = DateTime.Now
            };

            bool mensajeGuardado = mensajeBLL.GuardarMensaje(nuevoMensaje);

            if (mensajeGuardado)
            {
                MessageBox.Show("Mensaje enviado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtAsunto.Clear();
                txtContenido.Clear();
            }
            else
            {
                MessageBox.Show("No se pudo enviar el mensaje.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void txtUsuario_Click(object sender, EventArgs e)
        {
            if (usuarioActual != null)
            {
                string mensajeUsuario = $"Información del usuario:\n\n" +
                                      $"Nombre completo: {usuarioActual.Nombre} {usuarioActual.Apellido}\n" +
                                      $"Nombre de usuario: {usuarioActual.NombreUsuario}\n" +
                                      $"Email: {usuarioActual.Email}\n" +
                                      $"Estado: {(usuarioActual.Activo ? "Activo" : "Inactivo")}";

                MessageBox.Show(mensajeUsuario, "Detalles del Usuario",
                              MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No se pudieron cargar los datos del usuario.", "Información",
                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}