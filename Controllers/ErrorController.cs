using System;
using System.Web;
using System.Web.Mvc;

namespace Website.Controllers
{
    public class ErrorController : Controller
    {
        // GET: Error/NotFound (404)
        public ActionResult NotFound()
        {
            Response.StatusCode = 404;
            Response.TrySkipIisCustomErrors = true;
            
            ViewBag.Title = "Page Not Found";
            ViewBag.MetaDescription = "The page you are looking for could not be found on HITEC University website.";
            ViewBag.ErrorCode = "404";
            ViewBag.ErrorType = "Page Not Found";
            ViewBag.ErrorMessage = "The page you are looking for might have been removed, had its name changed, or is temporarily unavailable.";
            
            return View();
        }

        // GET: Error/Index (500 - Server Error)
        public ActionResult Index()
        {
            Response.StatusCode = 500;
            Response.TrySkipIisCustomErrors = true;
            
            ViewBag.Title = "Internal Server Error";
            ViewBag.MetaDescription = "An internal server error occurred on HITEC University website.";
            ViewBag.ErrorCode = "500";
            ViewBag.ErrorType = "Internal Server Error";
            ViewBag.ErrorMessage = "We're experiencing technical difficulties. Our team has been notified and is working to resolve the issue.";
            
            return View();
        }

        // GET: Error/UnderConstruction
        public ActionResult UnderConstruction()
        {
            ViewBag.Title = "Under Construction";
            ViewBag.MetaDescription = "This section of HITEC University website is currently under construction.";
            ViewBag.ErrorCode = "🚧";
            ViewBag.ErrorType = "Under Construction";
            ViewBag.ErrorMessage = "This page is currently being developed and will be available soon. Thank you for your patience!";
            
            return View();
        }

        // GET: Error/Maintenance
        public ActionResult Maintenance()
        {
            Response.StatusCode = 503;
            Response.TrySkipIisCustomErrors = true;
            
            ViewBag.Title = "Maintenance Mode";
            ViewBag.MetaDescription = "HITEC University website is currently under maintenance.";
            ViewBag.ErrorCode = "503";
            ViewBag.ErrorType = "Service Temporarily Unavailable";
            ViewBag.ErrorMessage = "We're performing scheduled maintenance to improve your experience. Please check back shortly.";
            
            return View();
        }

        // GET: Error/AccessDenied
        public ActionResult AccessDenied()
        {
            Response.StatusCode = 403;
            Response.TrySkipIisCustomErrors = true;
            
            ViewBag.Title = "Access Denied";
            ViewBag.MetaDescription = "Access denied to the requested resource on HITEC University website.";
            ViewBag.ErrorCode = "403";
            ViewBag.ErrorType = "Access Denied";
            ViewBag.ErrorMessage = "You don't have permission to access this resource. Please contact the administrator if you believe this is an error.";
            
            return View();
        }

        // Generic error handler
        public ActionResult GeneralError(int? statusCode = null)
        {
            if (statusCode.HasValue)
            {
                Response.StatusCode = statusCode.Value;
                Response.TrySkipIisCustomErrors = true;
            }

            ViewBag.Title = "Unexpected Error";
            ViewBag.MetaDescription = "An unexpected error occurred on HITEC University website.";
            ViewBag.ErrorCode = statusCode?.ToString() ?? "Error";
            ViewBag.ErrorType = "Unexpected Error";
            ViewBag.ErrorMessage = "Something unexpected happened. We apologize for the inconvenience and are working to resolve this issue.";
            
            return View("Index");
        }

        // Test page to demonstrate all error types (for development/testing)
        public ActionResult Test()
        {
            ViewBag.Title = "Error Page Test";
            return View();
        }

        // Test methods to trigger different error types
        public ActionResult Test404()
        {
            return RedirectToAction("NotFound");
        }

        public ActionResult Test500()
        {
            return RedirectToAction("Index");
        }

        public ActionResult TestConstruction()
        {
            return RedirectToAction("UnderConstruction");
        }

        public ActionResult TestMaintenance()
        {
            return RedirectToAction("Maintenance");
        }

        public ActionResult TestAccessDenied()
        {
            return RedirectToAction("AccessDenied");
        }
    }
}