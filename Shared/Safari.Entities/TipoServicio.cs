﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Safari.Entities
{
    public class TipoServicio : EntityBase
    {
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

       


        [DisplayName("Nombre")]
        [Required]
        public string Nombre { get; set; }
    }
}
