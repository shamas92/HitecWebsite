using System;
using System.Collections.Generic;
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
            try
            {
                using (var db = new Model1())
                {
                    var data = db.tblFinancialAssistances
                        .OrderByDescending(x => (DateTime?)x.UpdatedAt ?? x.CreatedAt)
                        .FirstOrDefault();

                    if (data == null)
                    {
                        data = new tblFinancialAssistance
                        {
                            ID = 0,
                            Title = "Financial Assistance",
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
                System.Diagnostics.Debug.WriteLine($"Error in FinancialAssistance: {ex.Message}");
                var emptyModel = new tblFinancialAssistance
                {
                    ID = 0,
                    Title = "Financial Assistance",
                    PageData = null,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = null
                };
                return View(emptyModel);
            }
        }

        public ActionResult RefundPolicy()
        {
            try
            {
                using (var db = new Model1())
                {
                    var data = db.tblRefundPolicies
                        .OrderByDescending(x => (DateTime?)x.UpdatedAt ?? x.CreatedAt)
                        .FirstOrDefault();

                    if (data == null)
                    {
                        data = new tblRefundPolicy
                        {
                            ID = 0,
                            Title = "Fee Refund Policy",
                            PageData = null,
                            CreatedAt = DateTime.Now,
                            UpdatedAt = null
                        };
                    }

                    ViewBag.Title = "Fee Refund Policy";
                    return View(data);
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Error in RefundPolicy: {ex.Message}");
                ViewBag.Title = "Fee Refund Policy";
                var emptyModel = new tblRefundPolicy
                {
                    ID = 0,
                    Title = "Fee Refund Policy",
                    PageData = null,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = null
                };
                return View(emptyModel);
            }
        }

        public ActionResult Fines()
        {
            try
            {
                using (var db = new Model1())
                {
                    // Get the first/latest late payment penalty record as single content page
                    var data = db.tblLatePaymentPenalties
                        .OrderByDescending(x => (DateTime?)x.ModifiedDate ?? x.CreatedDate)
                        .FirstOrDefault();

                    if (data == null)
                    {
                        data = new tblLatePaymentPenalty
                        {
                            PenaltyID = 0,
                            PenaltyDetail = null,
                            CreatedDate = DateTime.Now,
                            ModifiedDate = null
                        };
                    }

                    ViewBag.Title = "Fines/Penalties on Late Payments";
                    return View(data);
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Error in Fines: {ex.Message}");
                ViewBag.Title = "Fines/Penalties on Late Payments";
                var emptyModel = new tblLatePaymentPenalty
                {
                    PenaltyID = 0,
                    PenaltyDetail = null,
                    CreatedDate = DateTime.Now,
                    ModifiedDate = null
                };
                return View(emptyModel);
            }
        }

        public ActionResult Accommodation()
        {
            try
            {
                using (var db = new Model1())
                {
                    var data = db.tblAccomodations
                        .OrderByDescending(x => (DateTime?)x.UpdatedAt ?? x.CreatedAt)
                        .FirstOrDefault();

                    if (data == null)
                    {
                        data = new tblAccomodation
                        {
                            ID = 0,
                            Title = "Accommodation",
                            PageData = null,
                            CreatedAt = DateTime.Now,
                            UpdatedAt = null
                        };
                    }

                    ViewBag.Title = "Accommodation";
                    return View(data);
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Error in Accommodation: {ex.Message}");
                ViewBag.Title = "Accommodation";
                var emptyModel = new tblAccomodation
                {
                    ID = 0,
                    Title = "Accommodation",
                    PageData = null,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = null
                };
                return View(emptyModel);
            }
        }

        public ActionResult Transport()
        {
            try
            {
                using (var db = new Model1())
                {
                    var data = db.tblAdmTransports
                        .OrderByDescending(x => (DateTime?)x.UpdatedAt ?? x.CreatedAt)
                        .FirstOrDefault();

                    if (data == null)
                    {
                        data = new tblAdmTransport
                        {
                            ID = 0,
                            Title = "Transport",
                            PageData = null,
                            CreatedAt = DateTime.Now,
                            UpdatedAt = null
                        };
                    }

                    ViewBag.Title = "Transport";
                    return View(data);
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Error in Transport: {ex.Message}");
                ViewBag.Title = "Transport";
                var emptyModel = new tblAdmTransport
                {
                    ID = 0,
                    Title = "Transport",
                    PageData = null,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = null
                };
                return View(emptyModel);
            }
        }

        public ActionResult MiscellaneousCharges()
        {
            try
            {
                using (var db = new Model1())
                {
                    var data = db.tblMiscellaneousCharges
                        .OrderByDescending(x => (DateTime?)x.UpdatedAt ?? x.CreatedAt)
                        .FirstOrDefault();

                    if (data == null)
                    {
                        data = new tblMiscellaneousCharge
                        {
                            ID = 0,
                            Title = "Miscellaneous Charges",
                            PageData = null,
                            CreatedAt = DateTime.Now,
                            UpdatedAt = null
                        };
                    }

                    ViewBag.Title = "Miscellaneous Charges";
                    return View(data);
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Error in MiscellaneousCharges: {ex.Message}");
                ViewBag.Title = "Miscellaneous Charges";
                var emptyModel = new tblMiscellaneousCharge
                {
                    ID = 0,
                    Title = "Miscellaneous Charges",
                    PageData = null,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = null
                };
                return View(emptyModel);
            }
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
