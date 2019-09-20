using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Safari.Entities;
using Safari.Services;
using Safari.Services.Contracts;
using System.ServiceModel;

namespace Safari.UI.Process
{
 public   class MedicoProcess : ProcessComponent
    {

        public List<Medico> ListarTodos()
        {
            List<Medico> result = default(List<Medico>);
            Imedico proxy = new MedicoServices();

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

        public Medico Agregar(Medico medico)
        {
            Medico result = default(Medico);
            Imedico proxy = new MedicoServices();

            try
            {
                result = proxy.Create(medico);
            }
            catch (FaultException fex)
            {
                throw new ApplicationException(fex.Message);
            }

            return result;
        }

        public Medico Ver(int id)
        {
            Medico result = default(Medico);
            Imedico proxy = new MedicoServices();

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

        public Medico Eliminar(int id)
        {
            Medico result = default(Medico);
            Imedico proxy = new MedicoServices();

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

        public Medico Editar(int id, Medico medico)
        {
            Medico result = default(Medico);
            Imedico proxy = new MedicoServices();

            try
            {
                proxy.Update(medico);
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
