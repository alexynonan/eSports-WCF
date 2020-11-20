using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WebMVC_eSport.Models;

namespace WebMVC_eSport.Controllers
{
    public class EQUIPOesController : Controller
    {
        private eSportsEntities db = new eSportsEntities();

        // GET: EQUIPOes
        public ActionResult Index()
        {
            return View(db.EQUIPO.ToList());
        }

        // GET: EQUIPOes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EQUIPO eQUIPO = db.EQUIPO.Find(id);
            if (eQUIPO == null)
            {
                return HttpNotFound();
            }
            return View(eQUIPO);
        }

        // GET: EQUIPOes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: EQUIPOes/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "IdEquipo,NomEquipo,PaisEquipo")] EQUIPO eQUIPO)
        {
            if (ModelState.IsValid)
            {
                eQUIPO.IdEquipo = 0;
                db.EQUIPO.Add(eQUIPO);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(eQUIPO);
        }

        // GET: EQUIPOes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EQUIPO eQUIPO = db.EQUIPO.Find(id);
            if (eQUIPO == null)
            {
                return HttpNotFound();
            }
            return View(eQUIPO);
        }

        // POST: EQUIPOes/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "IdEquipo,NomEquipo,PaisEquipo")] EQUIPO eQUIPO)
        {
            if (ModelState.IsValid)
            {
                db.Entry(eQUIPO).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(eQUIPO);
        }

        // GET: EQUIPOes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EQUIPO eQUIPO = db.EQUIPO.Find(id);
            if (eQUIPO == null)
            {
                return HttpNotFound();
            }
            return View(eQUIPO);
        }

        // POST: EQUIPOes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            EQUIPO eQUIPO = db.EQUIPO.Find(id);
            db.EQUIPO.Remove(eQUIPO);
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
