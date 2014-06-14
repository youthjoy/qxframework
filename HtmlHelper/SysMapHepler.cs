using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using QX.Model;
using QX.DAL;
using QX.Config;
using System.ComponentModel;

namespace QX.HtmlHelperLib
{
    public static class SysMapHepler
    {
        /// <summary>
        /// 返回映射中的列表名称 
        /// </summary>
        /// <param name="hepler"></param>
        /// <param name="itype"></param>
        /// <returns></returns>
        public static string Comm_Map_ListName(this HtmlHelper hepler, string ModuleCode, string itype)
        {
            return hepler.Comm_Map_Name(ModuleCode, itype, "Map_Object");
        }

        /// <summary>
        /// 返回映射中的表单名称
        /// </summary>
        /// <param name="hepler"></param>
        /// <param name="itype"></param>
        /// <returns></returns>
        public static string Comm_Map_FormName(this HtmlHelper hepler, string ModuleCode, string itype)
        {
            return hepler.Comm_Map_Name(ModuleCode, itype, "Map_Object1");
        }

        /// <summary>
        ///返回指定模块的指定字段值
        /// </summary>
        /// <param name="hepler"></param>
        /// <param name="ModuleCode">模块名称</param>
        /// <param name="ColumName">指定字段</param>
        /// <returns></returns>
        public static string Comm_Map_FormKey(this HtmlHelper hepler, string ModuleCode, string itype, string ColumName)
        {
            return hepler.Comm_Map_Name(ModuleCode, itype, ColumName);
        }

        /// <summary>
        /// 返回映射中的指定字段名称值
        /// </summary>
        /// <param name="hepler"></param>
        /// <param name="itype"></param>
        /// <param name="ReturnKey"></param>
        /// <returns></returns>
        public static string Comm_Map_Name(this HtmlHelper hepler, string ModuleCode, string itype, string ReturnKey)
        {
            string name = "";
            Sys_Map model = new Sys_Map();
            if (!string.IsNullOrEmpty(itype))
            {
                //开启Session缓存映射数据
                //if (SessionConfig.GetSession("ITYPE") == null)
                //{
                ADOSys_Map MapInstance = new ADOSys_Map();
                var result = MapInstance.GetAll();
                SessionConfig.SetSession("ITYPE", result);
                //}
                List<Sys_Map> list = (List<Sys_Map>)SessionConfig.GetSession("ITYPE");
                PropertyDescriptorCollection pList = TypeDescriptor.GetProperties(typeof(Sys_Map));
                var filterList = list.Where(o => o.Map_Source == itype
                    && o.Map_Module == ModuleCode);

                if (list != null && filterList != null && filterList.Count() > 0)
                {
                    model = filterList.FirstOrDefault();
                    name = pList[ReturnKey] != null ? pList[ReturnKey].GetValue(model).ToString() : "";
                }
            }
            return name;
        }

        /// <summary>
        /// 根据单据模块获取配置
        /// </summary>
        /// <param name="hepler"></param>
        /// <param name="itype"></param>
        /// <returns></returns>
        public static Sys_Rec_RefDepend Comm_Ref_Config(this HtmlHelper hepler, string itype)
        {
            Sys_Rec_RefDepend model = new Sys_Rec_RefDepend();
            ADOSys_Rec_RefDepend instance = new ADOSys_Rec_RefDepend();
            var list = instance.GetListByWhere(" and RefDepend_Code='" + itype + "' ");
            if (list.Count > 0)
            {
                model = list[0];
            }
            else
            {
                model = null;
            }
            return model;
        }

    }
}
