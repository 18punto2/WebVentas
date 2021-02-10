using System;
using System.Collections.Generic;

#nullable disable

namespace WebVentas.Models
{
    public partial class SunatAdicionalesCabecera
    {
        public int? Id { get; set; }
        public string CuentaBancoNacionDetraccion { get; set; }
        public string CodBienDetraccion { get; set; }
        public string PorcentajeDetraccion { get; set; }
        public string MontoDetraccion { get; set; }
        public string CodPaisCliente { get; set; }
        public string CodUbigeoCliente { get; set; }
        public string DireccionCliente { get; set; }
        public string CodPaisEntrega { get; set; }
        public string CodUbigeoEntrega { get; set; }
        public string DireccionEntrega { get; set; }
    }
}
