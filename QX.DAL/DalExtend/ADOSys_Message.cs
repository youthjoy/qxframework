using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Text;
using QX.Model;
using QX.DataAcess;

namespace QX.DAL
{
   [Serializable]
   public partial class ADOSys_Message
   {
      public IDBOperator idb =  DBOperator.GetInstance();
      /// <summary>
      /// 添加Sys_Message对象(即:一条记录)
      /// </summary>
      public int Add(Sys_Message sys_Message)
      {
         string sql = "INSERT INTO Sys_Message (SYM_Module,SYM_Key,SYM_Content,SYM_UDef1,SYM_UDef2,SYM_UDef3,SYM_UDef4,SYM_UDef5,Stat) VALUES (@SYM_Module,@SYM_Key,@SYM_Content,@SYM_UDef1,@SYM_UDef2,@SYM_UDef3,@SYM_UDef4,@SYM_UDef5,@Stat)";
         if (string.IsNullOrEmpty(sys_Message.SYM_Module))
         {
            idb.AddParameter("@SYM_Module", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SYM_Module", sys_Message.SYM_Module);
         }
         if (string.IsNullOrEmpty(sys_Message.SYM_Key))
         {
            idb.AddParameter("@SYM_Key", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SYM_Key", sys_Message.SYM_Key);
         }
         if (string.IsNullOrEmpty(sys_Message.SYM_Content))
         {
            idb.AddParameter("@SYM_Content", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SYM_Content", sys_Message.SYM_Content);
         }
         if (string.IsNullOrEmpty(sys_Message.SYM_UDef1))
         {
            idb.AddParameter("@SYM_UDef1", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SYM_UDef1", sys_Message.SYM_UDef1);
         }
         if (string.IsNullOrEmpty(sys_Message.SYM_UDef2))
         {
            idb.AddParameter("@SYM_UDef2", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SYM_UDef2", sys_Message.SYM_UDef2);
         }
         if (string.IsNullOrEmpty(sys_Message.SYM_UDef3))
         {
            idb.AddParameter("@SYM_UDef3", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SYM_UDef3", sys_Message.SYM_UDef3);
         }
         if (string.IsNullOrEmpty(sys_Message.SYM_UDef4))
         {
            idb.AddParameter("@SYM_UDef4", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SYM_UDef4", sys_Message.SYM_UDef4);
         }
         if (string.IsNullOrEmpty(sys_Message.SYM_UDef5))
         {
            idb.AddParameter("@SYM_UDef5", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SYM_UDef5", sys_Message.SYM_UDef5);
         }
         if (sys_Message.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", sys_Message.Stat);
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
      /// 添加Sys_Message对象(即:一条记录)
      /// </summary>
      public object AddWithReturn(Sys_Message sys_Message)
      {
         string sql = "INSERT INTO Sys_Message (SYM_Module,SYM_Key,SYM_Content,SYM_UDef1,SYM_UDef2,SYM_UDef3,SYM_UDef4,SYM_UDef5,Stat) VALUES (@SYM_Module,@SYM_Key,@SYM_Content,@SYM_UDef1,@SYM_UDef2,@SYM_UDef3,@SYM_UDef4,@SYM_UDef5,@Stat);SELECT @@IDENTITY AS ReturnID;";
         if (string.IsNullOrEmpty(sys_Message.SYM_Module))
         {
            idb.AddParameter("@SYM_Module", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SYM_Module", sys_Message.SYM_Module);
         }
         if (string.IsNullOrEmpty(sys_Message.SYM_Key))
         {
            idb.AddParameter("@SYM_Key", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SYM_Key", sys_Message.SYM_Key);
         }
         if (string.IsNullOrEmpty(sys_Message.SYM_Content))
         {
            idb.AddParameter("@SYM_Content", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SYM_Content", sys_Message.SYM_Content);
         }
         if (string.IsNullOrEmpty(sys_Message.SYM_UDef1))
         {
            idb.AddParameter("@SYM_UDef1", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SYM_UDef1", sys_Message.SYM_UDef1);
         }
         if (string.IsNullOrEmpty(sys_Message.SYM_UDef2))
         {
            idb.AddParameter("@SYM_UDef2", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SYM_UDef2", sys_Message.SYM_UDef2);
         }
         if (string.IsNullOrEmpty(sys_Message.SYM_UDef3))
         {
            idb.AddParameter("@SYM_UDef3", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SYM_UDef3", sys_Message.SYM_UDef3);
         }
         if (string.IsNullOrEmpty(sys_Message.SYM_UDef4))
         {
            idb.AddParameter("@SYM_UDef4", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SYM_UDef4", sys_Message.SYM_UDef4);
         }
         if (string.IsNullOrEmpty(sys_Message.SYM_UDef5))
         {
            idb.AddParameter("@SYM_UDef5", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SYM_UDef5", sys_Message.SYM_UDef5);
         }
         if (sys_Message.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", sys_Message.Stat);
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
      /// 更新Sys_Message对象(即:一条记录
      /// </summary>
      public int Update(Sys_Message sys_Message)
      {
         
         StringBuilder sbParameter=new StringBuilder();
      StringBuilder sb=new StringBuilder();
      sb.Append(@"UPDATE       Sys_Message       SET ");
            if(sys_Message.SYM_Module_IsChanged){sbParameter.Append("SYM_Module=@SYM_Module, ");}
      if(sys_Message.SYM_Key_IsChanged){sbParameter.Append("SYM_Key=@SYM_Key, ");}
      if(sys_Message.SYM_Content_IsChanged){sbParameter.Append("SYM_Content=@SYM_Content, ");}
      if(sys_Message.SYM_UDef1_IsChanged){sbParameter.Append("SYM_UDef1=@SYM_UDef1, ");}
      if(sys_Message.SYM_UDef2_IsChanged){sbParameter.Append("SYM_UDef2=@SYM_UDef2, ");}
      if(sys_Message.SYM_UDef3_IsChanged){sbParameter.Append("SYM_UDef3=@SYM_UDef3, ");}
      if(sys_Message.SYM_UDef4_IsChanged){sbParameter.Append("SYM_UDef4=@SYM_UDef4, ");}
      if(sys_Message.SYM_UDef5_IsChanged){sbParameter.Append("SYM_UDef5=@SYM_UDef5, ");}
      if(sys_Message.Stat_IsChanged){sbParameter.Append("Stat=@Stat ");}          sb.Append(sbParameter.ToString().Trim().TrimEnd(',')); 
      sb.Append(      " WHERE 1=1 AND ((Stat is null) or (Stat=0))   and SYM_ID=@SYM_ID; " );
      string sql=sb.ToString();
         if(sys_Message.SYM_Module_IsChanged)
         {
         if (string.IsNullOrEmpty(sys_Message.SYM_Module))
         {
            idb.AddParameter("@SYM_Module", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SYM_Module", sys_Message.SYM_Module);
         }
          }
         if(sys_Message.SYM_Key_IsChanged)
         {
         if (string.IsNullOrEmpty(sys_Message.SYM_Key))
         {
            idb.AddParameter("@SYM_Key", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SYM_Key", sys_Message.SYM_Key);
         }
          }
         if(sys_Message.SYM_Content_IsChanged)
         {
         if (string.IsNullOrEmpty(sys_Message.SYM_Content))
         {
            idb.AddParameter("@SYM_Content", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SYM_Content", sys_Message.SYM_Content);
         }
          }
         if(sys_Message.SYM_UDef1_IsChanged)
         {
         if (string.IsNullOrEmpty(sys_Message.SYM_UDef1))
         {
            idb.AddParameter("@SYM_UDef1", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SYM_UDef1", sys_Message.SYM_UDef1);
         }
          }
         if(sys_Message.SYM_UDef2_IsChanged)
         {
         if (string.IsNullOrEmpty(sys_Message.SYM_UDef2))
         {
            idb.AddParameter("@SYM_UDef2", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SYM_UDef2", sys_Message.SYM_UDef2);
         }
          }
         if(sys_Message.SYM_UDef3_IsChanged)
         {
         if (string.IsNullOrEmpty(sys_Message.SYM_UDef3))
         {
            idb.AddParameter("@SYM_UDef3", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SYM_UDef3", sys_Message.SYM_UDef3);
         }
          }
         if(sys_Message.SYM_UDef4_IsChanged)
         {
         if (string.IsNullOrEmpty(sys_Message.SYM_UDef4))
         {
            idb.AddParameter("@SYM_UDef4", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SYM_UDef4", sys_Message.SYM_UDef4);
         }
          }
         if(sys_Message.SYM_UDef5_IsChanged)
         {
         if (string.IsNullOrEmpty(sys_Message.SYM_UDef5))
         {
            idb.AddParameter("@SYM_UDef5", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SYM_UDef5", sys_Message.SYM_UDef5);
         }
          }
         if(sys_Message.Stat_IsChanged)
         {
         if (sys_Message.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", sys_Message.Stat);
         }
          }

         idb.AddParameter("@SYM_ID", sys_Message.SYM_ID);

           
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
      /// 删除Sys_Message对象(即:一条记录
      /// </summary>
      public int Delete(Int64 sYM_ID)
      {
         string sql = "DELETE Sys_Message WHERE 1=1  AND SYM_ID=@SYM_ID ";
         idb.AddParameter("@SYM_ID", sYM_ID);

           
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
      /// 获取指定的Sys_Message对象(即:一条记录
      /// </summary>
      public Sys_Message GetByKey(Int64 sYM_ID)
      {
         Sys_Message sys_Message = new Sys_Message();
         string sql = "SELECT  SYM_ID,SYM_Module,SYM_Key,SYM_Content,SYM_UDef1,SYM_UDef2,SYM_UDef3,SYM_UDef4,SYM_UDef5,Stat FROM Sys_Message WHERE 1=1 AND ((Stat is null) or (Stat=0) )  AND SYM_ID=@SYM_ID ";
         idb.AddParameter("@SYM_ID", sYM_ID);

          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            if (dr["SYM_ID"] != DBNull.Value) sys_Message.SYM_ID = Convert.ToInt64(dr["SYM_ID"]);
            if (dr["SYM_Module"] != DBNull.Value) sys_Message.SYM_Module = Convert.ToString(dr["SYM_Module"]);
            if (dr["SYM_Key"] != DBNull.Value) sys_Message.SYM_Key = Convert.ToString(dr["SYM_Key"]);
            if (dr["SYM_Content"] != DBNull.Value) sys_Message.SYM_Content = Convert.ToString(dr["SYM_Content"]);
            if (dr["SYM_UDef1"] != DBNull.Value) sys_Message.SYM_UDef1 = Convert.ToString(dr["SYM_UDef1"]);
            if (dr["SYM_UDef2"] != DBNull.Value) sys_Message.SYM_UDef2 = Convert.ToString(dr["SYM_UDef2"]);
            if (dr["SYM_UDef3"] != DBNull.Value) sys_Message.SYM_UDef3 = Convert.ToString(dr["SYM_UDef3"]);
            if (dr["SYM_UDef4"] != DBNull.Value) sys_Message.SYM_UDef4 = Convert.ToString(dr["SYM_UDef4"]);
            if (dr["SYM_UDef5"] != DBNull.Value) sys_Message.SYM_UDef5 = Convert.ToString(dr["SYM_UDef5"]);
            if (dr["Stat"] != DBNull.Value) sys_Message.Stat = Convert.ToInt32(dr["Stat"]);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   }  
         return sys_Message;
      }
      /// <summary>
      /// 获取指定的Sys_Message对象集合
      /// </summary>
      public List<Sys_Message> GetListByWhere(string strCondition)
      {
         List<Sys_Message> ret = new List<Sys_Message>();
         string sql = "SELECT  SYM_ID,SYM_Module,SYM_Key,SYM_Content,SYM_UDef1,SYM_UDef2,SYM_UDef3,SYM_UDef4,SYM_UDef5,Stat FROM Sys_Message WHERE 1=1 AND ((Stat is null) or (Stat=0) ) ";
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
            Sys_Message sys_Message = new Sys_Message();
            if (dr["SYM_ID"] != DBNull.Value) sys_Message.SYM_ID = Convert.ToInt64(dr["SYM_ID"]);
            if (dr["SYM_Module"] != DBNull.Value) sys_Message.SYM_Module = Convert.ToString(dr["SYM_Module"]);
            if (dr["SYM_Key"] != DBNull.Value) sys_Message.SYM_Key = Convert.ToString(dr["SYM_Key"]);
            if (dr["SYM_Content"] != DBNull.Value) sys_Message.SYM_Content = Convert.ToString(dr["SYM_Content"]);
            if (dr["SYM_UDef1"] != DBNull.Value) sys_Message.SYM_UDef1 = Convert.ToString(dr["SYM_UDef1"]);
            if (dr["SYM_UDef2"] != DBNull.Value) sys_Message.SYM_UDef2 = Convert.ToString(dr["SYM_UDef2"]);
            if (dr["SYM_UDef3"] != DBNull.Value) sys_Message.SYM_UDef3 = Convert.ToString(dr["SYM_UDef3"]);
            if (dr["SYM_UDef4"] != DBNull.Value) sys_Message.SYM_UDef4 = Convert.ToString(dr["SYM_UDef4"]);
            if (dr["SYM_UDef5"] != DBNull.Value) sys_Message.SYM_UDef5 = Convert.ToString(dr["SYM_UDef5"]);
            if (dr["Stat"] != DBNull.Value) sys_Message.Stat = Convert.ToInt32(dr["Stat"]);
            ret.Add(sys_Message);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   }  
         return ret;
      }
      /// <summary>
      /// 获取所有的Sys_Message对象(即:一条记录
      /// </summary>
      public List<Sys_Message> GetAll()
      {
         List<Sys_Message> ret = new List<Sys_Message>();
         string sql = "SELECT  SYM_ID,SYM_Module,SYM_Key,SYM_Content,SYM_UDef1,SYM_UDef2,SYM_UDef3,SYM_UDef4,SYM_UDef5,Stat FROM Sys_Message where 1=1 AND ((Stat is null) or (Stat=0) ) order by SYM_ID desc ";
          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            Sys_Message sys_Message = new Sys_Message();
            if (dr["SYM_ID"] != DBNull.Value) sys_Message.SYM_ID = Convert.ToInt64(dr["SYM_ID"]);
            if (dr["SYM_Module"] != DBNull.Value) sys_Message.SYM_Module = Convert.ToString(dr["SYM_Module"]);
            if (dr["SYM_Key"] != DBNull.Value) sys_Message.SYM_Key = Convert.ToString(dr["SYM_Key"]);
            if (dr["SYM_Content"] != DBNull.Value) sys_Message.SYM_Content = Convert.ToString(dr["SYM_Content"]);
            if (dr["SYM_UDef1"] != DBNull.Value) sys_Message.SYM_UDef1 = Convert.ToString(dr["SYM_UDef1"]);
            if (dr["SYM_UDef2"] != DBNull.Value) sys_Message.SYM_UDef2 = Convert.ToString(dr["SYM_UDef2"]);
            if (dr["SYM_UDef3"] != DBNull.Value) sys_Message.SYM_UDef3 = Convert.ToString(dr["SYM_UDef3"]);
            if (dr["SYM_UDef4"] != DBNull.Value) sys_Message.SYM_UDef4 = Convert.ToString(dr["SYM_UDef4"]);
            if (dr["SYM_UDef5"] != DBNull.Value) sys_Message.SYM_UDef5 = Convert.ToString(dr["SYM_UDef5"]);
            if (dr["Stat"] != DBNull.Value) sys_Message.Stat = Convert.ToInt32(dr["Stat"]);
            ret.Add(sys_Message);
         }
          }catch (System.Exception ex){ throw ex; }  finally {  if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   } 
         return ret;
      }
   }
}
