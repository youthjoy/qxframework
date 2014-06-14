using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QX.Config
{
    /// <summary>
    /// Tab解析类
    /// </summary>
    public class TabParse
    {
        /// <summary>
        /// 解析Tab
        /// </summary>
        /// <param name="source"></param>
        /// <returns></returns>
        public static Dictionary<string,string> Parse(string source)
        {
            Dictionary<string, string> list = new Dictionary<string, string>();
            if (!string.IsNullOrEmpty(source))
            {
                if (source.Contains(":"))
                {
                    if (source.Contains(","))
                    {
                        string[] nodes = source.Split(',');
                        for (int i = 0; i < nodes.Length; i++)
                        {
                            string[] item = nodes[i].Split(':');
                            list.Add(item[0], item[1]);
                        }
                    }
                    else //只有一个Tab的情况
                    {
                        string[] item = source.Split(':');
                        list.Add(item[0], item[1]);
                    }
                }
            }
            if (list.Count==0)
            {
                list = null;    
            }
            return list;
        }
    }
}
