using Safari.Business;
using Safari.Services.Contracts;
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
        public ListarTodosEspecieResponse ListarTodos()
        {


            try
            {
                var response = new ListarTodosEspecieResponse();
                var bc = new EspecieComponent();
                response.result = bc.Read();
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
