namespace QX.HtmlHelperLib
{

    using QX.DeskConfig.DAL;
    using QX.DeskConfig.Model;
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Data.SqlClient;
    using System.Linq;
    using System.Runtime.CompilerServices;
    using System.Text;
    using System.Web.Mvc;
    using QX.Config;

    public static class DeskTopHelpler
    {

        private static string CreateHtml(string Location)
        {
            StringBuilder builder = new StringBuilder();
            string str = "<li><a href='{0}'>{1}：({2})</a></li>";
            //Bll_Sys_DesktopConfig config = new Bll_Sys_DesktopConfig();
            ADOComm BLL_Comm = new ADOComm();
            ADOSys_DesktopConfig config = new ADOSys_DesktopConfig();
            List<Sys_DesktopConfig> source = new List<Sys_DesktopConfig>();
            source = (from o in config.GetListByWhere(" AND SC_AreaPCode='" + Location + "' ")
                orderby o.SC_Order
                select o).ToList<Sys_DesktopConfig>();
            var enumerable = from a in source
                group a by new { SC_Group = a.SC_Group } into g
                select new { SC_Group = g.Key.SC_Group };
            if (enumerable.Count() > 0)
            {
                using (var enumerator = enumerable.GetEnumerator())
                {
                    Func<Sys_DesktopConfig, bool> predicate = null;
                    var d = enumerator.Current;
                    while (enumerator.MoveNext())
                    {
                        try
                        {
                            d = enumerator.Current;
                            if (predicate == null)
                            {
                                predicate = o => o.SC_Group == d.SC_Group;
                            }
                            List<Sys_DesktopConfig> list2 = source.Where<Sys_DesktopConfig>(predicate).ToList<Sys_DesktopConfig>();
                            if (list2.Count > 0)
                            {
                                if (!string.IsNullOrEmpty(d.SC_Group))
                                {
                                    builder.AppendFormat("<fieldset> <legend>{0}</legend>", d.SC_Group);
                                }
                                foreach (Sys_DesktopConfig config2 in list2)
                                {
                                    string template = !string.IsNullOrEmpty(config2.SC_Loop) ? config2.SC_Loop : str;
                                    string str3 = !string.IsNullOrEmpty(config2.SC_Loop) ? config2.SC_Loop : str;
                                    template = str3;

                                    string newValue = !string.IsNullOrEmpty(config2.SC_URL) ? config2.SC_URL : "#";
                                    if (!string.IsNullOrEmpty(config2.SC_SQL))
                                    {
                                        string str5 = config2.SC_SQL;
                                        DataTable table = new DataTable();
                                        if (str5.ToLower().Contains("qx_proc"))
                                        {
                                            Dictionary<string, string> dictionary = ParseProc(str5);
                                            if (dictionary.Count > 0)
                                            {
                                                SqlParameter[] parameterArray = new SqlParameter[dictionary.Count - 1];
                                                int index = 0;
                                                foreach (KeyValuePair<string, string> pair in dictionary)
                                                {
                                                    if (pair.Key != "qx_proc")
                                                    {
                                                        parameterArray[index] = new SqlParameter { ParameterName = "@" + pair.Key, Value = pair.Value, SqlDbType = SqlDbType.VarChar, Size = 50 };
                                                        index++;
                                                    }
                                                }
                                                table = BLL_Comm.ExcuteProc(dictionary["qx_proc"], (IDbDataParameter[])parameterArray);
                                            }
                                        }
                                        else
                                        {
                                            table = BLL_Comm.idb.ReturnDataTable(str5);
                                        }
                                        if (table.Rows.Count > 0)
                                        {
                                            for (int i = 0; i < table.Rows.Count; i++)
                                            {
                                                decimal result = 0M;
                                                decimal.TryParse(table.Rows[i][0].ToString(), out result);
                                                string str6 = table.Rows[i][0].ToString();
                                                if (!string.IsNullOrEmpty(config2.SC_Filter))
                                                {
                                                    decimal num4 = 0M;
                                                    decimal.TryParse(config2.SC_Filter.Substring(1, config2.SC_Filter.Length - 1), out num4);
                                                    if (config2.SC_Filter.Contains(">"))
                                                    {
                                                        if (num4 < result)
                                                        {
                                                            str6 = string.Format("<font color='{0}'>{1}</font>", config2.SC_Color, str6);
                                                        }
                                                    }
                                                    else if (num4 > result)
                                                    {
                                                        str6 = string.Format("<font color='{0}'>{1}</font>", config2.SC_Color, str6);
                                                    }
                                                }
                                                //如果名字为空，则取数据库里面对应的列的数据作为名字
                                                if (string.IsNullOrEmpty(config2.SC_AreaName))
                                                {
                                                    if (table.Rows[i]["ColName"] != null)
                                                    {
                                                        str3 = template.Replace("{0}", newValue).Replace("{1}", table.Rows[i]["ColName"].ToString()).Replace("{2}", str6);
                                                        builder.AppendLine(str3);
                                                    }
                                                }
                                                else
                                                {
                                                    str3 = template.Replace("{0}", newValue).Replace("{1}", config2.SC_AreaName).Replace("{2}", str6);
                                                    builder.AppendLine(str3);
                                                }
                                            }
                                        }
                                    }
                                    else
                                    {
                                        str3 = str3.Replace("{0}", newValue).Replace("{1}", config2.SC_AreaName);
                                        builder.AppendLine(str3);
                                    }
                                }
                                if (!string.IsNullOrEmpty(d.SC_Group))
                                {
                                    builder.AppendLine("</fieldset>");
                                }
                            }
                        }
                        catch (Exception ex)
                        { 
                            
                        }
                    }//whild
                }
            }
            return builder.ToString();
        }

