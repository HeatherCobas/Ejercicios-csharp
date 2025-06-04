using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidad;
using System.Runtime.Remoting.Contexts;
using System.Security.Cryptography;
using System.Security.Policy;

namespace CapaDatos
{
    public class UsuarioDAL
    {
        private readonly Conexion conexion = new Conexion();

        public Usuario ValidarUsuario(string nombreUsuario, string contraseña)
        {
            using (SqlConnection conn = conexion.ObtenerConexion())
            {
                SqlCommand cmd = new SqlCommand("SP_ValidarUsuario", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@NombreUsuario", nombreUsuario);
                cmd.Parameters.AddWithValue("@Contraseña", contraseña);

                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    return new Usuario
                    {
                        IdUsuario = Convert.ToInt32(reader["Id_Usuario"]),
                        NombreUsuario = reader["Nombre_Usuario"].ToString(),
                        Nombre = reader["Nombre"].ToString(),
                        Apellido = reader["Apellido"].ToString(),
                        Email = reader["Email"].ToString()
                    };
                }

                return null;
            }
        }

        public (bool Exito, string Mensaje) RegistrarUsuario(Usuario usuario)
        {
            if (string.IsNullOrWhiteSpace(usuario.NombreUsuario) || string.IsNullOrWhiteSpace(usuario.Contraseña) ||
                string.IsNullOrWhiteSpace(usuario.Nombre) || string.IsNullOrWhiteSpace(usuario.Apellido) ||
                string.IsNullOrWhiteSpace(usuario.Email))
            {
                return (false, "Todos los campos son obligatorios");
            }

            try
            {
                using (SqlConnection conn = conexion.ObtenerConexion())
                {
                    SqlCommand cmd = new SqlCommand("SP_InsertarUsuario", conn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@Nombre_Usuario", usuario.NombreUsuario);
                    cmd.Parameters.AddWithValue("@Contraseña", HashPassword(usuario.Contraseña));
                    cmd.Parameters.AddWithValue("@Nombre", usuario.Nombre);
                    cmd.Parameters.AddWithValue("@Apellido", usuario.Apellido);
                    cmd.Parameters.AddWithValue("@Email", usuario.Email.Trim().ToLower());
                    cmd.Parameters.AddWithValue("@Activo", usuario.Activo);
                    cmd.Parameters.AddWithValue("@RutaFotoPerfil", usuario.RutaFotoPerfil ?? (object)DBNull.Value);

                    conn.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            int resultado = Convert.ToInt32(reader["Resultado"]);
                            string mensaje = reader["Mensaje"].ToString();
                            return (resultado == 1, mensaje);
                        }
                        else
                        {
                            return (true, "Usuario registrado correctamente (sin mensaje del SP)");
                        }
                    }
                }
            }
            catch (SqlException sqlEx) when (sqlEx.Number == 2627 || sqlEx.Number == 2601)
            {
                string campo = sqlEx.Message.Contains("Nombre_Usuario") ? "nombre de usuario" : "email";
                return (false, $"El {campo} ya está registrado");
            }
            catch (SqlException sqlEx)
            {
                Console.WriteLine($"Error SQL al registrar usuario: {sqlEx.Message}");
                return (false, "Error de base de datos al registrar el usuario");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error inesperado al registrar usuario: {ex.Message}");
                return (false, "Error inesperado al registrar el usuario");
            }

        }


        public Usuario ObtenerUsuarioRecordado()
        {
            using (SqlConnection conn = conexion.ObtenerConexion())
            {
                SqlCommand cmd = new SqlCommand("SP_ObtenerUsuarioRecordado", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    return new Usuario
                    {
                        IdUsuario = Convert.ToInt32(reader["Id_Usuario"]),
                        NombreUsuario = reader["Nombre_Usuario"].ToString(),
                        Contraseña = reader["Contraseña"].ToString(),
                        Nombre = reader["Nombre"].ToString(),
                        Apellido = reader["Apellido"].ToString(),
                        Email = reader["Email"].ToString()
                    };
                }

                return null;
            }
        }

        public Usuario IniciarSesion(string nombreUsuario, string contraseña)
        {
            using (SqlConnection conn = conexion.ObtenerConexion())
            {
                SqlCommand cmd = new SqlCommand("SP_IniciarSesion", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@NombreUsuario", nombreUsuario);
                cmd.Parameters.AddWithValue("@Contraseña", HashPassword(contraseña));

                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    return new Usuario
                    {
                        IdUsuario = Convert.ToInt32(reader["Id_Usuario"]),
                        NombreUsuario = reader["Nombre_Usuario"].ToString(),
                        Nombre = reader["Nombre"].ToString(),
                        Apellido = reader["Apellido"].ToString(),
                        Email = reader["Email"].ToString(),
                        RutaFotoPerfil = reader["RutaFotoPerfil"]?.ToString()
                    };
                }
                return null;
            }
        }

