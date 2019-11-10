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
 public   class PacienteResponse
    {
        [DataMember]
        public List<Paciente> obtenerTodos { get; set; }
        [DataMember]
        public Paciente obtenerUno { get; set; }
    }
}
