using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Linq.Dynamic;

using QX.HtmlHelperLib.Model;
using QX.HtmlHelperLib.Comm;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.IO;
using System.Data;
using System.Collections;
using System.Text;
using System.Reflection;
using QX.HtmlHelperLib.BLL;
using QX.HtmlHelperLib.Comm;
using QX.HtmlHelperLib;
using QX.Config;


namespace QX.HtmlHelperLib.Controllers
{

    //[ExceptionFillters]
    //[ActionFillters]
    //[ResultFillters][QX.Cache.CompressFilter][QX.Cache.CacheFilter(Duration=120)]
    
    public class Sys_Config_ListPageController : Controller
    {

        private Bll_Sys_Config_ListPage instance = new Bll_Sys_Config_ListPage();
        private Bll_Sys_Config_Fieled filedInstance = new Bll_Sys_Config_Fieled();
        private Bll_Bse_Dict DictInstance = new Bll_Bse_Dict();

        //
        // GET: /Config_ListPage/

        public ActionResult Index()
        {
            return View();
        }

        /// <summary>
        /// 获取自增编码
        /// </summary>
        /// <param name="oper"></param>
        /// <param name="n"></param>
        /// <returns></returns>
        public ActionResult GetTableKeyCode(string oper, string n)
        {
            string newid = DateTime.Now.Ticks.ToString();
            if (oper == "add")
            {
                newid = instance.GetTableKeyCode(n);
            }
            return Content(newid);
        }

        /// <summary>
        /// 通过模块SQL语句自动绑定返回Grid
        /// </summary>
        /// <param name="Module"></param>
        /// <returns></returns>
        [HttpPost]        
        public ActionResult InitGrid(int page, int rows, string search, string sidx, string sord)
        {
            string ModuleCode = Request["ModuleCode"] == null ? "" : Request["ModuleCode"].ToString();
            string NameSpace = Request["NameSpace"] == null ? "" : Request["NameSpace"].ToString();
            string LoginId = Request["userid"] == null ? "" : Request["userid"].ToString(); // session
            string deptid = Request["deptid"] == null ? "" : Request["deptid"].ToString();  // session
            string filters = Request["filters"] == null ? "" : Request["filters"].ToString();
            string Inlinetype = Request["itype"] == null ? "0" : Request["itype"].ToString();
            string GeneralType = Request["type"] == null ? "0" : Request["type"].ToString();
            string record = Request["record"] == null ? "" : Request["record"];
            string filtersSql = "1=1";
            if (!string.IsNullOrEmpty(filters))
            {
                filtersSql = filters.BuildSearch(ModuleCode);
                //filtersSql = BulidJqGridSearch.BuildSearch(filters);
                //动态查询入口更改，查询结果后进行筛选
                //filtersSql = "";
            }

            //临时赋值
            LoginId = SessionConfig.UserId();
            deptid = SessionConfig.DeptId();

            //预留两个自定义参数

            Dictionary<String, String> param = new Dictionary<string, string>();
            param.Add("@Page", page.ToString());
            param.Add("@Rows", rows.ToString());
            param.Add("@Search", filtersSql); //查询字段
            param.Add("@Sidx", sidx);     //排序字段
            param.Add("@Sord", sord);     //排序 ASC DESC
            param.Add("@ModuleCode", ModuleCode); //模块编码
            param.Add("@NameSpace", NameSpace); //模块命名空间
            param.Add("@Userid", LoginId);
            param.Add("@Deptid", deptid);
            param.Add("@InlineType", Inlinetype);
            param.Add("@GeneralType", GeneralType);

            //获取所有的数据列
            var dt = instance.GetListPageAllRecords(ModuleCode, NameSpace, param);
            if (!string.IsNullOrEmpty(record))
            {
                dt = FilterDataTable(dt, "Record_ID='" + record + "'");
            }
            DataTable newDt = GetPagedTable(dt, page, rows, ModuleCode);            
            

            //newDt.DefaultView.Sort = " CreateDate DESC ";
            //DataTable newDt = DataTablePage.GetPagedTable(dt, page, rows);

            //var json = DataTablePage.JsonForJqgrid(newDt, page, rows, dt.Rows.Count);
            var json = Bll_Comm.JsonForJqgrid(ModuleCode,newDt, page, rows, dt.Rows.Count);
            return JavaScript(json);
        }


