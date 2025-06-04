using System;
using System.Windows.Forms;
using CapaEntidad;
using CapaNegocio;


namespace Act.Inicio_de_Sesion
{
    public partial class FrmRegistrarUsuario : Form
    {
        public FrmRegistrarUsuario()
        {
            InitializeComponent();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text.Trim();
            string contraseña = txtContraseña.Text.Trim();
            string confirmarContraseña = txtConfirmarContraseña.Text.Trim();
            string nombre = txtNombre.Text.Trim();
            string apellido = txtApellidos.Text.Trim();
            string email = txtEmail.Text.Trim();
            bool activo = true;
            string rutaFotoPerfil = "default_user.png";


            if (usuario == "" || contraseña == "" || nombre == "" || apellido == "" || email == "")
            {
                MessageBox.Show("Por favor complete todos los campos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!cbTerminos.Checked)
            {
                MessageBox.Show("Debe aceptar los términos y condiciones para continuar", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!IsValidEmail(email))
            {
                MessageBox.Show("Por favor ingrese un correo electrónico válido", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!EsUsuarioValido(usuario))
            {
                MessageBox.Show("El nombre de usuario no es válido", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (contraseña != confirmarContraseña)
            {
                MessageBox.Show("Las contraseñas no coinciden", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }


        private bool IsValidEmail(string email)
        {
            try
            {
                var mailAddress = new System.Net.Mail.MailAddress(email);
                return mailAddress.Address == email;
            }
            catch
            {
                return false;
            }
        }

        private bool EsUsuarioValido(string usuario)
        {
            string[] palabrasProhibidas = { "malo", "tonto", "idiota", "pene", "toto" }; 
            if (usuario.Length > 15)
                return false;

            foreach (string palabra in palabrasProhibidas)
            {
                if (usuario.ToLower().Contains(palabra))
                    return false;
            }

            return true;
        }


        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtUsuario.Clear();
            txtContraseña.Clear();
            txtNombre.Clear();
            txtApellidos.Clear();
            txtEmail.Clear();
            txtTelefono.Clear();
            txtConfirmarContraseña.Clear();
        }

        private void pictureBoxLogo_Click(object sender, EventArgs e)
        {

        }

        private void panelLateral_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}