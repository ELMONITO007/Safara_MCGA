using Safari.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Safari.Services.Contracts
{
    [DataContract]
    public   class ClienteResponse
    {
        [DataMember]
        public List<Entities.Cliente> obtenerTodos { get; set; }

        [DataMember]
        public Cliente obtenerUno { get; set; }

        [DataMember]
        public Cliente agregar { get; set; }
    }
}
