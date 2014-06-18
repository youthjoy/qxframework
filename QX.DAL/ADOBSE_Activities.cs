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
   /// 活动情况
   /// </summary>
   [Serializable]
   public partial class ADOBSE_Activities
   {
      public IDBOperator idb =  DBOperator.GetInstance();
      /// <summary>
      /// 添加活动情况 BSE_Activities对象(即:一条记录)
      /// </summary>
      public int Add(BSE_Activities bSE_Activities)
      {
         string sql = "INSERT INTO BSE_Activities (BAA_Code,BAA_Type,BAA_Category,BAA_CName,BAA_CCode,BAA_Owner,BAA_Member,BAA_Contract,BAA_Tel,BAA_Begin,BAA_End,BAA_Period,BAA_Priority,BAA_Addr,BAA_Reminder,BAA_Content,BAA_Stat,BAA_iType,BAA_Remark,BAA_RefType,BAA_RefCode) VALUES (@BAA_Code,@BAA_Type,@BAA_Category,@BAA_CName,@BAA_CCode,@BAA_Owner,@BAA_Member,@BAA_Contract,@BAA_Tel,@BAA_Begin,@BAA_End,@BAA_Period,@BAA_Priority,@BAA_Addr,@BAA_Reminder,@BAA_Content,@BAA_Stat,@BAA_iType,@BAA_Remark,@BAA_RefType,@BAA_RefCode)";
         if (string.IsNullOrEmpty(bSE_Activities.BAA_Code))
         {
            idb.AddParameter("@BAA_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@BAA_Code", bSE_Activities.BAA_Code);
         }
         if (string.IsNullOrEmpty(bSE_Activities.BAA_Type))
         {
            idb.AddParameter("@BAA_Type", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@BAA_Type", bSE_Activities.BAA_Type);
         }
         if (string.IsNullOrEmpty(bSE_Activities.BAA_Category))
         {
            idb.AddParameter("@BAA_Category", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@BAA_Category", bSE_Activities.BAA_Category);
         }
         if (string.IsNullOrEmpty(bSE_Activities.BAA_CName))
         {
            idb.AddParameter("@BAA_CName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@BAA_CName", bSE_Activities.BAA_CName);
         }
         if (string.IsNullOrEmpty(bSE_Activities.BAA_CCode))
         {
            idb.AddParameter("@BAA_CCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@BAA_CCode", bSE_Activities.BAA_CCode);
         }
         if (string.IsNullOrEmpty(bSE_Activities.BAA_Owner))
         {
            idb.AddParameter("@BAA_Owner", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@BAA_Owner", bSE_Activities.BAA_Owner);
         }
         if (string.IsNullOrEmpty(bSE_Activities.BAA_Member))
         {
            idb.AddParameter("@BAA_Member", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@BAA_Member", bSE_Activities.BAA_Member);
         }
         if (string.IsNullOrEmpty(bSE_Activities.BAA_Contract))
         {
            idb.AddParameter("@BAA_Contract", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@BAA_Contract", bSE_Activities.BAA_Contract);
         }
         if (string.IsNullOrEmpty(bSE_Activities.BAA_Tel))
         {
            idb.AddParameter("@BAA_Tel", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@BAA_Tel", bSE_Activities.BAA_Tel);
         }
         if (bSE_Activities.BAA_Begin == DateTime.MinValue)
         {
            idb.AddParameter("@BAA_Begin", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@BAA_Begin", bSE_Activities.BAA_Begin);
         }
         if (bSE_Activities.BAA_End == DateTime.MinValue)
         {
            idb.AddParameter("@BAA_End", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@BAA_End", bSE_Activities.BAA_End);
         }
         if (bSE_Activities.BAA_Period == 0)
         {
            idb.AddParameter("@BAA_Period", 0);
         }
         else
         {
            idb.AddParameter("@BAA_Period", bSE_Activities.BAA_Period);
         }
         if (string.IsNullOrEmpty(bSE_Activities.BAA_Priority))
         {
            idb.AddParameter("@BAA_Priority", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@BAA_Priority", bSE_Activities.BAA_Priority);
         }
         if (string.IsNullOrEmpty(bSE_Activities.BAA_Addr))
         {
            idb.AddParameter("@BAA_Addr", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@BAA_Addr", bSE_Activities.BAA_Addr);
         }
         if (bSE_Activities.BAA_Reminder == DateTime.MinValue)
         {
            idb.AddParameter("@BAA_Reminder", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@BAA_Reminder", bSE_Activities.BAA_Reminder);
         }
         if (string.IsNullOrEmpty(bSE_Activities.BAA_Content))
         {
            idb.AddParameter("@BAA_Content", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@BAA_Content", bSE_Activities.BAA_Content);
         }
         if (bSE_Activities.BAA_Stat == 0)
         {
            idb.AddParameter("@BAA_Stat", 0);
         }
         else
         {
            idb.AddParameter("@BAA_Stat", bSE_Activities.BAA_Stat);
         }
         if (string.IsNullOrEmpty(bSE_Activities.BAA_iType))
         {
            idb.AddParameter("@BAA_iType", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@BAA_iType", bSE_Activities.BAA_iType);
         }
         if (string.IsNullOrEmpty(bSE_Activities.BAA_Remark))
         {
            idb.AddParameter("@BAA_Remark", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@BAA_Remark", bSE_Activities.BAA_Remark);
         }
         if (string.IsNullOrEmpty(bSE_Activities.BAA_RefType))
         {
            idb.AddParameter("@BAA_RefType", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@BAA_RefType", bSE_Activities.BAA_RefType);
         }
         if (string.IsNullOrEmpty(bSE_Activities.BAA_RefCode))
         {
            idb.AddParameter("@BAA_RefCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@BAA_RefCode", bSE_Activities.BAA_RefCode);
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
      /// 添加活动情况 BSE_Activities对象(即:一条记录)
      /// </summary>
      public object AddWithReturn(BSE_Activities bSE_Activities)
      {
         string sql = "INSERT INTO BSE_Activities (BAA_Code,BAA_Type,BAA_Category,BAA_CName,BAA_CCode,BAA_Owner,BAA_Member,BAA_Contract,BAA_Tel,BAA_Begin,BAA_End,BAA_Period,BAA_Priority,BAA_Addr,BAA_Reminder,BAA_Content,BAA_Stat,BAA_iType,BAA_Remark,BAA_RefType,BAA_RefCode) VALUES (@BAA_Code,@BAA_Type,@BAA_Category,@BAA_CName,@BAA_CCode,@BAA_Owner,@BAA_Member,@BAA_Contract,@BAA_Tel,@BAA_Begin,@BAA_End,@BAA_Period,@BAA_Priority,@BAA_Addr,@BAA_Reminder,@BAA_Content,@BAA_Stat,@BAA_iType,@BAA_Remark,@BAA_RefType,@BAA_RefCode);SELECT @@IDENTITY AS ReturnID;";
         if (string.IsNullOrEmpty(bSE_Activities.BAA_Code))
         {
            idb.AddParameter("@BAA_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@BAA_Code", bSE_Activities.BAA_Code);
         }
         if (string.IsNullOrEmpty(bSE_Activities.BAA_Type))
         {
            idb.AddParameter("@BAA_Type", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@BAA_Type", bSE_Activities.BAA_Type);
         }
         if (string.IsNullOrEmpty(bSE_Activities.BAA_Category))
         {
            idb.AddParameter("@BAA_Category", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@BAA_Category", bSE_Activities.BAA_Category);
         }
         if (string.IsNullOrEmpty(bSE_Activities.BAA_CName))
         {
            idb.AddParameter("@BAA_CName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@BAA_CName", bSE_Activities.BAA_CName);
         }
         if (string.IsNullOrEmpty(bSE_Activities.BAA_CCode))
         {
            idb.AddParameter("@BAA_CCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@BAA_CCode", bSE_Activities.BAA_CCode);
         }
         if (string.IsNullOrEmpty(bSE_Activities.BAA_Owner))
         {
            idb.AddParameter("@BAA_Owner", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@BAA_Owner", bSE_Activities.BAA_Owner);
         }
         if (string.IsNullOrEmpty(bSE_Activities.BAA_Member))
         {
            idb.AddParameter("@BAA_Member", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@BAA_Member", bSE_Activities.BAA_Member);
         }
         if (string.IsNullOrEmpty(bSE_Activities.BAA_Contract))
         {
            idb.AddParameter("@BAA_Contract", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@BAA_Contract", bSE_Activities.BAA_Contract);
         }
         if (string.IsNullOrEmpty(bSE_Activities.BAA_Tel))
         {
            idb.AddParameter("@BAA_Tel", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@BAA_Tel", bSE_Activities.BAA_Tel);
         }
         if (bSE_Activities.BAA_Begin == DateTime.MinValue)
         {
            idb.AddParameter("@BAA_Begin", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@BAA_Begin", bSE_Activities.BAA_Begin);
         }
         if (bSE_Activities.BAA_End == DateTime.MinValue)
         {
            idb.AddParameter("@BAA_End", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@BAA_End", bSE_Activities.BAA_End);
         }
         if (bSE_Activities.BAA_Period == 0)
         {
            idb.AddParameter("@BAA_Period", 0);
         }
         else
         {
            idb.AddParameter("@BAA_Period", bSE_Activities.BAA_Period);
         }
         if (string.IsNullOrEmpty(bSE_Activities.BAA_Priority))
         {
            idb.AddParameter("@BAA_Priority", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@BAA_Priority", bSE_Activities.BAA_Priority);
         }
         if (string.IsNullOrEmpty(bSE_Activities.BAA_Addr))
         {
            idb.AddParameter("@BAA_Addr", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@BAA_Addr", bSE_Activities.BAA_Addr);
         }
         if (bSE_Activities.BAA_Reminder == DateTime.MinValue)
         {
            idb.AddParameter("@BAA_Reminder", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@BAA_Reminder", bSE_Activities.BAA_Reminder);
         }
         if (string.IsNullOrEmpty(bSE_Activities.BAA_Content))
         {
            idb.AddParameter("@BAA_Content", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@BAA_Content", bSE_Activities.BAA_Content);
         }
         if (bSE_Activities.BAA_Stat == 0)
         {
            idb.AddParameter("@BAA_Stat", 0);
         }
         else
         {
            idb.AddParameter("@BAA_Stat", bSE_Activities.BAA_Stat);
         }
         if (string.IsNullOrEmpty(bSE_Activities.BAA_iType))
         {
            idb.AddParameter("@BAA_iType", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@BAA_iType", bSE_Activities.BAA_iType);
         }
         if (string.IsNullOrEmpty(bSE_Activities.BAA_Remark))
         {
            idb.AddParameter("@BAA_Remark", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@BAA_Remark", bSE_Activities.BAA_Remark);
         }
         if (string.IsNullOrEmpty(bSE_Activities.BAA_RefType))
         {
            idb.AddParameter("@BAA_RefType", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@BAA_RefType", bSE_Activities.BAA_RefType);
         }
         if (string.IsNullOrEmpty(bSE_Activities.BAA_RefCode))
         {
            idb.AddParameter("@BAA_RefCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@BAA_RefCode", bSE_Activities.BAA_RefCode);
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
      /// 更新活动情况 BSE_Activities对象(即:一条记录
      /// </summary>
      public int Update(BSE_Activities bSE_Activities)
      {
         
         StringBuilder sbParameter=new StringBuilder();
      StringBuilder sb=new StringBuilder();
      sb.Append(@"UPDATE       BSE_Activities       SET ");
            if(bSE_Activities.BAA_Code_IsChanged){sbParameter.Append("BAA_Code=@BAA_Code, ");}
      if(bSE_Activities.BAA_Type_IsChanged){sbParameter.Append("BAA_Type=@BAA_Type, ");}
      if(bSE_Activities.BAA_Category_IsChanged){sbParameter.Append("BAA_Category=@BAA_Category, ");}
      if(bSE_Activities.BAA_CName_IsChanged){sbParameter.Append("BAA_CName=@BAA_CName, ");}
      if(bSE_Activities.BAA_CCode_IsChanged){sbParameter.Append("BAA_CCode=@BAA_CCode, ");}
      if(bSE_Activities.BAA_Owner_IsChanged){sbParameter.Append("BAA_Owner=@BAA_Owner, ");}
      if(bSE_Activities.BAA_Member_IsChanged){sbParameter.Append("BAA_Member=@BAA_Member, ");}
      if(bSE_Activities.BAA_Contract_IsChanged){sbParameter.Append("BAA_Contract=@BAA_Contract, ");}
      if(bSE_Activities.BAA_Tel_IsChanged){sbParameter.Append("BAA_Tel=@BAA_Tel, ");}
      if(bSE_Activities.BAA_Begin_IsChanged){sbParameter.Append("BAA_Begin=@BAA_Begin, ");}
      if(bSE_Activities.BAA_End_IsChanged){sbParameter.Append("BAA_End=@BAA_End, ");}
      if(bSE_Activities.BAA_Period_IsChanged){sbParameter.Append("BAA_Period=@BAA_Period, ");}
      if(bSE_Activities.BAA_Priority_IsChanged){sbParameter.Append("BAA_Priority=@BAA_Priority, ");}
      if(bSE_Activities.BAA_Addr_IsChanged){sbParameter.Append("BAA_Addr=@BAA_Addr, ");}
      if(bSE_Activities.BAA_Reminder_IsChanged){sbParameter.Append("BAA_Reminder=@BAA_Reminder, ");}
      if(bSE_Activities.BAA_Content_IsChanged){sbParameter.Append("BAA_Content=@BAA_Content, ");}
      if(bSE_Activities.BAA_Stat_IsChanged){sbParameter.Append("BAA_Stat=@BAA_Stat, ");}
      if(bSE_Activities.BAA_iType_IsChanged){sbParameter.Append("BAA_iType=@BAA_iType, ");}
      if(bSE_Activities.BAA_Remark_IsChanged){sbParameter.Append("BAA_Remark=@BAA_Remark, ");}
      if(bSE_Activities.BAA_RefType_IsChanged){sbParameter.Append("BAA_RefType=@BAA_RefType, ");}
      if(bSE_Activities.BAA_RefCode_IsChanged){sbParameter.Append("BAA_RefCode=@BAA_RefCode ");}          sb.Append(sbParameter.ToString().Trim().TrimEnd(',')); 
      sb.Append(      " WHERE 1=1 AND ((Stat is null) or (Stat=0))   and BAA_ID=@BAA_ID; " );
      string sql=sb.ToString();
         if(bSE_Activities.BAA_Code_IsChanged)
         {
         if (string.IsNullOrEmpty(bSE_Activities.BAA_Code))
         {
            idb.AddParameter("@BAA_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@BAA_Code", bSE_Activities.BAA_Code);
         }
          }
         if(bSE_Activities.BAA_Type_IsChanged)
         {
         if (string.IsNullOrEmpty(bSE_Activities.BAA_Type))
         {
            idb.AddParameter("@BAA_Type", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@BAA_Type", bSE_Activities.BAA_Type);
         }
          }
         if(bSE_Activities.BAA_Category_IsChanged)
         {
         if (string.IsNullOrEmpty(bSE_Activities.BAA_Category))
         {
            idb.AddParameter("@BAA_Category", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@BAA_Category", bSE_Activities.BAA_Category);
         }
          }
         if(bSE_Activities.BAA_CName_IsChanged)
         {
         if (string.IsNullOrEmpty(bSE_Activities.BAA_CName))
         {
            idb.AddParameter("@BAA_CName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@BAA_CName", bSE_Activities.BAA_CName);
         }
          }
         if(bSE_Activities.BAA_CCode_IsChanged)
         {
         if (string.IsNullOrEmpty(bSE_Activities.BAA_CCode))
         {
            idb.AddParameter("@BAA_CCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@BAA_CCode", bSE_Activities.BAA_CCode);
         }
          }
         if(bSE_Activities.BAA_Owner_IsChanged)
         {
         if (string.IsNullOrEmpty(bSE_Activities.BAA_Owner))
         {
            idb.AddParameter("@BAA_Owner", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@BAA_Owner", bSE_Activities.BAA_Owner);
         }
          }
         if(bSE_Activities.BAA_Member_IsChanged)
         {
         if (string.IsNullOrEmpty(bSE_Activities.BAA_Member))
         {
            idb.AddParameter("@BAA_Member", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@BAA_Member", bSE_Activities.BAA_Member);
         }
          }
         if(bSE_Activities.BAA_Contract_IsChanged)
         {
         if (string.IsNullOrEmpty(bSE_Activities.BAA_Contract))
         {
            idb.AddParameter("@BAA_Contract", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@BAA_Contract", bSE_Activities.BAA_Contract);
         }
          }
         if(bSE_Activities.BAA_Tel_IsChanged)
         {
         if (string.IsNullOrEmpty(bSE_Activities.BAA_Tel))
         {
            idb.AddParameter("@BAA_Tel", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@BAA_Tel", bSE_Activities.BAA_Tel);
         }
          }
         if(bSE_Activities.BAA_Begin_IsChanged)
         {
         if (bSE_Activities.BAA_Begin == DateTime.MinValue)
         {
            idb.AddParameter("@BAA_Begin", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@BAA_Begin", bSE_Activities.BAA_Begin);
         }
          }
         if(bSE_Activities.BAA_End_IsChanged)
         {
         if (bSE_Activities.BAA_End == DateTime.MinValue)
         {
            idb.AddParameter("@BAA_End", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@BAA_End", bSE_Activities.BAA_End);
         }
          }
         if(bSE_Activities.BAA_Period_IsChanged)
         {
         if (bSE_Activities.BAA_Period == 0)
         {
            idb.AddParameter("@BAA_Period", 0);
         }
         else
         {
            idb.AddParameter("@BAA_Period", bSE_Activities.BAA_Period);
         }
          }
         if(bSE_Activities.BAA_Priority_IsChanged)
         {
         if (string.IsNullOrEmpty(bSE_Activities.BAA_Priority))
         {
            idb.AddParameter("@BAA_Priority", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@BAA_Priority", bSE_Activities.BAA_Priority);
         }
          }
         if(bSE_Activities.BAA_Addr_IsChanged)
         {
         if (string.IsNullOrEmpty(bSE_Activities.BAA_Addr))
         {
            idb.AddParameter("@BAA_Addr", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@BAA_Addr", bSE_Activities.BAA_Addr);
         }
          }
         if(bSE_Activities.BAA_Reminder_IsChanged)
         {
         if (bSE_Activities.BAA_Reminder == DateTime.MinValue)
         {
            idb.AddParameter("@BAA_Reminder", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@BAA_Reminder", bSE_Activities.BAA_Reminder);
         }
          }
         if(bSE_Activities.BAA_Content_IsChanged)
         {
         if (string.IsNullOrEmpty(bSE_Activities.BAA_Content))
         {
            idb.AddParameter("@BAA_Content", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@BAA_Content", bSE_Activities.BAA_Content);
         }
          }
         if(bSE_Activities.BAA_Stat_IsChanged)
         {
         if (bSE_Activities.BAA_Stat == 0)
         {
            idb.AddParameter("@BAA_Stat", 0);
         }
         else
         {
            idb.AddParameter("@BAA_Stat", bSE_Activities.BAA_Stat);
         }
          }
         if(bSE_Activities.BAA_iType_IsChanged)
         {
         if (string.IsNullOrEmpty(bSE_Activities.BAA_iType))
         {
            idb.AddParameter("@BAA_iType", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@BAA_iType", bSE_Activities.BAA_iType);
         }
          }
         if(bSE_Activities.BAA_Remark_IsChanged)
         {
         if (string.IsNullOrEmpty(bSE_Activities.BAA_Remark))
         {
            idb.AddParameter("@BAA_Remark", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@BAA_Remark", bSE_Activities.BAA_Remark);
         }
          }
         if(bSE_Activities.BAA_RefType_IsChanged)
         {
         if (string.IsNullOrEmpty(bSE_Activities.BAA_RefType))
         {
            idb.AddParameter("@BAA_RefType", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@BAA_RefType", bSE_Activities.BAA_RefType);
         }
          }
         if(bSE_Activities.BAA_RefCode_IsChanged)
         {
         if (string.IsNullOrEmpty(bSE_Activities.BAA_RefCode))
         {
            idb.AddParameter("@BAA_RefCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@BAA_RefCode", bSE_Activities.BAA_RefCode);
         }
          }

         idb.AddParameter("@BAA_ID", bSE_Activities.BAA_ID);

           
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
      /// 删除活动情况 BSE_Activities对象(即:一条记录
      /// </summary>
      public int Delete(decimal bAA_ID)
      {
         string sql = "DELETE BSE_Activities WHERE 1=1  AND BAA_ID=@BAA_ID ";
         idb.AddParameter("@BAA_ID", bAA_ID);

           
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
      /// 获取指定的活动情况 BSE_Activities对象(即:一条记录
      /// </summary>
      public BSE_Activities GetByKey(decimal bAA_ID)
      {
         BSE_Activities bSE_Activities = new BSE_Activities();
         string sql = "SELECT  BAA_ID,BAA_Code,BAA_Type,BAA_Category,BAA_CName,BAA_CCode,BAA_Owner,BAA_Member,BAA_Contract,BAA_Tel,BAA_Begin,BAA_End,BAA_Period,BAA_Priority,BAA_Addr,BAA_Reminder,BAA_Content,BAA_Stat,BAA_iType,BAA_Remark,BAA_RefType,BAA_RefCode FROM BSE_Activities WHERE 1=1 AND ((Stat is null) or (Stat=0) )  AND BAA_ID=@BAA_ID ";
         idb.AddParameter("@BAA_ID", bAA_ID);

          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            if (dr["BAA_ID"] != DBNull.Value) bSE_Activities.BAA_ID = Convert.ToDecimal(dr["BAA_ID"]);
            if (dr["BAA_Code"] != DBNull.Value) bSE_Activities.BAA_Code = Convert.ToString(dr["BAA_Code"]);
            if (dr["BAA_Type"] != DBNull.Value) bSE_Activities.BAA_Type = Convert.ToString(dr["BAA_Type"]);
            if (dr["BAA_Category"] != DBNull.Value) bSE_Activities.BAA_Category = Convert.ToString(dr["BAA_Category"]);
            if (dr["BAA_CName"] != DBNull.Value) bSE_Activities.BAA_CName = Convert.ToString(dr["BAA_CName"]);
            if (dr["BAA_CCode"] != DBNull.Value) bSE_Activities.BAA_CCode = Convert.ToString(dr["BAA_CCode"]);
            if (dr["BAA_Owner"] != DBNull.Value) bSE_Activities.BAA_Owner = Convert.ToString(dr["BAA_Owner"]);
            if (dr["BAA_Member"] != DBNull.Value) bSE_Activities.BAA_Member = Convert.ToString(dr["BAA_Member"]);
            if (dr["BAA_Contract"] != DBNull.Value) bSE_Activities.BAA_Contract = Convert.ToString(dr["BAA_Contract"]);
            if (dr["BAA_Tel"] != DBNull.Value) bSE_Activities.BAA_Tel = Convert.ToString(dr["BAA_Tel"]);
            if (dr["BAA_Begin"] != DBNull.Value) bSE_Activities.BAA_Begin = Convert.ToDateTime(dr["BAA_Begin"]);
            if (dr["BAA_End"] != DBNull.Value) bSE_Activities.BAA_End = Convert.ToDateTime(dr["BAA_End"]);
            if (dr["BAA_Period"] != DBNull.Value) bSE_Activities.BAA_Period = Convert.ToInt32(dr["BAA_Period"]);
            if (dr["BAA_Priority"] != DBNull.Value) bSE_Activities.BAA_Priority = Convert.ToString(dr["BAA_Priority"]);
            if (dr["BAA_Addr"] != DBNull.Value) bSE_Activities.BAA_Addr = Convert.ToString(dr["BAA_Addr"]);
            if (dr["BAA_Reminder"] != DBNull.Value) bSE_Activities.BAA_Reminder = Convert.ToDateTime(dr["BAA_Reminder"]);
            if (dr["BAA_Content"] != DBNull.Value) bSE_Activities.BAA_Content = Convert.ToString(dr["BAA_Content"]);
            if (dr["BAA_Stat"] != DBNull.Value) bSE_Activities.BAA_Stat = Convert.ToInt32(dr["BAA_Stat"]);
            if (dr["BAA_iType"] != DBNull.Value) bSE_Activities.BAA_iType = Convert.ToString(dr["BAA_iType"]);
            if (dr["BAA_Remark"] != DBNull.Value) bSE_Activities.BAA_Remark = Convert.ToString(dr["BAA_Remark"]);
            if (dr["BAA_RefType"] != DBNull.Value) bSE_Activities.BAA_RefType = Convert.ToString(dr["BAA_RefType"]);
            if (dr["BAA_RefCode"] != DBNull.Value) bSE_Activities.BAA_RefCode = Convert.ToString(dr["BAA_RefCode"]);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   }  
         return bSE_Activities;
      }
      /// <summary>
      /// 获取指定的活动情况 BSE_Activities对象集合
      /// </summary>
      public List<BSE_Activities> GetListByWhere(string strCondition)
      {
         List<BSE_Activities> ret = new List<BSE_Activities>();
         string sql = "SELECT  BAA_ID,BAA_Code,BAA_Type,BAA_Category,BAA_CName,BAA_CCode,BAA_Owner,BAA_Member,BAA_Contract,BAA_Tel,BAA_Begin,BAA_End,BAA_Period,BAA_Priority,BAA_Addr,BAA_Reminder,BAA_Content,BAA_Stat,BAA_iType,BAA_Remark,BAA_RefType,BAA_RefCode FROM BSE_Activities WHERE 1=1 AND ((Stat is null) or (Stat=0) ) ";
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
            BSE_Activities bSE_Activities = new BSE_Activities();
            if (dr["BAA_ID"] != DBNull.Value) bSE_Activities.BAA_ID = Convert.ToDecimal(dr["BAA_ID"]);
            if (dr["BAA_Code"] != DBNull.Value) bSE_Activities.BAA_Code = Convert.ToString(dr["BAA_Code"]);
            if (dr["BAA_Type"] != DBNull.Value) bSE_Activities.BAA_Type = Convert.ToString(dr["BAA_Type"]);
            if (dr["BAA_Category"] != DBNull.Value) bSE_Activities.BAA_Category = Convert.ToString(dr["BAA_Category"]);
            if (dr["BAA_CName"] != DBNull.Value) bSE_Activities.BAA_CName = Convert.ToString(dr["BAA_CName"]);
            if (dr["BAA_CCode"] != DBNull.Value) bSE_Activities.BAA_CCode = Convert.ToString(dr["BAA_CCode"]);
            if (dr["BAA_Owner"] != DBNull.Value) bSE_Activities.BAA_Owner = Convert.ToString(dr["BAA_Owner"]);
            if (dr["BAA_Member"] != DBNull.Value) bSE_Activities.BAA_Member = Convert.ToString(dr["BAA_Member"]);
            if (dr["BAA_Contract"] != DBNull.Value) bSE_Activities.BAA_Contract = Convert.ToString(dr["BAA_Contract"]);
            if (dr["BAA_Tel"] != DBNull.Value) bSE_Activities.BAA_Tel = Convert.ToString(dr["BAA_Tel"]);
            if (dr["BAA_Begin"] != DBNull.Value) bSE_Activities.BAA_Begin = Convert.ToDateTime(dr["BAA_Begin"]);
            if (dr["BAA_End"] != DBNull.Value) bSE_Activities.BAA_End = Convert.ToDateTime(dr["BAA_End"]);
            if (dr["BAA_Period"] != DBNull.Value) bSE_Activities.BAA_Period = Convert.ToInt32(dr["BAA_Period"]);
            if (dr["BAA_Priority"] != DBNull.Value) bSE_Activities.BAA_Priority = Convert.ToString(dr["BAA_Priority"]);
            if (dr["BAA_Addr"] != DBNull.Value) bSE_Activities.BAA_Addr = Convert.ToString(dr["BAA_Addr"]);
            if (dr["BAA_Reminder"] != DBNull.Value) bSE_Activities.BAA_Reminder = Convert.ToDateTime(dr["BAA_Reminder"]);
            if (dr["BAA_Content"] != DBNull.Value) bSE_Activities.BAA_Content = Convert.ToString(dr["BAA_Content"]);
            if (dr["BAA_Stat"] != DBNull.Value) bSE_Activities.BAA_Stat = Convert.ToInt32(dr["BAA_Stat"]);
            if (dr["BAA_iType"] != DBNull.Value) bSE_Activities.BAA_iType = Convert.ToString(dr["BAA_iType"]);
            if (dr["BAA_Remark"] != DBNull.Value) bSE_Activities.BAA_Remark = Convert.ToString(dr["BAA_Remark"]);
            if (dr["BAA_RefType"] != DBNull.Value) bSE_Activities.BAA_RefType = Convert.ToString(dr["BAA_RefType"]);
            if (dr["BAA_RefCode"] != DBNull.Value) bSE_Activities.BAA_RefCode = Convert.ToString(dr["BAA_RefCode"]);
            ret.Add(bSE_Activities);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   }  
         return ret;
      }
      /// <summary>
      /// 获取所有的活动情况 BSE_Activities对象(即:一条记录
      /// </summary>
      public List<BSE_Activities> GetAll()
      {
         List<BSE_Activities> ret = new List<BSE_Activities>();
         string sql = "SELECT  BAA_ID,BAA_Code,BAA_Type,BAA_Category,BAA_CName,BAA_CCode,BAA_Owner,BAA_Member,BAA_Contract,BAA_Tel,BAA_Begin,BAA_End,BAA_Period,BAA_Priority,BAA_Addr,BAA_Reminder,BAA_Content,BAA_Stat,BAA_iType,BAA_Remark,BAA_RefType,BAA_RefCode FROM BSE_Activities where 1=1 AND ((Stat is null) or (Stat=0) ) order by BAA_ID desc ";
          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            BSE_Activities bSE_Activities = new BSE_Activities();
            if (dr["BAA_ID"] != DBNull.Value) bSE_Activities.BAA_ID = Convert.ToDecimal(dr["BAA_ID"]);
            if (dr["BAA_Code"] != DBNull.Value) bSE_Activities.BAA_Code = Convert.ToString(dr["BAA_Code"]);
            if (dr["BAA_Type"] != DBNull.Value) bSE_Activities.BAA_Type = Convert.ToString(dr["BAA_Type"]);
            if (dr["BAA_Category"] != DBNull.Value) bSE_Activities.BAA_Category = Convert.ToString(dr["BAA_Category"]);
            if (dr["BAA_CName"] != DBNull.Value) bSE_Activities.BAA_CName = Convert.ToString(dr["BAA_CName"]);
            if (dr["BAA_CCode"] != DBNull.Value) bSE_Activities.BAA_CCode = Convert.ToString(dr["BAA_CCode"]);
            if (dr["BAA_Owner"] != DBNull.Value) bSE_Activities.BAA_Owner = Convert.ToString(dr["BAA_Owner"]);
            if (dr["BAA_Member"] != DBNull.Value) bSE_Activities.BAA_Member = Convert.ToString(dr["BAA_Member"]);
            if (dr["BAA_Contract"] != DBNull.Value) bSE_Activities.BAA_Contract = Convert.ToString(dr["BAA_Contract"]);
            if (dr["BAA_Tel"] != DBNull.Value) bSE_Activities.BAA_Tel = Convert.ToString(dr["BAA_Tel"]);
            if (dr["BAA_Begin"] != DBNull.Value) bSE_Activities.BAA_Begin = Convert.ToDateTime(dr["BAA_Begin"]);
            if (dr["BAA_End"] != DBNull.Value) bSE_Activities.BAA_End = Convert.ToDateTime(dr["BAA_End"]);
            if (dr["BAA_Period"] != DBNull.Value) bSE_Activities.BAA_Period = Convert.ToInt32(dr["BAA_Period"]);
            if (dr["BAA_Priority"] != DBNull.Value) bSE_Activities.BAA_Priority = Convert.ToString(dr["BAA_Priority"]);
            if (dr["BAA_Addr"] != DBNull.Value) bSE_Activities.BAA_Addr = Convert.ToString(dr["BAA_Addr"]);
            if (dr["BAA_Reminder"] != DBNull.Value) bSE_Activities.BAA_Reminder = Convert.ToDateTime(dr["BAA_Reminder"]);
            if (dr["BAA_Content"] != DBNull.Value) bSE_Activities.BAA_Content = Convert.ToString(dr["BAA_Content"]);
            if (dr["BAA_Stat"] != DBNull.Value) bSE_Activities.BAA_Stat = Convert.ToInt32(dr["BAA_Stat"]);
            if (dr["BAA_iType"] != DBNull.Value) bSE_Activities.BAA_iType = Convert.ToString(dr["BAA_iType"]);
            if (dr["BAA_Remark"] != DBNull.Value) bSE_Activities.BAA_Remark = Convert.ToString(dr["BAA_Remark"]);
            if (dr["BAA_RefType"] != DBNull.Value) bSE_Activities.BAA_RefType = Convert.ToString(dr["BAA_RefType"]);
            if (dr["BAA_RefCode"] != DBNull.Value) bSE_Activities.BAA_RefCode = Convert.ToString(dr["BAA_RefCode"]);
            ret.Add(bSE_Activities);
         }
          }catch (System.Exception ex){ throw ex; }  finally {  if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   } 
         return ret;
      }
   }
}
