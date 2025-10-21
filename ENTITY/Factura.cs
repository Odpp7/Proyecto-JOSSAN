using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITY
{
    public class Factura
    {
        public string IdFactura { get; set; }
        public string NumeroFactura { get; set; }
        public Persona Persona { get; set; }
        public Usuario Usuario { get; set; }
        public MetodoPago MetodoPago { get; set; }
        public DateTime FechaEmision { get; set; }
        public decimal Subtotal { get; set; }
        public decimal IVA { get; set; }
        public decimal DescuentoTotal { get; set; }
        public decimal Total { get; set; }
        public string EstadoFactura { get; set; }
        public string EstadoDian { get; set; }
    }
}
