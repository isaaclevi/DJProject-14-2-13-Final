using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DJProject.Models;

namespace DJProject.Controllers
{
    public class HomeController : Controller
    {
        UsersContext db = new UsersContext();

        public ActionResult Index()
        {
            return View();
        }


        public ActionResult Transmition()
        {
            return View();
        }


    }
}
