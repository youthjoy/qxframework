using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using QX.Log;
using QX.Config;
using System.Web;

namespace QX.AOP
{
    /// <summary>
    /// 异常拦截器
    /// </summary>
    public class ExceptionFillters : FilterAttribute,IExceptionFilter
    {
        #region IExceptionFilter 成员
        /// <summary>
        /// 全局异常处理：Error记录到文本
        /// </summary>
        /// <param name="filterContext"></param>
        public void OnException(ExceptionContext filterContext)
        {      
            //写入文本日志
            //PlateLog.WriteInFile(SessionConfig.UserId(), SessionConfig.UserName(), 
            //    HttpContext.Current.Request.UserHostAddress,HttpContext.Current.Request.Url.ToString(),
            //   filterContext.Exception.Message, PlateLog.LogMessageType.Error, filterContext.Exception);

            //写入数据库日志
            PlateLog.WriteError(SessionConfig.UserId(), SessionConfig.UserName(),
                HttpContext.Current.Request.UserHostAddress, HttpContext.Current.Request.Url.ToString(),
               filterContext.Exception.Message, PlateLog.LogMessageType.Error, filterContext.Exception);
        }
        #endregion
    }
    /// <summary>
    /// 方法拦截器
    /// </summary>
    public class ActionFillters : FilterAttribute, IActionFilter
    {
        public string Module
        {
            get;
            set;
        }

        public string ModuleName
        {
            get;
            set;
        }

        #region IActionFilter 成员

        /// <summary>
        /// Action操作后处理：日志
        /// </summary>
        /// <param name="filterContext"></param>
        public void OnActionExecuted(ActionExecutedContext filterContext)
        {
            //var f=filterContext.ActionDescriptor.GetParameters();
            PlateLog.WriteOp(SessionConfig.UserId(), SessionConfig.UserName(), SessionConfig.CurrentIP(), HttpContext.Current.Request.Url.AbsoluteUri, filterContext.ActionDescriptor.ActionName, PlateLog.LogMessageType.Info,Module,ModuleName);
        }


        /// <summary>
        /// Action执行前：权限
        /// </summary>
        /// <param name="filterContext"></param>
        public void OnActionExecuting(ActionExecutingContext filterContext)
        {
            
           
            //var list=Permission.PermissionHelper.Instance.GetUserPermissionListByUser(SessionConfig.UserId());
            
            //string actionname = filterContext.ActionDescriptor.ActionName;
            //string controller = filterContext.ActionDescriptor.ControllerDescriptor.ControllerName;
            //ContentResult r = new ContentResult();
            //r.Content = "您没有操作当前页面的权限";
            //filterContext.Result = r;
        }

        #endregion
    }

    /// <summary>
    /// 结果拦截器
    /// </summary>
    public class ResultFillters : FilterAttribute, IResultFilter
    {

        #region IResultFilter 成员
        /// <summary>
        /// 操作执行后
        /// </summary>
        /// <param name="filterContext"></param>
        public void OnResultExecuted(ResultExecutedContext filterContext)
        {
            //PlateLog.Write(filterContext.Exception.Message, PlateLog.LogMessageType.Info, filterContext.Exception);

            

            //PlateLog.WriteOp(SessionConfig.UserId(), SessionConfig.UserName(), SessionConfig.CurrentIP(),HttpContext.Current.Request.Url.AbsoluteUri,filterContext.Exception.Message, PlateLog.LogMessageType.Info, "", "");
            
        }
        /// <summary>
        /// 操作执行前
        /// </summary>
        /// <param name="filterContext"></param>
        public void OnResultExecuting(ResultExecutingContext filterContext)
        {
            //PlateLog.WriteOp(SessionConfig.UserId(), SessionConfig.UserName(), HttpContext.Current.Request.UserHostAddress,
            //   HttpContext.Current.Request.Url.ToString(), "", PlateLog.LogMessageType.Info);
        }

        #endregion

    }
    
}
