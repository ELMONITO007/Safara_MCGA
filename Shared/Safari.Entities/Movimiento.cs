using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
namespace Safari.Entities
{
    public class Movimiento : EntityBase
    {

        [DisplayName("Fecha")]
        public DateTime Fecha { get; set; }


        [DisplayName("Cliente")]
        public Cliente Cliente { get; set; }


        [DisplayName("Tipo de Movimiento")]
        public TipoMovimiento tipoMovimiento { get; set; }


        [DisplayName("Valor")]
        public int valor { get; set; }


        [DisplayName("ID")]
        public override int Id { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
