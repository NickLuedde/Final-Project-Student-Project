using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using GAG_101.Models;
using GAG_101.Models.ViewModels;

namespace GAG_101.Controllers
{
    public class LocalExperts1Controller : Controller
    {
        
        private GotAGuy_DB1Entities db = new GotAGuy_DB1Entities();

        // GET: LocalExperts1
        public ActionResult Index(int? id)
        {

            IEnumerable<LocalExperts1> expertsModel;

            if (id.HasValue)
            {

                expertsModel = db.JobTypes1.Find(id).LocalExperts1.ToList();


            }

            else
            {
                expertsModel = db.LocalExperts1.ToList();

            }

            return View (expertsModel);
        }


        [HttpPost]
        public ActionResult Index(LocalExpertSearchViewModel localExpertSearchViewModel)
        {

            IEnumerable<LocalExperts1> experts;

            if (localExpertSearchViewModel.Job_Type_ID.HasValue)

            {

                experts = db.JobTypes1.Find(localExpertSearchViewModel.Job_Type_ID).LocalExperts1;


            }

            else
            {

                experts = db.LocalExperts1;


            }

            if (!string.IsNullOrWhiteSpace(localExpertSearchViewModel.Name))
            {
                experts = experts.Where(e => e.Name?.Contains(localExpertSearchViewModel.Name) ?? false);

            }

            if (!string.IsNullOrWhiteSpace(localExpertSearchViewModel.Business_Name))
            {

                experts = experts.Where(e => e.Business_Name?.Contains(localExpertSearchViewModel.Business_Name) ?? false);

            }

            if ((localExpertSearchViewModel.Location_Zip.HasValue))
            {

                experts = experts.Where(e => e.Location_Zip == (localExpertSearchViewModel.Location_Zip));

            }

           

            switch (localExpertSearchViewModel.SortOrder)
            {

                case ExpertSortOrder.bestReviews:

                    experts = experts.OrderByDescending(e => e.AverageRating);
                    break;

                case ExpertSortOrder.qualityRanking:

                    experts = experts.OrderByDescending(e => e.QualityRating);
                    break;

                case ExpertSortOrder.fairPriceRanking:

                    experts = experts.OrderByDescending(e => e.FairPriceTimeRating);
                    break;

                case ExpertSortOrder.timeleyCompletioneRanking:

                    experts = experts.OrderByDescending(e => e.CompletionTimeRating);
                    break;



            }

            return View("Index", experts.ToList());

        }



        // GET: LocalExperts1/Details/5
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

        // GET: LocalExperts1/Create
        public ActionResult Create()
        {
           
            ViewBag.TotalJobTypes = new MultiSelectList(db.JobTypes1.ToList(), "JobType_ID", "Name_JobType");
            
            return View();
        }

        // POST: LocalExperts1/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create( ExpertCreateViewModel expertVM)
        {
            if (ModelState.IsValid)
            {

                var localExperts1 = new LocalExperts1()
                {
                    BU_FEIN = expertVM.BU_FEIN,
                    Email = expertVM.Email,
                    Business_Name = expertVM.Business_Name,
                    Location_Zip = expertVM.Location_Zip,
                    Name = expertVM.Name,
                    Name_JobType = expertVM.Name_JobType,
                    Phone_Number = expertVM.Phone_Number,

                    JobTypes1 = new List<JobTypes1>()


                };

                foreach (var JobTypeId in expertVM.JobTypes1)

                {
                    localExperts1.JobTypes1.Add(db.JobTypes1.Find(JobTypeId));


                }





                db.LocalExperts1.Add(localExperts1);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.TotalJobTypes = new MultiSelectList(db.JobTypes1.ToList(), "JobType_ID", "Name_JobType");


            return View(expertVM);


        }

        public ActionResult Search()
        {

            ViewBag.TotalJobTypes = new SelectList(db.JobTypes1.ToList(), "JobType_ID", "Name_JobType");




            return PartialView();




        }

        





        // GET: LocalExperts1/Edit/5
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

        // POST: LocalExperts1/Edit/5
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

        // GET: LocalExperts1/Delete/5
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

        // POST: LocalExperts1/Delete/5
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
