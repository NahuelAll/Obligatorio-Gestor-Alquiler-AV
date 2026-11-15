using AV.Entities.Enumerators;
using System;
using System.Collections.Generic;
using System.Text;

namespace AV.Entities
{
    public class Pago
    {
        public int Id { get; set; }
        public DateTime Fecha { get; set; } = DateTime.UtcNow;
        public decimal Monto { get; set; }
        public MedioPago MedioPago { get; set; }
    }
}
