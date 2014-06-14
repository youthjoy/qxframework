using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using System.Collections;

namespace QX.MenuHelper
{
    public static class JsTreeHelper
    {
        #region 返回数据格式
        public enum JsTreeDataFormat
        {
            html_data,
            json_data,
            xml_data
        }
        #endregion

        public static string Dtree<T>(this HtmlHelper helper, string TreeId, IEnumerable<T> rootItems, Func<T, IEnumerable<T>> childrenProperty,
            Func<T, string> itemContents)
        {
            var builder = new TagBuilder("script");
            builder.MergeAttribute("type", "text/javascript");
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("{0} = new dTree('{0}');",TreeId);
            foreach (T item in rootItems)
            {
                DtreeRenderLi(TreeId, sb, item, itemContents);
                DtreeAppendChildren(TreeId, sb, item, childrenProperty, itemContents);
            }
            sb.AppendFormat("document.write({0});",TreeId);            
            builder.InnerHtml =sb.ToString();
            return builder.ToString();
        }

        private static void DtreeAppendChildren<T>(string TreeId, StringBuilder sb, T root, Func<T, IEnumerable<T>> childrenProperty, Func<T, string> itemContent)
        {
            if (childrenProperty != null)
            {
                var children = childrenProperty(root);
                if (children == null || children.Count() == 0)
                {
                    sb.AppendLine("");
                    return;
                }
                sb.AppendLine("\r\n");
                foreach (T item in children)
                {
                    DtreeRenderLi(TreeId, sb, item, itemContent);
                    DtreeAppendChildren(TreeId, sb, item, childrenProperty, itemContent);
                }
            }
        }

        private static void DtreeRenderLi<T>(string TreeId, StringBuilder sb, T item, Func<T, string> itemContent)
        {
            sb.AppendFormat("{0}.add({1});", TreeId, itemContent(item));
        }


          

        /// <summary>
        /// 初始化JsTree
        /// </summary>
        /// <param name="helper"></param>
        /// <param name="TreeId">层对象ID</param>
        /// <param name="ActionUrl">获取数据源URL</param>
        /// <param name="IsCheck">是否显示CheckBox</param>
        /// <param name="DataFormat">返回数据格式</param>
        /// <returns></returns>
        public static string TreeView(this HtmlHelper helper, string TreeId, string ActionUrl, bool IsCheck, JsTreeDataFormat DataFormat)
        {
            return JsTreeJavascriptInit(TreeId, ActionUrl, IsCheck, DataFormat);
        }

        private static string JsTreeJavascriptInit(string TreeViewTarget, string ActionUrl, bool IsCheck, JsTreeDataFormat DataFormat)
        {
            string StrCheckBox = IsCheck ? ",\"checkbox\"" : "";

            var builder = new TagBuilder("script");
            builder.MergeAttribute("type", "text/javascript");

            StringBuilder innerHtml = new StringBuilder();
            innerHtml.Append("\n\t$(function(){");

            innerHtml.AppendFormat("$(\"#{0}\") ", TreeViewTarget);
            innerHtml.Append("		.jstree({ ");
            innerHtml.Append("           \"plugins\": [\"themes\", \"" + DataFormat.ToString() + "\", \"ui\", \"crrm\", \"cookies\", \"dnd\", \"search\", \"types\", \"hotkeys\", \"contextmenu\", \"unique\" " + StrCheckBox + " ], ");
            innerHtml.AppendFormat("		    \"{0}\": { ", DataFormat.ToString());
            innerHtml.Append("		        \"ajax\": { ");
            innerHtml.AppendFormat("		            \"url\": \"{0}\", ", ActionUrl);
            innerHtml.Append("		            \"data\": function(n) { ");
            innerHtml.Append("		                return { ");
            innerHtml.Append("		                    \"operation\": \"get_children\", ");
            innerHtml.Append("		                    \"id\": n.attr ? n.attr(\"id\").replace(\"node_\", \"\") : 1 ");
            innerHtml.Append("		                }; ");
            innerHtml.Append("		            } ");
            innerHtml.Append("		        } ");
            innerHtml.Append("		    }, ");
            innerHtml.Append("  'core':{ 'animation':0  },");
            innerHtml.Append("		    \"themes\" : { ");
            innerHtml.Append("		        \"theme\": \"default\", ");
            innerHtml.Append("		        \"url\": \"/Content/JsTreeThemes/classic/style.css\", ");
            innerHtml.Append("		        \"dots\": true, ");
            innerHtml.Append("	            \"icons\" : false ");
            innerHtml.Append("	        }, ");
            innerHtml.Append("		    \"ui\": { ");
            innerHtml.Append("		        \"select_limit\" : 1, ");
            innerHtml.Append("	            \"select_multiple_modifier\" : \"ctrl\"           ");
            innerHtml.Append("		    }		     ");
            innerHtml.Append("		}) ");

            innerHtml.Append("\n\t});\n    ");
            builder.InnerHtml = innerHtml.ToString();
            return builder.ToString(TagRenderMode.Normal);
        }


