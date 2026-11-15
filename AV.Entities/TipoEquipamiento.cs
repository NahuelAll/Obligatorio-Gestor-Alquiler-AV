using System;
using System.Collections.Generic;
using System.Text;

namespace AV.Entities
{
    public class TipoEquipamiento
    {
        public int Id { get; set; }
        public required string Nombre { get; set; }
        public required string Categoria { get; set; }
    }
}
