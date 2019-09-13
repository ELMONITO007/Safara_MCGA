using Safari.Data;
using Safari.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Safari.Business
{
    public class ClienteComponent : Component<Cliente>
    {
        public override Cliente Create(Cliente objeto)
        {
            Cliente result = default(Cliente);
            var clienteDAC = new ClienteDAC();

            result = clienteDAC.Create(objeto);
            return result;
        }

        public override void Delete(int id)
        {
            var clienteDAC = new ClienteDAC();
            clienteDAC.Delete(id);
        }

        public override List<Cliente> Read()
        {
            List<Cliente> result = default(List<Cliente>);

            var clienteDAC = new ClienteDAC();
            result = clienteDAC.Read();
            return result;
        }

        public override Cliente ReadBy(int id)
        {
            Cliente result = default(Cliente);
            var clienteDAC = new ClienteDAC();
            result = clienteDAC.ReadBy(id);
            return result;
        }

        public override void Update(Cliente objeto)
        {
            var clienteDAC = new ClienteDAC();
            clienteDAC.Update(objeto);
        }
    }
}
