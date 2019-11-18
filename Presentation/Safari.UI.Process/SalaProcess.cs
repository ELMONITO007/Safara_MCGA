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
    public class SalaProcess : ProcessComponent, IProcess<Sala, SalaRequest>
    {
        public void Actualizar(SalaRequest request)
        {
            var response = HttpPost("api/Sala/Actualizar", request, MediaType.Json);
        }

        public void Agregar(SalaRequest request)
        {
            var response = HttpPost("api/Sala/Agregar", request, MediaType.Json);
        }

        public void Eliminar(int id)
        {
            var response = HttpPost("api/Sala/Eliminar", id, MediaType.Json);
        }

        public Sala ObtenerUno(int id)
        {
            var response = HttpGet<SalaResponse>("api/Sala/ObtenerUno", new Dictionary<string, object>(id), MediaType.Json);
            return response.obtenerUno;
        }


        public IList<Sala> ToList()
        {
            var response = HttpGet<SalaResponse>("api/Sala/ListarTodos", new Dictionary<string, object>(), MediaType.Json);
            return response.obtenerTodos;
        }
    }
}
