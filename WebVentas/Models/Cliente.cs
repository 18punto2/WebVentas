using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace WebVentas.Models
{
    public partial class Cliente
    {
        public Cliente()
        {
            Cabeceras = new HashSet<Cabecera>();
            Ubigeos = new HashSet<Ubigeo>();
        }

        public int Id { get; set; }
        [Display(Name = "Nombre")]
        public string NombApe { get; set; }
        [Display(Name = "Nombre Comercial")]
        public string NombCom { get; set; }
        public string IdTipoDoc { get; set; }
        [Display(Name = "Numero Documento")]
        public string NumDoc { get; set; }
        public string Direccion { get; set; }
        [Display(Name = "Ubigeo")]
        public string UbigeoDireccion { get; set; }
        public string Email { get; set; }

        public virtual Tipodocumento IdTipoDoc1 { get; set; }
        public virtual SunatTipoDocumento IdTipoDocNavigation { get; set; }
        public virtual ICollection<Cabecera> Cabeceras { get; set; }
        public virtual ICollection<Ubigeo> Ubigeos { get; set; }
    }
}
