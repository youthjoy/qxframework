using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QX.DAL
{
    public partial class ADOBse_Dict
    {
        /// <summary>
        /// 返回当前表最大值
        /// </summary>
        /// <param name="columnName"></param>
        /// <returns>最小返回0</returns>
        public object GetMax(string columnName,string key)
        {
            string sql = string.Format(@"SELECT
	isnull(Max({0}),0)
FROM
	Bse_Dict WHERE 1=1 AND Dict_Key='{1}'", columnName,key);

            return idb.ReturnValue(sql);
        }
    }
}
