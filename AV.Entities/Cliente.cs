using System;
using System.Collections.Generic;
using System.Text;

namespace AV.Entities
{
    public class Cliente
    {
        public int Id { get; set; }
        public required string Email { get; set; }
        public required string Telefono { get; set; }
    }
}
