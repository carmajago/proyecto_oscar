using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Security;

namespace Proyecto_oscar.Models
{
    public class Administradores
    {   [Key]
        public int ID { get; set; }
        [Required(ErrorMessage ="Se requiere el nombre")]
        public string nombre { get; set; }
        public string apellido { get; set; }
        [MembershipPassword(
        MinRequiredPasswordLength = 8, ErrorMessage = "su contraseña necesita minimo 8 caracteres")]
        public string contrasena { get; set; }
        public permisos privilegios { get; set; }

        public enum permisos { Lectura,Escritura};
    }
}