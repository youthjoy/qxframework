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
   /// 采购计划中间汇总表
   /// </summary>
   [Serializable]
   public partial class ADOSTA_MMPP_DayCount
   {
      public IDBOperator idb =  DBOperator.GetInstance();
      /// <summary>
      /// 添加采购计划中间汇总表 STA_MMPP_DayCount对象(即:一条记录)
      /// </summary>
      public int Add(STA_MMPP_DayCount sTA_MMPP_DayCount)
      {
         string sql = "INSERT INTO STA_MMPP_DayCount (PP_Dept,PP_DeptCode,PP_Company,PP_CompanyCode,PP_DateTime,PP_PCount,PP_UCount,PP_RType,PP_iType,Stat) VALUES (@PP_Dept,@PP_DeptCode,@PP_Company,@PP_CompanyCode,@PP_DateTime,@PP_PCount,@PP_UCount,@PP_RType,@PP_iType,@Stat)";
         if (string.IsNullOrEmpty(sTA_MMPP_DayCount.PP_Dept))
         {
            idb.AddParameter("@PP_Dept", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PP_Dept", sTA_MMPP_DayCount.PP_Dept);
         }
         if (string.IsNullOrEmpty(sTA_MMPP_DayCount.PP_DeptCode))
         {
            idb.AddParameter("@PP_DeptCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PP_DeptCode", sTA_MMPP_DayCount.PP_DeptCode);
         }
         if (string.IsNullOrEmpty(sTA_MMPP_DayCount.PP_Company))
         {
            idb.AddParameter("@PP_Company", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PP_Company", sTA_MMPP_DayCount.PP_Company);
         }
         if (string.IsNullOrEmpty(sTA_MMPP_DayCount.PP_CompanyCode))
         {
            idb.AddParameter("@PP_CompanyCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PP_CompanyCode", sTA_MMPP_DayCount.PP_CompanyCode);
         }
         if (sTA_MMPP_DayCount.PP_DateTime == DateTime.MinValue)
         {
            idb.AddParameter("@PP_DateTime", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PP_DateTime", sTA_MMPP_DayCount.PP_DateTime);
         }
         if (sTA_MMPP_DayCount.PP_PCount == 0)
         {
            idb.AddParameter("@PP_PCount", 0);
         }
         else
         {
            idb.AddParameter("@PP_PCount", sTA_MMPP_DayCount.PP_PCount);
         }
         if (sTA_MMPP_DayCount.PP_UCount == 0)
         {
            idb.AddParameter("@PP_UCount", 0);
         }
         else
         {
            idb.AddParameter("@PP_UCount", sTA_MMPP_DayCount.PP_UCount);
         }
         if (string.IsNullOrEmpty(sTA_MMPP_DayCount.PP_RType))
         {
            idb.AddParameter("@PP_RType", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PP_RType", sTA_MMPP_DayCount.PP_RType);
         }
         if (string.IsNullOrEmpty(sTA_MMPP_DayCount.PP_iType))
         {
            idb.AddParameter("@PP_iType", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PP_iType", sTA_MMPP_DayCount.PP_iType);
         }
         if (sTA_MMPP_DayCount.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", sTA_MMPP_DayCount.Stat);
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
      /// 添加采购计划中间汇总表 STA_MMPP_DayCount对象(即:一条记录)
      /// </summary>
      public object AddWithReturn(STA_MMPP_DayCount sTA_MMPP_DayCount)
      {
         string sql = "INSERT INTO STA_MMPP_DayCount (PP_Dept,PP_DeptCode,PP_Company,PP_CompanyCode,PP_DateTime,PP_PCount,PP_UCount,PP_RType,PP_iType,Stat) VALUES (@PP_Dept,@PP_DeptCode,@PP_Company,@PP_CompanyCode,@PP_DateTime,@PP_PCount,@PP_UCount,@PP_RType,@PP_iType,@Stat);SELECT @@IDENTITY AS ReturnID;";
         if (string.IsNullOrEmpty(sTA_MMPP_DayCount.PP_Dept))
         {
            idb.AddParameter("@PP_Dept", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PP_Dept", sTA_MMPP_DayCount.PP_Dept);
         }
         if (string.IsNullOrEmpty(sTA_MMPP_DayCount.PP_DeptCode))
         {
            idb.AddParameter("@PP_DeptCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PP_DeptCode", sTA_MMPP_DayCount.PP_DeptCode);
         }
         if (string.IsNullOrEmpty(sTA_MMPP_DayCount.PP_Company))
         {
            idb.AddParameter("@PP_Company", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PP_Company", sTA_MMPP_DayCount.PP_Company);
         }
         if (string.IsNullOrEmpty(sTA_MMPP_DayCount.PP_CompanyCode))
         {
            idb.AddParameter("@PP_CompanyCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PP_CompanyCode", sTA_MMPP_DayCount.PP_CompanyCode);
         }
         if (sTA_MMPP_DayCount.PP_DateTime == DateTime.MinValue)
         {
            idb.AddParameter("@PP_DateTime", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PP_DateTime", sTA_MMPP_DayCount.PP_DateTime);
         }
         if (sTA_MMPP_DayCount.PP_PCount == 0)
         {
            idb.AddParameter("@PP_PCount", 0);
         }
         else
         {
            idb.AddParameter("@PP_PCount", sTA_MMPP_DayCount.PP_PCount);
         }
         if (sTA_MMPP_DayCount.PP_UCount == 0)
         {
            idb.AddParameter("@PP_UCount", 0);
         }
         else
         {
            idb.AddParameter("@PP_UCount", sTA_MMPP_DayCount.PP_UCount);
         }
         if (string.IsNullOrEmpty(sTA_MMPP_DayCount.PP_RType))
         {
            idb.AddParameter("@PP_RType", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PP_RType", sTA_MMPP_DayCount.PP_RType);
         }
         if (string.IsNullOrEmpty(sTA_MMPP_DayCount.PP_iType))
         {
            idb.AddParameter("@PP_iType", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PP_iType", sTA_MMPP_DayCount.PP_iType);
         }
         if (sTA_MMPP_DayCount.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", sTA_MMPP_DayCount.Stat);
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
      /// 更新采购计划中间汇总表 STA_MMPP_DayCount对象(即:一条记录
      /// </summary>
      public int Update(STA_MMPP_DayCount sTA_MMPP_DayCount)
      {
         
         StringBuilder sbParameter=new StringBuilder();
      StringBuilder sb=new StringBuilder();
      sb.Append(@"UPDATE       STA_MMPP_DayCount       SET ");
            if(sTA_MMPP_DayCount.PP_Dept_IsChanged){sbParameter.Append("PP_Dept=@PP_Dept, ");}
      if(sTA_MMPP_DayCount.PP_DeptCode_IsChanged){sbParameter.Append("PP_DeptCode=@PP_DeptCode, ");}
      if(sTA_MMPP_DayCount.PP_Company_IsChanged){sbParameter.Append("PP_Company=@PP_Company, ");}
      if(sTA_MMPP_DayCount.PP_CompanyCode_IsChanged){sbParameter.Append("PP_CompanyCode=@PP_CompanyCode, ");}
      if(sTA_MMPP_DayCount.PP_DateTime_IsChanged){sbParameter.Append("PP_DateTime=@PP_DateTime, ");}
      if(sTA_MMPP_DayCount.PP_PCount_IsChanged){sbParameter.Append("PP_PCount=@PP_PCount, ");}
      if(sTA_MMPP_DayCount.PP_UCount_IsChanged){sbParameter.Append("PP_UCount=@PP_UCount, ");}
      if(sTA_MMPP_DayCount.PP_RType_IsChanged){sbParameter.Append("PP_RType=@PP_RType, ");}
      if(sTA_MMPP_DayCount.PP_iType_IsChanged){sbParameter.Append("PP_iType=@PP_iType, ");}
      if(sTA_MMPP_DayCount.Stat_IsChanged){sbParameter.Append("Stat=@Stat ");}          sb.Append(sbParameter.ToString().Trim().TrimEnd(',')); 
      sb.Append(      " WHERE 1=1 AND ((Stat is null) or (Stat=0))   and PP_ID=@PP_ID; " );
      string sql=sb.ToString();
         if(sTA_MMPP_DayCount.PP_Dept_IsChanged)
         {
         if (string.IsNullOrEmpty(sTA_MMPP_DayCount.PP_Dept))
         {
            idb.AddParameter("@PP_Dept", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PP_Dept", sTA_MMPP_DayCount.PP_Dept);
         }
          }
         if(sTA_MMPP_DayCount.PP_DeptCode_IsChanged)
         {
         if (string.IsNullOrEmpty(sTA_MMPP_DayCount.PP_DeptCode))
         {
            idb.AddParameter("@PP_DeptCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PP_DeptCode", sTA_MMPP_DayCount.PP_DeptCode);
         }
          }
         if(sTA_MMPP_DayCount.PP_Company_IsChanged)
         {
         if (string.IsNullOrEmpty(sTA_MMPP_DayCount.PP_Company))
         {
            idb.AddParameter("@PP_Company", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PP_Company", sTA_MMPP_DayCount.PP_Company);
         }
          }
         if(sTA_MMPP_DayCount.PP_CompanyCode_IsChanged)
         {
         if (string.IsNullOrEmpty(sTA_MMPP_DayCount.PP_CompanyCode))
         {
            idb.AddParameter("@PP_CompanyCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PP_CompanyCode", sTA_MMPP_DayCount.PP_CompanyCode);
         }
          }
         if(sTA_MMPP_DayCount.PP_DateTime_IsChanged)
         {
         if (sTA_MMPP_DayCount.PP_DateTime == DateTime.MinValue)
         {
            idb.AddParameter("@PP_DateTime", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PP_DateTime", sTA_MMPP_DayCount.PP_DateTime);
         }
          }
         if(sTA_MMPP_DayCount.PP_PCount_IsChanged)
         {
         if (sTA_MMPP_DayCount.PP_PCount == 0)
         {
            idb.AddParameter("@PP_PCount", 0);
         }
         else
         {
            idb.AddParameter("@PP_PCount", sTA_MMPP_DayCount.PP_PCount);
         }
          }
         if(sTA_MMPP_DayCount.PP_UCount_IsChanged)
         {
         if (sTA_MMPP_DayCount.PP_UCount == 0)
         {
            idb.AddParameter("@PP_UCount", 0);
         }
         else
         {
            idb.AddParameter("@PP_UCount", sTA_MMPP_DayCount.PP_UCount);
         }
          }
         if(sTA_MMPP_DayCount.PP_RType_IsChanged)
         {
         if (string.IsNullOrEmpty(sTA_MMPP_DayCount.PP_RType))
         {
            idb.AddParameter("@PP_RType", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PP_RType", sTA_MMPP_DayCount.PP_RType);
         }
          }
         if(sTA_MMPP_DayCount.PP_iType_IsChanged)
         {
         if (string.IsNullOrEmpty(sTA_MMPP_DayCount.PP_iType))
         {
            idb.AddParameter("@PP_iType", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PP_iType", sTA_MMPP_DayCount.PP_iType);
         }
          }
         if(sTA_MMPP_DayCount.Stat_IsChanged)
         {
         if (sTA_MMPP_DayCount.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", sTA_MMPP_DayCount.Stat);
         }
          }

         idb.AddParameter("@PP_ID", sTA_MMPP_DayCount.PP_ID);

           
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
      /// 删除采购计划中间汇总表 STA_MMPP_DayCount对象(即:一条记录
      /// </summary>
      public int Delete(decimal pP_ID)
      {
         string sql = "DELETE STA_MMPP_DayCount WHERE 1=1  AND PP_ID=@PP_ID ";
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
      /// 获取指定的采购计划中间汇总表 STA_MMPP_DayCount对象(即:一条记录
      /// </summary>
      public STA_MMPP_DayCount GetByKey(decimal pP_ID)
      {
         STA_MMPP_DayCount sTA_MMPP_DayCount = new STA_MMPP_DayCount();
         string sql = "SELECT  PP_ID,PP_Dept,PP_DeptCode,PP_Company,PP_CompanyCode,PP_DateTime,PP_PCount,PP_UCount,PP_RType,PP_iType,Stat FROM STA_MMPP_DayCount WHERE 1=1 AND ((Stat is null) or (Stat=0) )  AND PP_ID=@PP_ID ";
         idb.AddParameter("@PP_ID", pP_ID);

          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            if (dr["PP_ID"] != DBNull.Value) sTA_MMPP_DayCount.PP_ID = Convert.ToDecimal(dr["PP_ID"]);
            if (dr["PP_Dept"] != DBNull.Value) sTA_MMPP_DayCount.PP_Dept = Convert.ToString(dr["PP_Dept"]);
            if (dr["PP_DeptCode"] != DBNull.Value) sTA_MMPP_DayCount.PP_DeptCode = Convert.ToString(dr["PP_DeptCode"]);
            if (dr["PP_Company"] != DBNull.Value) sTA_MMPP_DayCount.PP_Company = Convert.ToString(dr["PP_Company"]);
            if (dr["PP_CompanyCode"] != DBNull.Value) sTA_MMPP_DayCount.PP_CompanyCode = Convert.ToString(dr["PP_CompanyCode"]);
            if (dr["PP_DateTime"] != DBNull.Value) sTA_MMPP_DayCount.PP_DateTime = Convert.ToDateTime(dr["PP_DateTime"]);
            if (dr["PP_PCount"] != DBNull.Value) sTA_MMPP_DayCount.PP_PCount = Convert.ToInt32(dr["PP_PCount"]);
            if (dr["PP_UCount"] != DBNull.Value) sTA_MMPP_DayCount.PP_UCount = Convert.ToInt32(dr["PP_UCount"]);
            if (dr["PP_RType"] != DBNull.Value) sTA_MMPP_DayCount.PP_RType = Convert.ToString(dr["PP_RType"]);
            if (dr["PP_iType"] != DBNull.Value) sTA_MMPP_DayCount.PP_iType = Convert.ToString(dr["PP_iType"]);
            if (dr["Stat"] != DBNull.Value) sTA_MMPP_DayCount.Stat = Convert.ToInt32(dr["Stat"]);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   }  
         return sTA_MMPP_DayCount;
      }
      /// <summary>
      /// 获取指定的采购计划中间汇总表 STA_MMPP_DayCount对象集合
      /// </summary>
      public List<STA_MMPP_DayCount> GetListByWhere(string strCondition)
      {
         List<STA_MMPP_DayCount> ret = new List<STA_MMPP_DayCount>();
         string sql = "SELECT  PP_ID,PP_Dept,PP_DeptCode,PP_Company,PP_CompanyCode,PP_DateTime,PP_PCount,PP_UCount,PP_RType,PP_iType,Stat FROM STA_MMPP_DayCount WHERE 1=1 AND ((Stat is null) or (Stat=0) ) ";
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
            STA_MMPP_DayCount sTA_MMPP_DayCount = new STA_MMPP_DayCount();
            if (dr["PP_ID"] != DBNull.Value) sTA_MMPP_DayCount.PP_ID = Convert.ToDecimal(dr["PP_ID"]);
            if (dr["PP_Dept"] != DBNull.Value) sTA_MMPP_DayCount.PP_Dept = Convert.ToString(dr["PP_Dept"]);
            if (dr["PP_DeptCode"] != DBNull.Value) sTA_MMPP_DayCount.PP_DeptCode = Convert.ToString(dr["PP_DeptCode"]);
            if (dr["PP_Company"] != DBNull.Value) sTA_MMPP_DayCount.PP_Company = Convert.ToString(dr["PP_Company"]);
            if (dr["PP_CompanyCode"] != DBNull.Value) sTA_MMPP_DayCount.PP_CompanyCode = Convert.ToString(dr["PP_CompanyCode"]);
            if (dr["PP_DateTime"] != DBNull.Value) sTA_MMPP_DayCount.PP_DateTime = Convert.ToDateTime(dr["PP_DateTime"]);
            if (dr["PP_PCount"] != DBNull.Value) sTA_MMPP_DayCount.PP_PCount = Convert.ToInt32(dr["PP_PCount"]);
            if (dr["PP_UCount"] != DBNull.Value) sTA_MMPP_DayCount.PP_UCount = Convert.ToInt32(dr["PP_UCount"]);
            if (dr["PP_RType"] != DBNull.Value) sTA_MMPP_DayCount.PP_RType = Convert.ToString(dr["PP_RType"]);
            if (dr["PP_iType"] != DBNull.Value) sTA_MMPP_DayCount.PP_iType = Convert.ToString(dr["PP_iType"]);
            if (dr["Stat"] != DBNull.Value) sTA_MMPP_DayCount.Stat = Convert.ToInt32(dr["Stat"]);
            ret.Add(sTA_MMPP_DayCount);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   }  
         return ret;
      }
      /// <summary>
      /// 获取所有的采购计划中间汇总表 STA_MMPP_DayCount对象(即:一条记录
      /// </summary>
      public List<STA_MMPP_DayCount> GetAll()
      {
         List<STA_MMPP_DayCount> ret = new List<STA_MMPP_DayCount>();
         string sql = "SELECT  PP_ID,PP_Dept,PP_DeptCode,PP_Company,PP_CompanyCode,PP_DateTime,PP_PCount,PP_UCount,PP_RType,PP_iType,Stat FROM STA_MMPP_DayCount where 1=1 AND ((Stat is null) or (Stat=0) ) order by PP_ID desc ";
          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            STA_MMPP_DayCount sTA_MMPP_DayCount = new STA_MMPP_DayCount();
            if (dr["PP_ID"] != DBNull.Value) sTA_MMPP_DayCount.PP_ID = Convert.ToDecimal(dr["PP_ID"]);
            if (dr["PP_Dept"] != DBNull.Value) sTA_MMPP_DayCount.PP_Dept = Convert.ToString(dr["PP_Dept"]);
            if (dr["PP_DeptCode"] != DBNull.Value) sTA_MMPP_DayCount.PP_DeptCode = Convert.ToString(dr["PP_DeptCode"]);
            if (dr["PP_Company"] != DBNull.Value) sTA_MMPP_DayCount.PP_Company = Convert.ToString(dr["PP_Company"]);
            if (dr["PP_CompanyCode"] != DBNull.Value) sTA_MMPP_DayCount.PP_CompanyCode = Convert.ToString(dr["PP_CompanyCode"]);
            if (dr["PP_DateTime"] != DBNull.Value) sTA_MMPP_DayCount.PP_DateTime = Convert.ToDateTime(dr["PP_DateTime"]);
            if (dr["PP_PCount"] != DBNull.Value) sTA_MMPP_DayCount.PP_PCount = Convert.ToInt32(dr["PP_PCount"]);
            if (dr["PP_UCount"] != DBNull.Value) sTA_MMPP_DayCount.PP_UCount = Convert.ToInt32(dr["PP_UCount"]);
            if (dr["PP_RType"] != DBNull.Value) sTA_MMPP_DayCount.PP_RType = Convert.ToString(dr["PP_RType"]);
            if (dr["PP_iType"] != DBNull.Value) sTA_MMPP_DayCount.PP_iType = Convert.ToString(dr["PP_iType"]);
            if (dr["Stat"] != DBNull.Value) sTA_MMPP_DayCount.Stat = Convert.ToInt32(dr["Stat"]);
            ret.Add(sTA_MMPP_DayCount);
         }
          }catch (System.Exception ex){ throw ex; }  finally {  if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   } 
         return ret;
      }
   }
}
