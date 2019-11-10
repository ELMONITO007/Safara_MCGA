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
    public class TipoMovimientoResponse
    {
        [DataMember]
        public List<TipoMovimiento> obtenerTodos { get; set; }
        [DataMember]
        public TipoMovimiento obtenerUno { get; set; }
    }
}
