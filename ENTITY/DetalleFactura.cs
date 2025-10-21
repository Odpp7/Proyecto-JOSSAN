using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITY
{
    public class DetalleFactura
    {
        public string IdDetalle { get; set; }
        public Factura Factura { get; set; }
        public Articulo Articulo { get; set; }
        public decimal PrecioUnitario { get; set; }
        public int Cantidad { get; set; }
        public decimal Descuento { get; set; }
        public decimal Subtotal { get; set; }
    }
}
