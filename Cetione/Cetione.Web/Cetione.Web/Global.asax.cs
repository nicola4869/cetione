using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using System.Configuration;
using Cetione.DAL;

namespace Cetione.Web
{
    // 注意: 有关启用 IIS6 或 IIS7 经典模式的说明，
    // 请访问 http://go.microsoft.com/?LinkId=9394801

    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            try
            {
                AreaRegistration.RegisterAllAreas();

                WebApiConfig.Register(GlobalConfiguration.Configuration);
                FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
                RouteConfig.RegisterRoutes(RouteTable.Routes);
                BundleConfig.RegisterBundles(BundleTable.Bundles);
                BundleTable.EnableOptimizations = false; 
                AuthConfig.RegisterAuth();

                RegisterView();//注册视图访问规则

                //数据库连接字符串
                SqlHelper.ConnectString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            }
            catch { }
        }

        protected void RegisterView()
        {
            ViewEngines.Engines.Clear();
            ViewEngines.Engines.Add(new MyViewEngine());
        }
    }
}