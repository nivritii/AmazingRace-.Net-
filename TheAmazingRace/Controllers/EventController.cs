using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TheAmazingRace.Controllers
{
    public class EventController : Controller
    {
        AmazingRaceContext db = new AmazingRaceContext();

        // GET: Event
        public ActionResult Index()
        {
            return View(db.Events.ToList());
        }
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }


        [HttpPost]
        public ActionResult Create(Event e)
        {
            if(ModelState.IsValid)
            {
                db.Events.Add(e);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(e);
        }

        public ActionResult Details(int? id)
        {
            if (id == null)
                return new HttpStatusCodeResult(System.Net.HttpStatusCode.BadRequest);

            Event eventObj = db.Events.Find(id);
            if (eventObj == null)
                return HttpNotFound();
            return View(eventObj);
        }

        public ActionResult Edit(int? id)
        {
            if (id == null)
                return new HttpStatusCodeResult(System.Net.HttpStatusCode.BadRequest);

            Event eventObj = db.Events.Find(id);
            if (eventObj == null)
                return HttpNotFound();
            return View(eventObj);

        }
        [HttpPost]
        public ActionResult Edit(Event eventObj)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    db.Entry(eventObj).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }
                return View(eventObj);
            }
            catch
            {
                return View();
            }

        }
        public ActionResult Delete(int? id)
        {
            if (id == null)
                return new HttpStatusCodeResult(System.Net.HttpStatusCode.BadRequest);
            Event eventObj = db.Events.Find(id);
            if (eventObj == null)
                return HttpNotFound();
            return View(eventObj);
        }

        [HttpPost]
        public ActionResult Delete(int? id, Event eventObj)
        {
            try
            {
                Event eventObject= new Event();
                if (ModelState.IsValid)
                {
                    if (id == null)
                        return new HttpStatusCodeResult(System.Net.HttpStatusCode.BadRequest);
                    eventObject = db.Events.Find(id);

                    if (eventObject == null)
                        return HttpNotFound();

                    db.Events.Remove(eventObject);
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }

                return View(eventObject);

            }
            catch
            {
                return View();
            }
        }

    }
}