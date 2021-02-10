using System;
using System.Collections.Generic;

#nullable disable

namespace WebVentas.Models
{
    public partial class SunatRetencionDetalle
    {
        public int Id { get; set; }
        public string TipoDocRelacionado { get; set; }
        public string NumeroDocRelacionado { get; set; }
        public string FechaEmiDocRelacionado { get; set; }
        public string ImporteTotalDocRelacionado { get; set; }
        public string TipoMonedaDocRelacionado { get; set; }
        public string FechaPago { get; set; }
        public string NumeroPago { get; set; }
        public string ImportePago { get; set; }
        public string TipoMonedaPago { get; set; }
        public string ImporteRetenido { get; set; }
        public string MonedaImporteRetenido { get; set; }
        public string FechaRetencion { get; set; }
        public string TotalPagarNeto { get; set; }
        public string MonedaTotalPagarNeto { get; set; }
        public string TipoMonedaRefTipoCambio { get; set; }
        public string TasaTipoCambio { get; set; }
        public string FactorTipoCambio { get; set; }
        public string FechaTipoCambio { get; set; }
    }
}
