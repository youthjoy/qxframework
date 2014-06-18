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
   /// 供应商往来主表
   /// </summary>
   [Serializable]
   public partial class ADOPU_Main
   {
      public IDBOperator idb =  DBOperator.GetInstance();
      /// <summary>
      /// 添加供应商往来主表 PU_Main对象(即:一条记录)
      /// </summary>
      public int Add(PU_Main pU_Main)
      {
         string sql = "INSERT INTO PU_Main (PUM_RType,PUM_RCode,PUM_Title,PUM_SCode,PUM_SName,PUM_SContact,PUM_STel,PUM_State,PUM_PDate,PUM_IDate,PUM_RDate,PUM_Owner,PUM_Tranfee,PUM_Discount,PUM_DisSum,PUM_Tax,PUM_Payable,PUM_Bak,PUM_BOwner,PUM_RefType,PUM_RefCode,AuditStat,AuditCurAudit,PUM_Company,PUM_Dept,PUM_User,PUM_UseType,Stat,CreateDate,UpdateDate,DeleteDate,PUM_CompanyCode,PUM_DeptCode,PUM_Type,PUM_Operator,PUM_OCode,PUM_OpDate,PUM_UDEF1,PUM_UDEF2,PUM_UDEF3,PUM_UDEF4,PUM_UDEF5,PUM_UDEF6,PUM_UDEF7,PUM_UDEF8,PUM_UDEF9,PUM_UDEF10,PUM_OwnerCode) VALUES (@PUM_RType,@PUM_RCode,@PUM_Title,@PUM_SCode,@PUM_SName,@PUM_SContact,@PUM_STel,@PUM_State,@PUM_PDate,@PUM_IDate,@PUM_RDate,@PUM_Owner,@PUM_Tranfee,@PUM_Discount,@PUM_DisSum,@PUM_Tax,@PUM_Payable,@PUM_Bak,@PUM_BOwner,@PUM_RefType,@PUM_RefCode,@AuditStat,@AuditCurAudit,@PUM_Company,@PUM_Dept,@PUM_User,@PUM_UseType,@Stat,@CreateDate,@UpdateDate,@DeleteDate,@PUM_CompanyCode,@PUM_DeptCode,@PUM_Type,@PUM_Operator,@PUM_OCode,@PUM_OpDate,@PUM_UDEF1,@PUM_UDEF2,@PUM_UDEF3,@PUM_UDEF4,@PUM_UDEF5,@PUM_UDEF6,@PUM_UDEF7,@PUM_UDEF8,@PUM_UDEF9,@PUM_UDEF10,@PUM_OwnerCode)";
         if (string.IsNullOrEmpty(pU_Main.PUM_RType))
         {
            idb.AddParameter("@PUM_RType", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PUM_RType", pU_Main.PUM_RType);
         }
         if (string.IsNullOrEmpty(pU_Main.PUM_RCode))
         {
            idb.AddParameter("@PUM_RCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PUM_RCode", pU_Main.PUM_RCode);
         }
         if (string.IsNullOrEmpty(pU_Main.PUM_Title))
         {
            idb.AddParameter("@PUM_Title", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PUM_Title", pU_Main.PUM_Title);
         }
         if (string.IsNullOrEmpty(pU_Main.PUM_SCode))
         {
            idb.AddParameter("@PUM_SCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PUM_SCode", pU_Main.PUM_SCode);
         }
         if (string.IsNullOrEmpty(pU_Main.PUM_SName))
         {
            idb.AddParameter("@PUM_SName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PUM_SName", pU_Main.PUM_SName);
         }
         if (string.IsNullOrEmpty(pU_Main.PUM_SContact))
         {
            idb.AddParameter("@PUM_SContact", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PUM_SContact", pU_Main.PUM_SContact);
         }
         if (string.IsNullOrEmpty(pU_Main.PUM_STel))
         {
            idb.AddParameter("@PUM_STel", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PUM_STel", pU_Main.PUM_STel);
         }
         if (string.IsNullOrEmpty(pU_Main.PUM_State))
         {
            idb.AddParameter("@PUM_State", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PUM_State", pU_Main.PUM_State);
         }
         if (pU_Main.PUM_PDate == DateTime.MinValue)
         {
            idb.AddParameter("@PUM_PDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PUM_PDate", pU_Main.PUM_PDate);
         }
         if (pU_Main.PUM_IDate == DateTime.MinValue)
         {
            idb.AddParameter("@PUM_IDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PUM_IDate", pU_Main.PUM_IDate);
         }
         if (pU_Main.PUM_RDate == DateTime.MinValue)
         {
            idb.AddParameter("@PUM_RDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PUM_RDate", pU_Main.PUM_RDate);
         }
         if (string.IsNullOrEmpty(pU_Main.PUM_Owner))
         {
            idb.AddParameter("@PUM_Owner", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PUM_Owner", pU_Main.PUM_Owner);
         }
         if (pU_Main.PUM_Tranfee == 0)
         {
            idb.AddParameter("@PUM_Tranfee", 0);
         }
         else
         {
            idb.AddParameter("@PUM_Tranfee", pU_Main.PUM_Tranfee);
         }
         if (pU_Main.PUM_Discount == 0)
         {
            idb.AddParameter("@PUM_Discount", 0);
         }
         else
         {
            idb.AddParameter("@PUM_Discount", pU_Main.PUM_Discount);
         }
         if (pU_Main.PUM_DisSum == 0)
         {
            idb.AddParameter("@PUM_DisSum", 0);
         }
         else
         {
            idb.AddParameter("@PUM_DisSum", pU_Main.PUM_DisSum);
         }
         if (pU_Main.PUM_Tax == 0)
         {
            idb.AddParameter("@PUM_Tax", 0);
         }
         else
         {
            idb.AddParameter("@PUM_Tax", pU_Main.PUM_Tax);
         }
         if (pU_Main.PUM_Payable == 0)
         {
            idb.AddParameter("@PUM_Payable", 0);
         }
         else
         {
            idb.AddParameter("@PUM_Payable", pU_Main.PUM_Payable);
         }
         if (string.IsNullOrEmpty(pU_Main.PUM_Bak))
         {
            idb.AddParameter("@PUM_Bak", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PUM_Bak", pU_Main.PUM_Bak);
         }
         if (string.IsNullOrEmpty(pU_Main.PUM_BOwner))
         {
            idb.AddParameter("@PUM_BOwner", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PUM_BOwner", pU_Main.PUM_BOwner);
         }
         if (string.IsNullOrEmpty(pU_Main.PUM_RefType))
         {
            idb.AddParameter("@PUM_RefType", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PUM_RefType", pU_Main.PUM_RefType);
         }
         if (string.IsNullOrEmpty(pU_Main.PUM_RefCode))
         {
            idb.AddParameter("@PUM_RefCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PUM_RefCode", pU_Main.PUM_RefCode);
         }
         if (string.IsNullOrEmpty(pU_Main.AuditStat))
         {
            idb.AddParameter("@AuditStat", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AuditStat", pU_Main.AuditStat);
         }
         if (string.IsNullOrEmpty(pU_Main.AuditCurAudit))
         {
            idb.AddParameter("@AuditCurAudit", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AuditCurAudit", pU_Main.AuditCurAudit);
         }
         if (string.IsNullOrEmpty(pU_Main.PUM_Company))
         {
            idb.AddParameter("@PUM_Company", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PUM_Company", pU_Main.PUM_Company);
         }
         if (string.IsNullOrEmpty(pU_Main.PUM_Dept))
         {
            idb.AddParameter("@PUM_Dept", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PUM_Dept", pU_Main.PUM_Dept);
         }
         if (string.IsNullOrEmpty(pU_Main.PUM_User))
         {
            idb.AddParameter("@PUM_User", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PUM_User", pU_Main.PUM_User);
         }
         if (string.IsNullOrEmpty(pU_Main.PUM_UseType))
         {
            idb.AddParameter("@PUM_UseType", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PUM_UseType", pU_Main.PUM_UseType);
         }
         if (pU_Main.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", pU_Main.Stat);
         }
         if (pU_Main.CreateDate == DateTime.MinValue)
         {
            idb.AddParameter("@CreateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateDate", pU_Main.CreateDate);
         }
         if (pU_Main.UpdateDate == DateTime.MinValue)
         {
            idb.AddParameter("@UpdateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@UpdateDate", pU_Main.UpdateDate);
         }
         if (pU_Main.DeleteDate == DateTime.MinValue)
         {
            idb.AddParameter("@DeleteDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DeleteDate", pU_Main.DeleteDate);
         }
         if (string.IsNullOrEmpty(pU_Main.PUM_CompanyCode))
         {
            idb.AddParameter("@PUM_CompanyCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PUM_CompanyCode", pU_Main.PUM_CompanyCode);
         }
         if (string.IsNullOrEmpty(pU_Main.PUM_DeptCode))
         {
            idb.AddParameter("@PUM_DeptCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PUM_DeptCode", pU_Main.PUM_DeptCode);
         }
         if (string.IsNullOrEmpty(pU_Main.PUM_Type))
         {
            idb.AddParameter("@PUM_Type", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PUM_Type", pU_Main.PUM_Type);
         }
         if (string.IsNullOrEmpty(pU_Main.PUM_Operator))
         {
            idb.AddParameter("@PUM_Operator", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PUM_Operator", pU_Main.PUM_Operator);
         }
         if (string.IsNullOrEmpty(pU_Main.PUM_OCode))
         {
            idb.AddParameter("@PUM_OCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PUM_OCode", pU_Main.PUM_OCode);
         }
         if (pU_Main.PUM_OpDate == DateTime.MinValue)
         {
            idb.AddParameter("@PUM_OpDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PUM_OpDate", pU_Main.PUM_OpDate);
         }
         if (string.IsNullOrEmpty(pU_Main.PUM_UDEF1))
         {
            idb.AddParameter("@PUM_UDEF1", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PUM_UDEF1", pU_Main.PUM_UDEF1);
         }
         if (string.IsNullOrEmpty(pU_Main.PUM_UDEF2))
         {
            idb.AddParameter("@PUM_UDEF2", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PUM_UDEF2", pU_Main.PUM_UDEF2);
         }
         if (string.IsNullOrEmpty(pU_Main.PUM_UDEF3))
         {
            idb.AddParameter("@PUM_UDEF3", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PUM_UDEF3", pU_Main.PUM_UDEF3);
         }
         if (string.IsNullOrEmpty(pU_Main.PUM_UDEF4))
         {
            idb.AddParameter("@PUM_UDEF4", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PUM_UDEF4", pU_Main.PUM_UDEF4);
         }
         if (string.IsNullOrEmpty(pU_Main.PUM_UDEF5))
         {
            idb.AddParameter("@PUM_UDEF5", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PUM_UDEF5", pU_Main.PUM_UDEF5);
         }
         if (string.IsNullOrEmpty(pU_Main.PUM_UDEF6))
         {
            idb.AddParameter("@PUM_UDEF6", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PUM_UDEF6", pU_Main.PUM_UDEF6);
         }
         if (string.IsNullOrEmpty(pU_Main.PUM_UDEF7))
         {
            idb.AddParameter("@PUM_UDEF7", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PUM_UDEF7", pU_Main.PUM_UDEF7);
         }
         if (string.IsNullOrEmpty(pU_Main.PUM_UDEF8))
         {
            idb.AddParameter("@PUM_UDEF8", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PUM_UDEF8", pU_Main.PUM_UDEF8);
         }
         if (string.IsNullOrEmpty(pU_Main.PUM_UDEF9))
         {
            idb.AddParameter("@PUM_UDEF9", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PUM_UDEF9", pU_Main.PUM_UDEF9);
         }
         if (string.IsNullOrEmpty(pU_Main.PUM_UDEF10))
         {
            idb.AddParameter("@PUM_UDEF10", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PUM_UDEF10", pU_Main.PUM_UDEF10);
         }
         if (string.IsNullOrEmpty(pU_Main.PUM_OwnerCode))
         {
            idb.AddParameter("@PUM_OwnerCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PUM_OwnerCode", pU_Main.PUM_OwnerCode);
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
      /// 添加供应商往来主表 PU_Main对象(即:一条记录)
      /// </summary>
      public object AddWithReturn(PU_Main pU_Main)
      {
         string sql = "INSERT INTO PU_Main (PUM_RType,PUM_RCode,PUM_Title,PUM_SCode,PUM_SName,PUM_SContact,PUM_STel,PUM_State,PUM_PDate,PUM_IDate,PUM_RDate,PUM_Owner,PUM_Tranfee,PUM_Discount,PUM_DisSum,PUM_Tax,PUM_Payable,PUM_Bak,PUM_BOwner,PUM_RefType,PUM_RefCode,AuditStat,AuditCurAudit,PUM_Company,PUM_Dept,PUM_User,PUM_UseType,Stat,CreateDate,UpdateDate,DeleteDate,PUM_CompanyCode,PUM_DeptCode,PUM_Type,PUM_Operator,PUM_OCode,PUM_OpDate,PUM_UDEF1,PUM_UDEF2,PUM_UDEF3,PUM_UDEF4,PUM_UDEF5,PUM_UDEF6,PUM_UDEF7,PUM_UDEF8,PUM_UDEF9,PUM_UDEF10,PUM_OwnerCode) VALUES (@PUM_RType,@PUM_RCode,@PUM_Title,@PUM_SCode,@PUM_SName,@PUM_SContact,@PUM_STel,@PUM_State,@PUM_PDate,@PUM_IDate,@PUM_RDate,@PUM_Owner,@PUM_Tranfee,@PUM_Discount,@PUM_DisSum,@PUM_Tax,@PUM_Payable,@PUM_Bak,@PUM_BOwner,@PUM_RefType,@PUM_RefCode,@AuditStat,@AuditCurAudit,@PUM_Company,@PUM_Dept,@PUM_User,@PUM_UseType,@Stat,@CreateDate,@UpdateDate,@DeleteDate,@PUM_CompanyCode,@PUM_DeptCode,@PUM_Type,@PUM_Operator,@PUM_OCode,@PUM_OpDate,@PUM_UDEF1,@PUM_UDEF2,@PUM_UDEF3,@PUM_UDEF4,@PUM_UDEF5,@PUM_UDEF6,@PUM_UDEF7,@PUM_UDEF8,@PUM_UDEF9,@PUM_UDEF10,@PUM_OwnerCode);SELECT @@IDENTITY AS ReturnID;";
         if (string.IsNullOrEmpty(pU_Main.PUM_RType))
         {
            idb.AddParameter("@PUM_RType", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PUM_RType", pU_Main.PUM_RType);
         }
         if (string.IsNullOrEmpty(pU_Main.PUM_RCode))
         {
            idb.AddParameter("@PUM_RCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PUM_RCode", pU_Main.PUM_RCode);
         }
         if (string.IsNullOrEmpty(pU_Main.PUM_Title))
         {
            idb.AddParameter("@PUM_Title", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PUM_Title", pU_Main.PUM_Title);
         }
         if (string.IsNullOrEmpty(pU_Main.PUM_SCode))
         {
            idb.AddParameter("@PUM_SCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PUM_SCode", pU_Main.PUM_SCode);
         }
         if (string.IsNullOrEmpty(pU_Main.PUM_SName))
         {
            idb.AddParameter("@PUM_SName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PUM_SName", pU_Main.PUM_SName);
         }
         if (string.IsNullOrEmpty(pU_Main.PUM_SContact))
         {
            idb.AddParameter("@PUM_SContact", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PUM_SContact", pU_Main.PUM_SContact);
         }
         if (string.IsNullOrEmpty(pU_Main.PUM_STel))
         {
            idb.AddParameter("@PUM_STel", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PUM_STel", pU_Main.PUM_STel);
         }
         if (string.IsNullOrEmpty(pU_Main.PUM_State))
         {
            idb.AddParameter("@PUM_State", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PUM_State", pU_Main.PUM_State);
         }
         if (pU_Main.PUM_PDate == DateTime.MinValue)
         {
            idb.AddParameter("@PUM_PDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PUM_PDate", pU_Main.PUM_PDate);
         }
         if (pU_Main.PUM_IDate == DateTime.MinValue)
         {
            idb.AddParameter("@PUM_IDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PUM_IDate", pU_Main.PUM_IDate);
         }
         if (pU_Main.PUM_RDate == DateTime.MinValue)
         {
            idb.AddParameter("@PUM_RDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PUM_RDate", pU_Main.PUM_RDate);
         }
         if (string.IsNullOrEmpty(pU_Main.PUM_Owner))
         {
            idb.AddParameter("@PUM_Owner", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PUM_Owner", pU_Main.PUM_Owner);
         }
         if (pU_Main.PUM_Tranfee == 0)
         {
            idb.AddParameter("@PUM_Tranfee", 0);
         }
         else
         {
            idb.AddParameter("@PUM_Tranfee", pU_Main.PUM_Tranfee);
         }
         if (pU_Main.PUM_Discount == 0)
         {
            idb.AddParameter("@PUM_Discount", 0);
         }
         else
         {
            idb.AddParameter("@PUM_Discount", pU_Main.PUM_Discount);
         }
         if (pU_Main.PUM_DisSum == 0)
         {
            idb.AddParameter("@PUM_DisSum", 0);
         }
         else
         {
            idb.AddParameter("@PUM_DisSum", pU_Main.PUM_DisSum);
         }
         if (pU_Main.PUM_Tax == 0)
         {
            idb.AddParameter("@PUM_Tax", 0);
         }
         else
         {
            idb.AddParameter("@PUM_Tax", pU_Main.PUM_Tax);
         }
         if (pU_Main.PUM_Payable == 0)
         {
            idb.AddParameter("@PUM_Payable", 0);
         }
         else
         {
            idb.AddParameter("@PUM_Payable", pU_Main.PUM_Payable);
         }
         if (string.IsNullOrEmpty(pU_Main.PUM_Bak))
         {
            idb.AddParameter("@PUM_Bak", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PUM_Bak", pU_Main.PUM_Bak);
         }
         if (string.IsNullOrEmpty(pU_Main.PUM_BOwner))
         {
            idb.AddParameter("@PUM_BOwner", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PUM_BOwner", pU_Main.PUM_BOwner);
         }
         if (string.IsNullOrEmpty(pU_Main.PUM_RefType))
         {
            idb.AddParameter("@PUM_RefType", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PUM_RefType", pU_Main.PUM_RefType);
         }
         if (string.IsNullOrEmpty(pU_Main.PUM_RefCode))
         {
            idb.AddParameter("@PUM_RefCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PUM_RefCode", pU_Main.PUM_RefCode);
         }
         if (string.IsNullOrEmpty(pU_Main.AuditStat))
         {
            idb.AddParameter("@AuditStat", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AuditStat", pU_Main.AuditStat);
         }
         if (string.IsNullOrEmpty(pU_Main.AuditCurAudit))
         {
            idb.AddParameter("@AuditCurAudit", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AuditCurAudit", pU_Main.AuditCurAudit);
         }
         if (string.IsNullOrEmpty(pU_Main.PUM_Company))
         {
            idb.AddParameter("@PUM_Company", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PUM_Company", pU_Main.PUM_Company);
         }
         if (string.IsNullOrEmpty(pU_Main.PUM_Dept))
         {
            idb.AddParameter("@PUM_Dept", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PUM_Dept", pU_Main.PUM_Dept);
         }
         if (string.IsNullOrEmpty(pU_Main.PUM_User))
         {
            idb.AddParameter("@PUM_User", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PUM_User", pU_Main.PUM_User);
         }
         if (string.IsNullOrEmpty(pU_Main.PUM_UseType))
         {
            idb.AddParameter("@PUM_UseType", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PUM_UseType", pU_Main.PUM_UseType);
         }
         if (pU_Main.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", pU_Main.Stat);
         }
         if (pU_Main.CreateDate == DateTime.MinValue)
         {
            idb.AddParameter("@CreateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateDate", pU_Main.CreateDate);
         }
         if (pU_Main.UpdateDate == DateTime.MinValue)
         {
            idb.AddParameter("@UpdateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@UpdateDate", pU_Main.UpdateDate);
         }
         if (pU_Main.DeleteDate == DateTime.MinValue)
         {
            idb.AddParameter("@DeleteDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DeleteDate", pU_Main.DeleteDate);
         }
         if (string.IsNullOrEmpty(pU_Main.PUM_CompanyCode))
         {
            idb.AddParameter("@PUM_CompanyCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PUM_CompanyCode", pU_Main.PUM_CompanyCode);
         }
         if (string.IsNullOrEmpty(pU_Main.PUM_DeptCode))
         {
            idb.AddParameter("@PUM_DeptCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PUM_DeptCode", pU_Main.PUM_DeptCode);
         }
         if (string.IsNullOrEmpty(pU_Main.PUM_Type))
         {
            idb.AddParameter("@PUM_Type", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PUM_Type", pU_Main.PUM_Type);
         }
         if (string.IsNullOrEmpty(pU_Main.PUM_Operator))
         {
            idb.AddParameter("@PUM_Operator", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PUM_Operator", pU_Main.PUM_Operator);
         }
         if (string.IsNullOrEmpty(pU_Main.PUM_OCode))
         {
            idb.AddParameter("@PUM_OCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PUM_OCode", pU_Main.PUM_OCode);
         }
         if (pU_Main.PUM_OpDate == DateTime.MinValue)
         {
            idb.AddParameter("@PUM_OpDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PUM_OpDate", pU_Main.PUM_OpDate);
         }
         if (string.IsNullOrEmpty(pU_Main.PUM_UDEF1))
         {
            idb.AddParameter("@PUM_UDEF1", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PUM_UDEF1", pU_Main.PUM_UDEF1);
         }
         if (string.IsNullOrEmpty(pU_Main.PUM_UDEF2))
         {
            idb.AddParameter("@PUM_UDEF2", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PUM_UDEF2", pU_Main.PUM_UDEF2);
         }
         if (string.IsNullOrEmpty(pU_Main.PUM_UDEF3))
         {
            idb.AddParameter("@PUM_UDEF3", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PUM_UDEF3", pU_Main.PUM_UDEF3);
         }
         if (string.IsNullOrEmpty(pU_Main.PUM_UDEF4))
         {
            idb.AddParameter("@PUM_UDEF4", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PUM_UDEF4", pU_Main.PUM_UDEF4);
         }
         if (string.IsNullOrEmpty(pU_Main.PUM_UDEF5))
         {
            idb.AddParameter("@PUM_UDEF5", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PUM_UDEF5", pU_Main.PUM_UDEF5);
         }
         if (string.IsNullOrEmpty(pU_Main.PUM_UDEF6))
         {
            idb.AddParameter("@PUM_UDEF6", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PUM_UDEF6", pU_Main.PUM_UDEF6);
         }
         if (string.IsNullOrEmpty(pU_Main.PUM_UDEF7))
         {
            idb.AddParameter("@PUM_UDEF7", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PUM_UDEF7", pU_Main.PUM_UDEF7);
         }
         if (string.IsNullOrEmpty(pU_Main.PUM_UDEF8))
         {
            idb.AddParameter("@PUM_UDEF8", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PUM_UDEF8", pU_Main.PUM_UDEF8);
         }
         if (string.IsNullOrEmpty(pU_Main.PUM_UDEF9))
         {
            idb.AddParameter("@PUM_UDEF9", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PUM_UDEF9", pU_Main.PUM_UDEF9);
         }
         if (string.IsNullOrEmpty(pU_Main.PUM_UDEF10))
         {
            idb.AddParameter("@PUM_UDEF10", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PUM_UDEF10", pU_Main.PUM_UDEF10);
         }
         if (string.IsNullOrEmpty(pU_Main.PUM_OwnerCode))
         {
            idb.AddParameter("@PUM_OwnerCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PUM_OwnerCode", pU_Main.PUM_OwnerCode);
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
      /// 更新供应商往来主表 PU_Main对象(即:一条记录
      /// </summary>
      public int Update(PU_Main pU_Main)
      {
         
         StringBuilder sbParameter=new StringBuilder();
      StringBuilder sb=new StringBuilder();
      sb.Append(@"UPDATE       PU_Main       SET ");
            if(pU_Main.PUM_RType_IsChanged){sbParameter.Append("PUM_RType=@PUM_RType, ");}
      if(pU_Main.PUM_RCode_IsChanged){sbParameter.Append("PUM_RCode=@PUM_RCode, ");}
      if(pU_Main.PUM_Title_IsChanged){sbParameter.Append("PUM_Title=@PUM_Title, ");}
      if(pU_Main.PUM_SCode_IsChanged){sbParameter.Append("PUM_SCode=@PUM_SCode, ");}
      if(pU_Main.PUM_SName_IsChanged){sbParameter.Append("PUM_SName=@PUM_SName, ");}
      if(pU_Main.PUM_SContact_IsChanged){sbParameter.Append("PUM_SContact=@PUM_SContact, ");}
      if(pU_Main.PUM_STel_IsChanged){sbParameter.Append("PUM_STel=@PUM_STel, ");}
      if(pU_Main.PUM_State_IsChanged){sbParameter.Append("PUM_State=@PUM_State, ");}
      if(pU_Main.PUM_PDate_IsChanged){sbParameter.Append("PUM_PDate=@PUM_PDate, ");}
      if(pU_Main.PUM_IDate_IsChanged){sbParameter.Append("PUM_IDate=@PUM_IDate, ");}
      if(pU_Main.PUM_RDate_IsChanged){sbParameter.Append("PUM_RDate=@PUM_RDate, ");}
      if(pU_Main.PUM_Owner_IsChanged){sbParameter.Append("PUM_Owner=@PUM_Owner, ");}
      if(pU_Main.PUM_Tranfee_IsChanged){sbParameter.Append("PUM_Tranfee=@PUM_Tranfee, ");}
      if(pU_Main.PUM_Discount_IsChanged){sbParameter.Append("PUM_Discount=@PUM_Discount, ");}
      if(pU_Main.PUM_DisSum_IsChanged){sbParameter.Append("PUM_DisSum=@PUM_DisSum, ");}
      if(pU_Main.PUM_Tax_IsChanged){sbParameter.Append("PUM_Tax=@PUM_Tax, ");}
      if(pU_Main.PUM_Payable_IsChanged){sbParameter.Append("PUM_Payable=@PUM_Payable, ");}
      if(pU_Main.PUM_Bak_IsChanged){sbParameter.Append("PUM_Bak=@PUM_Bak, ");}
      if(pU_Main.PUM_BOwner_IsChanged){sbParameter.Append("PUM_BOwner=@PUM_BOwner, ");}
      if(pU_Main.PUM_RefType_IsChanged){sbParameter.Append("PUM_RefType=@PUM_RefType, ");}
      if(pU_Main.PUM_RefCode_IsChanged){sbParameter.Append("PUM_RefCode=@PUM_RefCode, ");}
      if(pU_Main.AuditStat_IsChanged){sbParameter.Append("AuditStat=@AuditStat, ");}
      if(pU_Main.AuditCurAudit_IsChanged){sbParameter.Append("AuditCurAudit=@AuditCurAudit, ");}
      if(pU_Main.PUM_Company_IsChanged){sbParameter.Append("PUM_Company=@PUM_Company, ");}
      if(pU_Main.PUM_Dept_IsChanged){sbParameter.Append("PUM_Dept=@PUM_Dept, ");}
      if(pU_Main.PUM_User_IsChanged){sbParameter.Append("PUM_User=@PUM_User, ");}
      if(pU_Main.PUM_UseType_IsChanged){sbParameter.Append("PUM_UseType=@PUM_UseType, ");}
      if(pU_Main.Stat_IsChanged){sbParameter.Append("Stat=@Stat, ");}
      if(pU_Main.CreateDate_IsChanged){sbParameter.Append("CreateDate=@CreateDate, ");}
      if(pU_Main.UpdateDate_IsChanged){sbParameter.Append("UpdateDate=@UpdateDate, ");}
      if(pU_Main.DeleteDate_IsChanged){sbParameter.Append("DeleteDate=@DeleteDate, ");}
      if(pU_Main.PUM_CompanyCode_IsChanged){sbParameter.Append("PUM_CompanyCode=@PUM_CompanyCode, ");}
      if(pU_Main.PUM_DeptCode_IsChanged){sbParameter.Append("PUM_DeptCode=@PUM_DeptCode, ");}
      if(pU_Main.PUM_Type_IsChanged){sbParameter.Append("PUM_Type=@PUM_Type, ");}
      if(pU_Main.PUM_Operator_IsChanged){sbParameter.Append("PUM_Operator=@PUM_Operator, ");}
      if(pU_Main.PUM_OCode_IsChanged){sbParameter.Append("PUM_OCode=@PUM_OCode, ");}
      if(pU_Main.PUM_OpDate_IsChanged){sbParameter.Append("PUM_OpDate=@PUM_OpDate, ");}
      if(pU_Main.PUM_UDEF1_IsChanged){sbParameter.Append("PUM_UDEF1=@PUM_UDEF1, ");}
      if(pU_Main.PUM_UDEF2_IsChanged){sbParameter.Append("PUM_UDEF2=@PUM_UDEF2, ");}
      if(pU_Main.PUM_UDEF3_IsChanged){sbParameter.Append("PUM_UDEF3=@PUM_UDEF3, ");}
      if(pU_Main.PUM_UDEF4_IsChanged){sbParameter.Append("PUM_UDEF4=@PUM_UDEF4, ");}
      if(pU_Main.PUM_UDEF5_IsChanged){sbParameter.Append("PUM_UDEF5=@PUM_UDEF5, ");}
      if(pU_Main.PUM_UDEF6_IsChanged){sbParameter.Append("PUM_UDEF6=@PUM_UDEF6, ");}
      if(pU_Main.PUM_UDEF7_IsChanged){sbParameter.Append("PUM_UDEF7=@PUM_UDEF7, ");}
      if(pU_Main.PUM_UDEF8_IsChanged){sbParameter.Append("PUM_UDEF8=@PUM_UDEF8, ");}
      if(pU_Main.PUM_UDEF9_IsChanged){sbParameter.Append("PUM_UDEF9=@PUM_UDEF9, ");}
      if(pU_Main.PUM_UDEF10_IsChanged){sbParameter.Append("PUM_UDEF10=@PUM_UDEF10, ");}
      if(pU_Main.PUM_OwnerCode_IsChanged){sbParameter.Append("PUM_OwnerCode=@PUM_OwnerCode ");}          sb.Append(sbParameter.ToString().Trim().TrimEnd(',')); 
      sb.Append(      " WHERE 1=1 AND ((Stat is null) or (Stat=0))   and PUM_ID=@PUM_ID; " );
      string sql=sb.ToString();
         if(pU_Main.PUM_RType_IsChanged)
         {
         if (string.IsNullOrEmpty(pU_Main.PUM_RType))
         {
            idb.AddParameter("@PUM_RType", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PUM_RType", pU_Main.PUM_RType);
         }
          }
         if(pU_Main.PUM_RCode_IsChanged)
         {
         if (string.IsNullOrEmpty(pU_Main.PUM_RCode))
         {
            idb.AddParameter("@PUM_RCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PUM_RCode", pU_Main.PUM_RCode);
         }
          }
         if(pU_Main.PUM_Title_IsChanged)
         {
         if (string.IsNullOrEmpty(pU_Main.PUM_Title))
         {
            idb.AddParameter("@PUM_Title", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PUM_Title", pU_Main.PUM_Title);
         }
          }
         if(pU_Main.PUM_SCode_IsChanged)
         {
         if (string.IsNullOrEmpty(pU_Main.PUM_SCode))
         {
            idb.AddParameter("@PUM_SCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PUM_SCode", pU_Main.PUM_SCode);
         }
          }
         if(pU_Main.PUM_SName_IsChanged)
         {
         if (string.IsNullOrEmpty(pU_Main.PUM_SName))
         {
            idb.AddParameter("@PUM_SName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PUM_SName", pU_Main.PUM_SName);
         }
          }
         if(pU_Main.PUM_SContact_IsChanged)
         {
         if (string.IsNullOrEmpty(pU_Main.PUM_SContact))
         {
            idb.AddParameter("@PUM_SContact", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PUM_SContact", pU_Main.PUM_SContact);
         }
          }
         if(pU_Main.PUM_STel_IsChanged)
         {
         if (string.IsNullOrEmpty(pU_Main.PUM_STel))
         {
            idb.AddParameter("@PUM_STel", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PUM_STel", pU_Main.PUM_STel);
         }
          }
         if(pU_Main.PUM_State_IsChanged)
         {
         if (string.IsNullOrEmpty(pU_Main.PUM_State))
         {
            idb.AddParameter("@PUM_State", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PUM_State", pU_Main.PUM_State);
         }
          }
         if(pU_Main.PUM_PDate_IsChanged)
         {
         if (pU_Main.PUM_PDate == DateTime.MinValue)
         {
            idb.AddParameter("@PUM_PDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PUM_PDate", pU_Main.PUM_PDate);
         }
          }
         if(pU_Main.PUM_IDate_IsChanged)
         {
         if (pU_Main.PUM_IDate == DateTime.MinValue)
         {
            idb.AddParameter("@PUM_IDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PUM_IDate", pU_Main.PUM_IDate);
         }
          }
         if(pU_Main.PUM_RDate_IsChanged)
         {
         if (pU_Main.PUM_RDate == DateTime.MinValue)
         {
            idb.AddParameter("@PUM_RDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PUM_RDate", pU_Main.PUM_RDate);
         }
          }
         if(pU_Main.PUM_Owner_IsChanged)
         {
         if (string.IsNullOrEmpty(pU_Main.PUM_Owner))
         {
            idb.AddParameter("@PUM_Owner", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PUM_Owner", pU_Main.PUM_Owner);
         }
          }
         if(pU_Main.PUM_Tranfee_IsChanged)
         {
         if (pU_Main.PUM_Tranfee == 0)
         {
            idb.AddParameter("@PUM_Tranfee", 0);
         }
         else
         {
            idb.AddParameter("@PUM_Tranfee", pU_Main.PUM_Tranfee);
         }
          }
         if(pU_Main.PUM_Discount_IsChanged)
         {
         if (pU_Main.PUM_Discount == 0)
         {
            idb.AddParameter("@PUM_Discount", 0);
         }
         else
         {
            idb.AddParameter("@PUM_Discount", pU_Main.PUM_Discount);
         }
          }
         if(pU_Main.PUM_DisSum_IsChanged)
         {
         if (pU_Main.PUM_DisSum == 0)
         {
            idb.AddParameter("@PUM_DisSum", 0);
         }
         else
         {
            idb.AddParameter("@PUM_DisSum", pU_Main.PUM_DisSum);
         }
          }
         if(pU_Main.PUM_Tax_IsChanged)
         {
         if (pU_Main.PUM_Tax == 0)
         {
            idb.AddParameter("@PUM_Tax", 0);
         }
         else
         {
            idb.AddParameter("@PUM_Tax", pU_Main.PUM_Tax);
         }
          }
         if(pU_Main.PUM_Payable_IsChanged)
         {
         if (pU_Main.PUM_Payable == 0)
         {
            idb.AddParameter("@PUM_Payable", 0);
         }
         else
         {
            idb.AddParameter("@PUM_Payable", pU_Main.PUM_Payable);
         }
          }
         if(pU_Main.PUM_Bak_IsChanged)
         {
         if (string.IsNullOrEmpty(pU_Main.PUM_Bak))
         {
            idb.AddParameter("@PUM_Bak", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PUM_Bak", pU_Main.PUM_Bak);
         }
          }
         if(pU_Main.PUM_BOwner_IsChanged)
         {
         if (string.IsNullOrEmpty(pU_Main.PUM_BOwner))
         {
            idb.AddParameter("@PUM_BOwner", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PUM_BOwner", pU_Main.PUM_BOwner);
         }
          }
         if(pU_Main.PUM_RefType_IsChanged)
         {
         if (string.IsNullOrEmpty(pU_Main.PUM_RefType))
         {
            idb.AddParameter("@PUM_RefType", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PUM_RefType", pU_Main.PUM_RefType);
         }
          }
         if(pU_Main.PUM_RefCode_IsChanged)
         {
         if (string.IsNullOrEmpty(pU_Main.PUM_RefCode))
         {
            idb.AddParameter("@PUM_RefCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PUM_RefCode", pU_Main.PUM_RefCode);
         }
          }
         if(pU_Main.AuditStat_IsChanged)
         {
         if (string.IsNullOrEmpty(pU_Main.AuditStat))
         {
            idb.AddParameter("@AuditStat", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AuditStat", pU_Main.AuditStat);
         }
          }
         if(pU_Main.AuditCurAudit_IsChanged)
         {
         if (string.IsNullOrEmpty(pU_Main.AuditCurAudit))
         {
            idb.AddParameter("@AuditCurAudit", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AuditCurAudit", pU_Main.AuditCurAudit);
         }
          }
         if(pU_Main.PUM_Company_IsChanged)
         {
         if (string.IsNullOrEmpty(pU_Main.PUM_Company))
         {
            idb.AddParameter("@PUM_Company", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PUM_Company", pU_Main.PUM_Company);
         }
          }
         if(pU_Main.PUM_Dept_IsChanged)
         {
         if (string.IsNullOrEmpty(pU_Main.PUM_Dept))
         {
            idb.AddParameter("@PUM_Dept", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PUM_Dept", pU_Main.PUM_Dept);
         }
          }
         if(pU_Main.PUM_User_IsChanged)
         {
         if (string.IsNullOrEmpty(pU_Main.PUM_User))
         {
            idb.AddParameter("@PUM_User", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PUM_User", pU_Main.PUM_User);
         }
          }
         if(pU_Main.PUM_UseType_IsChanged)
         {
         if (string.IsNullOrEmpty(pU_Main.PUM_UseType))
         {
            idb.AddParameter("@PUM_UseType", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PUM_UseType", pU_Main.PUM_UseType);
         }
          }
         if(pU_Main.Stat_IsChanged)
         {
         if (pU_Main.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", pU_Main.Stat);
         }
          }
         if(pU_Main.CreateDate_IsChanged)
         {
         if (pU_Main.CreateDate == DateTime.MinValue)
         {
            idb.AddParameter("@CreateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateDate", pU_Main.CreateDate);
         }
          }
         if(pU_Main.UpdateDate_IsChanged)
         {
         if (pU_Main.UpdateDate == DateTime.MinValue)
         {
            idb.AddParameter("@UpdateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@UpdateDate", pU_Main.UpdateDate);
         }
          }
         if(pU_Main.DeleteDate_IsChanged)
         {
         if (pU_Main.DeleteDate == DateTime.MinValue)
         {
            idb.AddParameter("@DeleteDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DeleteDate", pU_Main.DeleteDate);
         }
          }
         if(pU_Main.PUM_CompanyCode_IsChanged)
         {
         if (string.IsNullOrEmpty(pU_Main.PUM_CompanyCode))
         {
            idb.AddParameter("@PUM_CompanyCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PUM_CompanyCode", pU_Main.PUM_CompanyCode);
         }
          }
         if(pU_Main.PUM_DeptCode_IsChanged)
         {
         if (string.IsNullOrEmpty(pU_Main.PUM_DeptCode))
         {
            idb.AddParameter("@PUM_DeptCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PUM_DeptCode", pU_Main.PUM_DeptCode);
         }
          }
         if(pU_Main.PUM_Type_IsChanged)
         {
         if (string.IsNullOrEmpty(pU_Main.PUM_Type))
         {
            idb.AddParameter("@PUM_Type", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PUM_Type", pU_Main.PUM_Type);
         }
          }
         if(pU_Main.PUM_Operator_IsChanged)
         {
         if (string.IsNullOrEmpty(pU_Main.PUM_Operator))
         {
            idb.AddParameter("@PUM_Operator", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PUM_Operator", pU_Main.PUM_Operator);
         }
          }
         if(pU_Main.PUM_OCode_IsChanged)
         {
         if (string.IsNullOrEmpty(pU_Main.PUM_OCode))
         {
            idb.AddParameter("@PUM_OCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PUM_OCode", pU_Main.PUM_OCode);
         }
          }
         if(pU_Main.PUM_OpDate_IsChanged)
         {
         if (pU_Main.PUM_OpDate == DateTime.MinValue)
         {
            idb.AddParameter("@PUM_OpDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PUM_OpDate", pU_Main.PUM_OpDate);
         }
          }
         if(pU_Main.PUM_UDEF1_IsChanged)
         {
         if (string.IsNullOrEmpty(pU_Main.PUM_UDEF1))
         {
            idb.AddParameter("@PUM_UDEF1", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PUM_UDEF1", pU_Main.PUM_UDEF1);
         }
          }
         if(pU_Main.PUM_UDEF2_IsChanged)
         {
         if (string.IsNullOrEmpty(pU_Main.PUM_UDEF2))
         {
            idb.AddParameter("@PUM_UDEF2", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PUM_UDEF2", pU_Main.PUM_UDEF2);
         }
          }
         if(pU_Main.PUM_UDEF3_IsChanged)
         {
         if (string.IsNullOrEmpty(pU_Main.PUM_UDEF3))
         {
            idb.AddParameter("@PUM_UDEF3", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PUM_UDEF3", pU_Main.PUM_UDEF3);
         }
          }
         if(pU_Main.PUM_UDEF4_IsChanged)
         {
         if (string.IsNullOrEmpty(pU_Main.PUM_UDEF4))
         {
            idb.AddParameter("@PUM_UDEF4", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PUM_UDEF4", pU_Main.PUM_UDEF4);
         }
          }
         if(pU_Main.PUM_UDEF5_IsChanged)
         {
         if (string.IsNullOrEmpty(pU_Main.PUM_UDEF5))
         {
            idb.AddParameter("@PUM_UDEF5", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PUM_UDEF5", pU_Main.PUM_UDEF5);
         }
          }
         if(pU_Main.PUM_UDEF6_IsChanged)
         {
         if (string.IsNullOrEmpty(pU_Main.PUM_UDEF6))
         {
            idb.AddParameter("@PUM_UDEF6", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PUM_UDEF6", pU_Main.PUM_UDEF6);
         }
          }
         if(pU_Main.PUM_UDEF7_IsChanged)
         {
         if (string.IsNullOrEmpty(pU_Main.PUM_UDEF7))
         {
            idb.AddParameter("@PUM_UDEF7", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PUM_UDEF7", pU_Main.PUM_UDEF7);
         }
          }
         if(pU_Main.PUM_UDEF8_IsChanged)
         {
         if (string.IsNullOrEmpty(pU_Main.PUM_UDEF8))
         {
            idb.AddParameter("@PUM_UDEF8", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PUM_UDEF8", pU_Main.PUM_UDEF8);
         }
          }
         if(pU_Main.PUM_UDEF9_IsChanged)
         {
         if (string.IsNullOrEmpty(pU_Main.PUM_UDEF9))
         {
            idb.AddParameter("@PUM_UDEF9", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PUM_UDEF9", pU_Main.PUM_UDEF9);
         }
          }
         if(pU_Main.PUM_UDEF10_IsChanged)
         {
         if (string.IsNullOrEmpty(pU_Main.PUM_UDEF10))
         {
            idb.AddParameter("@PUM_UDEF10", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PUM_UDEF10", pU_Main.PUM_UDEF10);
         }
          }
         if(pU_Main.PUM_OwnerCode_IsChanged)
         {
         if (string.IsNullOrEmpty(pU_Main.PUM_OwnerCode))
         {
            idb.AddParameter("@PUM_OwnerCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PUM_OwnerCode", pU_Main.PUM_OwnerCode);
         }
          }

         idb.AddParameter("@PUM_ID", pU_Main.PUM_ID);

           
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
      /// 删除供应商往来主表 PU_Main对象(即:一条记录
      /// </summary>
      public int Delete(decimal pUM_ID)
      {
         string sql = "DELETE PU_Main WHERE 1=1  AND PUM_ID=@PUM_ID ";
         idb.AddParameter("@PUM_ID", pUM_ID);

           
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
      /// 获取指定的供应商往来主表 PU_Main对象(即:一条记录
      /// </summary>
      public PU_Main GetByKey(decimal pUM_ID)
      {
         PU_Main pU_Main = new PU_Main();
         string sql = "SELECT  PUM_ID,PUM_RType,PUM_RCode,PUM_Title,PUM_SCode,PUM_SName,PUM_SContact,PUM_STel,PUM_State,PUM_PDate,PUM_IDate,PUM_RDate,PUM_Owner,PUM_Tranfee,PUM_Discount,PUM_DisSum,PUM_Tax,PUM_Payable,PUM_Bak,PUM_BOwner,PUM_RefType,PUM_RefCode,AuditStat,AuditCurAudit,PUM_Company,PUM_Dept,PUM_User,PUM_UseType,Stat,CreateDate,UpdateDate,DeleteDate,PUM_CompanyCode,PUM_DeptCode,PUM_Type,PUM_Operator,PUM_OCode,PUM_OpDate,PUM_UDEF1,PUM_UDEF2,PUM_UDEF3,PUM_UDEF4,PUM_UDEF5,PUM_UDEF6,PUM_UDEF7,PUM_UDEF8,PUM_UDEF9,PUM_UDEF10,PUM_OwnerCode FROM PU_Main WHERE 1=1 AND ((Stat is null) or (Stat=0) )  AND PUM_ID=@PUM_ID ";
         idb.AddParameter("@PUM_ID", pUM_ID);

          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            if (dr["PUM_ID"] != DBNull.Value) pU_Main.PUM_ID = Convert.ToDecimal(dr["PUM_ID"]);
            if (dr["PUM_RType"] != DBNull.Value) pU_Main.PUM_RType = Convert.ToString(dr["PUM_RType"]);
            if (dr["PUM_RCode"] != DBNull.Value) pU_Main.PUM_RCode = Convert.ToString(dr["PUM_RCode"]);
            if (dr["PUM_Title"] != DBNull.Value) pU_Main.PUM_Title = Convert.ToString(dr["PUM_Title"]);
            if (dr["PUM_SCode"] != DBNull.Value) pU_Main.PUM_SCode = Convert.ToString(dr["PUM_SCode"]);
            if (dr["PUM_SName"] != DBNull.Value) pU_Main.PUM_SName = Convert.ToString(dr["PUM_SName"]);
            if (dr["PUM_SContact"] != DBNull.Value) pU_Main.PUM_SContact = Convert.ToString(dr["PUM_SContact"]);
            if (dr["PUM_STel"] != DBNull.Value) pU_Main.PUM_STel = Convert.ToString(dr["PUM_STel"]);
            if (dr["PUM_State"] != DBNull.Value) pU_Main.PUM_State = Convert.ToString(dr["PUM_State"]);
            if (dr["PUM_PDate"] != DBNull.Value) pU_Main.PUM_PDate = Convert.ToDateTime(dr["PUM_PDate"]);
            if (dr["PUM_IDate"] != DBNull.Value) pU_Main.PUM_IDate = Convert.ToDateTime(dr["PUM_IDate"]);
            if (dr["PUM_RDate"] != DBNull.Value) pU_Main.PUM_RDate = Convert.ToDateTime(dr["PUM_RDate"]);
            if (dr["PUM_Owner"] != DBNull.Value) pU_Main.PUM_Owner = Convert.ToString(dr["PUM_Owner"]);
            if (dr["PUM_Tranfee"] != DBNull.Value) pU_Main.PUM_Tranfee = Convert.ToDecimal(dr["PUM_Tranfee"]);
            if (dr["PUM_Discount"] != DBNull.Value) pU_Main.PUM_Discount = Convert.ToDecimal(dr["PUM_Discount"]);
            if (dr["PUM_DisSum"] != DBNull.Value) pU_Main.PUM_DisSum = Convert.ToDecimal(dr["PUM_DisSum"]);
            if (dr["PUM_Tax"] != DBNull.Value) pU_Main.PUM_Tax = Convert.ToDecimal(dr["PUM_Tax"]);
            if (dr["PUM_Payable"] != DBNull.Value) pU_Main.PUM_Payable = Convert.ToDecimal(dr["PUM_Payable"]);
            if (dr["PUM_Bak"] != DBNull.Value) pU_Main.PUM_Bak = Convert.ToString(dr["PUM_Bak"]);
            if (dr["PUM_BOwner"] != DBNull.Value) pU_Main.PUM_BOwner = Convert.ToString(dr["PUM_BOwner"]);
            if (dr["PUM_RefType"] != DBNull.Value) pU_Main.PUM_RefType = Convert.ToString(dr["PUM_RefType"]);
            if (dr["PUM_RefCode"] != DBNull.Value) pU_Main.PUM_RefCode = Convert.ToString(dr["PUM_RefCode"]);
            if (dr["AuditStat"] != DBNull.Value) pU_Main.AuditStat = Convert.ToString(dr["AuditStat"]);
            if (dr["AuditCurAudit"] != DBNull.Value) pU_Main.AuditCurAudit = Convert.ToString(dr["AuditCurAudit"]);
            if (dr["PUM_Company"] != DBNull.Value) pU_Main.PUM_Company = Convert.ToString(dr["PUM_Company"]);
            if (dr["PUM_Dept"] != DBNull.Value) pU_Main.PUM_Dept = Convert.ToString(dr["PUM_Dept"]);
            if (dr["PUM_User"] != DBNull.Value) pU_Main.PUM_User = Convert.ToString(dr["PUM_User"]);
            if (dr["PUM_UseType"] != DBNull.Value) pU_Main.PUM_UseType = Convert.ToString(dr["PUM_UseType"]);
            if (dr["Stat"] != DBNull.Value) pU_Main.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["CreateDate"] != DBNull.Value) pU_Main.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
            if (dr["UpdateDate"] != DBNull.Value) pU_Main.UpdateDate = Convert.ToDateTime(dr["UpdateDate"]);
            if (dr["DeleteDate"] != DBNull.Value) pU_Main.DeleteDate = Convert.ToDateTime(dr["DeleteDate"]);
            if (dr["PUM_CompanyCode"] != DBNull.Value) pU_Main.PUM_CompanyCode = Convert.ToString(dr["PUM_CompanyCode"]);
            if (dr["PUM_DeptCode"] != DBNull.Value) pU_Main.PUM_DeptCode = Convert.ToString(dr["PUM_DeptCode"]);
            if (dr["PUM_Type"] != DBNull.Value) pU_Main.PUM_Type = Convert.ToString(dr["PUM_Type"]);
            if (dr["PUM_Operator"] != DBNull.Value) pU_Main.PUM_Operator = Convert.ToString(dr["PUM_Operator"]);
            if (dr["PUM_OCode"] != DBNull.Value) pU_Main.PUM_OCode = Convert.ToString(dr["PUM_OCode"]);
            if (dr["PUM_OpDate"] != DBNull.Value) pU_Main.PUM_OpDate = Convert.ToDateTime(dr["PUM_OpDate"]);
            if (dr["PUM_UDEF1"] != DBNull.Value) pU_Main.PUM_UDEF1 = Convert.ToString(dr["PUM_UDEF1"]);
            if (dr["PUM_UDEF2"] != DBNull.Value) pU_Main.PUM_UDEF2 = Convert.ToString(dr["PUM_UDEF2"]);
            if (dr["PUM_UDEF3"] != DBNull.Value) pU_Main.PUM_UDEF3 = Convert.ToString(dr["PUM_UDEF3"]);
            if (dr["PUM_UDEF4"] != DBNull.Value) pU_Main.PUM_UDEF4 = Convert.ToString(dr["PUM_UDEF4"]);
            if (dr["PUM_UDEF5"] != DBNull.Value) pU_Main.PUM_UDEF5 = Convert.ToString(dr["PUM_UDEF5"]);
            if (dr["PUM_UDEF6"] != DBNull.Value) pU_Main.PUM_UDEF6 = Convert.ToString(dr["PUM_UDEF6"]);
            if (dr["PUM_UDEF7"] != DBNull.Value) pU_Main.PUM_UDEF7 = Convert.ToString(dr["PUM_UDEF7"]);
            if (dr["PUM_UDEF8"] != DBNull.Value) pU_Main.PUM_UDEF8 = Convert.ToString(dr["PUM_UDEF8"]);
            if (dr["PUM_UDEF9"] != DBNull.Value) pU_Main.PUM_UDEF9 = Convert.ToString(dr["PUM_UDEF9"]);
            if (dr["PUM_UDEF10"] != DBNull.Value) pU_Main.PUM_UDEF10 = Convert.ToString(dr["PUM_UDEF10"]);
            if (dr["PUM_OwnerCode"] != DBNull.Value) pU_Main.PUM_OwnerCode = Convert.ToString(dr["PUM_OwnerCode"]);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   }  
         return pU_Main;
      }
      /// <summary>
      /// 获取指定的供应商往来主表 PU_Main对象集合
      /// </summary>
      public List<PU_Main> GetListByWhere(string strCondition)
      {
         List<PU_Main> ret = new List<PU_Main>();
         string sql = "SELECT  PUM_ID,PUM_RType,PUM_RCode,PUM_Title,PUM_SCode,PUM_SName,PUM_SContact,PUM_STel,PUM_State,PUM_PDate,PUM_IDate,PUM_RDate,PUM_Owner,PUM_Tranfee,PUM_Discount,PUM_DisSum,PUM_Tax,PUM_Payable,PUM_Bak,PUM_BOwner,PUM_RefType,PUM_RefCode,AuditStat,AuditCurAudit,PUM_Company,PUM_Dept,PUM_User,PUM_UseType,Stat,CreateDate,UpdateDate,DeleteDate,PUM_CompanyCode,PUM_DeptCode,PUM_Type,PUM_Operator,PUM_OCode,PUM_OpDate,PUM_UDEF1,PUM_UDEF2,PUM_UDEF3,PUM_UDEF4,PUM_UDEF5,PUM_UDEF6,PUM_UDEF7,PUM_UDEF8,PUM_UDEF9,PUM_UDEF10,PUM_OwnerCode FROM PU_Main WHERE 1=1 AND ((Stat is null) or (Stat=0) ) ";
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
            PU_Main pU_Main = new PU_Main();
            if (dr["PUM_ID"] != DBNull.Value) pU_Main.PUM_ID = Convert.ToDecimal(dr["PUM_ID"]);
            if (dr["PUM_RType"] != DBNull.Value) pU_Main.PUM_RType = Convert.ToString(dr["PUM_RType"]);
            if (dr["PUM_RCode"] != DBNull.Value) pU_Main.PUM_RCode = Convert.ToString(dr["PUM_RCode"]);
            if (dr["PUM_Title"] != DBNull.Value) pU_Main.PUM_Title = Convert.ToString(dr["PUM_Title"]);
            if (dr["PUM_SCode"] != DBNull.Value) pU_Main.PUM_SCode = Convert.ToString(dr["PUM_SCode"]);
            if (dr["PUM_SName"] != DBNull.Value) pU_Main.PUM_SName = Convert.ToString(dr["PUM_SName"]);
            if (dr["PUM_SContact"] != DBNull.Value) pU_Main.PUM_SContact = Convert.ToString(dr["PUM_SContact"]);
            if (dr["PUM_STel"] != DBNull.Value) pU_Main.PUM_STel = Convert.ToString(dr["PUM_STel"]);
            if (dr["PUM_State"] != DBNull.Value) pU_Main.PUM_State = Convert.ToString(dr["PUM_State"]);
            if (dr["PUM_PDate"] != DBNull.Value) pU_Main.PUM_PDate = Convert.ToDateTime(dr["PUM_PDate"]);
            if (dr["PUM_IDate"] != DBNull.Value) pU_Main.PUM_IDate = Convert.ToDateTime(dr["PUM_IDate"]);
            if (dr["PUM_RDate"] != DBNull.Value) pU_Main.PUM_RDate = Convert.ToDateTime(dr["PUM_RDate"]);
            if (dr["PUM_Owner"] != DBNull.Value) pU_Main.PUM_Owner = Convert.ToString(dr["PUM_Owner"]);
            if (dr["PUM_Tranfee"] != DBNull.Value) pU_Main.PUM_Tranfee = Convert.ToDecimal(dr["PUM_Tranfee"]);
            if (dr["PUM_Discount"] != DBNull.Value) pU_Main.PUM_Discount = Convert.ToDecimal(dr["PUM_Discount"]);
            if (dr["PUM_DisSum"] != DBNull.Value) pU_Main.PUM_DisSum = Convert.ToDecimal(dr["PUM_DisSum"]);
            if (dr["PUM_Tax"] != DBNull.Value) pU_Main.PUM_Tax = Convert.ToDecimal(dr["PUM_Tax"]);
            if (dr["PUM_Payable"] != DBNull.Value) pU_Main.PUM_Payable = Convert.ToDecimal(dr["PUM_Payable"]);
            if (dr["PUM_Bak"] != DBNull.Value) pU_Main.PUM_Bak = Convert.ToString(dr["PUM_Bak"]);
            if (dr["PUM_BOwner"] != DBNull.Value) pU_Main.PUM_BOwner = Convert.ToString(dr["PUM_BOwner"]);
            if (dr["PUM_RefType"] != DBNull.Value) pU_Main.PUM_RefType = Convert.ToString(dr["PUM_RefType"]);
            if (dr["PUM_RefCode"] != DBNull.Value) pU_Main.PUM_RefCode = Convert.ToString(dr["PUM_RefCode"]);
            if (dr["AuditStat"] != DBNull.Value) pU_Main.AuditStat = Convert.ToString(dr["AuditStat"]);
            if (dr["AuditCurAudit"] != DBNull.Value) pU_Main.AuditCurAudit = Convert.ToString(dr["AuditCurAudit"]);
            if (dr["PUM_Company"] != DBNull.Value) pU_Main.PUM_Company = Convert.ToString(dr["PUM_Company"]);
            if (dr["PUM_Dept"] != DBNull.Value) pU_Main.PUM_Dept = Convert.ToString(dr["PUM_Dept"]);
            if (dr["PUM_User"] != DBNull.Value) pU_Main.PUM_User = Convert.ToString(dr["PUM_User"]);
            if (dr["PUM_UseType"] != DBNull.Value) pU_Main.PUM_UseType = Convert.ToString(dr["PUM_UseType"]);
            if (dr["Stat"] != DBNull.Value) pU_Main.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["CreateDate"] != DBNull.Value) pU_Main.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
            if (dr["UpdateDate"] != DBNull.Value) pU_Main.UpdateDate = Convert.ToDateTime(dr["UpdateDate"]);
            if (dr["DeleteDate"] != DBNull.Value) pU_Main.DeleteDate = Convert.ToDateTime(dr["DeleteDate"]);
            if (dr["PUM_CompanyCode"] != DBNull.Value) pU_Main.PUM_CompanyCode = Convert.ToString(dr["PUM_CompanyCode"]);
            if (dr["PUM_DeptCode"] != DBNull.Value) pU_Main.PUM_DeptCode = Convert.ToString(dr["PUM_DeptCode"]);
            if (dr["PUM_Type"] != DBNull.Value) pU_Main.PUM_Type = Convert.ToString(dr["PUM_Type"]);
            if (dr["PUM_Operator"] != DBNull.Value) pU_Main.PUM_Operator = Convert.ToString(dr["PUM_Operator"]);
            if (dr["PUM_OCode"] != DBNull.Value) pU_Main.PUM_OCode = Convert.ToString(dr["PUM_OCode"]);
            if (dr["PUM_OpDate"] != DBNull.Value) pU_Main.PUM_OpDate = Convert.ToDateTime(dr["PUM_OpDate"]);
            if (dr["PUM_UDEF1"] != DBNull.Value) pU_Main.PUM_UDEF1 = Convert.ToString(dr["PUM_UDEF1"]);
            if (dr["PUM_UDEF2"] != DBNull.Value) pU_Main.PUM_UDEF2 = Convert.ToString(dr["PUM_UDEF2"]);
            if (dr["PUM_UDEF3"] != DBNull.Value) pU_Main.PUM_UDEF3 = Convert.ToString(dr["PUM_UDEF3"]);
            if (dr["PUM_UDEF4"] != DBNull.Value) pU_Main.PUM_UDEF4 = Convert.ToString(dr["PUM_UDEF4"]);
            if (dr["PUM_UDEF5"] != DBNull.Value) pU_Main.PUM_UDEF5 = Convert.ToString(dr["PUM_UDEF5"]);
            if (dr["PUM_UDEF6"] != DBNull.Value) pU_Main.PUM_UDEF6 = Convert.ToString(dr["PUM_UDEF6"]);
            if (dr["PUM_UDEF7"] != DBNull.Value) pU_Main.PUM_UDEF7 = Convert.ToString(dr["PUM_UDEF7"]);
            if (dr["PUM_UDEF8"] != DBNull.Value) pU_Main.PUM_UDEF8 = Convert.ToString(dr["PUM_UDEF8"]);
            if (dr["PUM_UDEF9"] != DBNull.Value) pU_Main.PUM_UDEF9 = Convert.ToString(dr["PUM_UDEF9"]);
            if (dr["PUM_UDEF10"] != DBNull.Value) pU_Main.PUM_UDEF10 = Convert.ToString(dr["PUM_UDEF10"]);
            if (dr["PUM_OwnerCode"] != DBNull.Value) pU_Main.PUM_OwnerCode = Convert.ToString(dr["PUM_OwnerCode"]);
            ret.Add(pU_Main);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   }  
         return ret;
      }
      /// <summary>
      /// 获取所有的供应商往来主表 PU_Main对象(即:一条记录
      /// </summary>
      public List<PU_Main> GetAll()
      {
         List<PU_Main> ret = new List<PU_Main>();
         string sql = "SELECT  PUM_ID,PUM_RType,PUM_RCode,PUM_Title,PUM_SCode,PUM_SName,PUM_SContact,PUM_STel,PUM_State,PUM_PDate,PUM_IDate,PUM_RDate,PUM_Owner,PUM_Tranfee,PUM_Discount,PUM_DisSum,PUM_Tax,PUM_Payable,PUM_Bak,PUM_BOwner,PUM_RefType,PUM_RefCode,AuditStat,AuditCurAudit,PUM_Company,PUM_Dept,PUM_User,PUM_UseType,Stat,CreateDate,UpdateDate,DeleteDate,PUM_CompanyCode,PUM_DeptCode,PUM_Type,PUM_Operator,PUM_OCode,PUM_OpDate,PUM_UDEF1,PUM_UDEF2,PUM_UDEF3,PUM_UDEF4,PUM_UDEF5,PUM_UDEF6,PUM_UDEF7,PUM_UDEF8,PUM_UDEF9,PUM_UDEF10,PUM_OwnerCode FROM PU_Main where 1=1 AND ((Stat is null) or (Stat=0) ) order by PUM_ID desc ";
          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            PU_Main pU_Main = new PU_Main();
            if (dr["PUM_ID"] != DBNull.Value) pU_Main.PUM_ID = Convert.ToDecimal(dr["PUM_ID"]);
            if (dr["PUM_RType"] != DBNull.Value) pU_Main.PUM_RType = Convert.ToString(dr["PUM_RType"]);
            if (dr["PUM_RCode"] != DBNull.Value) pU_Main.PUM_RCode = Convert.ToString(dr["PUM_RCode"]);
            if (dr["PUM_Title"] != DBNull.Value) pU_Main.PUM_Title = Convert.ToString(dr["PUM_Title"]);
            if (dr["PUM_SCode"] != DBNull.Value) pU_Main.PUM_SCode = Convert.ToString(dr["PUM_SCode"]);
            if (dr["PUM_SName"] != DBNull.Value) pU_Main.PUM_SName = Convert.ToString(dr["PUM_SName"]);
            if (dr["PUM_SContact"] != DBNull.Value) pU_Main.PUM_SContact = Convert.ToString(dr["PUM_SContact"]);
            if (dr["PUM_STel"] != DBNull.Value) pU_Main.PUM_STel = Convert.ToString(dr["PUM_STel"]);
            if (dr["PUM_State"] != DBNull.Value) pU_Main.PUM_State = Convert.ToString(dr["PUM_State"]);
            if (dr["PUM_PDate"] != DBNull.Value) pU_Main.PUM_PDate = Convert.ToDateTime(dr["PUM_PDate"]);
            if (dr["PUM_IDate"] != DBNull.Value) pU_Main.PUM_IDate = Convert.ToDateTime(dr["PUM_IDate"]);
            if (dr["PUM_RDate"] != DBNull.Value) pU_Main.PUM_RDate = Convert.ToDateTime(dr["PUM_RDate"]);
            if (dr["PUM_Owner"] != DBNull.Value) pU_Main.PUM_Owner = Convert.ToString(dr["PUM_Owner"]);
            if (dr["PUM_Tranfee"] != DBNull.Value) pU_Main.PUM_Tranfee = Convert.ToDecimal(dr["PUM_Tranfee"]);
            if (dr["PUM_Discount"] != DBNull.Value) pU_Main.PUM_Discount = Convert.ToDecimal(dr["PUM_Discount"]);
            if (dr["PUM_DisSum"] != DBNull.Value) pU_Main.PUM_DisSum = Convert.ToDecimal(dr["PUM_DisSum"]);
            if (dr["PUM_Tax"] != DBNull.Value) pU_Main.PUM_Tax = Convert.ToDecimal(dr["PUM_Tax"]);
            if (dr["PUM_Payable"] != DBNull.Value) pU_Main.PUM_Payable = Convert.ToDecimal(dr["PUM_Payable"]);
            if (dr["PUM_Bak"] != DBNull.Value) pU_Main.PUM_Bak = Convert.ToString(dr["PUM_Bak"]);
            if (dr["PUM_BOwner"] != DBNull.Value) pU_Main.PUM_BOwner = Convert.ToString(dr["PUM_BOwner"]);
            if (dr["PUM_RefType"] != DBNull.Value) pU_Main.PUM_RefType = Convert.ToString(dr["PUM_RefType"]);
            if (dr["PUM_RefCode"] != DBNull.Value) pU_Main.PUM_RefCode = Convert.ToString(dr["PUM_RefCode"]);
            if (dr["AuditStat"] != DBNull.Value) pU_Main.AuditStat = Convert.ToString(dr["AuditStat"]);
            if (dr["AuditCurAudit"] != DBNull.Value) pU_Main.AuditCurAudit = Convert.ToString(dr["AuditCurAudit"]);
            if (dr["PUM_Company"] != DBNull.Value) pU_Main.PUM_Company = Convert.ToString(dr["PUM_Company"]);
            if (dr["PUM_Dept"] != DBNull.Value) pU_Main.PUM_Dept = Convert.ToString(dr["PUM_Dept"]);
            if (dr["PUM_User"] != DBNull.Value) pU_Main.PUM_User = Convert.ToString(dr["PUM_User"]);
            if (dr["PUM_UseType"] != DBNull.Value) pU_Main.PUM_UseType = Convert.ToString(dr["PUM_UseType"]);
            if (dr["Stat"] != DBNull.Value) pU_Main.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["CreateDate"] != DBNull.Value) pU_Main.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
            if (dr["UpdateDate"] != DBNull.Value) pU_Main.UpdateDate = Convert.ToDateTime(dr["UpdateDate"]);
            if (dr["DeleteDate"] != DBNull.Value) pU_Main.DeleteDate = Convert.ToDateTime(dr["DeleteDate"]);
            if (dr["PUM_CompanyCode"] != DBNull.Value) pU_Main.PUM_CompanyCode = Convert.ToString(dr["PUM_CompanyCode"]);
            if (dr["PUM_DeptCode"] != DBNull.Value) pU_Main.PUM_DeptCode = Convert.ToString(dr["PUM_DeptCode"]);
            if (dr["PUM_Type"] != DBNull.Value) pU_Main.PUM_Type = Convert.ToString(dr["PUM_Type"]);
            if (dr["PUM_Operator"] != DBNull.Value) pU_Main.PUM_Operator = Convert.ToString(dr["PUM_Operator"]);
            if (dr["PUM_OCode"] != DBNull.Value) pU_Main.PUM_OCode = Convert.ToString(dr["PUM_OCode"]);
            if (dr["PUM_OpDate"] != DBNull.Value) pU_Main.PUM_OpDate = Convert.ToDateTime(dr["PUM_OpDate"]);
            if (dr["PUM_UDEF1"] != DBNull.Value) pU_Main.PUM_UDEF1 = Convert.ToString(dr["PUM_UDEF1"]);
            if (dr["PUM_UDEF2"] != DBNull.Value) pU_Main.PUM_UDEF2 = Convert.ToString(dr["PUM_UDEF2"]);
            if (dr["PUM_UDEF3"] != DBNull.Value) pU_Main.PUM_UDEF3 = Convert.ToString(dr["PUM_UDEF3"]);
            if (dr["PUM_UDEF4"] != DBNull.Value) pU_Main.PUM_UDEF4 = Convert.ToString(dr["PUM_UDEF4"]);
            if (dr["PUM_UDEF5"] != DBNull.Value) pU_Main.PUM_UDEF5 = Convert.ToString(dr["PUM_UDEF5"]);
            if (dr["PUM_UDEF6"] != DBNull.Value) pU_Main.PUM_UDEF6 = Convert.ToString(dr["PUM_UDEF6"]);
            if (dr["PUM_UDEF7"] != DBNull.Value) pU_Main.PUM_UDEF7 = Convert.ToString(dr["PUM_UDEF7"]);
            if (dr["PUM_UDEF8"] != DBNull.Value) pU_Main.PUM_UDEF8 = Convert.ToString(dr["PUM_UDEF8"]);
            if (dr["PUM_UDEF9"] != DBNull.Value) pU_Main.PUM_UDEF9 = Convert.ToString(dr["PUM_UDEF9"]);
            if (dr["PUM_UDEF10"] != DBNull.Value) pU_Main.PUM_UDEF10 = Convert.ToString(dr["PUM_UDEF10"]);
            if (dr["PUM_OwnerCode"] != DBNull.Value) pU_Main.PUM_OwnerCode = Convert.ToString(dr["PUM_OwnerCode"]);
            ret.Add(pU_Main);
         }
          }catch (System.Exception ex){ throw ex; }  finally {  if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   } 
         return ret;
      }
   }
}
