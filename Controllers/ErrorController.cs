using System;
using System.Configuration;
using System.Web;
using System.Web.Mvc;

namespace Website.Controllers
{
    public class ErrorController : Controller
    {
        // Helper method to check if custom error pages are enabled
        private bool IsCustomErrorPagesEnabled()
        {
            return bool.Parse(ConfigurationManager.AppSettings["EnableCustomErrorPages"] ?? "true");
        }
        
        // Helper method to check if admin debug mode is enabled
        private bool IsAdminDebugMode()
        {
            return bool.Parse(ConfigurationManager.AppSettings["AdminDebugMode"] ?? "false");
        }
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

        // Admin Panel for Error Handling Configuration
        public ActionResult AdminPanel()
        {
            ViewBag.Title = "Error Handling Admin Panel";
            ViewBag.EnableCustomErrorPages = IsCustomErrorPagesEnabled();
            ViewBag.AdminDebugMode = IsAdminDebugMode();
            
            return View();
        }
        
        // Toggle Custom Error Pages
        [HttpPost]
        public ActionResult ToggleCustomErrorPages()
        {
            try
            {
                var config = System.Web.Configuration.WebConfigurationManager.OpenWebConfiguration("~");
                var appSettings = config.AppSettings.Settings;
                
                bool currentValue = bool.Parse(appSettings["EnableCustomErrorPages"]?.Value ?? "true");
                bool newValue = !currentValue;
                
                if (appSettings["EnableCustomErrorPages"] == null)
                {
                    appSettings.Add("EnableCustomErrorPages", newValue.ToString());
                }
                else
                {
                    appSettings["EnableCustomErrorPages"].Value = newValue.ToString();
                }
                
                config.Save();
                
                TempData["SuccessMessage"] = $"Custom error pages {(newValue ? "enabled" : "disabled")} successfully!";
            }
            catch (Exception ex)
            {
                TempData["ErrorMessage"] = $"Failed to toggle custom error pages: {ex.Message}";
            }
            
            return RedirectToAction("AdminPanel");
        }
        
        // Toggle Admin Debug Mode
        [HttpPost]
        public ActionResult ToggleAdminDebugMode()
        {
            try
            {
                var config = System.Web.Configuration.WebConfigurationManager.OpenWebConfiguration("~");
                var appSettings = config.AppSettings.Settings;
                
                bool currentValue = bool.Parse(appSettings["AdminDebugMode"]?.Value ?? "false");
                bool newValue = !currentValue;
                
                if (appSettings["AdminDebugMode"] == null)
                {
                    appSettings.Add("AdminDebugMode", newValue.ToString());
                }
                else
                {
                    appSettings["AdminDebugMode"].Value = newValue.ToString();
                }
                
                config.Save();
                
                TempData["SuccessMessage"] = $"Admin debug mode {(newValue ? "enabled" : "disabled")} successfully!";
            }
            catch (Exception ex)
            {
                TempData["ErrorMessage"] = $"Failed to toggle admin debug mode: {ex.Message}";
            }
            
            return RedirectToAction("AdminPanel");
        }
        
        // Debug view for detailed error information
        public ActionResult Debug(int? statusCode = null, string exceptionMessage = null, string stackTrace = null)
        {
            ViewBag.Title = "Error Debug Information";
            ViewBag.StatusCode = statusCode;
            ViewBag.ExceptionMessage = exceptionMessage ?? "No exception details available";
            ViewBag.StackTrace = stackTrace ?? "No stack trace available";
            ViewBag.IsAdminDebugMode = IsAdminDebugMode();
            ViewBag.EnableCustomErrorPages = IsCustomErrorPagesEnabled();
            
            return View();
        }

        // Test page to demonstrate all error types (for development/testing)
        public ActionResult Test()
        {
            ViewBag.Title = "Error Page Test";
            ViewBag.EnableCustomErrorPages = IsCustomErrorPagesEnabled();
            ViewBag.AdminDebugMode = IsAdminDebugMode();
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
        
        // Test method to trigger actual exception for debugging
        public ActionResult TestException()
        {
            throw new InvalidOperationException("This is a test exception for debugging purposes.");
        }
    }
}