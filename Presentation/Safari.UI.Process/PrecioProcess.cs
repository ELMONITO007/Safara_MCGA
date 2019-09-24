using Safari.Entities;
using Safari.Services;
using Safari.Services.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
namespace Safari.UI.Process
{
    public class PrecioProcess : ProcessComponent, Process<Precio>
    {
        public Precio Agregar(Precio objeto)
        {
            Precio result = default(Precio);
            IPrecio proxy = new PrecioServices();

            try
            {
                result = proxy.Create(objeto);
            }
            catch (FaultException fex)
            {
                throw new ApplicationException(fex.Message);
            }
            return result;
        }

        public Precio Editar(int id, Precio objeto)
        {
            Precio result = default(Precio);
            IPrecio proxy = new PrecioServices();
            try
            {
                proxy.Update(objeto);
                result = proxy.ReadBy(id);
            }
            catch (FaultException fex)
            {
                throw new ApplicationException(fex.Message);
            }

            return result;
        }

        public Precio Eliminar(int id)
        {
            Precio result = default(Precio);
            IPrecio proxy = new PrecioServices();
            try
            {
                proxy.Delete(id);
            }
            catch (FaultException fex)
            {
                throw new ApplicationException(fex.Message);
            }

            return result;
        }

        public List<Precio> ListarTodos()
        {
            List<Precio> result = default(List<Precio>);
            IPrecio proxy = new PrecioServices();


            try
            {
                result = proxy.Read();
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
            IPrecio proxy = new PrecioServices();

            try
            {
                result = proxy.ReadBy(id);
            }
            catch (FaultException fex)
            {
                throw new ApplicationException(fex.Message);
            }

            return result;
        }
    }
}
