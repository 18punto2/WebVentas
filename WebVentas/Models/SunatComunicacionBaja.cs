using System;
using System.Collections.Generic;

#nullable disable

namespace WebVentas.Models
{
    public partial class SunatComunicacionBaja
    {
        public int Id { get; set; }
        public string FecGeneracion { get; set; }
        public string FecComunicacion { get; set; }
        public string TipDocBaja { get; set; }
        public string NumDocBaja { get; set; }
        public string DesMotivoBaja { get; set; }
    }
}
