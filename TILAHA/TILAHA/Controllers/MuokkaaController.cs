﻿using System;
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
    public class MuokkaaController : Controller
    {
        private WarehouseDBEntities db = new WarehouseDBEntities();

        // GET: Muokkaa
        public ActionResult Index()
        {
            return View(db.Laitteet.ToList());
        }

        // GET: Muokkaa/Details/5
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

        // GET: Muokkaa/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Muokkaa/Create
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

        // GET: Muokkaa/Edit/5
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

        // POST: Muokkaa/Edit/5
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

        // GET: Muokkaa/Delete/5
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

        // POST: Muokkaa/Delete/5
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
