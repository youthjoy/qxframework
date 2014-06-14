using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using QX.Config;
using System.Web;

namespace QX.Controllers
{
    /// <summary>
    /// 通用日志扩展类
    /// </summary>
    public static class CommLog
    {
        /// <summary>
        /// 扩展系统操作日志
        /// </summary>
        /// <param name="controller">Controller</param>
        /// <param name="Module">模块编码</param>
        /// <param name="ModuleName">模块名称(格式：Add:物料管理,编码:xxxxxx)</param>
        /// <param name="Message">信息(格式：success:sql语句/异常信息)</param>
        public static void OpLog(this Controller controller,string Module,string ModuleName,string Message)
        {
            BLL.Bll_Comm.OpLog(Module, ModuleName, Message);
        }
    }
}
