using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using YZERP.Model;
using YZERP.BLL;
using YZERP.Utility;

namespace YZERP.Web.Controllers
{
    /// <summary>
    /// 产品库存控制器
    /// </summary>
    public class StoreController : Controller
    {
        //
        // GET: /Store/

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult InStore()
        {
            return View();
        }

        public ActionResult OutStore()
        {
            return View();
        }


        /// <summary>
        /// 查询产品库存信息
        /// </summary>
        /// <param name="productName"></param>
        /// <param name="productStyle"></param>
        /// <param name="page"></param>
        /// <param name="rows"></param>
        /// <returns></returns>
        public ActionResult Query(string productName, string productStyle, int page, int rows)
        {
            if (rows < 20) rows = 20;
            int totalRecordCount = 0;
            List<ProductStoreInfo> storeList = ProductStoreInfoBLL.GetProductStoreList(CurrentUser.LoginUser.CustCode, productName, productStyle, page, rows, ref totalRecordCount);
            JsonResult<ProductStoreInfo> jsonResult = new JsonResult<ProductStoreInfo>(totalRecordCount, storeList);
            return Content(jsonResult.ToString());
        }
    }
}
