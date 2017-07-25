using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DJProject.Models;

namespace DJProject.Controllers
{
    public class BrodCastController : Controller
    {
        //
        // GET: /BrodCast/
        private UsersContext db = new UsersContext();

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ListOfBrodCast()
        {
            return View();
        }

        public ActionResult SearchBrodCast()
        {
            return View();
        }

        [HttpGet]
        [Authorize(Roles = "Administrator")]
        public ActionResult CreateBrodCast()
        {
            return View();
        }

        [HttpPost]
        [Authorize(Roles="Administrator")]
        public ActionResult CreateBrodCast(Models.BrodCast BrodCast)
        {
            if (DateTime.Now >= BrodCast.StartDate)
                { ModelState.AddModelError("Date", "the date as past"); }
            if (!ModelState.IsValid)
            {
                db.BrodCasts.Add(BrodCast);
                db.SaveChanges();
                return View();
            }
            return View();
        }
    }
}
