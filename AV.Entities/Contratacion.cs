using AV.Entities.Enumerators;
using System;
using System.Collections.Generic;
using System.Text;

namespace AV.Entities
{
    public class Contratacion
    {
        public int Id { get; set; }
        public DateTime Fecha { get; set; } = DateTime.UtcNow;
        public EstadoContratacion Estado { get; set; }
    }
}
