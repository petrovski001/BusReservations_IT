using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using BusReservations.Models;

namespace BusReservations.Controllers
{
    public class BusCompaniesController : Controller
    {
        private BusReservationsDB db = new BusReservationsDB();

        // GET: BusCompanies
        public ActionResult Index()
        {
            return View(db.BusCompanies.ToList());
        }

        // GET: BusCompanies/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BusCompany busCompany = db.BusCompanies.Find(id);
            if (busCompany == null)
            {
                return HttpNotFound();
            }
            return View(busCompany);
        }

        // GET: BusCompanies/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: BusCompanies/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Name")] BusCompany busCompany)
        {
            if (ModelState.IsValid)
            {
                db.BusCompanies.Add(busCompany);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(busCompany);
        }

        // GET: BusCompanies/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BusCompany busCompany = db.BusCompanies.Find(id);
            if (busCompany == null)
            {
                return HttpNotFound();
            }
            return View(busCompany);
        }

        // POST: BusCompanies/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Name")] BusCompany busCompany)
        {
            if (ModelState.IsValid)
            {
                db.Entry(busCompany).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(busCompany);
        }

        // GET: BusCompanies/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BusCompany busCompany = db.BusCompanies.Find(id);
            if (busCompany == null)
            {
                return HttpNotFound();
            }
            return View(busCompany);
        }

        // POST: BusCompanies/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            BusCompany busCompany = db.BusCompanies.Find(id);
            db.BusCompanies.Remove(busCompany);
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
