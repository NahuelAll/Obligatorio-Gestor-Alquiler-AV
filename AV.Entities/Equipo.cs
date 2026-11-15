using System;
using System.Collections.Generic;
using System.Text;

namespace AV.Entities
{
    public class Equipo
    {
        public int Id { get; set; }
        public int NumeroSerie { get; set; }
        public required string Nombre { get; set; }
        public required string Modelo { get; set; }
        public required string Marca { get; set; }
        public int Anio { get; set; }
        public required EstadoEquipo Estado { get; set; }
        public required TipoEquipamiento Tipo { get; set; }
    }
}
