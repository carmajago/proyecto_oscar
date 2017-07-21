using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Security;

namespace Proyecto_oscar.Models
{
    public class Profesionales
    {  
        [Key]
        public int cedulaID { get; set; }
        [Required(ErrorMessage ="Se requiere el nombre")]
        public string nombre { get; set; }
        public string apellido { get; set; }
        [MembershipPassword(
         MinRequiredPasswordLength = 8, ErrorMessage = "su contraseña necesita minimo 8 caracteres")]
        public string contrasena { get; set; }
        public genero sexo { get; set; }
        public string rol { get; set; }
        public int celular { get; set; }
        public string codigo_profesional { get; set; }
        public string estado { get; set;}


        public enum  genero { Masculino,Femenino};
    }
}