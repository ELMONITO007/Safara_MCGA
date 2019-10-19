using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Safari.Entities
{
    public class Medico : EntityBase
    {



        [DisplayName("Tipo de Matricula")]
        [DataType(DataType.Text, ErrorMessage = "Ingrese texto")]
        [Required]
        public string TipoMatricula { get; set; }



        [DisplayName("Numero de Matricula")]
        [Range(0, int.MaxValue, ErrorMessage = "Ingrese un numero")]
        [Required]
        public int NumeroMatricula { get; set; }




        [DisplayName("Nombre")]
        [Required]
        [DataType(DataType.Text, ErrorMessage = "Ingrese texto")]
        public string Nombre { get; set; }




        [DisplayName("Apellido")]
        [DataType(DataType.Text, ErrorMessage = "Ingrese texto")]
        [Required]
        public string Apellido { get; set; }


        [DisplayName("Correo Electronico")]
        [Required]
        [EmailAddress(ErrorMessage = "Ingrese un correo valido")]
        public string Email { get; set; }



        [DisplayName("Número de teléfono")]
        [Required]
        [Range(0, int.MaxValue, ErrorMessage = "Ingrese un numero")]
        public string Telefono { get; set; }


        [DisplayName("Especialidad")]
        [DataType(DataType.Text, ErrorMessage = "Ingrese texto")]
        public string Especialidad { get; set; }


        [DisplayName("Fecha de Nacimiento")]
        [Required]
        [DataType(DataType.Date, ErrorMessage = "Ingrese una fecha")]
        public DateTime FechaNacimiento { get; set; }

        [DisplayName("Id")]
        public override int Id { get; set; }
    }
    
}
