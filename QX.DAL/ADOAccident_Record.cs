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
   /// 事故调查报告
   /// </summary>
   [Serializable]
   public partial class ADOAccident_Record
   {
      public IDBOperator idb =  DBOperator.GetInstance();
      /// <summary>
      /// 添加事故调查报告 Accident_Record对象(即:一条记录)
      /// </summary>
      public int Add(Accident_Record accident_Record)
      {
         string sql = "INSERT INTO Accident_Record (AR_Code,AR_Type,AR_Date,AR_CheckDate,AR_Injurer,AR_Content,AR_MainReason,AR_Reason,AR_Identification,AR_Rectification,AR_RectificationDate,AR_RectificationPerson,AR_RectificationContent,AR_Duty,AR_DutyDept,AR_iType,AR_AuditStat,AR_Stat,AR_Remark,Stat,CreateDate,UpdateDate,DeleteDate) VALUES (@AR_Code,@AR_Type,@AR_Date,@AR_CheckDate,@AR_Injurer,@AR_Content,@AR_MainReason,@AR_Reason,@AR_Identification,@AR_Rectification,@AR_RectificationDate,@AR_RectificationPerson,@AR_RectificationContent,@AR_Duty,@AR_DutyDept,@AR_iType,@AR_AuditStat,@AR_Stat,@AR_Remark,@Stat,@CreateDate,@UpdateDate,@DeleteDate)";
         if (string.IsNullOrEmpty(accident_Record.AR_Code))
         {
            idb.AddParameter("@AR_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AR_Code", accident_Record.AR_Code);
         }
         if (string.IsNullOrEmpty(accident_Record.AR_Type))
         {
            idb.AddParameter("@AR_Type", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AR_Type", accident_Record.AR_Type);
         }
         if (accident_Record.AR_Date == DateTime.MinValue)
         {
            idb.AddParameter("@AR_Date", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AR_Date", accident_Record.AR_Date);
         }
         if (accident_Record.AR_CheckDate == DateTime.MinValue)
         {
            idb.AddParameter("@AR_CheckDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AR_CheckDate", accident_Record.AR_CheckDate);
         }
         if (string.IsNullOrEmpty(accident_Record.AR_Injurer))
         {
            idb.AddParameter("@AR_Injurer", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AR_Injurer", accident_Record.AR_Injurer);
         }
         if (string.IsNullOrEmpty(accident_Record.AR_Content))
         {
            idb.AddParameter("@AR_Content", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AR_Content", accident_Record.AR_Content);
         }
         if (string.IsNullOrEmpty(accident_Record.AR_MainReason))
         {
            idb.AddParameter("@AR_MainReason", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AR_MainReason", accident_Record.AR_MainReason);
         }
         if (string.IsNullOrEmpty(accident_Record.AR_Reason))
         {
            idb.AddParameter("@AR_Reason", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AR_Reason", accident_Record.AR_Reason);
         }
         if (string.IsNullOrEmpty(accident_Record.AR_Identification))
         {
            idb.AddParameter("@AR_Identification", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AR_Identification", accident_Record.AR_Identification);
         }
         if (string.IsNullOrEmpty(accident_Record.AR_Rectification))
         {
            idb.AddParameter("@AR_Rectification", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AR_Rectification", accident_Record.AR_Rectification);
         }
         if (accident_Record.AR_RectificationDate == DateTime.MinValue)
         {
            idb.AddParameter("@AR_RectificationDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AR_RectificationDate", accident_Record.AR_RectificationDate);
         }
         if (string.IsNullOrEmpty(accident_Record.AR_RectificationPerson))
         {
            idb.AddParameter("@AR_RectificationPerson", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AR_RectificationPerson", accident_Record.AR_RectificationPerson);
         }
         if (string.IsNullOrEmpty(accident_Record.AR_RectificationContent))
         {
            idb.AddParameter("@AR_RectificationContent", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AR_RectificationContent", accident_Record.AR_RectificationContent);
         }
         if (string.IsNullOrEmpty(accident_Record.AR_Duty))
         {
            idb.AddParameter("@AR_Duty", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AR_Duty", accident_Record.AR_Duty);
         }
         if (string.IsNullOrEmpty(accident_Record.AR_DutyDept))
         {
            idb.AddParameter("@AR_DutyDept", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AR_DutyDept", accident_Record.AR_DutyDept);
         }
         if (string.IsNullOrEmpty(accident_Record.AR_iType))
         {
            idb.AddParameter("@AR_iType", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AR_iType", accident_Record.AR_iType);
         }
         if (string.IsNullOrEmpty(accident_Record.AR_AuditStat))
         {
            idb.AddParameter("@AR_AuditStat", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AR_AuditStat", accident_Record.AR_AuditStat);
         }
         if (string.IsNullOrEmpty(accident_Record.AR_Stat))
         {
            idb.AddParameter("@AR_Stat", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AR_Stat", accident_Record.AR_Stat);
         }
         if (string.IsNullOrEmpty(accident_Record.AR_Remark))
         {
            idb.AddParameter("@AR_Remark", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AR_Remark", accident_Record.AR_Remark);
         }
         if (accident_Record.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", accident_Record.Stat);
         }
         if (accident_Record.CreateDate == DateTime.MinValue)
         {
            idb.AddParameter("@CreateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateDate", accident_Record.CreateDate);
         }
         if (accident_Record.UpdateDate == DateTime.MinValue)
         {
            idb.AddParameter("@UpdateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@UpdateDate", accident_Record.UpdateDate);
         }
         if (accident_Record.DeleteDate == DateTime.MinValue)
         {
            idb.AddParameter("@DeleteDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DeleteDate", accident_Record.DeleteDate);
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
      /// 添加事故调查报告 Accident_Record对象(即:一条记录)
      /// </summary>
      public object AddWithReturn(Accident_Record accident_Record)
      {
         string sql = "INSERT INTO Accident_Record (AR_Code,AR_Type,AR_Date,AR_CheckDate,AR_Injurer,AR_Content,AR_MainReason,AR_Reason,AR_Identification,AR_Rectification,AR_RectificationDate,AR_RectificationPerson,AR_RectificationContent,AR_Duty,AR_DutyDept,AR_iType,AR_AuditStat,AR_Stat,AR_Remark,Stat,CreateDate,UpdateDate,DeleteDate) VALUES (@AR_Code,@AR_Type,@AR_Date,@AR_CheckDate,@AR_Injurer,@AR_Content,@AR_MainReason,@AR_Reason,@AR_Identification,@AR_Rectification,@AR_RectificationDate,@AR_RectificationPerson,@AR_RectificationContent,@AR_Duty,@AR_DutyDept,@AR_iType,@AR_AuditStat,@AR_Stat,@AR_Remark,@Stat,@CreateDate,@UpdateDate,@DeleteDate);SELECT @@IDENTITY AS ReturnID;";
         if (string.IsNullOrEmpty(accident_Record.AR_Code))
         {
            idb.AddParameter("@AR_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AR_Code", accident_Record.AR_Code);
         }
         if (string.IsNullOrEmpty(accident_Record.AR_Type))
         {
            idb.AddParameter("@AR_Type", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AR_Type", accident_Record.AR_Type);
         }
         if (accident_Record.AR_Date == DateTime.MinValue)
         {
            idb.AddParameter("@AR_Date", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AR_Date", accident_Record.AR_Date);
         }
         if (accident_Record.AR_CheckDate == DateTime.MinValue)
         {
            idb.AddParameter("@AR_CheckDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AR_CheckDate", accident_Record.AR_CheckDate);
         }
         if (string.IsNullOrEmpty(accident_Record.AR_Injurer))
         {
            idb.AddParameter("@AR_Injurer", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AR_Injurer", accident_Record.AR_Injurer);
         }
         if (string.IsNullOrEmpty(accident_Record.AR_Content))
         {
            idb.AddParameter("@AR_Content", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AR_Content", accident_Record.AR_Content);
         }
         if (string.IsNullOrEmpty(accident_Record.AR_MainReason))
         {
            idb.AddParameter("@AR_MainReason", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AR_MainReason", accident_Record.AR_MainReason);
         }
         if (string.IsNullOrEmpty(accident_Record.AR_Reason))
         {
            idb.AddParameter("@AR_Reason", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AR_Reason", accident_Record.AR_Reason);
         }
         if (string.IsNullOrEmpty(accident_Record.AR_Identification))
         {
            idb.AddParameter("@AR_Identification", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AR_Identification", accident_Record.AR_Identification);
         }
         if (string.IsNullOrEmpty(accident_Record.AR_Rectification))
         {
            idb.AddParameter("@AR_Rectification", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AR_Rectification", accident_Record.AR_Rectification);
         }
         if (accident_Record.AR_RectificationDate == DateTime.MinValue)
         {
            idb.AddParameter("@AR_RectificationDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AR_RectificationDate", accident_Record.AR_RectificationDate);
         }
         if (string.IsNullOrEmpty(accident_Record.AR_RectificationPerson))
         {
            idb.AddParameter("@AR_RectificationPerson", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AR_RectificationPerson", accident_Record.AR_RectificationPerson);
         }
         if (string.IsNullOrEmpty(accident_Record.AR_RectificationContent))
         {
            idb.AddParameter("@AR_RectificationContent", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AR_RectificationContent", accident_Record.AR_RectificationContent);
         }
         if (string.IsNullOrEmpty(accident_Record.AR_Duty))
         {
            idb.AddParameter("@AR_Duty", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AR_Duty", accident_Record.AR_Duty);
         }
         if (string.IsNullOrEmpty(accident_Record.AR_DutyDept))
         {
            idb.AddParameter("@AR_DutyDept", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AR_DutyDept", accident_Record.AR_DutyDept);
         }
         if (string.IsNullOrEmpty(accident_Record.AR_iType))
         {
            idb.AddParameter("@AR_iType", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AR_iType", accident_Record.AR_iType);
         }
         if (string.IsNullOrEmpty(accident_Record.AR_AuditStat))
         {
            idb.AddParameter("@AR_AuditStat", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AR_AuditStat", accident_Record.AR_AuditStat);
         }
         if (string.IsNullOrEmpty(accident_Record.AR_Stat))
         {
            idb.AddParameter("@AR_Stat", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AR_Stat", accident_Record.AR_Stat);
         }
         if (string.IsNullOrEmpty(accident_Record.AR_Remark))
         {
            idb.AddParameter("@AR_Remark", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AR_Remark", accident_Record.AR_Remark);
         }
         if (accident_Record.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", accident_Record.Stat);
         }
         if (accident_Record.CreateDate == DateTime.MinValue)
         {
            idb.AddParameter("@CreateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateDate", accident_Record.CreateDate);
         }
         if (accident_Record.UpdateDate == DateTime.MinValue)
         {
            idb.AddParameter("@UpdateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@UpdateDate", accident_Record.UpdateDate);
         }
         if (accident_Record.DeleteDate == DateTime.MinValue)
         {
            idb.AddParameter("@DeleteDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DeleteDate", accident_Record.DeleteDate);
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
      /// 更新事故调查报告 Accident_Record对象(即:一条记录
      /// </summary>
      public int Update(Accident_Record accident_Record)
      {
         
         StringBuilder sbParameter=new StringBuilder();
      StringBuilder sb=new StringBuilder();
      sb.Append(@"UPDATE       Accident_Record       SET ");
            if(accident_Record.AR_Code_IsChanged){sbParameter.Append("AR_Code=@AR_Code, ");}
      if(accident_Record.AR_Type_IsChanged){sbParameter.Append("AR_Type=@AR_Type, ");}
      if(accident_Record.AR_Date_IsChanged){sbParameter.Append("AR_Date=@AR_Date, ");}
      if(accident_Record.AR_CheckDate_IsChanged){sbParameter.Append("AR_CheckDate=@AR_CheckDate, ");}
      if(accident_Record.AR_Injurer_IsChanged){sbParameter.Append("AR_Injurer=@AR_Injurer, ");}
      if(accident_Record.AR_Content_IsChanged){sbParameter.Append("AR_Content=@AR_Content, ");}
      if(accident_Record.AR_MainReason_IsChanged){sbParameter.Append("AR_MainReason=@AR_MainReason, ");}
      if(accident_Record.AR_Reason_IsChanged){sbParameter.Append("AR_Reason=@AR_Reason, ");}
      if(accident_Record.AR_Identification_IsChanged){sbParameter.Append("AR_Identification=@AR_Identification, ");}
      if(accident_Record.AR_Rectification_IsChanged){sbParameter.Append("AR_Rectification=@AR_Rectification, ");}
      if(accident_Record.AR_RectificationDate_IsChanged){sbParameter.Append("AR_RectificationDate=@AR_RectificationDate, ");}
      if(accident_Record.AR_RectificationPerson_IsChanged){sbParameter.Append("AR_RectificationPerson=@AR_RectificationPerson, ");}
      if(accident_Record.AR_RectificationContent_IsChanged){sbParameter.Append("AR_RectificationContent=@AR_RectificationContent, ");}
      if(accident_Record.AR_Duty_IsChanged){sbParameter.Append("AR_Duty=@AR_Duty, ");}
      if(accident_Record.AR_DutyDept_IsChanged){sbParameter.Append("AR_DutyDept=@AR_DutyDept, ");}
      if(accident_Record.AR_iType_IsChanged){sbParameter.Append("AR_iType=@AR_iType, ");}
      if(accident_Record.AR_AuditStat_IsChanged){sbParameter.Append("AR_AuditStat=@AR_AuditStat, ");}
      if(accident_Record.AR_Stat_IsChanged){sbParameter.Append("AR_Stat=@AR_Stat, ");}
      if(accident_Record.AR_Remark_IsChanged){sbParameter.Append("AR_Remark=@AR_Remark, ");}
      if(accident_Record.Stat_IsChanged){sbParameter.Append("Stat=@Stat, ");}
      if(accident_Record.CreateDate_IsChanged){sbParameter.Append("CreateDate=@CreateDate, ");}
      if(accident_Record.UpdateDate_IsChanged){sbParameter.Append("UpdateDate=@UpdateDate, ");}
      if(accident_Record.DeleteDate_IsChanged){sbParameter.Append("DeleteDate=@DeleteDate ");}          sb.Append(sbParameter.ToString().Trim().TrimEnd(',')); 
      sb.Append(      " WHERE 1=1 AND ((Stat is null) or (Stat=0))   and AR_ID=@AR_ID; " );
      string sql=sb.ToString();
         if(accident_Record.AR_Code_IsChanged)
         {
         if (string.IsNullOrEmpty(accident_Record.AR_Code))
         {
            idb.AddParameter("@AR_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AR_Code", accident_Record.AR_Code);
         }
          }
         if(accident_Record.AR_Type_IsChanged)
         {
         if (string.IsNullOrEmpty(accident_Record.AR_Type))
         {
            idb.AddParameter("@AR_Type", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AR_Type", accident_Record.AR_Type);
         }
          }
         if(accident_Record.AR_Date_IsChanged)
         {
         if (accident_Record.AR_Date == DateTime.MinValue)
         {
            idb.AddParameter("@AR_Date", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AR_Date", accident_Record.AR_Date);
         }
          }
         if(accident_Record.AR_CheckDate_IsChanged)
         {
         if (accident_Record.AR_CheckDate == DateTime.MinValue)
         {
            idb.AddParameter("@AR_CheckDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AR_CheckDate", accident_Record.AR_CheckDate);
         }
          }
         if(accident_Record.AR_Injurer_IsChanged)
         {
         if (string.IsNullOrEmpty(accident_Record.AR_Injurer))
         {
            idb.AddParameter("@AR_Injurer", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AR_Injurer", accident_Record.AR_Injurer);
         }
          }
         if(accident_Record.AR_Content_IsChanged)
         {
         if (string.IsNullOrEmpty(accident_Record.AR_Content))
         {
            idb.AddParameter("@AR_Content", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AR_Content", accident_Record.AR_Content);
         }
          }
         if(accident_Record.AR_MainReason_IsChanged)
         {
         if (string.IsNullOrEmpty(accident_Record.AR_MainReason))
         {
            idb.AddParameter("@AR_MainReason", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AR_MainReason", accident_Record.AR_MainReason);
         }
          }
         if(accident_Record.AR_Reason_IsChanged)
         {
         if (string.IsNullOrEmpty(accident_Record.AR_Reason))
         {
            idb.AddParameter("@AR_Reason", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AR_Reason", accident_Record.AR_Reason);
         }
          }
         if(accident_Record.AR_Identification_IsChanged)
         {
         if (string.IsNullOrEmpty(accident_Record.AR_Identification))
         {
            idb.AddParameter("@AR_Identification", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AR_Identification", accident_Record.AR_Identification);
         }
          }
         if(accident_Record.AR_Rectification_IsChanged)
         {
         if (string.IsNullOrEmpty(accident_Record.AR_Rectification))
         {
            idb.AddParameter("@AR_Rectification", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AR_Rectification", accident_Record.AR_Rectification);
         }
          }
         if(accident_Record.AR_RectificationDate_IsChanged)
         {
         if (accident_Record.AR_RectificationDate == DateTime.MinValue)
         {
            idb.AddParameter("@AR_RectificationDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AR_RectificationDate", accident_Record.AR_RectificationDate);
         }
          }
         if(accident_Record.AR_RectificationPerson_IsChanged)
         {
         if (string.IsNullOrEmpty(accident_Record.AR_RectificationPerson))
         {
            idb.AddParameter("@AR_RectificationPerson", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AR_RectificationPerson", accident_Record.AR_RectificationPerson);
         }
          }
         if(accident_Record.AR_RectificationContent_IsChanged)
         {
         if (string.IsNullOrEmpty(accident_Record.AR_RectificationContent))
         {
            idb.AddParameter("@AR_RectificationContent", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AR_RectificationContent", accident_Record.AR_RectificationContent);
         }
          }
         if(accident_Record.AR_Duty_IsChanged)
         {
         if (string.IsNullOrEmpty(accident_Record.AR_Duty))
         {
            idb.AddParameter("@AR_Duty", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AR_Duty", accident_Record.AR_Duty);
         }
          }
         if(accident_Record.AR_DutyDept_IsChanged)
         {
         if (string.IsNullOrEmpty(accident_Record.AR_DutyDept))
         {
            idb.AddParameter("@AR_DutyDept", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AR_DutyDept", accident_Record.AR_DutyDept);
         }
          }
         if(accident_Record.AR_iType_IsChanged)
         {
         if (string.IsNullOrEmpty(accident_Record.AR_iType))
         {
            idb.AddParameter("@AR_iType", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AR_iType", accident_Record.AR_iType);
         }
          }
         if(accident_Record.AR_AuditStat_IsChanged)
         {
         if (string.IsNullOrEmpty(accident_Record.AR_AuditStat))
         {
            idb.AddParameter("@AR_AuditStat", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AR_AuditStat", accident_Record.AR_AuditStat);
         }
          }
         if(accident_Record.AR_Stat_IsChanged)
         {
         if (string.IsNullOrEmpty(accident_Record.AR_Stat))
         {
            idb.AddParameter("@AR_Stat", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AR_Stat", accident_Record.AR_Stat);
         }
          }
         if(accident_Record.AR_Remark_IsChanged)
         {
         if (string.IsNullOrEmpty(accident_Record.AR_Remark))
         {
            idb.AddParameter("@AR_Remark", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AR_Remark", accident_Record.AR_Remark);
         }
          }
         if(accident_Record.Stat_IsChanged)
         {
         if (accident_Record.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", accident_Record.Stat);
         }
          }
         if(accident_Record.CreateDate_IsChanged)
         {
         if (accident_Record.CreateDate == DateTime.MinValue)
         {
            idb.AddParameter("@CreateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateDate", accident_Record.CreateDate);
         }
          }
         if(accident_Record.UpdateDate_IsChanged)
         {
         if (accident_Record.UpdateDate == DateTime.MinValue)
         {
            idb.AddParameter("@UpdateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@UpdateDate", accident_Record.UpdateDate);
         }
          }
         if(accident_Record.DeleteDate_IsChanged)
         {
         if (accident_Record.DeleteDate == DateTime.MinValue)
         {
            idb.AddParameter("@DeleteDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DeleteDate", accident_Record.DeleteDate);
         }
          }

         idb.AddParameter("@AR_ID", accident_Record.AR_ID);

           
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
      /// 删除事故调查报告 Accident_Record对象(即:一条记录
      /// </summary>
      public int Delete(decimal aR_ID)
      {
         string sql = "DELETE Accident_Record WHERE 1=1  AND AR_ID=@AR_ID ";
         idb.AddParameter("@AR_ID", aR_ID);

           
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
      /// 获取指定的事故调查报告 Accident_Record对象(即:一条记录
      /// </summary>
      public Accident_Record GetByKey(decimal aR_ID)
      {
         Accident_Record accident_Record = new Accident_Record();
         string sql = "SELECT  AR_ID,AR_Code,AR_Type,AR_Date,AR_CheckDate,AR_Injurer,AR_Content,AR_MainReason,AR_Reason,AR_Identification,AR_Rectification,AR_RectificationDate,AR_RectificationPerson,AR_RectificationContent,AR_Duty,AR_DutyDept,AR_iType,AR_AuditStat,AR_Stat,AR_Remark,Stat,CreateDate,UpdateDate,DeleteDate FROM Accident_Record WHERE 1=1 AND ((Stat is null) or (Stat=0) )  AND AR_ID=@AR_ID ";
         idb.AddParameter("@AR_ID", aR_ID);

          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            if (dr["AR_ID"] != DBNull.Value) accident_Record.AR_ID = Convert.ToDecimal(dr["AR_ID"]);
            if (dr["AR_Code"] != DBNull.Value) accident_Record.AR_Code = Convert.ToString(dr["AR_Code"]);
            if (dr["AR_Type"] != DBNull.Value) accident_Record.AR_Type = Convert.ToString(dr["AR_Type"]);
            if (dr["AR_Date"] != DBNull.Value) accident_Record.AR_Date = Convert.ToDateTime(dr["AR_Date"]);
            if (dr["AR_CheckDate"] != DBNull.Value) accident_Record.AR_CheckDate = Convert.ToDateTime(dr["AR_CheckDate"]);
            if (dr["AR_Injurer"] != DBNull.Value) accident_Record.AR_Injurer = Convert.ToString(dr["AR_Injurer"]);
            if (dr["AR_Content"] != DBNull.Value) accident_Record.AR_Content = Convert.ToString(dr["AR_Content"]);
            if (dr["AR_MainReason"] != DBNull.Value) accident_Record.AR_MainReason = Convert.ToString(dr["AR_MainReason"]);
            if (dr["AR_Reason"] != DBNull.Value) accident_Record.AR_Reason = Convert.ToString(dr["AR_Reason"]);
            if (dr["AR_Identification"] != DBNull.Value) accident_Record.AR_Identification = Convert.ToString(dr["AR_Identification"]);
            if (dr["AR_Rectification"] != DBNull.Value) accident_Record.AR_Rectification = Convert.ToString(dr["AR_Rectification"]);
            if (dr["AR_RectificationDate"] != DBNull.Value) accident_Record.AR_RectificationDate = Convert.ToDateTime(dr["AR_RectificationDate"]);
            if (dr["AR_RectificationPerson"] != DBNull.Value) accident_Record.AR_RectificationPerson = Convert.ToString(dr["AR_RectificationPerson"]);
            if (dr["AR_RectificationContent"] != DBNull.Value) accident_Record.AR_RectificationContent = Convert.ToString(dr["AR_RectificationContent"]);
            if (dr["AR_Duty"] != DBNull.Value) accident_Record.AR_Duty = Convert.ToString(dr["AR_Duty"]);
            if (dr["AR_DutyDept"] != DBNull.Value) accident_Record.AR_DutyDept = Convert.ToString(dr["AR_DutyDept"]);
            if (dr["AR_iType"] != DBNull.Value) accident_Record.AR_iType = Convert.ToString(dr["AR_iType"]);
            if (dr["AR_AuditStat"] != DBNull.Value) accident_Record.AR_AuditStat = Convert.ToString(dr["AR_AuditStat"]);
            if (dr["AR_Stat"] != DBNull.Value) accident_Record.AR_Stat = Convert.ToString(dr["AR_Stat"]);
            if (dr["AR_Remark"] != DBNull.Value) accident_Record.AR_Remark = Convert.ToString(dr["AR_Remark"]);
            if (dr["Stat"] != DBNull.Value) accident_Record.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["CreateDate"] != DBNull.Value) accident_Record.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
            if (dr["UpdateDate"] != DBNull.Value) accident_Record.UpdateDate = Convert.ToDateTime(dr["UpdateDate"]);
            if (dr["DeleteDate"] != DBNull.Value) accident_Record.DeleteDate = Convert.ToDateTime(dr["DeleteDate"]);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   }  
         return accident_Record;
      }
      /// <summary>
      /// 获取指定的事故调查报告 Accident_Record对象集合
      /// </summary>
      public List<Accident_Record> GetListByWhere(string strCondition)
      {
         List<Accident_Record> ret = new List<Accident_Record>();
         string sql = "SELECT  AR_ID,AR_Code,AR_Type,AR_Date,AR_CheckDate,AR_Injurer,AR_Content,AR_MainReason,AR_Reason,AR_Identification,AR_Rectification,AR_RectificationDate,AR_RectificationPerson,AR_RectificationContent,AR_Duty,AR_DutyDept,AR_iType,AR_AuditStat,AR_Stat,AR_Remark,Stat,CreateDate,UpdateDate,DeleteDate FROM Accident_Record WHERE 1=1 AND ((Stat is null) or (Stat=0) ) ";
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
            Accident_Record accident_Record = new Accident_Record();
            if (dr["AR_ID"] != DBNull.Value) accident_Record.AR_ID = Convert.ToDecimal(dr["AR_ID"]);
            if (dr["AR_Code"] != DBNull.Value) accident_Record.AR_Code = Convert.ToString(dr["AR_Code"]);
            if (dr["AR_Type"] != DBNull.Value) accident_Record.AR_Type = Convert.ToString(dr["AR_Type"]);
            if (dr["AR_Date"] != DBNull.Value) accident_Record.AR_Date = Convert.ToDateTime(dr["AR_Date"]);
            if (dr["AR_CheckDate"] != DBNull.Value) accident_Record.AR_CheckDate = Convert.ToDateTime(dr["AR_CheckDate"]);
            if (dr["AR_Injurer"] != DBNull.Value) accident_Record.AR_Injurer = Convert.ToString(dr["AR_Injurer"]);
            if (dr["AR_Content"] != DBNull.Value) accident_Record.AR_Content = Convert.ToString(dr["AR_Content"]);
            if (dr["AR_MainReason"] != DBNull.Value) accident_Record.AR_MainReason = Convert.ToString(dr["AR_MainReason"]);
            if (dr["AR_Reason"] != DBNull.Value) accident_Record.AR_Reason = Convert.ToString(dr["AR_Reason"]);
            if (dr["AR_Identification"] != DBNull.Value) accident_Record.AR_Identification = Convert.ToString(dr["AR_Identification"]);
            if (dr["AR_Rectification"] != DBNull.Value) accident_Record.AR_Rectification = Convert.ToString(dr["AR_Rectification"]);
            if (dr["AR_RectificationDate"] != DBNull.Value) accident_Record.AR_RectificationDate = Convert.ToDateTime(dr["AR_RectificationDate"]);
            if (dr["AR_RectificationPerson"] != DBNull.Value) accident_Record.AR_RectificationPerson = Convert.ToString(dr["AR_RectificationPerson"]);
            if (dr["AR_RectificationContent"] != DBNull.Value) accident_Record.AR_RectificationContent = Convert.ToString(dr["AR_RectificationContent"]);
            if (dr["AR_Duty"] != DBNull.Value) accident_Record.AR_Duty = Convert.ToString(dr["AR_Duty"]);
            if (dr["AR_DutyDept"] != DBNull.Value) accident_Record.AR_DutyDept = Convert.ToString(dr["AR_DutyDept"]);
            if (dr["AR_iType"] != DBNull.Value) accident_Record.AR_iType = Convert.ToString(dr["AR_iType"]);
            if (dr["AR_AuditStat"] != DBNull.Value) accident_Record.AR_AuditStat = Convert.ToString(dr["AR_AuditStat"]);
            if (dr["AR_Stat"] != DBNull.Value) accident_Record.AR_Stat = Convert.ToString(dr["AR_Stat"]);
            if (dr["AR_Remark"] != DBNull.Value) accident_Record.AR_Remark = Convert.ToString(dr["AR_Remark"]);
            if (dr["Stat"] != DBNull.Value) accident_Record.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["CreateDate"] != DBNull.Value) accident_Record.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
            if (dr["UpdateDate"] != DBNull.Value) accident_Record.UpdateDate = Convert.ToDateTime(dr["UpdateDate"]);
            if (dr["DeleteDate"] != DBNull.Value) accident_Record.DeleteDate = Convert.ToDateTime(dr["DeleteDate"]);
            ret.Add(accident_Record);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   }  
         return ret;
      }
      /// <summary>
      /// 获取所有的事故调查报告 Accident_Record对象(即:一条记录
      /// </summary>
      public List<Accident_Record> GetAll()
      {
         List<Accident_Record> ret = new List<Accident_Record>();
         string sql = "SELECT  AR_ID,AR_Code,AR_Type,AR_Date,AR_CheckDate,AR_Injurer,AR_Content,AR_MainReason,AR_Reason,AR_Identification,AR_Rectification,AR_RectificationDate,AR_RectificationPerson,AR_RectificationContent,AR_Duty,AR_DutyDept,AR_iType,AR_AuditStat,AR_Stat,AR_Remark,Stat,CreateDate,UpdateDate,DeleteDate FROM Accident_Record where 1=1 AND ((Stat is null) or (Stat=0) ) order by AR_ID desc ";
          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            Accident_Record accident_Record = new Accident_Record();
            if (dr["AR_ID"] != DBNull.Value) accident_Record.AR_ID = Convert.ToDecimal(dr["AR_ID"]);
            if (dr["AR_Code"] != DBNull.Value) accident_Record.AR_Code = Convert.ToString(dr["AR_Code"]);
            if (dr["AR_Type"] != DBNull.Value) accident_Record.AR_Type = Convert.ToString(dr["AR_Type"]);
            if (dr["AR_Date"] != DBNull.Value) accident_Record.AR_Date = Convert.ToDateTime(dr["AR_Date"]);
            if (dr["AR_CheckDate"] != DBNull.Value) accident_Record.AR_CheckDate = Convert.ToDateTime(dr["AR_CheckDate"]);
            if (dr["AR_Injurer"] != DBNull.Value) accident_Record.AR_Injurer = Convert.ToString(dr["AR_Injurer"]);
            if (dr["AR_Content"] != DBNull.Value) accident_Record.AR_Content = Convert.ToString(dr["AR_Content"]);
            if (dr["AR_MainReason"] != DBNull.Value) accident_Record.AR_MainReason = Convert.ToString(dr["AR_MainReason"]);
            if (dr["AR_Reason"] != DBNull.Value) accident_Record.AR_Reason = Convert.ToString(dr["AR_Reason"]);
            if (dr["AR_Identification"] != DBNull.Value) accident_Record.AR_Identification = Convert.ToString(dr["AR_Identification"]);
            if (dr["AR_Rectification"] != DBNull.Value) accident_Record.AR_Rectification = Convert.ToString(dr["AR_Rectification"]);
            if (dr["AR_RectificationDate"] != DBNull.Value) accident_Record.AR_RectificationDate = Convert.ToDateTime(dr["AR_RectificationDate"]);
            if (dr["AR_RectificationPerson"] != DBNull.Value) accident_Record.AR_RectificationPerson = Convert.ToString(dr["AR_RectificationPerson"]);
            if (dr["AR_RectificationContent"] != DBNull.Value) accident_Record.AR_RectificationContent = Convert.ToString(dr["AR_RectificationContent"]);
            if (dr["AR_Duty"] != DBNull.Value) accident_Record.AR_Duty = Convert.ToString(dr["AR_Duty"]);
            if (dr["AR_DutyDept"] != DBNull.Value) accident_Record.AR_DutyDept = Convert.ToString(dr["AR_DutyDept"]);
            if (dr["AR_iType"] != DBNull.Value) accident_Record.AR_iType = Convert.ToString(dr["AR_iType"]);
            if (dr["AR_AuditStat"] != DBNull.Value) accident_Record.AR_AuditStat = Convert.ToString(dr["AR_AuditStat"]);
            if (dr["AR_Stat"] != DBNull.Value) accident_Record.AR_Stat = Convert.ToString(dr["AR_Stat"]);
            if (dr["AR_Remark"] != DBNull.Value) accident_Record.AR_Remark = Convert.ToString(dr["AR_Remark"]);
            if (dr["Stat"] != DBNull.Value) accident_Record.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["CreateDate"] != DBNull.Value) accident_Record.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
            if (dr["UpdateDate"] != DBNull.Value) accident_Record.UpdateDate = Convert.ToDateTime(dr["UpdateDate"]);
            if (dr["DeleteDate"] != DBNull.Value) accident_Record.DeleteDate = Convert.ToDateTime(dr["DeleteDate"]);
            ret.Add(accident_Record);
         }
          }catch (System.Exception ex){ throw ex; }  finally {  if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   } 
         return ret;
      }
   }
}
