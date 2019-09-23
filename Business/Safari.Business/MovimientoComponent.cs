using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Safari.Data;
using Safari.Entities;

namespace Safari.Business
{
    public class MovimientoComponent : Component<Movimiento>
    {
        public override Movimiento Create(Movimiento objeto)
        {
            Movimiento result = default(Movimiento);
            var movimientoDAC = new MovimientoDAC();

            result = movimientoDAC.Create(objeto);
            return result;
        }

        public override void Delete(int id)
        {
            var movimientoDAC = new MovimientoDAC();
            movimientoDAC.Delete(id);
        }

        public override List<Movimiento> Read()
        {
            List<Movimiento> result = default(List<Movimiento>);

            var movimientoDAC = new MovimientoDAC();
            result = movimientoDAC.Read();
            return result;
        }

        public override Movimiento ReadBy(int id)
        {
            Movimiento result = default(Movimiento);
            var movimientoDAC = new MovimientoDAC();
            result = movimientoDAC.ReadBy(id);
            return result;
        }

        public override void Update(Movimiento objeto)
        {
            var movimientoDAC = new MovimientoDAC();
            movimientoDAC.Update(objeto);
        }
    }
}
