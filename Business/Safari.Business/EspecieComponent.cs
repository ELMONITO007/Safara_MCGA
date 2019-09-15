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
            var especieDAC = new EspecieDAC();
            especieDAC.Delete(id);
        }

        public override List<Especie> Read()
        {
            List<Especie> result = default(List<Especie>);

            var especieDAC = new EspecieDAC(); 
            result = especieDAC.Read();
            return result;
        }

        public override Especie ReadBy(int id)
        {
            Especie result = default(Especie);
            var especieDAC = new EspecieDAC();
            result = especieDAC.ReadBy(id);
            return result;

        }

        public override void Update(Especie objeto)
        {
            var especieDAC = new EspecieDAC();
            especieDAC.Update(objeto);
        }
    }
}
