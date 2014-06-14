using System.Web.Mvc;
using System.Web.Routing;
using System.Text;

namespace QX.HtmlHelperLib.Interactions
{
    public static class SelectableExtensions
    {
        public static string Selectable(this HtmlHelper htmlHelper, string id, string[] value)
        {
            return Selectable(htmlHelper, id, value, false/*withoutScript*/);
        }

        public static string Selectable(this HtmlHelper htmlHelper, string id, string[] value, bool withoutScript)
        {
            return Selectable(htmlHelper, id, value, null/*selectableOptions*/, withoutScript);
        }

        public static string Selectable(this HtmlHelper htmlHelper, string id, string[] value, object selectableOptions)
        {
            return Selectable(htmlHelper, id, value, selectableOptions, false/*withoutScript*/);
        }

        public static string Selectable(this HtmlHelper htmlHelper, string id, string[] value, object selectableOptions, bool withoutScript)
        {
            return Selectable(htmlHelper, id, value, selectableOptions, null/*htmlAttributes*/, withoutScript);
        }

        public static string Selectable(this HtmlHelper htmlHelper, string id, string[] value, object dataPickerOptions, object htmlAttributes)
        {
            return Selectable(htmlHelper, id, value, dataPickerOptions, htmlAttributes, false/*withoutScript*/);
        }

        public static string Selectable(this HtmlHelper htmlHelper, string id, string[] value, object dataPickerOptions, object htmlAttributes, bool withoutScript)
        {
            // Create tag builder
            var builder = new TagBuilder("ol");

            // Create valid id
            builder.GenerateId(id);

            // Add attributes
            builder.MergeAttributes(new RouteValueDictionary(htmlAttributes));

            foreach (var v in value)
            {
                builder.InnerHtml += string.Format("\n\t<li class=\"{0}\">{1}</li>", "ui-widget-content", v);
            }

            // Render tag
            return builder.ToString(TagRenderMode.Normal) + (withoutScript == true ? string.Empty : "\n    " + RenderSelectable(htmlHelper, new string[] { id }, dataPickerOptions));
        }

        public static string Selectable(this HtmlHelper htmlHelper, string id, string[] value, SelectableTypes selectableType)
        {
            return Selectable(htmlHelper, id, value, selectableType, false/*withoutScript*/);
        }

        public static string Selectable(this HtmlHelper htmlHelper, string id, string[] value, SelectableTypes selectableType, bool withoutScript)
        {
            return Selectable(htmlHelper, id, value, selectableType, null/*htmlAttributes*/, withoutScript);
        }

        public static string Selectable(this HtmlHelper htmlHelper, string id, string[] value, SelectableTypes selectableType, object htmlAttributes)
        {
            return Selectable(htmlHelper, id, value, selectableType, htmlAttributes, false/*withoutScript*/);
        }

        public static string Selectable(this HtmlHelper htmlHelper, string id, string[] value, SelectableTypes selectableType, object htmlAttributes, bool withoutScript)
        {
            // Create tag builder
            var builder = new TagBuilder("div");

            // Create valid id
            builder.GenerateId(id);

            // Add attributes
            builder.MergeAttributes(new RouteValueDictionary(htmlAttributes));

            foreach (var v in value)
            {
                builder.InnerHtml += string.Format("\n\t<li class=\"{0}\">{1}</li>", "ui-widget-content", v);
            }

            // Render tag
            return builder.ToString(TagRenderMode.Normal)
                + (withoutScript == true ? string.Empty : "\n    " + RenderSelectable(htmlHelper, new string[] { id }, selectableType));
        }

        public static string RenderSelectable(this HtmlHelper htmlHelper, string[] selectableIds)
        {
            return RenderSelectable(htmlHelper, selectableIds, null/*selectableOptions*/);
        }

        public static string RenderSelectable(this HtmlHelper htmlHelper, string[] selectableIds, object selectableOptions)
        {
            // Render Style
            StringBuilder styles = new StringBuilder();
            for(int i = 0; i < selectableIds.Length; i++)
            {
                styles.Append(RenderSelectableStyle(selectableIds[i]) + "\n    ");
            }

            // Create tag builder
            var builder = new TagBuilder("script");

            builder.MergeAttribute("type", "text/javascript");

            StringBuilder innerHtml = new StringBuilder();
            innerHtml.Append("\n\t$(function(){");

            if (selectableOptions != null)
            {
                TagBuilder tg = new TagBuilder("a");
                tg.MergeAttributes(new RouteValueDictionary(selectableOptions));

                // Add attributes
                int length = tg.ToString(TagRenderMode.SelfClosing).Length;
                string atts = "";
                if (length > 5)
                    atts = tg.ToString(TagRenderMode.SelfClosing).Replace('=', ':').Replace('"', '\0').Replace(' ', ',').Substring(3, length - 6);
                else
                    atts = string.Empty;

                foreach (var item in selectableIds)
                {
                    innerHtml.Append("\n\t    $('#" + item + "').selectable({" + atts + "});");
                }
            }
            else
            {
                foreach (var item in selectableIds)
                {
                    innerHtml.Append("\n\t    $('#" + item + "').selectable();");
                }
            }

            innerHtml.Append("\n\t});\n    ");

            builder.InnerHtml = innerHtml.ToString();

            StringBuilder ids = new StringBuilder();
            foreach (var id in selectableIds)
            {
                ids.AppendFormat(",{0}", id);
            }

            int len = ids.Length;

            // Render tag
            return styles + builder.ToString(TagRenderMode.Normal);
        }

        public static string RenderSelectable(this HtmlHelper htmlHelper, string[] selectableIds, SelectableTypes selectableType)
        {
            switch (selectableType)
            {
                case SelectableTypes.Recommendation:
                    return RenderSelectable(htmlHelper, selectableIds, new {  });
                case SelectableTypes.DefaultFuntionality:
                    return RenderSelectable(htmlHelper, selectableIds, new { });
                default:    // Recommendation
                    return RenderSelectable(htmlHelper, selectableIds, new { });
            }
        }

        public static string RenderSelectableStyle(string id)
        {
            // Create tag builder
            var builder = new TagBuilder("style");

            builder.MergeAttribute("type", "text/css");

            builder.InnerHtml += "\n\t#feedback { font-size: 1.4em; }";
            builder.InnerHtml += "\n\t#" + id + " .ui-selecting { background: #FECA40; }";
            builder.InnerHtml += "\n\t#" + id + " .ui-selected { background: #F39814; color: white; }";
            builder.InnerHtml += "\n\t#" + id + " { list-style-type: none; margin: 0; padding: 0; width: 60%; }";
            builder.InnerHtml += "\n\t#" + id + " li { margin: 3px; padding: 0.4em; font-size: 1.4em; height: 18px; }\n    ";

            return builder.ToString(TagRenderMode.Normal);
        }
    }

    public enum SelectableTypes : int
    {
        Recommendation = 0,
        DefaultFuntionality = 1
    }
}
