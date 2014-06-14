using System.Web.Mvc;
using System.Web.Routing;
using System.Text;

namespace QX.HtmlHelperLib.Widgets
{
    public static class TabsExtensions
    {
        public static string Tabs(this HtmlHelper htmlHelper, string id, string[] title, string[] content)
        {
            return Tabs(htmlHelper, id, title, content, false/*withoutScript*/);
        }

        public static string Tabs(this HtmlHelper htmlHelper, string id, string[] title, string[] content, bool withoutScript)
        {
            return Tabs(htmlHelper, id, title, content, null/*tabsOptions*/, withoutScript);
        }

        public static string Tabs(this HtmlHelper htmlHelper, string id, string[] title, string[] content, object tabsOptions)
        {
            return Tabs(htmlHelper, id, title, content, tabsOptions, false/*withoutScript*/);
        }

        public static string Tabs(this HtmlHelper htmlHelper, string id, string[] title, string[] content, object tabsOptions, bool withoutScript)
        {
            return Tabs(htmlHelper, id, title, content, tabsOptions, null/*htmlAttributes*/, withoutScript);
        }

        public static string Tabs(this HtmlHelper htmlHelper, string id, string[] title, string[] content, object dataPickerOptions, object htmlAttributes)
        {
            return Tabs(htmlHelper, id, title, content, dataPickerOptions, htmlAttributes, false/*withoutScript*/);
        }

        public static string Tabs(this HtmlHelper htmlHelper, string id, string[] title, string[] content, object dataPickerOptions, object htmlAttributes, bool withoutScript)
        {
            // Create tag builder
            var builder = new TagBuilder("div");

            // Create valid id
            builder.GenerateId(id);

            // Add attributes
            builder.MergeAttributes(new RouteValueDictionary(htmlAttributes));

            // title
            builder.InnerHtml += "\n    <ul>";
            int i = 1;
            foreach (var t in title)
            {
                builder.InnerHtml += string.Format("\n\t<li><a href=\"#{0}_tabs-{1}\">{2}</a></li>",id, i++, t);
            }
            builder.InnerHtml += "\n    </ul>";

            // content
            i = 1;
            foreach (var c in content)
            {
                builder.InnerHtml += string.Format("\n    <div id=\"{0}_tabs-{1}\">\n\t{2}\n    </div>",id, i++, c);
            }

            // Render tag
            return builder.ToString(TagRenderMode.Normal) + (withoutScript == true ? string.Empty : "\n    " + RenderTabs(htmlHelper, new string[] { id }, dataPickerOptions));
        }

        public static string Tabs(this HtmlHelper htmlHelper, string id, string[] title, string[] content, TabsTypes tabsType)
        {
            return Tabs(htmlHelper, id, title, content, tabsType, false/*withoutScript*/);
        }

        public static string Tabs(this HtmlHelper htmlHelper, string id, string[] title, string[] content, TabsTypes tabsType, bool withoutScript)
        {
            return Tabs(htmlHelper, id, title, content, tabsType, null/*htmlAttributes*/, withoutScript);
        }

        public static string Tabs(this HtmlHelper htmlHelper, string id, string[] title, string[] content, TabsTypes tabsType, object htmlAttributes)
        {
            return Tabs(htmlHelper, id, title, content, tabsType, htmlAttributes, false/*withoutScript*/);
        }

        public static string Tabs(this HtmlHelper htmlHelper, string id, string[] title, string[] content, TabsTypes tabsType, object htmlAttributes, bool withoutScript)
        {
            // Create tag builder
            var builder = new TagBuilder("div");

            // Create valid id
            builder.GenerateId(id);

            // Add attributes
            builder.MergeAttributes(new RouteValueDictionary(htmlAttributes));

            // title
            builder.InnerHtml += "<ul>";
            int i = 1;
            foreach (var t in title)
            {
                builder.InnerHtml += string.Format("<li><a href=\"#{0}_tabs-{1}\">{2}</a></li>",id, i++, t);
            }
            builder.InnerHtml += "</ul>";

            // content
            i = 1;
            foreach (var c in content)
            {
                builder.InnerHtml += string.Format("<div id=\"#{0}_tabs-{1}\">{2}</div>",id, i++, c);
            }

            // Render tag
            return builder.ToString(TagRenderMode.Normal)
                + (withoutScript == true ? string.Empty : "\n    " + RenderTabs(htmlHelper, new string[] { id }, tabsType));
        }

        public static string RenderTabs(this HtmlHelper htmlHelper, string[] tabsIds)
        {
            return RenderTabs(htmlHelper, tabsIds, null/*tabsOptions*/);
        }

        public static string RenderTabs(this HtmlHelper htmlHelper, string[] tabsIds, object tabsOptions)
        {
            // Create tag builder
            var builder = new TagBuilder("script");

            builder.MergeAttribute("type", "text/javascript");

            StringBuilder innerHtml = new StringBuilder();
            innerHtml.Append("\n\t$(function(){");

            if (tabsOptions != null)
            {
                TagBuilder tg = new TagBuilder("a");
                tg.MergeAttributes(new RouteValueDictionary(tabsOptions));

                // Add attributes
                int length = tg.ToString(TagRenderMode.SelfClosing).Length;
                string atts = "";
                if (length > 5)
                    atts = tg.ToString(TagRenderMode.SelfClosing).Replace('=', ':').Replace('"', '\0').Replace(' ', ',').Substring(3, length - 6);
                else
                    atts = string.Empty;

                foreach (var item in tabsIds)
                {
                    innerHtml.Append("\n\t    $('#" + item + "').tabs({" + atts + "});");
                }
            }
            else
            {
                foreach (var item in tabsIds)
                {
                    innerHtml.Append("\n\t    $('#" + item + "').tabs();");
                }
            }

            innerHtml.Append("\n\t});\n    ");

            builder.InnerHtml = innerHtml.ToString();

            StringBuilder ids = new StringBuilder();
            foreach (var id in tabsIds)
            {
                ids.AppendFormat(",{0}", id);
            }

            int len = ids.Length;

            // Render tag
            return builder.ToString(TagRenderMode.Normal);
        }

        public static string RenderTabs(this HtmlHelper htmlHelper, string[] tabsIds, TabsTypes tabsType)
        {
            switch (tabsType)
            {
                case TabsTypes.Recommendation:
                    return RenderTabs(htmlHelper, tabsIds, new {  });
                case TabsTypes.DefaultFuntionality:
                    return RenderTabs(htmlHelper, tabsIds, new { });
                default:    // Recommendation
                    return RenderTabs(htmlHelper, tabsIds, new { });
            }
        }
    }

    public enum TabsTypes : int
    {
        Recommendation = 0,
        DefaultFuntionality = 1
    }
}
