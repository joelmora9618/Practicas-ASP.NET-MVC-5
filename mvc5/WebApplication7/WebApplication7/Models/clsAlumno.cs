using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using WebApplication7.Validaciones;
using System.Web;

namespace WebApplication7.Models
{
    public class clsAlumno
    {
        [Required(ErrorMessage = "Por favor, ingrese su DNI")]
        [MaxLength(8, ErrorMessage = "Por favor, introduzca un n° de DNI valido")]
        public int dni_alumno { get; set; }
        [Required(ErrorMessage = "Por favor, ingrese su Nombre")]
        public String nombre { get; set; }
        [Required(ErrorMessage = "Por favor, ingrese su Apellido")]
        public String apellido { get; set; }
        [Required(ErrorMessage = "Por favor, ingrese su Edad")]
        public int edad { get; set; }
        [Required(ErrorMessage = "Por favor, ingrese su Sexo")]
        [SexoValidation(ErrorMessage = "Por favor, solo ingrese M O F")]
        public String sexo { get; set; }
        [Required(ErrorMessage = "Por favor, ingrese la Divicion")]
        public String divicion { get; set; }
        [Required(ErrorMessage = "Por favor, ingrese el Turno")]
        public String turno { get; set; }
    }
}