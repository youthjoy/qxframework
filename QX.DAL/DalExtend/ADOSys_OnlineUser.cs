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
   /// 用户在线列表
   /// </summary>
   [Serializable]
   public partial class ADOSys_OnlineUser
   {
      public IDBOperator idb =  DBOperator.GetInstance();
      /// <summary>
      /// 添加用户在线列表 Sys_OnlineUser对象(即:一条记录)
      /// </summary>
      public int Add(Sys_OnlineUser sys_OnlineUser)
      {
         string sql = "INSERT INTO Sys_OnlineUser (EL_UserCode,EL_IP,EL_DateSpan) VALUES (@EL_UserCode,@EL_IP,@EL_DateSpan)";
         if (string.IsNullOrEmpty(sys_OnlineUser.EL_UserCode))
         {
            idb.AddParameter("@EL_UserCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@EL_UserCode", sys_OnlineUser.EL_UserCode);
         }
         if (string.IsNullOrEmpty(sys_OnlineUser.EL_IP))
         {
            idb.AddParameter("@EL_IP", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@EL_IP", sys_OnlineUser.EL_IP);
         }
         if (sys_OnlineUser.EL_DateSpan == 0)
         {
            idb.AddParameter("@EL_DateSpan", 0);
         }
         else
         {
            idb.AddParameter("@EL_DateSpan", sys_OnlineUser.EL_DateSpan);
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
      /// 添加用户在线列表 Sys_OnlineUser对象(即:一条记录)
      /// </summary>
      public object AddWithReturn(Sys_OnlineUser sys_OnlineUser)
      {
         string sql = "INSERT INTO Sys_OnlineUser (EL_UserCode,EL_IP,EL_DateSpan) VALUES (@EL_UserCode,@EL_IP,@EL_DateSpan);SELECT @@IDENTITY AS ReturnID;";
         if (string.IsNullOrEmpty(sys_OnlineUser.EL_UserCode))
         {
            idb.AddParameter("@EL_UserCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@EL_UserCode", sys_OnlineUser.EL_UserCode);
         }
         if (string.IsNullOrEmpty(sys_OnlineUser.EL_IP))
         {
            idb.AddParameter("@EL_IP", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@EL_IP", sys_OnlineUser.EL_IP);
         }
         if (sys_OnlineUser.EL_DateSpan == 0)
         {
            idb.AddParameter("@EL_DateSpan", 0);
         }
         else
         {
            idb.AddParameter("@EL_DateSpan", sys_OnlineUser.EL_DateSpan);
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
      /// 更新用户在线列表 Sys_OnlineUser对象(即:一条记录
      /// </summary>
      public int Update(Sys_OnlineUser sys_OnlineUser)
      {
         
         StringBuilder sbParameter=new StringBuilder();
      StringBuilder sb=new StringBuilder();
      sb.Append(@"UPDATE       Sys_OnlineUser       SET ");
            if(sys_OnlineUser.EL_UserCode_IsChanged){sbParameter.Append("EL_UserCode=@EL_UserCode, ");}
      if(sys_OnlineUser.EL_IP_IsChanged){sbParameter.Append("EL_IP=@EL_IP, ");}
      if(sys_OnlineUser.EL_DateSpan_IsChanged){sbParameter.Append("EL_DateSpan=@EL_DateSpan ");}          sb.Append(sbParameter.ToString().Trim().TrimEnd(',')); 
      sb.Append(      " WHERE 1=1 AND ((Stat is null) or (Stat=0))   and EL_ID=@EL_ID; " );
      string sql=sb.ToString();
         if(sys_OnlineUser.EL_UserCode_IsChanged)
         {
         if (string.IsNullOrEmpty(sys_OnlineUser.EL_UserCode))
         {
            idb.AddParameter("@EL_UserCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@EL_UserCode", sys_OnlineUser.EL_UserCode);
         }
          }
         if(sys_OnlineUser.EL_IP_IsChanged)
         {
         if (string.IsNullOrEmpty(sys_OnlineUser.EL_IP))
         {
            idb.AddParameter("@EL_IP", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@EL_IP", sys_OnlineUser.EL_IP);
         }
          }
         if(sys_OnlineUser.EL_DateSpan_IsChanged)
         {
         if (sys_OnlineUser.EL_DateSpan == 0)
         {
            idb.AddParameter("@EL_DateSpan", 0);
         }
         else
         {
            idb.AddParameter("@EL_DateSpan", sys_OnlineUser.EL_DateSpan);
         }
          }

         idb.AddParameter("@EL_ID", sys_OnlineUser.EL_ID);

           
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
      /// 删除用户在线列表 Sys_OnlineUser对象(即:一条记录
      /// </summary>
      public int Delete(decimal eL_ID)
      {
         string sql = "DELETE Sys_OnlineUser WHERE 1=1  AND EL_ID=@EL_ID ";
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
      /// 获取指定的用户在线列表 Sys_OnlineUser对象(即:一条记录
      /// </summary>
      public Sys_OnlineUser GetByKey(decimal eL_ID)
      {
         Sys_OnlineUser sys_OnlineUser = new Sys_OnlineUser();
         string sql = "SELECT  EL_ID,EL_UserCode,EL_IP,EL_DateSpan FROM Sys_OnlineUser WHERE 1=1 AND ((Stat is null) or (Stat=0) )  AND EL_ID=@EL_ID ";
         idb.AddParameter("@EL_ID", eL_ID);

          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            if (dr["EL_ID"] != DBNull.Value) sys_OnlineUser.EL_ID = Convert.ToDecimal(dr["EL_ID"]);
            if (dr["EL_UserCode"] != DBNull.Value) sys_OnlineUser.EL_UserCode = Convert.ToString(dr["EL_UserCode"]);
            if (dr["EL_IP"] != DBNull.Value) sys_OnlineUser.EL_IP = Convert.ToString(dr["EL_IP"]);
            if (dr["EL_DateSpan"] != DBNull.Value) sys_OnlineUser.EL_DateSpan = Convert.ToDecimal(dr["EL_DateSpan"]);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   }  
         return sys_OnlineUser;
      }
      /// <summary>
      /// 获取指定的用户在线列表 Sys_OnlineUser对象集合
      /// </summary>
      public List<Sys_OnlineUser> GetListByWhere(string strCondition)
      {
         List<Sys_OnlineUser> ret = new List<Sys_OnlineUser>();
         string sql = "SELECT  EL_ID,EL_UserCode,EL_IP,EL_DateSpan FROM Sys_OnlineUser WHERE 1=1 AND ((Stat is null) or (Stat=0) ) ";
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
            Sys_OnlineUser sys_OnlineUser = new Sys_OnlineUser();
            if (dr["EL_ID"] != DBNull.Value) sys_OnlineUser.EL_ID = Convert.ToDecimal(dr["EL_ID"]);
            if (dr["EL_UserCode"] != DBNull.Value) sys_OnlineUser.EL_UserCode = Convert.ToString(dr["EL_UserCode"]);
            if (dr["EL_IP"] != DBNull.Value) sys_OnlineUser.EL_IP = Convert.ToString(dr["EL_IP"]);
            if (dr["EL_DateSpan"] != DBNull.Value) sys_OnlineUser.EL_DateSpan = Convert.ToDecimal(dr["EL_DateSpan"]);
            ret.Add(sys_OnlineUser);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   }  
         return ret;
      }
      /// <summary>
      /// 获取所有的用户在线列表 Sys_OnlineUser对象(即:一条记录
      /// </summary>
      public List<Sys_OnlineUser> GetAll()
      {
         List<Sys_OnlineUser> ret = new List<Sys_OnlineUser>();
         string sql = "SELECT  EL_ID,EL_UserCode,EL_IP,EL_DateSpan FROM Sys_OnlineUser where 1=1 AND ((Stat is null) or (Stat=0) ) order by EL_ID desc ";
          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            Sys_OnlineUser sys_OnlineUser = new Sys_OnlineUser();
            if (dr["EL_ID"] != DBNull.Value) sys_OnlineUser.EL_ID = Convert.ToDecimal(dr["EL_ID"]);
            if (dr["EL_UserCode"] != DBNull.Value) sys_OnlineUser.EL_UserCode = Convert.ToString(dr["EL_UserCode"]);
            if (dr["EL_IP"] != DBNull.Value) sys_OnlineUser.EL_IP = Convert.ToString(dr["EL_IP"]);
            if (dr["EL_DateSpan"] != DBNull.Value) sys_OnlineUser.EL_DateSpan = Convert.ToDecimal(dr["EL_DateSpan"]);
            ret.Add(sys_OnlineUser);
         }
          }catch (System.Exception ex){ throw ex; }  finally {  if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   } 
         return ret;
      }
   }
}
