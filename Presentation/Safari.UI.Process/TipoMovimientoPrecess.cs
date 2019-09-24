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
    public class TipoMovimientoPrecess : ProcessComponent, Process<TipoMovimiento>
    {
        public TipoMovimiento Agregar(TipoMovimiento objeto)
        {
            TipoMovimiento result = default(TipoMovimiento);
            ITipoMovimiento proxy = new TipoMovimientoServices();

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

        public TipoMovimiento Editar(int id, TipoMovimiento objeto)
        {
            TipoMovimiento result = default(TipoMovimiento);
            ITipoMovimiento proxy = new TipoMovimientoServices();

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

        public TipoMovimiento Eliminar(int id)
        {
            TipoMovimiento result = default(TipoMovimiento);
            ITipoMovimiento proxy = new TipoMovimientoServices();
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

        public List<TipoMovimiento> ListarTodos()
        {
            List<TipoMovimiento> result = default(List<TipoMovimiento>);
            ITipoMovimiento proxy = new TipoMovimientoServices();

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

        public TipoMovimiento Ver(int id)
        {

            TipoMovimiento result = default(TipoMovimiento);
            ITipoMovimiento proxy = new TipoMovimientoServices();
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
