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
   /// 固定资产流程
   /// </summary>
   [Serializable]
   public partial class ADOAsset_Process
   {
      public IDBOperator idb =  DBOperator.GetInstance();
      /// <summary>
      /// 添加固定资产流程 Asset_Process对象(即:一条记录)
      /// </summary>
      public int Add(Asset_Process asset_Process)
      {
         string sql = "INSERT INTO Asset_Process (AP_Code,AP_Type,AP_Title,AP_Company,AP_CompanyCode,AP_DepartmentCode,AP_Department,AP_Owner,AP_Content,AP_FCode,AP_FName,AP_Reason,AP_Conclusion,AuditStat,AuditCurAudit,Stat,CreateDate,UpdateDate,DeleteDate,AP_itype,AuditStatName,AP_Status,AP_SCode,AP_SName,AP_Contact,AP_Mobile) VALUES (@AP_Code,@AP_Type,@AP_Title,@AP_Company,@AP_CompanyCode,@AP_DepartmentCode,@AP_Department,@AP_Owner,@AP_Content,@AP_FCode,@AP_FName,@AP_Reason,@AP_Conclusion,@AuditStat,@AuditCurAudit,@Stat,@CreateDate,@UpdateDate,@DeleteDate,@AP_itype,@AuditStatName,@AP_Status,@AP_SCode,@AP_SName,@AP_Contact,@AP_Mobile)";
         if (string.IsNullOrEmpty(asset_Process.AP_Code))
         {
            idb.AddParameter("@AP_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AP_Code", asset_Process.AP_Code);
         }
         if (string.IsNullOrEmpty(asset_Process.AP_Type))
         {
            idb.AddParameter("@AP_Type", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AP_Type", asset_Process.AP_Type);
         }
         if (string.IsNullOrEmpty(asset_Process.AP_Title))
         {
            idb.AddParameter("@AP_Title", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AP_Title", asset_Process.AP_Title);
         }
         if (string.IsNullOrEmpty(asset_Process.AP_Company))
         {
            idb.AddParameter("@AP_Company", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AP_Company", asset_Process.AP_Company);
         }
         if (string.IsNullOrEmpty(asset_Process.AP_CompanyCode))
         {
            idb.AddParameter("@AP_CompanyCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AP_CompanyCode", asset_Process.AP_CompanyCode);
         }
         if (string.IsNullOrEmpty(asset_Process.AP_DepartmentCode))
         {
            idb.AddParameter("@AP_DepartmentCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AP_DepartmentCode", asset_Process.AP_DepartmentCode);
         }
         if (string.IsNullOrEmpty(asset_Process.AP_Department))
         {
            idb.AddParameter("@AP_Department", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AP_Department", asset_Process.AP_Department);
         }
         if (string.IsNullOrEmpty(asset_Process.AP_Owner))
         {
            idb.AddParameter("@AP_Owner", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AP_Owner", asset_Process.AP_Owner);
         }
         if (string.IsNullOrEmpty(asset_Process.AP_Content))
         {
            idb.AddParameter("@AP_Content", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AP_Content", asset_Process.AP_Content);
         }
         if (string.IsNullOrEmpty(asset_Process.AP_FCode))
         {
            idb.AddParameter("@AP_FCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AP_FCode", asset_Process.AP_FCode);
         }
         if (string.IsNullOrEmpty(asset_Process.AP_FName))
         {
            idb.AddParameter("@AP_FName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AP_FName", asset_Process.AP_FName);
         }
         if (string.IsNullOrEmpty(asset_Process.AP_Reason))
         {
            idb.AddParameter("@AP_Reason", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AP_Reason", asset_Process.AP_Reason);
         }
         if (string.IsNullOrEmpty(asset_Process.AP_Conclusion))
         {
            idb.AddParameter("@AP_Conclusion", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AP_Conclusion", asset_Process.AP_Conclusion);
         }
         if (string.IsNullOrEmpty(asset_Process.AuditStat))
         {
            idb.AddParameter("@AuditStat", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AuditStat", asset_Process.AuditStat);
         }
         if (string.IsNullOrEmpty(asset_Process.AuditCurAudit))
         {
            idb.AddParameter("@AuditCurAudit", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AuditCurAudit", asset_Process.AuditCurAudit);
         }
         if (asset_Process.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", asset_Process.Stat);
         }
         if (asset_Process.CreateDate == DateTime.MinValue)
         {
            idb.AddParameter("@CreateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateDate", asset_Process.CreateDate);
         }
         if (asset_Process.UpdateDate == DateTime.MinValue)
         {
            idb.AddParameter("@UpdateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@UpdateDate", asset_Process.UpdateDate);
         }
         if (asset_Process.DeleteDate == DateTime.MinValue)
         {
            idb.AddParameter("@DeleteDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DeleteDate", asset_Process.DeleteDate);
         }
         if (string.IsNullOrEmpty(asset_Process.AP_itype))
         {
            idb.AddParameter("@AP_itype", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AP_itype", asset_Process.AP_itype);
         }
         if (string.IsNullOrEmpty(asset_Process.AuditStatName))
         {
            idb.AddParameter("@AuditStatName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AuditStatName", asset_Process.AuditStatName);
         }
         if (string.IsNullOrEmpty(asset_Process.AP_Status))
         {
            idb.AddParameter("@AP_Status", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AP_Status", asset_Process.AP_Status);
         }
         if (string.IsNullOrEmpty(asset_Process.AP_SCode))
         {
            idb.AddParameter("@AP_SCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AP_SCode", asset_Process.AP_SCode);
         }
         if (string.IsNullOrEmpty(asset_Process.AP_SName))
         {
            idb.AddParameter("@AP_SName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AP_SName", asset_Process.AP_SName);
         }
         if (string.IsNullOrEmpty(asset_Process.AP_Contact))
         {
            idb.AddParameter("@AP_Contact", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AP_Contact", asset_Process.AP_Contact);
         }
         if (string.IsNullOrEmpty(asset_Process.AP_Mobile))
         {
            idb.AddParameter("@AP_Mobile", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AP_Mobile", asset_Process.AP_Mobile);
         }

         return idb.ExeCmd(sql);
      }
      /// <summary>
      /// 添加固定资产流程 Asset_Process对象(即:一条记录)
      /// </summary>
      public object AddWithReturn(Asset_Process asset_Process)
      {
         string sql = "INSERT INTO Asset_Process (AP_Code,AP_Type,AP_Title,AP_Company,AP_CompanyCode,AP_DepartmentCode,AP_Department,AP_Owner,AP_Content,AP_FCode,AP_FName,AP_Reason,AP_Conclusion,AuditStat,AuditCurAudit,Stat,CreateDate,UpdateDate,DeleteDate,AP_itype,AuditStatName,AP_Status,AP_SCode,AP_SName,AP_Contact,AP_Mobile) VALUES (@AP_Code,@AP_Type,@AP_Title,@AP_Company,@AP_CompanyCode,@AP_DepartmentCode,@AP_Department,@AP_Owner,@AP_Content,@AP_FCode,@AP_FName,@AP_Reason,@AP_Conclusion,@AuditStat,@AuditCurAudit,@Stat,@CreateDate,@UpdateDate,@DeleteDate,@AP_itype,@AuditStatName,@AP_Status,@AP_SCode,@AP_SName,@AP_Contact,@AP_Mobile);SELECT @@IDENTITY AS ReturnID;";
         if (string.IsNullOrEmpty(asset_Process.AP_Code))
         {
            idb.AddParameter("@AP_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AP_Code", asset_Process.AP_Code);
         }
         if (string.IsNullOrEmpty(asset_Process.AP_Type))
         {
            idb.AddParameter("@AP_Type", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AP_Type", asset_Process.AP_Type);
         }
         if (string.IsNullOrEmpty(asset_Process.AP_Title))
         {
            idb.AddParameter("@AP_Title", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AP_Title", asset_Process.AP_Title);
         }
         if (string.IsNullOrEmpty(asset_Process.AP_Company))
         {
            idb.AddParameter("@AP_Company", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AP_Company", asset_Process.AP_Company);
         }
         if (string.IsNullOrEmpty(asset_Process.AP_CompanyCode))
         {
            idb.AddParameter("@AP_CompanyCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AP_CompanyCode", asset_Process.AP_CompanyCode);
         }
         if (string.IsNullOrEmpty(asset_Process.AP_DepartmentCode))
         {
            idb.AddParameter("@AP_DepartmentCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AP_DepartmentCode", asset_Process.AP_DepartmentCode);
         }
         if (string.IsNullOrEmpty(asset_Process.AP_Department))
         {
            idb.AddParameter("@AP_Department", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AP_Department", asset_Process.AP_Department);
         }
         if (string.IsNullOrEmpty(asset_Process.AP_Owner))
         {
            idb.AddParameter("@AP_Owner", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AP_Owner", asset_Process.AP_Owner);
         }
         if (string.IsNullOrEmpty(asset_Process.AP_Content))
         {
            idb.AddParameter("@AP_Content", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AP_Content", asset_Process.AP_Content);
         }
         if (string.IsNullOrEmpty(asset_Process.AP_FCode))
         {
            idb.AddParameter("@AP_FCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AP_FCode", asset_Process.AP_FCode);
         }
         if (string.IsNullOrEmpty(asset_Process.AP_FName))
         {
            idb.AddParameter("@AP_FName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AP_FName", asset_Process.AP_FName);
         }
         if (string.IsNullOrEmpty(asset_Process.AP_Reason))
         {
            idb.AddParameter("@AP_Reason", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AP_Reason", asset_Process.AP_Reason);
         }
         if (string.IsNullOrEmpty(asset_Process.AP_Conclusion))
         {
            idb.AddParameter("@AP_Conclusion", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AP_Conclusion", asset_Process.AP_Conclusion);
         }
         if (string.IsNullOrEmpty(asset_Process.AuditStat))
         {
            idb.AddParameter("@AuditStat", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AuditStat", asset_Process.AuditStat);
         }
         if (string.IsNullOrEmpty(asset_Process.AuditCurAudit))
         {
            idb.AddParameter("@AuditCurAudit", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AuditCurAudit", asset_Process.AuditCurAudit);
         }
         if (asset_Process.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", asset_Process.Stat);
         }
         if (asset_Process.CreateDate == DateTime.MinValue)
         {
            idb.AddParameter("@CreateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateDate", asset_Process.CreateDate);
         }
         if (asset_Process.UpdateDate == DateTime.MinValue)
         {
            idb.AddParameter("@UpdateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@UpdateDate", asset_Process.UpdateDate);
         }
         if (asset_Process.DeleteDate == DateTime.MinValue)
         {
            idb.AddParameter("@DeleteDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DeleteDate", asset_Process.DeleteDate);
         }
         if (string.IsNullOrEmpty(asset_Process.AP_itype))
         {
            idb.AddParameter("@AP_itype", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AP_itype", asset_Process.AP_itype);
         }
         if (string.IsNullOrEmpty(asset_Process.AuditStatName))
         {
            idb.AddParameter("@AuditStatName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AuditStatName", asset_Process.AuditStatName);
         }
         if (string.IsNullOrEmpty(asset_Process.AP_Status))
         {
            idb.AddParameter("@AP_Status", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AP_Status", asset_Process.AP_Status);
         }
         if (string.IsNullOrEmpty(asset_Process.AP_SCode))
         {
            idb.AddParameter("@AP_SCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AP_SCode", asset_Process.AP_SCode);
         }
         if (string.IsNullOrEmpty(asset_Process.AP_SName))
         {
            idb.AddParameter("@AP_SName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AP_SName", asset_Process.AP_SName);
         }
         if (string.IsNullOrEmpty(asset_Process.AP_Contact))
         {
            idb.AddParameter("@AP_Contact", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AP_Contact", asset_Process.AP_Contact);
         }
         if (string.IsNullOrEmpty(asset_Process.AP_Mobile))
         {
            idb.AddParameter("@AP_Mobile", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AP_Mobile", asset_Process.AP_Mobile);
         }

         return idb.ReturnValue(sql);
      }
      /// <summary>
      /// 更新固定资产流程 Asset_Process对象(即:一条记录
      /// </summary>
      public int Update(Asset_Process asset_Process)
      {
         
         StringBuilder sbParameter=new StringBuilder();
      StringBuilder sb=new StringBuilder();
      sb.Append(@"UPDATE       Asset_Process       SET ");
            if(asset_Process.AP_Code_IsChanged){sbParameter.Append("AP_Code=@AP_Code, ");}
      if(asset_Process.AP_Type_IsChanged){sbParameter.Append("AP_Type=@AP_Type, ");}
      if(asset_Process.AP_Title_IsChanged){sbParameter.Append("AP_Title=@AP_Title, ");}
      if(asset_Process.AP_Company_IsChanged){sbParameter.Append("AP_Company=@AP_Company, ");}
      if(asset_Process.AP_CompanyCode_IsChanged){sbParameter.Append("AP_CompanyCode=@AP_CompanyCode, ");}
      if(asset_Process.AP_DepartmentCode_IsChanged){sbParameter.Append("AP_DepartmentCode=@AP_DepartmentCode, ");}
      if(asset_Process.AP_Department_IsChanged){sbParameter.Append("AP_Department=@AP_Department, ");}
      if(asset_Process.AP_Owner_IsChanged){sbParameter.Append("AP_Owner=@AP_Owner, ");}
      if(asset_Process.AP_Content_IsChanged){sbParameter.Append("AP_Content=@AP_Content, ");}
      if(asset_Process.AP_FCode_IsChanged){sbParameter.Append("AP_FCode=@AP_FCode, ");}
      if(asset_Process.AP_FName_IsChanged){sbParameter.Append("AP_FName=@AP_FName, ");}
      if(asset_Process.AP_Reason_IsChanged){sbParameter.Append("AP_Reason=@AP_Reason, ");}
      if(asset_Process.AP_Conclusion_IsChanged){sbParameter.Append("AP_Conclusion=@AP_Conclusion, ");}
      if(asset_Process.AuditStat_IsChanged){sbParameter.Append("AuditStat=@AuditStat, ");}
      if(asset_Process.AuditCurAudit_IsChanged){sbParameter.Append("AuditCurAudit=@AuditCurAudit, ");}
      if(asset_Process.Stat_IsChanged){sbParameter.Append("Stat=@Stat, ");}
      if(asset_Process.CreateDate_IsChanged){sbParameter.Append("CreateDate=@CreateDate, ");}
      if(asset_Process.UpdateDate_IsChanged){sbParameter.Append("UpdateDate=@UpdateDate, ");}
      if(asset_Process.DeleteDate_IsChanged){sbParameter.Append("DeleteDate=@DeleteDate, ");}
      if(asset_Process.AP_itype_IsChanged){sbParameter.Append("AP_itype=@AP_itype, ");}
      if(asset_Process.AuditStatName_IsChanged){sbParameter.Append("AuditStatName=@AuditStatName, ");}
      if(asset_Process.AP_Status_IsChanged){sbParameter.Append("AP_Status=@AP_Status, ");}
      if(asset_Process.AP_SCode_IsChanged){sbParameter.Append("AP_SCode=@AP_SCode, ");}
      if(asset_Process.AP_SName_IsChanged){sbParameter.Append("AP_SName=@AP_SName, ");}
      if(asset_Process.AP_Contact_IsChanged){sbParameter.Append("AP_Contact=@AP_Contact, ");}
      if(asset_Process.AP_Mobile_IsChanged){sbParameter.Append("AP_Mobile=@AP_Mobile ");}          sb.Append(sbParameter.ToString().Trim().TrimEnd(',')); 
      sb.Append(      " WHERE 1=1 AND ((Stat is null) or (Stat=0))   and AP_ID=@AP_ID; " );
      string sql=sb.ToString();
         if(asset_Process.AP_Code_IsChanged)
         {
         if (string.IsNullOrEmpty(asset_Process.AP_Code))
         {
            idb.AddParameter("@AP_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AP_Code", asset_Process.AP_Code);
         }
          }
         if(asset_Process.AP_Type_IsChanged)
         {
         if (string.IsNullOrEmpty(asset_Process.AP_Type))
         {
            idb.AddParameter("@AP_Type", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AP_Type", asset_Process.AP_Type);
         }
          }
         if(asset_Process.AP_Title_IsChanged)
         {
         if (string.IsNullOrEmpty(asset_Process.AP_Title))
         {
            idb.AddParameter("@AP_Title", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AP_Title", asset_Process.AP_Title);
         }
          }
         if(asset_Process.AP_Company_IsChanged)
         {
         if (string.IsNullOrEmpty(asset_Process.AP_Company))
         {
            idb.AddParameter("@AP_Company", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AP_Company", asset_Process.AP_Company);
         }
          }
         if(asset_Process.AP_CompanyCode_IsChanged)
         {
         if (string.IsNullOrEmpty(asset_Process.AP_CompanyCode))
         {
            idb.AddParameter("@AP_CompanyCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AP_CompanyCode", asset_Process.AP_CompanyCode);
         }
          }
         if(asset_Process.AP_DepartmentCode_IsChanged)
         {
         if (string.IsNullOrEmpty(asset_Process.AP_DepartmentCode))
         {
            idb.AddParameter("@AP_DepartmentCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AP_DepartmentCode", asset_Process.AP_DepartmentCode);
         }
          }
         if(asset_Process.AP_Department_IsChanged)
         {
         if (string.IsNullOrEmpty(asset_Process.AP_Department))
         {
            idb.AddParameter("@AP_Department", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AP_Department", asset_Process.AP_Department);
         }
          }
         if(asset_Process.AP_Owner_IsChanged)
         {
         if (string.IsNullOrEmpty(asset_Process.AP_Owner))
         {
            idb.AddParameter("@AP_Owner", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AP_Owner", asset_Process.AP_Owner);
         }
          }
         if(asset_Process.AP_Content_IsChanged)
         {
         if (string.IsNullOrEmpty(asset_Process.AP_Content))
         {
            idb.AddParameter("@AP_Content", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AP_Content", asset_Process.AP_Content);
         }
          }
         if(asset_Process.AP_FCode_IsChanged)
         {
         if (string.IsNullOrEmpty(asset_Process.AP_FCode))
         {
            idb.AddParameter("@AP_FCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AP_FCode", asset_Process.AP_FCode);
         }
          }
         if(asset_Process.AP_FName_IsChanged)
         {
         if (string.IsNullOrEmpty(asset_Process.AP_FName))
         {
            idb.AddParameter("@AP_FName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AP_FName", asset_Process.AP_FName);
         }
          }
         if(asset_Process.AP_Reason_IsChanged)
         {
         if (string.IsNullOrEmpty(asset_Process.AP_Reason))
         {
            idb.AddParameter("@AP_Reason", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AP_Reason", asset_Process.AP_Reason);
         }
          }
         if(asset_Process.AP_Conclusion_IsChanged)
         {
         if (string.IsNullOrEmpty(asset_Process.AP_Conclusion))
         {
            idb.AddParameter("@AP_Conclusion", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AP_Conclusion", asset_Process.AP_Conclusion);
         }
          }
         if(asset_Process.AuditStat_IsChanged)
         {
         if (string.IsNullOrEmpty(asset_Process.AuditStat))
         {
            idb.AddParameter("@AuditStat", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AuditStat", asset_Process.AuditStat);
         }
          }
         if(asset_Process.AuditCurAudit_IsChanged)
         {
         if (string.IsNullOrEmpty(asset_Process.AuditCurAudit))
         {
            idb.AddParameter("@AuditCurAudit", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AuditCurAudit", asset_Process.AuditCurAudit);
         }
          }
         if(asset_Process.Stat_IsChanged)
         {
         if (asset_Process.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", asset_Process.Stat);
         }
          }
         if(asset_Process.CreateDate_IsChanged)
         {
         if (asset_Process.CreateDate == DateTime.MinValue)
         {
            idb.AddParameter("@CreateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateDate", asset_Process.CreateDate);
         }
          }
         if(asset_Process.UpdateDate_IsChanged)
         {
         if (asset_Process.UpdateDate == DateTime.MinValue)
         {
            idb.AddParameter("@UpdateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@UpdateDate", asset_Process.UpdateDate);
         }
          }
         if(asset_Process.DeleteDate_IsChanged)
         {
         if (asset_Process.DeleteDate == DateTime.MinValue)
         {
            idb.AddParameter("@DeleteDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DeleteDate", asset_Process.DeleteDate);
         }
          }
         if(asset_Process.AP_itype_IsChanged)
         {
         if (string.IsNullOrEmpty(asset_Process.AP_itype))
         {
            idb.AddParameter("@AP_itype", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AP_itype", asset_Process.AP_itype);
         }
          }
         if(asset_Process.AuditStatName_IsChanged)
         {
         if (string.IsNullOrEmpty(asset_Process.AuditStatName))
         {
            idb.AddParameter("@AuditStatName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AuditStatName", asset_Process.AuditStatName);
         }
          }
         if(asset_Process.AP_Status_IsChanged)
         {
         if (string.IsNullOrEmpty(asset_Process.AP_Status))
         {
            idb.AddParameter("@AP_Status", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AP_Status", asset_Process.AP_Status);
         }
          }
         if(asset_Process.AP_SCode_IsChanged)
         {
         if (string.IsNullOrEmpty(asset_Process.AP_SCode))
         {
            idb.AddParameter("@AP_SCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AP_SCode", asset_Process.AP_SCode);
         }
          }
         if(asset_Process.AP_SName_IsChanged)
         {
         if (string.IsNullOrEmpty(asset_Process.AP_SName))
         {
            idb.AddParameter("@AP_SName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AP_SName", asset_Process.AP_SName);
         }
          }
         if(asset_Process.AP_Contact_IsChanged)
         {
         if (string.IsNullOrEmpty(asset_Process.AP_Contact))
         {
            idb.AddParameter("@AP_Contact", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AP_Contact", asset_Process.AP_Contact);
         }
          }
         if(asset_Process.AP_Mobile_IsChanged)
         {
         if (string.IsNullOrEmpty(asset_Process.AP_Mobile))
         {
            idb.AddParameter("@AP_Mobile", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AP_Mobile", asset_Process.AP_Mobile);
         }
          }

         idb.AddParameter("@AP_ID", asset_Process.AP_ID);

         return idb.ExeCmd(sql);
      }
      /// <summary>
      /// 删除固定资产流程 Asset_Process对象(即:一条记录
      /// </summary>
      public int Delete(decimal aP_ID)
      {
         string sql = "DELETE Asset_Process WHERE 1=1  AND AP_ID=@AP_ID ";
         idb.AddParameter("@AP_ID", aP_ID);

         return idb.ExeCmd(sql);
      }
      /// <summary>
      /// 获取指定的固定资产流程 Asset_Process对象(即:一条记录
      /// </summary>
      public Asset_Process GetByKey(decimal aP_ID)
      {
         Asset_Process asset_Process = new Asset_Process();
         string sql = "SELECT  AP_ID,AP_Code,AP_Type,AP_Title,AP_Company,AP_CompanyCode,AP_DepartmentCode,AP_Department,AP_Owner,AP_Content,AP_FCode,AP_FName,AP_Reason,AP_Conclusion,AuditStat,AuditCurAudit,Stat,CreateDate,UpdateDate,DeleteDate,AP_itype,AuditStatName,AP_Status,AP_SCode,AP_SName,AP_Contact,AP_Mobile FROM Asset_Process WHERE 1=1 AND ((Stat is null) or (Stat=0) )  AND AP_ID=@AP_ID ";
         idb.AddParameter("@AP_ID", aP_ID);

          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            if (dr["AP_ID"] != DBNull.Value) asset_Process.AP_ID = Convert.ToDecimal(dr["AP_ID"]);
            if (dr["AP_Code"] != DBNull.Value) asset_Process.AP_Code = Convert.ToString(dr["AP_Code"]);
            if (dr["AP_Type"] != DBNull.Value) asset_Process.AP_Type = Convert.ToString(dr["AP_Type"]);
            if (dr["AP_Title"] != DBNull.Value) asset_Process.AP_Title = Convert.ToString(dr["AP_Title"]);
            if (dr["AP_Company"] != DBNull.Value) asset_Process.AP_Company = Convert.ToString(dr["AP_Company"]);
            if (dr["AP_CompanyCode"] != DBNull.Value) asset_Process.AP_CompanyCode = Convert.ToString(dr["AP_CompanyCode"]);
            if (dr["AP_DepartmentCode"] != DBNull.Value) asset_Process.AP_DepartmentCode = Convert.ToString(dr["AP_DepartmentCode"]);
            if (dr["AP_Department"] != DBNull.Value) asset_Process.AP_Department = Convert.ToString(dr["AP_Department"]);
            if (dr["AP_Owner"] != DBNull.Value) asset_Process.AP_Owner = Convert.ToString(dr["AP_Owner"]);
            if (dr["AP_Content"] != DBNull.Value) asset_Process.AP_Content = Convert.ToString(dr["AP_Content"]);
            if (dr["AP_FCode"] != DBNull.Value) asset_Process.AP_FCode = Convert.ToString(dr["AP_FCode"]);
            if (dr["AP_FName"] != DBNull.Value) asset_Process.AP_FName = Convert.ToString(dr["AP_FName"]);
            if (dr["AP_Reason"] != DBNull.Value) asset_Process.AP_Reason = Convert.ToString(dr["AP_Reason"]);
            if (dr["AP_Conclusion"] != DBNull.Value) asset_Process.AP_Conclusion = Convert.ToString(dr["AP_Conclusion"]);
            if (dr["AuditStat"] != DBNull.Value) asset_Process.AuditStat = Convert.ToString(dr["AuditStat"]);
            if (dr["AuditCurAudit"] != DBNull.Value) asset_Process.AuditCurAudit = Convert.ToString(dr["AuditCurAudit"]);
            if (dr["Stat"] != DBNull.Value) asset_Process.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["CreateDate"] != DBNull.Value) asset_Process.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
            if (dr["UpdateDate"] != DBNull.Value) asset_Process.UpdateDate = Convert.ToDateTime(dr["UpdateDate"]);
            if (dr["DeleteDate"] != DBNull.Value) asset_Process.DeleteDate = Convert.ToDateTime(dr["DeleteDate"]);
            if (dr["AP_itype"] != DBNull.Value) asset_Process.AP_itype = Convert.ToString(dr["AP_itype"]);
            if (dr["AuditStatName"] != DBNull.Value) asset_Process.AuditStatName = Convert.ToString(dr["AuditStatName"]);
            if (dr["AP_Status"] != DBNull.Value) asset_Process.AP_Status = Convert.ToString(dr["AP_Status"]);
            if (dr["AP_SCode"] != DBNull.Value) asset_Process.AP_SCode = Convert.ToString(dr["AP_SCode"]);
            if (dr["AP_SName"] != DBNull.Value) asset_Process.AP_SName = Convert.ToString(dr["AP_SName"]);
            if (dr["AP_Contact"] != DBNull.Value) asset_Process.AP_Contact = Convert.ToString(dr["AP_Contact"]);
            if (dr["AP_Mobile"] != DBNull.Value) asset_Process.AP_Mobile = Convert.ToString(dr["AP_Mobile"]);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   }  
         return asset_Process;
      }
      /// <summary>
      /// 获取指定的固定资产流程 Asset_Process对象集合
      /// </summary>
      public List<Asset_Process> GetListByWhere(string strCondition)
      {
         List<Asset_Process> ret = new List<Asset_Process>();
         string sql = "SELECT  AP_ID,AP_Code,AP_Type,AP_Title,AP_Company,AP_CompanyCode,AP_DepartmentCode,AP_Department,AP_Owner,AP_Content,AP_FCode,AP_FName,AP_Reason,AP_Conclusion,AuditStat,AuditCurAudit,Stat,CreateDate,UpdateDate,DeleteDate,AP_itype,AuditStatName,AP_Status,AP_SCode,AP_SName,AP_Contact,AP_Mobile FROM Asset_Process WHERE 1=1 AND ((Stat is null) or (Stat=0) ) ";
         if(!string.IsNullOrEmpty(strCondition))
         {
            strCondition.Replace('\'','"'); //防sql注入
            sql += strCondition ;
         }
          sql += " ORDER BY AP_ID DESC "; 
          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            Asset_Process asset_Process = new Asset_Process();
            if (dr["AP_ID"] != DBNull.Value) asset_Process.AP_ID = Convert.ToDecimal(dr["AP_ID"]);
            if (dr["AP_Code"] != DBNull.Value) asset_Process.AP_Code = Convert.ToString(dr["AP_Code"]);
            if (dr["AP_Type"] != DBNull.Value) asset_Process.AP_Type = Convert.ToString(dr["AP_Type"]);
            if (dr["AP_Title"] != DBNull.Value) asset_Process.AP_Title = Convert.ToString(dr["AP_Title"]);
            if (dr["AP_Company"] != DBNull.Value) asset_Process.AP_Company = Convert.ToString(dr["AP_Company"]);
            if (dr["AP_CompanyCode"] != DBNull.Value) asset_Process.AP_CompanyCode = Convert.ToString(dr["AP_CompanyCode"]);
            if (dr["AP_DepartmentCode"] != DBNull.Value) asset_Process.AP_DepartmentCode = Convert.ToString(dr["AP_DepartmentCode"]);
            if (dr["AP_Department"] != DBNull.Value) asset_Process.AP_Department = Convert.ToString(dr["AP_Department"]);
            if (dr["AP_Owner"] != DBNull.Value) asset_Process.AP_Owner = Convert.ToString(dr["AP_Owner"]);
            if (dr["AP_Content"] != DBNull.Value) asset_Process.AP_Content = Convert.ToString(dr["AP_Content"]);
            if (dr["AP_FCode"] != DBNull.Value) asset_Process.AP_FCode = Convert.ToString(dr["AP_FCode"]);
            if (dr["AP_FName"] != DBNull.Value) asset_Process.AP_FName = Convert.ToString(dr["AP_FName"]);
            if (dr["AP_Reason"] != DBNull.Value) asset_Process.AP_Reason = Convert.ToString(dr["AP_Reason"]);
            if (dr["AP_Conclusion"] != DBNull.Value) asset_Process.AP_Conclusion = Convert.ToString(dr["AP_Conclusion"]);
            if (dr["AuditStat"] != DBNull.Value) asset_Process.AuditStat = Convert.ToString(dr["AuditStat"]);
            if (dr["AuditCurAudit"] != DBNull.Value) asset_Process.AuditCurAudit = Convert.ToString(dr["AuditCurAudit"]);
            if (dr["Stat"] != DBNull.Value) asset_Process.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["CreateDate"] != DBNull.Value) asset_Process.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
            if (dr["UpdateDate"] != DBNull.Value) asset_Process.UpdateDate = Convert.ToDateTime(dr["UpdateDate"]);
            if (dr["DeleteDate"] != DBNull.Value) asset_Process.DeleteDate = Convert.ToDateTime(dr["DeleteDate"]);
            if (dr["AP_itype"] != DBNull.Value) asset_Process.AP_itype = Convert.ToString(dr["AP_itype"]);
            if (dr["AuditStatName"] != DBNull.Value) asset_Process.AuditStatName = Convert.ToString(dr["AuditStatName"]);
            if (dr["AP_Status"] != DBNull.Value) asset_Process.AP_Status = Convert.ToString(dr["AP_Status"]);
            if (dr["AP_SCode"] != DBNull.Value) asset_Process.AP_SCode = Convert.ToString(dr["AP_SCode"]);
            if (dr["AP_SName"] != DBNull.Value) asset_Process.AP_SName = Convert.ToString(dr["AP_SName"]);
            if (dr["AP_Contact"] != DBNull.Value) asset_Process.AP_Contact = Convert.ToString(dr["AP_Contact"]);
            if (dr["AP_Mobile"] != DBNull.Value) asset_Process.AP_Mobile = Convert.ToString(dr["AP_Mobile"]);
            ret.Add(asset_Process);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   }  
         return ret;
      }
      /// <summary>
      /// 获取所有的固定资产流程 Asset_Process对象(即:一条记录
      /// </summary>
      public List<Asset_Process> GetAll()
      {
         List<Asset_Process> ret = new List<Asset_Process>();
         string sql = "SELECT  AP_ID,AP_Code,AP_Type,AP_Title,AP_Company,AP_CompanyCode,AP_DepartmentCode,AP_Department,AP_Owner,AP_Content,AP_FCode,AP_FName,AP_Reason,AP_Conclusion,AuditStat,AuditCurAudit,Stat,CreateDate,UpdateDate,DeleteDate,AP_itype,AuditStatName,AP_Status,AP_SCode,AP_SName,AP_Contact,AP_Mobile FROM Asset_Process where 1=1 AND ((Stat is null) or (Stat=0) ) order by AP_ID desc ";
          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            Asset_Process asset_Process = new Asset_Process();
            if (dr["AP_ID"] != DBNull.Value) asset_Process.AP_ID = Convert.ToDecimal(dr["AP_ID"]);
            if (dr["AP_Code"] != DBNull.Value) asset_Process.AP_Code = Convert.ToString(dr["AP_Code"]);
            if (dr["AP_Type"] != DBNull.Value) asset_Process.AP_Type = Convert.ToString(dr["AP_Type"]);
            if (dr["AP_Title"] != DBNull.Value) asset_Process.AP_Title = Convert.ToString(dr["AP_Title"]);
            if (dr["AP_Company"] != DBNull.Value) asset_Process.AP_Company = Convert.ToString(dr["AP_Company"]);
            if (dr["AP_CompanyCode"] != DBNull.Value) asset_Process.AP_CompanyCode = Convert.ToString(dr["AP_CompanyCode"]);
            if (dr["AP_DepartmentCode"] != DBNull.Value) asset_Process.AP_DepartmentCode = Convert.ToString(dr["AP_DepartmentCode"]);
            if (dr["AP_Department"] != DBNull.Value) asset_Process.AP_Department = Convert.ToString(dr["AP_Department"]);
            if (dr["AP_Owner"] != DBNull.Value) asset_Process.AP_Owner = Convert.ToString(dr["AP_Owner"]);
            if (dr["AP_Content"] != DBNull.Value) asset_Process.AP_Content = Convert.ToString(dr["AP_Content"]);
            if (dr["AP_FCode"] != DBNull.Value) asset_Process.AP_FCode = Convert.ToString(dr["AP_FCode"]);
            if (dr["AP_FName"] != DBNull.Value) asset_Process.AP_FName = Convert.ToString(dr["AP_FName"]);
            if (dr["AP_Reason"] != DBNull.Value) asset_Process.AP_Reason = Convert.ToString(dr["AP_Reason"]);
            if (dr["AP_Conclusion"] != DBNull.Value) asset_Process.AP_Conclusion = Convert.ToString(dr["AP_Conclusion"]);
            if (dr["AuditStat"] != DBNull.Value) asset_Process.AuditStat = Convert.ToString(dr["AuditStat"]);
            if (dr["AuditCurAudit"] != DBNull.Value) asset_Process.AuditCurAudit = Convert.ToString(dr["AuditCurAudit"]);
            if (dr["Stat"] != DBNull.Value) asset_Process.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["CreateDate"] != DBNull.Value) asset_Process.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
            if (dr["UpdateDate"] != DBNull.Value) asset_Process.UpdateDate = Convert.ToDateTime(dr["UpdateDate"]);
            if (dr["DeleteDate"] != DBNull.Value) asset_Process.DeleteDate = Convert.ToDateTime(dr["DeleteDate"]);
            if (dr["AP_itype"] != DBNull.Value) asset_Process.AP_itype = Convert.ToString(dr["AP_itype"]);
            if (dr["AuditStatName"] != DBNull.Value) asset_Process.AuditStatName = Convert.ToString(dr["AuditStatName"]);
            if (dr["AP_Status"] != DBNull.Value) asset_Process.AP_Status = Convert.ToString(dr["AP_Status"]);
            if (dr["AP_SCode"] != DBNull.Value) asset_Process.AP_SCode = Convert.ToString(dr["AP_SCode"]);
            if (dr["AP_SName"] != DBNull.Value) asset_Process.AP_SName = Convert.ToString(dr["AP_SName"]);
            if (dr["AP_Contact"] != DBNull.Value) asset_Process.AP_Contact = Convert.ToString(dr["AP_Contact"]);
            if (dr["AP_Mobile"] != DBNull.Value) asset_Process.AP_Mobile = Convert.ToString(dr["AP_Mobile"]);
            ret.Add(asset_Process);
         }
          }catch (System.Exception ex){ throw ex; }  finally {  if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   } 
         return ret;
      }
   }
}
