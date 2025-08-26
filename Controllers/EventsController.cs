using System;
using System.Linq;
using System.Web.Mvc;
using System.Data.Entity;
using Website.Models;

namespace Website.Controllers
{
    public class EventsController : Controller
    {
        // GET: Events
        public ActionResult Index()
        {
            using (var db = new Model1())
            {
                var events = db.tblEvents
                    .Include(e => e.tblEventHead) // Eagerly load the tblEventHead to prevent ObjectDisposedException
                    .Where(e => e.Active == true)
                    .OrderByDescending(e => e.EventDate)
                    .ToList();

                return View(events);
            }
        }
        // GET: /Events/Details/5
        public ActionResult Details(int? id)
        {
            // If id is not provided, redirect to the index page
            if (!id.HasValue)
            {
                return RedirectToAction("Index");
            }

            using (var db = new Model1())
            {
                var ev = db.tblEvents
                    .Include(e => e.tblEventPhotos)
                    .Include(e => e.tblEventVideos)
                    .Include(e => e.tblEventHead)
                    .FirstOrDefault(e => e.EventID == id.Value);

                if (ev == null)
                {
                    return HttpNotFound();
                }

                // increment views safely
                ev.Views = (ev.Views ?? 0) + 1;
                db.Entry(ev).Property(x => x.Views).IsModified = true;
                db.SaveChanges();

                return View(ev);
            }
        }

        // Action method to get latest events for the navigation menu
        [ChildActionOnly]
        public ActionResult GetLatestEvents()
        {
            try
            {
                using (var db = new Model1())
                {
                    var latestEvents = db.tblEvents
                        .Include(e => e.tblEventHead) // Eagerly load the tblEventHead to prevent ObjectDisposedException
                        .Where(e => e.Active == true)
                        .OrderByDescending(e => e.EventDate)
                        .Take(3)
                        .ToList();

                    return PartialView("_LatestEventsMenu", latestEvents);
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Error in GetLatestEvents: {ex.Message}");
                return Content("<!-- Latest Events Error -->");
            }
        }
    }
}

