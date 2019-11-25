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
    public class MedicoProcess : ProcessComponent, IProcess<Medico, MedicoRequest>
    {
        public void Actualizar(MedicoRequest request)
        {
            var response = HttpPost("api/Medico/Actualizar", request, MediaType.Json);
        }

        public void Agregar(MedicoRequest request)
        {
            var response = HttpPost("api/Medico/Agregar", request, MediaType.Json);
        }

        public void Eliminar(int id)
        {
            var response = HttpPost("api/Medico/Eliminar", id, MediaType.Json);
        }

        public Medico ObtenerUno(int id)
        {
            var parameters = new Dictionary<string, object>();
            parameters.Add("id", id);
            var response = HttpGet<MedicoResponse>("api/Medico/ObtenerUno", parameters, MediaType.Json);
            return response.obtenerUno;
        }

        public IList<Medico> ToList()
        {
            var response = HttpGet<MedicoResponse>("api/Medico/ListarTodos", new Dictionary<string, object>(), MediaType.Json);
            return response.obtenerTodos;
        }
    }   
}
