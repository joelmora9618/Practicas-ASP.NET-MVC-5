using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication7.Models
{
    public class clsProfesor
    {
        public int dni_profesor { get; set; }
        public String nombre { get; set; }
        public String apellido { get; set; }
        public int edad { get; set; }
        public int id_materia { get; set; }
        public String divicion { get; set; }
    }
}