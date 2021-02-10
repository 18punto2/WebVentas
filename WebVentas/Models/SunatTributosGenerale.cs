using System;
using System.Collections.Generic;

#nullable disable

namespace WebVentas.Models
{
    public partial class SunatTributosGenerale
    {
        public int Id { get; set; }
        public string IdentificadorTributo { get; set; }
        public string NombreTributo { get; set; }
        public string CodTipoTributo { get; set; }
        public string CodCategoriaTributo { get; set; }
        public string MontoBaseImponible { get; set; }
        public string MontoTributo { get; set; }
    }
}
