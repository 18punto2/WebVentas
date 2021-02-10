using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using WebVentas.Models;

namespace WebVentas.Data
{
    public class ProductoDAO:IDisposable
    {
        VENTASContext db = new VENTASContext();
        private bool disposedValue;

        public int Agregar(Producto producto)
        {
            db.Productos.Add(producto);
            return db.SaveChanges();//Confirma cambios
        }
        public int Editar(Producto producto)
        {
            db.Productos.Update(producto);
            return db.SaveChanges();//Confirma cambios
        }
        public int Eliminar(int id)
        {
            var item = db.Productos.Where(x => x.IdArt == id).SingleOrDefault();// retorna un solo registro
            db.Productos.Remove(item);
            return db.SaveChanges();//Confirma cambios
        }
        public Producto Buscar(int id)
        {
            var item = db.Productos.Where(x => x.IdArt == id).SingleOrDefault();// retorna un solo registro
            return item;
        }
        public List<Producto> Listar()
        {
            var query= db.Productos.Take(100).OrderByDescending(p=>p.IdArt).ToList();
            return query;
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    // TODO: eliminar el estado administrado (objetos administrados)
                }

                // TODO: liberar los recursos no administrados (objetos no administrados) y reemplazar el finalizador
                // TODO: establecer los campos grandes como NULL
                disposedValue = true;
            }
        }

        // // TODO: reemplazar el finalizador solo si "Dispose(bool disposing)" tiene código para liberar los recursos no administrados
        // ~ProductoDAO()
        // {
        //     // No cambie este código. Coloque el código de limpieza en el método "Dispose(bool disposing)".
        //     Dispose(disposing: false);
        // }

        public void Dispose()
        {
            // No cambie este código. Coloque el código de limpieza en el método "Dispose(bool disposing)".
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }
    }
}
