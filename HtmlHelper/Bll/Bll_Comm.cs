using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using QX.HtmlHelperLib.DAL;
using QX.HtmlHelperLib.Model;
using System.Collections;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using QX.Config;
using System.Web;
using QX.Log;
using QX.HtmlHelperLib.Comm;
namespace QX.HtmlHelperLib.BLL
{
    public class Bll_Comm
    {
        public const string root = "ROOT";


        /// <summary>
        /// 写入操作日志
        /// </summary>
        /// <param name="Module">模块编码 </param>
        /// <param name="ModuleName">模块名称</param>
        /// <param name="Message">异常信息</param>
        public static void OpLog(string Module, string ModuleName, string Message)
        {
            var IS_OPEN_PERMISSION = ConfigHelper.GetApp("IS_OPEN_FUNCATIONLOG");
            if (!string.IsNullOrEmpty(IS_OPEN_PERMISSION) && IS_OPEN_PERMISSION == "true")
            {
                try
                {
                    PlateLog.WriteOp(SessionConfig.UserId(), SessionConfig.UserName(),
                    HttpContext.Current.Request.UserHostAddress, HttpContext.Current.Request.Url.ToString(),
                    Message, PlateLog.LogMessageType.Info, Module, ModuleName);
                }
                catch (System.Exception ex)
                {
                    PlateLog.WriteInFile(SessionConfig.UserId(), SessionConfig.UserName(),
                    HttpContext.Current.Request.UserHostAddress, HttpContext.Current.Request.Url.ToString(),
                    Message, PlateLog.LogMessageType.Error, ex);
                }
            }

        }

        public static string JsonForJqgrid(string Module, DataTable dt, int pageIndex, int pageSize, int totalCount)
        {
            StringBuilder jsonBuilder = new StringBuilder();
            int total = 0;
            int page = totalCount / pageSize;
            total = totalCount > pageSize ? totalCount / pageSize : 1;
            if (totalCount > pageSize)
            {
                if (totalCount % pageSize > 0)
                {
                    total = total + 1;
                }
            }
            if (totalCount == 0)
            {
                total = 0;
                pageIndex = 0;
            }

            jsonBuilder.Append("{\"Page\":" + pageIndex + ",\"Total\":" + total + ",\"Records\":" + totalCount + ",\"Rows\":");


            #region 对时间进行格式化

            Sys_Config_ListPage M_Model = new Sys_Config_ListPage();
            List<Sys_Config_Fieled> listfiled = new List<Sys_Config_Fieled>();
            GetListConfig(Module, out M_Model, out listfiled);

            DataTable newDt = dt.Clone();
            //DataTable resultDt = dt.Clone();

            //string json = JsonConvert.SerializeObject(dt, new DataTableConverter(), new JsonDateConverter("yyyy-MM-dd"));

            for (var x = 0; x < newDt.Columns.Count; x++)
            {
                var D_Index = dt.Columns[x].ColumnName;

                var tmpModel = listfiled.Where(o => o.D_Index == D_Index);
                if (tmpModel.Count() > 0)
                {
                    if (tmpModel.FirstOrDefault().D_EditType == "datetime")
                    {
                        newDt.Columns[x].DataType = typeof(string);
                    }
                    else if (tmpModel.FirstOrDefault().D_EditType == "date")
                    {
                        newDt.Columns[x].DataType = typeof(string);
                    }
                }
            }

            newDt.Rows.Clear();
            for (var i = 0; i < dt.Rows.Count; i++)
            {
                DataRow newRow = newDt.NewRow();
                for (var j = 0; j < dt.Columns.Count; j++)
                {
                    var D_Index = dt.Columns[j].ColumnName;
                    var tmpModel = listfiled.Where(o => o.D_Index == D_Index);
                    if (tmpModel.Count() > 0)
                    {
                        if (tmpModel.FirstOrDefault().D_EditType == "datetime")
                        {

                            newRow[D_Index] = dt.Rows[i][D_Index] != null && !string.IsNullOrEmpty(dt.Rows[i][D_Index].ToString())
                                ? JsonConvert.SerializeObject(DateTime.Parse(dt.Rows[i][D_Index].ToString()), new JsonDateConverter("yyyy-MM-dd HH:mm:ss")).Replace("\"", " ") : "";
                        }
                        else if (tmpModel.FirstOrDefault().D_EditType == "date")
                        {
                            //newDt.Columns[j].DataType = typeof(string);
                            newRow[D_Index] = dt.Rows[i][D_Index] != null && !string.IsNullOrEmpty(dt.Rows[i][D_Index].ToString())
                                ? JsonConvert.SerializeObject(DateTime.Parse(dt.Rows[i][D_Index].ToString()), new JsonDateConverter("yyyy-MM-dd")).Replace("\"", " ") : "";
                        }
                        else
                        {
                            newRow[D_Index] = dt.Rows[i][D_Index];
                        }
                    }
                }
                newDt.Rows.Add(newRow);
            }
            #endregion


            jsonBuilder.Append(JsonConvert.SerializeObject(newDt, new DataTableConverter()));
            //jsonBuilder.Append(" ,\"UserData\":{ \"PUD_Num\":100 } ");
            jsonBuilder.Append("}");
            return jsonBuilder.ToString();
        }


        public static Sys_Config_ListPage GetListConfig(string moduleName, out Sys_Config_ListPage M_Model, out List<Sys_Config_Fieled> D_List)
        {
            ADOSys_Config_ListPage ListInstance = new ADOSys_Config_ListPage();
            ADOSys_Config_Fieled FieledInstance = new ADOSys_Config_Fieled();
            M_Model = null;
            D_List = null;
            try
            {
                if (!string.IsNullOrEmpty(moduleName))
                {
                    //第一步：根据传入模块获取Grid配置
                    List<Sys_Config_ListPage> _ListPage = ListInstance.GetListByWhere(" AND M_ModuleCode='" +
                    moduleName + "'");
                    if (_ListPage.Count > 0)
                    {
                        M_Model = _ListPage[0];
                    }
                    //第二步：根据模块获取所有字段
                    D_List = FieledInstance.GetListByWhere(" AND D_ModuleCode='" + moduleName + "'");
                }
                else
                {
                    M_Model = null;
                    D_List = null;
                }
            }
            catch (System.Exception ex)
            {
                M_Model = null;
                D_List = null;
            }

            return M_Model;
        }

    }
}
