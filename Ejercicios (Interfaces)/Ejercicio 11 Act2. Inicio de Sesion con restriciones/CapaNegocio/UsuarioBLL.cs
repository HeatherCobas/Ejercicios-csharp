using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaEntidad;

namespace CapaNegocio
{
    public class UsuarioBLL
    {
        private readonly UsuarioDAL usuarioDAL = new UsuarioDAL();
        private readonly Conexion conexion = new Conexion();

        public Usuario IniciarSesion(string nombreUsuario, string contraseña)
        {
            UsuarioDAL dal = new UsuarioDAL();
            return dal.IniciarSesion(nombreUsuario, contraseña);
        }

        public (bool Exito, string Mensaje) Registrar(Usuario usuario)
        {
            return usuarioDAL.RegistrarUsuario(usuario);
        }

        public void RecordarUsuario(int usuarioId, bool recordar)
        {
            usuarioDAL.RecordarUsuario(usuarioId, recordar);
        }

        public Usuario ObtenerUsuarioRecordado()
        {
            return usuarioDAL.ObtenerUsuarioRecordado();
        }

        public void GuardarRutaFotoPerfil(int idUsuario, string ruta)
        {
            usuarioDAL.GuardarRutaFotoPerfil(idUsuario, ruta);
        }

        public string EliminarUsuario(int id)
        {
            try
            {
                return usuarioDAL.EliminarUsuario(id);
            }
            catch (Exception ex)
            {
                return "Error al eliminar: " + ex.Message;
            }
        }

        public string EditarUsuario(Usuario usuario)
        {
            return usuarioDAL.EditarUsuario(usuario);
        }


        public DataTable BuscarUsuarios(string filtro)
        {
            return usuarioDAL.BuscarUsuarios(filtro);
        }

        public DataTable ObtenerUsuarios()
        {
            return usuarioDAL.ObtenerUsuarios();
        }

        public void GuardarUsuario(Usuario usuario)
        {
            usuarioDAL.GuardarUsuario(usuario);
        }

        public Usuario ObtenerUsuarioPorId(int idUsuario)
        {
            try
            {
                return usuarioDAL.ObtenerUsuarioPorId(idUsuario);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener usuario: " + ex.Message);
            }
        }
    }
}