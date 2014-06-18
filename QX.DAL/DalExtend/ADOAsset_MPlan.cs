using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Text;
using QX.Model;
using QX.DataAcess;

namespace QX.DAL
{
    public partial class ADOAsset_MPlan
    {
        /// <summary>
        /// 获取所有的固定资产检修计划 Asset_MPlan对象(即:一条记录
        /// </summary>
        public List<Asset_MPlan> GetListByWhere(string code,int A)
        {
            List<Asset_MPlan> ret = new List<Asset_MPlan>();
            string sql = "SELECT*FROM Asset_MPlan am WHERE 1=1 AND ((am.Stat is null) or (am.Stat=0) ) AND am.AMP_Code IN(SELECT ai2.AIP_MCode  FROM Asset_Infomation ai JOIN Asset_IPlan ai2 ON ai.AInfo_Code=ai2.AIP_FCode WHERE ai.AInfo_Code='"+code+"')";
            SqlDataReader dr = null;
            try
            {
                dr = (SqlDataReader)idb.ReturnReader(sql);
                while (dr.Read())
                {
                    Asset_MPlan asset_MPlan = new Asset_MPlan();
                    if (dr["AMP_ID"] != DBNull.Value) asset_MPlan.AMP_ID = Convert.ToDecimal(dr["AMP_ID"]);
                    if (dr["AMP_Code"] != DBNull.Value) asset_MPlan.AMP_Code = Convert.ToString(dr["AMP_Code"]);
                    if (dr["AMP_Name"] != DBNull.Value) asset_MPlan.AMP_Name = Convert.ToString(dr["AMP_Name"]);
                    if (dr["AMP_Stuff"] != DBNull.Value) asset_MPlan.AMP_Stuff = Convert.ToString(dr["AMP_Stuff"]);
                    if (dr["AMP_Start"] != DBNull.Value) asset_MPlan.AMP_Start = Convert.ToDateTime(dr["AMP_Start"]);
                    if (dr["AMP_End"] != DBNull.Value) asset_MPlan.AMP_End = Convert.ToDateTime(dr["AMP_End"]);
                    if (dr["VerifyStuff"] != DBNull.Value) asset_MPlan.VerifyStuff = Convert.ToString(dr["VerifyStuff"]);
                    if (dr["AuditStat"] != DBNull.Value) asset_MPlan.AuditStat = Convert.ToString(dr["AuditStat"]);
                    if (dr["VerifyDate"] != DBNull.Value) asset_MPlan.VerifyDate = Convert.ToDateTime(dr["VerifyDate"]);
                    if (dr["Stat"] != DBNull.Value) asset_MPlan.Stat = Convert.ToInt32(dr["Stat"]);
                    if (dr["CreateDate"] != DBNull.Value) asset_MPlan.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
                    if (dr["UpdateDate"] != DBNull.Value) asset_MPlan.UpdateDate = Convert.ToDateTime(dr["UpdateDate"]);
                    if (dr["DeleteDate"] != DBNull.Value) asset_MPlan.DeleteDate = Convert.ToDateTime(dr["DeleteDate"]);
                    if (dr["AuditCurAudit"] != DBNull.Value) asset_MPlan.AuditCurAudit = Convert.ToString(dr["AuditCurAudit"]);
                    if (dr["AMP_Type"] != DBNull.Value) asset_MPlan.AMP_Type = Convert.ToString(dr["AMP_Type"]);
                    if (dr["AMP_Company"] != DBNull.Value) asset_MPlan.AMP_Company = Convert.ToString(dr["AMP_Company"]);
                    if (dr["AMP_Dept"] != DBNull.Value) asset_MPlan.AMP_Dept = Convert.ToString(dr["AMP_Dept"]);
                    ret.Add(asset_MPlan);
                }
            }
            catch (System.Exception ex) { throw ex; }
            finally { if (dr != null) { dr.Close(); } }
            return ret;
        }
    }
}
