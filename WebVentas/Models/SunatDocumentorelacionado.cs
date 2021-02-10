using System;
using System.Collections.Generic;

#nullable disable

namespace WebVentas.Models
{
    public partial class SunatDocumentorelacionado
    {
        public int Id { get; set; }
        public string Indicador { get; set; }
        public string NumeroIdentificadorAnticipo { get; set; }
        public string Tipo { get; set; }
        public string Numero { get; set; }
        public string TipoDocEmisor { get; set; }
        public string NumeroDocEmisor { get; set; }
        public string Monto { get; set; }
    }
}
