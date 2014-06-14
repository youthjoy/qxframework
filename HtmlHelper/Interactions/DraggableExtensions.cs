using System.Web.Mvc;
using System.Web.Routing;
using System.Text;

namespace QX.HtmlHelperLib.Interactions
{
    public static class DraggableExtensions
    {
        public static string Draggable(this HtmlHelper htmlHelper, string id, string value)
        {
            return Draggable(htmlHelper, id, value, false/*withoutScript*/);
        }

        public static string Draggable(this HtmlHelper htmlHelper, string id, string value, bool withoutScript)
        {
            return Draggable(htmlHelper, id, value, null/*draggableOptions*/, withoutScript);
        }

        public static string Draggable(this HtmlHelper htmlHelper, string id, string value, object draggableOptions)
        {
            return Draggable(htmlHelper, id, value, draggableOptions, false/*withoutScript*/);
        }

        public static string Draggable(this HtmlHelper htmlHelper, string id, string value, object draggableOptions, bool withoutScript)
        {
            return Draggable(htmlHelper, id, value, draggableOptions, null/*htmlAttributes*/, withoutScript);
        }

        public static string Draggable(this HtmlHelper htmlHelper, string id, string value, object dataPickerOptions, object htmlAttributes)
        {
            return Draggable(htmlHelper, id, value, dataPickerOptions, htmlAttributes, false/*withoutScript*/);
        }

        public static string Draggable(this HtmlHelper htmlHelper, string id, string value, object dataPickerOptions, object htmlAttributes, bool withoutScript)
        {
            var style = new TagBuilder("style");
            style.MergeAttribute("type", "text/css");
            style.InnerHtml += "\n\t#" + id + " { width: 150px; height: 150px; padding: 0.5em; }\n    ";

            // Create tag builder
            var builder = new TagBuilder("div");

            // Create valid id
            builder.GenerateId(id);

            // Add attributes
            builder.MergeAttributes(new RouteValueDictionary(htmlAttributes));
            builder.MergeAttribute("class", "ui-widget-content");

            builder.InnerHtml += "\n\t";
            builder.InnerHtml += value.Replace("<br />", "\n\t").Replace("\n", "\n\t");
            builder.InnerHtml += "\n    ";

            // Render tag
            return style.ToString(TagRenderMode.Normal) + "\n    " + builder.ToString(TagRenderMode.Normal) + (withoutScript == true ? string.Empty : "\n    " + RenderDraggable(htmlHelper, new string[] { id }, dataPickerOptions));
        }

        public static string Draggable(this HtmlHelper htmlHelper, string id, string value, DraggableTypes draggableType)
        {
            return Draggable(htmlHelper, id, value, draggableType, false/*withoutScript*/);
        }

        public static string Draggable(this HtmlHelper htmlHelper, string id, string value, DraggableTypes draggableType, bool withoutScript)
        {
            return Draggable(htmlHelper, id, value, draggableType, null/*htmlAttributes*/, withoutScript);
        }

        public static string Draggable(this HtmlHelper htmlHelper, string id, string value, DraggableTypes draggableType, object htmlAttributes)
        {
            return Draggable(htmlHelper, id, value, draggableType, htmlAttributes, false/*withoutScript*/);
        }

        public static string Draggable(this HtmlHelper htmlHelper, string id, string value, DraggableTypes draggableType, object htmlAttributes, bool withoutScript)
        {
            var style = new TagBuilder("style");
            style.MergeAttribute("type", "text/css");
            style.InnerHtml += "\n\t#" + id + " { width: 150px; height: 150px; padding: 0.5em; }\n    ";

            // Create tag builder
            var builder = new TagBuilder("div");

            // Create valid id
            builder.GenerateId(id);

            // Add attributes
            builder.MergeAttributes(new RouteValueDictionary(htmlAttributes));
            builder.MergeAttribute("class", "ui-widget-content");

            builder.InnerHtml += "\n\t";
            builder.InnerHtml += value.Replace("<br />", "\n\t").Replace("\n", "\n\t");
            builder.InnerHtml += "\n    ";

            // Render tag
            return "<!-- " + id + " Draggable Control //-->" + "\n    " + builder.ToString(TagRenderMode.Normal)
                + (withoutScript == true ? string.Empty : "\n    " + RenderDraggable(htmlHelper, new string[] { id }, draggableType));
        }

        public static string RenderDraggable(this HtmlHelper htmlHelper, string[] draggableIds)
        {
            return RenderDraggable(htmlHelper, draggableIds, null/*draggableOptions*/);
        }

        public static string RenderDraggable(this HtmlHelper htmlHelper, string[] draggableIds, object draggableOptions)
        {
            // Create tag builder
            var builder = new TagBuilder("script");

            builder.MergeAttribute("type", "text/javascript");

            StringBuilder innerHtml = new StringBuilder();
            innerHtml.Append("\n\t$(function(){");

            if (draggableOptions != null)
            {
                TagBuilder tg = new TagBuilder("a");
                tg.MergeAttributes(new RouteValueDictionary(draggableOptions));

                // Add attributes
                int length = tg.ToString(TagRenderMode.SelfClosing).Length;
                string atts = "";
                if (length > 5)
                    atts = tg.ToString(TagRenderMode.SelfClosing).Replace('=', ':').Replace('"', '\0').Replace(' ', ',').Substring(3, length - 6);
                else
                    atts = string.Empty;

                foreach (var item in draggableIds)
                {
                    innerHtml.Append("\n\t    $('#" + item + "').draggable({" + atts + "});");
                }
            }
            else
            {
                foreach (var item in draggableIds)
                {
                    innerHtml.Append("\n\t    $('#" + item + "').draggable();");
                }
            }

            innerHtml.Append("\n\t});\n    ");

            builder.InnerHtml = innerHtml.ToString();

            StringBuilder ids = new StringBuilder();
            foreach (var id in draggableIds)
            {
                ids.AppendFormat(",{0}", id);
            }

            int len = ids.Length;

            // Render tag
            return builder.ToString(TagRenderMode.Normal);
        }

        public static string RenderDraggable(this HtmlHelper htmlHelper, string[] draggableIds, DraggableTypes draggableType)
        {
            switch (draggableType)
            {
                case DraggableTypes.Recommendation:
                    return RenderDraggable(htmlHelper, draggableIds, new { });
                case DraggableTypes.DefaultFuntionality:
                    return RenderDraggable(htmlHelper, draggableIds, new { });
                default:    // Recommendation
                    return RenderDraggable(htmlHelper, draggableIds, new { });
            }
        }
    }

    public enum DraggableTypes : int
    {
        Recommendation = 0,
        DefaultFuntionality = 1
    }
}
