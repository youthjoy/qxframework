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
   /// 库存量信息表
   /// </summary>
    public partial class ADOWH_Storage
    {
        public List<WH_Storage> GetListByWhereEx(string strCondition)
        {
            List<WH_Storage> ret = new List<WH_Storage>();
            //string sql = "SELECT  WH_Storage.*,WH_Material.MD_Name FROM WH_Storage,WH_Material WHERE 1=1 AND ((WH_Material.Stat is null) or (WH_Material.Stat=0) ) AND WH_Storage.Storage_MaterielCode= WH_Material.MD_MCode ";
            string sql = @"SELECT a.Storage_ID,a.Storage_WarehouseCode,a.Storage_WarehouseNo, a.Storage_Company,a.Storage_CompanyCode,a.Storage_MaterielCode,
                            b.MD_Name,c.WP_Price as Storage_Price,a.Storage_Code,a.Storage_Count,a.Storage_Available,a.Storage_LNum,a.Storage_TNum,
                            a.Storage_PromiseCount,a.Storage_Dvalue,a.Storage_OrderCount,a.Storage_Remark
                             from WH_Storage a INNER JOIN WH_Material b on a.Storage_MaterielCode=b.MD_MCode 
                            Inner JOIN WH_Price c on a.Storage_MaterielCode=c.WP_MCode where a.Storage_CompanyCode=c.WP_CCode and isnull(a.Stat,0)=0 and isnull(b.Stat,0)=0 and isnull(c.Stat,0)=0";

            if (!string.IsNullOrEmpty(strCondition))
            {
                strCondition.Replace('\'', '"'); //防sql注入
                sql += strCondition;
            }
            sql += " ORDER BY a.Storage_ID DESC ";
            SqlDataReader dr = null;
            try
            {
                dr = (SqlDataReader)idb.ReturnReader(sql);
                while (dr.Read())
                {
                    WH_Storage wH_Storage = new WH_Storage();
                    if (dr["Storage_ID"] != DBNull.Value) wH_Storage.Storage_ID = Convert.ToDecimal(dr["Storage_ID"]);
                    if (dr["Storage_Code"] != DBNull.Value) wH_Storage.Storage_Code = Convert.ToString(dr["Storage_Code"]);
                    if (dr["Storage_MaterielCode"] != DBNull.Value) wH_Storage.Storage_MaterielCode = Convert.ToString(dr["Storage_MaterielCode"]);
                    if (dr["Storage_WarehouseCode"] != DBNull.Value) wH_Storage.Storage_WarehouseCode = Convert.ToString(dr["Storage_WarehouseCode"]);
                    if (dr["Storage_WarehouseNo"] != DBNull.Value) wH_Storage.Storage_WarehouseNo = Convert.ToString(dr["Storage_WarehouseNo"]);
                    if (dr["Storage_Count"] != DBNull.Value) wH_Storage.Storage_Count = Convert.ToInt64(dr["Storage_Count"]);
                    if (dr["Storage_PromiseCount"] != DBNull.Value) wH_Storage.Storage_PromiseCount = Convert.ToInt64(dr["Storage_PromiseCount"]);
                    if (dr["Storage_OrderCount"] != DBNull.Value) wH_Storage.Storage_OrderCount = Convert.ToInt64(dr["Storage_OrderCount"]);
                    if (dr["Storage_Available"] != DBNull.Value) wH_Storage.Storage_Available = Convert.ToDecimal(dr["Storage_Available"]);
                    if (dr["Storage_TNum"] != DBNull.Value) wH_Storage.Storage_TNum = Convert.ToInt64(dr["Storage_TNum"]);
                    if (dr["Storage_LNum"] != DBNull.Value) wH_Storage.Storage_LNum = Convert.ToInt64(dr["Storage_LNum"]);
                    if (dr["Storage_Remark"] != DBNull.Value) wH_Storage.Storage_Remark = Convert.ToString(dr["Storage_Remark"]);
                    //if (dr["Stat"] != DBNull.Value) wH_Storage.Stat = Convert.ToInt32(dr["Stat"]);
                    //if (dr["CreateDate"] != DBNull.Value) wH_Storage.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
                    //if (dr["UpdateDate"] != DBNull.Value) wH_Storage.UpdateDate = Convert.ToDateTime(dr["UpdateDate"]);
                    //if (dr["DeleteDate"] != DBNull.Value) wH_Storage.DeleteDate = Convert.ToDateTime(dr["DeleteDate"]);
                    if (dr["MD_Name"] != DBNull.Value) wH_Storage.MD_Name = Convert.ToString(dr["MD_Name"]);
                    if (dr["Storage_Company"] != DBNull.Value) wH_Storage.Storage_Company = Convert.ToString(dr["Storage_Company"]);
                    if (dr["Storage_CompanyCode"] != DBNull.Value) wH_Storage.Storage_CompanyCode = Convert.ToString(dr["Storage_CompanyCode"]);
                    if (dr["Storage_Price"] != DBNull.Value) wH_Storage.Storage_Price = Convert.ToDecimal(dr["Storage_Price"]);
                    ret.Add(wH_Storage);
                }
            }
            catch (System.Exception ex) { throw ex; }
            finally { if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); } }
            return ret;
        }
    }
}