        private Dictionary<string, string> FormParse(string Keys)
        {
            Dictionary<string, string> KeyPaire = new Dictionary<string, string>();
            string[] Key = Keys.Split('&');
            for (var i = 0; i < Key.Length; i++)
            {
                string[] val = Key[i].Split('=');
                KeyPaire.Add(val[0], val[1]);
            }
            return KeyPaire;
        }

        /// <summary>
        /// 通用编辑方法
        /// </summary>
        /// <param name="oper">操作</param>
        /// <param name="id">code</param>
        /// <returns></returns>
        [HttpPost]
        public ActionResult GridEdit(string oper, string id)
        {
            string ModuleCode = Request["ModuleCode"] == null ? "" : Request["ModuleCode"].ToString();
            string NameSpace = Request["NameSpace"] == null ? "" : Request["NameSpace"].ToString();
            string Form = Request["form"] == null ? "" : Request["form"];
            string FormId = Request["btn"];
            oper = !string.IsNullOrEmpty(oper) ? oper : (Request["oper"] != null ? Request["oper"] : "");
            id = !string.IsNullOrEmpty(id) ? id : (Request["id"] != null ? Request["id"] : "");

            string TableName = "";
            string InertSQL = "";
            string UpdateSQL = "";
            string DeleteSQL = "";
            string TableKey = "";
            string filterKey = "";
            bool result = false;
            string strResult = "fail";
            Dictionary<string, string> FormValue = new Dictionary<string, string>();
            Sys_Config_ListPage model=new Sys_Config_ListPage();
            List<Sys_Config_Fieled> listfiled = new List<Sys_Config_Fieled>();
            StringBuilder ErrorList = new StringBuilder();

            if (!string.IsNullOrEmpty(ModuleCode) && !string.IsNullOrEmpty(NameSpace))
            {
                // var _model = instance.GetListByCode(" AND M_ModuleCode='" + ModuleCode + "' AND M_NameSpace='" + NameSpace + "' ");
                var _model = instance.GetListByCode(" AND M_ModuleCode='" + ModuleCode + "' ");
                model = _model.Count > 0 ? _model[0] : null;
                //var listfiled = filedInstance.GetListByCode(" AND D_ModuleCode='" + ModuleCode + "' AND D_NameSpace='" + NameSpace + "' ");
                listfiled = filedInstance.GetListByCode(" AND D_ModuleCode='" + ModuleCode + "'");
                TableName = model.M_TableName;
                TableKey = listfiled.Where(o => o.D_IsKey == 1).FirstOrDefault().D_Index;
                filterKey = string.Format("{0}='{1}'", TableKey, id);
                if (!string.IsNullOrEmpty(Form))
                {
                    FormValue = FormParse(Form);
                    string _key = "";
                    string _value = "";
                    string _upkey = "";
                    filterKey = string.Format("{0}='{1}'", TableKey, FormValue[TableKey]);

                    var newListFiled = listfiled.Where(o => string.IsNullOrEmpty(o.D_EditHidden)
                        || o.D_EditHidden == "false"
                        || !string.IsNullOrEmpty(o.D_DefaultValue)
                        || o.D_EditType == "loadall");

                    if (!string.IsNullOrEmpty(FormId))
                    {
                        #region 扩展


                        if (FormId.Contains("btn1"))
                        {
                            newListFiled = listfiled.Where(o => !string.IsNullOrEmpty(o.D_UDEF1)
                            && JsonConvert.DeserializeObject<FormEdit>(o.D_UDEF1).Show.ToLower() == "true")
                            .OrderBy(o => JsonConvert.DeserializeObject<FormEdit>(o.D_UDEF1).Order).ToList();
                        }
                        else if (FormId.Contains("btn2"))
                        {
                            newListFiled = listfiled.Where(o => !string.IsNullOrEmpty(o.D_UDEF2)
                            && JsonConvert.DeserializeObject<FormEdit>(o.D_UDEF2).Show.ToLower() == "true")
                            .OrderBy(o => JsonConvert.DeserializeObject<FormEdit>(o.D_UDEF2).Order).ToList();
                        }
                        else if (FormId.Contains("btn3"))
                        {
                            newListFiled = listfiled.Where(o => !string.IsNullOrEmpty(o.D_UDEF3)
                            && JsonConvert.DeserializeObject<FormEdit>(o.D_UDEF3).Show.ToLower() == "true")
                            .OrderBy(o => JsonConvert.DeserializeObject<FormEdit>(o.D_UDEF3).Order).ToList();
                        }
                        else if (FormId.Contains("btn4"))
                        {
                            newListFiled = listfiled.Where(o => !string.IsNullOrEmpty(o.D_UDEF4)
                              && JsonConvert.DeserializeObject<FormEdit>(o.D_UDEF4).Show.ToLower() == "true")
                              .OrderBy(o => JsonConvert.DeserializeObject<FormEdit>(o.D_UDEF4).Order).ToList();
                        }
                        #endregion
                    }

                    foreach (var item in newListFiled)
                    {
                        try
                        {
                            if (!string.IsNullOrEmpty(FormValue[item.D_Index]))
                            {
                                if (!string.IsNullOrEmpty(item.D_Type) && item.D_Type.Contains("int"))
                                {
                                    _value += "" + FormValue[item.D_Index] + "" + ",";
                                    _upkey += item.D_Index + "=" + FormValue[item.D_Index] + "" + ",";
                                }
                                else
                                {
                                    if (item.D_Type.Contains("datetime"))
                                    {
                                        FormValue[item.D_Index] = FormValue[item.D_Index].Replace("+"," ");
                                    }
                                    _value += "'" + FormValue[item.D_Index] + "'" + ",";
                                    _upkey += item.D_Index + "='" + FormValue[item.D_Index] + "'" + ",";
                                }
                                _key += item.D_Index + ",";
                            }
                            else
                            {
                                if (!string.IsNullOrEmpty(item.D_Type) && (item.D_Type.Contains("int") || item.D_Type.Contains("decimal")))
                                {
                                    _value += "0,";
                                    _upkey += item.D_Index + "=0" + ",";
                                }
                                else
                                {
                                    if (item.D_Type.Contains("datetime"))
                                    {
                                        FormValue[item.D_Index] = "1900-01-01";
                                    }
                                    _value += "'" + FormValue[item.D_Index] + "'" + ",";
                                    _upkey += item.D_Index + "='" + FormValue[item.D_Index] + "'" + ",";
                                }
                                _key += item.D_Index + ",";
                            }
                        }
                        catch (System.Exception ex)
                        {
                            ErrorList.AppendLine(ex.ToString());
                            continue;
                        }
                        
                    }
                    //拼接Add sql
                    _key = _key;// +" CreateTime,";
                    _value = _value;// +"'" + DateTime.Now + "',";
                    InertSQL = "INSERT INTO  " + TableName + " (" + _key.TrimEnd(',') + ") VALUES (" + _value.TrimEnd(',') + ")  ";
                    //拼接update sql
                    _upkey = _upkey;//+ " UpdateTime='" + DateTime.Now + "',";
                    UpdateSQL = "UPDATE " + TableName + " SET " + _upkey.TrimEnd(',') + " WHERE " + filterKey;

                }
                //拼接 Delete Sql
                DeleteSQL = "UPDATE " + TableName + " SET Stat=1 WHERE " + filterKey;
            }

            switch (oper)
            {
                case "add":
                    result = instance.SaveData(InertSQL);
                    strResult = result ? "success" : "fail";
                                        
                    //功能日志
                    this.OpLog(model.M_ModuleCode,
                        "添加:" + model.M_Title + ",编码:" + FormValue[TableKey],
                        strResult + "," + InertSQL + "," + ErrorList.ToString());
                    
                    return Content(strResult);
                case "edit":
                    result = instance.SaveData(UpdateSQL);
                    strResult = result ? "success" : "fail";

                    //功能日志
                    this.OpLog(model.M_ModuleCode,
                       "修改:" + model.M_Title + ",编码:" + FormValue[TableKey],
                       strResult + "," + InertSQL + "," + ErrorList.ToString());

                    return Content(strResult);
                case "del":
                    result = instance.SaveData(DeleteSQL);
                    strResult = result ? "success" : "fail";
                    
                    //功能日志
                    this.OpLog(model.M_ModuleCode,
                        "删除:" + model.M_Title + ",编码:" + id,
                        strResult + "," + InertSQL + "," + ErrorList.ToString());

                    return Content(strResult);
                case "view":
                    DataTable dt = instance.ListDataByCode(TableName, filterKey);

                    DataTable newDt = dt.Clone();
                    //string json = JsonConvert.SerializeObject(dt, new DataTableConverter(), new JsonDateConverter("yyyy-MM-dd"));

                    for (var x = 0; x < newDt.Columns.Count;x++ )
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
                    for (var i = 0; i < dt.Rows.Count;i++ )
                    {
                        DataRow newRow = newDt.NewRow();
                        for (var j = 0; j < dt.Columns.Count;j++ )
                        {
                            var D_Index = dt.Columns[j].ColumnName;
                            
                            var tmpModel = listfiled.Where(o => o.D_Index == D_Index);
                            if (tmpModel.Count()>0)
                            {
                                if (tmpModel.FirstOrDefault().D_EditType == "datetime")
                               {

                                   newRow[D_Index] = dt.Rows[i][j] != null && !string.IsNullOrEmpty(dt.Rows[i][j].ToString()) 
                                       ? JsonConvert.SerializeObject(DateTime.Parse(dt.Rows[i][j].ToString()), new JsonDateConverter("yyyy-MM-dd HH:mm:ss")).Replace("\"","") : "";
                               }
                               else if (tmpModel.FirstOrDefault().D_EditType == "date") 
                               {
                                   //newDt.Columns[j].DataType = typeof(string);
                                   newRow[D_Index] = dt.Rows[i][j] != null && !string.IsNullOrEmpty(dt.Rows[i][j].ToString())
                                       ? JsonConvert.SerializeObject(DateTime.Parse(dt.Rows[i][j].ToString()), new JsonDateConverter("yyyy-MM-dd")).Replace("\"", "") : "";
                               }
                               else
                               {
                                   newRow[D_Index] = dt.Rows[i][j];
                               }                                
                            }
                            
                        }
                        newDt.Rows.Add(newRow);
                    }
                    string json = JsonConvert.SerializeObject(newDt, new DataTableConverter());
                    return JavaScript(json);
            }
            return Content("");
        }

