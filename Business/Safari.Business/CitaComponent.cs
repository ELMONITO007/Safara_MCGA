using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Safari.Data;
using Safari.Entities;

namespace Safari.Business
{
    public class CitaComponent : Component<Cita>
    {
        public override Cita Create(Cita objeto)
        {
            Cita result = default(Cita);
            var citaDAC = new CitaDAC();

            result = citaDAC.Create(objeto);
            return result;
        }

        public override void Delete(int id)
        {
            var citaDAC = new CitaDAC();
            citaDAC.Delete(id);
        }

        public override List<Cita> Read()
        {
            List<Cita> result = default(List<Cita>);

            var citaDAC = new CitaDAC();
            result = citaDAC.Read();
            return result;
        }

        public override Cita ReadBy(int id)
        {
            Cita result = default(Cita);
            var citaDAC = new CitaDAC();
            result = citaDAC.ReadBy(id);
            return result;
        }

        public override void Update(Cita objeto)
        {
            var citaDAC = new CitaDAC();
            citaDAC.Update(objeto);
        }
    }
}
