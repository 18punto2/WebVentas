using System;
using System.Collections.Generic;

#nullable disable

namespace WebVentas.Models
{
    public partial class SunatRetencionCabecera
    {
        public int Id { get; set; }
        public string FechaEmision { get; set; }
        public string NumeroDocIdeReceptor { get; set; }
        public string TipoDocIdeReceptor { get; set; }
        public string NombreComReceptor { get; set; }
        public string UbigeoReceptor { get; set; }
        public string DireccionReceptor { get; set; }
        public string UrbanizacionReceptor { get; set; }
        public string DepartamentoReceptor { get; set; }
        public string ProvinciaReceptor { get; set; }
        public string DistritoReceptor { get; set; }
        public string CodPaisReceptor { get; set; }
        public string RazonSocialReceptor { get; set; }
        public string CodRegimenRetencion { get; set; }
        public string TasaRetencion { get; set; }
        public string ObservacionesRetencion { get; set; }
        public string ImporteTotalRetencion { get; set; }
        public string MonedaImporteTotalRetencion { get; set; }
        public string ImporteTotalPagadoRetencion { get; set; }
        public string MonedaImporteTotalPagadoRetencion { get; set; }
    }
}
