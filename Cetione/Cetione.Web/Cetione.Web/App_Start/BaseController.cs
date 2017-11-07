using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace Cetione.Web
{
    public class BaseController : Controller
    {
        protected override void OnAuthorization(AuthorizationContext filterContext)
        {
            var reurl = filterContext.HttpContext.Request.Url == null
                ? "#"
                : filterContext.HttpContext.Request.Url.PathAndQuery;

            if (Request.RawUrl.ToLower().Contains("www.")) filterContext.Result = RedirectPermanent(Request.RawUrl.ToLower().Replace("www.", ""));
            HttpCookie auth_cookie = Request.Cookies[CurrentUser.LoginUserKey];
            if (auth_cookie != null)
            {
                //FormsAuthenticationTicket auth_ticket = FormsAuthentication.Decrypt(auth_cookie.Value);
                //System.Web.HttpContext.Current.User = new System.Security.Principal.GenericPrincipal(new FormsIdentity(auth_ticket), null);
                base.OnAuthorization(filterContext);
            }
            else
            {
                filterContext.Result = RedirectToAction("Index", "Login", new { ReturnUrl = reurl });
                return;
            }

        }

    }
}