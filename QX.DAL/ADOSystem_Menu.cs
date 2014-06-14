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
   /// 系统菜单
   /// </summary>
   [Serializable]
   public partial class ADOSystem_Menu
   {
      public IDBOperator idb =  DBOperator.GetInstance();
      /// <summary>
      /// 添加系统菜单 System_Menu对象(即:一条记录)
      /// </summary>
      public int Add(System_Menu system_Menu)
      {
         string sql = "INSERT INTO System_Menu (Menu_Code,Menu_Title,Menu_Location,Menu_PCode,Menu_Enable,Menu_Url,Menu_Order,Menu_Icon,Stat,Shortcut) VALUES (@Menu_Code,@Menu_Title,@Menu_Location,@Menu_PCode,@Menu_Enable,@Menu_Url,@Menu_Order,@Menu_Icon,@Stat,@Shortcut)";
         if (string.IsNullOrEmpty(system_Menu.Menu_Code))
         {
            idb.AddParameter("@Menu_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Menu_Code", system_Menu.Menu_Code);
         }
         if (string.IsNullOrEmpty(system_Menu.Menu_Title))
         {
            idb.AddParameter("@Menu_Title", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Menu_Title", system_Menu.Menu_Title);
         }
         if (string.IsNullOrEmpty(system_Menu.Menu_Location))
         {
            idb.AddParameter("@Menu_Location", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Menu_Location", system_Menu.Menu_Location);
         }
         if (string.IsNullOrEmpty(system_Menu.Menu_PCode))
         {
            idb.AddParameter("@Menu_PCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Menu_PCode", system_Menu.Menu_PCode);
         }
         if (string.IsNullOrEmpty(system_Menu.Menu_Enable))
         {
            idb.AddParameter("@Menu_Enable", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Menu_Enable", system_Menu.Menu_Enable);
         }
         if (string.IsNullOrEmpty(system_Menu.Menu_Url))
         {
            idb.AddParameter("@Menu_Url", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Menu_Url", system_Menu.Menu_Url);
         }
         if (system_Menu.Menu_Order == 0)
         {
            idb.AddParameter("@Menu_Order", 0);
         }
         else
         {
            idb.AddParameter("@Menu_Order", system_Menu.Menu_Order);
         }
         if (string.IsNullOrEmpty(system_Menu.Menu_Icon))
         {
            idb.AddParameter("@Menu_Icon", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Menu_Icon", system_Menu.Menu_Icon);
         }
         if (system_Menu.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", system_Menu.Stat);
         }
         if (system_Menu.Shortcut == 0)
         {
            idb.AddParameter("@Shortcut", 0);
         }
         else
         {
            idb.AddParameter("@Shortcut", system_Menu.Shortcut);
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
      /// 添加系统菜单 System_Menu对象(即:一条记录)
      /// </summary>
      public object AddWithReturn(System_Menu system_Menu)
      {
         string sql = "INSERT INTO System_Menu (Menu_Code,Menu_Title,Menu_Location,Menu_PCode,Menu_Enable,Menu_Url,Menu_Order,Menu_Icon,Stat,Shortcut) VALUES (@Menu_Code,@Menu_Title,@Menu_Location,@Menu_PCode,@Menu_Enable,@Menu_Url,@Menu_Order,@Menu_Icon,@Stat,@Shortcut);SELECT @@IDENTITY AS ReturnID;";
         if (string.IsNullOrEmpty(system_Menu.Menu_Code))
         {
            idb.AddParameter("@Menu_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Menu_Code", system_Menu.Menu_Code);
         }
         if (string.IsNullOrEmpty(system_Menu.Menu_Title))
         {
            idb.AddParameter("@Menu_Title", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Menu_Title", system_Menu.Menu_Title);
         }
         if (string.IsNullOrEmpty(system_Menu.Menu_Location))
         {
            idb.AddParameter("@Menu_Location", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Menu_Location", system_Menu.Menu_Location);
         }
         if (string.IsNullOrEmpty(system_Menu.Menu_PCode))
         {
            idb.AddParameter("@Menu_PCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Menu_PCode", system_Menu.Menu_PCode);
         }
         if (string.IsNullOrEmpty(system_Menu.Menu_Enable))
         {
            idb.AddParameter("@Menu_Enable", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Menu_Enable", system_Menu.Menu_Enable);
         }
         if (string.IsNullOrEmpty(system_Menu.Menu_Url))
         {
            idb.AddParameter("@Menu_Url", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Menu_Url", system_Menu.Menu_Url);
         }
         if (system_Menu.Menu_Order == 0)
         {
            idb.AddParameter("@Menu_Order", 0);
         }
         else
         {
            idb.AddParameter("@Menu_Order", system_Menu.Menu_Order);
         }
         if (string.IsNullOrEmpty(system_Menu.Menu_Icon))
         {
            idb.AddParameter("@Menu_Icon", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Menu_Icon", system_Menu.Menu_Icon);
         }
         if (system_Menu.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", system_Menu.Stat);
         }
         if (system_Menu.Shortcut == 0)
         {
            idb.AddParameter("@Shortcut", 0);
         }
         else
         {
            idb.AddParameter("@Shortcut", system_Menu.Shortcut);
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
      /// 更新系统菜单 System_Menu对象(即:一条记录
      /// </summary>
      public int Update(System_Menu system_Menu)
      {
         
         StringBuilder sbParameter=new StringBuilder();
      StringBuilder sb=new StringBuilder();
      sb.Append(@"UPDATE       System_Menu       SET ");
            if(system_Menu.Menu_Code_IsChanged){sbParameter.Append("Menu_Code=@Menu_Code, ");}
      if(system_Menu.Menu_Title_IsChanged){sbParameter.Append("Menu_Title=@Menu_Title, ");}
      if(system_Menu.Menu_Location_IsChanged){sbParameter.Append("Menu_Location=@Menu_Location, ");}
      if(system_Menu.Menu_PCode_IsChanged){sbParameter.Append("Menu_PCode=@Menu_PCode, ");}
      if(system_Menu.Menu_Enable_IsChanged){sbParameter.Append("Menu_Enable=@Menu_Enable, ");}
      if(system_Menu.Menu_Url_IsChanged){sbParameter.Append("Menu_Url=@Menu_Url, ");}
      if(system_Menu.Menu_Order_IsChanged){sbParameter.Append("Menu_Order=@Menu_Order, ");}
      if(system_Menu.Menu_Icon_IsChanged){sbParameter.Append("Menu_Icon=@Menu_Icon, ");}
      if(system_Menu.Stat_IsChanged){sbParameter.Append("Stat=@Stat, ");}
      if(system_Menu.Shortcut_IsChanged){sbParameter.Append("Shortcut=@Shortcut ");}
          sb.Append(sbParameter.ToString().Trim().TrimEnd(',')); 
      sb.Append(      " WHERE 1=1 AND ((Stat is null) or (Stat=0))   and Menu_ID=@Menu_ID; " );
      string sql=sb.ToString();
         if(system_Menu.Menu_Code_IsChanged)
         {
         if (string.IsNullOrEmpty(system_Menu.Menu_Code))
         {
            idb.AddParameter("@Menu_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Menu_Code", system_Menu.Menu_Code);
         }
          }
         if(system_Menu.Menu_Title_IsChanged)
         {
         if (string.IsNullOrEmpty(system_Menu.Menu_Title))
         {
            idb.AddParameter("@Menu_Title", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Menu_Title", system_Menu.Menu_Title);
         }
          }
         if(system_Menu.Menu_Location_IsChanged)
         {
         if (string.IsNullOrEmpty(system_Menu.Menu_Location))
         {
            idb.AddParameter("@Menu_Location", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Menu_Location", system_Menu.Menu_Location);
         }
          }
         if(system_Menu.Menu_PCode_IsChanged)
         {
         if (string.IsNullOrEmpty(system_Menu.Menu_PCode))
         {
            idb.AddParameter("@Menu_PCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Menu_PCode", system_Menu.Menu_PCode);
         }
          }
         if(system_Menu.Menu_Enable_IsChanged)
         {
         if (string.IsNullOrEmpty(system_Menu.Menu_Enable))
         {
            idb.AddParameter("@Menu_Enable", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Menu_Enable", system_Menu.Menu_Enable);
         }
          }
         if(system_Menu.Menu_Url_IsChanged)
         {
         if (string.IsNullOrEmpty(system_Menu.Menu_Url))
         {
            idb.AddParameter("@Menu_Url", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Menu_Url", system_Menu.Menu_Url);
         }
          }
         if(system_Menu.Menu_Order_IsChanged)
         {
         if (system_Menu.Menu_Order == 0)
         {
            idb.AddParameter("@Menu_Order", 0);
         }
         else
         {
            idb.AddParameter("@Menu_Order", system_Menu.Menu_Order);
         }
          }
         if(system_Menu.Menu_Icon_IsChanged)
         {
         if (string.IsNullOrEmpty(system_Menu.Menu_Icon))
         {
            idb.AddParameter("@Menu_Icon", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Menu_Icon", system_Menu.Menu_Icon);
         }
          }
         if(system_Menu.Stat_IsChanged)
         {
         if (system_Menu.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", system_Menu.Stat);
         }
          }
         if(system_Menu.Shortcut_IsChanged)
         {
         if (system_Menu.Shortcut == 0)
         {
            idb.AddParameter("@Shortcut", 0);
         }
         else
         {
            idb.AddParameter("@Shortcut", system_Menu.Shortcut);
         }
          }

         idb.AddParameter("@Menu_ID", system_Menu.Menu_ID);

           
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
      /// 删除系统菜单 System_Menu对象(即:一条记录
      /// </summary>
      public int Delete(decimal menu_ID)
      {
         string sql = "DELETE System_Menu WHERE 1=1  AND Menu_ID=@Menu_ID ";
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
      /// 获取指定的系统菜单 System_Menu对象(即:一条记录
      /// </summary>
      public System_Menu GetByKey(decimal menu_ID)
      {
         System_Menu system_Menu = new System_Menu();
         string sql = "SELECT  Menu_ID,Menu_Code,Menu_Title,Menu_Location,Menu_PCode,Menu_Enable,Menu_Url,Menu_Order,Menu_Icon,Stat,Shortcut FROM System_Menu WHERE 1=1 AND ((Stat is null) or (Stat=0) )  AND Menu_ID=@Menu_ID ";
         idb.AddParameter("@Menu_ID", menu_ID);

          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            if (dr["Menu_ID"] != DBNull.Value) system_Menu.Menu_ID = Convert.ToDecimal(dr["Menu_ID"]);
            if (dr["Menu_Code"] != DBNull.Value) system_Menu.Menu_Code = Convert.ToString(dr["Menu_Code"]);
            if (dr["Menu_Title"] != DBNull.Value) system_Menu.Menu_Title = Convert.ToString(dr["Menu_Title"]);
            if (dr["Menu_Location"] != DBNull.Value) system_Menu.Menu_Location = Convert.ToString(dr["Menu_Location"]);
            if (dr["Menu_PCode"] != DBNull.Value) system_Menu.Menu_PCode = Convert.ToString(dr["Menu_PCode"]);
            if (dr["Menu_Enable"] != DBNull.Value) system_Menu.Menu_Enable = Convert.ToString(dr["Menu_Enable"]);
            if (dr["Menu_Url"] != DBNull.Value) system_Menu.Menu_Url = Convert.ToString(dr["Menu_Url"]);
            if (dr["Menu_Order"] != DBNull.Value) system_Menu.Menu_Order = Convert.ToInt32(dr["Menu_Order"]);
            if (dr["Menu_Icon"] != DBNull.Value) system_Menu.Menu_Icon = Convert.ToString(dr["Menu_Icon"]);
            if (dr["Stat"] != DBNull.Value) system_Menu.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["Shortcut"] != DBNull.Value) system_Menu.Shortcut = Convert.ToInt32(dr["Shortcut"]);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   }  
         return system_Menu;
      }
      /// <summary>
      /// 获取指定的系统菜单 System_Menu对象集合
      /// </summary>
      public List<System_Menu> GetListByWhere(string strCondition)
      {
         List<System_Menu> ret = new List<System_Menu>();
         string sql = "SELECT  Menu_ID,Menu_Code,Menu_Title,Menu_Location,Menu_PCode,Menu_Enable,Menu_Url,Menu_Order,Menu_Icon,Stat,Shortcut FROM System_Menu WHERE 1=1 AND ((Stat is null) or (Stat=0) ) ";
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
            System_Menu system_Menu = new System_Menu();
            if (dr["Menu_ID"] != DBNull.Value) system_Menu.Menu_ID = Convert.ToDecimal(dr["Menu_ID"]);
            if (dr["Menu_Code"] != DBNull.Value) system_Menu.Menu_Code = Convert.ToString(dr["Menu_Code"]);
            if (dr["Menu_Title"] != DBNull.Value) system_Menu.Menu_Title = Convert.ToString(dr["Menu_Title"]);
            if (dr["Menu_Location"] != DBNull.Value) system_Menu.Menu_Location = Convert.ToString(dr["Menu_Location"]);
            if (dr["Menu_PCode"] != DBNull.Value) system_Menu.Menu_PCode = Convert.ToString(dr["Menu_PCode"]);
            if (dr["Menu_Enable"] != DBNull.Value) system_Menu.Menu_Enable = Convert.ToString(dr["Menu_Enable"]);
            if (dr["Menu_Url"] != DBNull.Value) system_Menu.Menu_Url = Convert.ToString(dr["Menu_Url"]);
            if (dr["Menu_Order"] != DBNull.Value) system_Menu.Menu_Order = Convert.ToInt32(dr["Menu_Order"]);
            if (dr["Menu_Icon"] != DBNull.Value) system_Menu.Menu_Icon = Convert.ToString(dr["Menu_Icon"]);
            if (dr["Stat"] != DBNull.Value) system_Menu.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["Shortcut"] != DBNull.Value) system_Menu.Shortcut = Convert.ToInt32(dr["Shortcut"]);
            ret.Add(system_Menu);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   }  
         return ret;
      }
      /// <summary>
      /// 获取所有的系统菜单 System_Menu对象(即:一条记录
      /// </summary>
      public List<System_Menu> GetAll()
      {
         List<System_Menu> ret = new List<System_Menu>();
         string sql = "SELECT  Menu_ID,Menu_Code,Menu_Title,Menu_Location,Menu_PCode,Menu_Enable,Menu_Url,Menu_Order,Menu_Icon,Stat,Shortcut FROM System_Menu where 1=1 AND ((Stat is null) or (Stat=0) ) order by Menu_ID desc ";
          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            System_Menu system_Menu = new System_Menu();
            if (dr["Menu_ID"] != DBNull.Value) system_Menu.Menu_ID = Convert.ToDecimal(dr["Menu_ID"]);
            if (dr["Menu_Code"] != DBNull.Value) system_Menu.Menu_Code = Convert.ToString(dr["Menu_Code"]);
            if (dr["Menu_Title"] != DBNull.Value) system_Menu.Menu_Title = Convert.ToString(dr["Menu_Title"]);
            if (dr["Menu_Location"] != DBNull.Value) system_Menu.Menu_Location = Convert.ToString(dr["Menu_Location"]);
            if (dr["Menu_PCode"] != DBNull.Value) system_Menu.Menu_PCode = Convert.ToString(dr["Menu_PCode"]);
            if (dr["Menu_Enable"] != DBNull.Value) system_Menu.Menu_Enable = Convert.ToString(dr["Menu_Enable"]);
            if (dr["Menu_Url"] != DBNull.Value) system_Menu.Menu_Url = Convert.ToString(dr["Menu_Url"]);
            if (dr["Menu_Order"] != DBNull.Value) system_Menu.Menu_Order = Convert.ToInt32(dr["Menu_Order"]);
            if (dr["Menu_Icon"] != DBNull.Value) system_Menu.Menu_Icon = Convert.ToString(dr["Menu_Icon"]);
            if (dr["Stat"] != DBNull.Value) system_Menu.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["Shortcut"] != DBNull.Value) system_Menu.Shortcut = Convert.ToInt32(dr["Shortcut"]);
            ret.Add(system_Menu);
         }
          }catch (System.Exception ex){ throw ex; }  finally {  if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   } 
         return ret;
      }
   }
}
