using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using QX.Config;
using QX.AOP;

namespace QX.Controllers.Controllers
{

    [ExceptionFillters]
    [ActionFillters]
    [ResultFillters][QX.Cache.CompressFilter][QX.Cache.CacheFilter(Duration=120)]
    public class SysSessionController : Controller
    {

        [HttpPost]
        public ActionResult GetLoginUser()
        {
            //string key = Request["key"];
            //string result = string.Empty;
            //if (!string.IsNullOrEmpty(key))
            //{
            //    result = this.GetSession<string>(key);
            //}
            return Json(new { UserId = this.GetSession<string>("UserId"), UserName = this.GetSession<string>("UserName") });
        }

        [HttpPost]
        public ActionResult GetCurrentDate()
        {
            return Content(DateTime.Now.ToString("yyyy-MM-dd"));
        }
        [HttpPost]
        public ActionResult GetCurrentTime()
        {
            return Content(DateTime.Now.ToString("yyyy-MM-dd hh:mm ss"));
        }


        /// <summary>
        /// 获取Session信息
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        [HttpPost]
        public ActionResult get(string key)
        {
            string result = string.Empty;
            if (!string.IsNullOrEmpty(key))
            {
                result = this.GetSession<string>(key);
            }
            return Content(result);
        }

        /// <summary>
        /// 设备Session信息
        /// </summary>
        /// <param name="key"></param>
        /// <param name="val"></param>
        /// <returns></returns>
        public ActionResult set()
        {
            string key = Request["key"];
            string val = Request["val"];
            this.SetSession<string>(key, val);
            return Content("true");
        }
    }
}
