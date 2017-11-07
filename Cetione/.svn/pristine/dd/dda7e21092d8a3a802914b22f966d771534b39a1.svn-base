using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Cetione.Web
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");


            routes.MapRoute(
                name: "Admin",// 路由名称，这个只要保证在路由集合中唯一即可
                url: "Admin/{controller}/{action}/{id}",
                defaults: new { controller = "Login", action = "Index", id = UrlParameter.Optional }
            );

            //智能分析
            routes.MapRoute(
                name: "Analysis",// 路由名称，这个只要保证在路由集合中唯一即可
                url: "Analysis/{controller}/{action}/{id}",
                defaults: new { controller = "Login", action = "Index", id = UrlParameter.Optional }
            );

            //系统管理
            routes.MapRoute(
                name: "System",// 路由名称，这个只要保证在路由集合中唯一即可
                url: "System/{controller}/{action}/{id}",
                defaults: new { controller = "Login", action = "Index", id = UrlParameter.Optional }
            );

            //基础资料
            routes.MapRoute(
                name: "Base",// 路由名称，这个只要保证在路由集合中唯一即可
                url: "Base/{controller}/{action}/{id}",
                defaults: new { controller = "Login", action = "Index", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Login", action = "Index", id = UrlParameter.Optional }
            );

            

        }
    }
}