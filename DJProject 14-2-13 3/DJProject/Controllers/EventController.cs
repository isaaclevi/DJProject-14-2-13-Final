using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DJProject.Models;

namespace DJProject.Controllers
{
    public class EventController : Controller
    {
        //
        // GET: /Event/
        private UsersContext db = new UsersContext();

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ListOfEvents()
        {
            var EventsList = db.Events;
            return View(EventsList);
        }

        public ActionResult ListOfEventsQury(List<Events> Qury)
        {
            List<Events> ls = (List<Events>)Session["EventSearch"];
            return View(ls);
        }

        [HttpGet]
        public ActionResult SearchEvents()
        {
            return View();
        }

        [HttpPost]
        public ActionResult SearchEvents(EventSearch Event)
        {
             string where="";
             if (Event.EventName!=null)
             { where += Event.EventName.ToString(); }
             if (Event.Date != null)
             { where +="||"+Event.Date.ToString()+"||"; }
             if (Event.Description != null)
             { where += "||" + Event.Description.ToString() + "||"; }
             if (Event.Plase != null)
             { where += "||" + Event.Plase.ToString(); }

             IQueryable<Events> Qury = from x in db.Events
                                       where x.EventName == Event.EventName || x.Date == Event.Date || x.Description == Event.Description || x.Plase == Event.Plase
                                       select x;
            List<Events> ls=   Qury.ToList();
            
            if (ls != null)
            {
                Session["EventSearch"] = ls;
                return RedirectToAction("ListOfEventsQury",ls);
            }
            return View();
        }

        [HttpGet]
        [Authorize(Roles = "Administrator")]
        public ActionResult Edit(int EventsID)
        {
            Events Event = db.Events.Find(EventsID);
            return View(Event);
        }

        [HttpPost]
        [Authorize(Roles = "Administrator")]
        public ActionResult Edit(Models.Events Event)
        {
            if(!ModelState.IsValid)
            {
                return View(Event);
            }
            db.Entry(Event).State = EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        [Authorize(Roles = "Administrator")]
        public ActionResult Delete(int EventsID)
        {
            Events Event = db.Events.Find(EventsID);
            return View(Event);
        }

        [HttpPost, ActionName("Delete")]
        [Authorize(Roles = "Administrator")]
        public ActionResult DeleteConfirmed(int EventsID)
        {
            Events Event = db.Events.Find(EventsID);
            db.Events.Remove(Event);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        [Authorize(Roles = "Administrator")]
        public ActionResult CreateEvent()
        {
            return View();
        }

        [HttpPost]
        [Authorize(Roles = "Administrator")]
        public ActionResult CreateEvent(Models.Events Event)
        {
            if (DateTime.Now >= Event.Date)
                { ModelState.AddModelError("Date", "the date as past"); }
            if (ModelState.IsValid)
	        {
		        db.Events.Add(Event);
                db.SaveChanges();
                return RedirectToAction("Index");
	        }
            return View(Event);
        }

        public ActionResult FullDescription(Events Event)
        {
            return View(Event);
        }

        public ActionResult _PartialViewEvent()
        {
            var EventsList = db.Events;
            return View(EventsList);
        }
    }
}
