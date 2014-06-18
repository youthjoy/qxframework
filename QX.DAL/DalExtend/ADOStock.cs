using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using QX.Model;
using QX.DataAcess;

namespace QX.DAL
{
    public class ADOStock
    {
        public IDBOperator idb = DBOperator.GetInstance();

        /// <summary>
        /// 根据供应商获取所有明细列表
        /// </summary>
        /// <param name="code"></param>
        /// <returns></returns>
        public List<WH_MVItem> GetMaterialListByVendor(string code,string status)
        {
            List<WH_MVItem> ret = new List<WH_MVItem>();
            string sql = @"select b.* from WH_Movement a,
                            WH_MVItem b
                            where a.MV_RecordCode=b.MVI_RCode
                            and a.MV_RecordCode='{0}' and a.MV_MType='{1}' ";
            sql = string.Format(sql, code,status);
            SqlDataReader dr = (SqlDataReader)idb.ReturnReader(sql);
            while (dr.Read())
            {
                WH_MVItem wH_MVItem = new WH_MVItem();
                if (dr["MVI_ID"] != DBNull.Value) wH_MVItem.MVI_ID = Convert.ToInt32(dr["MVI_ID"]);
                if (dr["MVI_RCode"] != DBNull.Value) wH_MVItem.MVI_RCode = Convert.ToString(dr["MVI_RCode"]);
                if (dr["MVI_Type"] != DBNull.Value) wH_MVItem.MVI_Type = Convert.ToString(dr["MVI_Type"]);
                if (dr["MVI_Code"] != DBNull.Value) wH_MVItem.MVI_Code = Convert.ToString(dr["MVI_Code"]);
                if (dr["MVI_MCode"] != DBNull.Value) wH_MVItem.MVI_MCode = Convert.ToString(dr["MVI_MCode"]);
                if (dr["MVI_Spec"] != DBNull.Value) wH_MVItem.MVI_Spec = Convert.ToString(dr["MVI_Spec"]);
                if (dr["MVI_Sup"] != DBNull.Value) wH_MVItem.MVI_Sup = Convert.ToString(dr["MVI_Sup"]);
                if (dr["MVI_Num"] != DBNull.Value) wH_MVItem.MVI_Num = Convert.ToInt32(dr["MVI_Num"]);
                if (dr["MVI_Unit"] != DBNull.Value) wH_MVItem.MVI_Unit = Convert.ToString(dr["MVI_Unit"]);
                if (dr["MVI_MDPrice"] != DBNull.Value) wH_MVItem.MVI_MDPrice = Convert.ToDecimal(dr["MVI_MDPrice"]);
                if (dr["MVI_CostStuffCode"] != DBNull.Value) wH_MVItem.MVI_CostStuffCode = Convert.ToString(dr["MVI_CostStuffCode"]);
                if (dr["MVI_CostStuff"] != DBNull.Value) wH_MVItem.MVI_CostStuff = Convert.ToString(dr["MVI_CostStuff"]);
                if (dr["MVI_CostDeptCode"] != DBNull.Value) wH_MVItem.MVI_CostDeptCode = Convert.ToString(dr["MVI_CostDeptCode"]);
                if (dr["MVI_CostDept"] != DBNull.Value) wH_MVItem.MVI_CostDept = Convert.ToString(dr["MVI_CostDept"]);
                if (dr["MVI_CostEqu"] != DBNull.Value) wH_MVItem.MVI_CostEqu = Convert.ToString(dr["MVI_CostEqu"]);
                if (dr["MVI_CostDate"] != DBNull.Value) wH_MVItem.MVI_CostDate = Convert.ToDateTime(dr["MVI_CostDate"]);
                if (dr["Stat"] != DBNull.Value) wH_MVItem.Stat = Convert.ToInt32(dr["Stat"]);
                if (dr["WHI_ID"] != DBNull.Value) wH_MVItem.WHI_ID = Convert.ToString(dr["WHI_ID"]);
                ret.Add(wH_MVItem);
            }
            dr.Close();
            return ret;


        }
    }
}
