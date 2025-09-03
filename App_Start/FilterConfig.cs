using System.Web;
using System.Web.Mvc;
using Website.Analytics;

namespace Website
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
            filters.Add(new AnalyticsTrackingFilter()); // analytics tracking
        }
    }
}