        public string JsonForJqgrid(DataTable dt, int pageIndex, int pageSize, int totalCount)
        {
            StringBuilder jsonBuilder = new StringBuilder();
            int total = 0;
            int page = totalCount / pageSize;
            total = totalCount > pageSize ? totalCount / pageSize : 1;
            if (totalCount % pageSize>0)
            {            
                total=total + 1;
            }
            jsonBuilder.Append("{\"Page\":" + pageIndex + ",\"Total\":" + total + ",\"Records\":" + totalCount + ",\"Rows\":");
            jsonBuilder.Append(JsonConvert.SerializeObject(dt, new DataTableConverter(), new JsonDateConverter("yyyy-MM-dd")));
            jsonBuilder.Append("}");
            return jsonBuilder.ToString();
        }

        public static DataTable GetPagedTable(DataTable dt, int PageIndex, int PageSize)
        {
            if (PageIndex == 0)
                return dt;
            DataTable newdt = dt.Clone();
            //newdt.Clear();
            int rowbegin = (PageIndex - 1) * PageSize;
            int rowend = PageIndex * PageSize;

            if (rowbegin >= dt.Rows.Count)
                return newdt;

            if (rowend > dt.Rows.Count)
                rowend = dt.Rows.Count;
            for (int i = rowbegin; i <= rowend - 1; i++)
            {
                DataRow newdr = newdt.NewRow();
                DataRow dr = dt.Rows[i];
                foreach (DataColumn column in dt.Columns)
                {
                    newdr[column.ColumnName] = dr[column.ColumnName];
                }
                newdt.Rows.Add(newdr);
            }
            return newdt;
        }


