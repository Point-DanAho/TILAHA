using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using TILAHA.Controllers.Models;

namespace TILAHA.Controllers
{
    public class PoistaController : Controller
    {
        private LaitekantaEntities db = new LaitekantaEntities();

        // GET: Poista
        public ActionResult Index()
        {
            return View(db.Laite.ToList());
        }

     /*   // GET: Poista/Details/5       ///// Tätä ei tarvita poista-kohdassa.
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Laite laite = db.Laite.Find(id);
            if (laite == null)
            {
                return HttpNotFound();
            }
            return View(laite); 
        } */

     /*   // GET: Poista/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Poista/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "DeviceId,AccId,Model,Type,SN,Cond,DeviceType,AddInfo,PurcDate,WarrEndDate,PurchPrize")] Laite laite)
        {
            if (ModelState.IsValid)
            {
                db.Laite.Add(laite);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(laite);
        } */

      /*  // GET: Poista/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Laite laite = db.Laite.Find(id);
            if (laite == null)
            {
                return HttpNotFound();
            }
            return View(laite);
        }

        // POST: Poista/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "DeviceId,AccId,Model,Type,SN,Cond,DeviceType,AddInfo,PurcDate,WarrEndDate,PurchPrize")] Laite laite)
        {
            if (ModelState.IsValid)
            {
                db.Entry(laite).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(laite);
        } */

        // GET: Poista/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Laite laite = db.Laite.Find(id);
            if (laite == null)
            {
                return HttpNotFound();
            }
            return View(laite);
        }

        // POST: Poista/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Laite laite = db.Laite.Find(id);
            db.Laite.Remove(laite);
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
