using System.Web.Mvc;
using System.Web.Routing;
using System.Text;

namespace QX.HtmlHelperLib.Interactions
{
    public static class ResizableExtensions
    {
        public static string Resizable(this HtmlHelper htmlHelper, string id, string value)
        {
            return Resizable(htmlHelper, id, value, false/*withoutScript*/);
        }

        public static string Resizable(this HtmlHelper htmlHelper, string id, string value, bool withoutScript)
        {
            return Resizable(htmlHelper, id, value, null/*resizableOptions*/, withoutScript);
        }

        public static string Resizable(this HtmlHelper htmlHelper, string id, string value, object resizableOptions)
        {
            return Resizable(htmlHelper, id, value, resizableOptions, false/*withoutScript*/);
        }

        public static string Resizable(this HtmlHelper htmlHelper, string id, string value, object resizableOptions, bool withoutScript)
        {
            return Resizable(htmlHelper, id, value, resizableOptions, null/*htmlAttributes*/, withoutScript);
        }

        public static string Resizable(this HtmlHelper htmlHelper, string id, string value, object dataPickerOptions, object htmlAttributes)
        {
            return Resizable(htmlHelper, id, value, dataPickerOptions, htmlAttributes, false/*withoutScript*/);
        }

        public static string Resizable(this HtmlHelper htmlHelper, string id, string value, object dataPickerOptions, object htmlAttributes, bool withoutScript)
        {
            // style
            var style = new TagBuilder("style");
            style.MergeAttribute("type", "text/css");
            style.InnerHtml += "\n\t#" + id + " { width: 150px; height: 150px; padding: 0.5em; }";
            style.InnerHtml += "\n\t#" + id + " h3 { text-align: center; margin: 0; }\n    ";

            // Create tag builder
            var builder = new TagBuilder("div");

            // Create valid id
            builder.GenerateId(id);

            // Add attributes
            builder.MergeAttributes(new RouteValueDictionary(htmlAttributes));
            builder.MergeAttribute("class", "ui-widget-content");

            builder.InnerHtml = "\n\t" + value + "\n    ";

            // Render tag
            return style.ToString(TagRenderMode.Normal) + "\n    " + builder.ToString(TagRenderMode.Normal) + (withoutScript == true ? string.Empty : "\n    " + RenderResizable(htmlHelper, new string[] { id }, dataPickerOptions));
        }

        public static string Resizable(this HtmlHelper htmlHelper, string id, string value, ResizableTypes resizableType)
        {
            return Resizable(htmlHelper, id, value, resizableType, false/*withoutScript*/);
        }

        public static string Resizable(this HtmlHelper htmlHelper, string id, string value, ResizableTypes resizableType, bool withoutScript)
        {
            return Resizable(htmlHelper, id, value, resizableType, null/*htmlAttributes*/, withoutScript);
        }

        public static string Resizable(this HtmlHelper htmlHelper, string id, string value, ResizableTypes resizableType, object htmlAttributes)
        {
            return Resizable(htmlHelper, id, value, resizableType, htmlAttributes, false/*withoutScript*/);
        }

        public static string Resizable(this HtmlHelper htmlHelper, string id, string value, ResizableTypes resizableType, object htmlAttributes, bool withoutScript)
        {
            // style
            var style = new TagBuilder("style");
            style.MergeAttribute("type", "text/css");
            style.InnerHtml += "\n\t#" + id + " { width: 150px; height: 150px; padding: 0.5em; }";
            style.InnerHtml += "\n\t#" + id + " h3 { text-align: center; margin: 0; }\n    ";

            // Create tag builder
            var builder = new TagBuilder("div");

            // Create valid id
            builder.GenerateId(id);

            // Add attributes
            builder.MergeAttributes(new RouteValueDictionary(htmlAttributes));
            builder.MergeAttribute("class", "ui-widget-content");

            builder.InnerHtml = value;

            // Render tag
            return style.ToString(TagRenderMode.Normal) + "\n    " + builder.ToString(TagRenderMode.Normal)
                + (withoutScript == true ? string.Empty : "\n    " + RenderResizable(htmlHelper, new string[] { id }, resizableType));
        }

        public static string RenderResizable(this HtmlHelper htmlHelper, string[] resizableIds)
        {
            return RenderResizable(htmlHelper, resizableIds, null/*resizableOptions*/);
        }

        public static string RenderResizable(this HtmlHelper htmlHelper, string[] resizableIds, object resizableOptions)
        {
            // Create tag builder
            var builder = new TagBuilder("script");

            builder.MergeAttribute("type", "text/javascript");

            StringBuilder innerHtml = new StringBuilder();
            innerHtml.Append("\n\t$(function(){");

            if (resizableOptions != null)
            {
                TagBuilder tg = new TagBuilder("a");
                tg.MergeAttributes(new RouteValueDictionary(resizableOptions));

                // Add attributes
                int length = tg.ToString(TagRenderMode.SelfClosing).Length;
                string atts = "";
                if (length > 5)
                    atts = tg.ToString(TagRenderMode.SelfClosing).Replace('=', ':').Replace('"', '\0').Replace(' ', ',').Substring(3, length - 6);
                else
                    atts = string.Empty;

                foreach (var item in resizableIds)
                {
                    innerHtml.Append("\n\t    $('#" + item + "').resizable({" + atts + "});");
                }
            }
            else
            {
                foreach (var item in resizableIds)
                {
                    innerHtml.Append("\n\t    $('#" + item + "').resizable();");
                }
            }

            innerHtml.Append("\n\t});\n    ");

            builder.InnerHtml = innerHtml.ToString();

            StringBuilder ids = new StringBuilder();
            foreach (var id in resizableIds)
            {
                ids.AppendFormat(",{0}", id);
            }

            int len = ids.Length;

            // Render tag
            return builder.ToString(TagRenderMode.Normal);
        }

        public static string RenderResizable(this HtmlHelper htmlHelper, string[] resizableIds, ResizableTypes resizableType)
        {
            switch (resizableType)
            {
                case ResizableTypes.Recommendation:
                    return RenderResizable(htmlHelper, resizableIds, new {  });
                case ResizableTypes.DefaultFuntionality:
                    return RenderResizable(htmlHelper, resizableIds, new { });
                default:    // Recommendation
                    return RenderResizable(htmlHelper, resizableIds, new { });
            }
        }
    }

    public enum ResizableTypes : int
    {
        Recommendation = 0,
        DefaultFuntionality = 1
    }
}
