using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Proyecto_oscar.Models
{
    public class Servicios
    {
        [Key]
        public int servicioID { get; set; }
        [Required(ErrorMessage ="Se requiere el nombre")]
        public string nombre { get; set; }
        public double valor_min { get; set; }
        public double  valor_max { get; set; }
        [ForeignKey("categorias")]
        public int categoriaFK { get; set; }
        public virtual Categoria categorias { get; set; }
    }
}