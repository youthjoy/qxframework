using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using QX.Model;
using System.Data.SqlClient;

namespace QX.DAL
{
    public partial class ADOWH_Material
    {

        public List<WH_Material> GetListByWhereForPage(string strCondition, int CurrentPage, int PageSize)
        {
            List<WH_Material> ret = new List<WH_Material>();
            string sql = "SELECT MD_ID,MD_MCode,MD_Name,MD_Spec,MD_Barcode,MD_Group,MD_iType,MD_PriceList,MD_Unit,MD_Num,MD_LNum,MD_TNum,MD_Factory,MD_Units,MD_Bak,Stat,CreateDate,UpdateDate,DeleteDate FROM WH_Material WHERE 1=1 AND ((Stat is null) or (Stat=0) ) ";
            if (!string.IsNullOrEmpty(strCondition))
            {
                strCondition.Replace('\'', '"'); //防sql注入
                sql += strCondition;
            }

            string pageSql = string.Format(@"SELECT * FROM (SELECT row_number()over(order by MD_ID) as RN, A.*  from ({0})A) B
    WHERE RN>{1} AND RN<={2}
", sql, (CurrentPage - 1) * PageSize, CurrentPage * PageSize);


            SqlDataReader dr = null;
            try
            {
                dr = (SqlDataReader)idb.ReturnReader(pageSql);
                while (dr.Read())
                {
                    WH_Material wH_Material = new WH_Material();
                    if (dr["MD_ID"] != DBNull.Value) wH_Material.MD_ID = Convert.ToDecimal(dr["MD_ID"]);
                    if (dr["MD_MCode"] != DBNull.Value) wH_Material.MD_MCode = Convert.ToString(dr["MD_MCode"]);
                    if (dr["MD_Name"] != DBNull.Value) wH_Material.MD_Name = Convert.ToString(dr["MD_Name"]);
                    if (dr["MD_Spec"] != DBNull.Value) wH_Material.MD_Spec = Convert.ToString(dr["MD_Spec"]);
                    if (dr["MD_Barcode"] != DBNull.Value) wH_Material.MD_Barcode = Convert.ToString(dr["MD_Barcode"]);
                    if (dr["MD_Group"] != DBNull.Value) wH_Material.MD_Group = Convert.ToString(dr["MD_Group"]);
                    if (dr["MD_iType"] != DBNull.Value) wH_Material.MD_iType = Convert.ToString(dr["MD_iType"]);
                    if (dr["MD_PriceList"] != DBNull.Value) wH_Material.MD_PriceList = Convert.ToDecimal(dr["MD_PriceList"]);
                    if (dr["MD_Unit"] != DBNull.Value) wH_Material.MD_Unit = Convert.ToString(dr["MD_Unit"]);
                    if (dr["MD_Num"] != DBNull.Value) wH_Material.MD_Num = Convert.ToDecimal(dr["MD_Num"]);
                    if (dr["MD_LNum"] != DBNull.Value) wH_Material.MD_LNum = Convert.ToDecimal(dr["MD_LNum"]);
                    if (dr["MD_TNum"] != DBNull.Value) wH_Material.MD_TNum = Convert.ToDecimal(dr["MD_TNum"]);
                    if (dr["MD_Factory"] != DBNull.Value) wH_Material.MD_Factory = Convert.ToString(dr["MD_Factory"]);
                    if (dr["MD_Units"] != DBNull.Value) wH_Material.MD_Units = Convert.ToString(dr["MD_Units"]);
                    if (dr["MD_Bak"] != DBNull.Value) wH_Material.MD_Bak = Convert.ToString(dr["MD_Bak"]);
                    if (dr["Stat"] != DBNull.Value) wH_Material.Stat = Convert.ToInt32(dr["Stat"]);
                    if (dr["CreateDate"] != DBNull.Value) wH_Material.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
                    if (dr["UpdateDate"] != DBNull.Value) wH_Material.UpdateDate = Convert.ToDateTime(dr["UpdateDate"]);
                    if (dr["DeleteDate"] != DBNull.Value) wH_Material.DeleteDate = Convert.ToDateTime(dr["DeleteDate"]);
                    ret.Add(wH_Material);
                }
            }
            catch (System.Exception ex) { throw ex; }
            finally { if (dr != null) { dr.Close(); } }
            return ret;
        }


        public List<WH_Material> GetListByWhereExtend(string strCondition, string RType, bool IsContainWareHouse)
        {
            ADOWH_Warehouse wareHouse = new ADOWH_Warehouse();

            List<WH_Material> ret = new List<WH_Material>();
            string sql = strCondition;
            //if (!string.IsNullOrEmpty(strCondition))
            //{
            //    strCondition.Replace('\'', '"'); //防sql注入
            //    sql += strCondition;
            //}

            //            string pageSql = string.Format(@"SELECT * FROM (SELECT row_number()over(order by MD_ID) as RN, A.*  from ({0})A) B
            //    WHERE RN>{1} AND RN<={2}
            //", sql, (CurrentPage - 1) * PageSize, CurrentPage * PageSize);


            SqlDataReader dr = null;
            try
            {
                dr = (SqlDataReader)idb.ReturnReader(sql);
                while (dr.Read())
                {
                    WH_Material wH_Material = new WH_Material();
                    //if (dr["MD_ID"] != DBNull.Value) wH_Material.MD_ID = Convert.ToDecimal(dr["MD_ID"]);
                    if (dr["MD_MCode"] != DBNull.Value) wH_Material.MD_MCode = Convert.ToString(dr["MD_MCode"]);
                    if (dr["MD_Name"] != DBNull.Value) wH_Material.MD_Name = Convert.ToString(dr["MD_Name"]);
                    if (dr["MD_Spec"] != DBNull.Value) wH_Material.MD_Spec = Convert.ToString(dr["MD_Spec"]);
                    //if (dr["MD_Barcode"] != DBNull.Value) wH_Material.MD_Barcode = Convert.ToString(dr["MD_Barcode"]);
                    //if (dr["MD_Group"] != DBNull.Value) wH_Material.MD_Group = Convert.ToString(dr["MD_Group"]);
                    //if (dr["MD_iType"] != DBNull.Value) wH_Material.MD_iType = Convert.ToString(dr["MD_iType"]);
                    if (dr["MD_PriceList"] != DBNull.Value) wH_Material.MD_PriceList = Convert.ToDecimal(dr["MD_PriceList"]);
                    if (dr["MD_Unit"] != DBNull.Value) wH_Material.MD_Unit = Convert.ToString(dr["MD_Unit"]);
                    if (dr["MD_Num"] != DBNull.Value) wH_Material.MD_Num = Convert.ToDecimal(dr["MD_Num"]);
                    //if (dr["MD_LNum"] != DBNull.Value) wH_Material.MD_LNum = Convert.ToDecimal(dr["MD_LNum"]);
                    //if (dr["MD_TNum"] != DBNull.Value) wH_Material.MD_TNum = Convert.ToDecimal(dr["MD_TNum"]);
                    //if (dr["MD_Factory"] != DBNull.Value) wH_Material.MD_Factory = Convert.ToString(dr["MD_Factory"]);
                    //if (dr["MD_Units"] != DBNull.Value) wH_Material.MD_Units = Convert.ToString(dr["MD_Units"]);
                    //if (dr["MD_Bak"] != DBNull.Value) wH_Material.MD_Bak = Convert.ToString(dr["MD_Bak"]);

                    if (IsContainWareHouse)
                    {
                        //扩展属性
                        if (dr["Storage_Count"] != DBNull.Value) wH_Material.Storage_Count = long.Parse(dr["Storage_Count"].ToString());
                        if (dr["Storage_WarehouseCode"] != DBNull.Value) wH_Material.Storage_Code = Convert.ToString(dr["Storage_WarehouseCode"]);
                        if (dr["Storage_WarehouseNo"] != DBNull.Value) wH_Material.Storage_WarehouseNo = Convert.ToString(dr["Storage_WarehouseNo"]);
                        if (dr["Warehouse_Name"] != DBNull.Value) wH_Material.Storage_WarehouseNoName = Convert.ToString(dr["Warehouse_Name"]);
                        if (dr["Storage_Company"] != DBNull.Value) wH_Material.Storage_Company = Convert.ToString(dr["Storage_Company"]);
                        if (dr["Storage_CompanyCode"] != DBNull.Value) wH_Material.Storage_CompanyCode = Convert.ToString(dr["Storage_CompanyCode"]);

                        if (!string.IsNullOrEmpty(wH_Material.Storage_Code))
                        {
                            var li = wareHouse.GetListByWhere(" and Warehouse_Code='" + wH_Material.Storage_Code + "'");
                            if (li.Count > 0)
                            {
                                wH_Material.Storage_Name = li.FirstOrDefault().Warehouse_Name;
                            }
                        }
                    }

                    ret.Add(wH_Material);
                }
            }
            catch (System.Exception ex) { throw ex; }
            finally { if (dr != null) { dr.Close(); } }
            return ret;
        }


        public List<WH_Material> GetASListByWhereExtend(string strCondition)
        {
            List<WH_Material> ret = new List<WH_Material>();
            string sql = @"SELECT AI.*,isnull(WHS.Storage_Count,0) AS Storage_Count,WHS.Storage_Code,WHS.Storage_WarehouseNo FROM Asset_Infomation AI
                            LEFT JOIN WH_Storage WHS
                            ON AI.AInfo_Code=WHS.Storage_MaterielCode
                            WHERE 1=1 AND ((AI.Stat is null) or (AI.Stat=0) )  ";
            if (!string.IsNullOrEmpty(strCondition))
            {
                strCondition.Replace('\'', '"'); //防sql注入
                sql += strCondition;
            }

            //            string pageSql = string.Format(@"SELECT * FROM (SELECT row_number()over(order by MD_ID) as RN, A.*  from ({0})A) B
            //    WHERE RN>{1} AND RN<={2}
            //", sql, (CurrentPage - 1) * PageSize, CurrentPage * PageSize);


            SqlDataReader dr = null;
            try
            {
                dr = (SqlDataReader)idb.ReturnReader(sql);
                while (dr.Read())
                {
                    WH_Material wH_Material = new WH_Material();
                    if (dr["AInfo_ID"] != DBNull.Value) wH_Material.MD_ID = Convert.ToDecimal(dr["AInfo_ID"]);
                    if (dr["AInfo_Code"] != DBNull.Value) wH_Material.MD_MCode = Convert.ToString(dr["AInfo_Code"]);
                    if (dr["AInfo_Name"] != DBNull.Value) wH_Material.MD_Name = Convert.ToString(dr["AInfo_Name"]);
                    if (dr["AInfo_Spec"] != DBNull.Value) wH_Material.MD_Spec = Convert.ToString(dr["AInfo_Spec"]);
                    if (dr["AInfo_Type"] != DBNull.Value) wH_Material.MD_Group = Convert.ToString(dr["AInfo_Type"]);
                    if (dr["AInfo_iType"] != DBNull.Value) wH_Material.MD_iType = Convert.ToString(dr["AInfo_iType"]);
                    if (dr["AInfo_Price"] != DBNull.Value) wH_Material.MD_PriceList = Convert.ToDecimal(dr["AInfo_Price"]);

                    //扩展属性
                    if (dr["Storage_Count"] != DBNull.Value) wH_Material.Storage_Count = long.Parse(dr["Storage_Count"].ToString());
                    if (dr["Storage_Count"] != DBNull.Value) wH_Material.Storage_Count = long.Parse(dr["Storage_Count"].ToString());
                    if (dr["Storage_Code"] != DBNull.Value) wH_Material.Storage_Code = Convert.ToString(dr["Storage_Code"]);
                    if (dr["Storage_WarehouseNo"] != DBNull.Value) wH_Material.Storage_WarehouseNo = Convert.ToString(dr["Storage_WarehouseNo"]);

                    ret.Add(wH_Material);
                }
            }
            catch (System.Exception ex) { throw ex; }
            finally { if (dr != null) { dr.Close(); } }
            return ret;
        }

    }
}
