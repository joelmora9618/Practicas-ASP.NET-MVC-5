using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication5.Models;

namespace WebApplication5.Controllers
{
    public class PersonaController : Controller
    {
        // GET: Persona
        public ActionResult Index()
        {
            List<Persona> personas = new List<Persona>();

            Persona persona1 = new Persona();
            persona1.nombre = "joel";
            persona1.apellido = "mora";
            persona1.edad = 20;
            persona1.dni = 39715645;
            personas.Add(persona1);

            Persona persona2 = new Persona();
            persona2.nombre = "alan";
            persona2.apellido = "mora";
            persona2.edad = 20;
            persona2.dni = 39715645;
            personas.Add(persona2);

            Persona persona3 = new Persona();
            persona3.nombre = "emanuel";
            persona3.apellido = "mora";
            persona3.edad = 20;
            persona3.dni = 39715645;
            personas.Add(persona3);

            return View(personas);
        }
    }
}