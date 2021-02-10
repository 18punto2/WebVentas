using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebVentas.Models
{
    public class PedidosFecha
    {
        [Key]
        [Display(Name = "Codigo")]
        public int IdCabecera { get; set; }
        [Display(Name = "Fecha Emision")]
        [DisplayFormat(DataFormatString ="{0:d}")]
        public DateTime FechaEmision { get; set; }
        [Display(Name = "Fecha Vencimiento")]
        [DisplayFormat(DataFormatString = "{0:d}")]
        public DateTime FechaVencimiento { get; set; }
        public decimal Total { get; set; }
        public string Cliente { get; set; }
        public string Vendedor { get; set; }
    }
}
