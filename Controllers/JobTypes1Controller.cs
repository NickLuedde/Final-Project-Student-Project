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
    public class JobTypes1Controller : Controller
    {
        private GotAGuy_DB1Entities db = new GotAGuy_DB1Entities();

        // GET: JobTypes1
        public ActionResult Index()
        {
            return View(db.JobTypes1.ToList());
        }

        // GET: JobTypes1/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            JobTypes1 jobTypes1 = db.JobTypes1.Find(id);
            if (jobTypes1 == null)
            {
                return HttpNotFound();
            }
            return View(jobTypes1);
        }

        // GET: JobTypes1/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: JobTypes1/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "JobType_ID,Name_JobType")] JobTypes1 jobTypes1)
        {
            if (ModelState.IsValid)
            {
                db.JobTypes1.Add(jobTypes1);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(jobTypes1);
        }

        // GET: JobTypes1/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            JobTypes1 jobTypes1 = db.JobTypes1.Find(id);
            if (jobTypes1 == null)
            {
                return HttpNotFound();
            }
            return View(jobTypes1);
        }

        // POST: JobTypes1/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "JobType_ID,Name_JobType")] JobTypes1 jobTypes1)
        {
            if (ModelState.IsValid)
            {
                db.Entry(jobTypes1).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(jobTypes1);
        }

        // GET: JobTypes1/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            JobTypes1 jobTypes1 = db.JobTypes1.Find(id);
            if (jobTypes1 == null)
            {
                return HttpNotFound();
            }
            return View(jobTypes1);
        }

        // POST: JobTypes1/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            JobTypes1 jobTypes1 = db.JobTypes1.Find(id);
            db.JobTypes1.Remove(jobTypes1);
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
