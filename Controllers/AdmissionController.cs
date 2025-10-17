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

        // Admissions pages
        public ActionResult FeeStructure()
        {
            ViewBag.Title = "Fee Structure";
            ViewBag.MetaDescription = "Detailed fee structure for all programs at HITEC University including tuition fees, hostel charges, transport charges and miscellaneous fees for academic year 2025-26.";
            ViewBag.MetaKeywords = "HITEC University, fee structure, tuition fees, admission fees, hostel charges, transport charges, education cost";
            return View();
        }



        public ActionResult FinancialMatters()
        {
            ViewBag.Title = "Financial Matters";
            return View();
        }

        public ActionResult FinancialAssistance()
        {
            ViewBag.Title = "Financial Assistance";
            return View();
        }

        public ActionResult RefundPolicy()
        {
            ViewBag.Title = "Refund Policy";
            return View();
        }

        public ActionResult FinesPenaltiesOnLatePayments()
        {
            ViewBag.Title = "Fines/Penalties on Late Payments";
            return View();
        }

        public ActionResult Accommodation()
        {
            ViewBag.Title = "Accommodation";
            return View();
        }

        public ActionResult Transport()
        {
            ViewBag.Title = "Transport";
            return View();
        }

        public ActionResult MiscellaneousCharges()
        {
            ViewBag.Title = "Miscellaneous Charges";
            return View();
        }

        public ActionResult AdmissionPolicy()
        {
            ViewBag.Title = "Admission Policy";
            return View();
        }

        public ActionResult AcademicRegulations()
        {
            ViewBag.Title = "Academic Regulations";
            return View();
        }

        public ActionResult AcademicDeficiencies()
        {
            ViewBag.Title = "Academic Deficiencies";
            return View();
        }

        public ActionResult RulesAndRegulationsMS()
        {
            ViewBag.Title = "Rules & Regulations (MS)";
            return View();
        }

        public ActionResult RulesAndRegulationsPhD()
        {
            ViewBag.Title = "Rules & Regulations (PhD)";
            return View();
        }

        public ActionResult HitecUniversityAct2009()
        {
            ViewBag.Title = "HITEC University Act 2009";
            return View();
        }
    }
}
