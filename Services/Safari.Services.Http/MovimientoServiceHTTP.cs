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
    [RoutePrefix("api/Movimiento")]
    public class MovimientoServiceHTTP : ApiController
    {
        [HttpGet]
        [Route("ListarTodos")]
        public MovimientoResponse ListarTodos()
        {


            try
            {
                var response = new MovimientoResponse();
                var bc = new MovimientoComponent();
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
        public MovimientoResponse ObtenerUno(int id)
        {
            try
            {
                var response = new MovimientoResponse();
                var bc = new MovimientoComponent();
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
        [Route("Eliminar")]
        public void Eliminar(int id)
        {
            try
            {
                
                var bc = new MovimientoComponent();
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
        public void Agregar(AgregarMovimientoRequest agregarMovimiento)
        {
            try
            {
                
                var bc = new MovimientoComponent();
                bc.Create(agregarMovimiento.movimiento);
               
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
        [Route("Actualizar")]
        public void Actualizar(AgregarMovimientoRequest agregarMovimiento)
        {
            try
            {

                var bc = new MovimientoComponent();
                bc.Update(agregarMovimiento.movimiento);

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
