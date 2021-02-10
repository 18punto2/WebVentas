using System;
using System.Collections.Generic;

#nullable disable

namespace WebVentas.Models
{
    public partial class Tipocomprobante
    {
        public int Id { get; set; }
        public string Codigo { get; set; }
        public string Descripcion { get; set; }
        public bool Activado { get; set; }
        public string Coddoc { get; set; }
    }
}
