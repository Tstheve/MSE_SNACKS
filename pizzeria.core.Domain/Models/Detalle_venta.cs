using System;
using System.Collections.Generic;
using System.Text;

namespace pizzeria.core.Domain.Models
{
    internal class Detalle_venta
    {
        public Guid Venta_id { get; set; }
        public DateTime Fecha { get; set; }
        public Guid Producto_id { get; set; }
        public int Cantidad { get; set; }
        public Double Precio { get; set; }
        public Double Descuento { get; set; }
    }
}
