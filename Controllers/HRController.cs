using System;
using System.Linq;
using System.Web.Mvc;
using Website.Models;
using HitecCM.Models;

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
                    // Try to get the latest classification/services record
                    var data = db.tblHrClassificationServices
                        .OrderByDescending(x => (DateTime?)x.UpdatedAt ?? x.CreatedAt)
                        .FirstOrDefault();

                    // If no data exists, create a placeholder object for the view
                    if (data == null)
                    {
                        data = new tblHrClassificationServices
                        {
                            ID = 0,
                            Title = "Employment Types & Classification",
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
                System.Diagnostics.Debug.WriteLine($"Error in TypesAndClassification: {ex.Message}");
                // Return empty model on error
                var emptyModel = new tblHrClassificationServices
                {
                    ID = 0,
                    Title = "Employment Types & Classification",
                    PageData = null,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = null
                };
                return View(emptyModel);
            }
        }

        // GET: HR/EligibilityRecruitment
        public ActionResult EligibilityRecruitment()
        {
            try
            {
                using (var db = new Model1())
                {
                    var data = db.tblHrESTRs
                        .OrderByDescending(x => (DateTime?)x.UpdatedAt ?? x.CreatedAt)
                        .FirstOrDefault();

                    if (data == null)
                    {
                        data = new tblHrESTR
                        {
                            ID = 0,
                            Title = "Eligibility, Recruitment/Selection, Termination, Resignation",
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
                System.Diagnostics.Debug.WriteLine($"Error in EligibilityRecruitment: {ex.Message}");
                var emptyModel = new tblHrESTR
                {
                    ID = 0,
                    Title = "Eligibility, Recruitment/Selection, Termination, Resignation",
                    PageData = null,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = null
                };
                return View(emptyModel);
            }
        }

        // GET: HR/PerksPrivileges
        public ActionResult PerksPrivileges()
        {
            try
            {
                using (var db = new Model1())
                {
                    var data = db.tblHrPerks
                        .OrderByDescending(x => (DateTime?)x.UpdatedAt ?? x.CreatedAt)
                        .FirstOrDefault();

                    if (data == null)
                    {
                        data = new tblHrPerks
                        {
                            ID = 0,
                            Title = "Perks & Privileges",
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
                System.Diagnostics.Debug.WriteLine($"Error in PerksPrivileges: {ex.Message}");
                var emptyModel = new tblHrPerks
                {
                    ID = 0,
                    Title = "Perks & Privileges",
                    PageData = null,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = null
                };
                return View(emptyModel);
            }
        }

        // GET: HR/Leave
        public ActionResult Leave()
        {
            try
            {
                using (var db = new Model1())
                {
                    var data = db.tblHrLeaves
                        .OrderByDescending(x => (DateTime?)x.UpdatedAt ?? x.CreatedAt)
                        .FirstOrDefault();

                    if (data == null)
                    {
                        data = new tblHrLeaves
                        {
                            ID = 0,
                            Title = "Leave Policies & Procedures",
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
                System.Diagnostics.Debug.WriteLine($"Error in Leave: {ex.Message}");
                var emptyModel = new tblHrLeaves
                {
                    ID = 0,
                    Title = "Leave Policies & Procedures",
                    PageData = null,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = null
                };
                return View(emptyModel);
            }
        }

        // GET: HR/ContributoryFund
        public ActionResult ContributoryFund()
        {
            try
            {
                using (var db = new Model1())
                {
                    var data = db.tblHrContributoryFunds
                        .OrderByDescending(x => (DateTime?)x.UpdatedAt ?? x.CreatedAt)
                        .FirstOrDefault();

                    if (data == null)
                    {
                        data = new tblHrContributoryFund
                        {
                            ID = 0,
                            Title = "Contributory Fund",
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
                System.Diagnostics.Debug.WriteLine($"Error in ContributoryFund: {ex.Message}");
                var emptyModel = new tblHrContributoryFund
                {
                    ID = 0,
                    Title = "Contributory Fund",
                    PageData = null,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = null
                };
                return View(emptyModel);
            }
        }

        // GET: HR/ConductDiscipline
        public ActionResult ConductDiscipline()
        {
            try
            {
                using (var db = new Model1())
                {
                    var data = db.tblHrDisciplines
                        .OrderByDescending(x => (DateTime?)x.UpdatedAt ?? x.CreatedAt)
                        .FirstOrDefault();

                    if (data == null)
                    {
                        data = new tblHrDiscipline
                        {
                            ID = 0,
                            Title = "Conduct and Discipline",
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
                System.Diagnostics.Debug.WriteLine($"Error in ConductDiscipline: {ex.Message}");
                var emptyModel = new tblHrDiscipline
                {
                    ID = 0,
                    Title = "Conduct and Discipline",
                    PageData = null,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = null
                };
                return View(emptyModel);
            }
        }
    }
}