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
    public class MovimientoProcess : ProcessComponent, IProcess<Movimiento, MoviemientoRequest>
    {
        public void Actualizar(MoviemientoRequest request)
        {
            var response = HttpPost("api/Movimiento/Actualizar", request, MediaType.Json);
        }

        public void Agregar(MoviemientoRequest request)
        {
            var response = HttpPost("api/Movimiento/Agregar", request, MediaType.Json);
        }

        public void Eliminar(int id)
        {
            var response = HttpPost("api/Movimiento/Eliminar", id, MediaType.Json);
        }

        public Movimiento ObtenerUno(int id)
        {
            var parameters = new Dictionary<string, object>();
            parameters.Add("id", id);
            var response = HttpGet<MovimientoResponse>("api/Movimiento/ObtenerUno", parameters, MediaType.Json);
            return response.obtenerUno;
        }

        public IList<Movimiento> ToList()
        {
            var response = HttpGet<MovimientoResponse>("api/Movimiento/ListarTodos", new Dictionary<string, object>(), MediaType.Json);
            return response.obtenerTodos;
        }
    }
}

