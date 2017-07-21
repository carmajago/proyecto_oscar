using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Proyecto_oscar.Models
{
    public class Categoria
    {
        [Key]
        public int categoriaID { get; set; }
        [Required(ErrorMessage ="Se requiere el nombre")]
        public string nombre { get; set; }

        public List<Servicios> servicios { get; set; }



    }
}