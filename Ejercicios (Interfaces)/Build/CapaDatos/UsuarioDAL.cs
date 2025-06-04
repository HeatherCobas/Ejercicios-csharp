using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidad;
using System.Security.Cryptography;

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
            using (SqlConnection conn = conexion.ObtenerConexion())
            {
                SqlCommand cmd = new SqlCommand("SP_RegistrarUsuario", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@NombreUsuario", usuario.NombreUsuario);
                cmd.Parameters.AddWithValue("@Contraseña", usuario.Contraseña);
                cmd.Parameters.AddWithValue("@Nombre", usuario.Nombre);
                cmd.Parameters.AddWithValue("@Apellido", usuario.Apellido);
                cmd.Parameters.AddWithValue("@Email", usuario.Email);

                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    int resultado = Convert.ToInt32(reader["Resultado"]);
                    string mensaje = reader["Mensaje"].ToString();
                    return (resultado == 1, mensaje);
                }

                return (false, "No se pudo registrar el usuario");
            }
        }

        public (bool success, string message) RegistrarUsuario(string usuario, string contraseña, string nombre, string apellido, string email)
        {

            if (string.IsNullOrWhiteSpace(usuario) || string.IsNullOrWhiteSpace(contraseña) ||
                string.IsNullOrWhiteSpace(nombre) || string.IsNullOrWhiteSpace(apellido) ||
                string.IsNullOrWhiteSpace(email))
            {
                return (false, "Todos los campos son obligatorios");
            }

            if (!IsValidEmail(email))
            {
                return (false, "El formato del email no es válido");
            }

            try
            {
                using (SqlConnection conn = conexion.ObtenerConexion())
                {
                    using (SqlCommand cmd = new SqlCommand("SP_RegistrarUsuario", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.CommandTimeout = 30;

                        cmd.Parameters.Add("@Nombre_Usuario", SqlDbType.VarChar, 50).Value = usuario.Trim();
                        cmd.Parameters.Add("@Contraseña", SqlDbType.VarChar, 255).Value = HashPassword(contraseña);
                        cmd.Parameters.Add("@Nombre", SqlDbType.VarChar, 100).Value = nombre.Trim();
                        cmd.Parameters.Add("@Apellido", SqlDbType.VarChar, 100).Value = apellido.Trim();
                        cmd.Parameters.Add("@Email", SqlDbType.VarChar, 150).Value = email.Trim().ToLower();

                        conn.Open();

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                int resultado = reader.GetInt32(reader.GetOrdinal("Resultado"));
                                string mensaje = reader.GetString(reader.GetOrdinal("Mensaje"));
                                return (resultado == 1, mensaje);
                            }
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

            return (false, "No se pudo completar el registro");
        }

        private bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
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
                SqlCommand cmd = new SqlCommand("sp_IniciarSesion", conn);
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

        public string EditarUsuario(Usuario user)
        {
            using (SqlConnection conn = conexion.ObtenerConexion())
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SP_EditarUsuario", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@IdUsuario", user.IdUsuario);
                cmd.Parameters.AddWithValue("@NombreUsuario", user.NombreUsuario);
                cmd.Parameters.AddWithValue("@Contraseña", user.Contraseña);
                cmd.Parameters.AddWithValue("@Nombre", user.Nombre);
                cmd.Parameters.AddWithValue("@Apellido", user.Apellido);
                cmd.Parameters.AddWithValue("@Email", user.Email);
                cmd.Parameters.AddWithValue("@RutaFotoPerfil", user.RutaFotoPerfil);
                cmd.Parameters.AddWithValue("@Activo", user.Activo);

                int filas = cmd.ExecuteNonQuery();
                return filas > 0 ? "Usuario actualizado correctamente" : "No se pudo actualizar el usuario";
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

        private string HashPassword(string password)
        {
            using (SHA256 sha256Hash = SHA256.Create())
            {
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(password));
                StringBuilder builder = new StringBuilder();
                foreach (byte b in bytes)
                {
                    builder.Append(b.ToString("x2"));
                }
                return builder.ToString();
            }
        }



        public void GuardarUsuario(Usuario usuario)
        {
            using (SqlConnection conn = conexion.ObtenerConexion())
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand
                {
                    Connection = conn,
                    CommandType = CommandType.StoredProcedure
                };

                if (usuario.IdUsuario != null) //El resultado de la expresión siempre es 'true' porque un valor del tipo 'int' nunca es igual a 'NULL' de tipo 'int?'
                {
                    cmd.CommandText = "SP_ActualizarUsuario";
                    cmd.Parameters.AddWithValue("@Id_Usuario", usuario.IdUsuario);
                }
                else
                {
                    cmd.CommandText = "SP_InsertarUsuario";
                }

                cmd.Parameters.AddWithValue("@Nombre_Usuario", usuario.NombreUsuario);
                cmd.Parameters.AddWithValue("@Contraseña", usuario.Contraseña);
                cmd.Parameters.AddWithValue("@Nombre", usuario.Nombre);
                cmd.Parameters.AddWithValue("@Apellido", usuario.Apellido);
                cmd.Parameters.AddWithValue("@Email", usuario.Email);
                cmd.Parameters.AddWithValue("@Activo", usuario.Activo);
                cmd.Parameters.AddWithValue("@RutaFotoPerfil", usuario.RutaFotoPerfil);

                cmd.ExecuteNonQuery();
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