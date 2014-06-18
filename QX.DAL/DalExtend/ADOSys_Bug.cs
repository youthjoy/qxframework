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
   /// Bug管理系统
   /// </summary>
   [Serializable]
   public partial class ADOSys_Bug
   {
       public IDBOperator idb = DBOperator.GetBugInstance();
      /// <summary>
      /// 添加Bug管理系统 Sys_Bug对象(即:一条记录)
      /// </summary>
      public int Add(Sys_Bug sys_Bug)
      {
         string sql = "INSERT INTO Sys_Bug (Sys_Code,Sys_Date,Sys_Title,Sys_Des,Sys_Project,Sys_Module,Sys_UserCode,Sys_UserName,Sys_Owner,Sys_OpUser,Sys_Status,Stat) VALUES (@Sys_Code,@Sys_Date,@Sys_Title,@Sys_Des,@Sys_Project,@Sys_Module,@Sys_UserCode,@Sys_UserName,@Sys_Owner,@Sys_OpUser,@Sys_Status,@Stat)";
         if (string.IsNullOrEmpty(sys_Bug.Sys_Code))
         {
            idb.AddParameter("@Sys_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Sys_Code", sys_Bug.Sys_Code);
         }
         if (sys_Bug.Sys_Date == DateTime.MinValue)
         {
            idb.AddParameter("@Sys_Date", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Sys_Date", sys_Bug.Sys_Date);
         }
         if (string.IsNullOrEmpty(sys_Bug.Sys_Title))
         {
            idb.AddParameter("@Sys_Title", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Sys_Title", sys_Bug.Sys_Title);
         }
         if (string.IsNullOrEmpty(sys_Bug.Sys_Des))
         {
            idb.AddParameter("@Sys_Des", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Sys_Des", sys_Bug.Sys_Des);
         }
         if (string.IsNullOrEmpty(sys_Bug.Sys_Project))
         {
            idb.AddParameter("@Sys_Project", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Sys_Project", sys_Bug.Sys_Project);
         }
         if (string.IsNullOrEmpty(sys_Bug.Sys_Module))
         {
            idb.AddParameter("@Sys_Module", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Sys_Module", sys_Bug.Sys_Module);
         }
         if (string.IsNullOrEmpty(sys_Bug.Sys_UserCode))
         {
            idb.AddParameter("@Sys_UserCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Sys_UserCode", sys_Bug.Sys_UserCode);
         }
         if (string.IsNullOrEmpty(sys_Bug.Sys_UserName))
         {
            idb.AddParameter("@Sys_UserName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Sys_UserName", sys_Bug.Sys_UserName);
         }
         if (string.IsNullOrEmpty(sys_Bug.Sys_Owner))
         {
            idb.AddParameter("@Sys_Owner", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Sys_Owner", sys_Bug.Sys_Owner);
         }
         if (string.IsNullOrEmpty(sys_Bug.Sys_OpUser))
         {
            idb.AddParameter("@Sys_OpUser", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Sys_OpUser", sys_Bug.Sys_OpUser);
         }
         if (string.IsNullOrEmpty(sys_Bug.Sys_Status))
         {
            idb.AddParameter("@Sys_Status", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Sys_Status", sys_Bug.Sys_Status);
         }
         if (sys_Bug.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", sys_Bug.Stat);
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
      /// 添加Bug管理系统 Sys_Bug对象(即:一条记录)
      /// </summary>
      public object AddWithReturn(Sys_Bug sys_Bug)
      {
         string sql = "INSERT INTO Sys_Bug (Sys_Code,Sys_Date,Sys_Title,Sys_Des,Sys_Project,Sys_Module,Sys_UserCode,Sys_UserName,Sys_Owner,Sys_OpUser,Sys_Status,Stat) VALUES (@Sys_Code,@Sys_Date,@Sys_Title,@Sys_Des,@Sys_Project,@Sys_Module,@Sys_UserCode,@Sys_UserName,@Sys_Owner,@Sys_OpUser,@Sys_Status,@Stat);SELECT @@IDENTITY AS ReturnID;";
         if (string.IsNullOrEmpty(sys_Bug.Sys_Code))
         {
            idb.AddParameter("@Sys_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Sys_Code", sys_Bug.Sys_Code);
         }
         if (sys_Bug.Sys_Date == DateTime.MinValue)
         {
            idb.AddParameter("@Sys_Date", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Sys_Date", sys_Bug.Sys_Date);
         }
         if (string.IsNullOrEmpty(sys_Bug.Sys_Title))
         {
            idb.AddParameter("@Sys_Title", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Sys_Title", sys_Bug.Sys_Title);
         }
         if (string.IsNullOrEmpty(sys_Bug.Sys_Des))
         {
            idb.AddParameter("@Sys_Des", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Sys_Des", sys_Bug.Sys_Des);
         }
         if (string.IsNullOrEmpty(sys_Bug.Sys_Project))
         {
            idb.AddParameter("@Sys_Project", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Sys_Project", sys_Bug.Sys_Project);
         }
         if (string.IsNullOrEmpty(sys_Bug.Sys_Module))
         {
            idb.AddParameter("@Sys_Module", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Sys_Module", sys_Bug.Sys_Module);
         }
         if (string.IsNullOrEmpty(sys_Bug.Sys_UserCode))
         {
            idb.AddParameter("@Sys_UserCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Sys_UserCode", sys_Bug.Sys_UserCode);
         }
         if (string.IsNullOrEmpty(sys_Bug.Sys_UserName))
         {
            idb.AddParameter("@Sys_UserName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Sys_UserName", sys_Bug.Sys_UserName);
         }
         if (string.IsNullOrEmpty(sys_Bug.Sys_Owner))
         {
            idb.AddParameter("@Sys_Owner", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Sys_Owner", sys_Bug.Sys_Owner);
         }
         if (string.IsNullOrEmpty(sys_Bug.Sys_OpUser))
         {
            idb.AddParameter("@Sys_OpUser", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Sys_OpUser", sys_Bug.Sys_OpUser);
         }
         if (string.IsNullOrEmpty(sys_Bug.Sys_Status))
         {
            idb.AddParameter("@Sys_Status", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Sys_Status", sys_Bug.Sys_Status);
         }
         if (sys_Bug.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", sys_Bug.Stat);
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
      /// 更新Bug管理系统 Sys_Bug对象(即:一条记录
      /// </summary>
      public int Update(Sys_Bug sys_Bug)
      {
         
         StringBuilder sbParameter=new StringBuilder();
      StringBuilder sb=new StringBuilder();
      sb.Append(@"UPDATE       Sys_Bug       SET ");
            if(sys_Bug.Sys_Code_IsChanged){sbParameter.Append("Sys_Code=@Sys_Code, ");}
      if(sys_Bug.Sys_Date_IsChanged){sbParameter.Append("Sys_Date=@Sys_Date, ");}
      if(sys_Bug.Sys_Title_IsChanged){sbParameter.Append("Sys_Title=@Sys_Title, ");}
      if(sys_Bug.Sys_Des_IsChanged){sbParameter.Append("Sys_Des=@Sys_Des, ");}
      if(sys_Bug.Sys_Project_IsChanged){sbParameter.Append("Sys_Project=@Sys_Project, ");}
      if(sys_Bug.Sys_Module_IsChanged){sbParameter.Append("Sys_Module=@Sys_Module, ");}
      if(sys_Bug.Sys_UserCode_IsChanged){sbParameter.Append("Sys_UserCode=@Sys_UserCode, ");}
      if(sys_Bug.Sys_UserName_IsChanged){sbParameter.Append("Sys_UserName=@Sys_UserName, ");}
      if(sys_Bug.Sys_Owner_IsChanged){sbParameter.Append("Sys_Owner=@Sys_Owner, ");}
      if(sys_Bug.Sys_OpUser_IsChanged){sbParameter.Append("Sys_OpUser=@Sys_OpUser, ");}
      if(sys_Bug.Sys_Status_IsChanged){sbParameter.Append("Sys_Status=@Sys_Status, ");}
      if(sys_Bug.Stat_IsChanged){sbParameter.Append("Stat=@Stat ");}
          sb.Append(sbParameter.ToString().Trim().TrimEnd(',')); 
      sb.Append(      " WHERE 1=1 AND ((Stat is null) or (Stat=0))   and Sys_ID=@Sys_ID; " );
      string sql=sb.ToString();
         if(sys_Bug.Sys_Code_IsChanged)
         {
         if (string.IsNullOrEmpty(sys_Bug.Sys_Code))
         {
            idb.AddParameter("@Sys_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Sys_Code", sys_Bug.Sys_Code);
         }
          }
         if(sys_Bug.Sys_Date_IsChanged)
         {
         if (sys_Bug.Sys_Date == DateTime.MinValue)
         {
            idb.AddParameter("@Sys_Date", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Sys_Date", sys_Bug.Sys_Date);
         }
          }
         if(sys_Bug.Sys_Title_IsChanged)
         {
         if (string.IsNullOrEmpty(sys_Bug.Sys_Title))
         {
            idb.AddParameter("@Sys_Title", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Sys_Title", sys_Bug.Sys_Title);
         }
          }
         if(sys_Bug.Sys_Des_IsChanged)
         {
         if (string.IsNullOrEmpty(sys_Bug.Sys_Des))
         {
            idb.AddParameter("@Sys_Des", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Sys_Des", sys_Bug.Sys_Des);
         }
          }
         if(sys_Bug.Sys_Project_IsChanged)
         {
         if (string.IsNullOrEmpty(sys_Bug.Sys_Project))
         {
            idb.AddParameter("@Sys_Project", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Sys_Project", sys_Bug.Sys_Project);
         }
          }
         if(sys_Bug.Sys_Module_IsChanged)
         {
         if (string.IsNullOrEmpty(sys_Bug.Sys_Module))
         {
            idb.AddParameter("@Sys_Module", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Sys_Module", sys_Bug.Sys_Module);
         }
          }
         if(sys_Bug.Sys_UserCode_IsChanged)
         {
         if (string.IsNullOrEmpty(sys_Bug.Sys_UserCode))
         {
            idb.AddParameter("@Sys_UserCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Sys_UserCode", sys_Bug.Sys_UserCode);
         }
          }
         if(sys_Bug.Sys_UserName_IsChanged)
         {
         if (string.IsNullOrEmpty(sys_Bug.Sys_UserName))
         {
            idb.AddParameter("@Sys_UserName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Sys_UserName", sys_Bug.Sys_UserName);
         }
          }
         if(sys_Bug.Sys_Owner_IsChanged)
         {
         if (string.IsNullOrEmpty(sys_Bug.Sys_Owner))
         {
            idb.AddParameter("@Sys_Owner", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Sys_Owner", sys_Bug.Sys_Owner);
         }
          }
         if(sys_Bug.Sys_OpUser_IsChanged)
         {
         if (string.IsNullOrEmpty(sys_Bug.Sys_OpUser))
         {
            idb.AddParameter("@Sys_OpUser", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Sys_OpUser", sys_Bug.Sys_OpUser);
         }
          }
         if(sys_Bug.Sys_Status_IsChanged)
         {
         if (string.IsNullOrEmpty(sys_Bug.Sys_Status))
         {
            idb.AddParameter("@Sys_Status", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Sys_Status", sys_Bug.Sys_Status);
         }
          }
         if(sys_Bug.Stat_IsChanged)
         {
         if (sys_Bug.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", sys_Bug.Stat);
         }
          }

         idb.AddParameter("@Sys_ID", sys_Bug.Sys_ID);

           
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
      /// 删除Bug管理系统 Sys_Bug对象(即:一条记录
      /// </summary>
      public int Delete(decimal sys_ID)
      {
         string sql = "DELETE Sys_Bug WHERE 1=1  AND Sys_ID=@Sys_ID ";
         idb.AddParameter("@Sys_ID", sys_ID);

           
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
      /// 获取指定的Bug管理系统 Sys_Bug对象(即:一条记录
      /// </summary>
      public Sys_Bug GetByKey(decimal sys_ID)
      {
         Sys_Bug sys_Bug = new Sys_Bug();
         string sql = "SELECT  Sys_ID,Sys_Code,Sys_Date,Sys_Title,Sys_Des,Sys_Project,Sys_Module,Sys_UserCode,Sys_UserName,Sys_Owner,Sys_OpUser,Sys_Status,Stat FROM Sys_Bug WHERE 1=1 AND ((Stat is null) or (Stat=0) )  AND Sys_ID=@Sys_ID ";
         idb.AddParameter("@Sys_ID", sys_ID);

          SqlDataReader dr=null;  
           try {
               sql += "ORDER BY Sys_ID DESC";
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            if (dr["Sys_ID"] != DBNull.Value) sys_Bug.Sys_ID = Convert.ToDecimal(dr["Sys_ID"]);
            if (dr["Sys_Code"] != DBNull.Value) sys_Bug.Sys_Code = Convert.ToString(dr["Sys_Code"]);
            if (dr["Sys_Date"] != DBNull.Value) sys_Bug.Sys_Date = Convert.ToDateTime(dr["Sys_Date"]);
            if (dr["Sys_Title"] != DBNull.Value) sys_Bug.Sys_Title = Convert.ToString(dr["Sys_Title"]);
            if (dr["Sys_Des"] != DBNull.Value) sys_Bug.Sys_Des = Convert.ToString(dr["Sys_Des"]);
            if (dr["Sys_Project"] != DBNull.Value) sys_Bug.Sys_Project = Convert.ToString(dr["Sys_Project"]);
            if (dr["Sys_Module"] != DBNull.Value) sys_Bug.Sys_Module = Convert.ToString(dr["Sys_Module"]);
            if (dr["Sys_UserCode"] != DBNull.Value) sys_Bug.Sys_UserCode = Convert.ToString(dr["Sys_UserCode"]);
            if (dr["Sys_UserName"] != DBNull.Value) sys_Bug.Sys_UserName = Convert.ToString(dr["Sys_UserName"]);
            if (dr["Sys_Owner"] != DBNull.Value) sys_Bug.Sys_Owner = Convert.ToString(dr["Sys_Owner"]);
            if (dr["Sys_OpUser"] != DBNull.Value) sys_Bug.Sys_OpUser = Convert.ToString(dr["Sys_OpUser"]);
            if (dr["Sys_Status"] != DBNull.Value) sys_Bug.Sys_Status = Convert.ToString(dr["Sys_Status"]);
            if (dr["Stat"] != DBNull.Value) sys_Bug.Stat = Convert.ToInt32(dr["Stat"]);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   }  
         return sys_Bug;
      }
      /// <summary>
      /// 获取指定的Bug管理系统 Sys_Bug对象集合
      /// </summary>
      public List<Sys_Bug> GetListByWhere(string strCondition)
      {
         List<Sys_Bug> ret = new List<Sys_Bug>();
         string sql = "SELECT  Sys_ID,Sys_Code,Sys_Date,Sys_Title,Sys_Des,Sys_Project,Sys_Module,Sys_UserCode,Sys_UserName,Sys_Owner,Sys_OpUser,Sys_Status,Stat FROM Sys_Bug WHERE 1=1 AND ((Stat is null) or (Stat=0) ) ";
         if(!string.IsNullOrEmpty(strCondition))
         {
            strCondition.Replace('\'','"'); //防sql注入
            sql += strCondition ;

         }
          SqlDataReader dr=null;  
           try {
               sql += "ORDER BY Sys_ID DESC";
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            Sys_Bug sys_Bug = new Sys_Bug();
            if (dr["Sys_ID"] != DBNull.Value) sys_Bug.Sys_ID = Convert.ToDecimal(dr["Sys_ID"]);
            if (dr["Sys_Code"] != DBNull.Value) sys_Bug.Sys_Code = Convert.ToString(dr["Sys_Code"]);
            if (dr["Sys_Date"] != DBNull.Value) sys_Bug.Sys_Date = Convert.ToDateTime(dr["Sys_Date"]);
            if (dr["Sys_Title"] != DBNull.Value) sys_Bug.Sys_Title = Convert.ToString(dr["Sys_Title"]);
            if (dr["Sys_Des"] != DBNull.Value) sys_Bug.Sys_Des = Convert.ToString(dr["Sys_Des"]);
            if (dr["Sys_Project"] != DBNull.Value) sys_Bug.Sys_Project = Convert.ToString(dr["Sys_Project"]);
            if (dr["Sys_Module"] != DBNull.Value) sys_Bug.Sys_Module = Convert.ToString(dr["Sys_Module"]);
            if (dr["Sys_UserCode"] != DBNull.Value) sys_Bug.Sys_UserCode = Convert.ToString(dr["Sys_UserCode"]);
            if (dr["Sys_UserName"] != DBNull.Value) sys_Bug.Sys_UserName = Convert.ToString(dr["Sys_UserName"]);
            if (dr["Sys_Owner"] != DBNull.Value) sys_Bug.Sys_Owner = Convert.ToString(dr["Sys_Owner"]);
            if (dr["Sys_OpUser"] != DBNull.Value) sys_Bug.Sys_OpUser = Convert.ToString(dr["Sys_OpUser"]);
            if (dr["Sys_Status"] != DBNull.Value) sys_Bug.Sys_Status = Convert.ToString(dr["Sys_Status"]);
            if (dr["Stat"] != DBNull.Value) sys_Bug.Stat = Convert.ToInt32(dr["Stat"]);
            ret.Add(sys_Bug);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   }  
         return ret;
      }
      /// <summary>
      /// 获取所有的Bug管理系统 Sys_Bug对象(即:一条记录
      /// </summary>
      public List<Sys_Bug> GetAll()
      {
         List<Sys_Bug> ret = new List<Sys_Bug>();
         string sql = "SELECT  Sys_ID,Sys_Code,Sys_Date,Sys_Title,Sys_Des,Sys_Project,Sys_Module,Sys_UserCode,Sys_UserName,Sys_Owner,Sys_OpUser,Sys_Status,Stat FROM Sys_Bug where 1=1 AND ((Stat is null) or (Stat=0) ) order by Sys_ID desc ";
          SqlDataReader dr=null;  
           try {
               //sql += "ORDER BY Sys_ID DESC";
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            Sys_Bug sys_Bug = new Sys_Bug();
            if (dr["Sys_ID"] != DBNull.Value) sys_Bug.Sys_ID = Convert.ToDecimal(dr["Sys_ID"]);
            if (dr["Sys_Code"] != DBNull.Value) sys_Bug.Sys_Code = Convert.ToString(dr["Sys_Code"]);
            if (dr["Sys_Date"] != DBNull.Value) sys_Bug.Sys_Date = Convert.ToDateTime(dr["Sys_Date"]);
            if (dr["Sys_Title"] != DBNull.Value) sys_Bug.Sys_Title = Convert.ToString(dr["Sys_Title"]);
            if (dr["Sys_Des"] != DBNull.Value) sys_Bug.Sys_Des = Convert.ToString(dr["Sys_Des"]);
            if (dr["Sys_Project"] != DBNull.Value) sys_Bug.Sys_Project = Convert.ToString(dr["Sys_Project"]);
            if (dr["Sys_Module"] != DBNull.Value) sys_Bug.Sys_Module = Convert.ToString(dr["Sys_Module"]);
            if (dr["Sys_UserCode"] != DBNull.Value) sys_Bug.Sys_UserCode = Convert.ToString(dr["Sys_UserCode"]);
            if (dr["Sys_UserName"] != DBNull.Value) sys_Bug.Sys_UserName = Convert.ToString(dr["Sys_UserName"]);
            if (dr["Sys_Owner"] != DBNull.Value) sys_Bug.Sys_Owner = Convert.ToString(dr["Sys_Owner"]);
            if (dr["Sys_OpUser"] != DBNull.Value) sys_Bug.Sys_OpUser = Convert.ToString(dr["Sys_OpUser"]);
            if (dr["Sys_Status"] != DBNull.Value) sys_Bug.Sys_Status = Convert.ToString(dr["Sys_Status"]);
            if (dr["Stat"] != DBNull.Value) sys_Bug.Stat = Convert.ToInt32(dr["Stat"]);
            ret.Add(sys_Bug);
         }
          }catch (System.Exception ex){ throw ex; }  finally {  if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   } 
         return ret;
      }
   }
}
