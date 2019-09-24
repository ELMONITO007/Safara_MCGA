﻿using Safari.Entities;
using Safari.Services;
using Safari.Services.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Safari.UI.Process
{
    public class TipoServicioProcess : ProcessComponent, Process<TipoServicio>
    {
        public TipoServicio Agregar(TipoServicio objeto)
        {
            TipoServicio result = default(TipoServicio);
            ITipoServicio proxy = new TipoServicioServices();

            try
            {
                result = proxy.Create(objeto);
            }
            catch (FaultException fex)
            {
                throw new ApplicationException(fex.Message);
            }

            return result;
        }

        public TipoServicio Editar(int id, TipoServicio objeto)
        {
            TipoServicio result = default(TipoServicio);
            ITipoServicio proxy = new TipoServicioServices();

            try
            {
                proxy.Update(objeto);
                result = proxy.ReadBy(id);
            }
            catch (FaultException fex)
            {
                throw new ApplicationException(fex.Message);
            }

            return result;
        }

        public TipoServicio Eliminar(int id)
        {
            TipoServicio result = default(TipoServicio);
            ITipoServicio proxy = new TipoServicioServices();

            try
            {
                proxy.Delete(id);
            }
            catch (FaultException fex)
            {
                throw new ApplicationException(fex.Message);
            }

            return result;
        }

        public List<TipoServicio> ListarTodos()
        {
            List<TipoServicio> result = default(List<TipoServicio>);
            ITipoServicio proxy = new TipoServicioServices();


            try
            {
                result = proxy.Read();
            }
            catch (FaultException fex)
            {
                throw new ApplicationException(fex.Message);
            }
            return result;
        }

        public TipoServicio Ver(int id)
        {
            TipoServicio result = default(TipoServicio);
            ITipoServicio proxy = new TipoServicioServices();

            try
            {
                result = proxy.ReadBy(id);
            }
            catch (FaultException fex)
            {
                throw new ApplicationException(fex.Message);
            }

            return result;
        }
    }
}