        /// <summary>
        /// 初始化JsTree
        /// </summary>
        /// <typeparam name="T">数据源对应实体</typeparam>
        /// <param name="html"></param>
        /// <param name="treeId">树控件id</param>
        /// <param name="rootItems">数据源</param>
        /// <param name="childrenProperty">读取子节点的方法（Lambda）</param>
        /// <param name="itemContent">显示内容的表达式（Lambda）</param>
        /// <returns></returns>
        public static string TreeView<T>(this HtmlHelper html,
          string treeId,
          IEnumerable<T> rootItems,
          Func<T, IEnumerable<T>> childrenProperty,
          Func<T, string> itemContent)
        {
            return TreeView<T>(html, treeId, rootItems, childrenProperty, itemContent, true, "", false, "");
        }


        /// <summary>
        /// 初始化JsTree
        /// </summary>
        /// <typeparam name="T">数据源对应实体</typeparam>
        /// <param name="html"></param>
        /// <param name="treeId">树控件id</param>
        /// <param name="rootItems">数据源</param>
        /// <param name="childrenProperty">读取子节点的方法（Lambda）</param>
        /// <param name="itemContent">显示内容的表达式（Lambda）</param>
        /// <param name="includeJavaScript">是否包含初始化树控件脚本</param>
        /// <param name="emptyContent">空数据源时候显示内容</param>
        /// <param name="IsCheck">是否显示checkbox</param>
        /// <returns></returns>
        public static string TreeView<T>(this HtmlHelper html,
            string treeId,
            IEnumerable<T> rootItems,
            Func<T, IEnumerable<T>> childrenProperty,
            Func<T, string> itemContent,
            bool includeJavaScript,
            string emptyContent,
            bool IsCheck,
            string extendJs)
        {
            string StrCheckBox = IsCheck ? ",'checkbox'" : "";

            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("<div id='{0}'>", treeId);
            sb.AppendLine("<ul>");

            if (rootItems.Count() == 0)
            {
                sb.AppendFormat("<li>{0}</li>", emptyContent);
            }

            foreach (T item in rootItems)
            {
                RenderLi(sb, item, itemContent);
                AppendChildren(sb, item, childrenProperty, itemContent);
            }

            sb.AppendLine("</ul></div>");

            if (includeJavaScript)
            {
                sb.AppendLine("<script type='text/javascript'> ");
                sb.AppendLine("    $(document).ready(function() { ");
                sb.AppendLine("        $('#" + treeId + "').jstree({  ");
                sb.AppendLine(" 'core':{ 'animation':0 }, ");
                sb.AppendLine("           'plugins': ['themes', 'html_data', 'ui', 'crrm', 'cookies', 'dnd', 'search', 'types', 'hotkeys', 'contextmenu', 'unique' " + StrCheckBox + " ], ");
                sb.AppendLine("           'themes' : {'theme': 'classic','url': '/Content/JsTreeThemes/classic/style.css','dots': true,'icons' :true }, ");

                if (!string.IsNullOrEmpty(extendJs))
                {

       
                    sb.AppendLine("         callback:{");

                    sb.AppendLine("         "+extendJs);

                    sb.AppendLine("},");
                }

                sb.AppendLine("           'ui': { 'select_limit' : 1, 'select_multiple_modifier' : 'alt', 'selected_parent_close' : 'select_parent'} ");

                //sb.AppendLine(" core:{ 'initially_open' : [ 'root' ] } ");

                sb.AppendLine("          }) ");
                sb.AppendLine("  }) ");
                sb.AppendLine("</script> ");
            }

            return sb.ToString();
        }

        private static void AppendChildren<T>(StringBuilder sb, T root, Func<T, IEnumerable<T>> childrenProperty, Func<T, string> itemContent)
        {
            if (childrenProperty!=null)
            {
                var children = childrenProperty(root);
                if (children==null||children.Count() == 0)
                {
                    sb.AppendLine("</li>");
                    return;
                }

                sb.AppendLine("\r\n<ul>");
                foreach (T item in children)
                {
                    RenderLi(sb, item, itemContent);
                    AppendChildren(sb, item, childrenProperty, itemContent);
                }

                sb.AppendLine("</ul></li>");
            }            
        }

        private static void RenderLi<T>(StringBuilder sb, T item, Func<T, string> itemContent)
        {
            sb.AppendFormat("<li>{0}", itemContent(item));
        }
        
    }
}
