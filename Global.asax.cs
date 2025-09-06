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
    }
}
