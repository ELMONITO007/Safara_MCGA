using Safari.Entities;
using Safari.Services;
using Safari.Services.Contracts;
using Safari.Services.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Safari.UI.Process
{
    public class PrecioProcess : ProcessComponent
    {
        public IList<Precio> ToList()

        {
          
            var response1 = HttpGet<PrecioResponse>("api/Precio/ListarTodos", new Dictionary<string, object>(), MediaType.Json);
            return response1.obtenerTodos;

            
            //return response.obtenerTodos;
        }



        public Precio Agregar(Precio objeto)
        {
            Precio result = default(Precio);
            
            return result;
        }

        public Precio Editar(int id, Precio objeto)
        {
            Precio result = default(Precio);
            

            return result;
        }

        public Precio Eliminar(int id)
        {
            Precio result = default(Precio);
           

            return result;
        }

        public List<Precio> ListarTodos()
        {
            List<Precio> result = default(List<Precio>);
            


            try
            {
               
            }
            catch (FaultException fex)
            {
                throw new ApplicationException(fex.Message);
            }
            return result;
        }

        public Precio Ver(int id)
        {
            Precio result = default(Precio);
          

          

            return result;
        }
    }
}
