using System.Web;
using System.Web.Optimization;

namespace Cetione.Web
{
    public class BundleConfig
    {
        // 有关 Bundling 的详细信息，请访问 http://go.microsoft.com/fwlink/?LinkId=254725
        public static void RegisterBundles(BundleCollection bundles)
        {
            #region -- 基础数据管理模板 --

            /*
            bundles.Add(new StyleBundle("~/Content/basedatamanage").Include(
                                       "~/Content/styles/font-awesome.css",
                                       "~/Content/styles/jquery-ui.css",
                                       "~/Content/styles/bootstrap.css",
                                       "~/Content/styles/learun-ui.css",
                                       "~/Content/jquery-easyui-1.5/themes/gray/easyui.css",
                                       "~/Content/jquery-easyui-1.5/themes/icon.css"
              ));

            bundles.Add(new ScriptBundle("~/bundles/basedatamanage").Include(
                                        "~/Content/Scripts/jquery/jquery-1.10.2.js",
                                        "~/Content/jquery-easyui-1.5/jquery.easyui.js",
                                        "~/Content/jquery-easyui-1.5/locale/easyui-lang-zh_CN.js",
                                        "~/Content/Scripts/jquery/jquery-ui.js",
                                        "~/Content/Scripts/bootstrap.js",
                                        "~/Content/Scripts/format.js"));
             * */



            bundles.Add(new StyleBundle("~/Content/basedatamanage").Include(
                                       "~/Content/styles/jquery-ui.css",
                                       "~/Content/jquery-easyui-1.5/themes/gray/easyui.css",
                                       "~/Content/jquery-easyui-1.5/themes/icon.css"
              ));

            bundles.Add(new ScriptBundle("~/bundles/basedatamanage").Include(
                                       "~/Content/Scripts/jquery/jquery-1.10.2.js",
                                       "~/Content/jquery-easyui-1.5/jquery.easyui.js",
                                       "~/Content/jquery-easyui-1.5/locale/easyui-lang-zh_CN.js",
                                       "~/Content/Scripts/jquery/jquery-ui.js",
                                       "~/Content/Scripts/js/Common.js"
                                       ));


            #endregion
        }
    }
}