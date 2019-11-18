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
    public class PacienteProcess : ProcessComponent, IProcess<Paciente, PacienteRequest>
    {
        public void Actualizar(PacienteRequest request)
        {
            var response = HttpPost("api/Paciente/Actualizar", request, MediaType.Json);
        }

        public void Agregar(PacienteRequest request)
        {
            var response = HttpPost("api/Paciente/Agregar", request, MediaType.Json);
        }

        public void Eliminar(int id)
        {
            var response = HttpPost("api/Paciente/Eliminar", id, MediaType.Json);
        }

        public Paciente ObtenerUno(int id)
        {

            var response = HttpGet<PacienteResponse>("api/Paciente/ObtenerUno", new Dictionary<string, object>(id), MediaType.Json);
            return response.obtenerUno;
        }

        public IList<Paciente> ToList()
        {
            var response = HttpGet<PacienteResponse>("api/Paciente/ListarTodos", new Dictionary<string, object>(), MediaType.Json);
            return response.obtenerTodos;
        }
    }
}
    