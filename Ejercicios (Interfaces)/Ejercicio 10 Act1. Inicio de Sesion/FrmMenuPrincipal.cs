using CapaEntidad;
using CapaNegocio;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Collections.Specialized.BitVector32;

namespace Act.Inicio_de_Sesion
{
    public partial class FrmMenuPrincipal: Form
    {
        private Usuario usuarioActual;
        private RolBLL rolBLL = new RolBLL();
        private Rol rolActual;
        public int IdUsuarioLogueado { get; set; }
        public string NombreUsuarioLogueado { get; set; }


        public FrmMenuPrincipal(Usuario usuario)
        {
            InitializeComponent();
            usuarioActual = usuario;

            TxtNombreUsuario.Text = usuarioActual.NombreUsuario;
            lblBienvenida.Text = $"Bienvenido, {usuario.Nombre} {usuario.Apellido}";

            rolActual = rolBLL.ObtenerRolPorUsuario(usuarioActual.IdUsuario);
            txtRol.Text = rolActual?.NombreRol ?? "Rol no asignado";

            CargarFotoPerfil();
            CargarRol();

            if (rolActual != null && (rolActual.NombreRol == "Administrador" || rolActual.NombreRol == "Soporte"))
            {
                BtnRespuestasU.Visible = true;
            }
            else
            {
                BtnRespuestasU.Visible = false;
            }
        }
        private void BtnCerrarSesion_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.Show();
        }
        private void Pic_FDP_Click(object sender, EventArgs e)
        {
        }
        private void CargarFotoPerfil()
        {
            string carpetaFotos = Path.Combine(Application.StartupPath, "Resources");
            string rutaFoto = usuarioActual.RutaFotoPerfil;

            try
            {
                if (!string.IsNullOrEmpty(rutaFoto) && File.Exists(rutaFoto))
                {
                    Pic_FDP.Image = Image.FromFile(rutaFoto);
                }
                else
                {
                    string[] extensiones = { ".jpg", ".jpeg", ".png" };
                    foreach (string ext in extensiones)
                    {
                        string posibleRuta = Path.Combine(carpetaFotos, $"usuario_{usuarioActual.IdUsuario}{ext}");
                        if (File.Exists(posibleRuta))
                        {
                            Pic_FDP.Image = Image.FromFile(posibleRuta);
                            usuarioActual.RutaFotoPerfil = posibleRuta;
                            return;
                        }
                    }

                    string rutaDefault = Path.Combine(carpetaFotos, "default.png");
                    if (File.Exists(rutaDefault))
                    {
                        Pic_FDP.Image = Image.FromFile(rutaDefault);
                    }
                    else
                    {
                        Pic_FDP.Image = null;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar la imagen de perfil: " + ex.Message);
            }
        }

        private void BtnUsuarios_Click(object sender, EventArgs e)
        {
            rolActual = rolBLL.ObtenerRolPorUsuario(usuarioActual.IdUsuario);

            if (rolActual != null)
            {
                FrmUsuarios frmUsuarios = new FrmUsuarios();
                frmUsuarios.ShowDialog();
            }
            else
            {
                MessageBox.Show("No se pudo determinar tu rol. Acceso denegado.");
                BtnUsuarios.Enabled = false;
            }
        }

        private Rol CargarRol()
        {
            return new Rol
            {
                IdRol = 1,
                NombreRol = "Administrador"
            };
        }

        private void txtRol_Click(object sender, EventArgs e)
        {
            Rol rol = rolBLL.ObtenerRolPorUsuario(usuarioActual.IdUsuario);

            if (rol != null)
            {
                txtRol.Text = rol.NombreRol;
            }
            else
            {
                MessageBox.Show("No se ha asignado un rol para este usuario.");
            }
        }

        private void BtnRespuestasU_Click(object sender, EventArgs e)
        {
            FrmMensajesSoporte frm = new FrmMensajesSoporte();
            frm.Show();
        }

        private void BtnMensajesU_Click(object sender, EventArgs e)
        {
            FrmMensajesUsuario frm = new FrmMensajesUsuario(IdUsuarioLogueado, NombreUsuarioLogueado);
            frm.Show();
        }
    }
}