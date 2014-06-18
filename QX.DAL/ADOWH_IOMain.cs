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
   /// 物料出库主表
   /// </summary>
   [Serializable]
   public partial class ADOWH_IOMain
   {
      public IDBOperator idb =  DBOperator.GetInstance();
      /// <summary>
      /// 添加物料出库主表 WH_IOMain对象(即:一条记录)
      /// </summary>
      public int Add(WH_IOMain wH_IOMain)
      {
         string sql = "INSERT INTO WH_IOMain (WHIOM_Type,WHIOM_Code,WHIOM_Title,WHIOM_CompanyCode,WHIOM_Company,WHIOM_DepartmentCode,WHIOM_Department,WHIOM_Owner,WHIOM_State,WHIOM_PDate,WHIOM_IDate,WHIOM_RDate,WHIOM_WOwner,WHIOM_BOwner,WHIOM_TranFee,WHIOM_DisCount,WHIOM_DisSum,WHIOM_Tax,WHIOM_Sum,WHIOM_Project,WHIOM_RefType,WHIOM_RefCode,WHIOM_Bak,Stat,CreateDate,UpdateDate,DeleteDate,AuditStat,AuditCurAudit,WHIOM_IType,WHIOM_UDEF1,WHIOM_UDEF2,WHIOM_UDEF3,WHIOM_UDEF4,WHIOM_UDEF5,WHIOM_UDEF6,WHIOM_UDEF7,WHIOM_UDEF8,WHIOM_UDEF9,WHIOM_UDEF10,WHIOM_Operator,WHIOM_OCode,WHIOM_OpDate,WHIOM_OwnerCode) VALUES (@WHIOM_Type,@WHIOM_Code,@WHIOM_Title,@WHIOM_CompanyCode,@WHIOM_Company,@WHIOM_DepartmentCode,@WHIOM_Department,@WHIOM_Owner,@WHIOM_State,@WHIOM_PDate,@WHIOM_IDate,@WHIOM_RDate,@WHIOM_WOwner,@WHIOM_BOwner,@WHIOM_TranFee,@WHIOM_DisCount,@WHIOM_DisSum,@WHIOM_Tax,@WHIOM_Sum,@WHIOM_Project,@WHIOM_RefType,@WHIOM_RefCode,@WHIOM_Bak,@Stat,@CreateDate,@UpdateDate,@DeleteDate,@AuditStat,@AuditCurAudit,@WHIOM_IType,@WHIOM_UDEF1,@WHIOM_UDEF2,@WHIOM_UDEF3,@WHIOM_UDEF4,@WHIOM_UDEF5,@WHIOM_UDEF6,@WHIOM_UDEF7,@WHIOM_UDEF8,@WHIOM_UDEF9,@WHIOM_UDEF10,@WHIOM_Operator,@WHIOM_OCode,@WHIOM_OpDate,@WHIOM_OwnerCode)";
         if (string.IsNullOrEmpty(wH_IOMain.WHIOM_Type))
         {
            idb.AddParameter("@WHIOM_Type", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHIOM_Type", wH_IOMain.WHIOM_Type);
         }
         if (string.IsNullOrEmpty(wH_IOMain.WHIOM_Code))
         {
            idb.AddParameter("@WHIOM_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHIOM_Code", wH_IOMain.WHIOM_Code);
         }
         if (string.IsNullOrEmpty(wH_IOMain.WHIOM_Title))
         {
            idb.AddParameter("@WHIOM_Title", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHIOM_Title", wH_IOMain.WHIOM_Title);
         }
         if (string.IsNullOrEmpty(wH_IOMain.WHIOM_CompanyCode))
         {
            idb.AddParameter("@WHIOM_CompanyCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHIOM_CompanyCode", wH_IOMain.WHIOM_CompanyCode);
         }
         if (string.IsNullOrEmpty(wH_IOMain.WHIOM_Company))
         {
            idb.AddParameter("@WHIOM_Company", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHIOM_Company", wH_IOMain.WHIOM_Company);
         }
         if (string.IsNullOrEmpty(wH_IOMain.WHIOM_DepartmentCode))
         {
            idb.AddParameter("@WHIOM_DepartmentCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHIOM_DepartmentCode", wH_IOMain.WHIOM_DepartmentCode);
         }
         if (string.IsNullOrEmpty(wH_IOMain.WHIOM_Department))
         {
            idb.AddParameter("@WHIOM_Department", "''");
         }
         else
         {
            idb.AddParameter("@WHIOM_Department", wH_IOMain.WHIOM_Department);
         }
         if (string.IsNullOrEmpty(wH_IOMain.WHIOM_Owner))
         {
            idb.AddParameter("@WHIOM_Owner", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHIOM_Owner", wH_IOMain.WHIOM_Owner);
         }
         if (string.IsNullOrEmpty(wH_IOMain.WHIOM_State))
         {
            idb.AddParameter("@WHIOM_State", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHIOM_State", wH_IOMain.WHIOM_State);
         }
         if (wH_IOMain.WHIOM_PDate == DateTime.MinValue)
         {
            idb.AddParameter("@WHIOM_PDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHIOM_PDate", wH_IOMain.WHIOM_PDate);
         }
         if (wH_IOMain.WHIOM_IDate == DateTime.MinValue)
         {
            idb.AddParameter("@WHIOM_IDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHIOM_IDate", wH_IOMain.WHIOM_IDate);
         }
         if (wH_IOMain.WHIOM_RDate == DateTime.MinValue)
         {
            idb.AddParameter("@WHIOM_RDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHIOM_RDate", wH_IOMain.WHIOM_RDate);
         }
         if (string.IsNullOrEmpty(wH_IOMain.WHIOM_WOwner))
         {
            idb.AddParameter("@WHIOM_WOwner", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHIOM_WOwner", wH_IOMain.WHIOM_WOwner);
         }
         if (string.IsNullOrEmpty(wH_IOMain.WHIOM_BOwner))
         {
            idb.AddParameter("@WHIOM_BOwner", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHIOM_BOwner", wH_IOMain.WHIOM_BOwner);
         }
         if (wH_IOMain.WHIOM_TranFee == 0)
         {
            idb.AddParameter("@WHIOM_TranFee", 0);
         }
         else
         {
            idb.AddParameter("@WHIOM_TranFee", wH_IOMain.WHIOM_TranFee);
         }
         if (wH_IOMain.WHIOM_DisCount == 0)
         {
            idb.AddParameter("@WHIOM_DisCount", 0);
         }
         else
         {
            idb.AddParameter("@WHIOM_DisCount", wH_IOMain.WHIOM_DisCount);
         }
         if (wH_IOMain.WHIOM_DisSum == 0)
         {
            idb.AddParameter("@WHIOM_DisSum", 0);
         }
         else
         {
            idb.AddParameter("@WHIOM_DisSum", wH_IOMain.WHIOM_DisSum);
         }
         if (wH_IOMain.WHIOM_Tax == 0)
         {
            idb.AddParameter("@WHIOM_Tax", 0);
         }
         else
         {
            idb.AddParameter("@WHIOM_Tax", wH_IOMain.WHIOM_Tax);
         }
         if (wH_IOMain.WHIOM_Sum == 0)
         {
            idb.AddParameter("@WHIOM_Sum", 0);
         }
         else
         {
            idb.AddParameter("@WHIOM_Sum", wH_IOMain.WHIOM_Sum);
         }
         if (string.IsNullOrEmpty(wH_IOMain.WHIOM_Project))
         {
            idb.AddParameter("@WHIOM_Project", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHIOM_Project", wH_IOMain.WHIOM_Project);
         }
         if (string.IsNullOrEmpty(wH_IOMain.WHIOM_RefType))
         {
            idb.AddParameter("@WHIOM_RefType", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHIOM_RefType", wH_IOMain.WHIOM_RefType);
         }
         if (string.IsNullOrEmpty(wH_IOMain.WHIOM_RefCode))
         {
            idb.AddParameter("@WHIOM_RefCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHIOM_RefCode", wH_IOMain.WHIOM_RefCode);
         }
         if (string.IsNullOrEmpty(wH_IOMain.WHIOM_Bak))
         {
            idb.AddParameter("@WHIOM_Bak", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHIOM_Bak", wH_IOMain.WHIOM_Bak);
         }
         if (wH_IOMain.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", wH_IOMain.Stat);
         }
         if (wH_IOMain.CreateDate == DateTime.MinValue)
         {
            idb.AddParameter("@CreateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateDate", wH_IOMain.CreateDate);
         }
         if (wH_IOMain.UpdateDate == DateTime.MinValue)
         {
            idb.AddParameter("@UpdateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@UpdateDate", wH_IOMain.UpdateDate);
         }
         if (wH_IOMain.DeleteDate == DateTime.MinValue)
         {
            idb.AddParameter("@DeleteDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DeleteDate", wH_IOMain.DeleteDate);
         }
         if (string.IsNullOrEmpty(wH_IOMain.AuditStat))
         {
            idb.AddParameter("@AuditStat", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AuditStat", wH_IOMain.AuditStat);
         }
         if (string.IsNullOrEmpty(wH_IOMain.AuditCurAudit))
         {
            idb.AddParameter("@AuditCurAudit", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AuditCurAudit", wH_IOMain.AuditCurAudit);
         }
         if (string.IsNullOrEmpty(wH_IOMain.WHIOM_IType))
         {
            idb.AddParameter("@WHIOM_IType", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHIOM_IType", wH_IOMain.WHIOM_IType);
         }
         if (string.IsNullOrEmpty(wH_IOMain.WHIOM_UDEF1))
         {
            idb.AddParameter("@WHIOM_UDEF1", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHIOM_UDEF1", wH_IOMain.WHIOM_UDEF1);
         }
         if (string.IsNullOrEmpty(wH_IOMain.WHIOM_UDEF2))
         {
            idb.AddParameter("@WHIOM_UDEF2", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHIOM_UDEF2", wH_IOMain.WHIOM_UDEF2);
         }
         if (string.IsNullOrEmpty(wH_IOMain.WHIOM_UDEF3))
         {
            idb.AddParameter("@WHIOM_UDEF3", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHIOM_UDEF3", wH_IOMain.WHIOM_UDEF3);
         }
         if (string.IsNullOrEmpty(wH_IOMain.WHIOM_UDEF4))
         {
            idb.AddParameter("@WHIOM_UDEF4", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHIOM_UDEF4", wH_IOMain.WHIOM_UDEF4);
         }
         if (string.IsNullOrEmpty(wH_IOMain.WHIOM_UDEF5))
         {
            idb.AddParameter("@WHIOM_UDEF5", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHIOM_UDEF5", wH_IOMain.WHIOM_UDEF5);
         }
         if (string.IsNullOrEmpty(wH_IOMain.WHIOM_UDEF6))
         {
            idb.AddParameter("@WHIOM_UDEF6", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHIOM_UDEF6", wH_IOMain.WHIOM_UDEF6);
         }
         if (string.IsNullOrEmpty(wH_IOMain.WHIOM_UDEF7))
         {
            idb.AddParameter("@WHIOM_UDEF7", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHIOM_UDEF7", wH_IOMain.WHIOM_UDEF7);
         }
         if (string.IsNullOrEmpty(wH_IOMain.WHIOM_UDEF8))
         {
            idb.AddParameter("@WHIOM_UDEF8", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHIOM_UDEF8", wH_IOMain.WHIOM_UDEF8);
         }
         if (string.IsNullOrEmpty(wH_IOMain.WHIOM_UDEF9))
         {
            idb.AddParameter("@WHIOM_UDEF9", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHIOM_UDEF9", wH_IOMain.WHIOM_UDEF9);
         }
         if (string.IsNullOrEmpty(wH_IOMain.WHIOM_UDEF10))
         {
            idb.AddParameter("@WHIOM_UDEF10", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHIOM_UDEF10", wH_IOMain.WHIOM_UDEF10);
         }
         if (string.IsNullOrEmpty(wH_IOMain.WHIOM_Operator))
         {
            idb.AddParameter("@WHIOM_Operator", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHIOM_Operator", wH_IOMain.WHIOM_Operator);
         }
         if (string.IsNullOrEmpty(wH_IOMain.WHIOM_OCode))
         {
            idb.AddParameter("@WHIOM_OCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHIOM_OCode", wH_IOMain.WHIOM_OCode);
         }
         if (wH_IOMain.WHIOM_OpDate == DateTime.MinValue)
         {
            idb.AddParameter("@WHIOM_OpDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHIOM_OpDate", wH_IOMain.WHIOM_OpDate);
         }
         if (string.IsNullOrEmpty(wH_IOMain.WHIOM_OwnerCode))
         {
            idb.AddParameter("@WHIOM_OwnerCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHIOM_OwnerCode", wH_IOMain.WHIOM_OwnerCode);
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
      /// 添加物料出库主表 WH_IOMain对象(即:一条记录)
      /// </summary>
      public object AddWithReturn(WH_IOMain wH_IOMain)
      {
         string sql = "INSERT INTO WH_IOMain (WHIOM_Type,WHIOM_Code,WHIOM_Title,WHIOM_CompanyCode,WHIOM_Company,WHIOM_DepartmentCode,WHIOM_Department,WHIOM_Owner,WHIOM_State,WHIOM_PDate,WHIOM_IDate,WHIOM_RDate,WHIOM_WOwner,WHIOM_BOwner,WHIOM_TranFee,WHIOM_DisCount,WHIOM_DisSum,WHIOM_Tax,WHIOM_Sum,WHIOM_Project,WHIOM_RefType,WHIOM_RefCode,WHIOM_Bak,Stat,CreateDate,UpdateDate,DeleteDate,AuditStat,AuditCurAudit,WHIOM_IType,WHIOM_UDEF1,WHIOM_UDEF2,WHIOM_UDEF3,WHIOM_UDEF4,WHIOM_UDEF5,WHIOM_UDEF6,WHIOM_UDEF7,WHIOM_UDEF8,WHIOM_UDEF9,WHIOM_UDEF10,WHIOM_Operator,WHIOM_OCode,WHIOM_OpDate,WHIOM_OwnerCode) VALUES (@WHIOM_Type,@WHIOM_Code,@WHIOM_Title,@WHIOM_CompanyCode,@WHIOM_Company,@WHIOM_DepartmentCode,@WHIOM_Department,@WHIOM_Owner,@WHIOM_State,@WHIOM_PDate,@WHIOM_IDate,@WHIOM_RDate,@WHIOM_WOwner,@WHIOM_BOwner,@WHIOM_TranFee,@WHIOM_DisCount,@WHIOM_DisSum,@WHIOM_Tax,@WHIOM_Sum,@WHIOM_Project,@WHIOM_RefType,@WHIOM_RefCode,@WHIOM_Bak,@Stat,@CreateDate,@UpdateDate,@DeleteDate,@AuditStat,@AuditCurAudit,@WHIOM_IType,@WHIOM_UDEF1,@WHIOM_UDEF2,@WHIOM_UDEF3,@WHIOM_UDEF4,@WHIOM_UDEF5,@WHIOM_UDEF6,@WHIOM_UDEF7,@WHIOM_UDEF8,@WHIOM_UDEF9,@WHIOM_UDEF10,@WHIOM_Operator,@WHIOM_OCode,@WHIOM_OpDate,@WHIOM_OwnerCode);SELECT @@IDENTITY AS ReturnID;";
         if (string.IsNullOrEmpty(wH_IOMain.WHIOM_Type))
         {
            idb.AddParameter("@WHIOM_Type", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHIOM_Type", wH_IOMain.WHIOM_Type);
         }
         if (string.IsNullOrEmpty(wH_IOMain.WHIOM_Code))
         {
            idb.AddParameter("@WHIOM_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHIOM_Code", wH_IOMain.WHIOM_Code);
         }
         if (string.IsNullOrEmpty(wH_IOMain.WHIOM_Title))
         {
            idb.AddParameter("@WHIOM_Title", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHIOM_Title", wH_IOMain.WHIOM_Title);
         }
         if (string.IsNullOrEmpty(wH_IOMain.WHIOM_CompanyCode))
         {
            idb.AddParameter("@WHIOM_CompanyCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHIOM_CompanyCode", wH_IOMain.WHIOM_CompanyCode);
         }
         if (string.IsNullOrEmpty(wH_IOMain.WHIOM_Company))
         {
            idb.AddParameter("@WHIOM_Company", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHIOM_Company", wH_IOMain.WHIOM_Company);
         }
         if (string.IsNullOrEmpty(wH_IOMain.WHIOM_DepartmentCode))
         {
            idb.AddParameter("@WHIOM_DepartmentCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHIOM_DepartmentCode", wH_IOMain.WHIOM_DepartmentCode);
         }
         if (string.IsNullOrEmpty(wH_IOMain.WHIOM_Department))
         {
            idb.AddParameter("@WHIOM_Department", "''");
         }
         else
         {
            idb.AddParameter("@WHIOM_Department", wH_IOMain.WHIOM_Department);
         }
         if (string.IsNullOrEmpty(wH_IOMain.WHIOM_Owner))
         {
            idb.AddParameter("@WHIOM_Owner", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHIOM_Owner", wH_IOMain.WHIOM_Owner);
         }
         if (string.IsNullOrEmpty(wH_IOMain.WHIOM_State))
         {
            idb.AddParameter("@WHIOM_State", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHIOM_State", wH_IOMain.WHIOM_State);
         }
         if (wH_IOMain.WHIOM_PDate == DateTime.MinValue)
         {
            idb.AddParameter("@WHIOM_PDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHIOM_PDate", wH_IOMain.WHIOM_PDate);
         }
         if (wH_IOMain.WHIOM_IDate == DateTime.MinValue)
         {
            idb.AddParameter("@WHIOM_IDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHIOM_IDate", wH_IOMain.WHIOM_IDate);
         }
         if (wH_IOMain.WHIOM_RDate == DateTime.MinValue)
         {
            idb.AddParameter("@WHIOM_RDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHIOM_RDate", wH_IOMain.WHIOM_RDate);
         }
         if (string.IsNullOrEmpty(wH_IOMain.WHIOM_WOwner))
         {
            idb.AddParameter("@WHIOM_WOwner", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHIOM_WOwner", wH_IOMain.WHIOM_WOwner);
         }
         if (string.IsNullOrEmpty(wH_IOMain.WHIOM_BOwner))
         {
            idb.AddParameter("@WHIOM_BOwner", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHIOM_BOwner", wH_IOMain.WHIOM_BOwner);
         }
         if (wH_IOMain.WHIOM_TranFee == 0)
         {
            idb.AddParameter("@WHIOM_TranFee", 0);
         }
         else
         {
            idb.AddParameter("@WHIOM_TranFee", wH_IOMain.WHIOM_TranFee);
         }
         if (wH_IOMain.WHIOM_DisCount == 0)
         {
            idb.AddParameter("@WHIOM_DisCount", 0);
         }
         else
         {
            idb.AddParameter("@WHIOM_DisCount", wH_IOMain.WHIOM_DisCount);
         }
         if (wH_IOMain.WHIOM_DisSum == 0)
         {
            idb.AddParameter("@WHIOM_DisSum", 0);
         }
         else
         {
            idb.AddParameter("@WHIOM_DisSum", wH_IOMain.WHIOM_DisSum);
         }
         if (wH_IOMain.WHIOM_Tax == 0)
         {
            idb.AddParameter("@WHIOM_Tax", 0);
         }
         else
         {
            idb.AddParameter("@WHIOM_Tax", wH_IOMain.WHIOM_Tax);
         }
         if (wH_IOMain.WHIOM_Sum == 0)
         {
            idb.AddParameter("@WHIOM_Sum", 0);
         }
         else
         {
            idb.AddParameter("@WHIOM_Sum", wH_IOMain.WHIOM_Sum);
         }
         if (string.IsNullOrEmpty(wH_IOMain.WHIOM_Project))
         {
            idb.AddParameter("@WHIOM_Project", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHIOM_Project", wH_IOMain.WHIOM_Project);
         }
         if (string.IsNullOrEmpty(wH_IOMain.WHIOM_RefType))
         {
            idb.AddParameter("@WHIOM_RefType", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHIOM_RefType", wH_IOMain.WHIOM_RefType);
         }
         if (string.IsNullOrEmpty(wH_IOMain.WHIOM_RefCode))
         {
            idb.AddParameter("@WHIOM_RefCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHIOM_RefCode", wH_IOMain.WHIOM_RefCode);
         }
         if (string.IsNullOrEmpty(wH_IOMain.WHIOM_Bak))
         {
            idb.AddParameter("@WHIOM_Bak", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHIOM_Bak", wH_IOMain.WHIOM_Bak);
         }
         if (wH_IOMain.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", wH_IOMain.Stat);
         }
         if (wH_IOMain.CreateDate == DateTime.MinValue)
         {
            idb.AddParameter("@CreateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateDate", wH_IOMain.CreateDate);
         }
         if (wH_IOMain.UpdateDate == DateTime.MinValue)
         {
            idb.AddParameter("@UpdateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@UpdateDate", wH_IOMain.UpdateDate);
         }
         if (wH_IOMain.DeleteDate == DateTime.MinValue)
         {
            idb.AddParameter("@DeleteDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DeleteDate", wH_IOMain.DeleteDate);
         }
         if (string.IsNullOrEmpty(wH_IOMain.AuditStat))
         {
            idb.AddParameter("@AuditStat", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AuditStat", wH_IOMain.AuditStat);
         }
         if (string.IsNullOrEmpty(wH_IOMain.AuditCurAudit))
         {
            idb.AddParameter("@AuditCurAudit", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AuditCurAudit", wH_IOMain.AuditCurAudit);
         }
         if (string.IsNullOrEmpty(wH_IOMain.WHIOM_IType))
         {
            idb.AddParameter("@WHIOM_IType", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHIOM_IType", wH_IOMain.WHIOM_IType);
         }
         if (string.IsNullOrEmpty(wH_IOMain.WHIOM_UDEF1))
         {
            idb.AddParameter("@WHIOM_UDEF1", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHIOM_UDEF1", wH_IOMain.WHIOM_UDEF1);
         }
         if (string.IsNullOrEmpty(wH_IOMain.WHIOM_UDEF2))
         {
            idb.AddParameter("@WHIOM_UDEF2", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHIOM_UDEF2", wH_IOMain.WHIOM_UDEF2);
         }
         if (string.IsNullOrEmpty(wH_IOMain.WHIOM_UDEF3))
         {
            idb.AddParameter("@WHIOM_UDEF3", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHIOM_UDEF3", wH_IOMain.WHIOM_UDEF3);
         }
         if (string.IsNullOrEmpty(wH_IOMain.WHIOM_UDEF4))
         {
            idb.AddParameter("@WHIOM_UDEF4", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHIOM_UDEF4", wH_IOMain.WHIOM_UDEF4);
         }
         if (string.IsNullOrEmpty(wH_IOMain.WHIOM_UDEF5))
         {
            idb.AddParameter("@WHIOM_UDEF5", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHIOM_UDEF5", wH_IOMain.WHIOM_UDEF5);
         }
         if (string.IsNullOrEmpty(wH_IOMain.WHIOM_UDEF6))
         {
            idb.AddParameter("@WHIOM_UDEF6", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHIOM_UDEF6", wH_IOMain.WHIOM_UDEF6);
         }
         if (string.IsNullOrEmpty(wH_IOMain.WHIOM_UDEF7))
         {
            idb.AddParameter("@WHIOM_UDEF7", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHIOM_UDEF7", wH_IOMain.WHIOM_UDEF7);
         }
         if (string.IsNullOrEmpty(wH_IOMain.WHIOM_UDEF8))
         {
            idb.AddParameter("@WHIOM_UDEF8", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHIOM_UDEF8", wH_IOMain.WHIOM_UDEF8);
         }
         if (string.IsNullOrEmpty(wH_IOMain.WHIOM_UDEF9))
         {
            idb.AddParameter("@WHIOM_UDEF9", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHIOM_UDEF9", wH_IOMain.WHIOM_UDEF9);
         }
         if (string.IsNullOrEmpty(wH_IOMain.WHIOM_UDEF10))
         {
            idb.AddParameter("@WHIOM_UDEF10", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHIOM_UDEF10", wH_IOMain.WHIOM_UDEF10);
         }
         if (string.IsNullOrEmpty(wH_IOMain.WHIOM_Operator))
         {
            idb.AddParameter("@WHIOM_Operator", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHIOM_Operator", wH_IOMain.WHIOM_Operator);
         }
         if (string.IsNullOrEmpty(wH_IOMain.WHIOM_OCode))
         {
            idb.AddParameter("@WHIOM_OCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHIOM_OCode", wH_IOMain.WHIOM_OCode);
         }
         if (wH_IOMain.WHIOM_OpDate == DateTime.MinValue)
         {
            idb.AddParameter("@WHIOM_OpDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHIOM_OpDate", wH_IOMain.WHIOM_OpDate);
         }
         if (string.IsNullOrEmpty(wH_IOMain.WHIOM_OwnerCode))
         {
            idb.AddParameter("@WHIOM_OwnerCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHIOM_OwnerCode", wH_IOMain.WHIOM_OwnerCode);
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
      /// 更新物料出库主表 WH_IOMain对象(即:一条记录
      /// </summary>
      public int Update(WH_IOMain wH_IOMain)
      {
         
         StringBuilder sbParameter=new StringBuilder();
      StringBuilder sb=new StringBuilder();
      sb.Append(@"UPDATE       WH_IOMain       SET ");
            if(wH_IOMain.WHIOM_Type_IsChanged){sbParameter.Append("WHIOM_Type=@WHIOM_Type, ");}
      if(wH_IOMain.WHIOM_Code_IsChanged){sbParameter.Append("WHIOM_Code=@WHIOM_Code, ");}
      if(wH_IOMain.WHIOM_Title_IsChanged){sbParameter.Append("WHIOM_Title=@WHIOM_Title, ");}
      if(wH_IOMain.WHIOM_CompanyCode_IsChanged){sbParameter.Append("WHIOM_CompanyCode=@WHIOM_CompanyCode, ");}
      if(wH_IOMain.WHIOM_Company_IsChanged){sbParameter.Append("WHIOM_Company=@WHIOM_Company, ");}
      if(wH_IOMain.WHIOM_DepartmentCode_IsChanged){sbParameter.Append("WHIOM_DepartmentCode=@WHIOM_DepartmentCode, ");}
      if(wH_IOMain.WHIOM_Department_IsChanged){sbParameter.Append("WHIOM_Department=@WHIOM_Department, ");}
      if(wH_IOMain.WHIOM_Owner_IsChanged){sbParameter.Append("WHIOM_Owner=@WHIOM_Owner, ");}
      if(wH_IOMain.WHIOM_State_IsChanged){sbParameter.Append("WHIOM_State=@WHIOM_State, ");}
      if(wH_IOMain.WHIOM_PDate_IsChanged){sbParameter.Append("WHIOM_PDate=@WHIOM_PDate, ");}
      if(wH_IOMain.WHIOM_IDate_IsChanged){sbParameter.Append("WHIOM_IDate=@WHIOM_IDate, ");}
      if(wH_IOMain.WHIOM_RDate_IsChanged){sbParameter.Append("WHIOM_RDate=@WHIOM_RDate, ");}
      if(wH_IOMain.WHIOM_WOwner_IsChanged){sbParameter.Append("WHIOM_WOwner=@WHIOM_WOwner, ");}
      if(wH_IOMain.WHIOM_BOwner_IsChanged){sbParameter.Append("WHIOM_BOwner=@WHIOM_BOwner, ");}
      if(wH_IOMain.WHIOM_TranFee_IsChanged){sbParameter.Append("WHIOM_TranFee=@WHIOM_TranFee, ");}
      if(wH_IOMain.WHIOM_DisCount_IsChanged){sbParameter.Append("WHIOM_DisCount=@WHIOM_DisCount, ");}
      if(wH_IOMain.WHIOM_DisSum_IsChanged){sbParameter.Append("WHIOM_DisSum=@WHIOM_DisSum, ");}
      if(wH_IOMain.WHIOM_Tax_IsChanged){sbParameter.Append("WHIOM_Tax=@WHIOM_Tax, ");}
      if(wH_IOMain.WHIOM_Sum_IsChanged){sbParameter.Append("WHIOM_Sum=@WHIOM_Sum, ");}
      if(wH_IOMain.WHIOM_Project_IsChanged){sbParameter.Append("WHIOM_Project=@WHIOM_Project, ");}
      if(wH_IOMain.WHIOM_RefType_IsChanged){sbParameter.Append("WHIOM_RefType=@WHIOM_RefType, ");}
      if(wH_IOMain.WHIOM_RefCode_IsChanged){sbParameter.Append("WHIOM_RefCode=@WHIOM_RefCode, ");}
      if(wH_IOMain.WHIOM_Bak_IsChanged){sbParameter.Append("WHIOM_Bak=@WHIOM_Bak, ");}
      if(wH_IOMain.Stat_IsChanged){sbParameter.Append("Stat=@Stat, ");}
      if(wH_IOMain.CreateDate_IsChanged){sbParameter.Append("CreateDate=@CreateDate, ");}
      if(wH_IOMain.UpdateDate_IsChanged){sbParameter.Append("UpdateDate=@UpdateDate, ");}
      if(wH_IOMain.DeleteDate_IsChanged){sbParameter.Append("DeleteDate=@DeleteDate, ");}
      if(wH_IOMain.AuditStat_IsChanged){sbParameter.Append("AuditStat=@AuditStat, ");}
      if(wH_IOMain.AuditCurAudit_IsChanged){sbParameter.Append("AuditCurAudit=@AuditCurAudit, ");}
      if(wH_IOMain.WHIOM_IType_IsChanged){sbParameter.Append("WHIOM_IType=@WHIOM_IType, ");}
      if(wH_IOMain.WHIOM_UDEF1_IsChanged){sbParameter.Append("WHIOM_UDEF1=@WHIOM_UDEF1, ");}
      if(wH_IOMain.WHIOM_UDEF2_IsChanged){sbParameter.Append("WHIOM_UDEF2=@WHIOM_UDEF2, ");}
      if(wH_IOMain.WHIOM_UDEF3_IsChanged){sbParameter.Append("WHIOM_UDEF3=@WHIOM_UDEF3, ");}
      if(wH_IOMain.WHIOM_UDEF4_IsChanged){sbParameter.Append("WHIOM_UDEF4=@WHIOM_UDEF4, ");}
      if(wH_IOMain.WHIOM_UDEF5_IsChanged){sbParameter.Append("WHIOM_UDEF5=@WHIOM_UDEF5, ");}
      if(wH_IOMain.WHIOM_UDEF6_IsChanged){sbParameter.Append("WHIOM_UDEF6=@WHIOM_UDEF6, ");}
      if(wH_IOMain.WHIOM_UDEF7_IsChanged){sbParameter.Append("WHIOM_UDEF7=@WHIOM_UDEF7, ");}
      if(wH_IOMain.WHIOM_UDEF8_IsChanged){sbParameter.Append("WHIOM_UDEF8=@WHIOM_UDEF8, ");}
      if(wH_IOMain.WHIOM_UDEF9_IsChanged){sbParameter.Append("WHIOM_UDEF9=@WHIOM_UDEF9, ");}
      if(wH_IOMain.WHIOM_UDEF10_IsChanged){sbParameter.Append("WHIOM_UDEF10=@WHIOM_UDEF10, ");}
      if(wH_IOMain.WHIOM_Operator_IsChanged){sbParameter.Append("WHIOM_Operator=@WHIOM_Operator, ");}
      if(wH_IOMain.WHIOM_OCode_IsChanged){sbParameter.Append("WHIOM_OCode=@WHIOM_OCode, ");}
      if(wH_IOMain.WHIOM_OpDate_IsChanged){sbParameter.Append("WHIOM_OpDate=@WHIOM_OpDate, ");}
      if(wH_IOMain.WHIOM_OwnerCode_IsChanged){sbParameter.Append("WHIOM_OwnerCode=@WHIOM_OwnerCode ");}          sb.Append(sbParameter.ToString().Trim().TrimEnd(',')); 
      sb.Append(      " WHERE 1=1 AND ((Stat is null) or (Stat=0))   and WHIOM_ID=@WHIOM_ID; " );
      string sql=sb.ToString();
         if(wH_IOMain.WHIOM_Type_IsChanged)
         {
         if (string.IsNullOrEmpty(wH_IOMain.WHIOM_Type))
         {
            idb.AddParameter("@WHIOM_Type", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHIOM_Type", wH_IOMain.WHIOM_Type);
         }
          }
         if(wH_IOMain.WHIOM_Code_IsChanged)
         {
         if (string.IsNullOrEmpty(wH_IOMain.WHIOM_Code))
         {
            idb.AddParameter("@WHIOM_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHIOM_Code", wH_IOMain.WHIOM_Code);
         }
          }
         if(wH_IOMain.WHIOM_Title_IsChanged)
         {
         if (string.IsNullOrEmpty(wH_IOMain.WHIOM_Title))
         {
            idb.AddParameter("@WHIOM_Title", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHIOM_Title", wH_IOMain.WHIOM_Title);
         }
          }
         if(wH_IOMain.WHIOM_CompanyCode_IsChanged)
         {
         if (string.IsNullOrEmpty(wH_IOMain.WHIOM_CompanyCode))
         {
            idb.AddParameter("@WHIOM_CompanyCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHIOM_CompanyCode", wH_IOMain.WHIOM_CompanyCode);
         }
          }
         if(wH_IOMain.WHIOM_Company_IsChanged)
         {
         if (string.IsNullOrEmpty(wH_IOMain.WHIOM_Company))
         {
            idb.AddParameter("@WHIOM_Company", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHIOM_Company", wH_IOMain.WHIOM_Company);
         }
          }
         if(wH_IOMain.WHIOM_DepartmentCode_IsChanged)
         {
         if (string.IsNullOrEmpty(wH_IOMain.WHIOM_DepartmentCode))
         {
            idb.AddParameter("@WHIOM_DepartmentCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHIOM_DepartmentCode", wH_IOMain.WHIOM_DepartmentCode);
         }
          }
         if(wH_IOMain.WHIOM_Department_IsChanged)
         {
         if (string.IsNullOrEmpty(wH_IOMain.WHIOM_Department))
         {
            idb.AddParameter("@WHIOM_Department", "''");
         }
         else
         {
            idb.AddParameter("@WHIOM_Department", wH_IOMain.WHIOM_Department);
         }
          }
         if(wH_IOMain.WHIOM_Owner_IsChanged)
         {
         if (string.IsNullOrEmpty(wH_IOMain.WHIOM_Owner))
         {
            idb.AddParameter("@WHIOM_Owner", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHIOM_Owner", wH_IOMain.WHIOM_Owner);
         }
          }
         if(wH_IOMain.WHIOM_State_IsChanged)
         {
         if (string.IsNullOrEmpty(wH_IOMain.WHIOM_State))
         {
            idb.AddParameter("@WHIOM_State", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHIOM_State", wH_IOMain.WHIOM_State);
         }
          }
         if(wH_IOMain.WHIOM_PDate_IsChanged)
         {
         if (wH_IOMain.WHIOM_PDate == DateTime.MinValue)
         {
            idb.AddParameter("@WHIOM_PDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHIOM_PDate", wH_IOMain.WHIOM_PDate);
         }
          }
         if(wH_IOMain.WHIOM_IDate_IsChanged)
         {
         if (wH_IOMain.WHIOM_IDate == DateTime.MinValue)
         {
            idb.AddParameter("@WHIOM_IDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHIOM_IDate", wH_IOMain.WHIOM_IDate);
         }
          }
         if(wH_IOMain.WHIOM_RDate_IsChanged)
         {
         if (wH_IOMain.WHIOM_RDate == DateTime.MinValue)
         {
            idb.AddParameter("@WHIOM_RDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHIOM_RDate", wH_IOMain.WHIOM_RDate);
         }
          }
         if(wH_IOMain.WHIOM_WOwner_IsChanged)
         {
         if (string.IsNullOrEmpty(wH_IOMain.WHIOM_WOwner))
         {
            idb.AddParameter("@WHIOM_WOwner", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHIOM_WOwner", wH_IOMain.WHIOM_WOwner);
         }
          }
         if(wH_IOMain.WHIOM_BOwner_IsChanged)
         {
         if (string.IsNullOrEmpty(wH_IOMain.WHIOM_BOwner))
         {
            idb.AddParameter("@WHIOM_BOwner", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHIOM_BOwner", wH_IOMain.WHIOM_BOwner);
         }
          }
         if(wH_IOMain.WHIOM_TranFee_IsChanged)
         {
         if (wH_IOMain.WHIOM_TranFee == 0)
         {
            idb.AddParameter("@WHIOM_TranFee", 0);
         }
         else
         {
            idb.AddParameter("@WHIOM_TranFee", wH_IOMain.WHIOM_TranFee);
         }
          }
         if(wH_IOMain.WHIOM_DisCount_IsChanged)
         {
         if (wH_IOMain.WHIOM_DisCount == 0)
         {
            idb.AddParameter("@WHIOM_DisCount", 0);
         }
         else
         {
            idb.AddParameter("@WHIOM_DisCount", wH_IOMain.WHIOM_DisCount);
         }
          }
         if(wH_IOMain.WHIOM_DisSum_IsChanged)
         {
         if (wH_IOMain.WHIOM_DisSum == 0)
         {
            idb.AddParameter("@WHIOM_DisSum", 0);
         }
         else
         {
            idb.AddParameter("@WHIOM_DisSum", wH_IOMain.WHIOM_DisSum);
         }
          }
         if(wH_IOMain.WHIOM_Tax_IsChanged)
         {
         if (wH_IOMain.WHIOM_Tax == 0)
         {
            idb.AddParameter("@WHIOM_Tax", 0);
         }
         else
         {
            idb.AddParameter("@WHIOM_Tax", wH_IOMain.WHIOM_Tax);
         }
          }
         if(wH_IOMain.WHIOM_Sum_IsChanged)
         {
         if (wH_IOMain.WHIOM_Sum == 0)
         {
            idb.AddParameter("@WHIOM_Sum", 0);
         }
         else
         {
            idb.AddParameter("@WHIOM_Sum", wH_IOMain.WHIOM_Sum);
         }
          }
         if(wH_IOMain.WHIOM_Project_IsChanged)
         {
         if (string.IsNullOrEmpty(wH_IOMain.WHIOM_Project))
         {
            idb.AddParameter("@WHIOM_Project", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHIOM_Project", wH_IOMain.WHIOM_Project);
         }
          }
         if(wH_IOMain.WHIOM_RefType_IsChanged)
         {
         if (string.IsNullOrEmpty(wH_IOMain.WHIOM_RefType))
         {
            idb.AddParameter("@WHIOM_RefType", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHIOM_RefType", wH_IOMain.WHIOM_RefType);
         }
          }
         if(wH_IOMain.WHIOM_RefCode_IsChanged)
         {
         if (string.IsNullOrEmpty(wH_IOMain.WHIOM_RefCode))
         {
            idb.AddParameter("@WHIOM_RefCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHIOM_RefCode", wH_IOMain.WHIOM_RefCode);
         }
          }
         if(wH_IOMain.WHIOM_Bak_IsChanged)
         {
         if (string.IsNullOrEmpty(wH_IOMain.WHIOM_Bak))
         {
            idb.AddParameter("@WHIOM_Bak", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHIOM_Bak", wH_IOMain.WHIOM_Bak);
         }
          }
         if(wH_IOMain.Stat_IsChanged)
         {
         if (wH_IOMain.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", wH_IOMain.Stat);
         }
          }
         if(wH_IOMain.CreateDate_IsChanged)
         {
         if (wH_IOMain.CreateDate == DateTime.MinValue)
         {
            idb.AddParameter("@CreateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateDate", wH_IOMain.CreateDate);
         }
          }
         if(wH_IOMain.UpdateDate_IsChanged)
         {
         if (wH_IOMain.UpdateDate == DateTime.MinValue)
         {
            idb.AddParameter("@UpdateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@UpdateDate", wH_IOMain.UpdateDate);
         }
          }
         if(wH_IOMain.DeleteDate_IsChanged)
         {
         if (wH_IOMain.DeleteDate == DateTime.MinValue)
         {
            idb.AddParameter("@DeleteDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DeleteDate", wH_IOMain.DeleteDate);
         }
          }
         if(wH_IOMain.AuditStat_IsChanged)
         {
         if (string.IsNullOrEmpty(wH_IOMain.AuditStat))
         {
            idb.AddParameter("@AuditStat", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AuditStat", wH_IOMain.AuditStat);
         }
          }
         if(wH_IOMain.AuditCurAudit_IsChanged)
         {
         if (string.IsNullOrEmpty(wH_IOMain.AuditCurAudit))
         {
            idb.AddParameter("@AuditCurAudit", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AuditCurAudit", wH_IOMain.AuditCurAudit);
         }
          }
         if(wH_IOMain.WHIOM_IType_IsChanged)
         {
         if (string.IsNullOrEmpty(wH_IOMain.WHIOM_IType))
         {
            idb.AddParameter("@WHIOM_IType", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHIOM_IType", wH_IOMain.WHIOM_IType);
         }
          }
         if(wH_IOMain.WHIOM_UDEF1_IsChanged)
         {
         if (string.IsNullOrEmpty(wH_IOMain.WHIOM_UDEF1))
         {
            idb.AddParameter("@WHIOM_UDEF1", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHIOM_UDEF1", wH_IOMain.WHIOM_UDEF1);
         }
          }
         if(wH_IOMain.WHIOM_UDEF2_IsChanged)
         {
         if (string.IsNullOrEmpty(wH_IOMain.WHIOM_UDEF2))
         {
            idb.AddParameter("@WHIOM_UDEF2", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHIOM_UDEF2", wH_IOMain.WHIOM_UDEF2);
         }
          }
         if(wH_IOMain.WHIOM_UDEF3_IsChanged)
         {
         if (string.IsNullOrEmpty(wH_IOMain.WHIOM_UDEF3))
         {
            idb.AddParameter("@WHIOM_UDEF3", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHIOM_UDEF3", wH_IOMain.WHIOM_UDEF3);
         }
          }
         if(wH_IOMain.WHIOM_UDEF4_IsChanged)
         {
         if (string.IsNullOrEmpty(wH_IOMain.WHIOM_UDEF4))
         {
            idb.AddParameter("@WHIOM_UDEF4", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHIOM_UDEF4", wH_IOMain.WHIOM_UDEF4);
         }
          }
         if(wH_IOMain.WHIOM_UDEF5_IsChanged)
         {
         if (string.IsNullOrEmpty(wH_IOMain.WHIOM_UDEF5))
         {
            idb.AddParameter("@WHIOM_UDEF5", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHIOM_UDEF5", wH_IOMain.WHIOM_UDEF5);
         }
          }
         if(wH_IOMain.WHIOM_UDEF6_IsChanged)
         {
         if (string.IsNullOrEmpty(wH_IOMain.WHIOM_UDEF6))
         {
            idb.AddParameter("@WHIOM_UDEF6", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHIOM_UDEF6", wH_IOMain.WHIOM_UDEF6);
         }
          }
         if(wH_IOMain.WHIOM_UDEF7_IsChanged)
         {
         if (string.IsNullOrEmpty(wH_IOMain.WHIOM_UDEF7))
         {
            idb.AddParameter("@WHIOM_UDEF7", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHIOM_UDEF7", wH_IOMain.WHIOM_UDEF7);
         }
          }
         if(wH_IOMain.WHIOM_UDEF8_IsChanged)
         {
         if (string.IsNullOrEmpty(wH_IOMain.WHIOM_UDEF8))
         {
            idb.AddParameter("@WHIOM_UDEF8", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHIOM_UDEF8", wH_IOMain.WHIOM_UDEF8);
         }
          }
         if(wH_IOMain.WHIOM_UDEF9_IsChanged)
         {
         if (string.IsNullOrEmpty(wH_IOMain.WHIOM_UDEF9))
         {
            idb.AddParameter("@WHIOM_UDEF9", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHIOM_UDEF9", wH_IOMain.WHIOM_UDEF9);
         }
          }
         if(wH_IOMain.WHIOM_UDEF10_IsChanged)
         {
         if (string.IsNullOrEmpty(wH_IOMain.WHIOM_UDEF10))
         {
            idb.AddParameter("@WHIOM_UDEF10", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHIOM_UDEF10", wH_IOMain.WHIOM_UDEF10);
         }
          }
         if(wH_IOMain.WHIOM_Operator_IsChanged)
         {
         if (string.IsNullOrEmpty(wH_IOMain.WHIOM_Operator))
         {
            idb.AddParameter("@WHIOM_Operator", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHIOM_Operator", wH_IOMain.WHIOM_Operator);
         }
          }
         if(wH_IOMain.WHIOM_OCode_IsChanged)
         {
         if (string.IsNullOrEmpty(wH_IOMain.WHIOM_OCode))
         {
            idb.AddParameter("@WHIOM_OCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHIOM_OCode", wH_IOMain.WHIOM_OCode);
         }
          }
         if(wH_IOMain.WHIOM_OpDate_IsChanged)
         {
         if (wH_IOMain.WHIOM_OpDate == DateTime.MinValue)
         {
            idb.AddParameter("@WHIOM_OpDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHIOM_OpDate", wH_IOMain.WHIOM_OpDate);
         }
          }
         if(wH_IOMain.WHIOM_OwnerCode_IsChanged)
         {
         if (string.IsNullOrEmpty(wH_IOMain.WHIOM_OwnerCode))
         {
            idb.AddParameter("@WHIOM_OwnerCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@WHIOM_OwnerCode", wH_IOMain.WHIOM_OwnerCode);
         }
          }

         idb.AddParameter("@WHIOM_ID", wH_IOMain.WHIOM_ID);

           
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
      /// 删除物料出库主表 WH_IOMain对象(即:一条记录
      /// </summary>
      public int Delete(decimal wHIOM_ID)
      {
         string sql = "DELETE WH_IOMain WHERE 1=1  AND WHIOM_ID=@WHIOM_ID ";
         idb.AddParameter("@WHIOM_ID", wHIOM_ID);

           
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
      /// 获取指定的物料出库主表 WH_IOMain对象(即:一条记录
      /// </summary>
      public WH_IOMain GetByKey(decimal wHIOM_ID)
      {
         WH_IOMain wH_IOMain = new WH_IOMain();
         string sql = "SELECT  WHIOM_ID,WHIOM_Type,WHIOM_Code,WHIOM_Title,WHIOM_CompanyCode,WHIOM_Company,WHIOM_DepartmentCode,WHIOM_Department,WHIOM_Owner,WHIOM_State,WHIOM_PDate,WHIOM_IDate,WHIOM_RDate,WHIOM_WOwner,WHIOM_BOwner,WHIOM_TranFee,WHIOM_DisCount,WHIOM_DisSum,WHIOM_Tax,WHIOM_Sum,WHIOM_Project,WHIOM_RefType,WHIOM_RefCode,WHIOM_Bak,Stat,CreateDate,UpdateDate,DeleteDate,AuditStat,AuditCurAudit,WHIOM_IType,WHIOM_UDEF1,WHIOM_UDEF2,WHIOM_UDEF3,WHIOM_UDEF4,WHIOM_UDEF5,WHIOM_UDEF6,WHIOM_UDEF7,WHIOM_UDEF8,WHIOM_UDEF9,WHIOM_UDEF10,WHIOM_Operator,WHIOM_OCode,WHIOM_OpDate,WHIOM_OwnerCode FROM WH_IOMain WHERE 1=1 AND ((Stat is null) or (Stat=0) )  AND WHIOM_ID=@WHIOM_ID ";
         idb.AddParameter("@WHIOM_ID", wHIOM_ID);

          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            if (dr["WHIOM_ID"] != DBNull.Value) wH_IOMain.WHIOM_ID = Convert.ToDecimal(dr["WHIOM_ID"]);
            if (dr["WHIOM_Type"] != DBNull.Value) wH_IOMain.WHIOM_Type = Convert.ToString(dr["WHIOM_Type"]);
            if (dr["WHIOM_Code"] != DBNull.Value) wH_IOMain.WHIOM_Code = Convert.ToString(dr["WHIOM_Code"]);
            if (dr["WHIOM_Title"] != DBNull.Value) wH_IOMain.WHIOM_Title = Convert.ToString(dr["WHIOM_Title"]);
            if (dr["WHIOM_CompanyCode"] != DBNull.Value) wH_IOMain.WHIOM_CompanyCode = Convert.ToString(dr["WHIOM_CompanyCode"]);
            if (dr["WHIOM_Company"] != DBNull.Value) wH_IOMain.WHIOM_Company = Convert.ToString(dr["WHIOM_Company"]);
            if (dr["WHIOM_DepartmentCode"] != DBNull.Value) wH_IOMain.WHIOM_DepartmentCode = Convert.ToString(dr["WHIOM_DepartmentCode"]);
            if (dr["WHIOM_Department"] != DBNull.Value) wH_IOMain.WHIOM_Department = Convert.ToString(dr["WHIOM_Department"]);
            if (dr["WHIOM_Owner"] != DBNull.Value) wH_IOMain.WHIOM_Owner = Convert.ToString(dr["WHIOM_Owner"]);
            if (dr["WHIOM_State"] != DBNull.Value) wH_IOMain.WHIOM_State = Convert.ToString(dr["WHIOM_State"]);
            if (dr["WHIOM_PDate"] != DBNull.Value) wH_IOMain.WHIOM_PDate = Convert.ToDateTime(dr["WHIOM_PDate"]);
            if (dr["WHIOM_IDate"] != DBNull.Value) wH_IOMain.WHIOM_IDate = Convert.ToDateTime(dr["WHIOM_IDate"]);
            if (dr["WHIOM_RDate"] != DBNull.Value) wH_IOMain.WHIOM_RDate = Convert.ToDateTime(dr["WHIOM_RDate"]);
            if (dr["WHIOM_WOwner"] != DBNull.Value) wH_IOMain.WHIOM_WOwner = Convert.ToString(dr["WHIOM_WOwner"]);
            if (dr["WHIOM_BOwner"] != DBNull.Value) wH_IOMain.WHIOM_BOwner = Convert.ToString(dr["WHIOM_BOwner"]);
            if (dr["WHIOM_TranFee"] != DBNull.Value) wH_IOMain.WHIOM_TranFee = Convert.ToDecimal(dr["WHIOM_TranFee"]);
            if (dr["WHIOM_DisCount"] != DBNull.Value) wH_IOMain.WHIOM_DisCount = Convert.ToDecimal(dr["WHIOM_DisCount"]);
            if (dr["WHIOM_DisSum"] != DBNull.Value) wH_IOMain.WHIOM_DisSum = Convert.ToDecimal(dr["WHIOM_DisSum"]);
            if (dr["WHIOM_Tax"] != DBNull.Value) wH_IOMain.WHIOM_Tax = Convert.ToDecimal(dr["WHIOM_Tax"]);
            if (dr["WHIOM_Sum"] != DBNull.Value) wH_IOMain.WHIOM_Sum = Convert.ToDecimal(dr["WHIOM_Sum"]);
            if (dr["WHIOM_Project"] != DBNull.Value) wH_IOMain.WHIOM_Project = Convert.ToString(dr["WHIOM_Project"]);
            if (dr["WHIOM_RefType"] != DBNull.Value) wH_IOMain.WHIOM_RefType = Convert.ToString(dr["WHIOM_RefType"]);
            if (dr["WHIOM_RefCode"] != DBNull.Value) wH_IOMain.WHIOM_RefCode = Convert.ToString(dr["WHIOM_RefCode"]);
            if (dr["WHIOM_Bak"] != DBNull.Value) wH_IOMain.WHIOM_Bak = Convert.ToString(dr["WHIOM_Bak"]);
            if (dr["Stat"] != DBNull.Value) wH_IOMain.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["CreateDate"] != DBNull.Value) wH_IOMain.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
            if (dr["UpdateDate"] != DBNull.Value) wH_IOMain.UpdateDate = Convert.ToDateTime(dr["UpdateDate"]);
            if (dr["DeleteDate"] != DBNull.Value) wH_IOMain.DeleteDate = Convert.ToDateTime(dr["DeleteDate"]);
            if (dr["AuditStat"] != DBNull.Value) wH_IOMain.AuditStat = Convert.ToString(dr["AuditStat"]);
            if (dr["AuditCurAudit"] != DBNull.Value) wH_IOMain.AuditCurAudit = Convert.ToString(dr["AuditCurAudit"]);
            if (dr["WHIOM_IType"] != DBNull.Value) wH_IOMain.WHIOM_IType = Convert.ToString(dr["WHIOM_IType"]);
            if (dr["WHIOM_UDEF1"] != DBNull.Value) wH_IOMain.WHIOM_UDEF1 = Convert.ToString(dr["WHIOM_UDEF1"]);
            if (dr["WHIOM_UDEF2"] != DBNull.Value) wH_IOMain.WHIOM_UDEF2 = Convert.ToString(dr["WHIOM_UDEF2"]);
            if (dr["WHIOM_UDEF3"] != DBNull.Value) wH_IOMain.WHIOM_UDEF3 = Convert.ToString(dr["WHIOM_UDEF3"]);
            if (dr["WHIOM_UDEF4"] != DBNull.Value) wH_IOMain.WHIOM_UDEF4 = Convert.ToString(dr["WHIOM_UDEF4"]);
            if (dr["WHIOM_UDEF5"] != DBNull.Value) wH_IOMain.WHIOM_UDEF5 = Convert.ToString(dr["WHIOM_UDEF5"]);
            if (dr["WHIOM_UDEF6"] != DBNull.Value) wH_IOMain.WHIOM_UDEF6 = Convert.ToString(dr["WHIOM_UDEF6"]);
            if (dr["WHIOM_UDEF7"] != DBNull.Value) wH_IOMain.WHIOM_UDEF7 = Convert.ToString(dr["WHIOM_UDEF7"]);
            if (dr["WHIOM_UDEF8"] != DBNull.Value) wH_IOMain.WHIOM_UDEF8 = Convert.ToString(dr["WHIOM_UDEF8"]);
            if (dr["WHIOM_UDEF9"] != DBNull.Value) wH_IOMain.WHIOM_UDEF9 = Convert.ToString(dr["WHIOM_UDEF9"]);
            if (dr["WHIOM_UDEF10"] != DBNull.Value) wH_IOMain.WHIOM_UDEF10 = Convert.ToString(dr["WHIOM_UDEF10"]);
            if (dr["WHIOM_Operator"] != DBNull.Value) wH_IOMain.WHIOM_Operator = Convert.ToString(dr["WHIOM_Operator"]);
            if (dr["WHIOM_OCode"] != DBNull.Value) wH_IOMain.WHIOM_OCode = Convert.ToString(dr["WHIOM_OCode"]);
            if (dr["WHIOM_OpDate"] != DBNull.Value) wH_IOMain.WHIOM_OpDate = Convert.ToDateTime(dr["WHIOM_OpDate"]);
            if (dr["WHIOM_OwnerCode"] != DBNull.Value) wH_IOMain.WHIOM_OwnerCode = Convert.ToString(dr["WHIOM_OwnerCode"]);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   }  
         return wH_IOMain;
      }
      /// <summary>
      /// 获取指定的物料出库主表 WH_IOMain对象集合
      /// </summary>
      public List<WH_IOMain> GetListByWhere(string strCondition)
      {
         List<WH_IOMain> ret = new List<WH_IOMain>();
         string sql = "SELECT  WHIOM_ID,WHIOM_Type,WHIOM_Code,WHIOM_Title,WHIOM_CompanyCode,WHIOM_Company,WHIOM_DepartmentCode,WHIOM_Department,WHIOM_Owner,WHIOM_State,WHIOM_PDate,WHIOM_IDate,WHIOM_RDate,WHIOM_WOwner,WHIOM_BOwner,WHIOM_TranFee,WHIOM_DisCount,WHIOM_DisSum,WHIOM_Tax,WHIOM_Sum,WHIOM_Project,WHIOM_RefType,WHIOM_RefCode,WHIOM_Bak,Stat,CreateDate,UpdateDate,DeleteDate,AuditStat,AuditCurAudit,WHIOM_IType,WHIOM_UDEF1,WHIOM_UDEF2,WHIOM_UDEF3,WHIOM_UDEF4,WHIOM_UDEF5,WHIOM_UDEF6,WHIOM_UDEF7,WHIOM_UDEF8,WHIOM_UDEF9,WHIOM_UDEF10,WHIOM_Operator,WHIOM_OCode,WHIOM_OpDate,WHIOM_OwnerCode FROM WH_IOMain WHERE 1=1 AND ((Stat is null) or (Stat=0) ) ";
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
            WH_IOMain wH_IOMain = new WH_IOMain();
            if (dr["WHIOM_ID"] != DBNull.Value) wH_IOMain.WHIOM_ID = Convert.ToDecimal(dr["WHIOM_ID"]);
            if (dr["WHIOM_Type"] != DBNull.Value) wH_IOMain.WHIOM_Type = Convert.ToString(dr["WHIOM_Type"]);
            if (dr["WHIOM_Code"] != DBNull.Value) wH_IOMain.WHIOM_Code = Convert.ToString(dr["WHIOM_Code"]);
            if (dr["WHIOM_Title"] != DBNull.Value) wH_IOMain.WHIOM_Title = Convert.ToString(dr["WHIOM_Title"]);
            if (dr["WHIOM_CompanyCode"] != DBNull.Value) wH_IOMain.WHIOM_CompanyCode = Convert.ToString(dr["WHIOM_CompanyCode"]);
            if (dr["WHIOM_Company"] != DBNull.Value) wH_IOMain.WHIOM_Company = Convert.ToString(dr["WHIOM_Company"]);
            if (dr["WHIOM_DepartmentCode"] != DBNull.Value) wH_IOMain.WHIOM_DepartmentCode = Convert.ToString(dr["WHIOM_DepartmentCode"]);
            if (dr["WHIOM_Department"] != DBNull.Value) wH_IOMain.WHIOM_Department = Convert.ToString(dr["WHIOM_Department"]);
            if (dr["WHIOM_Owner"] != DBNull.Value) wH_IOMain.WHIOM_Owner = Convert.ToString(dr["WHIOM_Owner"]);
            if (dr["WHIOM_State"] != DBNull.Value) wH_IOMain.WHIOM_State = Convert.ToString(dr["WHIOM_State"]);
            if (dr["WHIOM_PDate"] != DBNull.Value) wH_IOMain.WHIOM_PDate = Convert.ToDateTime(dr["WHIOM_PDate"]);
            if (dr["WHIOM_IDate"] != DBNull.Value) wH_IOMain.WHIOM_IDate = Convert.ToDateTime(dr["WHIOM_IDate"]);
            if (dr["WHIOM_RDate"] != DBNull.Value) wH_IOMain.WHIOM_RDate = Convert.ToDateTime(dr["WHIOM_RDate"]);
            if (dr["WHIOM_WOwner"] != DBNull.Value) wH_IOMain.WHIOM_WOwner = Convert.ToString(dr["WHIOM_WOwner"]);
            if (dr["WHIOM_BOwner"] != DBNull.Value) wH_IOMain.WHIOM_BOwner = Convert.ToString(dr["WHIOM_BOwner"]);
            if (dr["WHIOM_TranFee"] != DBNull.Value) wH_IOMain.WHIOM_TranFee = Convert.ToDecimal(dr["WHIOM_TranFee"]);
            if (dr["WHIOM_DisCount"] != DBNull.Value) wH_IOMain.WHIOM_DisCount = Convert.ToDecimal(dr["WHIOM_DisCount"]);
            if (dr["WHIOM_DisSum"] != DBNull.Value) wH_IOMain.WHIOM_DisSum = Convert.ToDecimal(dr["WHIOM_DisSum"]);
            if (dr["WHIOM_Tax"] != DBNull.Value) wH_IOMain.WHIOM_Tax = Convert.ToDecimal(dr["WHIOM_Tax"]);
            if (dr["WHIOM_Sum"] != DBNull.Value) wH_IOMain.WHIOM_Sum = Convert.ToDecimal(dr["WHIOM_Sum"]);
            if (dr["WHIOM_Project"] != DBNull.Value) wH_IOMain.WHIOM_Project = Convert.ToString(dr["WHIOM_Project"]);
            if (dr["WHIOM_RefType"] != DBNull.Value) wH_IOMain.WHIOM_RefType = Convert.ToString(dr["WHIOM_RefType"]);
            if (dr["WHIOM_RefCode"] != DBNull.Value) wH_IOMain.WHIOM_RefCode = Convert.ToString(dr["WHIOM_RefCode"]);
            if (dr["WHIOM_Bak"] != DBNull.Value) wH_IOMain.WHIOM_Bak = Convert.ToString(dr["WHIOM_Bak"]);
            if (dr["Stat"] != DBNull.Value) wH_IOMain.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["CreateDate"] != DBNull.Value) wH_IOMain.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
            if (dr["UpdateDate"] != DBNull.Value) wH_IOMain.UpdateDate = Convert.ToDateTime(dr["UpdateDate"]);
            if (dr["DeleteDate"] != DBNull.Value) wH_IOMain.DeleteDate = Convert.ToDateTime(dr["DeleteDate"]);
            if (dr["AuditStat"] != DBNull.Value) wH_IOMain.AuditStat = Convert.ToString(dr["AuditStat"]);
            if (dr["AuditCurAudit"] != DBNull.Value) wH_IOMain.AuditCurAudit = Convert.ToString(dr["AuditCurAudit"]);
            if (dr["WHIOM_IType"] != DBNull.Value) wH_IOMain.WHIOM_IType = Convert.ToString(dr["WHIOM_IType"]);
            if (dr["WHIOM_UDEF1"] != DBNull.Value) wH_IOMain.WHIOM_UDEF1 = Convert.ToString(dr["WHIOM_UDEF1"]);
            if (dr["WHIOM_UDEF2"] != DBNull.Value) wH_IOMain.WHIOM_UDEF2 = Convert.ToString(dr["WHIOM_UDEF2"]);
            if (dr["WHIOM_UDEF3"] != DBNull.Value) wH_IOMain.WHIOM_UDEF3 = Convert.ToString(dr["WHIOM_UDEF3"]);
            if (dr["WHIOM_UDEF4"] != DBNull.Value) wH_IOMain.WHIOM_UDEF4 = Convert.ToString(dr["WHIOM_UDEF4"]);
            if (dr["WHIOM_UDEF5"] != DBNull.Value) wH_IOMain.WHIOM_UDEF5 = Convert.ToString(dr["WHIOM_UDEF5"]);
            if (dr["WHIOM_UDEF6"] != DBNull.Value) wH_IOMain.WHIOM_UDEF6 = Convert.ToString(dr["WHIOM_UDEF6"]);
            if (dr["WHIOM_UDEF7"] != DBNull.Value) wH_IOMain.WHIOM_UDEF7 = Convert.ToString(dr["WHIOM_UDEF7"]);
            if (dr["WHIOM_UDEF8"] != DBNull.Value) wH_IOMain.WHIOM_UDEF8 = Convert.ToString(dr["WHIOM_UDEF8"]);
            if (dr["WHIOM_UDEF9"] != DBNull.Value) wH_IOMain.WHIOM_UDEF9 = Convert.ToString(dr["WHIOM_UDEF9"]);
            if (dr["WHIOM_UDEF10"] != DBNull.Value) wH_IOMain.WHIOM_UDEF10 = Convert.ToString(dr["WHIOM_UDEF10"]);
            if (dr["WHIOM_Operator"] != DBNull.Value) wH_IOMain.WHIOM_Operator = Convert.ToString(dr["WHIOM_Operator"]);
            if (dr["WHIOM_OCode"] != DBNull.Value) wH_IOMain.WHIOM_OCode = Convert.ToString(dr["WHIOM_OCode"]);
            if (dr["WHIOM_OpDate"] != DBNull.Value) wH_IOMain.WHIOM_OpDate = Convert.ToDateTime(dr["WHIOM_OpDate"]);
            if (dr["WHIOM_OwnerCode"] != DBNull.Value) wH_IOMain.WHIOM_OwnerCode = Convert.ToString(dr["WHIOM_OwnerCode"]);
            ret.Add(wH_IOMain);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   }  
         return ret;
      }
      /// <summary>
      /// 获取所有的物料出库主表 WH_IOMain对象(即:一条记录
      /// </summary>
      public List<WH_IOMain> GetAll()
      {
         List<WH_IOMain> ret = new List<WH_IOMain>();
         string sql = "SELECT  WHIOM_ID,WHIOM_Type,WHIOM_Code,WHIOM_Title,WHIOM_CompanyCode,WHIOM_Company,WHIOM_DepartmentCode,WHIOM_Department,WHIOM_Owner,WHIOM_State,WHIOM_PDate,WHIOM_IDate,WHIOM_RDate,WHIOM_WOwner,WHIOM_BOwner,WHIOM_TranFee,WHIOM_DisCount,WHIOM_DisSum,WHIOM_Tax,WHIOM_Sum,WHIOM_Project,WHIOM_RefType,WHIOM_RefCode,WHIOM_Bak,Stat,CreateDate,UpdateDate,DeleteDate,AuditStat,AuditCurAudit,WHIOM_IType,WHIOM_UDEF1,WHIOM_UDEF2,WHIOM_UDEF3,WHIOM_UDEF4,WHIOM_UDEF5,WHIOM_UDEF6,WHIOM_UDEF7,WHIOM_UDEF8,WHIOM_UDEF9,WHIOM_UDEF10,WHIOM_Operator,WHIOM_OCode,WHIOM_OpDate,WHIOM_OwnerCode FROM WH_IOMain where 1=1 AND ((Stat is null) or (Stat=0) ) order by WHIOM_ID desc ";
          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            WH_IOMain wH_IOMain = new WH_IOMain();
            if (dr["WHIOM_ID"] != DBNull.Value) wH_IOMain.WHIOM_ID = Convert.ToDecimal(dr["WHIOM_ID"]);
            if (dr["WHIOM_Type"] != DBNull.Value) wH_IOMain.WHIOM_Type = Convert.ToString(dr["WHIOM_Type"]);
            if (dr["WHIOM_Code"] != DBNull.Value) wH_IOMain.WHIOM_Code = Convert.ToString(dr["WHIOM_Code"]);
            if (dr["WHIOM_Title"] != DBNull.Value) wH_IOMain.WHIOM_Title = Convert.ToString(dr["WHIOM_Title"]);
            if (dr["WHIOM_CompanyCode"] != DBNull.Value) wH_IOMain.WHIOM_CompanyCode = Convert.ToString(dr["WHIOM_CompanyCode"]);
            if (dr["WHIOM_Company"] != DBNull.Value) wH_IOMain.WHIOM_Company = Convert.ToString(dr["WHIOM_Company"]);
            if (dr["WHIOM_DepartmentCode"] != DBNull.Value) wH_IOMain.WHIOM_DepartmentCode = Convert.ToString(dr["WHIOM_DepartmentCode"]);
            if (dr["WHIOM_Department"] != DBNull.Value) wH_IOMain.WHIOM_Department = Convert.ToString(dr["WHIOM_Department"]);
            if (dr["WHIOM_Owner"] != DBNull.Value) wH_IOMain.WHIOM_Owner = Convert.ToString(dr["WHIOM_Owner"]);
            if (dr["WHIOM_State"] != DBNull.Value) wH_IOMain.WHIOM_State = Convert.ToString(dr["WHIOM_State"]);
            if (dr["WHIOM_PDate"] != DBNull.Value) wH_IOMain.WHIOM_PDate = Convert.ToDateTime(dr["WHIOM_PDate"]);
            if (dr["WHIOM_IDate"] != DBNull.Value) wH_IOMain.WHIOM_IDate = Convert.ToDateTime(dr["WHIOM_IDate"]);
            if (dr["WHIOM_RDate"] != DBNull.Value) wH_IOMain.WHIOM_RDate = Convert.ToDateTime(dr["WHIOM_RDate"]);
            if (dr["WHIOM_WOwner"] != DBNull.Value) wH_IOMain.WHIOM_WOwner = Convert.ToString(dr["WHIOM_WOwner"]);
            if (dr["WHIOM_BOwner"] != DBNull.Value) wH_IOMain.WHIOM_BOwner = Convert.ToString(dr["WHIOM_BOwner"]);
            if (dr["WHIOM_TranFee"] != DBNull.Value) wH_IOMain.WHIOM_TranFee = Convert.ToDecimal(dr["WHIOM_TranFee"]);
            if (dr["WHIOM_DisCount"] != DBNull.Value) wH_IOMain.WHIOM_DisCount = Convert.ToDecimal(dr["WHIOM_DisCount"]);
            if (dr["WHIOM_DisSum"] != DBNull.Value) wH_IOMain.WHIOM_DisSum = Convert.ToDecimal(dr["WHIOM_DisSum"]);
            if (dr["WHIOM_Tax"] != DBNull.Value) wH_IOMain.WHIOM_Tax = Convert.ToDecimal(dr["WHIOM_Tax"]);
            if (dr["WHIOM_Sum"] != DBNull.Value) wH_IOMain.WHIOM_Sum = Convert.ToDecimal(dr["WHIOM_Sum"]);
            if (dr["WHIOM_Project"] != DBNull.Value) wH_IOMain.WHIOM_Project = Convert.ToString(dr["WHIOM_Project"]);
            if (dr["WHIOM_RefType"] != DBNull.Value) wH_IOMain.WHIOM_RefType = Convert.ToString(dr["WHIOM_RefType"]);
            if (dr["WHIOM_RefCode"] != DBNull.Value) wH_IOMain.WHIOM_RefCode = Convert.ToString(dr["WHIOM_RefCode"]);
            if (dr["WHIOM_Bak"] != DBNull.Value) wH_IOMain.WHIOM_Bak = Convert.ToString(dr["WHIOM_Bak"]);
            if (dr["Stat"] != DBNull.Value) wH_IOMain.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["CreateDate"] != DBNull.Value) wH_IOMain.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
            if (dr["UpdateDate"] != DBNull.Value) wH_IOMain.UpdateDate = Convert.ToDateTime(dr["UpdateDate"]);
            if (dr["DeleteDate"] != DBNull.Value) wH_IOMain.DeleteDate = Convert.ToDateTime(dr["DeleteDate"]);
            if (dr["AuditStat"] != DBNull.Value) wH_IOMain.AuditStat = Convert.ToString(dr["AuditStat"]);
            if (dr["AuditCurAudit"] != DBNull.Value) wH_IOMain.AuditCurAudit = Convert.ToString(dr["AuditCurAudit"]);
            if (dr["WHIOM_IType"] != DBNull.Value) wH_IOMain.WHIOM_IType = Convert.ToString(dr["WHIOM_IType"]);
            if (dr["WHIOM_UDEF1"] != DBNull.Value) wH_IOMain.WHIOM_UDEF1 = Convert.ToString(dr["WHIOM_UDEF1"]);
            if (dr["WHIOM_UDEF2"] != DBNull.Value) wH_IOMain.WHIOM_UDEF2 = Convert.ToString(dr["WHIOM_UDEF2"]);
            if (dr["WHIOM_UDEF3"] != DBNull.Value) wH_IOMain.WHIOM_UDEF3 = Convert.ToString(dr["WHIOM_UDEF3"]);
            if (dr["WHIOM_UDEF4"] != DBNull.Value) wH_IOMain.WHIOM_UDEF4 = Convert.ToString(dr["WHIOM_UDEF4"]);
            if (dr["WHIOM_UDEF5"] != DBNull.Value) wH_IOMain.WHIOM_UDEF5 = Convert.ToString(dr["WHIOM_UDEF5"]);
            if (dr["WHIOM_UDEF6"] != DBNull.Value) wH_IOMain.WHIOM_UDEF6 = Convert.ToString(dr["WHIOM_UDEF6"]);
            if (dr["WHIOM_UDEF7"] != DBNull.Value) wH_IOMain.WHIOM_UDEF7 = Convert.ToString(dr["WHIOM_UDEF7"]);
            if (dr["WHIOM_UDEF8"] != DBNull.Value) wH_IOMain.WHIOM_UDEF8 = Convert.ToString(dr["WHIOM_UDEF8"]);
            if (dr["WHIOM_UDEF9"] != DBNull.Value) wH_IOMain.WHIOM_UDEF9 = Convert.ToString(dr["WHIOM_UDEF9"]);
            if (dr["WHIOM_UDEF10"] != DBNull.Value) wH_IOMain.WHIOM_UDEF10 = Convert.ToString(dr["WHIOM_UDEF10"]);
            if (dr["WHIOM_Operator"] != DBNull.Value) wH_IOMain.WHIOM_Operator = Convert.ToString(dr["WHIOM_Operator"]);
            if (dr["WHIOM_OCode"] != DBNull.Value) wH_IOMain.WHIOM_OCode = Convert.ToString(dr["WHIOM_OCode"]);
            if (dr["WHIOM_OpDate"] != DBNull.Value) wH_IOMain.WHIOM_OpDate = Convert.ToDateTime(dr["WHIOM_OpDate"]);
            if (dr["WHIOM_OwnerCode"] != DBNull.Value) wH_IOMain.WHIOM_OwnerCode = Convert.ToString(dr["WHIOM_OwnerCode"]);
            ret.Add(wH_IOMain);
         }
          }catch (System.Exception ex){ throw ex; }  finally {  if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   } 
         return ret;
      }
   }
}
