using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Text;
using QX.HtmlHelperLib.Model;
using QX.DataAcess;

namespace QX.HtmlHelperLib.DAL
{
   /// <summary>
   /// Bug日志
   /// </summary>
   [Serializable]
   public partial class ADOSys_BugLog
   {
      public IDBOperator idb =  DBOperator.GetBugInstance();
      /// <summary>
      /// 添加Bug日志 Sys_BugLog对象(即:一条记录)
      /// </summary>
      public int Add(Sys_BugLog sys_BugLog)
      {
         string sql = "INSERT INTO Sys_BugLog (SL_Code,SL_OpUser,SL_Date,SL_Status,SL_Owner,Stat) VALUES (@SL_Code,@SL_OpUser,@SL_Date,@SL_Status,@SL_Owner,@Stat)";
         if (string.IsNullOrEmpty(sys_BugLog.SL_Code))
         {
            idb.AddParameter("@SL_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SL_Code", sys_BugLog.SL_Code);
         }
         if (string.IsNullOrEmpty(sys_BugLog.SL_OpUser))
         {
            idb.AddParameter("@SL_OpUser", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SL_OpUser", sys_BugLog.SL_OpUser);
         }
         if (sys_BugLog.SL_Date == DateTime.MinValue)
         {
            idb.AddParameter("@SL_Date", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SL_Date", sys_BugLog.SL_Date);
         }
         if (string.IsNullOrEmpty(sys_BugLog.SL_Status))
         {
            idb.AddParameter("@SL_Status", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SL_Status", sys_BugLog.SL_Status);
         }
         if (string.IsNullOrEmpty(sys_BugLog.SL_Owner))
         {
            idb.AddParameter("@SL_Owner", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SL_Owner", sys_BugLog.SL_Owner);
         }
         if (sys_BugLog.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", sys_BugLog.Stat);
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
      /// 添加Bug日志 Sys_BugLog对象(即:一条记录)
      /// </summary>
      public object AddWithReturn(Sys_BugLog sys_BugLog)
      {
         string sql = "INSERT INTO Sys_BugLog (SL_Code,SL_OpUser,SL_Date,SL_Status,SL_Owner,Stat) VALUES (@SL_Code,@SL_OpUser,@SL_Date,@SL_Status,@SL_Owner,@Stat);SELECT @@IDENTITY AS ReturnID;";
         if (string.IsNullOrEmpty(sys_BugLog.SL_Code))
         {
            idb.AddParameter("@SL_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SL_Code", sys_BugLog.SL_Code);
         }
         if (string.IsNullOrEmpty(sys_BugLog.SL_OpUser))
         {
            idb.AddParameter("@SL_OpUser", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SL_OpUser", sys_BugLog.SL_OpUser);
         }
         if (sys_BugLog.SL_Date == DateTime.MinValue)
         {
            idb.AddParameter("@SL_Date", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SL_Date", sys_BugLog.SL_Date);
         }
         if (string.IsNullOrEmpty(sys_BugLog.SL_Status))
         {
            idb.AddParameter("@SL_Status", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SL_Status", sys_BugLog.SL_Status);
         }
         if (string.IsNullOrEmpty(sys_BugLog.SL_Owner))
         {
            idb.AddParameter("@SL_Owner", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SL_Owner", sys_BugLog.SL_Owner);
         }
         if (sys_BugLog.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", sys_BugLog.Stat);
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
      /// 更新Bug日志 Sys_BugLog对象(即:一条记录
      /// </summary>
      public int Update(Sys_BugLog sys_BugLog)
      {
         
         StringBuilder sbParameter=new StringBuilder();
      StringBuilder sb=new StringBuilder();
      sb.Append(@"UPDATE       Sys_BugLog       SET ");
            if(sys_BugLog.SL_Code_IsChanged){sbParameter.Append("SL_Code=@SL_Code, ");}
      if(sys_BugLog.SL_OpUser_IsChanged){sbParameter.Append("SL_OpUser=@SL_OpUser, ");}
      if(sys_BugLog.SL_Date_IsChanged){sbParameter.Append("SL_Date=@SL_Date, ");}
      if(sys_BugLog.SL_Status_IsChanged){sbParameter.Append("SL_Status=@SL_Status, ");}
      if(sys_BugLog.SL_Owner_IsChanged){sbParameter.Append("SL_Owner=@SL_Owner, ");}
      if(sys_BugLog.Stat_IsChanged){sbParameter.Append("Stat=@Stat ");}
          sb.Append(sbParameter.ToString().Trim().TrimEnd(',')); 
      sb.Append(      " WHERE 1=1 AND ((Stat is null) or (Stat=0))   and SL_ID=@SL_ID; " );
      string sql=sb.ToString();
         if(sys_BugLog.SL_Code_IsChanged)
         {
         if (string.IsNullOrEmpty(sys_BugLog.SL_Code))
         {
            idb.AddParameter("@SL_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SL_Code", sys_BugLog.SL_Code);
         }
          }
         if(sys_BugLog.SL_OpUser_IsChanged)
         {
         if (string.IsNullOrEmpty(sys_BugLog.SL_OpUser))
         {
            idb.AddParameter("@SL_OpUser", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SL_OpUser", sys_BugLog.SL_OpUser);
         }
          }
         if(sys_BugLog.SL_Date_IsChanged)
         {
         if (sys_BugLog.SL_Date == DateTime.MinValue)
         {
            idb.AddParameter("@SL_Date", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SL_Date", sys_BugLog.SL_Date);
         }
          }
         if(sys_BugLog.SL_Status_IsChanged)
         {
         if (string.IsNullOrEmpty(sys_BugLog.SL_Status))
         {
            idb.AddParameter("@SL_Status", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SL_Status", sys_BugLog.SL_Status);
         }
          }
         if(sys_BugLog.SL_Owner_IsChanged)
         {
         if (string.IsNullOrEmpty(sys_BugLog.SL_Owner))
         {
            idb.AddParameter("@SL_Owner", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SL_Owner", sys_BugLog.SL_Owner);
         }
          }
         if(sys_BugLog.Stat_IsChanged)
         {
         if (sys_BugLog.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", sys_BugLog.Stat);
         }
          }

         idb.AddParameter("@SL_ID", sys_BugLog.SL_ID);

           
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
      /// 删除Bug日志 Sys_BugLog对象(即:一条记录
      /// </summary>
      public int Delete(decimal sL_ID)
      {
         string sql = "DELETE Sys_BugLog WHERE 1=1  AND SL_ID=@SL_ID ";
         idb.AddParameter("@SL_ID", sL_ID);

           
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
      /// 获取指定的Bug日志 Sys_BugLog对象(即:一条记录
      /// </summary>
      public Sys_BugLog GetByKey(decimal sL_ID)
      {
         Sys_BugLog sys_BugLog = new Sys_BugLog();
         string sql = "SELECT  SL_ID,SL_Code,SL_OpUser,SL_Date,SL_Status,SL_Owner,Stat FROM Sys_BugLog WHERE 1=1 AND ((Stat is null) or (Stat=0) )  AND SL_ID=@SL_ID ";
         idb.AddParameter("@SL_ID", sL_ID);

          SqlDataReader dr=null;  
           try {
               sql += "ORDER BY SL_ID DESC";
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            if (dr["SL_ID"] != DBNull.Value) sys_BugLog.SL_ID = Convert.ToDecimal(dr["SL_ID"]);
            if (dr["SL_Code"] != DBNull.Value) sys_BugLog.SL_Code = Convert.ToString(dr["SL_Code"]);
            if (dr["SL_OpUser"] != DBNull.Value) sys_BugLog.SL_OpUser = Convert.ToString(dr["SL_OpUser"]);
            if (dr["SL_Date"] != DBNull.Value) sys_BugLog.SL_Date = Convert.ToDateTime(dr["SL_Date"]);
            if (dr["SL_Status"] != DBNull.Value) sys_BugLog.SL_Status = Convert.ToString(dr["SL_Status"]);
            if (dr["SL_Owner"] != DBNull.Value) sys_BugLog.SL_Owner = Convert.ToString(dr["SL_Owner"]);
            if (dr["Stat"] != DBNull.Value) sys_BugLog.Stat = Convert.ToInt32(dr["Stat"]);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   }  
         return sys_BugLog;
      }
      /// <summary>
      /// 获取指定的Bug日志 Sys_BugLog对象集合
      /// </summary>
      public List<Sys_BugLog> GetListByWhere(string strCondition)
      {
         List<Sys_BugLog> ret = new List<Sys_BugLog>();
         string sql = "SELECT  SL_ID,SL_Code,SL_OpUser,SL_Date,SL_Status,SL_Owner,Stat FROM Sys_BugLog WHERE 1=1 AND ((Stat is null) or (Stat=0) ) ";
         if(!string.IsNullOrEmpty(strCondition))
         {
            strCondition.Replace('\'','"'); //防sql注入
            sql += strCondition ;
         }
          SqlDataReader dr=null;  
           try {
               sql += "ORDER BY SL_ID DESC";
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            Sys_BugLog sys_BugLog = new Sys_BugLog();
            if (dr["SL_ID"] != DBNull.Value) sys_BugLog.SL_ID = Convert.ToDecimal(dr["SL_ID"]);
            if (dr["SL_Code"] != DBNull.Value) sys_BugLog.SL_Code = Convert.ToString(dr["SL_Code"]);
            if (dr["SL_OpUser"] != DBNull.Value) sys_BugLog.SL_OpUser = Convert.ToString(dr["SL_OpUser"]);
            if (dr["SL_Date"] != DBNull.Value) sys_BugLog.SL_Date = Convert.ToDateTime(dr["SL_Date"]);
            if (dr["SL_Status"] != DBNull.Value) sys_BugLog.SL_Status = Convert.ToString(dr["SL_Status"]);
            if (dr["SL_Owner"] != DBNull.Value) sys_BugLog.SL_Owner = Convert.ToString(dr["SL_Owner"]);
            if (dr["Stat"] != DBNull.Value) sys_BugLog.Stat = Convert.ToInt32(dr["Stat"]);
            ret.Add(sys_BugLog);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   }  
         return ret;
      }
      /// <summary>
      /// 获取所有的Bug日志 Sys_BugLog对象(即:一条记录
      /// </summary>
      public List<Sys_BugLog> GetAll()
      {
         List<Sys_BugLog> ret = new List<Sys_BugLog>();
         string sql = "SELECT  SL_ID,SL_Code,SL_OpUser,SL_Date,SL_Status,SL_Owner,Stat FROM Sys_BugLog where 1=1 AND ((Stat is null) or (Stat=0) ) order by SL_ID desc ";
          SqlDataReader dr=null;  
           try {
              // sql += "ORDER BY SL_ID DESC";
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            Sys_BugLog sys_BugLog = new Sys_BugLog();
            if (dr["SL_ID"] != DBNull.Value) sys_BugLog.SL_ID = Convert.ToDecimal(dr["SL_ID"]);
            if (dr["SL_Code"] != DBNull.Value) sys_BugLog.SL_Code = Convert.ToString(dr["SL_Code"]);
            if (dr["SL_OpUser"] != DBNull.Value) sys_BugLog.SL_OpUser = Convert.ToString(dr["SL_OpUser"]);
            if (dr["SL_Date"] != DBNull.Value) sys_BugLog.SL_Date = Convert.ToDateTime(dr["SL_Date"]);
            if (dr["SL_Status"] != DBNull.Value) sys_BugLog.SL_Status = Convert.ToString(dr["SL_Status"]);
            if (dr["SL_Owner"] != DBNull.Value) sys_BugLog.SL_Owner = Convert.ToString(dr["SL_Owner"]);
            if (dr["Stat"] != DBNull.Value) sys_BugLog.Stat = Convert.ToInt32(dr["Stat"]);
            ret.Add(sys_BugLog);
         }
          }catch (System.Exception ex){ throw ex; }  finally {  if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   } 
         return ret;
      }
   }
}
