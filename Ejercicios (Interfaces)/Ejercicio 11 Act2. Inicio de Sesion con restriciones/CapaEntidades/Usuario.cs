using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Usuario
    {
        public int IdUsuario { get; set; }
        public string NombreUsuario { get; set; }
        public string Contraseña { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Email { get; set; }
        public bool Activo { get; set; }
        public bool Recordar { get; set; }
        public string RutaFotoPerfil { get; set; }
        public Rol Rol { get; set; }
    }

    public class Rol
    {
        public int IdRol { get; set; }
        public string NombreRol { get; set; }
    }
}