        public DataTable GetPagedTable(DataTable dt, int PageIndex, int PageSize, string moduleCode)
        {
            if (PageIndex == 0)
                return null;
            DataTable newdt = dt.Clone();

            #region 获取字典相关信息
            //获取列表字段的配置信息
            Bll_Sys_Config_Fieled filedInstance = new Bll_Sys_Config_Fieled();
            Bll_Bse_Dict DictInstance = new Bll_Bse_Dict();
            List<Sys_Config_Fieled> listField = filedInstance.GetListByCode(" AND D_ModuleCode='" + moduleCode + "'");
            string dictKeyList = "''";
            foreach (var field in listField)
            {
                if (!string.IsNullOrEmpty(field.D_DictKey))
                {
                    dictKeyList += ",'" + field.D_DictKey + "'";
                }                
            }
            //获取配置信息中所有的字典表关键字里拥有的字典信息
            List<Bse_Dict> listDictionary = DictInstance.GetListByCode("  and (dict_key in (" + dictKeyList + "))");
            
            #endregion

            //newdt.Clear();
            int rowbegin = (PageIndex - 1) * PageSize;
            int rowend = PageIndex * PageSize;

            if (rowbegin >= dt.Rows.Count)//如果开始列数大于所拥有的列数
                rowbegin = 0;

            if (rowend > dt.Rows.Count)
                rowend = dt.Rows.Count;
            for (int i = rowbegin; i <= rowend - 1; i++)
            {
                DataRow newdr = newdt.NewRow();
                DataRow dr = dt.Rows[i];
                foreach (DataColumn column in dt.Columns)
                {
                    newdr[column.ColumnName] = dr[column.ColumnName];
                    //更新字典信息
                    var field = listField.Where(o => o.D_Index == column.ColumnName).FirstOrDefault();
                    if (field!=null&&!string.IsNullOrEmpty(field.D_DictKey))
                    {
                        Bse_Dict dict = listDictionary.Where(o => o.Dict_Code == dr[column.ColumnName].ToString()).FirstOrDefault();
                        if (dict != null)
                        {
                            newdr[column.ColumnName] = dict.Dict_Name;
                        }
                    }

                    //对编码进行转换
                    //if (field!=null && !string.IsNullOrEmpty(field.D_UDEF1))
                    //{
                    //    string[] Converts = field.D_UDEF1.Split(',');
                    //    if (Converts.Count()==3)
                    //    {
                    //        if (dr[column.ColumnName]!=null && !string.IsNullOrEmpty(dr[column.ColumnName].ToString()))
                    //        {
                    //            var data = instance.ListDataByCode(Converts[0], Converts[1] + "='" + dr[column.ColumnName].ToString() + "'");
                    //            if (data.Rows.Count>0)
                    //            {
                    //                newdr[column.ColumnName] = data.Rows[0][Converts[2]].ToString();
                    //            }
                    //        }                           
                    //    }
                    //}
                    
                }
                newdt.Rows.Add(newdr);
            }
            return newdt;
        }


