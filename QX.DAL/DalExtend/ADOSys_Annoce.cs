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
   /// 系统消息
   /// </summary>
   [Serializable]
   public partial class ADOSys_Annoce
   {
      public IDBOperator idb =  DBOperator.GetInstance();
      /// <summary>
      /// 添加系统消息 Sys_Annoce对象(即:一条记录)
      /// </summary>
      public int Add(Sys_Annoce sys_Annoce)
      {
         string sql = "INSERT INTO Sys_Annoce (EL_Type,EL_User,EL_Dept,EL_Title,EL_Msg,EL_URL,EL_StartDate,EL_EndDate) VALUES (@EL_Type,@EL_User,@EL_Dept,@EL_Title,@EL_Msg,@EL_URL,@EL_StartDate,@EL_EndDate)";
         if (string.IsNullOrEmpty(sys_Annoce.EL_Type))
         {
            idb.AddParameter("@EL_Type", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@EL_Type", sys_Annoce.EL_Type);
         }
         if (string.IsNullOrEmpty(sys_Annoce.EL_User))
         {
            idb.AddParameter("@EL_User", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@EL_User", sys_Annoce.EL_User);
         }
         if (string.IsNullOrEmpty(sys_Annoce.EL_Dept))
         {
            idb.AddParameter("@EL_Dept", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@EL_Dept", sys_Annoce.EL_Dept);
         }
         if (string.IsNullOrEmpty(sys_Annoce.EL_Title))
         {
            idb.AddParameter("@EL_Title", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@EL_Title", sys_Annoce.EL_Title);
         }
         if (string.IsNullOrEmpty(sys_Annoce.EL_Msg))
         {
            idb.AddParameter("@EL_Msg", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@EL_Msg", sys_Annoce.EL_Msg);
         }
         if (string.IsNullOrEmpty(sys_Annoce.EL_URL))
         {
            idb.AddParameter("@EL_URL", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@EL_URL", sys_Annoce.EL_URL);
         }
         if (sys_Annoce.EL_StartDate == DateTime.MinValue)
         {
            idb.AddParameter("@EL_StartDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@EL_StartDate", sys_Annoce.EL_StartDate);
         }
         if (sys_Annoce.EL_EndDate == DateTime.MinValue)
         {
            idb.AddParameter("@EL_EndDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@EL_EndDate", sys_Annoce.EL_EndDate);
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
      /// 添加系统消息 Sys_Annoce对象(即:一条记录)
      /// </summary>
      public object AddWithReturn(Sys_Annoce sys_Annoce)
      {
         string sql = "INSERT INTO Sys_Annoce (EL_Type,EL_User,EL_Dept,EL_Title,EL_Msg,EL_URL,EL_StartDate,EL_EndDate) VALUES (@EL_Type,@EL_User,@EL_Dept,@EL_Title,@EL_Msg,@EL_URL,@EL_StartDate,@EL_EndDate);SELECT @@IDENTITY AS ReturnID;";
         if (string.IsNullOrEmpty(sys_Annoce.EL_Type))
         {
            idb.AddParameter("@EL_Type", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@EL_Type", sys_Annoce.EL_Type);
         }
         if (string.IsNullOrEmpty(sys_Annoce.EL_User))
         {
            idb.AddParameter("@EL_User", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@EL_User", sys_Annoce.EL_User);
         }
         if (string.IsNullOrEmpty(sys_Annoce.EL_Dept))
         {
            idb.AddParameter("@EL_Dept", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@EL_Dept", sys_Annoce.EL_Dept);
         }
         if (string.IsNullOrEmpty(sys_Annoce.EL_Title))
         {
            idb.AddParameter("@EL_Title", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@EL_Title", sys_Annoce.EL_Title);
         }
         if (string.IsNullOrEmpty(sys_Annoce.EL_Msg))
         {
            idb.AddParameter("@EL_Msg", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@EL_Msg", sys_Annoce.EL_Msg);
         }
         if (string.IsNullOrEmpty(sys_Annoce.EL_URL))
         {
            idb.AddParameter("@EL_URL", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@EL_URL", sys_Annoce.EL_URL);
         }
         if (sys_Annoce.EL_StartDate == DateTime.MinValue)
         {
            idb.AddParameter("@EL_StartDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@EL_StartDate", sys_Annoce.EL_StartDate);
         }
         if (sys_Annoce.EL_EndDate == DateTime.MinValue)
         {
            idb.AddParameter("@EL_EndDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@EL_EndDate", sys_Annoce.EL_EndDate);
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
      /// 更新系统消息 Sys_Annoce对象(即:一条记录
      /// </summary>
      public int Update(Sys_Annoce sys_Annoce)
      {
         
         StringBuilder sbParameter=new StringBuilder();
      StringBuilder sb=new StringBuilder();
      sb.Append(@"UPDATE       Sys_Annoce       SET ");
            if(sys_Annoce.EL_Type_IsChanged){sbParameter.Append("EL_Type=@EL_Type, ");}
      if(sys_Annoce.EL_User_IsChanged){sbParameter.Append("EL_User=@EL_User, ");}
      if(sys_Annoce.EL_Dept_IsChanged){sbParameter.Append("EL_Dept=@EL_Dept, ");}
      if(sys_Annoce.EL_Title_IsChanged){sbParameter.Append("EL_Title=@EL_Title, ");}
      if(sys_Annoce.EL_Msg_IsChanged){sbParameter.Append("EL_Msg=@EL_Msg, ");}
      if(sys_Annoce.EL_URL_IsChanged){sbParameter.Append("EL_URL=@EL_URL, ");}
      if(sys_Annoce.EL_StartDate_IsChanged){sbParameter.Append("EL_StartDate=@EL_StartDate, ");}
      if(sys_Annoce.EL_EndDate_IsChanged){sbParameter.Append("EL_EndDate=@EL_EndDate ");}          sb.Append(sbParameter.ToString().Trim().TrimEnd(',')); 
      sb.Append(      " WHERE 1=1 AND ((Stat is null) or (Stat=0))   and EL_ID=@EL_ID; " );
      string sql=sb.ToString();
         if(sys_Annoce.EL_Type_IsChanged)
         {
         if (string.IsNullOrEmpty(sys_Annoce.EL_Type))
         {
            idb.AddParameter("@EL_Type", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@EL_Type", sys_Annoce.EL_Type);
         }
          }
         if(sys_Annoce.EL_User_IsChanged)
         {
         if (string.IsNullOrEmpty(sys_Annoce.EL_User))
         {
            idb.AddParameter("@EL_User", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@EL_User", sys_Annoce.EL_User);
         }
          }
         if(sys_Annoce.EL_Dept_IsChanged)
         {
         if (string.IsNullOrEmpty(sys_Annoce.EL_Dept))
         {
            idb.AddParameter("@EL_Dept", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@EL_Dept", sys_Annoce.EL_Dept);
         }
          }
         if(sys_Annoce.EL_Title_IsChanged)
         {
         if (string.IsNullOrEmpty(sys_Annoce.EL_Title))
         {
            idb.AddParameter("@EL_Title", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@EL_Title", sys_Annoce.EL_Title);
         }
          }
         if(sys_Annoce.EL_Msg_IsChanged)
         {
         if (string.IsNullOrEmpty(sys_Annoce.EL_Msg))
         {
            idb.AddParameter("@EL_Msg", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@EL_Msg", sys_Annoce.EL_Msg);
         }
          }
         if(sys_Annoce.EL_URL_IsChanged)
         {
         if (string.IsNullOrEmpty(sys_Annoce.EL_URL))
         {
            idb.AddParameter("@EL_URL", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@EL_URL", sys_Annoce.EL_URL);
         }
          }
         if(sys_Annoce.EL_StartDate_IsChanged)
         {
         if (sys_Annoce.EL_StartDate == DateTime.MinValue)
         {
            idb.AddParameter("@EL_StartDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@EL_StartDate", sys_Annoce.EL_StartDate);
         }
          }
         if(sys_Annoce.EL_EndDate_IsChanged)
         {
         if (sys_Annoce.EL_EndDate == DateTime.MinValue)
         {
            idb.AddParameter("@EL_EndDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@EL_EndDate", sys_Annoce.EL_EndDate);
         }
          }

         idb.AddParameter("@EL_ID", sys_Annoce.EL_ID);

           
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
      /// 删除系统消息 Sys_Annoce对象(即:一条记录
      /// </summary>
      public int Delete(decimal eL_ID)
      {
         string sql = "DELETE Sys_Annoce WHERE 1=1  AND EL_ID=@EL_ID ";
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
      /// 获取指定的系统消息 Sys_Annoce对象(即:一条记录
      /// </summary>
      public Sys_Annoce GetByKey(decimal eL_ID)
      {
         Sys_Annoce sys_Annoce = new Sys_Annoce();
         string sql = "SELECT  EL_ID,EL_Type,EL_User,EL_Dept,EL_Title,EL_Msg,EL_URL,EL_StartDate,EL_EndDate FROM Sys_Annoce WHERE 1=1 AND ((Stat is null) or (Stat=0) )  AND EL_ID=@EL_ID ";
         idb.AddParameter("@EL_ID", eL_ID);

          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            if (dr["EL_ID"] != DBNull.Value) sys_Annoce.EL_ID = Convert.ToDecimal(dr["EL_ID"]);
            if (dr["EL_Type"] != DBNull.Value) sys_Annoce.EL_Type = Convert.ToString(dr["EL_Type"]);
            if (dr["EL_User"] != DBNull.Value) sys_Annoce.EL_User = Convert.ToString(dr["EL_User"]);
            if (dr["EL_Dept"] != DBNull.Value) sys_Annoce.EL_Dept = Convert.ToString(dr["EL_Dept"]);
            if (dr["EL_Title"] != DBNull.Value) sys_Annoce.EL_Title = Convert.ToString(dr["EL_Title"]);
            if (dr["EL_Msg"] != DBNull.Value) sys_Annoce.EL_Msg = Convert.ToString(dr["EL_Msg"]);
            if (dr["EL_URL"] != DBNull.Value) sys_Annoce.EL_URL = Convert.ToString(dr["EL_URL"]);
            if (dr["EL_StartDate"] != DBNull.Value) sys_Annoce.EL_StartDate = Convert.ToDateTime(dr["EL_StartDate"]);
            if (dr["EL_EndDate"] != DBNull.Value) sys_Annoce.EL_EndDate = Convert.ToDateTime(dr["EL_EndDate"]);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   }  
         return sys_Annoce;
      }
      /// <summary>
      /// 获取指定的系统消息 Sys_Annoce对象集合
      /// </summary>
      public List<Sys_Annoce> GetListByWhere(string strCondition)
      {
         List<Sys_Annoce> ret = new List<Sys_Annoce>();
         string sql = "SELECT  EL_ID,EL_Type,EL_User,EL_Dept,EL_Title,EL_Msg,EL_URL,EL_StartDate,EL_EndDate FROM Sys_Annoce WHERE 1=1 AND ((Stat is null) or (Stat=0) ) ";
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
            Sys_Annoce sys_Annoce = new Sys_Annoce();
            if (dr["EL_ID"] != DBNull.Value) sys_Annoce.EL_ID = Convert.ToDecimal(dr["EL_ID"]);
            if (dr["EL_Type"] != DBNull.Value) sys_Annoce.EL_Type = Convert.ToString(dr["EL_Type"]);
            if (dr["EL_User"] != DBNull.Value) sys_Annoce.EL_User = Convert.ToString(dr["EL_User"]);
            if (dr["EL_Dept"] != DBNull.Value) sys_Annoce.EL_Dept = Convert.ToString(dr["EL_Dept"]);
            if (dr["EL_Title"] != DBNull.Value) sys_Annoce.EL_Title = Convert.ToString(dr["EL_Title"]);
            if (dr["EL_Msg"] != DBNull.Value) sys_Annoce.EL_Msg = Convert.ToString(dr["EL_Msg"]);
            if (dr["EL_URL"] != DBNull.Value) sys_Annoce.EL_URL = Convert.ToString(dr["EL_URL"]);
            if (dr["EL_StartDate"] != DBNull.Value) sys_Annoce.EL_StartDate = Convert.ToDateTime(dr["EL_StartDate"]);
            if (dr["EL_EndDate"] != DBNull.Value) sys_Annoce.EL_EndDate = Convert.ToDateTime(dr["EL_EndDate"]);
            ret.Add(sys_Annoce);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   }  
         return ret;
      }
      /// <summary>
      /// 获取所有的系统消息 Sys_Annoce对象(即:一条记录
      /// </summary>
      public List<Sys_Annoce> GetAll()
      {
         List<Sys_Annoce> ret = new List<Sys_Annoce>();
         string sql = "SELECT  EL_ID,EL_Type,EL_User,EL_Dept,EL_Title,EL_Msg,EL_URL,EL_StartDate,EL_EndDate FROM Sys_Annoce where 1=1 AND ((Stat is null) or (Stat=0) ) order by EL_ID desc ";
          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            Sys_Annoce sys_Annoce = new Sys_Annoce();
            if (dr["EL_ID"] != DBNull.Value) sys_Annoce.EL_ID = Convert.ToDecimal(dr["EL_ID"]);
            if (dr["EL_Type"] != DBNull.Value) sys_Annoce.EL_Type = Convert.ToString(dr["EL_Type"]);
            if (dr["EL_User"] != DBNull.Value) sys_Annoce.EL_User = Convert.ToString(dr["EL_User"]);
            if (dr["EL_Dept"] != DBNull.Value) sys_Annoce.EL_Dept = Convert.ToString(dr["EL_Dept"]);
            if (dr["EL_Title"] != DBNull.Value) sys_Annoce.EL_Title = Convert.ToString(dr["EL_Title"]);
            if (dr["EL_Msg"] != DBNull.Value) sys_Annoce.EL_Msg = Convert.ToString(dr["EL_Msg"]);
            if (dr["EL_URL"] != DBNull.Value) sys_Annoce.EL_URL = Convert.ToString(dr["EL_URL"]);
            if (dr["EL_StartDate"] != DBNull.Value) sys_Annoce.EL_StartDate = Convert.ToDateTime(dr["EL_StartDate"]);
            if (dr["EL_EndDate"] != DBNull.Value) sys_Annoce.EL_EndDate = Convert.ToDateTime(dr["EL_EndDate"]);
            ret.Add(sys_Annoce);
         }
          }catch (System.Exception ex){ throw ex; }  finally {  if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   } 
         return ret;
      }
   }
}
