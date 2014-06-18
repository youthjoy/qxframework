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
   /// 系统消息处理日志
   /// </summary>
   [Serializable]
   public partial class ADOSys_AnnoceLog
   {
      public IDBOperator idb =  DBOperator.GetInstance();
      /// <summary>
      /// 添加系统消息处理日志 Sys_AnnoceLog对象(即:一条记录)
      /// </summary>
      public int Add(Sys_AnnoceLog sys_AnnoceLog)
      {
         string sql = "INSERT INTO Sys_AnnoceLog (EL_UserCode,EL_Date,EL_IP) VALUES (@EL_UserCode,@EL_Date,@EL_IP)";
         if (string.IsNullOrEmpty(sys_AnnoceLog.EL_UserCode))
         {
            idb.AddParameter("@EL_UserCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@EL_UserCode", sys_AnnoceLog.EL_UserCode);
         }
         if (sys_AnnoceLog.EL_Date == DateTime.MinValue)
         {
            idb.AddParameter("@EL_Date", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@EL_Date", sys_AnnoceLog.EL_Date);
         }
         if (string.IsNullOrEmpty(sys_AnnoceLog.EL_IP))
         {
            idb.AddParameter("@EL_IP", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@EL_IP", sys_AnnoceLog.EL_IP);
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
      /// 添加系统消息处理日志 Sys_AnnoceLog对象(即:一条记录)
      /// </summary>
      public object AddWithReturn(Sys_AnnoceLog sys_AnnoceLog)
      {
         string sql = "INSERT INTO Sys_AnnoceLog (EL_UserCode,EL_Date,EL_IP) VALUES (@EL_UserCode,@EL_Date,@EL_IP);SELECT @@IDENTITY AS ReturnID;";
         if (string.IsNullOrEmpty(sys_AnnoceLog.EL_UserCode))
         {
            idb.AddParameter("@EL_UserCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@EL_UserCode", sys_AnnoceLog.EL_UserCode);
         }
         if (sys_AnnoceLog.EL_Date == DateTime.MinValue)
         {
            idb.AddParameter("@EL_Date", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@EL_Date", sys_AnnoceLog.EL_Date);
         }
         if (string.IsNullOrEmpty(sys_AnnoceLog.EL_IP))
         {
            idb.AddParameter("@EL_IP", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@EL_IP", sys_AnnoceLog.EL_IP);
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
      /// 更新系统消息处理日志 Sys_AnnoceLog对象(即:一条记录
      /// </summary>
      public int Update(Sys_AnnoceLog sys_AnnoceLog)
      {
         
         StringBuilder sbParameter=new StringBuilder();
      StringBuilder sb=new StringBuilder();
      sb.Append(@"UPDATE       Sys_AnnoceLog       SET ");
            if(sys_AnnoceLog.EL_UserCode_IsChanged){sbParameter.Append("EL_UserCode=@EL_UserCode, ");}
      if(sys_AnnoceLog.EL_Date_IsChanged){sbParameter.Append("EL_Date=@EL_Date, ");}
      if(sys_AnnoceLog.EL_IP_IsChanged){sbParameter.Append("EL_IP=@EL_IP ");}          sb.Append(sbParameter.ToString().Trim().TrimEnd(',')); 
      sb.Append(      " WHERE 1=1 AND ((Stat is null) or (Stat=0))   and EL_ID=@EL_ID; " );
      string sql=sb.ToString();
         if(sys_AnnoceLog.EL_UserCode_IsChanged)
         {
         if (string.IsNullOrEmpty(sys_AnnoceLog.EL_UserCode))
         {
            idb.AddParameter("@EL_UserCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@EL_UserCode", sys_AnnoceLog.EL_UserCode);
         }
          }
         if(sys_AnnoceLog.EL_Date_IsChanged)
         {
         if (sys_AnnoceLog.EL_Date == DateTime.MinValue)
         {
            idb.AddParameter("@EL_Date", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@EL_Date", sys_AnnoceLog.EL_Date);
         }
          }
         if(sys_AnnoceLog.EL_IP_IsChanged)
         {
         if (string.IsNullOrEmpty(sys_AnnoceLog.EL_IP))
         {
            idb.AddParameter("@EL_IP", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@EL_IP", sys_AnnoceLog.EL_IP);
         }
          }

         idb.AddParameter("@EL_ID", sys_AnnoceLog.EL_ID);

           
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
      /// 删除系统消息处理日志 Sys_AnnoceLog对象(即:一条记录
      /// </summary>
      public int Delete(decimal eL_ID)
      {
         string sql = "DELETE Sys_AnnoceLog WHERE 1=1  AND EL_ID=@EL_ID ";
         idb.AddParameter("@EL_ID", eL_ID);

           
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
      /// 获取指定的系统消息处理日志 Sys_AnnoceLog对象(即:一条记录
      /// </summary>
      public Sys_AnnoceLog GetByKey(decimal eL_ID)
      {
         Sys_AnnoceLog sys_AnnoceLog = new Sys_AnnoceLog();
         string sql = "SELECT  EL_ID,EL_UserCode,EL_Date,EL_IP FROM Sys_AnnoceLog WHERE 1=1 AND ((Stat is null) or (Stat=0) )  AND EL_ID=@EL_ID ";
         idb.AddParameter("@EL_ID", eL_ID);

          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            if (dr["EL_ID"] != DBNull.Value) sys_AnnoceLog.EL_ID = Convert.ToDecimal(dr["EL_ID"]);
            if (dr["EL_UserCode"] != DBNull.Value) sys_AnnoceLog.EL_UserCode = Convert.ToString(dr["EL_UserCode"]);
            if (dr["EL_Date"] != DBNull.Value) sys_AnnoceLog.EL_Date = Convert.ToDateTime(dr["EL_Date"]);
            if (dr["EL_IP"] != DBNull.Value) sys_AnnoceLog.EL_IP = Convert.ToString(dr["EL_IP"]);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   }  
         return sys_AnnoceLog;
      }
      /// <summary>
      /// 获取指定的系统消息处理日志 Sys_AnnoceLog对象集合
      /// </summary>
      public List<Sys_AnnoceLog> GetListByWhere(string strCondition)
      {
         List<Sys_AnnoceLog> ret = new List<Sys_AnnoceLog>();
         string sql = "SELECT  EL_ID,EL_UserCode,EL_Date,EL_IP FROM Sys_AnnoceLog WHERE 1=1 AND ((Stat is null) or (Stat=0) ) ";
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
            Sys_AnnoceLog sys_AnnoceLog = new Sys_AnnoceLog();
            if (dr["EL_ID"] != DBNull.Value) sys_AnnoceLog.EL_ID = Convert.ToDecimal(dr["EL_ID"]);
            if (dr["EL_UserCode"] != DBNull.Value) sys_AnnoceLog.EL_UserCode = Convert.ToString(dr["EL_UserCode"]);
            if (dr["EL_Date"] != DBNull.Value) sys_AnnoceLog.EL_Date = Convert.ToDateTime(dr["EL_Date"]);
            if (dr["EL_IP"] != DBNull.Value) sys_AnnoceLog.EL_IP = Convert.ToString(dr["EL_IP"]);
            ret.Add(sys_AnnoceLog);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   }  
         return ret;
      }
      /// <summary>
      /// 获取所有的系统消息处理日志 Sys_AnnoceLog对象(即:一条记录
      /// </summary>
      public List<Sys_AnnoceLog> GetAll()
      {
         List<Sys_AnnoceLog> ret = new List<Sys_AnnoceLog>();
         string sql = "SELECT  EL_ID,EL_UserCode,EL_Date,EL_IP FROM Sys_AnnoceLog where 1=1 AND ((Stat is null) or (Stat=0) ) order by EL_ID desc ";
          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            Sys_AnnoceLog sys_AnnoceLog = new Sys_AnnoceLog();
            if (dr["EL_ID"] != DBNull.Value) sys_AnnoceLog.EL_ID = Convert.ToDecimal(dr["EL_ID"]);
            if (dr["EL_UserCode"] != DBNull.Value) sys_AnnoceLog.EL_UserCode = Convert.ToString(dr["EL_UserCode"]);
            if (dr["EL_Date"] != DBNull.Value) sys_AnnoceLog.EL_Date = Convert.ToDateTime(dr["EL_Date"]);
            if (dr["EL_IP"] != DBNull.Value) sys_AnnoceLog.EL_IP = Convert.ToString(dr["EL_IP"]);
            ret.Add(sys_AnnoceLog);
         }
          }catch (System.Exception ex){ throw ex; }  finally {  if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   } 
         return ret;
      }
   }
}
