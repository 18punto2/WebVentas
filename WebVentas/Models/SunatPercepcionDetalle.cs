using System;
using System.Collections.Generic;

#nullable disable

namespace WebVentas.Models
{
    public partial class SunatPercepcionDetalle
    {
        public int Id { get; set; }
        public string TipoDocRelacionado { get; set; }
        public string NumeroDocRelacionado { get; set; }
        public string FechaEmisionDocRelacionado { get; set; }
        public string TotalDocRelacionado { get; set; }
        public string TipoMonedaDocRelacionado { get; set; }
        public string FechaPago { get; set; }
        public string NumeroPago { get; set; }
        public string ImportePago { get; set; }
        public string TipoMonedaPago { get; set; }
        public string ImportePercibido { get; set; }
        public string MonedaImportePercibido { get; set; }
        public string FechaPercepcion { get; set; }
        public string ImporteTotalPagarNeto { get; set; }
        public string TipoMonedaImporteTotalPagarNeto { get; set; }
        public string TipoMonedaRefTipoCambio { get; set; }
        public string TasaTipoCambio { get; set; }
        public string FactorTipoCambio { get; set; }
        public string FechaTipoCambio { get; set; }
    }
}
