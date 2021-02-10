using System;
using System.Collections.Generic;

#nullable disable

namespace WebVentas.Models
{
    public partial class TotalValorizado
    {
        public int Id { get; set; }
        public DateTime? Fecha { get; set; }
        public string Almacen { get; set; }
        public decimal? TotalCosto { get; set; }
        public decimal? TotalVenta { get; set; }
    }
}
