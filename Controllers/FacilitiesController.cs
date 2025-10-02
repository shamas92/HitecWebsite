using System;
using System.Web.Mvc;

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
                // Transport_Info entity was removed; render static informative page.
                return View();
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Error in Transport: {ex.Message}");
                return View();
            }
        }

        // Other facilities-related actions can be added here
        // Like Cafeteria, Hostels, etc.
    }
}