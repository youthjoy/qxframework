using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace QX.DeskConfig.Comm
{
    public static class BulidJqGridSearch
    {

        public class MetaOper{
            public string groupOp { get; set; }
            public object rules { get; set; }            
        }

        public class MetaRules{
            public string field { get; set; }
            public string op { get; set; }
            public string data { get; set; }
        }

        public static Dictionary<string,string> ReturnBuild()
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

        public static string BuildSearch(string txt)
        {
            StringBuilder strQuery = new StringBuilder();
            Dictionary<string, string> dict = ReturnBuild();
            MetaOper mod = JsonConvert.DeserializeObject<MetaOper>(txt);
            List<MetaRules> oper = JsonConvert.DeserializeObject<List<MetaRules>>(mod.rules.ToString());
            if (oper.Count>0)
            {
                
                for (int i = 0; i < oper.Count ; i++)
                {
                    string _oper = string.Empty;
                    if (i!=oper.Count-1)
                    {
                        _oper = "  "+mod.groupOp+"  ";
                    }
                    strQuery.Append(dict[oper[i].op].Replace("{field}", oper[i].field).Replace("{data}", oper[i].data) + _oper);
                }
            }
            return strQuery.ToString();
        }


    }
}
