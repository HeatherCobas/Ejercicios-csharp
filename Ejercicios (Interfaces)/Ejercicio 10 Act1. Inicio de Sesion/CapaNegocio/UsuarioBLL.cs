using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
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

        public (bool, string) RegistrarUsuario(string usuario, string contraseña, string nombre, string apellido, string email)
        {
            return usuarioDAL.RegistrarUsuario(usuario, contraseña, nombre, apellido, email);
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
            using (SqlConnection conn = conexion.ObtenerConexion())
            {
                SqlCommand cmd = new SqlCommand("SP_EditarUsuario", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@IdUsuario", usuario.IdUsuario);
                cmd.Parameters.AddWithValue("@NombreUsuario", usuario.NombreUsuario);
                cmd.Parameters.AddWithValue("@Contraseña", usuario.Contraseña);
                cmd.Parameters.AddWithValue("@Nombre", usuario.Nombre);
                cmd.Parameters.AddWithValue("@Apellido", usuario.Apellido);
                cmd.Parameters.AddWithValue("@Email", usuario.Email);
                cmd.Parameters.AddWithValue("@RutaFotoPerfil", usuario.RutaFotoPerfil ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@Activo", usuario.Activo);

                conn.Open();
                int filasAfectadas = cmd.ExecuteNonQuery();

                if (filasAfectadas > 0)
                    return "Usuario actualizado con éxito.";
                else
                    return $"Error: no se actualizó ningún registro. ID: {usuario.IdUsuario}";
            }
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