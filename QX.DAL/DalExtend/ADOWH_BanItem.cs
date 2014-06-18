using System;
using System.Text;
using System.Data;
using System.Data.Common;
using System.Collections.Generic;

using QX.Model;
using System.Data.SqlClient;

namespace QX.DAL
{
    public partial class ADOWH_BanItem
    {
        /// <summary>
        /// 获取指定的盘点物料列表 WH_BanItem对象集合
        /// </summary>
        public List<WH_BanItem> GetListForPrint(string strCondition)
        {
            List<WH_BanItem> ret = new List<WH_BanItem>();
            string sql = "SELECT BI.*,BM.WHBM_Company FROM WH_BanItem BI,WH_BanMain BM WHERE BM.WHBM_Code=BI.WHBI_BCode AND  1=1 AND ISNULL(BM.Stat,0)=0 AND ISNULL(BI.Stat,0)=0 ";
            if (!string.IsNullOrEmpty(strCondition))
            {
                strCondition.Replace('\'', '"'); //防sql注入
                sql += strCondition;
            }
            //sql = sql + " group by WHBI_WNo";
            SqlDataReader dr = null;
            try
            {
                dr = (SqlDataReader)idb.ReturnReader(sql);
                while (dr.Read())
                {
                    WH_BanItem wH_BanItem = new WH_BanItem();
                    if (dr["WHBI_ID"] != DBNull.Value) wH_BanItem.WHBI_ID = Convert.ToDecimal(dr["WHBI_ID"]);
                    if (dr["WHBI_Code"] != DBNull.Value) wH_BanItem.WHBI_Code = Convert.ToString(dr["WHBI_Code"]);
                    if (dr["WHBI_BCode"] != DBNull.Value) wH_BanItem.WHBI_BCode = Convert.ToString(dr["WHBI_BCode"]);

                    if (dr["WHBI_WCode"] != DBNull.Value) wH_BanItem.WHBI_WCode = Convert.ToString(dr["WHBI_WCode"]);
                    if (dr["WHBI_WName"] != DBNull.Value) wH_BanItem.WHBI_WName = Convert.ToString(dr["WHBI_WName"]);
                    if (dr["WHBI_WNo"] != DBNull.Value) wH_BanItem.WHBI_WNo = Convert.ToString(dr["WHBI_WNo"]);
                    if (dr["WHBI_WNoName"] != DBNull.Value) wH_BanItem.WHBI_WNoName = Convert.ToString(dr["WHBI_WNoName"]);

                    if (dr["WHBI_MCode"] != DBNull.Value) wH_BanItem.WHBI_MCode = Convert.ToString(dr["WHBI_MCode"]);
                    if (dr["WHBI_MName"] != DBNull.Value) wH_BanItem.WHBI_MName = Convert.ToString(dr["WHBI_MName"]);
                    if (dr["WHBI_MSpec"] != DBNull.Value) wH_BanItem.WHBI_MSpec = Convert.ToString(dr["WHBI_MSpec"]);
                    if (dr["WHBI_MUnit"] != DBNull.Value) wH_BanItem.WHBI_MUnit = Convert.ToString(dr["WHBI_MUnit"]);
                    //if (dr["WHBI_RNum"] != DBNull.Value) wH_BanItem.WHBI_RNum = Convert.ToInt32(dr["WHBI_RNum"]);
                    if (dr["WHBI_BNum"] != DBNull.Value) wH_BanItem.WHBI_BNum = Convert.ToDecimal(dr["WHBI_BNum"]);
                    //if (dr["WHBI_MNum"] != DBNull.Value) wH_BanItem.WHBI_MNum = Convert.ToInt32(dr["WHBI_MNum"]);
                    //if (dr["WHBI_LNum"] != DBNull.Value) wH_BanItem.WHBI_LNum = Convert.ToInt32(dr["WHBI_LNum"]);
                    if (dr["WHBI_Type"] != DBNull.Value) wH_BanItem.WHBI_Type = Convert.ToString(dr["WHBI_Type"]);
                    if (dr["WHBI_RType"] != DBNull.Value) wH_BanItem.WHBI_RType = Convert.ToString(dr["WHBI_RType"]);
                    if (dr["WHBI_Date"] != DBNull.Value) wH_BanItem.WHBI_Date = Convert.ToDateTime(dr["WHBI_Date"]);
                    if (dr["WHBI_Owner"] != DBNull.Value) wH_BanItem.WHBI_Owner = Convert.ToString(dr["WHBI_Owner"]);
                    if (dr["WHBI_Bak"] != DBNull.Value) wH_BanItem.WHBI_Bak = Convert.ToString(dr["WHBI_Bak"]);
                    if (dr["Stat"] != DBNull.Value) wH_BanItem.Stat = Convert.ToInt32(dr["Stat"]);
                    if (dr["CreateDate"] != DBNull.Value) wH_BanItem.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
                    if (dr["UpdateDate"] != DBNull.Value) wH_BanItem.UpdateDate = Convert.ToDateTime(dr["UpdateDate"]);
                    if (dr["DeleteDate"] != DBNull.Value) wH_BanItem.DeleteDate = Convert.ToDateTime(dr["DeleteDate"]);
                    //WHBM_Company
                    if (dr["WHBM_Company"] != DBNull.Value) wH_BanItem.WHBM_Company = Convert.ToString(dr["WHBM_Company"]);
                    ret.Add(wH_BanItem);
                }
            }
            catch (System.Exception ex) { throw ex; }
            finally { if (dr != null) { dr.Close(); } }
            return ret;
        }

    }
}
