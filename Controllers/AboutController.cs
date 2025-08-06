using System.Web.Mvc;
using System.Linq;
using Website.Models;
using HitecCM.Models;

namespace Website.Controllers
{
    public class AboutController : Controller
    {
        public ActionResult Index()
        {
            using (var db = new Model1())
            {
                var faculty = db.tblFaculties
                    .Where(f => (f.AdDesignation != null && (f.AdDesignation.Contains("Head of Program") || f.AdDesignation.Contains("Chairperson"))))
                    .Where(f => f.Active == true)
                    .OrderBy(f => f.OrderNo)
                    .ToList();
                return View(faculty);
            }
        }

        public ActionResult ChairmanMessage()
        {
            using (var db = new Model1())
            {
                // Get the first record or create a default one if none exists
                var about = db.tblAbouts.OrderByDescending(a => a.id).FirstOrDefault();
                if (about == null)
                {
                    // Create a default object to prevent null reference exception
                    about = new tblAbout
                    {
                        id = 0,
                        chairman_message = "",
                        vc_message = "",
                        motto = "",
                        vision = "",
                        mission = "",
                        emblem = "",
                        chairman_image = "",
                        vc_image = ""
                    };
                }
                return View(about);
            }
        }

        public ActionResult VcMessage()
        {
            using (var db = new Model1())
            {
                var about = db.tblAbouts.OrderByDescending(a => a.id).FirstOrDefault();
                if (about == null)
                {
                    // Create a default object to prevent null reference exception
                    about = new tblAbout
                    {
                        id = 0,
                        chairman_message = "",
                        vc_message = "",
                        motto = "",
                        vision = "",
                        mission = "",
                        emblem = "",
                        chairman_image = "",
                        vc_image = ""
                    };
                }
                return View(about);
            }
        }

        public ActionResult Motto()
        {
            using (var db = new Model1())
            {
                var about = db.tblAbouts.OrderByDescending(a => a.id).FirstOrDefault();
                if (about == null)
                {
                    // Create a default object to prevent null reference exception
                    about = new tblAbout
                    {
                        id = 0,
                        chairman_message = "",
                        vc_message = "",
                        motto = "",
                        vision = "",
                        mission = "",
                        emblem = "",
                        chairman_image = "",
                        vc_image = ""
                    };
                }
                return View(about);
            }
        }

        public ActionResult VisionMission()
        {
            using (var db = new Model1())
            {
                var about = db.tblAbouts.OrderByDescending(a => a.id).FirstOrDefault();
                if (about == null)
                {
                    // Create a default object to prevent null reference exception
                    about = new tblAbout
                    {
                        id = 0,
                        chairman_message = "",
                        vc_message = "",
                        motto = "",
                        vision = "",
                        mission = "",
                        emblem = "",
                        chairman_image = "",
                        vc_image = ""
                    };
                }
                return View(about);
            }
        }

        public ActionResult Emblem()
        {
            using (var db = new Model1())
            {
                var about = db.tblAbouts.OrderByDescending(a => a.id).FirstOrDefault();
                if (about == null)
                {
                    // Create a default object to prevent null reference exception
                    about = new tblAbout
                    {
                        id = 0,
                        chairman_message = "",
                        vc_message = "",
                        motto = "",
                        vision = "",
                        mission = "",
                        emblem = "",
                        chairman_image = "",
                        vc_image = ""
                    };
                }
                return View(about);
            }
        }
    }
} 