using System;
using System.Collections.Generic;
using System.Text;

namespace pizzeria.core.Domain.Models
{
    internal class Usuario_Accion
    {
        public Guid Usuario_id { get; set; }
        public string Codigo_accion { get; set; }
        public string Usuario_creacion { get; set; }
        public DateTime Fecha_creacion { get; set; }

    }
}
