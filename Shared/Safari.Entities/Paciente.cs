using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
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
        [Required]
        [DataMember]
        [DataType(DataType.Text, ErrorMessage = "Ingrese texto")]
        [DisplayName("Nombre")]
        public string nombre { get; set; }
        [Required]
        [DataMember]
        [DataType(DataType.Date, ErrorMessage = "Ingrese texto")]
        [DisplayName("Fecha Nacimiento")]
        public DateTime fechaNacimiento { get; set; }

        [Required]
        [DataType(DataType.Text, ErrorMessage = "Ingrese texto")]
        [DataMember]
        [DisplayName("Observacion")]
        public string observacion { get; set; }
       
        [DataMember]
        [DisplayName("Id")]
        public override int Id { get; set; }
    }
}

