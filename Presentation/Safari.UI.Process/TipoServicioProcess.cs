﻿using Safari.Entities;
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
    public class TipoServicioProcess : ProcessComponent, IProcess<TipoServicio, TipoDeServicioRequest>
    {
        public void Actualizar(TipoDeServicioRequest request)
        {
            var response = HttpPost("api/TipoServicio/Actualizar", request, MediaType.Json);
        }

        public void Agregar(TipoDeServicioRequest request)
        {
            var response = HttpPost("api/TipoServicio/Agregar", request, MediaType.Json);
        }

        public void Eliminar(int id)
        {
            var response = HttpPost("api/TipoServicio/Eliminar", id, MediaType.Json);
        }

        public TipoServicio ObtenerUno(int id)
        {
            var parameters = new Dictionary<string, object>();
            parameters.Add("id", id);
            var response = HttpGet<TipoDeServicioReponse>("api/TipoServicio/ObtenerUno", parameters, MediaType.Json);
            return response.obtenerUno;
        }

        public IList<TipoServicio> ToList()
        {
            var response = HttpGet<TipoDeServicioReponse>("api/TipoServicio/ListarTodos", new Dictionary<string, object>(), MediaType.Json);
            return response.obtenerTodos;
        }
    }
}
