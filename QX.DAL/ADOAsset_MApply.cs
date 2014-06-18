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
   /// 维修申请
   /// </summary>
   [Serializable]
   public partial class ADOAsset_MApply
   {
      public IDBOperator idb =  DBOperator.GetInstance();
      /// <summary>
      /// 添加维修申请 Asset_MApply对象(即:一条记录)
      /// </summary>
      public int Add(Asset_MApply asset_MApply)
      {
         string sql = "INSERT INTO Asset_MApply (AMA_Code,AMA_FCode,AMA_FName,AMA_FSpec,AMA_Company,AMA_Department,AMA_Reason,AMA_Description,AMA_Date,AMA_TimeCost,AMA_Owner,AMA_OwnerCode,AMA_OpDate,AMA_ReceiveDate,AMA_OperatorCode,AMA_Operator,AMA_Content,AMA_OStatus,AMA_Stat,AuditStat,AMA_Remark,AMA_ApplyType,AMA_Type,Stat,CreateDate,UpdateDate,DeleteDate,AuditCurAudit,AMA_name,AMA_CompanyCode,AMA_DeptCode) VALUES (@AMA_Code,@AMA_FCode,@AMA_FName,@AMA_FSpec,@AMA_Company,@AMA_Department,@AMA_Reason,@AMA_Description,@AMA_Date,@AMA_TimeCost,@AMA_Owner,@AMA_OwnerCode,@AMA_OpDate,@AMA_ReceiveDate,@AMA_OperatorCode,@AMA_Operator,@AMA_Content,@AMA_OStatus,@AMA_Stat,@AuditStat,@AMA_Remark,@AMA_ApplyType,@AMA_Type,@Stat,@CreateDate,@UpdateDate,@DeleteDate,@AuditCurAudit,@AMA_name,@AMA_CompanyCode,@AMA_DeptCode)";
         if (string.IsNullOrEmpty(asset_MApply.AMA_Code))
         {
            idb.AddParameter("@AMA_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AMA_Code", asset_MApply.AMA_Code);
         }
         if (string.IsNullOrEmpty(asset_MApply.AMA_FCode))
         {
            idb.AddParameter("@AMA_FCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AMA_FCode", asset_MApply.AMA_FCode);
         }
         if (string.IsNullOrEmpty(asset_MApply.AMA_FName))
         {
            idb.AddParameter("@AMA_FName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AMA_FName", asset_MApply.AMA_FName);
         }
         if (string.IsNullOrEmpty(asset_MApply.AMA_FSpec))
         {
            idb.AddParameter("@AMA_FSpec", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AMA_FSpec", asset_MApply.AMA_FSpec);
         }
         if (string.IsNullOrEmpty(asset_MApply.AMA_Company))
         {
            idb.AddParameter("@AMA_Company", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AMA_Company", asset_MApply.AMA_Company);
         }
         if (string.IsNullOrEmpty(asset_MApply.AMA_Department))
         {
            idb.AddParameter("@AMA_Department", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AMA_Department", asset_MApply.AMA_Department);
         }
         if (string.IsNullOrEmpty(asset_MApply.AMA_Reason))
         {
            idb.AddParameter("@AMA_Reason", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AMA_Reason", asset_MApply.AMA_Reason);
         }
         if (string.IsNullOrEmpty(asset_MApply.AMA_Description))
         {
            idb.AddParameter("@AMA_Description", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AMA_Description", asset_MApply.AMA_Description);
         }
         if (asset_MApply.AMA_Date == DateTime.MinValue)
         {
            idb.AddParameter("@AMA_Date", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AMA_Date", asset_MApply.AMA_Date);
         }
         if (asset_MApply.AMA_TimeCost == 0)
         {
            idb.AddParameter("@AMA_TimeCost", 0);
         }
         else
         {
            idb.AddParameter("@AMA_TimeCost", asset_MApply.AMA_TimeCost);
         }
         if (string.IsNullOrEmpty(asset_MApply.AMA_Owner))
         {
            idb.AddParameter("@AMA_Owner", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AMA_Owner", asset_MApply.AMA_Owner);
         }
         if (string.IsNullOrEmpty(asset_MApply.AMA_OwnerCode))
         {
            idb.AddParameter("@AMA_OwnerCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AMA_OwnerCode", asset_MApply.AMA_OwnerCode);
         }
         if (asset_MApply.AMA_OpDate == DateTime.MinValue)
         {
            idb.AddParameter("@AMA_OpDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AMA_OpDate", asset_MApply.AMA_OpDate);
         }
         if (asset_MApply.AMA_ReceiveDate == DateTime.MinValue)
         {
            idb.AddParameter("@AMA_ReceiveDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AMA_ReceiveDate", asset_MApply.AMA_ReceiveDate);
         }
         if (string.IsNullOrEmpty(asset_MApply.AMA_OperatorCode))
         {
            idb.AddParameter("@AMA_OperatorCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AMA_OperatorCode", asset_MApply.AMA_OperatorCode);
         }
         if (string.IsNullOrEmpty(asset_MApply.AMA_Operator))
         {
            idb.AddParameter("@AMA_Operator", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AMA_Operator", asset_MApply.AMA_Operator);
         }
         if (string.IsNullOrEmpty(asset_MApply.AMA_Content))
         {
            idb.AddParameter("@AMA_Content", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AMA_Content", asset_MApply.AMA_Content);
         }
         if (string.IsNullOrEmpty(asset_MApply.AMA_OStatus))
         {
            idb.AddParameter("@AMA_OStatus", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AMA_OStatus", asset_MApply.AMA_OStatus);
         }
         if (string.IsNullOrEmpty(asset_MApply.AMA_Stat))
         {
            idb.AddParameter("@AMA_Stat", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AMA_Stat", asset_MApply.AMA_Stat);
         }
         if (string.IsNullOrEmpty(asset_MApply.AuditStat))
         {
            idb.AddParameter("@AuditStat", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AuditStat", asset_MApply.AuditStat);
         }
         if (string.IsNullOrEmpty(asset_MApply.AMA_Remark))
         {
            idb.AddParameter("@AMA_Remark", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AMA_Remark", asset_MApply.AMA_Remark);
         }
         if (string.IsNullOrEmpty(asset_MApply.AMA_ApplyType))
         {
            idb.AddParameter("@AMA_ApplyType", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AMA_ApplyType", asset_MApply.AMA_ApplyType);
         }
         if (string.IsNullOrEmpty(asset_MApply.AMA_Type))
         {
            idb.AddParameter("@AMA_Type", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AMA_Type", asset_MApply.AMA_Type);
         }
         if (asset_MApply.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", asset_MApply.Stat);
         }
         if (asset_MApply.CreateDate == DateTime.MinValue)
         {
            idb.AddParameter("@CreateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateDate", asset_MApply.CreateDate);
         }
         if (asset_MApply.UpdateDate == DateTime.MinValue)
         {
            idb.AddParameter("@UpdateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@UpdateDate", asset_MApply.UpdateDate);
         }
         if (asset_MApply.DeleteDate == DateTime.MinValue)
         {
            idb.AddParameter("@DeleteDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DeleteDate", asset_MApply.DeleteDate);
         }
         if (string.IsNullOrEmpty(asset_MApply.AuditCurAudit))
         {
            idb.AddParameter("@AuditCurAudit", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AuditCurAudit", asset_MApply.AuditCurAudit);
         }
         if (string.IsNullOrEmpty(asset_MApply.AMA_name))
         {
            idb.AddParameter("@AMA_name", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AMA_name", asset_MApply.AMA_name);
         }
         if (string.IsNullOrEmpty(asset_MApply.AMA_CompanyCode))
         {
            idb.AddParameter("@AMA_CompanyCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AMA_CompanyCode", asset_MApply.AMA_CompanyCode);
         }
         if (string.IsNullOrEmpty(asset_MApply.AMA_DeptCode))
         {
            idb.AddParameter("@AMA_DeptCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AMA_DeptCode", asset_MApply.AMA_DeptCode);
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
      /// 添加维修申请 Asset_MApply对象(即:一条记录)
      /// </summary>
      public object AddWithReturn(Asset_MApply asset_MApply)
      {
         string sql = "INSERT INTO Asset_MApply (AMA_Code,AMA_FCode,AMA_FName,AMA_FSpec,AMA_Company,AMA_Department,AMA_Reason,AMA_Description,AMA_Date,AMA_TimeCost,AMA_Owner,AMA_OwnerCode,AMA_OpDate,AMA_ReceiveDate,AMA_OperatorCode,AMA_Operator,AMA_Content,AMA_OStatus,AMA_Stat,AuditStat,AMA_Remark,AMA_ApplyType,AMA_Type,Stat,CreateDate,UpdateDate,DeleteDate,AuditCurAudit,AMA_name,AMA_CompanyCode,AMA_DeptCode) VALUES (@AMA_Code,@AMA_FCode,@AMA_FName,@AMA_FSpec,@AMA_Company,@AMA_Department,@AMA_Reason,@AMA_Description,@AMA_Date,@AMA_TimeCost,@AMA_Owner,@AMA_OwnerCode,@AMA_OpDate,@AMA_ReceiveDate,@AMA_OperatorCode,@AMA_Operator,@AMA_Content,@AMA_OStatus,@AMA_Stat,@AuditStat,@AMA_Remark,@AMA_ApplyType,@AMA_Type,@Stat,@CreateDate,@UpdateDate,@DeleteDate,@AuditCurAudit,@AMA_name,@AMA_CompanyCode,@AMA_DeptCode);SELECT @@IDENTITY AS ReturnID;";
         if (string.IsNullOrEmpty(asset_MApply.AMA_Code))
         {
            idb.AddParameter("@AMA_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AMA_Code", asset_MApply.AMA_Code);
         }
         if (string.IsNullOrEmpty(asset_MApply.AMA_FCode))
         {
            idb.AddParameter("@AMA_FCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AMA_FCode", asset_MApply.AMA_FCode);
         }
         if (string.IsNullOrEmpty(asset_MApply.AMA_FName))
         {
            idb.AddParameter("@AMA_FName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AMA_FName", asset_MApply.AMA_FName);
         }
         if (string.IsNullOrEmpty(asset_MApply.AMA_FSpec))
         {
            idb.AddParameter("@AMA_FSpec", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AMA_FSpec", asset_MApply.AMA_FSpec);
         }
         if (string.IsNullOrEmpty(asset_MApply.AMA_Company))
         {
            idb.AddParameter("@AMA_Company", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AMA_Company", asset_MApply.AMA_Company);
         }
         if (string.IsNullOrEmpty(asset_MApply.AMA_Department))
         {
            idb.AddParameter("@AMA_Department", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AMA_Department", asset_MApply.AMA_Department);
         }
         if (string.IsNullOrEmpty(asset_MApply.AMA_Reason))
         {
            idb.AddParameter("@AMA_Reason", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AMA_Reason", asset_MApply.AMA_Reason);
         }
         if (string.IsNullOrEmpty(asset_MApply.AMA_Description))
         {
            idb.AddParameter("@AMA_Description", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AMA_Description", asset_MApply.AMA_Description);
         }
         if (asset_MApply.AMA_Date == DateTime.MinValue)
         {
            idb.AddParameter("@AMA_Date", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AMA_Date", asset_MApply.AMA_Date);
         }
         if (asset_MApply.AMA_TimeCost == 0)
         {
            idb.AddParameter("@AMA_TimeCost", 0);
         }
         else
         {
            idb.AddParameter("@AMA_TimeCost", asset_MApply.AMA_TimeCost);
         }
         if (string.IsNullOrEmpty(asset_MApply.AMA_Owner))
         {
            idb.AddParameter("@AMA_Owner", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AMA_Owner", asset_MApply.AMA_Owner);
         }
         if (string.IsNullOrEmpty(asset_MApply.AMA_OwnerCode))
         {
            idb.AddParameter("@AMA_OwnerCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AMA_OwnerCode", asset_MApply.AMA_OwnerCode);
         }
         if (asset_MApply.AMA_OpDate == DateTime.MinValue)
         {
            idb.AddParameter("@AMA_OpDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AMA_OpDate", asset_MApply.AMA_OpDate);
         }
         if (asset_MApply.AMA_ReceiveDate == DateTime.MinValue)
         {
            idb.AddParameter("@AMA_ReceiveDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AMA_ReceiveDate", asset_MApply.AMA_ReceiveDate);
         }
         if (string.IsNullOrEmpty(asset_MApply.AMA_OperatorCode))
         {
            idb.AddParameter("@AMA_OperatorCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AMA_OperatorCode", asset_MApply.AMA_OperatorCode);
         }
         if (string.IsNullOrEmpty(asset_MApply.AMA_Operator))
         {
            idb.AddParameter("@AMA_Operator", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AMA_Operator", asset_MApply.AMA_Operator);
         }
         if (string.IsNullOrEmpty(asset_MApply.AMA_Content))
         {
            idb.AddParameter("@AMA_Content", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AMA_Content", asset_MApply.AMA_Content);
         }
         if (string.IsNullOrEmpty(asset_MApply.AMA_OStatus))
         {
            idb.AddParameter("@AMA_OStatus", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AMA_OStatus", asset_MApply.AMA_OStatus);
         }
         if (string.IsNullOrEmpty(asset_MApply.AMA_Stat))
         {
            idb.AddParameter("@AMA_Stat", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AMA_Stat", asset_MApply.AMA_Stat);
         }
         if (string.IsNullOrEmpty(asset_MApply.AuditStat))
         {
            idb.AddParameter("@AuditStat", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AuditStat", asset_MApply.AuditStat);
         }
         if (string.IsNullOrEmpty(asset_MApply.AMA_Remark))
         {
            idb.AddParameter("@AMA_Remark", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AMA_Remark", asset_MApply.AMA_Remark);
         }
         if (string.IsNullOrEmpty(asset_MApply.AMA_ApplyType))
         {
            idb.AddParameter("@AMA_ApplyType", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AMA_ApplyType", asset_MApply.AMA_ApplyType);
         }
         if (string.IsNullOrEmpty(asset_MApply.AMA_Type))
         {
            idb.AddParameter("@AMA_Type", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AMA_Type", asset_MApply.AMA_Type);
         }
         if (asset_MApply.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", asset_MApply.Stat);
         }
         if (asset_MApply.CreateDate == DateTime.MinValue)
         {
            idb.AddParameter("@CreateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateDate", asset_MApply.CreateDate);
         }
         if (asset_MApply.UpdateDate == DateTime.MinValue)
         {
            idb.AddParameter("@UpdateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@UpdateDate", asset_MApply.UpdateDate);
         }
         if (asset_MApply.DeleteDate == DateTime.MinValue)
         {
            idb.AddParameter("@DeleteDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DeleteDate", asset_MApply.DeleteDate);
         }
         if (string.IsNullOrEmpty(asset_MApply.AuditCurAudit))
         {
            idb.AddParameter("@AuditCurAudit", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AuditCurAudit", asset_MApply.AuditCurAudit);
         }
         if (string.IsNullOrEmpty(asset_MApply.AMA_name))
         {
            idb.AddParameter("@AMA_name", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AMA_name", asset_MApply.AMA_name);
         }
         if (string.IsNullOrEmpty(asset_MApply.AMA_CompanyCode))
         {
            idb.AddParameter("@AMA_CompanyCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AMA_CompanyCode", asset_MApply.AMA_CompanyCode);
         }
         if (string.IsNullOrEmpty(asset_MApply.AMA_DeptCode))
         {
            idb.AddParameter("@AMA_DeptCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AMA_DeptCode", asset_MApply.AMA_DeptCode);
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
      /// 更新维修申请 Asset_MApply对象(即:一条记录
      /// </summary>
      public int Update(Asset_MApply asset_MApply)
      {
         
         StringBuilder sbParameter=new StringBuilder();
      StringBuilder sb=new StringBuilder();
      sb.Append(@"UPDATE       Asset_MApply       SET ");
            if(asset_MApply.AMA_Code_IsChanged){sbParameter.Append("AMA_Code=@AMA_Code, ");}
      if(asset_MApply.AMA_FCode_IsChanged){sbParameter.Append("AMA_FCode=@AMA_FCode, ");}
      if(asset_MApply.AMA_FName_IsChanged){sbParameter.Append("AMA_FName=@AMA_FName, ");}
      if(asset_MApply.AMA_FSpec_IsChanged){sbParameter.Append("AMA_FSpec=@AMA_FSpec, ");}
      if(asset_MApply.AMA_Company_IsChanged){sbParameter.Append("AMA_Company=@AMA_Company, ");}
      if(asset_MApply.AMA_Department_IsChanged){sbParameter.Append("AMA_Department=@AMA_Department, ");}
      if(asset_MApply.AMA_Reason_IsChanged){sbParameter.Append("AMA_Reason=@AMA_Reason, ");}
      if(asset_MApply.AMA_Description_IsChanged){sbParameter.Append("AMA_Description=@AMA_Description, ");}
      if(asset_MApply.AMA_Date_IsChanged){sbParameter.Append("AMA_Date=@AMA_Date, ");}
      if(asset_MApply.AMA_TimeCost_IsChanged){sbParameter.Append("AMA_TimeCost=@AMA_TimeCost, ");}
      if(asset_MApply.AMA_Owner_IsChanged){sbParameter.Append("AMA_Owner=@AMA_Owner, ");}
      if(asset_MApply.AMA_OwnerCode_IsChanged){sbParameter.Append("AMA_OwnerCode=@AMA_OwnerCode, ");}
      if(asset_MApply.AMA_OpDate_IsChanged){sbParameter.Append("AMA_OpDate=@AMA_OpDate, ");}
      if(asset_MApply.AMA_ReceiveDate_IsChanged){sbParameter.Append("AMA_ReceiveDate=@AMA_ReceiveDate, ");}
      if(asset_MApply.AMA_OperatorCode_IsChanged){sbParameter.Append("AMA_OperatorCode=@AMA_OperatorCode, ");}
      if(asset_MApply.AMA_Operator_IsChanged){sbParameter.Append("AMA_Operator=@AMA_Operator, ");}
      if(asset_MApply.AMA_Content_IsChanged){sbParameter.Append("AMA_Content=@AMA_Content, ");}
      if(asset_MApply.AMA_OStatus_IsChanged){sbParameter.Append("AMA_OStatus=@AMA_OStatus, ");}
      if(asset_MApply.AMA_Stat_IsChanged){sbParameter.Append("AMA_Stat=@AMA_Stat, ");}
      if(asset_MApply.AuditStat_IsChanged){sbParameter.Append("AuditStat=@AuditStat, ");}
      if(asset_MApply.AMA_Remark_IsChanged){sbParameter.Append("AMA_Remark=@AMA_Remark, ");}
      if(asset_MApply.AMA_ApplyType_IsChanged){sbParameter.Append("AMA_ApplyType=@AMA_ApplyType, ");}
      if(asset_MApply.AMA_Type_IsChanged){sbParameter.Append("AMA_Type=@AMA_Type, ");}
      if(asset_MApply.Stat_IsChanged){sbParameter.Append("Stat=@Stat, ");}
      if(asset_MApply.CreateDate_IsChanged){sbParameter.Append("CreateDate=@CreateDate, ");}
      if(asset_MApply.UpdateDate_IsChanged){sbParameter.Append("UpdateDate=@UpdateDate, ");}
      if(asset_MApply.DeleteDate_IsChanged){sbParameter.Append("DeleteDate=@DeleteDate, ");}
      if(asset_MApply.AuditCurAudit_IsChanged){sbParameter.Append("AuditCurAudit=@AuditCurAudit, ");}
      if(asset_MApply.AMA_name_IsChanged){sbParameter.Append("AMA_name=@AMA_name, ");}
      if(asset_MApply.AMA_CompanyCode_IsChanged){sbParameter.Append("AMA_CompanyCode=@AMA_CompanyCode, ");}
      if(asset_MApply.AMA_DeptCode_IsChanged){sbParameter.Append("AMA_DeptCode=@AMA_DeptCode ");}          sb.Append(sbParameter.ToString().Trim().TrimEnd(',')); 
      sb.Append(      " WHERE 1=1 AND ((Stat is null) or (Stat=0))   and AMA_ID=@AMA_ID; " );
      string sql=sb.ToString();
         if(asset_MApply.AMA_Code_IsChanged)
         {
         if (string.IsNullOrEmpty(asset_MApply.AMA_Code))
         {
            idb.AddParameter("@AMA_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AMA_Code", asset_MApply.AMA_Code);
         }
          }
         if(asset_MApply.AMA_FCode_IsChanged)
         {
         if (string.IsNullOrEmpty(asset_MApply.AMA_FCode))
         {
            idb.AddParameter("@AMA_FCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AMA_FCode", asset_MApply.AMA_FCode);
         }
          }
         if(asset_MApply.AMA_FName_IsChanged)
         {
         if (string.IsNullOrEmpty(asset_MApply.AMA_FName))
         {
            idb.AddParameter("@AMA_FName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AMA_FName", asset_MApply.AMA_FName);
         }
          }
         if(asset_MApply.AMA_FSpec_IsChanged)
         {
         if (string.IsNullOrEmpty(asset_MApply.AMA_FSpec))
         {
            idb.AddParameter("@AMA_FSpec", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AMA_FSpec", asset_MApply.AMA_FSpec);
         }
          }
         if(asset_MApply.AMA_Company_IsChanged)
         {
         if (string.IsNullOrEmpty(asset_MApply.AMA_Company))
         {
            idb.AddParameter("@AMA_Company", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AMA_Company", asset_MApply.AMA_Company);
         }
          }
         if(asset_MApply.AMA_Department_IsChanged)
         {
         if (string.IsNullOrEmpty(asset_MApply.AMA_Department))
         {
            idb.AddParameter("@AMA_Department", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AMA_Department", asset_MApply.AMA_Department);
         }
          }
         if(asset_MApply.AMA_Reason_IsChanged)
         {
         if (string.IsNullOrEmpty(asset_MApply.AMA_Reason))
         {
            idb.AddParameter("@AMA_Reason", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AMA_Reason", asset_MApply.AMA_Reason);
         }
          }
         if(asset_MApply.AMA_Description_IsChanged)
         {
         if (string.IsNullOrEmpty(asset_MApply.AMA_Description))
         {
            idb.AddParameter("@AMA_Description", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AMA_Description", asset_MApply.AMA_Description);
         }
          }
         if(asset_MApply.AMA_Date_IsChanged)
         {
         if (asset_MApply.AMA_Date == DateTime.MinValue)
         {
            idb.AddParameter("@AMA_Date", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AMA_Date", asset_MApply.AMA_Date);
         }
          }
         if(asset_MApply.AMA_TimeCost_IsChanged)
         {
         if (asset_MApply.AMA_TimeCost == 0)
         {
            idb.AddParameter("@AMA_TimeCost", 0);
         }
         else
         {
            idb.AddParameter("@AMA_TimeCost", asset_MApply.AMA_TimeCost);
         }
          }
         if(asset_MApply.AMA_Owner_IsChanged)
         {
         if (string.IsNullOrEmpty(asset_MApply.AMA_Owner))
         {
            idb.AddParameter("@AMA_Owner", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AMA_Owner", asset_MApply.AMA_Owner);
         }
          }
         if(asset_MApply.AMA_OwnerCode_IsChanged)
         {
         if (string.IsNullOrEmpty(asset_MApply.AMA_OwnerCode))
         {
            idb.AddParameter("@AMA_OwnerCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AMA_OwnerCode", asset_MApply.AMA_OwnerCode);
         }
          }
         if(asset_MApply.AMA_OpDate_IsChanged)
         {
         if (asset_MApply.AMA_OpDate == DateTime.MinValue)
         {
            idb.AddParameter("@AMA_OpDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AMA_OpDate", asset_MApply.AMA_OpDate);
         }
          }
         if(asset_MApply.AMA_ReceiveDate_IsChanged)
         {
         if (asset_MApply.AMA_ReceiveDate == DateTime.MinValue)
         {
            idb.AddParameter("@AMA_ReceiveDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AMA_ReceiveDate", asset_MApply.AMA_ReceiveDate);
         }
          }
         if(asset_MApply.AMA_OperatorCode_IsChanged)
         {
         if (string.IsNullOrEmpty(asset_MApply.AMA_OperatorCode))
         {
            idb.AddParameter("@AMA_OperatorCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AMA_OperatorCode", asset_MApply.AMA_OperatorCode);
         }
          }
         if(asset_MApply.AMA_Operator_IsChanged)
         {
         if (string.IsNullOrEmpty(asset_MApply.AMA_Operator))
         {
            idb.AddParameter("@AMA_Operator", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AMA_Operator", asset_MApply.AMA_Operator);
         }
          }
         if(asset_MApply.AMA_Content_IsChanged)
         {
         if (string.IsNullOrEmpty(asset_MApply.AMA_Content))
         {
            idb.AddParameter("@AMA_Content", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AMA_Content", asset_MApply.AMA_Content);
         }
          }
         if(asset_MApply.AMA_OStatus_IsChanged)
         {
         if (string.IsNullOrEmpty(asset_MApply.AMA_OStatus))
         {
            idb.AddParameter("@AMA_OStatus", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AMA_OStatus", asset_MApply.AMA_OStatus);
         }
          }
         if(asset_MApply.AMA_Stat_IsChanged)
         {
         if (string.IsNullOrEmpty(asset_MApply.AMA_Stat))
         {
            idb.AddParameter("@AMA_Stat", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AMA_Stat", asset_MApply.AMA_Stat);
         }
          }
         if(asset_MApply.AuditStat_IsChanged)
         {
         if (string.IsNullOrEmpty(asset_MApply.AuditStat))
         {
            idb.AddParameter("@AuditStat", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AuditStat", asset_MApply.AuditStat);
         }
          }
         if(asset_MApply.AMA_Remark_IsChanged)
         {
         if (string.IsNullOrEmpty(asset_MApply.AMA_Remark))
         {
            idb.AddParameter("@AMA_Remark", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AMA_Remark", asset_MApply.AMA_Remark);
         }
          }
         if(asset_MApply.AMA_ApplyType_IsChanged)
         {
         if (string.IsNullOrEmpty(asset_MApply.AMA_ApplyType))
         {
            idb.AddParameter("@AMA_ApplyType", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AMA_ApplyType", asset_MApply.AMA_ApplyType);
         }
          }
         if(asset_MApply.AMA_Type_IsChanged)
         {
         if (string.IsNullOrEmpty(asset_MApply.AMA_Type))
         {
            idb.AddParameter("@AMA_Type", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AMA_Type", asset_MApply.AMA_Type);
         }
          }
         if(asset_MApply.Stat_IsChanged)
         {
         if (asset_MApply.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", asset_MApply.Stat);
         }
          }
         if(asset_MApply.CreateDate_IsChanged)
         {
         if (asset_MApply.CreateDate == DateTime.MinValue)
         {
            idb.AddParameter("@CreateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateDate", asset_MApply.CreateDate);
         }
          }
         if(asset_MApply.UpdateDate_IsChanged)
         {
         if (asset_MApply.UpdateDate == DateTime.MinValue)
         {
            idb.AddParameter("@UpdateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@UpdateDate", asset_MApply.UpdateDate);
         }
          }
         if(asset_MApply.DeleteDate_IsChanged)
         {
         if (asset_MApply.DeleteDate == DateTime.MinValue)
         {
            idb.AddParameter("@DeleteDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DeleteDate", asset_MApply.DeleteDate);
         }
          }
         if(asset_MApply.AuditCurAudit_IsChanged)
         {
         if (string.IsNullOrEmpty(asset_MApply.AuditCurAudit))
         {
            idb.AddParameter("@AuditCurAudit", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AuditCurAudit", asset_MApply.AuditCurAudit);
         }
          }
         if(asset_MApply.AMA_name_IsChanged)
         {
         if (string.IsNullOrEmpty(asset_MApply.AMA_name))
         {
            idb.AddParameter("@AMA_name", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AMA_name", asset_MApply.AMA_name);
         }
          }
         if(asset_MApply.AMA_CompanyCode_IsChanged)
         {
         if (string.IsNullOrEmpty(asset_MApply.AMA_CompanyCode))
         {
            idb.AddParameter("@AMA_CompanyCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AMA_CompanyCode", asset_MApply.AMA_CompanyCode);
         }
          }
         if(asset_MApply.AMA_DeptCode_IsChanged)
         {
         if (string.IsNullOrEmpty(asset_MApply.AMA_DeptCode))
         {
            idb.AddParameter("@AMA_DeptCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AMA_DeptCode", asset_MApply.AMA_DeptCode);
         }
          }

         idb.AddParameter("@AMA_ID", asset_MApply.AMA_ID);

           
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
      /// 删除维修申请 Asset_MApply对象(即:一条记录
      /// </summary>
      public int Delete(decimal aMA_ID)
      {
         string sql = "DELETE Asset_MApply WHERE 1=1  AND AMA_ID=@AMA_ID ";
         idb.AddParameter("@AMA_ID", aMA_ID);

           
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
      /// 获取指定的维修申请 Asset_MApply对象(即:一条记录
      /// </summary>
      public Asset_MApply GetByKey(decimal aMA_ID)
      {
         Asset_MApply asset_MApply = new Asset_MApply();
         string sql = "SELECT  AMA_ID,AMA_Code,AMA_FCode,AMA_FName,AMA_FSpec,AMA_Company,AMA_Department,AMA_Reason,AMA_Description,AMA_Date,AMA_TimeCost,AMA_Owner,AMA_OwnerCode,AMA_OpDate,AMA_ReceiveDate,AMA_OperatorCode,AMA_Operator,AMA_Content,AMA_OStatus,AMA_Stat,AuditStat,AMA_Remark,AMA_ApplyType,AMA_Type,Stat,CreateDate,UpdateDate,DeleteDate,AuditCurAudit,AMA_name,AMA_CompanyCode,AMA_DeptCode FROM Asset_MApply WHERE 1=1 AND ((Stat is null) or (Stat=0) )  AND AMA_ID=@AMA_ID ";
         idb.AddParameter("@AMA_ID", aMA_ID);

          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            if (dr["AMA_ID"] != DBNull.Value) asset_MApply.AMA_ID = Convert.ToDecimal(dr["AMA_ID"]);
            if (dr["AMA_Code"] != DBNull.Value) asset_MApply.AMA_Code = Convert.ToString(dr["AMA_Code"]);
            if (dr["AMA_FCode"] != DBNull.Value) asset_MApply.AMA_FCode = Convert.ToString(dr["AMA_FCode"]);
            if (dr["AMA_FName"] != DBNull.Value) asset_MApply.AMA_FName = Convert.ToString(dr["AMA_FName"]);
            if (dr["AMA_FSpec"] != DBNull.Value) asset_MApply.AMA_FSpec = Convert.ToString(dr["AMA_FSpec"]);
            if (dr["AMA_Company"] != DBNull.Value) asset_MApply.AMA_Company = Convert.ToString(dr["AMA_Company"]);
            if (dr["AMA_Department"] != DBNull.Value) asset_MApply.AMA_Department = Convert.ToString(dr["AMA_Department"]);
            if (dr["AMA_Reason"] != DBNull.Value) asset_MApply.AMA_Reason = Convert.ToString(dr["AMA_Reason"]);
            if (dr["AMA_Description"] != DBNull.Value) asset_MApply.AMA_Description = Convert.ToString(dr["AMA_Description"]);
            if (dr["AMA_Date"] != DBNull.Value) asset_MApply.AMA_Date = Convert.ToDateTime(dr["AMA_Date"]);
            if (dr["AMA_TimeCost"] != DBNull.Value) asset_MApply.AMA_TimeCost = Convert.ToDecimal(dr["AMA_TimeCost"]);
            if (dr["AMA_Owner"] != DBNull.Value) asset_MApply.AMA_Owner = Convert.ToString(dr["AMA_Owner"]);
            if (dr["AMA_OwnerCode"] != DBNull.Value) asset_MApply.AMA_OwnerCode = Convert.ToString(dr["AMA_OwnerCode"]);
            if (dr["AMA_OpDate"] != DBNull.Value) asset_MApply.AMA_OpDate = Convert.ToDateTime(dr["AMA_OpDate"]);
            if (dr["AMA_ReceiveDate"] != DBNull.Value) asset_MApply.AMA_ReceiveDate = Convert.ToDateTime(dr["AMA_ReceiveDate"]);
            if (dr["AMA_OperatorCode"] != DBNull.Value) asset_MApply.AMA_OperatorCode = Convert.ToString(dr["AMA_OperatorCode"]);
            if (dr["AMA_Operator"] != DBNull.Value) asset_MApply.AMA_Operator = Convert.ToString(dr["AMA_Operator"]);
            if (dr["AMA_Content"] != DBNull.Value) asset_MApply.AMA_Content = Convert.ToString(dr["AMA_Content"]);
            if (dr["AMA_OStatus"] != DBNull.Value) asset_MApply.AMA_OStatus = Convert.ToString(dr["AMA_OStatus"]);
            if (dr["AMA_Stat"] != DBNull.Value) asset_MApply.AMA_Stat = Convert.ToString(dr["AMA_Stat"]);
            if (dr["AuditStat"] != DBNull.Value) asset_MApply.AuditStat = Convert.ToString(dr["AuditStat"]);
            if (dr["AMA_Remark"] != DBNull.Value) asset_MApply.AMA_Remark = Convert.ToString(dr["AMA_Remark"]);
            if (dr["AMA_ApplyType"] != DBNull.Value) asset_MApply.AMA_ApplyType = Convert.ToString(dr["AMA_ApplyType"]);
            if (dr["AMA_Type"] != DBNull.Value) asset_MApply.AMA_Type = Convert.ToString(dr["AMA_Type"]);
            if (dr["Stat"] != DBNull.Value) asset_MApply.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["CreateDate"] != DBNull.Value) asset_MApply.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
            if (dr["UpdateDate"] != DBNull.Value) asset_MApply.UpdateDate = Convert.ToDateTime(dr["UpdateDate"]);
            if (dr["DeleteDate"] != DBNull.Value) asset_MApply.DeleteDate = Convert.ToDateTime(dr["DeleteDate"]);
            if (dr["AuditCurAudit"] != DBNull.Value) asset_MApply.AuditCurAudit = Convert.ToString(dr["AuditCurAudit"]);
            if (dr["AMA_name"] != DBNull.Value) asset_MApply.AMA_name = Convert.ToString(dr["AMA_name"]);
            if (dr["AMA_CompanyCode"] != DBNull.Value) asset_MApply.AMA_CompanyCode = Convert.ToString(dr["AMA_CompanyCode"]);
            if (dr["AMA_DeptCode"] != DBNull.Value) asset_MApply.AMA_DeptCode = Convert.ToString(dr["AMA_DeptCode"]);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   }  
         return asset_MApply;
      }
      /// <summary>
      /// 获取指定的维修申请 Asset_MApply对象集合
      /// </summary>
      public List<Asset_MApply> GetListByWhere(string strCondition)
      {
         List<Asset_MApply> ret = new List<Asset_MApply>();
         string sql = "SELECT  AMA_ID,AMA_Code,AMA_FCode,AMA_FName,AMA_FSpec,AMA_Company,AMA_Department,AMA_Reason,AMA_Description,AMA_Date,AMA_TimeCost,AMA_Owner,AMA_OwnerCode,AMA_OpDate,AMA_ReceiveDate,AMA_OperatorCode,AMA_Operator,AMA_Content,AMA_OStatus,AMA_Stat,AuditStat,AMA_Remark,AMA_ApplyType,AMA_Type,Stat,CreateDate,UpdateDate,DeleteDate,AuditCurAudit,AMA_name,AMA_CompanyCode,AMA_DeptCode FROM Asset_MApply WHERE 1=1 AND ((Stat is null) or (Stat=0) ) ";
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
            Asset_MApply asset_MApply = new Asset_MApply();
            if (dr["AMA_ID"] != DBNull.Value) asset_MApply.AMA_ID = Convert.ToDecimal(dr["AMA_ID"]);
            if (dr["AMA_Code"] != DBNull.Value) asset_MApply.AMA_Code = Convert.ToString(dr["AMA_Code"]);
            if (dr["AMA_FCode"] != DBNull.Value) asset_MApply.AMA_FCode = Convert.ToString(dr["AMA_FCode"]);
            if (dr["AMA_FName"] != DBNull.Value) asset_MApply.AMA_FName = Convert.ToString(dr["AMA_FName"]);
            if (dr["AMA_FSpec"] != DBNull.Value) asset_MApply.AMA_FSpec = Convert.ToString(dr["AMA_FSpec"]);
            if (dr["AMA_Company"] != DBNull.Value) asset_MApply.AMA_Company = Convert.ToString(dr["AMA_Company"]);
            if (dr["AMA_Department"] != DBNull.Value) asset_MApply.AMA_Department = Convert.ToString(dr["AMA_Department"]);
            if (dr["AMA_Reason"] != DBNull.Value) asset_MApply.AMA_Reason = Convert.ToString(dr["AMA_Reason"]);
            if (dr["AMA_Description"] != DBNull.Value) asset_MApply.AMA_Description = Convert.ToString(dr["AMA_Description"]);
            if (dr["AMA_Date"] != DBNull.Value) asset_MApply.AMA_Date = Convert.ToDateTime(dr["AMA_Date"]);
            if (dr["AMA_TimeCost"] != DBNull.Value) asset_MApply.AMA_TimeCost = Convert.ToDecimal(dr["AMA_TimeCost"]);
            if (dr["AMA_Owner"] != DBNull.Value) asset_MApply.AMA_Owner = Convert.ToString(dr["AMA_Owner"]);
            if (dr["AMA_OwnerCode"] != DBNull.Value) asset_MApply.AMA_OwnerCode = Convert.ToString(dr["AMA_OwnerCode"]);
            if (dr["AMA_OpDate"] != DBNull.Value) asset_MApply.AMA_OpDate = Convert.ToDateTime(dr["AMA_OpDate"]);
            if (dr["AMA_ReceiveDate"] != DBNull.Value) asset_MApply.AMA_ReceiveDate = Convert.ToDateTime(dr["AMA_ReceiveDate"]);
            if (dr["AMA_OperatorCode"] != DBNull.Value) asset_MApply.AMA_OperatorCode = Convert.ToString(dr["AMA_OperatorCode"]);
            if (dr["AMA_Operator"] != DBNull.Value) asset_MApply.AMA_Operator = Convert.ToString(dr["AMA_Operator"]);
            if (dr["AMA_Content"] != DBNull.Value) asset_MApply.AMA_Content = Convert.ToString(dr["AMA_Content"]);
            if (dr["AMA_OStatus"] != DBNull.Value) asset_MApply.AMA_OStatus = Convert.ToString(dr["AMA_OStatus"]);
            if (dr["AMA_Stat"] != DBNull.Value) asset_MApply.AMA_Stat = Convert.ToString(dr["AMA_Stat"]);
            if (dr["AuditStat"] != DBNull.Value) asset_MApply.AuditStat = Convert.ToString(dr["AuditStat"]);
            if (dr["AMA_Remark"] != DBNull.Value) asset_MApply.AMA_Remark = Convert.ToString(dr["AMA_Remark"]);
            if (dr["AMA_ApplyType"] != DBNull.Value) asset_MApply.AMA_ApplyType = Convert.ToString(dr["AMA_ApplyType"]);
            if (dr["AMA_Type"] != DBNull.Value) asset_MApply.AMA_Type = Convert.ToString(dr["AMA_Type"]);
            if (dr["Stat"] != DBNull.Value) asset_MApply.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["CreateDate"] != DBNull.Value) asset_MApply.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
            if (dr["UpdateDate"] != DBNull.Value) asset_MApply.UpdateDate = Convert.ToDateTime(dr["UpdateDate"]);
            if (dr["DeleteDate"] != DBNull.Value) asset_MApply.DeleteDate = Convert.ToDateTime(dr["DeleteDate"]);
            if (dr["AuditCurAudit"] != DBNull.Value) asset_MApply.AuditCurAudit = Convert.ToString(dr["AuditCurAudit"]);
            if (dr["AMA_name"] != DBNull.Value) asset_MApply.AMA_name = Convert.ToString(dr["AMA_name"]);
            if (dr["AMA_CompanyCode"] != DBNull.Value) asset_MApply.AMA_CompanyCode = Convert.ToString(dr["AMA_CompanyCode"]);
            if (dr["AMA_DeptCode"] != DBNull.Value) asset_MApply.AMA_DeptCode = Convert.ToString(dr["AMA_DeptCode"]);
            ret.Add(asset_MApply);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   }  
         return ret;
      }
      /// <summary>
      /// 获取所有的维修申请 Asset_MApply对象(即:一条记录
      /// </summary>
      public List<Asset_MApply> GetAll()
      {
         List<Asset_MApply> ret = new List<Asset_MApply>();
         string sql = "SELECT  AMA_ID,AMA_Code,AMA_FCode,AMA_FName,AMA_FSpec,AMA_Company,AMA_Department,AMA_Reason,AMA_Description,AMA_Date,AMA_TimeCost,AMA_Owner,AMA_OwnerCode,AMA_OpDate,AMA_ReceiveDate,AMA_OperatorCode,AMA_Operator,AMA_Content,AMA_OStatus,AMA_Stat,AuditStat,AMA_Remark,AMA_ApplyType,AMA_Type,Stat,CreateDate,UpdateDate,DeleteDate,AuditCurAudit,AMA_name,AMA_CompanyCode,AMA_DeptCode FROM Asset_MApply where 1=1 AND ((Stat is null) or (Stat=0) ) order by AMA_ID desc ";
          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            Asset_MApply asset_MApply = new Asset_MApply();
            if (dr["AMA_ID"] != DBNull.Value) asset_MApply.AMA_ID = Convert.ToDecimal(dr["AMA_ID"]);
            if (dr["AMA_Code"] != DBNull.Value) asset_MApply.AMA_Code = Convert.ToString(dr["AMA_Code"]);
            if (dr["AMA_FCode"] != DBNull.Value) asset_MApply.AMA_FCode = Convert.ToString(dr["AMA_FCode"]);
            if (dr["AMA_FName"] != DBNull.Value) asset_MApply.AMA_FName = Convert.ToString(dr["AMA_FName"]);
            if (dr["AMA_FSpec"] != DBNull.Value) asset_MApply.AMA_FSpec = Convert.ToString(dr["AMA_FSpec"]);
            if (dr["AMA_Company"] != DBNull.Value) asset_MApply.AMA_Company = Convert.ToString(dr["AMA_Company"]);
            if (dr["AMA_Department"] != DBNull.Value) asset_MApply.AMA_Department = Convert.ToString(dr["AMA_Department"]);
            if (dr["AMA_Reason"] != DBNull.Value) asset_MApply.AMA_Reason = Convert.ToString(dr["AMA_Reason"]);
            if (dr["AMA_Description"] != DBNull.Value) asset_MApply.AMA_Description = Convert.ToString(dr["AMA_Description"]);
            if (dr["AMA_Date"] != DBNull.Value) asset_MApply.AMA_Date = Convert.ToDateTime(dr["AMA_Date"]);
            if (dr["AMA_TimeCost"] != DBNull.Value) asset_MApply.AMA_TimeCost = Convert.ToDecimal(dr["AMA_TimeCost"]);
            if (dr["AMA_Owner"] != DBNull.Value) asset_MApply.AMA_Owner = Convert.ToString(dr["AMA_Owner"]);
            if (dr["AMA_OwnerCode"] != DBNull.Value) asset_MApply.AMA_OwnerCode = Convert.ToString(dr["AMA_OwnerCode"]);
            if (dr["AMA_OpDate"] != DBNull.Value) asset_MApply.AMA_OpDate = Convert.ToDateTime(dr["AMA_OpDate"]);
            if (dr["AMA_ReceiveDate"] != DBNull.Value) asset_MApply.AMA_ReceiveDate = Convert.ToDateTime(dr["AMA_ReceiveDate"]);
            if (dr["AMA_OperatorCode"] != DBNull.Value) asset_MApply.AMA_OperatorCode = Convert.ToString(dr["AMA_OperatorCode"]);
            if (dr["AMA_Operator"] != DBNull.Value) asset_MApply.AMA_Operator = Convert.ToString(dr["AMA_Operator"]);
            if (dr["AMA_Content"] != DBNull.Value) asset_MApply.AMA_Content = Convert.ToString(dr["AMA_Content"]);
            if (dr["AMA_OStatus"] != DBNull.Value) asset_MApply.AMA_OStatus = Convert.ToString(dr["AMA_OStatus"]);
            if (dr["AMA_Stat"] != DBNull.Value) asset_MApply.AMA_Stat = Convert.ToString(dr["AMA_Stat"]);
            if (dr["AuditStat"] != DBNull.Value) asset_MApply.AuditStat = Convert.ToString(dr["AuditStat"]);
            if (dr["AMA_Remark"] != DBNull.Value) asset_MApply.AMA_Remark = Convert.ToString(dr["AMA_Remark"]);
            if (dr["AMA_ApplyType"] != DBNull.Value) asset_MApply.AMA_ApplyType = Convert.ToString(dr["AMA_ApplyType"]);
            if (dr["AMA_Type"] != DBNull.Value) asset_MApply.AMA_Type = Convert.ToString(dr["AMA_Type"]);
            if (dr["Stat"] != DBNull.Value) asset_MApply.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["CreateDate"] != DBNull.Value) asset_MApply.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
            if (dr["UpdateDate"] != DBNull.Value) asset_MApply.UpdateDate = Convert.ToDateTime(dr["UpdateDate"]);
            if (dr["DeleteDate"] != DBNull.Value) asset_MApply.DeleteDate = Convert.ToDateTime(dr["DeleteDate"]);
            if (dr["AuditCurAudit"] != DBNull.Value) asset_MApply.AuditCurAudit = Convert.ToString(dr["AuditCurAudit"]);
            if (dr["AMA_name"] != DBNull.Value) asset_MApply.AMA_name = Convert.ToString(dr["AMA_name"]);
            if (dr["AMA_CompanyCode"] != DBNull.Value) asset_MApply.AMA_CompanyCode = Convert.ToString(dr["AMA_CompanyCode"]);
            if (dr["AMA_DeptCode"] != DBNull.Value) asset_MApply.AMA_DeptCode = Convert.ToString(dr["AMA_DeptCode"]);
            ret.Add(asset_MApply);
         }
          }catch (System.Exception ex){ throw ex; }  finally {  if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   } 
         return ret;
      }
   }
}
