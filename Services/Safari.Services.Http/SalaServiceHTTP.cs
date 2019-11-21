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
    [RoutePrefix("api/Sala")]
    public class SalaServiceHTTP : ApiController, IServiceHttp<SalaResponse, SalaRequest>

    {
        [HttpPost]
        [Route("Actualizar")]
        public void Actualizar(SalaRequest agregarRequest)
        {
            try
            {

                var bc = new SalaComponent();
                bc.Update(agregarRequest.tipoMovimiento);

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
        public void Crear(SalaRequest agregarRequest)
        {

            try
            {

                var bc = new SalaComponent();
                bc.Create(agregarRequest.tipoMovimiento);

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

                var bc = new SalaComponent();
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
        public SalaResponse ListarTodos()
        {
            try
            {
                var response = new SalaResponse();
                var bc = new SalaComponent();
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
        public SalaResponse ObtenerUno(int id)
        {
            try
            {
                var response = new SalaResponse();
                var bc = new SalaComponent();
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
