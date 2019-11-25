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
    public class PrecioProcess : ProcessComponent, IProcess<Precio, PrecioRequest>
    {
        public void Actualizar(PrecioRequest request)
        {
            var response = HttpPost("api/Precio/Actualizar", request, MediaType.Json);
        }

        public void Agregar(PrecioRequest request)
        {
            var response = HttpPost("api/Precio/Agregar", request, MediaType.Json);
        }

        public void Eliminar(int id)
        {
            var response = HttpPost("api/Precio/Eliminar", id, MediaType.Json);
        }

        public Precio ObtenerUno(int id)
        {
            var parameters = new Dictionary<string, object>();
            parameters.Add("id", id);
            var response = HttpGet<PrecioResponse>("api/Precio/ObtenerUno", parameters, MediaType.Json);
            return response.obtenerUno;
        }

        public IList<Precio> ToList()
        {
            var response = HttpGet<PrecioResponse>("api/Precio/ListarTodos", new Dictionary<string, object>(), MediaType.Json);
            return response.obtenerTodos;
        }
    }
}
