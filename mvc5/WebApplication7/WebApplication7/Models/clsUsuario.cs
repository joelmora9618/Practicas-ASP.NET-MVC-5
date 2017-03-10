using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication7.Models
{
    public class clsUsuario
    {
        [Required(ErrorMessage = "Por favor, ingrese su nombre de usuario")]
        public double login { get; set; }
        [Required(ErrorMessage = "Por favor, ingrese su clave")]
        public double clave { get; set; }
    }
}