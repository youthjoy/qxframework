using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using QX.Model;
using System.Data.SqlClient;
using System.Data;

namespace QX.DAL
{
    public partial class ADOSys_UserPermission
    {
        /// <summary>
        /// 获取用户权限点列表
        /// </summary>
        /// <param name="UserId">用户编码</param>
        /// <returns>用户权限点列表（含有权限和没有权限的所有节点）</returns>
        public List<Sys_UserPermission> GetUserPerimission(string UserId)
        {
            List<Sys_UserPermission> ret = new List<Sys_UserPermission>();
            string sql = @"SELECT  PU_ID,PU_Code,PU_UserCode,PU_FunName,PU_FunCode,PU_FunPCode,PU_UDef1,PU_UDef2,PU_UDef3,PU_IsCheck,Fun_UDef1,Fun_iType
                            FROM Sys_UserPermission p,Sys_Function f where
                            ISNULL(p.Stat,0)=0 AND ISNULL(f.Stat,0)=0
                            and f.Fun_Code=p.PU_FunCode
                            and p.PU_UserCode='" + UserId + "' ";
            SqlDataReader dr = null;
            try
            {                
                dr = (SqlDataReader) idb.ReturnReader(sql);
                while (dr.Read())
                {
                    Sys_UserPermission sys_UserPermission = new Sys_UserPermission();
                    if (dr["PU_ID"] != DBNull.Value) sys_UserPermission.PU_ID = Convert.ToDecimal(dr["PU_ID"]);
                    if (dr["PU_Code"] != DBNull.Value) sys_UserPermission.PU_Code = Convert.ToString(dr["PU_Code"]);
                    if (dr["PU_UserCode"] != DBNull.Value) sys_UserPermission.PU_UserCode = Convert.ToString(dr["PU_UserCode"]);
                    if (dr["PU_FunName"] != DBNull.Value) sys_UserPermission.PU_FunName = Convert.ToString(dr["PU_FunName"]);
                    if (dr["PU_FunCode"] != DBNull.Value) sys_UserPermission.PU_FunCode = Convert.ToString(dr["PU_FunCode"]);
                    if (dr["PU_FunPCode"] != DBNull.Value) sys_UserPermission.PU_FunPCode = Convert.ToString(dr["PU_FunPCode"]);
                    if (dr["PU_UDef1"] != DBNull.Value) sys_UserPermission.PU_UDef1 = Convert.ToString(dr["PU_UDef1"]);
                    if (dr["PU_UDef2"] != DBNull.Value) sys_UserPermission.PU_UDef2 = Convert.ToString(dr["PU_UDef2"]);
                    if (dr["PU_UDef3"] != DBNull.Value) sys_UserPermission.PU_UDef3 = Convert.ToString(dr["PU_UDef3"]);
                    if (dr["PU_IsCheck"] != DBNull.Value) sys_UserPermission.PU_IsCheck = Convert.ToString(dr["PU_IsCheck"]);
                    //if (dr["Stat"] != DBNull.Value) sys_UserPermission.Stat = Convert.ToInt32(dr["Stat"]);
                    //if (dr["CreateDate"] != DBNull.Value) sys_UserPermission.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
                    //if (dr["UpdateDate"] != DBNull.Value) sys_UserPermission.UpdateDate = Convert.ToDateTime(dr["UpdateDate"]);
                    //if (dr["DeleteDate"] != DBNull.Value) sys_UserPermission.DeleteDate = Convert.ToDateTime(dr["DeleteDate"]);
                    if (dr["Fun_UDef1"] != DBNull.Value) sys_UserPermission.Fun_UDef1 = Convert.ToString(dr["Fun_UDef1"]);
                    if (dr["Fun_iType"] != DBNull.Value) sys_UserPermission.Fun_iType = Convert.ToString(dr["Fun_iType"]);
                    ret.Add(sys_UserPermission);
                }
            }
            catch (System.Exception ex) { throw ex; }
            finally { if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); } }
            return ret;
        }

        /// <summary>
        /// hack  Fun_Name as PU_FunName||Fun_PCode as PU_FunPCode
        /// </summary>
        /// <param name="strCondition"></param>
        /// <returns></returns>
        public List<Sys_UserPermission> GetUserPerimissionEx(string strCondition)
        {
            List<Sys_UserPermission> ret = new List<Sys_UserPermission>();
            string sql = @"SELECT  PU_ID,PU_Code,PU_UserCode,Fun_Name as PU_FunName,PU_FunCode,Fun_PCode as PU_FunPCode,PU_UDef1,PU_UDef2,PU_UDef3,PU_IsCheck,Fun_UDef1,Fun_iType
                            FROM Sys_UserPermission p,Sys_Function f where
                            ISNULL(p.Stat,0)=0 AND ISNULL(f.Stat,0)=0
                            and f.Fun_Code=p.PU_FunCode
                            ";
            SqlDataReader dr = null;

            if (!string.IsNullOrEmpty(strCondition))
            {
                strCondition.Replace('\'', '"'); //防sql注入
                sql += strCondition;
            }

            try
            {
                dr = (SqlDataReader)idb.ReturnReader(sql);
                while (dr.Read())
                {
                    Sys_UserPermission sys_UserPermission = new Sys_UserPermission();
                    if (dr["PU_ID"] != DBNull.Value) sys_UserPermission.PU_ID = Convert.ToDecimal(dr["PU_ID"]);
                    if (dr["PU_Code"] != DBNull.Value) sys_UserPermission.PU_Code = Convert.ToString(dr["PU_Code"]);
                    if (dr["PU_UserCode"] != DBNull.Value) sys_UserPermission.PU_UserCode = Convert.ToString(dr["PU_UserCode"]);
                    if (dr["PU_FunName"] != DBNull.Value) sys_UserPermission.PU_FunName = Convert.ToString(dr["PU_FunName"]);
                    if (dr["PU_FunCode"] != DBNull.Value) sys_UserPermission.PU_FunCode = Convert.ToString(dr["PU_FunCode"]);
                    if (dr["PU_FunPCode"] != DBNull.Value) sys_UserPermission.PU_FunPCode = Convert.ToString(dr["PU_FunPCode"]);
                    if (dr["PU_UDef1"] != DBNull.Value) sys_UserPermission.PU_UDef1 = Convert.ToString(dr["PU_UDef1"]);
                    if (dr["PU_UDef2"] != DBNull.Value) sys_UserPermission.PU_UDef2 = Convert.ToString(dr["PU_UDef2"]);
                    if (dr["PU_UDef3"] != DBNull.Value) sys_UserPermission.PU_UDef3 = Convert.ToString(dr["PU_UDef3"]);
                    if (dr["PU_IsCheck"] != DBNull.Value) sys_UserPermission.PU_IsCheck = Convert.ToString(dr["PU_IsCheck"]);
                    //if (dr["Stat"] != DBNull.Value) sys_UserPermission.Stat = Convert.ToInt32(dr["Stat"]);
                    //if (dr["CreateDate"] != DBNull.Value) sys_UserPermission.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
                    //if (dr["UpdateDate"] != DBNull.Value) sys_UserPermission.UpdateDate = Convert.ToDateTime(dr["UpdateDate"]);
                    //if (dr["DeleteDate"] != DBNull.Value) sys_UserPermission.DeleteDate = Convert.ToDateTime(dr["DeleteDate"]);
                    if (dr["Fun_UDef1"] != DBNull.Value) sys_UserPermission.Fun_UDef1 = Convert.ToString(dr["Fun_UDef1"]);
                    if (dr["Fun_iType"] != DBNull.Value) sys_UserPermission.Fun_iType = Convert.ToString(dr["Fun_iType"]);

                    ret.Add(sys_UserPermission);
                }
            }
            catch (System.Exception ex) { throw ex; }
            finally { if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); } }
            return ret;
        }
    }
}
