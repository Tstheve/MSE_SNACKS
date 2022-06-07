using System;
using System.Collections.Generic;
using System.Text;

namespace pizzeria.core.Domain.Models
{
    internal class usuario
    {
        public Guid usuario_id { get; set; }
        public string Nombre { get; set; }
        public Guid id_Empleado { get; set; }
        public string usuario_creacion { get; set; }
        public DateTime fecha_creacion { get; set; }

    }
}
