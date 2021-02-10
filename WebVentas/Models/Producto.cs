using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace WebVentas.Models
{
    public partial class Producto
    {
        public Producto()
        {
            Detalles = new HashSet<Detalle>();
        }
        [Display(Name = "Codigo")]
        public string Codcom { get; set; }
        public int IdArt { get; set; }
        [Display(Name = "Descripcion")]
        public string Detalle { get; set; }
        [Display(Name = "Medida")]
        public string Idmedida { get; set; }
        public decimal? Stock { get; set; }
        [Display(Name = "Precio")]
        public decimal? Pmayor { get; set; }
        [Display(Name = "Tipo Mercaderia")]
        public string IdTipMer { get; set; }
        public bool? Activo { get; set; }
        [Display(Name = "Codigo Sunat")]
        public string CodSunat { get; set; }
        public byte[] Image { get; set; }
        [Display(Name = "Familia")]
        public int? IdFamilia { get; set; }
        [Display(Name = "Linea")]
        public int? IdLinea { get; set; }

        public virtual SunatTipoMercaderia IdTipMerNavigation { get; set; }
        public virtual SunatUnidadMedida IdmedidaNavigation { get; set; }
        public virtual ICollection<Detalle> Detalles { get; set; }
    }
}
