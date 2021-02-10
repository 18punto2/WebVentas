using System;
using System.Collections.Generic;

#nullable disable

namespace WebVentas.Models
{
    public partial class SunatTipoDocumento
    {
        public SunatTipoDocumento()
        {
            Clientes = new HashSet<Cliente>();
        }

        public string Codigo { get; set; }
        public string Descripcion { get; set; }
        public bool? Activado { get; set; }

        public virtual ICollection<Cliente> Clientes { get; set; }
    }
}
