using System;
using System.Collections.Generic;

#nullable disable

namespace WebVentas.Models
{
    public partial class TransPerfilRegla
    {
        public int PerfilId { get; set; }
        public int ReglaId { get; set; }

        public virtual TblPerfil Perfil { get; set; }
        public virtual TblRegla Regla { get; set; }
    }
}
