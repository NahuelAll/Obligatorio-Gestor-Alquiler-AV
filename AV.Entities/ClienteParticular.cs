using System;
using System.Collections.Generic;
using System.Text;

namespace AV.Entities
{
    public class ClienteParticular : Cliente
    {
        public required string CI { get; set; }
        public required string Nombre { get; set; }
        public required string Apellido { get; set; }
    }
}
