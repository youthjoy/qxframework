namespace QX.HtmlHelperLib
{
    using QX.Comm;
    using System;
    using System.Runtime.CompilerServices;
    using System.Web.Mvc;

    public static class SysErp
    {
        public static string InitConfig(this HtmlHelper helper)
        {
            string str = "";
            if (!Convert.ToBoolean(ConfigHelper.GetApp("JS_DEBUG")))
            {
                str = new TagBuilder("script") { InnerHtml = " function HideError(){ return true; }   window.onerror = HideError;" }.ToString();
            }
            return str;
        }
    }
}

