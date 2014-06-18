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
   /// 生产配比信息
   /// </summary>
   [Serializable]
   public partial class ADOTC_PComp
   {
      public IDBOperator idb =  DBOperator.GetInstance();
      /// <summary>
      /// 添加生产配比信息 TC_PComp对象(即:一条记录)
      /// </summary>
      public int Add(TC_PComp tC_PComp)
      {
         string sql = "INSERT INTO TC_PComp (TCPC_Code,TCPC_Name,TCPC_Type,TCPC_Lev,TCPC_IMLEVEL,TCPC_Day,TCPC_Station,TCPC_Line,TCPC_PCode,TCPC_Owner,TCPC_Date,TCPC_IsCurrent,TCPC_RefSTCode,TCPC_RefType,TCPC_RefCode,TCPC_Weight,TCPC_ZDate,TCPC_JDate,AuditStat,AuditCurAudit,Stat,CreateDate,UpdateDate,DeleteDate,TCPC_Udef1,TCPC_Udef2,TCPC_Udef3) VALUES (@TCPC_Code,@TCPC_Name,@TCPC_Type,@TCPC_Lev,@TCPC_IMLEVEL,@TCPC_Day,@TCPC_Station,@TCPC_Line,@TCPC_PCode,@TCPC_Owner,@TCPC_Date,@TCPC_IsCurrent,@TCPC_RefSTCode,@TCPC_RefType,@TCPC_RefCode,@TCPC_Weight,@TCPC_ZDate,@TCPC_JDate,@AuditStat,@AuditCurAudit,@Stat,@CreateDate,@UpdateDate,@DeleteDate,@TCPC_Udef1,@TCPC_Udef2,@TCPC_Udef3)";
         if (string.IsNullOrEmpty(tC_PComp.TCPC_Code))
         {
            idb.AddParameter("@TCPC_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TCPC_Code", tC_PComp.TCPC_Code);
         }
         if (string.IsNullOrEmpty(tC_PComp.TCPC_Name))
         {
            idb.AddParameter("@TCPC_Name", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TCPC_Name", tC_PComp.TCPC_Name);
         }
         if (string.IsNullOrEmpty(tC_PComp.TCPC_Type))
         {
            idb.AddParameter("@TCPC_Type", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TCPC_Type", tC_PComp.TCPC_Type);
         }
         if (string.IsNullOrEmpty(tC_PComp.TCPC_Lev))
         {
            idb.AddParameter("@TCPC_Lev", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TCPC_Lev", tC_PComp.TCPC_Lev);
         }
         if (string.IsNullOrEmpty(tC_PComp.TCPC_IMLEVEL))
         {
            idb.AddParameter("@TCPC_IMLEVEL", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TCPC_IMLEVEL", tC_PComp.TCPC_IMLEVEL);
         }
         if (string.IsNullOrEmpty(tC_PComp.TCPC_Day))
         {
            idb.AddParameter("@TCPC_Day", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TCPC_Day", tC_PComp.TCPC_Day);
         }
         if (string.IsNullOrEmpty(tC_PComp.TCPC_Station))
         {
            idb.AddParameter("@TCPC_Station", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TCPC_Station", tC_PComp.TCPC_Station);
         }
         if (string.IsNullOrEmpty(tC_PComp.TCPC_Line))
         {
            idb.AddParameter("@TCPC_Line", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TCPC_Line", tC_PComp.TCPC_Line);
         }
         if (string.IsNullOrEmpty(tC_PComp.TCPC_PCode))
         {
            idb.AddParameter("@TCPC_PCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TCPC_PCode", tC_PComp.TCPC_PCode);
         }
         if (string.IsNullOrEmpty(tC_PComp.TCPC_Owner))
         {
            idb.AddParameter("@TCPC_Owner", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TCPC_Owner", tC_PComp.TCPC_Owner);
         }
         if (tC_PComp.TCPC_Date == DateTime.MinValue)
         {
            idb.AddParameter("@TCPC_Date", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TCPC_Date", tC_PComp.TCPC_Date);
         }
         if (tC_PComp.TCPC_IsCurrent == 0)
         {
            idb.AddParameter("@TCPC_IsCurrent", 0);
         }
         else
         {
            idb.AddParameter("@TCPC_IsCurrent", tC_PComp.TCPC_IsCurrent);
         }
         if (string.IsNullOrEmpty(tC_PComp.TCPC_RefSTCode))
         {
            idb.AddParameter("@TCPC_RefSTCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TCPC_RefSTCode", tC_PComp.TCPC_RefSTCode);
         }
         if (string.IsNullOrEmpty(tC_PComp.TCPC_RefType))
         {
            idb.AddParameter("@TCPC_RefType", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TCPC_RefType", tC_PComp.TCPC_RefType);
         }
         if (string.IsNullOrEmpty(tC_PComp.TCPC_RefCode))
         {
            idb.AddParameter("@TCPC_RefCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TCPC_RefCode", tC_PComp.TCPC_RefCode);
         }
         if (tC_PComp.TCPC_Weight == 0)
         {
            idb.AddParameter("@TCPC_Weight", 0);
         }
         else
         {
            idb.AddParameter("@TCPC_Weight", tC_PComp.TCPC_Weight);
         }
         if (tC_PComp.TCPC_ZDate == 0)
         {
            idb.AddParameter("@TCPC_ZDate", 0);
         }
         else
         {
            idb.AddParameter("@TCPC_ZDate", tC_PComp.TCPC_ZDate);
         }
         if (tC_PComp.TCPC_JDate == 0)
         {
            idb.AddParameter("@TCPC_JDate", 0);
         }
         else
         {
            idb.AddParameter("@TCPC_JDate", tC_PComp.TCPC_JDate);
         }
         if (string.IsNullOrEmpty(tC_PComp.AuditStat))
         {
            idb.AddParameter("@AuditStat", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AuditStat", tC_PComp.AuditStat);
         }
         if (string.IsNullOrEmpty(tC_PComp.AuditCurAudit))
         {
            idb.AddParameter("@AuditCurAudit", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AuditCurAudit", tC_PComp.AuditCurAudit);
         }
         if (tC_PComp.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", tC_PComp.Stat);
         }
         if (tC_PComp.CreateDate == DateTime.MinValue)
         {
            idb.AddParameter("@CreateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateDate", tC_PComp.CreateDate);
         }
         if (tC_PComp.UpdateDate == DateTime.MinValue)
         {
            idb.AddParameter("@UpdateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@UpdateDate", tC_PComp.UpdateDate);
         }
         if (tC_PComp.DeleteDate == DateTime.MinValue)
         {
            idb.AddParameter("@DeleteDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DeleteDate", tC_PComp.DeleteDate);
         }
         if (string.IsNullOrEmpty(tC_PComp.TCPC_Udef1))
         {
            idb.AddParameter("@TCPC_Udef1", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TCPC_Udef1", tC_PComp.TCPC_Udef1);
         }
         if (string.IsNullOrEmpty(tC_PComp.TCPC_Udef2))
         {
            idb.AddParameter("@TCPC_Udef2", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TCPC_Udef2", tC_PComp.TCPC_Udef2);
         }
         if (string.IsNullOrEmpty(tC_PComp.TCPC_Udef3))
         {
            idb.AddParameter("@TCPC_Udef3", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TCPC_Udef3", tC_PComp.TCPC_Udef3);
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
      /// 添加生产配比信息 TC_PComp对象(即:一条记录)
      /// </summary>
      public object AddWithReturn(TC_PComp tC_PComp)
      {
         string sql = "INSERT INTO TC_PComp (TCPC_Code,TCPC_Name,TCPC_Type,TCPC_Lev,TCPC_IMLEVEL,TCPC_Day,TCPC_Station,TCPC_Line,TCPC_PCode,TCPC_Owner,TCPC_Date,TCPC_IsCurrent,TCPC_RefSTCode,TCPC_RefType,TCPC_RefCode,TCPC_Weight,TCPC_ZDate,TCPC_JDate,AuditStat,AuditCurAudit,Stat,CreateDate,UpdateDate,DeleteDate,TCPC_Udef1,TCPC_Udef2,TCPC_Udef3) VALUES (@TCPC_Code,@TCPC_Name,@TCPC_Type,@TCPC_Lev,@TCPC_IMLEVEL,@TCPC_Day,@TCPC_Station,@TCPC_Line,@TCPC_PCode,@TCPC_Owner,@TCPC_Date,@TCPC_IsCurrent,@TCPC_RefSTCode,@TCPC_RefType,@TCPC_RefCode,@TCPC_Weight,@TCPC_ZDate,@TCPC_JDate,@AuditStat,@AuditCurAudit,@Stat,@CreateDate,@UpdateDate,@DeleteDate,@TCPC_Udef1,@TCPC_Udef2,@TCPC_Udef3);SELECT @@IDENTITY AS ReturnID;";
         if (string.IsNullOrEmpty(tC_PComp.TCPC_Code))
         {
            idb.AddParameter("@TCPC_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TCPC_Code", tC_PComp.TCPC_Code);
         }
         if (string.IsNullOrEmpty(tC_PComp.TCPC_Name))
         {
            idb.AddParameter("@TCPC_Name", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TCPC_Name", tC_PComp.TCPC_Name);
         }
         if (string.IsNullOrEmpty(tC_PComp.TCPC_Type))
         {
            idb.AddParameter("@TCPC_Type", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TCPC_Type", tC_PComp.TCPC_Type);
         }
         if (string.IsNullOrEmpty(tC_PComp.TCPC_Lev))
         {
            idb.AddParameter("@TCPC_Lev", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TCPC_Lev", tC_PComp.TCPC_Lev);
         }
         if (string.IsNullOrEmpty(tC_PComp.TCPC_IMLEVEL))
         {
            idb.AddParameter("@TCPC_IMLEVEL", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TCPC_IMLEVEL", tC_PComp.TCPC_IMLEVEL);
         }
         if (string.IsNullOrEmpty(tC_PComp.TCPC_Day))
         {
            idb.AddParameter("@TCPC_Day", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TCPC_Day", tC_PComp.TCPC_Day);
         }
         if (string.IsNullOrEmpty(tC_PComp.TCPC_Station))
         {
            idb.AddParameter("@TCPC_Station", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TCPC_Station", tC_PComp.TCPC_Station);
         }
         if (string.IsNullOrEmpty(tC_PComp.TCPC_Line))
         {
            idb.AddParameter("@TCPC_Line", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TCPC_Line", tC_PComp.TCPC_Line);
         }
         if (string.IsNullOrEmpty(tC_PComp.TCPC_PCode))
         {
            idb.AddParameter("@TCPC_PCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TCPC_PCode", tC_PComp.TCPC_PCode);
         }
         if (string.IsNullOrEmpty(tC_PComp.TCPC_Owner))
         {
            idb.AddParameter("@TCPC_Owner", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TCPC_Owner", tC_PComp.TCPC_Owner);
         }
         if (tC_PComp.TCPC_Date == DateTime.MinValue)
         {
            idb.AddParameter("@TCPC_Date", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TCPC_Date", tC_PComp.TCPC_Date);
         }
         if (tC_PComp.TCPC_IsCurrent == 0)
         {
            idb.AddParameter("@TCPC_IsCurrent", 0);
         }
         else
         {
            idb.AddParameter("@TCPC_IsCurrent", tC_PComp.TCPC_IsCurrent);
         }
         if (string.IsNullOrEmpty(tC_PComp.TCPC_RefSTCode))
         {
            idb.AddParameter("@TCPC_RefSTCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TCPC_RefSTCode", tC_PComp.TCPC_RefSTCode);
         }
         if (string.IsNullOrEmpty(tC_PComp.TCPC_RefType))
         {
            idb.AddParameter("@TCPC_RefType", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TCPC_RefType", tC_PComp.TCPC_RefType);
         }
         if (string.IsNullOrEmpty(tC_PComp.TCPC_RefCode))
         {
            idb.AddParameter("@TCPC_RefCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TCPC_RefCode", tC_PComp.TCPC_RefCode);
         }
         if (tC_PComp.TCPC_Weight == 0)
         {
            idb.AddParameter("@TCPC_Weight", 0);
         }
         else
         {
            idb.AddParameter("@TCPC_Weight", tC_PComp.TCPC_Weight);
         }
         if (tC_PComp.TCPC_ZDate == 0)
         {
            idb.AddParameter("@TCPC_ZDate", 0);
         }
         else
         {
            idb.AddParameter("@TCPC_ZDate", tC_PComp.TCPC_ZDate);
         }
         if (tC_PComp.TCPC_JDate == 0)
         {
            idb.AddParameter("@TCPC_JDate", 0);
         }
         else
         {
            idb.AddParameter("@TCPC_JDate", tC_PComp.TCPC_JDate);
         }
         if (string.IsNullOrEmpty(tC_PComp.AuditStat))
         {
            idb.AddParameter("@AuditStat", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AuditStat", tC_PComp.AuditStat);
         }
         if (string.IsNullOrEmpty(tC_PComp.AuditCurAudit))
         {
            idb.AddParameter("@AuditCurAudit", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AuditCurAudit", tC_PComp.AuditCurAudit);
         }
         if (tC_PComp.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", tC_PComp.Stat);
         }
         if (tC_PComp.CreateDate == DateTime.MinValue)
         {
            idb.AddParameter("@CreateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateDate", tC_PComp.CreateDate);
         }
         if (tC_PComp.UpdateDate == DateTime.MinValue)
         {
            idb.AddParameter("@UpdateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@UpdateDate", tC_PComp.UpdateDate);
         }
         if (tC_PComp.DeleteDate == DateTime.MinValue)
         {
            idb.AddParameter("@DeleteDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DeleteDate", tC_PComp.DeleteDate);
         }
         if (string.IsNullOrEmpty(tC_PComp.TCPC_Udef1))
         {
            idb.AddParameter("@TCPC_Udef1", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TCPC_Udef1", tC_PComp.TCPC_Udef1);
         }
         if (string.IsNullOrEmpty(tC_PComp.TCPC_Udef2))
         {
            idb.AddParameter("@TCPC_Udef2", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TCPC_Udef2", tC_PComp.TCPC_Udef2);
         }
         if (string.IsNullOrEmpty(tC_PComp.TCPC_Udef3))
         {
            idb.AddParameter("@TCPC_Udef3", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TCPC_Udef3", tC_PComp.TCPC_Udef3);
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
      /// 更新生产配比信息 TC_PComp对象(即:一条记录
      /// </summary>
      public int Update(TC_PComp tC_PComp)
      {
         
         StringBuilder sbParameter=new StringBuilder();
      StringBuilder sb=new StringBuilder();
      sb.Append(@"UPDATE       TC_PComp       SET ");
            if(tC_PComp.TCPC_Code_IsChanged){sbParameter.Append("TCPC_Code=@TCPC_Code, ");}
      if(tC_PComp.TCPC_Name_IsChanged){sbParameter.Append("TCPC_Name=@TCPC_Name, ");}
      if(tC_PComp.TCPC_Type_IsChanged){sbParameter.Append("TCPC_Type=@TCPC_Type, ");}
      if(tC_PComp.TCPC_Lev_IsChanged){sbParameter.Append("TCPC_Lev=@TCPC_Lev, ");}
      if(tC_PComp.TCPC_IMLEVEL_IsChanged){sbParameter.Append("TCPC_IMLEVEL=@TCPC_IMLEVEL, ");}
      if(tC_PComp.TCPC_Day_IsChanged){sbParameter.Append("TCPC_Day=@TCPC_Day, ");}
      if(tC_PComp.TCPC_Station_IsChanged){sbParameter.Append("TCPC_Station=@TCPC_Station, ");}
      if(tC_PComp.TCPC_Line_IsChanged){sbParameter.Append("TCPC_Line=@TCPC_Line, ");}
      if(tC_PComp.TCPC_PCode_IsChanged){sbParameter.Append("TCPC_PCode=@TCPC_PCode, ");}
      if(tC_PComp.TCPC_Owner_IsChanged){sbParameter.Append("TCPC_Owner=@TCPC_Owner, ");}
      if(tC_PComp.TCPC_Date_IsChanged){sbParameter.Append("TCPC_Date=@TCPC_Date, ");}
      if(tC_PComp.TCPC_IsCurrent_IsChanged){sbParameter.Append("TCPC_IsCurrent=@TCPC_IsCurrent, ");}
      if(tC_PComp.TCPC_RefSTCode_IsChanged){sbParameter.Append("TCPC_RefSTCode=@TCPC_RefSTCode, ");}
      if(tC_PComp.TCPC_RefType_IsChanged){sbParameter.Append("TCPC_RefType=@TCPC_RefType, ");}
      if(tC_PComp.TCPC_RefCode_IsChanged){sbParameter.Append("TCPC_RefCode=@TCPC_RefCode, ");}
      if(tC_PComp.TCPC_Weight_IsChanged){sbParameter.Append("TCPC_Weight=@TCPC_Weight, ");}
      if(tC_PComp.TCPC_ZDate_IsChanged){sbParameter.Append("TCPC_ZDate=@TCPC_ZDate, ");}
      if(tC_PComp.TCPC_JDate_IsChanged){sbParameter.Append("TCPC_JDate=@TCPC_JDate, ");}
      if(tC_PComp.AuditStat_IsChanged){sbParameter.Append("AuditStat=@AuditStat, ");}
      if(tC_PComp.AuditCurAudit_IsChanged){sbParameter.Append("AuditCurAudit=@AuditCurAudit, ");}
      if(tC_PComp.Stat_IsChanged){sbParameter.Append("Stat=@Stat, ");}
      if(tC_PComp.CreateDate_IsChanged){sbParameter.Append("CreateDate=@CreateDate, ");}
      if(tC_PComp.UpdateDate_IsChanged){sbParameter.Append("UpdateDate=@UpdateDate, ");}
      if(tC_PComp.DeleteDate_IsChanged){sbParameter.Append("DeleteDate=@DeleteDate, ");}
      if(tC_PComp.TCPC_Udef1_IsChanged){sbParameter.Append("TCPC_Udef1=@TCPC_Udef1, ");}
      if(tC_PComp.TCPC_Udef2_IsChanged){sbParameter.Append("TCPC_Udef2=@TCPC_Udef2, ");}
      if(tC_PComp.TCPC_Udef3_IsChanged){sbParameter.Append("TCPC_Udef3=@TCPC_Udef3 ");}          sb.Append(sbParameter.ToString().Trim().TrimEnd(',')); 
      sb.Append(      " WHERE 1=1 AND ((Stat is null) or (Stat=0))   and TCPC_ID=@TCPC_ID; " );
      string sql=sb.ToString();
         if(tC_PComp.TCPC_Code_IsChanged)
         {
         if (string.IsNullOrEmpty(tC_PComp.TCPC_Code))
         {
            idb.AddParameter("@TCPC_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TCPC_Code", tC_PComp.TCPC_Code);
         }
          }
         if(tC_PComp.TCPC_Name_IsChanged)
         {
         if (string.IsNullOrEmpty(tC_PComp.TCPC_Name))
         {
            idb.AddParameter("@TCPC_Name", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TCPC_Name", tC_PComp.TCPC_Name);
         }
          }
         if(tC_PComp.TCPC_Type_IsChanged)
         {
         if (string.IsNullOrEmpty(tC_PComp.TCPC_Type))
         {
            idb.AddParameter("@TCPC_Type", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TCPC_Type", tC_PComp.TCPC_Type);
         }
          }
         if(tC_PComp.TCPC_Lev_IsChanged)
         {
         if (string.IsNullOrEmpty(tC_PComp.TCPC_Lev))
         {
            idb.AddParameter("@TCPC_Lev", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TCPC_Lev", tC_PComp.TCPC_Lev);
         }
          }
         if(tC_PComp.TCPC_IMLEVEL_IsChanged)
         {
         if (string.IsNullOrEmpty(tC_PComp.TCPC_IMLEVEL))
         {
            idb.AddParameter("@TCPC_IMLEVEL", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TCPC_IMLEVEL", tC_PComp.TCPC_IMLEVEL);
         }
          }
         if(tC_PComp.TCPC_Day_IsChanged)
         {
         if (string.IsNullOrEmpty(tC_PComp.TCPC_Day))
         {
            idb.AddParameter("@TCPC_Day", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TCPC_Day", tC_PComp.TCPC_Day);
         }
          }
         if(tC_PComp.TCPC_Station_IsChanged)
         {
         if (string.IsNullOrEmpty(tC_PComp.TCPC_Station))
         {
            idb.AddParameter("@TCPC_Station", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TCPC_Station", tC_PComp.TCPC_Station);
         }
          }
         if(tC_PComp.TCPC_Line_IsChanged)
         {
         if (string.IsNullOrEmpty(tC_PComp.TCPC_Line))
         {
            idb.AddParameter("@TCPC_Line", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TCPC_Line", tC_PComp.TCPC_Line);
         }
          }
         if(tC_PComp.TCPC_PCode_IsChanged)
         {
         if (string.IsNullOrEmpty(tC_PComp.TCPC_PCode))
         {
            idb.AddParameter("@TCPC_PCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TCPC_PCode", tC_PComp.TCPC_PCode);
         }
          }
         if(tC_PComp.TCPC_Owner_IsChanged)
         {
         if (string.IsNullOrEmpty(tC_PComp.TCPC_Owner))
         {
            idb.AddParameter("@TCPC_Owner", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TCPC_Owner", tC_PComp.TCPC_Owner);
         }
          }
         if(tC_PComp.TCPC_Date_IsChanged)
         {
         if (tC_PComp.TCPC_Date == DateTime.MinValue)
         {
            idb.AddParameter("@TCPC_Date", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TCPC_Date", tC_PComp.TCPC_Date);
         }
          }
         if(tC_PComp.TCPC_IsCurrent_IsChanged)
         {
         if (tC_PComp.TCPC_IsCurrent == 0)
         {
            idb.AddParameter("@TCPC_IsCurrent", 0);
         }
         else
         {
            idb.AddParameter("@TCPC_IsCurrent", tC_PComp.TCPC_IsCurrent);
         }
          }
         if(tC_PComp.TCPC_RefSTCode_IsChanged)
         {
         if (string.IsNullOrEmpty(tC_PComp.TCPC_RefSTCode))
         {
            idb.AddParameter("@TCPC_RefSTCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TCPC_RefSTCode", tC_PComp.TCPC_RefSTCode);
         }
          }
         if(tC_PComp.TCPC_RefType_IsChanged)
         {
         if (string.IsNullOrEmpty(tC_PComp.TCPC_RefType))
         {
            idb.AddParameter("@TCPC_RefType", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TCPC_RefType", tC_PComp.TCPC_RefType);
         }
          }
         if(tC_PComp.TCPC_RefCode_IsChanged)
         {
         if (string.IsNullOrEmpty(tC_PComp.TCPC_RefCode))
         {
            idb.AddParameter("@TCPC_RefCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TCPC_RefCode", tC_PComp.TCPC_RefCode);
         }
          }
         if(tC_PComp.TCPC_Weight_IsChanged)
         {
         if (tC_PComp.TCPC_Weight == 0)
         {
            idb.AddParameter("@TCPC_Weight", 0);
         }
         else
         {
            idb.AddParameter("@TCPC_Weight", tC_PComp.TCPC_Weight);
         }
          }
         if(tC_PComp.TCPC_ZDate_IsChanged)
         {
         if (tC_PComp.TCPC_ZDate == 0)
         {
            idb.AddParameter("@TCPC_ZDate", 0);
         }
         else
         {
            idb.AddParameter("@TCPC_ZDate", tC_PComp.TCPC_ZDate);
         }
          }
         if(tC_PComp.TCPC_JDate_IsChanged)
         {
         if (tC_PComp.TCPC_JDate == 0)
         {
            idb.AddParameter("@TCPC_JDate", 0);
         }
         else
         {
            idb.AddParameter("@TCPC_JDate", tC_PComp.TCPC_JDate);
         }
          }
         if(tC_PComp.AuditStat_IsChanged)
         {
         if (string.IsNullOrEmpty(tC_PComp.AuditStat))
         {
            idb.AddParameter("@AuditStat", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AuditStat", tC_PComp.AuditStat);
         }
          }
         if(tC_PComp.AuditCurAudit_IsChanged)
         {
         if (string.IsNullOrEmpty(tC_PComp.AuditCurAudit))
         {
            idb.AddParameter("@AuditCurAudit", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AuditCurAudit", tC_PComp.AuditCurAudit);
         }
          }
         if(tC_PComp.Stat_IsChanged)
         {
         if (tC_PComp.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", tC_PComp.Stat);
         }
          }
         if(tC_PComp.CreateDate_IsChanged)
         {
         if (tC_PComp.CreateDate == DateTime.MinValue)
         {
            idb.AddParameter("@CreateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateDate", tC_PComp.CreateDate);
         }
          }
         if(tC_PComp.UpdateDate_IsChanged)
         {
         if (tC_PComp.UpdateDate == DateTime.MinValue)
         {
            idb.AddParameter("@UpdateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@UpdateDate", tC_PComp.UpdateDate);
         }
          }
         if(tC_PComp.DeleteDate_IsChanged)
         {
         if (tC_PComp.DeleteDate == DateTime.MinValue)
         {
            idb.AddParameter("@DeleteDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DeleteDate", tC_PComp.DeleteDate);
         }
          }
         if(tC_PComp.TCPC_Udef1_IsChanged)
         {
         if (string.IsNullOrEmpty(tC_PComp.TCPC_Udef1))
         {
            idb.AddParameter("@TCPC_Udef1", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TCPC_Udef1", tC_PComp.TCPC_Udef1);
         }
          }
         if(tC_PComp.TCPC_Udef2_IsChanged)
         {
         if (string.IsNullOrEmpty(tC_PComp.TCPC_Udef2))
         {
            idb.AddParameter("@TCPC_Udef2", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TCPC_Udef2", tC_PComp.TCPC_Udef2);
         }
          }
         if(tC_PComp.TCPC_Udef3_IsChanged)
         {
         if (string.IsNullOrEmpty(tC_PComp.TCPC_Udef3))
         {
            idb.AddParameter("@TCPC_Udef3", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TCPC_Udef3", tC_PComp.TCPC_Udef3);
         }
          }

         idb.AddParameter("@TCPC_ID", tC_PComp.TCPC_ID);

           
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
      /// 删除生产配比信息 TC_PComp对象(即:一条记录
      /// </summary>
      public int Delete(decimal tCPC_ID)
      {
         string sql = "DELETE TC_PComp WHERE 1=1  AND TCPC_ID=@TCPC_ID ";
         idb.AddParameter("@TCPC_ID", tCPC_ID);

           
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
      /// 获取指定的生产配比信息 TC_PComp对象(即:一条记录
      /// </summary>
      public TC_PComp GetByKey(decimal tCPC_ID)
      {
         TC_PComp tC_PComp = new TC_PComp();
         string sql = "SELECT  TCPC_ID,TCPC_Code,TCPC_Name,TCPC_Type,TCPC_Lev,TCPC_IMLEVEL,TCPC_Day,TCPC_Station,TCPC_Line,TCPC_PCode,TCPC_Owner,TCPC_Date,TCPC_IsCurrent,TCPC_RefSTCode,TCPC_RefType,TCPC_RefCode,TCPC_Weight,TCPC_ZDate,TCPC_JDate,AuditStat,AuditCurAudit,Stat,CreateDate,UpdateDate,DeleteDate,TCPC_Udef1,TCPC_Udef2,TCPC_Udef3 FROM TC_PComp WHERE 1=1 AND ((Stat is null) or (Stat=0) )  AND TCPC_ID=@TCPC_ID ";
         idb.AddParameter("@TCPC_ID", tCPC_ID);

          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            if (dr["TCPC_ID"] != DBNull.Value) tC_PComp.TCPC_ID = Convert.ToDecimal(dr["TCPC_ID"]);
            if (dr["TCPC_Code"] != DBNull.Value) tC_PComp.TCPC_Code = Convert.ToString(dr["TCPC_Code"]);
            if (dr["TCPC_Name"] != DBNull.Value) tC_PComp.TCPC_Name = Convert.ToString(dr["TCPC_Name"]);
            if (dr["TCPC_Type"] != DBNull.Value) tC_PComp.TCPC_Type = Convert.ToString(dr["TCPC_Type"]);
            if (dr["TCPC_Lev"] != DBNull.Value) tC_PComp.TCPC_Lev = Convert.ToString(dr["TCPC_Lev"]);
            if (dr["TCPC_IMLEVEL"] != DBNull.Value) tC_PComp.TCPC_IMLEVEL = Convert.ToString(dr["TCPC_IMLEVEL"]);
            if (dr["TCPC_Day"] != DBNull.Value) tC_PComp.TCPC_Day = Convert.ToString(dr["TCPC_Day"]);
            if (dr["TCPC_Station"] != DBNull.Value) tC_PComp.TCPC_Station = Convert.ToString(dr["TCPC_Station"]);
            if (dr["TCPC_Line"] != DBNull.Value) tC_PComp.TCPC_Line = Convert.ToString(dr["TCPC_Line"]);
            if (dr["TCPC_PCode"] != DBNull.Value) tC_PComp.TCPC_PCode = Convert.ToString(dr["TCPC_PCode"]);
            if (dr["TCPC_Owner"] != DBNull.Value) tC_PComp.TCPC_Owner = Convert.ToString(dr["TCPC_Owner"]);
            if (dr["TCPC_Date"] != DBNull.Value) tC_PComp.TCPC_Date = Convert.ToDateTime(dr["TCPC_Date"]);
            if (dr["TCPC_IsCurrent"] != DBNull.Value) tC_PComp.TCPC_IsCurrent = Convert.ToInt32(dr["TCPC_IsCurrent"]);
            if (dr["TCPC_RefSTCode"] != DBNull.Value) tC_PComp.TCPC_RefSTCode = Convert.ToString(dr["TCPC_RefSTCode"]);
            if (dr["TCPC_RefType"] != DBNull.Value) tC_PComp.TCPC_RefType = Convert.ToString(dr["TCPC_RefType"]);
            if (dr["TCPC_RefCode"] != DBNull.Value) tC_PComp.TCPC_RefCode = Convert.ToString(dr["TCPC_RefCode"]);
            if (dr["TCPC_Weight"] != DBNull.Value) tC_PComp.TCPC_Weight = Convert.ToDecimal(dr["TCPC_Weight"]);
            if (dr["TCPC_ZDate"] != DBNull.Value) tC_PComp.TCPC_ZDate = Convert.ToInt32(dr["TCPC_ZDate"]);
            if (dr["TCPC_JDate"] != DBNull.Value) tC_PComp.TCPC_JDate = Convert.ToInt32(dr["TCPC_JDate"]);
            if (dr["AuditStat"] != DBNull.Value) tC_PComp.AuditStat = Convert.ToString(dr["AuditStat"]);
            if (dr["AuditCurAudit"] != DBNull.Value) tC_PComp.AuditCurAudit = Convert.ToString(dr["AuditCurAudit"]);
            if (dr["Stat"] != DBNull.Value) tC_PComp.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["CreateDate"] != DBNull.Value) tC_PComp.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
            if (dr["UpdateDate"] != DBNull.Value) tC_PComp.UpdateDate = Convert.ToDateTime(dr["UpdateDate"]);
            if (dr["DeleteDate"] != DBNull.Value) tC_PComp.DeleteDate = Convert.ToDateTime(dr["DeleteDate"]);
            if (dr["TCPC_Udef1"] != DBNull.Value) tC_PComp.TCPC_Udef1 = Convert.ToString(dr["TCPC_Udef1"]);
            if (dr["TCPC_Udef2"] != DBNull.Value) tC_PComp.TCPC_Udef2 = Convert.ToString(dr["TCPC_Udef2"]);
            if (dr["TCPC_Udef3"] != DBNull.Value) tC_PComp.TCPC_Udef3 = Convert.ToString(dr["TCPC_Udef3"]);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   }  
         return tC_PComp;
      }
      /// <summary>
      /// 获取指定的生产配比信息 TC_PComp对象集合
      /// </summary>
      public List<TC_PComp> GetListByWhere(string strCondition)
      {
         List<TC_PComp> ret = new List<TC_PComp>();
         string sql = "SELECT  TCPC_ID,TCPC_Code,TCPC_Name,TCPC_Type,TCPC_Lev,TCPC_IMLEVEL,TCPC_Day,TCPC_Station,TCPC_Line,TCPC_PCode,TCPC_Owner,TCPC_Date,TCPC_IsCurrent,TCPC_RefSTCode,TCPC_RefType,TCPC_RefCode,TCPC_Weight,TCPC_ZDate,TCPC_JDate,AuditStat,AuditCurAudit,Stat,CreateDate,UpdateDate,DeleteDate,TCPC_Udef1,TCPC_Udef2,TCPC_Udef3 FROM TC_PComp WHERE 1=1 AND ((Stat is null) or (Stat=0) ) ";
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
            TC_PComp tC_PComp = new TC_PComp();
            if (dr["TCPC_ID"] != DBNull.Value) tC_PComp.TCPC_ID = Convert.ToDecimal(dr["TCPC_ID"]);
            if (dr["TCPC_Code"] != DBNull.Value) tC_PComp.TCPC_Code = Convert.ToString(dr["TCPC_Code"]);
            if (dr["TCPC_Name"] != DBNull.Value) tC_PComp.TCPC_Name = Convert.ToString(dr["TCPC_Name"]);
            if (dr["TCPC_Type"] != DBNull.Value) tC_PComp.TCPC_Type = Convert.ToString(dr["TCPC_Type"]);
            if (dr["TCPC_Lev"] != DBNull.Value) tC_PComp.TCPC_Lev = Convert.ToString(dr["TCPC_Lev"]);
            if (dr["TCPC_IMLEVEL"] != DBNull.Value) tC_PComp.TCPC_IMLEVEL = Convert.ToString(dr["TCPC_IMLEVEL"]);
            if (dr["TCPC_Day"] != DBNull.Value) tC_PComp.TCPC_Day = Convert.ToString(dr["TCPC_Day"]);
            if (dr["TCPC_Station"] != DBNull.Value) tC_PComp.TCPC_Station = Convert.ToString(dr["TCPC_Station"]);
            if (dr["TCPC_Line"] != DBNull.Value) tC_PComp.TCPC_Line = Convert.ToString(dr["TCPC_Line"]);
            if (dr["TCPC_PCode"] != DBNull.Value) tC_PComp.TCPC_PCode = Convert.ToString(dr["TCPC_PCode"]);
            if (dr["TCPC_Owner"] != DBNull.Value) tC_PComp.TCPC_Owner = Convert.ToString(dr["TCPC_Owner"]);
            if (dr["TCPC_Date"] != DBNull.Value) tC_PComp.TCPC_Date = Convert.ToDateTime(dr["TCPC_Date"]);
            if (dr["TCPC_IsCurrent"] != DBNull.Value) tC_PComp.TCPC_IsCurrent = Convert.ToInt32(dr["TCPC_IsCurrent"]);
            if (dr["TCPC_RefSTCode"] != DBNull.Value) tC_PComp.TCPC_RefSTCode = Convert.ToString(dr["TCPC_RefSTCode"]);
            if (dr["TCPC_RefType"] != DBNull.Value) tC_PComp.TCPC_RefType = Convert.ToString(dr["TCPC_RefType"]);
            if (dr["TCPC_RefCode"] != DBNull.Value) tC_PComp.TCPC_RefCode = Convert.ToString(dr["TCPC_RefCode"]);
            if (dr["TCPC_Weight"] != DBNull.Value) tC_PComp.TCPC_Weight = Convert.ToDecimal(dr["TCPC_Weight"]);
            if (dr["TCPC_ZDate"] != DBNull.Value) tC_PComp.TCPC_ZDate = Convert.ToInt32(dr["TCPC_ZDate"]);
            if (dr["TCPC_JDate"] != DBNull.Value) tC_PComp.TCPC_JDate = Convert.ToInt32(dr["TCPC_JDate"]);
            if (dr["AuditStat"] != DBNull.Value) tC_PComp.AuditStat = Convert.ToString(dr["AuditStat"]);
            if (dr["AuditCurAudit"] != DBNull.Value) tC_PComp.AuditCurAudit = Convert.ToString(dr["AuditCurAudit"]);
            if (dr["Stat"] != DBNull.Value) tC_PComp.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["CreateDate"] != DBNull.Value) tC_PComp.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
            if (dr["UpdateDate"] != DBNull.Value) tC_PComp.UpdateDate = Convert.ToDateTime(dr["UpdateDate"]);
            if (dr["DeleteDate"] != DBNull.Value) tC_PComp.DeleteDate = Convert.ToDateTime(dr["DeleteDate"]);
            if (dr["TCPC_Udef1"] != DBNull.Value) tC_PComp.TCPC_Udef1 = Convert.ToString(dr["TCPC_Udef1"]);
            if (dr["TCPC_Udef2"] != DBNull.Value) tC_PComp.TCPC_Udef2 = Convert.ToString(dr["TCPC_Udef2"]);
            if (dr["TCPC_Udef3"] != DBNull.Value) tC_PComp.TCPC_Udef3 = Convert.ToString(dr["TCPC_Udef3"]);
            ret.Add(tC_PComp);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   }  
         return ret;
      }
      /// <summary>
      /// 获取所有的生产配比信息 TC_PComp对象(即:一条记录
      /// </summary>
      public List<TC_PComp> GetAll()
      {
         List<TC_PComp> ret = new List<TC_PComp>();
         string sql = "SELECT  TCPC_ID,TCPC_Code,TCPC_Name,TCPC_Type,TCPC_Lev,TCPC_IMLEVEL,TCPC_Day,TCPC_Station,TCPC_Line,TCPC_PCode,TCPC_Owner,TCPC_Date,TCPC_IsCurrent,TCPC_RefSTCode,TCPC_RefType,TCPC_RefCode,TCPC_Weight,TCPC_ZDate,TCPC_JDate,AuditStat,AuditCurAudit,Stat,CreateDate,UpdateDate,DeleteDate,TCPC_Udef1,TCPC_Udef2,TCPC_Udef3 FROM TC_PComp where 1=1 AND ((Stat is null) or (Stat=0) ) order by TCPC_ID desc ";
          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            TC_PComp tC_PComp = new TC_PComp();
            if (dr["TCPC_ID"] != DBNull.Value) tC_PComp.TCPC_ID = Convert.ToDecimal(dr["TCPC_ID"]);
            if (dr["TCPC_Code"] != DBNull.Value) tC_PComp.TCPC_Code = Convert.ToString(dr["TCPC_Code"]);
            if (dr["TCPC_Name"] != DBNull.Value) tC_PComp.TCPC_Name = Convert.ToString(dr["TCPC_Name"]);
            if (dr["TCPC_Type"] != DBNull.Value) tC_PComp.TCPC_Type = Convert.ToString(dr["TCPC_Type"]);
            if (dr["TCPC_Lev"] != DBNull.Value) tC_PComp.TCPC_Lev = Convert.ToString(dr["TCPC_Lev"]);
            if (dr["TCPC_IMLEVEL"] != DBNull.Value) tC_PComp.TCPC_IMLEVEL = Convert.ToString(dr["TCPC_IMLEVEL"]);
            if (dr["TCPC_Day"] != DBNull.Value) tC_PComp.TCPC_Day = Convert.ToString(dr["TCPC_Day"]);
            if (dr["TCPC_Station"] != DBNull.Value) tC_PComp.TCPC_Station = Convert.ToString(dr["TCPC_Station"]);
            if (dr["TCPC_Line"] != DBNull.Value) tC_PComp.TCPC_Line = Convert.ToString(dr["TCPC_Line"]);
            if (dr["TCPC_PCode"] != DBNull.Value) tC_PComp.TCPC_PCode = Convert.ToString(dr["TCPC_PCode"]);
            if (dr["TCPC_Owner"] != DBNull.Value) tC_PComp.TCPC_Owner = Convert.ToString(dr["TCPC_Owner"]);
            if (dr["TCPC_Date"] != DBNull.Value) tC_PComp.TCPC_Date = Convert.ToDateTime(dr["TCPC_Date"]);
            if (dr["TCPC_IsCurrent"] != DBNull.Value) tC_PComp.TCPC_IsCurrent = Convert.ToInt32(dr["TCPC_IsCurrent"]);
            if (dr["TCPC_RefSTCode"] != DBNull.Value) tC_PComp.TCPC_RefSTCode = Convert.ToString(dr["TCPC_RefSTCode"]);
            if (dr["TCPC_RefType"] != DBNull.Value) tC_PComp.TCPC_RefType = Convert.ToString(dr["TCPC_RefType"]);
            if (dr["TCPC_RefCode"] != DBNull.Value) tC_PComp.TCPC_RefCode = Convert.ToString(dr["TCPC_RefCode"]);
            if (dr["TCPC_Weight"] != DBNull.Value) tC_PComp.TCPC_Weight = Convert.ToDecimal(dr["TCPC_Weight"]);
            if (dr["TCPC_ZDate"] != DBNull.Value) tC_PComp.TCPC_ZDate = Convert.ToInt32(dr["TCPC_ZDate"]);
            if (dr["TCPC_JDate"] != DBNull.Value) tC_PComp.TCPC_JDate = Convert.ToInt32(dr["TCPC_JDate"]);
            if (dr["AuditStat"] != DBNull.Value) tC_PComp.AuditStat = Convert.ToString(dr["AuditStat"]);
            if (dr["AuditCurAudit"] != DBNull.Value) tC_PComp.AuditCurAudit = Convert.ToString(dr["AuditCurAudit"]);
            if (dr["Stat"] != DBNull.Value) tC_PComp.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["CreateDate"] != DBNull.Value) tC_PComp.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
            if (dr["UpdateDate"] != DBNull.Value) tC_PComp.UpdateDate = Convert.ToDateTime(dr["UpdateDate"]);
            if (dr["DeleteDate"] != DBNull.Value) tC_PComp.DeleteDate = Convert.ToDateTime(dr["DeleteDate"]);
            if (dr["TCPC_Udef1"] != DBNull.Value) tC_PComp.TCPC_Udef1 = Convert.ToString(dr["TCPC_Udef1"]);
            if (dr["TCPC_Udef2"] != DBNull.Value) tC_PComp.TCPC_Udef2 = Convert.ToString(dr["TCPC_Udef2"]);
            if (dr["TCPC_Udef3"] != DBNull.Value) tC_PComp.TCPC_Udef3 = Convert.ToString(dr["TCPC_Udef3"]);
            ret.Add(tC_PComp);
         }
          }catch (System.Exception ex){ throw ex; }  finally {  if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   } 
         return ret;
      }
   }
}
