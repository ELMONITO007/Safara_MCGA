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
    [RoutePrefix("api/Especie")]
    public  class EspecieServiceHttp :ApiController, IServiceHttp<EspecieResponse,EspecieRequest>
    {
        [HttpGet]
        [Route("ListarTodos")]
        public EspecieResponse ListarTodos()
        {


            try
            {
                var response = new EspecieResponse();
                var bc = new EspecieComponent();
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



        [HttpPost]
        [Route("Actualizar")]
        public void Actualizar(EspecieRequest agregarRequest)
        {
            try
            {

                var bc = new EspecieComponent();
                bc.Update(agregarRequest.Especie);

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
        [Route("ObtenerUno")]
        public EspecieResponse ObtenerUno(int id)
        {
            try
            {
                var response = new EspecieResponse();
                var bc = new EspecieComponent();
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
        [HttpGet]
        [Route("Eliminar")]
        public void Eliminar(int id)
        {
            try
            {

                var bc = new EspecieComponent();
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
        [HttpPost]
        [Route("Agregar")]
        public void Crear(EspecieRequest agregarRequest)
        {
            try
            {
                var response = new EspecieResponse();
                var bc = new EspecieComponent();
                bc.Create(agregarRequest.Especie);
               
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
    }
}
