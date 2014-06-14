using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace QX.HtmlHelperLib.BLL
{
    public partial class Bll_Sys_Config_Refer
    {
        public DataTable ListDataByCode(string TableName, string filter,string searchFilter)
        {
            if (!string.IsNullOrEmpty(filter))
            {
                filter = " AND " + filter;
            }
            if (!string.IsNullOrEmpty(searchFilter))
            {
                searchFilter = " AND " + searchFilter;
            }
            string sql = "SELECT * FROM " + TableName + " WHERE (Stat is null or Stat=0) " + filter+searchFilter;
            return instance.idb.ReturnDataTable(sql);
        }

        public DataTable ListBySql(string sql)
        {
            return instance.idb.ReturnDataTable(sql);
        }
    }
}
