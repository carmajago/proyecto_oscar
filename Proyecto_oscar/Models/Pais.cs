using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Proyecto_oscar.Models
{
    public class Pais
    {  [Key]
        public int paidID { get; set; }
        [Required(ErrorMessage ="Se requiere el nombre")]
        public string nombre { get; set; }

        public List<Ciudad> ciudad { get; set; }

    }
}