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

        public bool EnviarMensaje(Mensaje mensaje)
        {
            using (SqlConnection conn = conexion.ObtenerConexion())
            {
                SqlCommand cmd = new SqlCommand("SP_EnviarMensaje", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@NombreUsuario", mensaje.NombreUsuario);
                cmd.Parameters.AddWithValue("@Asunto", mensaje.Asunto);
                cmd.Parameters.AddWithValue("@Contenido", mensaje.Contenido);

                conn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public List<Mensaje> ObtenerMensajesPendientes()
        {
            List<Mensaje> mensajes = new List<Mensaje>();
            using (SqlConnection conn = conexion.ObtenerConexion())
            {
                SqlCommand cmd = new SqlCommand("SP_ObtenerMensajesPendientes", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Mensaje mensaje = new Mensaje()
                    {
                        IdMensaje = Convert.ToInt32(reader["IdMensaje"]),
                        NombreUsuario = reader["Nombre_Usuario"].ToString(),
                        Asunto = reader["Asunto"].ToString(),
                        Contenido = reader["Contenido"].ToString(),
                        Respuesta = reader["Respuesta"].ToString(),
                        FechaEnvio = Convert.ToDateTime(reader["FechaEnvio"]),
                        Contestado = Convert.ToBoolean(reader["Contestado"])
                    };
                    mensajes.Add(mensaje);
                }
            }
            return mensajes;
        }

        public List<Mensaje> ObtenerTodosLosMensajes()
        {
            List<Mensaje> lista = new List<Mensaje>();

            using (SqlConnection conn = conexion.ObtenerConexion())
            {
                SqlCommand cmd = new SqlCommand("SP_ObtenerTodosLosMensajes", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                conn.Open();

                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    lista.Add(new Mensaje
                    {
                        IdMensaje = Convert.ToInt32(reader["IdMensaje"]),
                        NombreUsuario = reader["NombreUsuario"].ToString(),
                        Asunto = reader["Asunto"].ToString(),
                        Contenido = reader["Contenido"].ToString(),
                        FechaEnvio = Convert.ToDateTime(reader["FechaEnvio"]),
                        Respuesta = reader["Respuesta"]?.ToString(),
                        FechaRespuesta = reader["FechaRespuesta"] == DBNull.Value ? (DateTime?)null : Convert.ToDateTime(reader["FechaRespuesta"]),
                        Contestado = Convert.ToBoolean(reader["Contestado"])
                    });
                }
            }

            return lista;
        }


        public bool ResponderMensaje(Mensaje mensaje)
        {
            using (SqlConnection conn = conexion.ObtenerConexion())
            {
                SqlCommand cmd = new SqlCommand("SP_ResponderMensaje", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@IdMensaje", mensaje.IdMensaje);
                cmd.Parameters.AddWithValue("@Respuesta", mensaje.Respuesta);
                cmd.Parameters.AddWithValue("@Contestado", mensaje.Contestado);

                conn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public DataTable ObtenerRespuestasPorUsuario(int idUsuario)
        {
            using (SqlConnection conn = conexion.ObtenerConexion())
            {
                SqlCommand cmd = new SqlCommand("SP_ObtenerRespuestasPorUsuario", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@IdUsuario", idUsuario);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }
    }
}