using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using GAG_101.Models;
using Microsoft.Ajax.Utilities;
using Microsoft.AspNet.Identity;

namespace GAG_101.Controllers
{
    public class HomeController : Controller
    {
        private GotAGuy_DB1Entities db = new GotAGuy_DB1Entities();


     public ActionResult Index()
        {

            if (Request.IsAuthenticated)
            {
                var UserID = User.Identity.GetUserId();

                if (User.IsInRole("Local BusinessUser"))
                {

                    var BusinessUser = db.LocalBusinessUsers1.Single(x => x.LocalBusiness_UserID == UserID);

                    return RedirectToAction("Login", "Account", new {id = BusinessUser.LocalBusiness_ID});

                }

                else if (User.IsInRole("LocalExpert"))
                {

                    var LocalExpert = db.LocalExperts1.Single(x => x.LocalExpert_UserID == UserID);

                    return RedirectToAction("Login", "Account", new {id = LocalExpert.LocalExpert_ID});

                }
            }


            return View();
        } 
        



        public ActionResult Contact()
        {
            return View();

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