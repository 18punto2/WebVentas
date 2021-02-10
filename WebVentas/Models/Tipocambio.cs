using System;
using System.Collections.Generic;

#nullable disable

namespace WebVentas.Models
{
    public partial class Tipocambio
    {
        public int Id { get; set; }
        public DateTime? Fecha { get; set; }
        public decimal? Venta { get; set; }
        public decimal? Compra { get; set; }
        public bool? Activado { get; set; }
    }
}
