using System;
using System.Collections.Generic;

#nullable disable

namespace WebVentas.Models
{
    public partial class Nubefact
    {
        public long NumeroRegistro { get; set; }
        public string TipoDeComprobante { get; set; }
        public string Serie { get; set; }
        public int Numero { get; set; }
        public string Enlace { get; set; }
        public bool AceptadaPorSunat { get; set; }
        public string SunatDescription { get; set; }
        public string SunatNote { get; set; }
        public string SunatResponsecode { get; set; }
        public string SunatSoapError { get; set; }
        public string PdfZipBase64 { get; set; }
        public string XmlZipBase64 { get; set; }
        public string CdrZipBase64 { get; set; }
        public string CadenaParaCodigoQr { get; set; }
        public string CodigoHash { get; set; }
        public string EnlaceDelPdf { get; set; }
        public string EnlaceDelXml { get; set; }
        public string EnlaceDelCdr { get; set; }
    }
}
