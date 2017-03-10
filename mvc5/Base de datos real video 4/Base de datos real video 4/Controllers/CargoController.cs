using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Base_de_datos_real_video_4.Models;

namespace Base_de_datos_real_video_4.Controllers
{
    public class CargoController : Controller
    {

        db_escuelaEntities entidad = new db_escuelaEntities();
        // GET: Cargo
        public ActionResult Index()
        {
            var listaCargo = entidad.cargo;
            return View(listaCargo.ToList());
        }

        public ActionResult listaMaestraCargos()
        {
            var listaCargo = entidad.cargo;
            return View(listaCargo.ToList());
        }

        public ActionResult UsuarioxCargo(string cargo)
        {
            var modelo = from p in entidad.usuario where p.cargo.car_des == cargo select p;
            return View(modelo.ToList());
        }

        public ActionResult ListadoUsuarioDescripcionCargo()
        {
            var modelo = from p in entidad.usuario
                         join c in entidad.cargo
                         on p.car_cod equals c.car_cod

                         select new ElUsuario
                         {
                             codigo = p.usu_cod,
                             nombre = p.usu_nom,
                             cargo = c.car_des
                         };
            return View(modelo.ToList());
        }
    }
}