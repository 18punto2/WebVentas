using System;
using System.Collections.Generic;

#nullable disable

namespace WebVentas.Models
{
    public partial class Proveedore
    {
        public int IdProv { get; set; }
        public string Ruc { get; set; }
        public string Proveedor { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public string Fax { get; set; }
        public string Mail { get; set; }
        public string Giro { get; set; }
        public string Contacto { get; set; }
        public string Cta { get; set; }
        public DateTime? Fecha { get; set; }
    }
}
