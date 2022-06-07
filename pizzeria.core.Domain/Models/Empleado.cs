using System;
using System.Collections.Generic;
using System.Text;

namespace pizzeria.core.Domain.Models
{
    internal class Empleado
    {
        public Guid Empleado_id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string cedula { get; set; }
        public string Direccion { get; set; }
        public int Telefono { get; set; }
    }
}
