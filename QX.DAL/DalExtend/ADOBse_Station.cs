using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace QX.DAL
{
    public partial class ADOBse_Station
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="paras"></param>
        /// <returns></returns>
        public DataTable GetStationsData(Dictionary<string,object> paras)
        {
            List<SqlParameter> list = new List<SqlParameter>();

            foreach (var d in paras)
            {
                SqlParameter p = new SqlParameter("@"+d.Key,d.Value);
                list.Add(p);
            }

            DataTable table=idb.RunProcReturnDatatable("qx_data_stations", list.ToArray());

            return table;
        }

        /// <summary>
        /// 权限过滤数据
        /// </summary>
        /// <param name="paras"></param>
        /// <returns></returns>
        public DataTable GetStationsDataWithPermission(Dictionary<string, object> paras)
        {
            List<SqlParameter> list = new List<SqlParameter>();

            foreach (var d in paras)
            {
                SqlParameter p = new SqlParameter("@" + d.Key, d.Value);
                list.Add(p);
            }

            DataTable table = idb.RunProcReturnDatatable("qx_data_stations", list.ToArray());

            return table;
        }

        

    }
}
