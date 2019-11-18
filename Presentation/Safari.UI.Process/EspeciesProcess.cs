using Safari.Entities;
using Safari.Services;
using Safari.Services.Contracts;
using Safari.Services.Contracts.Request;
using Safari.Services.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Safari.UI.Process
{
    public class EspeciesProcess : ProcessComponent
    {        
        public IList<Especie> ToList()
        {
            
            var response = HttpGet<EspecieResponse>("api/Especie/ListarTodos", new Dictionary<string, object>(), MediaType.Json);
            return response.obtenerTodos;
        }

        public void Agregar(EspecieRequest especie)
        {
           

            var response = HttpPost("api/Especie/Agregar", especie, MediaType.Json);
          

        }

        public Especie ObtenerUno(int id)
        {
            var response = HttpGet<EspecieResponse>("api/Especie/ObtenerUno", new Dictionary<string, object>(id), MediaType.Json);
            return response.obtenerUno;
        }

        public void Actualizar(EspecieRequest especie)
        {
            var response = HttpPost("api/Especie/Actualizar", especie, MediaType.Json);
         
        }


        public void Eliminar(int especie)
        {
            var response = HttpPost("api/Especie/Eliminar", especie, MediaType.Json);
          
        }

        //public List<Especie> ListarTodos()
        //{
        //    List<Especie> result = default(List<Especie>);
        //    Iespecie proxy = new EspecieServices();
        //    EspecieServiceHttp a = new EspecieServiceHttp();

        //    try
        //    {
        //        result = proxy.Read();
        //    }
        //    catch (FaultException fex)
        //    {
        //        throw new ApplicationException(fex.Message);
        //    }
        //    return result;
        //}

        //public Especie Agregar(Especie especie)
        //{
        //    Especie result = default(Especie);
        //    Iespecie proxy = new EspecieServices();

        //    try
        //    {
        //        result = proxy.Create(especie);
        //    }
        //    catch (FaultException fex)
        //    {
        //        throw new ApplicationException(fex.Message);
        //    }

        //    return result;
        //}

        //public Especie Ver(int id)
        //{
        //    Especie result = default(Especie);
        //    Iespecie proxy = new EspecieServices();

        //    try
        //    {
        //        result = proxy.ReadBy(id);
        //    }
        //    catch (FaultException fex)
        //    {
        //        throw new ApplicationException(fex.Message);
        //    }

        //    return result;
        //}

        //public Especie Eliminar(int id)
        //{
        //    Especie result = default(Especie);
        //    Iespecie proxy = new EspecieServices();

        //    try
        //    {
        //        proxy.Delete(id);
        //    }
        //    catch (FaultException fex)
        //    {
        //        throw new ApplicationException(fex.Message);
        //    }

        //    return result;
        //}

        //public Especie Editar(int id, Especie especie)
        //{
        //    Especie result = default(Especie);
        //    Iespecie proxy = new EspecieServices();

        //    try
        //    {
        //        proxy.Update( especie);
        //        result = proxy.ReadBy(id);
        //    }
        //    catch (FaultException fex)
        //    {
        //        throw new ApplicationException(fex.Message);
        //    }

        //    return result;
        //}

    }
}
