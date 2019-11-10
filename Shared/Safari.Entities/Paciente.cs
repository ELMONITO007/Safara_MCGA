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
    public class Paciente : EntityBase
    {
        [DataMember]
        [DisplayName("Cliente")]
        public int cliente { get; set; }

        [DataMember]
        [DisplayName("Especie")]
        public int Especie { get; set; }

        [DataMember]
        [DisplayName("Nombre")]
        public string nombre { get; set; }

        [DataMember]
        [DisplayName("Fecha Naciomiento")]
        public DateTime fechaNacimiento { get; set; }

        [DataMember]
        [DisplayName("Observacion")]
        public string observacion { get; set; }

        [DataMember]
        [DisplayName("Id")]
        public override int Id { get; set; }
    }
}

