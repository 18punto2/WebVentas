using System;
using System.Collections.Generic;

#nullable disable

namespace WebVentas.Models
{
    public partial class TblUsuario
    {
        public TblUsuario()
        {
            SRolesUsers = new HashSet<SRolesUser>();
        }

        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int? Dni { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public string Usuario { get; set; }
        public string Password { get; set; }
        public string Tipo { get; set; }
        public int? PerfilId { get; set; }
        public int? IdEmpresa { get; set; }

        public virtual TblPerfil Perfil { get; set; }
        public virtual ICollection<SRolesUser> SRolesUsers { get; set; }
    }
}
