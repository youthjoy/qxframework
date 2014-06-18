using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using QX.DataAcess;

namespace QX.DAL
{
    public class GetMaxHandler
    {
        private  IDBOperator idb = DBOperator.GetInstance();

        /// <summary>
        /// 返回当前表最大值
        /// </summary>
        /// <param name="columnName"></param>
        /// <returns>最小返回0</returns>
        public  object GetMax(string columnName,string tablename)
        {
            string sql = string.Format(@"SELECT
	isnull(Max({0}),0)
FROM
	{1} WHERE 1=1 ", columnName, tablename);

            return idb.ReturnValue(sql);
        }
    }
}
