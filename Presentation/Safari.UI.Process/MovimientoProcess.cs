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
    public class MovimientoProcess : ProcessComponent
    {
        public IList<Movimiento> ToList()
        {
            var response = HttpGet<MovimientoResponse>("api/Movimiento/ListarTodos", new Dictionary<string, object>(), MediaType.Json);
            return response.obtenerTodos;
        }



        //public Movimiento Agregar(Movimiento objeto)
        //{
        //    Movimiento result = default(Movimiento);

        //    return result;
        //}

        //public Movimiento Editar(int id, Movimiento objeto)
        //{
        //    Movimiento result = default(Movimiento);


        //    return result;
        //}

        //public Movimiento Eliminar(int id)
        //{
        //    Movimiento result = default(Movimiento);


        //    return result;
        //}

        //public List<Movimiento> ListarTodos()
        //{
        //    List<Movimiento> result = default(List<Movimiento>);

        //    return result;
        //}

        //public Movimiento Ver(int id)
        //{
        //    Movimiento result = default(Movimiento);

        //    return result;
        //}
    }
}

