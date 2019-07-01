using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Livraria.Models;

namespace LivrariaFontana.Controllers
{
    public class LivrosController : Controller
    {
        private Contexto db = new Contexto();

        //
        // GET: /Livros/

        public ActionResult Index()
        {
            return View(db.Livros.ToList());
        }

        //
        // GET: /Livros/Details/5

        public ActionResult Details(string id = null)
        {
            Livros livros = db.Livros.Find(id);
            if (livros == null)
            {
                return HttpNotFound();
            }
            return View(livros);
        }

        //
        // GET: /Livros/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Livros/Create

        [HttpPost]
        public ActionResult Create(Livros livros)
        {
            if (ModelState.IsValid)
            {
                db.Livros.Add(livros);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(livros);
        }

        //
        // GET: /Livros/Edit/5

        public ActionResult Edit(string id = null)
        {
            Livros livros = db.Livros.Find(id);
            if (livros == null)
            {
                return HttpNotFound();
            }
            return View(livros);
        }

        //
        // POST: /Livros/Edit/5

        [HttpPost]
        public ActionResult Edit(Livros livros)
        {
            if (ModelState.IsValid)
            {
                db.Entry(livros).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(livros);
        }

        //
        // GET: /Livros/Delete/5

        public ActionResult Delete(string id = null)
        {
            Livros livros = db.Livros.Find(id);
            if (livros == null)
            {
                return HttpNotFound();
            }
            return View(livros);
        }

        //
        // POST: /Livros/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(string id)
        {
            Livros livros = db.Livros.Find(id);
            db.Livros.Remove(livros);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}