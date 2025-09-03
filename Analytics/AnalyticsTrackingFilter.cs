using System.Web.Mvc;
using Website.Analytics;

namespace Website.Analytics
{
    // Global filter to track a single logical page view per full MVC view result.
    public class AnalyticsTrackingFilter : ActionFilterAttribute
    {
        private readonly IAnalyticsTracker _tracker;
        private const string TrackedFlagKey = "__AnalyticsTracked";

        public AnalyticsTrackingFilter() : this(new AnalyticsTracker()) { }
        public AnalyticsTrackingFilter(IAnalyticsTracker tracker) { _tracker = tracker; }

        public override void OnResultExecuted(ResultExecutedContext filterContext)
        {
            if (filterContext == null) return;
            var ctx = filterContext.HttpContext;
            if (ctx == null) return;

            // Skip if already tracked in this request
            if (ctx.Items[TrackedFlagKey] != null) return;

            // Skip child actions / partial invocations
            if (filterContext.IsChildAction) return;

            // Only track standard view results (skip JsonResult, FileResult, Redirects etc.)
            if (!(filterContext.Result is ViewResultBase)) return;

            // Skip redirects and non-success codes
            var status = ctx.Response.StatusCode;
            if (status >= 300 && status < 400) return;

            // Skip AJAX requests
            if (ctx.Request.IsAjaxRequest()) return;

            // Mark as tracked to avoid duplicates from other lifecycle events
            ctx.Items[TrackedFlagKey] = true;

            _tracker.Track(ctx);
        }
    }
}
