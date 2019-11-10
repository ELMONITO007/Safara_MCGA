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
    public partial class SalaResponse
    {
        [DataMember]
        public List<Sala> obtenerTodos { get; set; }
        [DataMember]
        public Sala obtenerUno { get; set; }
    }
}
