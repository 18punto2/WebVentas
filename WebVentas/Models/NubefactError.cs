using System;
using System.Collections.Generic;

#nullable disable

namespace WebVentas.Models
{
    public partial class NubefactError
    {
        public long NumeroRegistro { get; set; }
        public string Errors { get; set; }
        public int Codigo { get; set; }
    }
}
