using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Proyecto_oscar.Models
{
    public class Servicios
    { public int servicioID { get; set; }
        public string tipo { get; set; }
        public float valor_min { get; set; }
        public float valor_max {get;set;}
        public int categoriaFK { get; set; }

    }
}