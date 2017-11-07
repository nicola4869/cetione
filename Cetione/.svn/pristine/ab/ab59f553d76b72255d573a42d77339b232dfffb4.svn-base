using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using Cetione.Model;
using Cetione.Utility;
using Cetione.BLL;
using System.Web.Security;

namespace Cetione.Web.Controllers
{
    /// <summary>
    /// 主界面控制器
    /// </summary>
    public class HomeController : Controller
    {
        /// <summary>
        /// 主界面view跳转
        /// </summary>
        /// <returns></returns>
        [AuthAttribute]
        public ActionResult Index()
        {
            ViewBag.UserName = CurrentUser.LoginUser.UserName;
            ViewBag.RoleName = CurrentUser.LoginUser.Position;

            return View();
        }

        /// <summary>
        /// 主界面中“首页”选项卡跳转
        /// </summary>
        /// <returns></returns>
        [AuthAttribute]
        public ActionResult Default()
        {
            //ViewBag.SingleWaitAuditOrderCount = ApplyOrderAuditInfoBLL.GetApplyOrderAuditCount(CurrentUser.LoginUser.KeyID, CurrentUser.LoginUser.AccountID);
            //ViewBag.GatherWaitAuditOrderCount = ApplyOrderAuditInfoBLL.GetApplyOrderSummaryAuditCount(CurrentUser.LoginUser.KeyID, CurrentUser.LoginUser.AccountID);

            return View();
        }

        /// <summary>
        /// 获取左边的折叠菜单列表
        /// </summary>
        /// <returns></returns>
        public ActionResult LoadAccordionMenu()
        {
            if (CurrentUser.LoginUser != null)
            {
                List<MenuInfo> list = MenuInfoBLL.GetCurrentUserMenu(CurrentUser.LoginUser.AccountID,CurrentUser.LoginUser.UserCode);
                return Content(list.ToJson().Replace("&nbsp;", ""));
            }
            else
            {
                return RedirectToAction("Index", "Login");
            }
        }

        /// <summary>
        /// 设置快捷方式界面
        /// </summary>
        /// <returns></returns>
        public ActionResult Shortcuts()
        {
            return View();
        }



    }
}
