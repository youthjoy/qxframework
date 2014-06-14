using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using QX.Model;
using QX.BLL;
using QX.Comm;
using QX.Config;
using QX.HtmlHelperLib.JqGrid;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.IO;

namespace QX.Controllers
{
    public static class CommRefDepend
    {
        /// <summary>
        /// 获取依赖映射配置
        /// </summary>
        /// <param name="controller"></param>
        /// <param name="code"></param>
        /// <returns></returns>
        public static ViewDataDictionary GetRefdenped(this Controller controller,bool IsPU)
        {
            ViewDataDictionary dict = new ViewDataDictionary();
          
            //To Do 预留各种单据默认配置
            string itype = "";
            string type = "";
            string view = "";
            string MRTOPO = "";
            string IsHideMaterialSearch = "";

            string defaultPU_SPec_DetailModule = "Spec_PUDetailModule";
            string defaultIA_Spec_DetailModule = "nOSpec_IOItemModule";
            string defaultPU_DetailModule = "PU_PUDetailModule";
            string defaultIA_DetailModule = "PU_IOItemModule";

            string PU_DetailModule = "";
            string IA_DetailModule = "";       
            
                        
            view = HttpContext.Current.Request["view"] != null ? "style='display:none'" : "";
            
            //PU配置
            if (IsPU)
            {
                itype = controller.RouteData.Values["rtype"] != null ? controller.RouteData.Values["rtype"].ToString() : "";
                itype = itype.Replace("#", " ").Trim();
                type = controller.RouteData.Values["code"] != null ? controller.RouteData.Values["code"].ToString() : "";
                MRTOPO = HttpContext.Current.Request["MRTOPO"] != null ? HttpContext.Current.Request["MRTOPO"] : "";
                //Create edit
                string id = controller.RouteData.Values["id"] != null ? controller.RouteData.Values["id"].ToString() : "";
                if (!string.IsNullOrEmpty(id))
                {
                    itype = id;
                }
                dict.Add("RType", itype);
                dict.Add("RRType", type);
                
            }
            else
            {
                itype=HttpContext.Current.Request["itype"]!=null?HttpContext.Current.Request["itype"]:"";
                type = HttpContext.Current.Request["type"] != null ? HttpContext.Current.Request["type"] : "";
                dict.Add("itype", itype);
                dict.Add("type", type);
                
            }
            
            var model = Bll_Comm.CommRefDepend(itype);
            if (model == null)
                return null;

            if (itype.Contains("MET") || itype.Contains("MEP") || itype.Contains("CTP")||itype.Contains("WOI")||itype.Contains("baseSER"))
            {
                PU_DetailModule = defaultPU_SPec_DetailModule;
                IA_DetailModule = defaultIA_Spec_DetailModule;

                if (model.RefDepend_Type == "PU")
                {
                    var ChildModuleName = string.IsNullOrEmpty(model.RefDepend_UDEF10) ? PU_DetailModule : model.RefDepend_UDEF10;
                    dict.Add("ChildModuleName", ChildModuleName);
                }
                else if (model.RefDepend_Type == "IA")
                {
                    var ChildModuleName = string.IsNullOrEmpty(model.RefDepend_UDEF10) ? IA_DetailModule : model.RefDepend_UDEF10;
                    dict.Add("ChildModuleName", ChildModuleName);
                }
                else if (model.RefDepend_Type == "MA")
                {
                    var ChildModuleName = string.IsNullOrEmpty(model.RefDepend_UDEF10) ? defaultPU_SPec_DetailModule : model.RefDepend_UDEF10;
                    dict.Add("ChildModuleName", ChildModuleName);
                }
            }
            else
            {
                PU_DetailModule = defaultPU_DetailModule;
                IA_DetailModule = defaultIA_DetailModule;

                if (model.RefDepend_Type == "PU")
                {
                    var ChildModuleName = string.IsNullOrEmpty(model.RefDepend_UDEF10) ? PU_DetailModule : model.RefDepend_UDEF10;
                    dict.Add("ChildModuleName", ChildModuleName);
                }
                else if (model.RefDepend_Type == "IA")
                {
                    var ChildModuleName = string.IsNullOrEmpty(model.RefDepend_UDEF10) ? IA_DetailModule : model.RefDepend_UDEF10;
                    dict.Add("ChildModuleName", ChildModuleName);
                }
            }           

            var MainName = model.RefDepend_ObjectName;
            var FormName = model.RefDepend_ShowName;
            var ModuleName = model.RefDepend_UDEF1;

            var AuditName = model.RefDepend_UDEF2;

            IsHideMaterialSearch = model.RefDepend_UDEF18;

            var StorageCheck = "";

            if (!string.IsNullOrEmpty(model.RefDepend_UDEF14))
            {
                StorageCheck = "Check";
            }

            
            if (string.IsNullOrEmpty(AuditName))
            {
                AuditName = "";
            }

            string backUrl = model.RefDepend_UDEF9;
            if (string.IsNullOrEmpty(backUrl))
            {
                backUrl = "";
            }
            dict.Add("BackUrl", backUrl);

            var ShowMain = model.RefDepend_ShowMain;
            var ShowOther = model.RefDepend_ShowOther;
            dict.Add("MainName", MainName);
            dict.Add("FormName", FormName);
            dict.Add("ModuleName", ModuleName);
            dict.Add("AuditName", AuditName);
            dict.Add("Main", ShowMain);
            dict.Add("Other", ShowOther);
            dict.Add("StorageCheck", StorageCheck); //库存检查
            dict.Add("MRTOPO", MRTOPO); //汇总生成订单
            dict.Add("IsHideMaterialSearch", IsHideMaterialSearch);
            dict.Add("TOPOModule", model.RefDepend_UDEF20); //采购汇总生成订单模块

            if (!string.IsNullOrEmpty(model.RefDepend_UDEF3))
            {
                dict.Add("HouseType", model.RefDepend_UDEF3);//获取仓库类型
            }
            dict.Add("view", view);
            
            //if (!string.IsNullOrEmpty(itype))
            //{
            //    //设置单据表单，模块，审核
            //    var model = Bll_Comm.CommRefDepend(itype);
                
                                 
            //}            

            return dict;
        }

    }
}
