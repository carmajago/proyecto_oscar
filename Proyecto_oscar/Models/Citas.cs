using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Proyecto_oscar.Models
{
    public class Citas
    {
        public long citaID { get; set; }
        public int cedula_clienteFK { get; set; }
        public int cedula_profesionaFK { get; set; }
        public int servicioFK { get; set; }
        public DateTime fecha { get; set; }
        public float valor_cita { get; set; }
        public string historial_clinico { get; set; }

    }
}