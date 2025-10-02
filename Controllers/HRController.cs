using System;
using System.Web.Mvc;

namespace Website.Controllers
{
    public class HRController : Controller
    {
        // GET: HR
        public ActionResult Index()
        {
            return View();
        }

        // GET: HR/TypesAndClassification
        public ActionResult TypesAndClassification()
        {
            try
            {
                // Under current schema, Employment_Types entity/table was removed.
                // Render static informative page; view no longer requires a model.
                return View();
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Error in TypesAndClassification: {ex.Message}");
                return View();
            }
        }

        // Other HR-related actions can be added here
        // Like Policies, Benefits, etc.
    }
}