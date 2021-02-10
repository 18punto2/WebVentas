using System;
using System.Collections.Generic;

#nullable disable

namespace WebVentas.Models
{
    public partial class SMenu
    {
        public int Id { get; set; }
        public string Menuid { get; set; }
        public string Menuname { get; set; }
        public string Menuparent { get; set; }
        public bool? Enable { get; set; }
        public string Role { get; set; }
    }
}