        public void RecordarUsuario(int usuarioId, bool recordar)
        {
            using (SqlConnection conn = conexion.ObtenerConexion())
            {
                SqlCommand cmd = new SqlCommand("SP_RecordarUsuario", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@IdUsuario", usuarioId);
                cmd.Parameters.AddWithValue("@Recordar", recordar);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }


        public void GuardarRutaFotoPerfil(int idUsuario, string ruta)
        {
            using (SqlConnection conn = conexion.ObtenerConexion())
            {
                string query = "UPDATE Usuarios SET RutaFotoPerfil = @Ruta WHERE Id_Usuario = @Id";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Ruta", ruta);
                cmd.Parameters.AddWithValue("@Id", idUsuario);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public string EliminarUsuario(int id)
        {
            using (SqlConnection conn = conexion.ObtenerConexion())
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SP_EliminarUsuario", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@IdUsuario", id);

                int filas = cmd.ExecuteNonQuery();
                return filas > 0 ? "Usuario eliminado correctamente" : "No se pudo eliminar el usuario";
            }
        }


        public string EditarUsuario(Usuario usuario)
        {
            try
            {
                using (SqlConnection conn = conexion.ObtenerConexion())
                {
                    SqlCommand cmd = new SqlCommand("SP_EditarUsuario", conn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@IdUsuario", usuario.IdUsuario);
                    cmd.Parameters.AddWithValue("@NombreUsuario", usuario.NombreUsuario);

                    string contraseñaHasheada = HashPassword(usuario.Contraseña);
                    cmd.Parameters.AddWithValue("@Contraseña", contraseñaHasheada);

                    cmd.Parameters.AddWithValue("@Nombre", usuario.Nombre);
                    cmd.Parameters.AddWithValue("@Apellido", usuario.Apellido);
                    cmd.Parameters.AddWithValue("@Email", usuario.Email);
                    cmd.Parameters.AddWithValue("@RutaFotoPerfil", usuario.RutaFotoPerfil ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@Activo", usuario.Activo);
                    cmd.Parameters.AddWithValue("@IdRol", usuario.Rol?.IdRol ?? (object)DBNull.Value);

                    conn.Open();
                    int filasAfectadas = cmd.ExecuteNonQuery();

                    return filasAfectadas > 0
                        ? "Usuario actualizado con éxito."
                        : $"Error: no se actualizó ningún registro. ID: {usuario.IdUsuario}";
                }
            }
            catch (Exception ex)
            {
                return $"Error al editar usuario: {ex.Message}";
            }
        }

        public DataTable BuscarUsuarios(string filtro)
        {
            using (SqlConnection conn = conexion.ObtenerConexion())
            {
                SqlDataAdapter da = new SqlDataAdapter("SP_BuscarUsuarios", conn);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.AddWithValue("@Filtro", filtro);
                DataTable tabla = new DataTable();
                da.Fill(tabla);
                return tabla;
            }
        }

        public DataTable ObtenerUsuarios()
        {
            using (SqlConnection conn = conexion.ObtenerConexion())
            {
                SqlCommand cmd = new SqlCommand("SP_ObtenerUsuarios", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable tabla = new DataTable();
                da.Fill(tabla);
                return tabla;
            }
        }

        public void GuardarUsuario(Usuario usuario)
        {
            using (SqlConnection conn = conexion.ObtenerConexion())
            {
                SqlCommand cmd = new SqlCommand("sp_GuardarUsuario", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@NombreUsuario", usuario.NombreUsuario);
                cmd.Parameters.AddWithValue("@Contraseña", usuario.Contraseña);
                cmd.Parameters.AddWithValue("@Nombre", usuario.Nombre);
                cmd.Parameters.AddWithValue("@Apellido", usuario.Apellido);
                cmd.Parameters.AddWithValue("@Email", usuario.Email);
                cmd.Parameters.AddWithValue("@Activo", usuario.Activo);
                cmd.Parameters.AddWithValue("@RutaFotoPerfil", usuario.RutaFotoPerfil ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@IdRol", usuario.Rol.IdRol);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        private string HashPassword(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = Encoding.UTF8.GetBytes(password);
                byte[] hashBytes = sha256.ComputeHash(bytes);
                StringBuilder sb = new StringBuilder();

                foreach (byte b in hashBytes)
                {
                    sb.Append(b.ToString("x2"));
                }

                return sb.ToString();
            }
        }



        public Usuario ObtenerUsuarioPorId(int idUsuario)
        {
            Usuario usuario = null;

            try
            {
                using (SqlConnection conn = conexion.ObtenerConexion())
                {
                    SqlCommand cmd = new SqlCommand("SP_ObtenerUsuarioPorId", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@IdUsuario", idUsuario);

                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        usuario = new Usuario
                        {
                            IdUsuario = Convert.ToInt32(reader["Id_Usuario"]),
                            NombreUsuario = reader["Nombre_Usuario"].ToString(),
                            Nombre = reader["Nombre"].ToString(),
                            Apellido = reader["Apellido"].ToString(),
                            Email = reader["Email"].ToString(),
                            Activo = Convert.ToBoolean(reader["Activo"]),
                            Recordar = Convert.ToBoolean(reader["Recordar"]),
                            RutaFotoPerfil = reader["RutaFotoPerfil"] != DBNull.Value ?
                                            reader["RutaFotoPerfil"].ToString() : null
                        };
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error en ObtenerUsuarioPorId: " + ex.Message);
            }

            return usuario;
        }
    }
}