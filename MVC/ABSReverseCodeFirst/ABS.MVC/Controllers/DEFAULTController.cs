﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ABS.Data;
using ABS.Model;

namespace ABS.MVC.Controllers
{
    public class DEFAULTController : Controller
    {
        private BookingSystemDbContext db = new BookingSystemDbContext();

        // GET: Airlines
        public ActionResult Index()
        {
            return View(db.Airlines.ToList());
        }

        // GET: Airlines/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Airline airline = db.Airlines.Find(id);
            if (airline == null)
            {
                return HttpNotFound();
            }
            return View(airline);
        }

        // GET: Airlines/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Airlines/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
         public ActionResult Create([Bind(Include = "Id,AirlineName")] Airline airline)
        {
            if (ModelState.IsValid)
            {
                db.Airlines.Add(airline);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(airline);
        }

        // GET: Airlines/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Airline airline = db.Airlines.Find(id);
            if (airline == null)
            {
                return HttpNotFound();
            }
            return View(airline);
        }

        // POST: Airlines/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,AirlineName")] Airline airline)
        {
            if (ModelState.IsValid)
            {
                db.Entry(airline).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(airline);
        }

        // GET: Airlines/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Airline airline = db.Airlines.Find(id);
            if (airline == null)
            {
                return HttpNotFound();
            }
            return View(airline);
        }

        // POST: Airlines/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Airline airline = db.Airlines.Find(id);
            db.Airlines.Remove(airline);
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
