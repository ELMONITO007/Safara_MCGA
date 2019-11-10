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
    public class TipoMovimiento : EntityBase
    {


        [DataMember]
        [DisplayName("Nombre")]
        [Required]

        public string Nombre { get; set; }
        [DataMember]
        [DisplayName("Multiplicador")]
        [Required]
        public int Multiplador { get; set; }
        [DataMember]
        [DisplayName("Id")]
        public override int Id { get; set; }
    }
}
