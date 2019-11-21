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
    [RoutePrefix("api/Paciente")]
    public class PacienteServiceHTTP : ApiController, IServiceHttp<PacienteResponse,PacienteRequest>
    {
        [HttpPost]
        [Route("Actualizar")]
        public void Actualizar(PacienteRequest agregarRequest)
        {
            try
            {

                var bc = new PacienteComponent();
                bc.Update(agregarRequest.paciente);

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
        public void Crear(PacienteRequest agregarRequest)
        {

            try
            {

                var bc = new PacienteComponent();
                bc.Create(agregarRequest.paciente);

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

                var bc = new PacienteComponent();
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
        public PacienteResponse ListarTodos()
        {
            try
            {
                var response = new PacienteResponse();
                var bc = new PacienteComponent();
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
        public PacienteResponse ObtenerUno(int id)
        {
            try
            {
                var response = new Contracts.PacienteResponse();
                var bc = new PacienteComponent();
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
