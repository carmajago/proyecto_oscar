using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Proyecto_oscar.Models
{
    public class Clientes
    {
        public int cedulaID { get; set; }
        public string nombre { get; set; }
        public int celular { get; set; }
        public string contrasena { get; set; }
        public string ciudadFK { get; set; }

    }
}