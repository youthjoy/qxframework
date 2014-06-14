using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;
using System.Data;
using QX.HtmlHelperLib.Model;
using QX.HtmlHelperLib.DAL;
using QX.HtmlHelperLib.Comm;
using Newtonsoft.Json.Converters;

namespace QX.HtmlHelperLib
{
    public class SConfigHelper
    {
        public static string JsonForJqgridForRpt(string Module, DataTable dt, int pageIndex, int pageSize, int totalCount)
        {

            StringBuilder jsonBuilder = new StringBuilder();

            StringBuilder sumBuilder = new StringBuilder();

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
            ADOSys_Config_Fieled cfInstance=new ADOSys_Config_Fieled();
            ADOSys_Config_ListPage clInstance=new ADOSys_Config_ListPage();
           // GetListConfig(Module, out M_Model, out listfiled);
            M_Model = clInstance.GetListByWhere(string.Format(" AND M_ModuleCode='{0}'", Module)).FirstOrDefault();
            listfiled = cfInstance.GetListByWhere(string.Format("AND D_ModuleCode='{0}'", Module));
            DataTable newDt = dt.Clone();
            //DataTable resultDt = dt.Clone();

            //string json = JsonConvert.SerializeObject(dt, new DataTableConverter(), new JsonDateConverter("yyyy-MM-dd"));

            //for (var x = 0; x < newDt.Columns.Count; x++)
            //{
            //    var D_Index = dt.Columns[x].ColumnName;

            //    var tmpModel = listfiled.Where(o => o.D_Index == D_Index);
            //    if (tmpModel.Count() > 0)
            //    {
            //        if (tmpModel.FirstOrDefault().D_EditType == "datetime")
            //        {
            //            newDt.Columns[x].DataType = typeof(string);
            //        }
            //        else if (tmpModel.FirstOrDefault().D_EditType == "date")
            //        {
            //            newDt.Columns[x].DataType = typeof(string);
            //        }
            //    }
            //}

            var timelist = listfiled.Where(o => o.D_EditType == "datetime" || o.D_EditType == "date");
            foreach (var t in timelist)
            {
                newDt.Columns[t.D_Index].DataType = typeof(string);
            }

            var D_SumList = listfiled.Where(o => !string.IsNullOrEmpty(o.D_Summary));

            newDt.Rows.Clear();
            for (var i = 0; i < dt.Rows.Count; i++)
            {
                DataRow newRow = newDt.NewRow();
                for (var j = 0; j < dt.Columns.Count; j++)
                {
                    var D_Index = dt.Columns[j].ColumnName;
                    var tmpModel = listfiled.Where(o => o.D_Index == D_Index);
                    var temp = timelist.FirstOrDefault(o => o.D_Index == D_Index);
                    if (temp != null)
                    {
                        if (temp.D_EditType == "datetime")
                        {

                            newRow[D_Index] = dt.Rows[i][D_Index] != null && !string.IsNullOrEmpty(dt.Rows[i][D_Index].ToString())
                                ? JsonConvert.SerializeObject(DateTime.Parse(dt.Rows[i][D_Index].ToString()), new JsonDateConverter("yyyy-MM-dd HH:mm:ss")).Replace("\"", " ") : "";
                        }
                        else if (temp.D_EditType == "date")
                        {
                            //newDt.Columns[j].DataType = typeof(string);
                            newRow[D_Index] = dt.Rows[i][D_Index] != null && !string.IsNullOrEmpty(dt.Rows[i][D_Index].ToString())
                                ? JsonConvert.SerializeObject(DateTime.Parse(dt.Rows[i][D_Index].ToString()), new JsonDateConverter("yyyy-MM-dd")).Replace("\"", " ") : "";
                        }
                    }
                    else
                    {
                        newRow[D_Index] = dt.Rows[i][D_Index];
                    }

                    //    if (tmpModel.Count() > 0)
                    //    {
                    //        if (tmpModel.FirstOrDefault().D_EditType == "datetime")
                    //        {

                    //            newRow[D_Index] = dt.Rows[i][D_Index] != null && !string.IsNullOrEmpty(dt.Rows[i][D_Index].ToString())
                    //                ? JsonConvert.SerializeObject(DateTime.Parse(dt.Rows[i][D_Index].ToString()), new JsonDateConverter("yyyy-MM-dd HH:mm:ss")).Replace("\"", " ") : "";
                    //        }
                    //        else if (tmpModel.FirstOrDefault().D_EditType == "date")
                    //        {
                    //            //newDt.Columns[j].DataType = typeof(string);
                    //            newRow[D_Index] = dt.Rows[i][D_Index] != null && !string.IsNullOrEmpty(dt.Rows[i][D_Index].ToString())
                    //                ? JsonConvert.SerializeObject(DateTime.Parse(dt.Rows[i][D_Index].ToString()), new JsonDateConverter("yyyy-MM-dd")).Replace("\"", " ") : "";
                    //        }
                    //        else
                    //        {
                    //            newRow[D_Index] = dt.Rows[i][D_Index];
                    //        }
                    //    }
                }

                newDt.Rows.Add(newRow);
            }
            #endregion

            if (D_SumList.Count() > 0 && newDt.Rows.Count > 0)
            {
                sumBuilder.Append(",\"UserData\":{");
                StringBuilder sb = new StringBuilder();
                foreach (var item in D_SumList)
                {
                    if (newDt.Columns.Contains(item.D_Index))
                    {
                        var val = newDt.Compute(string.Format("Sum({0})", item.D_Index), "");
                        //var d = decimal.Parse(val.ToString());
                        sb.AppendFormat("\"{0}\":{1},", item.D_Index, val);
                    }
                }
                sumBuilder.Append(sb.ToString().TrimEnd(','));
                sumBuilder.Append(" }");
            }
            else
            {
                sumBuilder.Append(",\"UserData\":{");
                StringBuilder sb = new StringBuilder();
                foreach (var item in D_SumList)
                {
                    //if (newDt.Columns.Contains(item.D_Index))
                    //{
                    //var val = newDt.Compute(string.Format("Sum({0})", item.D_Index), "");
                    //var d = decimal.Parse(val.ToString());
                    sb.AppendFormat("\"{0}\":{1},", item.D_Index, "0");
                    //}
                }
                sumBuilder.Append(sb.ToString().TrimEnd(','));
                sumBuilder.Append(" }");
            }

            jsonBuilder.Append(JsonConvert.SerializeObject(newDt, new DataTableConverter()));
            if (!string.IsNullOrEmpty(sumBuilder.ToString()))
            {
                jsonBuilder.Append(sumBuilder.ToString());
            }
            jsonBuilder.Append("}");
            return jsonBuilder.ToString();
        }
    }
}
