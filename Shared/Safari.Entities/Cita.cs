using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace Safari.Entities
{
    public class Cita : EntityBase
    {
        [DisplayName("Fecha de la cita")]
        public DateTime fecha { get; set; }

        [DisplayName("Medico")]
        public Medico medico { get; set; }

        [DisplayName("Paciente")]
        public Paciente Paciente { get; set; }

        [DisplayName("Sala")]
        public Sala sala { get; set; }

        [DisplayName("Tipo de servicio")]
        public TipoServicio tipoServicio { get; set; }

        [DisplayName("Estado")]
        public string estado { get; set; }

        public int createBy { get; set; }
        public DateTime createDate { get; set; }

        public int changeBy { get; set; }
        public DateTime changeDate { get; set; }

        public int deleteBy { get; set; }
        public DateTime deleteDate { get; set; }


        public int delete { get; set; }


        public override int Id { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
