using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using QX.Model;
using System.Data.SqlClient;
using System.Data;
namespace QX.DAL
{
    public partial class ADOPU_Detail
    {
        /// <summary>
        /// 关联PU_Main主表查询
        /// </summary>
        /// <param name="strCondition"></param>
        /// <returns></returns>
        public List<PU_Detail> GetListByWhereRefMain(string strCondition)
        {
            List<PU_Detail> ret = new List<PU_Detail>();
            string sql = @"SELECT PUD_ID,PUD_Code,PUD_MCode,PUD_MName,PUD_Spec
,PUD_Unit,PUD_Price,PUD_Num,PUD_Bak,(CASE PUM_RType  
when 'MMPO' 
THEN  '采购订单' 
  When 'MMPI' THEN  '采购收货' END) PUD_RType,PUD_RCode
,PUD_RefWCode,PUD_RefWNo,PUD_RefWName,PUD_Tranfee,pd.Stat,pd.CreateDate
,pd.UpdateDate,pd.DeleteDate,PUD_DNum,PUD_DStatus,PUD_RefWNoName
,PUD_Udef1,PUD_Udef2,PUD_Udef3,PUD_Udef4,PUD_Udef5,PUD_CCompany
,PUD_CCompanyCode,PUD_Dept,PUD_DeptCode,PUD_RDate,PUD_SupCode
,PUD_SupName,PUD_Num1,PUD_Num2,PUD_Num3,PUD_Num4,PUD_Num5 
FROM PU_Detail pd
JOIN PU_Main pu on pd.PUD_RCode=pu.PUM_RCode
WHERE 1=1 AND PUD_RType in ('MMPO','MMPI') AND ((pu.Stat is null) or (pu.Stat=0) ) AND ((pd.Stat is null) or (pd.Stat=0) ) ";
            if (!string.IsNullOrEmpty(strCondition))
            {
                strCondition.Replace('\'', '"'); //防sql注入
                sql += strCondition;
            }
            sql += " ORDER BY PUD_ID DESC ";
            SqlDataReader dr = null;
            try
            {
                dr = (SqlDataReader)idb.ReturnReader(sql);
                while (dr.Read())
                {
                    PU_Detail pU_Detail = new PU_Detail();
                    if (dr["PUD_ID"] != DBNull.Value) pU_Detail.PUD_ID = Convert.ToDecimal(dr["PUD_ID"]);
                    if (dr["PUD_Code"] != DBNull.Value) pU_Detail.PUD_Code = Convert.ToString(dr["PUD_Code"]);
                    if (dr["PUD_MCode"] != DBNull.Value) pU_Detail.PUD_MCode = Convert.ToString(dr["PUD_MCode"]);
                    if (dr["PUD_MName"] != DBNull.Value) pU_Detail.PUD_MName = Convert.ToString(dr["PUD_MName"]);
                    if (dr["PUD_Spec"] != DBNull.Value) pU_Detail.PUD_Spec = Convert.ToString(dr["PUD_Spec"]);
                    if (dr["PUD_Unit"] != DBNull.Value) pU_Detail.PUD_Unit = Convert.ToString(dr["PUD_Unit"]);
                    if (dr["PUD_Price"] != DBNull.Value) pU_Detail.PUD_Price = Convert.ToDecimal(dr["PUD_Price"]);
                    if (dr["PUD_Num"] != DBNull.Value) pU_Detail.PUD_Num = Convert.ToDecimal(dr["PUD_Num"]);
                    if (dr["PUD_Bak"] != DBNull.Value) pU_Detail.PUD_Bak = Convert.ToString(dr["PUD_Bak"]);
                    if (dr["PUD_RType"] != DBNull.Value) pU_Detail.PUD_RType = Convert.ToString(dr["PUD_RType"]);
                    if (dr["PUD_RCode"] != DBNull.Value) pU_Detail.PUD_RCode = Convert.ToString(dr["PUD_RCode"]);
                    if (dr["PUD_RefWCode"] != DBNull.Value) pU_Detail.PUD_RefWCode = Convert.ToString(dr["PUD_RefWCode"]);
                    if (dr["PUD_RefWNo"] != DBNull.Value) pU_Detail.PUD_RefWNo = Convert.ToString(dr["PUD_RefWNo"]);
                    if (dr["PUD_RefWName"] != DBNull.Value) pU_Detail.PUD_RefWName = Convert.ToString(dr["PUD_RefWName"]);
                    if (dr["PUD_Tranfee"] != DBNull.Value) pU_Detail.PUD_Tranfee = Convert.ToDecimal(dr["PUD_Tranfee"]);
                    if (dr["Stat"] != DBNull.Value) pU_Detail.Stat = Convert.ToInt32(dr["Stat"]);
                    if (dr["CreateDate"] != DBNull.Value) pU_Detail.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
                    if (dr["UpdateDate"] != DBNull.Value) pU_Detail.UpdateDate = Convert.ToDateTime(dr["UpdateDate"]);
                    if (dr["DeleteDate"] != DBNull.Value) pU_Detail.DeleteDate = Convert.ToDateTime(dr["DeleteDate"]);
                    if (dr["PUD_DNum"] != DBNull.Value) pU_Detail.PUD_DNum = Convert.ToDecimal(dr["PUD_DNum"]);
                    if (dr["PUD_DStatus"] != DBNull.Value) pU_Detail.PUD_DStatus = Convert.ToString(dr["PUD_DStatus"]);
                    if (dr["PUD_RefWNoName"] != DBNull.Value) pU_Detail.PUD_RefWNoName = Convert.ToString(dr["PUD_RefWNoName"]);
                    if (dr["PUD_Udef1"] != DBNull.Value) pU_Detail.PUD_Udef1 = Convert.ToString(dr["PUD_Udef1"]);
                    if (dr["PUD_Udef2"] != DBNull.Value) pU_Detail.PUD_Udef2 = Convert.ToString(dr["PUD_Udef2"]);
                    if (dr["PUD_Udef3"] != DBNull.Value) pU_Detail.PUD_Udef3 = Convert.ToString(dr["PUD_Udef3"]);
                    if (dr["PUD_Udef4"] != DBNull.Value) pU_Detail.PUD_Udef4 = Convert.ToString(dr["PUD_Udef4"]);
                    if (dr["PUD_Udef5"] != DBNull.Value) pU_Detail.PUD_Udef5 = Convert.ToString(dr["PUD_Udef5"]);
                    if (dr["PUD_CCompany"] != DBNull.Value) pU_Detail.PUD_CCompany = Convert.ToString(dr["PUD_CCompany"]);
                    if (dr["PUD_CCompanyCode"] != DBNull.Value) pU_Detail.PUD_CCompanyCode = Convert.ToString(dr["PUD_CCompanyCode"]);
                    if (dr["PUD_Dept"] != DBNull.Value) pU_Detail.PUD_Dept = Convert.ToString(dr["PUD_Dept"]);
                    if (dr["PUD_DeptCode"] != DBNull.Value) pU_Detail.PUD_DeptCode = Convert.ToString(dr["PUD_DeptCode"]);
                    if (dr["PUD_RDate"] != DBNull.Value) pU_Detail.PUD_RDate = Convert.ToDateTime(dr["PUD_RDate"]);
                    if (dr["PUD_SupCode"] != DBNull.Value) pU_Detail.PUD_SupCode = Convert.ToString(dr["PUD_SupCode"]);
                    if (dr["PUD_SupName"] != DBNull.Value) pU_Detail.PUD_SupName = Convert.ToString(dr["PUD_SupName"]);
                    if (dr["PUD_Num1"] != DBNull.Value) pU_Detail.PUD_Num1 = Convert.ToDecimal(dr["PUD_Num1"]);
                    if (dr["PUD_Num2"] != DBNull.Value) pU_Detail.PUD_Num2 = Convert.ToDecimal(dr["PUD_Num2"]);
                    if (dr["PUD_Num3"] != DBNull.Value) pU_Detail.PUD_Num3 = Convert.ToDecimal(dr["PUD_Num3"]);
                    if (dr["PUD_Num4"] != DBNull.Value) pU_Detail.PUD_Num4 = Convert.ToDecimal(dr["PUD_Num4"]);
                    if (dr["PUD_Num5"] != DBNull.Value) pU_Detail.PUD_Num5 = Convert.ToDecimal(dr["PUD_Num5"]);
                    ret.Add(pU_Detail);
                }
            }
            catch (System.Exception ex) { throw ex; }
            finally { if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); } }
            return ret;
        }

        /// <summary>
        /// 关联PU_Main主表查询
        /// </summary>
        /// <param name="strCondition"></param>
        /// <returns></returns>
        public List<PU_Detail> GetListByWhereMain(string MCode,string RType)
        {
            List<PU_Detail> ret = new List<PU_Detail>();
            string sql = @"select pd.[PUD_ID]
      ,pd.[PUD_Code]
      ,pd.[PUD_MCode]
      ,pd.[PUD_MName]
      ,pd.[PUD_Spec]
      ,pd.[PUD_Unit]
      ,pd.[PUD_Price]
      ,pd.[PUD_Num]
      ,pd.[PUD_Bak]
      ,pd.[PUD_RType]
      ,pd.[PUD_RCode]
      ,pd.[PUD_RefWCode]
      ,pd.[PUD_RefWNo]
      ,pd.[PUD_RefWName]
      ,pd.[PUD_Tranfee]
      ,pd.[Stat]
      ,pd.[CreateDate]
      ,pd.[UpdateDate]
      ,pd.[DeleteDate]
      ,pd.[PUD_DNum]
      ,pd.[PUD_DStatus]
      ,pd.[PUD_RefWNoName]
      ,pd.[PUD_Udef1]
      ,pd.[PUD_Udef2]
      ,pd.[PUD_Udef3]
      ,pd.[PUD_Udef4]
      ,pd.[PUD_Udef5]
      ,pd.[PUD_CCompany]
      ,pd.[PUD_CCompanyCode]
      ,pd.[PUD_Dept]
      ,pd.[PUD_DeptCode]
      ,pd.[PUD_RDate]
      ,pm.PUM_SCode as PUD_SupCode
      ,pm.PUM_SName as PUD_SupName
      ,pd.[PUD_Num1]
      ,pd.[PUD_Num2]
      ,pd.[PUD_Num3]
      ,pd.[PUD_Num4]
      ,pd.[PUD_Num5] from PU_Main pm INNER JOIN PU_Detail pd
                            on pm.PUM_RCode=pd.PUD_RCode
                            where pd.PUD_MCode='{MCode}' 
                            and pd.PUD_RType='{RType}'
                            and pm.AuditStat='LastAudit'
                            and ISNULL(pm.Stat, 0)=0 ORDER BY pd.PUD_ID DESC ";
            //if (!string.IsNullOrEmpty(strCondition))
            //{
            //    strCondition.Replace('\'', '"'); //防sql注入
            //    sql += strCondition;
            //}
            sql = sql.Replace("{MCode}", MCode);
            sql = sql.Replace("{RType}", RType);
            SqlDataReader dr = null;
            try
            {
                dr = (SqlDataReader)idb.ReturnReader(sql);
                while (dr.Read())
                {
                    PU_Detail pU_Detail = new PU_Detail();
                    if (dr["PUD_ID"] != DBNull.Value) pU_Detail.PUD_ID = Convert.ToDecimal(dr["PUD_ID"]);
                    if (dr["PUD_Code"] != DBNull.Value) pU_Detail.PUD_Code = Convert.ToString(dr["PUD_Code"]);
                    if (dr["PUD_MCode"] != DBNull.Value) pU_Detail.PUD_MCode = Convert.ToString(dr["PUD_MCode"]);
                    if (dr["PUD_MName"] != DBNull.Value) pU_Detail.PUD_MName = Convert.ToString(dr["PUD_MName"]);
                    if (dr["PUD_Spec"] != DBNull.Value) pU_Detail.PUD_Spec = Convert.ToString(dr["PUD_Spec"]);
                    if (dr["PUD_Unit"] != DBNull.Value) pU_Detail.PUD_Unit = Convert.ToString(dr["PUD_Unit"]);
                    if (dr["PUD_Price"] != DBNull.Value) pU_Detail.PUD_Price = Convert.ToDecimal(dr["PUD_Price"]);
                    if (dr["PUD_Num"] != DBNull.Value) pU_Detail.PUD_Num = Convert.ToDecimal(dr["PUD_Num"]);
                    if (dr["PUD_Bak"] != DBNull.Value) pU_Detail.PUD_Bak = Convert.ToString(dr["PUD_Bak"]);
                    if (dr["PUD_RType"] != DBNull.Value) pU_Detail.PUD_RType = Convert.ToString(dr["PUD_RType"]);
                    if (dr["PUD_RCode"] != DBNull.Value) pU_Detail.PUD_RCode = Convert.ToString(dr["PUD_RCode"]);
                    if (dr["PUD_RefWCode"] != DBNull.Value) pU_Detail.PUD_RefWCode = Convert.ToString(dr["PUD_RefWCode"]);
                    if (dr["PUD_RefWNo"] != DBNull.Value) pU_Detail.PUD_RefWNo = Convert.ToString(dr["PUD_RefWNo"]);
                    if (dr["PUD_RefWName"] != DBNull.Value) pU_Detail.PUD_RefWName = Convert.ToString(dr["PUD_RefWName"]);
                    if (dr["PUD_Tranfee"] != DBNull.Value) pU_Detail.PUD_Tranfee = Convert.ToDecimal(dr["PUD_Tranfee"]);
                    if (dr["Stat"] != DBNull.Value) pU_Detail.Stat = Convert.ToInt32(dr["Stat"]);
                    if (dr["CreateDate"] != DBNull.Value) pU_Detail.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
                    if (dr["UpdateDate"] != DBNull.Value) pU_Detail.UpdateDate = Convert.ToDateTime(dr["UpdateDate"]);
                    if (dr["DeleteDate"] != DBNull.Value) pU_Detail.DeleteDate = Convert.ToDateTime(dr["DeleteDate"]);
                    if (dr["PUD_DNum"] != DBNull.Value) pU_Detail.PUD_DNum = Convert.ToDecimal(dr["PUD_DNum"]);
                    if (dr["PUD_DStatus"] != DBNull.Value) pU_Detail.PUD_DStatus = Convert.ToString(dr["PUD_DStatus"]);
                    if (dr["PUD_RefWNoName"] != DBNull.Value) pU_Detail.PUD_RefWNoName = Convert.ToString(dr["PUD_RefWNoName"]);
                    if (dr["PUD_Udef1"] != DBNull.Value) pU_Detail.PUD_Udef1 = Convert.ToString(dr["PUD_Udef1"]);
                    if (dr["PUD_Udef2"] != DBNull.Value) pU_Detail.PUD_Udef2 = Convert.ToString(dr["PUD_Udef2"]);
                    if (dr["PUD_Udef3"] != DBNull.Value) pU_Detail.PUD_Udef3 = Convert.ToString(dr["PUD_Udef3"]);
                    if (dr["PUD_Udef4"] != DBNull.Value) pU_Detail.PUD_Udef4 = Convert.ToString(dr["PUD_Udef4"]);
                    if (dr["PUD_Udef5"] != DBNull.Value) pU_Detail.PUD_Udef5 = Convert.ToString(dr["PUD_Udef5"]);
                    if (dr["PUD_CCompany"] != DBNull.Value) pU_Detail.PUD_CCompany = Convert.ToString(dr["PUD_CCompany"]);
                    if (dr["PUD_CCompanyCode"] != DBNull.Value) pU_Detail.PUD_CCompanyCode = Convert.ToString(dr["PUD_CCompanyCode"]);
                    if (dr["PUD_Dept"] != DBNull.Value) pU_Detail.PUD_Dept = Convert.ToString(dr["PUD_Dept"]);
                    if (dr["PUD_DeptCode"] != DBNull.Value) pU_Detail.PUD_DeptCode = Convert.ToString(dr["PUD_DeptCode"]);
                    if (dr["PUD_RDate"] != DBNull.Value) pU_Detail.PUD_RDate = Convert.ToDateTime(dr["PUD_RDate"]);
                    if (dr["PUD_SupCode"] != DBNull.Value) pU_Detail.PUD_SupCode = Convert.ToString(dr["PUD_SupCode"]);
                    if (dr["PUD_SupName"] != DBNull.Value) pU_Detail.PUD_SupName = Convert.ToString(dr["PUD_SupName"]);
                    if (dr["PUD_Num1"] != DBNull.Value) pU_Detail.PUD_Num1 = Convert.ToDecimal(dr["PUD_Num1"]);
                    if (dr["PUD_Num2"] != DBNull.Value) pU_Detail.PUD_Num2 = Convert.ToDecimal(dr["PUD_Num2"]);
                    if (dr["PUD_Num3"] != DBNull.Value) pU_Detail.PUD_Num3 = Convert.ToDecimal(dr["PUD_Num3"]);
                    if (dr["PUD_Num4"] != DBNull.Value) pU_Detail.PUD_Num4 = Convert.ToDecimal(dr["PUD_Num4"]);
                    if (dr["PUD_Num5"] != DBNull.Value) pU_Detail.PUD_Num5 = Convert.ToDecimal(dr["PUD_Num5"]);
                    ret.Add(pU_Detail);
                }
            }
            catch (System.Exception ex) { throw ex; }
            finally { if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); } }
            return ret;
        }
    }
}
