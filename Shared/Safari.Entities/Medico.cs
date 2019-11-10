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
    public class Medico : EntityBase
    {


        [DataMember]
        [DisplayName("Tipo de Matricula")]
        [DataType(DataType.Text, ErrorMessage = "Ingrese texto")]
        [Required]
        public string TipoMatricula { get; set; }


        [DataMember]
        [DisplayName("Numero de Matricula")]
        [Range(0, int.MaxValue, ErrorMessage = "Ingrese un numero")]
        [Required]
        public int NumeroMatricula { get; set; }



        [DataMember]
        [DisplayName("Nombre")]
        [Required]
        [DataType(DataType.Text, ErrorMessage = "Ingrese texto")]
        public string Nombre { get; set; }



        [DataMember]
        [DisplayName("Apellido")]
        [DataType(DataType.Text, ErrorMessage = "Ingrese texto")]
        [Required]
        public string Apellido { get; set; }

        [DataMember]
        [DisplayName("Correo Electronico")]
        [Required]
        [EmailAddress(ErrorMessage = "Ingrese un correo valido")]
        public string Email { get; set; }


        [DataMember]
        [DisplayName("Número de teléfono")]
        [Required]
        [Range(0, int.MaxValue, ErrorMessage = "Ingrese un numero")]
        public string Telefono { get; set; }

        [DataMember]
        [DisplayName("Especialidad")]
        [DataType(DataType.Text, ErrorMessage = "Ingrese texto")]
        public string Especialidad { get; set; }
        [DataMember]

        [DisplayName("Fecha de Nacimiento")]
        [Required]
        [DataType(DataType.Date, ErrorMessage = "Ingrese una fecha")]
        public DateTime FechaNacimiento { get; set; }

        [DataMember]
        [DisplayName("Id")]
        public override int Id { get; set; }
    }
    
}
