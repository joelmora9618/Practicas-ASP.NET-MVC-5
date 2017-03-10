using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication7.Models;

namespace WebApplication7.Controllers
{
    public class CursoController : Controller
    {
        practica7Entities entidad = new practica7Entities();
        // GET: Curso
        public ActionResult Index()
        {
            var listaCurso = entidad.curso;
            return View(listaCurso.ToList());
        }

        public ActionResult ListaMaestraCurso()
        {
            var listaCurso = entidad.curso;
            return View(listaCurso.ToList());
        }

        public ActionResult ListaCursoAlumno(String curso)
        {
            var modelo = from p in entidad.alumno where p.curso.divicion == curso select p;
            return View(modelo.ToList());
        }

        public ActionResult AgregarAlumno()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AgregarAlumno(clsAlumno alumno)
        {
            if(ModelState.IsValid)
            {
                if(ExisteAlumno(alumno.dni_alumno))
                {
                    ModelState.AddModelError("dni_alumno", "el usuario ingresado ya existe");
                }
            }

            if(!ModelState.IsValid)
            {
                return View(alumno);
            }
            else
            {
                return RedirectToAction("Index","Home");
            }
        }

        private bool ExisteAlumno (int dni)
        {
            bool existe = false;
            foreach(var alumno in entidad.alumno)
                if(dni.Equals(alumno.dni_alumno))
                {
                    existe = true;
                }
            return existe;
        }

        public ActionResult ListaProfesoresCurso(String profesor)
        {
            var modelo = from p in entidad.profesores where p.curso.divicion == profesor select p;
            
            return View(modelo.ToList());
        }

        public ActionResult ListaDetalleCursoAlumno(String curso)
        {
            var modelo = from p in entidad.alumno
                         join c in entidad.curso
                         on p.divicion equals c.divicion

                         select new clsAlumno
                         {
                             dni_alumno = p.dni_alumno,
                             nombre = p.nombre,
                             apellido = p.apellido,
                             edad = p.edad,
                             sexo = p.sexo,
                             divicion = c.divicion,
                             turno = c.turno
                             
                         };
            return View(modelo.ToList());

        }

    }
}