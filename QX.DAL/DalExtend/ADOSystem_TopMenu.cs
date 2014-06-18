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
   /// 顶部快捷方式
   /// </summary>
   [Serializable]
   public partial class ADOSystem_TopMenu
   {
      public IDBOperator idb =  DBOperator.GetInstance();
      /// <summary>
      /// 添加顶部快捷方式 System_TopMenu对象(即:一条记录)
      /// </summary>
      public int Add(System_TopMenu system_TopMenu)
      {
         string sql = "INSERT INTO System_TopMenu (Menu_User,Menu_Links) VALUES (@Menu_User,@Menu_Links)";
         if (string.IsNullOrEmpty(system_TopMenu.Menu_User))
         {
            idb.AddParameter("@Menu_User", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Menu_User", system_TopMenu.Menu_User);
         }
         if (string.IsNullOrEmpty(system_TopMenu.Menu_Links))
         {
            idb.AddParameter("@Menu_Links", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Menu_Links", system_TopMenu.Menu_Links);
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
      /// 添加顶部快捷方式 System_TopMenu对象(即:一条记录)
      /// </summary>
      public object AddWithReturn(System_TopMenu system_TopMenu)
      {
         string sql = "INSERT INTO System_TopMenu (Menu_User,Menu_Links) VALUES (@Menu_User,@Menu_Links);SELECT @@IDENTITY AS ReturnID;";
         if (string.IsNullOrEmpty(system_TopMenu.Menu_User))
         {
            idb.AddParameter("@Menu_User", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Menu_User", system_TopMenu.Menu_User);
         }
         if (string.IsNullOrEmpty(system_TopMenu.Menu_Links))
         {
            idb.AddParameter("@Menu_Links", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Menu_Links", system_TopMenu.Menu_Links);
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
      /// 更新顶部快捷方式 System_TopMenu对象(即:一条记录
      /// </summary>
      public int Update(System_TopMenu system_TopMenu)
      {
         
         StringBuilder sbParameter=new StringBuilder();
      StringBuilder sb=new StringBuilder();
      sb.Append(@"UPDATE       System_TopMenu       SET ");
            if(system_TopMenu.Menu_User_IsChanged){sbParameter.Append("Menu_User=@Menu_User, ");}
      if(system_TopMenu.Menu_Links_IsChanged){sbParameter.Append("Menu_Links=@Menu_Links ");}          sb.Append(sbParameter.ToString().Trim().TrimEnd(',')); 
      sb.Append(      " WHERE 1=1 AND ((Stat is null) or (Stat=0))   and Menu_ID=@Menu_ID; " );
      string sql=sb.ToString();
         if(system_TopMenu.Menu_User_IsChanged)
         {
         if (string.IsNullOrEmpty(system_TopMenu.Menu_User))
         {
            idb.AddParameter("@Menu_User", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Menu_User", system_TopMenu.Menu_User);
         }
          }
         if(system_TopMenu.Menu_Links_IsChanged)
         {
         if (string.IsNullOrEmpty(system_TopMenu.Menu_Links))
         {
            idb.AddParameter("@Menu_Links", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Menu_Links", system_TopMenu.Menu_Links);
         }
          }

         idb.AddParameter("@Menu_ID", system_TopMenu.Menu_ID);

           
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
      /// 删除顶部快捷方式 System_TopMenu对象(即:一条记录
      /// </summary>
      public int Delete(decimal menu_ID)
      {
         string sql = "DELETE System_TopMenu WHERE 1=1  AND Menu_ID=@Menu_ID ";
         idb.AddParameter("@Menu_ID", menu_ID);

           
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
      /// 获取指定的顶部快捷方式 System_TopMenu对象(即:一条记录
      /// </summary>
      public System_TopMenu GetByKey(decimal menu_ID)
      {
         System_TopMenu system_TopMenu = new System_TopMenu();
         string sql = "SELECT  Menu_ID,Menu_User,Menu_Links FROM System_TopMenu WHERE 1=1 AND ((Stat is null) or (Stat=0) )  AND Menu_ID=@Menu_ID ";
         idb.AddParameter("@Menu_ID", menu_ID);

          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            if (dr["Menu_ID"] != DBNull.Value) system_TopMenu.Menu_ID = Convert.ToDecimal(dr["Menu_ID"]);
            if (dr["Menu_User"] != DBNull.Value) system_TopMenu.Menu_User = Convert.ToString(dr["Menu_User"]);
            if (dr["Menu_Links"] != DBNull.Value) system_TopMenu.Menu_Links = Convert.ToString(dr["Menu_Links"]);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   }  
         return system_TopMenu;
      }
      /// <summary>
      /// 获取指定的顶部快捷方式 System_TopMenu对象集合
      /// </summary>
      public List<System_TopMenu> GetListByWhere(string strCondition)
      {
         List<System_TopMenu> ret = new List<System_TopMenu>();
         string sql = "SELECT  Menu_ID,Menu_User,Menu_Links FROM System_TopMenu WHERE 1=1 AND ((Stat is null) or (Stat=0) ) ";
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
            System_TopMenu system_TopMenu = new System_TopMenu();
            if (dr["Menu_ID"] != DBNull.Value) system_TopMenu.Menu_ID = Convert.ToDecimal(dr["Menu_ID"]);
            if (dr["Menu_User"] != DBNull.Value) system_TopMenu.Menu_User = Convert.ToString(dr["Menu_User"]);
            if (dr["Menu_Links"] != DBNull.Value) system_TopMenu.Menu_Links = Convert.ToString(dr["Menu_Links"]);
            ret.Add(system_TopMenu);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   }  
         return ret;
      }
      /// <summary>
      /// 获取所有的顶部快捷方式 System_TopMenu对象(即:一条记录
      /// </summary>
      public List<System_TopMenu> GetAll()
      {
         List<System_TopMenu> ret = new List<System_TopMenu>();
         string sql = "SELECT  Menu_ID,Menu_User,Menu_Links FROM System_TopMenu where 1=1 AND ((Stat is null) or (Stat=0) ) order by Menu_ID desc ";
          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            System_TopMenu system_TopMenu = new System_TopMenu();
            if (dr["Menu_ID"] != DBNull.Value) system_TopMenu.Menu_ID = Convert.ToDecimal(dr["Menu_ID"]);
            if (dr["Menu_User"] != DBNull.Value) system_TopMenu.Menu_User = Convert.ToString(dr["Menu_User"]);
            if (dr["Menu_Links"] != DBNull.Value) system_TopMenu.Menu_Links = Convert.ToString(dr["Menu_Links"]);
            ret.Add(system_TopMenu);
         }
          }catch (System.Exception ex){ throw ex; }  finally {  if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   } 
         return ret;
      }
   }
}
