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
   /// 销售合同基本信息
   /// </summary>
   [Serializable]
   public partial class ADOSD_Contract
   {
      public IDBOperator idb =  DBOperator.GetInstance();
      /// <summary>
      /// 添加销售合同基本信息 SD_Contract对象(即:一条记录)
      /// </summary>
      public int Add(SD_Contract sD_Contract)
      {
         string sql = "INSERT INTO SD_Contract (SDC_iType,SDC_Code,SDC_CName,SDC_CCode,SDC_Date,SDC_Place,SC_OwnerCode,SDC_Owner,SDC_Dept,SDC_Start,SDC_End,SDC_EOwnerCode,SDC_EOwner,SDC_Num,SDC_TechDecision,SDC_TechCode,SDC_PayContent,SDC_COwner,SDC_CContact,SDC_Content,SDC_Description,SDC_Control,SDC_IsAFor,Audit1CurAudit,Audit1Stat,Audit1Date,Audit1Owner,AuditCurAudit,AuditStat,AuditDate,AuditOwner,Stat,CreateDate,UpdateDate,DeleteDate,CreateOwner,SDC_Stat,SDC_Type,SDC_Company,SDC_CompanyCode,SDC_TotalSend,SDC_LastSend,SDC_LastDate,SDC_Return,SDC_StartSend,SDC_EndSend,SDC_TotalDate,SDC_AgreeQuantity,SDC_PlanQuantity,SDC_SupQuantity,SDC_TotalMoney,SDC_PayMoney,SDC_SPayMoney,SDC_PayType,SDC_BType,SDC_BTypeName) VALUES (@SDC_iType,@SDC_Code,@SDC_CName,@SDC_CCode,@SDC_Date,@SDC_Place,@SC_OwnerCode,@SDC_Owner,@SDC_Dept,@SDC_Start,@SDC_End,@SDC_EOwnerCode,@SDC_EOwner,@SDC_Num,@SDC_TechDecision,@SDC_TechCode,@SDC_PayContent,@SDC_COwner,@SDC_CContact,@SDC_Content,@SDC_Description,@SDC_Control,@SDC_IsAFor,@Audit1CurAudit,@Audit1Stat,@Audit1Date,@Audit1Owner,@AuditCurAudit,@AuditStat,@AuditDate,@AuditOwner,@Stat,@CreateDate,@UpdateDate,@DeleteDate,@CreateOwner,@SDC_Stat,@SDC_Type,@SDC_Company,@SDC_CompanyCode,@SDC_TotalSend,@SDC_LastSend,@SDC_LastDate,@SDC_Return,@SDC_StartSend,@SDC_EndSend,@SDC_TotalDate,@SDC_AgreeQuantity,@SDC_PlanQuantity,@SDC_SupQuantity,@SDC_TotalMoney,@SDC_PayMoney,@SDC_SPayMoney,@SDC_PayType,@SDC_BType,@SDC_BTypeName)";
         if (string.IsNullOrEmpty(sD_Contract.SDC_iType))
         {
            idb.AddParameter("@SDC_iType", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDC_iType", sD_Contract.SDC_iType);
         }
         if (string.IsNullOrEmpty(sD_Contract.SDC_Code))
         {
            idb.AddParameter("@SDC_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDC_Code", sD_Contract.SDC_Code);
         }
         if (string.IsNullOrEmpty(sD_Contract.SDC_CName))
         {
            idb.AddParameter("@SDC_CName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDC_CName", sD_Contract.SDC_CName);
         }
         if (string.IsNullOrEmpty(sD_Contract.SDC_CCode))
         {
            idb.AddParameter("@SDC_CCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDC_CCode", sD_Contract.SDC_CCode);
         }
         if (sD_Contract.SDC_Date == DateTime.MinValue)
         {
            idb.AddParameter("@SDC_Date", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDC_Date", sD_Contract.SDC_Date);
         }
         if (string.IsNullOrEmpty(sD_Contract.SDC_Place))
         {
            idb.AddParameter("@SDC_Place", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDC_Place", sD_Contract.SDC_Place);
         }
         if (string.IsNullOrEmpty(sD_Contract.SC_OwnerCode))
         {
            idb.AddParameter("@SC_OwnerCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SC_OwnerCode", sD_Contract.SC_OwnerCode);
         }
         if (string.IsNullOrEmpty(sD_Contract.SDC_Owner))
         {
            idb.AddParameter("@SDC_Owner", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDC_Owner", sD_Contract.SDC_Owner);
         }
         if (string.IsNullOrEmpty(sD_Contract.SDC_Dept))
         {
            idb.AddParameter("@SDC_Dept", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDC_Dept", sD_Contract.SDC_Dept);
         }
         if (sD_Contract.SDC_Start == DateTime.MinValue)
         {
            idb.AddParameter("@SDC_Start", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDC_Start", sD_Contract.SDC_Start);
         }
         if (sD_Contract.SDC_End == DateTime.MinValue)
         {
            idb.AddParameter("@SDC_End", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDC_End", sD_Contract.SDC_End);
         }
         if (string.IsNullOrEmpty(sD_Contract.SDC_EOwnerCode))
         {
            idb.AddParameter("@SDC_EOwnerCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDC_EOwnerCode", sD_Contract.SDC_EOwnerCode);
         }
         if (string.IsNullOrEmpty(sD_Contract.SDC_EOwner))
         {
            idb.AddParameter("@SDC_EOwner", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDC_EOwner", sD_Contract.SDC_EOwner);
         }
         if (sD_Contract.SDC_Num == 0)
         {
            idb.AddParameter("@SDC_Num", 0);
         }
         else
         {
            idb.AddParameter("@SDC_Num", sD_Contract.SDC_Num);
         }
         if (string.IsNullOrEmpty(sD_Contract.SDC_TechDecision))
         {
            idb.AddParameter("@SDC_TechDecision", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDC_TechDecision", sD_Contract.SDC_TechDecision);
         }
         if (string.IsNullOrEmpty(sD_Contract.SDC_TechCode))
         {
            idb.AddParameter("@SDC_TechCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDC_TechCode", sD_Contract.SDC_TechCode);
         }
         if (string.IsNullOrEmpty(sD_Contract.SDC_PayContent))
         {
            idb.AddParameter("@SDC_PayContent", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDC_PayContent", sD_Contract.SDC_PayContent);
         }
         if (string.IsNullOrEmpty(sD_Contract.SDC_COwner))
         {
            idb.AddParameter("@SDC_COwner", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDC_COwner", sD_Contract.SDC_COwner);
         }
         if (string.IsNullOrEmpty(sD_Contract.SDC_CContact))
         {
            idb.AddParameter("@SDC_CContact", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDC_CContact", sD_Contract.SDC_CContact);
         }
         if (string.IsNullOrEmpty(sD_Contract.SDC_Content))
         {
            idb.AddParameter("@SDC_Content", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDC_Content", sD_Contract.SDC_Content);
         }
         if (string.IsNullOrEmpty(sD_Contract.SDC_Description))
         {
            idb.AddParameter("@SDC_Description", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDC_Description", sD_Contract.SDC_Description);
         }
         if (string.IsNullOrEmpty(sD_Contract.SDC_Control))
         {
            idb.AddParameter("@SDC_Control", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDC_Control", sD_Contract.SDC_Control);
         }
         if (string.IsNullOrEmpty(sD_Contract.SDC_IsAFor))
         {
            idb.AddParameter("@SDC_IsAFor", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDC_IsAFor", sD_Contract.SDC_IsAFor);
         }
         if (string.IsNullOrEmpty(sD_Contract.Audit1CurAudit))
         {
            idb.AddParameter("@Audit1CurAudit", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Audit1CurAudit", sD_Contract.Audit1CurAudit);
         }
         if (string.IsNullOrEmpty(sD_Contract.Audit1Stat))
         {
            idb.AddParameter("@Audit1Stat", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Audit1Stat", sD_Contract.Audit1Stat);
         }
         if (sD_Contract.Audit1Date == DateTime.MinValue)
         {
            idb.AddParameter("@Audit1Date", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Audit1Date", sD_Contract.Audit1Date);
         }
         if (string.IsNullOrEmpty(sD_Contract.Audit1Owner))
         {
            idb.AddParameter("@Audit1Owner", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Audit1Owner", sD_Contract.Audit1Owner);
         }
         if (string.IsNullOrEmpty(sD_Contract.AuditCurAudit))
         {
            idb.AddParameter("@AuditCurAudit", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AuditCurAudit", sD_Contract.AuditCurAudit);
         }
         if (string.IsNullOrEmpty(sD_Contract.AuditStat))
         {
            idb.AddParameter("@AuditStat", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AuditStat", sD_Contract.AuditStat);
         }
         if (sD_Contract.AuditDate == DateTime.MinValue)
         {
            idb.AddParameter("@AuditDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AuditDate", sD_Contract.AuditDate);
         }
         if (string.IsNullOrEmpty(sD_Contract.AuditOwner))
         {
            idb.AddParameter("@AuditOwner", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AuditOwner", sD_Contract.AuditOwner);
         }
         if (sD_Contract.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", sD_Contract.Stat);
         }
         if (sD_Contract.CreateDate == DateTime.MinValue)
         {
            idb.AddParameter("@CreateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateDate", sD_Contract.CreateDate);
         }
         if (sD_Contract.UpdateDate == DateTime.MinValue)
         {
            idb.AddParameter("@UpdateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@UpdateDate", sD_Contract.UpdateDate);
         }
         if (sD_Contract.DeleteDate == DateTime.MinValue)
         {
            idb.AddParameter("@DeleteDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DeleteDate", sD_Contract.DeleteDate);
         }
         if (string.IsNullOrEmpty(sD_Contract.CreateOwner))
         {
            idb.AddParameter("@CreateOwner", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateOwner", sD_Contract.CreateOwner);
         }
         if (string.IsNullOrEmpty(sD_Contract.SDC_Stat))
         {
            idb.AddParameter("@SDC_Stat", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDC_Stat", sD_Contract.SDC_Stat);
         }
         if (string.IsNullOrEmpty(sD_Contract.SDC_Type))
         {
            idb.AddParameter("@SDC_Type", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDC_Type", sD_Contract.SDC_Type);
         }
         if (string.IsNullOrEmpty(sD_Contract.SDC_Company))
         {
            idb.AddParameter("@SDC_Company", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDC_Company", sD_Contract.SDC_Company);
         }
         if (string.IsNullOrEmpty(sD_Contract.SDC_CompanyCode))
         {
            idb.AddParameter("@SDC_CompanyCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDC_CompanyCode", sD_Contract.SDC_CompanyCode);
         }
         if (string.IsNullOrEmpty(sD_Contract.SDC_TotalSend))
         {
            idb.AddParameter("@SDC_TotalSend", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDC_TotalSend", sD_Contract.SDC_TotalSend);
         }
         if (string.IsNullOrEmpty(sD_Contract.SDC_LastSend))
         {
            idb.AddParameter("@SDC_LastSend", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDC_LastSend", sD_Contract.SDC_LastSend);
         }
         if (sD_Contract.SDC_LastDate == DateTime.MinValue)
         {
            idb.AddParameter("@SDC_LastDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDC_LastDate", sD_Contract.SDC_LastDate);
         }
         if (string.IsNullOrEmpty(sD_Contract.SDC_Return))
         {
            idb.AddParameter("@SDC_Return", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDC_Return", sD_Contract.SDC_Return);
         }
         if (sD_Contract.SDC_StartSend == DateTime.MinValue)
         {
            idb.AddParameter("@SDC_StartSend", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDC_StartSend", sD_Contract.SDC_StartSend);
         }
         if (sD_Contract.SDC_EndSend == DateTime.MinValue)
         {
            idb.AddParameter("@SDC_EndSend", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDC_EndSend", sD_Contract.SDC_EndSend);
         }
         if (string.IsNullOrEmpty(sD_Contract.SDC_TotalDate))
         {
            idb.AddParameter("@SDC_TotalDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDC_TotalDate", sD_Contract.SDC_TotalDate);
         }
         if (string.IsNullOrEmpty(sD_Contract.SDC_AgreeQuantity))
         {
            idb.AddParameter("@SDC_AgreeQuantity", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDC_AgreeQuantity", sD_Contract.SDC_AgreeQuantity);
         }
         if (string.IsNullOrEmpty(sD_Contract.SDC_PlanQuantity))
         {
            idb.AddParameter("@SDC_PlanQuantity", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDC_PlanQuantity", sD_Contract.SDC_PlanQuantity);
         }
         if (string.IsNullOrEmpty(sD_Contract.SDC_SupQuantity))
         {
            idb.AddParameter("@SDC_SupQuantity", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDC_SupQuantity", sD_Contract.SDC_SupQuantity);
         }
         if (sD_Contract.SDC_TotalMoney == 0)
         {
            idb.AddParameter("@SDC_TotalMoney", 0);
         }
         else
         {
            idb.AddParameter("@SDC_TotalMoney", sD_Contract.SDC_TotalMoney);
         }
         if (sD_Contract.SDC_PayMoney == 0)
         {
            idb.AddParameter("@SDC_PayMoney", 0);
         }
         else
         {
            idb.AddParameter("@SDC_PayMoney", sD_Contract.SDC_PayMoney);
         }
         if (sD_Contract.SDC_SPayMoney == 0)
         {
            idb.AddParameter("@SDC_SPayMoney", 0);
         }
         else
         {
            idb.AddParameter("@SDC_SPayMoney", sD_Contract.SDC_SPayMoney);
         }
         if (string.IsNullOrEmpty(sD_Contract.SDC_PayType))
         {
            idb.AddParameter("@SDC_PayType", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDC_PayType", sD_Contract.SDC_PayType);
         }
         if (string.IsNullOrEmpty(sD_Contract.SDC_BType))
         {
            idb.AddParameter("@SDC_BType", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDC_BType", sD_Contract.SDC_BType);
         }
         if (string.IsNullOrEmpty(sD_Contract.SDC_BTypeName))
         {
            idb.AddParameter("@SDC_BTypeName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDC_BTypeName", sD_Contract.SDC_BTypeName);
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
      /// 添加销售合同基本信息 SD_Contract对象(即:一条记录)
      /// </summary>
      public object AddWithReturn(SD_Contract sD_Contract)
      {
         string sql = "INSERT INTO SD_Contract (SDC_iType,SDC_Code,SDC_CName,SDC_CCode,SDC_Date,SDC_Place,SC_OwnerCode,SDC_Owner,SDC_Dept,SDC_Start,SDC_End,SDC_EOwnerCode,SDC_EOwner,SDC_Num,SDC_TechDecision,SDC_TechCode,SDC_PayContent,SDC_COwner,SDC_CContact,SDC_Content,SDC_Description,SDC_Control,SDC_IsAFor,Audit1CurAudit,Audit1Stat,Audit1Date,Audit1Owner,AuditCurAudit,AuditStat,AuditDate,AuditOwner,Stat,CreateDate,UpdateDate,DeleteDate,CreateOwner,SDC_Stat,SDC_Type,SDC_Company,SDC_CompanyCode,SDC_TotalSend,SDC_LastSend,SDC_LastDate,SDC_Return,SDC_StartSend,SDC_EndSend,SDC_TotalDate,SDC_AgreeQuantity,SDC_PlanQuantity,SDC_SupQuantity,SDC_TotalMoney,SDC_PayMoney,SDC_SPayMoney,SDC_PayType,SDC_BType,SDC_BTypeName) VALUES (@SDC_iType,@SDC_Code,@SDC_CName,@SDC_CCode,@SDC_Date,@SDC_Place,@SC_OwnerCode,@SDC_Owner,@SDC_Dept,@SDC_Start,@SDC_End,@SDC_EOwnerCode,@SDC_EOwner,@SDC_Num,@SDC_TechDecision,@SDC_TechCode,@SDC_PayContent,@SDC_COwner,@SDC_CContact,@SDC_Content,@SDC_Description,@SDC_Control,@SDC_IsAFor,@Audit1CurAudit,@Audit1Stat,@Audit1Date,@Audit1Owner,@AuditCurAudit,@AuditStat,@AuditDate,@AuditOwner,@Stat,@CreateDate,@UpdateDate,@DeleteDate,@CreateOwner,@SDC_Stat,@SDC_Type,@SDC_Company,@SDC_CompanyCode,@SDC_TotalSend,@SDC_LastSend,@SDC_LastDate,@SDC_Return,@SDC_StartSend,@SDC_EndSend,@SDC_TotalDate,@SDC_AgreeQuantity,@SDC_PlanQuantity,@SDC_SupQuantity,@SDC_TotalMoney,@SDC_PayMoney,@SDC_SPayMoney,@SDC_PayType,@SDC_BType,@SDC_BTypeName);SELECT @@IDENTITY AS ReturnID;";
         if (string.IsNullOrEmpty(sD_Contract.SDC_iType))
         {
            idb.AddParameter("@SDC_iType", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDC_iType", sD_Contract.SDC_iType);
         }
         if (string.IsNullOrEmpty(sD_Contract.SDC_Code))
         {
            idb.AddParameter("@SDC_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDC_Code", sD_Contract.SDC_Code);
         }
         if (string.IsNullOrEmpty(sD_Contract.SDC_CName))
         {
            idb.AddParameter("@SDC_CName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDC_CName", sD_Contract.SDC_CName);
         }
         if (string.IsNullOrEmpty(sD_Contract.SDC_CCode))
         {
            idb.AddParameter("@SDC_CCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDC_CCode", sD_Contract.SDC_CCode);
         }
         if (sD_Contract.SDC_Date == DateTime.MinValue)
         {
            idb.AddParameter("@SDC_Date", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDC_Date", sD_Contract.SDC_Date);
         }
         if (string.IsNullOrEmpty(sD_Contract.SDC_Place))
         {
            idb.AddParameter("@SDC_Place", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDC_Place", sD_Contract.SDC_Place);
         }
         if (string.IsNullOrEmpty(sD_Contract.SC_OwnerCode))
         {
            idb.AddParameter("@SC_OwnerCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SC_OwnerCode", sD_Contract.SC_OwnerCode);
         }
         if (string.IsNullOrEmpty(sD_Contract.SDC_Owner))
         {
            idb.AddParameter("@SDC_Owner", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDC_Owner", sD_Contract.SDC_Owner);
         }
         if (string.IsNullOrEmpty(sD_Contract.SDC_Dept))
         {
            idb.AddParameter("@SDC_Dept", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDC_Dept", sD_Contract.SDC_Dept);
         }
         if (sD_Contract.SDC_Start == DateTime.MinValue)
         {
            idb.AddParameter("@SDC_Start", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDC_Start", sD_Contract.SDC_Start);
         }
         if (sD_Contract.SDC_End == DateTime.MinValue)
         {
            idb.AddParameter("@SDC_End", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDC_End", sD_Contract.SDC_End);
         }
         if (string.IsNullOrEmpty(sD_Contract.SDC_EOwnerCode))
         {
            idb.AddParameter("@SDC_EOwnerCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDC_EOwnerCode", sD_Contract.SDC_EOwnerCode);
         }
         if (string.IsNullOrEmpty(sD_Contract.SDC_EOwner))
         {
            idb.AddParameter("@SDC_EOwner", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDC_EOwner", sD_Contract.SDC_EOwner);
         }
         if (sD_Contract.SDC_Num == 0)
         {
            idb.AddParameter("@SDC_Num", 0);
         }
         else
         {
            idb.AddParameter("@SDC_Num", sD_Contract.SDC_Num);
         }
         if (string.IsNullOrEmpty(sD_Contract.SDC_TechDecision))
         {
            idb.AddParameter("@SDC_TechDecision", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDC_TechDecision", sD_Contract.SDC_TechDecision);
         }
         if (string.IsNullOrEmpty(sD_Contract.SDC_TechCode))
         {
            idb.AddParameter("@SDC_TechCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDC_TechCode", sD_Contract.SDC_TechCode);
         }
         if (string.IsNullOrEmpty(sD_Contract.SDC_PayContent))
         {
            idb.AddParameter("@SDC_PayContent", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDC_PayContent", sD_Contract.SDC_PayContent);
         }
         if (string.IsNullOrEmpty(sD_Contract.SDC_COwner))
         {
            idb.AddParameter("@SDC_COwner", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDC_COwner", sD_Contract.SDC_COwner);
         }
         if (string.IsNullOrEmpty(sD_Contract.SDC_CContact))
         {
            idb.AddParameter("@SDC_CContact", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDC_CContact", sD_Contract.SDC_CContact);
         }
         if (string.IsNullOrEmpty(sD_Contract.SDC_Content))
         {
            idb.AddParameter("@SDC_Content", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDC_Content", sD_Contract.SDC_Content);
         }
         if (string.IsNullOrEmpty(sD_Contract.SDC_Description))
         {
            idb.AddParameter("@SDC_Description", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDC_Description", sD_Contract.SDC_Description);
         }
         if (string.IsNullOrEmpty(sD_Contract.SDC_Control))
         {
            idb.AddParameter("@SDC_Control", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDC_Control", sD_Contract.SDC_Control);
         }
         if (string.IsNullOrEmpty(sD_Contract.SDC_IsAFor))
         {
            idb.AddParameter("@SDC_IsAFor", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDC_IsAFor", sD_Contract.SDC_IsAFor);
         }
         if (string.IsNullOrEmpty(sD_Contract.Audit1CurAudit))
         {
            idb.AddParameter("@Audit1CurAudit", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Audit1CurAudit", sD_Contract.Audit1CurAudit);
         }
         if (string.IsNullOrEmpty(sD_Contract.Audit1Stat))
         {
            idb.AddParameter("@Audit1Stat", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Audit1Stat", sD_Contract.Audit1Stat);
         }
         if (sD_Contract.Audit1Date == DateTime.MinValue)
         {
            idb.AddParameter("@Audit1Date", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Audit1Date", sD_Contract.Audit1Date);
         }
         if (string.IsNullOrEmpty(sD_Contract.Audit1Owner))
         {
            idb.AddParameter("@Audit1Owner", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Audit1Owner", sD_Contract.Audit1Owner);
         }
         if (string.IsNullOrEmpty(sD_Contract.AuditCurAudit))
         {
            idb.AddParameter("@AuditCurAudit", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AuditCurAudit", sD_Contract.AuditCurAudit);
         }
         if (string.IsNullOrEmpty(sD_Contract.AuditStat))
         {
            idb.AddParameter("@AuditStat", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AuditStat", sD_Contract.AuditStat);
         }
         if (sD_Contract.AuditDate == DateTime.MinValue)
         {
            idb.AddParameter("@AuditDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AuditDate", sD_Contract.AuditDate);
         }
         if (string.IsNullOrEmpty(sD_Contract.AuditOwner))
         {
            idb.AddParameter("@AuditOwner", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AuditOwner", sD_Contract.AuditOwner);
         }
         if (sD_Contract.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", sD_Contract.Stat);
         }
         if (sD_Contract.CreateDate == DateTime.MinValue)
         {
            idb.AddParameter("@CreateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateDate", sD_Contract.CreateDate);
         }
         if (sD_Contract.UpdateDate == DateTime.MinValue)
         {
            idb.AddParameter("@UpdateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@UpdateDate", sD_Contract.UpdateDate);
         }
         if (sD_Contract.DeleteDate == DateTime.MinValue)
         {
            idb.AddParameter("@DeleteDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DeleteDate", sD_Contract.DeleteDate);
         }
         if (string.IsNullOrEmpty(sD_Contract.CreateOwner))
         {
            idb.AddParameter("@CreateOwner", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateOwner", sD_Contract.CreateOwner);
         }
         if (string.IsNullOrEmpty(sD_Contract.SDC_Stat))
         {
            idb.AddParameter("@SDC_Stat", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDC_Stat", sD_Contract.SDC_Stat);
         }
         if (string.IsNullOrEmpty(sD_Contract.SDC_Type))
         {
            idb.AddParameter("@SDC_Type", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDC_Type", sD_Contract.SDC_Type);
         }
         if (string.IsNullOrEmpty(sD_Contract.SDC_Company))
         {
            idb.AddParameter("@SDC_Company", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDC_Company", sD_Contract.SDC_Company);
         }
         if (string.IsNullOrEmpty(sD_Contract.SDC_CompanyCode))
         {
            idb.AddParameter("@SDC_CompanyCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDC_CompanyCode", sD_Contract.SDC_CompanyCode);
         }
         if (string.IsNullOrEmpty(sD_Contract.SDC_TotalSend))
         {
            idb.AddParameter("@SDC_TotalSend", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDC_TotalSend", sD_Contract.SDC_TotalSend);
         }
         if (string.IsNullOrEmpty(sD_Contract.SDC_LastSend))
         {
            idb.AddParameter("@SDC_LastSend", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDC_LastSend", sD_Contract.SDC_LastSend);
         }
         if (sD_Contract.SDC_LastDate == DateTime.MinValue)
         {
            idb.AddParameter("@SDC_LastDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDC_LastDate", sD_Contract.SDC_LastDate);
         }
         if (string.IsNullOrEmpty(sD_Contract.SDC_Return))
         {
            idb.AddParameter("@SDC_Return", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDC_Return", sD_Contract.SDC_Return);
         }
         if (sD_Contract.SDC_StartSend == DateTime.MinValue)
         {
            idb.AddParameter("@SDC_StartSend", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDC_StartSend", sD_Contract.SDC_StartSend);
         }
         if (sD_Contract.SDC_EndSend == DateTime.MinValue)
         {
            idb.AddParameter("@SDC_EndSend", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDC_EndSend", sD_Contract.SDC_EndSend);
         }
         if (string.IsNullOrEmpty(sD_Contract.SDC_TotalDate))
         {
            idb.AddParameter("@SDC_TotalDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDC_TotalDate", sD_Contract.SDC_TotalDate);
         }
         if (string.IsNullOrEmpty(sD_Contract.SDC_AgreeQuantity))
         {
            idb.AddParameter("@SDC_AgreeQuantity", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDC_AgreeQuantity", sD_Contract.SDC_AgreeQuantity);
         }
         if (string.IsNullOrEmpty(sD_Contract.SDC_PlanQuantity))
         {
            idb.AddParameter("@SDC_PlanQuantity", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDC_PlanQuantity", sD_Contract.SDC_PlanQuantity);
         }
         if (string.IsNullOrEmpty(sD_Contract.SDC_SupQuantity))
         {
            idb.AddParameter("@SDC_SupQuantity", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDC_SupQuantity", sD_Contract.SDC_SupQuantity);
         }
         if (sD_Contract.SDC_TotalMoney == 0)
         {
            idb.AddParameter("@SDC_TotalMoney", 0);
         }
         else
         {
            idb.AddParameter("@SDC_TotalMoney", sD_Contract.SDC_TotalMoney);
         }
         if (sD_Contract.SDC_PayMoney == 0)
         {
            idb.AddParameter("@SDC_PayMoney", 0);
         }
         else
         {
            idb.AddParameter("@SDC_PayMoney", sD_Contract.SDC_PayMoney);
         }
         if (sD_Contract.SDC_SPayMoney == 0)
         {
            idb.AddParameter("@SDC_SPayMoney", 0);
         }
         else
         {
            idb.AddParameter("@SDC_SPayMoney", sD_Contract.SDC_SPayMoney);
         }
         if (string.IsNullOrEmpty(sD_Contract.SDC_PayType))
         {
            idb.AddParameter("@SDC_PayType", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDC_PayType", sD_Contract.SDC_PayType);
         }
         if (string.IsNullOrEmpty(sD_Contract.SDC_BType))
         {
            idb.AddParameter("@SDC_BType", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDC_BType", sD_Contract.SDC_BType);
         }
         if (string.IsNullOrEmpty(sD_Contract.SDC_BTypeName))
         {
            idb.AddParameter("@SDC_BTypeName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDC_BTypeName", sD_Contract.SDC_BTypeName);
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
      /// 更新销售合同基本信息 SD_Contract对象(即:一条记录
      /// </summary>
      public int Update(SD_Contract sD_Contract)
      {
         
         StringBuilder sbParameter=new StringBuilder();
      StringBuilder sb=new StringBuilder();
      sb.Append(@"UPDATE       SD_Contract       SET ");
            if(sD_Contract.SDC_iType_IsChanged){sbParameter.Append("SDC_iType=@SDC_iType, ");}
      if(sD_Contract.SDC_Code_IsChanged){sbParameter.Append("SDC_Code=@SDC_Code, ");}
      if(sD_Contract.SDC_CName_IsChanged){sbParameter.Append("SDC_CName=@SDC_CName, ");}
      if(sD_Contract.SDC_CCode_IsChanged){sbParameter.Append("SDC_CCode=@SDC_CCode, ");}
      if(sD_Contract.SDC_Date_IsChanged){sbParameter.Append("SDC_Date=@SDC_Date, ");}
      if(sD_Contract.SDC_Place_IsChanged){sbParameter.Append("SDC_Place=@SDC_Place, ");}
      if(sD_Contract.SC_OwnerCode_IsChanged){sbParameter.Append("SC_OwnerCode=@SC_OwnerCode, ");}
      if(sD_Contract.SDC_Owner_IsChanged){sbParameter.Append("SDC_Owner=@SDC_Owner, ");}
      if(sD_Contract.SDC_Dept_IsChanged){sbParameter.Append("SDC_Dept=@SDC_Dept, ");}
      if(sD_Contract.SDC_Start_IsChanged){sbParameter.Append("SDC_Start=@SDC_Start, ");}
      if(sD_Contract.SDC_End_IsChanged){sbParameter.Append("SDC_End=@SDC_End, ");}
      if(sD_Contract.SDC_EOwnerCode_IsChanged){sbParameter.Append("SDC_EOwnerCode=@SDC_EOwnerCode, ");}
      if(sD_Contract.SDC_EOwner_IsChanged){sbParameter.Append("SDC_EOwner=@SDC_EOwner, ");}
      if(sD_Contract.SDC_Num_IsChanged){sbParameter.Append("SDC_Num=@SDC_Num, ");}
      if(sD_Contract.SDC_TechDecision_IsChanged){sbParameter.Append("SDC_TechDecision=@SDC_TechDecision, ");}
      if(sD_Contract.SDC_TechCode_IsChanged){sbParameter.Append("SDC_TechCode=@SDC_TechCode, ");}
      if(sD_Contract.SDC_PayContent_IsChanged){sbParameter.Append("SDC_PayContent=@SDC_PayContent, ");}
      if(sD_Contract.SDC_COwner_IsChanged){sbParameter.Append("SDC_COwner=@SDC_COwner, ");}
      if(sD_Contract.SDC_CContact_IsChanged){sbParameter.Append("SDC_CContact=@SDC_CContact, ");}
      if(sD_Contract.SDC_Content_IsChanged){sbParameter.Append("SDC_Content=@SDC_Content, ");}
      if(sD_Contract.SDC_Description_IsChanged){sbParameter.Append("SDC_Description=@SDC_Description, ");}
      if(sD_Contract.SDC_Control_IsChanged){sbParameter.Append("SDC_Control=@SDC_Control, ");}
      if(sD_Contract.SDC_IsAFor_IsChanged){sbParameter.Append("SDC_IsAFor=@SDC_IsAFor, ");}
      if(sD_Contract.Audit1CurAudit_IsChanged){sbParameter.Append("Audit1CurAudit=@Audit1CurAudit, ");}
      if(sD_Contract.Audit1Stat_IsChanged){sbParameter.Append("Audit1Stat=@Audit1Stat, ");}
      if(sD_Contract.Audit1Date_IsChanged){sbParameter.Append("Audit1Date=@Audit1Date, ");}
      if(sD_Contract.Audit1Owner_IsChanged){sbParameter.Append("Audit1Owner=@Audit1Owner, ");}
      if(sD_Contract.AuditCurAudit_IsChanged){sbParameter.Append("AuditCurAudit=@AuditCurAudit, ");}
      if(sD_Contract.AuditStat_IsChanged){sbParameter.Append("AuditStat=@AuditStat, ");}
      if(sD_Contract.AuditDate_IsChanged){sbParameter.Append("AuditDate=@AuditDate, ");}
      if(sD_Contract.AuditOwner_IsChanged){sbParameter.Append("AuditOwner=@AuditOwner, ");}
      if(sD_Contract.Stat_IsChanged){sbParameter.Append("Stat=@Stat, ");}
      if(sD_Contract.CreateDate_IsChanged){sbParameter.Append("CreateDate=@CreateDate, ");}
      if(sD_Contract.UpdateDate_IsChanged){sbParameter.Append("UpdateDate=@UpdateDate, ");}
      if(sD_Contract.DeleteDate_IsChanged){sbParameter.Append("DeleteDate=@DeleteDate, ");}
      if(sD_Contract.CreateOwner_IsChanged){sbParameter.Append("CreateOwner=@CreateOwner, ");}
      if(sD_Contract.SDC_Stat_IsChanged){sbParameter.Append("SDC_Stat=@SDC_Stat, ");}
      if(sD_Contract.SDC_Type_IsChanged){sbParameter.Append("SDC_Type=@SDC_Type, ");}
      if(sD_Contract.SDC_Company_IsChanged){sbParameter.Append("SDC_Company=@SDC_Company, ");}
      if(sD_Contract.SDC_CompanyCode_IsChanged){sbParameter.Append("SDC_CompanyCode=@SDC_CompanyCode, ");}
      if(sD_Contract.SDC_TotalSend_IsChanged){sbParameter.Append("SDC_TotalSend=@SDC_TotalSend, ");}
      if(sD_Contract.SDC_LastSend_IsChanged){sbParameter.Append("SDC_LastSend=@SDC_LastSend, ");}
      if(sD_Contract.SDC_LastDate_IsChanged){sbParameter.Append("SDC_LastDate=@SDC_LastDate, ");}
      if(sD_Contract.SDC_Return_IsChanged){sbParameter.Append("SDC_Return=@SDC_Return, ");}
      if(sD_Contract.SDC_StartSend_IsChanged){sbParameter.Append("SDC_StartSend=@SDC_StartSend, ");}
      if(sD_Contract.SDC_EndSend_IsChanged){sbParameter.Append("SDC_EndSend=@SDC_EndSend, ");}
      if(sD_Contract.SDC_TotalDate_IsChanged){sbParameter.Append("SDC_TotalDate=@SDC_TotalDate, ");}
      if(sD_Contract.SDC_AgreeQuantity_IsChanged){sbParameter.Append("SDC_AgreeQuantity=@SDC_AgreeQuantity, ");}
      if(sD_Contract.SDC_PlanQuantity_IsChanged){sbParameter.Append("SDC_PlanQuantity=@SDC_PlanQuantity, ");}
      if(sD_Contract.SDC_SupQuantity_IsChanged){sbParameter.Append("SDC_SupQuantity=@SDC_SupQuantity, ");}
      if(sD_Contract.SDC_TotalMoney_IsChanged){sbParameter.Append("SDC_TotalMoney=@SDC_TotalMoney, ");}
      if(sD_Contract.SDC_PayMoney_IsChanged){sbParameter.Append("SDC_PayMoney=@SDC_PayMoney, ");}
      if(sD_Contract.SDC_SPayMoney_IsChanged){sbParameter.Append("SDC_SPayMoney=@SDC_SPayMoney, ");}
      if(sD_Contract.SDC_PayType_IsChanged){sbParameter.Append("SDC_PayType=@SDC_PayType, ");}
      if(sD_Contract.SDC_BType_IsChanged){sbParameter.Append("SDC_BType=@SDC_BType, ");}
      if(sD_Contract.SDC_BTypeName_IsChanged){sbParameter.Append("SDC_BTypeName=@SDC_BTypeName ");}          sb.Append(sbParameter.ToString().Trim().TrimEnd(',')); 
      sb.Append(      " WHERE 1=1 AND ((Stat is null) or (Stat=0))   and SDC_ID=@SDC_ID; " );
      string sql=sb.ToString();
         if(sD_Contract.SDC_iType_IsChanged)
         {
         if (string.IsNullOrEmpty(sD_Contract.SDC_iType))
         {
            idb.AddParameter("@SDC_iType", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDC_iType", sD_Contract.SDC_iType);
         }
          }
         if(sD_Contract.SDC_Code_IsChanged)
         {
         if (string.IsNullOrEmpty(sD_Contract.SDC_Code))
         {
            idb.AddParameter("@SDC_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDC_Code", sD_Contract.SDC_Code);
         }
          }
         if(sD_Contract.SDC_CName_IsChanged)
         {
         if (string.IsNullOrEmpty(sD_Contract.SDC_CName))
         {
            idb.AddParameter("@SDC_CName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDC_CName", sD_Contract.SDC_CName);
         }
          }
         if(sD_Contract.SDC_CCode_IsChanged)
         {
         if (string.IsNullOrEmpty(sD_Contract.SDC_CCode))
         {
            idb.AddParameter("@SDC_CCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDC_CCode", sD_Contract.SDC_CCode);
         }
          }
         if(sD_Contract.SDC_Date_IsChanged)
         {
         if (sD_Contract.SDC_Date == DateTime.MinValue)
         {
            idb.AddParameter("@SDC_Date", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDC_Date", sD_Contract.SDC_Date);
         }
          }
         if(sD_Contract.SDC_Place_IsChanged)
         {
         if (string.IsNullOrEmpty(sD_Contract.SDC_Place))
         {
            idb.AddParameter("@SDC_Place", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDC_Place", sD_Contract.SDC_Place);
         }
          }
         if(sD_Contract.SC_OwnerCode_IsChanged)
         {
         if (string.IsNullOrEmpty(sD_Contract.SC_OwnerCode))
         {
            idb.AddParameter("@SC_OwnerCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SC_OwnerCode", sD_Contract.SC_OwnerCode);
         }
          }
         if(sD_Contract.SDC_Owner_IsChanged)
         {
         if (string.IsNullOrEmpty(sD_Contract.SDC_Owner))
         {
            idb.AddParameter("@SDC_Owner", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDC_Owner", sD_Contract.SDC_Owner);
         }
          }
         if(sD_Contract.SDC_Dept_IsChanged)
         {
         if (string.IsNullOrEmpty(sD_Contract.SDC_Dept))
         {
            idb.AddParameter("@SDC_Dept", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDC_Dept", sD_Contract.SDC_Dept);
         }
          }
         if(sD_Contract.SDC_Start_IsChanged)
         {
         if (sD_Contract.SDC_Start == DateTime.MinValue)
         {
            idb.AddParameter("@SDC_Start", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDC_Start", sD_Contract.SDC_Start);
         }
          }
         if(sD_Contract.SDC_End_IsChanged)
         {
         if (sD_Contract.SDC_End == DateTime.MinValue)
         {
            idb.AddParameter("@SDC_End", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDC_End", sD_Contract.SDC_End);
         }
          }
         if(sD_Contract.SDC_EOwnerCode_IsChanged)
         {
         if (string.IsNullOrEmpty(sD_Contract.SDC_EOwnerCode))
         {
            idb.AddParameter("@SDC_EOwnerCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDC_EOwnerCode", sD_Contract.SDC_EOwnerCode);
         }
          }
         if(sD_Contract.SDC_EOwner_IsChanged)
         {
         if (string.IsNullOrEmpty(sD_Contract.SDC_EOwner))
         {
            idb.AddParameter("@SDC_EOwner", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDC_EOwner", sD_Contract.SDC_EOwner);
         }
          }
         if(sD_Contract.SDC_Num_IsChanged)
         {
         if (sD_Contract.SDC_Num == 0)
         {
            idb.AddParameter("@SDC_Num", 0);
         }
         else
         {
            idb.AddParameter("@SDC_Num", sD_Contract.SDC_Num);
         }
          }
         if(sD_Contract.SDC_TechDecision_IsChanged)
         {
         if (string.IsNullOrEmpty(sD_Contract.SDC_TechDecision))
         {
            idb.AddParameter("@SDC_TechDecision", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDC_TechDecision", sD_Contract.SDC_TechDecision);
         }
          }
         if(sD_Contract.SDC_TechCode_IsChanged)
         {
         if (string.IsNullOrEmpty(sD_Contract.SDC_TechCode))
         {
            idb.AddParameter("@SDC_TechCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDC_TechCode", sD_Contract.SDC_TechCode);
         }
          }
         if(sD_Contract.SDC_PayContent_IsChanged)
         {
         if (string.IsNullOrEmpty(sD_Contract.SDC_PayContent))
         {
            idb.AddParameter("@SDC_PayContent", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDC_PayContent", sD_Contract.SDC_PayContent);
         }
          }
         if(sD_Contract.SDC_COwner_IsChanged)
         {
         if (string.IsNullOrEmpty(sD_Contract.SDC_COwner))
         {
            idb.AddParameter("@SDC_COwner", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDC_COwner", sD_Contract.SDC_COwner);
         }
          }
         if(sD_Contract.SDC_CContact_IsChanged)
         {
         if (string.IsNullOrEmpty(sD_Contract.SDC_CContact))
         {
            idb.AddParameter("@SDC_CContact", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDC_CContact", sD_Contract.SDC_CContact);
         }
          }
         if(sD_Contract.SDC_Content_IsChanged)
         {
         if (string.IsNullOrEmpty(sD_Contract.SDC_Content))
         {
            idb.AddParameter("@SDC_Content", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDC_Content", sD_Contract.SDC_Content);
         }
          }
         if(sD_Contract.SDC_Description_IsChanged)
         {
         if (string.IsNullOrEmpty(sD_Contract.SDC_Description))
         {
            idb.AddParameter("@SDC_Description", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDC_Description", sD_Contract.SDC_Description);
         }
          }
         if(sD_Contract.SDC_Control_IsChanged)
         {
         if (string.IsNullOrEmpty(sD_Contract.SDC_Control))
         {
            idb.AddParameter("@SDC_Control", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDC_Control", sD_Contract.SDC_Control);
         }
          }
         if(sD_Contract.SDC_IsAFor_IsChanged)
         {
         if (string.IsNullOrEmpty(sD_Contract.SDC_IsAFor))
         {
            idb.AddParameter("@SDC_IsAFor", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDC_IsAFor", sD_Contract.SDC_IsAFor);
         }
          }
         if(sD_Contract.Audit1CurAudit_IsChanged)
         {
         if (string.IsNullOrEmpty(sD_Contract.Audit1CurAudit))
         {
            idb.AddParameter("@Audit1CurAudit", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Audit1CurAudit", sD_Contract.Audit1CurAudit);
         }
          }
         if(sD_Contract.Audit1Stat_IsChanged)
         {
         if (string.IsNullOrEmpty(sD_Contract.Audit1Stat))
         {
            idb.AddParameter("@Audit1Stat", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Audit1Stat", sD_Contract.Audit1Stat);
         }
          }
         if(sD_Contract.Audit1Date_IsChanged)
         {
         if (sD_Contract.Audit1Date == DateTime.MinValue)
         {
            idb.AddParameter("@Audit1Date", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Audit1Date", sD_Contract.Audit1Date);
         }
          }
         if(sD_Contract.Audit1Owner_IsChanged)
         {
         if (string.IsNullOrEmpty(sD_Contract.Audit1Owner))
         {
            idb.AddParameter("@Audit1Owner", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Audit1Owner", sD_Contract.Audit1Owner);
         }
          }
         if(sD_Contract.AuditCurAudit_IsChanged)
         {
         if (string.IsNullOrEmpty(sD_Contract.AuditCurAudit))
         {
            idb.AddParameter("@AuditCurAudit", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AuditCurAudit", sD_Contract.AuditCurAudit);
         }
          }
         if(sD_Contract.AuditStat_IsChanged)
         {
         if (string.IsNullOrEmpty(sD_Contract.AuditStat))
         {
            idb.AddParameter("@AuditStat", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AuditStat", sD_Contract.AuditStat);
         }
          }
         if(sD_Contract.AuditDate_IsChanged)
         {
         if (sD_Contract.AuditDate == DateTime.MinValue)
         {
            idb.AddParameter("@AuditDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AuditDate", sD_Contract.AuditDate);
         }
          }
         if(sD_Contract.AuditOwner_IsChanged)
         {
         if (string.IsNullOrEmpty(sD_Contract.AuditOwner))
         {
            idb.AddParameter("@AuditOwner", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AuditOwner", sD_Contract.AuditOwner);
         }
          }
         if(sD_Contract.Stat_IsChanged)
         {
         if (sD_Contract.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", sD_Contract.Stat);
         }
          }
         if(sD_Contract.CreateDate_IsChanged)
         {
         if (sD_Contract.CreateDate == DateTime.MinValue)
         {
            idb.AddParameter("@CreateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateDate", sD_Contract.CreateDate);
         }
          }
         if(sD_Contract.UpdateDate_IsChanged)
         {
         if (sD_Contract.UpdateDate == DateTime.MinValue)
         {
            idb.AddParameter("@UpdateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@UpdateDate", sD_Contract.UpdateDate);
         }
          }
         if(sD_Contract.DeleteDate_IsChanged)
         {
         if (sD_Contract.DeleteDate == DateTime.MinValue)
         {
            idb.AddParameter("@DeleteDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DeleteDate", sD_Contract.DeleteDate);
         }
          }
         if(sD_Contract.CreateOwner_IsChanged)
         {
         if (string.IsNullOrEmpty(sD_Contract.CreateOwner))
         {
            idb.AddParameter("@CreateOwner", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateOwner", sD_Contract.CreateOwner);
         }
          }
         if(sD_Contract.SDC_Stat_IsChanged)
         {
         if (string.IsNullOrEmpty(sD_Contract.SDC_Stat))
         {
            idb.AddParameter("@SDC_Stat", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDC_Stat", sD_Contract.SDC_Stat);
         }
          }
         if(sD_Contract.SDC_Type_IsChanged)
         {
         if (string.IsNullOrEmpty(sD_Contract.SDC_Type))
         {
            idb.AddParameter("@SDC_Type", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDC_Type", sD_Contract.SDC_Type);
         }
          }
         if(sD_Contract.SDC_Company_IsChanged)
         {
         if (string.IsNullOrEmpty(sD_Contract.SDC_Company))
         {
            idb.AddParameter("@SDC_Company", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDC_Company", sD_Contract.SDC_Company);
         }
          }
         if(sD_Contract.SDC_CompanyCode_IsChanged)
         {
         if (string.IsNullOrEmpty(sD_Contract.SDC_CompanyCode))
         {
            idb.AddParameter("@SDC_CompanyCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDC_CompanyCode", sD_Contract.SDC_CompanyCode);
         }
          }
         if(sD_Contract.SDC_TotalSend_IsChanged)
         {
         if (string.IsNullOrEmpty(sD_Contract.SDC_TotalSend))
         {
            idb.AddParameter("@SDC_TotalSend", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDC_TotalSend", sD_Contract.SDC_TotalSend);
         }
          }
         if(sD_Contract.SDC_LastSend_IsChanged)
         {
         if (string.IsNullOrEmpty(sD_Contract.SDC_LastSend))
         {
            idb.AddParameter("@SDC_LastSend", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDC_LastSend", sD_Contract.SDC_LastSend);
         }
          }
         if(sD_Contract.SDC_LastDate_IsChanged)
         {
         if (sD_Contract.SDC_LastDate == DateTime.MinValue)
         {
            idb.AddParameter("@SDC_LastDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDC_LastDate", sD_Contract.SDC_LastDate);
         }
          }
         if(sD_Contract.SDC_Return_IsChanged)
         {
         if (string.IsNullOrEmpty(sD_Contract.SDC_Return))
         {
            idb.AddParameter("@SDC_Return", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDC_Return", sD_Contract.SDC_Return);
         }
          }
         if(sD_Contract.SDC_StartSend_IsChanged)
         {
         if (sD_Contract.SDC_StartSend == DateTime.MinValue)
         {
            idb.AddParameter("@SDC_StartSend", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDC_StartSend", sD_Contract.SDC_StartSend);
         }
          }
         if(sD_Contract.SDC_EndSend_IsChanged)
         {
         if (sD_Contract.SDC_EndSend == DateTime.MinValue)
         {
            idb.AddParameter("@SDC_EndSend", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDC_EndSend", sD_Contract.SDC_EndSend);
         }
          }
         if(sD_Contract.SDC_TotalDate_IsChanged)
         {
         if (string.IsNullOrEmpty(sD_Contract.SDC_TotalDate))
         {
            idb.AddParameter("@SDC_TotalDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDC_TotalDate", sD_Contract.SDC_TotalDate);
         }
          }
         if(sD_Contract.SDC_AgreeQuantity_IsChanged)
         {
         if (string.IsNullOrEmpty(sD_Contract.SDC_AgreeQuantity))
         {
            idb.AddParameter("@SDC_AgreeQuantity", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDC_AgreeQuantity", sD_Contract.SDC_AgreeQuantity);
         }
          }
         if(sD_Contract.SDC_PlanQuantity_IsChanged)
         {
         if (string.IsNullOrEmpty(sD_Contract.SDC_PlanQuantity))
         {
            idb.AddParameter("@SDC_PlanQuantity", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDC_PlanQuantity", sD_Contract.SDC_PlanQuantity);
         }
          }
         if(sD_Contract.SDC_SupQuantity_IsChanged)
         {
         if (string.IsNullOrEmpty(sD_Contract.SDC_SupQuantity))
         {
            idb.AddParameter("@SDC_SupQuantity", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDC_SupQuantity", sD_Contract.SDC_SupQuantity);
         }
          }
         if(sD_Contract.SDC_TotalMoney_IsChanged)
         {
         if (sD_Contract.SDC_TotalMoney == 0)
         {
            idb.AddParameter("@SDC_TotalMoney", 0);
         }
         else
         {
            idb.AddParameter("@SDC_TotalMoney", sD_Contract.SDC_TotalMoney);
         }
          }
         if(sD_Contract.SDC_PayMoney_IsChanged)
         {
         if (sD_Contract.SDC_PayMoney == 0)
         {
            idb.AddParameter("@SDC_PayMoney", 0);
         }
         else
         {
            idb.AddParameter("@SDC_PayMoney", sD_Contract.SDC_PayMoney);
         }
          }
         if(sD_Contract.SDC_SPayMoney_IsChanged)
         {
         if (sD_Contract.SDC_SPayMoney == 0)
         {
            idb.AddParameter("@SDC_SPayMoney", 0);
         }
         else
         {
            idb.AddParameter("@SDC_SPayMoney", sD_Contract.SDC_SPayMoney);
         }
          }
         if(sD_Contract.SDC_PayType_IsChanged)
         {
         if (string.IsNullOrEmpty(sD_Contract.SDC_PayType))
         {
            idb.AddParameter("@SDC_PayType", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDC_PayType", sD_Contract.SDC_PayType);
         }
          }
         if(sD_Contract.SDC_BType_IsChanged)
         {
         if (string.IsNullOrEmpty(sD_Contract.SDC_BType))
         {
            idb.AddParameter("@SDC_BType", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDC_BType", sD_Contract.SDC_BType);
         }
          }
         if(sD_Contract.SDC_BTypeName_IsChanged)
         {
         if (string.IsNullOrEmpty(sD_Contract.SDC_BTypeName))
         {
            idb.AddParameter("@SDC_BTypeName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDC_BTypeName", sD_Contract.SDC_BTypeName);
         }
          }

         idb.AddParameter("@SDC_ID", sD_Contract.SDC_ID);

           
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
      /// 删除销售合同基本信息 SD_Contract对象(即:一条记录
      /// </summary>
      public int Delete(decimal sDC_ID)
      {
         string sql = "DELETE SD_Contract WHERE 1=1  AND SDC_ID=@SDC_ID ";
         idb.AddParameter("@SDC_ID", sDC_ID);

           
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
      /// 获取指定的销售合同基本信息 SD_Contract对象(即:一条记录
      /// </summary>
      public SD_Contract GetByKey(decimal sDC_ID)
      {
         SD_Contract sD_Contract = new SD_Contract();
         string sql = "SELECT  SDC_ID,SDC_iType,SDC_Code,SDC_CName,SDC_CCode,SDC_Date,SDC_Place,SC_OwnerCode,SDC_Owner,SDC_Dept,SDC_Start,SDC_End,SDC_EOwnerCode,SDC_EOwner,SDC_Num,SDC_TechDecision,SDC_TechCode,SDC_PayContent,SDC_COwner,SDC_CContact,SDC_Content,SDC_Description,SDC_Control,SDC_IsAFor,Audit1CurAudit,Audit1Stat,Audit1Date,Audit1Owner,AuditCurAudit,AuditStat,AuditDate,AuditOwner,Stat,CreateDate,UpdateDate,DeleteDate,CreateOwner,SDC_Stat,SDC_Type,SDC_Company,SDC_CompanyCode,SDC_TotalSend,SDC_LastSend,SDC_LastDate,SDC_Return,SDC_StartSend,SDC_EndSend,SDC_TotalDate,SDC_AgreeQuantity,SDC_PlanQuantity,SDC_SupQuantity,SDC_TotalMoney,SDC_PayMoney,SDC_SPayMoney,SDC_PayType,SDC_BType,SDC_BTypeName FROM SD_Contract WHERE 1=1 AND ((Stat is null) or (Stat=0) )  AND SDC_ID=@SDC_ID ";
         idb.AddParameter("@SDC_ID", sDC_ID);

          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            if (dr["SDC_ID"] != DBNull.Value) sD_Contract.SDC_ID = Convert.ToDecimal(dr["SDC_ID"]);
            if (dr["SDC_iType"] != DBNull.Value) sD_Contract.SDC_iType = Convert.ToString(dr["SDC_iType"]);
            if (dr["SDC_Code"] != DBNull.Value) sD_Contract.SDC_Code = Convert.ToString(dr["SDC_Code"]);
            if (dr["SDC_CName"] != DBNull.Value) sD_Contract.SDC_CName = Convert.ToString(dr["SDC_CName"]);
            if (dr["SDC_CCode"] != DBNull.Value) sD_Contract.SDC_CCode = Convert.ToString(dr["SDC_CCode"]);
            if (dr["SDC_Date"] != DBNull.Value) sD_Contract.SDC_Date = Convert.ToDateTime(dr["SDC_Date"]);
            if (dr["SDC_Place"] != DBNull.Value) sD_Contract.SDC_Place = Convert.ToString(dr["SDC_Place"]);
            if (dr["SC_OwnerCode"] != DBNull.Value) sD_Contract.SC_OwnerCode = Convert.ToString(dr["SC_OwnerCode"]);
            if (dr["SDC_Owner"] != DBNull.Value) sD_Contract.SDC_Owner = Convert.ToString(dr["SDC_Owner"]);
            if (dr["SDC_Dept"] != DBNull.Value) sD_Contract.SDC_Dept = Convert.ToString(dr["SDC_Dept"]);
            if (dr["SDC_Start"] != DBNull.Value) sD_Contract.SDC_Start = Convert.ToDateTime(dr["SDC_Start"]);
            if (dr["SDC_End"] != DBNull.Value) sD_Contract.SDC_End = Convert.ToDateTime(dr["SDC_End"]);
            if (dr["SDC_EOwnerCode"] != DBNull.Value) sD_Contract.SDC_EOwnerCode = Convert.ToString(dr["SDC_EOwnerCode"]);
            if (dr["SDC_EOwner"] != DBNull.Value) sD_Contract.SDC_EOwner = Convert.ToString(dr["SDC_EOwner"]);
            if (dr["SDC_Num"] != DBNull.Value) sD_Contract.SDC_Num = Convert.ToInt32(dr["SDC_Num"]);
            if (dr["SDC_TechDecision"] != DBNull.Value) sD_Contract.SDC_TechDecision = Convert.ToString(dr["SDC_TechDecision"]);
            if (dr["SDC_TechCode"] != DBNull.Value) sD_Contract.SDC_TechCode = Convert.ToString(dr["SDC_TechCode"]);
            if (dr["SDC_PayContent"] != DBNull.Value) sD_Contract.SDC_PayContent = Convert.ToString(dr["SDC_PayContent"]);
            if (dr["SDC_COwner"] != DBNull.Value) sD_Contract.SDC_COwner = Convert.ToString(dr["SDC_COwner"]);
            if (dr["SDC_CContact"] != DBNull.Value) sD_Contract.SDC_CContact = Convert.ToString(dr["SDC_CContact"]);
            if (dr["SDC_Content"] != DBNull.Value) sD_Contract.SDC_Content = Convert.ToString(dr["SDC_Content"]);
            if (dr["SDC_Description"] != DBNull.Value) sD_Contract.SDC_Description = Convert.ToString(dr["SDC_Description"]);
            if (dr["SDC_Control"] != DBNull.Value) sD_Contract.SDC_Control = Convert.ToString(dr["SDC_Control"]);
            if (dr["SDC_IsAFor"] != DBNull.Value) sD_Contract.SDC_IsAFor = Convert.ToString(dr["SDC_IsAFor"]);
            if (dr["Audit1CurAudit"] != DBNull.Value) sD_Contract.Audit1CurAudit = Convert.ToString(dr["Audit1CurAudit"]);
            if (dr["Audit1Stat"] != DBNull.Value) sD_Contract.Audit1Stat = Convert.ToString(dr["Audit1Stat"]);
            if (dr["Audit1Date"] != DBNull.Value) sD_Contract.Audit1Date = Convert.ToDateTime(dr["Audit1Date"]);
            if (dr["Audit1Owner"] != DBNull.Value) sD_Contract.Audit1Owner = Convert.ToString(dr["Audit1Owner"]);
            if (dr["AuditCurAudit"] != DBNull.Value) sD_Contract.AuditCurAudit = Convert.ToString(dr["AuditCurAudit"]);
            if (dr["AuditStat"] != DBNull.Value) sD_Contract.AuditStat = Convert.ToString(dr["AuditStat"]);
            if (dr["AuditDate"] != DBNull.Value) sD_Contract.AuditDate = Convert.ToDateTime(dr["AuditDate"]);
            if (dr["AuditOwner"] != DBNull.Value) sD_Contract.AuditOwner = Convert.ToString(dr["AuditOwner"]);
            if (dr["Stat"] != DBNull.Value) sD_Contract.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["CreateDate"] != DBNull.Value) sD_Contract.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
            if (dr["UpdateDate"] != DBNull.Value) sD_Contract.UpdateDate = Convert.ToDateTime(dr["UpdateDate"]);
            if (dr["DeleteDate"] != DBNull.Value) sD_Contract.DeleteDate = Convert.ToDateTime(dr["DeleteDate"]);
            if (dr["CreateOwner"] != DBNull.Value) sD_Contract.CreateOwner = Convert.ToString(dr["CreateOwner"]);
            if (dr["SDC_Stat"] != DBNull.Value) sD_Contract.SDC_Stat = Convert.ToString(dr["SDC_Stat"]);
            if (dr["SDC_Type"] != DBNull.Value) sD_Contract.SDC_Type = Convert.ToString(dr["SDC_Type"]);
            if (dr["SDC_Company"] != DBNull.Value) sD_Contract.SDC_Company = Convert.ToString(dr["SDC_Company"]);
            if (dr["SDC_CompanyCode"] != DBNull.Value) sD_Contract.SDC_CompanyCode = Convert.ToString(dr["SDC_CompanyCode"]);
            if (dr["SDC_TotalSend"] != DBNull.Value) sD_Contract.SDC_TotalSend = Convert.ToString(dr["SDC_TotalSend"]);
            if (dr["SDC_LastSend"] != DBNull.Value) sD_Contract.SDC_LastSend = Convert.ToString(dr["SDC_LastSend"]);
            if (dr["SDC_LastDate"] != DBNull.Value) sD_Contract.SDC_LastDate = Convert.ToDateTime(dr["SDC_LastDate"]);
            if (dr["SDC_Return"] != DBNull.Value) sD_Contract.SDC_Return = Convert.ToString(dr["SDC_Return"]);
            if (dr["SDC_StartSend"] != DBNull.Value) sD_Contract.SDC_StartSend = Convert.ToDateTime(dr["SDC_StartSend"]);
            if (dr["SDC_EndSend"] != DBNull.Value) sD_Contract.SDC_EndSend = Convert.ToDateTime(dr["SDC_EndSend"]);
            if (dr["SDC_TotalDate"] != DBNull.Value) sD_Contract.SDC_TotalDate = Convert.ToString(dr["SDC_TotalDate"]);
            if (dr["SDC_AgreeQuantity"] != DBNull.Value) sD_Contract.SDC_AgreeQuantity = Convert.ToString(dr["SDC_AgreeQuantity"]);
            if (dr["SDC_PlanQuantity"] != DBNull.Value) sD_Contract.SDC_PlanQuantity = Convert.ToString(dr["SDC_PlanQuantity"]);
            if (dr["SDC_SupQuantity"] != DBNull.Value) sD_Contract.SDC_SupQuantity = Convert.ToString(dr["SDC_SupQuantity"]);
            if (dr["SDC_TotalMoney"] != DBNull.Value) sD_Contract.SDC_TotalMoney = Convert.ToDecimal(dr["SDC_TotalMoney"]);
            if (dr["SDC_PayMoney"] != DBNull.Value) sD_Contract.SDC_PayMoney = Convert.ToDecimal(dr["SDC_PayMoney"]);
            if (dr["SDC_SPayMoney"] != DBNull.Value) sD_Contract.SDC_SPayMoney = Convert.ToDecimal(dr["SDC_SPayMoney"]);
            if (dr["SDC_PayType"] != DBNull.Value) sD_Contract.SDC_PayType = Convert.ToString(dr["SDC_PayType"]);
            if (dr["SDC_BType"] != DBNull.Value) sD_Contract.SDC_BType = Convert.ToString(dr["SDC_BType"]);
            if (dr["SDC_BTypeName"] != DBNull.Value) sD_Contract.SDC_BTypeName = Convert.ToString(dr["SDC_BTypeName"]);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   }  
         return sD_Contract;
      }
      /// <summary>
      /// 获取指定的销售合同基本信息 SD_Contract对象集合
      /// </summary>
      public List<SD_Contract> GetListByWhere(string strCondition)
      {
         List<SD_Contract> ret = new List<SD_Contract>();
         string sql = "SELECT  SDC_ID,SDC_iType,SDC_Code,SDC_CName,SDC_CCode,SDC_Date,SDC_Place,SC_OwnerCode,SDC_Owner,SDC_Dept,SDC_Start,SDC_End,SDC_EOwnerCode,SDC_EOwner,SDC_Num,SDC_TechDecision,SDC_TechCode,SDC_PayContent,SDC_COwner,SDC_CContact,SDC_Content,SDC_Description,SDC_Control,SDC_IsAFor,Audit1CurAudit,Audit1Stat,Audit1Date,Audit1Owner,AuditCurAudit,AuditStat,AuditDate,AuditOwner,Stat,CreateDate,UpdateDate,DeleteDate,CreateOwner,SDC_Stat,SDC_Type,SDC_Company,SDC_CompanyCode,SDC_TotalSend,SDC_LastSend,SDC_LastDate,SDC_Return,SDC_StartSend,SDC_EndSend,SDC_TotalDate,SDC_AgreeQuantity,SDC_PlanQuantity,SDC_SupQuantity,SDC_TotalMoney,SDC_PayMoney,SDC_SPayMoney,SDC_PayType,SDC_BType,SDC_BTypeName FROM SD_Contract WHERE 1=1 AND ((Stat is null) or (Stat=0) ) ";
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
            SD_Contract sD_Contract = new SD_Contract();
            if (dr["SDC_ID"] != DBNull.Value) sD_Contract.SDC_ID = Convert.ToDecimal(dr["SDC_ID"]);
            if (dr["SDC_iType"] != DBNull.Value) sD_Contract.SDC_iType = Convert.ToString(dr["SDC_iType"]);
            if (dr["SDC_Code"] != DBNull.Value) sD_Contract.SDC_Code = Convert.ToString(dr["SDC_Code"]);
            if (dr["SDC_CName"] != DBNull.Value) sD_Contract.SDC_CName = Convert.ToString(dr["SDC_CName"]);
            if (dr["SDC_CCode"] != DBNull.Value) sD_Contract.SDC_CCode = Convert.ToString(dr["SDC_CCode"]);
            if (dr["SDC_Date"] != DBNull.Value) sD_Contract.SDC_Date = Convert.ToDateTime(dr["SDC_Date"]);
            if (dr["SDC_Place"] != DBNull.Value) sD_Contract.SDC_Place = Convert.ToString(dr["SDC_Place"]);
            if (dr["SC_OwnerCode"] != DBNull.Value) sD_Contract.SC_OwnerCode = Convert.ToString(dr["SC_OwnerCode"]);
            if (dr["SDC_Owner"] != DBNull.Value) sD_Contract.SDC_Owner = Convert.ToString(dr["SDC_Owner"]);
            if (dr["SDC_Dept"] != DBNull.Value) sD_Contract.SDC_Dept = Convert.ToString(dr["SDC_Dept"]);
            if (dr["SDC_Start"] != DBNull.Value) sD_Contract.SDC_Start = Convert.ToDateTime(dr["SDC_Start"]);
            if (dr["SDC_End"] != DBNull.Value) sD_Contract.SDC_End = Convert.ToDateTime(dr["SDC_End"]);
            if (dr["SDC_EOwnerCode"] != DBNull.Value) sD_Contract.SDC_EOwnerCode = Convert.ToString(dr["SDC_EOwnerCode"]);
            if (dr["SDC_EOwner"] != DBNull.Value) sD_Contract.SDC_EOwner = Convert.ToString(dr["SDC_EOwner"]);
            if (dr["SDC_Num"] != DBNull.Value) sD_Contract.SDC_Num = Convert.ToInt32(dr["SDC_Num"]);
            if (dr["SDC_TechDecision"] != DBNull.Value) sD_Contract.SDC_TechDecision = Convert.ToString(dr["SDC_TechDecision"]);
            if (dr["SDC_TechCode"] != DBNull.Value) sD_Contract.SDC_TechCode = Convert.ToString(dr["SDC_TechCode"]);
            if (dr["SDC_PayContent"] != DBNull.Value) sD_Contract.SDC_PayContent = Convert.ToString(dr["SDC_PayContent"]);
            if (dr["SDC_COwner"] != DBNull.Value) sD_Contract.SDC_COwner = Convert.ToString(dr["SDC_COwner"]);
            if (dr["SDC_CContact"] != DBNull.Value) sD_Contract.SDC_CContact = Convert.ToString(dr["SDC_CContact"]);
            if (dr["SDC_Content"] != DBNull.Value) sD_Contract.SDC_Content = Convert.ToString(dr["SDC_Content"]);
            if (dr["SDC_Description"] != DBNull.Value) sD_Contract.SDC_Description = Convert.ToString(dr["SDC_Description"]);
            if (dr["SDC_Control"] != DBNull.Value) sD_Contract.SDC_Control = Convert.ToString(dr["SDC_Control"]);
            if (dr["SDC_IsAFor"] != DBNull.Value) sD_Contract.SDC_IsAFor = Convert.ToString(dr["SDC_IsAFor"]);
            if (dr["Audit1CurAudit"] != DBNull.Value) sD_Contract.Audit1CurAudit = Convert.ToString(dr["Audit1CurAudit"]);
            if (dr["Audit1Stat"] != DBNull.Value) sD_Contract.Audit1Stat = Convert.ToString(dr["Audit1Stat"]);
            if (dr["Audit1Date"] != DBNull.Value) sD_Contract.Audit1Date = Convert.ToDateTime(dr["Audit1Date"]);
            if (dr["Audit1Owner"] != DBNull.Value) sD_Contract.Audit1Owner = Convert.ToString(dr["Audit1Owner"]);
            if (dr["AuditCurAudit"] != DBNull.Value) sD_Contract.AuditCurAudit = Convert.ToString(dr["AuditCurAudit"]);
            if (dr["AuditStat"] != DBNull.Value) sD_Contract.AuditStat = Convert.ToString(dr["AuditStat"]);
            if (dr["AuditDate"] != DBNull.Value) sD_Contract.AuditDate = Convert.ToDateTime(dr["AuditDate"]);
            if (dr["AuditOwner"] != DBNull.Value) sD_Contract.AuditOwner = Convert.ToString(dr["AuditOwner"]);
            if (dr["Stat"] != DBNull.Value) sD_Contract.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["CreateDate"] != DBNull.Value) sD_Contract.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
            if (dr["UpdateDate"] != DBNull.Value) sD_Contract.UpdateDate = Convert.ToDateTime(dr["UpdateDate"]);
            if (dr["DeleteDate"] != DBNull.Value) sD_Contract.DeleteDate = Convert.ToDateTime(dr["DeleteDate"]);
            if (dr["CreateOwner"] != DBNull.Value) sD_Contract.CreateOwner = Convert.ToString(dr["CreateOwner"]);
            if (dr["SDC_Stat"] != DBNull.Value) sD_Contract.SDC_Stat = Convert.ToString(dr["SDC_Stat"]);
            if (dr["SDC_Type"] != DBNull.Value) sD_Contract.SDC_Type = Convert.ToString(dr["SDC_Type"]);
            if (dr["SDC_Company"] != DBNull.Value) sD_Contract.SDC_Company = Convert.ToString(dr["SDC_Company"]);
            if (dr["SDC_CompanyCode"] != DBNull.Value) sD_Contract.SDC_CompanyCode = Convert.ToString(dr["SDC_CompanyCode"]);
            if (dr["SDC_TotalSend"] != DBNull.Value) sD_Contract.SDC_TotalSend = Convert.ToString(dr["SDC_TotalSend"]);
            if (dr["SDC_LastSend"] != DBNull.Value) sD_Contract.SDC_LastSend = Convert.ToString(dr["SDC_LastSend"]);
            if (dr["SDC_LastDate"] != DBNull.Value) sD_Contract.SDC_LastDate = Convert.ToDateTime(dr["SDC_LastDate"]);
            if (dr["SDC_Return"] != DBNull.Value) sD_Contract.SDC_Return = Convert.ToString(dr["SDC_Return"]);
            if (dr["SDC_StartSend"] != DBNull.Value) sD_Contract.SDC_StartSend = Convert.ToDateTime(dr["SDC_StartSend"]);
            if (dr["SDC_EndSend"] != DBNull.Value) sD_Contract.SDC_EndSend = Convert.ToDateTime(dr["SDC_EndSend"]);
            if (dr["SDC_TotalDate"] != DBNull.Value) sD_Contract.SDC_TotalDate = Convert.ToString(dr["SDC_TotalDate"]);
            if (dr["SDC_AgreeQuantity"] != DBNull.Value) sD_Contract.SDC_AgreeQuantity = Convert.ToString(dr["SDC_AgreeQuantity"]);
            if (dr["SDC_PlanQuantity"] != DBNull.Value) sD_Contract.SDC_PlanQuantity = Convert.ToString(dr["SDC_PlanQuantity"]);
            if (dr["SDC_SupQuantity"] != DBNull.Value) sD_Contract.SDC_SupQuantity = Convert.ToString(dr["SDC_SupQuantity"]);
            if (dr["SDC_TotalMoney"] != DBNull.Value) sD_Contract.SDC_TotalMoney = Convert.ToDecimal(dr["SDC_TotalMoney"]);
            if (dr["SDC_PayMoney"] != DBNull.Value) sD_Contract.SDC_PayMoney = Convert.ToDecimal(dr["SDC_PayMoney"]);
            if (dr["SDC_SPayMoney"] != DBNull.Value) sD_Contract.SDC_SPayMoney = Convert.ToDecimal(dr["SDC_SPayMoney"]);
            if (dr["SDC_PayType"] != DBNull.Value) sD_Contract.SDC_PayType = Convert.ToString(dr["SDC_PayType"]);
            if (dr["SDC_BType"] != DBNull.Value) sD_Contract.SDC_BType = Convert.ToString(dr["SDC_BType"]);
            if (dr["SDC_BTypeName"] != DBNull.Value) sD_Contract.SDC_BTypeName = Convert.ToString(dr["SDC_BTypeName"]);
            ret.Add(sD_Contract);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   }  
         return ret;
      }
      /// <summary>
      /// 获取所有的销售合同基本信息 SD_Contract对象(即:一条记录
      /// </summary>
      public List<SD_Contract> GetAll()
      {
         List<SD_Contract> ret = new List<SD_Contract>();
         string sql = "SELECT  SDC_ID,SDC_iType,SDC_Code,SDC_CName,SDC_CCode,SDC_Date,SDC_Place,SC_OwnerCode,SDC_Owner,SDC_Dept,SDC_Start,SDC_End,SDC_EOwnerCode,SDC_EOwner,SDC_Num,SDC_TechDecision,SDC_TechCode,SDC_PayContent,SDC_COwner,SDC_CContact,SDC_Content,SDC_Description,SDC_Control,SDC_IsAFor,Audit1CurAudit,Audit1Stat,Audit1Date,Audit1Owner,AuditCurAudit,AuditStat,AuditDate,AuditOwner,Stat,CreateDate,UpdateDate,DeleteDate,CreateOwner,SDC_Stat,SDC_Type,SDC_Company,SDC_CompanyCode,SDC_TotalSend,SDC_LastSend,SDC_LastDate,SDC_Return,SDC_StartSend,SDC_EndSend,SDC_TotalDate,SDC_AgreeQuantity,SDC_PlanQuantity,SDC_SupQuantity,SDC_TotalMoney,SDC_PayMoney,SDC_SPayMoney,SDC_PayType,SDC_BType,SDC_BTypeName FROM SD_Contract where 1=1 AND ((Stat is null) or (Stat=0) ) order by SDC_ID desc ";
          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            SD_Contract sD_Contract = new SD_Contract();
            if (dr["SDC_ID"] != DBNull.Value) sD_Contract.SDC_ID = Convert.ToDecimal(dr["SDC_ID"]);
            if (dr["SDC_iType"] != DBNull.Value) sD_Contract.SDC_iType = Convert.ToString(dr["SDC_iType"]);
            if (dr["SDC_Code"] != DBNull.Value) sD_Contract.SDC_Code = Convert.ToString(dr["SDC_Code"]);
            if (dr["SDC_CName"] != DBNull.Value) sD_Contract.SDC_CName = Convert.ToString(dr["SDC_CName"]);
            if (dr["SDC_CCode"] != DBNull.Value) sD_Contract.SDC_CCode = Convert.ToString(dr["SDC_CCode"]);
            if (dr["SDC_Date"] != DBNull.Value) sD_Contract.SDC_Date = Convert.ToDateTime(dr["SDC_Date"]);
            if (dr["SDC_Place"] != DBNull.Value) sD_Contract.SDC_Place = Convert.ToString(dr["SDC_Place"]);
            if (dr["SC_OwnerCode"] != DBNull.Value) sD_Contract.SC_OwnerCode = Convert.ToString(dr["SC_OwnerCode"]);
            if (dr["SDC_Owner"] != DBNull.Value) sD_Contract.SDC_Owner = Convert.ToString(dr["SDC_Owner"]);
            if (dr["SDC_Dept"] != DBNull.Value) sD_Contract.SDC_Dept = Convert.ToString(dr["SDC_Dept"]);
            if (dr["SDC_Start"] != DBNull.Value) sD_Contract.SDC_Start = Convert.ToDateTime(dr["SDC_Start"]);
            if (dr["SDC_End"] != DBNull.Value) sD_Contract.SDC_End = Convert.ToDateTime(dr["SDC_End"]);
            if (dr["SDC_EOwnerCode"] != DBNull.Value) sD_Contract.SDC_EOwnerCode = Convert.ToString(dr["SDC_EOwnerCode"]);
            if (dr["SDC_EOwner"] != DBNull.Value) sD_Contract.SDC_EOwner = Convert.ToString(dr["SDC_EOwner"]);
            if (dr["SDC_Num"] != DBNull.Value) sD_Contract.SDC_Num = Convert.ToInt32(dr["SDC_Num"]);
            if (dr["SDC_TechDecision"] != DBNull.Value) sD_Contract.SDC_TechDecision = Convert.ToString(dr["SDC_TechDecision"]);
            if (dr["SDC_TechCode"] != DBNull.Value) sD_Contract.SDC_TechCode = Convert.ToString(dr["SDC_TechCode"]);
            if (dr["SDC_PayContent"] != DBNull.Value) sD_Contract.SDC_PayContent = Convert.ToString(dr["SDC_PayContent"]);
            if (dr["SDC_COwner"] != DBNull.Value) sD_Contract.SDC_COwner = Convert.ToString(dr["SDC_COwner"]);
            if (dr["SDC_CContact"] != DBNull.Value) sD_Contract.SDC_CContact = Convert.ToString(dr["SDC_CContact"]);
            if (dr["SDC_Content"] != DBNull.Value) sD_Contract.SDC_Content = Convert.ToString(dr["SDC_Content"]);
            if (dr["SDC_Description"] != DBNull.Value) sD_Contract.SDC_Description = Convert.ToString(dr["SDC_Description"]);
            if (dr["SDC_Control"] != DBNull.Value) sD_Contract.SDC_Control = Convert.ToString(dr["SDC_Control"]);
            if (dr["SDC_IsAFor"] != DBNull.Value) sD_Contract.SDC_IsAFor = Convert.ToString(dr["SDC_IsAFor"]);
            if (dr["Audit1CurAudit"] != DBNull.Value) sD_Contract.Audit1CurAudit = Convert.ToString(dr["Audit1CurAudit"]);
            if (dr["Audit1Stat"] != DBNull.Value) sD_Contract.Audit1Stat = Convert.ToString(dr["Audit1Stat"]);
            if (dr["Audit1Date"] != DBNull.Value) sD_Contract.Audit1Date = Convert.ToDateTime(dr["Audit1Date"]);
            if (dr["Audit1Owner"] != DBNull.Value) sD_Contract.Audit1Owner = Convert.ToString(dr["Audit1Owner"]);
            if (dr["AuditCurAudit"] != DBNull.Value) sD_Contract.AuditCurAudit = Convert.ToString(dr["AuditCurAudit"]);
            if (dr["AuditStat"] != DBNull.Value) sD_Contract.AuditStat = Convert.ToString(dr["AuditStat"]);
            if (dr["AuditDate"] != DBNull.Value) sD_Contract.AuditDate = Convert.ToDateTime(dr["AuditDate"]);
            if (dr["AuditOwner"] != DBNull.Value) sD_Contract.AuditOwner = Convert.ToString(dr["AuditOwner"]);
            if (dr["Stat"] != DBNull.Value) sD_Contract.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["CreateDate"] != DBNull.Value) sD_Contract.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
            if (dr["UpdateDate"] != DBNull.Value) sD_Contract.UpdateDate = Convert.ToDateTime(dr["UpdateDate"]);
            if (dr["DeleteDate"] != DBNull.Value) sD_Contract.DeleteDate = Convert.ToDateTime(dr["DeleteDate"]);
            if (dr["CreateOwner"] != DBNull.Value) sD_Contract.CreateOwner = Convert.ToString(dr["CreateOwner"]);
            if (dr["SDC_Stat"] != DBNull.Value) sD_Contract.SDC_Stat = Convert.ToString(dr["SDC_Stat"]);
            if (dr["SDC_Type"] != DBNull.Value) sD_Contract.SDC_Type = Convert.ToString(dr["SDC_Type"]);
            if (dr["SDC_Company"] != DBNull.Value) sD_Contract.SDC_Company = Convert.ToString(dr["SDC_Company"]);
            if (dr["SDC_CompanyCode"] != DBNull.Value) sD_Contract.SDC_CompanyCode = Convert.ToString(dr["SDC_CompanyCode"]);
            if (dr["SDC_TotalSend"] != DBNull.Value) sD_Contract.SDC_TotalSend = Convert.ToString(dr["SDC_TotalSend"]);
            if (dr["SDC_LastSend"] != DBNull.Value) sD_Contract.SDC_LastSend = Convert.ToString(dr["SDC_LastSend"]);
            if (dr["SDC_LastDate"] != DBNull.Value) sD_Contract.SDC_LastDate = Convert.ToDateTime(dr["SDC_LastDate"]);
            if (dr["SDC_Return"] != DBNull.Value) sD_Contract.SDC_Return = Convert.ToString(dr["SDC_Return"]);
            if (dr["SDC_StartSend"] != DBNull.Value) sD_Contract.SDC_StartSend = Convert.ToDateTime(dr["SDC_StartSend"]);
            if (dr["SDC_EndSend"] != DBNull.Value) sD_Contract.SDC_EndSend = Convert.ToDateTime(dr["SDC_EndSend"]);
            if (dr["SDC_TotalDate"] != DBNull.Value) sD_Contract.SDC_TotalDate = Convert.ToString(dr["SDC_TotalDate"]);
            if (dr["SDC_AgreeQuantity"] != DBNull.Value) sD_Contract.SDC_AgreeQuantity = Convert.ToString(dr["SDC_AgreeQuantity"]);
            if (dr["SDC_PlanQuantity"] != DBNull.Value) sD_Contract.SDC_PlanQuantity = Convert.ToString(dr["SDC_PlanQuantity"]);
            if (dr["SDC_SupQuantity"] != DBNull.Value) sD_Contract.SDC_SupQuantity = Convert.ToString(dr["SDC_SupQuantity"]);
            if (dr["SDC_TotalMoney"] != DBNull.Value) sD_Contract.SDC_TotalMoney = Convert.ToDecimal(dr["SDC_TotalMoney"]);
            if (dr["SDC_PayMoney"] != DBNull.Value) sD_Contract.SDC_PayMoney = Convert.ToDecimal(dr["SDC_PayMoney"]);
            if (dr["SDC_SPayMoney"] != DBNull.Value) sD_Contract.SDC_SPayMoney = Convert.ToDecimal(dr["SDC_SPayMoney"]);
            if (dr["SDC_PayType"] != DBNull.Value) sD_Contract.SDC_PayType = Convert.ToString(dr["SDC_PayType"]);
            if (dr["SDC_BType"] != DBNull.Value) sD_Contract.SDC_BType = Convert.ToString(dr["SDC_BType"]);
            if (dr["SDC_BTypeName"] != DBNull.Value) sD_Contract.SDC_BTypeName = Convert.ToString(dr["SDC_BTypeName"]);
            ret.Add(sD_Contract);
         }
          }catch (System.Exception ex){ throw ex; }  finally {  if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   } 
         return ret;
      }
   }
}
