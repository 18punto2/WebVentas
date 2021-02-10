using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using WebVentas.Data;
using WebVentas.Models;
using WebVentas.ViewModels;

namespace WebVentas.Controllers
{
    public class ProductoController : Controller
    {
        [HttpGet]//HttpGet- crean pantallas-formularios
        public IActionResult Index(string nombre="", int pagina=1)
        {
            using(ProductoDAO db=new ProductoDAO())//Garantiza que el objeto se cree y se autodestruye
            {
                if(string.IsNullOrEmpty(nombre))
                    nombre = "";
                
                var registrosPorPagina = 10;
                //lista registro 
                var list = db.Listar().Where(x => x.Detalle.Contains(nombre));
                var productos = list
                    .OrderBy(p => p.Detalle)
                    .Skip((pagina - 1) * registrosPorPagina)
                    .Take(registrosPorPagina).ToList();
                //Obtener la cantidad registros de la consulta
                var TotalDeRegistros = list.Count();
                //configurar la paginacion
                var modelo = new IndexViewModel();
                modelo.PaginaProductos = productos;
                modelo.PaginaActual = pagina;
                modelo.TotalDeRegistros = TotalDeRegistros;
                modelo.RegistrosPorPagina = registrosPorPagina;
                
                modelo.ValoresQueryString = new RouteValueDictionary();
                modelo.ValoresQueryString["nombre"] = nombre;
                modelo.NombreProducto = nombre;
                return View(modelo);
            }
        }
        [HttpGet]//crea una vista con un formulario para ingresar los datos del producto//
        public IActionResult Agregar()
        {
            CargarListas();
            return View();
        }

        [HttpPost]// para un boton que esta dentro de la vista
        public IActionResult Agregar(Producto item)
        {
            using(ProductoDAO db =new ProductoDAO())
            {
                db.Agregar(item);
            }
            return RedirectToAction("index");
        }
        [HttpGet]
        public IActionResult Editar(int id)
        {
            CargarListas();
            using (ProductoDAO db = new ProductoDAO())
            {
                var item = db.Buscar(id);
                if (item != null)
                {
                    return View(item);// devuelve a la vista el producto
                }
            }
            return View();
        }
        [HttpPost]
        public IActionResult Editar(Producto item)
        {
            using(ProductoDAO db=new ProductoDAO())
            {
                db.Editar(item);
            }
            return RedirectToAction("index");
        }
        [HttpGet]
        public IActionResult Eliminar(int id)
        {
            using (ProductoDAO db=new ProductoDAO())
            {
                var item = db.Buscar(id);
                if (item != null)
                    return View(item);            
            }
            return View();
        }
        [HttpPost]
        public IActionResult Eliminar(int id,bool flag=false)
        {
            using (ProductoDAO db = new ProductoDAO())
            {
                db.Eliminar(id);
            }
            return RedirectToAction("index");
        }
        [HttpGet]
        public IActionResult Detalle(int id)
        {
            CargarListas();
            using (ProductoDAO db = new ProductoDAO())
            {
                var item = db.Buscar(id);
                return View(item);// devuelve a la vista el producto
            }
        }
        private void CargarListas()
        {
            using(CatalogoDAO db=new CatalogoDAO())// using no acepta en clases que no implementan el idisposable
            {
                ViewBag.Idmedida = db.ListarUnidadMedida();
                ViewBag.IdTipMer = db.ListarTipoMercaderia();
                ViewBag.IdFamilia = db.ListarFamilia();
                ViewBag.IdLinea = db.ListarLinea();
            }
        }
        //ViewBag - objeto que permite pasar datos desde la accion del controlador hacia la vista- temporal y se autodestruye

    }
}
