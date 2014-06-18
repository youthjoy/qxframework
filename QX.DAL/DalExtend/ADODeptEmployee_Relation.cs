using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using QX.Model;
using System.Data.SqlClient;
namespace QX.DAL
{
    public partial class ADODeptEmployee_Relation
    {
        public List<HR_Stuff> GetListByWhereExtend(string strCondition)
        {
            List<HR_Stuff> ret = new List<HR_Stuff>();
            string sql = "select*from HR_Stuff  WHERE 1=1 AND ((Stat is null) or (Stat=0))";
            if (!string.IsNullOrEmpty(strCondition))
            {
                strCondition.Replace('\'', '"'); //防sql注入
                sql += strCondition;
            }
            SqlDataReader dr = (SqlDataReader)idb.ReturnReader(sql);
            while (dr.Read())
            {
                HR_Stuff hR_Stuff = new HR_Stuff();
                if (dr["Stuff_ID"] != DBNull.Value) hR_Stuff.Stuff_ID = Convert.ToDecimal(dr["Stuff_ID"]);
                if (dr["Stuff_Code"] != DBNull.Value) hR_Stuff.Stuff_Code = Convert.ToString(dr["Stuff_Code"]);
                if (dr["Stuff_Name"] != DBNull.Value) hR_Stuff.Stuff_Name = Convert.ToString(dr["Stuff_Name"]);
                if (dr["Stuff_ENName"] != DBNull.Value) hR_Stuff.Stuff_ENName = Convert.ToString(dr["Stuff_ENName"]);
                if (dr["Stuff_Duty"] != DBNull.Value) hR_Stuff.Stuff_Duty = Convert.ToString(dr["Stuff_Duty"]);
                if (dr["Stuff_DutyCode"] != DBNull.Value) hR_Stuff.Stuff_DutyCode = Convert.ToString(dr["Stuff_DutyCode"]);
                if (dr["Stuff_Title"] != DBNull.Value) hR_Stuff.Stuff_Title = Convert.ToString(dr["Stuff_Title"]);
                if (dr["Stuff_DepCode"] != DBNull.Value) hR_Stuff.Stuff_DepCode = Convert.ToString(dr["Stuff_DepCode"]);
                if (dr["Stuff_DepName"] != DBNull.Value) hR_Stuff.Stuff_DepName = Convert.ToString(dr["Stuff_DepName"]);
                if (dr["Stuff_Director"] != DBNull.Value) hR_Stuff.Stuff_Director = Convert.ToString(dr["Stuff_Director"]);
                if (dr["Stuff_DirectorCode"] != DBNull.Value) hR_Stuff.Stuff_DirectorCode = Convert.ToString(dr["Stuff_DirectorCode"]);
                if (dr["Stuff_OTel"] != DBNull.Value) hR_Stuff.Stuff_OTel = Convert.ToString(dr["Stuff_OTel"]);
                if (dr["Stuff_Mobile"] != DBNull.Value) hR_Stuff.Stuff_Mobile = Convert.ToString(dr["Stuff_Mobile"]);
                if (dr["Stuff_Email"] != DBNull.Value) hR_Stuff.Stuff_Email = Convert.ToString(dr["Stuff_Email"]);
                if (dr["Stuff_Fax"] != DBNull.Value) hR_Stuff.Stuff_Fax = Convert.ToString(dr["Stuff_Fax"]);
                if (dr["Stuff_HTel"] != DBNull.Value) hR_Stuff.Stuff_HTel = Convert.ToString(dr["Stuff_HTel"]);
                if (dr["Stuff_Addr"] != DBNull.Value) hR_Stuff.Stuff_Addr = Convert.ToString(dr["Stuff_Addr"]);
                if (dr["Stuff_Start"] != DBNull.Value) hR_Stuff.Stuff_Start = Convert.ToString(dr["Stuff_Start"]);
                if (dr["Stuff_Left"] != DBNull.Value) hR_Stuff.Stuff_Left = Convert.ToString(dr["Stuff_Left"]);
                if (dr["Stuff_Stat"] != DBNull.Value) hR_Stuff.Stuff_Stat = Convert.ToString(dr["Stuff_Stat"]);
                if (dr["Stuff_Gender"] != DBNull.Value) hR_Stuff.Stuff_Gender = Convert.ToString(dr["Stuff_Gender"]);
                if (dr["Stuff_Birth"] != DBNull.Value) hR_Stuff.Stuff_Birth = Convert.ToString(dr["Stuff_Birth"]);
                
                if (dr["Stuff_Nation"] != DBNull.Value) hR_Stuff.Stuff_Nation = Convert.ToString(dr["Stuff_Nation"]);
                if (dr["Stuff_Province"] != DBNull.Value) hR_Stuff.Stuff_Province = Convert.ToString(dr["Stuff_Province"]);
                if (dr["Stuff_Salary"] != DBNull.Value) hR_Stuff.Stuff_Salary = Convert.ToInt64(dr["Stuff_Salary"]);
                if (dr["Stuff_Cost"] != DBNull.Value) hR_Stuff.Stuff_Cost = Convert.ToString(dr["Stuff_Cost"]);
                if (dr["Stuff_Type"] != DBNull.Value) hR_Stuff.Stuff_Type = Convert.ToString(dr["Stuff_Type"]);
                if (dr["Stuff_InsuraceStat"] != DBNull.Value) hR_Stuff.Stuff_InsuraceStat = Convert.ToString(dr["Stuff_InsuraceStat"]);
                if (dr["Stuff_Edu"] != DBNull.Value) hR_Stuff.Stuff_Edu = Convert.ToString(dr["Stuff_Edu"]);
                if (dr["Stat"] != DBNull.Value) hR_Stuff.Stat = Convert.ToInt32(dr["Stat"]);
                if (dr["CreateDate"] != DBNull.Value) hR_Stuff.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
                if (dr["Creator"] != DBNull.Value) hR_Stuff.Creator = Convert.ToString(dr["Creator"]);
                if (dr["Stuff_UserName"] != DBNull.Value) hR_Stuff.Stuff_UserName = Convert.ToString(dr["Stuff_UserName"]);
                if (dr["Stuff_Password"] != DBNull.Value) hR_Stuff.Stuff_Password = Convert.ToString(dr["Stuff_Password"]);
                if (dr["Stuff_LoginType"] != DBNull.Value) hR_Stuff.Stuff_LoginType = Convert.ToString(dr["Stuff_LoginType"]);
                if (dr["Stuff_ShortTel"] != DBNull.Value) hR_Stuff.Stuff_ShortTel = Convert.ToString(dr["Stuff_ShortTel"]);
                if (dr["Stuff_WorkNo"] != DBNull.Value) hR_Stuff.Stuff_WorkNo = Convert.ToString(dr["Stuff_WorkNo"]);
                if (dr["Stuff_TechLevel"] != DBNull.Value) hR_Stuff.Stuff_TechLevel = Convert.ToString(dr["Stuff_TechLevel"]);
                if (dr["Stuff_Heath"] != DBNull.Value) hR_Stuff.Stuff_Heath = Convert.ToString(dr["Stuff_Heath"]);
                if (dr["Stuff_InDate"] != DBNull.Value) hR_Stuff.Stuff_InDate = Convert.ToString(dr["Stuff_InDate"]);
                if (dr["Stuff_TurnDate"] != DBNull.Value) hR_Stuff.Stuff_TurnDate = Convert.ToString(dr["Stuff_TurnDate"]);
                if (dr["Stuff_TradeDate"] != DBNull.Value) hR_Stuff.Stuff_TradeDate = Convert.ToString(dr["Stuff_TradeDate"]);
                if (dr["Stuff_SignStartDate"] != DBNull.Value) hR_Stuff.Stuff_SignStartDate = Convert.ToString(dr["Stuff_SignStartDate"]);
                if (dr["Stuff_SingEndDate"] != DBNull.Value) hR_Stuff.Stuff_SingEndDate = Convert.ToString(dr["Stuff_SingEndDate"]);
                if (dr["Stuff_SpeicalCard"] != DBNull.Value) hR_Stuff.Stuff_SpeicalCard = Convert.ToString(dr["Stuff_SpeicalCard"]);
                if (dr["Stuff_FinishSchool"] != DBNull.Value) hR_Stuff.Stuff_FinishSchool = Convert.ToString(dr["Stuff_FinishSchool"]);
                if (dr["Stuff_Major"] != DBNull.Value) hR_Stuff.Stuff_Major = Convert.ToString(dr["Stuff_Major"]);
                if (dr["Stuff_IsResume"] != DBNull.Value) hR_Stuff.Stuff_IsResume = Convert.ToString(dr["Stuff_IsResume"]);
                if (dr["Stuff_IsPic"] != DBNull.Value) hR_Stuff.Stuff_IsPic = Convert.ToString(dr["Stuff_IsPic"]);
                if (dr["Stuff_IsIDCard"] != DBNull.Value) hR_Stuff.Stuff_IsIDCard = Convert.ToString(dr["Stuff_IsIDCard"]);
                if (dr["Stuff_IsHouseHod"] != DBNull.Value) hR_Stuff.Stuff_IsHouseHod = Convert.ToString(dr["Stuff_IsHouseHod"]);
                if (dr["Stuff_FinishCard"] != DBNull.Value) hR_Stuff.Stuff_FinishCard = Convert.ToString(dr["Stuff_FinishCard"]);
                if (dr["Stuff_TechnicalCard"] != DBNull.Value) hR_Stuff.Stuff_TechnicalCard = Convert.ToString(dr["Stuff_TechnicalCard"]);
                if (dr["Stuff_OperationCard"] != DBNull.Value) hR_Stuff.Stuff_OperationCard = Convert.ToString(dr["Stuff_OperationCard"]);
                if (dr["Stuff_QualificationCard"] != DBNull.Value) hR_Stuff.Stuff_QualificationCard = Convert.ToString(dr["Stuff_QualificationCard"]);
                if (dr["Stuff_RelaseContract"] != DBNull.Value) hR_Stuff.Stuff_RelaseContract = Convert.ToString(dr["Stuff_RelaseContract"]);
                if (dr["Stuff_TurnPaper"] != DBNull.Value) hR_Stuff.Stuff_TurnPaper = Convert.ToString(dr["Stuff_TurnPaper"]);
                if (dr["Stuff_Trasfer"] != DBNull.Value) hR_Stuff.Stuff_Trasfer = Convert.ToString(dr["Stuff_Trasfer"]);
                if (dr["Stuff_HeathPaper"] != DBNull.Value) hR_Stuff.Stuff_HeathPaper = Convert.ToString(dr["Stuff_HeathPaper"]);
                if (dr["Stuff_AnnoucePaper"] != DBNull.Value) hR_Stuff.Stuff_AnnoucePaper = Convert.ToString(dr["Stuff_AnnoucePaper"]);
                if (dr["Stuff_AssurePaper"] != DBNull.Value) hR_Stuff.Stuff_AssurePaper = Convert.ToString(dr["Stuff_AssurePaper"]);
                if (dr["Stuff_OnTrialContract"] != DBNull.Value) hR_Stuff.Stuff_OnTrialContract = Convert.ToString(dr["Stuff_OnTrialContract"]);
                if (dr["Stuff_ContractChangeBody"] != DBNull.Value) hR_Stuff.Stuff_ContractChangeBody = Convert.ToString(dr["Stuff_ContractChangeBody"]);
                if (dr["Stuff_ContractCompany"] != DBNull.Value) hR_Stuff.Stuff_ContractCompany = Convert.ToString(dr["Stuff_ContractCompany"]);
                if (dr["Stuff_ContractCompanyCode"] != DBNull.Value) hR_Stuff.Stuff_ContractCompanyCode = Convert.ToString(dr["Stuff_ContractCompanyCode"]);
                if (dr["Stuff_FileRecord"] != DBNull.Value) hR_Stuff.Stuff_FileRecord = Convert.ToString(dr["Stuff_FileRecord"]);
                if (dr["Stuff_FileRecordRemove"] != DBNull.Value) hR_Stuff.Stuff_FileRecordRemove = Convert.ToString(dr["Stuff_FileRecordRemove"]);
                //if (dr["UpdateDate"] != DBNull.Value) hR_Stuff.UpdateDate = Convert.ToDateTime(dr["UpdateDate"]);
                //if (dr["DeleteDate"] != DBNull.Value) hR_Stuff.DeleteDate = Convert.ToDateTime(dr["DeleteDate"]);
                if (dr["Stuff_Bak"] != DBNull.Value) hR_Stuff.Stuff_Bak = Convert.ToString(dr["Stuff_Bak"]);
                ret.Add(hR_Stuff);
            }
            dr.Close();
            return ret;
        }
        public List<HR_TimeSheet> GetListByWhereKq(string strCondition)
        {
            List<HR_TimeSheet> ret = new List<HR_TimeSheet>();
            string sql = "SELECT *FROM HR_TimeSheet, HR_Stuff, HR_Department  WHERE 1=1 AND ((HR_Stuff.Stat is null) or (HR_Stuff.Stat=0) ) and HR_Stuff.Stuff_DepCode= HR_Department.Dept_Code AND HR_Stuff.Stuff_Code= HR_TimeSheet.TS_StuffCode  ";
            if (!string.IsNullOrEmpty(strCondition))
            {
                strCondition.Replace('\'', '"'); //防sql注入
                sql += strCondition;
            }
            SqlDataReader dr = null;
            try
            {
                dr = (SqlDataReader)idb.ReturnReader(sql);
                while (dr.Read())
                {
                    HR_TimeSheet hR_TimeSheet = new HR_TimeSheet();
                    if (dr["TS_ID"] != DBNull.Value) hR_TimeSheet.TS_ID = Convert.ToInt32(dr["TS_ID"]);
                    if (dr["TS_Code"] != DBNull.Value) hR_TimeSheet.TS_Code = Convert.ToString(dr["TS_Code"]);
                    if (dr["TS_StuffName"] != DBNull.Value) hR_TimeSheet.TS_StuffName = Convert.ToString(dr["TS_StuffName"]);
                    if (dr["TS_StuffCode"] != DBNull.Value) hR_TimeSheet.TS_StuffCode = Convert.ToString(dr["TS_StuffCode"]);
                    if (dr["TS_TypeName"] != DBNull.Value) hR_TimeSheet.TS_TypeName = Convert.ToString(dr["TS_TypeName"]);
                    if (dr["TS_Type"] != DBNull.Value) hR_TimeSheet.TS_Type = Convert.ToString(dr["TS_Type"]);
                    if (dr["TS_Start"] != DBNull.Value) hR_TimeSheet.TS_Start = Convert.ToDateTime(dr["TS_Start"]);
                    if (dr["TS_End"] != DBNull.Value) hR_TimeSheet.TS_End = Convert.ToDateTime(dr["TS_End"]);
                    if (dr["TS_Total"] != DBNull.Value) hR_TimeSheet.TS_Total = Convert.ToInt64(dr["TS_Total"]);
                    if (dr["TS_Matter"] != DBNull.Value) hR_TimeSheet.TS_Matter = Convert.ToString(dr["TS_Matter"]);
                    if (dr["Creator"] != DBNull.Value) hR_TimeSheet.Creator = Convert.ToString(dr["Creator"]);
                    if (dr["CreateTime"] != DBNull.Value) hR_TimeSheet.CreateTime = Convert.ToDateTime(dr["CreateTime"]);
                    if (dr["VerifyStat"] != DBNull.Value) hR_TimeSheet.VerifyStat = Convert.ToString(dr["VerifyStat"]);
                    if (dr["VerifyDate"] != DBNull.Value) hR_TimeSheet.VerifyDate = Convert.ToDateTime(dr["VerifyDate"]);
                    if (dr["VerifyStuff"] != DBNull.Value) hR_TimeSheet.VerifyStuff = Convert.ToString(dr["VerifyStuff"]);
                    if (dr["VerifyNext"] != DBNull.Value) hR_TimeSheet.VerifyNext = Convert.ToString(dr["VerifyNext"]);
                    if (dr["Stat"] != DBNull.Value) hR_TimeSheet.Stat = Convert.ToInt32(dr["Stat"]);
                    ret.Add(hR_TimeSheet);
                }
            }
            catch (System.Exception ex) { throw ex; }
            finally { if (dr != null) { dr.Close(); } }
            return ret;
        }
        /// <summary>
        /// 获取指定的HR_In对象集合
        /// </summary>
        public List<HR_In> GetListByWhereZW(string strCondition)
        {
            List<HR_In> ret = new List<HR_In>();
            string sql = "SELECT *FROM HR_In, HR_Stuff, HR_Department WHERE 1=1 AND ((HR_Stuff.Stat is null) or (HR_Stuff.Stat=0) ) and HR_Stuff.Stuff_DepCode= HR_Department.Dept_Code AND HR_Stuff.Stuff_Code= HR_In.HM_ECode";
            if (!string.IsNullOrEmpty(strCondition))
            {
                strCondition.Replace('\'', '"'); //防sql注入
                sql += strCondition;
            }
            SqlDataReader dr = null;
            try
            {
                dr = (SqlDataReader)idb.ReturnReader(sql);
                while (dr.Read())
                {
                    HR_In hR_In = new HR_In();
                    if (dr["HM_ID"] != DBNull.Value) hR_In.HM_ID = Convert.ToInt32(dr["HM_ID"]);
                    if (dr["HM_EName"] != DBNull.Value) hR_In.HM_EName = Convert.ToString(dr["HM_EName"]);
                    if (dr["HM_InCode"] != DBNull.Value) hR_In.HM_InCode = Convert.ToString(dr["HM_InCode"]);
                    if (dr["HM_Type"] != DBNull.Value) hR_In.HM_Type = Convert.ToString(dr["HM_Type"]);
                    if (dr["HM_ECode"] != DBNull.Value) hR_In.HM_ECode = Convert.ToString(dr["HM_ECode"]);
                    if (dr["HM_OTitle"] != DBNull.Value) hR_In.HM_OTitle = Convert.ToString(dr["HM_OTitle"]);
                    if (dr["HM_OSalary"] != DBNull.Value) hR_In.HM_OSalary = Convert.ToDouble(dr["HM_OSalary"]);
                    if (dr["HM_CTitle"] != DBNull.Value) hR_In.HM_CTitle = Convert.ToString(dr["HM_CTitle"]);
                    if (dr["HM_CSalary"] != DBNull.Value) hR_In.HM_CSalary = Convert.ToDouble(dr["HM_CSalary"]);
                    if (dr["HM_Content"] != DBNull.Value) hR_In.HM_Content = Convert.ToString(dr["HM_Content"]);
                    if (dr["HM_Bak"] != DBNull.Value) hR_In.HM_Bak = Convert.ToString(dr["HM_Bak"]);
                    if (dr["Stat"] != DBNull.Value) hR_In.Stat = Convert.ToInt32(dr["Stat"]);
                    ret.Add(hR_In);
                }
            }
            catch (System.Exception ex) { throw ex; }
            finally { if (dr != null) { dr.Close(); } }
            return ret;
        }
    }
}
