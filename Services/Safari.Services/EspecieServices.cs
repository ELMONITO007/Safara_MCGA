﻿using Safari.Business;
using Safari.Entities;
using Safari.Services.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Safari.Services
{
    public class EspecieServices : IEspecieService
    {
        public Especie Create(Especie objeto)
        {
            var bc = new EspecieComponent();
            return bc.Create(objeto);
        }

        public void Delete(int id)
        {
            var bc = new EspecieComponent();
         
        }

        public List<Especie> Read()
        {
            var bc = new EspecieComponent();
            return bc.Read();
        }

        public Especie ReadBy(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Especie objeto)
        {
            throw new NotImplementedException();
        }
    }
}
