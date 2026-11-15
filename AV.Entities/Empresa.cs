using System;
using System.Collections.Generic;
using System.Text;

namespace AV.Entities
{
    public class Empresa : Cliente
    {
        public int RUT { get; set; }
        public required string RazonSocial { get; set; }
    }
}
