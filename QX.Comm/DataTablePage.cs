using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Data;
using System.Linq.Dynamic;

namespace QX.Comm
{
    public static class DataTablePage
    {
        /// <summary>
        /// JqGrid通用分页序列化
        /// </summary>
        /// <param name="dt"></param>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <param name="totalCount"></param>
        /// <returns></returns>
        public static string JsonForJqgrid(DataTable dt, int pageIndex, int pageSize, int totalCount)
        {
            StringBuilder jsonBuilder = new StringBuilder();
            int total = 0;
            int page = totalCount / pageSize;
            total = totalCount > pageSize ? totalCount / pageSize : 1;
            if (totalCount>pageSize)
            {
                if (totalCount % pageSize > 0)
                {
                    total = total + 1;
                }
            }
            if (totalCount==0)
            {
                total = 0;
                pageIndex = 0;
            }
           
            jsonBuilder.Append("{\"Page\":" + pageIndex + ",\"Total\":" + total + ",\"Records\":" + totalCount + ",\"Rows\":");
            jsonBuilder.Append(JsonConvert.SerializeObject(dt, new DataTableConverter(), new JsonDateConverter("yyyy-MM-dd")));
            jsonBuilder.Append("}");
            return jsonBuilder.ToString();
        }

        /// <summary>
        /// Jqgrid通用分页
        /// </summary>
        /// <param name="dt"></param>
        /// <param name="PageIndex"></param>
        /// <param name="PageSize"></param>
        /// <returns></returns>
        public static DataTable GetPagedTable(DataTable dt, int PageIndex, int PageSize)
        {
            if (PageIndex == 0)
                return dt;
            DataTable newdt = dt.Clone();
            //newdt.Clear();
            int rowbegin = (PageIndex - 1) * PageSize;
            int rowend = PageIndex * PageSize;

            if (rowbegin >= dt.Rows.Count)
                return newdt;

            if (rowend > dt.Rows.Count)
                rowend = dt.Rows.Count;
            for (int i = rowbegin; i <= rowend - 1; i++)
            {
                DataRow newdr = newdt.NewRow();
                DataRow dr = dt.Rows[i];
                foreach (DataColumn column in dt.Columns)
                {
                    newdr[column.ColumnName] = dr[column.ColumnName];
                }
                newdt.Rows.Add(newdr);
            }
            return newdt;
        }




    }

    /// <summary>
    /// DataTable Helper扩展类
    /// </summary>
    public static class DynQueryHeplerExstion
    {
        /// <summary>
        /// 动态查询DataTable
        /// </summary>
        /// <param name="ds"></param>
        /// <param name="Experssion"></param>
        /// <returns></returns>
        public static DataTable DynQuery(this DataTable ds , string Experssion)
        {
            DataRow[] rows = ds.Select(Experssion);
            DataTable newDt=ds.Clone();
            foreach (DataRow item in rows)
            {
                newDt.ImportRow(item);
            }
            return newDt;
        }

        public static IQueryable<T> DynQuery<T>(this IQueryable<T> list, string Experssion)
        {
            //list.Provider.CreateQuery<T>(
            var newList = list.Where(Experssion);
            return newList;
        }

        public static string ToJqGridData(this DataTable dt, int pageIndex, int pageSize, int totalCount)
        {
            StringBuilder jsonBuilder = new StringBuilder();
            int total = 0;
            int page = totalCount / pageSize;
            total = totalCount > pageSize ? totalCount / pageSize : 1;
            if (totalCount > pageSize)
            {
                if (totalCount % pageSize > 0)
                {
                    total = total + 1;
                }
            }
            if (totalCount == 0)
            {
                total = 0;
                pageIndex = 0;
            }

            jsonBuilder.Append("{\"Page\":" + pageIndex + ",\"Total\":" + total + ",\"Records\":" + totalCount + ",\"Rows\":");
            jsonBuilder.Append(JsonConvert.SerializeObject(dt, new DataTableConverter(), new JsonDateConverter("yyyy-MM-dd")));
            jsonBuilder.Append("}");
            return jsonBuilder.ToString();
        }


        /// <summary>
        /// Jqgrid通用分页
        /// </summary>
        /// <param name="dt"></param>
        /// <param name="PageIndex"></param>
        /// <param name="PageSize"></param>
        /// <returns></returns>
        public static DataTable ToPagedTable(this DataTable dt, int PageIndex, int PageSize)
        {
            if (PageIndex == 0)
                return dt;
            DataTable newdt = dt.Clone();
            //newdt.Clear();
            int rowbegin = (PageIndex - 1) * PageSize;
            int rowend = PageIndex * PageSize;

            if (rowbegin >= dt.Rows.Count)
                return newdt;

            if (rowend > dt.Rows.Count)
                rowend = dt.Rows.Count;
            for (int i = rowbegin; i <= rowend - 1; i++)
            {
                DataRow newdr = newdt.NewRow();
                DataRow dr = dt.Rows[i];
                foreach (DataColumn column in dt.Columns)
                {
                    newdr[column.ColumnName] = dr[column.ColumnName];
                }
                newdt.Rows.Add(newdr);
            }
            return newdt;
        }
    }

}
