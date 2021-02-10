using System;
using System.Collections.Generic;

#nullable disable

namespace WebVentas.Models
{
    public partial class SunatTipoComprobante
    {
        public SunatTipoComprobante()
        {
            Cabeceras = new HashSet<Cabecera>();
        }

        public int Codigo { get; set; }
        public string Descripcion { get; set; }
        public bool? Activado { get; set; }

        public virtual ICollection<Cabecera> Cabeceras { get; set; }
    }
}
