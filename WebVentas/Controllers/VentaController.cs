using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using WebVentas.Models;
using WebVentas.ViewModels;
using WebVentas.Data;

namespace WebVentas.Controllers
{
    public class VentaController : Controller
    {
        VENTASContext db = new VENTASContext();
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public async Task<IActionResult> ListaPedidosFecha(DateTime fechaInicio
            , DateTime fechaFin, int idCliente, int pagina=1)
        {
            using(ClienteDAO p=new ClienteDAO())
            {
                ViewBag.IdCliente = p.Listar();
            }

            var registrosPorPagina = 5;
            var pedidos = db.ListaPedidosFechaAsync(fechaInicio, fechaFin, idCliente).Result
                .Skip((pagina - 1) * registrosPorPagina)
                .Take(registrosPorPagina).ToList();
            var totalRegistros = pedidos.Count();
            //configurar la paginacion
            var modelo = new IndexViewModel();
            modelo.PaginaPedidos = pedidos;

            modelo.PaginaActual = pagina;
            modelo.RegistrosPorPagina = registrosPorPagina;
            //guardar los parametros para cuando cambie de pagina
            modelo.ValoresQueryString = new RouteValueDictionary();

            modelo.ValoresQueryString["fechaInicio"] = fechaInicio;
            modelo.ValoresQueryString["fechaFin"] = fechaFin;
            modelo.ValoresQueryString["idCliente"] = idCliente;
            //conservar los valores ingresados en los controles
            modelo.Fechainicio = fechaInicio;
            modelo.Fechafin = fechaFin;
            modelo.IdCliente = idCliente;

            return View(modelo);
        }
    }
}
