using System;
using System.Collections.Generic;

#nullable disable

namespace WebVentas.Models
{
    public partial class Parametro
    {
        public int Id { get; set; }
        public string Categoria { get; set; }
        public string Nombre { get; set; }
        public string Valor { get; set; }
        public string Descripcion { get; set; }
    }
}
