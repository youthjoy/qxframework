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
   /// 物料移动单据
   /// </summary>
   [Serializable]
   public partial class ADOWH_Movement
   {
      public IDBOperator idb =  DBOperator.GetInstance();
      /// <summary>
      /// 添加物料移动单据 WH_Movement对象(即:一条记录)
      /// </summary>
      public int Add(WH_Movement wH_Movement)
      {
         string sql = "INSERT INTO WH_Movement (MV_RecordCode,MV_MType,MV_RefKey,MV_RefRecord,Creator,CreateTime,UPTStuff,UPTDate,DELStuff,DELDate,MV_CustCode,MV_CustName,MV_CustRef,MV_CustDate,MV_VerifyStep,MV_VerifyStuff,MV_VerifyDate,MV_VerifyStat,MV_ContractNo,Stat,MV_ReciveStaus) VALUES (@MV_RecordCode,@MV_MType,@MV_RefKey,@MV_RefRecord,@Creator,@CreateTime,@UPTStuff,@UPTDate,@DELStuff,@DELDate,@MV_CustCode,@MV_CustName,@MV_CustRef,@MV_CustDate,@MV_VerifyStep,@MV_VerifyStuff,@MV_VerifyDate,@MV_VerifyStat,@MV_ContractNo,@Stat,@MV_ReciveStaus)";
         if (string.IsNullOrEmpty(wH_Movement.MV_RecordCode))
         {
            idb.AddParameter("@MV_RecordCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@MV_RecordCode", wH_Movement.MV_RecordCode);
         }
         if (string.IsNullOrEmpty(wH_Movement.MV_MType))
         {
            idb.AddParameter("@MV_MType", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@MV_MType", wH_Movement.MV_MType);
         }
         if (string.IsNullOrEmpty(wH_Movement.MV_RefKey))
         {
            idb.AddParameter("@MV_RefKey", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@MV_RefKey", wH_Movement.MV_RefKey);
         }
         if (string.IsNullOrEmpty(wH_Movement.MV_RefRecord))
         {
            idb.AddParameter("@MV_RefRecord", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@MV_RefRecord", wH_Movement.MV_RefRecord);
         }
         if (string.IsNullOrEmpty(wH_Movement.Creator))
         {
            idb.AddParameter("@Creator", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Creator", wH_Movement.Creator);
         }
         if (wH_Movement.CreateTime == DateTime.MinValue)
         {
            idb.AddParameter("@CreateTime", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateTime", wH_Movement.CreateTime);
         }
         if (string.IsNullOrEmpty(wH_Movement.UPTStuff))
         {
            idb.AddParameter("@UPTStuff", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@UPTStuff", wH_Movement.UPTStuff);
         }
         if (wH_Movement.UPTDate == DateTime.MinValue)
         {
            idb.AddParameter("@UPTDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@UPTDate", wH_Movement.UPTDate);
         }
         if (string.IsNullOrEmpty(wH_Movement.DELStuff))
         {
            idb.AddParameter("@DELStuff", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DELStuff", wH_Movement.DELStuff);
         }
         if (wH_Movement.DELDate == DateTime.MinValue)
         {
            idb.AddParameter("@DELDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DELDate", wH_Movement.DELDate);
         }
         if (string.IsNullOrEmpty(wH_Movement.MV_CustCode))
         {
            idb.AddParameter("@MV_CustCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@MV_CustCode", wH_Movement.MV_CustCode);
         }
         if (string.IsNullOrEmpty(wH_Movement.MV_CustName))
         {
            idb.AddParameter("@MV_CustName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@MV_CustName", wH_Movement.MV_CustName);
         }
         if (string.IsNullOrEmpty(wH_Movement.MV_CustRef))
         {
            idb.AddParameter("@MV_CustRef", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@MV_CustRef", wH_Movement.MV_CustRef);
         }
         if (wH_Movement.MV_CustDate == DateTime.MinValue)
         {
            idb.AddParameter("@MV_CustDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@MV_CustDate", wH_Movement.MV_CustDate);
         }
         if (string.IsNullOrEmpty(wH_Movement.MV_VerifyStep))
         {
            idb.AddParameter("@MV_VerifyStep", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@MV_VerifyStep", wH_Movement.MV_VerifyStep);
         }
         if (string.IsNullOrEmpty(wH_Movement.MV_VerifyStuff))
         {
            idb.AddParameter("@MV_VerifyStuff", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@MV_VerifyStuff", wH_Movement.MV_VerifyStuff);
         }
         if (wH_Movement.MV_VerifyDate == DateTime.MinValue)
         {
            idb.AddParameter("@MV_VerifyDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@MV_VerifyDate", wH_Movement.MV_VerifyDate);
         }
         if (string.IsNullOrEmpty(wH_Movement.MV_VerifyStat))
         {
            idb.AddParameter("@MV_VerifyStat", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@MV_VerifyStat", wH_Movement.MV_VerifyStat);
         }
         if (string.IsNullOrEmpty(wH_Movement.MV_ContractNo))
         {
            idb.AddParameter("@MV_ContractNo", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@MV_ContractNo", wH_Movement.MV_ContractNo);
         }
         if (wH_Movement.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", wH_Movement.Stat);
         }
         if (string.IsNullOrEmpty(wH_Movement.MV_ReciveStaus))
         {
            idb.AddParameter("@MV_ReciveStaus", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@MV_ReciveStaus", wH_Movement.MV_ReciveStaus);
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
      /// 添加物料移动单据 WH_Movement对象(即:一条记录)
      /// </summary>
      public object AddWithReturn(WH_Movement wH_Movement)
      {
         string sql = "INSERT INTO WH_Movement (MV_RecordCode,MV_MType,MV_RefKey,MV_RefRecord,Creator,CreateTime,UPTStuff,UPTDate,DELStuff,DELDate,MV_CustCode,MV_CustName,MV_CustRef,MV_CustDate,MV_VerifyStep,MV_VerifyStuff,MV_VerifyDate,MV_VerifyStat,MV_ContractNo,Stat,MV_ReciveStaus) VALUES (@MV_RecordCode,@MV_MType,@MV_RefKey,@MV_RefRecord,@Creator,@CreateTime,@UPTStuff,@UPTDate,@DELStuff,@DELDate,@MV_CustCode,@MV_CustName,@MV_CustRef,@MV_CustDate,@MV_VerifyStep,@MV_VerifyStuff,@MV_VerifyDate,@MV_VerifyStat,@MV_ContractNo,@Stat,@MV_ReciveStaus);SELECT @@IDENTITY AS ReturnID;";
         if (string.IsNullOrEmpty(wH_Movement.MV_RecordCode))
         {
            idb.AddParameter("@MV_RecordCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@MV_RecordCode", wH_Movement.MV_RecordCode);
         }
         if (string.IsNullOrEmpty(wH_Movement.MV_MType))
         {
            idb.AddParameter("@MV_MType", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@MV_MType", wH_Movement.MV_MType);
         }
         if (string.IsNullOrEmpty(wH_Movement.MV_RefKey))
         {
            idb.AddParameter("@MV_RefKey", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@MV_RefKey", wH_Movement.MV_RefKey);
         }
         if (string.IsNullOrEmpty(wH_Movement.MV_RefRecord))
         {
            idb.AddParameter("@MV_RefRecord", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@MV_RefRecord", wH_Movement.MV_RefRecord);
         }
         if (string.IsNullOrEmpty(wH_Movement.Creator))
         {
            idb.AddParameter("@Creator", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Creator", wH_Movement.Creator);
         }
         if (wH_Movement.CreateTime == DateTime.MinValue)
         {
            idb.AddParameter("@CreateTime", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateTime", wH_Movement.CreateTime);
         }
         if (string.IsNullOrEmpty(wH_Movement.UPTStuff))
         {
            idb.AddParameter("@UPTStuff", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@UPTStuff", wH_Movement.UPTStuff);
         }
         if (wH_Movement.UPTDate == DateTime.MinValue)
         {
            idb.AddParameter("@UPTDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@UPTDate", wH_Movement.UPTDate);
         }
         if (string.IsNullOrEmpty(wH_Movement.DELStuff))
         {
            idb.AddParameter("@DELStuff", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DELStuff", wH_Movement.DELStuff);
         }
         if (wH_Movement.DELDate == DateTime.MinValue)
         {
            idb.AddParameter("@DELDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DELDate", wH_Movement.DELDate);
         }
         if (string.IsNullOrEmpty(wH_Movement.MV_CustCode))
         {
            idb.AddParameter("@MV_CustCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@MV_CustCode", wH_Movement.MV_CustCode);
         }
         if (string.IsNullOrEmpty(wH_Movement.MV_CustName))
         {
            idb.AddParameter("@MV_CustName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@MV_CustName", wH_Movement.MV_CustName);
         }
         if (string.IsNullOrEmpty(wH_Movement.MV_CustRef))
         {
            idb.AddParameter("@MV_CustRef", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@MV_CustRef", wH_Movement.MV_CustRef);
         }
         if (wH_Movement.MV_CustDate == DateTime.MinValue)
         {
            idb.AddParameter("@MV_CustDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@MV_CustDate", wH_Movement.MV_CustDate);
         }
         if (string.IsNullOrEmpty(wH_Movement.MV_VerifyStep))
         {
            idb.AddParameter("@MV_VerifyStep", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@MV_VerifyStep", wH_Movement.MV_VerifyStep);
         }
         if (string.IsNullOrEmpty(wH_Movement.MV_VerifyStuff))
         {
            idb.AddParameter("@MV_VerifyStuff", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@MV_VerifyStuff", wH_Movement.MV_VerifyStuff);
         }
         if (wH_Movement.MV_VerifyDate == DateTime.MinValue)
         {
            idb.AddParameter("@MV_VerifyDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@MV_VerifyDate", wH_Movement.MV_VerifyDate);
         }
         if (string.IsNullOrEmpty(wH_Movement.MV_VerifyStat))
         {
            idb.AddParameter("@MV_VerifyStat", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@MV_VerifyStat", wH_Movement.MV_VerifyStat);
         }
         if (string.IsNullOrEmpty(wH_Movement.MV_ContractNo))
         {
            idb.AddParameter("@MV_ContractNo", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@MV_ContractNo", wH_Movement.MV_ContractNo);
         }
         if (wH_Movement.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", wH_Movement.Stat);
         }
         if (string.IsNullOrEmpty(wH_Movement.MV_ReciveStaus))
         {
            idb.AddParameter("@MV_ReciveStaus", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@MV_ReciveStaus", wH_Movement.MV_ReciveStaus);
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
      /// 更新物料移动单据 WH_Movement对象(即:一条记录
      /// </summary>
      public int Update(WH_Movement wH_Movement)
      {
         
         StringBuilder sbParameter=new StringBuilder();
      StringBuilder sb=new StringBuilder();
      sb.Append(@"UPDATE       WH_Movement       SET ");
            if(wH_Movement.MV_RecordCode_IsChanged){sbParameter.Append("MV_RecordCode=@MV_RecordCode, ");}
      if(wH_Movement.MV_MType_IsChanged){sbParameter.Append("MV_MType=@MV_MType, ");}
      if(wH_Movement.MV_RefKey_IsChanged){sbParameter.Append("MV_RefKey=@MV_RefKey, ");}
      if(wH_Movement.MV_RefRecord_IsChanged){sbParameter.Append("MV_RefRecord=@MV_RefRecord, ");}
      if(wH_Movement.Creator_IsChanged){sbParameter.Append("Creator=@Creator, ");}
      if(wH_Movement.CreateTime_IsChanged){sbParameter.Append("CreateTime=@CreateTime, ");}
      if(wH_Movement.UPTStuff_IsChanged){sbParameter.Append("UPTStuff=@UPTStuff, ");}
      if(wH_Movement.UPTDate_IsChanged){sbParameter.Append("UPTDate=@UPTDate, ");}
      if(wH_Movement.DELStuff_IsChanged){sbParameter.Append("DELStuff=@DELStuff, ");}
      if(wH_Movement.DELDate_IsChanged){sbParameter.Append("DELDate=@DELDate, ");}
      if(wH_Movement.MV_CustCode_IsChanged){sbParameter.Append("MV_CustCode=@MV_CustCode, ");}
      if(wH_Movement.MV_CustName_IsChanged){sbParameter.Append("MV_CustName=@MV_CustName, ");}
      if(wH_Movement.MV_CustRef_IsChanged){sbParameter.Append("MV_CustRef=@MV_CustRef, ");}
      if(wH_Movement.MV_CustDate_IsChanged){sbParameter.Append("MV_CustDate=@MV_CustDate, ");}
      if(wH_Movement.MV_VerifyStep_IsChanged){sbParameter.Append("MV_VerifyStep=@MV_VerifyStep, ");}
      if(wH_Movement.MV_VerifyStuff_IsChanged){sbParameter.Append("MV_VerifyStuff=@MV_VerifyStuff, ");}
      if(wH_Movement.MV_VerifyDate_IsChanged){sbParameter.Append("MV_VerifyDate=@MV_VerifyDate, ");}
      if(wH_Movement.MV_VerifyStat_IsChanged){sbParameter.Append("MV_VerifyStat=@MV_VerifyStat, ");}
      if(wH_Movement.MV_ContractNo_IsChanged){sbParameter.Append("MV_ContractNo=@MV_ContractNo, ");}
      if(wH_Movement.Stat_IsChanged){sbParameter.Append("Stat=@Stat, ");}
      if(wH_Movement.MV_ReciveStaus_IsChanged){sbParameter.Append("MV_ReciveStaus=@MV_ReciveStaus ");}          sb.Append(sbParameter.ToString().Trim().TrimEnd(',')); 
      sb.Append(      " WHERE 1=1 AND ((Stat is null) or (Stat=0))   and MV_ID=@MV_ID; " );
      string sql=sb.ToString();
         if(wH_Movement.MV_RecordCode_IsChanged)
         {
         if (string.IsNullOrEmpty(wH_Movement.MV_RecordCode))
         {
            idb.AddParameter("@MV_RecordCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@MV_RecordCode", wH_Movement.MV_RecordCode);
         }
          }
         if(wH_Movement.MV_MType_IsChanged)
         {
         if (string.IsNullOrEmpty(wH_Movement.MV_MType))
         {
            idb.AddParameter("@MV_MType", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@MV_MType", wH_Movement.MV_MType);
         }
          }
         if(wH_Movement.MV_RefKey_IsChanged)
         {
         if (string.IsNullOrEmpty(wH_Movement.MV_RefKey))
         {
            idb.AddParameter("@MV_RefKey", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@MV_RefKey", wH_Movement.MV_RefKey);
         }
          }
         if(wH_Movement.MV_RefRecord_IsChanged)
         {
         if (string.IsNullOrEmpty(wH_Movement.MV_RefRecord))
         {
            idb.AddParameter("@MV_RefRecord", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@MV_RefRecord", wH_Movement.MV_RefRecord);
         }
          }
         if(wH_Movement.Creator_IsChanged)
         {
         if (string.IsNullOrEmpty(wH_Movement.Creator))
         {
            idb.AddParameter("@Creator", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Creator", wH_Movement.Creator);
         }
          }
         if(wH_Movement.CreateTime_IsChanged)
         {
         if (wH_Movement.CreateTime == DateTime.MinValue)
         {
            idb.AddParameter("@CreateTime", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateTime", wH_Movement.CreateTime);
         }
          }
         if(wH_Movement.UPTStuff_IsChanged)
         {
         if (string.IsNullOrEmpty(wH_Movement.UPTStuff))
         {
            idb.AddParameter("@UPTStuff", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@UPTStuff", wH_Movement.UPTStuff);
         }
          }
         if(wH_Movement.UPTDate_IsChanged)
         {
         if (wH_Movement.UPTDate == DateTime.MinValue)
         {
            idb.AddParameter("@UPTDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@UPTDate", wH_Movement.UPTDate);
         }
          }
         if(wH_Movement.DELStuff_IsChanged)
         {
         if (string.IsNullOrEmpty(wH_Movement.DELStuff))
         {
            idb.AddParameter("@DELStuff", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DELStuff", wH_Movement.DELStuff);
         }
          }
         if(wH_Movement.DELDate_IsChanged)
         {
         if (wH_Movement.DELDate == DateTime.MinValue)
         {
            idb.AddParameter("@DELDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DELDate", wH_Movement.DELDate);
         }
          }
         if(wH_Movement.MV_CustCode_IsChanged)
         {
         if (string.IsNullOrEmpty(wH_Movement.MV_CustCode))
         {
            idb.AddParameter("@MV_CustCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@MV_CustCode", wH_Movement.MV_CustCode);
         }
          }
         if(wH_Movement.MV_CustName_IsChanged)
         {
         if (string.IsNullOrEmpty(wH_Movement.MV_CustName))
         {
            idb.AddParameter("@MV_CustName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@MV_CustName", wH_Movement.MV_CustName);
         }
          }
         if(wH_Movement.MV_CustRef_IsChanged)
         {
         if (string.IsNullOrEmpty(wH_Movement.MV_CustRef))
         {
            idb.AddParameter("@MV_CustRef", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@MV_CustRef", wH_Movement.MV_CustRef);
         }
          }
         if(wH_Movement.MV_CustDate_IsChanged)
         {
         if (wH_Movement.MV_CustDate == DateTime.MinValue)
         {
            idb.AddParameter("@MV_CustDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@MV_CustDate", wH_Movement.MV_CustDate);
         }
          }
         if(wH_Movement.MV_VerifyStep_IsChanged)
         {
         if (string.IsNullOrEmpty(wH_Movement.MV_VerifyStep))
         {
            idb.AddParameter("@MV_VerifyStep", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@MV_VerifyStep", wH_Movement.MV_VerifyStep);
         }
          }
         if(wH_Movement.MV_VerifyStuff_IsChanged)
         {
         if (string.IsNullOrEmpty(wH_Movement.MV_VerifyStuff))
         {
            idb.AddParameter("@MV_VerifyStuff", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@MV_VerifyStuff", wH_Movement.MV_VerifyStuff);
         }
          }
         if(wH_Movement.MV_VerifyDate_IsChanged)
         {
         if (wH_Movement.MV_VerifyDate == DateTime.MinValue)
         {
            idb.AddParameter("@MV_VerifyDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@MV_VerifyDate", wH_Movement.MV_VerifyDate);
         }
          }
         if(wH_Movement.MV_VerifyStat_IsChanged)
         {
         if (string.IsNullOrEmpty(wH_Movement.MV_VerifyStat))
         {
            idb.AddParameter("@MV_VerifyStat", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@MV_VerifyStat", wH_Movement.MV_VerifyStat);
         }
          }
         if(wH_Movement.MV_ContractNo_IsChanged)
         {
         if (string.IsNullOrEmpty(wH_Movement.MV_ContractNo))
         {
            idb.AddParameter("@MV_ContractNo", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@MV_ContractNo", wH_Movement.MV_ContractNo);
         }
          }
         if(wH_Movement.Stat_IsChanged)
         {
         if (wH_Movement.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", wH_Movement.Stat);
         }
          }
         if(wH_Movement.MV_ReciveStaus_IsChanged)
         {
         if (string.IsNullOrEmpty(wH_Movement.MV_ReciveStaus))
         {
            idb.AddParameter("@MV_ReciveStaus", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@MV_ReciveStaus", wH_Movement.MV_ReciveStaus);
         }
          }

         idb.AddParameter("@MV_ID", wH_Movement.MV_ID);

           
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
      /// 删除物料移动单据 WH_Movement对象(即:一条记录
      /// </summary>
      public int Delete(decimal mV_ID)
      {
         string sql = "DELETE WH_Movement WHERE 1=1  AND MV_ID=@MV_ID ";
         idb.AddParameter("@MV_ID", mV_ID);

           
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
      /// 获取指定的物料移动单据 WH_Movement对象(即:一条记录
      /// </summary>
      public WH_Movement GetByKey(decimal mV_ID)
      {
         WH_Movement wH_Movement = new WH_Movement();
         string sql = "SELECT  MV_ID,MV_RecordCode,MV_MType,MV_RefKey,MV_RefRecord,Creator,CreateTime,UPTStuff,UPTDate,DELStuff,DELDate,MV_CustCode,MV_CustName,MV_CustRef,MV_CustDate,MV_VerifyStep,MV_VerifyStuff,MV_VerifyDate,MV_VerifyStat,MV_ContractNo,Stat,MV_ReciveStaus FROM WH_Movement WHERE 1=1 AND ((Stat is null) or (Stat=0) )  AND MV_ID=@MV_ID ";
         idb.AddParameter("@MV_ID", mV_ID);

          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            if (dr["MV_ID"] != DBNull.Value) wH_Movement.MV_ID = Convert.ToDecimal(dr["MV_ID"]);
            if (dr["MV_RecordCode"] != DBNull.Value) wH_Movement.MV_RecordCode = Convert.ToString(dr["MV_RecordCode"]);
            if (dr["MV_MType"] != DBNull.Value) wH_Movement.MV_MType = Convert.ToString(dr["MV_MType"]);
            if (dr["MV_RefKey"] != DBNull.Value) wH_Movement.MV_RefKey = Convert.ToString(dr["MV_RefKey"]);
            if (dr["MV_RefRecord"] != DBNull.Value) wH_Movement.MV_RefRecord = Convert.ToString(dr["MV_RefRecord"]);
            if (dr["Creator"] != DBNull.Value) wH_Movement.Creator = Convert.ToString(dr["Creator"]);
            if (dr["CreateTime"] != DBNull.Value) wH_Movement.CreateTime = Convert.ToDateTime(dr["CreateTime"]);
            if (dr["UPTStuff"] != DBNull.Value) wH_Movement.UPTStuff = Convert.ToString(dr["UPTStuff"]);
            if (dr["UPTDate"] != DBNull.Value) wH_Movement.UPTDate = Convert.ToDateTime(dr["UPTDate"]);
            if (dr["DELStuff"] != DBNull.Value) wH_Movement.DELStuff = Convert.ToString(dr["DELStuff"]);
            if (dr["DELDate"] != DBNull.Value) wH_Movement.DELDate = Convert.ToDateTime(dr["DELDate"]);
            if (dr["MV_CustCode"] != DBNull.Value) wH_Movement.MV_CustCode = Convert.ToString(dr["MV_CustCode"]);
            if (dr["MV_CustName"] != DBNull.Value) wH_Movement.MV_CustName = Convert.ToString(dr["MV_CustName"]);
            if (dr["MV_CustRef"] != DBNull.Value) wH_Movement.MV_CustRef = Convert.ToString(dr["MV_CustRef"]);
            if (dr["MV_CustDate"] != DBNull.Value) wH_Movement.MV_CustDate = Convert.ToDateTime(dr["MV_CustDate"]);
            if (dr["MV_VerifyStep"] != DBNull.Value) wH_Movement.MV_VerifyStep = Convert.ToString(dr["MV_VerifyStep"]);
            if (dr["MV_VerifyStuff"] != DBNull.Value) wH_Movement.MV_VerifyStuff = Convert.ToString(dr["MV_VerifyStuff"]);
            if (dr["MV_VerifyDate"] != DBNull.Value) wH_Movement.MV_VerifyDate = Convert.ToDateTime(dr["MV_VerifyDate"]);
            if (dr["MV_VerifyStat"] != DBNull.Value) wH_Movement.MV_VerifyStat = Convert.ToString(dr["MV_VerifyStat"]);
            if (dr["MV_ContractNo"] != DBNull.Value) wH_Movement.MV_ContractNo = Convert.ToString(dr["MV_ContractNo"]);
            if (dr["Stat"] != DBNull.Value) wH_Movement.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["MV_ReciveStaus"] != DBNull.Value) wH_Movement.MV_ReciveStaus = Convert.ToString(dr["MV_ReciveStaus"]);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   }  
         return wH_Movement;
      }
      /// <summary>
      /// 获取指定的物料移动单据 WH_Movement对象集合
      /// </summary>
      public List<WH_Movement> GetListByWhere(string strCondition)
      {
         List<WH_Movement> ret = new List<WH_Movement>();
         string sql = "SELECT  MV_ID,MV_RecordCode,MV_MType,MV_RefKey,MV_RefRecord,Creator,CreateTime,UPTStuff,UPTDate,DELStuff,DELDate,MV_CustCode,MV_CustName,MV_CustRef,MV_CustDate,MV_VerifyStep,MV_VerifyStuff,MV_VerifyDate,MV_VerifyStat,MV_ContractNo,Stat,MV_ReciveStaus FROM WH_Movement WHERE 1=1 AND ((Stat is null) or (Stat=0) ) ";
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
            WH_Movement wH_Movement = new WH_Movement();
            if (dr["MV_ID"] != DBNull.Value) wH_Movement.MV_ID = Convert.ToDecimal(dr["MV_ID"]);
            if (dr["MV_RecordCode"] != DBNull.Value) wH_Movement.MV_RecordCode = Convert.ToString(dr["MV_RecordCode"]);
            if (dr["MV_MType"] != DBNull.Value) wH_Movement.MV_MType = Convert.ToString(dr["MV_MType"]);
            if (dr["MV_RefKey"] != DBNull.Value) wH_Movement.MV_RefKey = Convert.ToString(dr["MV_RefKey"]);
            if (dr["MV_RefRecord"] != DBNull.Value) wH_Movement.MV_RefRecord = Convert.ToString(dr["MV_RefRecord"]);
            if (dr["Creator"] != DBNull.Value) wH_Movement.Creator = Convert.ToString(dr["Creator"]);
            if (dr["CreateTime"] != DBNull.Value) wH_Movement.CreateTime = Convert.ToDateTime(dr["CreateTime"]);
            if (dr["UPTStuff"] != DBNull.Value) wH_Movement.UPTStuff = Convert.ToString(dr["UPTStuff"]);
            if (dr["UPTDate"] != DBNull.Value) wH_Movement.UPTDate = Convert.ToDateTime(dr["UPTDate"]);
            if (dr["DELStuff"] != DBNull.Value) wH_Movement.DELStuff = Convert.ToString(dr["DELStuff"]);
            if (dr["DELDate"] != DBNull.Value) wH_Movement.DELDate = Convert.ToDateTime(dr["DELDate"]);
            if (dr["MV_CustCode"] != DBNull.Value) wH_Movement.MV_CustCode = Convert.ToString(dr["MV_CustCode"]);
            if (dr["MV_CustName"] != DBNull.Value) wH_Movement.MV_CustName = Convert.ToString(dr["MV_CustName"]);
            if (dr["MV_CustRef"] != DBNull.Value) wH_Movement.MV_CustRef = Convert.ToString(dr["MV_CustRef"]);
            if (dr["MV_CustDate"] != DBNull.Value) wH_Movement.MV_CustDate = Convert.ToDateTime(dr["MV_CustDate"]);
            if (dr["MV_VerifyStep"] != DBNull.Value) wH_Movement.MV_VerifyStep = Convert.ToString(dr["MV_VerifyStep"]);
            if (dr["MV_VerifyStuff"] != DBNull.Value) wH_Movement.MV_VerifyStuff = Convert.ToString(dr["MV_VerifyStuff"]);
            if (dr["MV_VerifyDate"] != DBNull.Value) wH_Movement.MV_VerifyDate = Convert.ToDateTime(dr["MV_VerifyDate"]);
            if (dr["MV_VerifyStat"] != DBNull.Value) wH_Movement.MV_VerifyStat = Convert.ToString(dr["MV_VerifyStat"]);
            if (dr["MV_ContractNo"] != DBNull.Value) wH_Movement.MV_ContractNo = Convert.ToString(dr["MV_ContractNo"]);
            if (dr["Stat"] != DBNull.Value) wH_Movement.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["MV_ReciveStaus"] != DBNull.Value) wH_Movement.MV_ReciveStaus = Convert.ToString(dr["MV_ReciveStaus"]);
            ret.Add(wH_Movement);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   }  
         return ret;
      }
      /// <summary>
      /// 获取所有的物料移动单据 WH_Movement对象(即:一条记录
      /// </summary>
      public List<WH_Movement> GetAll()
      {
         List<WH_Movement> ret = new List<WH_Movement>();
         string sql = "SELECT  MV_ID,MV_RecordCode,MV_MType,MV_RefKey,MV_RefRecord,Creator,CreateTime,UPTStuff,UPTDate,DELStuff,DELDate,MV_CustCode,MV_CustName,MV_CustRef,MV_CustDate,MV_VerifyStep,MV_VerifyStuff,MV_VerifyDate,MV_VerifyStat,MV_ContractNo,Stat,MV_ReciveStaus FROM WH_Movement where 1=1 AND ((Stat is null) or (Stat=0) ) order by MV_ID desc ";
          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            WH_Movement wH_Movement = new WH_Movement();
            if (dr["MV_ID"] != DBNull.Value) wH_Movement.MV_ID = Convert.ToDecimal(dr["MV_ID"]);
            if (dr["MV_RecordCode"] != DBNull.Value) wH_Movement.MV_RecordCode = Convert.ToString(dr["MV_RecordCode"]);
            if (dr["MV_MType"] != DBNull.Value) wH_Movement.MV_MType = Convert.ToString(dr["MV_MType"]);
            if (dr["MV_RefKey"] != DBNull.Value) wH_Movement.MV_RefKey = Convert.ToString(dr["MV_RefKey"]);
            if (dr["MV_RefRecord"] != DBNull.Value) wH_Movement.MV_RefRecord = Convert.ToString(dr["MV_RefRecord"]);
            if (dr["Creator"] != DBNull.Value) wH_Movement.Creator = Convert.ToString(dr["Creator"]);
            if (dr["CreateTime"] != DBNull.Value) wH_Movement.CreateTime = Convert.ToDateTime(dr["CreateTime"]);
            if (dr["UPTStuff"] != DBNull.Value) wH_Movement.UPTStuff = Convert.ToString(dr["UPTStuff"]);
            if (dr["UPTDate"] != DBNull.Value) wH_Movement.UPTDate = Convert.ToDateTime(dr["UPTDate"]);
            if (dr["DELStuff"] != DBNull.Value) wH_Movement.DELStuff = Convert.ToString(dr["DELStuff"]);
            if (dr["DELDate"] != DBNull.Value) wH_Movement.DELDate = Convert.ToDateTime(dr["DELDate"]);
            if (dr["MV_CustCode"] != DBNull.Value) wH_Movement.MV_CustCode = Convert.ToString(dr["MV_CustCode"]);
            if (dr["MV_CustName"] != DBNull.Value) wH_Movement.MV_CustName = Convert.ToString(dr["MV_CustName"]);
            if (dr["MV_CustRef"] != DBNull.Value) wH_Movement.MV_CustRef = Convert.ToString(dr["MV_CustRef"]);
            if (dr["MV_CustDate"] != DBNull.Value) wH_Movement.MV_CustDate = Convert.ToDateTime(dr["MV_CustDate"]);
            if (dr["MV_VerifyStep"] != DBNull.Value) wH_Movement.MV_VerifyStep = Convert.ToString(dr["MV_VerifyStep"]);
            if (dr["MV_VerifyStuff"] != DBNull.Value) wH_Movement.MV_VerifyStuff = Convert.ToString(dr["MV_VerifyStuff"]);
            if (dr["MV_VerifyDate"] != DBNull.Value) wH_Movement.MV_VerifyDate = Convert.ToDateTime(dr["MV_VerifyDate"]);
            if (dr["MV_VerifyStat"] != DBNull.Value) wH_Movement.MV_VerifyStat = Convert.ToString(dr["MV_VerifyStat"]);
            if (dr["MV_ContractNo"] != DBNull.Value) wH_Movement.MV_ContractNo = Convert.ToString(dr["MV_ContractNo"]);
            if (dr["Stat"] != DBNull.Value) wH_Movement.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["MV_ReciveStaus"] != DBNull.Value) wH_Movement.MV_ReciveStaus = Convert.ToString(dr["MV_ReciveStaus"]);
            ret.Add(wH_Movement);
         }
          }catch (System.Exception ex){ throw ex; }  finally {  if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   } 
         return ret;
      }
   }
}
