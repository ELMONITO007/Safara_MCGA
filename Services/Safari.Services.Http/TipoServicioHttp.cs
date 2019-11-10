﻿using Safari.Business;
using Safari.Services.Contracts;
using Safari.Services.Contracts.Request;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;

namespace Safari.Services.Http
{
    [RoutePrefix("api/TipoServicio")]
    public class TipoServicioHttp : ApiController, IServiceHttp<TipoDeServicioReponse, TipoDeServicioRequest>
    {
        [HttpPost]
        [Route("Actualizar")]
        public void Actualizar(TipoDeServicioRequest agregarRequest)
        {
            try
            {

                var bc = new TipoServicioComponent();
                bc.Update(agregarRequest.tipoServicio);

            }
            catch (Exception ex)
            {
                var httpError = new HttpResponseMessage()
                {
                    StatusCode = (HttpStatusCode)422, // UNPROCESSABLE ENTITY
                    ReasonPhrase = ex.Message
                };
                throw new HttpResponseException(httpError);
            }
        }

        [HttpPost]
        [Route("Agregar")]
        public void Crear(TipoDeServicioRequest agregarRequest)
        {
            try
            {

                var bc = new TipoServicioComponent();
                bc.Create(agregarRequest.tipoServicio);

            }
            catch (Exception ex)
            {
                var httpError = new HttpResponseMessage()
                {
                    StatusCode = (HttpStatusCode)422, // UNPROCESSABLE ENTITY
                    ReasonPhrase = ex.Message
                };
                throw new HttpResponseException(httpError);
            }
        }

        [HttpGet]
        [Route("Eliminar")]
        public void Eliminar(int id)
        {
            try
            {

                var bc = new TipoServicioComponent();
                bc.Delete(id);


            }
            catch (Exception ex)
            {

                var httpError = new HttpResponseMessage()
                {
                    StatusCode = (HttpStatusCode)422,
                    ReasonPhrase = ex.Message
                };
                throw new HttpResponseException(httpError);

            }
        }

        [HttpGet]
        [Route("ListarTodos")]

        public TipoDeServicioReponse ListarTodos()
        {
            try
            {
                var response = new TipoDeServicioReponse();
                var bc = new TipoServicioComponent();
                response.obtenerTodos = bc.Read();
                return response;

            }
            catch (Exception ex)
            {

                var httpError = new HttpResponseMessage()
                {
                    StatusCode = (HttpStatusCode)422,
                    ReasonPhrase = ex.Message
                };
                throw new HttpResponseException(httpError);

            }
        }


        [HttpGet]
        [Route("ObtenerUno")]
        public TipoDeServicioReponse ObtenerUno(int id)
        {
            try
            {
                var response = new TipoDeServicioReponse();
                var bc = new TipoServicioComponent();
                response.obtenerUno = bc.ReadBy(id);
                return response;

            }
            catch (Exception ex)
            {

                var httpError = new HttpResponseMessage()
                {
                    StatusCode = (HttpStatusCode)422,
                    ReasonPhrase = ex.Message
                };
                throw new HttpResponseException(httpError);

            }
        }
    }
}
