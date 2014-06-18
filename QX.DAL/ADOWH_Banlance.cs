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
   /// 结算单
   /// </summary>
   [Serializable]
   public partial class ADOWH_Banlance
   {
      public IDBOperator idb =  DBOperator.GetInstance();
      /// <summary>
      /// 添加结算单 WH_Banlance对象(即:一条记录)
      /// </summary>
      public int Add(WH_Banlance wH_Banlance)
      {
         string sql = "INSERT INTO WH_Banlance (WHB_Period,WHB_iType,WHB_Code,WHB_UCompany,WHB_UCompanyCode,WHB_SCode,WHB_SName,WHB_LastMonth,WHB_CurMonth,WHB_CurPay,WHB_CurLeft,WHB_Plan,WHB_NextMonth,WHB_broom,WHB_Recive,WHB_Date,WHB_Status,WHB_UDEF1,WHB_UDEF2,WHB_UDEF3,WHB_UDEF4,WHB_UDEF5,WHB_UDEF6,WHB_UDEF7,WHB_UDEF8,WHB_UDEF9,WHB_UDEF10,Stat,CreateDate,UpdateDate,DeleteDate,WHB_Invoice,WHB_Pay,WHB_RInvoice,WHB_RPay,WHB_NumLast,WHB_NumCur,WHB_NumReturn,WHB_NumReal) VALUES (@WHB_Period,@WHB_iType,@WHB_Code,@WHB_UCompany,@WHB_UCompanyCode,@WHB_SCode,@WHB_SName,@WHB_LastMonth,@WHB_CurMonth,@WHB_CurPay,@WHB_CurLeft,@WHB_Plan,@WHB_NextMonth,@WHB_broom,@WHB_Recive,@WHB_Date,@WHB_Status,@WHB_UDEF1,@WHB_UDEF2,@WHB_UDEF3,@WHB_UDEF4,@WHB_UDEF5,@WHB_UDEF6,@WHB_UDEF7,@WHB_UDEF8,@WHB_UDEF9,@WHB_UDEF10,@Stat,@CreateDate,@UpdateDate,@DeleteDate,@WHB_Invoice,@WHB_Pay,@WHB_RInvoice,@WHB_RPay,@WHB_NumLast,@WHB_NumCur,@WHB_NumReturn,@WHB_NumReal)";
         if (string.IsNullOrEmpty(wH_Banlance.WHB_Period))
         {
            idb.AddParameter("@WHB_Period", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHB_Period", wH_Banlance.WHB_Period);
         }
         if (string.IsNullOrEmpty(wH_Banlance.WHB_iType))
         {
            idb.AddParameter("@WHB_iType", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHB_iType", wH_Banlance.WHB_iType);
         }
         if (string.IsNullOrEmpty(wH_Banlance.WHB_Code))
         {
            idb.AddParameter("@WHB_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHB_Code", wH_Banlance.WHB_Code);
         }
         if (string.IsNullOrEmpty(wH_Banlance.WHB_UCompany))
         {
            idb.AddParameter("@WHB_UCompany", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHB_UCompany", wH_Banlance.WHB_UCompany);
         }
         if (string.IsNullOrEmpty(wH_Banlance.WHB_UCompanyCode))
         {
            idb.AddParameter("@WHB_UCompanyCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHB_UCompanyCode", wH_Banlance.WHB_UCompanyCode);
         }
         if (string.IsNullOrEmpty(wH_Banlance.WHB_SCode))
         {
            idb.AddParameter("@WHB_SCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHB_SCode", wH_Banlance.WHB_SCode);
         }
         if (string.IsNullOrEmpty(wH_Banlance.WHB_SName))
         {
            idb.AddParameter("@WHB_SName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHB_SName", wH_Banlance.WHB_SName);
         }
         if (wH_Banlance.WHB_LastMonth == 0)
         {
            idb.AddParameter("@WHB_LastMonth", 0);
         }
         else
         {
            idb.AddParameter("@WHB_LastMonth", wH_Banlance.WHB_LastMonth);
         }
         if (wH_Banlance.WHB_CurMonth == 0)
         {
            idb.AddParameter("@WHB_CurMonth", 0);
         }
         else
         {
            idb.AddParameter("@WHB_CurMonth", wH_Banlance.WHB_CurMonth);
         }
         if (wH_Banlance.WHB_CurPay == 0)
         {
            idb.AddParameter("@WHB_CurPay", 0);
         }
         else
         {
            idb.AddParameter("@WHB_CurPay", wH_Banlance.WHB_CurPay);
         }
         if (wH_Banlance.WHB_CurLeft == 0)
         {
            idb.AddParameter("@WHB_CurLeft", 0);
         }
         else
         {
            idb.AddParameter("@WHB_CurLeft", wH_Banlance.WHB_CurLeft);
         }
         if (wH_Banlance.WHB_Plan == 0)
         {
            idb.AddParameter("@WHB_Plan", 0);
         }
         else
         {
            idb.AddParameter("@WHB_Plan", wH_Banlance.WHB_Plan);
         }
         if (wH_Banlance.WHB_NextMonth == 0)
         {
            idb.AddParameter("@WHB_NextMonth", 0);
         }
         else
         {
            idb.AddParameter("@WHB_NextMonth", wH_Banlance.WHB_NextMonth);
         }
         if (wH_Banlance.WHB_broom == 0)
         {
            idb.AddParameter("@WHB_broom", 0);
         }
         else
         {
            idb.AddParameter("@WHB_broom", wH_Banlance.WHB_broom);
         }
         if (wH_Banlance.WHB_Recive == 0)
         {
            idb.AddParameter("@WHB_Recive", 0);
         }
         else
         {
            idb.AddParameter("@WHB_Recive", wH_Banlance.WHB_Recive);
         }
         if (wH_Banlance.WHB_Date == DateTime.MinValue)
         {
            idb.AddParameter("@WHB_Date", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHB_Date", wH_Banlance.WHB_Date);
         }
         if (string.IsNullOrEmpty(wH_Banlance.WHB_Status))
         {
            idb.AddParameter("@WHB_Status", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHB_Status", wH_Banlance.WHB_Status);
         }
         if (string.IsNullOrEmpty(wH_Banlance.WHB_UDEF1))
         {
            idb.AddParameter("@WHB_UDEF1", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHB_UDEF1", wH_Banlance.WHB_UDEF1);
         }
         if (string.IsNullOrEmpty(wH_Banlance.WHB_UDEF2))
         {
            idb.AddParameter("@WHB_UDEF2", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHB_UDEF2", wH_Banlance.WHB_UDEF2);
         }
         if (string.IsNullOrEmpty(wH_Banlance.WHB_UDEF3))
         {
            idb.AddParameter("@WHB_UDEF3", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHB_UDEF3", wH_Banlance.WHB_UDEF3);
         }
         if (string.IsNullOrEmpty(wH_Banlance.WHB_UDEF4))
         {
            idb.AddParameter("@WHB_UDEF4", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHB_UDEF4", wH_Banlance.WHB_UDEF4);
         }
         if (string.IsNullOrEmpty(wH_Banlance.WHB_UDEF5))
         {
            idb.AddParameter("@WHB_UDEF5", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHB_UDEF5", wH_Banlance.WHB_UDEF5);
         }
         if (string.IsNullOrEmpty(wH_Banlance.WHB_UDEF6))
         {
            idb.AddParameter("@WHB_UDEF6", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHB_UDEF6", wH_Banlance.WHB_UDEF6);
         }
         if (string.IsNullOrEmpty(wH_Banlance.WHB_UDEF7))
         {
            idb.AddParameter("@WHB_UDEF7", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHB_UDEF7", wH_Banlance.WHB_UDEF7);
         }
         if (string.IsNullOrEmpty(wH_Banlance.WHB_UDEF8))
         {
            idb.AddParameter("@WHB_UDEF8", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHB_UDEF8", wH_Banlance.WHB_UDEF8);
         }
         if (string.IsNullOrEmpty(wH_Banlance.WHB_UDEF9))
         {
            idb.AddParameter("@WHB_UDEF9", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHB_UDEF9", wH_Banlance.WHB_UDEF9);
         }
         if (string.IsNullOrEmpty(wH_Banlance.WHB_UDEF10))
         {
            idb.AddParameter("@WHB_UDEF10", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHB_UDEF10", wH_Banlance.WHB_UDEF10);
         }
         if (wH_Banlance.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", wH_Banlance.Stat);
         }
         if (wH_Banlance.CreateDate == DateTime.MinValue)
         {
            idb.AddParameter("@CreateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateDate", wH_Banlance.CreateDate);
         }
         if (wH_Banlance.UpdateDate == DateTime.MinValue)
         {
            idb.AddParameter("@UpdateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@UpdateDate", wH_Banlance.UpdateDate);
         }
         if (wH_Banlance.DeleteDate == DateTime.MinValue)
         {
            idb.AddParameter("@DeleteDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DeleteDate", wH_Banlance.DeleteDate);
         }
         if (wH_Banlance.WHB_Invoice == 0)
         {
            idb.AddParameter("@WHB_Invoice", 0);
         }
         else
         {
            idb.AddParameter("@WHB_Invoice", wH_Banlance.WHB_Invoice);
         }
         if (wH_Banlance.WHB_Pay == 0)
         {
            idb.AddParameter("@WHB_Pay", 0);
         }
         else
         {
            idb.AddParameter("@WHB_Pay", wH_Banlance.WHB_Pay);
         }
         if (wH_Banlance.WHB_RInvoice == 0)
         {
            idb.AddParameter("@WHB_RInvoice", 0);
         }
         else
         {
            idb.AddParameter("@WHB_RInvoice", wH_Banlance.WHB_RInvoice);
         }
         if (wH_Banlance.WHB_RPay == 0)
         {
            idb.AddParameter("@WHB_RPay", 0);
         }
         else
         {
            idb.AddParameter("@WHB_RPay", wH_Banlance.WHB_RPay);
         }
         if (wH_Banlance.WHB_NumLast == 0)
         {
            idb.AddParameter("@WHB_NumLast", 0);
         }
         else
         {
            idb.AddParameter("@WHB_NumLast", wH_Banlance.WHB_NumLast);
         }
         if (wH_Banlance.WHB_NumCur == 0)
         {
            idb.AddParameter("@WHB_NumCur", 0);
         }
         else
         {
            idb.AddParameter("@WHB_NumCur", wH_Banlance.WHB_NumCur);
         }
         if (wH_Banlance.WHB_NumReturn == 0)
         {
            idb.AddParameter("@WHB_NumReturn", 0);
         }
         else
         {
            idb.AddParameter("@WHB_NumReturn", wH_Banlance.WHB_NumReturn);
         }
         if (wH_Banlance.WHB_NumReal == 0)
         {
            idb.AddParameter("@WHB_NumReal", 0);
         }
         else
         {
            idb.AddParameter("@WHB_NumReal", wH_Banlance.WHB_NumReal);
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
      /// 添加结算单 WH_Banlance对象(即:一条记录)
      /// </summary>
      public object AddWithReturn(WH_Banlance wH_Banlance)
      {
         string sql = "INSERT INTO WH_Banlance (WHB_Period,WHB_iType,WHB_Code,WHB_UCompany,WHB_UCompanyCode,WHB_SCode,WHB_SName,WHB_LastMonth,WHB_CurMonth,WHB_CurPay,WHB_CurLeft,WHB_Plan,WHB_NextMonth,WHB_broom,WHB_Recive,WHB_Date,WHB_Status,WHB_UDEF1,WHB_UDEF2,WHB_UDEF3,WHB_UDEF4,WHB_UDEF5,WHB_UDEF6,WHB_UDEF7,WHB_UDEF8,WHB_UDEF9,WHB_UDEF10,Stat,CreateDate,UpdateDate,DeleteDate,WHB_Invoice,WHB_Pay,WHB_RInvoice,WHB_RPay,WHB_NumLast,WHB_NumCur,WHB_NumReturn,WHB_NumReal) VALUES (@WHB_Period,@WHB_iType,@WHB_Code,@WHB_UCompany,@WHB_UCompanyCode,@WHB_SCode,@WHB_SName,@WHB_LastMonth,@WHB_CurMonth,@WHB_CurPay,@WHB_CurLeft,@WHB_Plan,@WHB_NextMonth,@WHB_broom,@WHB_Recive,@WHB_Date,@WHB_Status,@WHB_UDEF1,@WHB_UDEF2,@WHB_UDEF3,@WHB_UDEF4,@WHB_UDEF5,@WHB_UDEF6,@WHB_UDEF7,@WHB_UDEF8,@WHB_UDEF9,@WHB_UDEF10,@Stat,@CreateDate,@UpdateDate,@DeleteDate,@WHB_Invoice,@WHB_Pay,@WHB_RInvoice,@WHB_RPay,@WHB_NumLast,@WHB_NumCur,@WHB_NumReturn,@WHB_NumReal);SELECT @@IDENTITY AS ReturnID;";
         if (string.IsNullOrEmpty(wH_Banlance.WHB_Period))
         {
            idb.AddParameter("@WHB_Period", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHB_Period", wH_Banlance.WHB_Period);
         }
         if (string.IsNullOrEmpty(wH_Banlance.WHB_iType))
         {
            idb.AddParameter("@WHB_iType", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHB_iType", wH_Banlance.WHB_iType);
         }
         if (string.IsNullOrEmpty(wH_Banlance.WHB_Code))
         {
            idb.AddParameter("@WHB_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHB_Code", wH_Banlance.WHB_Code);
         }
         if (string.IsNullOrEmpty(wH_Banlance.WHB_UCompany))
         {
            idb.AddParameter("@WHB_UCompany", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHB_UCompany", wH_Banlance.WHB_UCompany);
         }
         if (string.IsNullOrEmpty(wH_Banlance.WHB_UCompanyCode))
         {
            idb.AddParameter("@WHB_UCompanyCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHB_UCompanyCode", wH_Banlance.WHB_UCompanyCode);
         }
         if (string.IsNullOrEmpty(wH_Banlance.WHB_SCode))
         {
            idb.AddParameter("@WHB_SCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHB_SCode", wH_Banlance.WHB_SCode);
         }
         if (string.IsNullOrEmpty(wH_Banlance.WHB_SName))
         {
            idb.AddParameter("@WHB_SName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHB_SName", wH_Banlance.WHB_SName);
         }
         if (wH_Banlance.WHB_LastMonth == 0)
         {
            idb.AddParameter("@WHB_LastMonth", 0);
         }
         else
         {
            idb.AddParameter("@WHB_LastMonth", wH_Banlance.WHB_LastMonth);
         }
         if (wH_Banlance.WHB_CurMonth == 0)
         {
            idb.AddParameter("@WHB_CurMonth", 0);
         }
         else
         {
            idb.AddParameter("@WHB_CurMonth", wH_Banlance.WHB_CurMonth);
         }
         if (wH_Banlance.WHB_CurPay == 0)
         {
            idb.AddParameter("@WHB_CurPay", 0);
         }
         else
         {
            idb.AddParameter("@WHB_CurPay", wH_Banlance.WHB_CurPay);
         }
         if (wH_Banlance.WHB_CurLeft == 0)
         {
            idb.AddParameter("@WHB_CurLeft", 0);
         }
         else
         {
            idb.AddParameter("@WHB_CurLeft", wH_Banlance.WHB_CurLeft);
         }
         if (wH_Banlance.WHB_Plan == 0)
         {
            idb.AddParameter("@WHB_Plan", 0);
         }
         else
         {
            idb.AddParameter("@WHB_Plan", wH_Banlance.WHB_Plan);
         }
         if (wH_Banlance.WHB_NextMonth == 0)
         {
            idb.AddParameter("@WHB_NextMonth", 0);
         }
         else
         {
            idb.AddParameter("@WHB_NextMonth", wH_Banlance.WHB_NextMonth);
         }
         if (wH_Banlance.WHB_broom == 0)
         {
            idb.AddParameter("@WHB_broom", 0);
         }
         else
         {
            idb.AddParameter("@WHB_broom", wH_Banlance.WHB_broom);
         }
         if (wH_Banlance.WHB_Recive == 0)
         {
            idb.AddParameter("@WHB_Recive", 0);
         }
         else
         {
            idb.AddParameter("@WHB_Recive", wH_Banlance.WHB_Recive);
         }
         if (wH_Banlance.WHB_Date == DateTime.MinValue)
         {
            idb.AddParameter("@WHB_Date", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHB_Date", wH_Banlance.WHB_Date);
         }
         if (string.IsNullOrEmpty(wH_Banlance.WHB_Status))
         {
            idb.AddParameter("@WHB_Status", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHB_Status", wH_Banlance.WHB_Status);
         }
         if (string.IsNullOrEmpty(wH_Banlance.WHB_UDEF1))
         {
            idb.AddParameter("@WHB_UDEF1", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHB_UDEF1", wH_Banlance.WHB_UDEF1);
         }
         if (string.IsNullOrEmpty(wH_Banlance.WHB_UDEF2))
         {
            idb.AddParameter("@WHB_UDEF2", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHB_UDEF2", wH_Banlance.WHB_UDEF2);
         }
         if (string.IsNullOrEmpty(wH_Banlance.WHB_UDEF3))
         {
            idb.AddParameter("@WHB_UDEF3", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHB_UDEF3", wH_Banlance.WHB_UDEF3);
         }
         if (string.IsNullOrEmpty(wH_Banlance.WHB_UDEF4))
         {
            idb.AddParameter("@WHB_UDEF4", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHB_UDEF4", wH_Banlance.WHB_UDEF4);
         }
         if (string.IsNullOrEmpty(wH_Banlance.WHB_UDEF5))
         {
            idb.AddParameter("@WHB_UDEF5", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHB_UDEF5", wH_Banlance.WHB_UDEF5);
         }
         if (string.IsNullOrEmpty(wH_Banlance.WHB_UDEF6))
         {
            idb.AddParameter("@WHB_UDEF6", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHB_UDEF6", wH_Banlance.WHB_UDEF6);
         }
         if (string.IsNullOrEmpty(wH_Banlance.WHB_UDEF7))
         {
            idb.AddParameter("@WHB_UDEF7", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHB_UDEF7", wH_Banlance.WHB_UDEF7);
         }
         if (string.IsNullOrEmpty(wH_Banlance.WHB_UDEF8))
         {
            idb.AddParameter("@WHB_UDEF8", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHB_UDEF8", wH_Banlance.WHB_UDEF8);
         }
         if (string.IsNullOrEmpty(wH_Banlance.WHB_UDEF9))
         {
            idb.AddParameter("@WHB_UDEF9", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHB_UDEF9", wH_Banlance.WHB_UDEF9);
         }
         if (string.IsNullOrEmpty(wH_Banlance.WHB_UDEF10))
         {
            idb.AddParameter("@WHB_UDEF10", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHB_UDEF10", wH_Banlance.WHB_UDEF10);
         }
         if (wH_Banlance.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", wH_Banlance.Stat);
         }
         if (wH_Banlance.CreateDate == DateTime.MinValue)
         {
            idb.AddParameter("@CreateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateDate", wH_Banlance.CreateDate);
         }
         if (wH_Banlance.UpdateDate == DateTime.MinValue)
         {
            idb.AddParameter("@UpdateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@UpdateDate", wH_Banlance.UpdateDate);
         }
         if (wH_Banlance.DeleteDate == DateTime.MinValue)
         {
            idb.AddParameter("@DeleteDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DeleteDate", wH_Banlance.DeleteDate);
         }
         if (wH_Banlance.WHB_Invoice == 0)
         {
            idb.AddParameter("@WHB_Invoice", 0);
         }
         else
         {
            idb.AddParameter("@WHB_Invoice", wH_Banlance.WHB_Invoice);
         }
         if (wH_Banlance.WHB_Pay == 0)
         {
            idb.AddParameter("@WHB_Pay", 0);
         }
         else
         {
            idb.AddParameter("@WHB_Pay", wH_Banlance.WHB_Pay);
         }
         if (wH_Banlance.WHB_RInvoice == 0)
         {
            idb.AddParameter("@WHB_RInvoice", 0);
         }
         else
         {
            idb.AddParameter("@WHB_RInvoice", wH_Banlance.WHB_RInvoice);
         }
         if (wH_Banlance.WHB_RPay == 0)
         {
            idb.AddParameter("@WHB_RPay", 0);
         }
         else
         {
            idb.AddParameter("@WHB_RPay", wH_Banlance.WHB_RPay);
         }
         if (wH_Banlance.WHB_NumLast == 0)
         {
            idb.AddParameter("@WHB_NumLast", 0);
         }
         else
         {
            idb.AddParameter("@WHB_NumLast", wH_Banlance.WHB_NumLast);
         }
         if (wH_Banlance.WHB_NumCur == 0)
         {
            idb.AddParameter("@WHB_NumCur", 0);
         }
         else
         {
            idb.AddParameter("@WHB_NumCur", wH_Banlance.WHB_NumCur);
         }
         if (wH_Banlance.WHB_NumReturn == 0)
         {
            idb.AddParameter("@WHB_NumReturn", 0);
         }
         else
         {
            idb.AddParameter("@WHB_NumReturn", wH_Banlance.WHB_NumReturn);
         }
         if (wH_Banlance.WHB_NumReal == 0)
         {
            idb.AddParameter("@WHB_NumReal", 0);
         }
         else
         {
            idb.AddParameter("@WHB_NumReal", wH_Banlance.WHB_NumReal);
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
      /// 更新结算单 WH_Banlance对象(即:一条记录
      /// </summary>
      public int Update(WH_Banlance wH_Banlance)
      {
         
         StringBuilder sbParameter=new StringBuilder();
      StringBuilder sb=new StringBuilder();
      sb.Append(@"UPDATE       WH_Banlance       SET ");
            if(wH_Banlance.WHB_Period_IsChanged){sbParameter.Append("WHB_Period=@WHB_Period, ");}
      if(wH_Banlance.WHB_iType_IsChanged){sbParameter.Append("WHB_iType=@WHB_iType, ");}
      if(wH_Banlance.WHB_Code_IsChanged){sbParameter.Append("WHB_Code=@WHB_Code, ");}
      if(wH_Banlance.WHB_UCompany_IsChanged){sbParameter.Append("WHB_UCompany=@WHB_UCompany, ");}
      if(wH_Banlance.WHB_UCompanyCode_IsChanged){sbParameter.Append("WHB_UCompanyCode=@WHB_UCompanyCode, ");}
      if(wH_Banlance.WHB_SCode_IsChanged){sbParameter.Append("WHB_SCode=@WHB_SCode, ");}
      if(wH_Banlance.WHB_SName_IsChanged){sbParameter.Append("WHB_SName=@WHB_SName, ");}
      if(wH_Banlance.WHB_LastMonth_IsChanged){sbParameter.Append("WHB_LastMonth=@WHB_LastMonth, ");}
      if(wH_Banlance.WHB_CurMonth_IsChanged){sbParameter.Append("WHB_CurMonth=@WHB_CurMonth, ");}
      if(wH_Banlance.WHB_CurPay_IsChanged){sbParameter.Append("WHB_CurPay=@WHB_CurPay, ");}
      if(wH_Banlance.WHB_CurLeft_IsChanged){sbParameter.Append("WHB_CurLeft=@WHB_CurLeft, ");}
      if(wH_Banlance.WHB_Plan_IsChanged){sbParameter.Append("WHB_Plan=@WHB_Plan, ");}
      if(wH_Banlance.WHB_NextMonth_IsChanged){sbParameter.Append("WHB_NextMonth=@WHB_NextMonth, ");}
      if(wH_Banlance.WHB_broom_IsChanged){sbParameter.Append("WHB_broom=@WHB_broom, ");}
      if(wH_Banlance.WHB_Recive_IsChanged){sbParameter.Append("WHB_Recive=@WHB_Recive, ");}
      if(wH_Banlance.WHB_Date_IsChanged){sbParameter.Append("WHB_Date=@WHB_Date, ");}
      if(wH_Banlance.WHB_Status_IsChanged){sbParameter.Append("WHB_Status=@WHB_Status, ");}
      if(wH_Banlance.WHB_UDEF1_IsChanged){sbParameter.Append("WHB_UDEF1=@WHB_UDEF1, ");}
      if(wH_Banlance.WHB_UDEF2_IsChanged){sbParameter.Append("WHB_UDEF2=@WHB_UDEF2, ");}
      if(wH_Banlance.WHB_UDEF3_IsChanged){sbParameter.Append("WHB_UDEF3=@WHB_UDEF3, ");}
      if(wH_Banlance.WHB_UDEF4_IsChanged){sbParameter.Append("WHB_UDEF4=@WHB_UDEF4, ");}
      if(wH_Banlance.WHB_UDEF5_IsChanged){sbParameter.Append("WHB_UDEF5=@WHB_UDEF5, ");}
      if(wH_Banlance.WHB_UDEF6_IsChanged){sbParameter.Append("WHB_UDEF6=@WHB_UDEF6, ");}
      if(wH_Banlance.WHB_UDEF7_IsChanged){sbParameter.Append("WHB_UDEF7=@WHB_UDEF7, ");}
      if(wH_Banlance.WHB_UDEF8_IsChanged){sbParameter.Append("WHB_UDEF8=@WHB_UDEF8, ");}
      if(wH_Banlance.WHB_UDEF9_IsChanged){sbParameter.Append("WHB_UDEF9=@WHB_UDEF9, ");}
      if(wH_Banlance.WHB_UDEF10_IsChanged){sbParameter.Append("WHB_UDEF10=@WHB_UDEF10, ");}
      if(wH_Banlance.Stat_IsChanged){sbParameter.Append("Stat=@Stat, ");}
      if(wH_Banlance.CreateDate_IsChanged){sbParameter.Append("CreateDate=@CreateDate, ");}
      if(wH_Banlance.UpdateDate_IsChanged){sbParameter.Append("UpdateDate=@UpdateDate, ");}
      if(wH_Banlance.DeleteDate_IsChanged){sbParameter.Append("DeleteDate=@DeleteDate, ");}
      if(wH_Banlance.WHB_Invoice_IsChanged){sbParameter.Append("WHB_Invoice=@WHB_Invoice, ");}
      if(wH_Banlance.WHB_Pay_IsChanged){sbParameter.Append("WHB_Pay=@WHB_Pay, ");}
      if(wH_Banlance.WHB_RInvoice_IsChanged){sbParameter.Append("WHB_RInvoice=@WHB_RInvoice, ");}
      if(wH_Banlance.WHB_RPay_IsChanged){sbParameter.Append("WHB_RPay=@WHB_RPay, ");}
      if(wH_Banlance.WHB_NumLast_IsChanged){sbParameter.Append("WHB_NumLast=@WHB_NumLast, ");}
      if(wH_Banlance.WHB_NumCur_IsChanged){sbParameter.Append("WHB_NumCur=@WHB_NumCur, ");}
      if(wH_Banlance.WHB_NumReturn_IsChanged){sbParameter.Append("WHB_NumReturn=@WHB_NumReturn, ");}
      if(wH_Banlance.WHB_NumReal_IsChanged){sbParameter.Append("WHB_NumReal=@WHB_NumReal ");}          sb.Append(sbParameter.ToString().Trim().TrimEnd(',')); 
      sb.Append(      " WHERE 1=1 AND ((Stat is null) or (Stat=0))   and WHB_ID=@WHB_ID; " );
      string sql=sb.ToString();
         if(wH_Banlance.WHB_Period_IsChanged)
         {
         if (string.IsNullOrEmpty(wH_Banlance.WHB_Period))
         {
            idb.AddParameter("@WHB_Period", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHB_Period", wH_Banlance.WHB_Period);
         }
          }
         if(wH_Banlance.WHB_iType_IsChanged)
         {
         if (string.IsNullOrEmpty(wH_Banlance.WHB_iType))
         {
            idb.AddParameter("@WHB_iType", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHB_iType", wH_Banlance.WHB_iType);
         }
          }
         if(wH_Banlance.WHB_Code_IsChanged)
         {
         if (string.IsNullOrEmpty(wH_Banlance.WHB_Code))
         {
            idb.AddParameter("@WHB_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHB_Code", wH_Banlance.WHB_Code);
         }
          }
         if(wH_Banlance.WHB_UCompany_IsChanged)
         {
         if (string.IsNullOrEmpty(wH_Banlance.WHB_UCompany))
         {
            idb.AddParameter("@WHB_UCompany", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHB_UCompany", wH_Banlance.WHB_UCompany);
         }
          }
         if(wH_Banlance.WHB_UCompanyCode_IsChanged)
         {
         if (string.IsNullOrEmpty(wH_Banlance.WHB_UCompanyCode))
         {
            idb.AddParameter("@WHB_UCompanyCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHB_UCompanyCode", wH_Banlance.WHB_UCompanyCode);
         }
          }
         if(wH_Banlance.WHB_SCode_IsChanged)
         {
         if (string.IsNullOrEmpty(wH_Banlance.WHB_SCode))
         {
            idb.AddParameter("@WHB_SCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHB_SCode", wH_Banlance.WHB_SCode);
         }
          }
         if(wH_Banlance.WHB_SName_IsChanged)
         {
         if (string.IsNullOrEmpty(wH_Banlance.WHB_SName))
         {
            idb.AddParameter("@WHB_SName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHB_SName", wH_Banlance.WHB_SName);
         }
          }
         if(wH_Banlance.WHB_LastMonth_IsChanged)
         {
         if (wH_Banlance.WHB_LastMonth == 0)
         {
            idb.AddParameter("@WHB_LastMonth", 0);
         }
         else
         {
            idb.AddParameter("@WHB_LastMonth", wH_Banlance.WHB_LastMonth);
         }
          }
         if(wH_Banlance.WHB_CurMonth_IsChanged)
         {
         if (wH_Banlance.WHB_CurMonth == 0)
         {
            idb.AddParameter("@WHB_CurMonth", 0);
         }
         else
         {
            idb.AddParameter("@WHB_CurMonth", wH_Banlance.WHB_CurMonth);
         }
          }
         if(wH_Banlance.WHB_CurPay_IsChanged)
         {
         if (wH_Banlance.WHB_CurPay == 0)
         {
            idb.AddParameter("@WHB_CurPay", 0);
         }
         else
         {
            idb.AddParameter("@WHB_CurPay", wH_Banlance.WHB_CurPay);
         }
          }
         if(wH_Banlance.WHB_CurLeft_IsChanged)
         {
         if (wH_Banlance.WHB_CurLeft == 0)
         {
            idb.AddParameter("@WHB_CurLeft", 0);
         }
         else
         {
            idb.AddParameter("@WHB_CurLeft", wH_Banlance.WHB_CurLeft);
         }
          }
         if(wH_Banlance.WHB_Plan_IsChanged)
         {
         if (wH_Banlance.WHB_Plan == 0)
         {
            idb.AddParameter("@WHB_Plan", 0);
         }
         else
         {
            idb.AddParameter("@WHB_Plan", wH_Banlance.WHB_Plan);
         }
          }
         if(wH_Banlance.WHB_NextMonth_IsChanged)
         {
         if (wH_Banlance.WHB_NextMonth == 0)
         {
            idb.AddParameter("@WHB_NextMonth", 0);
         }
         else
         {
            idb.AddParameter("@WHB_NextMonth", wH_Banlance.WHB_NextMonth);
         }
          }
         if(wH_Banlance.WHB_broom_IsChanged)
         {
         if (wH_Banlance.WHB_broom == 0)
         {
            idb.AddParameter("@WHB_broom", 0);
         }
         else
         {
            idb.AddParameter("@WHB_broom", wH_Banlance.WHB_broom);
         }
          }
         if(wH_Banlance.WHB_Recive_IsChanged)
         {
         if (wH_Banlance.WHB_Recive == 0)
         {
            idb.AddParameter("@WHB_Recive", 0);
         }
         else
         {
            idb.AddParameter("@WHB_Recive", wH_Banlance.WHB_Recive);
         }
          }
         if(wH_Banlance.WHB_Date_IsChanged)
         {
         if (wH_Banlance.WHB_Date == DateTime.MinValue)
         {
            idb.AddParameter("@WHB_Date", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHB_Date", wH_Banlance.WHB_Date);
         }
          }
         if(wH_Banlance.WHB_Status_IsChanged)
         {
         if (string.IsNullOrEmpty(wH_Banlance.WHB_Status))
         {
            idb.AddParameter("@WHB_Status", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHB_Status", wH_Banlance.WHB_Status);
         }
          }
         if(wH_Banlance.WHB_UDEF1_IsChanged)
         {
         if (string.IsNullOrEmpty(wH_Banlance.WHB_UDEF1))
         {
            idb.AddParameter("@WHB_UDEF1", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHB_UDEF1", wH_Banlance.WHB_UDEF1);
         }
          }
         if(wH_Banlance.WHB_UDEF2_IsChanged)
         {
         if (string.IsNullOrEmpty(wH_Banlance.WHB_UDEF2))
         {
            idb.AddParameter("@WHB_UDEF2", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHB_UDEF2", wH_Banlance.WHB_UDEF2);
         }
          }
         if(wH_Banlance.WHB_UDEF3_IsChanged)
         {
         if (string.IsNullOrEmpty(wH_Banlance.WHB_UDEF3))
         {
            idb.AddParameter("@WHB_UDEF3", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHB_UDEF3", wH_Banlance.WHB_UDEF3);
         }
          }
         if(wH_Banlance.WHB_UDEF4_IsChanged)
         {
         if (string.IsNullOrEmpty(wH_Banlance.WHB_UDEF4))
         {
            idb.AddParameter("@WHB_UDEF4", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHB_UDEF4", wH_Banlance.WHB_UDEF4);
         }
          }
         if(wH_Banlance.WHB_UDEF5_IsChanged)
         {
         if (string.IsNullOrEmpty(wH_Banlance.WHB_UDEF5))
         {
            idb.AddParameter("@WHB_UDEF5", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHB_UDEF5", wH_Banlance.WHB_UDEF5);
         }
          }
         if(wH_Banlance.WHB_UDEF6_IsChanged)
         {
         if (string.IsNullOrEmpty(wH_Banlance.WHB_UDEF6))
         {
            idb.AddParameter("@WHB_UDEF6", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHB_UDEF6", wH_Banlance.WHB_UDEF6);
         }
          }
         if(wH_Banlance.WHB_UDEF7_IsChanged)
         {
         if (string.IsNullOrEmpty(wH_Banlance.WHB_UDEF7))
         {
            idb.AddParameter("@WHB_UDEF7", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHB_UDEF7", wH_Banlance.WHB_UDEF7);
         }
          }
         if(wH_Banlance.WHB_UDEF8_IsChanged)
         {
         if (string.IsNullOrEmpty(wH_Banlance.WHB_UDEF8))
         {
            idb.AddParameter("@WHB_UDEF8", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHB_UDEF8", wH_Banlance.WHB_UDEF8);
         }
          }
         if(wH_Banlance.WHB_UDEF9_IsChanged)
         {
         if (string.IsNullOrEmpty(wH_Banlance.WHB_UDEF9))
         {
            idb.AddParameter("@WHB_UDEF9", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHB_UDEF9", wH_Banlance.WHB_UDEF9);
         }
          }
         if(wH_Banlance.WHB_UDEF10_IsChanged)
         {
         if (string.IsNullOrEmpty(wH_Banlance.WHB_UDEF10))
         {
            idb.AddParameter("@WHB_UDEF10", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHB_UDEF10", wH_Banlance.WHB_UDEF10);
         }
          }
         if(wH_Banlance.Stat_IsChanged)
         {
         if (wH_Banlance.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", wH_Banlance.Stat);
         }
          }
         if(wH_Banlance.CreateDate_IsChanged)
         {
         if (wH_Banlance.CreateDate == DateTime.MinValue)
         {
            idb.AddParameter("@CreateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateDate", wH_Banlance.CreateDate);
         }
          }
         if(wH_Banlance.UpdateDate_IsChanged)
         {
         if (wH_Banlance.UpdateDate == DateTime.MinValue)
         {
            idb.AddParameter("@UpdateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@UpdateDate", wH_Banlance.UpdateDate);
         }
          }
         if(wH_Banlance.DeleteDate_IsChanged)
         {
         if (wH_Banlance.DeleteDate == DateTime.MinValue)
         {
            idb.AddParameter("@DeleteDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DeleteDate", wH_Banlance.DeleteDate);
         }
          }
         if(wH_Banlance.WHB_Invoice_IsChanged)
         {
         if (wH_Banlance.WHB_Invoice == 0)
         {
            idb.AddParameter("@WHB_Invoice", 0);
         }
         else
         {
            idb.AddParameter("@WHB_Invoice", wH_Banlance.WHB_Invoice);
         }
          }
         if(wH_Banlance.WHB_Pay_IsChanged)
         {
         if (wH_Banlance.WHB_Pay == 0)
         {
            idb.AddParameter("@WHB_Pay", 0);
         }
         else
         {
            idb.AddParameter("@WHB_Pay", wH_Banlance.WHB_Pay);
         }
          }
         if(wH_Banlance.WHB_RInvoice_IsChanged)
         {
         if (wH_Banlance.WHB_RInvoice == 0)
         {
            idb.AddParameter("@WHB_RInvoice", 0);
         }
         else
         {
            idb.AddParameter("@WHB_RInvoice", wH_Banlance.WHB_RInvoice);
         }
          }
         if(wH_Banlance.WHB_RPay_IsChanged)
         {
         if (wH_Banlance.WHB_RPay == 0)
         {
            idb.AddParameter("@WHB_RPay", 0);
         }
         else
         {
            idb.AddParameter("@WHB_RPay", wH_Banlance.WHB_RPay);
         }
          }
         if(wH_Banlance.WHB_NumLast_IsChanged)
         {
         if (wH_Banlance.WHB_NumLast == 0)
         {
            idb.AddParameter("@WHB_NumLast", 0);
         }
         else
         {
            idb.AddParameter("@WHB_NumLast", wH_Banlance.WHB_NumLast);
         }
          }
         if(wH_Banlance.WHB_NumCur_IsChanged)
         {
         if (wH_Banlance.WHB_NumCur == 0)
         {
            idb.AddParameter("@WHB_NumCur", 0);
         }
         else
         {
            idb.AddParameter("@WHB_NumCur", wH_Banlance.WHB_NumCur);
         }
          }
         if(wH_Banlance.WHB_NumReturn_IsChanged)
         {
         if (wH_Banlance.WHB_NumReturn == 0)
         {
            idb.AddParameter("@WHB_NumReturn", 0);
         }
         else
         {
            idb.AddParameter("@WHB_NumReturn", wH_Banlance.WHB_NumReturn);
         }
          }
         if(wH_Banlance.WHB_NumReal_IsChanged)
         {
         if (wH_Banlance.WHB_NumReal == 0)
         {
            idb.AddParameter("@WHB_NumReal", 0);
         }
         else
         {
            idb.AddParameter("@WHB_NumReal", wH_Banlance.WHB_NumReal);
         }
          }

         idb.AddParameter("@WHB_ID", wH_Banlance.WHB_ID);

           
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
      /// 删除结算单 WH_Banlance对象(即:一条记录
      /// </summary>
      public int Delete(decimal wHB_ID)
      {
         string sql = "DELETE WH_Banlance WHERE 1=1  AND WHB_ID=@WHB_ID ";
         idb.AddParameter("@WHB_ID", wHB_ID);

           
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
      /// 获取指定的结算单 WH_Banlance对象(即:一条记录
      /// </summary>
      public WH_Banlance GetByKey(decimal wHB_ID)
      {
         WH_Banlance wH_Banlance = new WH_Banlance();
         string sql = "SELECT  WHB_ID,WHB_Period,WHB_iType,WHB_Code,WHB_UCompany,WHB_UCompanyCode,WHB_SCode,WHB_SName,WHB_LastMonth,WHB_CurMonth,WHB_CurPay,WHB_CurLeft,WHB_Plan,WHB_NextMonth,WHB_broom,WHB_Recive,WHB_Date,WHB_Status,WHB_UDEF1,WHB_UDEF2,WHB_UDEF3,WHB_UDEF4,WHB_UDEF5,WHB_UDEF6,WHB_UDEF7,WHB_UDEF8,WHB_UDEF9,WHB_UDEF10,Stat,CreateDate,UpdateDate,DeleteDate,WHB_Invoice,WHB_Pay,WHB_RInvoice,WHB_RPay,WHB_NumLast,WHB_NumCur,WHB_NumReturn,WHB_NumReal FROM WH_Banlance WHERE 1=1 AND ((Stat is null) or (Stat=0) )  AND WHB_ID=@WHB_ID ";
         idb.AddParameter("@WHB_ID", wHB_ID);

          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            if (dr["WHB_ID"] != DBNull.Value) wH_Banlance.WHB_ID = Convert.ToDecimal(dr["WHB_ID"]);
            if (dr["WHB_Period"] != DBNull.Value) wH_Banlance.WHB_Period = Convert.ToString(dr["WHB_Period"]);
            if (dr["WHB_iType"] != DBNull.Value) wH_Banlance.WHB_iType = Convert.ToString(dr["WHB_iType"]);
            if (dr["WHB_Code"] != DBNull.Value) wH_Banlance.WHB_Code = Convert.ToString(dr["WHB_Code"]);
            if (dr["WHB_UCompany"] != DBNull.Value) wH_Banlance.WHB_UCompany = Convert.ToString(dr["WHB_UCompany"]);
            if (dr["WHB_UCompanyCode"] != DBNull.Value) wH_Banlance.WHB_UCompanyCode = Convert.ToString(dr["WHB_UCompanyCode"]);
            if (dr["WHB_SCode"] != DBNull.Value) wH_Banlance.WHB_SCode = Convert.ToString(dr["WHB_SCode"]);
            if (dr["WHB_SName"] != DBNull.Value) wH_Banlance.WHB_SName = Convert.ToString(dr["WHB_SName"]);
            if (dr["WHB_LastMonth"] != DBNull.Value) wH_Banlance.WHB_LastMonth = Convert.ToDecimal(dr["WHB_LastMonth"]);
            if (dr["WHB_CurMonth"] != DBNull.Value) wH_Banlance.WHB_CurMonth = Convert.ToDecimal(dr["WHB_CurMonth"]);
            if (dr["WHB_CurPay"] != DBNull.Value) wH_Banlance.WHB_CurPay = Convert.ToDecimal(dr["WHB_CurPay"]);
            if (dr["WHB_CurLeft"] != DBNull.Value) wH_Banlance.WHB_CurLeft = Convert.ToDecimal(dr["WHB_CurLeft"]);
            if (dr["WHB_Plan"] != DBNull.Value) wH_Banlance.WHB_Plan = Convert.ToDecimal(dr["WHB_Plan"]);
            if (dr["WHB_NextMonth"] != DBNull.Value) wH_Banlance.WHB_NextMonth = Convert.ToDecimal(dr["WHB_NextMonth"]);
            if (dr["WHB_broom"] != DBNull.Value) wH_Banlance.WHB_broom = Convert.ToDecimal(dr["WHB_broom"]);
            if (dr["WHB_Recive"] != DBNull.Value) wH_Banlance.WHB_Recive = Convert.ToDecimal(dr["WHB_Recive"]);
            if (dr["WHB_Date"] != DBNull.Value) wH_Banlance.WHB_Date = Convert.ToDateTime(dr["WHB_Date"]);
            if (dr["WHB_Status"] != DBNull.Value) wH_Banlance.WHB_Status = Convert.ToString(dr["WHB_Status"]);
            if (dr["WHB_UDEF1"] != DBNull.Value) wH_Banlance.WHB_UDEF1 = Convert.ToString(dr["WHB_UDEF1"]);
            if (dr["WHB_UDEF2"] != DBNull.Value) wH_Banlance.WHB_UDEF2 = Convert.ToString(dr["WHB_UDEF2"]);
            if (dr["WHB_UDEF3"] != DBNull.Value) wH_Banlance.WHB_UDEF3 = Convert.ToString(dr["WHB_UDEF3"]);
            if (dr["WHB_UDEF4"] != DBNull.Value) wH_Banlance.WHB_UDEF4 = Convert.ToString(dr["WHB_UDEF4"]);
            if (dr["WHB_UDEF5"] != DBNull.Value) wH_Banlance.WHB_UDEF5 = Convert.ToString(dr["WHB_UDEF5"]);
            if (dr["WHB_UDEF6"] != DBNull.Value) wH_Banlance.WHB_UDEF6 = Convert.ToString(dr["WHB_UDEF6"]);
            if (dr["WHB_UDEF7"] != DBNull.Value) wH_Banlance.WHB_UDEF7 = Convert.ToString(dr["WHB_UDEF7"]);
            if (dr["WHB_UDEF8"] != DBNull.Value) wH_Banlance.WHB_UDEF8 = Convert.ToString(dr["WHB_UDEF8"]);
            if (dr["WHB_UDEF9"] != DBNull.Value) wH_Banlance.WHB_UDEF9 = Convert.ToString(dr["WHB_UDEF9"]);
            if (dr["WHB_UDEF10"] != DBNull.Value) wH_Banlance.WHB_UDEF10 = Convert.ToString(dr["WHB_UDEF10"]);
            if (dr["Stat"] != DBNull.Value) wH_Banlance.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["CreateDate"] != DBNull.Value) wH_Banlance.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
            if (dr["UpdateDate"] != DBNull.Value) wH_Banlance.UpdateDate = Convert.ToDateTime(dr["UpdateDate"]);
            if (dr["DeleteDate"] != DBNull.Value) wH_Banlance.DeleteDate = Convert.ToDateTime(dr["DeleteDate"]);
            if (dr["WHB_Invoice"] != DBNull.Value) wH_Banlance.WHB_Invoice = Convert.ToDecimal(dr["WHB_Invoice"]);
            if (dr["WHB_Pay"] != DBNull.Value) wH_Banlance.WHB_Pay = Convert.ToDecimal(dr["WHB_Pay"]);
            if (dr["WHB_RInvoice"] != DBNull.Value) wH_Banlance.WHB_RInvoice = Convert.ToDecimal(dr["WHB_RInvoice"]);
            if (dr["WHB_RPay"] != DBNull.Value) wH_Banlance.WHB_RPay = Convert.ToDecimal(dr["WHB_RPay"]);
            if (dr["WHB_NumLast"] != DBNull.Value) wH_Banlance.WHB_NumLast = Convert.ToDecimal(dr["WHB_NumLast"]);
            if (dr["WHB_NumCur"] != DBNull.Value) wH_Banlance.WHB_NumCur = Convert.ToDecimal(dr["WHB_NumCur"]);
            if (dr["WHB_NumReturn"] != DBNull.Value) wH_Banlance.WHB_NumReturn = Convert.ToDecimal(dr["WHB_NumReturn"]);
            if (dr["WHB_NumReal"] != DBNull.Value) wH_Banlance.WHB_NumReal = Convert.ToDecimal(dr["WHB_NumReal"]);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   }  
         return wH_Banlance;
      }
      /// <summary>
      /// 获取指定的结算单 WH_Banlance对象集合
      /// </summary>
      public List<WH_Banlance> GetListByWhere(string strCondition)
      {
         List<WH_Banlance> ret = new List<WH_Banlance>();
         string sql = "SELECT  WHB_ID,WHB_Period,WHB_iType,WHB_Code,WHB_UCompany,WHB_UCompanyCode,WHB_SCode,WHB_SName,WHB_LastMonth,WHB_CurMonth,WHB_CurPay,WHB_CurLeft,WHB_Plan,WHB_NextMonth,WHB_broom,WHB_Recive,WHB_Date,WHB_Status,WHB_UDEF1,WHB_UDEF2,WHB_UDEF3,WHB_UDEF4,WHB_UDEF5,WHB_UDEF6,WHB_UDEF7,WHB_UDEF8,WHB_UDEF9,WHB_UDEF10,Stat,CreateDate,UpdateDate,DeleteDate,WHB_Invoice,WHB_Pay,WHB_RInvoice,WHB_RPay,WHB_NumLast,WHB_NumCur,WHB_NumReturn,WHB_NumReal FROM WH_Banlance WHERE 1=1 AND ((Stat is null) or (Stat=0) ) ";
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
            WH_Banlance wH_Banlance = new WH_Banlance();
            if (dr["WHB_ID"] != DBNull.Value) wH_Banlance.WHB_ID = Convert.ToDecimal(dr["WHB_ID"]);
            if (dr["WHB_Period"] != DBNull.Value) wH_Banlance.WHB_Period = Convert.ToString(dr["WHB_Period"]);
            if (dr["WHB_iType"] != DBNull.Value) wH_Banlance.WHB_iType = Convert.ToString(dr["WHB_iType"]);
            if (dr["WHB_Code"] != DBNull.Value) wH_Banlance.WHB_Code = Convert.ToString(dr["WHB_Code"]);
            if (dr["WHB_UCompany"] != DBNull.Value) wH_Banlance.WHB_UCompany = Convert.ToString(dr["WHB_UCompany"]);
            if (dr["WHB_UCompanyCode"] != DBNull.Value) wH_Banlance.WHB_UCompanyCode = Convert.ToString(dr["WHB_UCompanyCode"]);
            if (dr["WHB_SCode"] != DBNull.Value) wH_Banlance.WHB_SCode = Convert.ToString(dr["WHB_SCode"]);
            if (dr["WHB_SName"] != DBNull.Value) wH_Banlance.WHB_SName = Convert.ToString(dr["WHB_SName"]);
            if (dr["WHB_LastMonth"] != DBNull.Value) wH_Banlance.WHB_LastMonth = Convert.ToDecimal(dr["WHB_LastMonth"]);
            if (dr["WHB_CurMonth"] != DBNull.Value) wH_Banlance.WHB_CurMonth = Convert.ToDecimal(dr["WHB_CurMonth"]);
            if (dr["WHB_CurPay"] != DBNull.Value) wH_Banlance.WHB_CurPay = Convert.ToDecimal(dr["WHB_CurPay"]);
            if (dr["WHB_CurLeft"] != DBNull.Value) wH_Banlance.WHB_CurLeft = Convert.ToDecimal(dr["WHB_CurLeft"]);
            if (dr["WHB_Plan"] != DBNull.Value) wH_Banlance.WHB_Plan = Convert.ToDecimal(dr["WHB_Plan"]);
            if (dr["WHB_NextMonth"] != DBNull.Value) wH_Banlance.WHB_NextMonth = Convert.ToDecimal(dr["WHB_NextMonth"]);
            if (dr["WHB_broom"] != DBNull.Value) wH_Banlance.WHB_broom = Convert.ToDecimal(dr["WHB_broom"]);
            if (dr["WHB_Recive"] != DBNull.Value) wH_Banlance.WHB_Recive = Convert.ToDecimal(dr["WHB_Recive"]);
            if (dr["WHB_Date"] != DBNull.Value) wH_Banlance.WHB_Date = Convert.ToDateTime(dr["WHB_Date"]);
            if (dr["WHB_Status"] != DBNull.Value) wH_Banlance.WHB_Status = Convert.ToString(dr["WHB_Status"]);
            if (dr["WHB_UDEF1"] != DBNull.Value) wH_Banlance.WHB_UDEF1 = Convert.ToString(dr["WHB_UDEF1"]);
            if (dr["WHB_UDEF2"] != DBNull.Value) wH_Banlance.WHB_UDEF2 = Convert.ToString(dr["WHB_UDEF2"]);
            if (dr["WHB_UDEF3"] != DBNull.Value) wH_Banlance.WHB_UDEF3 = Convert.ToString(dr["WHB_UDEF3"]);
            if (dr["WHB_UDEF4"] != DBNull.Value) wH_Banlance.WHB_UDEF4 = Convert.ToString(dr["WHB_UDEF4"]);
            if (dr["WHB_UDEF5"] != DBNull.Value) wH_Banlance.WHB_UDEF5 = Convert.ToString(dr["WHB_UDEF5"]);
            if (dr["WHB_UDEF6"] != DBNull.Value) wH_Banlance.WHB_UDEF6 = Convert.ToString(dr["WHB_UDEF6"]);
            if (dr["WHB_UDEF7"] != DBNull.Value) wH_Banlance.WHB_UDEF7 = Convert.ToString(dr["WHB_UDEF7"]);
            if (dr["WHB_UDEF8"] != DBNull.Value) wH_Banlance.WHB_UDEF8 = Convert.ToString(dr["WHB_UDEF8"]);
            if (dr["WHB_UDEF9"] != DBNull.Value) wH_Banlance.WHB_UDEF9 = Convert.ToString(dr["WHB_UDEF9"]);
            if (dr["WHB_UDEF10"] != DBNull.Value) wH_Banlance.WHB_UDEF10 = Convert.ToString(dr["WHB_UDEF10"]);
            if (dr["Stat"] != DBNull.Value) wH_Banlance.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["CreateDate"] != DBNull.Value) wH_Banlance.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
            if (dr["UpdateDate"] != DBNull.Value) wH_Banlance.UpdateDate = Convert.ToDateTime(dr["UpdateDate"]);
            if (dr["DeleteDate"] != DBNull.Value) wH_Banlance.DeleteDate = Convert.ToDateTime(dr["DeleteDate"]);
            if (dr["WHB_Invoice"] != DBNull.Value) wH_Banlance.WHB_Invoice = Convert.ToDecimal(dr["WHB_Invoice"]);
            if (dr["WHB_Pay"] != DBNull.Value) wH_Banlance.WHB_Pay = Convert.ToDecimal(dr["WHB_Pay"]);
            if (dr["WHB_RInvoice"] != DBNull.Value) wH_Banlance.WHB_RInvoice = Convert.ToDecimal(dr["WHB_RInvoice"]);
            if (dr["WHB_RPay"] != DBNull.Value) wH_Banlance.WHB_RPay = Convert.ToDecimal(dr["WHB_RPay"]);
            if (dr["WHB_NumLast"] != DBNull.Value) wH_Banlance.WHB_NumLast = Convert.ToDecimal(dr["WHB_NumLast"]);
            if (dr["WHB_NumCur"] != DBNull.Value) wH_Banlance.WHB_NumCur = Convert.ToDecimal(dr["WHB_NumCur"]);
            if (dr["WHB_NumReturn"] != DBNull.Value) wH_Banlance.WHB_NumReturn = Convert.ToDecimal(dr["WHB_NumReturn"]);
            if (dr["WHB_NumReal"] != DBNull.Value) wH_Banlance.WHB_NumReal = Convert.ToDecimal(dr["WHB_NumReal"]);
            ret.Add(wH_Banlance);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   }  
         return ret;
      }
      /// <summary>
      /// 获取所有的结算单 WH_Banlance对象(即:一条记录
      /// </summary>
      public List<WH_Banlance> GetAll()
      {
         List<WH_Banlance> ret = new List<WH_Banlance>();
         string sql = "SELECT  WHB_ID,WHB_Period,WHB_iType,WHB_Code,WHB_UCompany,WHB_UCompanyCode,WHB_SCode,WHB_SName,WHB_LastMonth,WHB_CurMonth,WHB_CurPay,WHB_CurLeft,WHB_Plan,WHB_NextMonth,WHB_broom,WHB_Recive,WHB_Date,WHB_Status,WHB_UDEF1,WHB_UDEF2,WHB_UDEF3,WHB_UDEF4,WHB_UDEF5,WHB_UDEF6,WHB_UDEF7,WHB_UDEF8,WHB_UDEF9,WHB_UDEF10,Stat,CreateDate,UpdateDate,DeleteDate,WHB_Invoice,WHB_Pay,WHB_RInvoice,WHB_RPay,WHB_NumLast,WHB_NumCur,WHB_NumReturn,WHB_NumReal FROM WH_Banlance where 1=1 AND ((Stat is null) or (Stat=0) ) order by WHB_ID desc ";
          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            WH_Banlance wH_Banlance = new WH_Banlance();
            if (dr["WHB_ID"] != DBNull.Value) wH_Banlance.WHB_ID = Convert.ToDecimal(dr["WHB_ID"]);
            if (dr["WHB_Period"] != DBNull.Value) wH_Banlance.WHB_Period = Convert.ToString(dr["WHB_Period"]);
            if (dr["WHB_iType"] != DBNull.Value) wH_Banlance.WHB_iType = Convert.ToString(dr["WHB_iType"]);
            if (dr["WHB_Code"] != DBNull.Value) wH_Banlance.WHB_Code = Convert.ToString(dr["WHB_Code"]);
            if (dr["WHB_UCompany"] != DBNull.Value) wH_Banlance.WHB_UCompany = Convert.ToString(dr["WHB_UCompany"]);
            if (dr["WHB_UCompanyCode"] != DBNull.Value) wH_Banlance.WHB_UCompanyCode = Convert.ToString(dr["WHB_UCompanyCode"]);
            if (dr["WHB_SCode"] != DBNull.Value) wH_Banlance.WHB_SCode = Convert.ToString(dr["WHB_SCode"]);
            if (dr["WHB_SName"] != DBNull.Value) wH_Banlance.WHB_SName = Convert.ToString(dr["WHB_SName"]);
            if (dr["WHB_LastMonth"] != DBNull.Value) wH_Banlance.WHB_LastMonth = Convert.ToDecimal(dr["WHB_LastMonth"]);
            if (dr["WHB_CurMonth"] != DBNull.Value) wH_Banlance.WHB_CurMonth = Convert.ToDecimal(dr["WHB_CurMonth"]);
            if (dr["WHB_CurPay"] != DBNull.Value) wH_Banlance.WHB_CurPay = Convert.ToDecimal(dr["WHB_CurPay"]);
            if (dr["WHB_CurLeft"] != DBNull.Value) wH_Banlance.WHB_CurLeft = Convert.ToDecimal(dr["WHB_CurLeft"]);
            if (dr["WHB_Plan"] != DBNull.Value) wH_Banlance.WHB_Plan = Convert.ToDecimal(dr["WHB_Plan"]);
            if (dr["WHB_NextMonth"] != DBNull.Value) wH_Banlance.WHB_NextMonth = Convert.ToDecimal(dr["WHB_NextMonth"]);
            if (dr["WHB_broom"] != DBNull.Value) wH_Banlance.WHB_broom = Convert.ToDecimal(dr["WHB_broom"]);
            if (dr["WHB_Recive"] != DBNull.Value) wH_Banlance.WHB_Recive = Convert.ToDecimal(dr["WHB_Recive"]);
            if (dr["WHB_Date"] != DBNull.Value) wH_Banlance.WHB_Date = Convert.ToDateTime(dr["WHB_Date"]);
            if (dr["WHB_Status"] != DBNull.Value) wH_Banlance.WHB_Status = Convert.ToString(dr["WHB_Status"]);
            if (dr["WHB_UDEF1"] != DBNull.Value) wH_Banlance.WHB_UDEF1 = Convert.ToString(dr["WHB_UDEF1"]);
            if (dr["WHB_UDEF2"] != DBNull.Value) wH_Banlance.WHB_UDEF2 = Convert.ToString(dr["WHB_UDEF2"]);
            if (dr["WHB_UDEF3"] != DBNull.Value) wH_Banlance.WHB_UDEF3 = Convert.ToString(dr["WHB_UDEF3"]);
            if (dr["WHB_UDEF4"] != DBNull.Value) wH_Banlance.WHB_UDEF4 = Convert.ToString(dr["WHB_UDEF4"]);
            if (dr["WHB_UDEF5"] != DBNull.Value) wH_Banlance.WHB_UDEF5 = Convert.ToString(dr["WHB_UDEF5"]);
            if (dr["WHB_UDEF6"] != DBNull.Value) wH_Banlance.WHB_UDEF6 = Convert.ToString(dr["WHB_UDEF6"]);
            if (dr["WHB_UDEF7"] != DBNull.Value) wH_Banlance.WHB_UDEF7 = Convert.ToString(dr["WHB_UDEF7"]);
            if (dr["WHB_UDEF8"] != DBNull.Value) wH_Banlance.WHB_UDEF8 = Convert.ToString(dr["WHB_UDEF8"]);
            if (dr["WHB_UDEF9"] != DBNull.Value) wH_Banlance.WHB_UDEF9 = Convert.ToString(dr["WHB_UDEF9"]);
            if (dr["WHB_UDEF10"] != DBNull.Value) wH_Banlance.WHB_UDEF10 = Convert.ToString(dr["WHB_UDEF10"]);
            if (dr["Stat"] != DBNull.Value) wH_Banlance.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["CreateDate"] != DBNull.Value) wH_Banlance.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
            if (dr["UpdateDate"] != DBNull.Value) wH_Banlance.UpdateDate = Convert.ToDateTime(dr["UpdateDate"]);
            if (dr["DeleteDate"] != DBNull.Value) wH_Banlance.DeleteDate = Convert.ToDateTime(dr["DeleteDate"]);
            if (dr["WHB_Invoice"] != DBNull.Value) wH_Banlance.WHB_Invoice = Convert.ToDecimal(dr["WHB_Invoice"]);
            if (dr["WHB_Pay"] != DBNull.Value) wH_Banlance.WHB_Pay = Convert.ToDecimal(dr["WHB_Pay"]);
            if (dr["WHB_RInvoice"] != DBNull.Value) wH_Banlance.WHB_RInvoice = Convert.ToDecimal(dr["WHB_RInvoice"]);
            if (dr["WHB_RPay"] != DBNull.Value) wH_Banlance.WHB_RPay = Convert.ToDecimal(dr["WHB_RPay"]);
            if (dr["WHB_NumLast"] != DBNull.Value) wH_Banlance.WHB_NumLast = Convert.ToDecimal(dr["WHB_NumLast"]);
            if (dr["WHB_NumCur"] != DBNull.Value) wH_Banlance.WHB_NumCur = Convert.ToDecimal(dr["WHB_NumCur"]);
            if (dr["WHB_NumReturn"] != DBNull.Value) wH_Banlance.WHB_NumReturn = Convert.ToDecimal(dr["WHB_NumReturn"]);
            if (dr["WHB_NumReal"] != DBNull.Value) wH_Banlance.WHB_NumReal = Convert.ToDecimal(dr["WHB_NumReal"]);
            ret.Add(wH_Banlance);
         }
          }catch (System.Exception ex){ throw ex; }  finally {  if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   } 
         return ret;
      }
   }
}
