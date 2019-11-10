using Safari.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace Safari.Entities
{
    [Serializable]
    [DataContract]
    public class Cliente : EntityBase

    {

        [DataMember]
        [DisplayName("Nombre")]
        [Required]
        public string Nombre { get; set; }

        [DataMember]
        [DisplayName("Apellido")]
        [Required]
        public string Apellido { get; set; }
        [DataMember]
        [DisplayName("Correo Electronico")]
        [Required]
        public string Email { get; set; }

        [DataMember]
        [DisplayName("Número de teléfono")]
        [Required]
        public string Telefono { get; set; }
        [DataMember]
        [DisplayName("Página Web")]
        public string Url { get; set; }
        [DataMember]
        [DisplayName("Fecha de Nacimiento")]
        [Required]
        public DateTime FechaNacimiento { get; set; }
        [DataMember]
        [DisplayName("Domicilio")]

        public string Domicilio { get; set; }
        [DataMember]
        [DisplayName("Id")]
        public override int Id { get; set; }
    }
    
}
