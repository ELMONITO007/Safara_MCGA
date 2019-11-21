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
    [RoutePrefix("api/TipoMovimiento")]
    public class TipoMovimientoServiceHTTP : ApiController, IServiceHttp<TipoMovimientoResponse, TipoMovimientoRequest>
    {
        [HttpPost]
        [Route("Actualizar")]
        public void Actualizar(TipoMovimientoRequest agregarRequest)
        {
            try
            {

                var bc = new TipoMovimientoComponent();
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
        public void Crear(TipoMovimientoRequest agregarRequest)
        {
            try
            {
                
                var bc = new TipoMovimientoComponent();
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

        [HttpGet]
        [Route("Eliminar")]
        public void Eliminar(int id)
        {

            try
            {

                var bc = new TipoMovimientoComponent();
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
        public TipoMovimientoResponse ListarTodos()
        {
            try
            {
                var response = new TipoMovimientoResponse();
                var bc = new TipoMovimientoComponent();
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
        public TipoMovimientoResponse ObtenerUno(int id)
        {
            try
            {
                var response = new TipoMovimientoResponse();
                var bc = new TipoMovimientoComponent();
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
