using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.Serialization;
namespace Safari.Entities
{
    [Serializable]
    [DataContract]
    public class Movimiento : EntityBase
    {
        [DataMember]
        [DisplayName("Fecha")]
        public DateTime Fecha { get; set; }

        [DataMember]
        [DisplayName("Cliente")]
        public int Cliente { get; set; }

        [DataMember]
        [DisplayName("Tipo de Movimiento")]
        public int tipoMovimiento { get; set; }

        [DataMember]
        [DisplayName("Valor")]
        public int valor { get; set; }

        [DataMember]
        [DisplayName("ID")]
        public override int Id { get; set; }
    }
}
