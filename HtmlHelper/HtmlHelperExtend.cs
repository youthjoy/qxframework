using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using System.ComponentModel;

using QX.Comm;
using QX.Model;

namespace QX.HtmlHelperLib
{
    public static class HtmlHelperExtend
    {

        //[Obsolete]
        //public static string BindModelToControl<T>(this System.Web.Mvc.HtmlHelper helper, T obj)
        //{
        //    StringBuilder sb = new StringBuilder();
        //    string labelclass = "editor-label";
        //    string fieldclass = "editor-field";
        //    string inputclass = "";

        //    QX.Comm.MetaReflection<T> mt = new QX.Comm.MetaReflection<T>();

        //    Dictionary<string, string> colCollection = mt.GetMeta();

        //    PropertyDescriptorCollection plist = TypeDescriptor.GetProperties(typeof(T));
        //    foreach (KeyValuePair<string, string> kv in colCollection)
        //    {
        //        if (plist[kv.Key].PropertyType == typeof(string))
        //        {
        //            if (plist[kv.Key].PropertyType == typeof(string))
        //            {
        //                sb.AppendLine(string.Format("<div class=\"{0}\"><label>{1}</label></div>", labelclass, kv.Value));

        //                sb.AppendLine(string.Format("<div class=\"{0}\"><input type=\"text\" class=\"{1}\" value='{2}' /></div>", fieldclass, inputclass, plist[kv.Key].GetValue(obj)));
        //            }
        //            else if (plist[kv.Key].PropertyType == typeof(Int64))
        //            {
        //                sb.AppendLine(string.Format("<div class=\"{0}\"><label>{1}</label></div>", labelclass, kv.Value));

        //                sb.AppendLine(string.Format("<div class=\"{0}\"><input type=\"text\" class=\"{1}\" value='{2}' /></div>", fieldclass, inputclass, plist[kv.Key].GetValue(obj)));
        //            }
        //            else if (plist[kv.Key].PropertyType == typeof(bool))
        //            {
        //                sb.AppendLine(string.Format("<div class=\"{0}\"><label>{1}</label></div>", labelclass, kv.Value));

        //                sb.AppendLine(string.Format("<div class=\"{0}\"><input type=\"checkbox\" class=\"{1}\" value='{2}' /></div>", fieldclass, inputclass, plist[kv.Key].GetValue(obj)));
        //            }
        //            else if (plist[kv.Key].PropertyType == typeof(decimal))
        //            {
        //                sb.AppendLine(string.Format("<div class=\"{0}\"><label>{1}</label></div>", labelclass, kv.Value));

        //                sb.AppendLine(string.Format("<div class=\"{0}\"><input type=\"text\" class=\"{1}\" value='{2}' /></div>", fieldclass, inputclass, plist[kv.Key].GetValue(obj)));
        //            }
        //            else if (plist[kv.Key].PropertyType == typeof(double))
        //            {
        //                sb.AppendLine(string.Format("<div class=\"{0}\"><label>{1}</label></div>", labelclass, kv.Value));

        //                sb.AppendLine(string.Format("<div class=\"{0}\"><input type=\"text\" class=\"{1}\" value='{2}' /></div>", fieldclass, inputclass, plist[kv.Key].GetValue(obj)));
        //            }
        //            else if (plist[kv.Key].PropertyType == typeof(DateTime))
        //            {
        //                sb.AppendLine(string.Format("<div class=\"{0}\"><label>{1}</label></div>", labelclass, kv.Value));

        //                sb.AppendLine(string.Format("<div class=\"{0}\"><input type=\"text\" class=\"{1}\" value='{2}' /></div>", fieldclass, inputclass, plist[kv.Key].GetValue(obj)));
        //            }

        //        }
        //    }

