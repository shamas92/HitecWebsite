using System.Web.Mvc;

namespace Website.Controllers
{
    public class ProgramController : Controller
    {
        // GET: /Program/ME
        public ActionResult ME()
        {
            ViewBag.Title = "Mechanical Engineering";
            ViewBag.MetaDescription = "Explore the Mechanical Engineering undergraduate program at HITEC University, including curriculum, labs, and career opportunities.";
            ViewBag.MetaKeywords = "Mechanical Engineering, ME program, undergraduate, engineering, HITEC University";
            return View();
        }
    }
}
