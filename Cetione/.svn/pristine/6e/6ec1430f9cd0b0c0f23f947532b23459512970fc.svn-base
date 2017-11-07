using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using Cetione.Utility;
using Cetione.Model;
using Cetione.BLL;
using Newtonsoft.Json;

namespace Cetione.Web.Controllers.System
{
    /// <summary>
    /// 用户权限控制器
    /// </summary>
    public class UserLimitsController : Controller
    {
        //
        // GET: /UserLimits/

        public ActionResult Index()
        {
            return View();
        }

        /// <summary>
        /// 查询
        /// </summary>
        /// <param name="UserCode"></param>
        /// <param name="page"></param>
        /// <param name="rows"></param>
        /// <returns></returns>
        public ActionResult Query(string UserCode, string Account)
        {
            int status = 0;
            List<UserLimits> userList =UserLimitsBLL.GetUserLimits(CurrentUser.LoginUser.UserCode, CurrentUser.LoginUser.AccountID, ref status);

            //JsonResult<UserLimits> jsonResult = new JsonResult<UserLimits>(2000, userList);

            //return Content(jsonResult.ToString());
            return Content(JsonConvert.SerializeObject(userList));
        }

                /// <summary>
        /// 保存（新增、修改）
        /// </summary>
        /// <returns></returns>
        public ActionResult Save()
        {
            string AccountID = Request.Form["AccountID"];//账套
            string UserCode = Request.Form["UserCode"];//用户编号
            string UserName = Request.Form["UserName"];//用户名

            return Content(new JsonMessage { Success = true, Message = "" }.ToString());
        }

    }
}
