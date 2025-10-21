using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITY
{
    public class Articulo
    {
        public string IdArticulo { get; set; }
        public string NombreArticulo { get; set; }
        public string Descripcion { get; set; }
        public decimal PrecioMayorista { get; set; }
        public decimal PrecioVenta { get; set; }
        public int Stock { get; set; }
        public string ImagenURL { get; set; }
        public decimal DescuentoVigente { get; set; }
        public string Estado { get; set; }
        public ICollection<Categoria> Categorias { get; set; }
    }
}
