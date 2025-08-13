using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;

namespace Website.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            using (var db = new Website.Models.Model1())
            {
                var faculty = db.tblFaculties
                    .Where(f => (f.AdDesignation != null && (f.AdDesignation.Contains("Head of Program") || f.AdDesignation.Contains("Chairperson"))))
                    .Where(f => f.Active == true)
                    .OrderBy(f => f.OrderNo)
                    .ToList();
                return View(faculty);
            }
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}