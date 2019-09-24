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
    public class PacienteProcess : ProcessComponent, Process<Paciente>
    {
    {
public Paciente Agregar(Paciente objeto)
        {

            Paciente result = default(Paciente);
            IPaciente proxy = new PacienteServices();

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

        public Paciente Editar(int id, Paciente objeto)
        {
            Paciente result = default(Paciente);
            IPaciente proxy = new PacienteServices();
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

        public Paciente Eliminar(int id)
        {
            Paciente result = default(Paciente);
            IPaciente proxy = new PacienteServices();
            try
            {
                proxy.Delete(id);
            }
            catch (FaultException fex)
            {
                throw new ApplicationException(fex.Message);
            }

            return result; ;
        }

        public List<Paciente> ListarTodos()
        {
            List<Paciente> result = default(List<Paciente>);
            IPaciente proxy = new PacienteServices();


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

        public Paciente Ver(int id)
        {
            Paciente result = default(Paciente);
            IPaciente proxy = new PacienteServices();
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
