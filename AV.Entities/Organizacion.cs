using System;
using System.Collections.Generic;
using System.Text;

namespace AV.Entities
{
    public class Organizacion
    {
        public required string RUT { get; set; }
        public required string NombreOrganizacion { get; set; }
        public required string Proposito { get; set; }
    }
}
