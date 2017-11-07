using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
namespace Cetione.Web
{

    public sealed class MyViewEngine : RazorViewEngine
    {

        public MyViewEngine()
        {
            ViewLocationFormats = new[]
            {
                "~/Views/{1}/{0}.cshtml",
                "~/Views/Shared/{0}.cshtml",
                "~/Views/Admin/{1}/{0}.cshtml",//分层
                "~/Views/Analysis/{1}/{0}.cshtml",
                "~/Views/System/{1}/{0}.cshtml",
                "~/Views/Base/{1}/{0}.cshtml"
            };
        }
        public override ViewEngineResult FindView(ControllerContext controllerContext, string viewName, string masterName, bool useCache)
        {
            return base.FindView(controllerContext, viewName, masterName, useCache);
        }

    }
}