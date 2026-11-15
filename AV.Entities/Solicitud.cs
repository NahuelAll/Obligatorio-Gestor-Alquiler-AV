using AV.Entities.Enumerators;
using System;
using System.Collections.Generic;
using System.Text;

namespace AV.Entities
{
    public class Solicitud
    {
        public int Id { get; set; }
        public DateTime Fecha { get; set; } = DateTime.UtcNow;
        public EstadoSolicitud Estado { get; set; }
    }
}
