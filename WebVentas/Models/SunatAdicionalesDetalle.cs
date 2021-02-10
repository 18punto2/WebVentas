using System;
using System.Collections.Generic;

#nullable disable

namespace WebVentas.Models
{
    public partial class SunatAdicionalesDetalle
    {
        public int Id { get; set; }
        public string LineaItem { get; set; }
        public string NombrePropiedad { get; set; }
        public string CodPropiedad { get; set; }
        public string ValorPropiedad { get; set; }
        public string CodConceptoItem { get; set; }
    }
}
