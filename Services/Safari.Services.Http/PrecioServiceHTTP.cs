using Safari.Business;
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
    [RoutePrefix("api/Precio")]
  public  class PrecioServiceHTTP : ApiController,IServiceHttp<PrecioResponse,PrecioRequest>
    {
        [HttpPost]
        [Route("Actualizar")]
        public void Actualizar(PrecioRequest agregarRequest)
        {
            try
            {

                var bc = new PrecioComponent();
                bc.Update(agregarRequest.Precio);

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
        public void Crear(PrecioRequest agregarRequest)
        {
            try
            {

                var bc = new PrecioComponent();
                bc.Create(agregarRequest.Precio);

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

                var bc = new PrecioComponent();
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
        public PrecioResponse ListarTodos()
        {


            try
            {
                var response = new PrecioResponse();
                var bc = new PrecioComponent();
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
        public PrecioResponse ObtenerUno(int id)
        {
            try
            {
                var response = new PrecioResponse();
                var bc = new PrecioComponent();
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
