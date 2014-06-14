using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using System.Collections;
using System.Web.Routing;
using System.Web;
using System.IO;
using QX.Comm;
using QX.HtmlHelperLib.Comm;

namespace QX.HtmlHelperLib
{
    public static class AutoLoadModule
    {
        /// <summary>
        /// 根据controller自动加载所有Js文件
        /// </summary>
        /// <param name="Helper"></param>
        /// <returns></returns>
        public static string AutoLoadModuleJs(this HtmlHelper Helper)
        {
            StringBuilder innerHtml = new StringBuilder();
            List<string> arrlist = new List<string>() ;
            RouteValueDictionary RouteData = Helper.ViewContext.RouteData.Values;
            string ControllerName = String.Empty;
            foreach (var item in RouteData)
            {
                if (!String.IsNullOrEmpty(item.Key) && item.Key.ToLower() == "controller")
                {
                    ControllerName = item.Value.ToString();
                }
            }
            if (!String.IsNullOrEmpty(ControllerName))
            {
                arrlist = LoadJsFiles(Helper, ControllerName);
                string script = @"<script type='text/javascript' src='/Scripts/{0}'></script>";
                foreach (string item in arrlist)
                {
                    innerHtml.AppendLine(string.Format(script, item));
                }
            }
            return innerHtml.ToString();
        }

        private static List<string> LoadJsFiles(HtmlHelper helper, string pathName)
        {
            string path = helper.ViewContext.HttpContext.Server.MapPath("~") + "\\Scripts\\" + pathName;
            string tmpPath = helper.ViewContext.HttpContext.Server.MapPath("~") + "\\Scripts\\";
            FileHelper file = new FileHelper();
            file.GetFilesByDirectory(path, "*.js");
            List<string> arr = file.FileList;
            List<string> tmpArr = new List<string>();
            if (arr!=null && arr.Count>0 )
            {
                for (int i = arr.Count-1; i>=0 ; i--)
                {
                    int index = arr[i].IndexOf(pathName);
                    string tmp = arr[i].Substring(index, arr[i].Length - index).Replace("\\","/");
                    tmpArr.Add(tmp);
                }
            }            
            return tmpArr;
        }
        
    }
}
