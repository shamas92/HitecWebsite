using System.Web;
using System.Web.Optimization;

namespace Website
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        //public static void RegisterBundles(BundleCollection bundles)
        //{
        //    bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
        //                "~/Scripts/jquery-3.7.1.min.js"));

        //    bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
        //                "~/Scripts/jquery.validate*"));

        //    // Use the development version of Modernizr to develop with and learn from. Then, when you're
        //    // ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
        //    bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
        //                "~/Scripts/bootstrap.bundle.min.js"));

        //    bundles.Add(new ScriptBundle("~/bundles/main").Include(
        //                "~/Scripts/main.js"));

        //    bundles.Add(new Bundle("~/bundles/modernizr").Include(
        //              "~/Scripts/modernizr.js"));

        //    bundles.Add(new StyleBundle("~/Content/css").Include(
        //              "~/Content/css/bootstrap.min.css",
        //              "~/Content/css/main.css"));
        //}
        //public static void RegisterBundles(BundleCollection bundles)
        //{
        //    bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
        //                "~/Scripts/main.js"
        //));

        //    bundles.Add(new Bundle("~/bundles/modernizr").Include(
        //                  "~/Scripts/modernizr.js"));

        //    // Use the development version of Modernizr to develop with and learn from. Then, when you're
        //    // ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
        //    bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
        //                "~/Scripts/jquery.validate*"));

        //    bundles.Add(new StyleBundle("~/Content/css").Include(
        //              "~/Content/css/main.css",
        //              "~/Content/scss/main.css"));
        //}

        //public static void RegisterBundles(BundleCollection bundles)
        //{
        //    bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
        //                "~/Scripts/jquery-3.7.1.min.js"));

        //    bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
        //                "~/Scripts/bootstrap.bundle.min.js"));

        //    bundles.Add(new ScriptBundle("~/bundles/main").Include(
        //                "~/Scripts/main.js"));

        //    bundles.Add(new Bundle("~/bundles/modernizr").Include(
        //              "~/Scripts/modernizr.js"));

        //    bundles.Add(new StyleBundle("~/Content/css").Include(
        //              "~/Content/css/bootstrap.min.css",
        //              "~/Content/css/main.css"));
        //}

        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new StyleBundle("~/Content/css").Include(
                "~/Content/css/animate.css",
                "~/Content/css/bootstrap.min.css",
                "~/Content/css/line-awesome.css",
                "~/Content/css/fontawesome.css",
                "~/Content/css/main.css",
                "~/Content/css/swiper.min.css",
                "~/Content/css/responsive.css",
                "~/Content/css/faculty-components.css"
            ));
            bundles.Add(new ScriptBundle("~/bundles/main").Include(
                "~/Scripts/main.js"
            ));
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                "~/Scripts/jquery-3.7.1.min.js"
            ));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                "~/Scripts/bootstrap.min.js"
            ));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
               "~/Scripts/bootstrap.bundle.min.js"
           ));

            

            bundles.Add(new ScriptBundle("~/bundles/swiper").Include(
                "~/Scripts/swiper.min.js"
            ));

            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                "~/Scripts/modernizr-2.8.3.js"
            ));

            bundles.Add(new ScriptBundle("~/bundles/vendor").Include(
               "~/Scripts/wow.min.js",
               "~/Scripts/appear.js",
               "~/Scripts/odometer.min.js",
               "~/Scripts/countdown.js",
               "~/Scripts/imagesloaded.pkgd.min.js",
               "~/Scripts/isotope.pkgd.min.js",
               "~/Scripts/parallax-scroll.js",
               "~/Scripts/jquery.nice-select.min.js",
               "~/Scripts/jquery.magnific-popup.min.js"
));

        }

    }
}
