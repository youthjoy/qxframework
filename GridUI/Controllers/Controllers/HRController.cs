using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Ajax;
using QX.Model;
using QX.BLL;
using QX.Comm;
using QX.HtmlHelperLib.JqGrid;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.IO;
using System.Web.UI;
using System.Diagnostics;
using QX.AOP;
using QX.Config;

namespace QX.Controllers.Controllers
{
    [ExceptionFillters]
    [ActionFillters]
    [ResultFillters][QX.Cache.CompressFilter][QX.Cache.CacheFilter(Duration=120)]
    
    public class HRController : Controller
    {
        BLL.Bll_HR_Stuff hrInstance = new BLL.Bll_HR_Stuff();
        BLL.Bll_HR_Department deptInstance = new QX.BLL.Bll_HR_Department();
        /// <summary>
        /// 获取部门信息列表（通用控件使用）
        /// </summary>
        /// <returns></returns>
        [OutputCache(CacheProfile = "Dept_CacheConfig")]
        public ActionResult GetDeptTree()
        {
            var list = deptInstance.GetDeptTree();
            return Json(list, JsonRequestBehavior.AllowGet);
        }

        public ActionResult AddNode(HR_Department model)
        {
            Model.HR_Department hrd = new Model.HR_Department();
            //hrd.Dept_PCode = code;
            hrd.Dept_Name = "请输入部门名称";
            hrd.Dept_Code = deptInstance.GenerateDeptCode();
            bool s = deptInstance.AddDept(hrd);
            //日志记录
            this.OpLog(this.GetControllerName(), "添加:部门信息,编码:" + "", s.ToString());

            return s ? Content(hrd.Dept_Code) : Content("false");


        }

        public ActionResult EditNode(HR_Department dep)
        {
            bool s = deptInstance.UpdateDept(dep);

            //日志记录
            this.OpLog(this.GetControllerName(), "修改:部门信息,编码:" + dep.Dept_Code, s.ToString());

            return s ? Content(dep.Dept_Code) : Content("false");
        }

        public ActionResult DeleteNode(string code)
        {
            var model = deptInstance.GetModel(string.Format("AND Dept_Code='{0}'", code));
            model.Stat = 1;
            bool s = this.deptInstance.UpdateDept(model);
            //日志记录
            this.OpLog(this.GetControllerName(), "删除:部门信息,编码:" + code, s.ToString());

            return s ? Content("success") : Content("false");
        }

    }
}
