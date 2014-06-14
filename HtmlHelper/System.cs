using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using QX.HtmlHelperLib.Comm;

namespace QX.HtmlHelperLib
{
    public static class SysErp
    {
        /// <summary>
        /// 系统初始化相关信息
        /// </summary>
        /// <param name="helper"></param>
        /// <returns>输出页面</returns>
        public static string InitConfig(this HtmlHelper helper)
        {
            string Html="";
            var OPEN_DEBUG = Convert.ToBoolean(ConfigHelper.GetApp("JS_DEBUG"));
            if (!OPEN_DEBUG)
            {
                TagBuilder builder = new TagBuilder("script");
                builder.InnerHtml = " function HideError(){ return true; }   window.onerror = HideError;";
                Html = builder.ToString();
            }
            return Html;
        }
    }
}
