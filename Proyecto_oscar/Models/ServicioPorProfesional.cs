using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Proyecto_oscar.Models
{
    public class ServicioPorProfesional
    {
        public int servicioFK { get; set; }
        public int profesionalFK { get; set; }
        public float valor_servicio { get; set; }

    }
}