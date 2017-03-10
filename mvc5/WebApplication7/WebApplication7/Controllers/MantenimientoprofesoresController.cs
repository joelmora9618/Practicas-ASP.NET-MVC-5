using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WebApplication7.Models;

namespace WebApplication7.Controllers
{
    public class MantenimientoprofesoresController : Controller
    {
        private practica7Entities db = new practica7Entities();

        // GET: Mantenimientoprofesores
        public ActionResult Index()
        {
            var profesores = db.profesores.Include(p => p.curso).Include(p => p.materia);
            return View(profesores.ToList());
        }

        public ActionResult Formulario()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Formulario(clsUsuario usuario)
        {
           if(!ModelState.IsValid)
            {
                return View(usuario);
            }   
            else
            {
                   return RedirectToAction("Index", "Home");
            }
        }      
        
        public ActionResult usuario()
        {
            return View();
        }
        
        public ActionResult ListaCurso()
        {
            ViewData["Nombre"] = "Joel";
            ViewData["Facebook"] = "Joel Ezequiel Mora";
            var modelo = db.curso;
            return View(modelo.ToList());
        }

        public ActionResult ListaProfesoresCurso(String curso)
        {
            var modelo = from p in db.profesores where p.curso.divicion == curso select p;
            return View(modelo.ToList());
        }

        public ActionResult ListaDetalleMateriProfesor(int profesor)
        {
            var modelo = from p in db.materia where p.id_materia == profesor select p;
            return View(modelo.ToList());
        }

        // GET: Mantenimientoprofesores/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            profesores profesores = db.profesores.Find(id);
            if (profesores == null)
            {
                return HttpNotFound();
            }
            return View(profesores);
        }

        // GET: Mantenimientoprofesores/Create
        public ActionResult Create()
        {
            ViewBag.divicion = new SelectList(db.curso, "divicion", "turno");
            ViewBag.id_materia = new SelectList(db.materia, "id_materia", "materia1");
            return View();
        }

        // POST: Mantenimientoprofesores/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "dni_profesor,nombre,apellido,edad,id_materia,divicion")] profesores profesores)
        {
            if (ModelState.IsValid)
            {
                db.profesores.Add(profesores);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.divicion = new SelectList(db.curso, "divicion", "turno", profesores.divicion);
            ViewBag.id_materia = new SelectList(db.materia, "id_materia", "materia1", profesores.id_materia);
            return View(profesores);
        }

        // GET: Mantenimientoprofesores/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            profesores profesores = db.profesores.Find(id);
            if (profesores == null)
            {
                return HttpNotFound();
            }
            ViewBag.divicion = new SelectList(db.curso, "divicion", "turno", profesores.divicion);
            ViewBag.id_materia = new SelectList(db.materia, "id_materia", "materia1", profesores.id_materia);
            return View(profesores);
        }

        // POST: Mantenimientoprofesores/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "dni_profesor,nombre,apellido,edad,id_materia,divicion")] profesores profesores)
        {
            if (ModelState.IsValid)
            {
                db.Entry(profesores).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.divicion = new SelectList(db.curso, "divicion", "turno", profesores.divicion);
            ViewBag.id_materia = new SelectList(db.materia, "id_materia", "materia1", profesores.id_materia);
            return View(profesores);
        }

        // GET: Mantenimientoprofesores/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            profesores profesores = db.profesores.Find(id);
            if (profesores == null)
            {
                return HttpNotFound();
            }
            return View(profesores);
        }

        // POST: Mantenimientoprofesores/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            profesores profesores = db.profesores.Find(id);
            db.profesores.Remove(profesores);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
