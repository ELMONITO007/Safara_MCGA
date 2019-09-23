using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Safari.Entities
{
 public  class Precio :EntityBase
    {
        [DisplayName("Tipo de servicio")]
        public TipoServicio tipoServicio { get; set; }
        [DisplayName("Desde")]
        public DateTime fechaDesde { get; set; }
        [DisplayName("Hasta")]
        public DateTime fechaHasta { get; set; }

        [DisplayName("Valor")]
        public int valor { get; set; }
        [DisplayName("ID")]
        public override int Id { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
