using Safari.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Safari.Entities
{
    public class Cliente : EntityBase

    {
       

        [DisplayName("Nombre")]
        [Required]
        public string Nombre { get; set; }

        [DisplayName("Apellido")]
        [Required]
        public string Apellido { get; set; }
        [DisplayName("Correo Electronico")]
        [Required]
        public string Email { get; set; }

        [DisplayName("Número de teléfono")]
        [Required]
        public string Telefono { get; set; }
        [DisplayName("Página Web")]
        public string Url { get; set; }
        [DisplayName("Fecha de Nacimiento")]
        [Required]
        public DateTime FechaNacimiento { get; set; }
        [DisplayName("Domicilio")]

        public string Domicilio { get; set; }

        [DisplayName("Id")]
        public override int Id
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }
    }
}
