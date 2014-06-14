using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;

namespace QX.Comm
{
    /// <summary>
    /// 元数据反射类
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class MetaReflection<T>
    {
        /// <summary>
        /// 获取实体特性
        /// </summary>
        /// <returns></returns>
        public Dictionary<String, String> GetMeta()
        {
            Dictionary<String, String> dic = new Dictionary<string, string>();
            Type aType = typeof(T);
            PropertyInfo[] infos = aType.GetProperties();
            for (int i = 0; i < infos.Length; i++)
            {
                PropertyInfo info = infos[i];
                object[] attrs = info.GetCustomAttributes(true);
                if (attrs.Length > 0)
                {
                    QX.Model.MetaData meta = (QX.Model.MetaData)attrs.GetValue(0);
                    if (!String.IsNullOrEmpty(meta.ColumKey) && !String.IsNullOrEmpty(meta.ColumDes))
                    {
                        dic.Add(meta.ColumKey.ToString(), meta.ColumDes.ToString());
                    }
                }
            }

            return dic;
        }
    }
}
