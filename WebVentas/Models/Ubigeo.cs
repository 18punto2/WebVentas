using System;
using System.Collections.Generic;

#nullable disable

namespace WebVentas.Models
{
    public partial class Ubigeo
    {
        public int Id { get; set; }
        public int IdCli { get; set; }
        public string Departamento { get; set; }
        public string Provincia { get; set; }
        public string Distrito { get; set; }
        public string Direccion { get; set; }
        public bool? Predeterminado { get; set; }
        public string Urbanizacion { get; set; }

        public virtual Cliente IdCliNavigation { get; set; }
    }
}
