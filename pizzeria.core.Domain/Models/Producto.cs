using System;
using System.Collections.Generic;
using System.Text;

namespace pizzeria.core.Domain.Models
{
    internal class Producto
    {
        public Guid Producto_id { get; set; }
        public string Descripcion { get; set; }
        public float Precio { get; set; }
        public int Existencia { get; set; }
        public string Usuario_creacion { get; set; }
        public DateTime Fecha_creacion { get; set; }
    }
}
