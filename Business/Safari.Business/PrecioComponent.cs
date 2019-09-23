using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Safari.Data;
using Safari.Entities;


namespace Safari.Business
{
    public class PrecioComponent : Component<Precio>
    {
        public override Precio Create(Precio objeto)
        {

            Precio result = default(Precio);
            var precioeDAC = new PrecioDAC();

            result = precioeDAC.Create(objeto);
            return result;
        }

        public override void Delete(int id)
        {
            var precioeDAC = new PrecioDAC();
            precioeDAC.Delete(id);
        }

        public override List<Precio> Read()
        {

            List<Precio> result = default(List<Precio>);

            var precioeDAC = new PrecioDAC();
            result = precioeDAC.Read();
            return result;
        }

        public override Precio ReadBy(int id)
        {
            Precio result = default(Precio);
            var precioeDAC = new PrecioDAC();
            result = precioeDAC.ReadBy(id);
            return result;
        }

        public override void Update(Precio objeto)
        {
            var precioeDAC = new PrecioDAC();
            precioeDAC.Update(objeto);
        }
    }
}
