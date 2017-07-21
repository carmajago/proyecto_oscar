using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using System.Web.Security;

namespace Proyecto_oscar.Models
{
    public class Clientes
    {  [Key]
        public int cedulaID { get; set; }
        [Required(ErrorMessage = "Se requiere el nombre")]
        public string nombre { get; set; }
        [Required(ErrorMessage = "Se requiere el numero de celular")]
        public int celular { get; set; }
        [DataType(DataType.EmailAddress)]
        public string correo { get; set; }
        [MembershipPassword(
         MinRequiredPasswordLength = 8,ErrorMessage = "su contraseña necesita minimo 8 caracteres")]
        public string contrasena { get; set;}
        [ForeignKey("ciudad")]
        public string ciudadFK { get; set; }
        public virtual Ciudad ciudad { get; set; }
        public List<Ubicaciones> ubicaciones { get; set; }
    }
}