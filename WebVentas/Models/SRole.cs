using System;
using System.Collections.Generic;

#nullable disable

namespace WebVentas.Models
{
    public partial class SRole
    {
        public SRole()
        {
            SRolesUsers = new HashSet<SRolesUser>();
        }

        public int Id { get; set; }
        public string Rol { get; set; }

        public virtual ICollection<SRolesUser> SRolesUsers { get; set; }
    }
}
