using System;
using System.Linq;
using System.Web.Mvc;
using System.Data.Entity;
using Website.Models;
using Website.ViewModels;

namespace Website.Controllers
{
    public class EventsController : Controller
    {
        // GET: Events
        public ActionResult Index(
            string q = null,
            bool? alumni = null,
            int? headId = null,
            DateTime? from = null,
            DateTime? to = null,
            string when = "all", // all | upcoming | past
            string sort = "date_desc",
            int page = 1,
            int pageSize = 12)
        {
            if (page <= 0) page = 1;
            if (pageSize <= 0 || pageSize > 48) pageSize = 12; // clamp

            using (var db = new Model1())
            {
                var query = db.tblEvents
                    .AsNoTracking()
                    .Include(e => e.tblEventHead)
                    .Where(e => e.Active == true);

                // When filter
                var now = DateTime.Now.Date;
                switch ((when ?? "all").ToLowerInvariant())
                {
                    case "upcoming":
                        query = query.Where(e => e.EventDate >= now);
                        break;
                    case "past":
                        query = query.Where(e => e.EventDate < now);
                        break;
                }

                // Alumni filter
                if (alumni.HasValue)
                {
                    query = query.Where(e => (e.AlumniEvent ?? false) == alumni.Value);
                }

                // Head/category filter
                if (headId.HasValue)
                {
                    query = query.Where(e => e.EventHeadID == headId.Value);
                }

                // Date range filter
                if (from.HasValue)
                {
                    var f = from.Value.Date;
                    query = query.Where(e => e.EventDate >= f);
                }
                if (to.HasValue)
                {
                    var t = to.Value.Date.AddDays(1).AddTicks(-1); // inclusive end of day
                    query = query.Where(e => e.EventDate <= t);
                }

                // Search filter (title, venue, head title)
                if (!string.IsNullOrWhiteSpace(q))
                {
                    var term = q.Trim();
                    query = query.Where(e =>
                        (e.Title != null && e.Title.Contains(term)) ||
                        (e.Venue != null && e.Venue.Contains(term)) ||
                        (e.tblEventHead != null && e.tblEventHead.Title.Contains(term))
                    );
                }

                // Sorting
                switch ((sort ?? "date_desc").ToLowerInvariant())
                {
                    case "date_asc":
                        query = query.OrderBy(e => e.EventDate).ThenBy(e => e.EventID);
                        break;
                    case "views_desc":
                        query = query.OrderByDescending(e => e.Views ?? 0).ThenByDescending(e => e.EventDate);
                        break;
                    case "views_asc":
                        query = query.OrderBy(e => (e.Views ?? 0)).ThenBy(e => e.EventDate);
                        break;
                    case "title_asc":
                        query = query.OrderBy(e => e.Title).ThenByDescending(e => e.EventDate);
                        break;
                    default: // date_desc
                        query = query.OrderByDescending(e => e.EventDate).ThenByDescending(e => e.EventID);
                        break;
                }

                var total = query.Count();
                var items = query
                    .Skip((page - 1) * pageSize)
                    .Take(pageSize)
                    .ToList();

                var heads = db.tblEventHeads.AsNoTracking().Where(h => h.Active == true).OrderBy(h => h.C_Order ?? int.MaxValue).ThenBy(h => h.Title).ToList();

                var vm = new EventsIndexViewModel
                {
                    Items = items,
                    Heads = heads,
                    Q = q,
                    Alumni = alumni,
                    HeadId = headId,
                    From = from,
                    To = to,
                    When = when,
                    Sort = sort,
                    Page = page,
                    PageSize = pageSize,
                    TotalCount = total
                };

                if (Request.IsAjaxRequest())
                {
                    return PartialView("_EventsList", vm);
                }

                return View(vm);
            }
        }
        // GET: /Events/Details/5
        public ActionResult Details(int? id)
        {
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

                ev.Views = (ev.Views ?? 0) + 1;
                db.Entry(ev).Property(x => x.Views).IsModified = true;
                db.SaveChanges();

                return View(ev);
            }
        }

        [ChildActionOnly]
        public ActionResult GetLatestEvents()
        {
            try
            {
                using (var db = new Model1())
                {
                    var latestEvents = db.tblEvents
                        .Include(e => e.tblEventHead)
                        .Where(e => e.Active == true)
                        .OrderByDescending(e => e.EventDate)
                        .Take(3)
                        .AsNoTracking()
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

