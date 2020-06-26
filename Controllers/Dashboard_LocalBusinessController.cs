using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GAG_101.Controllers
{
    public class Dashboard_LocalBusinessController : Controller
    {
        // GET: Dashboard_LocalBusiness
        public ActionResult Dashboard_LocalBusiness()
        {
            return View();
        }

        // GET: Dashboard_LocalBusiness/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Dashboard_LocalBusiness/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Dashboard_LocalBusiness/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Dashboard_LocalBusiness/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Dashboard_LocalBusiness/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Dashboard_LocalBusiness/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Dashboard_LocalBusiness/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
