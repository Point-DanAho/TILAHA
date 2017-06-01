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
    public class SijaintisController : Controller
    {
        private WarehouseDBEntities db = new WarehouseDBEntities();

        // GET: Sijaintis
        public ActionResult Index()
        {
            return View(db.Sijainti.ToList());
        }

        // GET: Sijaintis/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Sijainti sijainti = db.Sijainti.Find(id);
            if (sijainti == null)
            {
                return HttpNotFound();
            }
            return View(sijainti);
        }

        // GET: Sijaintis/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Sijaintis/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "DeviceId,Building,Space,Locker,Shelf,Status")] Sijainti sijainti)
        {
            if (ModelState.IsValid)
            {
                db.Sijainti.Add(sijainti);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(sijainti);
        }

        // GET: Sijaintis/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Sijainti sijainti = db.Sijainti.Find(id);
            if (sijainti == null)
            {
                return HttpNotFound();
            }
            return View(sijainti);
        }

        // POST: Sijaintis/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "DeviceId,Building,Space,Locker,Shelf,Status")] Sijainti sijainti)
        {
            if (ModelState.IsValid)
            {
                db.Entry(sijainti).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(sijainti);
        }

        // GET: Sijaintis/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Sijainti sijainti = db.Sijainti.Find(id);
            if (sijainti == null)
            {
                return HttpNotFound();
            }
            return View(sijainti);
        }

        // POST: Sijaintis/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Sijainti sijainti = db.Sijainti.Find(id);
            db.Sijainti.Remove(sijainti);
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
