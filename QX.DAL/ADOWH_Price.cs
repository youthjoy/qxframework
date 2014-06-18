using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Text;
using QX.Model;
using QX.DataAcess;

namespace QX.DAL
{
   [Serializable]
   public partial class ADOWH_Price
   {
      public IDBOperator idb =  DBOperator.GetInstance();
      /// <summary>
      /// 添加WH_Price对象(即:一条记录)
      /// </summary>
      public int Add(WH_Price wH_Price)
      {
         string sql = "INSERT INTO WH_Price (WP_CCode,WP_CName,WP_MCode,WP_MName,WP_Spec,WP_Unit,WP_Price,WP_Num,WP_ONum,WP_PNum,WP_RNum,WP_RONum,WP_INum,WP_PRONum,WP_PRINum,WP_Udef1,WP_Udef2,WP_Udef3,WP_Udef4,WP_Udef5,WP_Udef6,WP_Udef7,WP_Udef8,WP_Udef9,WP_Udef10,Stat,WP_LastPPDate,WP_LastPPCollectDate,WP_LastPODate,WP_LastPOSupCode,WP_LastPOSupName,WP_LastPIDate,WP_LastPISupCode,WP_LastPISupName,WP_LastPRDate,WP_LastPRSupCode,WP_LastPRSupName,WP_LastRODate,WP_LastRODeptCode,WP_LastRODeptName,WP_LastROUseType,WP_LastROEmpCode,WP_LastROEmpName,WP_LastPRODate,WP_LastPRIDate,WP_LastPRISupCode,WP_LastPRISupName,WP_LastPROSupCode,WP_LastPROSupName,WP_CountPP,WP_CountPO,WP_CountPI,WP_CountPR,WP_CountRO,WP_CountPRO,WP_CountRR,WP_LeftPO,WP_LeftPP,WP_LastRRDate,WP_LastRRDeptCode,WP_LastRRDeptName,WP_LastRRUseType,WP_LastRREmpCode,WP_LastRREmpName) VALUES (@WP_CCode,@WP_CName,@WP_MCode,@WP_MName,@WP_Spec,@WP_Unit,@WP_Price,@WP_Num,@WP_ONum,@WP_PNum,@WP_RNum,@WP_RONum,@WP_INum,@WP_PRONum,@WP_PRINum,@WP_Udef1,@WP_Udef2,@WP_Udef3,@WP_Udef4,@WP_Udef5,@WP_Udef6,@WP_Udef7,@WP_Udef8,@WP_Udef9,@WP_Udef10,@Stat,@WP_LastPPDate,@WP_LastPPCollectDate,@WP_LastPODate,@WP_LastPOSupCode,@WP_LastPOSupName,@WP_LastPIDate,@WP_LastPISupCode,@WP_LastPISupName,@WP_LastPRDate,@WP_LastPRSupCode,@WP_LastPRSupName,@WP_LastRODate,@WP_LastRODeptCode,@WP_LastRODeptName,@WP_LastROUseType,@WP_LastROEmpCode,@WP_LastROEmpName,@WP_LastPRODate,@WP_LastPRIDate,@WP_LastPRISupCode,@WP_LastPRISupName,@WP_LastPROSupCode,@WP_LastPROSupName,@WP_CountPP,@WP_CountPO,@WP_CountPI,@WP_CountPR,@WP_CountRO,@WP_CountPRO,@WP_CountRR,@WP_LeftPO,@WP_LeftPP,@WP_LastRRDate,@WP_LastRRDeptCode,@WP_LastRRDeptName,@WP_LastRRUseType,@WP_LastRREmpCode,@WP_LastRREmpName)";
         if (string.IsNullOrEmpty(wH_Price.WP_CCode))
         {
            idb.AddParameter("@WP_CCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WP_CCode", wH_Price.WP_CCode);
         }
         if (string.IsNullOrEmpty(wH_Price.WP_CName))
         {
            idb.AddParameter("@WP_CName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WP_CName", wH_Price.WP_CName);
         }
         if (string.IsNullOrEmpty(wH_Price.WP_MCode))
         {
            idb.AddParameter("@WP_MCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WP_MCode", wH_Price.WP_MCode);
         }
         if (string.IsNullOrEmpty(wH_Price.WP_MName))
         {
            idb.AddParameter("@WP_MName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WP_MName", wH_Price.WP_MName);
         }
         if (string.IsNullOrEmpty(wH_Price.WP_Spec))
         {
            idb.AddParameter("@WP_Spec", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WP_Spec", wH_Price.WP_Spec);
         }
         if (string.IsNullOrEmpty(wH_Price.WP_Unit))
         {
            idb.AddParameter("@WP_Unit", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WP_Unit", wH_Price.WP_Unit);
         }
         if (wH_Price.WP_Price == 0)
         {
            idb.AddParameter("@WP_Price", 0);
         }
         else
         {
            idb.AddParameter("@WP_Price", wH_Price.WP_Price);
         }
         if (wH_Price.WP_Num == 0)
         {
            idb.AddParameter("@WP_Num", 0);
         }
         else
         {
            idb.AddParameter("@WP_Num", wH_Price.WP_Num);
         }
         if (wH_Price.WP_ONum == 0)
         {
            idb.AddParameter("@WP_ONum", 0);
         }
         else
         {
            idb.AddParameter("@WP_ONum", wH_Price.WP_ONum);
         }
         if (wH_Price.WP_PNum == 0)
         {
            idb.AddParameter("@WP_PNum", 0);
         }
         else
         {
            idb.AddParameter("@WP_PNum", wH_Price.WP_PNum);
         }
         if (wH_Price.WP_RNum == 0)
         {
            idb.AddParameter("@WP_RNum", 0);
         }
         else
         {
            idb.AddParameter("@WP_RNum", wH_Price.WP_RNum);
         }
         if (wH_Price.WP_RONum == 0)
         {
            idb.AddParameter("@WP_RONum", 0);
         }
         else
         {
            idb.AddParameter("@WP_RONum", wH_Price.WP_RONum);
         }
         if (wH_Price.WP_INum == 0)
         {
            idb.AddParameter("@WP_INum", 0);
         }
         else
         {
            idb.AddParameter("@WP_INum", wH_Price.WP_INum);
         }
         if (wH_Price.WP_PRONum == 0)
         {
            idb.AddParameter("@WP_PRONum", 0);
         }
         else
         {
            idb.AddParameter("@WP_PRONum", wH_Price.WP_PRONum);
         }
         if (wH_Price.WP_PRINum == 0)
         {
            idb.AddParameter("@WP_PRINum", 0);
         }
         else
         {
            idb.AddParameter("@WP_PRINum", wH_Price.WP_PRINum);
         }
         if (string.IsNullOrEmpty(wH_Price.WP_Udef1))
         {
            idb.AddParameter("@WP_Udef1", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WP_Udef1", wH_Price.WP_Udef1);
         }
         if (string.IsNullOrEmpty(wH_Price.WP_Udef2))
         {
            idb.AddParameter("@WP_Udef2", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WP_Udef2", wH_Price.WP_Udef2);
         }
         if (string.IsNullOrEmpty(wH_Price.WP_Udef3))
         {
            idb.AddParameter("@WP_Udef3", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WP_Udef3", wH_Price.WP_Udef3);
         }
         if (string.IsNullOrEmpty(wH_Price.WP_Udef4))
         {
            idb.AddParameter("@WP_Udef4", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WP_Udef4", wH_Price.WP_Udef4);
         }
         if (string.IsNullOrEmpty(wH_Price.WP_Udef5))
         {
            idb.AddParameter("@WP_Udef5", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WP_Udef5", wH_Price.WP_Udef5);
         }
         if (string.IsNullOrEmpty(wH_Price.WP_Udef6))
         {
            idb.AddParameter("@WP_Udef6", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WP_Udef6", wH_Price.WP_Udef6);
         }
         if (string.IsNullOrEmpty(wH_Price.WP_Udef7))
         {
            idb.AddParameter("@WP_Udef7", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WP_Udef7", wH_Price.WP_Udef7);
         }
         if (string.IsNullOrEmpty(wH_Price.WP_Udef8))
         {
            idb.AddParameter("@WP_Udef8", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WP_Udef8", wH_Price.WP_Udef8);
         }
         if (string.IsNullOrEmpty(wH_Price.WP_Udef9))
         {
            idb.AddParameter("@WP_Udef9", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WP_Udef9", wH_Price.WP_Udef9);
         }
         if (string.IsNullOrEmpty(wH_Price.WP_Udef10))
         {
            idb.AddParameter("@WP_Udef10", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WP_Udef10", wH_Price.WP_Udef10);
         }
         if (wH_Price.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", wH_Price.Stat);
         }
         if (wH_Price.WP_LastPPDate == DateTime.MinValue)
         {
            idb.AddParameter("@WP_LastPPDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WP_LastPPDate", wH_Price.WP_LastPPDate);
         }
         if (wH_Price.WP_LastPPCollectDate == DateTime.MinValue)
         {
            idb.AddParameter("@WP_LastPPCollectDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WP_LastPPCollectDate", wH_Price.WP_LastPPCollectDate);
         }
         if (wH_Price.WP_LastPODate == DateTime.MinValue)
         {
            idb.AddParameter("@WP_LastPODate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WP_LastPODate", wH_Price.WP_LastPODate);
         }
         if (string.IsNullOrEmpty(wH_Price.WP_LastPOSupCode))
         {
            idb.AddParameter("@WP_LastPOSupCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WP_LastPOSupCode", wH_Price.WP_LastPOSupCode);
         }
         if (string.IsNullOrEmpty(wH_Price.WP_LastPOSupName))
         {
            idb.AddParameter("@WP_LastPOSupName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WP_LastPOSupName", wH_Price.WP_LastPOSupName);
         }
         if (wH_Price.WP_LastPIDate == DateTime.MinValue)
         {
            idb.AddParameter("@WP_LastPIDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WP_LastPIDate", wH_Price.WP_LastPIDate);
         }
         if (string.IsNullOrEmpty(wH_Price.WP_LastPISupCode))
         {
            idb.AddParameter("@WP_LastPISupCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WP_LastPISupCode", wH_Price.WP_LastPISupCode);
         }
         if (string.IsNullOrEmpty(wH_Price.WP_LastPISupName))
         {
            idb.AddParameter("@WP_LastPISupName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WP_LastPISupName", wH_Price.WP_LastPISupName);
         }
         if (wH_Price.WP_LastPRDate == DateTime.MinValue)
         {
            idb.AddParameter("@WP_LastPRDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WP_LastPRDate", wH_Price.WP_LastPRDate);
         }
         if (string.IsNullOrEmpty(wH_Price.WP_LastPRSupCode))
         {
            idb.AddParameter("@WP_LastPRSupCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WP_LastPRSupCode", wH_Price.WP_LastPRSupCode);
         }
         if (string.IsNullOrEmpty(wH_Price.WP_LastPRSupName))
         {
            idb.AddParameter("@WP_LastPRSupName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WP_LastPRSupName", wH_Price.WP_LastPRSupName);
         }
         if (wH_Price.WP_LastRODate == DateTime.MinValue)
         {
            idb.AddParameter("@WP_LastRODate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WP_LastRODate", wH_Price.WP_LastRODate);
         }
         if (string.IsNullOrEmpty(wH_Price.WP_LastRODeptCode))
         {
            idb.AddParameter("@WP_LastRODeptCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WP_LastRODeptCode", wH_Price.WP_LastRODeptCode);
         }
         if (string.IsNullOrEmpty(wH_Price.WP_LastRODeptName))
         {
            idb.AddParameter("@WP_LastRODeptName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WP_LastRODeptName", wH_Price.WP_LastRODeptName);
         }
         if (string.IsNullOrEmpty(wH_Price.WP_LastROUseType))
         {
            idb.AddParameter("@WP_LastROUseType", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WP_LastROUseType", wH_Price.WP_LastROUseType);
         }
         if (string.IsNullOrEmpty(wH_Price.WP_LastROEmpCode))
         {
            idb.AddParameter("@WP_LastROEmpCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WP_LastROEmpCode", wH_Price.WP_LastROEmpCode);
         }
         if (string.IsNullOrEmpty(wH_Price.WP_LastROEmpName))
         {
            idb.AddParameter("@WP_LastROEmpName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WP_LastROEmpName", wH_Price.WP_LastROEmpName);
         }
         if (wH_Price.WP_LastPRODate == DateTime.MinValue)
         {
            idb.AddParameter("@WP_LastPRODate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WP_LastPRODate", wH_Price.WP_LastPRODate);
         }
         if (wH_Price.WP_LastPRIDate == DateTime.MinValue)
         {
            idb.AddParameter("@WP_LastPRIDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WP_LastPRIDate", wH_Price.WP_LastPRIDate);
         }
         if (string.IsNullOrEmpty(wH_Price.WP_LastPRISupCode))
         {
            idb.AddParameter("@WP_LastPRISupCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WP_LastPRISupCode", wH_Price.WP_LastPRISupCode);
         }
         if (string.IsNullOrEmpty(wH_Price.WP_LastPRISupName))
         {
            idb.AddParameter("@WP_LastPRISupName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WP_LastPRISupName", wH_Price.WP_LastPRISupName);
         }
         if (string.IsNullOrEmpty(wH_Price.WP_LastPROSupCode))
         {
            idb.AddParameter("@WP_LastPROSupCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WP_LastPROSupCode", wH_Price.WP_LastPROSupCode);
         }
         if (string.IsNullOrEmpty(wH_Price.WP_LastPROSupName))
         {
            idb.AddParameter("@WP_LastPROSupName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WP_LastPROSupName", wH_Price.WP_LastPROSupName);
         }
         if (wH_Price.WP_CountPP == 0)
         {
            idb.AddParameter("@WP_CountPP", 0);
         }
         else
         {
            idb.AddParameter("@WP_CountPP", wH_Price.WP_CountPP);
         }
         if (wH_Price.WP_CountPO == 0)
         {
            idb.AddParameter("@WP_CountPO", 0);
         }
         else
         {
            idb.AddParameter("@WP_CountPO", wH_Price.WP_CountPO);
         }
         if (wH_Price.WP_CountPI == 0)
         {
            idb.AddParameter("@WP_CountPI", 0);
         }
         else
         {
            idb.AddParameter("@WP_CountPI", wH_Price.WP_CountPI);
         }
         if (wH_Price.WP_CountPR == 0)
         {
            idb.AddParameter("@WP_CountPR", 0);
         }
         else
         {
            idb.AddParameter("@WP_CountPR", wH_Price.WP_CountPR);
         }
         if (wH_Price.WP_CountRO == 0)
         {
            idb.AddParameter("@WP_CountRO", 0);
         }
         else
         {
            idb.AddParameter("@WP_CountRO", wH_Price.WP_CountRO);
         }
         if (wH_Price.WP_CountPRO == 0)
         {
            idb.AddParameter("@WP_CountPRO", 0);
         }
         else
         {
            idb.AddParameter("@WP_CountPRO", wH_Price.WP_CountPRO);
         }
         if (wH_Price.WP_CountRR == 0)
         {
            idb.AddParameter("@WP_CountRR", 0);
         }
         else
         {
            idb.AddParameter("@WP_CountRR", wH_Price.WP_CountRR);
         }
         if (wH_Price.WP_LeftPO == 0)
         {
            idb.AddParameter("@WP_LeftPO", 0);
         }
         else
         {
            idb.AddParameter("@WP_LeftPO", wH_Price.WP_LeftPO);
         }
         if (wH_Price.WP_LeftPP == 0)
         {
            idb.AddParameter("@WP_LeftPP", 0);
         }
         else
         {
            idb.AddParameter("@WP_LeftPP", wH_Price.WP_LeftPP);
         }
         if (wH_Price.WP_LastRRDate == DateTime.MinValue)
         {
            idb.AddParameter("@WP_LastRRDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WP_LastRRDate", wH_Price.WP_LastRRDate);
         }
         if (string.IsNullOrEmpty(wH_Price.WP_LastRRDeptCode))
         {
            idb.AddParameter("@WP_LastRRDeptCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WP_LastRRDeptCode", wH_Price.WP_LastRRDeptCode);
         }
         if (string.IsNullOrEmpty(wH_Price.WP_LastRRDeptName))
         {
            idb.AddParameter("@WP_LastRRDeptName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WP_LastRRDeptName", wH_Price.WP_LastRRDeptName);
         }
         if (string.IsNullOrEmpty(wH_Price.WP_LastRRUseType))
         {
            idb.AddParameter("@WP_LastRRUseType", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WP_LastRRUseType", wH_Price.WP_LastRRUseType);
         }
         if (string.IsNullOrEmpty(wH_Price.WP_LastRREmpCode))
         {
            idb.AddParameter("@WP_LastRREmpCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WP_LastRREmpCode", wH_Price.WP_LastRREmpCode);
         }
         if (string.IsNullOrEmpty(wH_Price.WP_LastRREmpName))
         {
            idb.AddParameter("@WP_LastRREmpName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WP_LastRREmpName", wH_Price.WP_LastRREmpName);
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
      /// 添加WH_Price对象(即:一条记录)
      /// </summary>
      public object AddWithReturn(WH_Price wH_Price)
      {
         string sql = "INSERT INTO WH_Price (WP_CCode,WP_CName,WP_MCode,WP_MName,WP_Spec,WP_Unit,WP_Price,WP_Num,WP_ONum,WP_PNum,WP_RNum,WP_RONum,WP_INum,WP_PRONum,WP_PRINum,WP_Udef1,WP_Udef2,WP_Udef3,WP_Udef4,WP_Udef5,WP_Udef6,WP_Udef7,WP_Udef8,WP_Udef9,WP_Udef10,Stat,WP_LastPPDate,WP_LastPPCollectDate,WP_LastPODate,WP_LastPOSupCode,WP_LastPOSupName,WP_LastPIDate,WP_LastPISupCode,WP_LastPISupName,WP_LastPRDate,WP_LastPRSupCode,WP_LastPRSupName,WP_LastRODate,WP_LastRODeptCode,WP_LastRODeptName,WP_LastROUseType,WP_LastROEmpCode,WP_LastROEmpName,WP_LastPRODate,WP_LastPRIDate,WP_LastPRISupCode,WP_LastPRISupName,WP_LastPROSupCode,WP_LastPROSupName,WP_CountPP,WP_CountPO,WP_CountPI,WP_CountPR,WP_CountRO,WP_CountPRO,WP_CountRR,WP_LeftPO,WP_LeftPP,WP_LastRRDate,WP_LastRRDeptCode,WP_LastRRDeptName,WP_LastRRUseType,WP_LastRREmpCode,WP_LastRREmpName) VALUES (@WP_CCode,@WP_CName,@WP_MCode,@WP_MName,@WP_Spec,@WP_Unit,@WP_Price,@WP_Num,@WP_ONum,@WP_PNum,@WP_RNum,@WP_RONum,@WP_INum,@WP_PRONum,@WP_PRINum,@WP_Udef1,@WP_Udef2,@WP_Udef3,@WP_Udef4,@WP_Udef5,@WP_Udef6,@WP_Udef7,@WP_Udef8,@WP_Udef9,@WP_Udef10,@Stat,@WP_LastPPDate,@WP_LastPPCollectDate,@WP_LastPODate,@WP_LastPOSupCode,@WP_LastPOSupName,@WP_LastPIDate,@WP_LastPISupCode,@WP_LastPISupName,@WP_LastPRDate,@WP_LastPRSupCode,@WP_LastPRSupName,@WP_LastRODate,@WP_LastRODeptCode,@WP_LastRODeptName,@WP_LastROUseType,@WP_LastROEmpCode,@WP_LastROEmpName,@WP_LastPRODate,@WP_LastPRIDate,@WP_LastPRISupCode,@WP_LastPRISupName,@WP_LastPROSupCode,@WP_LastPROSupName,@WP_CountPP,@WP_CountPO,@WP_CountPI,@WP_CountPR,@WP_CountRO,@WP_CountPRO,@WP_CountRR,@WP_LeftPO,@WP_LeftPP,@WP_LastRRDate,@WP_LastRRDeptCode,@WP_LastRRDeptName,@WP_LastRRUseType,@WP_LastRREmpCode,@WP_LastRREmpName);SELECT @@IDENTITY AS ReturnID;";
         if (string.IsNullOrEmpty(wH_Price.WP_CCode))
         {
            idb.AddParameter("@WP_CCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WP_CCode", wH_Price.WP_CCode);
         }
         if (string.IsNullOrEmpty(wH_Price.WP_CName))
         {
            idb.AddParameter("@WP_CName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WP_CName", wH_Price.WP_CName);
         }
         if (string.IsNullOrEmpty(wH_Price.WP_MCode))
         {
            idb.AddParameter("@WP_MCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WP_MCode", wH_Price.WP_MCode);
         }
         if (string.IsNullOrEmpty(wH_Price.WP_MName))
         {
            idb.AddParameter("@WP_MName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WP_MName", wH_Price.WP_MName);
         }
         if (string.IsNullOrEmpty(wH_Price.WP_Spec))
         {
            idb.AddParameter("@WP_Spec", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WP_Spec", wH_Price.WP_Spec);
         }
         if (string.IsNullOrEmpty(wH_Price.WP_Unit))
         {
            idb.AddParameter("@WP_Unit", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WP_Unit", wH_Price.WP_Unit);
         }
         if (wH_Price.WP_Price == 0)
         {
            idb.AddParameter("@WP_Price", 0);
         }
         else
         {
            idb.AddParameter("@WP_Price", wH_Price.WP_Price);
         }
         if (wH_Price.WP_Num == 0)
         {
            idb.AddParameter("@WP_Num", 0);
         }
         else
         {
            idb.AddParameter("@WP_Num", wH_Price.WP_Num);
         }
         if (wH_Price.WP_ONum == 0)
         {
            idb.AddParameter("@WP_ONum", 0);
         }
         else
         {
            idb.AddParameter("@WP_ONum", wH_Price.WP_ONum);
         }
         if (wH_Price.WP_PNum == 0)
         {
            idb.AddParameter("@WP_PNum", 0);
         }
         else
         {
            idb.AddParameter("@WP_PNum", wH_Price.WP_PNum);
         }
         if (wH_Price.WP_RNum == 0)
         {
            idb.AddParameter("@WP_RNum", 0);
         }
         else
         {
            idb.AddParameter("@WP_RNum", wH_Price.WP_RNum);
         }
         if (wH_Price.WP_RONum == 0)
         {
            idb.AddParameter("@WP_RONum", 0);
         }
         else
         {
            idb.AddParameter("@WP_RONum", wH_Price.WP_RONum);
         }
         if (wH_Price.WP_INum == 0)
         {
            idb.AddParameter("@WP_INum", 0);
         }
         else
         {
            idb.AddParameter("@WP_INum", wH_Price.WP_INum);
         }
         if (wH_Price.WP_PRONum == 0)
         {
            idb.AddParameter("@WP_PRONum", 0);
         }
         else
         {
            idb.AddParameter("@WP_PRONum", wH_Price.WP_PRONum);
         }
         if (wH_Price.WP_PRINum == 0)
         {
            idb.AddParameter("@WP_PRINum", 0);
         }
         else
         {
            idb.AddParameter("@WP_PRINum", wH_Price.WP_PRINum);
         }
         if (string.IsNullOrEmpty(wH_Price.WP_Udef1))
         {
            idb.AddParameter("@WP_Udef1", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WP_Udef1", wH_Price.WP_Udef1);
         }
         if (string.IsNullOrEmpty(wH_Price.WP_Udef2))
         {
            idb.AddParameter("@WP_Udef2", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WP_Udef2", wH_Price.WP_Udef2);
         }
         if (string.IsNullOrEmpty(wH_Price.WP_Udef3))
         {
            idb.AddParameter("@WP_Udef3", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WP_Udef3", wH_Price.WP_Udef3);
         }
         if (string.IsNullOrEmpty(wH_Price.WP_Udef4))
         {
            idb.AddParameter("@WP_Udef4", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WP_Udef4", wH_Price.WP_Udef4);
         }
         if (string.IsNullOrEmpty(wH_Price.WP_Udef5))
         {
            idb.AddParameter("@WP_Udef5", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WP_Udef5", wH_Price.WP_Udef5);
         }
         if (string.IsNullOrEmpty(wH_Price.WP_Udef6))
         {
            idb.AddParameter("@WP_Udef6", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WP_Udef6", wH_Price.WP_Udef6);
         }
         if (string.IsNullOrEmpty(wH_Price.WP_Udef7))
         {
            idb.AddParameter("@WP_Udef7", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WP_Udef7", wH_Price.WP_Udef7);
         }
         if (string.IsNullOrEmpty(wH_Price.WP_Udef8))
         {
            idb.AddParameter("@WP_Udef8", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WP_Udef8", wH_Price.WP_Udef8);
         }
         if (string.IsNullOrEmpty(wH_Price.WP_Udef9))
         {
            idb.AddParameter("@WP_Udef9", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WP_Udef9", wH_Price.WP_Udef9);
         }
         if (string.IsNullOrEmpty(wH_Price.WP_Udef10))
         {
            idb.AddParameter("@WP_Udef10", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WP_Udef10", wH_Price.WP_Udef10);
         }
         if (wH_Price.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", wH_Price.Stat);
         }
         if (wH_Price.WP_LastPPDate == DateTime.MinValue)
         {
            idb.AddParameter("@WP_LastPPDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WP_LastPPDate", wH_Price.WP_LastPPDate);
         }
         if (wH_Price.WP_LastPPCollectDate == DateTime.MinValue)
         {
            idb.AddParameter("@WP_LastPPCollectDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WP_LastPPCollectDate", wH_Price.WP_LastPPCollectDate);
         }
         if (wH_Price.WP_LastPODate == DateTime.MinValue)
         {
            idb.AddParameter("@WP_LastPODate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WP_LastPODate", wH_Price.WP_LastPODate);
         }
         if (string.IsNullOrEmpty(wH_Price.WP_LastPOSupCode))
         {
            idb.AddParameter("@WP_LastPOSupCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WP_LastPOSupCode", wH_Price.WP_LastPOSupCode);
         }
         if (string.IsNullOrEmpty(wH_Price.WP_LastPOSupName))
         {
            idb.AddParameter("@WP_LastPOSupName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WP_LastPOSupName", wH_Price.WP_LastPOSupName);
         }
         if (wH_Price.WP_LastPIDate == DateTime.MinValue)
         {
            idb.AddParameter("@WP_LastPIDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WP_LastPIDate", wH_Price.WP_LastPIDate);
         }
         if (string.IsNullOrEmpty(wH_Price.WP_LastPISupCode))
         {
            idb.AddParameter("@WP_LastPISupCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WP_LastPISupCode", wH_Price.WP_LastPISupCode);
         }
         if (string.IsNullOrEmpty(wH_Price.WP_LastPISupName))
         {
            idb.AddParameter("@WP_LastPISupName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WP_LastPISupName", wH_Price.WP_LastPISupName);
         }
         if (wH_Price.WP_LastPRDate == DateTime.MinValue)
         {
            idb.AddParameter("@WP_LastPRDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WP_LastPRDate", wH_Price.WP_LastPRDate);
         }
         if (string.IsNullOrEmpty(wH_Price.WP_LastPRSupCode))
         {
            idb.AddParameter("@WP_LastPRSupCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WP_LastPRSupCode", wH_Price.WP_LastPRSupCode);
         }
         if (string.IsNullOrEmpty(wH_Price.WP_LastPRSupName))
         {
            idb.AddParameter("@WP_LastPRSupName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WP_LastPRSupName", wH_Price.WP_LastPRSupName);
         }
         if (wH_Price.WP_LastRODate == DateTime.MinValue)
         {
            idb.AddParameter("@WP_LastRODate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WP_LastRODate", wH_Price.WP_LastRODate);
         }
         if (string.IsNullOrEmpty(wH_Price.WP_LastRODeptCode))
         {
            idb.AddParameter("@WP_LastRODeptCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WP_LastRODeptCode", wH_Price.WP_LastRODeptCode);
         }
         if (string.IsNullOrEmpty(wH_Price.WP_LastRODeptName))
         {
            idb.AddParameter("@WP_LastRODeptName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WP_LastRODeptName", wH_Price.WP_LastRODeptName);
         }
         if (string.IsNullOrEmpty(wH_Price.WP_LastROUseType))
         {
            idb.AddParameter("@WP_LastROUseType", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WP_LastROUseType", wH_Price.WP_LastROUseType);
         }
         if (string.IsNullOrEmpty(wH_Price.WP_LastROEmpCode))
         {
            idb.AddParameter("@WP_LastROEmpCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WP_LastROEmpCode", wH_Price.WP_LastROEmpCode);
         }
         if (string.IsNullOrEmpty(wH_Price.WP_LastROEmpName))
         {
            idb.AddParameter("@WP_LastROEmpName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WP_LastROEmpName", wH_Price.WP_LastROEmpName);
         }
         if (wH_Price.WP_LastPRODate == DateTime.MinValue)
         {
            idb.AddParameter("@WP_LastPRODate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WP_LastPRODate", wH_Price.WP_LastPRODate);
         }
         if (wH_Price.WP_LastPRIDate == DateTime.MinValue)
         {
            idb.AddParameter("@WP_LastPRIDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WP_LastPRIDate", wH_Price.WP_LastPRIDate);
         }
         if (string.IsNullOrEmpty(wH_Price.WP_LastPRISupCode))
         {
            idb.AddParameter("@WP_LastPRISupCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WP_LastPRISupCode", wH_Price.WP_LastPRISupCode);
         }
         if (string.IsNullOrEmpty(wH_Price.WP_LastPRISupName))
         {
            idb.AddParameter("@WP_LastPRISupName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WP_LastPRISupName", wH_Price.WP_LastPRISupName);
         }
         if (string.IsNullOrEmpty(wH_Price.WP_LastPROSupCode))
         {
            idb.AddParameter("@WP_LastPROSupCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WP_LastPROSupCode", wH_Price.WP_LastPROSupCode);
         }
         if (string.IsNullOrEmpty(wH_Price.WP_LastPROSupName))
         {
            idb.AddParameter("@WP_LastPROSupName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WP_LastPROSupName", wH_Price.WP_LastPROSupName);
         }
         if (wH_Price.WP_CountPP == 0)
         {
            idb.AddParameter("@WP_CountPP", 0);
         }
         else
         {
            idb.AddParameter("@WP_CountPP", wH_Price.WP_CountPP);
         }
         if (wH_Price.WP_CountPO == 0)
         {
            idb.AddParameter("@WP_CountPO", 0);
         }
         else
         {
            idb.AddParameter("@WP_CountPO", wH_Price.WP_CountPO);
         }
         if (wH_Price.WP_CountPI == 0)
         {
            idb.AddParameter("@WP_CountPI", 0);
         }
         else
         {
            idb.AddParameter("@WP_CountPI", wH_Price.WP_CountPI);
         }
         if (wH_Price.WP_CountPR == 0)
         {
            idb.AddParameter("@WP_CountPR", 0);
         }
         else
         {
            idb.AddParameter("@WP_CountPR", wH_Price.WP_CountPR);
         }
         if (wH_Price.WP_CountRO == 0)
         {
            idb.AddParameter("@WP_CountRO", 0);
         }
         else
         {
            idb.AddParameter("@WP_CountRO", wH_Price.WP_CountRO);
         }
         if (wH_Price.WP_CountPRO == 0)
         {
            idb.AddParameter("@WP_CountPRO", 0);
         }
         else
         {
            idb.AddParameter("@WP_CountPRO", wH_Price.WP_CountPRO);
         }
         if (wH_Price.WP_CountRR == 0)
         {
            idb.AddParameter("@WP_CountRR", 0);
         }
         else
         {
            idb.AddParameter("@WP_CountRR", wH_Price.WP_CountRR);
         }
         if (wH_Price.WP_LeftPO == 0)
         {
            idb.AddParameter("@WP_LeftPO", 0);
         }
         else
         {
            idb.AddParameter("@WP_LeftPO", wH_Price.WP_LeftPO);
         }
         if (wH_Price.WP_LeftPP == 0)
         {
            idb.AddParameter("@WP_LeftPP", 0);
         }
         else
         {
            idb.AddParameter("@WP_LeftPP", wH_Price.WP_LeftPP);
         }
         if (wH_Price.WP_LastRRDate == DateTime.MinValue)
         {
            idb.AddParameter("@WP_LastRRDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WP_LastRRDate", wH_Price.WP_LastRRDate);
         }
         if (string.IsNullOrEmpty(wH_Price.WP_LastRRDeptCode))
         {
            idb.AddParameter("@WP_LastRRDeptCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WP_LastRRDeptCode", wH_Price.WP_LastRRDeptCode);
         }
         if (string.IsNullOrEmpty(wH_Price.WP_LastRRDeptName))
         {
            idb.AddParameter("@WP_LastRRDeptName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WP_LastRRDeptName", wH_Price.WP_LastRRDeptName);
         }
         if (string.IsNullOrEmpty(wH_Price.WP_LastRRUseType))
         {
            idb.AddParameter("@WP_LastRRUseType", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WP_LastRRUseType", wH_Price.WP_LastRRUseType);
         }
         if (string.IsNullOrEmpty(wH_Price.WP_LastRREmpCode))
         {
            idb.AddParameter("@WP_LastRREmpCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WP_LastRREmpCode", wH_Price.WP_LastRREmpCode);
         }
         if (string.IsNullOrEmpty(wH_Price.WP_LastRREmpName))
         {
            idb.AddParameter("@WP_LastRREmpName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WP_LastRREmpName", wH_Price.WP_LastRREmpName);
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
      /// 更新WH_Price对象(即:一条记录
      /// </summary>
      public int Update(WH_Price wH_Price)
      {
         
         StringBuilder sbParameter=new StringBuilder();
      StringBuilder sb=new StringBuilder();
      sb.Append(@"UPDATE       WH_Price       SET ");
            if(wH_Price.WP_CCode_IsChanged){sbParameter.Append("WP_CCode=@WP_CCode, ");}
      if(wH_Price.WP_CName_IsChanged){sbParameter.Append("WP_CName=@WP_CName, ");}
      if(wH_Price.WP_MCode_IsChanged){sbParameter.Append("WP_MCode=@WP_MCode, ");}
      if(wH_Price.WP_MName_IsChanged){sbParameter.Append("WP_MName=@WP_MName, ");}
      if(wH_Price.WP_Spec_IsChanged){sbParameter.Append("WP_Spec=@WP_Spec, ");}
      if(wH_Price.WP_Unit_IsChanged){sbParameter.Append("WP_Unit=@WP_Unit, ");}
      if(wH_Price.WP_Price_IsChanged){sbParameter.Append("WP_Price=@WP_Price, ");}
      if(wH_Price.WP_Num_IsChanged){sbParameter.Append("WP_Num=@WP_Num, ");}
      if(wH_Price.WP_ONum_IsChanged){sbParameter.Append("WP_ONum=@WP_ONum, ");}
      if(wH_Price.WP_PNum_IsChanged){sbParameter.Append("WP_PNum=@WP_PNum, ");}
      if(wH_Price.WP_RNum_IsChanged){sbParameter.Append("WP_RNum=@WP_RNum, ");}
      if(wH_Price.WP_RONum_IsChanged){sbParameter.Append("WP_RONum=@WP_RONum, ");}
      if(wH_Price.WP_INum_IsChanged){sbParameter.Append("WP_INum=@WP_INum, ");}
      if(wH_Price.WP_PRONum_IsChanged){sbParameter.Append("WP_PRONum=@WP_PRONum, ");}
      if(wH_Price.WP_PRINum_IsChanged){sbParameter.Append("WP_PRINum=@WP_PRINum, ");}
      if(wH_Price.WP_Udef1_IsChanged){sbParameter.Append("WP_Udef1=@WP_Udef1, ");}
      if(wH_Price.WP_Udef2_IsChanged){sbParameter.Append("WP_Udef2=@WP_Udef2, ");}
      if(wH_Price.WP_Udef3_IsChanged){sbParameter.Append("WP_Udef3=@WP_Udef3, ");}
      if(wH_Price.WP_Udef4_IsChanged){sbParameter.Append("WP_Udef4=@WP_Udef4, ");}
      if(wH_Price.WP_Udef5_IsChanged){sbParameter.Append("WP_Udef5=@WP_Udef5, ");}
      if(wH_Price.WP_Udef6_IsChanged){sbParameter.Append("WP_Udef6=@WP_Udef6, ");}
      if(wH_Price.WP_Udef7_IsChanged){sbParameter.Append("WP_Udef7=@WP_Udef7, ");}
      if(wH_Price.WP_Udef8_IsChanged){sbParameter.Append("WP_Udef8=@WP_Udef8, ");}
      if(wH_Price.WP_Udef9_IsChanged){sbParameter.Append("WP_Udef9=@WP_Udef9, ");}
      if(wH_Price.WP_Udef10_IsChanged){sbParameter.Append("WP_Udef10=@WP_Udef10, ");}
      if(wH_Price.Stat_IsChanged){sbParameter.Append("Stat=@Stat, ");}
      if(wH_Price.WP_LastPPDate_IsChanged){sbParameter.Append("WP_LastPPDate=@WP_LastPPDate, ");}
      if(wH_Price.WP_LastPPCollectDate_IsChanged){sbParameter.Append("WP_LastPPCollectDate=@WP_LastPPCollectDate, ");}
      if(wH_Price.WP_LastPODate_IsChanged){sbParameter.Append("WP_LastPODate=@WP_LastPODate, ");}
      if(wH_Price.WP_LastPOSupCode_IsChanged){sbParameter.Append("WP_LastPOSupCode=@WP_LastPOSupCode, ");}
      if(wH_Price.WP_LastPOSupName_IsChanged){sbParameter.Append("WP_LastPOSupName=@WP_LastPOSupName, ");}
      if(wH_Price.WP_LastPIDate_IsChanged){sbParameter.Append("WP_LastPIDate=@WP_LastPIDate, ");}
      if(wH_Price.WP_LastPISupCode_IsChanged){sbParameter.Append("WP_LastPISupCode=@WP_LastPISupCode, ");}
      if(wH_Price.WP_LastPISupName_IsChanged){sbParameter.Append("WP_LastPISupName=@WP_LastPISupName, ");}
      if(wH_Price.WP_LastPRDate_IsChanged){sbParameter.Append("WP_LastPRDate=@WP_LastPRDate, ");}
      if(wH_Price.WP_LastPRSupCode_IsChanged){sbParameter.Append("WP_LastPRSupCode=@WP_LastPRSupCode, ");}
      if(wH_Price.WP_LastPRSupName_IsChanged){sbParameter.Append("WP_LastPRSupName=@WP_LastPRSupName, ");}
      if(wH_Price.WP_LastRODate_IsChanged){sbParameter.Append("WP_LastRODate=@WP_LastRODate, ");}
      if(wH_Price.WP_LastRODeptCode_IsChanged){sbParameter.Append("WP_LastRODeptCode=@WP_LastRODeptCode, ");}
      if(wH_Price.WP_LastRODeptName_IsChanged){sbParameter.Append("WP_LastRODeptName=@WP_LastRODeptName, ");}
      if(wH_Price.WP_LastROUseType_IsChanged){sbParameter.Append("WP_LastROUseType=@WP_LastROUseType, ");}
      if(wH_Price.WP_LastROEmpCode_IsChanged){sbParameter.Append("WP_LastROEmpCode=@WP_LastROEmpCode, ");}
      if(wH_Price.WP_LastROEmpName_IsChanged){sbParameter.Append("WP_LastROEmpName=@WP_LastROEmpName, ");}
      if(wH_Price.WP_LastPRODate_IsChanged){sbParameter.Append("WP_LastPRODate=@WP_LastPRODate, ");}
      if(wH_Price.WP_LastPRIDate_IsChanged){sbParameter.Append("WP_LastPRIDate=@WP_LastPRIDate, ");}
      if(wH_Price.WP_LastPRISupCode_IsChanged){sbParameter.Append("WP_LastPRISupCode=@WP_LastPRISupCode, ");}
      if(wH_Price.WP_LastPRISupName_IsChanged){sbParameter.Append("WP_LastPRISupName=@WP_LastPRISupName, ");}
      if(wH_Price.WP_LastPROSupCode_IsChanged){sbParameter.Append("WP_LastPROSupCode=@WP_LastPROSupCode, ");}
      if(wH_Price.WP_LastPROSupName_IsChanged){sbParameter.Append("WP_LastPROSupName=@WP_LastPROSupName, ");}
      if(wH_Price.WP_CountPP_IsChanged){sbParameter.Append("WP_CountPP=@WP_CountPP, ");}
      if(wH_Price.WP_CountPO_IsChanged){sbParameter.Append("WP_CountPO=@WP_CountPO, ");}
      if(wH_Price.WP_CountPI_IsChanged){sbParameter.Append("WP_CountPI=@WP_CountPI, ");}
      if(wH_Price.WP_CountPR_IsChanged){sbParameter.Append("WP_CountPR=@WP_CountPR, ");}
      if(wH_Price.WP_CountRO_IsChanged){sbParameter.Append("WP_CountRO=@WP_CountRO, ");}
      if(wH_Price.WP_CountPRO_IsChanged){sbParameter.Append("WP_CountPRO=@WP_CountPRO, ");}
      if(wH_Price.WP_CountRR_IsChanged){sbParameter.Append("WP_CountRR=@WP_CountRR, ");}
      if(wH_Price.WP_LeftPO_IsChanged){sbParameter.Append("WP_LeftPO=@WP_LeftPO, ");}
      if(wH_Price.WP_LeftPP_IsChanged){sbParameter.Append("WP_LeftPP=@WP_LeftPP, ");}
      if(wH_Price.WP_LastRRDate_IsChanged){sbParameter.Append("WP_LastRRDate=@WP_LastRRDate, ");}
      if(wH_Price.WP_LastRRDeptCode_IsChanged){sbParameter.Append("WP_LastRRDeptCode=@WP_LastRRDeptCode, ");}
      if(wH_Price.WP_LastRRDeptName_IsChanged){sbParameter.Append("WP_LastRRDeptName=@WP_LastRRDeptName, ");}
      if(wH_Price.WP_LastRRUseType_IsChanged){sbParameter.Append("WP_LastRRUseType=@WP_LastRRUseType, ");}
      if(wH_Price.WP_LastRREmpCode_IsChanged){sbParameter.Append("WP_LastRREmpCode=@WP_LastRREmpCode, ");}
      if(wH_Price.WP_LastRREmpName_IsChanged){sbParameter.Append("WP_LastRREmpName=@WP_LastRREmpName ");}          sb.Append(sbParameter.ToString().Trim().TrimEnd(',')); 
      sb.Append(      " WHERE 1=1 AND ((Stat is null) or (Stat=0))   and WP_ID=@WP_ID; " );
      string sql=sb.ToString();
         if(wH_Price.WP_CCode_IsChanged)
         {
         if (string.IsNullOrEmpty(wH_Price.WP_CCode))
         {
            idb.AddParameter("@WP_CCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WP_CCode", wH_Price.WP_CCode);
         }
          }
         if(wH_Price.WP_CName_IsChanged)
         {
         if (string.IsNullOrEmpty(wH_Price.WP_CName))
         {
            idb.AddParameter("@WP_CName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WP_CName", wH_Price.WP_CName);
         }
          }
         if(wH_Price.WP_MCode_IsChanged)
         {
         if (string.IsNullOrEmpty(wH_Price.WP_MCode))
         {
            idb.AddParameter("@WP_MCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WP_MCode", wH_Price.WP_MCode);
         }
          }
         if(wH_Price.WP_MName_IsChanged)
         {
         if (string.IsNullOrEmpty(wH_Price.WP_MName))
         {
            idb.AddParameter("@WP_MName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WP_MName", wH_Price.WP_MName);
         }
          }
         if(wH_Price.WP_Spec_IsChanged)
         {
         if (string.IsNullOrEmpty(wH_Price.WP_Spec))
         {
            idb.AddParameter("@WP_Spec", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WP_Spec", wH_Price.WP_Spec);
         }
          }
         if(wH_Price.WP_Unit_IsChanged)
         {
         if (string.IsNullOrEmpty(wH_Price.WP_Unit))
         {
            idb.AddParameter("@WP_Unit", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WP_Unit", wH_Price.WP_Unit);
         }
          }
         if(wH_Price.WP_Price_IsChanged)
         {
         if (wH_Price.WP_Price == 0)
         {
            idb.AddParameter("@WP_Price", 0);
         }
         else
         {
            idb.AddParameter("@WP_Price", wH_Price.WP_Price);
         }
          }
         if(wH_Price.WP_Num_IsChanged)
         {
         if (wH_Price.WP_Num == 0)
         {
            idb.AddParameter("@WP_Num", 0);
         }
         else
         {
            idb.AddParameter("@WP_Num", wH_Price.WP_Num);
         }
          }
         if(wH_Price.WP_ONum_IsChanged)
         {
         if (wH_Price.WP_ONum == 0)
         {
            idb.AddParameter("@WP_ONum", 0);
         }
         else
         {
            idb.AddParameter("@WP_ONum", wH_Price.WP_ONum);
         }
          }
         if(wH_Price.WP_PNum_IsChanged)
         {
         if (wH_Price.WP_PNum == 0)
         {
            idb.AddParameter("@WP_PNum", 0);
         }
         else
         {
            idb.AddParameter("@WP_PNum", wH_Price.WP_PNum);
         }
          }
         if(wH_Price.WP_RNum_IsChanged)
         {
         if (wH_Price.WP_RNum == 0)
         {
            idb.AddParameter("@WP_RNum", 0);
         }
         else
         {
            idb.AddParameter("@WP_RNum", wH_Price.WP_RNum);
         }
          }
         if(wH_Price.WP_RONum_IsChanged)
         {
         if (wH_Price.WP_RONum == 0)
         {
            idb.AddParameter("@WP_RONum", 0);
         }
         else
         {
            idb.AddParameter("@WP_RONum", wH_Price.WP_RONum);
         }
          }
         if(wH_Price.WP_INum_IsChanged)
         {
         if (wH_Price.WP_INum == 0)
         {
            idb.AddParameter("@WP_INum", 0);
         }
         else
         {
            idb.AddParameter("@WP_INum", wH_Price.WP_INum);
         }
          }
         if(wH_Price.WP_PRONum_IsChanged)
         {
         if (wH_Price.WP_PRONum == 0)
         {
            idb.AddParameter("@WP_PRONum", 0);
         }
         else
         {
            idb.AddParameter("@WP_PRONum", wH_Price.WP_PRONum);
         }
          }
         if(wH_Price.WP_PRINum_IsChanged)
         {
         if (wH_Price.WP_PRINum == 0)
         {
            idb.AddParameter("@WP_PRINum", 0);
         }
         else
         {
            idb.AddParameter("@WP_PRINum", wH_Price.WP_PRINum);
         }
          }
         if(wH_Price.WP_Udef1_IsChanged)
         {
         if (string.IsNullOrEmpty(wH_Price.WP_Udef1))
         {
            idb.AddParameter("@WP_Udef1", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WP_Udef1", wH_Price.WP_Udef1);
         }
          }
         if(wH_Price.WP_Udef2_IsChanged)
         {
         if (string.IsNullOrEmpty(wH_Price.WP_Udef2))
         {
            idb.AddParameter("@WP_Udef2", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WP_Udef2", wH_Price.WP_Udef2);
         }
          }
         if(wH_Price.WP_Udef3_IsChanged)
         {
         if (string.IsNullOrEmpty(wH_Price.WP_Udef3))
         {
            idb.AddParameter("@WP_Udef3", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WP_Udef3", wH_Price.WP_Udef3);
         }
          }
         if(wH_Price.WP_Udef4_IsChanged)
         {
         if (string.IsNullOrEmpty(wH_Price.WP_Udef4))
         {
            idb.AddParameter("@WP_Udef4", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WP_Udef4", wH_Price.WP_Udef4);
         }
          }
         if(wH_Price.WP_Udef5_IsChanged)
         {
         if (string.IsNullOrEmpty(wH_Price.WP_Udef5))
         {
            idb.AddParameter("@WP_Udef5", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WP_Udef5", wH_Price.WP_Udef5);
         }
          }
         if(wH_Price.WP_Udef6_IsChanged)
         {
         if (string.IsNullOrEmpty(wH_Price.WP_Udef6))
         {
            idb.AddParameter("@WP_Udef6", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WP_Udef6", wH_Price.WP_Udef6);
         }
          }
         if(wH_Price.WP_Udef7_IsChanged)
         {
         if (string.IsNullOrEmpty(wH_Price.WP_Udef7))
         {
            idb.AddParameter("@WP_Udef7", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WP_Udef7", wH_Price.WP_Udef7);
         }
          }
         if(wH_Price.WP_Udef8_IsChanged)
         {
         if (string.IsNullOrEmpty(wH_Price.WP_Udef8))
         {
            idb.AddParameter("@WP_Udef8", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WP_Udef8", wH_Price.WP_Udef8);
         }
          }
         if(wH_Price.WP_Udef9_IsChanged)
         {
         if (string.IsNullOrEmpty(wH_Price.WP_Udef9))
         {
            idb.AddParameter("@WP_Udef9", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WP_Udef9", wH_Price.WP_Udef9);
         }
          }
         if(wH_Price.WP_Udef10_IsChanged)
         {
         if (string.IsNullOrEmpty(wH_Price.WP_Udef10))
         {
            idb.AddParameter("@WP_Udef10", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WP_Udef10", wH_Price.WP_Udef10);
         }
          }
         if(wH_Price.Stat_IsChanged)
         {
         if (wH_Price.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", wH_Price.Stat);
         }
          }
         if(wH_Price.WP_LastPPDate_IsChanged)
         {
         if (wH_Price.WP_LastPPDate == DateTime.MinValue)
         {
            idb.AddParameter("@WP_LastPPDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WP_LastPPDate", wH_Price.WP_LastPPDate);
         }
          }
         if(wH_Price.WP_LastPPCollectDate_IsChanged)
         {
         if (wH_Price.WP_LastPPCollectDate == DateTime.MinValue)
         {
            idb.AddParameter("@WP_LastPPCollectDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WP_LastPPCollectDate", wH_Price.WP_LastPPCollectDate);
         }
          }
         if(wH_Price.WP_LastPODate_IsChanged)
         {
         if (wH_Price.WP_LastPODate == DateTime.MinValue)
         {
            idb.AddParameter("@WP_LastPODate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WP_LastPODate", wH_Price.WP_LastPODate);
         }
          }
         if(wH_Price.WP_LastPOSupCode_IsChanged)
         {
         if (string.IsNullOrEmpty(wH_Price.WP_LastPOSupCode))
         {
            idb.AddParameter("@WP_LastPOSupCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WP_LastPOSupCode", wH_Price.WP_LastPOSupCode);
         }
          }
         if(wH_Price.WP_LastPOSupName_IsChanged)
         {
         if (string.IsNullOrEmpty(wH_Price.WP_LastPOSupName))
         {
            idb.AddParameter("@WP_LastPOSupName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WP_LastPOSupName", wH_Price.WP_LastPOSupName);
         }
          }
         if(wH_Price.WP_LastPIDate_IsChanged)
         {
         if (wH_Price.WP_LastPIDate == DateTime.MinValue)
         {
            idb.AddParameter("@WP_LastPIDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WP_LastPIDate", wH_Price.WP_LastPIDate);
         }
          }
         if(wH_Price.WP_LastPISupCode_IsChanged)
         {
         if (string.IsNullOrEmpty(wH_Price.WP_LastPISupCode))
         {
            idb.AddParameter("@WP_LastPISupCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WP_LastPISupCode", wH_Price.WP_LastPISupCode);
         }
          }
         if(wH_Price.WP_LastPISupName_IsChanged)
         {
         if (string.IsNullOrEmpty(wH_Price.WP_LastPISupName))
         {
            idb.AddParameter("@WP_LastPISupName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WP_LastPISupName", wH_Price.WP_LastPISupName);
         }
          }
         if(wH_Price.WP_LastPRDate_IsChanged)
         {
         if (wH_Price.WP_LastPRDate == DateTime.MinValue)
         {
            idb.AddParameter("@WP_LastPRDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WP_LastPRDate", wH_Price.WP_LastPRDate);
         }
          }
         if(wH_Price.WP_LastPRSupCode_IsChanged)
         {
         if (string.IsNullOrEmpty(wH_Price.WP_LastPRSupCode))
         {
            idb.AddParameter("@WP_LastPRSupCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WP_LastPRSupCode", wH_Price.WP_LastPRSupCode);
         }
          }
         if(wH_Price.WP_LastPRSupName_IsChanged)
         {
         if (string.IsNullOrEmpty(wH_Price.WP_LastPRSupName))
         {
            idb.AddParameter("@WP_LastPRSupName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WP_LastPRSupName", wH_Price.WP_LastPRSupName);
         }
          }
         if(wH_Price.WP_LastRODate_IsChanged)
         {
         if (wH_Price.WP_LastRODate == DateTime.MinValue)
         {
            idb.AddParameter("@WP_LastRODate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WP_LastRODate", wH_Price.WP_LastRODate);
         }
          }
         if(wH_Price.WP_LastRODeptCode_IsChanged)
         {
         if (string.IsNullOrEmpty(wH_Price.WP_LastRODeptCode))
         {
            idb.AddParameter("@WP_LastRODeptCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WP_LastRODeptCode", wH_Price.WP_LastRODeptCode);
         }
          }
         if(wH_Price.WP_LastRODeptName_IsChanged)
         {
         if (string.IsNullOrEmpty(wH_Price.WP_LastRODeptName))
         {
            idb.AddParameter("@WP_LastRODeptName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WP_LastRODeptName", wH_Price.WP_LastRODeptName);
         }
          }
         if(wH_Price.WP_LastROUseType_IsChanged)
         {
         if (string.IsNullOrEmpty(wH_Price.WP_LastROUseType))
         {
            idb.AddParameter("@WP_LastROUseType", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WP_LastROUseType", wH_Price.WP_LastROUseType);
         }
          }
         if(wH_Price.WP_LastROEmpCode_IsChanged)
         {
         if (string.IsNullOrEmpty(wH_Price.WP_LastROEmpCode))
         {
            idb.AddParameter("@WP_LastROEmpCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WP_LastROEmpCode", wH_Price.WP_LastROEmpCode);
         }
          }
         if(wH_Price.WP_LastROEmpName_IsChanged)
         {
         if (string.IsNullOrEmpty(wH_Price.WP_LastROEmpName))
         {
            idb.AddParameter("@WP_LastROEmpName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WP_LastROEmpName", wH_Price.WP_LastROEmpName);
         }
          }
         if(wH_Price.WP_LastPRODate_IsChanged)
         {
         if (wH_Price.WP_LastPRODate == DateTime.MinValue)
         {
            idb.AddParameter("@WP_LastPRODate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WP_LastPRODate", wH_Price.WP_LastPRODate);
         }
          }
         if(wH_Price.WP_LastPRIDate_IsChanged)
         {
         if (wH_Price.WP_LastPRIDate == DateTime.MinValue)
         {
            idb.AddParameter("@WP_LastPRIDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WP_LastPRIDate", wH_Price.WP_LastPRIDate);
         }
          }
         if(wH_Price.WP_LastPRISupCode_IsChanged)
         {
         if (string.IsNullOrEmpty(wH_Price.WP_LastPRISupCode))
         {
            idb.AddParameter("@WP_LastPRISupCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WP_LastPRISupCode", wH_Price.WP_LastPRISupCode);
         }
          }
         if(wH_Price.WP_LastPRISupName_IsChanged)
         {
         if (string.IsNullOrEmpty(wH_Price.WP_LastPRISupName))
         {
            idb.AddParameter("@WP_LastPRISupName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WP_LastPRISupName", wH_Price.WP_LastPRISupName);
         }
          }
         if(wH_Price.WP_LastPROSupCode_IsChanged)
         {
         if (string.IsNullOrEmpty(wH_Price.WP_LastPROSupCode))
         {
            idb.AddParameter("@WP_LastPROSupCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WP_LastPROSupCode", wH_Price.WP_LastPROSupCode);
         }
          }
         if(wH_Price.WP_LastPROSupName_IsChanged)
         {
         if (string.IsNullOrEmpty(wH_Price.WP_LastPROSupName))
         {
            idb.AddParameter("@WP_LastPROSupName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WP_LastPROSupName", wH_Price.WP_LastPROSupName);
         }
          }
         if(wH_Price.WP_CountPP_IsChanged)
         {
         if (wH_Price.WP_CountPP == 0)
         {
            idb.AddParameter("@WP_CountPP", 0);
         }
         else
         {
            idb.AddParameter("@WP_CountPP", wH_Price.WP_CountPP);
         }
          }
         if(wH_Price.WP_CountPO_IsChanged)
         {
         if (wH_Price.WP_CountPO == 0)
         {
            idb.AddParameter("@WP_CountPO", 0);
         }
         else
         {
            idb.AddParameter("@WP_CountPO", wH_Price.WP_CountPO);
         }
          }
         if(wH_Price.WP_CountPI_IsChanged)
         {
         if (wH_Price.WP_CountPI == 0)
         {
            idb.AddParameter("@WP_CountPI", 0);
         }
         else
         {
            idb.AddParameter("@WP_CountPI", wH_Price.WP_CountPI);
         }
          }
         if(wH_Price.WP_CountPR_IsChanged)
         {
         if (wH_Price.WP_CountPR == 0)
         {
            idb.AddParameter("@WP_CountPR", 0);
         }
         else
         {
            idb.AddParameter("@WP_CountPR", wH_Price.WP_CountPR);
         }
          }
         if(wH_Price.WP_CountRO_IsChanged)
         {
         if (wH_Price.WP_CountRO == 0)
         {
            idb.AddParameter("@WP_CountRO", 0);
         }
         else
         {
            idb.AddParameter("@WP_CountRO", wH_Price.WP_CountRO);
         }
          }
         if(wH_Price.WP_CountPRO_IsChanged)
         {
         if (wH_Price.WP_CountPRO == 0)
         {
            idb.AddParameter("@WP_CountPRO", 0);
         }
         else
         {
            idb.AddParameter("@WP_CountPRO", wH_Price.WP_CountPRO);
         }
          }
         if(wH_Price.WP_CountRR_IsChanged)
         {
         if (wH_Price.WP_CountRR == 0)
         {
            idb.AddParameter("@WP_CountRR", 0);
         }
         else
         {
            idb.AddParameter("@WP_CountRR", wH_Price.WP_CountRR);
         }
          }
         if(wH_Price.WP_LeftPO_IsChanged)
         {
         if (wH_Price.WP_LeftPO == 0)
         {
            idb.AddParameter("@WP_LeftPO", 0);
         }
         else
         {
            idb.AddParameter("@WP_LeftPO", wH_Price.WP_LeftPO);
         }
          }
         if(wH_Price.WP_LeftPP_IsChanged)
         {
         if (wH_Price.WP_LeftPP == 0)
         {
            idb.AddParameter("@WP_LeftPP", 0);
         }
         else
         {
            idb.AddParameter("@WP_LeftPP", wH_Price.WP_LeftPP);
         }
          }
         if(wH_Price.WP_LastRRDate_IsChanged)
         {
         if (wH_Price.WP_LastRRDate == DateTime.MinValue)
         {
            idb.AddParameter("@WP_LastRRDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WP_LastRRDate", wH_Price.WP_LastRRDate);
         }
          }
         if(wH_Price.WP_LastRRDeptCode_IsChanged)
         {
         if (string.IsNullOrEmpty(wH_Price.WP_LastRRDeptCode))
         {
            idb.AddParameter("@WP_LastRRDeptCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WP_LastRRDeptCode", wH_Price.WP_LastRRDeptCode);
         }
          }
         if(wH_Price.WP_LastRRDeptName_IsChanged)
         {
         if (string.IsNullOrEmpty(wH_Price.WP_LastRRDeptName))
         {
            idb.AddParameter("@WP_LastRRDeptName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WP_LastRRDeptName", wH_Price.WP_LastRRDeptName);
         }
          }
         if(wH_Price.WP_LastRRUseType_IsChanged)
         {
         if (string.IsNullOrEmpty(wH_Price.WP_LastRRUseType))
         {
            idb.AddParameter("@WP_LastRRUseType", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WP_LastRRUseType", wH_Price.WP_LastRRUseType);
         }
          }
         if(wH_Price.WP_LastRREmpCode_IsChanged)
         {
         if (string.IsNullOrEmpty(wH_Price.WP_LastRREmpCode))
         {
            idb.AddParameter("@WP_LastRREmpCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WP_LastRREmpCode", wH_Price.WP_LastRREmpCode);
         }
          }
         if(wH_Price.WP_LastRREmpName_IsChanged)
         {
         if (string.IsNullOrEmpty(wH_Price.WP_LastRREmpName))
         {
            idb.AddParameter("@WP_LastRREmpName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WP_LastRREmpName", wH_Price.WP_LastRREmpName);
         }
          }

         idb.AddParameter("@WP_ID", wH_Price.WP_ID);

           
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
      /// 删除WH_Price对象(即:一条记录
      /// </summary>
      public int Delete(Int64 wP_ID)
      {
         string sql = "DELETE WH_Price WHERE 1=1  AND WP_ID=@WP_ID ";
         idb.AddParameter("@WP_ID", wP_ID);

           
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
      /// 获取指定的WH_Price对象(即:一条记录
      /// </summary>
      public WH_Price GetByKey(Int64 wP_ID)
      {
         WH_Price wH_Price = new WH_Price();
         string sql = "SELECT  WP_ID,WP_CCode,WP_CName,WP_MCode,WP_MName,WP_Spec,WP_Unit,WP_Price,WP_Num,WP_ONum,WP_PNum,WP_RNum,WP_RONum,WP_INum,WP_PRONum,WP_PRINum,WP_Udef1,WP_Udef2,WP_Udef3,WP_Udef4,WP_Udef5,WP_Udef6,WP_Udef7,WP_Udef8,WP_Udef9,WP_Udef10,Stat,WP_LastPPDate,WP_LastPPCollectDate,WP_LastPODate,WP_LastPOSupCode,WP_LastPOSupName,WP_LastPIDate,WP_LastPISupCode,WP_LastPISupName,WP_LastPRDate,WP_LastPRSupCode,WP_LastPRSupName,WP_LastRODate,WP_LastRODeptCode,WP_LastRODeptName,WP_LastROUseType,WP_LastROEmpCode,WP_LastROEmpName,WP_LastPRODate,WP_LastPRIDate,WP_LastPRISupCode,WP_LastPRISupName,WP_LastPROSupCode,WP_LastPROSupName,WP_CountPP,WP_CountPO,WP_CountPI,WP_CountPR,WP_CountRO,WP_CountPRO,WP_CountRR,WP_LeftPO,WP_LeftPP,WP_LastRRDate,WP_LastRRDeptCode,WP_LastRRDeptName,WP_LastRRUseType,WP_LastRREmpCode,WP_LastRREmpName FROM WH_Price WHERE 1=1 AND ((Stat is null) or (Stat=0) )  AND WP_ID=@WP_ID ";
         idb.AddParameter("@WP_ID", wP_ID);

          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            if (dr["WP_ID"] != DBNull.Value) wH_Price.WP_ID = Convert.ToInt64(dr["WP_ID"]);
            if (dr["WP_CCode"] != DBNull.Value) wH_Price.WP_CCode = Convert.ToString(dr["WP_CCode"]);
            if (dr["WP_CName"] != DBNull.Value) wH_Price.WP_CName = Convert.ToString(dr["WP_CName"]);
            if (dr["WP_MCode"] != DBNull.Value) wH_Price.WP_MCode = Convert.ToString(dr["WP_MCode"]);
            if (dr["WP_MName"] != DBNull.Value) wH_Price.WP_MName = Convert.ToString(dr["WP_MName"]);
            if (dr["WP_Spec"] != DBNull.Value) wH_Price.WP_Spec = Convert.ToString(dr["WP_Spec"]);
            if (dr["WP_Unit"] != DBNull.Value) wH_Price.WP_Unit = Convert.ToString(dr["WP_Unit"]);
            if (dr["WP_Price"] != DBNull.Value) wH_Price.WP_Price = Convert.ToDecimal(dr["WP_Price"]);
            if (dr["WP_Num"] != DBNull.Value) wH_Price.WP_Num = Convert.ToDecimal(dr["WP_Num"]);
            if (dr["WP_ONum"] != DBNull.Value) wH_Price.WP_ONum = Convert.ToDecimal(dr["WP_ONum"]);
            if (dr["WP_PNum"] != DBNull.Value) wH_Price.WP_PNum = Convert.ToDecimal(dr["WP_PNum"]);
            if (dr["WP_RNum"] != DBNull.Value) wH_Price.WP_RNum = Convert.ToDecimal(dr["WP_RNum"]);
            if (dr["WP_RONum"] != DBNull.Value) wH_Price.WP_RONum = Convert.ToDecimal(dr["WP_RONum"]);
            if (dr["WP_INum"] != DBNull.Value) wH_Price.WP_INum = Convert.ToDecimal(dr["WP_INum"]);
            if (dr["WP_PRONum"] != DBNull.Value) wH_Price.WP_PRONum = Convert.ToDecimal(dr["WP_PRONum"]);
            if (dr["WP_PRINum"] != DBNull.Value) wH_Price.WP_PRINum = Convert.ToDecimal(dr["WP_PRINum"]);
            if (dr["WP_Udef1"] != DBNull.Value) wH_Price.WP_Udef1 = Convert.ToString(dr["WP_Udef1"]);
            if (dr["WP_Udef2"] != DBNull.Value) wH_Price.WP_Udef2 = Convert.ToString(dr["WP_Udef2"]);
            if (dr["WP_Udef3"] != DBNull.Value) wH_Price.WP_Udef3 = Convert.ToString(dr["WP_Udef3"]);
            if (dr["WP_Udef4"] != DBNull.Value) wH_Price.WP_Udef4 = Convert.ToString(dr["WP_Udef4"]);
            if (dr["WP_Udef5"] != DBNull.Value) wH_Price.WP_Udef5 = Convert.ToString(dr["WP_Udef5"]);
            if (dr["WP_Udef6"] != DBNull.Value) wH_Price.WP_Udef6 = Convert.ToString(dr["WP_Udef6"]);
            if (dr["WP_Udef7"] != DBNull.Value) wH_Price.WP_Udef7 = Convert.ToString(dr["WP_Udef7"]);
            if (dr["WP_Udef8"] != DBNull.Value) wH_Price.WP_Udef8 = Convert.ToString(dr["WP_Udef8"]);
            if (dr["WP_Udef9"] != DBNull.Value) wH_Price.WP_Udef9 = Convert.ToString(dr["WP_Udef9"]);
            if (dr["WP_Udef10"] != DBNull.Value) wH_Price.WP_Udef10 = Convert.ToString(dr["WP_Udef10"]);
            if (dr["Stat"] != DBNull.Value) wH_Price.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["WP_LastPPDate"] != DBNull.Value) wH_Price.WP_LastPPDate = Convert.ToDateTime(dr["WP_LastPPDate"]);
            if (dr["WP_LastPPCollectDate"] != DBNull.Value) wH_Price.WP_LastPPCollectDate = Convert.ToDateTime(dr["WP_LastPPCollectDate"]);
            if (dr["WP_LastPODate"] != DBNull.Value) wH_Price.WP_LastPODate = Convert.ToDateTime(dr["WP_LastPODate"]);
            if (dr["WP_LastPOSupCode"] != DBNull.Value) wH_Price.WP_LastPOSupCode = Convert.ToString(dr["WP_LastPOSupCode"]);
            if (dr["WP_LastPOSupName"] != DBNull.Value) wH_Price.WP_LastPOSupName = Convert.ToString(dr["WP_LastPOSupName"]);
            if (dr["WP_LastPIDate"] != DBNull.Value) wH_Price.WP_LastPIDate = Convert.ToDateTime(dr["WP_LastPIDate"]);
            if (dr["WP_LastPISupCode"] != DBNull.Value) wH_Price.WP_LastPISupCode = Convert.ToString(dr["WP_LastPISupCode"]);
            if (dr["WP_LastPISupName"] != DBNull.Value) wH_Price.WP_LastPISupName = Convert.ToString(dr["WP_LastPISupName"]);
            if (dr["WP_LastPRDate"] != DBNull.Value) wH_Price.WP_LastPRDate = Convert.ToDateTime(dr["WP_LastPRDate"]);
            if (dr["WP_LastPRSupCode"] != DBNull.Value) wH_Price.WP_LastPRSupCode = Convert.ToString(dr["WP_LastPRSupCode"]);
            if (dr["WP_LastPRSupName"] != DBNull.Value) wH_Price.WP_LastPRSupName = Convert.ToString(dr["WP_LastPRSupName"]);
            if (dr["WP_LastRODate"] != DBNull.Value) wH_Price.WP_LastRODate = Convert.ToDateTime(dr["WP_LastRODate"]);
            if (dr["WP_LastRODeptCode"] != DBNull.Value) wH_Price.WP_LastRODeptCode = Convert.ToString(dr["WP_LastRODeptCode"]);
            if (dr["WP_LastRODeptName"] != DBNull.Value) wH_Price.WP_LastRODeptName = Convert.ToString(dr["WP_LastRODeptName"]);
            if (dr["WP_LastROUseType"] != DBNull.Value) wH_Price.WP_LastROUseType = Convert.ToString(dr["WP_LastROUseType"]);
            if (dr["WP_LastROEmpCode"] != DBNull.Value) wH_Price.WP_LastROEmpCode = Convert.ToString(dr["WP_LastROEmpCode"]);
            if (dr["WP_LastROEmpName"] != DBNull.Value) wH_Price.WP_LastROEmpName = Convert.ToString(dr["WP_LastROEmpName"]);
            if (dr["WP_LastPRODate"] != DBNull.Value) wH_Price.WP_LastPRODate = Convert.ToDateTime(dr["WP_LastPRODate"]);
            if (dr["WP_LastPRIDate"] != DBNull.Value) wH_Price.WP_LastPRIDate = Convert.ToDateTime(dr["WP_LastPRIDate"]);
            if (dr["WP_LastPRISupCode"] != DBNull.Value) wH_Price.WP_LastPRISupCode = Convert.ToString(dr["WP_LastPRISupCode"]);
            if (dr["WP_LastPRISupName"] != DBNull.Value) wH_Price.WP_LastPRISupName = Convert.ToString(dr["WP_LastPRISupName"]);
            if (dr["WP_LastPROSupCode"] != DBNull.Value) wH_Price.WP_LastPROSupCode = Convert.ToString(dr["WP_LastPROSupCode"]);
            if (dr["WP_LastPROSupName"] != DBNull.Value) wH_Price.WP_LastPROSupName = Convert.ToString(dr["WP_LastPROSupName"]);
            if (dr["WP_CountPP"] != DBNull.Value) wH_Price.WP_CountPP = Convert.ToInt32(dr["WP_CountPP"]);
            if (dr["WP_CountPO"] != DBNull.Value) wH_Price.WP_CountPO = Convert.ToInt32(dr["WP_CountPO"]);
            if (dr["WP_CountPI"] != DBNull.Value) wH_Price.WP_CountPI = Convert.ToInt32(dr["WP_CountPI"]);
            if (dr["WP_CountPR"] != DBNull.Value) wH_Price.WP_CountPR = Convert.ToInt32(dr["WP_CountPR"]);
            if (dr["WP_CountRO"] != DBNull.Value) wH_Price.WP_CountRO = Convert.ToInt32(dr["WP_CountRO"]);
            if (dr["WP_CountPRO"] != DBNull.Value) wH_Price.WP_CountPRO = Convert.ToDecimal(dr["WP_CountPRO"]);
            if (dr["WP_CountRR"] != DBNull.Value) wH_Price.WP_CountRR = Convert.ToDecimal(dr["WP_CountRR"]);
            if (dr["WP_LeftPO"] != DBNull.Value) wH_Price.WP_LeftPO = Convert.ToDecimal(dr["WP_LeftPO"]);
            if (dr["WP_LeftPP"] != DBNull.Value) wH_Price.WP_LeftPP = Convert.ToDecimal(dr["WP_LeftPP"]);
            if (dr["WP_LastRRDate"] != DBNull.Value) wH_Price.WP_LastRRDate = Convert.ToDateTime(dr["WP_LastRRDate"]);
            if (dr["WP_LastRRDeptCode"] != DBNull.Value) wH_Price.WP_LastRRDeptCode = Convert.ToString(dr["WP_LastRRDeptCode"]);
            if (dr["WP_LastRRDeptName"] != DBNull.Value) wH_Price.WP_LastRRDeptName = Convert.ToString(dr["WP_LastRRDeptName"]);
            if (dr["WP_LastRRUseType"] != DBNull.Value) wH_Price.WP_LastRRUseType = Convert.ToString(dr["WP_LastRRUseType"]);
            if (dr["WP_LastRREmpCode"] != DBNull.Value) wH_Price.WP_LastRREmpCode = Convert.ToString(dr["WP_LastRREmpCode"]);
            if (dr["WP_LastRREmpName"] != DBNull.Value) wH_Price.WP_LastRREmpName = Convert.ToString(dr["WP_LastRREmpName"]);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   }  
         return wH_Price;
      }
      /// <summary>
      /// 获取指定的WH_Price对象集合
      /// </summary>
      public List<WH_Price> GetListByWhere(string strCondition)
      {
         List<WH_Price> ret = new List<WH_Price>();
         string sql = "SELECT  WP_ID,WP_CCode,WP_CName,WP_MCode,WP_MName,WP_Spec,WP_Unit,WP_Price,WP_Num,WP_ONum,WP_PNum,WP_RNum,WP_RONum,WP_INum,WP_PRONum,WP_PRINum,WP_Udef1,WP_Udef2,WP_Udef3,WP_Udef4,WP_Udef5,WP_Udef6,WP_Udef7,WP_Udef8,WP_Udef9,WP_Udef10,Stat,WP_LastPPDate,WP_LastPPCollectDate,WP_LastPODate,WP_LastPOSupCode,WP_LastPOSupName,WP_LastPIDate,WP_LastPISupCode,WP_LastPISupName,WP_LastPRDate,WP_LastPRSupCode,WP_LastPRSupName,WP_LastRODate,WP_LastRODeptCode,WP_LastRODeptName,WP_LastROUseType,WP_LastROEmpCode,WP_LastROEmpName,WP_LastPRODate,WP_LastPRIDate,WP_LastPRISupCode,WP_LastPRISupName,WP_LastPROSupCode,WP_LastPROSupName,WP_CountPP,WP_CountPO,WP_CountPI,WP_CountPR,WP_CountRO,WP_CountPRO,WP_CountRR,WP_LeftPO,WP_LeftPP,WP_LastRRDate,WP_LastRRDeptCode,WP_LastRRDeptName,WP_LastRRUseType,WP_LastRREmpCode,WP_LastRREmpName FROM WH_Price WHERE 1=1 AND ((Stat is null) or (Stat=0) ) ";
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
            WH_Price wH_Price = new WH_Price();
            if (dr["WP_ID"] != DBNull.Value) wH_Price.WP_ID = Convert.ToInt64(dr["WP_ID"]);
            if (dr["WP_CCode"] != DBNull.Value) wH_Price.WP_CCode = Convert.ToString(dr["WP_CCode"]);
            if (dr["WP_CName"] != DBNull.Value) wH_Price.WP_CName = Convert.ToString(dr["WP_CName"]);
            if (dr["WP_MCode"] != DBNull.Value) wH_Price.WP_MCode = Convert.ToString(dr["WP_MCode"]);
            if (dr["WP_MName"] != DBNull.Value) wH_Price.WP_MName = Convert.ToString(dr["WP_MName"]);
            if (dr["WP_Spec"] != DBNull.Value) wH_Price.WP_Spec = Convert.ToString(dr["WP_Spec"]);
            if (dr["WP_Unit"] != DBNull.Value) wH_Price.WP_Unit = Convert.ToString(dr["WP_Unit"]);
            if (dr["WP_Price"] != DBNull.Value) wH_Price.WP_Price = Convert.ToDecimal(dr["WP_Price"]);
            if (dr["WP_Num"] != DBNull.Value) wH_Price.WP_Num = Convert.ToDecimal(dr["WP_Num"]);
            if (dr["WP_ONum"] != DBNull.Value) wH_Price.WP_ONum = Convert.ToDecimal(dr["WP_ONum"]);
            if (dr["WP_PNum"] != DBNull.Value) wH_Price.WP_PNum = Convert.ToDecimal(dr["WP_PNum"]);
            if (dr["WP_RNum"] != DBNull.Value) wH_Price.WP_RNum = Convert.ToDecimal(dr["WP_RNum"]);
            if (dr["WP_RONum"] != DBNull.Value) wH_Price.WP_RONum = Convert.ToDecimal(dr["WP_RONum"]);
            if (dr["WP_INum"] != DBNull.Value) wH_Price.WP_INum = Convert.ToDecimal(dr["WP_INum"]);
            if (dr["WP_PRONum"] != DBNull.Value) wH_Price.WP_PRONum = Convert.ToDecimal(dr["WP_PRONum"]);
            if (dr["WP_PRINum"] != DBNull.Value) wH_Price.WP_PRINum = Convert.ToDecimal(dr["WP_PRINum"]);
            if (dr["WP_Udef1"] != DBNull.Value) wH_Price.WP_Udef1 = Convert.ToString(dr["WP_Udef1"]);
            if (dr["WP_Udef2"] != DBNull.Value) wH_Price.WP_Udef2 = Convert.ToString(dr["WP_Udef2"]);
            if (dr["WP_Udef3"] != DBNull.Value) wH_Price.WP_Udef3 = Convert.ToString(dr["WP_Udef3"]);
            if (dr["WP_Udef4"] != DBNull.Value) wH_Price.WP_Udef4 = Convert.ToString(dr["WP_Udef4"]);
            if (dr["WP_Udef5"] != DBNull.Value) wH_Price.WP_Udef5 = Convert.ToString(dr["WP_Udef5"]);
            if (dr["WP_Udef6"] != DBNull.Value) wH_Price.WP_Udef6 = Convert.ToString(dr["WP_Udef6"]);
            if (dr["WP_Udef7"] != DBNull.Value) wH_Price.WP_Udef7 = Convert.ToString(dr["WP_Udef7"]);
            if (dr["WP_Udef8"] != DBNull.Value) wH_Price.WP_Udef8 = Convert.ToString(dr["WP_Udef8"]);
            if (dr["WP_Udef9"] != DBNull.Value) wH_Price.WP_Udef9 = Convert.ToString(dr["WP_Udef9"]);
            if (dr["WP_Udef10"] != DBNull.Value) wH_Price.WP_Udef10 = Convert.ToString(dr["WP_Udef10"]);
            if (dr["Stat"] != DBNull.Value) wH_Price.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["WP_LastPPDate"] != DBNull.Value) wH_Price.WP_LastPPDate = Convert.ToDateTime(dr["WP_LastPPDate"]);
            if (dr["WP_LastPPCollectDate"] != DBNull.Value) wH_Price.WP_LastPPCollectDate = Convert.ToDateTime(dr["WP_LastPPCollectDate"]);
            if (dr["WP_LastPODate"] != DBNull.Value) wH_Price.WP_LastPODate = Convert.ToDateTime(dr["WP_LastPODate"]);
            if (dr["WP_LastPOSupCode"] != DBNull.Value) wH_Price.WP_LastPOSupCode = Convert.ToString(dr["WP_LastPOSupCode"]);
            if (dr["WP_LastPOSupName"] != DBNull.Value) wH_Price.WP_LastPOSupName = Convert.ToString(dr["WP_LastPOSupName"]);
            if (dr["WP_LastPIDate"] != DBNull.Value) wH_Price.WP_LastPIDate = Convert.ToDateTime(dr["WP_LastPIDate"]);
            if (dr["WP_LastPISupCode"] != DBNull.Value) wH_Price.WP_LastPISupCode = Convert.ToString(dr["WP_LastPISupCode"]);
            if (dr["WP_LastPISupName"] != DBNull.Value) wH_Price.WP_LastPISupName = Convert.ToString(dr["WP_LastPISupName"]);
            if (dr["WP_LastPRDate"] != DBNull.Value) wH_Price.WP_LastPRDate = Convert.ToDateTime(dr["WP_LastPRDate"]);
            if (dr["WP_LastPRSupCode"] != DBNull.Value) wH_Price.WP_LastPRSupCode = Convert.ToString(dr["WP_LastPRSupCode"]);
            if (dr["WP_LastPRSupName"] != DBNull.Value) wH_Price.WP_LastPRSupName = Convert.ToString(dr["WP_LastPRSupName"]);
            if (dr["WP_LastRODate"] != DBNull.Value) wH_Price.WP_LastRODate = Convert.ToDateTime(dr["WP_LastRODate"]);
            if (dr["WP_LastRODeptCode"] != DBNull.Value) wH_Price.WP_LastRODeptCode = Convert.ToString(dr["WP_LastRODeptCode"]);
            if (dr["WP_LastRODeptName"] != DBNull.Value) wH_Price.WP_LastRODeptName = Convert.ToString(dr["WP_LastRODeptName"]);
            if (dr["WP_LastROUseType"] != DBNull.Value) wH_Price.WP_LastROUseType = Convert.ToString(dr["WP_LastROUseType"]);
            if (dr["WP_LastROEmpCode"] != DBNull.Value) wH_Price.WP_LastROEmpCode = Convert.ToString(dr["WP_LastROEmpCode"]);
            if (dr["WP_LastROEmpName"] != DBNull.Value) wH_Price.WP_LastROEmpName = Convert.ToString(dr["WP_LastROEmpName"]);
            if (dr["WP_LastPRODate"] != DBNull.Value) wH_Price.WP_LastPRODate = Convert.ToDateTime(dr["WP_LastPRODate"]);
            if (dr["WP_LastPRIDate"] != DBNull.Value) wH_Price.WP_LastPRIDate = Convert.ToDateTime(dr["WP_LastPRIDate"]);
            if (dr["WP_LastPRISupCode"] != DBNull.Value) wH_Price.WP_LastPRISupCode = Convert.ToString(dr["WP_LastPRISupCode"]);
            if (dr["WP_LastPRISupName"] != DBNull.Value) wH_Price.WP_LastPRISupName = Convert.ToString(dr["WP_LastPRISupName"]);
            if (dr["WP_LastPROSupCode"] != DBNull.Value) wH_Price.WP_LastPROSupCode = Convert.ToString(dr["WP_LastPROSupCode"]);
            if (dr["WP_LastPROSupName"] != DBNull.Value) wH_Price.WP_LastPROSupName = Convert.ToString(dr["WP_LastPROSupName"]);
            if (dr["WP_CountPP"] != DBNull.Value) wH_Price.WP_CountPP = Convert.ToInt32(dr["WP_CountPP"]);
            if (dr["WP_CountPO"] != DBNull.Value) wH_Price.WP_CountPO = Convert.ToInt32(dr["WP_CountPO"]);
            if (dr["WP_CountPI"] != DBNull.Value) wH_Price.WP_CountPI = Convert.ToInt32(dr["WP_CountPI"]);
            if (dr["WP_CountPR"] != DBNull.Value) wH_Price.WP_CountPR = Convert.ToInt32(dr["WP_CountPR"]);
            if (dr["WP_CountRO"] != DBNull.Value) wH_Price.WP_CountRO = Convert.ToInt32(dr["WP_CountRO"]);
            if (dr["WP_CountPRO"] != DBNull.Value) wH_Price.WP_CountPRO = Convert.ToDecimal(dr["WP_CountPRO"]);
            if (dr["WP_CountRR"] != DBNull.Value) wH_Price.WP_CountRR = Convert.ToDecimal(dr["WP_CountRR"]);
            if (dr["WP_LeftPO"] != DBNull.Value) wH_Price.WP_LeftPO = Convert.ToDecimal(dr["WP_LeftPO"]);
            if (dr["WP_LeftPP"] != DBNull.Value) wH_Price.WP_LeftPP = Convert.ToDecimal(dr["WP_LeftPP"]);
            if (dr["WP_LastRRDate"] != DBNull.Value) wH_Price.WP_LastRRDate = Convert.ToDateTime(dr["WP_LastRRDate"]);
            if (dr["WP_LastRRDeptCode"] != DBNull.Value) wH_Price.WP_LastRRDeptCode = Convert.ToString(dr["WP_LastRRDeptCode"]);
            if (dr["WP_LastRRDeptName"] != DBNull.Value) wH_Price.WP_LastRRDeptName = Convert.ToString(dr["WP_LastRRDeptName"]);
            if (dr["WP_LastRRUseType"] != DBNull.Value) wH_Price.WP_LastRRUseType = Convert.ToString(dr["WP_LastRRUseType"]);
            if (dr["WP_LastRREmpCode"] != DBNull.Value) wH_Price.WP_LastRREmpCode = Convert.ToString(dr["WP_LastRREmpCode"]);
            if (dr["WP_LastRREmpName"] != DBNull.Value) wH_Price.WP_LastRREmpName = Convert.ToString(dr["WP_LastRREmpName"]);
            ret.Add(wH_Price);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   }  
         return ret;
      }
      /// <summary>
      /// 获取所有的WH_Price对象(即:一条记录
      /// </summary>
      public List<WH_Price> GetAll()
      {
         List<WH_Price> ret = new List<WH_Price>();
         string sql = "SELECT  WP_ID,WP_CCode,WP_CName,WP_MCode,WP_MName,WP_Spec,WP_Unit,WP_Price,WP_Num,WP_ONum,WP_PNum,WP_RNum,WP_RONum,WP_INum,WP_PRONum,WP_PRINum,WP_Udef1,WP_Udef2,WP_Udef3,WP_Udef4,WP_Udef5,WP_Udef6,WP_Udef7,WP_Udef8,WP_Udef9,WP_Udef10,Stat,WP_LastPPDate,WP_LastPPCollectDate,WP_LastPODate,WP_LastPOSupCode,WP_LastPOSupName,WP_LastPIDate,WP_LastPISupCode,WP_LastPISupName,WP_LastPRDate,WP_LastPRSupCode,WP_LastPRSupName,WP_LastRODate,WP_LastRODeptCode,WP_LastRODeptName,WP_LastROUseType,WP_LastROEmpCode,WP_LastROEmpName,WP_LastPRODate,WP_LastPRIDate,WP_LastPRISupCode,WP_LastPRISupName,WP_LastPROSupCode,WP_LastPROSupName,WP_CountPP,WP_CountPO,WP_CountPI,WP_CountPR,WP_CountRO,WP_CountPRO,WP_CountRR,WP_LeftPO,WP_LeftPP,WP_LastRRDate,WP_LastRRDeptCode,WP_LastRRDeptName,WP_LastRRUseType,WP_LastRREmpCode,WP_LastRREmpName FROM WH_Price where 1=1 AND ((Stat is null) or (Stat=0) ) order by WP_ID desc ";
          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            WH_Price wH_Price = new WH_Price();
            if (dr["WP_ID"] != DBNull.Value) wH_Price.WP_ID = Convert.ToInt64(dr["WP_ID"]);
            if (dr["WP_CCode"] != DBNull.Value) wH_Price.WP_CCode = Convert.ToString(dr["WP_CCode"]);
            if (dr["WP_CName"] != DBNull.Value) wH_Price.WP_CName = Convert.ToString(dr["WP_CName"]);
            if (dr["WP_MCode"] != DBNull.Value) wH_Price.WP_MCode = Convert.ToString(dr["WP_MCode"]);
            if (dr["WP_MName"] != DBNull.Value) wH_Price.WP_MName = Convert.ToString(dr["WP_MName"]);
            if (dr["WP_Spec"] != DBNull.Value) wH_Price.WP_Spec = Convert.ToString(dr["WP_Spec"]);
            if (dr["WP_Unit"] != DBNull.Value) wH_Price.WP_Unit = Convert.ToString(dr["WP_Unit"]);
            if (dr["WP_Price"] != DBNull.Value) wH_Price.WP_Price = Convert.ToDecimal(dr["WP_Price"]);
            if (dr["WP_Num"] != DBNull.Value) wH_Price.WP_Num = Convert.ToDecimal(dr["WP_Num"]);
            if (dr["WP_ONum"] != DBNull.Value) wH_Price.WP_ONum = Convert.ToDecimal(dr["WP_ONum"]);
            if (dr["WP_PNum"] != DBNull.Value) wH_Price.WP_PNum = Convert.ToDecimal(dr["WP_PNum"]);
            if (dr["WP_RNum"] != DBNull.Value) wH_Price.WP_RNum = Convert.ToDecimal(dr["WP_RNum"]);
            if (dr["WP_RONum"] != DBNull.Value) wH_Price.WP_RONum = Convert.ToDecimal(dr["WP_RONum"]);
            if (dr["WP_INum"] != DBNull.Value) wH_Price.WP_INum = Convert.ToDecimal(dr["WP_INum"]);
            if (dr["WP_PRONum"] != DBNull.Value) wH_Price.WP_PRONum = Convert.ToDecimal(dr["WP_PRONum"]);
            if (dr["WP_PRINum"] != DBNull.Value) wH_Price.WP_PRINum = Convert.ToDecimal(dr["WP_PRINum"]);
            if (dr["WP_Udef1"] != DBNull.Value) wH_Price.WP_Udef1 = Convert.ToString(dr["WP_Udef1"]);
            if (dr["WP_Udef2"] != DBNull.Value) wH_Price.WP_Udef2 = Convert.ToString(dr["WP_Udef2"]);
            if (dr["WP_Udef3"] != DBNull.Value) wH_Price.WP_Udef3 = Convert.ToString(dr["WP_Udef3"]);
            if (dr["WP_Udef4"] != DBNull.Value) wH_Price.WP_Udef4 = Convert.ToString(dr["WP_Udef4"]);
            if (dr["WP_Udef5"] != DBNull.Value) wH_Price.WP_Udef5 = Convert.ToString(dr["WP_Udef5"]);
            if (dr["WP_Udef6"] != DBNull.Value) wH_Price.WP_Udef6 = Convert.ToString(dr["WP_Udef6"]);
            if (dr["WP_Udef7"] != DBNull.Value) wH_Price.WP_Udef7 = Convert.ToString(dr["WP_Udef7"]);
            if (dr["WP_Udef8"] != DBNull.Value) wH_Price.WP_Udef8 = Convert.ToString(dr["WP_Udef8"]);
            if (dr["WP_Udef9"] != DBNull.Value) wH_Price.WP_Udef9 = Convert.ToString(dr["WP_Udef9"]);
            if (dr["WP_Udef10"] != DBNull.Value) wH_Price.WP_Udef10 = Convert.ToString(dr["WP_Udef10"]);
            if (dr["Stat"] != DBNull.Value) wH_Price.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["WP_LastPPDate"] != DBNull.Value) wH_Price.WP_LastPPDate = Convert.ToDateTime(dr["WP_LastPPDate"]);
            if (dr["WP_LastPPCollectDate"] != DBNull.Value) wH_Price.WP_LastPPCollectDate = Convert.ToDateTime(dr["WP_LastPPCollectDate"]);
            if (dr["WP_LastPODate"] != DBNull.Value) wH_Price.WP_LastPODate = Convert.ToDateTime(dr["WP_LastPODate"]);
            if (dr["WP_LastPOSupCode"] != DBNull.Value) wH_Price.WP_LastPOSupCode = Convert.ToString(dr["WP_LastPOSupCode"]);
            if (dr["WP_LastPOSupName"] != DBNull.Value) wH_Price.WP_LastPOSupName = Convert.ToString(dr["WP_LastPOSupName"]);
            if (dr["WP_LastPIDate"] != DBNull.Value) wH_Price.WP_LastPIDate = Convert.ToDateTime(dr["WP_LastPIDate"]);
            if (dr["WP_LastPISupCode"] != DBNull.Value) wH_Price.WP_LastPISupCode = Convert.ToString(dr["WP_LastPISupCode"]);
            if (dr["WP_LastPISupName"] != DBNull.Value) wH_Price.WP_LastPISupName = Convert.ToString(dr["WP_LastPISupName"]);
            if (dr["WP_LastPRDate"] != DBNull.Value) wH_Price.WP_LastPRDate = Convert.ToDateTime(dr["WP_LastPRDate"]);
            if (dr["WP_LastPRSupCode"] != DBNull.Value) wH_Price.WP_LastPRSupCode = Convert.ToString(dr["WP_LastPRSupCode"]);
            if (dr["WP_LastPRSupName"] != DBNull.Value) wH_Price.WP_LastPRSupName = Convert.ToString(dr["WP_LastPRSupName"]);
            if (dr["WP_LastRODate"] != DBNull.Value) wH_Price.WP_LastRODate = Convert.ToDateTime(dr["WP_LastRODate"]);
            if (dr["WP_LastRODeptCode"] != DBNull.Value) wH_Price.WP_LastRODeptCode = Convert.ToString(dr["WP_LastRODeptCode"]);
            if (dr["WP_LastRODeptName"] != DBNull.Value) wH_Price.WP_LastRODeptName = Convert.ToString(dr["WP_LastRODeptName"]);
            if (dr["WP_LastROUseType"] != DBNull.Value) wH_Price.WP_LastROUseType = Convert.ToString(dr["WP_LastROUseType"]);
            if (dr["WP_LastROEmpCode"] != DBNull.Value) wH_Price.WP_LastROEmpCode = Convert.ToString(dr["WP_LastROEmpCode"]);
            if (dr["WP_LastROEmpName"] != DBNull.Value) wH_Price.WP_LastROEmpName = Convert.ToString(dr["WP_LastROEmpName"]);
            if (dr["WP_LastPRODate"] != DBNull.Value) wH_Price.WP_LastPRODate = Convert.ToDateTime(dr["WP_LastPRODate"]);
            if (dr["WP_LastPRIDate"] != DBNull.Value) wH_Price.WP_LastPRIDate = Convert.ToDateTime(dr["WP_LastPRIDate"]);
            if (dr["WP_LastPRISupCode"] != DBNull.Value) wH_Price.WP_LastPRISupCode = Convert.ToString(dr["WP_LastPRISupCode"]);
            if (dr["WP_LastPRISupName"] != DBNull.Value) wH_Price.WP_LastPRISupName = Convert.ToString(dr["WP_LastPRISupName"]);
            if (dr["WP_LastPROSupCode"] != DBNull.Value) wH_Price.WP_LastPROSupCode = Convert.ToString(dr["WP_LastPROSupCode"]);
            if (dr["WP_LastPROSupName"] != DBNull.Value) wH_Price.WP_LastPROSupName = Convert.ToString(dr["WP_LastPROSupName"]);
            if (dr["WP_CountPP"] != DBNull.Value) wH_Price.WP_CountPP = Convert.ToInt32(dr["WP_CountPP"]);
            if (dr["WP_CountPO"] != DBNull.Value) wH_Price.WP_CountPO = Convert.ToInt32(dr["WP_CountPO"]);
            if (dr["WP_CountPI"] != DBNull.Value) wH_Price.WP_CountPI = Convert.ToInt32(dr["WP_CountPI"]);
            if (dr["WP_CountPR"] != DBNull.Value) wH_Price.WP_CountPR = Convert.ToInt32(dr["WP_CountPR"]);
            if (dr["WP_CountRO"] != DBNull.Value) wH_Price.WP_CountRO = Convert.ToInt32(dr["WP_CountRO"]);
            if (dr["WP_CountPRO"] != DBNull.Value) wH_Price.WP_CountPRO = Convert.ToDecimal(dr["WP_CountPRO"]);
            if (dr["WP_CountRR"] != DBNull.Value) wH_Price.WP_CountRR = Convert.ToDecimal(dr["WP_CountRR"]);
            if (dr["WP_LeftPO"] != DBNull.Value) wH_Price.WP_LeftPO = Convert.ToDecimal(dr["WP_LeftPO"]);
            if (dr["WP_LeftPP"] != DBNull.Value) wH_Price.WP_LeftPP = Convert.ToDecimal(dr["WP_LeftPP"]);
            if (dr["WP_LastRRDate"] != DBNull.Value) wH_Price.WP_LastRRDate = Convert.ToDateTime(dr["WP_LastRRDate"]);
            if (dr["WP_LastRRDeptCode"] != DBNull.Value) wH_Price.WP_LastRRDeptCode = Convert.ToString(dr["WP_LastRRDeptCode"]);
            if (dr["WP_LastRRDeptName"] != DBNull.Value) wH_Price.WP_LastRRDeptName = Convert.ToString(dr["WP_LastRRDeptName"]);
            if (dr["WP_LastRRUseType"] != DBNull.Value) wH_Price.WP_LastRRUseType = Convert.ToString(dr["WP_LastRRUseType"]);
            if (dr["WP_LastRREmpCode"] != DBNull.Value) wH_Price.WP_LastRREmpCode = Convert.ToString(dr["WP_LastRREmpCode"]);
            if (dr["WP_LastRREmpName"] != DBNull.Value) wH_Price.WP_LastRREmpName = Convert.ToString(dr["WP_LastRREmpName"]);
            ret.Add(wH_Price);
         }
          }catch (System.Exception ex){ throw ex; }  finally {  if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   } 
         return ret;
      }
   }
}
