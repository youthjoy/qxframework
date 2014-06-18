using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using QX.Model;
using QX.DAL;
using System.Data.SqlClient;
using System.Data;

namespace QX.DAL
{
    public partial class ADOWH_IOItem
    {
        public List<WH_IOItem> GetIOItemForRef(string strCondition)
        {
            List<WH_IOItem> ret = new List<WH_IOItem>();
            string sql = @"SELECT  WHIOI_ID,WHIOI_Code,WHIOI_MainCode,WHIOI_MCode,WHIOI_MName
                            ,WHIOI_MSpec,WHIOI_MUnit,WHIOI_MNum,isnull((WP_Price),0) WHIOI_MPrice,WHIOI_Company
                            ,WHIOI_Department,WHIOI_UType,WHIOI_UOwner,WHIOI_UOwnerCode,WHIOI_Date
                            ,wi.Stat,wi.CreateDate,wi.UpdateDate,wi.DeleteDate,WHIOM_Code,WHIOI_RefWName
                            ,WHIOI_RefWCode,WHIOI_RefWNo,WHIOI_RefWNoName,WHIOI_Udef1,WHIOI_Udef2
                            ,WHIOI_Udef3,WHIOI_Udef4,WHIOI_Udef5,WHIOI_CCompany,WHIOI_CCompanyCode
                            ,WHIOI_CDept,WHIOI_CDeptCode,WHIOI_UDEF6,WHIOI_UDEF7,WHIOI_UDEF8
                            ,WHIOI_UDEF9,WHIOI_UDEF10,WHIOI_Num1,WHIOI_Num2,WHIOI_Num3,WHIOI_Num4,WHIOI_Num5 
                            FROM WH_IOItem wi
                            LEFT JOIN WH_Price wp ON wp.WP_CCode=wi.WHIOI_CCompanyCode and wp.WP_MCode=wi.WHIOI_MCode
                            WHERE 1=1 AND ((wi.Stat is null) or (wi.Stat=0) ) ";
            if (!string.IsNullOrEmpty(strCondition))
            {
                strCondition.Replace('\'', '"'); //防sql注入
                sql += strCondition;
            }
            sql += " ORDER BY WHIOI_ID DESC ";
            SqlDataReader dr = null;
            try
            {
                dr = (SqlDataReader)idb.ReturnReader(sql);
                while (dr.Read())
                {
                    WH_IOItem wH_IOItem = new WH_IOItem();
                    if (dr["WHIOI_ID"] != DBNull.Value) wH_IOItem.WHIOI_ID = Convert.ToDecimal(dr["WHIOI_ID"]);
                    if (dr["WHIOI_Code"] != DBNull.Value) wH_IOItem.WHIOI_Code = Convert.ToString(dr["WHIOI_Code"]);
                    if (dr["WHIOI_MainCode"] != DBNull.Value) wH_IOItem.WHIOI_MainCode = Convert.ToString(dr["WHIOI_MainCode"]);
                    if (dr["WHIOI_MCode"] != DBNull.Value) wH_IOItem.WHIOI_MCode = Convert.ToString(dr["WHIOI_MCode"]);
                    if (dr["WHIOI_MName"] != DBNull.Value) wH_IOItem.WHIOI_MName = Convert.ToString(dr["WHIOI_MName"]);
                    if (dr["WHIOI_MSpec"] != DBNull.Value) wH_IOItem.WHIOI_MSpec = Convert.ToString(dr["WHIOI_MSpec"]);
                    if (dr["WHIOI_MUnit"] != DBNull.Value) wH_IOItem.WHIOI_MUnit = Convert.ToString(dr["WHIOI_MUnit"]);
                    if (dr["WHIOI_MNum"] != DBNull.Value) wH_IOItem.WHIOI_MNum = Convert.ToDecimal(dr["WHIOI_MNum"]);
                    if (dr["WHIOI_MPrice"] != DBNull.Value) wH_IOItem.WHIOI_MPrice = Convert.ToDecimal(dr["WHIOI_MPrice"]);
                    if (dr["WHIOI_Company"] != DBNull.Value) wH_IOItem.WHIOI_Company = Convert.ToString(dr["WHIOI_Company"]);
                    if (dr["WHIOI_Department"] != DBNull.Value) wH_IOItem.WHIOI_Department = Convert.ToString(dr["WHIOI_Department"]);
                    if (dr["WHIOI_UType"] != DBNull.Value) wH_IOItem.WHIOI_UType = Convert.ToString(dr["WHIOI_UType"]);
                    if (dr["WHIOI_UOwner"] != DBNull.Value) wH_IOItem.WHIOI_UOwner = Convert.ToString(dr["WHIOI_UOwner"]);
                    if (dr["WHIOI_UOwnerCode"] != DBNull.Value) wH_IOItem.WHIOI_UOwnerCode = Convert.ToString(dr["WHIOI_UOwnerCode"]);
                    if (dr["WHIOI_Date"] != DBNull.Value) wH_IOItem.WHIOI_Date = Convert.ToDateTime(dr["WHIOI_Date"]);
                    if (dr["Stat"] != DBNull.Value) wH_IOItem.Stat = Convert.ToInt32(dr["Stat"]);
                    if (dr["CreateDate"] != DBNull.Value) wH_IOItem.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
                    if (dr["UpdateDate"] != DBNull.Value) wH_IOItem.UpdateDate = Convert.ToDateTime(dr["UpdateDate"]);
                    if (dr["DeleteDate"] != DBNull.Value) wH_IOItem.DeleteDate = Convert.ToDateTime(dr["DeleteDate"]);
                    if (dr["WHIOM_Code"] != DBNull.Value) wH_IOItem.WHIOM_Code = Convert.ToString(dr["WHIOM_Code"]);
                    if (dr["WHIOI_RefWName"] != DBNull.Value) wH_IOItem.WHIOI_RefWName = Convert.ToString(dr["WHIOI_RefWName"]);
                    if (dr["WHIOI_RefWCode"] != DBNull.Value) wH_IOItem.WHIOI_RefWCode = Convert.ToString(dr["WHIOI_RefWCode"]);
                    if (dr["WHIOI_RefWNo"] != DBNull.Value) wH_IOItem.WHIOI_RefWNo = Convert.ToString(dr["WHIOI_RefWNo"]);
                    if (dr["WHIOI_RefWNoName"] != DBNull.Value) wH_IOItem.WHIOI_RefWNoName = Convert.ToString(dr["WHIOI_RefWNoName"]);
                    if (dr["WHIOI_Udef1"] != DBNull.Value) wH_IOItem.WHIOI_Udef1 = Convert.ToString(dr["WHIOI_Udef1"]);
                    if (dr["WHIOI_Udef2"] != DBNull.Value) wH_IOItem.WHIOI_Udef2 = Convert.ToString(dr["WHIOI_Udef2"]);
                    if (dr["WHIOI_Udef3"] != DBNull.Value) wH_IOItem.WHIOI_Udef3 = Convert.ToString(dr["WHIOI_Udef3"]);
                    if (dr["WHIOI_Udef4"] != DBNull.Value) wH_IOItem.WHIOI_Udef4 = Convert.ToString(dr["WHIOI_Udef4"]);
                    if (dr["WHIOI_Udef5"] != DBNull.Value) wH_IOItem.WHIOI_Udef5 = Convert.ToString(dr["WHIOI_Udef5"]);
                    if (dr["WHIOI_CCompany"] != DBNull.Value) wH_IOItem.WHIOI_CCompany = Convert.ToString(dr["WHIOI_CCompany"]);
                    if (dr["WHIOI_CCompanyCode"] != DBNull.Value) wH_IOItem.WHIOI_CCompanyCode = Convert.ToString(dr["WHIOI_CCompanyCode"]);
                    if (dr["WHIOI_CDept"] != DBNull.Value) wH_IOItem.WHIOI_CDept = Convert.ToString(dr["WHIOI_CDept"]);
                    if (dr["WHIOI_CDeptCode"] != DBNull.Value) wH_IOItem.WHIOI_CDeptCode = Convert.ToString(dr["WHIOI_CDeptCode"]);
                    if (dr["WHIOI_UDEF6"] != DBNull.Value) wH_IOItem.WHIOI_UDEF6 = Convert.ToString(dr["WHIOI_UDEF6"]);
                    if (dr["WHIOI_UDEF7"] != DBNull.Value) wH_IOItem.WHIOI_UDEF7 = Convert.ToString(dr["WHIOI_UDEF7"]);
                    if (dr["WHIOI_UDEF8"] != DBNull.Value) wH_IOItem.WHIOI_UDEF8 = Convert.ToString(dr["WHIOI_UDEF8"]);
                    if (dr["WHIOI_UDEF9"] != DBNull.Value) wH_IOItem.WHIOI_UDEF9 = Convert.ToString(dr["WHIOI_UDEF9"]);
                    if (dr["WHIOI_UDEF10"] != DBNull.Value) wH_IOItem.WHIOI_UDEF10 = Convert.ToString(dr["WHIOI_UDEF10"]);
                    if (dr["WHIOI_Num1"] != DBNull.Value) wH_IOItem.WHIOI_Num1 = Convert.ToDecimal(dr["WHIOI_Num1"]);
                    if (dr["WHIOI_Num2"] != DBNull.Value) wH_IOItem.WHIOI_Num2 = Convert.ToDecimal(dr["WHIOI_Num2"]);
                    if (dr["WHIOI_Num3"] != DBNull.Value) wH_IOItem.WHIOI_Num3 = Convert.ToDecimal(dr["WHIOI_Num3"]);
                    if (dr["WHIOI_Num4"] != DBNull.Value) wH_IOItem.WHIOI_Num4 = Convert.ToDecimal(dr["WHIOI_Num4"]);
                    if (dr["WHIOI_Num5"] != DBNull.Value) wH_IOItem.WHIOI_Num5 = Convert.ToDecimal(dr["WHIOI_Num5"]);
                    ret.Add(wH_IOItem);
                }
            }
            catch (System.Exception ex) { throw ex; }
            finally { if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); } }
            return ret;
        }


        public List<WH_IOItem> GetIOItemRefMain(string MCode,string Rtype)
        {
            List<WH_IOItem> ret = new List<WH_IOItem>();
            string sql = @" select iod.* from WH_IOMain iom INNER JOIN WH_IOItem iod
                            on iom.WHIOM_Code=iod.WHIOI_MainCode
                            where iod.WHIOI_MCode='{MCode}'
                            and iom.WHIOM_Type='{RType}'
                            and iom.AuditStat='LastAudit'
                            and ISNULL(iom.Stat, 0)=0";

            sql = sql.Replace("{MCode}", MCode);
            sql = sql.Replace("{RType}", Rtype);
            SqlDataReader dr = null;
            try
            {
                dr = (SqlDataReader)idb.ReturnReader(sql);
                while (dr.Read())
                {
                    WH_IOItem wH_IOItem = new WH_IOItem();
                    if (dr["WHIOI_ID"] != DBNull.Value) wH_IOItem.WHIOI_ID = Convert.ToDecimal(dr["WHIOI_ID"]);
                    if (dr["WHIOI_Code"] != DBNull.Value) wH_IOItem.WHIOI_Code = Convert.ToString(dr["WHIOI_Code"]);
                    if (dr["WHIOI_MainCode"] != DBNull.Value) wH_IOItem.WHIOI_MainCode = Convert.ToString(dr["WHIOI_MainCode"]);
                    if (dr["WHIOI_MCode"] != DBNull.Value) wH_IOItem.WHIOI_MCode = Convert.ToString(dr["WHIOI_MCode"]);
                    if (dr["WHIOI_MName"] != DBNull.Value) wH_IOItem.WHIOI_MName = Convert.ToString(dr["WHIOI_MName"]);
                    if (dr["WHIOI_MSpec"] != DBNull.Value) wH_IOItem.WHIOI_MSpec = Convert.ToString(dr["WHIOI_MSpec"]);
                    if (dr["WHIOI_MUnit"] != DBNull.Value) wH_IOItem.WHIOI_MUnit = Convert.ToString(dr["WHIOI_MUnit"]);
                    if (dr["WHIOI_MNum"] != DBNull.Value) wH_IOItem.WHIOI_MNum = Convert.ToDecimal(dr["WHIOI_MNum"]);
                    if (dr["WHIOI_MPrice"] != DBNull.Value) wH_IOItem.WHIOI_MPrice = Convert.ToDecimal(dr["WHIOI_MPrice"]);
                    if (dr["WHIOI_Company"] != DBNull.Value) wH_IOItem.WHIOI_Company = Convert.ToString(dr["WHIOI_Company"]);
                    if (dr["WHIOI_Department"] != DBNull.Value) wH_IOItem.WHIOI_Department = Convert.ToString(dr["WHIOI_Department"]);
                    if (dr["WHIOI_UType"] != DBNull.Value) wH_IOItem.WHIOI_UType = Convert.ToString(dr["WHIOI_UType"]);
                    if (dr["WHIOI_UOwner"] != DBNull.Value) wH_IOItem.WHIOI_UOwner = Convert.ToString(dr["WHIOI_UOwner"]);
                    if (dr["WHIOI_UOwnerCode"] != DBNull.Value) wH_IOItem.WHIOI_UOwnerCode = Convert.ToString(dr["WHIOI_UOwnerCode"]);
                    if (dr["WHIOI_Date"] != DBNull.Value) wH_IOItem.WHIOI_Date = Convert.ToDateTime(dr["WHIOI_Date"]);
                    if (dr["Stat"] != DBNull.Value) wH_IOItem.Stat = Convert.ToInt32(dr["Stat"]);
                    if (dr["CreateDate"] != DBNull.Value) wH_IOItem.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
                    if (dr["UpdateDate"] != DBNull.Value) wH_IOItem.UpdateDate = Convert.ToDateTime(dr["UpdateDate"]);
                    if (dr["DeleteDate"] != DBNull.Value) wH_IOItem.DeleteDate = Convert.ToDateTime(dr["DeleteDate"]);
                    if (dr["WHIOM_Code"] != DBNull.Value) wH_IOItem.WHIOM_Code = Convert.ToString(dr["WHIOM_Code"]);
                    if (dr["WHIOI_RefWName"] != DBNull.Value) wH_IOItem.WHIOI_RefWName = Convert.ToString(dr["WHIOI_RefWName"]);
                    if (dr["WHIOI_RefWCode"] != DBNull.Value) wH_IOItem.WHIOI_RefWCode = Convert.ToString(dr["WHIOI_RefWCode"]);
                    if (dr["WHIOI_RefWNo"] != DBNull.Value) wH_IOItem.WHIOI_RefWNo = Convert.ToString(dr["WHIOI_RefWNo"]);
                    if (dr["WHIOI_RefWNoName"] != DBNull.Value) wH_IOItem.WHIOI_RefWNoName = Convert.ToString(dr["WHIOI_RefWNoName"]);
                    if (dr["WHIOI_Udef1"] != DBNull.Value) wH_IOItem.WHIOI_Udef1 = Convert.ToString(dr["WHIOI_Udef1"]);
                    if (dr["WHIOI_Udef2"] != DBNull.Value) wH_IOItem.WHIOI_Udef2 = Convert.ToString(dr["WHIOI_Udef2"]);
                    if (dr["WHIOI_Udef3"] != DBNull.Value) wH_IOItem.WHIOI_Udef3 = Convert.ToString(dr["WHIOI_Udef3"]);
                    if (dr["WHIOI_Udef4"] != DBNull.Value) wH_IOItem.WHIOI_Udef4 = Convert.ToString(dr["WHIOI_Udef4"]);
                    if (dr["WHIOI_Udef5"] != DBNull.Value) wH_IOItem.WHIOI_Udef5 = Convert.ToString(dr["WHIOI_Udef5"]);
                    if (dr["WHIOI_CCompany"] != DBNull.Value) wH_IOItem.WHIOI_CCompany = Convert.ToString(dr["WHIOI_CCompany"]);
                    if (dr["WHIOI_CCompanyCode"] != DBNull.Value) wH_IOItem.WHIOI_CCompanyCode = Convert.ToString(dr["WHIOI_CCompanyCode"]);
                    if (dr["WHIOI_CDept"] != DBNull.Value) wH_IOItem.WHIOI_CDept = Convert.ToString(dr["WHIOI_CDept"]);
                    if (dr["WHIOI_CDeptCode"] != DBNull.Value) wH_IOItem.WHIOI_CDeptCode = Convert.ToString(dr["WHIOI_CDeptCode"]);
                    if (dr["WHIOI_UDEF6"] != DBNull.Value) wH_IOItem.WHIOI_UDEF6 = Convert.ToString(dr["WHIOI_UDEF6"]);
                    if (dr["WHIOI_UDEF7"] != DBNull.Value) wH_IOItem.WHIOI_UDEF7 = Convert.ToString(dr["WHIOI_UDEF7"]);
                    if (dr["WHIOI_UDEF8"] != DBNull.Value) wH_IOItem.WHIOI_UDEF8 = Convert.ToString(dr["WHIOI_UDEF8"]);
                    if (dr["WHIOI_UDEF9"] != DBNull.Value) wH_IOItem.WHIOI_UDEF9 = Convert.ToString(dr["WHIOI_UDEF9"]);
                    if (dr["WHIOI_UDEF10"] != DBNull.Value) wH_IOItem.WHIOI_UDEF10 = Convert.ToString(dr["WHIOI_UDEF10"]);
                    if (dr["WHIOI_Num1"] != DBNull.Value) wH_IOItem.WHIOI_Num1 = Convert.ToDecimal(dr["WHIOI_Num1"]);
                    if (dr["WHIOI_Num2"] != DBNull.Value) wH_IOItem.WHIOI_Num2 = Convert.ToDecimal(dr["WHIOI_Num2"]);
                    if (dr["WHIOI_Num3"] != DBNull.Value) wH_IOItem.WHIOI_Num3 = Convert.ToDecimal(dr["WHIOI_Num3"]);
                    if (dr["WHIOI_Num4"] != DBNull.Value) wH_IOItem.WHIOI_Num4 = Convert.ToDecimal(dr["WHIOI_Num4"]);
                    if (dr["WHIOI_Num5"] != DBNull.Value) wH_IOItem.WHIOI_Num5 = Convert.ToDecimal(dr["WHIOI_Num5"]);
                    ret.Add(wH_IOItem);
                }
            }
            catch (System.Exception ex) { throw ex; }
            finally { if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); } }
            return ret;
        }



    }
}
