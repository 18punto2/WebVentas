using System;
using System.Collections.Generic;

#nullable disable

namespace WebVentas.Models
{
    public partial class SunatPercepcionCabecera
    {
        public int Id { get; set; }
        public string FechaEmision { get; set; }
        public string NumeroDocIdentidadReceptor { get; set; }
        public string TipoDocIdentidadReceptor { get; set; }
        public string NombreComercialReceptor { get; set; }
        public string UbigeoReceptor { get; set; }
        public string DireccionReceptor { get; set; }
        public string UrbanizacionReceptor { get; set; }
        public string DepartamentoReceptor { get; set; }
        public string ProvinciaReceptor { get; set; }
        public string DistritoReceptor { get; set; }
        public string CodPaisReceptor { get; set; }
        public string RazonSocialReceptor { get; set; }
        public string RegimenPercepcion { get; set; }
        public string TasaPercepcion { get; set; }
        public string Observaciones { get; set; }
        public string TotalPercepcion { get; set; }
        public string CodMonedaPercepcion { get; set; }
        public string TotalPagadoPercepcion { get; set; }
        public string TipoMonedaTotalPagadoPercepcion { get; set; }
    }
}
