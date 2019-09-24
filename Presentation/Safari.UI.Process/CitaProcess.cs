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
    public class CitaProcess : ProcessComponent, Process<Cita>
    {
        public Cita Agregar(Cita objeto)
        {
            Cita result = default(Cita);
            ICita proxy = new CitaServices();

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

        public Cita Editar(int id, Cita objeto)
        {
            Cita result = default(Cita);
            ICita proxy = new CitaServices();
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

        public Cita Eliminar(int id)
        {
            Cita result = default(Cita);
            ICita proxy = new CitaServices();
            
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
       

        public List<Cita> ListarTodos()
        {
            List<Cita> result = default(List<Cita>);
            ICita proxy = new CitaServices();


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

        public Cita Ver(int id)
        {
            Cita result = default(Cita);
            ICita proxy = new CitaServices();

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
