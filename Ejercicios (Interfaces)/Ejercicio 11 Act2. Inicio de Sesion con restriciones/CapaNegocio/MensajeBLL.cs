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
        private MensajeDAL mensajeDAL = new MensajeDAL();

        public bool EnviarMensaje(Mensaje mensaje)
        {
            MensajeDAL mensajeDAL = new MensajeDAL();
            return mensajeDAL.EnviarMensaje(mensaje);
        }

        public List<Mensaje> ObtenerMensajesPendientes()
        {
            MensajeDAL mensajeDAL = new MensajeDAL();
            return mensajeDAL.ObtenerMensajesPendientes();
        }
        public List<Mensaje> ObtenerTodosLosMensajes()
        {
            return mensajeDAL.ObtenerTodosLosMensajes();
        }

        public bool ResponderMensaje(Mensaje mensaje)
        {
            MensajeDAL mensajeDAL = new MensajeDAL();
            return mensajeDAL.ResponderMensaje(mensaje);
        }

        public DataTable ObtenerRespuestasPorUsuario(int idUsuario)
        {
            MensajeDAL datos = new MensajeDAL();
            return datos.ObtenerRespuestasPorUsuario(idUsuario);
        }
    }
}