using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ACE.DAL;
using ACE.Models;

namespace ACE.Controllers
{
    public class PitStopController : Controller
    {
        private EventContext db = new EventContext();

        // GET: PitStop
        public ActionResult Index()
        {
            var pitStops = db.PitStops.Include(p => p.Event).Include(p => p.Staff);
            return View(pitStops.ToList());
        }

        // GET: PitStop/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PitStop pitStop = db.PitStops.Find(id);
            if (pitStop == null)
            {
                return HttpNotFound();
            }
            return View(pitStop);
        }

        // GET: PitStop/Create
        public ActionResult Create()
        {
            ViewBag.EventID = new SelectList(db.Events, "EventID", "EventName");
            ViewBag.StaffID = new SelectList(db.Staffs, "StaffID", "StaffCode");
            return View();
        }

        // POST: PitStop/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "PitStopID,EventID,PitStopName,PitStopOrder,PitStopLocation,StaffID")]
                                    PitStop pitStop)
        {
            if (ModelState.IsValid)
            {
                db.PitStops.Add(pitStop);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.EventID = new SelectList(db.Events, "EventID", "EventName", pitStop.EventID);
            ViewBag.EventTotalPitStops = new SelectList(db.Events, "EventID", "EventTotalPitStops", pitStop.EventID);
            ViewBag.StaffID = new SelectList(db.Staffs, "StaffID", "StaffCode", pitStop.StaffID);

            return View(pitStop);
        }

        // GET: PitStop/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PitStop pitStop = db.PitStops.Find(id);
            if (pitStop == null)
            {
                return HttpNotFound();
            }
            ViewBag.EventID = new SelectList(db.Events, "EventID", "EventName", pitStop.EventID);
            ViewBag.StaffID = new SelectList(db.Staffs, "StaffID", "StaffCode", pitStop.StaffID);
            return View(pitStop);
        }

        // POST: PitStop/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "PitStopID,EventID,PitStopName,PitStopOrder,PitStopLocation,StaffID")] PitStop pitStop)
        {
            if (ModelState.IsValid)
            {
                db.Entry(pitStop).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.EventID = new SelectList(db.Events, "EventID", "EventName", pitStop.EventID);
            ViewBag.StaffID = new SelectList(db.Staffs, "StaffID", "StaffCode", pitStop.StaffID);
            return View(pitStop);
        }

        // GET: PitStop/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PitStop pitStop = db.PitStops.Find(id);
            if (pitStop == null)
            {
                return HttpNotFound();
            }
            return View(pitStop);
        }

        // POST: PitStop/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            PitStop pitStop = db.PitStops.Find(id);
            db.PitStops.Remove(pitStop);
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
