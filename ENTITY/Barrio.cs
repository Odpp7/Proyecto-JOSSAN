using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITY
{
    public class Barrio
    {
        public string IdBarrio {  get; set; }
        public string Nombre_barrio { get; set; }
        public Ciudad Ciudad { get; set; }
    }
}
