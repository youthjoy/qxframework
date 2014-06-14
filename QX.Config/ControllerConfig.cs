using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using System.Web;

namespace QX.Config
{
    public static class ControllerConfig
    {
        
        /// <summary>
        /// 获取Action名字
        /// </summary>
        /// <param name="controller"></param>
        /// <returns></returns>
        public static string GetActionName(this Controller controller)
        {
            string ConName = controller.ControllerContext.RouteData.Values["action"].ToString();            
            return ConName;
        }

        /// <summary>
        /// 获际Controller名字
        /// </summary>
        /// <param name="controller"></param>
        /// <returns></returns>
        public static string GetControllerName(this Controller controller)
        {
            string ConName = controller.ControllerContext.RouteData.Values["controller"].ToString();
            return ConName;
        }

        /// <summary>
        /// 设置Controller ViewData
        /// </summary>
        /// <param name="controller"></param>
        /// <param name="Key"></param>
        /// <param name="Value"></param>
        public static ViewDataDictionary SetControllerView(this Controller controller,string Key,string Value)
        {
            //string Name = controller.GetControllerName();
            ViewDataDictionary vDict = new ViewDataDictionary();            
            vDict.Add(Key, Value);
            return vDict;
        }

        /// <summary>
        /// 设置PUView
        /// </summary>
        /// <param name="controller"></param>
        public static KeyValuePair<string,object> SetPUView(this Controller controller)
        {
            KeyValuePair<string, object> dict = new KeyValuePair<string, object>("PUModule", controller.GetActionName());
            return dict;
        }

        

    }
}
