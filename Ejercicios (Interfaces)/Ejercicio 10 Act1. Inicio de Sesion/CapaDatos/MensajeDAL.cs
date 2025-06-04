using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class MensajeDAL
    {
        private Conexion conexion = new Conexion();

        // Agregar estos nuevos métodos a tu clase MensajeDAL

        public bool EnviarMensajePorNombreUsuario(string nombreUsuario, string asunto, string contenido)
        {
            try
            {
                using (SqlConnection conn = conexion.ObtenerConexion())
                {
                    SqlCommand cmd = new SqlCommand("SP_EnviarMensajePorNombreUsuario", conn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@NombreUsuario", nombreUsuario);
                    cmd.Parameters.AddWithValue("@Asunto", asunto ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@Contenido", contenido ?? (object)DBNull.Value);

                    conn.Open();
                    int filasAfectadas = cmd.ExecuteNonQuery();
                    return (filasAfectadas > 0);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error en EnviarMensajePorNombreUsuario: " + ex.Message);
                throw;
            }
        }

        public DataTable ObtenerMensajesUsuario(int idUsuario)
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection conn = conexion.ObtenerConexion())
                {
                    SqlCommand cmd = new SqlCommand("SP_ObtenerMensajesUsuario", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@IdUsuario", idUsuario);

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    adapter.Fill(dt);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error en ObtenerMensajesUsuario: " + ex.Message);
                throw;
            }
            return dt;
        }

        public bool ValidarUsuarioExistente(int idUsuario)
        {
            bool existe = false;
            try
            {
                using (SqlConnection conn = conexion.ObtenerConexion())
                {
                    string query = "SELECT COUNT(*) FROM Usuarios WHERE Id_Usuario = @IdUsuario";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@IdUsuario", idUsuario);

                    conn.Open();
                    int count = Convert.ToInt32(cmd.ExecuteScalar());
                    existe = (count > 0);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error en ValidarUsuarioExistente: " + ex.Message);
                throw;
            }
            return existe;
        }

        public bool GuardarMensaje(Mensaje mensaje)
        {
            try
            {
                if (!ValidarUsuarioExistente(mensaje.IdUsuario))
                {
                    throw new Exception($"El usuario con ID {mensaje.IdUsuario} no existe en la base de datos.");
                }

                using (SqlConnection conn = conexion.ObtenerConexion())
                {
                    SqlCommand cmd = new SqlCommand("SP_EnviarMensaje", conn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@IdUsuario", mensaje.IdUsuario);
                    cmd.Parameters.AddWithValue("@Asunto", mensaje.Asunto ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@Contenido", mensaje.Contenido ?? (object)DBNull.Value);

                    conn.Open();
                    int filasAfectadas = cmd.ExecuteNonQuery();
                    return (filasAfectadas > 0);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error en GuardarMensaje: " + ex.Message);
                throw;
            }
        }

        public DataTable ObtenerMensajes()
        {
            DataTable dt = new DataTable();

            try
            {
                using (SqlConnection conn = conexion.ObtenerConexion())
                {
                    SqlCommand command = new SqlCommand("SP_ObtenerTodosMensajes", conn);
                    command.CommandType = CommandType.StoredProcedure;

                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    adapter.Fill(dt);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error en ObtenerMensajes: " + ex.Message);
                throw;
            }

            return dt;
        }

        public bool ValidarUsuarioExistentePorNombre(string nombreUsuario)
        {
            bool existe = false;

            try
            {
                using (SqlConnection conn = conexion.ObtenerConexion())
                {
                    string query = "SELECT COUNT(*) FROM Usuarios WHERE Nombre_Usuario = @NombreUsuario";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@NombreUsuario", nombreUsuario);

                    conn.Open();
                    int count = Convert.ToInt32(cmd.ExecuteScalar());
                    conn.Close();

                    existe = (count > 0);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error en ValidarUsuarioExistentePorNombre: " + ex.Message);
                throw;
            }

            return existe;
        }

        public int ObtenerIdUsuarioPorNombre(string nombreUsuario)
        {
            try
            {
                using (SqlConnection conn = conexion.ObtenerConexion())
                using (SqlCommand cmd = new SqlCommand("SP_ObtenerIdUsuarioPorNombre", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;


                    cmd.Parameters.Add("@NombreUsuario", SqlDbType.VarChar, 50).Value = nombreUsuario;

                    conn.Open();
                    object result = cmd.ExecuteScalar();

                    return result != null ? Convert.ToInt32(result) : -1;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error en DAL al obtener ID: {ex.Message}");
                throw;
            }
        }

        public DataTable ObtenerMensajes(bool soloNoRespondidos = false)
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection conn = conexion.ObtenerConexion())
                {
                    string procedureName = soloNoRespondidos ?
                        "SP_ObtenerMensajesNoRespondidos" :
                        "SP_ObtenerTodosMensajes";

                    SqlCommand cmd = new SqlCommand(procedureName, conn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    adapter.Fill(dt);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error en ObtenerMensajes: " + ex.Message);
                throw;
            }
            return dt;
        }

        public bool ResponderMensaje(int idMensaje, string respuesta)
        {
            try
            {
                using (SqlConnection conn = conexion.ObtenerConexion())
                {
                    SqlCommand cmd = new SqlCommand("SP_ResponderMensaje", conn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@IdMensaje", idMensaje);
                    cmd.Parameters.AddWithValue("@Respuesta", respuesta);

                    conn.Open();
                    int filasAfectadas = cmd.ExecuteNonQuery();
                    return (filasAfectadas > 0);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error en ResponderMensaje: " + ex.Message);
                throw;
            }
        }
    }
}