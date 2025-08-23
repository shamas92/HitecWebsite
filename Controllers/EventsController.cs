using System;
using System.Linq;
using System.Web.Mvc;
using System.Data.Entity;
using Website.Models;

namespace Website.Controllers
{
    public class EventsController : Controller
    {
        // GET: /Events/Details/5
        public ActionResult Details(int id)
        {
            using (var db = new Model1())
            {
                var ev = db.tblEvents
                    .Include(e => e.tblEventPhotos)
                    .Include(e => e.tblEventVideos)
                    .FirstOrDefault(e => e.EventID == id);

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
        
        // GET: /Events/OpenHouse
        public ActionResult OpenHouse()
        {
            using (var db = new Model1())
            {
                // Filter events with "Open House" in their title or events where the title contains "Open"
                var openHouseEvents = db.tblEvents
                    .Where(e => (e.Title != null && (e.Title.Contains("Open House") || e.Title.Contains("Open Day"))) 
                            || (e.EventHeadID != null && db.tblEventHeads.Any(h => h.EventHeadID == e.EventHeadID && h.Title.Contains("Open House"))))
                    .Where(e => e.Active == true)
                    .OrderByDescending(e => e.EventDate)
                    .ToList();
                
                return View(openHouseEvents);
            }
        }
    }
}

