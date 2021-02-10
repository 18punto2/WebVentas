using System;
using System.Collections.Generic;

#nullable disable

namespace WebVentas.Models
{
    public partial class TblPerfil
    {
        public TblPerfil()
        {
            TblUsuarios = new HashSet<TblUsuario>();
            TransPerfilReglas = new HashSet<TransPerfilRegla>();
        }

        public int Id { get; set; }
        public string Perfil { get; set; }
        public string Descripcion { get; set; }

        public virtual ICollection<TblUsuario> TblUsuarios { get; set; }
        public virtual ICollection<TransPerfilRegla> TransPerfilReglas { get; set; }
    }
}
