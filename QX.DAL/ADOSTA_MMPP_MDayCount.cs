using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Text;
using QX.Model;
using QX.DataAcess;

namespace QX.DAL
{
   /// <summary>
   /// 采购计划物料按天汇总表
   /// </summary>
   [Serializable]
   public partial class ADOSTA_MMPP_MDayCount
   {
      public IDBOperator idb =  DBOperator.GetInstance();
      /// <summary>
      /// 添加采购计划物料按天汇总表 STA_MMPP_MDayCount对象(即:一条记录)
      /// </summary>
      public int Add(STA_MMPP_MDayCount sTA_MMPP_MDayCount)
      {
         string sql = "INSERT INTO STA_MMPP_MDayCount (PP_DeptCode,PP_Dept,PP_CompanyCode,PP_Company,PP_DateTime,PP_MCode,PP_MName,PP_Spec,PP_PlanCount,PP_ROCount,Stat) VALUES (@PP_DeptCode,@PP_Dept,@PP_CompanyCode,@PP_Company,@PP_DateTime,@PP_MCode,@PP_MName,@PP_Spec,@PP_PlanCount,@PP_ROCount,@Stat)";
         if (string.IsNullOrEmpty(sTA_MMPP_MDayCount.PP_DeptCode))
         {
            idb.AddParameter("@PP_DeptCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PP_DeptCode", sTA_MMPP_MDayCount.PP_DeptCode);
         }
         if (string.IsNullOrEmpty(sTA_MMPP_MDayCount.PP_Dept))
         {
            idb.AddParameter("@PP_Dept", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PP_Dept", sTA_MMPP_MDayCount.PP_Dept);
         }
         if (string.IsNullOrEmpty(sTA_MMPP_MDayCount.PP_CompanyCode))
         {
            idb.AddParameter("@PP_CompanyCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PP_CompanyCode", sTA_MMPP_MDayCount.PP_CompanyCode);
         }
         if (string.IsNullOrEmpty(sTA_MMPP_MDayCount.PP_Company))
         {
            idb.AddParameter("@PP_Company", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PP_Company", sTA_MMPP_MDayCount.PP_Company);
         }
         if (sTA_MMPP_MDayCount.PP_DateTime == DateTime.MinValue)
         {
            idb.AddParameter("@PP_DateTime", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PP_DateTime", sTA_MMPP_MDayCount.PP_DateTime);
         }
         if (string.IsNullOrEmpty(sTA_MMPP_MDayCount.PP_MCode))
         {
            idb.AddParameter("@PP_MCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PP_MCode", sTA_MMPP_MDayCount.PP_MCode);
         }
         if (string.IsNullOrEmpty(sTA_MMPP_MDayCount.PP_MName))
         {
            idb.AddParameter("@PP_MName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PP_MName", sTA_MMPP_MDayCount.PP_MName);
         }
         if (string.IsNullOrEmpty(sTA_MMPP_MDayCount.PP_Spec))
         {
            idb.AddParameter("@PP_Spec", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PP_Spec", sTA_MMPP_MDayCount.PP_Spec);
         }
         if (sTA_MMPP_MDayCount.PP_PlanCount == 0)
         {
            idb.AddParameter("@PP_PlanCount", 0);
         }
         else
         {
            idb.AddParameter("@PP_PlanCount", sTA_MMPP_MDayCount.PP_PlanCount);
         }
         if (sTA_MMPP_MDayCount.PP_ROCount == 0)
         {
            idb.AddParameter("@PP_ROCount", 0);
         }
         else
         {
            idb.AddParameter("@PP_ROCount", sTA_MMPP_MDayCount.PP_ROCount);
         }
         if (sTA_MMPP_MDayCount.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", sTA_MMPP_MDayCount.Stat);
         }

           
             int Re = 0;
             //SQL日志记录
             var RunMethod = System.Reflection.MethodBase.GetCurrentMethod();
             System.Collections.Hashtable param = new System.Collections.Hashtable();
             string Ex = "0";
             foreach (System.Collections.DictionaryEntry item in idb.GetParameters())
             {
                 param.Add(item.Key, item.Value);
             }
             try
             {
                 Re = idb.ExeCmd(sql);
                 Ex = Re.ToString();
             }
             catch (Exception ex)
             {
                 Ex = ex.Message;
             }
             
             SysRunLog.InsertRunSql(sql, param, RunMethod.DeclaringType + "." + RunMethod.Name,Ex);

             return Re;
         
      }
      /// <summary>
      /// 添加采购计划物料按天汇总表 STA_MMPP_MDayCount对象(即:一条记录)
      /// </summary>
      public object AddWithReturn(STA_MMPP_MDayCount sTA_MMPP_MDayCount)
      {
         string sql = "INSERT INTO STA_MMPP_MDayCount (PP_DeptCode,PP_Dept,PP_CompanyCode,PP_Company,PP_DateTime,PP_MCode,PP_MName,PP_Spec,PP_PlanCount,PP_ROCount,Stat) VALUES (@PP_DeptCode,@PP_Dept,@PP_CompanyCode,@PP_Company,@PP_DateTime,@PP_MCode,@PP_MName,@PP_Spec,@PP_PlanCount,@PP_ROCount,@Stat);SELECT @@IDENTITY AS ReturnID;";
         if (string.IsNullOrEmpty(sTA_MMPP_MDayCount.PP_DeptCode))
         {
            idb.AddParameter("@PP_DeptCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PP_DeptCode", sTA_MMPP_MDayCount.PP_DeptCode);
         }
         if (string.IsNullOrEmpty(sTA_MMPP_MDayCount.PP_Dept))
         {
            idb.AddParameter("@PP_Dept", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PP_Dept", sTA_MMPP_MDayCount.PP_Dept);
         }
         if (string.IsNullOrEmpty(sTA_MMPP_MDayCount.PP_CompanyCode))
         {
            idb.AddParameter("@PP_CompanyCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PP_CompanyCode", sTA_MMPP_MDayCount.PP_CompanyCode);
         }
         if (string.IsNullOrEmpty(sTA_MMPP_MDayCount.PP_Company))
         {
            idb.AddParameter("@PP_Company", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PP_Company", sTA_MMPP_MDayCount.PP_Company);
         }
         if (sTA_MMPP_MDayCount.PP_DateTime == DateTime.MinValue)
         {
            idb.AddParameter("@PP_DateTime", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PP_DateTime", sTA_MMPP_MDayCount.PP_DateTime);
         }
         if (string.IsNullOrEmpty(sTA_MMPP_MDayCount.PP_MCode))
         {
            idb.AddParameter("@PP_MCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PP_MCode", sTA_MMPP_MDayCount.PP_MCode);
         }
         if (string.IsNullOrEmpty(sTA_MMPP_MDayCount.PP_MName))
         {
            idb.AddParameter("@PP_MName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PP_MName", sTA_MMPP_MDayCount.PP_MName);
         }
         if (string.IsNullOrEmpty(sTA_MMPP_MDayCount.PP_Spec))
         {
            idb.AddParameter("@PP_Spec", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PP_Spec", sTA_MMPP_MDayCount.PP_Spec);
         }
         if (sTA_MMPP_MDayCount.PP_PlanCount == 0)
         {
            idb.AddParameter("@PP_PlanCount", 0);
         }
         else
         {
            idb.AddParameter("@PP_PlanCount", sTA_MMPP_MDayCount.PP_PlanCount);
         }
         if (sTA_MMPP_MDayCount.PP_ROCount == 0)
         {
            idb.AddParameter("@PP_ROCount", 0);
         }
         else
         {
            idb.AddParameter("@PP_ROCount", sTA_MMPP_MDayCount.PP_ROCount);
         }
         if (sTA_MMPP_MDayCount.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", sTA_MMPP_MDayCount.Stat);
         }

           
             int Re = 0;
             //SQL日志记录
             var RunMethod = System.Reflection.MethodBase.GetCurrentMethod();
             System.Collections.Hashtable param = new System.Collections.Hashtable();
             string Ex = "0";
             foreach (System.Collections.DictionaryEntry item in idb.GetParameters())
             {
                 param.Add(item.Key, item.Value);
             }
             try
             {
                 var Return = idb.ReturnValue(sql);
                 Ex = Return.ToString();
             }
             catch (Exception ex)
             {
                 Ex = ex.Message;
             }
             
             SysRunLog.InsertRunSql(sql, param, RunMethod.DeclaringType + "." + RunMethod.Name,Ex);

             return Re;
      }
      /// <summary>
      /// 更新采购计划物料按天汇总表 STA_MMPP_MDayCount对象(即:一条记录
      /// </summary>
      public int Update(STA_MMPP_MDayCount sTA_MMPP_MDayCount)
      {
         
         StringBuilder sbParameter=new StringBuilder();
      StringBuilder sb=new StringBuilder();
      sb.Append(@"UPDATE       STA_MMPP_MDayCount       SET ");
            if(sTA_MMPP_MDayCount.PP_DeptCode_IsChanged){sbParameter.Append("PP_DeptCode=@PP_DeptCode, ");}
      if(sTA_MMPP_MDayCount.PP_Dept_IsChanged){sbParameter.Append("PP_Dept=@PP_Dept, ");}
      if(sTA_MMPP_MDayCount.PP_CompanyCode_IsChanged){sbParameter.Append("PP_CompanyCode=@PP_CompanyCode, ");}
      if(sTA_MMPP_MDayCount.PP_Company_IsChanged){sbParameter.Append("PP_Company=@PP_Company, ");}
      if(sTA_MMPP_MDayCount.PP_DateTime_IsChanged){sbParameter.Append("PP_DateTime=@PP_DateTime, ");}
      if(sTA_MMPP_MDayCount.PP_MCode_IsChanged){sbParameter.Append("PP_MCode=@PP_MCode, ");}
      if(sTA_MMPP_MDayCount.PP_MName_IsChanged){sbParameter.Append("PP_MName=@PP_MName, ");}
      if(sTA_MMPP_MDayCount.PP_Spec_IsChanged){sbParameter.Append("PP_Spec=@PP_Spec, ");}
      if(sTA_MMPP_MDayCount.PP_PlanCount_IsChanged){sbParameter.Append("PP_PlanCount=@PP_PlanCount, ");}
      if(sTA_MMPP_MDayCount.PP_ROCount_IsChanged){sbParameter.Append("PP_ROCount=@PP_ROCount, ");}
      if(sTA_MMPP_MDayCount.Stat_IsChanged){sbParameter.Append("Stat=@Stat ");}          sb.Append(sbParameter.ToString().Trim().TrimEnd(',')); 
      sb.Append(      " WHERE 1=1 AND ((Stat is null) or (Stat=0))   and PP_ID=@PP_ID; " );
      string sql=sb.ToString();
         if(sTA_MMPP_MDayCount.PP_DeptCode_IsChanged)
         {
         if (string.IsNullOrEmpty(sTA_MMPP_MDayCount.PP_DeptCode))
         {
            idb.AddParameter("@PP_DeptCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PP_DeptCode", sTA_MMPP_MDayCount.PP_DeptCode);
         }
          }
         if(sTA_MMPP_MDayCount.PP_Dept_IsChanged)
         {
         if (string.IsNullOrEmpty(sTA_MMPP_MDayCount.PP_Dept))
         {
            idb.AddParameter("@PP_Dept", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PP_Dept", sTA_MMPP_MDayCount.PP_Dept);
         }
          }
         if(sTA_MMPP_MDayCount.PP_CompanyCode_IsChanged)
         {
         if (string.IsNullOrEmpty(sTA_MMPP_MDayCount.PP_CompanyCode))
         {
            idb.AddParameter("@PP_CompanyCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PP_CompanyCode", sTA_MMPP_MDayCount.PP_CompanyCode);
         }
          }
         if(sTA_MMPP_MDayCount.PP_Company_IsChanged)
         {
         if (string.IsNullOrEmpty(sTA_MMPP_MDayCount.PP_Company))
         {
            idb.AddParameter("@PP_Company", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PP_Company", sTA_MMPP_MDayCount.PP_Company);
         }
          }
         if(sTA_MMPP_MDayCount.PP_DateTime_IsChanged)
         {
         if (sTA_MMPP_MDayCount.PP_DateTime == DateTime.MinValue)
         {
            idb.AddParameter("@PP_DateTime", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PP_DateTime", sTA_MMPP_MDayCount.PP_DateTime);
         }
          }
         if(sTA_MMPP_MDayCount.PP_MCode_IsChanged)
         {
         if (string.IsNullOrEmpty(sTA_MMPP_MDayCount.PP_MCode))
         {
            idb.AddParameter("@PP_MCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PP_MCode", sTA_MMPP_MDayCount.PP_MCode);
         }
          }
         if(sTA_MMPP_MDayCount.PP_MName_IsChanged)
         {
         if (string.IsNullOrEmpty(sTA_MMPP_MDayCount.PP_MName))
         {
            idb.AddParameter("@PP_MName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PP_MName", sTA_MMPP_MDayCount.PP_MName);
         }
          }
         if(sTA_MMPP_MDayCount.PP_Spec_IsChanged)
         {
         if (string.IsNullOrEmpty(sTA_MMPP_MDayCount.PP_Spec))
         {
            idb.AddParameter("@PP_Spec", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PP_Spec", sTA_MMPP_MDayCount.PP_Spec);
         }
          }
         if(sTA_MMPP_MDayCount.PP_PlanCount_IsChanged)
         {
         if (sTA_MMPP_MDayCount.PP_PlanCount == 0)
         {
            idb.AddParameter("@PP_PlanCount", 0);
         }
         else
         {
            idb.AddParameter("@PP_PlanCount", sTA_MMPP_MDayCount.PP_PlanCount);
         }
          }
         if(sTA_MMPP_MDayCount.PP_ROCount_IsChanged)
         {
         if (sTA_MMPP_MDayCount.PP_ROCount == 0)
         {
            idb.AddParameter("@PP_ROCount", 0);
         }
         else
         {
            idb.AddParameter("@PP_ROCount", sTA_MMPP_MDayCount.PP_ROCount);
         }
          }
         if(sTA_MMPP_MDayCount.Stat_IsChanged)
         {
         if (sTA_MMPP_MDayCount.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", sTA_MMPP_MDayCount.Stat);
         }
          }

         idb.AddParameter("@PP_ID", sTA_MMPP_MDayCount.PP_ID);

           
             int Re = 0;
             //SQL日志记录
             var RunMethod = System.Reflection.MethodBase.GetCurrentMethod();
             System.Collections.Hashtable param = new System.Collections.Hashtable();
             string Ex = "0";
             foreach (System.Collections.DictionaryEntry item in idb.GetParameters())
             {
                 param.Add(item.Key, item.Value);
             }
             try
             {
                 Re = idb.ExeCmd(sql);
                 Ex = Re.ToString();
             }
             catch (Exception ex)
             {
                 Ex = ex.Message;
             }
             
             SysRunLog.InsertRunSql(sql, param, RunMethod.DeclaringType + "." + RunMethod.Name,Ex);

             return Re;
      }
      /// <summary>
      /// 删除采购计划物料按天汇总表 STA_MMPP_MDayCount对象(即:一条记录
      /// </summary>
      public int Delete(decimal pP_ID)
      {
         string sql = "DELETE STA_MMPP_MDayCount WHERE 1=1  AND PP_ID=@PP_ID ";
         idb.AddParameter("@PP_ID", pP_ID);

           
             int Re = 0;
             //SQL日志记录
             var RunMethod = System.Reflection.MethodBase.GetCurrentMethod();
             System.Collections.Hashtable param = new System.Collections.Hashtable();
             string Ex = "0";
             foreach (System.Collections.DictionaryEntry item in idb.GetParameters())
             {
                 param.Add(item.Key, item.Value);
             }
             try
             {
                 Re = idb.ExeCmd(sql);
                 Ex = Re.ToString();
             }
             catch (Exception ex)
             {
                 Ex = ex.Message;
             }
             
             SysRunLog.InsertRunSql(sql, param, RunMethod.DeclaringType + "." + RunMethod.Name,Ex);

             return Re;
      }
      /// <summary>
      /// 获取指定的采购计划物料按天汇总表 STA_MMPP_MDayCount对象(即:一条记录
      /// </summary>
      public STA_MMPP_MDayCount GetByKey(decimal pP_ID)
      {
         STA_MMPP_MDayCount sTA_MMPP_MDayCount = new STA_MMPP_MDayCount();
         string sql = "SELECT  PP_ID,PP_DeptCode,PP_Dept,PP_CompanyCode,PP_Company,PP_DateTime,PP_MCode,PP_MName,PP_Spec,PP_PlanCount,PP_ROCount,Stat FROM STA_MMPP_MDayCount WHERE 1=1 AND ((Stat is null) or (Stat=0) )  AND PP_ID=@PP_ID ";
         idb.AddParameter("@PP_ID", pP_ID);

          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            if (dr["PP_ID"] != DBNull.Value) sTA_MMPP_MDayCount.PP_ID = Convert.ToDecimal(dr["PP_ID"]);
            if (dr["PP_DeptCode"] != DBNull.Value) sTA_MMPP_MDayCount.PP_DeptCode = Convert.ToString(dr["PP_DeptCode"]);
            if (dr["PP_Dept"] != DBNull.Value) sTA_MMPP_MDayCount.PP_Dept = Convert.ToString(dr["PP_Dept"]);
            if (dr["PP_CompanyCode"] != DBNull.Value) sTA_MMPP_MDayCount.PP_CompanyCode = Convert.ToString(dr["PP_CompanyCode"]);
            if (dr["PP_Company"] != DBNull.Value) sTA_MMPP_MDayCount.PP_Company = Convert.ToString(dr["PP_Company"]);
            if (dr["PP_DateTime"] != DBNull.Value) sTA_MMPP_MDayCount.PP_DateTime = Convert.ToDateTime(dr["PP_DateTime"]);
            if (dr["PP_MCode"] != DBNull.Value) sTA_MMPP_MDayCount.PP_MCode = Convert.ToString(dr["PP_MCode"]);
            if (dr["PP_MName"] != DBNull.Value) sTA_MMPP_MDayCount.PP_MName = Convert.ToString(dr["PP_MName"]);
            if (dr["PP_Spec"] != DBNull.Value) sTA_MMPP_MDayCount.PP_Spec = Convert.ToString(dr["PP_Spec"]);
            if (dr["PP_PlanCount"] != DBNull.Value) sTA_MMPP_MDayCount.PP_PlanCount = Convert.ToInt32(dr["PP_PlanCount"]);
            if (dr["PP_ROCount"] != DBNull.Value) sTA_MMPP_MDayCount.PP_ROCount = Convert.ToInt32(dr["PP_ROCount"]);
            if (dr["Stat"] != DBNull.Value) sTA_MMPP_MDayCount.Stat = Convert.ToInt32(dr["Stat"]);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   }  
         return sTA_MMPP_MDayCount;
      }
      /// <summary>
      /// 获取指定的采购计划物料按天汇总表 STA_MMPP_MDayCount对象集合
      /// </summary>
      public List<STA_MMPP_MDayCount> GetListByWhere(string strCondition)
      {
         List<STA_MMPP_MDayCount> ret = new List<STA_MMPP_MDayCount>();
         string sql = "SELECT  PP_ID,PP_DeptCode,PP_Dept,PP_CompanyCode,PP_Company,PP_DateTime,PP_MCode,PP_MName,PP_Spec,PP_PlanCount,PP_ROCount,Stat FROM STA_MMPP_MDayCount WHERE 1=1 AND ((Stat is null) or (Stat=0) ) ";
         if(!string.IsNullOrEmpty(strCondition))
         {
            strCondition.Replace('\'','"'); //防sql注入
            sql += strCondition ;
         }
          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            STA_MMPP_MDayCount sTA_MMPP_MDayCount = new STA_MMPP_MDayCount();
            if (dr["PP_ID"] != DBNull.Value) sTA_MMPP_MDayCount.PP_ID = Convert.ToDecimal(dr["PP_ID"]);
            if (dr["PP_DeptCode"] != DBNull.Value) sTA_MMPP_MDayCount.PP_DeptCode = Convert.ToString(dr["PP_DeptCode"]);
            if (dr["PP_Dept"] != DBNull.Value) sTA_MMPP_MDayCount.PP_Dept = Convert.ToString(dr["PP_Dept"]);
            if (dr["PP_CompanyCode"] != DBNull.Value) sTA_MMPP_MDayCount.PP_CompanyCode = Convert.ToString(dr["PP_CompanyCode"]);
            if (dr["PP_Company"] != DBNull.Value) sTA_MMPP_MDayCount.PP_Company = Convert.ToString(dr["PP_Company"]);
            if (dr["PP_DateTime"] != DBNull.Value) sTA_MMPP_MDayCount.PP_DateTime = Convert.ToDateTime(dr["PP_DateTime"]);
            if (dr["PP_MCode"] != DBNull.Value) sTA_MMPP_MDayCount.PP_MCode = Convert.ToString(dr["PP_MCode"]);
            if (dr["PP_MName"] != DBNull.Value) sTA_MMPP_MDayCount.PP_MName = Convert.ToString(dr["PP_MName"]);
            if (dr["PP_Spec"] != DBNull.Value) sTA_MMPP_MDayCount.PP_Spec = Convert.ToString(dr["PP_Spec"]);
            if (dr["PP_PlanCount"] != DBNull.Value) sTA_MMPP_MDayCount.PP_PlanCount = Convert.ToInt32(dr["PP_PlanCount"]);
            if (dr["PP_ROCount"] != DBNull.Value) sTA_MMPP_MDayCount.PP_ROCount = Convert.ToInt32(dr["PP_ROCount"]);
            if (dr["Stat"] != DBNull.Value) sTA_MMPP_MDayCount.Stat = Convert.ToInt32(dr["Stat"]);
            ret.Add(sTA_MMPP_MDayCount);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   }  
         return ret;
      }
      /// <summary>
      /// 获取所有的采购计划物料按天汇总表 STA_MMPP_MDayCount对象(即:一条记录
      /// </summary>
      public List<STA_MMPP_MDayCount> GetAll()
      {
         List<STA_MMPP_MDayCount> ret = new List<STA_MMPP_MDayCount>();
         string sql = "SELECT  PP_ID,PP_DeptCode,PP_Dept,PP_CompanyCode,PP_Company,PP_DateTime,PP_MCode,PP_MName,PP_Spec,PP_PlanCount,PP_ROCount,Stat FROM STA_MMPP_MDayCount where 1=1 AND ((Stat is null) or (Stat=0) ) order by PP_ID desc ";
          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            STA_MMPP_MDayCount sTA_MMPP_MDayCount = new STA_MMPP_MDayCount();
            if (dr["PP_ID"] != DBNull.Value) sTA_MMPP_MDayCount.PP_ID = Convert.ToDecimal(dr["PP_ID"]);
            if (dr["PP_DeptCode"] != DBNull.Value) sTA_MMPP_MDayCount.PP_DeptCode = Convert.ToString(dr["PP_DeptCode"]);
            if (dr["PP_Dept"] != DBNull.Value) sTA_MMPP_MDayCount.PP_Dept = Convert.ToString(dr["PP_Dept"]);
            if (dr["PP_CompanyCode"] != DBNull.Value) sTA_MMPP_MDayCount.PP_CompanyCode = Convert.ToString(dr["PP_CompanyCode"]);
            if (dr["PP_Company"] != DBNull.Value) sTA_MMPP_MDayCount.PP_Company = Convert.ToString(dr["PP_Company"]);
            if (dr["PP_DateTime"] != DBNull.Value) sTA_MMPP_MDayCount.PP_DateTime = Convert.ToDateTime(dr["PP_DateTime"]);
            if (dr["PP_MCode"] != DBNull.Value) sTA_MMPP_MDayCount.PP_MCode = Convert.ToString(dr["PP_MCode"]);
            if (dr["PP_MName"] != DBNull.Value) sTA_MMPP_MDayCount.PP_MName = Convert.ToString(dr["PP_MName"]);
            if (dr["PP_Spec"] != DBNull.Value) sTA_MMPP_MDayCount.PP_Spec = Convert.ToString(dr["PP_Spec"]);
            if (dr["PP_PlanCount"] != DBNull.Value) sTA_MMPP_MDayCount.PP_PlanCount = Convert.ToInt32(dr["PP_PlanCount"]);
            if (dr["PP_ROCount"] != DBNull.Value) sTA_MMPP_MDayCount.PP_ROCount = Convert.ToInt32(dr["PP_ROCount"]);
            if (dr["Stat"] != DBNull.Value) sTA_MMPP_MDayCount.Stat = Convert.ToInt32(dr["Stat"]);
            ret.Add(sTA_MMPP_MDayCount);
         }
          }catch (System.Exception ex){ throw ex; }  finally {  if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   } 
         return ret;
      }
   }
}
