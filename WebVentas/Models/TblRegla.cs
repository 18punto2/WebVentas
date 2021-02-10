using System;
using System.Collections.Generic;

#nullable disable

namespace WebVentas.Models
{
    public partial class TblRegla
    {
        public TblRegla()
        {
            TransPerfilReglas = new HashSet<TransPerfilRegla>();
        }

        public int Id { get; set; }
        public string Regla { get; set; }
        public string Descripcion { get; set; }

        public virtual ICollection<TransPerfilRegla> TransPerfilReglas { get; set; }
    }
}
