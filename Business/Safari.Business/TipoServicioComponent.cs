using Safari.Data;
using Safari.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Safari.Business
{
    public class TipoServicioComponent : Component<TipoServicio>
    {
        public override TipoServicio Create(TipoServicio objeto)
        {
            TipoServicio result = default(TipoServicio);
            var tipoServicioDAC = new TipoServicioDAC();

            result = tipoServicioDAC.Create(objeto);
            return result;
        }

        public override void Delete(int id)
        {
            var tipoServicioDAC = new TipoServicioDAC();
            tipoServicioDAC.Delete(id);
        }

        public override List<TipoServicio> Read()
        {
            List<TipoServicio> result = default(List<TipoServicio>);

            var tipoServicioDAC = new TipoServicioDAC();
            result = tipoServicioDAC.Read();
            return result;
        }

        public override TipoServicio ReadBy(int id)
        {

            TipoServicio result = default(TipoServicio);
            var tipoServicioDAC = new TipoServicioDAC();
            result = tipoServicioDAC.ReadBy(id);
            return result;
        }

        public override void Update(TipoServicio objeto)
        {
            var tipoServicioDAC = new TipoServicioDAC();
            tipoServicioDAC.Update(objeto);
        }
    }
}
