using System.Web;
using System.Web.Optimization;

namespace SachOnline
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                        "~/Scripts/bootstrap.js"));

            bundles.Add(new ScriptBundle("~/bundles/datatables").Include(
                        "~/Scripts/jquery.unobtrusive-ajax.js",
                        "~/Scripts/jquery.dataTables.js",
                        "~/Scripts/dataTables.bootstrap.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                        "~/Content/all.css",
                        "~/Content/bootstrap.css"));

            bundles.Add(new StyleBundle("~/Content/Admin/css").Include(
                        "~/Content/structure.css",
                        "~/Content/reset.css"));

            bundles.Add(new StyleBundle("~/Content/datatables").Include(
                        "~/Content/dataTables.bootstrap4.css"));
        }
    }
}
