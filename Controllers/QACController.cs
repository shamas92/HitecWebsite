using System;
using System.Linq;
using System.Web.Mvc;
using System.Text.RegularExpressions;
using Website.Models;

namespace Website.Controllers
{
    public class QACController : Controller
    {
        // GET: /QAC (About)
        public ActionResult Index()
        {
            try
            {
                using (var db = new Model1())
                {
                    var qac = db.tblQACs
                        .OrderByDescending(x => x.ModifiedDate ?? x.UploadedDate)
                        .FirstOrDefault();

                    if (qac == null)
                    {
                        qac = new tblQAC
                        {
                            PageTitle = "Quality Assurance Cell (QAC)",
                            PageText = @"<p>The Quality Assurance Cell (QAC) at HITEC University is committed to fostering a culture of continuous improvement in teaching, learning, and research.</p>
                                       <ul>
                                           <li>Developing and implementing quality benchmarks</li>
                                           <li>Ensuring program and institutional accreditation readiness</li>
                                           <li>Facilitating feedback and improvement cycles</li>
                                           <li>Supporting outcomes-based education (OBE) practices</li>
                                       </ul>
                                       <p>This is placeholder content and will be replaced automatically when data is added in the database (tblQAC).</p>",
                            UploadedDate = DateTime.UtcNow
                        };
                    }

                    ViewBag.Title = qac.PageTitle ?? "Quality Assurance Cell";
                    var plain = Regex.Replace(qac.PageText ?? string.Empty, "<.*?>", string.Empty);
                    ViewBag.MetaDescription = (plain.Length > 155) ? plain.Substring(0, 155) : (plain.Length > 0 ? plain : "HITEC University Quality Assurance Cell (QAC) – fostering continuous improvement and academic excellence.");
                    ViewBag.ActiveQAC = "About";

                    return View(qac);
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"QAC Index Error: {ex.Message}");
                var fallback = new tblQAC
                {
                    PageTitle = "Quality Assurance Cell (QAC)",
                    PageText = "<p>Content is currently unavailable. Please check back later.</p>"
                };
                ViewBag.Title = fallback.PageTitle;
                ViewBag.MetaDescription = "HITEC University Quality Assurance Cell (QAC).";
                ViewBag.ActiveQAC = "About";
                return View(fallback);
            }
        }

        public ActionResult Policy()
        {
            using (var db = new Model1())
            {
                var pol = db.tblQAPolicies.OrderByDescending(x => x.ModifiedDate ?? x.UploadedDate).FirstOrDefault()
                          ?? new tblQAPolicy { PageTitle = "Quality Assurance Policy Statement", PageText = "<p>Policy content is currently unavailable. Please check back later.</p>" };
                ViewBag.Title = pol.PageTitle ?? "Quality Assurance Policy";
                ViewBag.ActiveQAC = "Policy";
                return View(pol);
            }
        }

        public ActionResult AnnualActivityCalendar()
        {
            using (var db = new Model1())
            {
                var aac = db.tblQACAnnualActivityCalenders.OrderByDescending(x => x.ModifiedDate ?? x.UploadedDate).FirstOrDefault()
                          ?? new tblQACAnnualActivityCalender { PdfFileName = "Annual Activity Calendar", PdfFilePath = null };
                ViewBag.Title = aac.PdfFileName ?? "Annual Activity Calendar";
                ViewBag.ActiveQAC = "AnnualActivityCalendar";
                return View(aac);
            }
        }

        public ActionResult Organogram()
        {
            using (var db = new Model1())
            {
                var org = db.tblQACOrganograms.OrderByDescending(x => x.ModifiedDate ?? x.UploadedDate).FirstOrDefault()
                          ?? new tblQACOrganogram { PageTitle = "QAC Organogram", PageText = "<p>Organogram details are currently unavailable. Please check back later.</p>" };
                ViewBag.Title = org.PageTitle ?? "QAC Organogram";
                ViewBag.ActiveQAC = "Organogram";
                return View(org);
            }
        }

        public ActionResult IPE()
        {
            using (var db = new Model1())
            {
                var ipe = db.tblQACIPEs.OrderByDescending(x => x.ModifiedDate ?? x.UploadedDate).FirstOrDefault()
                          ?? new tblQACIPE { PageTitle = "Internal Program Evaluation (IPE)", PageText = "<p>IPE information is currently unavailable. Please check back later.</p>" };
                ViewBag.Title = ipe.PageTitle ?? "Internal Program Evaluation (IPE)";
                ViewBag.ActiveQAC = "IPE";
                return View(ipe);
            }
        }

        public ActionResult RIPE()
        {
            // No table detected for RIPE; show dummy content
            ViewBag.Title = "RIPE";
            ViewBag.ActiveQAC = "RIPE";
            ViewBag.RIPEHtml = "<p>RIPE information is currently unavailable. Please check back later.</p>";
            return View();
        }

        public ActionResult PGPR()
        {
            using (var db = new Model1())
            {
                var pgpr = db.tblQACPGPRs.OrderByDescending(x => x.ModifiedDate ?? x.UploadedDate).FirstOrDefault()
                           ?? new tblQACPGPR { PageTitle = "Program Governance & Performance Review (PGPR)", PageText = "<p>PGPR content is currently unavailable. Please check back later.</p>" };
                ViewBag.Title = pgpr.PageTitle ?? "PGPR";
                ViewBag.ActiveQAC = "PGPR";
                return View(pgpr);
            }
        }

        public ActionResult SAR()
        {
            using (var db = new Model1())
            {
                var sar = db.tblQACSARs.OrderByDescending(x => x.ModifiedDate ?? x.UploadedDate).FirstOrDefault()
                          ?? new tblQACSAR { PageTitle = "Self-Assessment Reports (SARs)", PageText = "<p>SAR content is currently unavailable. Please check back later.</p>" };
                ViewBag.Title = sar.PageTitle ?? "SARs";
                ViewBag.ActiveQAC = "SAR";
                return View(sar);
            }
        }

        public ActionResult Survey()
        {
            using (var db = new Model1())
            {
                var surv = db.tblQACSurvays.OrderByDescending(x => x.ModifiedDate ?? x.UploadedDate).FirstOrDefault()
                           ?? new tblQACSurvay { PageTitle = "QAC Surveys", PageText = "<p>Survey content is currently unavailable. Please check back later.</p>" };
                ViewBag.Title = surv.PageTitle ?? "Surveys";
                ViewBag.ActiveQAC = "Survey";
                return View(surv);
            }
        }

        public ActionResult Accreditation()
        {
            using (var db = new Model1())
            {
                var acc = db.tblQACAccreditations.OrderByDescending(x => x.ModifiedDate ?? x.UploadedDate).FirstOrDefault()
                          ?? new tblQACAccreditation { PageTitle = "QAC Accreditation", PageText = "<p>Accreditation content is currently unavailable. Please check back later.</p>" };
                ViewBag.Title = acc.PageTitle ?? "Accreditation";
                ViewBag.ActiveQAC = "Accreditation";
                return View(acc);
            }
        }

        public ActionResult Contact()
        {
            using (var db = new Model1())
            {
                var contact = db.tblQACContacts.OrderByDescending(x => x.ModifiedDate ?? x.UploadedDate).FirstOrDefault()
                              ?? new tblQACContact { PageTitle = "QAC Contact", PageText = "<p>Contact information is currently unavailable. Please check back later.</p>" };
                ViewBag.Title = contact.PageTitle ?? "Contact";
                ViewBag.ActiveQAC = "Contact";
                return View(contact);
            }
        }
    }
}
