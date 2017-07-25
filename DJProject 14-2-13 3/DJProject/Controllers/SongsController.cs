using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DJProject.Models;

namespace DJProject.Controllers
{
    public class SongsController : Controller
    {
        private UsersContext db = new UsersContext();

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ListOfSongs()
        {
            var SongsList = db.Songs;
            return View(SongsList);
        }

        public ActionResult SearchSongs()
        {
            return View();
        }

        [Authorize(Roles = "Administrator")]
        public ActionResult Delete(int SongsID)
        {
            Songs song = db.Songs.Find(SongsID);
            return View(song);
        }

        [HttpPost, ActionName("Delete")]
        [Authorize(Roles = "Administrator")]
        public ActionResult DeleteConfirmed(int id)
        {
            Songs song = db.Songs.Find(id);
            db.Songs.Remove(song);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        [Authorize(Roles = "Administrator")]
        public ActionResult Edit(int SongsID)
        {
            Songs song = db.Songs.Find(SongsID);
            var SongTypeList = new SelectList(new[] { "Pop", "Rock", "Electrinics", "Latin" });
            ViewBag.SongTypeList = SongTypeList;
            return View(song);
        }

        [HttpPost]
        [Authorize(Roles = "Administrator")]
        public ActionResult Edit(Models.Songs song)
        {
            if(!ModelState.IsValid)
            {
                return View(song);
            }
            db.Entry(song).State = EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("Index");
        }


        [HttpGet]
        [Authorize(Roles = "Administrator")]
        public ActionResult CreateSong()
        {
            var SongTypeList = new SelectList(new[] { "Pop", "Rock", "Electrinics", "Latin" });
            ViewBag.SongTypeList = SongTypeList;
            return View();
        }

        [HttpPost]
        [Authorize(Roles = "Administrator")]
        public ActionResult CreateSong(Models.Songs song)
        {
            if (ModelState.IsValid)
	        {
		        db.Songs.Add(song);
                db.SaveChanges();
                return RedirectToAction("Index");
	        }
            return View(song);
        }

        public ActionResult FullDescription(Songs Song)
        {
            return View(Song);
        }

        public ActionResult _PartialViewSongs()
        {
            var SongsList = db.Songs;
            return View(SongsList);
        }

        public ActionResult _PartialViewSongsUsers()
        {
            var SongsList = db.Songs;
            return View(SongsList);
        }
        public ActionResult MusicCharts()
        {
            var SongsList = db.Songs;
            return View(SongsList);
        }
    }
}
