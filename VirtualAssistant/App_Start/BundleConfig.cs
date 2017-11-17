using System.Web;
using System.Web.Optimization;

namespace VirtualAssistant
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/lib").Include(
                        "~/Scripts/jquery-{version}.js",
                        "~/Scripts/bootstrap.js",
                        "~/Scripts/bootbox.js",
                        "~/Scripts/respond.js",
                        "~/Scripts/datatables/jquery.datatables.js",
                        "~/Scripts/datatables/datatables.bootsrap.js",
                        "~/Scripts/datatables/datatables.bootsrap.js",
                        "~/Scripts/toastr.js"
                        ));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));
            bundles.Add(new ScriptBundle("~/admin-lte/js").Include(
                     "~/admin-lte/js/adminlte.js",
                     "~/admin-lte/plugins/fastclick/fastclick.js",
                     "~/admin-lte/plugins/bootstrap-wysihtml5/bootstrap3-wysihtml5.all.min.js"
             ));
            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css",
                      "~/Content/datatables/css/datatables.bootsrap.css",
                      "~/admin-lte/css/AdminLTE.css",
                      "~/admin-lte/css/skins/skin-yellow.css",
                      "~/admin-lte/plugins/bootstrap-wysihtml5/bootstrap3-wysihtml5.min.css"));
        }
    }
}
