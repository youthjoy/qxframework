using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using QX.HtmlHelperLib.Model;
using QX.Comm;
using QX.HtmlHelperLib.JqGrid;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.IO;
using System.Data;
using System.Collections;
using System.Text;
using System.Reflection;
using QX.Config;
using QX.HtmlHelperLib.DAL;
using QX.HtmlHelperLib.BLL;
using QX.HtmlHelperLib.Comm;

namespace QX.HtmlHelperLib.Controllers
{
    //[ExceptionFillters]
    //[ActionFillters]
    //[ResultFillters][QX.Cache.CompressFilter][QX.Cache.CacheFilter(Duration=120)]
    public class Sys_Config_ReferController : Controller
    {
        private ADOBse_Dict DictInstance = new ADOBse_Dict();

        public ActionResult GetData(int page, int rows, string search, string sidx, string sord)
        {
            string Name = Request["name"] == null ? "" : Request["name"].ToString();
            string filters = Request["filters"] == null ? "" : Request["filters"].ToString();
            string filter = Request["filter"] == null ? "" : Request["filter"].ToString();
            string ModuleName = Request["m"] == null ? "" : Request["m"].ToString();
            string NameSpace = Request["n"] == null ? "" : Request["n"].ToString();
                      

            string filtersSql = string.Empty;
            string mapSqlFilter = string.Empty;
            if (!string.IsNullOrEmpty(filters))
            {
                filtersSql = BulidJqGridSearch.BuildSearch(filters);
            }
            Bll_Sys_Config_Refer configRefer = new Bll_Sys_Config_Refer();
            Bll_Sys_Config_Field_Refer configReferList = new Bll_Sys_Config_Field_Refer();
            Sys_Config_Refer model = configRefer.GetListByCode(" AND  R_ModuleName='"
                + ModuleName + "'")[0];
            var referList = configReferList.GetListByCode(" AND  D_ModuleName='" + ModuleName + "'").Where(o=>!string.IsNullOrEmpty(o.D_DictKey));
            Bll_Bse_Dict DictInstance = new Bll_Bse_Dict();


            DataTable dt = new DataTable();
            if (!string.IsNullOrEmpty(model.R_SQL))
            {
                if (!string.IsNullOrEmpty(filter))
                {
                    model.R_SQL = model.R_SQL + filter;
                }
                if (!string.IsNullOrEmpty(filtersSql))
                {
                    model.R_SQL = model.R_SQL + " AND " + filtersSql;
                }
                dt = configRefer.ListBySql(model.R_SQL);
            }
            else
            {
                string _filtersql = !String.IsNullOrEmpty(model.R_FilterSql) ? model.R_FilterSql : "";
                _filtersql = _filtersql + filter;

                //#region  特殊映射处理
                //if (ModuleName=="HR_StuffModule")
                //{
                //    //读取映射配置表中公司配置
                //    Bll_Comm comm = new Bll_Comm();
                //    string mapFilter = "";
                //    var mapModel = comm.CommMap(ModuleName, "Company");
                //    if (mapModel!=null)
                //    {
                //        var deptList = comm.GetChildListDeptNon(comm.CommMap(ModuleName, "Company").Map_Object);
                //        if (deptList.Count()>0)
                //        {
                //            foreach (var item in deptList)
                //            {
                                
                //            }
                //            for (int i = 0; i < deptList.Count;i++ )
                //            {
                //                if (i==(deptList.Count-1))
                //                {
                //                    mapFilter += "'" + deptList[i].Dept_Code+"'";
                //                }
                //                else
                //                {
                //                    mapFilter += "'" + deptList[i].Dept_Code+ "',";
                //                }
                //            }
                //            mapFilter.TrimEnd(',');
                //        }
                //        mapSqlFilter = " Stuff_DepCode in(" + mapFilter + ")";
                //    }
                //}
                //#endregion

                //为空时不初始化
                //if (!string.IsNullOrEmpty(filter))
                //{
                //    dt = configRefer.ListDataByCode(Name, _filtersql, filtersSql + mapSqlFilter);
                //}
                dt = configRefer.ListDataByCode(Name, _filtersql, filtersSql + mapSqlFilter);
            }

            DataTable newdt = DataTablePage.GetPagedTable(dt, page, rows);

            #region 字典进行转换
            //对字典进行转换

            for (int i = 0; i < newdt.Rows.Count; i++)
            {
                foreach (var item in referList.ToList())
                {
                    var value = newdt.Rows[i][item.D_Index] != null ? newdt.Rows[i][item.D_Index].ToString() : "";
                    var DictResult = DictInstance.GetListByCode(" AND Dict_Code='" + value
                                                                 + "' AND Dict_Key='" + item.D_DictKey + "' ");
                    if (DictResult.Count > 0)
                    {
                        newdt.Rows[i][item.D_Index] = DictResult.FirstOrDefault().Dict_Name;
                    }
                }
            }

            #endregion

            var json = DataTablePage.JsonForJqgrid(newdt, page, rows, dt.Rows.Count);
            return JavaScript(json);
        }

        
    }
}
