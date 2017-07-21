using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Proyecto_oscar.Models
{
    public class Ciudad
    {
        [Key]
        public int ciudadID { get; set; }
        [Required(ErrorMessage ="Se requiere el nombre")]
        public string nombre { get; set; }
        [ForeignKey("pais")]
        public int paisFK { get; set;}

        public virtual Pais pais { get; set;}
    }
}