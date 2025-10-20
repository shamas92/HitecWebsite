using System;
using System.Linq;
using System.Web.Mvc;
using Website.Models;
using HitecCM.Models;

namespace Website.Controllers
{
    public class AdmissionController : Controller
    {
        // GET: /Admission/AcademicCalendar
        public ActionResult AcademicCalendar()
        {
            try
            {
                using (var db = new Model1())
                {
                    var data = db.AcademicCalendars
                        .OrderByDescending(x => (DateTime?)x.UpdatedAt ?? x.CreatedAt)
                        .FirstOrDefault();

                    if (data == null)
                    {
                        data = new AcademicCalendar
                        {
                            CalendarID = 0,
                            Title = "Academic Calendar",
                            DescripQon = null,
                            CreatedAt = DateTime.Now,
                            UpdatedAt = null
                        };
                    }

                    return View(data);
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Error in AcademicCalendar: {ex.Message}");
                var emptyModel = new AcademicCalendar
                {
                    CalendarID = 0,
                    Title = "Academic Calendar",
                    DescripQon = null,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = null
                };
                return View(emptyModel);
            }
        }

        // GET: /Admission/FeeStructure
        public ActionResult FeeStructure()
        {
            try
            {
                using (var db = new Model1())
                {
                    var data = db.tblFeeStructures
                        .OrderByDescending(x => (DateTime?)x.UpdatedAt ?? x.CreatedAt)
                        .FirstOrDefault();

                    if (data == null)
                    {
                        data = new tblFeeStructure
                        {
                            ID = 0,
                            Title = "Fee Structure",
                            PageData = null,
                            CreatedAt = DateTime.Now,
                            UpdatedAt = null
                        };
                    }

                    return View(data);
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Error in FeeStructure: {ex.Message}");
                var emptyModel = new tblFeeStructure
                {
                    ID = 0,
                    Title = "Fee Structure",
                    PageData = null,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = null
                };
                return View(emptyModel);
            }
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

        // GET: /Admission/AcademicRegulations
        public ActionResult AcademicRegulations()
        {
            try
            {
                using (var db = new Model1())
                {
                    var data = db.tblAcademicRegulations
                        .OrderByDescending(x => (DateTime?)x.UpdatedAt ?? x.CreatedAt)
                        .FirstOrDefault();

                    if (data == null)
                    {
                        data = new tblAcademicRegulation
                        {
                            ID = 0,
                            Title = "Academic Regulations",
                            PageData = null,
                            CreatedAt = DateTime.Now,
                            UpdatedAt = null
                        };
                    }

                    return View(data);
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Error in AcademicRegulations: {ex.Message}");
                var emptyModel = new tblAcademicRegulation
                {
                    ID = 0,
                    Title = "Academic Regulations",
                    PageData = null,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = null
                };
                return View(emptyModel);
            }
        }

        // GET: /Admission/AcademicDeficiencies
        public ActionResult AcademicDeficiencies()
        {
            try
            {
                using (var db = new Model1())
                {
                    var data = db.tblAcademicDeficiencies
                        .OrderByDescending(x => (DateTime?)x.UpdatedAt ?? x.CreatedAt)
                        .FirstOrDefault();

                    if (data == null)
                    {
                        data = new tblAcademicDeficiency
                        {
                            ID = 0,
                            Title = "Academic Deficiencies",
                            PageData = null,
                            CreatedAt = DateTime.Now,
                            UpdatedAt = null
                        };
                    }

                    return View(data);
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Error in AcademicDeficiencies: {ex.Message}");
                var emptyModel = new tblAcademicDeficiency
                {
                    ID = 0,
                    Title = "Academic Deficiencies",
                    PageData = null,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = null
                };
                return View(emptyModel);
            }
        }

        // GET: /Admission/RulesAndRegulationsMS
        public ActionResult RulesAndRegulationsMS()
        {
            try
            {
                using (var db = new Model1())
                {
                    var data = db.tblRulesRegulationsMS
                        .OrderByDescending(x => (DateTime?)x.UpdatedAt ?? x.CreatedAt)
                        .FirstOrDefault();

                    if (data == null)
                    {
                        data = new tblRulesRegulationsMS
                        {
                            ID = 0,
                            Title = "Rules & Regulations for MS",
                            PageData = null,
                            CreatedAt = DateTime.Now,
                            UpdatedAt = null
                        };
                    }

                    return View(data);
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Error in RulesAndRegulationsMS: {ex.Message}");
                var emptyModel = new tblRulesRegulationsMS
                {
                    ID = 0,
                    Title = "Rules & Regulations for MS",
                    PageData = null,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = null
                };
                return View(emptyModel);
            }
        }

        // GET: /Admission/RulesAndRegulationsPhD
        public ActionResult RulesAndRegulationsPhD()
        {
            try
            {
                using (var db = new Model1())
                {
                    var data = db.tblRulesRegulationsPhd
                        .OrderByDescending(x => (DateTime?)x.UpdatedAt ?? x.CreatedAt)
                        .FirstOrDefault();

                    if (data == null)
                    {
                        data = new tblRulesRegulationsPhd
                        {
                            ID = 0,
                            Title = "Rules & Regulations for PhD",
                            PageData = null,
                            CreatedAt = DateTime.Now,
                            UpdatedAt = null
                        };
                    }

                    return View(data);
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Error in RulesAndRegulationsPhD: {ex.Message}");
                var emptyModel = new tblRulesRegulationsPhd
                {
                    ID = 0,
                    Title = "Rules & Regulations for PhD",
                    PageData = null,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = null
                };
                return View(emptyModel);
            }
        }

        public ActionResult HitecUniversityAct2009()
        {
            ViewBag.Title = "HITEC University Act 2009";
            return View();
        }
    }
}