        private DataRow ConvertDataTableDictionaryDisplay(DataRow dtSource, string moduleCode)
        {


            return dtSource;
        }

        public static DataTable FilterDataTable(DataTable dt, string filter)
        {
            DataTable newDt = dt.Clone();
            DataRow[] rows = dt.Select(filter);
            if (rows.Length > 0)
            {
                for (var i = 0; i < rows.Length; i++)
                {
                    newDt.ImportRow(rows[i]);
                }
            }
            return newDt;
        }

        /// <summary>
        /// 导出当前查询的Excel
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        //public ActionResult Export(string id, string data)
        //{

        //    data = HttpContext.Request.QueryString.ToString();

        //    Dictionary<string, string> form = new Dictionary<string, string>();
        //    var newForm = new Dictionary<string, string>();
        //    if (!string.IsNullOrEmpty(data))
        //    {
        //        newForm = QX.Comm.StringHelper.FormParse(data);
        //        if (newForm.Count == 0)
        //        {
        //            return Content("script> alert('获取参数失败');history.go(-1); </script>");
        //        }
        //    }

        //    //获取
        //    var itemValue = "";
        //    foreach (var item in newForm)
        //    {
        //        if (!string.IsNullOrEmpty(item.Value))
        //        {
        //            itemValue = HttpContext.Server.UrlDecode(item.Value);
        //            form.Add(item.Key, itemValue);
        //        }
        //        else
        //        {
        //            form.Add(item.Key, "");
        //        }

