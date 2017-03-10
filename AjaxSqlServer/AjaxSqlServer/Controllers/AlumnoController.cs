using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AjaxSqlServer.Models;

namespace AjaxSqlServer.Controllers
{
    public class AlumnoController : Controller
    {
        practica7Entities entidad = new practica7Entities();

        // GET: Alumno
        public ActionResult Index()
        {
            return View();
        }
    
        [HttpPost]
        public PartialViewResult ShowDetails()
        {
            System.Threading.Thread.Sleep(500);
            string S_dni = Request.Form["txtCode"];
            int dni = Int32.Parse(S_dni);
            alumno alumno = new alumno();
            foreach (alumno a in entidad.alumno)
            {
                if (a.dni_alumno.Equals(dni))
                {
                    alumno = a;
                    break;
                }
            }
            return PartialView("_ShowDetails", alumno);
        }
    }
}