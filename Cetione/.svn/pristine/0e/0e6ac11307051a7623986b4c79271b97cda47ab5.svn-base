using Cetione.BLL;
using Cetione.Model.Base;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Cetione.Web.Controllers.Base
{
    /// <summary>
    /// 部门控制器
    /// </summary>
    public class DepartmentController : Controller
    {
        //
        // GET: /Department/

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
        public ActionResult Query(string Account)
        {
            int status = 0;
            List<Bs_Department> userList = DepartmentBLL.GetDepartment(CurrentUser.LoginUser.AccountID, ref status);

            //JsonResult<UserLimits> jsonResult = new JsonResult<UserLimits>(2000, userList);

            //return Content(jsonResult.ToString());
            return Content(JsonConvert.SerializeObject(userList));
        }

    }
}
