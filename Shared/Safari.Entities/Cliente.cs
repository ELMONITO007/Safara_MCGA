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
        [DataType(DataType.Text, ErrorMessage = "Ingrese texto")]
        [Required]
        public string Nombre { get; set; }

        [DataMember]
        [DataType(DataType.Text, ErrorMessage = "Ingrese texto")]
        [DisplayName("Apellido")]
        [Required]
        public string Apellido { get; set; }
        [DataMember]
        [DataType(DataType.EmailAddress, ErrorMessage = "Ingrese texto")]
        [DisplayName("Correo Electronico")]
        [Required]
        public string Email { get; set; }

        [DataMember]
        [Range(0, int.MaxValue, ErrorMessage = "Ingrese un numero")]
        [DisplayName("Número de teléfono")]
        [Required]
        public string Telefono { get; set; }

        [DataMember]
        [DisplayName("Página Web")]
        [DataType(DataType.Url, ErrorMessage = "Ingrese un link")]
        public string Url { get; set; }
        [DataMember]
        [DataType(DataType.Date, ErrorMessage = "Ingrese texto")]
        [DisplayName("Fecha de Nacimiento")]
        [Required]


        public DateTime FechaNacimiento { get; set; }

        [DataType(DataType.EmailAddress, ErrorMessage = "Ingrese texto")]
        [DataMember]
        [DisplayName("Domicilio")]

        public string Domicilio { get; set; }
        [DataMember]
        [DisplayName("Id")]
        public override int Id { get; set; }
    }
    
}
