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
    public partial class EspecieResponse
    {
        [DataMember]
        public List<Entities.Especie> obtenerTodos { get; set; }

        [DataMember]
        public Especie obtenerUno { get; set; }

        [DataMember]
        public Especie agregar { get; set; }
    }
}
