using System.Collections.Generic;
using System.Text;
using System.Web.Mvc;
using System.IO;

namespace QX.HtmlHelperLib
{
    public static class ScriptExtensions
    {
        #region Solution 1

        /*
        --- From each view / partial view ---
        <% Html.RegisterScriptInclude(Url.Content("../../Scripts/jquery-ui-1.7.2.custom.js")); %>
        
        --- From the main Master/View ---
        <%= Html.RenderScripts() %>
         */
        private static SortedList<int, string> GetRegisteredScriptIncludes()
        {
            var registeredScriptIncludes = System.Web.HttpContext.Current.Items["RegisteredScriptIncludes"] as SortedList<int, string>;

            if (registeredScriptIncludes == null)
            {
                registeredScriptIncludes = new SortedList<int, string>();
                System.Web.HttpContext.Current.Items["RegisteredScriptIncludes"] = registeredScriptIncludes;
            }

            return registeredScriptIncludes;
        }

        public static void RegisterScriptInclude(this HtmlHelper htmlhelper, string script)
        {
            var registeredScriptIncludes = GetRegisteredScriptIncludes();
            if (!registeredScriptIncludes.ContainsValue(script))
            {
                registeredScriptIncludes.Add(registeredScriptIncludes.Count, script);
            }
        }

        public static string RenderScripts(this HtmlHelper htmlhelper)
        {
            var registeredScriptIncludes = GetRegisteredScriptIncludes();
            var scripts = new StringBuilder();
            foreach (string script in registeredScriptIncludes.Values)
            {
                scripts.AppendLine("<script src='" + script + "' type='text/javascript'></script>");
            }
            return scripts.ToString();
        }

        #endregion

        #region Solution 2

        /*
         --- From each view / partial view ---
        <%Html.AddClientScript("~/Scripts/jquery.js");%>
        <%Html.AddClientScript("~/Scripts/jquery-ui.js");%>
        <%Html.AddClientScript("~/Scripts/site.js");%>
        <%Html.AddClientScript("~/Scripts/views/myview.js");%>  

        --- From the main Master/View ---
        <%Html.ClientScripts();%>    
        </body>
         */

        public static void AddClientScript(this HtmlHelper helper, string scriptPath)
        {
            var scripts = helper.ViewContext.HttpContext.Items["client-script-list"] as Dictionary<string, string> ?? new Dictionary<string, string>();

            string scriptFilePath = helper.ViewContext.HttpContext.Server.MapPath(scriptPath);
            if (!File.Exists(scriptFilePath)) return;

            var fi = new FileInfo(scriptFilePath);

            if (scripts.ContainsKey(fi.FullName)) return;

            scripts.Add(fi.FullName, scriptPath);
            helper.ViewContext.HttpContext.Items["client-script-list"] = scripts;
        }

        public static void ClientScripts(this HtmlHelper helper)
        {
            var response = helper.ViewContext.HttpContext.Response;
            var url = new UrlHelper(helper.ViewContext.RequestContext, helper.RouteCollection);
            var scripts = helper.ViewContext.HttpContext.Items["client-script-list"] as Dictionary<string, string> ?? new Dictionary<string, string>();

            response.Write("\r\n\t<!-- BEGIN - Html.ClientScripts() -->\r\n");
            foreach (var script in scripts)
            {
                response.Write(string.Format(
                  "\t<script src=\"{0}\" type=\"text/javascript\">lt;/script>\r\n",
                  url.Content(script.Value)
                ));
            }
            response.Write("\t<!-- END - Html.ClientScripts() -->\r\n");
        }

        #endregion
    }
}
