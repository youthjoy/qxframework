using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Reflection;

namespace QX.Comm
{
    public class ConvertEx
    {
        
        /// <summary>
        /// 将List转换为DataTable
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="list"></param>
        /// <returns></returns>
        public static DataTable ListToTable<T>(List<T> list)
        {

            DataTable table = new DataTable();

            if (list.Count > 0)
            {

                PropertyInfo[] properties = list[0].GetType().GetProperties();

                List<string> columns = new List<string>();

                foreach (PropertyInfo pi in properties)
                {

                    table.Columns.Add(pi.Name);

                    columns.Add(pi.Name);

                }

                foreach (T item in list)
                {

                    object[] cells = getValues(columns, item);

                    table.Rows.Add(cells);

                }

            }

            return table;

        }

        private static object[] getValues(List<string> columns, object instance)
        {

            object[] ret = new object[columns.Count];

            for (int n = 0; n < ret.Length; n++)
            {

                PropertyInfo pi = instance.GetType().GetProperty(columns[n]);

                object value = pi.GetValue(instance, null);

                ret[n] = value;

            }

            return ret;

        }

    }

    public static class ConvertExstion
    {
        public static DataTable ToDataTable<T>(this List<T> list)
        {
            DataTable table = new DataTable();

            if (list.Count > 0)
            {

                PropertyInfo[] properties = list[0].GetType().GetProperties();

                List<string> columns = new List<string>();

                foreach (PropertyInfo pi in properties)
                {

                    table.Columns.Add(pi.Name);

                    columns.Add(pi.Name);

                }

                foreach (T item in list)
                {

                    object[] cells = getValues(columns, item);

                    table.Rows.Add(cells);

                }

            }

            return table;
        }

        private static object[] getValues(List<string> columns, object instance)
        {

            object[] ret = new object[columns.Count];

            for (int n = 0; n < ret.Length; n++)
            {

                PropertyInfo pi = instance.GetType().GetProperty(columns[n]);

                object value = pi.GetValue(instance, null);

                ret[n] = value;

            }

            return ret;

        }



    }


}
