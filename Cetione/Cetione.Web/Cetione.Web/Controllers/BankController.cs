using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using YZERP.Utility;
using YZERP.Model;
using YZERP.BLL;

namespace YZERP.Web.Controllers
{
    /// <summary>
    /// 公告信息控制器
    /// </summary>
    public class BankController : Controller
    {
        //
        // GET: /Bank/

        public ActionResult Index()
        {
            ViewBag.AddBank = true;
            ViewBag.DeleteBank = true;

            return View();
        }

        /// <summary>
        /// 查询
        /// </summary>
        /// <param name="userName"></param>
        /// <param name="page"></param>
        /// <param name="rows"></param>
        /// <returns></returns>
        public ActionResult Query(string BankCode, string BankName, string startTime, string endTime, int page, int rows)
        {
            DateTime sTime = DateTime.Now.AddYears(-5);
            DateTime eTime = DateTime.Now;

            if (!string.IsNullOrWhiteSpace(startTime))
            {
                sTime = Convert.ToDateTime(startTime);
            }
            if (!string.IsNullOrWhiteSpace(endTime))
            {
                eTime = Convert.ToDateTime(endTime);
            }

            if (rows < 20) rows = 20;
            int totalRecordCount = 0;
            List<BankInfo> noteList = BankInfoBLL.GetBankInfoList( BankCode, BankName, sTime, eTime, page, rows, ref totalRecordCount);
            JsonResult<BankInfo> jsonResult = new JsonResult<BankInfo>(totalRecordCount, noteList);

            return Content(jsonResult.ToString());
        }


    }
}
