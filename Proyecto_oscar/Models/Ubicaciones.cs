using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Proyecto_oscar.Models
{
    public class Ubicaciones
    {
        [ForeignKey("cliente")]
        public int clienteFk { get; set;}
        public string ubicacion { get; set; }

        public virtual Clientes cliente { get; set; }
    }
}