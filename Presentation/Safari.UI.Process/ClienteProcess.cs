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
using System.Threading.Tasks;

namespace Safari.UI.Process
{
    public class ClienteProcess : ProcessComponent, IProcess<Cliente, ClienteRequest>
    {
        public void Actualizar(ClienteRequest request)
        {
            var response = HttpPost("api/Cliente/Actualizar", request, MediaType.Json);
        }

        public void Agregar(ClienteRequest request)
        {
            var response = HttpPost("api/Cliente/Agregar", request, MediaType.Json);
        }

        public void Eliminar(int id)
        {
            var response = HttpPost("api/Cliente/Eliminar", id, MediaType.Json);
        }

        public Cliente ObtenerUno(int id)
        {
            var parameters = new Dictionary<string, object>();
            parameters.Add("id", id);
            var response = HttpGet<ClienteResponse>("api/Cliente/ObtenerUno", parameters, MediaType.Json);
            return response.obtenerUno;
        }

        public IList<Cliente> ToList()
        {
            var response = HttpGet<ClienteResponse>("api/Cliente/ListarTodos", new Dictionary<string, object>(), MediaType.Json);
            return response.obtenerTodos;
        }
    }
}
