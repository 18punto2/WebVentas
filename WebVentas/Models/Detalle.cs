using System;
using System.Collections.Generic;

#nullable disable

namespace WebVentas.Models
{
    public partial class Detalle
    {
        public int Idcab { get; set; }
        public string Codcom { get; set; }
        public decimal Cantidad { get; set; }
        public decimal Precio { get; set; }
        public decimal Total { get; set; }
        public bool? Activo { get; set; }
        public string Usuario { get; set; }
        public decimal? Igv { get; set; }
        public decimal? Descuento { get; set; }

        public virtual Producto CodcomNavigation { get; set; }
        public virtual Cabecera IdcabNavigation { get; set; }
    }
}
