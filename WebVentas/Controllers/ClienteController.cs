using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using WebVentas.Data;
using WebVentas.Models;

namespace WebVentas.Controllers
{
    
    public class ClienteController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            using(ClienteDAO db=new ClienteDAO())
            {
                return View(db.Listar()); 
            }
            
        }
        [HttpGet]
        public IActionResult Agregar()
        {
            CargarLista();
            return View();
        }
        [HttpPost]
        public IActionResult Agregar(Cliente item)
        {
            using(ClienteDAO db=new ClienteDAO())
            {
               db.Agregar(item);
            }
            return RedirectToAction("index");
        }
        [HttpGet]
        public IActionResult Editar(int id)
        {
            using(ClienteDAO db=new ClienteDAO())
            {
                var item = db.Buscar(id);
                if (item != null)
                    return View(item);
            }
            return View();
        }
        [HttpPost]
        public IActionResult Editar(Cliente item)
        {
            CargarLista();
            using (ClienteDAO db = new ClienteDAO())
            {
                db.Editar(item);
            }
            return RedirectToAction("index");
        }


        [HttpGet]
        public IActionResult Eliminar(int id)
        {
            using (ClienteDAO db = new ClienteDAO())
            {
                var item = db.Buscar(id);
                if (item != null)
                    return View(item);
            }
            return View();
        }
        [HttpPost]
        public IActionResult Eliminar(int id,bool flag= false)
        {
            using (ClienteDAO db = new ClienteDAO())
            {
                db.Eliminar(id);
            }
            return RedirectToAction("index");
        }
        [HttpGet]
        public IActionResult Detalle(int id)
        {
            using(ClienteDAO db=new ClienteDAO())
            {
                var item = db.Buscar(id);
                if (item != null)
                    return View(item);
            }
            return View();
        }
        [HttpGet]
        public IActionResult Buscar(int id)
        {
            using (ClienteDAO db = new ClienteDAO())
            {
                var item = db.Buscar(id);
                if (item != null)
                    return View(item);
            }
            return View();
        }
        private void CargarLista()
        {
            using (CatalogoDAO db = new CatalogoDAO())
            {
                ViewBag.IdTipoDoc = db.ListarTipoDocumento();
            }
        }
    }
}
