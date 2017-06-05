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
    public class LisaaLaiteController : Controller
    {
        private WarehouseDBEntities db = new WarehouseDBEntities();

        // GET: LisaaLaite
        public ActionResult Index()
        {
            return View(db.Laitteet.ToList());
        }

        // GET: LisaaLaite/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Laitteet laitteet = db.Laitteet.Find(id);
            if (laitteet == null)
            {
                return HttpNotFound();
            }
            return View(laitteet);
        }

        // GET: LisaaLaite/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: LisaaLaite/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "DeviceId,WarrantyId,Make,Model,SN,Condition,DeviceType,AddInfo,PurcDate,WarrEndDate,PurchPrize")] Laitteet laitteet)
        {
            if (ModelState.IsValid)
            {
                db.Laitteet.Add(laitteet);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(laitteet);
        }

        // GET: LisaaLaite/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Laitteet laitteet = db.Laitteet.Find(id);
            if (laitteet == null)
            {
                return HttpNotFound();
            }
            return View(laitteet);
        }

        // POST: LisaaLaite/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "DeviceId,WarrantyId,Make,Model,SN,Condition,DeviceType,AddInfo,PurcDate,WarrEndDate,PurchPrize")] Laitteet laitteet)
        {
            if (ModelState.IsValid)
            {
                db.Entry(laitteet).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(laitteet);
        }

        // GET: LisaaLaite/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Laitteet laitteet = db.Laitteet.Find(id);
            if (laitteet == null)
            {
                return HttpNotFound();
            }
            return View(laitteet);
        }

        // POST: LisaaLaite/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Laitteet laitteet = db.Laitteet.Find(id);
            db.Laitteet.Remove(laitteet);
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
