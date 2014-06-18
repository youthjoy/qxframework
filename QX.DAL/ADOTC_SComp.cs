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
   /// 标准配合比信息
   /// </summary>
   [Serializable]
   public partial class ADOTC_SComp
   {
      public IDBOperator idb =  DBOperator.GetInstance();
      /// <summary>
      /// 添加标准配合比信息 TC_SComp对象(即:一条记录)
      /// </summary>
      public int Add(TC_SComp tC_SComp)
      {
         string sql = "INSERT INTO TC_SComp (TCS_Code,TCS_Lev,TCS_IMLEVEL,TCS_Idt,TCS_Start,TCS_End,TCS_Weight,TCS_Status,TCS_iType,TCS_Version,AuditStat,AuditCurAudit,Stat,CreateDate,UpdateDate,DeleteDate,TCS_RefType,TCS_RefCode,TCS_Udef1,TCS_Udef2,TCS_Udef3) VALUES (@TCS_Code,@TCS_Lev,@TCS_IMLEVEL,@TCS_Idt,@TCS_Start,@TCS_End,@TCS_Weight,@TCS_Status,@TCS_iType,@TCS_Version,@AuditStat,@AuditCurAudit,@Stat,@CreateDate,@UpdateDate,@DeleteDate,@TCS_RefType,@TCS_RefCode,@TCS_Udef1,@TCS_Udef2,@TCS_Udef3)";
         if (string.IsNullOrEmpty(tC_SComp.TCS_Code))
         {
            idb.AddParameter("@TCS_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TCS_Code", tC_SComp.TCS_Code);
         }
         if (string.IsNullOrEmpty(tC_SComp.TCS_Lev))
         {
            idb.AddParameter("@TCS_Lev", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TCS_Lev", tC_SComp.TCS_Lev);
         }
         if (string.IsNullOrEmpty(tC_SComp.TCS_IMLEVEL))
         {
            idb.AddParameter("@TCS_IMLEVEL", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TCS_IMLEVEL", tC_SComp.TCS_IMLEVEL);
         }
         if (string.IsNullOrEmpty(tC_SComp.TCS_Idt))
         {
            idb.AddParameter("@TCS_Idt", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TCS_Idt", tC_SComp.TCS_Idt);
         }
         if (tC_SComp.TCS_Start == DateTime.MinValue)
         {
            idb.AddParameter("@TCS_Start", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TCS_Start", tC_SComp.TCS_Start);
         }
         if (tC_SComp.TCS_End == DateTime.MinValue)
         {
            idb.AddParameter("@TCS_End", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TCS_End", tC_SComp.TCS_End);
         }
         if (tC_SComp.TCS_Weight == 0)
         {
            idb.AddParameter("@TCS_Weight", 0);
         }
         else
         {
            idb.AddParameter("@TCS_Weight", tC_SComp.TCS_Weight);
         }
         if (string.IsNullOrEmpty(tC_SComp.TCS_Status))
         {
            idb.AddParameter("@TCS_Status", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TCS_Status", tC_SComp.TCS_Status);
         }
         if (string.IsNullOrEmpty(tC_SComp.TCS_iType))
         {
            idb.AddParameter("@TCS_iType", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TCS_iType", tC_SComp.TCS_iType);
         }
         if (tC_SComp.TCS_Version == 0)
         {
            idb.AddParameter("@TCS_Version", 0);
         }
         else
         {
            idb.AddParameter("@TCS_Version", tC_SComp.TCS_Version);
         }
         if (string.IsNullOrEmpty(tC_SComp.AuditStat))
         {
            idb.AddParameter("@AuditStat", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AuditStat", tC_SComp.AuditStat);
         }
         if (string.IsNullOrEmpty(tC_SComp.AuditCurAudit))
         {
            idb.AddParameter("@AuditCurAudit", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AuditCurAudit", tC_SComp.AuditCurAudit);
         }
         if (tC_SComp.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", tC_SComp.Stat);
         }
         if (tC_SComp.CreateDate == DateTime.MinValue)
         {
            idb.AddParameter("@CreateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateDate", tC_SComp.CreateDate);
         }
         if (tC_SComp.UpdateDate == DateTime.MinValue)
         {
            idb.AddParameter("@UpdateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@UpdateDate", tC_SComp.UpdateDate);
         }
         if (tC_SComp.DeleteDate == DateTime.MinValue)
         {
            idb.AddParameter("@DeleteDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DeleteDate", tC_SComp.DeleteDate);
         }
         if (string.IsNullOrEmpty(tC_SComp.TCS_RefType))
         {
            idb.AddParameter("@TCS_RefType", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TCS_RefType", tC_SComp.TCS_RefType);
         }
         if (string.IsNullOrEmpty(tC_SComp.TCS_RefCode))
         {
            idb.AddParameter("@TCS_RefCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TCS_RefCode", tC_SComp.TCS_RefCode);
         }
         if (string.IsNullOrEmpty(tC_SComp.TCS_Udef1))
         {
            idb.AddParameter("@TCS_Udef1", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TCS_Udef1", tC_SComp.TCS_Udef1);
         }
         if (string.IsNullOrEmpty(tC_SComp.TCS_Udef2))
         {
            idb.AddParameter("@TCS_Udef2", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TCS_Udef2", tC_SComp.TCS_Udef2);
         }
         if (string.IsNullOrEmpty(tC_SComp.TCS_Udef3))
         {
            idb.AddParameter("@TCS_Udef3", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TCS_Udef3", tC_SComp.TCS_Udef3);
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
      /// 添加标准配合比信息 TC_SComp对象(即:一条记录)
      /// </summary>
      public object AddWithReturn(TC_SComp tC_SComp)
      {
         string sql = "INSERT INTO TC_SComp (TCS_Code,TCS_Lev,TCS_IMLEVEL,TCS_Idt,TCS_Start,TCS_End,TCS_Weight,TCS_Status,TCS_iType,TCS_Version,AuditStat,AuditCurAudit,Stat,CreateDate,UpdateDate,DeleteDate,TCS_RefType,TCS_RefCode,TCS_Udef1,TCS_Udef2,TCS_Udef3) VALUES (@TCS_Code,@TCS_Lev,@TCS_IMLEVEL,@TCS_Idt,@TCS_Start,@TCS_End,@TCS_Weight,@TCS_Status,@TCS_iType,@TCS_Version,@AuditStat,@AuditCurAudit,@Stat,@CreateDate,@UpdateDate,@DeleteDate,@TCS_RefType,@TCS_RefCode,@TCS_Udef1,@TCS_Udef2,@TCS_Udef3);SELECT @@IDENTITY AS ReturnID;";
         if (string.IsNullOrEmpty(tC_SComp.TCS_Code))
         {
            idb.AddParameter("@TCS_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TCS_Code", tC_SComp.TCS_Code);
         }
         if (string.IsNullOrEmpty(tC_SComp.TCS_Lev))
         {
            idb.AddParameter("@TCS_Lev", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TCS_Lev", tC_SComp.TCS_Lev);
         }
         if (string.IsNullOrEmpty(tC_SComp.TCS_IMLEVEL))
         {
            idb.AddParameter("@TCS_IMLEVEL", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TCS_IMLEVEL", tC_SComp.TCS_IMLEVEL);
         }
         if (string.IsNullOrEmpty(tC_SComp.TCS_Idt))
         {
            idb.AddParameter("@TCS_Idt", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TCS_Idt", tC_SComp.TCS_Idt);
         }
         if (tC_SComp.TCS_Start == DateTime.MinValue)
         {
            idb.AddParameter("@TCS_Start", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TCS_Start", tC_SComp.TCS_Start);
         }
         if (tC_SComp.TCS_End == DateTime.MinValue)
         {
            idb.AddParameter("@TCS_End", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TCS_End", tC_SComp.TCS_End);
         }
         if (tC_SComp.TCS_Weight == 0)
         {
            idb.AddParameter("@TCS_Weight", 0);
         }
         else
         {
            idb.AddParameter("@TCS_Weight", tC_SComp.TCS_Weight);
         }
         if (string.IsNullOrEmpty(tC_SComp.TCS_Status))
         {
            idb.AddParameter("@TCS_Status", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TCS_Status", tC_SComp.TCS_Status);
         }
         if (string.IsNullOrEmpty(tC_SComp.TCS_iType))
         {
            idb.AddParameter("@TCS_iType", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TCS_iType", tC_SComp.TCS_iType);
         }
         if (tC_SComp.TCS_Version == 0)
         {
            idb.AddParameter("@TCS_Version", 0);
         }
         else
         {
            idb.AddParameter("@TCS_Version", tC_SComp.TCS_Version);
         }
         if (string.IsNullOrEmpty(tC_SComp.AuditStat))
         {
            idb.AddParameter("@AuditStat", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AuditStat", tC_SComp.AuditStat);
         }
         if (string.IsNullOrEmpty(tC_SComp.AuditCurAudit))
         {
            idb.AddParameter("@AuditCurAudit", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AuditCurAudit", tC_SComp.AuditCurAudit);
         }
         if (tC_SComp.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", tC_SComp.Stat);
         }
         if (tC_SComp.CreateDate == DateTime.MinValue)
         {
            idb.AddParameter("@CreateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateDate", tC_SComp.CreateDate);
         }
         if (tC_SComp.UpdateDate == DateTime.MinValue)
         {
            idb.AddParameter("@UpdateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@UpdateDate", tC_SComp.UpdateDate);
         }
         if (tC_SComp.DeleteDate == DateTime.MinValue)
         {
            idb.AddParameter("@DeleteDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DeleteDate", tC_SComp.DeleteDate);
         }
         if (string.IsNullOrEmpty(tC_SComp.TCS_RefType))
         {
            idb.AddParameter("@TCS_RefType", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TCS_RefType", tC_SComp.TCS_RefType);
         }
         if (string.IsNullOrEmpty(tC_SComp.TCS_RefCode))
         {
            idb.AddParameter("@TCS_RefCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TCS_RefCode", tC_SComp.TCS_RefCode);
         }
         if (string.IsNullOrEmpty(tC_SComp.TCS_Udef1))
         {
            idb.AddParameter("@TCS_Udef1", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TCS_Udef1", tC_SComp.TCS_Udef1);
         }
         if (string.IsNullOrEmpty(tC_SComp.TCS_Udef2))
         {
            idb.AddParameter("@TCS_Udef2", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TCS_Udef2", tC_SComp.TCS_Udef2);
         }
         if (string.IsNullOrEmpty(tC_SComp.TCS_Udef3))
         {
            idb.AddParameter("@TCS_Udef3", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TCS_Udef3", tC_SComp.TCS_Udef3);
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
      /// 更新标准配合比信息 TC_SComp对象(即:一条记录
      /// </summary>
      public int Update(TC_SComp tC_SComp)
      {
         
         StringBuilder sbParameter=new StringBuilder();
      StringBuilder sb=new StringBuilder();
      sb.Append(@"UPDATE       TC_SComp       SET ");
            if(tC_SComp.TCS_Code_IsChanged){sbParameter.Append("TCS_Code=@TCS_Code, ");}
      if(tC_SComp.TCS_Lev_IsChanged){sbParameter.Append("TCS_Lev=@TCS_Lev, ");}
      if(tC_SComp.TCS_IMLEVEL_IsChanged){sbParameter.Append("TCS_IMLEVEL=@TCS_IMLEVEL, ");}
      if(tC_SComp.TCS_Idt_IsChanged){sbParameter.Append("TCS_Idt=@TCS_Idt, ");}
      if(tC_SComp.TCS_Start_IsChanged){sbParameter.Append("TCS_Start=@TCS_Start, ");}
      if(tC_SComp.TCS_End_IsChanged){sbParameter.Append("TCS_End=@TCS_End, ");}
      if(tC_SComp.TCS_Weight_IsChanged){sbParameter.Append("TCS_Weight=@TCS_Weight, ");}
      if(tC_SComp.TCS_Status_IsChanged){sbParameter.Append("TCS_Status=@TCS_Status, ");}
      if(tC_SComp.TCS_iType_IsChanged){sbParameter.Append("TCS_iType=@TCS_iType, ");}
      if(tC_SComp.TCS_Version_IsChanged){sbParameter.Append("TCS_Version=@TCS_Version, ");}
      if(tC_SComp.AuditStat_IsChanged){sbParameter.Append("AuditStat=@AuditStat, ");}
      if(tC_SComp.AuditCurAudit_IsChanged){sbParameter.Append("AuditCurAudit=@AuditCurAudit, ");}
      if(tC_SComp.Stat_IsChanged){sbParameter.Append("Stat=@Stat, ");}
      if(tC_SComp.CreateDate_IsChanged){sbParameter.Append("CreateDate=@CreateDate, ");}
      if(tC_SComp.UpdateDate_IsChanged){sbParameter.Append("UpdateDate=@UpdateDate, ");}
      if(tC_SComp.DeleteDate_IsChanged){sbParameter.Append("DeleteDate=@DeleteDate, ");}
      if(tC_SComp.TCS_RefType_IsChanged){sbParameter.Append("TCS_RefType=@TCS_RefType, ");}
      if(tC_SComp.TCS_RefCode_IsChanged){sbParameter.Append("TCS_RefCode=@TCS_RefCode, ");}
      if(tC_SComp.TCS_Udef1_IsChanged){sbParameter.Append("TCS_Udef1=@TCS_Udef1, ");}
      if(tC_SComp.TCS_Udef2_IsChanged){sbParameter.Append("TCS_Udef2=@TCS_Udef2, ");}
      if(tC_SComp.TCS_Udef3_IsChanged){sbParameter.Append("TCS_Udef3=@TCS_Udef3 ");}          sb.Append(sbParameter.ToString().Trim().TrimEnd(',')); 
      sb.Append(      " WHERE 1=1 AND ((Stat is null) or (Stat=0))   and TCS_ID=@TCS_ID; " );
      string sql=sb.ToString();
         if(tC_SComp.TCS_Code_IsChanged)
         {
         if (string.IsNullOrEmpty(tC_SComp.TCS_Code))
         {
            idb.AddParameter("@TCS_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TCS_Code", tC_SComp.TCS_Code);
         }
          }
         if(tC_SComp.TCS_Lev_IsChanged)
         {
         if (string.IsNullOrEmpty(tC_SComp.TCS_Lev))
         {
            idb.AddParameter("@TCS_Lev", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TCS_Lev", tC_SComp.TCS_Lev);
         }
          }
         if(tC_SComp.TCS_IMLEVEL_IsChanged)
         {
         if (string.IsNullOrEmpty(tC_SComp.TCS_IMLEVEL))
         {
            idb.AddParameter("@TCS_IMLEVEL", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TCS_IMLEVEL", tC_SComp.TCS_IMLEVEL);
         }
          }
         if(tC_SComp.TCS_Idt_IsChanged)
         {
         if (string.IsNullOrEmpty(tC_SComp.TCS_Idt))
         {
            idb.AddParameter("@TCS_Idt", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TCS_Idt", tC_SComp.TCS_Idt);
         }
          }
         if(tC_SComp.TCS_Start_IsChanged)
         {
         if (tC_SComp.TCS_Start == DateTime.MinValue)
         {
            idb.AddParameter("@TCS_Start", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TCS_Start", tC_SComp.TCS_Start);
         }
          }
         if(tC_SComp.TCS_End_IsChanged)
         {
         if (tC_SComp.TCS_End == DateTime.MinValue)
         {
            idb.AddParameter("@TCS_End", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TCS_End", tC_SComp.TCS_End);
         }
          }
         if(tC_SComp.TCS_Weight_IsChanged)
         {
         if (tC_SComp.TCS_Weight == 0)
         {
            idb.AddParameter("@TCS_Weight", 0);
         }
         else
         {
            idb.AddParameter("@TCS_Weight", tC_SComp.TCS_Weight);
         }
          }
         if(tC_SComp.TCS_Status_IsChanged)
         {
         if (string.IsNullOrEmpty(tC_SComp.TCS_Status))
         {
            idb.AddParameter("@TCS_Status", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TCS_Status", tC_SComp.TCS_Status);
         }
          }
         if(tC_SComp.TCS_iType_IsChanged)
         {
         if (string.IsNullOrEmpty(tC_SComp.TCS_iType))
         {
            idb.AddParameter("@TCS_iType", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TCS_iType", tC_SComp.TCS_iType);
         }
          }
         if(tC_SComp.TCS_Version_IsChanged)
         {
         if (tC_SComp.TCS_Version == 0)
         {
            idb.AddParameter("@TCS_Version", 0);
         }
         else
         {
            idb.AddParameter("@TCS_Version", tC_SComp.TCS_Version);
         }
          }
         if(tC_SComp.AuditStat_IsChanged)
         {
         if (string.IsNullOrEmpty(tC_SComp.AuditStat))
         {
            idb.AddParameter("@AuditStat", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AuditStat", tC_SComp.AuditStat);
         }
          }
         if(tC_SComp.AuditCurAudit_IsChanged)
         {
         if (string.IsNullOrEmpty(tC_SComp.AuditCurAudit))
         {
            idb.AddParameter("@AuditCurAudit", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AuditCurAudit", tC_SComp.AuditCurAudit);
         }
          }
         if(tC_SComp.Stat_IsChanged)
         {
         if (tC_SComp.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", tC_SComp.Stat);
         }
          }
         if(tC_SComp.CreateDate_IsChanged)
         {
         if (tC_SComp.CreateDate == DateTime.MinValue)
         {
            idb.AddParameter("@CreateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateDate", tC_SComp.CreateDate);
         }
          }
         if(tC_SComp.UpdateDate_IsChanged)
         {
         if (tC_SComp.UpdateDate == DateTime.MinValue)
         {
            idb.AddParameter("@UpdateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@UpdateDate", tC_SComp.UpdateDate);
         }
          }
         if(tC_SComp.DeleteDate_IsChanged)
         {
         if (tC_SComp.DeleteDate == DateTime.MinValue)
         {
            idb.AddParameter("@DeleteDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DeleteDate", tC_SComp.DeleteDate);
         }
          }
         if(tC_SComp.TCS_RefType_IsChanged)
         {
         if (string.IsNullOrEmpty(tC_SComp.TCS_RefType))
         {
            idb.AddParameter("@TCS_RefType", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TCS_RefType", tC_SComp.TCS_RefType);
         }
          }
         if(tC_SComp.TCS_RefCode_IsChanged)
         {
         if (string.IsNullOrEmpty(tC_SComp.TCS_RefCode))
         {
            idb.AddParameter("@TCS_RefCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TCS_RefCode", tC_SComp.TCS_RefCode);
         }
          }
         if(tC_SComp.TCS_Udef1_IsChanged)
         {
         if (string.IsNullOrEmpty(tC_SComp.TCS_Udef1))
         {
            idb.AddParameter("@TCS_Udef1", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TCS_Udef1", tC_SComp.TCS_Udef1);
         }
          }
         if(tC_SComp.TCS_Udef2_IsChanged)
         {
         if (string.IsNullOrEmpty(tC_SComp.TCS_Udef2))
         {
            idb.AddParameter("@TCS_Udef2", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TCS_Udef2", tC_SComp.TCS_Udef2);
         }
          }
         if(tC_SComp.TCS_Udef3_IsChanged)
         {
         if (string.IsNullOrEmpty(tC_SComp.TCS_Udef3))
         {
            idb.AddParameter("@TCS_Udef3", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TCS_Udef3", tC_SComp.TCS_Udef3);
         }
          }

         idb.AddParameter("@TCS_ID", tC_SComp.TCS_ID);

           
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
      /// 删除标准配合比信息 TC_SComp对象(即:一条记录
      /// </summary>
      public int Delete(decimal tCS_ID)
      {
         string sql = "DELETE TC_SComp WHERE 1=1  AND TCS_ID=@TCS_ID ";
         idb.AddParameter("@TCS_ID", tCS_ID);

           
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
      /// 获取指定的标准配合比信息 TC_SComp对象(即:一条记录
      /// </summary>
      public TC_SComp GetByKey(decimal tCS_ID)
      {
         TC_SComp tC_SComp = new TC_SComp();
         string sql = "SELECT  TCS_ID,TCS_Code,TCS_Lev,TCS_IMLEVEL,TCS_Idt,TCS_Start,TCS_End,TCS_Weight,TCS_Status,TCS_iType,TCS_Version,AuditStat,AuditCurAudit,Stat,CreateDate,UpdateDate,DeleteDate,TCS_RefType,TCS_RefCode,TCS_Udef1,TCS_Udef2,TCS_Udef3 FROM TC_SComp WHERE 1=1 AND ((Stat is null) or (Stat=0) )  AND TCS_ID=@TCS_ID ";
         idb.AddParameter("@TCS_ID", tCS_ID);

          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            if (dr["TCS_ID"] != DBNull.Value) tC_SComp.TCS_ID = Convert.ToDecimal(dr["TCS_ID"]);
            if (dr["TCS_Code"] != DBNull.Value) tC_SComp.TCS_Code = Convert.ToString(dr["TCS_Code"]);
            if (dr["TCS_Lev"] != DBNull.Value) tC_SComp.TCS_Lev = Convert.ToString(dr["TCS_Lev"]);
            if (dr["TCS_IMLEVEL"] != DBNull.Value) tC_SComp.TCS_IMLEVEL = Convert.ToString(dr["TCS_IMLEVEL"]);
            if (dr["TCS_Idt"] != DBNull.Value) tC_SComp.TCS_Idt = Convert.ToString(dr["TCS_Idt"]);
            if (dr["TCS_Start"] != DBNull.Value) tC_SComp.TCS_Start = Convert.ToDateTime(dr["TCS_Start"]);
            if (dr["TCS_End"] != DBNull.Value) tC_SComp.TCS_End = Convert.ToDateTime(dr["TCS_End"]);
            if (dr["TCS_Weight"] != DBNull.Value) tC_SComp.TCS_Weight = Convert.ToDecimal(dr["TCS_Weight"]);
            if (dr["TCS_Status"] != DBNull.Value) tC_SComp.TCS_Status = Convert.ToString(dr["TCS_Status"]);
            if (dr["TCS_iType"] != DBNull.Value) tC_SComp.TCS_iType = Convert.ToString(dr["TCS_iType"]);
            if (dr["TCS_Version"] != DBNull.Value) tC_SComp.TCS_Version = Convert.ToInt32(dr["TCS_Version"]);
            if (dr["AuditStat"] != DBNull.Value) tC_SComp.AuditStat = Convert.ToString(dr["AuditStat"]);
            if (dr["AuditCurAudit"] != DBNull.Value) tC_SComp.AuditCurAudit = Convert.ToString(dr["AuditCurAudit"]);
            if (dr["Stat"] != DBNull.Value) tC_SComp.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["CreateDate"] != DBNull.Value) tC_SComp.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
            if (dr["UpdateDate"] != DBNull.Value) tC_SComp.UpdateDate = Convert.ToDateTime(dr["UpdateDate"]);
            if (dr["DeleteDate"] != DBNull.Value) tC_SComp.DeleteDate = Convert.ToDateTime(dr["DeleteDate"]);
            if (dr["TCS_RefType"] != DBNull.Value) tC_SComp.TCS_RefType = Convert.ToString(dr["TCS_RefType"]);
            if (dr["TCS_RefCode"] != DBNull.Value) tC_SComp.TCS_RefCode = Convert.ToString(dr["TCS_RefCode"]);
            if (dr["TCS_Udef1"] != DBNull.Value) tC_SComp.TCS_Udef1 = Convert.ToString(dr["TCS_Udef1"]);
            if (dr["TCS_Udef2"] != DBNull.Value) tC_SComp.TCS_Udef2 = Convert.ToString(dr["TCS_Udef2"]);
            if (dr["TCS_Udef3"] != DBNull.Value) tC_SComp.TCS_Udef3 = Convert.ToString(dr["TCS_Udef3"]);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   }  
         return tC_SComp;
      }
      /// <summary>
      /// 获取指定的标准配合比信息 TC_SComp对象集合
      /// </summary>
      public List<TC_SComp> GetListByWhere(string strCondition)
      {
         List<TC_SComp> ret = new List<TC_SComp>();
         string sql = "SELECT  TCS_ID,TCS_Code,TCS_Lev,TCS_IMLEVEL,TCS_Idt,TCS_Start,TCS_End,TCS_Weight,TCS_Status,TCS_iType,TCS_Version,AuditStat,AuditCurAudit,Stat,CreateDate,UpdateDate,DeleteDate,TCS_RefType,TCS_RefCode,TCS_Udef1,TCS_Udef2,TCS_Udef3 FROM TC_SComp WHERE 1=1 AND ((Stat is null) or (Stat=0) ) ";
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
            TC_SComp tC_SComp = new TC_SComp();
            if (dr["TCS_ID"] != DBNull.Value) tC_SComp.TCS_ID = Convert.ToDecimal(dr["TCS_ID"]);
            if (dr["TCS_Code"] != DBNull.Value) tC_SComp.TCS_Code = Convert.ToString(dr["TCS_Code"]);
            if (dr["TCS_Lev"] != DBNull.Value) tC_SComp.TCS_Lev = Convert.ToString(dr["TCS_Lev"]);
            if (dr["TCS_IMLEVEL"] != DBNull.Value) tC_SComp.TCS_IMLEVEL = Convert.ToString(dr["TCS_IMLEVEL"]);
            if (dr["TCS_Idt"] != DBNull.Value) tC_SComp.TCS_Idt = Convert.ToString(dr["TCS_Idt"]);
            if (dr["TCS_Start"] != DBNull.Value) tC_SComp.TCS_Start = Convert.ToDateTime(dr["TCS_Start"]);
            if (dr["TCS_End"] != DBNull.Value) tC_SComp.TCS_End = Convert.ToDateTime(dr["TCS_End"]);
            if (dr["TCS_Weight"] != DBNull.Value) tC_SComp.TCS_Weight = Convert.ToDecimal(dr["TCS_Weight"]);
            if (dr["TCS_Status"] != DBNull.Value) tC_SComp.TCS_Status = Convert.ToString(dr["TCS_Status"]);
            if (dr["TCS_iType"] != DBNull.Value) tC_SComp.TCS_iType = Convert.ToString(dr["TCS_iType"]);
            if (dr["TCS_Version"] != DBNull.Value) tC_SComp.TCS_Version = Convert.ToInt32(dr["TCS_Version"]);
            if (dr["AuditStat"] != DBNull.Value) tC_SComp.AuditStat = Convert.ToString(dr["AuditStat"]);
            if (dr["AuditCurAudit"] != DBNull.Value) tC_SComp.AuditCurAudit = Convert.ToString(dr["AuditCurAudit"]);
            if (dr["Stat"] != DBNull.Value) tC_SComp.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["CreateDate"] != DBNull.Value) tC_SComp.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
            if (dr["UpdateDate"] != DBNull.Value) tC_SComp.UpdateDate = Convert.ToDateTime(dr["UpdateDate"]);
            if (dr["DeleteDate"] != DBNull.Value) tC_SComp.DeleteDate = Convert.ToDateTime(dr["DeleteDate"]);
            if (dr["TCS_RefType"] != DBNull.Value) tC_SComp.TCS_RefType = Convert.ToString(dr["TCS_RefType"]);
            if (dr["TCS_RefCode"] != DBNull.Value) tC_SComp.TCS_RefCode = Convert.ToString(dr["TCS_RefCode"]);
            if (dr["TCS_Udef1"] != DBNull.Value) tC_SComp.TCS_Udef1 = Convert.ToString(dr["TCS_Udef1"]);
            if (dr["TCS_Udef2"] != DBNull.Value) tC_SComp.TCS_Udef2 = Convert.ToString(dr["TCS_Udef2"]);
            if (dr["TCS_Udef3"] != DBNull.Value) tC_SComp.TCS_Udef3 = Convert.ToString(dr["TCS_Udef3"]);
            ret.Add(tC_SComp);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   }  
         return ret;
      }
      /// <summary>
      /// 获取所有的标准配合比信息 TC_SComp对象(即:一条记录
      /// </summary>
      public List<TC_SComp> GetAll()
      {
         List<TC_SComp> ret = new List<TC_SComp>();
         string sql = "SELECT  TCS_ID,TCS_Code,TCS_Lev,TCS_IMLEVEL,TCS_Idt,TCS_Start,TCS_End,TCS_Weight,TCS_Status,TCS_iType,TCS_Version,AuditStat,AuditCurAudit,Stat,CreateDate,UpdateDate,DeleteDate,TCS_RefType,TCS_RefCode,TCS_Udef1,TCS_Udef2,TCS_Udef3 FROM TC_SComp where 1=1 AND ((Stat is null) or (Stat=0) ) order by TCS_ID desc ";
          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            TC_SComp tC_SComp = new TC_SComp();
            if (dr["TCS_ID"] != DBNull.Value) tC_SComp.TCS_ID = Convert.ToDecimal(dr["TCS_ID"]);
            if (dr["TCS_Code"] != DBNull.Value) tC_SComp.TCS_Code = Convert.ToString(dr["TCS_Code"]);
            if (dr["TCS_Lev"] != DBNull.Value) tC_SComp.TCS_Lev = Convert.ToString(dr["TCS_Lev"]);
            if (dr["TCS_IMLEVEL"] != DBNull.Value) tC_SComp.TCS_IMLEVEL = Convert.ToString(dr["TCS_IMLEVEL"]);
            if (dr["TCS_Idt"] != DBNull.Value) tC_SComp.TCS_Idt = Convert.ToString(dr["TCS_Idt"]);
            if (dr["TCS_Start"] != DBNull.Value) tC_SComp.TCS_Start = Convert.ToDateTime(dr["TCS_Start"]);
            if (dr["TCS_End"] != DBNull.Value) tC_SComp.TCS_End = Convert.ToDateTime(dr["TCS_End"]);
            if (dr["TCS_Weight"] != DBNull.Value) tC_SComp.TCS_Weight = Convert.ToDecimal(dr["TCS_Weight"]);
            if (dr["TCS_Status"] != DBNull.Value) tC_SComp.TCS_Status = Convert.ToString(dr["TCS_Status"]);
            if (dr["TCS_iType"] != DBNull.Value) tC_SComp.TCS_iType = Convert.ToString(dr["TCS_iType"]);
            if (dr["TCS_Version"] != DBNull.Value) tC_SComp.TCS_Version = Convert.ToInt32(dr["TCS_Version"]);
            if (dr["AuditStat"] != DBNull.Value) tC_SComp.AuditStat = Convert.ToString(dr["AuditStat"]);
            if (dr["AuditCurAudit"] != DBNull.Value) tC_SComp.AuditCurAudit = Convert.ToString(dr["AuditCurAudit"]);
            if (dr["Stat"] != DBNull.Value) tC_SComp.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["CreateDate"] != DBNull.Value) tC_SComp.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
            if (dr["UpdateDate"] != DBNull.Value) tC_SComp.UpdateDate = Convert.ToDateTime(dr["UpdateDate"]);
            if (dr["DeleteDate"] != DBNull.Value) tC_SComp.DeleteDate = Convert.ToDateTime(dr["DeleteDate"]);
            if (dr["TCS_RefType"] != DBNull.Value) tC_SComp.TCS_RefType = Convert.ToString(dr["TCS_RefType"]);
            if (dr["TCS_RefCode"] != DBNull.Value) tC_SComp.TCS_RefCode = Convert.ToString(dr["TCS_RefCode"]);
            if (dr["TCS_Udef1"] != DBNull.Value) tC_SComp.TCS_Udef1 = Convert.ToString(dr["TCS_Udef1"]);
            if (dr["TCS_Udef2"] != DBNull.Value) tC_SComp.TCS_Udef2 = Convert.ToString(dr["TCS_Udef2"]);
            if (dr["TCS_Udef3"] != DBNull.Value) tC_SComp.TCS_Udef3 = Convert.ToString(dr["TCS_Udef3"]);
            ret.Add(tC_SComp);
         }
          }catch (System.Exception ex){ throw ex; }  finally {  if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   } 
         return ret;
      }
   }
}
