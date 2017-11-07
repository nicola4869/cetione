using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using Cetione.Utility;
using Cetione.Model;
using Cetione.BLL;

namespace Cetione.Web.Controllers
{
    /// <summary>
    /// 用户控制器
    /// </summary>
    public class UserController : Controller
    {
        //
        // GET: /User/
        [AuthAttribute]
        public ActionResult Index()
        {
            ////权限
            ViewBag.AddUser = true;
            ViewBag.EditUser = true;
            ViewBag.DeleteUser = true;
            ViewBag.AccountID = CurrentUser.LoginUser.AccountID;

            return View();
        }

        /// <summary>
        /// 查询
        /// </summary>
        /// <param name="UserCode"></param>
        /// <param name="page"></param>
        /// <param name="rows"></param>
        /// <returns></returns>
        public ActionResult Query(string UserCode, string UserName, int page, int rows)
        {
            if (rows < 20) rows = 20;
            int totalRecordCount = 0;
            List<UserInfo> userList = UserInfoBLL.GetUserListByPage(CurrentUser.LoginUser.AccountID, UserCode, UserName,  page, rows, ref totalRecordCount);

            JsonResult<UserInfo> jsonResult = new JsonResult<UserInfo>(totalRecordCount, userList);

            return Content(jsonResult.ToString());
        }

        /// <summary>
        /// 保存（新增、修改）
        /// </summary>
        /// <returns></returns>
        public ActionResult Save()
        {
            string AccountID=Request.Form["AccountID"];//账套
            string UserCode = Request.Form["UserCode"];//用户编号
            string UserName = Request.Form["UserName"];//用户名
            string Pwd = Request.Form["Pwd"];//密码
            if (!string.IsNullOrWhiteSpace(Pwd))
            {
                DES des = new DES();
                Pwd = des.Encrypt(Pwd);
            }
            string Employee = Request.Form["Employee"];//员工编号
            string Position = Request.Form["Position"];//岗位
            string Department = Request.Form["Department"];//部门
            string Phone = Request.Form["Phone"];//电话
            DateTime BeginDate = Convert.ToDateTime(Request.Form["BeginDate"]);//生效日期
            DateTime EndDate = Convert.ToDateTime(Request.Form["EndDate"]);//失效日期
            string IsAdmin = Request.Form["IsAdmin"];//管理员
            string IsEnable = Request.Form["IsEnable"];//生效

            string actionType = Request.Form["actiontype"];//新增或者修改状态

            UserInfo userInfo = new UserInfo();
            
            userInfo.AccountID = AccountID;
            userInfo.UserCode = UserCode;
            userInfo.UserName = UserName;
            userInfo.Pwd = Pwd;
            userInfo.Employee = Employee;
            userInfo.Phone = Phone;
            userInfo.Department = Department;
            userInfo.Position = Position;
            userInfo.BeginDate = BeginDate;
            userInfo.EndDate = EndDate;
            userInfo.IsAdmin = Convert.ToInt32(IsAdmin);
            userInfo.IsEnable = Convert.ToInt32(IsEnable);

            bool sucesss = false;
            string message = "";
            if (actionType == "add")
            {
                if (UserInfoBLL.CheckObjIsExist(userInfo))
                {
                    sucesss = false;
                    message = "该用户已经存在，不能重复录入！";
                }
                else
                {
                    if (UserInfoBLL.Add(userInfo))
                    {
                        sucesss = true;
                    }
                }
            }
            else
            {
                int KeyID = Convert.ToInt32(Request.Form["KeyID"]);//主键
                userInfo.KeyID = KeyID;
                if (UserInfoBLL.Update(userInfo))
                {
                    sucesss = true;
                }
            }

            return Content(new JsonMessage { Success = sucesss, Message = message }.ToString());
        }

        /// <summary>
        /// 删除
        /// </summary>
        /// <returns></returns>
        public ActionResult Delete()
        {
            int KeyID = Convert.ToInt32(Request.Form["KeyID"]);
            if (UserInfoBLL.Delete(KeyID))
            {
                return Content(new JsonMessage { Success = true }.ToString());
            }
            else
            {
                return Content(new JsonMessage { Success = false }.ToString());
            }
        }

        /// <summary>
        /// 重置密码
        /// </summary>
        /// <returns></returns>
        public ActionResult ResetPassword()
        {
            int userID = Convert.ToInt32(Request.Form["KeyID"]);
            if (UserInfoBLL.ResetPassword(userID))
            {
                return Content(new JsonMessage { Success = true }.ToString());
            }
            else
            {
                return Content(new JsonMessage { Success = false }.ToString());
            }
        }

        /// <summary>
        /// 重置密码
        /// </summary>
        /// <returns></returns>
        public ActionResult SetUserEnable()
        {
            int userID = Convert.ToInt32(Request.Form["KeyID"]);
            int flag = Convert.ToInt32(Request.Form["flag"]);
            if (UserInfoBLL.SetUserEnabledStatus(userID, flag))
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
