using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Proyecto_oscar.Models
{
    public class ServicioPorProfesional
    {
        [ForeignKey("servicio")]
        public int servicioFK { get; set; }
        [ForeignKey("profesional")]
        public int profesionalFK { get; set; }
        public float valor_servicio { get; set; }

        public virtual Profesionales profesional { get; set; }
        public virtual Servicios servicio { get; set; }
        
    }
}