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
   public partial class ADOPU_SMain
   {
      public IDBOperator idb =  DBOperator.GetInstance();
      /// <summary>
      /// 添加PU_SMain对象(即:一条记录)
      /// </summary>
      public int Add(PU_SMain pU_SMain)
      {
         string sql = "INSERT INTO PU_SMain (PUS_Type,PUS_RCode,PUS_Company,PUS_CompanyName,PUS_Dept,PUS_MCode,PUS_MName,PUS_Owner,PUS_Num,PUS_Unit,PUS_Units,PUS_Stat,PUS_Spec,PUS_PDate,PUS_IDate,PUS_RDate,PUS_WOwner,PUS_BOwner,PUS_TranFee,PUS_Price,PUS_Sum,PUS_RefType,PUS_RefCode,PUS_SupType,PUS_UDef1,PUS_UDef2,PUS_UDef3,PUS_UDef4,PUS_UDef5,PUS_UDef6,PUS_UDef7,PUS_Remark,Stat,CreateDate,UpdateDate,DeleteDate,AuditStat,AuditCurAudit) VALUES (@PUS_Type,@PUS_RCode,@PUS_Company,@PUS_CompanyName,@PUS_Dept,@PUS_MCode,@PUS_MName,@PUS_Owner,@PUS_Num,@PUS_Unit,@PUS_Units,@PUS_Stat,@PUS_Spec,@PUS_PDate,@PUS_IDate,@PUS_RDate,@PUS_WOwner,@PUS_BOwner,@PUS_TranFee,@PUS_Price,@PUS_Sum,@PUS_RefType,@PUS_RefCode,@PUS_SupType,@PUS_UDef1,@PUS_UDef2,@PUS_UDef3,@PUS_UDef4,@PUS_UDef5,@PUS_UDef6,@PUS_UDef7,@PUS_Remark,@Stat,@CreateDate,@UpdateDate,@DeleteDate,@AuditStat,@AuditCurAudit)";
         if (string.IsNullOrEmpty(pU_SMain.PUS_Type))
         {
            idb.AddParameter("@PUS_Type", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PUS_Type", pU_SMain.PUS_Type);
         }
         if (string.IsNullOrEmpty(pU_SMain.PUS_RCode))
         {
            idb.AddParameter("@PUS_RCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PUS_RCode", pU_SMain.PUS_RCode);
         }
         if (string.IsNullOrEmpty(pU_SMain.PUS_Company))
         {
            idb.AddParameter("@PUS_Company", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PUS_Company", pU_SMain.PUS_Company);
         }
         if (string.IsNullOrEmpty(pU_SMain.PUS_CompanyName))
         {
            idb.AddParameter("@PUS_CompanyName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PUS_CompanyName", pU_SMain.PUS_CompanyName);
         }
         if (string.IsNullOrEmpty(pU_SMain.PUS_Dept))
         {
            idb.AddParameter("@PUS_Dept", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PUS_Dept", pU_SMain.PUS_Dept);
         }
         if (string.IsNullOrEmpty(pU_SMain.PUS_MCode))
         {
            idb.AddParameter("@PUS_MCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PUS_MCode", pU_SMain.PUS_MCode);
         }
         if (string.IsNullOrEmpty(pU_SMain.PUS_MName))
         {
            idb.AddParameter("@PUS_MName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PUS_MName", pU_SMain.PUS_MName);
         }
         if (string.IsNullOrEmpty(pU_SMain.PUS_Owner))
         {
            idb.AddParameter("@PUS_Owner", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PUS_Owner", pU_SMain.PUS_Owner);
         }
         if (pU_SMain.PUS_Num == 0)
         {
            idb.AddParameter("@PUS_Num", 0);
         }
         else
         {
            idb.AddParameter("@PUS_Num", pU_SMain.PUS_Num);
         }
         if (string.IsNullOrEmpty(pU_SMain.PUS_Unit))
         {
            idb.AddParameter("@PUS_Unit", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PUS_Unit", pU_SMain.PUS_Unit);
         }
         if (string.IsNullOrEmpty(pU_SMain.PUS_Units))
         {
            idb.AddParameter("@PUS_Units", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PUS_Units", pU_SMain.PUS_Units);
         }
         if (string.IsNullOrEmpty(pU_SMain.PUS_Stat))
         {
            idb.AddParameter("@PUS_Stat", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PUS_Stat", pU_SMain.PUS_Stat);
         }
         if (string.IsNullOrEmpty(pU_SMain.PUS_Spec))
         {
            idb.AddParameter("@PUS_Spec", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PUS_Spec", pU_SMain.PUS_Spec);
         }
         if (pU_SMain.PUS_PDate == DateTime.MinValue)
         {
            idb.AddParameter("@PUS_PDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PUS_PDate", pU_SMain.PUS_PDate);
         }
         if (pU_SMain.PUS_IDate == DateTime.MinValue)
         {
            idb.AddParameter("@PUS_IDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PUS_IDate", pU_SMain.PUS_IDate);
         }
         if (pU_SMain.PUS_RDate == DateTime.MinValue)
         {
            idb.AddParameter("@PUS_RDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PUS_RDate", pU_SMain.PUS_RDate);
         }
         if (string.IsNullOrEmpty(pU_SMain.PUS_WOwner))
         {
            idb.AddParameter("@PUS_WOwner", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PUS_WOwner", pU_SMain.PUS_WOwner);
         }
         if (string.IsNullOrEmpty(pU_SMain.PUS_BOwner))
         {
            idb.AddParameter("@PUS_BOwner", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PUS_BOwner", pU_SMain.PUS_BOwner);
         }
         if (pU_SMain.PUS_TranFee == 0)
         {
            idb.AddParameter("@PUS_TranFee", 0);
         }
         else
         {
            idb.AddParameter("@PUS_TranFee", pU_SMain.PUS_TranFee);
         }
         if (pU_SMain.PUS_Price == 0)
         {
            idb.AddParameter("@PUS_Price", 0);
         }
         else
         {
            idb.AddParameter("@PUS_Price", pU_SMain.PUS_Price);
         }
         if (pU_SMain.PUS_Sum == 0)
         {
            idb.AddParameter("@PUS_Sum", 0);
         }
         else
         {
            idb.AddParameter("@PUS_Sum", pU_SMain.PUS_Sum);
         }
         if (string.IsNullOrEmpty(pU_SMain.PUS_RefType))
         {
            idb.AddParameter("@PUS_RefType", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PUS_RefType", pU_SMain.PUS_RefType);
         }
         if (string.IsNullOrEmpty(pU_SMain.PUS_RefCode))
         {
            idb.AddParameter("@PUS_RefCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PUS_RefCode", pU_SMain.PUS_RefCode);
         }
         if (string.IsNullOrEmpty(pU_SMain.PUS_SupType))
         {
            idb.AddParameter("@PUS_SupType", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PUS_SupType", pU_SMain.PUS_SupType);
         }
         if (string.IsNullOrEmpty(pU_SMain.PUS_UDef1))
         {
            idb.AddParameter("@PUS_UDef1", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PUS_UDef1", pU_SMain.PUS_UDef1);
         }
         if (string.IsNullOrEmpty(pU_SMain.PUS_UDef2))
         {
            idb.AddParameter("@PUS_UDef2", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PUS_UDef2", pU_SMain.PUS_UDef2);
         }
         if (string.IsNullOrEmpty(pU_SMain.PUS_UDef3))
         {
            idb.AddParameter("@PUS_UDef3", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PUS_UDef3", pU_SMain.PUS_UDef3);
         }
         if (string.IsNullOrEmpty(pU_SMain.PUS_UDef4))
         {
            idb.AddParameter("@PUS_UDef4", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PUS_UDef4", pU_SMain.PUS_UDef4);
         }
         if (string.IsNullOrEmpty(pU_SMain.PUS_UDef5))
         {
            idb.AddParameter("@PUS_UDef5", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PUS_UDef5", pU_SMain.PUS_UDef5);
         }
         if (string.IsNullOrEmpty(pU_SMain.PUS_UDef6))
         {
            idb.AddParameter("@PUS_UDef6", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PUS_UDef6", pU_SMain.PUS_UDef6);
         }
         if (string.IsNullOrEmpty(pU_SMain.PUS_UDef7))
         {
            idb.AddParameter("@PUS_UDef7", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PUS_UDef7", pU_SMain.PUS_UDef7);
         }
         if (string.IsNullOrEmpty(pU_SMain.PUS_Remark))
         {
            idb.AddParameter("@PUS_Remark", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PUS_Remark", pU_SMain.PUS_Remark);
         }
         if (pU_SMain.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", pU_SMain.Stat);
         }
         if (pU_SMain.CreateDate == DateTime.MinValue)
         {
            idb.AddParameter("@CreateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateDate", pU_SMain.CreateDate);
         }
         if (pU_SMain.UpdateDate == DateTime.MinValue)
         {
            idb.AddParameter("@UpdateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@UpdateDate", pU_SMain.UpdateDate);
         }
         if (pU_SMain.DeleteDate == DateTime.MinValue)
         {
            idb.AddParameter("@DeleteDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DeleteDate", pU_SMain.DeleteDate);
         }
         if (string.IsNullOrEmpty(pU_SMain.AuditStat))
         {
            idb.AddParameter("@AuditStat", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AuditStat", pU_SMain.AuditStat);
         }
         if (string.IsNullOrEmpty(pU_SMain.AuditCurAudit))
         {
            idb.AddParameter("@AuditCurAudit", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AuditCurAudit", pU_SMain.AuditCurAudit);
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
      /// 添加PU_SMain对象(即:一条记录)
      /// </summary>
      public object AddWithReturn(PU_SMain pU_SMain)
      {
         string sql = "INSERT INTO PU_SMain (PUS_Type,PUS_RCode,PUS_Company,PUS_CompanyName,PUS_Dept,PUS_MCode,PUS_MName,PUS_Owner,PUS_Num,PUS_Unit,PUS_Units,PUS_Stat,PUS_Spec,PUS_PDate,PUS_IDate,PUS_RDate,PUS_WOwner,PUS_BOwner,PUS_TranFee,PUS_Price,PUS_Sum,PUS_RefType,PUS_RefCode,PUS_SupType,PUS_UDef1,PUS_UDef2,PUS_UDef3,PUS_UDef4,PUS_UDef5,PUS_UDef6,PUS_UDef7,PUS_Remark,Stat,CreateDate,UpdateDate,DeleteDate,AuditStat,AuditCurAudit) VALUES (@PUS_Type,@PUS_RCode,@PUS_Company,@PUS_CompanyName,@PUS_Dept,@PUS_MCode,@PUS_MName,@PUS_Owner,@PUS_Num,@PUS_Unit,@PUS_Units,@PUS_Stat,@PUS_Spec,@PUS_PDate,@PUS_IDate,@PUS_RDate,@PUS_WOwner,@PUS_BOwner,@PUS_TranFee,@PUS_Price,@PUS_Sum,@PUS_RefType,@PUS_RefCode,@PUS_SupType,@PUS_UDef1,@PUS_UDef2,@PUS_UDef3,@PUS_UDef4,@PUS_UDef5,@PUS_UDef6,@PUS_UDef7,@PUS_Remark,@Stat,@CreateDate,@UpdateDate,@DeleteDate,@AuditStat,@AuditCurAudit);SELECT @@IDENTITY AS ReturnID;";
         if (string.IsNullOrEmpty(pU_SMain.PUS_Type))
         {
            idb.AddParameter("@PUS_Type", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PUS_Type", pU_SMain.PUS_Type);
         }
         if (string.IsNullOrEmpty(pU_SMain.PUS_RCode))
         {
            idb.AddParameter("@PUS_RCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PUS_RCode", pU_SMain.PUS_RCode);
         }
         if (string.IsNullOrEmpty(pU_SMain.PUS_Company))
         {
            idb.AddParameter("@PUS_Company", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PUS_Company", pU_SMain.PUS_Company);
         }
         if (string.IsNullOrEmpty(pU_SMain.PUS_CompanyName))
         {
            idb.AddParameter("@PUS_CompanyName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PUS_CompanyName", pU_SMain.PUS_CompanyName);
         }
         if (string.IsNullOrEmpty(pU_SMain.PUS_Dept))
         {
            idb.AddParameter("@PUS_Dept", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PUS_Dept", pU_SMain.PUS_Dept);
         }
         if (string.IsNullOrEmpty(pU_SMain.PUS_MCode))
         {
            idb.AddParameter("@PUS_MCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PUS_MCode", pU_SMain.PUS_MCode);
         }
         if (string.IsNullOrEmpty(pU_SMain.PUS_MName))
         {
            idb.AddParameter("@PUS_MName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PUS_MName", pU_SMain.PUS_MName);
         }
         if (string.IsNullOrEmpty(pU_SMain.PUS_Owner))
         {
            idb.AddParameter("@PUS_Owner", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PUS_Owner", pU_SMain.PUS_Owner);
         }
         if (pU_SMain.PUS_Num == 0)
         {
            idb.AddParameter("@PUS_Num", 0);
         }
         else
         {
            idb.AddParameter("@PUS_Num", pU_SMain.PUS_Num);
         }
         if (string.IsNullOrEmpty(pU_SMain.PUS_Unit))
         {
            idb.AddParameter("@PUS_Unit", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PUS_Unit", pU_SMain.PUS_Unit);
         }
         if (string.IsNullOrEmpty(pU_SMain.PUS_Units))
         {
            idb.AddParameter("@PUS_Units", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PUS_Units", pU_SMain.PUS_Units);
         }
         if (string.IsNullOrEmpty(pU_SMain.PUS_Stat))
         {
            idb.AddParameter("@PUS_Stat", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PUS_Stat", pU_SMain.PUS_Stat);
         }
         if (string.IsNullOrEmpty(pU_SMain.PUS_Spec))
         {
            idb.AddParameter("@PUS_Spec", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PUS_Spec", pU_SMain.PUS_Spec);
         }
         if (pU_SMain.PUS_PDate == DateTime.MinValue)
         {
            idb.AddParameter("@PUS_PDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PUS_PDate", pU_SMain.PUS_PDate);
         }
         if (pU_SMain.PUS_IDate == DateTime.MinValue)
         {
            idb.AddParameter("@PUS_IDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PUS_IDate", pU_SMain.PUS_IDate);
         }
         if (pU_SMain.PUS_RDate == DateTime.MinValue)
         {
            idb.AddParameter("@PUS_RDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PUS_RDate", pU_SMain.PUS_RDate);
         }
         if (string.IsNullOrEmpty(pU_SMain.PUS_WOwner))
         {
            idb.AddParameter("@PUS_WOwner", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PUS_WOwner", pU_SMain.PUS_WOwner);
         }
         if (string.IsNullOrEmpty(pU_SMain.PUS_BOwner))
         {
            idb.AddParameter("@PUS_BOwner", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PUS_BOwner", pU_SMain.PUS_BOwner);
         }
         if (pU_SMain.PUS_TranFee == 0)
         {
            idb.AddParameter("@PUS_TranFee", 0);
         }
         else
         {
            idb.AddParameter("@PUS_TranFee", pU_SMain.PUS_TranFee);
         }
         if (pU_SMain.PUS_Price == 0)
         {
            idb.AddParameter("@PUS_Price", 0);
         }
         else
         {
            idb.AddParameter("@PUS_Price", pU_SMain.PUS_Price);
         }
         if (pU_SMain.PUS_Sum == 0)
         {
            idb.AddParameter("@PUS_Sum", 0);
         }
         else
         {
            idb.AddParameter("@PUS_Sum", pU_SMain.PUS_Sum);
         }
         if (string.IsNullOrEmpty(pU_SMain.PUS_RefType))
         {
            idb.AddParameter("@PUS_RefType", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PUS_RefType", pU_SMain.PUS_RefType);
         }
         if (string.IsNullOrEmpty(pU_SMain.PUS_RefCode))
         {
            idb.AddParameter("@PUS_RefCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PUS_RefCode", pU_SMain.PUS_RefCode);
         }
         if (string.IsNullOrEmpty(pU_SMain.PUS_SupType))
         {
            idb.AddParameter("@PUS_SupType", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PUS_SupType", pU_SMain.PUS_SupType);
         }
         if (string.IsNullOrEmpty(pU_SMain.PUS_UDef1))
         {
            idb.AddParameter("@PUS_UDef1", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PUS_UDef1", pU_SMain.PUS_UDef1);
         }
         if (string.IsNullOrEmpty(pU_SMain.PUS_UDef2))
         {
            idb.AddParameter("@PUS_UDef2", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PUS_UDef2", pU_SMain.PUS_UDef2);
         }
         if (string.IsNullOrEmpty(pU_SMain.PUS_UDef3))
         {
            idb.AddParameter("@PUS_UDef3", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PUS_UDef3", pU_SMain.PUS_UDef3);
         }
         if (string.IsNullOrEmpty(pU_SMain.PUS_UDef4))
         {
            idb.AddParameter("@PUS_UDef4", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PUS_UDef4", pU_SMain.PUS_UDef4);
         }
         if (string.IsNullOrEmpty(pU_SMain.PUS_UDef5))
         {
            idb.AddParameter("@PUS_UDef5", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PUS_UDef5", pU_SMain.PUS_UDef5);
         }
         if (string.IsNullOrEmpty(pU_SMain.PUS_UDef6))
         {
            idb.AddParameter("@PUS_UDef6", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PUS_UDef6", pU_SMain.PUS_UDef6);
         }
         if (string.IsNullOrEmpty(pU_SMain.PUS_UDef7))
         {
            idb.AddParameter("@PUS_UDef7", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PUS_UDef7", pU_SMain.PUS_UDef7);
         }
         if (string.IsNullOrEmpty(pU_SMain.PUS_Remark))
         {
            idb.AddParameter("@PUS_Remark", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PUS_Remark", pU_SMain.PUS_Remark);
         }
         if (pU_SMain.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", pU_SMain.Stat);
         }
         if (pU_SMain.CreateDate == DateTime.MinValue)
         {
            idb.AddParameter("@CreateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateDate", pU_SMain.CreateDate);
         }
         if (pU_SMain.UpdateDate == DateTime.MinValue)
         {
            idb.AddParameter("@UpdateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@UpdateDate", pU_SMain.UpdateDate);
         }
         if (pU_SMain.DeleteDate == DateTime.MinValue)
         {
            idb.AddParameter("@DeleteDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DeleteDate", pU_SMain.DeleteDate);
         }
         if (string.IsNullOrEmpty(pU_SMain.AuditStat))
         {
            idb.AddParameter("@AuditStat", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AuditStat", pU_SMain.AuditStat);
         }
         if (string.IsNullOrEmpty(pU_SMain.AuditCurAudit))
         {
            idb.AddParameter("@AuditCurAudit", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AuditCurAudit", pU_SMain.AuditCurAudit);
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
      /// 更新PU_SMain对象(即:一条记录
      /// </summary>
      public int Update(PU_SMain pU_SMain)
      {
         
         StringBuilder sbParameter=new StringBuilder();
      StringBuilder sb=new StringBuilder();
      sb.Append(@"UPDATE       PU_SMain       SET ");
            if(pU_SMain.PUS_Type_IsChanged){sbParameter.Append("PUS_Type=@PUS_Type, ");}
      if(pU_SMain.PUS_RCode_IsChanged){sbParameter.Append("PUS_RCode=@PUS_RCode, ");}
      if(pU_SMain.PUS_Company_IsChanged){sbParameter.Append("PUS_Company=@PUS_Company, ");}
      if(pU_SMain.PUS_CompanyName_IsChanged){sbParameter.Append("PUS_CompanyName=@PUS_CompanyName, ");}
      if(pU_SMain.PUS_Dept_IsChanged){sbParameter.Append("PUS_Dept=@PUS_Dept, ");}
      if(pU_SMain.PUS_MCode_IsChanged){sbParameter.Append("PUS_MCode=@PUS_MCode, ");}
      if(pU_SMain.PUS_MName_IsChanged){sbParameter.Append("PUS_MName=@PUS_MName, ");}
      if(pU_SMain.PUS_Owner_IsChanged){sbParameter.Append("PUS_Owner=@PUS_Owner, ");}
      if(pU_SMain.PUS_Num_IsChanged){sbParameter.Append("PUS_Num=@PUS_Num, ");}
      if(pU_SMain.PUS_Unit_IsChanged){sbParameter.Append("PUS_Unit=@PUS_Unit, ");}
      if(pU_SMain.PUS_Units_IsChanged){sbParameter.Append("PUS_Units=@PUS_Units, ");}
      if(pU_SMain.PUS_Stat_IsChanged){sbParameter.Append("PUS_Stat=@PUS_Stat, ");}
      if(pU_SMain.PUS_Spec_IsChanged){sbParameter.Append("PUS_Spec=@PUS_Spec, ");}
      if(pU_SMain.PUS_PDate_IsChanged){sbParameter.Append("PUS_PDate=@PUS_PDate, ");}
      if(pU_SMain.PUS_IDate_IsChanged){sbParameter.Append("PUS_IDate=@PUS_IDate, ");}
      if(pU_SMain.PUS_RDate_IsChanged){sbParameter.Append("PUS_RDate=@PUS_RDate, ");}
      if(pU_SMain.PUS_WOwner_IsChanged){sbParameter.Append("PUS_WOwner=@PUS_WOwner, ");}
      if(pU_SMain.PUS_BOwner_IsChanged){sbParameter.Append("PUS_BOwner=@PUS_BOwner, ");}
      if(pU_SMain.PUS_TranFee_IsChanged){sbParameter.Append("PUS_TranFee=@PUS_TranFee, ");}
      if(pU_SMain.PUS_Price_IsChanged){sbParameter.Append("PUS_Price=@PUS_Price, ");}
      if(pU_SMain.PUS_Sum_IsChanged){sbParameter.Append("PUS_Sum=@PUS_Sum, ");}
      if(pU_SMain.PUS_RefType_IsChanged){sbParameter.Append("PUS_RefType=@PUS_RefType, ");}
      if(pU_SMain.PUS_RefCode_IsChanged){sbParameter.Append("PUS_RefCode=@PUS_RefCode, ");}
      if(pU_SMain.PUS_SupType_IsChanged){sbParameter.Append("PUS_SupType=@PUS_SupType, ");}
      if(pU_SMain.PUS_UDef1_IsChanged){sbParameter.Append("PUS_UDef1=@PUS_UDef1, ");}
      if(pU_SMain.PUS_UDef2_IsChanged){sbParameter.Append("PUS_UDef2=@PUS_UDef2, ");}
      if(pU_SMain.PUS_UDef3_IsChanged){sbParameter.Append("PUS_UDef3=@PUS_UDef3, ");}
      if(pU_SMain.PUS_UDef4_IsChanged){sbParameter.Append("PUS_UDef4=@PUS_UDef4, ");}
      if(pU_SMain.PUS_UDef5_IsChanged){sbParameter.Append("PUS_UDef5=@PUS_UDef5, ");}
      if(pU_SMain.PUS_UDef6_IsChanged){sbParameter.Append("PUS_UDef6=@PUS_UDef6, ");}
      if(pU_SMain.PUS_UDef7_IsChanged){sbParameter.Append("PUS_UDef7=@PUS_UDef7, ");}
      if(pU_SMain.PUS_Remark_IsChanged){sbParameter.Append("PUS_Remark=@PUS_Remark, ");}
      if(pU_SMain.Stat_IsChanged){sbParameter.Append("Stat=@Stat, ");}
      if(pU_SMain.CreateDate_IsChanged){sbParameter.Append("CreateDate=@CreateDate, ");}
      if(pU_SMain.UpdateDate_IsChanged){sbParameter.Append("UpdateDate=@UpdateDate, ");}
      if(pU_SMain.DeleteDate_IsChanged){sbParameter.Append("DeleteDate=@DeleteDate, ");}
      if(pU_SMain.AuditStat_IsChanged){sbParameter.Append("AuditStat=@AuditStat, ");}
      if(pU_SMain.AuditCurAudit_IsChanged){sbParameter.Append("AuditCurAudit=@AuditCurAudit ");}          sb.Append(sbParameter.ToString().Trim().TrimEnd(',')); 
      sb.Append(      " WHERE 1=1 AND ((Stat is null) or (Stat=0))   and PUS_ID=@PUS_ID; " );
      string sql=sb.ToString();
         if(pU_SMain.PUS_Type_IsChanged)
         {
         if (string.IsNullOrEmpty(pU_SMain.PUS_Type))
         {
            idb.AddParameter("@PUS_Type", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PUS_Type", pU_SMain.PUS_Type);
         }
          }
         if(pU_SMain.PUS_RCode_IsChanged)
         {
         if (string.IsNullOrEmpty(pU_SMain.PUS_RCode))
         {
            idb.AddParameter("@PUS_RCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PUS_RCode", pU_SMain.PUS_RCode);
         }
          }
         if(pU_SMain.PUS_Company_IsChanged)
         {
         if (string.IsNullOrEmpty(pU_SMain.PUS_Company))
         {
            idb.AddParameter("@PUS_Company", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PUS_Company", pU_SMain.PUS_Company);
         }
          }
         if(pU_SMain.PUS_CompanyName_IsChanged)
         {
         if (string.IsNullOrEmpty(pU_SMain.PUS_CompanyName))
         {
            idb.AddParameter("@PUS_CompanyName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PUS_CompanyName", pU_SMain.PUS_CompanyName);
         }
          }
         if(pU_SMain.PUS_Dept_IsChanged)
         {
         if (string.IsNullOrEmpty(pU_SMain.PUS_Dept))
         {
            idb.AddParameter("@PUS_Dept", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PUS_Dept", pU_SMain.PUS_Dept);
         }
          }
         if(pU_SMain.PUS_MCode_IsChanged)
         {
         if (string.IsNullOrEmpty(pU_SMain.PUS_MCode))
         {
            idb.AddParameter("@PUS_MCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PUS_MCode", pU_SMain.PUS_MCode);
         }
          }
         if(pU_SMain.PUS_MName_IsChanged)
         {
         if (string.IsNullOrEmpty(pU_SMain.PUS_MName))
         {
            idb.AddParameter("@PUS_MName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PUS_MName", pU_SMain.PUS_MName);
         }
          }
         if(pU_SMain.PUS_Owner_IsChanged)
         {
         if (string.IsNullOrEmpty(pU_SMain.PUS_Owner))
         {
            idb.AddParameter("@PUS_Owner", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PUS_Owner", pU_SMain.PUS_Owner);
         }
          }
         if(pU_SMain.PUS_Num_IsChanged)
         {
         if (pU_SMain.PUS_Num == 0)
         {
            idb.AddParameter("@PUS_Num", 0);
         }
         else
         {
            idb.AddParameter("@PUS_Num", pU_SMain.PUS_Num);
         }
          }
         if(pU_SMain.PUS_Unit_IsChanged)
         {
         if (string.IsNullOrEmpty(pU_SMain.PUS_Unit))
         {
            idb.AddParameter("@PUS_Unit", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PUS_Unit", pU_SMain.PUS_Unit);
         }
          }
         if(pU_SMain.PUS_Units_IsChanged)
         {
         if (string.IsNullOrEmpty(pU_SMain.PUS_Units))
         {
            idb.AddParameter("@PUS_Units", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PUS_Units", pU_SMain.PUS_Units);
         }
          }
         if(pU_SMain.PUS_Stat_IsChanged)
         {
         if (string.IsNullOrEmpty(pU_SMain.PUS_Stat))
         {
            idb.AddParameter("@PUS_Stat", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PUS_Stat", pU_SMain.PUS_Stat);
         }
          }
         if(pU_SMain.PUS_Spec_IsChanged)
         {
         if (string.IsNullOrEmpty(pU_SMain.PUS_Spec))
         {
            idb.AddParameter("@PUS_Spec", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PUS_Spec", pU_SMain.PUS_Spec);
         }
          }
         if(pU_SMain.PUS_PDate_IsChanged)
         {
         if (pU_SMain.PUS_PDate == DateTime.MinValue)
         {
            idb.AddParameter("@PUS_PDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PUS_PDate", pU_SMain.PUS_PDate);
         }
          }
         if(pU_SMain.PUS_IDate_IsChanged)
         {
         if (pU_SMain.PUS_IDate == DateTime.MinValue)
         {
            idb.AddParameter("@PUS_IDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PUS_IDate", pU_SMain.PUS_IDate);
         }
          }
         if(pU_SMain.PUS_RDate_IsChanged)
         {
         if (pU_SMain.PUS_RDate == DateTime.MinValue)
         {
            idb.AddParameter("@PUS_RDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PUS_RDate", pU_SMain.PUS_RDate);
         }
          }
         if(pU_SMain.PUS_WOwner_IsChanged)
         {
         if (string.IsNullOrEmpty(pU_SMain.PUS_WOwner))
         {
            idb.AddParameter("@PUS_WOwner", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PUS_WOwner", pU_SMain.PUS_WOwner);
         }
          }
         if(pU_SMain.PUS_BOwner_IsChanged)
         {
         if (string.IsNullOrEmpty(pU_SMain.PUS_BOwner))
         {
            idb.AddParameter("@PUS_BOwner", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PUS_BOwner", pU_SMain.PUS_BOwner);
         }
          }
         if(pU_SMain.PUS_TranFee_IsChanged)
         {
         if (pU_SMain.PUS_TranFee == 0)
         {
            idb.AddParameter("@PUS_TranFee", 0);
         }
         else
         {
            idb.AddParameter("@PUS_TranFee", pU_SMain.PUS_TranFee);
         }
          }
         if(pU_SMain.PUS_Price_IsChanged)
         {
         if (pU_SMain.PUS_Price == 0)
         {
            idb.AddParameter("@PUS_Price", 0);
         }
         else
         {
            idb.AddParameter("@PUS_Price", pU_SMain.PUS_Price);
         }
          }
         if(pU_SMain.PUS_Sum_IsChanged)
         {
         if (pU_SMain.PUS_Sum == 0)
         {
            idb.AddParameter("@PUS_Sum", 0);
         }
         else
         {
            idb.AddParameter("@PUS_Sum", pU_SMain.PUS_Sum);
         }
          }
         if(pU_SMain.PUS_RefType_IsChanged)
         {
         if (string.IsNullOrEmpty(pU_SMain.PUS_RefType))
         {
            idb.AddParameter("@PUS_RefType", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PUS_RefType", pU_SMain.PUS_RefType);
         }
          }
         if(pU_SMain.PUS_RefCode_IsChanged)
         {
         if (string.IsNullOrEmpty(pU_SMain.PUS_RefCode))
         {
            idb.AddParameter("@PUS_RefCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PUS_RefCode", pU_SMain.PUS_RefCode);
         }
          }
         if(pU_SMain.PUS_SupType_IsChanged)
         {
         if (string.IsNullOrEmpty(pU_SMain.PUS_SupType))
         {
            idb.AddParameter("@PUS_SupType", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PUS_SupType", pU_SMain.PUS_SupType);
         }
          }
         if(pU_SMain.PUS_UDef1_IsChanged)
         {
         if (string.IsNullOrEmpty(pU_SMain.PUS_UDef1))
         {
            idb.AddParameter("@PUS_UDef1", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PUS_UDef1", pU_SMain.PUS_UDef1);
         }
          }
         if(pU_SMain.PUS_UDef2_IsChanged)
         {
         if (string.IsNullOrEmpty(pU_SMain.PUS_UDef2))
         {
            idb.AddParameter("@PUS_UDef2", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PUS_UDef2", pU_SMain.PUS_UDef2);
         }
          }
         if(pU_SMain.PUS_UDef3_IsChanged)
         {
         if (string.IsNullOrEmpty(pU_SMain.PUS_UDef3))
         {
            idb.AddParameter("@PUS_UDef3", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PUS_UDef3", pU_SMain.PUS_UDef3);
         }
          }
         if(pU_SMain.PUS_UDef4_IsChanged)
         {
         if (string.IsNullOrEmpty(pU_SMain.PUS_UDef4))
         {
            idb.AddParameter("@PUS_UDef4", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PUS_UDef4", pU_SMain.PUS_UDef4);
         }
          }
         if(pU_SMain.PUS_UDef5_IsChanged)
         {
         if (string.IsNullOrEmpty(pU_SMain.PUS_UDef5))
         {
            idb.AddParameter("@PUS_UDef5", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PUS_UDef5", pU_SMain.PUS_UDef5);
         }
          }
         if(pU_SMain.PUS_UDef6_IsChanged)
         {
         if (string.IsNullOrEmpty(pU_SMain.PUS_UDef6))
         {
            idb.AddParameter("@PUS_UDef6", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PUS_UDef6", pU_SMain.PUS_UDef6);
         }
          }
         if(pU_SMain.PUS_UDef7_IsChanged)
         {
         if (string.IsNullOrEmpty(pU_SMain.PUS_UDef7))
         {
            idb.AddParameter("@PUS_UDef7", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PUS_UDef7", pU_SMain.PUS_UDef7);
         }
          }
         if(pU_SMain.PUS_Remark_IsChanged)
         {
         if (string.IsNullOrEmpty(pU_SMain.PUS_Remark))
         {
            idb.AddParameter("@PUS_Remark", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PUS_Remark", pU_SMain.PUS_Remark);
         }
          }
         if(pU_SMain.Stat_IsChanged)
         {
         if (pU_SMain.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", pU_SMain.Stat);
         }
          }
         if(pU_SMain.CreateDate_IsChanged)
         {
         if (pU_SMain.CreateDate == DateTime.MinValue)
         {
            idb.AddParameter("@CreateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateDate", pU_SMain.CreateDate);
         }
          }
         if(pU_SMain.UpdateDate_IsChanged)
         {
         if (pU_SMain.UpdateDate == DateTime.MinValue)
         {
            idb.AddParameter("@UpdateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@UpdateDate", pU_SMain.UpdateDate);
         }
          }
         if(pU_SMain.DeleteDate_IsChanged)
         {
         if (pU_SMain.DeleteDate == DateTime.MinValue)
         {
            idb.AddParameter("@DeleteDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DeleteDate", pU_SMain.DeleteDate);
         }
          }
         if(pU_SMain.AuditStat_IsChanged)
         {
         if (string.IsNullOrEmpty(pU_SMain.AuditStat))
         {
            idb.AddParameter("@AuditStat", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AuditStat", pU_SMain.AuditStat);
         }
          }
         if(pU_SMain.AuditCurAudit_IsChanged)
         {
         if (string.IsNullOrEmpty(pU_SMain.AuditCurAudit))
         {
            idb.AddParameter("@AuditCurAudit", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AuditCurAudit", pU_SMain.AuditCurAudit);
         }
          }

         idb.AddParameter("@PUS_ID", pU_SMain.PUS_ID);

           
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
      /// 删除PU_SMain对象(即:一条记录
      /// </summary>
      public int Delete(decimal pUS_ID)
      {
         string sql = "DELETE PU_SMain WHERE 1=1  AND PUS_ID=@PUS_ID ";
         idb.AddParameter("@PUS_ID", pUS_ID);

           
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
      /// 获取指定的PU_SMain对象(即:一条记录
      /// </summary>
      public PU_SMain GetByKey(decimal pUS_ID)
      {
         PU_SMain pU_SMain = new PU_SMain();
         string sql = "SELECT  PUS_ID,PUS_Type,PUS_RCode,PUS_Company,PUS_CompanyName,PUS_Dept,PUS_MCode,PUS_MName,PUS_Owner,PUS_Num,PUS_Unit,PUS_Units,PUS_Stat,PUS_Spec,PUS_PDate,PUS_IDate,PUS_RDate,PUS_WOwner,PUS_BOwner,PUS_TranFee,PUS_Price,PUS_Sum,PUS_RefType,PUS_RefCode,PUS_SupType,PUS_UDef1,PUS_UDef2,PUS_UDef3,PUS_UDef4,PUS_UDef5,PUS_UDef6,PUS_UDef7,PUS_Remark,Stat,CreateDate,UpdateDate,DeleteDate,AuditStat,AuditCurAudit FROM PU_SMain WHERE 1=1 AND ((Stat is null) or (Stat=0) )  AND PUS_ID=@PUS_ID ";
         idb.AddParameter("@PUS_ID", pUS_ID);

          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            if (dr["PUS_ID"] != DBNull.Value) pU_SMain.PUS_ID = Convert.ToDecimal(dr["PUS_ID"]);
            if (dr["PUS_Type"] != DBNull.Value) pU_SMain.PUS_Type = Convert.ToString(dr["PUS_Type"]);
            if (dr["PUS_RCode"] != DBNull.Value) pU_SMain.PUS_RCode = Convert.ToString(dr["PUS_RCode"]);
            if (dr["PUS_Company"] != DBNull.Value) pU_SMain.PUS_Company = Convert.ToString(dr["PUS_Company"]);
            if (dr["PUS_CompanyName"] != DBNull.Value) pU_SMain.PUS_CompanyName = Convert.ToString(dr["PUS_CompanyName"]);
            if (dr["PUS_Dept"] != DBNull.Value) pU_SMain.PUS_Dept = Convert.ToString(dr["PUS_Dept"]);
            if (dr["PUS_MCode"] != DBNull.Value) pU_SMain.PUS_MCode = Convert.ToString(dr["PUS_MCode"]);
            if (dr["PUS_MName"] != DBNull.Value) pU_SMain.PUS_MName = Convert.ToString(dr["PUS_MName"]);
            if (dr["PUS_Owner"] != DBNull.Value) pU_SMain.PUS_Owner = Convert.ToString(dr["PUS_Owner"]);
            if (dr["PUS_Num"] != DBNull.Value) pU_SMain.PUS_Num = Convert.ToDecimal(dr["PUS_Num"]);
            if (dr["PUS_Unit"] != DBNull.Value) pU_SMain.PUS_Unit = Convert.ToString(dr["PUS_Unit"]);
            if (dr["PUS_Units"] != DBNull.Value) pU_SMain.PUS_Units = Convert.ToString(dr["PUS_Units"]);
            if (dr["PUS_Stat"] != DBNull.Value) pU_SMain.PUS_Stat = Convert.ToString(dr["PUS_Stat"]);
            if (dr["PUS_Spec"] != DBNull.Value) pU_SMain.PUS_Spec = Convert.ToString(dr["PUS_Spec"]);
            if (dr["PUS_PDate"] != DBNull.Value) pU_SMain.PUS_PDate = Convert.ToDateTime(dr["PUS_PDate"]);
            if (dr["PUS_IDate"] != DBNull.Value) pU_SMain.PUS_IDate = Convert.ToDateTime(dr["PUS_IDate"]);
            if (dr["PUS_RDate"] != DBNull.Value) pU_SMain.PUS_RDate = Convert.ToDateTime(dr["PUS_RDate"]);
            if (dr["PUS_WOwner"] != DBNull.Value) pU_SMain.PUS_WOwner = Convert.ToString(dr["PUS_WOwner"]);
            if (dr["PUS_BOwner"] != DBNull.Value) pU_SMain.PUS_BOwner = Convert.ToString(dr["PUS_BOwner"]);
            if (dr["PUS_TranFee"] != DBNull.Value) pU_SMain.PUS_TranFee = Convert.ToDecimal(dr["PUS_TranFee"]);
            if (dr["PUS_Price"] != DBNull.Value) pU_SMain.PUS_Price = Convert.ToDecimal(dr["PUS_Price"]);
            if (dr["PUS_Sum"] != DBNull.Value) pU_SMain.PUS_Sum = Convert.ToDecimal(dr["PUS_Sum"]);
            if (dr["PUS_RefType"] != DBNull.Value) pU_SMain.PUS_RefType = Convert.ToString(dr["PUS_RefType"]);
            if (dr["PUS_RefCode"] != DBNull.Value) pU_SMain.PUS_RefCode = Convert.ToString(dr["PUS_RefCode"]);
            if (dr["PUS_SupType"] != DBNull.Value) pU_SMain.PUS_SupType = Convert.ToString(dr["PUS_SupType"]);
            if (dr["PUS_UDef1"] != DBNull.Value) pU_SMain.PUS_UDef1 = Convert.ToString(dr["PUS_UDef1"]);
            if (dr["PUS_UDef2"] != DBNull.Value) pU_SMain.PUS_UDef2 = Convert.ToString(dr["PUS_UDef2"]);
            if (dr["PUS_UDef3"] != DBNull.Value) pU_SMain.PUS_UDef3 = Convert.ToString(dr["PUS_UDef3"]);
            if (dr["PUS_UDef4"] != DBNull.Value) pU_SMain.PUS_UDef4 = Convert.ToString(dr["PUS_UDef4"]);
            if (dr["PUS_UDef5"] != DBNull.Value) pU_SMain.PUS_UDef5 = Convert.ToString(dr["PUS_UDef5"]);
            if (dr["PUS_UDef6"] != DBNull.Value) pU_SMain.PUS_UDef6 = Convert.ToString(dr["PUS_UDef6"]);
            if (dr["PUS_UDef7"] != DBNull.Value) pU_SMain.PUS_UDef7 = Convert.ToString(dr["PUS_UDef7"]);
            if (dr["PUS_Remark"] != DBNull.Value) pU_SMain.PUS_Remark = Convert.ToString(dr["PUS_Remark"]);
            if (dr["Stat"] != DBNull.Value) pU_SMain.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["CreateDate"] != DBNull.Value) pU_SMain.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
            if (dr["UpdateDate"] != DBNull.Value) pU_SMain.UpdateDate = Convert.ToDateTime(dr["UpdateDate"]);
            if (dr["DeleteDate"] != DBNull.Value) pU_SMain.DeleteDate = Convert.ToDateTime(dr["DeleteDate"]);
            if (dr["AuditStat"] != DBNull.Value) pU_SMain.AuditStat = Convert.ToString(dr["AuditStat"]);
            if (dr["AuditCurAudit"] != DBNull.Value) pU_SMain.AuditCurAudit = Convert.ToString(dr["AuditCurAudit"]);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   }  
         return pU_SMain;
      }
      /// <summary>
      /// 获取指定的PU_SMain对象集合
      /// </summary>
      public List<PU_SMain> GetListByWhere(string strCondition)
      {
         List<PU_SMain> ret = new List<PU_SMain>();
         string sql = "SELECT  PUS_ID,PUS_Type,PUS_RCode,PUS_Company,PUS_CompanyName,PUS_Dept,PUS_MCode,PUS_MName,PUS_Owner,PUS_Num,PUS_Unit,PUS_Units,PUS_Stat,PUS_Spec,PUS_PDate,PUS_IDate,PUS_RDate,PUS_WOwner,PUS_BOwner,PUS_TranFee,PUS_Price,PUS_Sum,PUS_RefType,PUS_RefCode,PUS_SupType,PUS_UDef1,PUS_UDef2,PUS_UDef3,PUS_UDef4,PUS_UDef5,PUS_UDef6,PUS_UDef7,PUS_Remark,Stat,CreateDate,UpdateDate,DeleteDate,AuditStat,AuditCurAudit FROM PU_SMain WHERE 1=1 AND ((Stat is null) or (Stat=0) ) ";
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
            PU_SMain pU_SMain = new PU_SMain();
            if (dr["PUS_ID"] != DBNull.Value) pU_SMain.PUS_ID = Convert.ToDecimal(dr["PUS_ID"]);
            if (dr["PUS_Type"] != DBNull.Value) pU_SMain.PUS_Type = Convert.ToString(dr["PUS_Type"]);
            if (dr["PUS_RCode"] != DBNull.Value) pU_SMain.PUS_RCode = Convert.ToString(dr["PUS_RCode"]);
            if (dr["PUS_Company"] != DBNull.Value) pU_SMain.PUS_Company = Convert.ToString(dr["PUS_Company"]);
            if (dr["PUS_CompanyName"] != DBNull.Value) pU_SMain.PUS_CompanyName = Convert.ToString(dr["PUS_CompanyName"]);
            if (dr["PUS_Dept"] != DBNull.Value) pU_SMain.PUS_Dept = Convert.ToString(dr["PUS_Dept"]);
            if (dr["PUS_MCode"] != DBNull.Value) pU_SMain.PUS_MCode = Convert.ToString(dr["PUS_MCode"]);
            if (dr["PUS_MName"] != DBNull.Value) pU_SMain.PUS_MName = Convert.ToString(dr["PUS_MName"]);
            if (dr["PUS_Owner"] != DBNull.Value) pU_SMain.PUS_Owner = Convert.ToString(dr["PUS_Owner"]);
            if (dr["PUS_Num"] != DBNull.Value) pU_SMain.PUS_Num = Convert.ToDecimal(dr["PUS_Num"]);
            if (dr["PUS_Unit"] != DBNull.Value) pU_SMain.PUS_Unit = Convert.ToString(dr["PUS_Unit"]);
            if (dr["PUS_Units"] != DBNull.Value) pU_SMain.PUS_Units = Convert.ToString(dr["PUS_Units"]);
            if (dr["PUS_Stat"] != DBNull.Value) pU_SMain.PUS_Stat = Convert.ToString(dr["PUS_Stat"]);
            if (dr["PUS_Spec"] != DBNull.Value) pU_SMain.PUS_Spec = Convert.ToString(dr["PUS_Spec"]);
            if (dr["PUS_PDate"] != DBNull.Value) pU_SMain.PUS_PDate = Convert.ToDateTime(dr["PUS_PDate"]);
            if (dr["PUS_IDate"] != DBNull.Value) pU_SMain.PUS_IDate = Convert.ToDateTime(dr["PUS_IDate"]);
            if (dr["PUS_RDate"] != DBNull.Value) pU_SMain.PUS_RDate = Convert.ToDateTime(dr["PUS_RDate"]);
            if (dr["PUS_WOwner"] != DBNull.Value) pU_SMain.PUS_WOwner = Convert.ToString(dr["PUS_WOwner"]);
            if (dr["PUS_BOwner"] != DBNull.Value) pU_SMain.PUS_BOwner = Convert.ToString(dr["PUS_BOwner"]);
            if (dr["PUS_TranFee"] != DBNull.Value) pU_SMain.PUS_TranFee = Convert.ToDecimal(dr["PUS_TranFee"]);
            if (dr["PUS_Price"] != DBNull.Value) pU_SMain.PUS_Price = Convert.ToDecimal(dr["PUS_Price"]);
            if (dr["PUS_Sum"] != DBNull.Value) pU_SMain.PUS_Sum = Convert.ToDecimal(dr["PUS_Sum"]);
            if (dr["PUS_RefType"] != DBNull.Value) pU_SMain.PUS_RefType = Convert.ToString(dr["PUS_RefType"]);
            if (dr["PUS_RefCode"] != DBNull.Value) pU_SMain.PUS_RefCode = Convert.ToString(dr["PUS_RefCode"]);
            if (dr["PUS_SupType"] != DBNull.Value) pU_SMain.PUS_SupType = Convert.ToString(dr["PUS_SupType"]);
            if (dr["PUS_UDef1"] != DBNull.Value) pU_SMain.PUS_UDef1 = Convert.ToString(dr["PUS_UDef1"]);
            if (dr["PUS_UDef2"] != DBNull.Value) pU_SMain.PUS_UDef2 = Convert.ToString(dr["PUS_UDef2"]);
            if (dr["PUS_UDef3"] != DBNull.Value) pU_SMain.PUS_UDef3 = Convert.ToString(dr["PUS_UDef3"]);
            if (dr["PUS_UDef4"] != DBNull.Value) pU_SMain.PUS_UDef4 = Convert.ToString(dr["PUS_UDef4"]);
            if (dr["PUS_UDef5"] != DBNull.Value) pU_SMain.PUS_UDef5 = Convert.ToString(dr["PUS_UDef5"]);
            if (dr["PUS_UDef6"] != DBNull.Value) pU_SMain.PUS_UDef6 = Convert.ToString(dr["PUS_UDef6"]);
            if (dr["PUS_UDef7"] != DBNull.Value) pU_SMain.PUS_UDef7 = Convert.ToString(dr["PUS_UDef7"]);
            if (dr["PUS_Remark"] != DBNull.Value) pU_SMain.PUS_Remark = Convert.ToString(dr["PUS_Remark"]);
            if (dr["Stat"] != DBNull.Value) pU_SMain.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["CreateDate"] != DBNull.Value) pU_SMain.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
            if (dr["UpdateDate"] != DBNull.Value) pU_SMain.UpdateDate = Convert.ToDateTime(dr["UpdateDate"]);
            if (dr["DeleteDate"] != DBNull.Value) pU_SMain.DeleteDate = Convert.ToDateTime(dr["DeleteDate"]);
            if (dr["AuditStat"] != DBNull.Value) pU_SMain.AuditStat = Convert.ToString(dr["AuditStat"]);
            if (dr["AuditCurAudit"] != DBNull.Value) pU_SMain.AuditCurAudit = Convert.ToString(dr["AuditCurAudit"]);
            ret.Add(pU_SMain);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   }  
         return ret;
      }
      /// <summary>
      /// 获取所有的PU_SMain对象(即:一条记录
      /// </summary>
      public List<PU_SMain> GetAll()
      {
         List<PU_SMain> ret = new List<PU_SMain>();
         string sql = "SELECT  PUS_ID,PUS_Type,PUS_RCode,PUS_Company,PUS_CompanyName,PUS_Dept,PUS_MCode,PUS_MName,PUS_Owner,PUS_Num,PUS_Unit,PUS_Units,PUS_Stat,PUS_Spec,PUS_PDate,PUS_IDate,PUS_RDate,PUS_WOwner,PUS_BOwner,PUS_TranFee,PUS_Price,PUS_Sum,PUS_RefType,PUS_RefCode,PUS_SupType,PUS_UDef1,PUS_UDef2,PUS_UDef3,PUS_UDef4,PUS_UDef5,PUS_UDef6,PUS_UDef7,PUS_Remark,Stat,CreateDate,UpdateDate,DeleteDate,AuditStat,AuditCurAudit FROM PU_SMain where 1=1 AND ((Stat is null) or (Stat=0) ) order by PUS_ID desc ";
          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            PU_SMain pU_SMain = new PU_SMain();
            if (dr["PUS_ID"] != DBNull.Value) pU_SMain.PUS_ID = Convert.ToDecimal(dr["PUS_ID"]);
            if (dr["PUS_Type"] != DBNull.Value) pU_SMain.PUS_Type = Convert.ToString(dr["PUS_Type"]);
            if (dr["PUS_RCode"] != DBNull.Value) pU_SMain.PUS_RCode = Convert.ToString(dr["PUS_RCode"]);
            if (dr["PUS_Company"] != DBNull.Value) pU_SMain.PUS_Company = Convert.ToString(dr["PUS_Company"]);
            if (dr["PUS_CompanyName"] != DBNull.Value) pU_SMain.PUS_CompanyName = Convert.ToString(dr["PUS_CompanyName"]);
            if (dr["PUS_Dept"] != DBNull.Value) pU_SMain.PUS_Dept = Convert.ToString(dr["PUS_Dept"]);
            if (dr["PUS_MCode"] != DBNull.Value) pU_SMain.PUS_MCode = Convert.ToString(dr["PUS_MCode"]);
            if (dr["PUS_MName"] != DBNull.Value) pU_SMain.PUS_MName = Convert.ToString(dr["PUS_MName"]);
            if (dr["PUS_Owner"] != DBNull.Value) pU_SMain.PUS_Owner = Convert.ToString(dr["PUS_Owner"]);
            if (dr["PUS_Num"] != DBNull.Value) pU_SMain.PUS_Num = Convert.ToDecimal(dr["PUS_Num"]);
            if (dr["PUS_Unit"] != DBNull.Value) pU_SMain.PUS_Unit = Convert.ToString(dr["PUS_Unit"]);
            if (dr["PUS_Units"] != DBNull.Value) pU_SMain.PUS_Units = Convert.ToString(dr["PUS_Units"]);
            if (dr["PUS_Stat"] != DBNull.Value) pU_SMain.PUS_Stat = Convert.ToString(dr["PUS_Stat"]);
            if (dr["PUS_Spec"] != DBNull.Value) pU_SMain.PUS_Spec = Convert.ToString(dr["PUS_Spec"]);
            if (dr["PUS_PDate"] != DBNull.Value) pU_SMain.PUS_PDate = Convert.ToDateTime(dr["PUS_PDate"]);
            if (dr["PUS_IDate"] != DBNull.Value) pU_SMain.PUS_IDate = Convert.ToDateTime(dr["PUS_IDate"]);
            if (dr["PUS_RDate"] != DBNull.Value) pU_SMain.PUS_RDate = Convert.ToDateTime(dr["PUS_RDate"]);
            if (dr["PUS_WOwner"] != DBNull.Value) pU_SMain.PUS_WOwner = Convert.ToString(dr["PUS_WOwner"]);
            if (dr["PUS_BOwner"] != DBNull.Value) pU_SMain.PUS_BOwner = Convert.ToString(dr["PUS_BOwner"]);
            if (dr["PUS_TranFee"] != DBNull.Value) pU_SMain.PUS_TranFee = Convert.ToDecimal(dr["PUS_TranFee"]);
            if (dr["PUS_Price"] != DBNull.Value) pU_SMain.PUS_Price = Convert.ToDecimal(dr["PUS_Price"]);
            if (dr["PUS_Sum"] != DBNull.Value) pU_SMain.PUS_Sum = Convert.ToDecimal(dr["PUS_Sum"]);
            if (dr["PUS_RefType"] != DBNull.Value) pU_SMain.PUS_RefType = Convert.ToString(dr["PUS_RefType"]);
            if (dr["PUS_RefCode"] != DBNull.Value) pU_SMain.PUS_RefCode = Convert.ToString(dr["PUS_RefCode"]);
            if (dr["PUS_SupType"] != DBNull.Value) pU_SMain.PUS_SupType = Convert.ToString(dr["PUS_SupType"]);
            if (dr["PUS_UDef1"] != DBNull.Value) pU_SMain.PUS_UDef1 = Convert.ToString(dr["PUS_UDef1"]);
            if (dr["PUS_UDef2"] != DBNull.Value) pU_SMain.PUS_UDef2 = Convert.ToString(dr["PUS_UDef2"]);
            if (dr["PUS_UDef3"] != DBNull.Value) pU_SMain.PUS_UDef3 = Convert.ToString(dr["PUS_UDef3"]);
            if (dr["PUS_UDef4"] != DBNull.Value) pU_SMain.PUS_UDef4 = Convert.ToString(dr["PUS_UDef4"]);
            if (dr["PUS_UDef5"] != DBNull.Value) pU_SMain.PUS_UDef5 = Convert.ToString(dr["PUS_UDef5"]);
            if (dr["PUS_UDef6"] != DBNull.Value) pU_SMain.PUS_UDef6 = Convert.ToString(dr["PUS_UDef6"]);
            if (dr["PUS_UDef7"] != DBNull.Value) pU_SMain.PUS_UDef7 = Convert.ToString(dr["PUS_UDef7"]);
            if (dr["PUS_Remark"] != DBNull.Value) pU_SMain.PUS_Remark = Convert.ToString(dr["PUS_Remark"]);
            if (dr["Stat"] != DBNull.Value) pU_SMain.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["CreateDate"] != DBNull.Value) pU_SMain.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
            if (dr["UpdateDate"] != DBNull.Value) pU_SMain.UpdateDate = Convert.ToDateTime(dr["UpdateDate"]);
            if (dr["DeleteDate"] != DBNull.Value) pU_SMain.DeleteDate = Convert.ToDateTime(dr["DeleteDate"]);
            if (dr["AuditStat"] != DBNull.Value) pU_SMain.AuditStat = Convert.ToString(dr["AuditStat"]);
            if (dr["AuditCurAudit"] != DBNull.Value) pU_SMain.AuditCurAudit = Convert.ToString(dr["AuditCurAudit"]);
            ret.Add(pU_SMain);
         }
          }catch (System.Exception ex){ throw ex; }  finally {  if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   } 
         return ret;
      }
   }
}
