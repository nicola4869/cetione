using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Cetione.Web.Controllers.Admin
{
    public class FeddyController : Controller
    {
        //
        // GET: /Feddy/

        public ActionResult Index()
        {
            ////权限
            ViewBag.AddUser = true;
            ViewBag.EditUser = true;
            ViewBag.DeleteUser = true;
            ViewBag.AccountID = CurrentUser.LoginUser.AccountID;
            return View();
        }

    }
}
