using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using WebVentas.Models;

namespace WebVentas.Data
{
    public class ClienteDAO:IDisposable
    {
        VENTASContext db = new VENTASContext();
        private bool disposedValue;

        public int Agregar(Cliente item)
        {
            db.Clientes.Add(item);
            return db.SaveChanges();
        }
        public int Editar(Cliente item)
        {
            //var item = db.Clientes.Where(x => x.Id == id).SingleOrDefault();
            db.Clientes.Update(item);
            return db.SaveChanges();
        }
        public int Eliminar(int id)
        {
            var item = db.Clientes.Where(x => x.Id == id).SingleOrDefault();
            db.Clientes.Remove(item);
            return db.SaveChanges();
        }
        public Cliente Buscar(int id)
        {
            var item = db.Clientes.Where(x => x.Id == id).SingleOrDefault();
            return item;
        }
        public List<Cliente> Listar()
        {
            return db.Clientes.ToList();
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
        // ~ClienteDAO()
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
