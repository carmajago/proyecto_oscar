using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Proyecto_oscar.Models
{
    public class Profesionales
    {
        public int cedulaID { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public string contrasena { get; set; }
        public bool sexo { get; set; }
        public string rol { get; set; }
        public int celular { get; set; }
        public string codigo_profesional { get; set; }
        public string estado { get; set;}

    }
}