using System;
using System.Collections.Generic;

#nullable disable

namespace WebVentas.Models
{
    public partial class TipoAfectacionIgv
    {
        public int? Idtipo { get; set; }
        public int Codigo { get; set; }
        public int? CodNubefact { get; set; }
        public string Descripcion { get; set; }
    }
}
