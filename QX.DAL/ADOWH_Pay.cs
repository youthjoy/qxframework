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
   /// 付款
   /// </summary>
   [Serializable]
   public partial class ADOWH_Pay
   {
      public IDBOperator idb =  DBOperator.GetInstance();
      /// <summary>
      /// 添加付款 WH_Pay对象(即:一条记录)
      /// </summary>
      public int Add(WH_Pay wH_Pay)
      {
         string sql = "INSERT INTO WH_Pay (WHPP_Code,WHPP_Period,WHPP_Type,WHPP_Reason,WHPP_CompanyCode,WHPP_CompanyName,WHPP_SCode,WHPP_SName,WHPP_Date,WHPP_PName,WHPP_PayMethod,WHPP_Sum,WHPP_RefType,WHPP_RefCode,WHPP_FOwner,WHPP_POwner,WHPP_Bak,Stat,CreateDate,UpdateDate,DeleteDate,WHPP_LastMonth,WHPP_CurMonth,WHPP_NextMonth,WHPP_broom,WHPP_CurPay,WHPP_Plan,WHPP_Recive,WHPP_UDEF1,WHPP_UDEF2,WHPP_UDEF3,WHPP_UDEF4,WHPP_UDEF5,WHPP_UDEF6,WHPP_UDEF7,WHPP_UDEF8,WHPP_UDEF9,WHPP_UDEF10,WHPP_RelSum,WHPP_Pay,AuditStat,AuditCurAudit) VALUES (@WHPP_Code,@WHPP_Period,@WHPP_Type,@WHPP_Reason,@WHPP_CompanyCode,@WHPP_CompanyName,@WHPP_SCode,@WHPP_SName,@WHPP_Date,@WHPP_PName,@WHPP_PayMethod,@WHPP_Sum,@WHPP_RefType,@WHPP_RefCode,@WHPP_FOwner,@WHPP_POwner,@WHPP_Bak,@Stat,@CreateDate,@UpdateDate,@DeleteDate,@WHPP_LastMonth,@WHPP_CurMonth,@WHPP_NextMonth,@WHPP_broom,@WHPP_CurPay,@WHPP_Plan,@WHPP_Recive,@WHPP_UDEF1,@WHPP_UDEF2,@WHPP_UDEF3,@WHPP_UDEF4,@WHPP_UDEF5,@WHPP_UDEF6,@WHPP_UDEF7,@WHPP_UDEF8,@WHPP_UDEF9,@WHPP_UDEF10,@WHPP_RelSum,@WHPP_Pay,@AuditStat,@AuditCurAudit)";
         if (string.IsNullOrEmpty(wH_Pay.WHPP_Code))
         {
            idb.AddParameter("@WHPP_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHPP_Code", wH_Pay.WHPP_Code);
         }
         if (string.IsNullOrEmpty(wH_Pay.WHPP_Period))
         {
            idb.AddParameter("@WHPP_Period", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHPP_Period", wH_Pay.WHPP_Period);
         }
         if (string.IsNullOrEmpty(wH_Pay.WHPP_Type))
         {
            idb.AddParameter("@WHPP_Type", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHPP_Type", wH_Pay.WHPP_Type);
         }
         if (string.IsNullOrEmpty(wH_Pay.WHPP_Reason))
         {
            idb.AddParameter("@WHPP_Reason", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHPP_Reason", wH_Pay.WHPP_Reason);
         }
         if (string.IsNullOrEmpty(wH_Pay.WHPP_CompanyCode))
         {
            idb.AddParameter("@WHPP_CompanyCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHPP_CompanyCode", wH_Pay.WHPP_CompanyCode);
         }
         if (string.IsNullOrEmpty(wH_Pay.WHPP_CompanyName))
         {
            idb.AddParameter("@WHPP_CompanyName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHPP_CompanyName", wH_Pay.WHPP_CompanyName);
         }
         if (string.IsNullOrEmpty(wH_Pay.WHPP_SCode))
         {
            idb.AddParameter("@WHPP_SCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHPP_SCode", wH_Pay.WHPP_SCode);
         }
         if (string.IsNullOrEmpty(wH_Pay.WHPP_SName))
         {
            idb.AddParameter("@WHPP_SName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHPP_SName", wH_Pay.WHPP_SName);
         }
         if (wH_Pay.WHPP_Date == DateTime.MinValue)
         {
            idb.AddParameter("@WHPP_Date", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHPP_Date", wH_Pay.WHPP_Date);
         }
         if (string.IsNullOrEmpty(wH_Pay.WHPP_PName))
         {
            idb.AddParameter("@WHPP_PName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHPP_PName", wH_Pay.WHPP_PName);
         }
         if (string.IsNullOrEmpty(wH_Pay.WHPP_PayMethod))
         {
            idb.AddParameter("@WHPP_PayMethod", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHPP_PayMethod", wH_Pay.WHPP_PayMethod);
         }
         if (wH_Pay.WHPP_Sum == 0)
         {
            idb.AddParameter("@WHPP_Sum", 0);
         }
         else
         {
            idb.AddParameter("@WHPP_Sum", wH_Pay.WHPP_Sum);
         }
         if (string.IsNullOrEmpty(wH_Pay.WHPP_RefType))
         {
            idb.AddParameter("@WHPP_RefType", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHPP_RefType", wH_Pay.WHPP_RefType);
         }
         if (string.IsNullOrEmpty(wH_Pay.WHPP_RefCode))
         {
            idb.AddParameter("@WHPP_RefCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHPP_RefCode", wH_Pay.WHPP_RefCode);
         }
         if (string.IsNullOrEmpty(wH_Pay.WHPP_FOwner))
         {
            idb.AddParameter("@WHPP_FOwner", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHPP_FOwner", wH_Pay.WHPP_FOwner);
         }
         if (string.IsNullOrEmpty(wH_Pay.WHPP_POwner))
         {
            idb.AddParameter("@WHPP_POwner", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHPP_POwner", wH_Pay.WHPP_POwner);
         }
         if (string.IsNullOrEmpty(wH_Pay.WHPP_Bak))
         {
            idb.AddParameter("@WHPP_Bak", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHPP_Bak", wH_Pay.WHPP_Bak);
         }
         if (wH_Pay.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", wH_Pay.Stat);
         }
         if (wH_Pay.CreateDate == DateTime.MinValue)
         {
            idb.AddParameter("@CreateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateDate", wH_Pay.CreateDate);
         }
         if (wH_Pay.UpdateDate == DateTime.MinValue)
         {
            idb.AddParameter("@UpdateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@UpdateDate", wH_Pay.UpdateDate);
         }
         if (wH_Pay.DeleteDate == DateTime.MinValue)
         {
            idb.AddParameter("@DeleteDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DeleteDate", wH_Pay.DeleteDate);
         }
         if (wH_Pay.WHPP_LastMonth == 0)
         {
            idb.AddParameter("@WHPP_LastMonth", 0);
         }
         else
         {
            idb.AddParameter("@WHPP_LastMonth", wH_Pay.WHPP_LastMonth);
         }
         if (wH_Pay.WHPP_CurMonth == 0)
         {
            idb.AddParameter("@WHPP_CurMonth", 0);
         }
         else
         {
            idb.AddParameter("@WHPP_CurMonth", wH_Pay.WHPP_CurMonth);
         }
         if (wH_Pay.WHPP_NextMonth == 0)
         {
            idb.AddParameter("@WHPP_NextMonth", 0);
         }
         else
         {
            idb.AddParameter("@WHPP_NextMonth", wH_Pay.WHPP_NextMonth);
         }
         if (wH_Pay.WHPP_broom == 0)
         {
            idb.AddParameter("@WHPP_broom", 0);
         }
         else
         {
            idb.AddParameter("@WHPP_broom", wH_Pay.WHPP_broom);
         }
         if (wH_Pay.WHPP_CurPay == 0)
         {
            idb.AddParameter("@WHPP_CurPay", 0);
         }
         else
         {
            idb.AddParameter("@WHPP_CurPay", wH_Pay.WHPP_CurPay);
         }
         if (wH_Pay.WHPP_Plan == 0)
         {
            idb.AddParameter("@WHPP_Plan", 0);
         }
         else
         {
            idb.AddParameter("@WHPP_Plan", wH_Pay.WHPP_Plan);
         }
         if (wH_Pay.WHPP_Recive == 0)
         {
            idb.AddParameter("@WHPP_Recive", 0);
         }
         else
         {
            idb.AddParameter("@WHPP_Recive", wH_Pay.WHPP_Recive);
         }
         if (string.IsNullOrEmpty(wH_Pay.WHPP_UDEF1))
         {
            idb.AddParameter("@WHPP_UDEF1", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHPP_UDEF1", wH_Pay.WHPP_UDEF1);
         }
         if (string.IsNullOrEmpty(wH_Pay.WHPP_UDEF2))
         {
            idb.AddParameter("@WHPP_UDEF2", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHPP_UDEF2", wH_Pay.WHPP_UDEF2);
         }
         if (string.IsNullOrEmpty(wH_Pay.WHPP_UDEF3))
         {
            idb.AddParameter("@WHPP_UDEF3", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHPP_UDEF3", wH_Pay.WHPP_UDEF3);
         }
         if (string.IsNullOrEmpty(wH_Pay.WHPP_UDEF4))
         {
            idb.AddParameter("@WHPP_UDEF4", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHPP_UDEF4", wH_Pay.WHPP_UDEF4);
         }
         if (string.IsNullOrEmpty(wH_Pay.WHPP_UDEF5))
         {
            idb.AddParameter("@WHPP_UDEF5", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHPP_UDEF5", wH_Pay.WHPP_UDEF5);
         }
         if (string.IsNullOrEmpty(wH_Pay.WHPP_UDEF6))
         {
            idb.AddParameter("@WHPP_UDEF6", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHPP_UDEF6", wH_Pay.WHPP_UDEF6);
         }
         if (string.IsNullOrEmpty(wH_Pay.WHPP_UDEF7))
         {
            idb.AddParameter("@WHPP_UDEF7", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHPP_UDEF7", wH_Pay.WHPP_UDEF7);
         }
         if (string.IsNullOrEmpty(wH_Pay.WHPP_UDEF8))
         {
            idb.AddParameter("@WHPP_UDEF8", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHPP_UDEF8", wH_Pay.WHPP_UDEF8);
         }
         if (string.IsNullOrEmpty(wH_Pay.WHPP_UDEF9))
         {
            idb.AddParameter("@WHPP_UDEF9", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHPP_UDEF9", wH_Pay.WHPP_UDEF9);
         }
         if (string.IsNullOrEmpty(wH_Pay.WHPP_UDEF10))
         {
            idb.AddParameter("@WHPP_UDEF10", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHPP_UDEF10", wH_Pay.WHPP_UDEF10);
         }
         if (wH_Pay.WHPP_RelSum == 0)
         {
            idb.AddParameter("@WHPP_RelSum", 0);
         }
         else
         {
            idb.AddParameter("@WHPP_RelSum", wH_Pay.WHPP_RelSum);
         }
         if (wH_Pay.WHPP_Pay == 0)
         {
            idb.AddParameter("@WHPP_Pay", 0);
         }
         else
         {
            idb.AddParameter("@WHPP_Pay", wH_Pay.WHPP_Pay);
         }
         if (string.IsNullOrEmpty(wH_Pay.AuditStat))
         {
            idb.AddParameter("@AuditStat", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AuditStat", wH_Pay.AuditStat);
         }
         if (string.IsNullOrEmpty(wH_Pay.AuditCurAudit))
         {
            idb.AddParameter("@AuditCurAudit", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AuditCurAudit", wH_Pay.AuditCurAudit);
         }

         return idb.ExeCmd(sql);
      }
      /// <summary>
      /// 添加付款 WH_Pay对象(即:一条记录)
      /// </summary>
      public object AddWithReturn(WH_Pay wH_Pay)
      {
         string sql = "INSERT INTO WH_Pay (WHPP_Code,WHPP_Period,WHPP_Type,WHPP_Reason,WHPP_CompanyCode,WHPP_CompanyName,WHPP_SCode,WHPP_SName,WHPP_Date,WHPP_PName,WHPP_PayMethod,WHPP_Sum,WHPP_RefType,WHPP_RefCode,WHPP_FOwner,WHPP_POwner,WHPP_Bak,Stat,CreateDate,UpdateDate,DeleteDate,WHPP_LastMonth,WHPP_CurMonth,WHPP_NextMonth,WHPP_broom,WHPP_CurPay,WHPP_Plan,WHPP_Recive,WHPP_UDEF1,WHPP_UDEF2,WHPP_UDEF3,WHPP_UDEF4,WHPP_UDEF5,WHPP_UDEF6,WHPP_UDEF7,WHPP_UDEF8,WHPP_UDEF9,WHPP_UDEF10,WHPP_RelSum,WHPP_Pay,AuditStat,AuditCurAudit) VALUES (@WHPP_Code,@WHPP_Period,@WHPP_Type,@WHPP_Reason,@WHPP_CompanyCode,@WHPP_CompanyName,@WHPP_SCode,@WHPP_SName,@WHPP_Date,@WHPP_PName,@WHPP_PayMethod,@WHPP_Sum,@WHPP_RefType,@WHPP_RefCode,@WHPP_FOwner,@WHPP_POwner,@WHPP_Bak,@Stat,@CreateDate,@UpdateDate,@DeleteDate,@WHPP_LastMonth,@WHPP_CurMonth,@WHPP_NextMonth,@WHPP_broom,@WHPP_CurPay,@WHPP_Plan,@WHPP_Recive,@WHPP_UDEF1,@WHPP_UDEF2,@WHPP_UDEF3,@WHPP_UDEF4,@WHPP_UDEF5,@WHPP_UDEF6,@WHPP_UDEF7,@WHPP_UDEF8,@WHPP_UDEF9,@WHPP_UDEF10,@WHPP_RelSum,@WHPP_Pay,@AuditStat,@AuditCurAudit);SELECT @@IDENTITY AS ReturnID;";
         if (string.IsNullOrEmpty(wH_Pay.WHPP_Code))
         {
            idb.AddParameter("@WHPP_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHPP_Code", wH_Pay.WHPP_Code);
         }
         if (string.IsNullOrEmpty(wH_Pay.WHPP_Period))
         {
            idb.AddParameter("@WHPP_Period", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHPP_Period", wH_Pay.WHPP_Period);
         }
         if (string.IsNullOrEmpty(wH_Pay.WHPP_Type))
         {
            idb.AddParameter("@WHPP_Type", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHPP_Type", wH_Pay.WHPP_Type);
         }
         if (string.IsNullOrEmpty(wH_Pay.WHPP_Reason))
         {
            idb.AddParameter("@WHPP_Reason", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHPP_Reason", wH_Pay.WHPP_Reason);
         }
         if (string.IsNullOrEmpty(wH_Pay.WHPP_CompanyCode))
         {
            idb.AddParameter("@WHPP_CompanyCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHPP_CompanyCode", wH_Pay.WHPP_CompanyCode);
         }
         if (string.IsNullOrEmpty(wH_Pay.WHPP_CompanyName))
         {
            idb.AddParameter("@WHPP_CompanyName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHPP_CompanyName", wH_Pay.WHPP_CompanyName);
         }
         if (string.IsNullOrEmpty(wH_Pay.WHPP_SCode))
         {
            idb.AddParameter("@WHPP_SCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHPP_SCode", wH_Pay.WHPP_SCode);
         }
         if (string.IsNullOrEmpty(wH_Pay.WHPP_SName))
         {
            idb.AddParameter("@WHPP_SName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHPP_SName", wH_Pay.WHPP_SName);
         }
         if (wH_Pay.WHPP_Date == DateTime.MinValue)
         {
            idb.AddParameter("@WHPP_Date", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHPP_Date", wH_Pay.WHPP_Date);
         }
         if (string.IsNullOrEmpty(wH_Pay.WHPP_PName))
         {
            idb.AddParameter("@WHPP_PName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHPP_PName", wH_Pay.WHPP_PName);
         }
         if (string.IsNullOrEmpty(wH_Pay.WHPP_PayMethod))
         {
            idb.AddParameter("@WHPP_PayMethod", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHPP_PayMethod", wH_Pay.WHPP_PayMethod);
         }
         if (wH_Pay.WHPP_Sum == 0)
         {
            idb.AddParameter("@WHPP_Sum", 0);
         }
         else
         {
            idb.AddParameter("@WHPP_Sum", wH_Pay.WHPP_Sum);
         }
         if (string.IsNullOrEmpty(wH_Pay.WHPP_RefType))
         {
            idb.AddParameter("@WHPP_RefType", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHPP_RefType", wH_Pay.WHPP_RefType);
         }
         if (string.IsNullOrEmpty(wH_Pay.WHPP_RefCode))
         {
            idb.AddParameter("@WHPP_RefCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHPP_RefCode", wH_Pay.WHPP_RefCode);
         }
         if (string.IsNullOrEmpty(wH_Pay.WHPP_FOwner))
         {
            idb.AddParameter("@WHPP_FOwner", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHPP_FOwner", wH_Pay.WHPP_FOwner);
         }
         if (string.IsNullOrEmpty(wH_Pay.WHPP_POwner))
         {
            idb.AddParameter("@WHPP_POwner", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHPP_POwner", wH_Pay.WHPP_POwner);
         }
         if (string.IsNullOrEmpty(wH_Pay.WHPP_Bak))
         {
            idb.AddParameter("@WHPP_Bak", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHPP_Bak", wH_Pay.WHPP_Bak);
         }
         if (wH_Pay.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", wH_Pay.Stat);
         }
         if (wH_Pay.CreateDate == DateTime.MinValue)
         {
            idb.AddParameter("@CreateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateDate", wH_Pay.CreateDate);
         }
         if (wH_Pay.UpdateDate == DateTime.MinValue)
         {
            idb.AddParameter("@UpdateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@UpdateDate", wH_Pay.UpdateDate);
         }
         if (wH_Pay.DeleteDate == DateTime.MinValue)
         {
            idb.AddParameter("@DeleteDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DeleteDate", wH_Pay.DeleteDate);
         }
         if (wH_Pay.WHPP_LastMonth == 0)
         {
            idb.AddParameter("@WHPP_LastMonth", 0);
         }
         else
         {
            idb.AddParameter("@WHPP_LastMonth", wH_Pay.WHPP_LastMonth);
         }
         if (wH_Pay.WHPP_CurMonth == 0)
         {
            idb.AddParameter("@WHPP_CurMonth", 0);
         }
         else
         {
            idb.AddParameter("@WHPP_CurMonth", wH_Pay.WHPP_CurMonth);
         }
         if (wH_Pay.WHPP_NextMonth == 0)
         {
            idb.AddParameter("@WHPP_NextMonth", 0);
         }
         else
         {
            idb.AddParameter("@WHPP_NextMonth", wH_Pay.WHPP_NextMonth);
         }
         if (wH_Pay.WHPP_broom == 0)
         {
            idb.AddParameter("@WHPP_broom", 0);
         }
         else
         {
            idb.AddParameter("@WHPP_broom", wH_Pay.WHPP_broom);
         }
         if (wH_Pay.WHPP_CurPay == 0)
         {
            idb.AddParameter("@WHPP_CurPay", 0);
         }
         else
         {
            idb.AddParameter("@WHPP_CurPay", wH_Pay.WHPP_CurPay);
         }
         if (wH_Pay.WHPP_Plan == 0)
         {
            idb.AddParameter("@WHPP_Plan", 0);
         }
         else
         {
            idb.AddParameter("@WHPP_Plan", wH_Pay.WHPP_Plan);
         }
         if (wH_Pay.WHPP_Recive == 0)
         {
            idb.AddParameter("@WHPP_Recive", 0);
         }
         else
         {
            idb.AddParameter("@WHPP_Recive", wH_Pay.WHPP_Recive);
         }
         if (string.IsNullOrEmpty(wH_Pay.WHPP_UDEF1))
         {
            idb.AddParameter("@WHPP_UDEF1", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHPP_UDEF1", wH_Pay.WHPP_UDEF1);
         }
         if (string.IsNullOrEmpty(wH_Pay.WHPP_UDEF2))
         {
            idb.AddParameter("@WHPP_UDEF2", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHPP_UDEF2", wH_Pay.WHPP_UDEF2);
         }
         if (string.IsNullOrEmpty(wH_Pay.WHPP_UDEF3))
         {
            idb.AddParameter("@WHPP_UDEF3", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHPP_UDEF3", wH_Pay.WHPP_UDEF3);
         }
         if (string.IsNullOrEmpty(wH_Pay.WHPP_UDEF4))
         {
            idb.AddParameter("@WHPP_UDEF4", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHPP_UDEF4", wH_Pay.WHPP_UDEF4);
         }
         if (string.IsNullOrEmpty(wH_Pay.WHPP_UDEF5))
         {
            idb.AddParameter("@WHPP_UDEF5", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHPP_UDEF5", wH_Pay.WHPP_UDEF5);
         }
         if (string.IsNullOrEmpty(wH_Pay.WHPP_UDEF6))
         {
            idb.AddParameter("@WHPP_UDEF6", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHPP_UDEF6", wH_Pay.WHPP_UDEF6);
         }
         if (string.IsNullOrEmpty(wH_Pay.WHPP_UDEF7))
         {
            idb.AddParameter("@WHPP_UDEF7", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHPP_UDEF7", wH_Pay.WHPP_UDEF7);
         }
         if (string.IsNullOrEmpty(wH_Pay.WHPP_UDEF8))
         {
            idb.AddParameter("@WHPP_UDEF8", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHPP_UDEF8", wH_Pay.WHPP_UDEF8);
         }
         if (string.IsNullOrEmpty(wH_Pay.WHPP_UDEF9))
         {
            idb.AddParameter("@WHPP_UDEF9", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHPP_UDEF9", wH_Pay.WHPP_UDEF9);
         }
         if (string.IsNullOrEmpty(wH_Pay.WHPP_UDEF10))
         {
            idb.AddParameter("@WHPP_UDEF10", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHPP_UDEF10", wH_Pay.WHPP_UDEF10);
         }
         if (wH_Pay.WHPP_RelSum == 0)
         {
            idb.AddParameter("@WHPP_RelSum", 0);
         }
         else
         {
            idb.AddParameter("@WHPP_RelSum", wH_Pay.WHPP_RelSum);
         }
         if (wH_Pay.WHPP_Pay == 0)
         {
            idb.AddParameter("@WHPP_Pay", 0);
         }
         else
         {
            idb.AddParameter("@WHPP_Pay", wH_Pay.WHPP_Pay);
         }
         if (string.IsNullOrEmpty(wH_Pay.AuditStat))
         {
            idb.AddParameter("@AuditStat", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AuditStat", wH_Pay.AuditStat);
         }
         if (string.IsNullOrEmpty(wH_Pay.AuditCurAudit))
         {
            idb.AddParameter("@AuditCurAudit", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AuditCurAudit", wH_Pay.AuditCurAudit);
         }

         return idb.ReturnValue(sql);
      }
      /// <summary>
      /// 更新付款 WH_Pay对象(即:一条记录
      /// </summary>
      public int Update(WH_Pay wH_Pay)
      {
         
         StringBuilder sbParameter=new StringBuilder();
      StringBuilder sb=new StringBuilder();
      sb.Append(@"UPDATE       WH_Pay       SET ");
            if(wH_Pay.WHPP_Code_IsChanged){sbParameter.Append("WHPP_Code=@WHPP_Code, ");}
      if(wH_Pay.WHPP_Period_IsChanged){sbParameter.Append("WHPP_Period=@WHPP_Period, ");}
      if(wH_Pay.WHPP_Type_IsChanged){sbParameter.Append("WHPP_Type=@WHPP_Type, ");}
      if(wH_Pay.WHPP_Reason_IsChanged){sbParameter.Append("WHPP_Reason=@WHPP_Reason, ");}
      if(wH_Pay.WHPP_CompanyCode_IsChanged){sbParameter.Append("WHPP_CompanyCode=@WHPP_CompanyCode, ");}
      if(wH_Pay.WHPP_CompanyName_IsChanged){sbParameter.Append("WHPP_CompanyName=@WHPP_CompanyName, ");}
      if(wH_Pay.WHPP_SCode_IsChanged){sbParameter.Append("WHPP_SCode=@WHPP_SCode, ");}
      if(wH_Pay.WHPP_SName_IsChanged){sbParameter.Append("WHPP_SName=@WHPP_SName, ");}
      if(wH_Pay.WHPP_Date_IsChanged){sbParameter.Append("WHPP_Date=@WHPP_Date, ");}
      if(wH_Pay.WHPP_PName_IsChanged){sbParameter.Append("WHPP_PName=@WHPP_PName, ");}
      if(wH_Pay.WHPP_PayMethod_IsChanged){sbParameter.Append("WHPP_PayMethod=@WHPP_PayMethod, ");}
      if(wH_Pay.WHPP_Sum_IsChanged){sbParameter.Append("WHPP_Sum=@WHPP_Sum, ");}
      if(wH_Pay.WHPP_RefType_IsChanged){sbParameter.Append("WHPP_RefType=@WHPP_RefType, ");}
      if(wH_Pay.WHPP_RefCode_IsChanged){sbParameter.Append("WHPP_RefCode=@WHPP_RefCode, ");}
      if(wH_Pay.WHPP_FOwner_IsChanged){sbParameter.Append("WHPP_FOwner=@WHPP_FOwner, ");}
      if(wH_Pay.WHPP_POwner_IsChanged){sbParameter.Append("WHPP_POwner=@WHPP_POwner, ");}
      if(wH_Pay.WHPP_Bak_IsChanged){sbParameter.Append("WHPP_Bak=@WHPP_Bak, ");}
      if(wH_Pay.Stat_IsChanged){sbParameter.Append("Stat=@Stat, ");}
      if(wH_Pay.CreateDate_IsChanged){sbParameter.Append("CreateDate=@CreateDate, ");}
      if(wH_Pay.UpdateDate_IsChanged){sbParameter.Append("UpdateDate=@UpdateDate, ");}
      if(wH_Pay.DeleteDate_IsChanged){sbParameter.Append("DeleteDate=@DeleteDate, ");}
      if(wH_Pay.WHPP_LastMonth_IsChanged){sbParameter.Append("WHPP_LastMonth=@WHPP_LastMonth, ");}
      if(wH_Pay.WHPP_CurMonth_IsChanged){sbParameter.Append("WHPP_CurMonth=@WHPP_CurMonth, ");}
      if(wH_Pay.WHPP_NextMonth_IsChanged){sbParameter.Append("WHPP_NextMonth=@WHPP_NextMonth, ");}
      if(wH_Pay.WHPP_broom_IsChanged){sbParameter.Append("WHPP_broom=@WHPP_broom, ");}
      if(wH_Pay.WHPP_CurPay_IsChanged){sbParameter.Append("WHPP_CurPay=@WHPP_CurPay, ");}
      if(wH_Pay.WHPP_Plan_IsChanged){sbParameter.Append("WHPP_Plan=@WHPP_Plan, ");}
      if(wH_Pay.WHPP_Recive_IsChanged){sbParameter.Append("WHPP_Recive=@WHPP_Recive, ");}
      if(wH_Pay.WHPP_UDEF1_IsChanged){sbParameter.Append("WHPP_UDEF1=@WHPP_UDEF1, ");}
      if(wH_Pay.WHPP_UDEF2_IsChanged){sbParameter.Append("WHPP_UDEF2=@WHPP_UDEF2, ");}
      if(wH_Pay.WHPP_UDEF3_IsChanged){sbParameter.Append("WHPP_UDEF3=@WHPP_UDEF3, ");}
      if(wH_Pay.WHPP_UDEF4_IsChanged){sbParameter.Append("WHPP_UDEF4=@WHPP_UDEF4, ");}
      if(wH_Pay.WHPP_UDEF5_IsChanged){sbParameter.Append("WHPP_UDEF5=@WHPP_UDEF5, ");}
      if(wH_Pay.WHPP_UDEF6_IsChanged){sbParameter.Append("WHPP_UDEF6=@WHPP_UDEF6, ");}
      if(wH_Pay.WHPP_UDEF7_IsChanged){sbParameter.Append("WHPP_UDEF7=@WHPP_UDEF7, ");}
      if(wH_Pay.WHPP_UDEF8_IsChanged){sbParameter.Append("WHPP_UDEF8=@WHPP_UDEF8, ");}
      if(wH_Pay.WHPP_UDEF9_IsChanged){sbParameter.Append("WHPP_UDEF9=@WHPP_UDEF9, ");}
      if(wH_Pay.WHPP_UDEF10_IsChanged){sbParameter.Append("WHPP_UDEF10=@WHPP_UDEF10, ");}
      if(wH_Pay.WHPP_RelSum_IsChanged){sbParameter.Append("WHPP_RelSum=@WHPP_RelSum, ");}
      if(wH_Pay.WHPP_Pay_IsChanged){sbParameter.Append("WHPP_Pay=@WHPP_Pay, ");}
      if(wH_Pay.AuditStat_IsChanged){sbParameter.Append("AuditStat=@AuditStat, ");}
      if(wH_Pay.AuditCurAudit_IsChanged){sbParameter.Append("AuditCurAudit=@AuditCurAudit ");}          sb.Append(sbParameter.ToString().Trim().TrimEnd(',')); 
      sb.Append(      " WHERE 1=1 AND ((Stat is null) or (Stat=0))   and WHPP_ID=@WHPP_ID; " );
      string sql=sb.ToString();
         if(wH_Pay.WHPP_Code_IsChanged)
         {
         if (string.IsNullOrEmpty(wH_Pay.WHPP_Code))
         {
            idb.AddParameter("@WHPP_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHPP_Code", wH_Pay.WHPP_Code);
         }
          }
         if(wH_Pay.WHPP_Period_IsChanged)
         {
         if (string.IsNullOrEmpty(wH_Pay.WHPP_Period))
         {
            idb.AddParameter("@WHPP_Period", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHPP_Period", wH_Pay.WHPP_Period);
         }
          }
         if(wH_Pay.WHPP_Type_IsChanged)
         {
         if (string.IsNullOrEmpty(wH_Pay.WHPP_Type))
         {
            idb.AddParameter("@WHPP_Type", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHPP_Type", wH_Pay.WHPP_Type);
         }
          }
         if(wH_Pay.WHPP_Reason_IsChanged)
         {
         if (string.IsNullOrEmpty(wH_Pay.WHPP_Reason))
         {
            idb.AddParameter("@WHPP_Reason", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHPP_Reason", wH_Pay.WHPP_Reason);
         }
          }
         if(wH_Pay.WHPP_CompanyCode_IsChanged)
         {
         if (string.IsNullOrEmpty(wH_Pay.WHPP_CompanyCode))
         {
            idb.AddParameter("@WHPP_CompanyCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHPP_CompanyCode", wH_Pay.WHPP_CompanyCode);
         }
          }
         if(wH_Pay.WHPP_CompanyName_IsChanged)
         {
         if (string.IsNullOrEmpty(wH_Pay.WHPP_CompanyName))
         {
            idb.AddParameter("@WHPP_CompanyName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHPP_CompanyName", wH_Pay.WHPP_CompanyName);
         }
          }
         if(wH_Pay.WHPP_SCode_IsChanged)
         {
         if (string.IsNullOrEmpty(wH_Pay.WHPP_SCode))
         {
            idb.AddParameter("@WHPP_SCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHPP_SCode", wH_Pay.WHPP_SCode);
         }
          }
         if(wH_Pay.WHPP_SName_IsChanged)
         {
         if (string.IsNullOrEmpty(wH_Pay.WHPP_SName))
         {
            idb.AddParameter("@WHPP_SName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHPP_SName", wH_Pay.WHPP_SName);
         }
          }
         if(wH_Pay.WHPP_Date_IsChanged)
         {
         if (wH_Pay.WHPP_Date == DateTime.MinValue)
         {
            idb.AddParameter("@WHPP_Date", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHPP_Date", wH_Pay.WHPP_Date);
         }
          }
         if(wH_Pay.WHPP_PName_IsChanged)
         {
         if (string.IsNullOrEmpty(wH_Pay.WHPP_PName))
         {
            idb.AddParameter("@WHPP_PName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHPP_PName", wH_Pay.WHPP_PName);
         }
          }
         if(wH_Pay.WHPP_PayMethod_IsChanged)
         {
         if (string.IsNullOrEmpty(wH_Pay.WHPP_PayMethod))
         {
            idb.AddParameter("@WHPP_PayMethod", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHPP_PayMethod", wH_Pay.WHPP_PayMethod);
         }
          }
         if(wH_Pay.WHPP_Sum_IsChanged)
         {
         if (wH_Pay.WHPP_Sum == 0)
         {
            idb.AddParameter("@WHPP_Sum", 0);
         }
         else
         {
            idb.AddParameter("@WHPP_Sum", wH_Pay.WHPP_Sum);
         }
          }
         if(wH_Pay.WHPP_RefType_IsChanged)
         {
         if (string.IsNullOrEmpty(wH_Pay.WHPP_RefType))
         {
            idb.AddParameter("@WHPP_RefType", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHPP_RefType", wH_Pay.WHPP_RefType);
         }
          }
         if(wH_Pay.WHPP_RefCode_IsChanged)
         {
         if (string.IsNullOrEmpty(wH_Pay.WHPP_RefCode))
         {
            idb.AddParameter("@WHPP_RefCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHPP_RefCode", wH_Pay.WHPP_RefCode);
         }
          }
         if(wH_Pay.WHPP_FOwner_IsChanged)
         {
         if (string.IsNullOrEmpty(wH_Pay.WHPP_FOwner))
         {
            idb.AddParameter("@WHPP_FOwner", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHPP_FOwner", wH_Pay.WHPP_FOwner);
         }
          }
         if(wH_Pay.WHPP_POwner_IsChanged)
         {
         if (string.IsNullOrEmpty(wH_Pay.WHPP_POwner))
         {
            idb.AddParameter("@WHPP_POwner", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHPP_POwner", wH_Pay.WHPP_POwner);
         }
          }
         if(wH_Pay.WHPP_Bak_IsChanged)
         {
         if (string.IsNullOrEmpty(wH_Pay.WHPP_Bak))
         {
            idb.AddParameter("@WHPP_Bak", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHPP_Bak", wH_Pay.WHPP_Bak);
         }
          }
         if(wH_Pay.Stat_IsChanged)
         {
         if (wH_Pay.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", wH_Pay.Stat);
         }
          }
         if(wH_Pay.CreateDate_IsChanged)
         {
         if (wH_Pay.CreateDate == DateTime.MinValue)
         {
            idb.AddParameter("@CreateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateDate", wH_Pay.CreateDate);
         }
          }
         if(wH_Pay.UpdateDate_IsChanged)
         {
         if (wH_Pay.UpdateDate == DateTime.MinValue)
         {
            idb.AddParameter("@UpdateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@UpdateDate", wH_Pay.UpdateDate);
         }
          }
         if(wH_Pay.DeleteDate_IsChanged)
         {
         if (wH_Pay.DeleteDate == DateTime.MinValue)
         {
            idb.AddParameter("@DeleteDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DeleteDate", wH_Pay.DeleteDate);
         }
          }
         if(wH_Pay.WHPP_LastMonth_IsChanged)
         {
         if (wH_Pay.WHPP_LastMonth == 0)
         {
            idb.AddParameter("@WHPP_LastMonth", 0);
         }
         else
         {
            idb.AddParameter("@WHPP_LastMonth", wH_Pay.WHPP_LastMonth);
         }
          }
         if(wH_Pay.WHPP_CurMonth_IsChanged)
         {
         if (wH_Pay.WHPP_CurMonth == 0)
         {
            idb.AddParameter("@WHPP_CurMonth", 0);
         }
         else
         {
            idb.AddParameter("@WHPP_CurMonth", wH_Pay.WHPP_CurMonth);
         }
          }
         if(wH_Pay.WHPP_NextMonth_IsChanged)
         {
         if (wH_Pay.WHPP_NextMonth == 0)
         {
            idb.AddParameter("@WHPP_NextMonth", 0);
         }
         else
         {
            idb.AddParameter("@WHPP_NextMonth", wH_Pay.WHPP_NextMonth);
         }
          }
         if(wH_Pay.WHPP_broom_IsChanged)
         {
         if (wH_Pay.WHPP_broom == 0)
         {
            idb.AddParameter("@WHPP_broom", 0);
         }
         else
         {
            idb.AddParameter("@WHPP_broom", wH_Pay.WHPP_broom);
         }
          }
         if(wH_Pay.WHPP_CurPay_IsChanged)
         {
         if (wH_Pay.WHPP_CurPay == 0)
         {
            idb.AddParameter("@WHPP_CurPay", 0);
         }
         else
         {
            idb.AddParameter("@WHPP_CurPay", wH_Pay.WHPP_CurPay);
         }
          }
         if(wH_Pay.WHPP_Plan_IsChanged)
         {
         if (wH_Pay.WHPP_Plan == 0)
         {
            idb.AddParameter("@WHPP_Plan", 0);
         }
         else
         {
            idb.AddParameter("@WHPP_Plan", wH_Pay.WHPP_Plan);
         }
          }
         if(wH_Pay.WHPP_Recive_IsChanged)
         {
         if (wH_Pay.WHPP_Recive == 0)
         {
            idb.AddParameter("@WHPP_Recive", 0);
         }
         else
         {
            idb.AddParameter("@WHPP_Recive", wH_Pay.WHPP_Recive);
         }
          }
         if(wH_Pay.WHPP_UDEF1_IsChanged)
         {
         if (string.IsNullOrEmpty(wH_Pay.WHPP_UDEF1))
         {
            idb.AddParameter("@WHPP_UDEF1", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHPP_UDEF1", wH_Pay.WHPP_UDEF1);
         }
          }
         if(wH_Pay.WHPP_UDEF2_IsChanged)
         {
         if (string.IsNullOrEmpty(wH_Pay.WHPP_UDEF2))
         {
            idb.AddParameter("@WHPP_UDEF2", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHPP_UDEF2", wH_Pay.WHPP_UDEF2);
         }
          }
         if(wH_Pay.WHPP_UDEF3_IsChanged)
         {
         if (string.IsNullOrEmpty(wH_Pay.WHPP_UDEF3))
         {
            idb.AddParameter("@WHPP_UDEF3", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHPP_UDEF3", wH_Pay.WHPP_UDEF3);
         }
          }
         if(wH_Pay.WHPP_UDEF4_IsChanged)
         {
         if (string.IsNullOrEmpty(wH_Pay.WHPP_UDEF4))
         {
            idb.AddParameter("@WHPP_UDEF4", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHPP_UDEF4", wH_Pay.WHPP_UDEF4);
         }
          }
         if(wH_Pay.WHPP_UDEF5_IsChanged)
         {
         if (string.IsNullOrEmpty(wH_Pay.WHPP_UDEF5))
         {
            idb.AddParameter("@WHPP_UDEF5", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHPP_UDEF5", wH_Pay.WHPP_UDEF5);
         }
          }
         if(wH_Pay.WHPP_UDEF6_IsChanged)
         {
         if (string.IsNullOrEmpty(wH_Pay.WHPP_UDEF6))
         {
            idb.AddParameter("@WHPP_UDEF6", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHPP_UDEF6", wH_Pay.WHPP_UDEF6);
         }
          }
         if(wH_Pay.WHPP_UDEF7_IsChanged)
         {
         if (string.IsNullOrEmpty(wH_Pay.WHPP_UDEF7))
         {
            idb.AddParameter("@WHPP_UDEF7", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHPP_UDEF7", wH_Pay.WHPP_UDEF7);
         }
          }
         if(wH_Pay.WHPP_UDEF8_IsChanged)
         {
         if (string.IsNullOrEmpty(wH_Pay.WHPP_UDEF8))
         {
            idb.AddParameter("@WHPP_UDEF8", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHPP_UDEF8", wH_Pay.WHPP_UDEF8);
         }
          }
         if(wH_Pay.WHPP_UDEF9_IsChanged)
         {
         if (string.IsNullOrEmpty(wH_Pay.WHPP_UDEF9))
         {
            idb.AddParameter("@WHPP_UDEF9", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHPP_UDEF9", wH_Pay.WHPP_UDEF9);
         }
          }
         if(wH_Pay.WHPP_UDEF10_IsChanged)
         {
         if (string.IsNullOrEmpty(wH_Pay.WHPP_UDEF10))
         {
            idb.AddParameter("@WHPP_UDEF10", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHPP_UDEF10", wH_Pay.WHPP_UDEF10);
         }
          }
         if(wH_Pay.WHPP_RelSum_IsChanged)
         {
         if (wH_Pay.WHPP_RelSum == 0)
         {
            idb.AddParameter("@WHPP_RelSum", 0);
         }
         else
         {
            idb.AddParameter("@WHPP_RelSum", wH_Pay.WHPP_RelSum);
         }
          }
         if(wH_Pay.WHPP_Pay_IsChanged)
         {
         if (wH_Pay.WHPP_Pay == 0)
         {
            idb.AddParameter("@WHPP_Pay", 0);
         }
         else
         {
            idb.AddParameter("@WHPP_Pay", wH_Pay.WHPP_Pay);
         }
          }
         if(wH_Pay.AuditStat_IsChanged)
         {
         if (string.IsNullOrEmpty(wH_Pay.AuditStat))
         {
            idb.AddParameter("@AuditStat", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AuditStat", wH_Pay.AuditStat);
         }
          }
         if(wH_Pay.AuditCurAudit_IsChanged)
         {
         if (string.IsNullOrEmpty(wH_Pay.AuditCurAudit))
         {
            idb.AddParameter("@AuditCurAudit", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AuditCurAudit", wH_Pay.AuditCurAudit);
         }
          }

         idb.AddParameter("@WHPP_ID", wH_Pay.WHPP_ID);

         return idb.ExeCmd(sql);
      }
      /// <summary>
      /// 删除付款 WH_Pay对象(即:一条记录
      /// </summary>
      public int Delete(decimal wHPP_ID)
      {
         string sql = "DELETE WH_Pay WHERE 1=1  AND WHPP_ID=@WHPP_ID ";
         idb.AddParameter("@WHPP_ID", wHPP_ID);

         return idb.ExeCmd(sql);
      }
      /// <summary>
      /// 获取指定的付款 WH_Pay对象(即:一条记录
      /// </summary>
      public WH_Pay GetByKey(decimal wHPP_ID)
      {
         WH_Pay wH_Pay = new WH_Pay();
         string sql = "SELECT  WHPP_ID,WHPP_Code,WHPP_Period,WHPP_Type,WHPP_Reason,WHPP_CompanyCode,WHPP_CompanyName,WHPP_SCode,WHPP_SName,WHPP_Date,WHPP_PName,WHPP_PayMethod,WHPP_Sum,WHPP_RefType,WHPP_RefCode,WHPP_FOwner,WHPP_POwner,WHPP_Bak,Stat,CreateDate,UpdateDate,DeleteDate,WHPP_LastMonth,WHPP_CurMonth,WHPP_NextMonth,WHPP_broom,WHPP_CurPay,WHPP_Plan,WHPP_Recive,WHPP_UDEF1,WHPP_UDEF2,WHPP_UDEF3,WHPP_UDEF4,WHPP_UDEF5,WHPP_UDEF6,WHPP_UDEF7,WHPP_UDEF8,WHPP_UDEF9,WHPP_UDEF10,WHPP_RelSum,WHPP_Pay,AuditStat,AuditCurAudit FROM WH_Pay WHERE 1=1 AND ((Stat is null) or (Stat=0) )  AND WHPP_ID=@WHPP_ID ";
         idb.AddParameter("@WHPP_ID", wHPP_ID);

          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            if (dr["WHPP_ID"] != DBNull.Value) wH_Pay.WHPP_ID = Convert.ToDecimal(dr["WHPP_ID"]);
            if (dr["WHPP_Code"] != DBNull.Value) wH_Pay.WHPP_Code = Convert.ToString(dr["WHPP_Code"]);
            if (dr["WHPP_Period"] != DBNull.Value) wH_Pay.WHPP_Period = Convert.ToString(dr["WHPP_Period"]);
            if (dr["WHPP_Type"] != DBNull.Value) wH_Pay.WHPP_Type = Convert.ToString(dr["WHPP_Type"]);
            if (dr["WHPP_Reason"] != DBNull.Value) wH_Pay.WHPP_Reason = Convert.ToString(dr["WHPP_Reason"]);
            if (dr["WHPP_CompanyCode"] != DBNull.Value) wH_Pay.WHPP_CompanyCode = Convert.ToString(dr["WHPP_CompanyCode"]);
            if (dr["WHPP_CompanyName"] != DBNull.Value) wH_Pay.WHPP_CompanyName = Convert.ToString(dr["WHPP_CompanyName"]);
            if (dr["WHPP_SCode"] != DBNull.Value) wH_Pay.WHPP_SCode = Convert.ToString(dr["WHPP_SCode"]);
            if (dr["WHPP_SName"] != DBNull.Value) wH_Pay.WHPP_SName = Convert.ToString(dr["WHPP_SName"]);
            if (dr["WHPP_Date"] != DBNull.Value) wH_Pay.WHPP_Date = Convert.ToDateTime(dr["WHPP_Date"]);
            if (dr["WHPP_PName"] != DBNull.Value) wH_Pay.WHPP_PName = Convert.ToString(dr["WHPP_PName"]);
            if (dr["WHPP_PayMethod"] != DBNull.Value) wH_Pay.WHPP_PayMethod = Convert.ToString(dr["WHPP_PayMethod"]);
            if (dr["WHPP_Sum"] != DBNull.Value) wH_Pay.WHPP_Sum = Convert.ToDecimal(dr["WHPP_Sum"]);
            if (dr["WHPP_RefType"] != DBNull.Value) wH_Pay.WHPP_RefType = Convert.ToString(dr["WHPP_RefType"]);
            if (dr["WHPP_RefCode"] != DBNull.Value) wH_Pay.WHPP_RefCode = Convert.ToString(dr["WHPP_RefCode"]);
            if (dr["WHPP_FOwner"] != DBNull.Value) wH_Pay.WHPP_FOwner = Convert.ToString(dr["WHPP_FOwner"]);
            if (dr["WHPP_POwner"] != DBNull.Value) wH_Pay.WHPP_POwner = Convert.ToString(dr["WHPP_POwner"]);
            if (dr["WHPP_Bak"] != DBNull.Value) wH_Pay.WHPP_Bak = Convert.ToString(dr["WHPP_Bak"]);
            if (dr["Stat"] != DBNull.Value) wH_Pay.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["CreateDate"] != DBNull.Value) wH_Pay.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
            if (dr["UpdateDate"] != DBNull.Value) wH_Pay.UpdateDate = Convert.ToDateTime(dr["UpdateDate"]);
            if (dr["DeleteDate"] != DBNull.Value) wH_Pay.DeleteDate = Convert.ToDateTime(dr["DeleteDate"]);
            if (dr["WHPP_LastMonth"] != DBNull.Value) wH_Pay.WHPP_LastMonth = Convert.ToDecimal(dr["WHPP_LastMonth"]);
            if (dr["WHPP_CurMonth"] != DBNull.Value) wH_Pay.WHPP_CurMonth = Convert.ToDecimal(dr["WHPP_CurMonth"]);
            if (dr["WHPP_NextMonth"] != DBNull.Value) wH_Pay.WHPP_NextMonth = Convert.ToDecimal(dr["WHPP_NextMonth"]);
            if (dr["WHPP_broom"] != DBNull.Value) wH_Pay.WHPP_broom = Convert.ToDecimal(dr["WHPP_broom"]);
            if (dr["WHPP_CurPay"] != DBNull.Value) wH_Pay.WHPP_CurPay = Convert.ToDecimal(dr["WHPP_CurPay"]);
            if (dr["WHPP_Plan"] != DBNull.Value) wH_Pay.WHPP_Plan = Convert.ToDecimal(dr["WHPP_Plan"]);
            if (dr["WHPP_Recive"] != DBNull.Value) wH_Pay.WHPP_Recive = Convert.ToDecimal(dr["WHPP_Recive"]);
            if (dr["WHPP_UDEF1"] != DBNull.Value) wH_Pay.WHPP_UDEF1 = Convert.ToString(dr["WHPP_UDEF1"]);
            if (dr["WHPP_UDEF2"] != DBNull.Value) wH_Pay.WHPP_UDEF2 = Convert.ToString(dr["WHPP_UDEF2"]);
            if (dr["WHPP_UDEF3"] != DBNull.Value) wH_Pay.WHPP_UDEF3 = Convert.ToString(dr["WHPP_UDEF3"]);
            if (dr["WHPP_UDEF4"] != DBNull.Value) wH_Pay.WHPP_UDEF4 = Convert.ToString(dr["WHPP_UDEF4"]);
            if (dr["WHPP_UDEF5"] != DBNull.Value) wH_Pay.WHPP_UDEF5 = Convert.ToString(dr["WHPP_UDEF5"]);
            if (dr["WHPP_UDEF6"] != DBNull.Value) wH_Pay.WHPP_UDEF6 = Convert.ToString(dr["WHPP_UDEF6"]);
            if (dr["WHPP_UDEF7"] != DBNull.Value) wH_Pay.WHPP_UDEF7 = Convert.ToString(dr["WHPP_UDEF7"]);
            if (dr["WHPP_UDEF8"] != DBNull.Value) wH_Pay.WHPP_UDEF8 = Convert.ToString(dr["WHPP_UDEF8"]);
            if (dr["WHPP_UDEF9"] != DBNull.Value) wH_Pay.WHPP_UDEF9 = Convert.ToString(dr["WHPP_UDEF9"]);
            if (dr["WHPP_UDEF10"] != DBNull.Value) wH_Pay.WHPP_UDEF10 = Convert.ToString(dr["WHPP_UDEF10"]);
            if (dr["WHPP_RelSum"] != DBNull.Value) wH_Pay.WHPP_RelSum = Convert.ToDecimal(dr["WHPP_RelSum"]);
            if (dr["WHPP_Pay"] != DBNull.Value) wH_Pay.WHPP_Pay = Convert.ToDecimal(dr["WHPP_Pay"]);
            if (dr["AuditStat"] != DBNull.Value) wH_Pay.AuditStat = Convert.ToString(dr["AuditStat"]);
            if (dr["AuditCurAudit"] != DBNull.Value) wH_Pay.AuditCurAudit = Convert.ToString(dr["AuditCurAudit"]);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   }  
         return wH_Pay;
      }
      /// <summary>
      /// 获取指定的付款 WH_Pay对象集合
      /// </summary>
      public List<WH_Pay> GetListByWhere(string strCondition)
      {
         List<WH_Pay> ret = new List<WH_Pay>();
         string sql = "SELECT  WHPP_ID,WHPP_Code,WHPP_Period,WHPP_Type,WHPP_Reason,WHPP_CompanyCode,WHPP_CompanyName,WHPP_SCode,WHPP_SName,WHPP_Date,WHPP_PName,WHPP_PayMethod,WHPP_Sum,WHPP_RefType,WHPP_RefCode,WHPP_FOwner,WHPP_POwner,WHPP_Bak,Stat,CreateDate,UpdateDate,DeleteDate,WHPP_LastMonth,WHPP_CurMonth,WHPP_NextMonth,WHPP_broom,WHPP_CurPay,WHPP_Plan,WHPP_Recive,WHPP_UDEF1,WHPP_UDEF2,WHPP_UDEF3,WHPP_UDEF4,WHPP_UDEF5,WHPP_UDEF6,WHPP_UDEF7,WHPP_UDEF8,WHPP_UDEF9,WHPP_UDEF10,WHPP_RelSum,WHPP_Pay,AuditStat,AuditCurAudit FROM WH_Pay WHERE 1=1 AND ((Stat is null) or (Stat=0) ) ";
         if(!string.IsNullOrEmpty(strCondition))
         {
            strCondition.Replace('\'','"'); //防sql注入
            sql += strCondition ;
         }
          sql += " ORDER BY WHPP_ID DESC "; 
          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            WH_Pay wH_Pay = new WH_Pay();
            if (dr["WHPP_ID"] != DBNull.Value) wH_Pay.WHPP_ID = Convert.ToDecimal(dr["WHPP_ID"]);
            if (dr["WHPP_Code"] != DBNull.Value) wH_Pay.WHPP_Code = Convert.ToString(dr["WHPP_Code"]);
            if (dr["WHPP_Period"] != DBNull.Value) wH_Pay.WHPP_Period = Convert.ToString(dr["WHPP_Period"]);
            if (dr["WHPP_Type"] != DBNull.Value) wH_Pay.WHPP_Type = Convert.ToString(dr["WHPP_Type"]);
            if (dr["WHPP_Reason"] != DBNull.Value) wH_Pay.WHPP_Reason = Convert.ToString(dr["WHPP_Reason"]);
            if (dr["WHPP_CompanyCode"] != DBNull.Value) wH_Pay.WHPP_CompanyCode = Convert.ToString(dr["WHPP_CompanyCode"]);
            if (dr["WHPP_CompanyName"] != DBNull.Value) wH_Pay.WHPP_CompanyName = Convert.ToString(dr["WHPP_CompanyName"]);
            if (dr["WHPP_SCode"] != DBNull.Value) wH_Pay.WHPP_SCode = Convert.ToString(dr["WHPP_SCode"]);
            if (dr["WHPP_SName"] != DBNull.Value) wH_Pay.WHPP_SName = Convert.ToString(dr["WHPP_SName"]);
            if (dr["WHPP_Date"] != DBNull.Value) wH_Pay.WHPP_Date = Convert.ToDateTime(dr["WHPP_Date"]);
            if (dr["WHPP_PName"] != DBNull.Value) wH_Pay.WHPP_PName = Convert.ToString(dr["WHPP_PName"]);
            if (dr["WHPP_PayMethod"] != DBNull.Value) wH_Pay.WHPP_PayMethod = Convert.ToString(dr["WHPP_PayMethod"]);
            if (dr["WHPP_Sum"] != DBNull.Value) wH_Pay.WHPP_Sum = Convert.ToDecimal(dr["WHPP_Sum"]);
            if (dr["WHPP_RefType"] != DBNull.Value) wH_Pay.WHPP_RefType = Convert.ToString(dr["WHPP_RefType"]);
            if (dr["WHPP_RefCode"] != DBNull.Value) wH_Pay.WHPP_RefCode = Convert.ToString(dr["WHPP_RefCode"]);
            if (dr["WHPP_FOwner"] != DBNull.Value) wH_Pay.WHPP_FOwner = Convert.ToString(dr["WHPP_FOwner"]);
            if (dr["WHPP_POwner"] != DBNull.Value) wH_Pay.WHPP_POwner = Convert.ToString(dr["WHPP_POwner"]);
            if (dr["WHPP_Bak"] != DBNull.Value) wH_Pay.WHPP_Bak = Convert.ToString(dr["WHPP_Bak"]);
            if (dr["Stat"] != DBNull.Value) wH_Pay.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["CreateDate"] != DBNull.Value) wH_Pay.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
            if (dr["UpdateDate"] != DBNull.Value) wH_Pay.UpdateDate = Convert.ToDateTime(dr["UpdateDate"]);
            if (dr["DeleteDate"] != DBNull.Value) wH_Pay.DeleteDate = Convert.ToDateTime(dr["DeleteDate"]);
            if (dr["WHPP_LastMonth"] != DBNull.Value) wH_Pay.WHPP_LastMonth = Convert.ToDecimal(dr["WHPP_LastMonth"]);
            if (dr["WHPP_CurMonth"] != DBNull.Value) wH_Pay.WHPP_CurMonth = Convert.ToDecimal(dr["WHPP_CurMonth"]);
            if (dr["WHPP_NextMonth"] != DBNull.Value) wH_Pay.WHPP_NextMonth = Convert.ToDecimal(dr["WHPP_NextMonth"]);
            if (dr["WHPP_broom"] != DBNull.Value) wH_Pay.WHPP_broom = Convert.ToDecimal(dr["WHPP_broom"]);
            if (dr["WHPP_CurPay"] != DBNull.Value) wH_Pay.WHPP_CurPay = Convert.ToDecimal(dr["WHPP_CurPay"]);
            if (dr["WHPP_Plan"] != DBNull.Value) wH_Pay.WHPP_Plan = Convert.ToDecimal(dr["WHPP_Plan"]);
            if (dr["WHPP_Recive"] != DBNull.Value) wH_Pay.WHPP_Recive = Convert.ToDecimal(dr["WHPP_Recive"]);
            if (dr["WHPP_UDEF1"] != DBNull.Value) wH_Pay.WHPP_UDEF1 = Convert.ToString(dr["WHPP_UDEF1"]);
            if (dr["WHPP_UDEF2"] != DBNull.Value) wH_Pay.WHPP_UDEF2 = Convert.ToString(dr["WHPP_UDEF2"]);
            if (dr["WHPP_UDEF3"] != DBNull.Value) wH_Pay.WHPP_UDEF3 = Convert.ToString(dr["WHPP_UDEF3"]);
            if (dr["WHPP_UDEF4"] != DBNull.Value) wH_Pay.WHPP_UDEF4 = Convert.ToString(dr["WHPP_UDEF4"]);
            if (dr["WHPP_UDEF5"] != DBNull.Value) wH_Pay.WHPP_UDEF5 = Convert.ToString(dr["WHPP_UDEF5"]);
            if (dr["WHPP_UDEF6"] != DBNull.Value) wH_Pay.WHPP_UDEF6 = Convert.ToString(dr["WHPP_UDEF6"]);
            if (dr["WHPP_UDEF7"] != DBNull.Value) wH_Pay.WHPP_UDEF7 = Convert.ToString(dr["WHPP_UDEF7"]);
            if (dr["WHPP_UDEF8"] != DBNull.Value) wH_Pay.WHPP_UDEF8 = Convert.ToString(dr["WHPP_UDEF8"]);
            if (dr["WHPP_UDEF9"] != DBNull.Value) wH_Pay.WHPP_UDEF9 = Convert.ToString(dr["WHPP_UDEF9"]);
            if (dr["WHPP_UDEF10"] != DBNull.Value) wH_Pay.WHPP_UDEF10 = Convert.ToString(dr["WHPP_UDEF10"]);
            if (dr["WHPP_RelSum"] != DBNull.Value) wH_Pay.WHPP_RelSum = Convert.ToDecimal(dr["WHPP_RelSum"]);
            if (dr["WHPP_Pay"] != DBNull.Value) wH_Pay.WHPP_Pay = Convert.ToDecimal(dr["WHPP_Pay"]);
            if (dr["AuditStat"] != DBNull.Value) wH_Pay.AuditStat = Convert.ToString(dr["AuditStat"]);
            if (dr["AuditCurAudit"] != DBNull.Value) wH_Pay.AuditCurAudit = Convert.ToString(dr["AuditCurAudit"]);
            ret.Add(wH_Pay);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   }  
         return ret;
      }
      /// <summary>
      /// 获取所有的付款 WH_Pay对象(即:一条记录
      /// </summary>
      public List<WH_Pay> GetAll()
      {
         List<WH_Pay> ret = new List<WH_Pay>();
         string sql = "SELECT  WHPP_ID,WHPP_Code,WHPP_Period,WHPP_Type,WHPP_Reason,WHPP_CompanyCode,WHPP_CompanyName,WHPP_SCode,WHPP_SName,WHPP_Date,WHPP_PName,WHPP_PayMethod,WHPP_Sum,WHPP_RefType,WHPP_RefCode,WHPP_FOwner,WHPP_POwner,WHPP_Bak,Stat,CreateDate,UpdateDate,DeleteDate,WHPP_LastMonth,WHPP_CurMonth,WHPP_NextMonth,WHPP_broom,WHPP_CurPay,WHPP_Plan,WHPP_Recive,WHPP_UDEF1,WHPP_UDEF2,WHPP_UDEF3,WHPP_UDEF4,WHPP_UDEF5,WHPP_UDEF6,WHPP_UDEF7,WHPP_UDEF8,WHPP_UDEF9,WHPP_UDEF10,WHPP_RelSum,WHPP_Pay,AuditStat,AuditCurAudit FROM WH_Pay where 1=1 AND ((Stat is null) or (Stat=0) ) order by WHPP_ID desc ";
          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            WH_Pay wH_Pay = new WH_Pay();
            if (dr["WHPP_ID"] != DBNull.Value) wH_Pay.WHPP_ID = Convert.ToDecimal(dr["WHPP_ID"]);
            if (dr["WHPP_Code"] != DBNull.Value) wH_Pay.WHPP_Code = Convert.ToString(dr["WHPP_Code"]);
            if (dr["WHPP_Period"] != DBNull.Value) wH_Pay.WHPP_Period = Convert.ToString(dr["WHPP_Period"]);
            if (dr["WHPP_Type"] != DBNull.Value) wH_Pay.WHPP_Type = Convert.ToString(dr["WHPP_Type"]);
            if (dr["WHPP_Reason"] != DBNull.Value) wH_Pay.WHPP_Reason = Convert.ToString(dr["WHPP_Reason"]);
            if (dr["WHPP_CompanyCode"] != DBNull.Value) wH_Pay.WHPP_CompanyCode = Convert.ToString(dr["WHPP_CompanyCode"]);
            if (dr["WHPP_CompanyName"] != DBNull.Value) wH_Pay.WHPP_CompanyName = Convert.ToString(dr["WHPP_CompanyName"]);
            if (dr["WHPP_SCode"] != DBNull.Value) wH_Pay.WHPP_SCode = Convert.ToString(dr["WHPP_SCode"]);
            if (dr["WHPP_SName"] != DBNull.Value) wH_Pay.WHPP_SName = Convert.ToString(dr["WHPP_SName"]);
            if (dr["WHPP_Date"] != DBNull.Value) wH_Pay.WHPP_Date = Convert.ToDateTime(dr["WHPP_Date"]);
            if (dr["WHPP_PName"] != DBNull.Value) wH_Pay.WHPP_PName = Convert.ToString(dr["WHPP_PName"]);
            if (dr["WHPP_PayMethod"] != DBNull.Value) wH_Pay.WHPP_PayMethod = Convert.ToString(dr["WHPP_PayMethod"]);
            if (dr["WHPP_Sum"] != DBNull.Value) wH_Pay.WHPP_Sum = Convert.ToDecimal(dr["WHPP_Sum"]);
            if (dr["WHPP_RefType"] != DBNull.Value) wH_Pay.WHPP_RefType = Convert.ToString(dr["WHPP_RefType"]);
            if (dr["WHPP_RefCode"] != DBNull.Value) wH_Pay.WHPP_RefCode = Convert.ToString(dr["WHPP_RefCode"]);
            if (dr["WHPP_FOwner"] != DBNull.Value) wH_Pay.WHPP_FOwner = Convert.ToString(dr["WHPP_FOwner"]);
            if (dr["WHPP_POwner"] != DBNull.Value) wH_Pay.WHPP_POwner = Convert.ToString(dr["WHPP_POwner"]);
            if (dr["WHPP_Bak"] != DBNull.Value) wH_Pay.WHPP_Bak = Convert.ToString(dr["WHPP_Bak"]);
            if (dr["Stat"] != DBNull.Value) wH_Pay.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["CreateDate"] != DBNull.Value) wH_Pay.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
            if (dr["UpdateDate"] != DBNull.Value) wH_Pay.UpdateDate = Convert.ToDateTime(dr["UpdateDate"]);
            if (dr["DeleteDate"] != DBNull.Value) wH_Pay.DeleteDate = Convert.ToDateTime(dr["DeleteDate"]);
            if (dr["WHPP_LastMonth"] != DBNull.Value) wH_Pay.WHPP_LastMonth = Convert.ToDecimal(dr["WHPP_LastMonth"]);
            if (dr["WHPP_CurMonth"] != DBNull.Value) wH_Pay.WHPP_CurMonth = Convert.ToDecimal(dr["WHPP_CurMonth"]);
            if (dr["WHPP_NextMonth"] != DBNull.Value) wH_Pay.WHPP_NextMonth = Convert.ToDecimal(dr["WHPP_NextMonth"]);
            if (dr["WHPP_broom"] != DBNull.Value) wH_Pay.WHPP_broom = Convert.ToDecimal(dr["WHPP_broom"]);
            if (dr["WHPP_CurPay"] != DBNull.Value) wH_Pay.WHPP_CurPay = Convert.ToDecimal(dr["WHPP_CurPay"]);
            if (dr["WHPP_Plan"] != DBNull.Value) wH_Pay.WHPP_Plan = Convert.ToDecimal(dr["WHPP_Plan"]);
            if (dr["WHPP_Recive"] != DBNull.Value) wH_Pay.WHPP_Recive = Convert.ToDecimal(dr["WHPP_Recive"]);
            if (dr["WHPP_UDEF1"] != DBNull.Value) wH_Pay.WHPP_UDEF1 = Convert.ToString(dr["WHPP_UDEF1"]);
            if (dr["WHPP_UDEF2"] != DBNull.Value) wH_Pay.WHPP_UDEF2 = Convert.ToString(dr["WHPP_UDEF2"]);
            if (dr["WHPP_UDEF3"] != DBNull.Value) wH_Pay.WHPP_UDEF3 = Convert.ToString(dr["WHPP_UDEF3"]);
            if (dr["WHPP_UDEF4"] != DBNull.Value) wH_Pay.WHPP_UDEF4 = Convert.ToString(dr["WHPP_UDEF4"]);
            if (dr["WHPP_UDEF5"] != DBNull.Value) wH_Pay.WHPP_UDEF5 = Convert.ToString(dr["WHPP_UDEF5"]);
            if (dr["WHPP_UDEF6"] != DBNull.Value) wH_Pay.WHPP_UDEF6 = Convert.ToString(dr["WHPP_UDEF6"]);
            if (dr["WHPP_UDEF7"] != DBNull.Value) wH_Pay.WHPP_UDEF7 = Convert.ToString(dr["WHPP_UDEF7"]);
            if (dr["WHPP_UDEF8"] != DBNull.Value) wH_Pay.WHPP_UDEF8 = Convert.ToString(dr["WHPP_UDEF8"]);
            if (dr["WHPP_UDEF9"] != DBNull.Value) wH_Pay.WHPP_UDEF9 = Convert.ToString(dr["WHPP_UDEF9"]);
            if (dr["WHPP_UDEF10"] != DBNull.Value) wH_Pay.WHPP_UDEF10 = Convert.ToString(dr["WHPP_UDEF10"]);
            if (dr["WHPP_RelSum"] != DBNull.Value) wH_Pay.WHPP_RelSum = Convert.ToDecimal(dr["WHPP_RelSum"]);
            if (dr["WHPP_Pay"] != DBNull.Value) wH_Pay.WHPP_Pay = Convert.ToDecimal(dr["WHPP_Pay"]);
            if (dr["AuditStat"] != DBNull.Value) wH_Pay.AuditStat = Convert.ToString(dr["AuditStat"]);
            if (dr["AuditCurAudit"] != DBNull.Value) wH_Pay.AuditCurAudit = Convert.ToString(dr["AuditCurAudit"]);
            ret.Add(wH_Pay);
         }
          }catch (System.Exception ex){ throw ex; }  finally {  if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   } 
         return ret;
      }
   }
}
