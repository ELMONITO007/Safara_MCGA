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
 public   class EspeciesProcess : ProcessComponent
    {
        public List<Especie> ListarTodos()
        {
            List<Especie> result = default(List<Especie>);
            IEspecie proxy = new EspecieServices();

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

        public Especie Agregar(Especie especie)
        {
            Especie result = default(Especie);
            IEspecie proxy = new EspecieServices();

            try
            {
                result = proxy.Create(especie);
            }
            catch (FaultException fex)
            {
                throw new ApplicationException(fex.Message);
            }

            return result;
        }

        public Especie Ver(int id)
        {
            Especie result = default(Especie);
            IEspecie proxy = new EspecieServices();

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

        public Especie Eliminar(int id)
        {
            Especie result = default(Especie);
            IEspecie proxy = new EspecieServices();

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

        public Especie Editar(int id, Especie especie)
        {
            Especie result = default(Especie);
            IEspecie proxy = new EspecieServices();

            try
            {
                proxy.Update( especie);
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
