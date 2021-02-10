using System;
using System.Collections.Generic;

#nullable disable

namespace WebVentas.Models
{
    public partial class Ubigeo1
    {
        public int Id { get; set; }
        public string CodigoUbigeo { get; set; }
        public string CodigoDepartamento { get; set; }
        public string CodigoProvincia { get; set; }
        public string CodigoDistrito { get; set; }
        public string Nombre { get; set; }
    }
}
