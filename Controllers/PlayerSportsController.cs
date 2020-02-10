using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MIS4200ak353914.DAL;
using MIS4200ak353914.Models;

namespace MIS4200ak353914.Controllers
{
    public class PlayerSportsController : Controller
    {
        private MIS4200Context db = new MIS4200Context();

        // GET: PlayerSports
        public ActionResult Index()
        {
            var playerSport = db.PlayerSport.Include(p => p.Player).Include(p => p.Sport);
            return View(playerSport.ToList());
        }

        // GET: PlayerSports/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PlayerSport playerSport = db.PlayerSport.Find(id);
            if (playerSport == null)
            {
                return HttpNotFound();
            }
            return View(playerSport);
        }

        // GET: PlayerSports/Create
        public ActionResult Create()
        {
            ViewBag.playerID = new SelectList(db.Player, "playerID", "firstName");
            ViewBag.sportID = new SelectList(db.Sport, "sportID", "sportName");
            return View();
        }

        // POST: PlayerSports/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "playerSportID,position,playerID,sportID")] PlayerSport playerSport)
        {
            if (ModelState.IsValid)
            {
                db.PlayerSport.Add(playerSport);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.playerID = new SelectList(db.Player, "playerID", "firstName", playerSport.playerID);
            ViewBag.sportID = new SelectList(db.Sport, "sportID", "sportName", playerSport.sportID);
            return View(playerSport);
        }

        // GET: PlayerSports/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PlayerSport playerSport = db.PlayerSport.Find(id);
            if (playerSport == null)
            {
                return HttpNotFound();
            }
            ViewBag.playerID = new SelectList(db.Player, "playerID", "firstName", playerSport.playerID);
            ViewBag.sportID = new SelectList(db.Sport, "sportID", "sportName", playerSport.sportID);
            return View(playerSport);
        }

        // POST: PlayerSports/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "playerSportID,position,playerID,sportID")] PlayerSport playerSport)
        {
            if (ModelState.IsValid)
            {
                db.Entry(playerSport).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.playerID = new SelectList(db.Player, "playerID", "firstName", playerSport.playerID);
            ViewBag.sportID = new SelectList(db.Sport, "sportID", "sportName", playerSport.sportID);
            return View(playerSport);
        }

        // GET: PlayerSports/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PlayerSport playerSport = db.PlayerSport.Find(id);
            if (playerSport == null)
            {
                return HttpNotFound();
            }
            return View(playerSport);
        }

        // POST: PlayerSports/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            PlayerSport playerSport = db.PlayerSport.Find(id);
            db.PlayerSport.Remove(playerSport);
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
