using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using System.Web.Security;
using System.Web.SessionState;
using Website.Analytics; // added

namespace Website
{
    public class MvcApplication : System.Web.HttpApplication
    {
        // single shared tracker instance
        private static readonly IAnalyticsTracker _analyticsTracker = new AnalyticsTracker();

        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }

        protected void Application_BeginRequest()
        {
            try
            {
                if (Context != null)
                {
                    _analyticsTracker.Track(new HttpContextWrapper(Context));
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine("Analytics BeginRequest error: " + ex.Message);
            }
        }

        // Enhanced error handling with configurable custom error pages
        protected void Application_Error(object sender, EventArgs e)
        {
            Exception exception = Server.GetLastError();
            
            if (exception != null)
            {
                // Log error details for debugging purposes
                System.Diagnostics.Debug.WriteLine($"Application Error: {exception.Message}");
                System.Diagnostics.Debug.WriteLine($"Stack Trace: {exception.StackTrace}");
                
                // Check if custom error pages are enabled
                bool enableCustomErrorPages = bool.Parse(System.Configuration.ConfigurationManager.AppSettings["EnableCustomErrorPages"] ?? "true");
                bool adminDebugMode = bool.Parse(System.Configuration.ConfigurationManager.AppSettings["AdminDebugMode"] ?? "false");
                
                // If custom error pages are disabled or admin debug mode is enabled, allow default ASP.NET error handling
                if (!enableCustomErrorPages || adminDebugMode)
                {
                    return; // Let ASP.NET handle the error with detailed error pages
                }
                
                // Get the HTTP status code if available
                var httpException = exception as HttpException;
                int statusCode = httpException?.GetHttpCode() ?? 500;
                
                // Clear the error to prevent default error handling
                Server.ClearError();
                
                // Route to appropriate error page based on status code
                var routeData = new RouteData();
                routeData.Values["controller"] = "Error";
                
                switch (statusCode)
                {
                    case 404:
                        routeData.Values["action"] = "NotFound";
                        break;
                    case 403:
                        routeData.Values["action"] = "AccessDenied";
                        break;
                    case 503:
                        routeData.Values["action"] = "Maintenance";
                        break;
                    default:
                        routeData.Values["action"] = "Index";
                        break;
                }
                
                routeData.Values["statusCode"] = statusCode;
                routeData.Values["exception"] = exception; // Pass exception for debug view
                
                // Execute the error controller
                IController errorController = new Website.Controllers.ErrorController();
                var requestContext = new RequestContext(new HttpContextWrapper(Context), routeData);
                errorController.Execute(requestContext);
            }
        }
    }
}
