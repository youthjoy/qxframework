using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using System.ComponentModel;

namespace QX.Comm
{
    public static class HtmlHelperExtend
    {

        public static string BindModelToControl<T>(this HtmlHelper helper, T obj)
        {
            StringBuilder sb = new StringBuilder();
            string labelclass = "editor-label";
            string fieldclass = "editor-field";
            string inputclass = "";

            QX.Comm.MetaReflection<T> mt = new QX.Comm.MetaReflection<T>();

            Dictionary<string, string> colCollection = mt.GetMeta();

            PropertyDescriptorCollection plist = TypeDescriptor.GetProperties(typeof(T));
            foreach(KeyValuePair<string,string> kv in colCollection)
            {
                if (plist[kv.Key].PropertyType==typeof(string))
                {
                    if (plist[kv.Key].PropertyType == typeof(string))
                    { 
                       sb.AppendLine(string.Format("<div class=\"{0}\"><label>{1}</label></div>",labelclass,kv.Value));
                       
                       sb.AppendLine(string.Format("<div class=\"{0}\"><input type=\"text\" class=\"{1}\" value='{2}' /></div>",fieldclass,inputclass,plist[kv.Key].GetValue(obj)));
                    }
                    else if (plist[kv.Key].PropertyType == typeof(Int64))
                    {
                        sb.AppendLine(string.Format("<div class=\"{0}\"><label>{1}</label></div>", labelclass, kv.Value));

                        sb.AppendLine(string.Format("<div class=\"{0}\"><input type=\"text\" class=\"{1}\" value='{2}' /></div>", fieldclass, inputclass, plist[kv.Key].GetValue(obj)));
                    }
                    else if (plist[kv.Key].PropertyType == typeof(bool))
                    {
                        sb.AppendLine(string.Format("<div class=\"{0}\"><label>{1}</label></div>", labelclass, kv.Value));

                        sb.AppendLine(string.Format("<div class=\"{0}\"><input type=\"checkbox\" class=\"{1}\" value='{2}' /></div>", fieldclass, inputclass, plist[kv.Key].GetValue(obj)));
                    }
                    else if (plist[kv.Key].PropertyType == typeof(decimal))
                    {
                        sb.AppendLine(string.Format("<div class=\"{0}\"><label>{1}</label></div>", labelclass, kv.Value));

                        sb.AppendLine(string.Format("<div class=\"{0}\"><input type=\"text\" class=\"{1}\" value='{2}' /></div>", fieldclass, inputclass, plist[kv.Key].GetValue(obj)));
                    }
                    else if (plist[kv.Key].PropertyType == typeof(double))
                    {
                        sb.AppendLine(string.Format("<div class=\"{0}\"><label>{1}</label></div>", labelclass, kv.Value));

                        sb.AppendLine(string.Format("<div class=\"{0}\"><input type=\"text\" class=\"{1}\" value='{2}' /></div>", fieldclass, inputclass, plist[kv.Key].GetValue(obj)));
                    }
                    else if (plist[kv.Key].PropertyType == typeof(DateTime))
                    {
                        sb.AppendLine(string.Format("<div class=\"{0}\"><label>{1}</label></div>", labelclass, kv.Value));

                        sb.AppendLine(string.Format("<div class=\"{0}\"><input type=\"text\" class=\"{1}\" value='{2}' /></div>", fieldclass, inputclass, plist[kv.Key].GetValue(obj)));
                    }

                }
            }

            return sb.ToString();
        }




    }
}
