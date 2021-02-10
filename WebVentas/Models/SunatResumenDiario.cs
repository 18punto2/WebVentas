using System;
using System.Collections.Generic;

#nullable disable

namespace WebVentas.Models
{
    public partial class SunatResumenDiario
    {
        public int Id { get; set; }
        public string FechaEmision { get; set; }
        public string FechaResumen { get; set; }
        public string TipoDocResumen { get; set; }
        public string SerieNumeroDocResumen { get; set; }
        public string TipoDocUsuario { get; set; }
        public string NumeroDocUsuario { get; set; }
        public string TipoMoneda { get; set; }
        public string TotalValorGravado { get; set; }
        public string TotalValorExonerado { get; set; }
        public string TotalValorInafecto { get; set; }
        public string TotalValorGratuito { get; set; }
        public string ImporteTotalSumatoria { get; set; }
        public string TotalTribIsc { get; set; }
        public string TotalTribIgv { get; set; }
        public string TotalOtrosTributos { get; set; }
        public string ImporteTotalVenta { get; set; }
        public string TipoDocModifica { get; set; }
        public string NumeroSerieBoletaModifica { get; set; }
        public string NumeroCorrelativoBoleta { get; set; }
        public string RegimenPercepcion { get; set; }
        public string PorcentajePercepcion { get; set; }
        public string BasePercepcion { get; set; }
        public string MontoPercepcion { get; set; }
        public string MontoTotalIncluidaPercepcion { get; set; }
        public string TipoEstado { get; set; }
    }
}
