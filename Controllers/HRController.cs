using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Website.Models;

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
                using (var db = new Model1())
                {
                    var employmentTypes = db.Employment_Types.ToList();
                    return View(employmentTypes);
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Error in TypesAndClassification: {ex.Message}");
                // Return the view without model data, the view will handle empty model
                return View(new List<Employment_Types>());
            }
        }

        // Other HR-related actions can be added here
        // Like Policies, Benefits, etc.
    }
}