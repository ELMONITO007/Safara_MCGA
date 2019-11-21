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
    [RoutePrefix("api/Cliente")]
    public class ClienteServiceHTTP : ApiController, IServiceHttp<ClienteResponse, ClienteRequest>
    {
        [HttpPost]
        [Route("Actualizar")]
        public void Actualizar(ClienteRequest agregarRequest)
        {
            try
            {

                var bc = new ClienteComponent();
                bc.Update(agregarRequest.cliente);

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
        public void Crear(ClienteRequest agregarRequest)
        {
            try
            {

                var bc = new ClienteComponent();
                bc.Create(agregarRequest.cliente);

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
        [Route("Eliminar")]
        public void Eliminar(int id)
        {
            try
            {

                var bc = new ClienteComponent();
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
        public ClienteResponse ListarTodos()
        {
            try
            {
                var response = new ClienteResponse();
                var bc = new ClienteComponent();
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
        public ClienteResponse ObtenerUno(int id)
        {
            try
            {
                var response = new Contracts.ClienteResponse();
                var bc = new ClienteComponent();
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
