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
    public class SalaProcess : ProcessComponent, Process<Sala>
    {
        public Sala Agregar(Sala objeto)
        {
            Sala result = default(Sala);
            ISala proxy = new SalaServices();

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

        public Sala Editar(int id, Sala objeto)
        {

            Sala result = default(Sala);
            ISala proxy = new SalaServices();

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

        public Sala Eliminar(int id)
        {
            Sala result = default(Sala);
            ISala proxy = new SalaServices();
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

        public List<Sala> ListarTodos()
        {
            List<Sala> result = default(List<Sala>);
            ISala proxy = new SalaServices();


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
    

        public Sala Ver(int id)
        {
            Sala result = default(Sala);
            ISala proxy = new SalaServices();
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
