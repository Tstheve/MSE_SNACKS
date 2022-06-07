using System;
using System.Collections.Generic;
using System.Text;

namespace pizzeria.core.Domain.Models
{
    internal class Cliente
    {
        public Guid Cliente_id { get; set; }
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public DateTime Usuario_creacion { get; set; }
        public DateTime Fecha_creacion { get; set; }
    }
}
