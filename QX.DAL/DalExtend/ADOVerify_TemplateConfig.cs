using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using QX.Model;
using QX.DataAcess;
using System.Data.SqlClient;
namespace QX.DAL
{
    public partial class ADOVerify_TemplateConfig
    {

        public List<Verify_TemplateConfig> GetTemplateConfigList(string strCondition)
        {
            List<Verify_TemplateConfig> ret = new List<Verify_TemplateConfig>();
            string sql = @"SELECT  VT_ID,VT_Key,VT_Template_Code,VT_VerifyNode_Code,VT_VerifyNode_Name,Flag,VT_VerifyNode_Order,VT_VerifyNode_Back,vtc.Stat
FROM Verify_TemplateConfig  vtc
JOIN Verify_Users vu on vu.VU_VerifyNode_Code =vtc.VT_VerifyNode_Code
WHERE 1=1 AND ((vtc.Stat is null) or (vtc.Stat=0) ) ";
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
                    Verify_TemplateConfig verify_TemplateConfig = new Verify_TemplateConfig();
                    if (dr["VT_ID"] != DBNull.Value) verify_TemplateConfig.VT_ID = Convert.ToDecimal(dr["VT_ID"]);
                    if (dr["VT_Key"] != DBNull.Value) verify_TemplateConfig.VT_Key = Convert.ToString(dr["VT_Key"]);
                    if (dr["VT_Template_Code"] != DBNull.Value) verify_TemplateConfig.VT_Template_Code = Convert.ToString(dr["VT_Template_Code"]);
                    if (dr["VT_VerifyNode_Code"] != DBNull.Value) verify_TemplateConfig.VT_VerifyNode_Code = Convert.ToString(dr["VT_VerifyNode_Code"]);
                    if (dr["VT_VerifyNode_Name"] != DBNull.Value) verify_TemplateConfig.VT_VerifyNode_Name = Convert.ToString(dr["VT_VerifyNode_Name"]);
                    if (dr["Flag"] != DBNull.Value) verify_TemplateConfig.Flag = Convert.ToInt32(dr["Flag"]);
                    if (dr["VT_VerifyNode_Order"] != DBNull.Value) verify_TemplateConfig.VT_VerifyNode_Order = Convert.ToInt32(dr["VT_VerifyNode_Order"]);
                    if (dr["VT_VerifyNode_Back"] != DBNull.Value) verify_TemplateConfig.VT_VerifyNode_Back = Convert.ToString(dr["VT_VerifyNode_Back"]);
                    if (dr["Stat"] != DBNull.Value) verify_TemplateConfig.Stat = Convert.ToInt32(dr["Stat"]);
                    ret.Add(verify_TemplateConfig);
                }
            }
            catch (System.Exception ex) { throw ex; }
            finally { if (dr != null) { dr.Close(); } }
            return ret;
        }
    }
}
