using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Policy;

namespace CapaNegocio
{
    public class MensajeBLL
    {
        private Conexion conexion = new Conexion();
        private MensajeDAL mensajeDAL = new MensajeDAL();

            public bool GuardarMensaje(Mensaje mensaje)
            {
                try
                {
                    if (!mensajeDAL.ValidarUsuarioExistente(mensaje.IdUsuario))
                    {
                        throw new Exception("El usuario no existe en la base de datos");
                    }

                    return mensajeDAL.GuardarMensaje(mensaje);
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al guardar el mensaje: " + ex.Message);
                }
            }


        public bool EnviarMensajePorNombreUsuario(string nombreUsuario, string asunto, string contenido)
            {
                try
                {
                    if (!mensajeDAL.ValidarUsuarioExistentePorNombre(nombreUsuario))
                    {
                        throw new Exception("El nombre de usuario no está registrado");
                    }

                    return mensajeDAL.EnviarMensajePorNombreUsuario(nombreUsuario, asunto, contenido);
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al enviar el mensaje: " + ex.Message);
                }
            }

            public DataTable ObtenerTodosMensajes()
            {
                try
                {
                    return mensajeDAL.ObtenerMensajes();
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al obtener mensajes: " + ex.Message);
                }
            }

            public DataTable ObtenerMensajesUsuario(int idUsuario)
            {
                try
                {
                    return mensajeDAL.ObtenerMensajesUsuario(idUsuario);
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al obtener mensajes del usuario: " + ex.Message);
                }
            }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
           
        }



        public bool ValidarUsuarioExistentePorNombre(string nombreUsuario)
            {
                try
                {
                    return mensajeDAL.ValidarUsuarioExistentePorNombre(nombreUsuario);
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al validar usuario: " + ex.Message);
                }
            }

        public bool ResponderMensaje(int idMensaje, string respuesta)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(respuesta))
                {
                    throw new Exception("La respuesta no puede estar vacía");
                }

                return mensajeDAL.ResponderMensaje(idMensaje, respuesta);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al responder el mensaje: " + ex.Message);
            }
        }
    }
}