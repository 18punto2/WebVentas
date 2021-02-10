using System;
using System.Collections.Generic;

#nullable disable

namespace WebVentas.Models
{
    public partial class Traslado
    {
        public int Id { get; set; }
        public string Codigo { get; set; }
        public string Descripcion { get; set; }
        public bool? Activa { get; set; }
    }
}
