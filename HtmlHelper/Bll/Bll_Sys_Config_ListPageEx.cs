using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using QX.HtmlHelperLib.DAL;
using QX.HtmlHelperLib.Model;

namespace QX.HtmlHelperLib.BLL
{
    public partial class Bll_Sys_Config_ListPage
    {
        
        /// <summary>
        /// 初始化Grid
        /// </summary>
        /// <param name="ModuleCode"></param>
        /// <param name="Namespace"></param>
        /// <param name="param"></param>
        /// <returns></returns>
        public DataTable GetListPageAllRecords(string ModuleCode,string Namespace,Dictionary<string,string> param)
        {
            //读出配置存储过程及参数
            Bll_Sys_Config_ListPage ConfigMInstance = new Bll_Sys_Config_ListPage();
            ADOBse_Dict DictInstance = new ADOBse_Dict();
            Bll_Sys_Config_Fieled FieldInstance = new Bll_Sys_Config_Fieled();

            Sys_Config_ListPage config = ConfigMInstance.GetListByCode(" AND M_ModuleCode='" + ModuleCode + "' ")[0];
            List<Sys_Config_Fieled> ListField = FieldInstance.GetListByCode(" AND D_ModuleCode='" + ModuleCode + "'");

           
            List<SqlParameter> list = new List<SqlParameter>();
            SqlParameter search = new SqlParameter("@Search",param["@Search"]);
            list.Add(search);
            SqlParameter sidx = new SqlParameter("@Sidx", param["@Sidx"]);
            list.Add(sidx);
            SqlParameter sord = new SqlParameter("@Sord", param["@Sord"]);
            list.Add(sord);
            SqlParameter userid = new SqlParameter("@Userid", param["@Userid"]);
            list.Add(userid);
            SqlParameter deptid = new SqlParameter("@Deptid", param["@Deptid"]);
            list.Add(deptid);
            SqlParameter modulecode = new SqlParameter("@ModuleCode", ModuleCode);
            list.Add(modulecode);
            SqlParameter _namespace = new SqlParameter("@NameSpace", Namespace);
            list.Add(_namespace);
            SqlParameter InlineType = new SqlParameter("@InlineType", param["@InlineType"]);
            list.Add(InlineType);
            SqlParameter GeneralType = new SqlParameter("@GeneralType", param["@GeneralType"]);
            list.Add(GeneralType);
            DataTable newDt=instance.idb.RunProcReturnDatatable(config.M_SQL,list.ToArray());


            #region Old，已被废弃掉的代码片段 By Ye Fei  2011-01-30
            //首先获取config_filed表中有数据字典的列及相关数据字典标示
            //var newList = ListField.Where(o => !string.IsNullOrEmpty(o.D_DictKey) && o.D_EditType.ToLower()=="dict" && o.D_Hidden!="true" );
            //if (newList.Count()>0)
            //{ 
            //    for (int i = 0; i < newDt.Rows.Count; i++)
            //    {
            //        foreach (Sys_Config_Fieled item in newList)
            //        {
            //            var DictResult = DictInstance.GetListByCode(" AND Dict_Code='" + 
            //                                                          newDt.Rows[i][item.D_Index].ToString() 
            //                                                          + "' AND Dict_Key='"+item.D_DictKey+"' ");
            //            if (DictResult.Count > 0)
            //            {
            //                newDt.Rows[i][item.D_Index] = DictResult.FirstOrDefault().Dict_Name;
            //            }

            //            if (param["@InlineType"].Length > 0)
            //            {
            //                //物料动态字典取值
            //                string dynKey = param["@InlineType"] + "TYPE";
            //                var Result = DictInstance.GetListByCode(" AND Dict_Code='" +
            //                                                         newDt.Rows[i][item.D_Index].ToString()
            //                                                         + "' AND Dict_Key='" + dynKey.ToUpper() + "' ");
            //                if (Result.Count > 0)
            //                {
            //                    newDt.Rows[i][item.D_Index] = Result.FirstOrDefault().Dict_Name;
            //                }
            //            }

            //        }
            //    }
            //}
            
            ///排序
            //if (!string.IsNullOrEmpty(config.M_TableName))
            //{
            //    Bll_Comm commInstance = new Bll_Comm();
            //    DataSet ds = commInstance.GetTableInfo(config.M_TableName);
            //    string TableKey = commInstance.GetTableKey(ds);
            //    if (!string.IsNullOrEmpty(TableKey))
            //    {
            //        DataView dv = newDt.DefaultView;
            //        dv.Sort = TableKey + " desc";
            //        newDt = dv.ToTable();
            //    }
            //}
            #endregion
            return newDt;
        }
        public DataTable ListDataByCode(string TableName, string filter)
        {
            string sql = "SELECT * FROM "+TableName+" WHERE (Stat is null or Stat=0) AND "+filter ;
            return instance.idb.ReturnDataTable(sql);
        }
        public bool SaveData(string sql)
        {
            //int result = 0;
            //result = instance.idb.ExeCmd(sql);
            //bool _result = result > 0 ? true : false;
            //return _result;

            int Re = 0;
            //SQL日志记录
            var RunMethod = System.Reflection.MethodBase.GetCurrentMethod();
            System.Collections.Hashtable param = new System.Collections.Hashtable();
            string Ex = "0";
            foreach (System.Collections.DictionaryEntry item in instance.idb.GetParameters())
            {
                param.Add(item.Key, item.Value);
            }
            try
            {
                Re = instance.idb.ExeCmd(sql);
                Ex = Re.ToString();
            }
            catch (Exception ex)
            {
                Ex = ex.Message;
            }

            SysRunLog.InsertRunSql(sql, param, RunMethod.DeclaringType + "." + RunMethod.Name, Ex);

            bool _result = Re > 0 ? true : false;
            return _result;

        }

        public string GetTableKeyCode(string NameSapce)
        {
            SqlParameter x1 = new SqlParameter("@sTable", SqlDbType.NChar, 40);
            x1.Value = NameSapce.Trim();
            SqlParameter[] param = new SqlParameter[] { x1 };
            IDbDataParameter[] parames = param as IDbDataParameter[];
            DataTable dt = instance.idb.RunProcReturnDatatable("findnewid", parames);
            return dt.Rows[0][0].ToString();            
        }

    }
}
