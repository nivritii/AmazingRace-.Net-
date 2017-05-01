using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.Mvc;
using ACE.DAL;
using ACE.ViewModels;

namespace ACE.Controllers
{
    public class HomeController : Controller
    {
        private EventContext db = new EventContext();
        public ActionResult Index(int? EventID)
        {
            var viewModel = new EventIndexData();
            viewModel.Events = db.Events;
            DateTime systemDate = DateTime.Now.Date;
            ViewBag.EventID = new SelectList(db.Events.Where(i => i.EventStartDate == systemDate), "EventID", "EventName");
            //ViewBag.EventID = new SelectList(db.Events, "EventID", "EventName", team.EventID);
            return View(viewModel);

        }

        public ActionResult LiveEventIndex()
        {
            return View();
        }

        public ActionResult UpcomingEvent(int? id)
        {
            var viewModel = new EventIndexData();
            viewModel.Events = db.Events;
            return View(viewModel);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult simulateEvent()
        {
                ProcessStartInfo start = new ProcessStartInfo();
                start.FileName = "C:/Python27/python.exe";
                start.Arguments = string.Format("{0} {1}", "C:/Users/Rach/Desktop/pythonSimulator.py", null);
                start.UseShellExecute = false;
                start.RedirectStandardOutput = true;
                using (Process process = Process.Start(start))
                {
                    using (StreamReader reader = process.StandardOutput)
                    {
                        string result = reader.ReadToEnd();
                        Console.Write(result);
                    }
                }
            return RedirectToAction("Index", "Home");
        }
        
    }
}