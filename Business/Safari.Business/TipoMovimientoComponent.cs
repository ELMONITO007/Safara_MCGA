using Safari.Data;
using Safari.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Safari.Business
{
    public class TipoMovimientoComponent : Component<TipoMovimiento>
    {
        public override TipoMovimiento Create(TipoMovimiento objeto)
        {
            TipoMovimiento result = default(TipoMovimiento);
            var tipoMoviemtoDAC = new TipoMovimientoDAC();

            result = tipoMoviemtoDAC.Create(objeto);
            return result;
        }

        public override void Delete(int id)
        {
            var tipoMoviemtoDAC = new TipoMovimientoDAC();
            tipoMoviemtoDAC.Delete(id);
        }

        public override List<TipoMovimiento> Read()
        {
            List<TipoMovimiento> result = default(List<TipoMovimiento>);

            var tipoMovimientoDAC = new TipoMovimientoDAC();
            result = tipoMovimientoDAC.Read();
            return result;
        }

        public override TipoMovimiento ReadBy(int id)
        {
            TipoMovimiento result = default(TipoMovimiento);
            var tipoMovimientoDAC = new TipoMovimientoDAC();
            result = tipoMovimientoDAC.ReadBy(id);
            return result;
        }

        public override void Update(TipoMovimiento objeto)
        {
            var tipoMovimientoDAC = new TipoMovimientoDAC();
            tipoMovimientoDAC.Update(objeto);
        }
    }
}
