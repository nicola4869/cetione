using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using Cetione.Utility;
using Cetione.Model;
using System.Web.Security;

namespace Cetione.Web
{
    /// <summary>
    /// 当前登陆用户信息
    /// </summary>
    public class CurrentUser
    {
        public static string LoginUserKey = "LOGINUSERKEY";

        /// <summary>
        /// 当前用户
        /// </summary>
        public static UserInfo LoginUser
        {
            get
            {
                if (!HttpContext.Current.User.Identity.IsAuthenticated) return null;

                HttpCookie authCookie = System.Web.HttpContext.Current.Request.Cookies[FormsAuthentication.FormsCookieName];
                if (authCookie == null) return null;

                FormsAuthenticationTicket authTicket = null;
                authTicket = FormsAuthentication.Decrypt(authCookie.Value);
                string strUserInfo = authTicket.UserData.ToString();

                if (!string.IsNullOrWhiteSpace(strUserInfo))
                {
                    UserInfo userInfo = new UserInfo(strUserInfo);
                    //RoleFunctions roleFunctions = new RoleFunctions(userInfo.FunctionIDS);
                    //userInfo.RoleFunctions = roleFunctions;

                    return userInfo;
                }
                return null;
            }
        }

        ///// <summary>
        ///// 当前用户的角色权限
        ///// </summary>
        //public static RoleFunctions RoleFunctions
        //{
        //    get
        //    {
        //        //if (LoginUser != null)
        //        //{
        //        //    return LoginUser.RoleFunctions;
        //        //}
        //        return new RoleFunctions();
        //    }
        //}

        /// <summary>
        /// 保存登录用户数据
        /// </summary>
        /// <param name="userInfo"></param>
        public static void SaveUserData(UserInfo userInfo, int expireDays = 7)
        {
            CookieHelper.WriteCookie(LoginUserKey, userInfo.ToString(), expireDays);
        }

        /// <summary>
        /// 移除用户信息缓存
        /// </summary>
        public static void RemoveUserData()
        {
            //CookieHelper.DelCookie(LoginUserKey);

            FormsAuthentication.SignOut();
        }


        /// <summary>
        /// 创建用户登录票据
        /// </summary>
        /// <param name="userName"></param>
        /// <param name="userInfo"></param>
        /// <param name="expireDay"></param>
        public static void SaveUserData(string userName, UserInfo userInfo, int expireDay = 7)
        {
            string userData = userInfo.ToString();
            FormsAuthenticationTicket authTicket = new FormsAuthenticationTicket(1, userName,
                                                                                 DateTime.Now,
                                                                                 DateTime.Now.AddDays(expireDay),
                                                                                 expireDay == 0 ? false : true, userData, "");
            HttpCookie cookie = new HttpCookie(FormsAuthentication.FormsCookieName, FormsAuthentication.Encrypt(authTicket));
            if (expireDay != 0) cookie.Expires = authTicket.Expiration;
            System.Web.HttpContext.Current.Response.Cookies.Add(cookie);
        }
    }
}