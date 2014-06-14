using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Text;
using QX.DeskConfig.Model;
using QX.DataAcess;
using QX.MenuHelper.Model;

namespace QX.MenuHelper.DAL
{
   /// <summary>
   /// Sys_LoginLog
   /// </summary>
   [Serializable]
   public partial class ADOSys_LoginLog
   {
      public IDBOperator idb =  DBOperator.GetInstance();
      /// <summary>
      /// 添加Sys_LoginLog Sys_LoginLog对象(即:一条记录)
      /// </summary>
      public int Add(Sys_LoginLog sys_LoginLog)
      {
         string sql = "INSERT INTO Sys_LoginLog (EL_Date,EL_IP,EL_Mac,EL_Success,EL_UserCode,EL_UserName,EL_Dept,EL_Company,EL_CancleDate,Stat) VALUES (@EL_Date,@EL_IP,@EL_Mac,@EL_Success,@EL_UserCode,@EL_UserName,@EL_Dept,@EL_Company,@EL_CancleDate,@Stat)";
         if (sys_LoginLog.EL_Date == DateTime.MinValue)
         {
            idb.AddParameter("@EL_Date", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@EL_Date", sys_LoginLog.EL_Date);
         }
         if (string.IsNullOrEmpty(sys_LoginLog.EL_IP))
         {
            idb.AddParameter("@EL_IP", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@EL_IP", sys_LoginLog.EL_IP);
         }
         if (string.IsNullOrEmpty(sys_LoginLog.EL_Mac))
         {
            idb.AddParameter("@EL_Mac", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@EL_Mac", sys_LoginLog.EL_Mac);
         }
         if (string.IsNullOrEmpty(sys_LoginLog.EL_Success))
         {
            idb.AddParameter("@EL_Success", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@EL_Success", sys_LoginLog.EL_Success);
         }
         if (string.IsNullOrEmpty(sys_LoginLog.EL_UserCode))
         {
            idb.AddParameter("@EL_UserCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@EL_UserCode", sys_LoginLog.EL_UserCode);
         }
         if (string.IsNullOrEmpty(sys_LoginLog.EL_UserName))
         {
            idb.AddParameter("@EL_UserName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@EL_UserName", sys_LoginLog.EL_UserName);
         }
         if (string.IsNullOrEmpty(sys_LoginLog.EL_Dept))
         {
            idb.AddParameter("@EL_Dept", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@EL_Dept", sys_LoginLog.EL_Dept);
         }
         if (string.IsNullOrEmpty(sys_LoginLog.EL_Company))
         {
            idb.AddParameter("@EL_Company", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@EL_Company", sys_LoginLog.EL_Company);
         }
         if (sys_LoginLog.EL_CancleDate == DateTime.MinValue)
         {
            idb.AddParameter("@EL_CancleDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@EL_CancleDate", sys_LoginLog.EL_CancleDate);
         }
         if (sys_LoginLog.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", sys_LoginLog.Stat);
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
      /// 添加Sys_LoginLog Sys_LoginLog对象(即:一条记录)
      /// </summary>
      public object AddWithReturn(Sys_LoginLog sys_LoginLog)
      {
         string sql = "INSERT INTO Sys_LoginLog (EL_Date,EL_IP,EL_Mac,EL_Success,EL_UserCode,EL_UserName,EL_Dept,EL_Company,EL_CancleDate,Stat) VALUES (@EL_Date,@EL_IP,@EL_Mac,@EL_Success,@EL_UserCode,@EL_UserName,@EL_Dept,@EL_Company,@EL_CancleDate,@Stat);SELECT @@IDENTITY AS ReturnID;";
         if (sys_LoginLog.EL_Date == DateTime.MinValue)
         {
            idb.AddParameter("@EL_Date", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@EL_Date", sys_LoginLog.EL_Date);
         }
         if (string.IsNullOrEmpty(sys_LoginLog.EL_IP))
         {
            idb.AddParameter("@EL_IP", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@EL_IP", sys_LoginLog.EL_IP);
         }
         if (string.IsNullOrEmpty(sys_LoginLog.EL_Mac))
         {
            idb.AddParameter("@EL_Mac", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@EL_Mac", sys_LoginLog.EL_Mac);
         }
         if (string.IsNullOrEmpty(sys_LoginLog.EL_Success))
         {
            idb.AddParameter("@EL_Success", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@EL_Success", sys_LoginLog.EL_Success);
         }
         if (string.IsNullOrEmpty(sys_LoginLog.EL_UserCode))
         {
            idb.AddParameter("@EL_UserCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@EL_UserCode", sys_LoginLog.EL_UserCode);
         }
         if (string.IsNullOrEmpty(sys_LoginLog.EL_UserName))
         {
            idb.AddParameter("@EL_UserName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@EL_UserName", sys_LoginLog.EL_UserName);
         }
         if (string.IsNullOrEmpty(sys_LoginLog.EL_Dept))
         {
            idb.AddParameter("@EL_Dept", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@EL_Dept", sys_LoginLog.EL_Dept);
         }
         if (string.IsNullOrEmpty(sys_LoginLog.EL_Company))
         {
            idb.AddParameter("@EL_Company", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@EL_Company", sys_LoginLog.EL_Company);
         }
         if (sys_LoginLog.EL_CancleDate == DateTime.MinValue)
         {
            idb.AddParameter("@EL_CancleDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@EL_CancleDate", sys_LoginLog.EL_CancleDate);
         }
         if (sys_LoginLog.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", sys_LoginLog.Stat);
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
      /// 更新Sys_LoginLog Sys_LoginLog对象(即:一条记录
      /// </summary>
      public int Update(Sys_LoginLog sys_LoginLog)
      {
         
         StringBuilder sbParameter=new StringBuilder();
      StringBuilder sb=new StringBuilder();
      sb.Append(@"UPDATE       Sys_LoginLog       SET ");
            if(sys_LoginLog.EL_Date_IsChanged){sbParameter.Append("EL_Date=@EL_Date, ");}
      if(sys_LoginLog.EL_IP_IsChanged){sbParameter.Append("EL_IP=@EL_IP, ");}
      if(sys_LoginLog.EL_Mac_IsChanged){sbParameter.Append("EL_Mac=@EL_Mac, ");}
      if(sys_LoginLog.EL_Success_IsChanged){sbParameter.Append("EL_Success=@EL_Success, ");}
      if(sys_LoginLog.EL_UserCode_IsChanged){sbParameter.Append("EL_UserCode=@EL_UserCode, ");}
      if(sys_LoginLog.EL_UserName_IsChanged){sbParameter.Append("EL_UserName=@EL_UserName, ");}
      if(sys_LoginLog.EL_Dept_IsChanged){sbParameter.Append("EL_Dept=@EL_Dept, ");}
      if(sys_LoginLog.EL_Company_IsChanged){sbParameter.Append("EL_Company=@EL_Company, ");}
      if(sys_LoginLog.EL_CancleDate_IsChanged){sbParameter.Append("EL_CancleDate=@EL_CancleDate, ");}
      if(sys_LoginLog.Stat_IsChanged){sbParameter.Append("Stat=@Stat ");}
          sb.Append(sbParameter.ToString().Trim().TrimEnd(',')); 
      sb.Append(      " WHERE 1=1 AND ((Stat is null) or (Stat=0))   and EL_ID=@EL_ID; " );
      string sql=sb.ToString();
         if(sys_LoginLog.EL_Date_IsChanged)
         {
         if (sys_LoginLog.EL_Date == DateTime.MinValue)
         {
            idb.AddParameter("@EL_Date", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@EL_Date", sys_LoginLog.EL_Date);
         }
          }
         if(sys_LoginLog.EL_IP_IsChanged)
         {
         if (string.IsNullOrEmpty(sys_LoginLog.EL_IP))
         {
            idb.AddParameter("@EL_IP", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@EL_IP", sys_LoginLog.EL_IP);
         }
          }
         if(sys_LoginLog.EL_Mac_IsChanged)
         {
         if (string.IsNullOrEmpty(sys_LoginLog.EL_Mac))
         {
            idb.AddParameter("@EL_Mac", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@EL_Mac", sys_LoginLog.EL_Mac);
         }
          }
         if(sys_LoginLog.EL_Success_IsChanged)
         {
         if (string.IsNullOrEmpty(sys_LoginLog.EL_Success))
         {
            idb.AddParameter("@EL_Success", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@EL_Success", sys_LoginLog.EL_Success);
         }
          }
         if(sys_LoginLog.EL_UserCode_IsChanged)
         {
         if (string.IsNullOrEmpty(sys_LoginLog.EL_UserCode))
         {
            idb.AddParameter("@EL_UserCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@EL_UserCode", sys_LoginLog.EL_UserCode);
         }
          }
         if(sys_LoginLog.EL_UserName_IsChanged)
         {
         if (string.IsNullOrEmpty(sys_LoginLog.EL_UserName))
         {
            idb.AddParameter("@EL_UserName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@EL_UserName", sys_LoginLog.EL_UserName);
         }
          }
         if(sys_LoginLog.EL_Dept_IsChanged)
         {
         if (string.IsNullOrEmpty(sys_LoginLog.EL_Dept))
         {
            idb.AddParameter("@EL_Dept", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@EL_Dept", sys_LoginLog.EL_Dept);
         }
          }
         if(sys_LoginLog.EL_Company_IsChanged)
         {
         if (string.IsNullOrEmpty(sys_LoginLog.EL_Company))
         {
            idb.AddParameter("@EL_Company", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@EL_Company", sys_LoginLog.EL_Company);
         }
          }
         if(sys_LoginLog.EL_CancleDate_IsChanged)
         {
         if (sys_LoginLog.EL_CancleDate == DateTime.MinValue)
         {
            idb.AddParameter("@EL_CancleDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@EL_CancleDate", sys_LoginLog.EL_CancleDate);
         }
          }
         if(sys_LoginLog.Stat_IsChanged)
         {
         if (sys_LoginLog.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", sys_LoginLog.Stat);
         }
          }

         idb.AddParameter("@EL_ID", sys_LoginLog.EL_ID);

           
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
      /// 删除Sys_LoginLog Sys_LoginLog对象(即:一条记录
      /// </summary>
      public int Delete(decimal eL_ID)
      {
         string sql = "DELETE Sys_LoginLog WHERE 1=1  AND EL_ID=@EL_ID ";
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
      /// 获取指定的Sys_LoginLog Sys_LoginLog对象(即:一条记录
      /// </summary>
      public Sys_LoginLog GetByKey(decimal eL_ID)
      {
         Sys_LoginLog sys_LoginLog = new Sys_LoginLog();
         string sql = "SELECT  EL_ID,EL_Date,EL_IP,EL_Mac,EL_Success,EL_UserCode,EL_UserName,EL_Dept,EL_Company,EL_CancleDate,Stat FROM Sys_LoginLog WHERE 1=1 AND ((Stat is null) or (Stat=0) )  AND EL_ID=@EL_ID ";
         idb.AddParameter("@EL_ID", eL_ID);

          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            if (dr["EL_ID"] != DBNull.Value) sys_LoginLog.EL_ID = Convert.ToDecimal(dr["EL_ID"]);
            if (dr["EL_Date"] != DBNull.Value) sys_LoginLog.EL_Date = Convert.ToDateTime(dr["EL_Date"]);
            if (dr["EL_IP"] != DBNull.Value) sys_LoginLog.EL_IP = Convert.ToString(dr["EL_IP"]);
            if (dr["EL_Mac"] != DBNull.Value) sys_LoginLog.EL_Mac = Convert.ToString(dr["EL_Mac"]);
            if (dr["EL_Success"] != DBNull.Value) sys_LoginLog.EL_Success = Convert.ToString(dr["EL_Success"]);
            if (dr["EL_UserCode"] != DBNull.Value) sys_LoginLog.EL_UserCode = Convert.ToString(dr["EL_UserCode"]);
            if (dr["EL_UserName"] != DBNull.Value) sys_LoginLog.EL_UserName = Convert.ToString(dr["EL_UserName"]);
            if (dr["EL_Dept"] != DBNull.Value) sys_LoginLog.EL_Dept = Convert.ToString(dr["EL_Dept"]);
            if (dr["EL_Company"] != DBNull.Value) sys_LoginLog.EL_Company = Convert.ToString(dr["EL_Company"]);
            if (dr["EL_CancleDate"] != DBNull.Value) sys_LoginLog.EL_CancleDate = Convert.ToDateTime(dr["EL_CancleDate"]);
            if (dr["Stat"] != DBNull.Value) sys_LoginLog.Stat = Convert.ToInt32(dr["Stat"]);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   }  
         return sys_LoginLog;
      }
      /// <summary>
      /// 获取指定的Sys_LoginLog Sys_LoginLog对象集合
      /// </summary>
      public List<Sys_LoginLog> GetListByWhere(string strCondition)
      {
         List<Sys_LoginLog> ret = new List<Sys_LoginLog>();
         string sql = "SELECT  EL_ID,EL_Date,EL_IP,EL_Mac,EL_Success,EL_UserCode,EL_UserName,EL_Dept,EL_Company,EL_CancleDate,Stat FROM Sys_LoginLog WHERE 1=1 AND ((Stat is null) or (Stat=0) ) ";
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
            Sys_LoginLog sys_LoginLog = new Sys_LoginLog();
            if (dr["EL_ID"] != DBNull.Value) sys_LoginLog.EL_ID = Convert.ToDecimal(dr["EL_ID"]);
            if (dr["EL_Date"] != DBNull.Value) sys_LoginLog.EL_Date = Convert.ToDateTime(dr["EL_Date"]);
            if (dr["EL_IP"] != DBNull.Value) sys_LoginLog.EL_IP = Convert.ToString(dr["EL_IP"]);
            if (dr["EL_Mac"] != DBNull.Value) sys_LoginLog.EL_Mac = Convert.ToString(dr["EL_Mac"]);
            if (dr["EL_Success"] != DBNull.Value) sys_LoginLog.EL_Success = Convert.ToString(dr["EL_Success"]);
            if (dr["EL_UserCode"] != DBNull.Value) sys_LoginLog.EL_UserCode = Convert.ToString(dr["EL_UserCode"]);
            if (dr["EL_UserName"] != DBNull.Value) sys_LoginLog.EL_UserName = Convert.ToString(dr["EL_UserName"]);
            if (dr["EL_Dept"] != DBNull.Value) sys_LoginLog.EL_Dept = Convert.ToString(dr["EL_Dept"]);
            if (dr["EL_Company"] != DBNull.Value) sys_LoginLog.EL_Company = Convert.ToString(dr["EL_Company"]);
            if (dr["EL_CancleDate"] != DBNull.Value) sys_LoginLog.EL_CancleDate = Convert.ToDateTime(dr["EL_CancleDate"]);
            if (dr["Stat"] != DBNull.Value) sys_LoginLog.Stat = Convert.ToInt32(dr["Stat"]);
            ret.Add(sys_LoginLog);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   }  
         return ret;
      }
      /// <summary>
      /// 获取所有的Sys_LoginLog Sys_LoginLog对象(即:一条记录
      /// </summary>
      public List<Sys_LoginLog> GetAll()
      {
         List<Sys_LoginLog> ret = new List<Sys_LoginLog>();
         string sql = "SELECT  EL_ID,EL_Date,EL_IP,EL_Mac,EL_Success,EL_UserCode,EL_UserName,EL_Dept,EL_Company,EL_CancleDate,Stat FROM Sys_LoginLog where 1=1 AND ((Stat is null) or (Stat=0) ) order by EL_ID desc ";
          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            Sys_LoginLog sys_LoginLog = new Sys_LoginLog();
            if (dr["EL_ID"] != DBNull.Value) sys_LoginLog.EL_ID = Convert.ToDecimal(dr["EL_ID"]);
            if (dr["EL_Date"] != DBNull.Value) sys_LoginLog.EL_Date = Convert.ToDateTime(dr["EL_Date"]);
            if (dr["EL_IP"] != DBNull.Value) sys_LoginLog.EL_IP = Convert.ToString(dr["EL_IP"]);
            if (dr["EL_Mac"] != DBNull.Value) sys_LoginLog.EL_Mac = Convert.ToString(dr["EL_Mac"]);
            if (dr["EL_Success"] != DBNull.Value) sys_LoginLog.EL_Success = Convert.ToString(dr["EL_Success"]);
            if (dr["EL_UserCode"] != DBNull.Value) sys_LoginLog.EL_UserCode = Convert.ToString(dr["EL_UserCode"]);
            if (dr["EL_UserName"] != DBNull.Value) sys_LoginLog.EL_UserName = Convert.ToString(dr["EL_UserName"]);
            if (dr["EL_Dept"] != DBNull.Value) sys_LoginLog.EL_Dept = Convert.ToString(dr["EL_Dept"]);
            if (dr["EL_Company"] != DBNull.Value) sys_LoginLog.EL_Company = Convert.ToString(dr["EL_Company"]);
            if (dr["EL_CancleDate"] != DBNull.Value) sys_LoginLog.EL_CancleDate = Convert.ToDateTime(dr["EL_CancleDate"]);
            if (dr["Stat"] != DBNull.Value) sys_LoginLog.Stat = Convert.ToInt32(dr["Stat"]);
            ret.Add(sys_LoginLog);
         }
          }catch (System.Exception ex){ throw ex; }  finally {  if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   } 
         return ret;
      }
   }
}
