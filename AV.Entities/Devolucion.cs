using System;
using System.Collections.Generic;
using System.Text;

namespace AV.Entities
{
    public class Devolucion
    {
        public int Id { get; set; }
        public DateTime Fecha { get; set; } = DateTime.UtcNow;
        public required string MetodoDevolucion { get; set; } 
    }
}