        //    }

        //    string Module = id;
        //    QX.HtmlHelperLib.Model.Sys_Config_ListPage M_Model = new QX.Model.Sys_Config_ListPage();
        //    List<QX.HtmlHelperLib.Model.Sys_Config_Fieled> D_List = new List<QX.Model.Sys_Config_Fieled>();
        //    QX.BLL.Bll_Comm.GetListConfig(Module, out M_Model, out D_List);


        //    DataTable dt = new DataTable();

        //    if (M_Model != null)
        //    {
        //        var Paramter = M_Model.M_Parameters.Split(',');
        //        System.Data.SqlClient.SqlParameter[] param = new System.Data.SqlClient.SqlParameter[Paramter.Length + 1];
        //        var ModuleParameter = new System.Data.SqlClient.SqlParameter("@Module", System.Data.SqlDbType.VarChar, 50);
        //        ModuleParameter.Value = Module;
        //        param[0] = ModuleParameter;
        //        for (var i = 0; i < Paramter.Count(); i++)
        //        {
        //            var item = Paramter[i];
        //            if (!string.IsNullOrEmpty(item))
        //            {
        //                ModuleParameter = new System.Data.SqlClient.SqlParameter();
        //                ModuleParameter.ParameterName = "@" + item;
        //                if (form.ContainsKey(item))
        //                {
        //                    if (item.ToLower().Contains("edate"))
        //                    {
        //                        var date = DateTime.Parse(form[item]).ToString("yyyy-MM-dd 23:59:59");
        //                        ModuleParameter.Value = date;
        //                    }
        //                    else
        //                    {
        //                        ModuleParameter.Value = form[item];
        //                    }
        //                }
        //                else
        //                {
        //                    ModuleParameter.Value = "";
        //                }
        //                param[i + 1] = ModuleParameter;
        //            }
        //        }
        //        dt = QX.BLL.Bll_Comm.RunProc(M_Model.M_SQL, param);

        //        if (dt.Rows.Count==0)
        //        {
        //            return Content("<script>alert('没有数据,不需要导出');history.go(-1);</script>");
        //        }

        //        if (string.IsNullOrEmpty(M_Model.M_Title))
        //        {
        //            return Content("<script>alert('配置错误,请配置模块名称');history.go(-1);</script>");
        //        }

        //        var headers = D_List.Where(o => string.IsNullOrEmpty(o.D_Hidden) || o.D_Hidden == "false")
        //            .OrderBy(o => o.D_ShowOrder).Select(o => o.D_Name).ToArray();
        //        var rowsKey = D_List.Where(o => string.IsNullOrEmpty(o.D_Hidden) || o.D_Hidden == "false")
        //            .OrderBy(o => o.D_ShowOrder).Select(o => o.D_Index).ToArray();

                
        //        return this.Excel(M_Model.M_Title, M_Model.M_Title, dt, headers, rowsKey);       
       
        //    }
        //    else
        //    {
        //        return Content("<script>alert('导出配置模块出错');history.go(-1);</script>");
        //    }          
        //}


    }

}
