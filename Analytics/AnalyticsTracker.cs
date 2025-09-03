using System;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Web;
using Website.Models;
using HitecCM.Models;

namespace Website.Analytics
{
    public interface IAnalyticsTracker
    {
        void Track(HttpContextBase httpContext);
    }

    public class AnalyticsTracker : IAnalyticsTracker
    {
        private const string SessionCookieName = "vw_sid";
        private static readonly string IpSalt = System.Configuration.ConfigurationManager.AppSettings["AnalyticsIpSalt"] ?? "static-fallback-salt-change";

        public void Track(HttpContextBase httpContext)
        {
            try
            {
                var request = httpContext.Request;
                var response = httpContext.Response;

                if (httpContext.Items.Contains("__AnalyticsTrackedCore")) return; // defensive
                httpContext.Items["__AnalyticsTrackedCore"] = true;

                if (!string.Equals(request.HttpMethod, "GET", System.StringComparison.OrdinalIgnoreCase)) return;
                var path = request.Url?.AbsolutePath?.ToLowerInvariant() ?? string.Empty;
                if (path.StartsWith("/content/") || path.StartsWith("/scripts/") || path.EndsWith(".axd")) return;

                var ua = request.UserAgent ?? string.Empty;
                bool isBot = IsLikelyBot(ua);
                var sessionKey = EnsureSessionCookie(request, response);
                var nowUtc = System.DateTime.UtcNow;

                using (var db = new Model1())
                {
                    // Find or create session
                    var session = db.tblVisitSessions.FirstOrDefault(s => s.SessionKey == sessionKey);
                    if (session == null)
                    {
                        session = new tblVisitSession
                        {
                            SessionKey = sessionKey,
                            FirstSeenUtc = nowUtc,
                            LastSeenUtc = nowUtc,
                            PageViews = 0,
                            UserAgent = Truncate(ua, 256),
                            ReferrerHost = Truncate(request.UrlReferrer != null ? request.UrlReferrer.Host : null, 255),
                            IpHash = HashIp(GetClientIp(request)),
                            IsBot = isBot
                        };
                        db.tblVisitSessions.Add(session);
                        db.SaveChanges(); // need identity before adding page view
                    }
                    else
                    {
                        session.LastSeenUtc = nowUtc;
                        if (session.IsBot != isBot && isBot)
                        {
                            session.IsBot = true;
                        }
                        db.Entry(session).Property(x => x.LastSeenUtc).IsModified = true;
                        if (isBot) db.Entry(session).Property(x => x.IsBot).IsModified = true;
                    }

                    // Add page view
                    var pageView = new tblPageView
                    {
                        VisitSessionId = session.VisitSessionId,
                        Path = Truncate(request.Url?.AbsolutePath, 300) ?? "/",
                        ViewUtc = nowUtc,
                        StatusCode = (short)response.StatusCode,
                        UserId = null
                    };
                    db.tblPageViews.Add(pageView);

                    session.PageViews += 1;
                    db.Entry(session).Property(x => x.PageViews).IsModified = true;

                    db.SaveChanges();
                }
            }
            catch
            {
                // swallow errors
            }
        }

        private static string EnsureSessionCookie(HttpRequestBase request, HttpResponseBase response)
        {
            var cookie = request.Cookies[SessionCookieName];
            if (cookie != null && !string.IsNullOrWhiteSpace(cookie.Value)) return cookie.Value;
            var key = System.Guid.NewGuid().ToString("N");
            var newCookie = new HttpCookie(SessionCookieName, key)
            {
                Expires = System.DateTime.UtcNow.AddYears(1),
                HttpOnly = true,
                Secure = request.IsSecureConnection,
                SameSite = SameSiteMode.Lax
            };
            response.Cookies.Add(newCookie);
            return key;
        }

        private static byte[] HashIp(string ip)
        {
            if (string.IsNullOrEmpty(ip)) return null;
            try
            {
                using (var sha = SHA256.Create())
                {
                    return sha.ComputeHash(Encoding.UTF8.GetBytes(ip + IpSalt));
                }
            }
            catch { return null; }
        }

        private static string GetClientIp(HttpRequestBase request)
        {
            var ip = request.ServerVariables["HTTP_X_FORWARDED_FOR"];
            if (!string.IsNullOrEmpty(ip))
            {
                var first = ip.Split(',').Select(x => x.Trim()).FirstOrDefault();
                if (!string.IsNullOrEmpty(first)) return first;
            }
            return request.UserHostAddress;
        }

        private static string Truncate(string value, int len)
        {
            if (string.IsNullOrEmpty(value)) return value;
            return value.Length <= len ? value : value.Substring(0, len);
        }

        private static bool IsLikelyBot(string userAgent)
        {
            if (string.IsNullOrEmpty(userAgent)) return false;
            var ua = userAgent.ToLowerInvariant();
            return ua.Contains("bot") || ua.Contains("crawler") || ua.Contains("spider") || ua.Contains("slurp") || ua.Contains("bingpreview");
        }
    }
}
