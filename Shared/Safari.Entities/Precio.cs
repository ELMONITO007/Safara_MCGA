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
    public  class Precio :EntityBase
    {
        int _tipoServicioID;
        public DateTime _fechaDesde;
        public DateTime _fechaHasta;
        public int _valor;
        [Required]
        [DataMember]
        [DisplayName("Valor")]
        public int valor
        {
            get { return _valor; }
            set
            {
                _valor = value;
                NotifyPropertyChanged("valor");
            }
        }
        [DataMember]
        [DisplayName("Tipo de servicio")]
        
        public int tipoServicioID
    {
            get { return _tipoServicioID; }
            set
            {
                _tipoServicioID = value;
                NotifyPropertyChanged("Tipo de servicio");
            }
        }
        [Required]
        [DataMember]
        [DisplayName("Desde")]
        [DataType(DataType.DateTime, ErrorMessage = "Ingrese texto")]
        public DateTime fechaDesde
        {
            get { return _fechaDesde; }
            set
            {
                _fechaDesde = value;
                NotifyPropertyChanged("Desde");
            }
        }
        [Required]
        [DataMember]
        [DataType(DataType.DateTime, ErrorMessage = "Ingrese texto")]
        [DisplayName("Hasta")]

        public DateTime fechaHasta
        {
            get { return _fechaHasta; }
            set
            {
                _fechaHasta = value;
                NotifyPropertyChanged("Hasta");
            }
        }

                      
       

       
        [DataMember]
        [DisplayName("ID")]
        public override int Id { get; set; }

    }
}
