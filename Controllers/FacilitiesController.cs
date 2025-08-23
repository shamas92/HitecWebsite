using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Website.Models;

namespace Website.Controllers
{
    public class FacilitiesController : Controller
    {
        // GET: Facilities
        public ActionResult Index()
        {
            return View();
        }

        // GET: Facilities/Transport
        public ActionResult Transport()
        {
            try
            {
                using (var db = new Model1())
                {
                    var transportRoutes = db.Transport_Info.ToList();
                    return View(transportRoutes);
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Error in Transport: {ex.Message}");
                // Return the view without model data, the view will handle empty model
                return View(new List<Transport_Info>());
            }
        }

        // Other facilities-related actions can be added here
        // Like Cafeteria, Hostels, etc.
    }
}