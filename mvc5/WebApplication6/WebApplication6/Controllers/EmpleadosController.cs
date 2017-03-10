using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication6.Models;

namespace WebApplication6.Controllers
{
    public class EmpleadosController : Controller
    {
        practica6Entities entidad = new practica6Entities();
        // GET: Empleados
        public ActionResult Index()
        {
            var listaEmpleados = entidad.persona;
            return View(listaEmpleados.ToList());
        }
        public ActionResult listaCargos()
        {
            var listaCargos = entidad.cargo;
            return View(listaCargos.ToList());
        }
    }
}
