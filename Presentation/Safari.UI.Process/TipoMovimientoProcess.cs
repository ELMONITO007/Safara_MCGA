using Safari.Entities;
using Safari.Services;
using Safari.Services.Contracts;
using Safari.Services.Contracts.Request;
using Safari.Services.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Safari.UI.Process
{
    public class TipoMovimientoProcess : ProcessComponent, IProcess<TipoMovimiento, TipoMovimientoRequest>
    {
        public void Actualizar(TipoMovimientoRequest request)
        {
            var response = HttpPost("api/TipoMovimiento/Actualizar", request, MediaType.Json);
        }


        public void Agregar(TipoMovimientoRequest request)
        {
            var response = HttpPost("api/TipoMovimiento/Agregar", request, MediaType.Json);
        }

        public void Eliminar(int id)
        {
            var response = HttpPost("api/TipoMovimiento/Eliminar", id, MediaType.Json);
        }

        public TipoMovimiento ObtenerUno(int id)
        {
            var parameters = new Dictionary<string, object>();
            parameters.Add("id", id);
            var response = HttpGet<TipoMovimientoResponse>("api/TipoMovimiento/ObtenerUno",parameters, MediaType.Json);
            return response.obtenerUno;
        }

        public IList<TipoMovimiento> ToList()
        {
            try
            {
                var response = HttpGet<TipoMovimientoResponse>("api/TipoMovimiento/ListarTodos", new Dictionary<string, object>(), MediaType.Json);
                return response.obtenerTodos;
            }
            catch (Exception e)
            {

                throw;
            }
            
        }
    }
}
    