using System.Web.Mvc;

namespace Website.Controllers
{
    public class AdmissionController : Controller
    {
        // GET: /Admission/AcademicCalendar
        public ActionResult AcademicCalendar()
        {
            ViewBag.Title = "Academic Calendar";
            ViewBag.MetaDescription = "View the academic calendar including important dates for admissions, semesters, and examinations at HITEC University.";
            ViewBag.MetaKeywords = "Academic Calendar, admissions, semester dates, exam schedule, HITEC University";
            return View();
        }

    }
}
