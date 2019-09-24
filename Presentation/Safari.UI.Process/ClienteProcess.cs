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
    public class ClienteProcess : ProcessComponent, Process<Cliente>
    {
        public Cliente Agregar(Cliente objeto)
        {
            Cliente result = default(Cliente);
            ICliente proxy = new ClienteServices();

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

        public Cliente Editar(int id, Cliente objeto)
        {
            Cliente result = default(Cliente);
            ICliente proxy = new ClienteServices();
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

        public Cliente Eliminar(int id)
        {
            Cliente result = default(Cliente);
            ICliente proxy = new ClienteServices();
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

        public List<Cliente> ListarTodos()
        {
            List<Cliente> result = default(List<Cliente>);
            ICliente proxy = new ClienteServices();


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

        public Cliente Ver(int id)
        {
            Cliente result = default(Cliente);
            ICliente proxy = new ClienteServices();

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
