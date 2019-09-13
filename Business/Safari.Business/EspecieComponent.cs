using Safari.Data;
using Safari.Entities;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;


namespace Safari.Business
{
    public class EspecieComponent : Component<Especie>
    {
        public override Especie Create(Especie objeto)
        {
            Especie result = default(Especie);
            var especieDAC = new EspecieDAC();

            result = especieDAC.Create(objeto);
            return result;
        }

        public override void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public override List<Especie> Read()
        {
            throw new NotImplementedException();
        }

        public override Especie ReadBy(int id)
        {
            throw new NotImplementedException();
        }

        public override void Update(Especie objeto)
        {
            throw new NotImplementedException();
        }
    }
}
