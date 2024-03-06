using AgenziaSpedizioni.Dati;
using AgenziaSpedizioni.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AgenziaSpedizioni.Controllers
{
    public class UtentiController : Controller
    {
        private MyDbContext db = new MyDbContext();

        public ActionResult Index()
        {
            var utenti = db.Utenti.ToList();
            return View(utenti);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Utente utente)
        {
            if (ModelState.IsValid)
            {
                db.Utenti.Add(utente);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(utente);
        }

        public ActionResult Edit(int id)
        {
            var utente = db.Utenti.Find(id);
            if (utente == null)
            {
                return HttpNotFound();
            }
            return View(utente);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Utente utente)
        {
            if (ModelState.IsValid)
            {
                db.Entry(utente).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(utente);
        }

        public ActionResult Delete(int id)
        {
            var utente = db.Utenti.Find(id);
            if (utente == null)
            {
                return HttpNotFound();
            }
            return View(utente);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Utente utente = db.Utenti.Find(id);
            db.Utenti.Remove(utente);
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