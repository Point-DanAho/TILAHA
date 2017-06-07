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
    public class VarustesController : Controller
    {
        private WarehouseDBEntities db = new WarehouseDBEntities();

        // GET: Varustes
        public ActionResult Index()
        {
            return View(db.Varuste.ToList());
        }

        // GET: Varustes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Varuste varuste = db.Varuste.Find(id);
            if (varuste == null)
            {
                return HttpNotFound();
            }
            return View(varuste);
        }

        // GET: Varustes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Varustes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "AccId,DeviceID,Varusteet")] Varuste varuste)
        {
            if (ModelState.IsValid)
            {
                db.Varuste.Add(varuste);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(varuste);
        }

        // GET: Varustes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Varuste varuste = db.Varuste.Find(id);
            if (varuste == null)
            {
                return HttpNotFound();
            }
            return View(varuste);
        }

        // POST: Varustes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "AccId,DeviceID,Varusteet")] Varuste varuste)
        {
            if (ModelState.IsValid)
            {
                db.Entry(varuste).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(varuste);
        }

        // GET: Varustes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Varuste varuste = db.Varuste.Find(id);
            if (varuste == null)
            {
                return HttpNotFound();
            }
            return View(varuste);
        }

        // POST: Varustes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Varuste varuste = db.Varuste.Find(id);
            db.Varuste.Remove(varuste);
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
