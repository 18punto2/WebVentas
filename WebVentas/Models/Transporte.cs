using System;
using System.Collections.Generic;

#nullable disable

namespace WebVentas.Models
{
    public partial class Transporte
    {
        public int Id { get; set; }
        public string Ruc { get; set; }
        public string Proveedor { get; set; }
        public string Direccion { get; set; }
        public string Direccion2 { get; set; }
        public string Telefono { get; set; }
        public string Correo { get; set; }
        public string Contacto { get; set; }
    }
}
