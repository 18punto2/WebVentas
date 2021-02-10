using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebVentas.Models;

namespace WebVentas.ViewModels
{
    public class IndexViewModel:BaseModelo
    {
        public List<Producto> PaginaProductos { get; set; }
        public List<PedidosFecha> PaginaPedidos { get; set; }
        public string NombreProducto { get; set; }
        //Crear una propiedad para paginar los registros del procedimiento almacenado

        private DateTime fechainicio;
        public DateTime Fechainicio
        {
            get
            {
                if (fechainicio == DateTime.MinValue)
                    return DateTime.Now.Date;
                else
                    return this.fechainicio;
            }
            set
            {
                fechainicio = value;
            }
        }
        private DateTime fechafin;
        public DateTime Fechafin
        {
            get
            {
                if (fechafin == DateTime.MinValue)
                    return DateTime.Now.Date;
                else
                    return this.fechafin;
            }
            set
            {
                fechafin = value;
            }
        }
        public int IdCliente { get; set; }
    }
}
