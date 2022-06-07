using System;
using System.Collections.Generic;
using System.Text;

namespace pizzeria.core.Domain.Models
{
    internal class Usuario_grupo
    {
        public string Codigo_grupo { get; set; }
        public Guid Usuario_id { get; set; }
        public string Usuario_creacion { get; set; }
        public DateTime Fecha_creacion { get; set; }

    }
}
