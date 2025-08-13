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

        // // Temporary debug action to check events
        // public ActionResult DebugEvents()
        // {
        //     try
        //     {
        //         using (var db = new Website.Models.Model1())
        //         {
        //             // Test database connection
        //             var canConnect = db.Database.Exists();
        //             ViewBag.CanConnect = canConnect;

        //             if (canConnect)
        //             {
        //                 var events = db.tblEvents.Include(e => e.tblEventHead).Take(10).ToList();
        //                 ViewBag.EventsCount = events.Count;
        //                 ViewBag.Events = events;
        //             }
        //             else
        //             {
        //                 ViewBag.EventsCount = 0;
        //                 ViewBag.Events = new List<Website.Models.tblEvent>();
        //                 ViewBag.Error = "Cannot connect to database";
        //             }

        //             return View("DebugEvents");
        //         }
        //     }
        //     catch (Exception ex)
        //     {
        //         ViewBag.CanConnect = false;
        //         ViewBag.EventsCount = 0;
        //         ViewBag.Events = new List<Website.Models.tblEvent>();
        //         ViewBag.Error = ex.Message;
        //         return View("DebugEvents");
        //     }
        // }

        // // Debug action to check EventHeads
        // public ActionResult DebugEventHeads()
        // {
        //     try
        //     {
        //         using (var db = new Website.Models.Model1())
        //         {
        //             var eventHeads = db.tblEventHeads.ToList();
        //             ViewBag.EventHeadsCount = eventHeads.Count;
        //             ViewBag.EventHeads = eventHeads;

        //             var eventsWithHeads = db.tblEvents.Include(e => e.tblEventHead).Take(10).ToList();
        //             ViewBag.EventsWithHeads = eventsWithHeads;

        //             return View("DebugEventHeads");
        //         }
        //     }
        //     catch (Exception ex)
        //     {
        //         ViewBag.Error = ex.Message;
        //         return View("DebugEventHeads");
        //     }
        // }

        // // Method to create sample EventHeads if database is empty
        // public ActionResult SeedEventHeads()
        // {
        //     try
        //     {
        //         using (var db = new Website.Models.Model1())
        //         {
        //             // Check if EventHeads already exist
        //             if (db.tblEventHeads.Any())
        //             {
        //                 ViewBag.Message = "EventHeads already exist in the database.";
        //                 return View("SeedResult");
        //             }

        //             // Create sample EventHeads
        //             var sampleEventHeads = new List<Website.Models.tblEventHead>
        //             {
        //                 new Website.Models.tblEventHead { Title = "Academic", Active = true, C_Order = 1 },
        //                 new Website.Models.tblEventHead { Title = "Sports", Active = true, C_Order = 2 },
        //                 new Website.Models.tblEventHead { Title = "Cultural", Active = true, C_Order = 3 },
        //                 new Website.Models.tblEventHead { Title = "Workshop", Active = true, C_Order = 4 },
        //                 new Website.Models.tblEventHead { Title = "Seminar", Active = true, C_Order = 5 },
        //                 new Website.Models.tblEventHead { Title = "Conference", Active = true, C_Order = 6 }
        //             };

        //             db.tblEventHeads.AddRange(sampleEventHeads);
        //             db.SaveChanges();

        //             ViewBag.Message = $"Successfully created {sampleEventHeads.Count} sample EventHeads.";
        //             return View("SeedResult");
        //         }
        //     }
        //     catch (Exception ex)
        //     {
        //         ViewBag.Message = $"Error creating sample EventHeads: {ex.Message}";
        //         return View("SeedResult");
        //     }
        // }

        // // Method to create sample events if database is empty
        // public ActionResult SeedSampleEvents()
        // {
        //     try
        //     {
        //         using (var db = new Website.Models.Model1())
        //         {
        //             // Check if events already exist
        //             if (db.tblEvents.Any())
        //             {
        //                 ViewBag.Message = "Events already exist in the database.";
        //                 return View("SeedResult");
        //             }

        //             // Ensure EventHeads exist first
        //             if (!db.tblEventHeads.Any())
        //             {
        //                 // Create sample EventHeads first
        //                 var sampleEventHeads = new List<Website.Models.tblEventHead>
        //                 {
        //                     new Website.Models.tblEventHead { Title = "Academic", Active = true, C_Order = 1 },
        //                     new Website.Models.tblEventHead { Title = "Sports", Active = true, C_Order = 2 },
        //                     new Website.Models.tblEventHead { Title = "Cultural", Active = true, C_Order = 3 },
        //                     new Website.Models.tblEventHead { Title = "Workshop", Active = true, C_Order = 4 },
        //                     new Website.Models.tblEventHead { Title = "Seminar", Active = true, C_Order = 5 }
        //                 };
        //                 db.tblEventHeads.AddRange(sampleEventHeads);
        //                 db.SaveChanges();
        //             }

        //             // Get EventHead IDs for assignment
        //             var academicHead = db.tblEventHeads.FirstOrDefault(h => h.Title == "Academic");
        //             var sportsHead = db.tblEventHeads.FirstOrDefault(h => h.Title == "Sports");
        //             var culturalHead = db.tblEventHeads.FirstOrDefault(h => h.Title == "Cultural");
        //             var workshopHead = db.tblEventHeads.FirstOrDefault(h => h.Title == "Workshop");
        //             var seminarHead = db.tblEventHeads.FirstOrDefault(h => h.Title == "Seminar");

        //             // Create sample events
        //             var sampleEvents = new List<Website.Models.tblEvent>
        //             {
        //                 new Website.Models.tblEvent
        //                 {
        //                     Title = "Annual Science Fair 2024",
        //                     EventDate = DateTime.Now.AddDays(30),
        //                     Date = DateTime.Now,
        //                     Venue = "Main Auditorium",
        //                     Details = "Join us for our annual science fair showcasing student innovations.",
        //                     Active = true,
        //                     Views = 150,
        //                     EventHeadID = academicHead?.EventHeadID
        //                 },
        //                 new Website.Models.tblEvent
        //                 {
        //                     Title = "Engineering Workshop Series",
        //                     EventDate = DateTime.Now.AddDays(15),
        //                     Date = DateTime.Now,
        //                     Venue = "Engineering Lab",
        //                     Details = "Hands-on workshop for engineering students.",
        //                     Active = true,
        //                     Views = 89,
        //                     EventHeadID = workshopHead?.EventHeadID
        //                 },
        //                 new Website.Models.tblEvent
        //                 {
        //                     Title = "Career Guidance Seminar",
        //                     EventDate = DateTime.Now.AddDays(45),
        //                     Date = DateTime.Now,
        //                     Venue = "Conference Hall",
        //                     Details = "Expert guidance on career opportunities.",
        //                     Active = true,
        //                     Views = 234,
        //                     EventHeadID = seminarHead?.EventHeadID
        //                 },
        //                 new Website.Models.tblEvent
        //                 {
        //                     Title = "Sports Day 2024",
        //                     EventDate = DateTime.Now.AddDays(60),
        //                     Date = DateTime.Now,
        //                     Venue = "Sports Ground",
        //                     Details = "Annual sports competition for all students.",
        //                     Active = true,
        //                     Views = 312,
        //                     EventHeadID = sportsHead?.EventHeadID
        //                 },
        //                 new Website.Models.tblEvent
        //                 {
        //                     Title = "Cultural Festival",
        //                     EventDate = DateTime.Now.AddDays(75),
        //                     Date = DateTime.Now,
        //                     Venue = "Campus Grounds",
        //                     Details = "Celebrate diversity with our cultural festival.",
        //                     Active = true,
        //                     Views = 445,
        //                     EventHeadID = culturalHead?.EventHeadID
        //                 }
        //             };

        //             db.tblEvents.AddRange(sampleEvents);
        //             db.SaveChanges();

        //             ViewBag.Message = $"Successfully created {sampleEvents.Count} sample events.";
        //             return View("SeedResult");
        //         }
        //     }
        //     catch (Exception ex)
        //     {
        //         ViewBag.Message = $"Error creating sample events: {ex.Message}";
        //         return View("SeedResult");
        //     }
        // }

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