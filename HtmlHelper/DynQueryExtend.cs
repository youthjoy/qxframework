using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;
using QX.HtmlHelperLib.DAL;
using QX.HtmlHelperLib.Model;


namespace QX.HtmlHelperLib
{
    public static class DynQueryExtend
    {
        public class MetaOper
        {
            public string groupOp { get; set; }
            public object rules { get; set; }
        }

        public class MetaRules
        {
            public string field { get; set; }
            public string op { get; set; }
            public string data { get; set; }
        }

        public static Dictionary<string, string> ReturnBuild()
        {
            Dictionary<string, string> dict = new Dictionary<string, string>();
            dict.Add("eq", "{field}='{data}'");//等于
            dict.Add("ne", "{field}!='{data}'");//不等于
            dict.Add("lt", "{field}<'{data}'");//小于
            dict.Add("le", "{field}<='{data}'");//小于等于
            dict.Add("gt", "{field}>'{data}'");//大于
            dict.Add("ge", "{field}>='{data}'");//大于等于
            dict.Add("cn", "{field} like '%{data}%'");//包含

            return dict;
        }

        public static Dictionary<string, string> ReturnBuildDict()
        {
            Dictionary<string, string> dict = new Dictionary<string, string>();
            dict.Add("eq", "{field} in ({data})");//等于
            dict.Add("ne", "{field} not in ({data})");//不等于
            //dict.Add("lt", "{field}<'{data}'");//小于
            //dict.Add("le", "{field}<='{data}'");//小于等于
            //dict.Add("gt", "{field}>'{data}'");//大于
            //dict.Add("ge", "{field}>='{data}'");//大于等于
            dict.Add("cn", "{field} in ({data}) ");//包含

            return dict;
        }

        public static Sys_Config_ListPage GetListConfig(string moduleName, out Sys_Config_ListPage M_Model, out List<Sys_Config_Fieled> D_List)
        {
            ADOSys_Config_ListPage ListInstance = new ADOSys_Config_ListPage();
            ADOSys_Config_Fieled FieledInstance = new ADOSys_Config_Fieled();
            M_Model = null;
            D_List = null;
            try
            {
                if (!string.IsNullOrEmpty(moduleName))
                {
                    //第一步：根据传入模块获取Grid配置
                    List<Sys_Config_ListPage> _ListPage = ListInstance.GetListByWhere(" AND M_ModuleCode='" +
                    moduleName + "'");
                    if (_ListPage.Count > 0)
                    {
                        M_Model = _ListPage[0];
                    }
                    //第二步：根据模块获取所有字段
                    D_List = FieledInstance.GetListByWhere(" AND D_ModuleCode='" + moduleName + "'");
                }
                else
                {
                    M_Model = null;
                    D_List = null;
                }
            }
            catch (System.Exception ex)
            {
                M_Model = null;
                D_List = null;
            }

            return M_Model;
        }

        /// <summary>
        /// 动态解析查询条件
        /// </summary>
        /// <param name="txt"></param>
        /// <param name="module"></param>
        /// <returns></returns>
        public static string BuildSearch(this string txt, string module)
        {
            var QueryLeftTree = string.Empty;
            StringBuilder strQuery = new StringBuilder();
            //Dictionary<string, string> dict = ReturnBuild();
            Dictionary<string, string> dict = new Dictionary<string, string>();
            MetaOper mod = JsonConvert.DeserializeObject<MetaOper>(txt);
            List<MetaRules> oper = JsonConvert.DeserializeObject<List<MetaRules>>(mod.rules.ToString());

            ADOBse_Dict DictInstance = new ADOBse_Dict();
            Sys_Config_ListPage M_Model = new Sys_Config_ListPage();
            List<Sys_Config_Fieled> D_List = new List<Sys_Config_Fieled>();
            
            GetListConfig(module, out M_Model, out D_List);

            var D_List_Dict = D_List.Where(o => !string.IsNullOrEmpty(o.D_DictKey) && (string.IsNullOrEmpty(o.D_Hidden) || o.D_Hidden == "false"));

            var Str_DictList = D_List.Select(o => o.D_Index);
            var Str_Oper = oper.Select(o => o.field);


            if (D_List_Dict.Count() > 0 && Str_DictList.Intersect(Str_Oper).Count() > 0)
            {

                for (int i = 0; i < oper.Count; i++)
                {
                    string _oper = string.Empty;
                    StringBuilder ConvertData = new StringBuilder();
                    if (i != oper.Count - 1)
                    {
                        _oper = "  " + mod.groupOp + "  ";
                    }
                    var D_ListQuery = D_List_Dict.Where(o => o.D_Index == oper[i].field);

                    if (D_ListQuery.Count() > 0)
                    {
                        dict = ReturnBuildDict();

                        //构建查询条件Field
                        QueryLeftTree = !string.IsNullOrEmpty(D_ListQuery.First().D_DBField) ? D_ListQuery.First().D_DBField : oper[i].field;

                        //获取字典Code
                        if (!string.IsNullOrEmpty(oper[i].data))
                        {
                            var DictResult = DictInstance.GetListByWhere(" AND Dict_Key!=Dict_Code AND Dict_Name like '%" + oper[i].data + "%'");
                            if (DictResult.Count > 0)
                            {
                                foreach (var item in DictResult)
                                {
                                    ConvertData.Append("'" + item.Dict_Code + "',");
                                }
                            }

                            strQuery.Append(dict[oper[i].op].Replace("{field}", QueryLeftTree).Replace("{data}", ConvertData.ToString().TrimEnd(',')) + _oper);
                        }
                    }
                    else
                    {
                        dict = ReturnBuild();
                        if (i != oper.Count - 1)
                        {
                            _oper = "  " + mod.groupOp + "  ";
                        }

                        strQuery.Append(dict[oper[i].op].Replace("{field}", oper[i].field).Replace("{data}", oper[i].data) + _oper);
                    }
                }
            }
            else
            {
                if (oper.Count > 0)
                {
                    dict = ReturnBuild();
                    for (int i = 0; i < oper.Count; i++)
                    {
                        string _oper = string.Empty;
                        if (i != oper.Count - 1)
                        {
                            _oper = "  " + mod.groupOp + "  ";
                        }

                        strQuery.Append(dict[oper[i].op].Replace("{field}", oper[i].field).Replace("{data}", oper[i].data) + _oper);
                    }
                }
            }

            return strQuery.ToString();
        }
    }
}
