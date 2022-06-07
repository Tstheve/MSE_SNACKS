using System;
using System.Collections.Generic;
using System.Text;

namespace pizzeria.core.Domain.Models
{
    internal class Ventas
    {
        public Guid Venta_id { get; set; }
        public DateTime Fecha { get; set; }
        public Guid id_Cliente { get; set; }
        public string Vendedor { get; set; }
       

    }
}
