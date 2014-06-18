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
   /// 供应商发票信息
   /// </summary>
   [Serializable]
   public partial class ADOWH_Invoice
   {
      public IDBOperator idb =  DBOperator.GetInstance();
      /// <summary>
      /// 添加供应商发票信息 WH_Invoice对象(即:一条记录)
      /// </summary>
      public int Add(WH_Invoice wH_Invoice)
      {
         string sql = "INSERT INTO WH_Invoice (WHI_Code,WHI_SCode,WHI_SName,WHI_Name,WHI_Sum,WHI_Number,WHI_Date,WHI_ProcMan,WHI_Bak,WHI_CType,WHI_CCode,Stat,CreateDate,UpdateDate,DeleteDate,WHI_PayStat,WHI_PayCode,WHI_SProcMan,WHI_Company,WHI_CompanyCode,WHI_Pay,AuditStat,AuditCurAudit,WHI_RelSum) VALUES (@WHI_Code,@WHI_SCode,@WHI_SName,@WHI_Name,@WHI_Sum,@WHI_Number,@WHI_Date,@WHI_ProcMan,@WHI_Bak,@WHI_CType,@WHI_CCode,@Stat,@CreateDate,@UpdateDate,@DeleteDate,@WHI_PayStat,@WHI_PayCode,@WHI_SProcMan,@WHI_Company,@WHI_CompanyCode,@WHI_Pay,@AuditStat,@AuditCurAudit,@WHI_RelSum)";
         if (string.IsNullOrEmpty(wH_Invoice.WHI_Code))
         {
            idb.AddParameter("@WHI_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHI_Code", wH_Invoice.WHI_Code);
         }
         if (string.IsNullOrEmpty(wH_Invoice.WHI_SCode))
         {
            idb.AddParameter("@WHI_SCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHI_SCode", wH_Invoice.WHI_SCode);
         }
         if (string.IsNullOrEmpty(wH_Invoice.WHI_SName))
         {
            idb.AddParameter("@WHI_SName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHI_SName", wH_Invoice.WHI_SName);
         }
         if (string.IsNullOrEmpty(wH_Invoice.WHI_Name))
         {
            idb.AddParameter("@WHI_Name", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHI_Name", wH_Invoice.WHI_Name);
         }
         if (wH_Invoice.WHI_Sum == 0)
         {
            idb.AddParameter("@WHI_Sum", 0);
         }
         else
         {
            idb.AddParameter("@WHI_Sum", wH_Invoice.WHI_Sum);
         }
         if (string.IsNullOrEmpty(wH_Invoice.WHI_Number))
         {
            idb.AddParameter("@WHI_Number", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHI_Number", wH_Invoice.WHI_Number);
         }
         if (wH_Invoice.WHI_Date == DateTime.MinValue)
         {
            idb.AddParameter("@WHI_Date", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHI_Date", wH_Invoice.WHI_Date);
         }
         if (string.IsNullOrEmpty(wH_Invoice.WHI_ProcMan))
         {
            idb.AddParameter("@WHI_ProcMan", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHI_ProcMan", wH_Invoice.WHI_ProcMan);
         }
         if (string.IsNullOrEmpty(wH_Invoice.WHI_Bak))
         {
            idb.AddParameter("@WHI_Bak", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHI_Bak", wH_Invoice.WHI_Bak);
         }
         if (string.IsNullOrEmpty(wH_Invoice.WHI_CType))
         {
            idb.AddParameter("@WHI_CType", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHI_CType", wH_Invoice.WHI_CType);
         }
         if (string.IsNullOrEmpty(wH_Invoice.WHI_CCode))
         {
            idb.AddParameter("@WHI_CCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHI_CCode", wH_Invoice.WHI_CCode);
         }
         if (wH_Invoice.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", wH_Invoice.Stat);
         }
         if (wH_Invoice.CreateDate == DateTime.MinValue)
         {
            idb.AddParameter("@CreateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateDate", wH_Invoice.CreateDate);
         }
         if (wH_Invoice.UpdateDate == DateTime.MinValue)
         {
            idb.AddParameter("@UpdateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@UpdateDate", wH_Invoice.UpdateDate);
         }
         if (wH_Invoice.DeleteDate == DateTime.MinValue)
         {
            idb.AddParameter("@DeleteDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DeleteDate", wH_Invoice.DeleteDate);
         }
         if (string.IsNullOrEmpty(wH_Invoice.WHI_PayStat))
         {
            idb.AddParameter("@WHI_PayStat", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHI_PayStat", wH_Invoice.WHI_PayStat);
         }
         if (string.IsNullOrEmpty(wH_Invoice.WHI_PayCode))
         {
            idb.AddParameter("@WHI_PayCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHI_PayCode", wH_Invoice.WHI_PayCode);
         }
         if (string.IsNullOrEmpty(wH_Invoice.WHI_SProcMan))
         {
            idb.AddParameter("@WHI_SProcMan", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHI_SProcMan", wH_Invoice.WHI_SProcMan);
         }
         if (string.IsNullOrEmpty(wH_Invoice.WHI_Company))
         {
            idb.AddParameter("@WHI_Company", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHI_Company", wH_Invoice.WHI_Company);
         }
         if (string.IsNullOrEmpty(wH_Invoice.WHI_CompanyCode))
         {
            idb.AddParameter("@WHI_CompanyCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHI_CompanyCode", wH_Invoice.WHI_CompanyCode);
         }
         if (wH_Invoice.WHI_Pay == 0)
         {
            idb.AddParameter("@WHI_Pay", 0);
         }
         else
         {
            idb.AddParameter("@WHI_Pay", wH_Invoice.WHI_Pay);
         }
         if (string.IsNullOrEmpty(wH_Invoice.AuditStat))
         {
            idb.AddParameter("@AuditStat", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AuditStat", wH_Invoice.AuditStat);
         }
         if (string.IsNullOrEmpty(wH_Invoice.AuditCurAudit))
         {
            idb.AddParameter("@AuditCurAudit", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AuditCurAudit", wH_Invoice.AuditCurAudit);
         }
         if (wH_Invoice.WHI_RelSum == 0)
         {
            idb.AddParameter("@WHI_RelSum", 0);
         }
         else
         {
            idb.AddParameter("@WHI_RelSum", wH_Invoice.WHI_RelSum);
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
      /// 添加供应商发票信息 WH_Invoice对象(即:一条记录)
      /// </summary>
      public object AddWithReturn(WH_Invoice wH_Invoice)
      {
         string sql = "INSERT INTO WH_Invoice (WHI_Code,WHI_SCode,WHI_SName,WHI_Name,WHI_Sum,WHI_Number,WHI_Date,WHI_ProcMan,WHI_Bak,WHI_CType,WHI_CCode,Stat,CreateDate,UpdateDate,DeleteDate,WHI_PayStat,WHI_PayCode,WHI_SProcMan,WHI_Company,WHI_CompanyCode,WHI_Pay,AuditStat,AuditCurAudit,WHI_RelSum) VALUES (@WHI_Code,@WHI_SCode,@WHI_SName,@WHI_Name,@WHI_Sum,@WHI_Number,@WHI_Date,@WHI_ProcMan,@WHI_Bak,@WHI_CType,@WHI_CCode,@Stat,@CreateDate,@UpdateDate,@DeleteDate,@WHI_PayStat,@WHI_PayCode,@WHI_SProcMan,@WHI_Company,@WHI_CompanyCode,@WHI_Pay,@AuditStat,@AuditCurAudit,@WHI_RelSum);SELECT @@IDENTITY AS ReturnID;";
         if (string.IsNullOrEmpty(wH_Invoice.WHI_Code))
         {
            idb.AddParameter("@WHI_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHI_Code", wH_Invoice.WHI_Code);
         }
         if (string.IsNullOrEmpty(wH_Invoice.WHI_SCode))
         {
            idb.AddParameter("@WHI_SCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHI_SCode", wH_Invoice.WHI_SCode);
         }
         if (string.IsNullOrEmpty(wH_Invoice.WHI_SName))
         {
            idb.AddParameter("@WHI_SName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHI_SName", wH_Invoice.WHI_SName);
         }
         if (string.IsNullOrEmpty(wH_Invoice.WHI_Name))
         {
            idb.AddParameter("@WHI_Name", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHI_Name", wH_Invoice.WHI_Name);
         }
         if (wH_Invoice.WHI_Sum == 0)
         {
            idb.AddParameter("@WHI_Sum", 0);
         }
         else
         {
            idb.AddParameter("@WHI_Sum", wH_Invoice.WHI_Sum);
         }
         if (string.IsNullOrEmpty(wH_Invoice.WHI_Number))
         {
            idb.AddParameter("@WHI_Number", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHI_Number", wH_Invoice.WHI_Number);
         }
         if (wH_Invoice.WHI_Date == DateTime.MinValue)
         {
            idb.AddParameter("@WHI_Date", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHI_Date", wH_Invoice.WHI_Date);
         }
         if (string.IsNullOrEmpty(wH_Invoice.WHI_ProcMan))
         {
            idb.AddParameter("@WHI_ProcMan", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHI_ProcMan", wH_Invoice.WHI_ProcMan);
         }
         if (string.IsNullOrEmpty(wH_Invoice.WHI_Bak))
         {
            idb.AddParameter("@WHI_Bak", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHI_Bak", wH_Invoice.WHI_Bak);
         }
         if (string.IsNullOrEmpty(wH_Invoice.WHI_CType))
         {
            idb.AddParameter("@WHI_CType", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHI_CType", wH_Invoice.WHI_CType);
         }
         if (string.IsNullOrEmpty(wH_Invoice.WHI_CCode))
         {
            idb.AddParameter("@WHI_CCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHI_CCode", wH_Invoice.WHI_CCode);
         }
         if (wH_Invoice.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", wH_Invoice.Stat);
         }
         if (wH_Invoice.CreateDate == DateTime.MinValue)
         {
            idb.AddParameter("@CreateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateDate", wH_Invoice.CreateDate);
         }
         if (wH_Invoice.UpdateDate == DateTime.MinValue)
         {
            idb.AddParameter("@UpdateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@UpdateDate", wH_Invoice.UpdateDate);
         }
         if (wH_Invoice.DeleteDate == DateTime.MinValue)
         {
            idb.AddParameter("@DeleteDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DeleteDate", wH_Invoice.DeleteDate);
         }
         if (string.IsNullOrEmpty(wH_Invoice.WHI_PayStat))
         {
            idb.AddParameter("@WHI_PayStat", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHI_PayStat", wH_Invoice.WHI_PayStat);
         }
         if (string.IsNullOrEmpty(wH_Invoice.WHI_PayCode))
         {
            idb.AddParameter("@WHI_PayCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHI_PayCode", wH_Invoice.WHI_PayCode);
         }
         if (string.IsNullOrEmpty(wH_Invoice.WHI_SProcMan))
         {
            idb.AddParameter("@WHI_SProcMan", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHI_SProcMan", wH_Invoice.WHI_SProcMan);
         }
         if (string.IsNullOrEmpty(wH_Invoice.WHI_Company))
         {
            idb.AddParameter("@WHI_Company", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHI_Company", wH_Invoice.WHI_Company);
         }
         if (string.IsNullOrEmpty(wH_Invoice.WHI_CompanyCode))
         {
            idb.AddParameter("@WHI_CompanyCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHI_CompanyCode", wH_Invoice.WHI_CompanyCode);
         }
         if (wH_Invoice.WHI_Pay == 0)
         {
            idb.AddParameter("@WHI_Pay", 0);
         }
         else
         {
            idb.AddParameter("@WHI_Pay", wH_Invoice.WHI_Pay);
         }
         if (string.IsNullOrEmpty(wH_Invoice.AuditStat))
         {
            idb.AddParameter("@AuditStat", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AuditStat", wH_Invoice.AuditStat);
         }
         if (string.IsNullOrEmpty(wH_Invoice.AuditCurAudit))
         {
            idb.AddParameter("@AuditCurAudit", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AuditCurAudit", wH_Invoice.AuditCurAudit);
         }
         if (wH_Invoice.WHI_RelSum == 0)
         {
            idb.AddParameter("@WHI_RelSum", 0);
         }
         else
         {
            idb.AddParameter("@WHI_RelSum", wH_Invoice.WHI_RelSum);
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
      /// 更新供应商发票信息 WH_Invoice对象(即:一条记录
      /// </summary>
      public int Update(WH_Invoice wH_Invoice)
      {
         
         StringBuilder sbParameter=new StringBuilder();
      StringBuilder sb=new StringBuilder();
      sb.Append(@"UPDATE       WH_Invoice       SET ");
            if(wH_Invoice.WHI_Code_IsChanged){sbParameter.Append("WHI_Code=@WHI_Code, ");}
      if(wH_Invoice.WHI_SCode_IsChanged){sbParameter.Append("WHI_SCode=@WHI_SCode, ");}
      if(wH_Invoice.WHI_SName_IsChanged){sbParameter.Append("WHI_SName=@WHI_SName, ");}
      if(wH_Invoice.WHI_Name_IsChanged){sbParameter.Append("WHI_Name=@WHI_Name, ");}
      if(wH_Invoice.WHI_Sum_IsChanged){sbParameter.Append("WHI_Sum=@WHI_Sum, ");}
      if(wH_Invoice.WHI_Number_IsChanged){sbParameter.Append("WHI_Number=@WHI_Number, ");}
      if(wH_Invoice.WHI_Date_IsChanged){sbParameter.Append("WHI_Date=@WHI_Date, ");}
      if(wH_Invoice.WHI_ProcMan_IsChanged){sbParameter.Append("WHI_ProcMan=@WHI_ProcMan, ");}
      if(wH_Invoice.WHI_Bak_IsChanged){sbParameter.Append("WHI_Bak=@WHI_Bak, ");}
      if(wH_Invoice.WHI_CType_IsChanged){sbParameter.Append("WHI_CType=@WHI_CType, ");}
      if(wH_Invoice.WHI_CCode_IsChanged){sbParameter.Append("WHI_CCode=@WHI_CCode, ");}
      if(wH_Invoice.Stat_IsChanged){sbParameter.Append("Stat=@Stat, ");}
      if(wH_Invoice.CreateDate_IsChanged){sbParameter.Append("CreateDate=@CreateDate, ");}
      if(wH_Invoice.UpdateDate_IsChanged){sbParameter.Append("UpdateDate=@UpdateDate, ");}
      if(wH_Invoice.DeleteDate_IsChanged){sbParameter.Append("DeleteDate=@DeleteDate, ");}
      if(wH_Invoice.WHI_PayStat_IsChanged){sbParameter.Append("WHI_PayStat=@WHI_PayStat, ");}
      if(wH_Invoice.WHI_PayCode_IsChanged){sbParameter.Append("WHI_PayCode=@WHI_PayCode, ");}
      if(wH_Invoice.WHI_SProcMan_IsChanged){sbParameter.Append("WHI_SProcMan=@WHI_SProcMan, ");}
      if(wH_Invoice.WHI_Company_IsChanged){sbParameter.Append("WHI_Company=@WHI_Company, ");}
      if(wH_Invoice.WHI_CompanyCode_IsChanged){sbParameter.Append("WHI_CompanyCode=@WHI_CompanyCode, ");}
      if(wH_Invoice.WHI_Pay_IsChanged){sbParameter.Append("WHI_Pay=@WHI_Pay, ");}
      if(wH_Invoice.AuditStat_IsChanged){sbParameter.Append("AuditStat=@AuditStat, ");}
      if(wH_Invoice.AuditCurAudit_IsChanged){sbParameter.Append("AuditCurAudit=@AuditCurAudit, ");}
      if(wH_Invoice.WHI_RelSum_IsChanged){sbParameter.Append("WHI_RelSum=@WHI_RelSum ");}          sb.Append(sbParameter.ToString().Trim().TrimEnd(',')); 
      sb.Append(      " WHERE 1=1 AND ((Stat is null) or (Stat=0))   and WHI_ID=@WHI_ID; " );
      string sql=sb.ToString();
         if(wH_Invoice.WHI_Code_IsChanged)
         {
         if (string.IsNullOrEmpty(wH_Invoice.WHI_Code))
         {
            idb.AddParameter("@WHI_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHI_Code", wH_Invoice.WHI_Code);
         }
          }
         if(wH_Invoice.WHI_SCode_IsChanged)
         {
         if (string.IsNullOrEmpty(wH_Invoice.WHI_SCode))
         {
            idb.AddParameter("@WHI_SCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHI_SCode", wH_Invoice.WHI_SCode);
         }
          }
         if(wH_Invoice.WHI_SName_IsChanged)
         {
         if (string.IsNullOrEmpty(wH_Invoice.WHI_SName))
         {
            idb.AddParameter("@WHI_SName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHI_SName", wH_Invoice.WHI_SName);
         }
          }
         if(wH_Invoice.WHI_Name_IsChanged)
         {
         if (string.IsNullOrEmpty(wH_Invoice.WHI_Name))
         {
            idb.AddParameter("@WHI_Name", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHI_Name", wH_Invoice.WHI_Name);
         }
          }
         if(wH_Invoice.WHI_Sum_IsChanged)
         {
         if (wH_Invoice.WHI_Sum == 0)
         {
            idb.AddParameter("@WHI_Sum", 0);
         }
         else
         {
            idb.AddParameter("@WHI_Sum", wH_Invoice.WHI_Sum);
         }
          }
         if(wH_Invoice.WHI_Number_IsChanged)
         {
         if (string.IsNullOrEmpty(wH_Invoice.WHI_Number))
         {
            idb.AddParameter("@WHI_Number", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHI_Number", wH_Invoice.WHI_Number);
         }
          }
         if(wH_Invoice.WHI_Date_IsChanged)
         {
         if (wH_Invoice.WHI_Date == DateTime.MinValue)
         {
            idb.AddParameter("@WHI_Date", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHI_Date", wH_Invoice.WHI_Date);
         }
          }
         if(wH_Invoice.WHI_ProcMan_IsChanged)
         {
         if (string.IsNullOrEmpty(wH_Invoice.WHI_ProcMan))
         {
            idb.AddParameter("@WHI_ProcMan", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHI_ProcMan", wH_Invoice.WHI_ProcMan);
         }
          }
         if(wH_Invoice.WHI_Bak_IsChanged)
         {
         if (string.IsNullOrEmpty(wH_Invoice.WHI_Bak))
         {
            idb.AddParameter("@WHI_Bak", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHI_Bak", wH_Invoice.WHI_Bak);
         }
          }
         if(wH_Invoice.WHI_CType_IsChanged)
         {
         if (string.IsNullOrEmpty(wH_Invoice.WHI_CType))
         {
            idb.AddParameter("@WHI_CType", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHI_CType", wH_Invoice.WHI_CType);
         }
          }
         if(wH_Invoice.WHI_CCode_IsChanged)
         {
         if (string.IsNullOrEmpty(wH_Invoice.WHI_CCode))
         {
            idb.AddParameter("@WHI_CCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHI_CCode", wH_Invoice.WHI_CCode);
         }
          }
         if(wH_Invoice.Stat_IsChanged)
         {
         if (wH_Invoice.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", wH_Invoice.Stat);
         }
          }
         if(wH_Invoice.CreateDate_IsChanged)
         {
         if (wH_Invoice.CreateDate == DateTime.MinValue)
         {
            idb.AddParameter("@CreateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateDate", wH_Invoice.CreateDate);
         }
          }
         if(wH_Invoice.UpdateDate_IsChanged)
         {
         if (wH_Invoice.UpdateDate == DateTime.MinValue)
         {
            idb.AddParameter("@UpdateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@UpdateDate", wH_Invoice.UpdateDate);
         }
          }
         if(wH_Invoice.DeleteDate_IsChanged)
         {
         if (wH_Invoice.DeleteDate == DateTime.MinValue)
         {
            idb.AddParameter("@DeleteDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DeleteDate", wH_Invoice.DeleteDate);
         }
          }
         if(wH_Invoice.WHI_PayStat_IsChanged)
         {
         if (string.IsNullOrEmpty(wH_Invoice.WHI_PayStat))
         {
            idb.AddParameter("@WHI_PayStat", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHI_PayStat", wH_Invoice.WHI_PayStat);
         }
          }
         if(wH_Invoice.WHI_PayCode_IsChanged)
         {
         if (string.IsNullOrEmpty(wH_Invoice.WHI_PayCode))
         {
            idb.AddParameter("@WHI_PayCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHI_PayCode", wH_Invoice.WHI_PayCode);
         }
          }
         if(wH_Invoice.WHI_SProcMan_IsChanged)
         {
         if (string.IsNullOrEmpty(wH_Invoice.WHI_SProcMan))
         {
            idb.AddParameter("@WHI_SProcMan", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHI_SProcMan", wH_Invoice.WHI_SProcMan);
         }
          }
         if(wH_Invoice.WHI_Company_IsChanged)
         {
         if (string.IsNullOrEmpty(wH_Invoice.WHI_Company))
         {
            idb.AddParameter("@WHI_Company", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHI_Company", wH_Invoice.WHI_Company);
         }
          }
         if(wH_Invoice.WHI_CompanyCode_IsChanged)
         {
         if (string.IsNullOrEmpty(wH_Invoice.WHI_CompanyCode))
         {
            idb.AddParameter("@WHI_CompanyCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHI_CompanyCode", wH_Invoice.WHI_CompanyCode);
         }
          }
         if(wH_Invoice.WHI_Pay_IsChanged)
         {
         if (wH_Invoice.WHI_Pay == 0)
         {
            idb.AddParameter("@WHI_Pay", 0);
         }
         else
         {
            idb.AddParameter("@WHI_Pay", wH_Invoice.WHI_Pay);
         }
          }
         if(wH_Invoice.AuditStat_IsChanged)
         {
         if (string.IsNullOrEmpty(wH_Invoice.AuditStat))
         {
            idb.AddParameter("@AuditStat", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AuditStat", wH_Invoice.AuditStat);
         }
          }
         if(wH_Invoice.AuditCurAudit_IsChanged)
         {
         if (string.IsNullOrEmpty(wH_Invoice.AuditCurAudit))
         {
            idb.AddParameter("@AuditCurAudit", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AuditCurAudit", wH_Invoice.AuditCurAudit);
         }
          }
         if(wH_Invoice.WHI_RelSum_IsChanged)
         {
         if (wH_Invoice.WHI_RelSum == 0)
         {
            idb.AddParameter("@WHI_RelSum", 0);
         }
         else
         {
            idb.AddParameter("@WHI_RelSum", wH_Invoice.WHI_RelSum);
         }
          }

         idb.AddParameter("@WHI_ID", wH_Invoice.WHI_ID);

           
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
      /// 删除供应商发票信息 WH_Invoice对象(即:一条记录
      /// </summary>
      public int Delete(decimal wHI_ID)
      {
         string sql = "DELETE WH_Invoice WHERE 1=1  AND WHI_ID=@WHI_ID ";
         idb.AddParameter("@WHI_ID", wHI_ID);

           
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
      /// 获取指定的供应商发票信息 WH_Invoice对象(即:一条记录
      /// </summary>
      public WH_Invoice GetByKey(decimal wHI_ID)
      {
         WH_Invoice wH_Invoice = new WH_Invoice();
         string sql = "SELECT  WHI_ID,WHI_Code,WHI_SCode,WHI_SName,WHI_Name,WHI_Sum,WHI_Number,WHI_Date,WHI_ProcMan,WHI_Bak,WHI_CType,WHI_CCode,Stat,CreateDate,UpdateDate,DeleteDate,WHI_PayStat,WHI_PayCode,WHI_SProcMan,WHI_Company,WHI_CompanyCode,WHI_Pay,AuditStat,AuditCurAudit,WHI_RelSum FROM WH_Invoice WHERE 1=1 AND ((Stat is null) or (Stat=0) )  AND WHI_ID=@WHI_ID ";
         idb.AddParameter("@WHI_ID", wHI_ID);

          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            if (dr["WHI_ID"] != DBNull.Value) wH_Invoice.WHI_ID = Convert.ToDecimal(dr["WHI_ID"]);
            if (dr["WHI_Code"] != DBNull.Value) wH_Invoice.WHI_Code = Convert.ToString(dr["WHI_Code"]);
            if (dr["WHI_SCode"] != DBNull.Value) wH_Invoice.WHI_SCode = Convert.ToString(dr["WHI_SCode"]);
            if (dr["WHI_SName"] != DBNull.Value) wH_Invoice.WHI_SName = Convert.ToString(dr["WHI_SName"]);
            if (dr["WHI_Name"] != DBNull.Value) wH_Invoice.WHI_Name = Convert.ToString(dr["WHI_Name"]);
            if (dr["WHI_Sum"] != DBNull.Value) wH_Invoice.WHI_Sum = Convert.ToDouble(dr["WHI_Sum"]);
            if (dr["WHI_Number"] != DBNull.Value) wH_Invoice.WHI_Number = Convert.ToString(dr["WHI_Number"]);
            if (dr["WHI_Date"] != DBNull.Value) wH_Invoice.WHI_Date = Convert.ToDateTime(dr["WHI_Date"]);
            if (dr["WHI_ProcMan"] != DBNull.Value) wH_Invoice.WHI_ProcMan = Convert.ToString(dr["WHI_ProcMan"]);
            if (dr["WHI_Bak"] != DBNull.Value) wH_Invoice.WHI_Bak = Convert.ToString(dr["WHI_Bak"]);
            if (dr["WHI_CType"] != DBNull.Value) wH_Invoice.WHI_CType = Convert.ToString(dr["WHI_CType"]);
            if (dr["WHI_CCode"] != DBNull.Value) wH_Invoice.WHI_CCode = Convert.ToString(dr["WHI_CCode"]);
            if (dr["Stat"] != DBNull.Value) wH_Invoice.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["CreateDate"] != DBNull.Value) wH_Invoice.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
            if (dr["UpdateDate"] != DBNull.Value) wH_Invoice.UpdateDate = Convert.ToDateTime(dr["UpdateDate"]);
            if (dr["DeleteDate"] != DBNull.Value) wH_Invoice.DeleteDate = Convert.ToDateTime(dr["DeleteDate"]);
            if (dr["WHI_PayStat"] != DBNull.Value) wH_Invoice.WHI_PayStat = Convert.ToString(dr["WHI_PayStat"]);
            if (dr["WHI_PayCode"] != DBNull.Value) wH_Invoice.WHI_PayCode = Convert.ToString(dr["WHI_PayCode"]);
            if (dr["WHI_SProcMan"] != DBNull.Value) wH_Invoice.WHI_SProcMan = Convert.ToString(dr["WHI_SProcMan"]);
            if (dr["WHI_Company"] != DBNull.Value) wH_Invoice.WHI_Company = Convert.ToString(dr["WHI_Company"]);
            if (dr["WHI_CompanyCode"] != DBNull.Value) wH_Invoice.WHI_CompanyCode = Convert.ToString(dr["WHI_CompanyCode"]);
            if (dr["WHI_Pay"] != DBNull.Value) wH_Invoice.WHI_Pay = Convert.ToDecimal(dr["WHI_Pay"]);
            if (dr["AuditStat"] != DBNull.Value) wH_Invoice.AuditStat = Convert.ToString(dr["AuditStat"]);
            if (dr["AuditCurAudit"] != DBNull.Value) wH_Invoice.AuditCurAudit = Convert.ToString(dr["AuditCurAudit"]);
            if (dr["WHI_RelSum"] != DBNull.Value) wH_Invoice.WHI_RelSum = Convert.ToDecimal(dr["WHI_RelSum"]);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   }  
         return wH_Invoice;
      }
      /// <summary>
      /// 获取指定的供应商发票信息 WH_Invoice对象集合
      /// </summary>
      public List<WH_Invoice> GetListByWhere(string strCondition)
      {
         List<WH_Invoice> ret = new List<WH_Invoice>();
         string sql = "SELECT  WHI_ID,WHI_Code,WHI_SCode,WHI_SName,WHI_Name,WHI_Sum,WHI_Number,WHI_Date,WHI_ProcMan,WHI_Bak,WHI_CType,WHI_CCode,Stat,CreateDate,UpdateDate,DeleteDate,WHI_PayStat,WHI_PayCode,WHI_SProcMan,WHI_Company,WHI_CompanyCode,WHI_Pay,AuditStat,AuditCurAudit,WHI_RelSum FROM WH_Invoice WHERE 1=1 AND ((Stat is null) or (Stat=0) ) ";
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
            WH_Invoice wH_Invoice = new WH_Invoice();
            if (dr["WHI_ID"] != DBNull.Value) wH_Invoice.WHI_ID = Convert.ToDecimal(dr["WHI_ID"]);
            if (dr["WHI_Code"] != DBNull.Value) wH_Invoice.WHI_Code = Convert.ToString(dr["WHI_Code"]);
            if (dr["WHI_SCode"] != DBNull.Value) wH_Invoice.WHI_SCode = Convert.ToString(dr["WHI_SCode"]);
            if (dr["WHI_SName"] != DBNull.Value) wH_Invoice.WHI_SName = Convert.ToString(dr["WHI_SName"]);
            if (dr["WHI_Name"] != DBNull.Value) wH_Invoice.WHI_Name = Convert.ToString(dr["WHI_Name"]);
            if (dr["WHI_Sum"] != DBNull.Value) wH_Invoice.WHI_Sum = Convert.ToDouble(dr["WHI_Sum"]);
            if (dr["WHI_Number"] != DBNull.Value) wH_Invoice.WHI_Number = Convert.ToString(dr["WHI_Number"]);
            if (dr["WHI_Date"] != DBNull.Value) wH_Invoice.WHI_Date = Convert.ToDateTime(dr["WHI_Date"]);
            if (dr["WHI_ProcMan"] != DBNull.Value) wH_Invoice.WHI_ProcMan = Convert.ToString(dr["WHI_ProcMan"]);
            if (dr["WHI_Bak"] != DBNull.Value) wH_Invoice.WHI_Bak = Convert.ToString(dr["WHI_Bak"]);
            if (dr["WHI_CType"] != DBNull.Value) wH_Invoice.WHI_CType = Convert.ToString(dr["WHI_CType"]);
            if (dr["WHI_CCode"] != DBNull.Value) wH_Invoice.WHI_CCode = Convert.ToString(dr["WHI_CCode"]);
            if (dr["Stat"] != DBNull.Value) wH_Invoice.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["CreateDate"] != DBNull.Value) wH_Invoice.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
            if (dr["UpdateDate"] != DBNull.Value) wH_Invoice.UpdateDate = Convert.ToDateTime(dr["UpdateDate"]);
            if (dr["DeleteDate"] != DBNull.Value) wH_Invoice.DeleteDate = Convert.ToDateTime(dr["DeleteDate"]);
            if (dr["WHI_PayStat"] != DBNull.Value) wH_Invoice.WHI_PayStat = Convert.ToString(dr["WHI_PayStat"]);
            if (dr["WHI_PayCode"] != DBNull.Value) wH_Invoice.WHI_PayCode = Convert.ToString(dr["WHI_PayCode"]);
            if (dr["WHI_SProcMan"] != DBNull.Value) wH_Invoice.WHI_SProcMan = Convert.ToString(dr["WHI_SProcMan"]);
            if (dr["WHI_Company"] != DBNull.Value) wH_Invoice.WHI_Company = Convert.ToString(dr["WHI_Company"]);
            if (dr["WHI_CompanyCode"] != DBNull.Value) wH_Invoice.WHI_CompanyCode = Convert.ToString(dr["WHI_CompanyCode"]);
            if (dr["WHI_Pay"] != DBNull.Value) wH_Invoice.WHI_Pay = Convert.ToDecimal(dr["WHI_Pay"]);
            if (dr["AuditStat"] != DBNull.Value) wH_Invoice.AuditStat = Convert.ToString(dr["AuditStat"]);
            if (dr["AuditCurAudit"] != DBNull.Value) wH_Invoice.AuditCurAudit = Convert.ToString(dr["AuditCurAudit"]);
            if (dr["WHI_RelSum"] != DBNull.Value) wH_Invoice.WHI_RelSum = Convert.ToDecimal(dr["WHI_RelSum"]);
            ret.Add(wH_Invoice);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   }  
         return ret;
      }
      /// <summary>
      /// 获取所有的供应商发票信息 WH_Invoice对象(即:一条记录
      /// </summary>
      public List<WH_Invoice> GetAll()
      {
         List<WH_Invoice> ret = new List<WH_Invoice>();
         string sql = "SELECT  WHI_ID,WHI_Code,WHI_SCode,WHI_SName,WHI_Name,WHI_Sum,WHI_Number,WHI_Date,WHI_ProcMan,WHI_Bak,WHI_CType,WHI_CCode,Stat,CreateDate,UpdateDate,DeleteDate,WHI_PayStat,WHI_PayCode,WHI_SProcMan,WHI_Company,WHI_CompanyCode,WHI_Pay,AuditStat,AuditCurAudit,WHI_RelSum FROM WH_Invoice where 1=1 AND ((Stat is null) or (Stat=0) ) order by WHI_ID desc ";
          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            WH_Invoice wH_Invoice = new WH_Invoice();
            if (dr["WHI_ID"] != DBNull.Value) wH_Invoice.WHI_ID = Convert.ToDecimal(dr["WHI_ID"]);
            if (dr["WHI_Code"] != DBNull.Value) wH_Invoice.WHI_Code = Convert.ToString(dr["WHI_Code"]);
            if (dr["WHI_SCode"] != DBNull.Value) wH_Invoice.WHI_SCode = Convert.ToString(dr["WHI_SCode"]);
            if (dr["WHI_SName"] != DBNull.Value) wH_Invoice.WHI_SName = Convert.ToString(dr["WHI_SName"]);
            if (dr["WHI_Name"] != DBNull.Value) wH_Invoice.WHI_Name = Convert.ToString(dr["WHI_Name"]);
            if (dr["WHI_Sum"] != DBNull.Value) wH_Invoice.WHI_Sum = Convert.ToDouble(dr["WHI_Sum"]);
            if (dr["WHI_Number"] != DBNull.Value) wH_Invoice.WHI_Number = Convert.ToString(dr["WHI_Number"]);
            if (dr["WHI_Date"] != DBNull.Value) wH_Invoice.WHI_Date = Convert.ToDateTime(dr["WHI_Date"]);
            if (dr["WHI_ProcMan"] != DBNull.Value) wH_Invoice.WHI_ProcMan = Convert.ToString(dr["WHI_ProcMan"]);
            if (dr["WHI_Bak"] != DBNull.Value) wH_Invoice.WHI_Bak = Convert.ToString(dr["WHI_Bak"]);
            if (dr["WHI_CType"] != DBNull.Value) wH_Invoice.WHI_CType = Convert.ToString(dr["WHI_CType"]);
            if (dr["WHI_CCode"] != DBNull.Value) wH_Invoice.WHI_CCode = Convert.ToString(dr["WHI_CCode"]);
            if (dr["Stat"] != DBNull.Value) wH_Invoice.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["CreateDate"] != DBNull.Value) wH_Invoice.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
            if (dr["UpdateDate"] != DBNull.Value) wH_Invoice.UpdateDate = Convert.ToDateTime(dr["UpdateDate"]);
            if (dr["DeleteDate"] != DBNull.Value) wH_Invoice.DeleteDate = Convert.ToDateTime(dr["DeleteDate"]);
            if (dr["WHI_PayStat"] != DBNull.Value) wH_Invoice.WHI_PayStat = Convert.ToString(dr["WHI_PayStat"]);
            if (dr["WHI_PayCode"] != DBNull.Value) wH_Invoice.WHI_PayCode = Convert.ToString(dr["WHI_PayCode"]);
            if (dr["WHI_SProcMan"] != DBNull.Value) wH_Invoice.WHI_SProcMan = Convert.ToString(dr["WHI_SProcMan"]);
            if (dr["WHI_Company"] != DBNull.Value) wH_Invoice.WHI_Company = Convert.ToString(dr["WHI_Company"]);
            if (dr["WHI_CompanyCode"] != DBNull.Value) wH_Invoice.WHI_CompanyCode = Convert.ToString(dr["WHI_CompanyCode"]);
            if (dr["WHI_Pay"] != DBNull.Value) wH_Invoice.WHI_Pay = Convert.ToDecimal(dr["WHI_Pay"]);
            if (dr["AuditStat"] != DBNull.Value) wH_Invoice.AuditStat = Convert.ToString(dr["AuditStat"]);
            if (dr["AuditCurAudit"] != DBNull.Value) wH_Invoice.AuditCurAudit = Convert.ToString(dr["AuditCurAudit"]);
            if (dr["WHI_RelSum"] != DBNull.Value) wH_Invoice.WHI_RelSum = Convert.ToDecimal(dr["WHI_RelSum"]);
            ret.Add(wH_Invoice);
         }
          }catch (System.Exception ex){ throw ex; }  finally {  if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   } 
         return ret;
      }
   }
}
