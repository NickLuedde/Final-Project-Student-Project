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
    public class GeneralSearchExxpertsController : Controller
    {
        private GotAGuy_DB1Entities db = new GotAGuy_DB1Entities();

        // GET: GeneralSearchExxperts
        public ActionResult Index()
        {
            return View(db.LocalExperts1.ToList());
        }

        // GET: GeneralSearchExxperts/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            LocalExperts1 localExperts1 = db.LocalExperts1.Find(id);
            if (localExperts1 == null)
            {
                return HttpNotFound();
            }
            return View(localExperts1);
        }

        // GET: GeneralSearchExxperts/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: GeneralSearchExxperts/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "LocalExpert_ID,LocalExpert_UserID,Name,Email,Business_Name,Name_JobType,BU_FEIN,Location_Zip,Phone_Number")] LocalExperts1 localExperts1)
        {
            if (ModelState.IsValid)
            {
                db.LocalExperts1.Add(localExperts1);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(localExperts1);
        }

        // GET: GeneralSearchExxperts/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            LocalExperts1 localExperts1 = db.LocalExperts1.Find(id);
            if (localExperts1 == null)
            {
                return HttpNotFound();
            }
            return View(localExperts1);
        }

        // POST: GeneralSearchExxperts/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "LocalExpert_ID,LocalExpert_UserID,Name,Email,Business_Name,Name_JobType,BU_FEIN,Location_Zip,Phone_Number")] LocalExperts1 localExperts1)
        {
            if (ModelState.IsValid)
            {
                db.Entry(localExperts1).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(localExperts1);
        }

        // GET: GeneralSearchExxperts/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            LocalExperts1 localExperts1 = db.LocalExperts1.Find(id);
            if (localExperts1 == null)
            {
                return HttpNotFound();
            }
            return View(localExperts1);
        }

        // POST: GeneralSearchExxperts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            LocalExperts1 localExperts1 = db.LocalExperts1.Find(id);
            db.LocalExperts1.Remove(localExperts1);
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
