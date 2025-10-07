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

        // GET: HR/EligibilityRecruitment
        public ActionResult EligibilityRecruitment()
        {
            try
            {
                return View();
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Error in EligibilityRecruitment: {ex.Message}");
                return View();
            }
        }

        // GET: HR/PerksPrivileges
        public ActionResult PerksPrivileges()
        {
            try
            {
                return View();
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Error in PerksPrivileges: {ex.Message}");
                return View();
            }
        }

        // GET: HR/Leave
        public ActionResult Leave()
        {
            try
            {
                return View();
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Error in Leave: {ex.Message}");
                return View();
            }
        }

        // GET: HR/ContributoryFund
        public ActionResult ContributoryFund()
        {
            try
            {
                return View();
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Error in ContributoryFund: {ex.Message}");
                return View();
            }
        }

        // GET: HR/ConductDiscipline
        public ActionResult ConductDiscipline()
        {
            try
            {
                return View();
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Error in ConductDiscipline: {ex.Message}");
                return View();
            }
        }
    }
}