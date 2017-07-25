using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DJProject.Controllers
{
    public class FidbackController : Controller
    {
        //
        // GET: /Fidback/

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult CreateFidback()
        {
            return View();
        }

        public ActionResult FullDescription()
        {
            return View();
        }

        public ActionResult _PartialViewFidback()
        {
            return View();
        }
    }
}