        //    return sb.ToString();
        //}
        #region Old
        /// <summary>
        /// 
        /// </summary>
        /// <param name="helper"></param>
        /// <param name="moduleName"></param>
        /// <param name="className"></param>
        /// <returns></returns>
        public static string BindModelToControl<T>(this HtmlHelper helper, string moduleName)
        {
            string defaultClass = "form_textbox";
            string defaultLabelClass = "form_label";

            List<DisplayPage_Config> list = DisplayHelper.GetDisplayConfig(moduleName, typeof(T).ToString());

            StringBuilder sbContent = new StringBuilder();
            StringBuilder sbContentExtend = new StringBuilder();
            StringBuilder sbScript = new StringBuilder();
            string scriptContainer = string.Empty;

            sbContent.AppendLine("<table>");

            if (list.Count > 2)
            {
                int step = 0;
                for (int i = 0; i < list.Count; i++)
                {

                    DisplayPage_Config dp = list[i];
                    if (step == 0)
                    {
                        sbContent.AppendLine("<tr>");
                    }


                    //如果该控件设置隐藏则不做显示处理并跳出此次<td>的循环
                    if (dp.DCP_IsHidden == 1)
                    {
                        sbContentExtend.AppendLine(string.Format("<input name='{0}' type='hidden'  id='{0}'  />", dp.DCP_ControlID));
                        continue;
                    }



                    switch (dp.DCP_ControlType)
                    {
                        case "text":
                            if (dp.DCP_IsReadonly != 1)
                            {
                                sbContent.AppendLine(string.Format(@"<td><label class='{3}' form_label for='{1}'>{0}</label><span class='div_texbox'><input name='{1}' type='text' class='{2}' id='{1}' value='' /></span></td>", dp.DCP_Label, dp.DCP_ControlID, dp.DCP_Style == null ? defaultClass : dp.DCP_Style, defaultLabelClass));
                            }
                            else
                            {
                                sbContent.AppendLine(string.Format(@"<td><label class='{3}' for='{1}'>{0}</label><span class='div_texbox'><input name='{1}' readonly='true' type='text' class='{2}' id='{1}' value='' /></span></td>", dp.DCP_Label, dp.DCP_ControlID, dp.DCP_Style == null ? defaultClass : dp.DCP_Style, defaultLabelClass));
                            }

                            break;
                        case "date":
                            sbContent.AppendLine(string.Format(@"<td><label class='{3}' for='{1}'>{0}</label><span class='div_texbox'><input name='{1}' type='text' class='{2}' id='{1}' value='' /></span></td>", dp.DCP_Label, dp.DCP_ControlID, dp.DCP_Style == null ? defaultClass : dp.DCP_Style, defaultLabelClass));

                            sbScript.AppendLine(string.Format(@"$( '#{0}' ).datepicker();
", dp.DCP_ControlID));
                            sbScript.AppendLine("$('" + dp.DCP_ControlID + "').datepicker( \"option\", \"dateFormat\", 'yy-mm-dd')");
                            break;
                        case "check":
                            sbContent.AppendLine(string.Format(@"<td><label class='{2}' for='{1}'>{0}</label><span class='div_texbox'><input name='{1}' type='checkbox'  id='{1}' value='0' /></span></td>", dp.DCP_Label, dp.DCP_ControlID, defaultLabelClass));
                            break;
                        case "select":
                            sbContent.AppendLine(string.Format(@"<td><label class='{2}' for='{1}'>{0}</label><span class='div_texbox'><select name='{1}' class='select' id='{1}'></select></span></td>", dp.DCP_Label, dp.DCP_ControlID, defaultLabelClass));
                            break;
                        case "file":
                            sbContent.AppendLine(string.Format(@"<td><label class='{3}' form_label for='{1}'>{0}</label><span class='div_texbox'><input name='{1}' type='file' class='{2}' id='{1}' value='' /></span></td>", dp.DCP_Label, dp.DCP_ControlID, dp.DCP_Style == null ? defaultClass : dp.DCP_Style, defaultLabelClass));
                            break;

                    }
                    if (step == 1)
                    {
                        sbContent.AppendLine("</tr>");
                        step = 0;
                    }
                    else
                    {
                        step++;
                    }
                }
            }
            else
            {
                sbContent.AppendLine("<tr>");
                DisplayPage_Config dp = list[0];

                sbContent.AppendLine(string.Format(@"<td><label for='{1}'>{0}</label><span class='div_texbox'><input name='{1}' type='{2}' class='{3}' id='{1}' value='' /></span></td>", dp.DCP_Label, dp.DCP_ControlID, dp.DCP_ControlType, dp.DCP_Style == null ? defaultClass : dp.DCP_Style));

                sbContent.AppendLine("</tr>");
            }

            sbContent.AppendLine("</table>");
            sbContent.Append(sbContentExtend.ToString());
            scriptContainer = @"<script type='text/javascript'>
                $(document).ready(function(){" + sbScript.ToString().Trim() + @"});
                </script>";

            return sbContent.ToString() + scriptContainer;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="helper"></param>
        /// <param name="moduleName"></param>
        /// <param name="className"></param>
        /// <returns></returns>
        public static string BindComModelToControl<T>(this HtmlHelper helper, string moduleName)
        {
            string defaultClass = "form_textbox";
            string defaultLabelClass = "form_label";

            //配置数据源
            List<Sys_PU_Config> list = DisplayHelper.GetPUDisplayConfig(moduleName, typeof(T).ToString());
            List<Sys_PU_Config> hlist = DisplayHelper.GetHiddenPUDisplayConfig(moduleName, typeof(T).ToString());

            //输出html
            StringBuilder sbContent = new StringBuilder();
            //hidden控件
            StringBuilder sbContentExtend = new StringBuilder();
            //附带初始化脚本
            StringBuilder sbScript = new StringBuilder();


            //脚本容器
            string scriptContainer = string.Empty;

            sbContent.AppendLine("<table>");


            foreach (var dp in hlist)
            {

                //如果该控件设置隐藏则不做显示处理并跳出此次<td>的循环
                if (dp.DCP_IsHidden == 1)
                {
                   sbContentExtend.AppendLine(string.Format("<input name='{0}' type='hidden'  id='{0}'  />", dp.DCP_ControlID));

                }
            }

            if (list.Count > 2)
            {
                int step = 0;
                for (int i = 0; i < list.Count; i++)
                {
                    
                    Sys_PU_Config dp = list[i];



                    //如果该控件设置隐藏则不做显示处理并跳出此次<td>的循环
                    //if (dp.DCP_IsHidden == 1)
                    //{
                    //    sbContentExtend.AppendLine(string.Format("<input name='{0}' type='hidden'  id='{0}'  />", dp.DCP_ControlID));
                    //    continue;
                    //}

                    if (step == 0)
                    {
                        sbContent.AppendLine("<tr>");
                    }


                    switch (dp.DCP_ControlType)
                    {
                        case "text":
                            if (dp.DCP_IsReadonly != 1)
                            {
                                sbContent.AppendLine(string.Format(@"<td><label class='{3}' form_label for='{1}'>{0}</label><span class='div_texbox'><input name='{1}' type='text' class='{2}' id='{1}' value='' /><div>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span></span></div></span></td>", dp.DCP_Label, dp.DCP_ControlID, dp.DCP_Style == null ? defaultClass : dp.DCP_Style, defaultLabelClass));

                            }
                            else
                            {
                                sbContent.AppendLine(string.Format(@"<td><label class='{3}' form_label for='{1}'>{0}</label><span class='div_texbox'><input name='{1}' readonly='true' type='text' class='TextBoxReadOnly {2}' id='{1}' value='' /><div>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span></span></div></span></td>", dp.DCP_Label, dp.DCP_ControlID, dp.DCP_Style == null ? defaultClass : dp.DCP_Style, defaultLabelClass));

                            }

                            break;
                        case "date":
                            sbContent.AppendLine(string.Format(@"<td><label class='{3}' for='{1}'>{0}</label><span class='div_texbox'><input name='{1}' type='text' readonly='true' class='TextBoxReadOnly {2}' id='{1}' value='' /><div>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span></span></div></span></td>", dp.DCP_Label, dp.DCP_ControlID, dp.DCP_Style == null ? defaultClass : dp.DCP_Style, defaultLabelClass));

                            sbScript.AppendLine(string.Format(@"$( '#{0}' ).datepicker();
", dp.DCP_ControlID));
                            sbScript.AppendLine("$('#" + dp.DCP_ControlID + "').datepicker( \"option\", \"dateFormat\", 'yy-mm-dd')");


                            break;
                        case "check":
                            sbContent.AppendLine(string.Format(@"<td><label class='{2}' for='{1}'>{0}</label><span class='div_texbox'><input name='{1}' type='checkbox'  id='{1}' value='0' /><div>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span></span></div></span></td>", dp.DCP_Label, dp.DCP_ControlID, defaultLabelClass));


                            break;
                        case "select":
                            sbContent.AppendLine(string.Format(@"<td><label class='{2}' for='{1}'>{0}</label><span class='div_texbox'><select name='{1}' class='select' id='{1}'></select></span></td>", dp.DCP_Label, dp.DCP_ControlID, defaultLabelClass));



                            break;

                        case "file":
                            sbContent.AppendLine(string.Format(@"<td><label class='{3}' form_label for='{1}'>{0}</label><span class='div_texbox'><input name='{1}' type='file' class='{2}' id='{1}' value='' /><div>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span></span></div></span></td>", dp.DCP_Label, dp.DCP_ControlID, dp.DCP_Style == null ? defaultClass : dp.DCP_Style, defaultLabelClass));
                            break;
                        case "tarea":
                            if (step == 0)
                            {
                                sbContent.AppendLine(string.Format(@"<td colspan=2><label class='{3}' form_label for='{1}'>{0}</label><span class='div_textarea'><textarea name='{1}' rows='3' cols='80' class='{2}' id='{1}'></textarea></span></td>", dp.DCP_Label, dp.DCP_ControlID, dp.DCP_Style == null ? defaultClass : dp.DCP_Style, defaultLabelClass));
                                step = 1;
                            }
                            else if (step == 1)
                            {
                                sbContent.AppendLine(string.Format("<td></td></tr>"));
                                sbContent.AppendLine(string.Format(@"<td colspan=2><label class='{3}' form_label for='{1}'>{0}</label><span class='div_textarea'><textarea name='{1}' rows='3' cols='80' class='{2}' id='{1}'></textarea></span></td>", dp.DCP_Label, dp.DCP_ControlID, dp.DCP_Style == null ? defaultClass : dp.DCP_Style, defaultLabelClass));
                            }
                            break;

                    }
                    if (step == 1 || i == (list.Count - 1))
                    {
                        sbContent.AppendLine("</tr>");
                        step = 0;
                    }
                    else
                    {
                        step++;
                    }


                    if (i == (list.Count - 1))
                    {
                        sbContent.AppendLine("</tr>");
                    }
                }
            }
            else
            {
                sbContent.AppendLine("<tr>");
                Sys_PU_Config dp = list[0];

                sbContent.AppendLine(string.Format(@"<td><label for='{1}'>{0}</label><span class='div_texbox'><input name='{1}' type='{2}' class='{3}' id='{1}' value='' /><div>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span></span></div></span></td>", dp.DCP_Label, dp.DCP_ControlID, dp.DCP_ControlType, dp.DCP_Style == null ? defaultClass : dp.DCP_Style));

                sbContent.AppendLine("</tr>");
            }

            sbContent.AppendLine("</table>");
            sbContent.Append(sbContentExtend.ToString());
            scriptContainer = @"<script type='text/javascript'>
                $(document).ready(function(){
                    " + sbScript.ToString().Trim() + @" 
                });
                </script>";

            return sbContent.ToString() + scriptContainer;
        }

        /// <summary>
        /// 绑定数据到控件
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="helper"></param>
        /// <param name="moduleName"></param>
        /// <param name="obj"></param>
        /// <returns></returns>
        public static string BindComModelToControl<T>(this HtmlHelper helper, string moduleName, T obj) where T : new()
        {
            string defaultClass = "form_textbox";
            string defaultLabelClass = "form_label";

            if (obj == null)
            {
                obj = new T();
            }


            List<Sys_PU_Config> list = DisplayHelper.GetPUDisplayConfig(moduleName, typeof(T).ToString());


            List<Sys_PU_Config> hlist = DisplayHelper.GetHiddenPUDisplayConfig(moduleName, typeof(T).ToString());

            PropertyDescriptorCollection pList = TypeDescriptor.GetProperties(typeof(T));



            StringBuilder sbContent = new StringBuilder();

            StringBuilder sbContentExtend = new StringBuilder();

            StringBuilder sbScript = new StringBuilder();
            string scriptContainer = string.Empty;

            sbContent.AppendLine("<table>");

            foreach (var dp in hlist)
            {

                //如果该控件设置隐藏则不做显示处理并跳出此次<td>的循环
                if (dp.DCP_IsHidden == 1)
                {
                    sbContentExtend.AppendLine(string.Format("<input name='{0}' type='hidden'  id='{0}' value='{1}' />", dp.DCP_ControlID,pList[dp.DCP_ControlID]!=null?pList[dp.DCP_ControlID].GetValue(obj):""));
                    //continue;
                }
            }


            if (list.Count >= 2)
            {
                int step = 0;
                for (int i = 0; i < list.Count; i++)
                {

                    Sys_PU_Config dp = list[i];
                    if (step == 0)
                    {
                        sbContent.AppendLine("<tr>");
                    }


                    switch (dp.DCP_ControlType)
                    {
                        case "text":
                            if (dp.DCP_IsReadonly != 1)
                            {
                                sbContent.AppendLine(
                                    string.Format(@"<td><label class='{4}' for='{1}'>{0}</label><span class='div_texbox'>
                                                   <input name='{1}' type='text' class='{2}'  id='{1}' value='{3}' />
                                                  <div>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span></span></div>
                                                   </span></td>",
                                                                                                                                                                      dp.DCP_Label,
                                                                                                                                                                      dp.DCP_ControlID,
                                                                                                                                                                      dp.DCP_Style == null ? defaultClass : dp.DCP_Style,
                                                                                                                                                                      pList[dp.DCP_ControlID] != null ? pList[dp.DCP_ControlID].GetValue(obj) : "",
                                                                                                                                                                      defaultLabelClass)
                                                                                                                                                                     );
                            }
                            else
                            {
                                sbContent.AppendLine(
         string.Format(@"<td><label class='{4}' for='{1}'>{0}</label><span class='div_texbox'>
                                                   <input name='{1}' type='text' readonly='true' class='TextBoxReadOnly {2}'  id='{1}' value='{3}' />
                                                 <div>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span></span></div>
                                                   </span></td>",
                                                                                                                                           dp.DCP_Label,
                                                                                                                                           dp.DCP_ControlID,
                                                                                                                                           dp.DCP_Style == null ? defaultClass : dp.DCP_Style,
                                                                                                                                           pList[dp.DCP_ControlID] != null ? pList[dp.DCP_ControlID].GetValue(obj) : "",
                                                                                                                                           defaultLabelClass)
                                                                                                                                          );
                            }
                            break;
                        case "date":
                            sbContent.AppendLine(string.Format(@"<td><label class='{4}' for='{1}'>{0}</label><span class='div_texbox'><input name='{1}' type='text' readonly='true' class='TextBoxReadOnly {2}' id='{1}' value='{3}' /><div>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span></span></div></span></td>", dp.DCP_Label, dp.DCP_ControlID, dp.DCP_Style == null ? defaultClass : dp.DCP_Style, pList[dp.DCP_ControlID].GetValue(obj), defaultLabelClass));

                            sbScript.AppendLine(string.Format(@"$( '#{0}' ).datepicker();
", dp.DCP_ControlID));
                            sbScript.AppendLine("$('#" + dp.DCP_ControlID + "').datepicker( \"option\", \"dateFormat\", 'yy-mm-dd')");
                            break;
                        case "check":
                            sbContent.AppendLine(string.Format(@"<td><label class='{3}' for='{1}'>{0}</label><span class='div_texbox'><input name='{1}' type='checkbox'  id='{1}' value='{2}' /></span></td>", dp.DCP_Label, dp.DCP_ControlID, pList[dp.DCP_ControlID].GetValue(obj), defaultLabelClass));
                            break;
                        case "select":
                            sbContent.AppendLine(string.Format(@"<td><label class='{3}' for='{1}'>{0}</label><span class='div_texbox'><select name='{1}' class='select' id='{1}'><option>{2}</option></select></span></td>", dp.DCP_Label, dp.DCP_ControlID, pList[dp.DCP_ControlID].GetValue(obj), defaultLabelClass));
                            break;
                        case "tarea":
                            if (step == 0)
                            {
                                sbContent.AppendLine(string.Format(@"<td colspan=2><label class='{3}' form_label for='{1}'>{0}</label><span class='div_textarea'><textarea name='{1}' rows='3' cols='80' class='{2}' id='{1}'></textarea></span></td>", dp.DCP_Label, dp.DCP_ControlID, dp.DCP_Style == null ? defaultClass : dp.DCP_Style, defaultLabelClass));
                                step = 1;
                            }
                            else if (step == 1)
                            {
                                sbContent.AppendLine(string.Format("<td></td></tr>"));
                                sbContent.AppendLine(string.Format(@"<td colspan=2><label class='{3}' form_label for='{1}'>{0}</label><span class='div_textarea'><textarea name='{1}' rows='3' cols='80' class='{2}' id='{1}'></textarea></span></td>", dp.DCP_Label, dp.DCP_ControlID, dp.DCP_Style == null ? defaultClass : dp.DCP_Style, defaultLabelClass));
                            }
                            break;

                    }
                    if (step == 1)
                    {
                        sbContent.AppendLine("</tr>");
                        step = 0;
                    }
                    else
                    {
                        step++;
                    }

                    if (i == (list.Count - 1))
                    {
                        sbContent.AppendLine("</tr>");
                    }

                }
            }
            else
            {
                sbContent.AppendLine("<tr>");
                Sys_PU_Config dp = list[0];

                sbContent.AppendLine(string.Format(@"<td><label for='{1}'>{0}</label><span class='div_texbox'><input name='{1}' type='{2}' class='{3}' id='{1}' value='' /></span></td>", dp.DCP_Label, dp.DCP_ControlID, dp.DCP_ControlType, dp.DCP_Style == null ? defaultClass : dp.DCP_Style));

                sbContent.AppendLine("</tr>");
            }

            sbContent.AppendLine("</table>");

            sbContent.Append(sbContentExtend.ToString());

            scriptContainer = @"<script type='text/javascript'>
                $(document).ready(function(){" + sbScript.ToString().Trim() + @"});
                </script>";

            return sbContent.ToString() + scriptContainer;
        }


        #endregion

        /// <summary>
        /// 
        /// </summary>
        /// <param name="helper"></param>
        /// <param name="moduleName"></param>
        /// <param name="className"></param>
        /// <returns></returns>
        [Obsolete]
        public static string BindPUModelToControl<T>(this HtmlHelper helper, string moduleName)
        {
            string defaultClass = "form_textbox";
            string defaultLabelClass = "form_label";

            //配置数据源
            List<Sys_PU_Config> list = DisplayHelper.GetPUDisplayConfig(moduleName, typeof(T).ToString());

            //输出html
            StringBuilder sbContent = new StringBuilder();
            //hidden控件
            StringBuilder sbContentExtend = new StringBuilder();
            //附带初始化脚本
            StringBuilder sbScript = new StringBuilder();


            //脚本容器
            string scriptContainer = string.Empty;

            sbContent.AppendLine("<table>");

            if (list.Count > 2)
            {
                int step = 0;
                for (int i = 0; i < list.Count; i++)
                {

                    Sys_PU_Config dp = list[i];



                    //如果该控件设置隐藏则不做显示处理并跳出此次<td>的循环
                    if (dp.DCP_IsHidden == 1)
                    {
                        sbContentExtend.AppendLine(string.Format("<input name='{0}' type='hidden'  id='{0}'  />", dp.DCP_ControlID));
                        continue;
                    }

                    if (step == 0)
                    {
                        sbContent.AppendLine("<tr>");
                    }


                    switch (dp.DCP_ControlType)
                    {
                        case "text":
                            if (dp.DCP_IsReadonly != 1)
                            {
                                sbContent.AppendLine(string.Format(@"<td><label class='{3}' form_label for='{1}'>{0}</label><span class='div_texbox'><input name='{1}' type='text' class='{2}' id='{1}' value='' /><div>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span></span></div></span></td>", dp.DCP_Label, dp.DCP_ControlID, dp.DCP_Style == null ? defaultClass : dp.DCP_Style, defaultLabelClass));

                            }
                            else
                            {
                                sbContent.AppendLine(string.Format(@"<td><label class='{3}' for='{1}'>{0}</label><span class='div_texbox'><input name='{1}' readonly='true' type='text' class='{2}' id='{1}' value='' /><div>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span></span></div></span></td>", dp.DCP_Label, dp.DCP_ControlID, dp.DCP_Style == null ? defaultClass : dp.DCP_Style, defaultLabelClass));


                            }

                            break;
                        case "date":
                            sbContent.AppendLine(string.Format(@"<td><label class='{3}' for='{1}'>{0}</label><span class='div_texbox'><input name='{1}' type='text' class='{2}' id='{1}' value='' /><div>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span></span></div></span></td>", dp.DCP_Label, dp.DCP_ControlID, dp.DCP_Style == null ? defaultClass : dp.DCP_Style, defaultLabelClass));

                            sbScript.AppendLine(string.Format(@"$( '#{0}' ).datepicker();
", dp.DCP_ControlID));
                            sbScript.AppendLine("$('#" + dp.DCP_ControlID + "').datepicker( \"option\", \"dateFormat\", 'yy-mm-dd')");


                            break;
                        case "check":
                            sbContent.AppendLine(string.Format(@"<td><label class='{2}' for='{1}'>{0}</label><span class='div_texbox'><input name='{1}' type='checkbox'  id='{1}' value='0' /><div>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span></span></div></span></td>", dp.DCP_Label, dp.DCP_ControlID, defaultLabelClass));


                            break;
                        case "select":
                            sbContent.AppendLine(string.Format(@"<td><label class='{2}' for='{1}'>{0}</label><span class='div_texbox'><select name='{1}' class='select' id='{1}'></select></span></td>", dp.DCP_Label, dp.DCP_ControlID, defaultLabelClass));



                            break;
                        case "file":
                            sbContent.AppendLine(string.Format(@"<td><label class='{3}' form_label for='{1}'>{0}</label><span class='div_texbox'><input name='{1}' type='file' class='{2}' id='{1}' value='' /><div>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span></span></div></span></td>", dp.DCP_Label, dp.DCP_ControlID, dp.DCP_Style == null ? defaultClass : dp.DCP_Style, defaultLabelClass));
                            break;

                    }
                    if (step == 1 || i == (list.Count - 1))
                    {
                        sbContent.AppendLine("</tr>");
                        step = 0;
                    }
                    else
                    {
                        step++;
                    }
                }
            }
            else if(list.Count==1)
            {
                sbContent.AppendLine("<tr>");
                Sys_PU_Config dp = list[0];

                sbContent.AppendLine(string.Format(@"<td><label for='{1}'>{0}</label><span class='div_texbox'><input name='{1}' type='{2}' class='{3}' id='{1}' value='' /><div>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span></span></div></span></td>", dp.DCP_Label, dp.DCP_ControlID, dp.DCP_ControlType, dp.DCP_Style == null ? defaultClass : dp.DCP_Style));

                sbContent.AppendLine("</tr>");
            }

            sbContent.AppendLine("</table>");
            sbContent.Append(sbContentExtend.ToString());
            scriptContainer = @"<script type='text/javascript'>
                $(document).ready(function(){
                    " + sbScript.ToString().Trim() + @" 
                });
                </script>";

            return sbContent.ToString() + scriptContainer;
        }

        public static string BindValidateToControl<T>(this HtmlHelper helper, string formName)
        {
            //验证脚本
            StringBuilder sbValidateScript = new StringBuilder();
            //提示信息脚本
            StringBuilder sbMessageScript = new StringBuilder();

            string scriptContainer = string.Empty;

            //配置数据源
            List<Sys_PU_Config> list = DisplayHelper.GetValidateConfig(typeof(T).ToString());

            foreach (var item in list)
            {
                if (!string.IsNullOrEmpty(item.DCP_UDef1) && !string.IsNullOrEmpty(item.DCP_UDef2))
                {
                    sbValidateScript.AppendLine(item.DCP_ControlID + ":{" + item.DCP_UDef1.Trim().TrimEnd(',') + "},");

                    sbMessageScript.AppendLine(item.DCP_ControlID + ":{" + item.DCP_UDef2.Trim().TrimEnd(',') + "},");
                }
            }

            scriptContainer = @"<script type='text/javascript'>
                $(document).ready(function(){
                    var validator = $('#" + formName + @"').validate({
                        debug: false,       //调试模式取消submit的默认提交功能
                        errorClass: 'err_display', //默认为错误的样式类为：error
                        focusInvalid: false,
                        onkeyup: false,
                        rules: {           //定义验证规则,其中属性名为表单的name属性
                           " + sbValidateScript.ToString().Trim().TrimEnd(',') + @"
                        },
                        messages: {       //自定义验证消息
                          " + sbMessageScript.ToString().Trim().TrimEnd(',') + @"
                        },
                        errorPlacement: function(error, element) {  //验证消息放置的地方
                            if(error.html()!=''){
                                element.next().addClass('err_display');                            
                                element.next().find('span').html(error.html());
                            }else{
                                element.next().find('span').html(error.html());
                                element.next().removeClass('err_display');
                            }                            
                        },
                        highlight: function(element, errorClass) {  //针对验证的表单设置高亮
                            
                        },
                        success: function(label) {
                        }     
                    });

                });
            </script>
";

            return scriptContainer;
        }

        /// <summary>
        /// 绑定数据到控件
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="helper"></param>
        /// <param name="moduleName"></param>
        /// <param name="obj"></param>
        /// <returns></returns>
        [Obsolete]
        public static string BindPUModelToControl<T>(this HtmlHelper helper, string moduleName, T obj) where T : new()
        {
            string defaultClass = "form_textbox";
            string defaultLabelClass = "form_label";

            if (obj == null)
            {
                obj = new T();
            }


            List<Sys_PU_Config> list = DisplayHelper.GetPUDisplayConfig(moduleName, typeof(T).ToString());
            PropertyDescriptorCollection pList = TypeDescriptor.GetProperties(typeof(T));


            StringBuilder sbContent = new StringBuilder();

            StringBuilder sbContentExtend = new StringBuilder();

            StringBuilder sbScript = new StringBuilder();
            string scriptContainer = string.Empty;

            sbContent.AppendLine("<table>");

            if (list.Count > 2)
            {
                int step = 0;
                for (int i = 0; i < list.Count; i++)
                {

                    Sys_PU_Config dp = list[i];
                    if (step == 0)
                    {
                        sbContent.AppendLine("<tr>");
                    }

                    //如果该控件设置隐藏则不做显示处理并跳出此次<td>的循环
                    if (dp.DCP_IsHidden == 1)
                    {
                        sbContentExtend.AppendLine(string.Format("<input name='{0}' type='hidden'  id='{0}' value='{1}' />", dp.DCP_ControlID, pList[dp.DCP_ControlID].GetValue(obj)));
                        continue;
                    }

                    switch (dp.DCP_ControlType)
                    {
                        case "text":
                            if (dp.DCP_IsReadonly != 1)
                            {
                                sbContent.AppendLine(string.Format(@"<td><label class='{4}' for='{1}'>{0}</label><span class='div_texbox'>
                                                                     <input name='{1}' type='text' class='{2}' id='{1}' value='{3}' />
</span></td>", dp.DCP_Label, dp.DCP_ControlID, dp.DCP_Style == null ? defaultClass : dp.DCP_Style, pList[dp.DCP_ControlID].GetValue(obj), defaultLabelClass));
                            }
                            else
                            {
                                sbContent.AppendLine(string.Format(@"<td><label class='{4}' for='{1}'>{0}</label><span class='div_texbox'><input name='{1}' type='text' readonly='true' class='{2}' id='{1}' value='{3}' /></span></td>", dp.DCP_Label, dp.DCP_ControlID, dp.DCP_Style == null ? defaultClass : dp.DCP_Style, pList[dp.DCP_ControlID].GetValue(obj), defaultLabelClass));
                                //sbContent.AppendLine(string.Format(@"<td><label class='{4}' for='{1}'>{0}</label><span class='div_texbox'><input name='{1}' type='text' readonly='true' class='{2}' id='{1}' value='{3}' /></span></td>", dp.DCP_Label, dp.DCP_ControlID, dp.DCP_Style == null ? defaultClass : dp.DCP_Style, pList[dp.DCP_ControlID].GetValue(obj), defaultLabelClass));
                            }
                            break;
                        case "date":
                            sbContent.AppendLine(string.Format(@"<td><label class='{4}' for='{1}'>{0}</label><span class='div_texbox'><input name='{1}' type='text' class='{2}' id='{1}' value='{3}' /></span></td>", dp.DCP_Label, dp.DCP_ControlID, dp.DCP_Style == null ? defaultClass : dp.DCP_Style, pList[dp.DCP_ControlID].GetValue(obj), defaultLabelClass));

                            sbScript.AppendLine(string.Format(@"$( '#{0}' ).datepicker();
", dp.DCP_ControlID));
                            sbScript.AppendLine("$('#" + dp.DCP_ControlID + "').datepicker( \"option\", \"dateFormat\", 'yy-mm-dd')");
                            break;
                        case "check":
                            sbContent.AppendLine(string.Format(@"<td><label class='{3}' for='{1}'>{0}</label><span class='div_texbox'><input name='{1}' type='checkbox'  id='{1}' value='{2}' /></span></td>", dp.DCP_Label, dp.DCP_ControlID, pList[dp.DCP_ControlID].GetValue(obj), defaultLabelClass));
                            break;
                        case "select":
                            sbContent.AppendLine(string.Format(@"<td><label class='{3}' for='{1}'>{0}</label><span class='div_texbox'><select name='{1}' class='select' id='{1}'><option>{2}</option></select></span></td>", dp.DCP_Label, dp.DCP_ControlID, pList[dp.DCP_ControlID].GetValue(obj), defaultLabelClass));
                            break;

                    }

                    if (step == 1)
                    {
                        sbContent.AppendLine("</tr>");
                        step = 0;
                    }
                    else
                    {
                        step++;
                    }
                }
            }
            else if (list.Count == 1)
            {
                sbContent.AppendLine("<tr>");
                Sys_PU_Config dp = list[0];

                sbContent.AppendLine(string.Format(@"<td><label for='{1}'>{0}</label><span class='div_texbox'><input name='{1}' type='{2}' class='{3}' id='{1}' value='' /></span></td>", dp.DCP_Label, dp.DCP_ControlID, dp.DCP_ControlType, dp.DCP_Style == null ? defaultClass : dp.DCP_Style));

                sbContent.AppendLine("</tr>");
            }

            sbContent.AppendLine("</table>");

            sbContent.Append(sbContentExtend.ToString());

            scriptContainer = @"<script type='text/javascript'>
                $(document).ready(function(){" + sbScript.ToString().Trim() + @"});
                </script>";

            return sbContent.ToString() + scriptContainer;
        }

        /// <summary>
        /// 绑定数据到控件
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="helper"></param>
        /// <param name="moduleName"></param>
        /// <param name="obj"></param>
        /// <returns></returns>
        [Obsolete]
        public static string BindModelToControl<T>(this HtmlHelper helper, string moduleName, T obj) where T : new()
        {
            string defaultClass = "form_textbox";
            string defaultLabelClass = "form_label";

            if (obj == null)
            {
                obj = new T();
            }


            List<DisplayPage_Config> list = DisplayHelper.GetDisplayConfig(moduleName, typeof(T).ToString());
            PropertyDescriptorCollection pList = TypeDescriptor.GetProperties(typeof(T));


            StringBuilder sbContent = new StringBuilder();

            StringBuilder sbContentExtend = new StringBuilder();

            StringBuilder sbScript = new StringBuilder();
            string scriptContainer = string.Empty;

            sbContent.AppendLine("<table>");

            if (list.Count > 2)
            {
                int step = 0;
                for (int i = 0; i < list.Count; i++)
                {

                    DisplayPage_Config dp = list[i];
                    if (step == 0)
                    {
                        sbContent.AppendLine("<tr>");
                    }

                    //如果该控件设置隐藏则不做显示处理并跳出此次<td>的循环
                    if (dp.DCP_IsHidden == 1)
                    {
                        sbContentExtend.AppendLine(string.Format("<input name='{0}' type='hidden'  id='{0}' value='{1}' />", dp.DCP_ControlID, pList[dp.DCP_ControlID].GetValue(obj)));
                        continue;
                    }

                    switch (dp.DCP_ControlType)
                    {
                        case "text":
                            if (dp.DCP_IsReadonly != 1)
                            {
                                sbContent.AppendLine(string.Format(@"<td><label class='{4}' for='{1}'>{0}</label><span class='div_texbox'>
                                                                     <input name='{1}' type='text' class='{2}' id='{1}' value='{3}' />
                                                                     <span class='field-validation-valid' id='{1}_validationMessage'></span>
</span></td>",
                                                                                                                                                      dp.DCP_Label,
                                                                                                                                                      dp.DCP_ControlID,
                                                                                                                                                      dp.DCP_Style == null ? defaultClass : dp.DCP_Style,
                                                                                                                                                      pList[dp.DCP_ControlID].GetValue(obj), defaultLabelClass)
                                                                                                                                                      );
                            }
                            else
                            {
                                sbContent.AppendLine(string.Format(@"<td><label class='{4}' for='{1}'>{0}</label><span class='div_texbox'><input name='{1}' type='text' readonly='true' class='{2}' id='{1}' value='{3}' /></span></td>", dp.DCP_Label, dp.DCP_ControlID, dp.DCP_Style == null ? defaultClass : dp.DCP_Style, pList[dp.DCP_ControlID].GetValue(obj), defaultLabelClass));
                            }
                            break;
                        case "date":
                            sbContent.AppendLine(string.Format(@"<td><label class='{4}' for='{1}'>{0}</label><span class='div_texbox'><input name='{1}' type='text' class='{2}' id='{1}' value='{3}' /></span></td>", dp.DCP_Label, dp.DCP_ControlID, dp.DCP_Style == null ? defaultClass : dp.DCP_Style, pList[dp.DCP_ControlID].GetValue(obj), defaultLabelClass));

                            sbScript.AppendLine(string.Format(@"$( '#{0}' ).datepicker();
", dp.DCP_ControlID));

                            break;
                        case "check":
                            sbContent.AppendLine(string.Format(@"<td><label class='{3}' for='{1}'>{0}</label><span class='div_texbox'><input name='{1}' type='checkbox'  id='{1}' value='{2}' /></span></td>", dp.DCP_Label, dp.DCP_ControlID, pList[dp.DCP_ControlID].GetValue(obj), defaultLabelClass));
                            break;
                        case "select":
                            sbContent.AppendLine(string.Format(@"<td><label class='{3}' for='{1}'>{0}</label><span class='div_texbox'><select name='{1}' class='select' id='{1}'><option>{2}</option></select></span></td>", dp.DCP_Label, dp.DCP_ControlID, pList[dp.DCP_ControlID].GetValue(obj), defaultLabelClass));
                            break;

                    }

                    if (step == 1)
                    {
                        sbContent.AppendLine("</tr>");
                        step = 0;
                    }
                    else
                    {
                        step++;
                    }
                }
            }
            else
            {
                sbContent.AppendLine("<tr>");
                DisplayPage_Config dp = list[0];

                sbContent.AppendLine(string.Format(@"<td><label for='{1}'>{0}</label><span class='div_texbox'><input name='{1}' type='{2}' class='{3}' id='{1}' value='' /></span></td>", dp.DCP_Label, dp.DCP_ControlID, dp.DCP_ControlType, dp.DCP_Style == null ? defaultClass : dp.DCP_Style));

                sbContent.AppendLine("</tr>");
            }

            sbContent.AppendLine("</table>");

            sbContent.Append(sbContentExtend.ToString());

            scriptContainer = @"<script type='text/javascript'>
                $(document).ready(function(){" + sbScript.ToString().Trim() + @"});
                </script>";

            return sbContent.ToString() + scriptContainer;
        }
    }
}
