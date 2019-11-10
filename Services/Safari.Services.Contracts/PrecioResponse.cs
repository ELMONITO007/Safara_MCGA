﻿using Safari.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Safari.Services.Contracts
{
    [DataContract]
   public partial class PrecioResponse
    {
        [DataMember]
        public List<Precio> obtenerTodos { get; set; }
        [DataMember]
        public Precio obtenerUno { get; set; }
    }
}