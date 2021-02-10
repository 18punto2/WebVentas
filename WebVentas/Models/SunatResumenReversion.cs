using System;
using System.Collections.Generic;

#nullable disable

namespace WebVentas.Models
{
    public partial class SunatResumenReversion
    {
        public int Id { get; set; }
        public string FechaGeneracion { get; set; }
        public string FechaComunicacion { get; set; }
        public string TipoDocBaja { get; set; }
        public string NumeroDocBaja { get; set; }
        public string DescripcionMotivoBaja { get; set; }
    }
}
