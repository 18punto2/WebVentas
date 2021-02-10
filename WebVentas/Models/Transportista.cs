using System;
using System.Collections.Generic;

#nullable disable

namespace WebVentas.Models
{
    public partial class Transportista
    {
        public int IdTransportista { get; set; }
        public string Nombre { get; set; }
        public string Ruc { get; set; }
        public string TipoDocTrans { get; set; }
        public string DesTipoDocTrans { get; set; }
    }
}
