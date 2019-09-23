using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Safari.Data;
using Safari.Entities;

namespace Safari.Business
{
    public class PacienteComponent : Component<Paciente>
    {
        public override Paciente Create(Paciente objeto)
        {
            Paciente result = default(Paciente);
            var pacienteDAC = new PacienteDAC();

            result = pacienteDAC.Create(objeto);
            return result;
        }

        public override void Delete(int id)
        {
            var pacienteDAC = new PacienteDAC();
            pacienteDAC.Delete(id);
        }

        public override List<Paciente> Read()
        {

            List<Paciente> result = default(List<Paciente>);

            var pacienteDAC = new PacienteDAC();
            result = pacienteDAC.Read();
            return result;
        }

        public override Paciente ReadBy(int id)
        {
            Paciente result = default(Paciente);
            var pacienteDAC = new PacienteDAC();
            result = pacienteDAC.ReadBy(id);
            return result;
        }

        public override void Update(Paciente objeto)
        {
            var pacienteDAC = new PacienteDAC();
            pacienteDAC.Update(objeto);
        }
    }
}
