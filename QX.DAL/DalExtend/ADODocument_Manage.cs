using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using QX.Model;

namespace QX.DAL
{
   public partial class ADODocument_Manage
    {
        /// <summary>
        /// 更新档案信息管理 Document_Manage对象(即:一条记录
        /// </summary>
        public int Update(Document_Manage document_Manage,int A)
        {
            StringBuilder sbParameter = new StringBuilder();
            StringBuilder sb = new StringBuilder();
            sb.Append(@"UPDATE       Document_Manage       SET ");
            if (document_Manage.DM_Name_IsChanged) { sbParameter.Append("DM_Name=@DM_Name, "); }
            if (document_Manage.DM_iType_IsChanged) { sbParameter.Append("DM_iType=@DM_iType, "); }
            if (document_Manage.DM_Category_IsChanged) { sbParameter.Append("DM_Category=@DM_Category, "); }
            if (document_Manage.DM_FileNumber_IsChanged) { sbParameter.Append("DM_FileNumber=@DM_FileNumber, "); }
            if (document_Manage.DM_Num_IsChanged) { sbParameter.Append("DM_Num=@DM_Num, "); }
            if (document_Manage.DM_InNum_IsChanged) { sbParameter.Append("DM_InNum=@DM_InNum, "); }
            if (document_Manage.DM_AttachCompany_IsChanged) { sbParameter.Append("DM_AttachCompany=@DM_AttachCompany, "); }
            if (document_Manage.DM_AttachDept_IsChanged) { sbParameter.Append("DM_AttachDept=@DM_AttachDept, "); }
            if (document_Manage.DM_Issuer_IsChanged) { sbParameter.Append("DM_Issuer=@DM_Issuer, "); }
            if (document_Manage.DM_Operator_IsChanged) { sbParameter.Append("DM_Operator=@DM_Operator, "); }
            if (document_Manage.DM_Date_IsChanged) { sbParameter.Append("DM_Date=@DM_Date, "); }
            if (document_Manage.DM_ConversionDate_IsChanged) { sbParameter.Append("DM_ConversionDate=@DM_ConversionDate, "); }
            if (document_Manage.DM_PageNum_IsChanged) { sbParameter.Append("DM_PageNum=@DM_PageNum, "); }
            if (document_Manage.DM_SecretLevel_IsChanged) { sbParameter.Append("DM_SecretLevel=@DM_SecretLevel, "); }
            if (document_Manage.DM_Remark_IsChanged) { sbParameter.Append("DM_Remark=@DM_Remark, "); }
            if (document_Manage.DM_Content_IsChanged) { sbParameter.Append("DM_Content=@DM_Content, "); }
            if (document_Manage.DM_HoldingDept_IsChanged) { sbParameter.Append("DM_HoldingDept=@DM_HoldingDept, "); }
            if (document_Manage.DM_HoldingPerson_IsChanged) { sbParameter.Append("DM_HoldingPerson=@DM_HoldingPerson, "); }
            if (document_Manage.DM_Position_IsChanged) { sbParameter.Append("DM_Position=@DM_Position, "); }
            if (document_Manage.DM_Stat_IsChanged) { sbParameter.Append("DM_Stat=@DM_Stat, "); }
            if (document_Manage.DM_IsIssued_IsChanged) { sbParameter.Append("DM_IsIssued=@DM_IsIssued, "); }
            if (document_Manage.Stat_IsChanged) { sbParameter.Append("Stat=@Stat, "); }
            if (document_Manage.CreateDate_IsChanged) { sbParameter.Append("CreateDate=@CreateDate, "); }
            if (document_Manage.UpdateDate_IsChanged) { sbParameter.Append("UpdateDate=@UpdateDate, "); }
            if (document_Manage.DeleteDate_IsChanged) { sbParameter.Append("DeleteDate=@DeleteDate "); }
            sb.Append(sbParameter.ToString().Trim().TrimEnd(','));
            sb.Append(" WHERE 1=1 AND ((Stat is null) or (Stat=0))   and DM_Code=@DM_Code; ");
            string sql = sb.ToString();
            if (document_Manage.DM_Code_IsChanged)
            {
                if (string.IsNullOrEmpty(document_Manage.DM_Code))
                {
                    idb.AddParameter("@DM_Code", DBNull.Value);
                }
                else
                {
                    idb.AddParameter("@DM_Code", document_Manage.DM_Code);
                }
            }
            if (document_Manage.DM_Name_IsChanged)
            {
                if (string.IsNullOrEmpty(document_Manage.DM_Name))
                {
                    idb.AddParameter("@DM_Name", DBNull.Value);
                }
                else
                {
                    idb.AddParameter("@DM_Name", document_Manage.DM_Name);
                }
            }
            if (document_Manage.DM_iType_IsChanged)
            {
                if (string.IsNullOrEmpty(document_Manage.DM_iType))
                {
                    idb.AddParameter("@DM_iType", DBNull.Value);
                }
                else
                {
                    idb.AddParameter("@DM_iType", document_Manage.DM_iType);
                }
            }
            if (document_Manage.DM_Category_IsChanged)
            {
                if (string.IsNullOrEmpty(document_Manage.DM_Category))
                {
                    idb.AddParameter("@DM_Category", DBNull.Value);
                }
                else
                {
                    idb.AddParameter("@DM_Category", document_Manage.DM_Category);
                }
            }
            if (document_Manage.DM_FileNumber_IsChanged)
            {
                if (string.IsNullOrEmpty(document_Manage.DM_FileNumber))
                {
                    idb.AddParameter("@DM_FileNumber", DBNull.Value);
                }
                else
                {
                    idb.AddParameter("@DM_FileNumber", document_Manage.DM_FileNumber);
                }
            }
            if (document_Manage.DM_Num_IsChanged)
            {
                if (document_Manage.DM_Num == 0)
                {
                    idb.AddParameter("@DM_Num", DBNull.Value);
                }
                else
                {
                    idb.AddParameter("@DM_Num", document_Manage.DM_Num);
                }
            }
            if (document_Manage.DM_InNum_IsChanged)
            {
                if (document_Manage.DM_InNum == 0)
                {
                    idb.AddParameter("@DM_InNum", DBNull.Value);
                }
                else
                {
                    idb.AddParameter("@DM_InNum", document_Manage.DM_InNum);
                }
            }
            if (document_Manage.DM_AttachCompany_IsChanged)
            {
                if (string.IsNullOrEmpty(document_Manage.DM_AttachCompany))
                {
                    idb.AddParameter("@DM_AttachCompany", DBNull.Value);
                }
                else
                {
                    idb.AddParameter("@DM_AttachCompany", document_Manage.DM_AttachCompany);
                }
            }
            if (document_Manage.DM_AttachDept_IsChanged)
            {
                if (string.IsNullOrEmpty(document_Manage.DM_AttachDept))
                {
                    idb.AddParameter("@DM_AttachDept", DBNull.Value);
                }
                else
                {
                    idb.AddParameter("@DM_AttachDept", document_Manage.DM_AttachDept);
                }
            }
            if (document_Manage.DM_Issuer_IsChanged)
            {
                if (string.IsNullOrEmpty(document_Manage.DM_Issuer))
                {
                    idb.AddParameter("@DM_Issuer", DBNull.Value);
                }
                else
                {
                    idb.AddParameter("@DM_Issuer", document_Manage.DM_Issuer);
                }
            }
            if (document_Manage.DM_Operator_IsChanged)
            {
                if (string.IsNullOrEmpty(document_Manage.DM_Operator))
                {
                    idb.AddParameter("@DM_Operator", DBNull.Value);
                }
                else
                {
                    idb.AddParameter("@DM_Operator", document_Manage.DM_Operator);
                }
            }
            if (document_Manage.DM_Date_IsChanged)
            {
                if (document_Manage.DM_Date == DateTime.MinValue)
                {
                    idb.AddParameter("@DM_Date", DBNull.Value);
                }
                else
                {
                    idb.AddParameter("@DM_Date", document_Manage.DM_Date);
                }
            }
            if (document_Manage.DM_ConversionDate_IsChanged)
            {
                if (document_Manage.DM_ConversionDate == DateTime.MinValue)
                {
                    idb.AddParameter("@DM_ConversionDate", DBNull.Value);
                }
                else
                {
                    idb.AddParameter("@DM_ConversionDate", document_Manage.DM_ConversionDate);
                }
            }
            if (document_Manage.DM_PageNum_IsChanged)
            {
                if (document_Manage.DM_PageNum == 0)
                {
                    idb.AddParameter("@DM_PageNum", DBNull.Value);
                }
                else
                {
                    idb.AddParameter("@DM_PageNum", document_Manage.DM_PageNum);
                }
            }
            if (document_Manage.DM_SecretLevel_IsChanged)
            {
                if (string.IsNullOrEmpty(document_Manage.DM_SecretLevel))
                {
                    idb.AddParameter("@DM_SecretLevel", DBNull.Value);
                }
                else
                {
                    idb.AddParameter("@DM_SecretLevel", document_Manage.DM_SecretLevel);
                }
            }
            if (document_Manage.DM_Remark_IsChanged)
            {
                if (string.IsNullOrEmpty(document_Manage.DM_Remark))
                {
                    idb.AddParameter("@DM_Remark", DBNull.Value);
                }
                else
                {
                    idb.AddParameter("@DM_Remark", document_Manage.DM_Remark);
                }
            }
            if (document_Manage.DM_Content_IsChanged)
            {
                if (string.IsNullOrEmpty(document_Manage.DM_Content))
                {
                    idb.AddParameter("@DM_Content", DBNull.Value);
                }
                else
                {
                    idb.AddParameter("@DM_Content", document_Manage.DM_Content);
                }
            }
            if (document_Manage.DM_HoldingDept_IsChanged)
            {
                if (string.IsNullOrEmpty(document_Manage.DM_HoldingDept))
                {
                    idb.AddParameter("@DM_HoldingDept", DBNull.Value);
                }
                else
                {
                    idb.AddParameter("@DM_HoldingDept", document_Manage.DM_HoldingDept);
                }
            }
            if (document_Manage.DM_HoldingPerson_IsChanged)
            {
                if (string.IsNullOrEmpty(document_Manage.DM_HoldingPerson))
                {
                    idb.AddParameter("@DM_HoldingPerson", DBNull.Value);
                }
                else
                {
                    idb.AddParameter("@DM_HoldingPerson", document_Manage.DM_HoldingPerson);
                }
            }
            if (document_Manage.DM_Position_IsChanged)
            {
                if (string.IsNullOrEmpty(document_Manage.DM_Position))
                {
                    idb.AddParameter("@DM_Position", DBNull.Value);
                }
                else
                {
                    idb.AddParameter("@DM_Position", document_Manage.DM_Position);
                }
            }
            if (document_Manage.DM_Stat_IsChanged)
            {
                if (string.IsNullOrEmpty(document_Manage.DM_Stat))
                {
                    idb.AddParameter("@DM_Stat", DBNull.Value);
                }
                else
                {
                    idb.AddParameter("@DM_Stat", document_Manage.DM_Stat);
                }
            }
            if (document_Manage.DM_IsIssued_IsChanged)
            {
                if (document_Manage.DM_IsIssued == "false")
                {
                    idb.AddParameter("@DM_IsIssued", DBNull.Value);
                }
                else
                {
                    idb.AddParameter("@DM_IsIssued", document_Manage.DM_IsIssued);
                }
            }
            if (document_Manage.Stat_IsChanged)
            {
                if (document_Manage.Stat == 0)
                {
                    idb.AddParameter("@Stat", DBNull.Value);
                }
                else
                {
                    idb.AddParameter("@Stat", document_Manage.Stat);
                }
            }
            if (document_Manage.CreateDate_IsChanged)
            {
                if (document_Manage.CreateDate == DateTime.MinValue)
                {
                    idb.AddParameter("@CreateDate", DBNull.Value);
                }
                else
                {
                    idb.AddParameter("@CreateDate", document_Manage.CreateDate);
                }
            }
            if (document_Manage.UpdateDate_IsChanged)
            {
                if (document_Manage.UpdateDate == DateTime.MinValue)
                {
                    idb.AddParameter("@UpdateDate", DBNull.Value);
                }
                else
                {
                    idb.AddParameter("@UpdateDate", document_Manage.UpdateDate);
                }
            }
            if (document_Manage.DeleteDate_IsChanged)
            {
                if (document_Manage.DeleteDate == DateTime.MinValue)
                {
                    idb.AddParameter("@DeleteDate", DBNull.Value);
                }
                else
                {
                    idb.AddParameter("@DeleteDate", document_Manage.DeleteDate);
                }
            }
            return idb.ExeCmd(sql);
        }
    }
}
