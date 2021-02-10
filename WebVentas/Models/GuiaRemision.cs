using System;
using System.Collections.Generic;

#nullable disable

namespace WebVentas.Models
{
    public partial class GuiaRemision
    {
        public int Id { get; set; }
        public string NumeroGuiaRemision { get; set; }
        public string NumeroSalida { get; set; }
        public DateTime? FechaEmision { get; set; }
        public DateTime? FechaInicio { get; set; }
        public int? IdCliente { get; set; }
        public string Partida { get; set; }
        public string Llegada { get; set; }
        public string Placa { get; set; }
        public string Brevete { get; set; }
        public int? IdTransportista { get; set; }
        public string LicenciaConducir { get; set; }
        public string Comentario1 { get; set; }
        public string Comentario2 { get; set; }
        public string Despachador { get; set; }
        public string GuiaPorte { get; set; }
        public string Telefono { get; set; }
        public string NumDocRelacionado { get; set; }
        public string UsuarioCreacion { get; set; }
        public DateTime? FechaCreacion { get; set; }
        public string UsuarioModificacion { get; set; }
        public DateTime? FechaModificacion { get; set; }
        public bool? Activo { get; set; }
        public string TipoDocRelacionado { get; set; }
        public string Observaciones { get; set; }
        public string NumGuiaRemisionBaja { get; set; }
        public string TipoDocGuiaRemBaja { get; set; }
        public string NumDocRemite { get; set; }
        public string TipoDocRemite { get; set; }
        public string RazonSocialRemite { get; set; }
        public string NumDocDestinatario { get; set; }
        public string TipoDocDestinatario { get; set; }
        public string RazonSocialDestinatario { get; set; }
        public string NumDocProveedor { get; set; }
        public string TipoDocProveedor { get; set; }
        public string RazonSocialProveedor { get; set; }
        public string MotivoTraslado { get; set; }
        public string DescMotivo { get; set; }
        public string IndicaMotivoTraslado { get; set; }
        public decimal? Peso { get; set; }
        public string UniMedPesoBruto { get; set; }
        public decimal? NumBultosPallets { get; set; }
        public string MovilTraslado { get; set; }
        public DateTime? FechaInicioTraslado { get; set; }
        public string NumRucTransportista { get; set; }
        public string TipoDocTransportista { get; set; }
        public string RazonSocialTransportista { get; set; }
        public string TipoDocConductor { get; set; }
        public string NumDocConductor { get; set; }
        public string UbigeoPuntoLlegada { get; set; }
        public string NumContenedor { get; set; }
        public string UbigeoPuntoPartida { get; set; }
        public string CodPuertoEmbDes { get; set; }
        public string RazonSocialConductor { get; set; }
        public int? Idcomprobante { get; set; }
        public string Serie { get; set; }
        public string TipoTransporte { get; set; }
    }
}
