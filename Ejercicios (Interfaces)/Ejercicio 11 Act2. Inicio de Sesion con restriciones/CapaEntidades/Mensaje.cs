using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Mensaje
    {
        public int IdMensaje { get; set; }
        public string NombreUsuario { get; set; }
        public string Asunto { get; set; }
        public string Contenido { get; set; }
        public DateTime FechaEnvio { get; set; }
        public bool Contestado { get; set; }
        public string Respuesta { get; set; }
        public DateTime? FechaRespuesta { get; set; }
    }
}