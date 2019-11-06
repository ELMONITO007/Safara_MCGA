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
    public  class EspecieServiceHttp :ApiController
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
        [HttpGet]
        [Route("ListarUno")]
        public EspecieResponse ListarUno(int id)
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

        [HttpPost]
        [Route("Agregar")]
        public EspecieResponse Agregar(EspecieRequest request)
        {
            try
            {
                var response = new EspecieResponse();
                var bc = new EspecieComponent();
                response.agregar = bc.Create(request.Especie);
                return response;
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
