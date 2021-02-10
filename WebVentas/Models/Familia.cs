using System;
using System.Collections.Generic;

#nullable disable

namespace WebVentas.Models
{
    public partial class Familia
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public double? Activo { get; set; }
    }
}
