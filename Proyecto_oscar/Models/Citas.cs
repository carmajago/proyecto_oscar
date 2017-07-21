using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Proyecto_oscar.Models
{
    public class Citas
    {   [Key]
        public long citaID { get; set; }
        [ForeignKey("clientes")]
        public int cedula_clienteFK { get; set; }
        [ForeignKey("servicioporprofecional")]
        public int cedula_profesionaFK { get; set; }
        [ForeignKey("servicio")]
        public int servicioFK { get; set; }
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime fecha { get; set; }
        public double valor_cita { get; set; }
        public string historial_clinico { get; set; }
        public virtual ServicioPorProfesional servicioporprofesional { get; set; }
        public virtual Clientes clientes { get; set; }
        public virtual Clientes servicio { get; set; }
    }
}