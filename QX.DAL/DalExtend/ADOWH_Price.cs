using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Text;
using QX.Model;
using QX.DataAcess;

namespace QX.DAL
{
   public partial class ADOWH_Price
    {
        /// <summary>
        /// 获取指定的WH_Price对象集合
        /// </summary>
       public List<WH_Price> GetListByWhere(string strCondition, string spread)
        {
            List<WH_Price> ret = new List<WH_Price>();
            string sql = "SELECT*FROM WH_Price JOIN WH_Material ON WH_Price.WP_MCode=WH_Material.MD_MCode JOIN WH_Storage  ON WH_Material.MD_MCode=WH_Storage.Storage_MaterielCode WHERE 1=1 AND ((WH_Material.Stat is null) or (WH_Material.Stat=0) ) ";
            if (!string.IsNullOrEmpty(strCondition))
            {
                strCondition.Replace('\'', '"'); //防sql注入
                sql += strCondition;
            }
            sql += " ORDER BY WP_ID DESC ";
            SqlDataReader dr = null;
            try
            {
                dr = (SqlDataReader)idb.ReturnReader(sql);
                while (dr.Read())
                {
                    WH_Price wH_Price = new WH_Price();
                    if (dr["WP_ID"] != DBNull.Value) wH_Price.WP_ID = Convert.ToInt64(dr["WP_ID"]);
                    if (dr["WP_CCode"] != DBNull.Value) wH_Price.WP_CCode = Convert.ToString(dr["WP_CCode"]);
                    if (dr["WP_CName"] != DBNull.Value) wH_Price.WP_CName = Convert.ToString(dr["WP_CName"]);
                    if (dr["WP_MCode"] != DBNull.Value) wH_Price.WP_MCode = Convert.ToString(dr["WP_MCode"]);
                    if (dr["WP_Price"] != DBNull.Value) wH_Price.WP_Price = Convert.ToDecimal(dr["WP_Price"]);
                    if (dr["WP_Num"] != DBNull.Value) wH_Price.WP_Num = Convert.ToDecimal(dr["WP_Num"]);
                    if (dr["WP_ONum"] != DBNull.Value) wH_Price.WP_ONum = Convert.ToDecimal(dr["WP_ONum"]);
                    if (dr["WP_PNum"] != DBNull.Value) wH_Price.WP_PNum = Convert.ToDecimal(dr["WP_PNum"]);
                    if (dr["WP_Udef1"] != DBNull.Value) wH_Price.WP_Udef1 = Convert.ToString(dr["WP_Udef1"]);
                    if (dr["WP_Udef2"] != DBNull.Value) wH_Price.WP_Udef2 = Convert.ToString(dr["WP_Udef2"]);
                    if (dr["WP_Udef3"] != DBNull.Value) wH_Price.WP_Udef3 = Convert.ToString(dr["WP_Udef3"]);
                    if (dr["WP_Udef4"] != DBNull.Value) wH_Price.WP_Udef4 = Convert.ToString(dr["WP_Udef4"]);
                    if (dr["WP_Udef5"] != DBNull.Value) wH_Price.WP_Udef5 = Convert.ToString(dr["WP_Udef5"]);
                    if (dr["WP_Udef6"] != DBNull.Value) wH_Price.WP_Udef6 = Convert.ToString(dr["WP_Udef6"]);
                    if (dr["WP_Udef7"] != DBNull.Value) wH_Price.WP_Udef7 = Convert.ToString(dr["WP_Udef7"]);
                    if (dr["WP_Udef8"] != DBNull.Value) wH_Price.WP_Udef8 = Convert.ToString(dr["WP_Udef8"]);
                    if (dr["WP_Udef9"] != DBNull.Value) wH_Price.WP_Udef9 = Convert.ToString(dr["WP_Udef9"]);
                    if (dr["WP_Udef10"] != DBNull.Value) wH_Price.WP_Udef10 = Convert.ToString(dr["WP_Udef10"]);
                    if (dr["Stat"] != DBNull.Value) wH_Price.Stat = Convert.ToInt32(dr["Stat"]);
                    //扩展属性
                    if (dr["Storage_Count"] != DBNull.Value) wH_Price.Storage_Count = Convert.ToInt32(dr["Storage_Count"]);
                    if (dr["Storage_TNum"] != DBNull.Value) wH_Price.Storage_TNum = Convert.ToInt32(dr["Storage_TNum"]);
                    if (dr["Storage_LNum"] != DBNull.Value) wH_Price.Storage_LNum = Convert.ToInt32(dr["Storage_LNum"]);
                    if (dr["Storage_Dvalue"] != DBNull.Value) wH_Price.Storage_Dvalue = Convert.ToDecimal(dr["Storage_Dvalue"]);
                    ret.Add(wH_Price);
                }
            }
            catch (System.Exception ex) { throw ex; }
            finally { if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); } }
            return ret;
        }
    }
}
