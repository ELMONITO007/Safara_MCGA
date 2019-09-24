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
    public class MovimientoProcess : ProcessComponent, Process<Movimiento>
    {
        public Movimiento Agregar(Movimiento objeto)
        {
            Movimiento result = default(Movimiento);
            IMovimiento proxy = new MovimientoServices();

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

        public Movimiento Editar(int id, Movimiento objeto)
        {
            Movimiento result = default(Movimiento);
            IMovimiento proxy = new MovimientoServices();

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

        public Movimiento Eliminar(int id)
        {
            Movimiento result = default(Movimiento);
            IMovimiento proxy = new MovimientoServices();

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

        public List<Movimiento> ListarTodos()
        {
            List<Movimiento> result = default(List<Movimiento>);
            IMovimiento proxy = new MovimientoServices();


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

        public Movimiento Ver(int id)
        {
            Movimiento result = default(Movimiento);
            IMovimiento proxy = new MovimientoServices();

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
