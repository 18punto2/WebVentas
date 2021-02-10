using System;
using System.Collections.Generic;

#nullable disable

namespace WebVentas.Models
{
    public partial class Moneda
    {
        public Moneda()
        {
            Cabeceras = new HashSet<Cabecera>();
        }

        public string Codigo { get; set; }
        public string Descripción { get; set; }

        public virtual ICollection<Cabecera> Cabeceras { get; set; }
    }
}
