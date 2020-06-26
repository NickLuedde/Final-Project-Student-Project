using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using GAG_101.Models;

namespace GAG_101.Controllers
{
    public class LocalBusinessUsers1Controller : Controller
    {
        private GotAGuy_DB1Entities db = new GotAGuy_DB1Entities();

        // GET: LocalBusinessUsers1
        public ActionResult Index()
        {
            return View(db.LocalBusinessUsers1.ToList());
        }


        // GET: LocalBusinessUsers1/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            LocalBusinessUsers1 localBusinessUsers1 = db.LocalBusinessUsers1.Find(id);
            if (localBusinessUsers1 == null)
            {
                return HttpNotFound();
            }
            return View(localBusinessUsers1);
        }

        // GET: LocalBusinessUsers1/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: LocalBusinessUsers1/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create (LocalBusinessUsers1 localBusinessUsers1)
        {
            if (ModelState.IsValid)
            {
                db.LocalBusinessUsers1.Add(localBusinessUsers1);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(localBusinessUsers1);
        }

        // GET: LocalBusinessUsers1/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            LocalBusinessUsers1 localBusinessUsers1 = db.LocalBusinessUsers1.Find(id);
            if (localBusinessUsers1 == null)
            {
                return HttpNotFound();
            }
            return View(localBusinessUsers1);
        }

        // POST: LocalBusinessUsers1/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "LocalBusiness_ID,LocalBusiness_UserID,Name,Email,Business_Name,BU_FEIN,Location_Zip,Phone_Number")] LocalBusinessUsers1 localBusinessUsers1)
        {
            if (ModelState.IsValid)
            {
                db.Entry(localBusinessUsers1).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(localBusinessUsers1);
        }

        // GET: LocalBusinessUsers1/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            LocalBusinessUsers1 localBusinessUsers1 = db.LocalBusinessUsers1.Find(id);
            if (localBusinessUsers1 == null)
            {
                return HttpNotFound();
            }
            return View(localBusinessUsers1);
        }

        // POST: LocalBusinessUsers1/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            LocalBusinessUsers1 localBusinessUsers1 = db.LocalBusinessUsers1.Find(id);
            db.LocalBusinessUsers1.Remove(localBusinessUsers1);
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
