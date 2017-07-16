using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Proyecto_oscar.Models
{
    public class Ciudad
    {
        public int ciudadID { get; set; }
        public string nombre { get; set; }
        public int paisFK { get; set;}
    }
}