        public static string DeskTop(this HtmlHelper hepler, DeskTopLocation location)
        {
            return CreateHtml(location.ToString());
        }

        private static string Left()
        {
            return "";
        }

        private static Dictionary<string, string> ParseProc(string str)
        {
            Dictionary<string, string> dictionary = new Dictionary<string, string>();
            if (!string.IsNullOrEmpty(str))
            {
                string[] source = str.Split(new char[] { ';' });
                if ((source.Count<string>() <= 0) || (source.Count<string>() != 2))
                {
                    return dictionary;
                }
                string[] strArray2 = source[0].Split(new char[] { ':' });
                string[] strArray3 = source[1].Split(new char[] { ':' });
                dictionary.Add(strArray2[0], strArray2[1]);
                if (strArray3.Count<string>() <= 0)
                {
                    return dictionary;
                }
                Dictionary<string, string> dictionary2 = PaseProcParams(strArray3[1]);
                if (dictionary2.Count <= 0)
                {
                    return dictionary;
                }
                foreach (KeyValuePair<string, string> pair in dictionary2)
                {
                    string str2 = pair.Value.Replace("{UserId}", SessionConfig.UserId());
                    dictionary.Add(pair.Key, str2);
                }
            }
            return dictionary;
        }

        private static string ParseSql(string SQL)
        {
            SQL = SQL.Replace("{UserId}", SessionConfig.UserId());
            return SQL;
        }

        private static Dictionary<string, string> PaseProcParams(string str)
        {
            Dictionary<string, string> dictionary = new Dictionary<string, string>();
            if (!string.IsNullOrEmpty(str))
            {
                string[] source = str.Split(new char[] { ',' });
                if (source.Count<string>() <= 0)
                {
                    return dictionary;
                }
                for (int i = 0; i < source.Count<string>(); i++)
                {
                    if (source[i].Contains<char>('='))
                    {
                        string[] strArray2 = source[i].Split(new char[] { '=' });
                        if (strArray2.Count<string>() > 0)
                        {
                            dictionary.Add(strArray2[0], strArray2[1]);
                        }
                    }
                }
            }
            return dictionary;
        }

        private static string Right()
        {
            return "";
        }

        private static string Top()
        {
            return "";
        }
    }
}

