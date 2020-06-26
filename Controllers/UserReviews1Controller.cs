using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using GAG_101.Models;
using Microsoft.Ajax.Utilities;
using Microsoft.AspNet.Identity;

namespace GAG_101.Controllers
{
    public class UserReviews1Controller : Controller
    {
        private GotAGuy_DB1Entities db = new GotAGuy_DB1Entities();

        // GET: UserReviews1
        public ActionResult Index(int? id)
        {
            var userReviews1 = db.LocalExperts1.Find(id).UserReviews1.OrderByDescending(R=>R.AverageRating);

            ViewBag.expertID = id.Value;

            
            
            return PartialView(userReviews1.ToList());
        }

        // GET: UserReviews1/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            UserReviews1 userReviews1 = db.UserReviews1.Find(id);
            if (userReviews1 == null)
            {
                return HttpNotFound();
            }
            return View(userReviews1);
        }

        // GET: UserReviews1/Create
        [Authorize(Roles = "Local BusinessUser")]
        public ActionResult Create(int? id)
        {
            var localExpert = db.LocalExperts1.Find(id);

            var userId = User.Identity.GetUserId();
            var currentUser = db.LocalBusinessUsers1.Single(c => c.LocalBusiness_UserID == userId);

            var userReview = new UserReviews1
            {

                LocalBusiness_ID = currentUser.LocalBusiness_ID,
                LocalExpert_UserID = id.Value,
                ReviewBody_Date = DateTime.Now,


            };

            ViewBag.localExpert = localExpert;

            return View(userReview);
        }

        // POST: UserReviews1/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Review_ReferenceID,LocalBusiness_ID,LocalExpert_UserID,FairPrice_Rating,Quality_Rating,CompletionTime_Rating,Review_Body,ReviewBody_Date")] UserReviews1 userReviews1)
        {




            if (ModelState.IsValid)
            {

                userReviews1.ReviewBody_Date = DateTime.Now;
                



                    db.UserReviews1.Add(userReviews1);
                db.SaveChanges();
                return RedirectToAction("Details", "LocalExperts1", new { id = userReviews1.LocalExpert_UserID} );
            }
           
            return View(userReviews1);
        }

        // GET: UserReviews1/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            UserReviews1 userReviews1 = db.UserReviews1.Find(id);
            if (userReviews1 == null)
            {
                return HttpNotFound();
            }
            ViewBag.LocalBusiness_ID = new SelectList(db.LocalBusinessUsers1, "LocalBusiness_ID", "LocalBusiness_UserID", userReviews1.LocalBusiness_ID);
            ViewBag.LocalExpert_UserID = new SelectList(db.LocalExperts1, "LocalExpert_ID", "LocalExpert_UserID", userReviews1.LocalExpert_UserID);
            return View(userReviews1);
        }

        // POST: UserReviews1/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Review_ReferenceID,LocalBusiness_ID,LocalExpert_UserID,FairPrice_Rating,Quality_Rating,CompletionTime_Rating,Review_Body,ReviewBody_Date")] UserReviews1 userReviews1)
        {
            if (ModelState.IsValid)
            {
                db.Entry(userReviews1).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.LocalBusiness_ID = new SelectList(db.LocalBusinessUsers1, "LocalBusiness_ID", "LocalBusiness_UserID", userReviews1.LocalBusiness_ID);
            ViewBag.LocalExpert_UserID = new SelectList(db.LocalExperts1, "LocalExpert_ID", "LocalExpert_UserID", userReviews1.LocalExpert_UserID);
            return View(userReviews1);
        }

        // GET: UserReviews1/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            UserReviews1 userReviews1 = db.UserReviews1.Find(id);
            if (userReviews1 == null)
            {
                return HttpNotFound();
            }
            return View(userReviews1);
        }

        // POST: UserReviews1/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            UserReviews1 userReviews1 = db.UserReviews1.Find(id);
            db.UserReviews1.Remove(userReviews1);
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
