using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using Cetione.Utility;
using Cetione.Model;
using Cetione.BLL;
using System.Web.UI;
using System.Web.Security;

namespace Cetione.Web.Controllers
{
    /// <summary>
    /// 登录控制器
    /// </summary>
    public class LoginController : Controller
    {
        //
        // GET: /Login/

        public ActionResult Index()
        {
            return View();
        }

        //[MyValidateAntiForgeryToken]
        public ActionResult CheckLogin(string username, string password)
        {

            int IsEnable = 0;
            UserInfo userInfo = UserInfoBLL.GetUser(username, password, ref IsEnable);
            if (userInfo == null)
            {
                ContentResult content = new ContentResult();
                content.Content = string.Format("<script type='text/javascript'>alert('用户名或密码错误！');window.location.href='{0}';</script>", FormsAuthentication.LoginUrl);
                return content;
            }
            else
            {
                userInfo.TransCode = Guid.NewGuid().ToString();
                //记录用户登录IP
                UserInfoBLL.UpdateUserLoginIPAndTime(IPController.GetWebClientIp(), userInfo);

                //保存用户信息
                CurrentUser.SaveUserData(username, userInfo, 7);

                return RedirectToAction("Index", "Home");
            }
        }

        /// <summary>
        /// 安全退出系统
        /// </summary>
        /// <returns></returns>
        public ActionResult OutLogin()
        {
            CurrentUser.RemoveUserData();
            return RedirectToAction("Index");
        }
    }
}
