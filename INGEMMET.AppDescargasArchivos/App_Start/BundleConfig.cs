using System.Web;
using System.Web.Optimization;

namespace INGEMMET.AppDescargasArchivos
{
    public class BundleConfig
    {
        // Para obtener más información acerca de Bundling, consulte http://go.microsoft.com/fwlink/?LinkId=254725
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.IgnoreList.Clear();

            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                "~/Scripts/jquery-{version}.js"));


            //// Scripts jQuery DataTables
            //bundles.Add(new ScriptBundle("~/DataTables/js")
            //    .Include("~/Scripts/DataTables/jquery.dataTables.min.js")
            //    .Include("~/Scripts/DataTables/dataTables.bootstrap.min.js")
            //    .Include("~/Scripts/DataTables/dataTables.responsive.min.js")
            //    .Include("~/Scripts/DataTables/responsive.bootstrap.min.js")
            //    .Include("~/Scripts/DataTables/dataTables.language.es.js"));

            //// Scripts Validación de Formularios
            //bundles.Add(new ScriptBundle("~/bundles/forms")
            //    .Include("~/Scripts/jquery.validate.min.js")
            //    .Include("~/Scripts/jquery.validate.unobtrusive.min.js")
            //    .Include("~/Scripts/general.js"));

            //// Scripts Base para el Funcionamiento del Módulo
            //bundles.Add(new ScriptBundle("~/bundles/base")
            //    .Include("~/Scripts/bootstrap.min.js")
            //    .Include("~/Scripts/eflexis/eflexis.dialog.js")
            //    .Include("~/Scripts/eflexis/jquery.eflexis.dialog.js")
            //    .Include("~/Scripts/jquery.icheck.min.js")
            //    .Include("~/Scripts/jquery-ui-1.12.1.min.js")
            //    .Include("~/Scripts/jquery.base64.js")
            //    .Include("~/Scripts/jquery-ui-extend.js")
            //    .Include("~/Scripts/smartresize.js")
            //    .Include("~/Scripts/Site.js"));

            //// Scripts jquery select2
            //bundles.Add(new ScriptBundle("~/SelectBox/js")
            //    .Include("~/Scripts/select2/select2.full.min.js")
            //    .Include("~/Scripts/select2/es.js"));

            //// Styles jQuery DataTables
            //bundles.Add(new StyleBundle("~/Content/DataTables/base").Include(
            //    "~/Content/DataTables/base.css"));

            //// Styles Base
            bundles.Add(new StyleBundle("~/Content/css")
                .Include("~/Content/bootstrap.min.css")
                .Include("~/Content/bootstrap-theme.min.css")
            //    .Include("~/Content/font-awesome.min.css")
                .Include("~/Content/Site.css"));
        }
    }
}
