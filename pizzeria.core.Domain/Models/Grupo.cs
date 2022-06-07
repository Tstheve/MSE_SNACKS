using System;
using System.Collections.Generic;
using System.Text;

namespace pizzeria.core.Domain.Models
{
    internal class Grupo
    {
        public string Codigo_grupo { get; set; }
        public string Descripcion { get; set; }
        public string Usuario_creacion { get; set; }
        public DateTime Fecha_creacion { get; set; }

    }
}
