using AV.Entities.Enumerators;
using System;
using System.Collections.Generic;
using System.Text;

namespace AV.Entities
{
    public class Evento
    {
        public int Id { get; set; }
        public required string Nombre { get; set; }
        public TipoEvento TipoEvento { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
        public required string Direccion { get; set; }
        public TimeSpan HoraInicio { get; set; }
        public TimeSpan HoraFin { get; set; }
        public int CantidadAsistentes { get; set; }
    }
}
