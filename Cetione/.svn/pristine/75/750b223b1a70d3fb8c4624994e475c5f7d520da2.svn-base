using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Cetione.BLL;
using Cetione.Web;
using Cetione.Utility;
using Cetione.DAL.System;
using Cetione.BLL.System;

namespace Cetione.Web.Controllers.System
{
    public class MenuLimitsController : Controller
    {
        //
        // GET: /MenuLimits/

        public ActionResult Index()
        {
            ViewBag.AccountID = CurrentUser.LoginUser.AccountID;
            return View();
        }

        /// <summary>
        /// 递增授权
        /// </summary>
        /// <returns></returns>
        public ActionResult AddMenu(string AccountID)
        {
            if (MenuLimitsBLL.AddMenu(AccountID))
            {
                return Content(new JsonMessage { Success = true }.ToString());
            }
            else
            {
                return Content(new JsonMessage { Success = false }.ToString());
            }
        }


        /// <summary>
        /// 重新授权
        /// </summary>
        /// <returns></returns>
        public ActionResult ResetMenu(string AccountID)
        {
            if (MenuLimitsBLL.ResetMenu(AccountID))
            {
                return Content(new JsonMessage { Success = true }.ToString());
            }
            else
            {
                return Content(new JsonMessage { Success = false }.ToString());
            }
        }
    }
}
