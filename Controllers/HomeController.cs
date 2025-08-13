using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;

namespace Website.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            using (var db = new Website.Models.Model1())
            {
                try
                {
                    // First, try to get any events at all (without filters) and include EventHead
                    var allEvents = db.tblEvents.Include(e => e.tblEventHead).ToList();

                    if (allEvents.Count == 0)
                    {
                        // No events in database, return empty list
                        return View(new List<Website.Models.tblEvent>());
                    }

                    // Get events that are active (true or null)
                    var activeEvents = allEvents
                        .Where(e => e.Active == true || e.Active == null)
                        .ToList();

                    if (activeEvents.Count == 0)
                    {
                        // No active events, return first 5 events regardless of active status
                        return View(allEvents.Take(5).ToList());
                    }

                    // Sort by EventDate or Date, then by EventID
                    var sortedEvents = activeEvents
                        .OrderByDescending(e => e.EventDate ?? e.Date ?? DateTime.MinValue)
                        .ThenByDescending(e => e.EventID)
                        .Take(10)
                        .ToList();

                    // Randomly select 5 from the top 10
                    var rnd = new Random();
                    var randomFive = sortedEvents.OrderBy(e => rnd.Next()).Take(5).ToList();

                    return View(randomFive);
                }
                catch (Exception ex)
                {
                    // Log the error and return empty list
                    System.Diagnostics.Debug.WriteLine($"Error in Index: {ex.Message}");
                    return View(new List<Website.Models.tblEvent>());
                }
            }
        }


        public ActionResult About()
        {
            using (var db = new Website.Models.Model1())
            {
                var faculty = db.tblFaculties
                    .Where(f => (f.AdDesignation != null && (f.AdDesignation.Contains("Head of Program") || f.AdDesignation.Contains("Chairperson"))))
                    .Where(f => f.Active == true)
                    .OrderBy(f => f.OrderNo)
                    .ToList();
                return View(faculty);
            }
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}