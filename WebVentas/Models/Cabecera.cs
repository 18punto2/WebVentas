using System;
using System.Collections.Generic;

#nullable disable

namespace WebVentas.Models
{
    public partial class Cabecera
    {
        public Cabecera()
        {
            Detalles = new HashSet<Detalle>();
        }

        public int Idcabecera { get; set; }
        public string Idmoneda { get; set; }
        public string Observaciones { get; set; }
        public int? Idtipocomp { get; set; }
        public string Serie { get; set; }
        public string Numero { get; set; }
        public bool? Incligv { get; set; }
        public decimal? Dscto { get; set; }
        public decimal? Igv { get; set; }
        public decimal? Total { get; set; }
        public DateTime? Fechaemision { get; set; }
        public string Numdoc { get; set; }
        public string Usuario { get; set; }
        public DateTime? Fechavencimiento { get; set; }
        public bool? Chser { get; set; }
        public decimal? TCompra { get; set; }
        public bool? Activo { get; set; }
        public decimal? Porcigv { get; set; }
        public int? Idcliente { get; set; }
        public string Guiaremision { get; set; }
        public decimal? TotSubtotal { get; set; }
        public decimal? TotDsctos { get; set; }
        public decimal? TotTotal { get; set; }
        public decimal? TotIgv { get; set; }
        public decimal? TotIcbper { get; set; }
        public decimal? TotOtros { get; set; }
        public decimal? TotNeto { get; set; }
        public decimal? TotIsc { get; set; }
        public string IdTipoNotaCredito { get; set; }
        public string Motivo { get; set; }
        public string TipoDocRef { get; set; }
        public string NumDocRef { get; set; }
        public DateTime? FechaEmiRef { get; set; }
        public string SerieDocRef { get; set; }
        public string IdTipoNotaDebito { get; set; }

        public virtual Cliente IdclienteNavigation { get; set; }
        public virtual Moneda IdmonedaNavigation { get; set; }
        public virtual SunatTipoComprobante IdtipocompNavigation { get; set; }
        public virtual ICollection<Detalle> Detalles { get; set; }
    }
}
