using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Safari.Entities
{
    public class Paciente : EntityBase
    {
        [DisplayName("Cliente")]
        public Cliente cliente { get; set; }
        [DisplayName("Especie")]
        public Especie Especie { get; set; }

        [DisplayName("Nombre")]
        public string nombre { get; set; }

        [DisplayName("Fecha Naciomiento")]
        public DateTime fechaNacimiento { get; set; }

        [DisplayName("Observacion")]
        public string observacion { get; set; }

      [DisplayName("Id")]
        public override int Id { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}

