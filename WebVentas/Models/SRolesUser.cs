using System;
using System.Collections.Generic;

#nullable disable

namespace WebVentas.Models
{
    public partial class SRolesUser
    {
        public int IdRol { get; set; }
        public int Idusuario { get; set; }

        public virtual SRole IdRolNavigation { get; set; }
        public virtual TblUsuario IdusuarioNavigation { get; set; }
    }
}
