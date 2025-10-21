using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITY
{
    public class Usuario
    {
        public string IdUsuario { get; set; }
        public Rol IdRol { get; set; }
        public string Cedula { get; set; }
        public string NombreUsuario { get; set; }
        public string ApellidoPaterno { get; set; }
        public string ApellidoMaterno { get; set; }
        public string Contraseña { get; set; }
        public string Correo { get; set; }
        public string Telefono { get; set; }
    }
}
