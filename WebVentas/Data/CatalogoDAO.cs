using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using WebVentas.Models;

namespace WebVentas.Data
{
    public class CatalogoDAO:IDisposable
    {
        VENTASContext db = new VENTASContext();
        private bool disposedValue;

        public List<SunatUnidadMedida> ListarUnidadMedida()
        {
            return db.SunatUnidadMedidas.ToList();
        }
        public List<SunatTipoMercaderia> ListarTipoMercaderia()
        {
            return db.SunatTipoMercaderias.ToList();
        }
        public List<Familia> ListarFamilia()
        {
            return db.Familias.ToList();
        }
        public List<Linea> ListarLinea()
        {
            return db.Lineas.ToList();
        }
        public List<SunatTipoDocumento> ListarTipoDocumento()
        {
            return db.SunatTipoDocumentos.ToList();
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
        // ~CatalogoDAO()
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
