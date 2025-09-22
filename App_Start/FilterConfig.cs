using System.Web;
using System.Web.Mvc;
using Website.Analytics;

namespace Website
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            var handleError = new HandleErrorAttribute
            {
                View = "Error", // use our custom Error view for MVC exceptions
                ExceptionType = typeof(System.Exception),
                Order = 1
            };
            // Render error views with minimal layout to avoid nested failures
            filters.Add(handleError);
            filters.Add(new AnalyticsTrackingFilter()); // analytics tracking
        }
    }
}
