﻿using System;
using System.Collections.Generic;

#nullable disable

namespace WebVentas.Models
{
    public partial class SunatUnidadMedida
    {
        public SunatUnidadMedida()
        {
            Productos = new HashSet<Producto>();
        }

        public string Codigo { get; set; }
        public string Descripcion { get; set; }
        public bool Activado { get; set; }

        public virtual ICollection<Producto> Productos { get; set; }
    }
}
