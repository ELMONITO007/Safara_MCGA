using Safari.Data;
using Safari.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Safari.Business
{
    public class SalaComponent : Component<Sala>
    {
        public override Sala Create(Sala objeto)
        {
            Sala result = default(Sala);
            var salaDAC = new SalaDAC();

            result = salaDAC.Create(objeto);
            return result;
        }

        public override void Delete(int id)
        {
            var salaDAC = new SalaDAC();
            salaDAC.Delete(id);
        }

        public override List<Sala> Read()
        {
            List<Sala> result = default(List<Sala>);

            var salaDAC = new SalaDAC();
            result = salaDAC.Read();
            return result;
        }

        public override Sala ReadBy(int id)
        {
            Sala result = default(Sala);
            var salaDAC = new SalaDAC();
            result = salaDAC.ReadBy(id);
            return result;
        }

        public override void Update(Sala objeto)
        {
            var salaDAC = new SalaDAC();
            salaDAC.Update(objeto);
        }
    }
}
