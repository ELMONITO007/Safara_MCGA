using Safari.Data;
using Safari.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Safari.Business
{
    public class MedicoComponent : Component<Medico>
    {
        public override Medico Create(Medico objeto)
        {
            Medico result = default(Medico);
         
            var MedicoDAC = new MedicoDAC();

            result = MedicoDAC.Create(objeto);
            return result;
        }

        public override void Delete(int id)
        {
            var MedicoDAC = new MedicoDAC();
            MedicoDAC.Delete(id);
        }

        public override List<Medico> Read()
        {
            List<Medico> result = default(List<Medico>);

            var MedicoDAC = new MedicoDAC();
            result = MedicoDAC.Read();
            return result;
        }

        public override Medico ReadBy(int id)
        {
            Medico result = default(Medico);
            var MedicoDAC = new MedicoDAC();
            result = MedicoDAC.ReadBy(id);
            return result;
        }

        public override void Update(Medico objeto)
        {
            var MedicoDAC = new MedicoDAC();
            MedicoDAC.Update(objeto);
        }
    }
}
