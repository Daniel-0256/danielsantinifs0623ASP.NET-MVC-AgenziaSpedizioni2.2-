using AgenziaSpedizioni.Dati;
using AgenziaSpedizioni.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace AgenziaSpedizioni.Controllers
{
    public class SpedizioniController : Controller
    {
        private MyDbContext db = new MyDbContext();

        // GET: Spedizioni
        public ActionResult Index()
        {
            return View(db.Spedizioni.ToList());
        }

        // GET: Spedizioni/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Spedizione spedizione = db.Spedizioni.Find(id);
            if (spedizione == null)
            {
                return HttpNotFound();
            }
            return View(spedizione);
        }

        // GET: Spedizioni/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Spedizioni/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "IDSpedizione,DataSpedizione,Peso,CittaDestinataria,IndirizzoDestinatario,NomeDestinatario,CostoSpedizione,DataConsegnaPrevista")] Spedizione spedizione)
        {
            if (ModelState.IsValid)
            {
                db.Spedizioni.Add(spedizione);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(spedizione);
        }

        // GET: Spedizioni/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Spedizione spedizione = db.Spedizioni.Find(id);
            if (spedizione == null)
            {
                return HttpNotFound();
            }
            return View(spedizione);
        }

        // POST: Spedizioni/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "IDSpedizione,DataSpedizione,Peso,CittaDestinataria,IndirizzoDestinatario,NomeDestinatario,CostoSpedizione,DataConsegnaPrevista")] Spedizione spedizione)
        {
            if (ModelState.IsValid)
            {
                db.Entry(spedizione).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(spedizione);
        }

        // GET: Spedizioni/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Spedizione spedizione = db.Spedizioni.Find(id);
            if (spedizione == null)
            {
                return HttpNotFound();
            }
            return View(spedizione);
        }

        // POST: Spedizioni/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Spedizione spedizione = db.Spedizioni.Find(id);
            db.Spedizioni.Remove(spedizione);
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