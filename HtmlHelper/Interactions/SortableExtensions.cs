using System.Web.Mvc;
using System.Web.Routing;
using System.Text;

namespace QX.HtmlHelperLib.Interactions
{
    public static class SortableExtensions
    {
        public static string Sortable(this HtmlHelper htmlHelper, string id, string[] value)
        {
            return Sortable(htmlHelper, id, value, false/*withoutScript*/);
        }

        public static string Sortable(this HtmlHelper htmlHelper, string id, string[] value, bool withoutScript)
        {
            return Sortable(htmlHelper, id, value, null/*sortableOptions*/, withoutScript);
        }

        public static string Sortable(this HtmlHelper htmlHelper, string id, string[] value, object sortableOptions)
        {
            return Sortable(htmlHelper, id, value, sortableOptions, false/*withoutScript*/);
        }

        public static string Sortable(this HtmlHelper htmlHelper, string id, string[] value, object sortableOptions, bool withoutScript)
        {
            return Sortable(htmlHelper, id, value, sortableOptions, null/*htmlAttributes*/, withoutScript);
        }

        public static string Sortable(this HtmlHelper htmlHelper, string id, string[] value, object dataPickerOptions, object htmlAttributes)
        {
            return Sortable(htmlHelper, id, value, dataPickerOptions, htmlAttributes, false/*withoutScript*/);
        }

        public static string Sortable(this HtmlHelper htmlHelper, string id, string[] value, object dataPickerOptions, object htmlAttributes, bool withoutScript)
        {
            // Create tag builder
            var builder = new TagBuilder("ol");

            // Create valid id
            builder.GenerateId(id);

            // Add attributes
            builder.MergeAttributes(new RouteValueDictionary(htmlAttributes));

            foreach (var v in value)
            {
                builder.InnerHtml += string.Format("\n\t<li class=\"{0}\"><span class=\"ui-icon ui-icon-arrowthick-2-n-s\"></span>{1}</li>", "ui-state-default", v);
            }
            builder.InnerHtml += "\n    ";

            // Render tag
            return builder.ToString(TagRenderMode.Normal) + (withoutScript == true ? string.Empty : "\n    " + RenderSortable(htmlHelper, new string[] { id }, dataPickerOptions));
        }

        public static string Sortable(this HtmlHelper htmlHelper, string id, string[] value, SortableTypes sortableType)
        {
            return Sortable(htmlHelper, id, value, sortableType, false/*withoutScript*/);
        }

        public static string Sortable(this HtmlHelper htmlHelper, string id, string[] value, SortableTypes sortableType, bool withoutScript)
        {
            return Sortable(htmlHelper, id, value, sortableType, null/*htmlAttributes*/, withoutScript);
        }

        public static string Sortable(this HtmlHelper htmlHelper, string id, string[] value, SortableTypes sortableType, object htmlAttributes)
        {
            return Sortable(htmlHelper, id, value, sortableType, htmlAttributes, false/*withoutScript*/);
        }

        public static string Sortable(this HtmlHelper htmlHelper, string id, string[] value, SortableTypes sortableType, object htmlAttributes, bool withoutScript)
        {
            // Create tag builder
            var builder = new TagBuilder("ol");

            // Create valid id
            builder.GenerateId(id);

            // Add attributes
            builder.MergeAttributes(new RouteValueDictionary(htmlAttributes));

            foreach (var v in value)
            {
                builder.InnerHtml += string.Format("\n\t<li class=\"{0}\"><span class=\"ui-icon ui-icon-arrowthick-2-n-s\"></span>{1}</li>", "ui-state-default", v);
            }

            // Render tag
            return builder.ToString(TagRenderMode.Normal)
                + (withoutScript == true ? string.Empty : "\n    " + RenderSortable(htmlHelper, new string[] { id }, sortableType));
        }

        public static string RenderSortable(this HtmlHelper htmlHelper, string[] sortableIds)
        {
            return RenderSortable(htmlHelper, sortableIds, null/*sortableOptions*/);
        }

        public static string RenderSortable(this HtmlHelper htmlHelper, string[] sortableIds, object sortableOptions)
        {
            // Render Style
            StringBuilder styles = new StringBuilder();
            for (int i = 0; i < sortableIds.Length; i++)
            {
                styles.Append(RenderSortableStyle(sortableIds[i]) + "\n    ");
            }

            // Create tag builder
            var builder = new TagBuilder("script");

            builder.MergeAttribute("type", "text/javascript");

            StringBuilder innerHtml = new StringBuilder();
            innerHtml.Append("\n\t$(function(){");

            if (sortableOptions != null)
            {
                TagBuilder tg = new TagBuilder("a");
                tg.MergeAttributes(new RouteValueDictionary(sortableOptions));

                // Add attributes
                int length = tg.ToString(TagRenderMode.SelfClosing).Length;
                string atts = "";
                if (length > 5)
                    atts = tg.ToString(TagRenderMode.SelfClosing).Replace('=', ':').Replace('"', '\0').Replace(' ', ',').Substring(3, length - 6);
                else
                    atts = string.Empty;

                foreach (var item in sortableIds)
                {
                    innerHtml.Append("\n\t    $('#" + item + "').sortable({" + atts + "});");
                }
            }
            else
            {
                foreach (var item in sortableIds)
                {
                    innerHtml.Append("\n\t    $('#" + item + "').sortable();");
                }
            }

            foreach (var id in sortableIds)
            {
                innerHtml.Append("\n\t    $('#" + id + "').disableSelection();");
            }

            innerHtml.Append("\n\t});\n    ");

            builder.InnerHtml = innerHtml.ToString();

            StringBuilder ids = new StringBuilder();
            foreach (var id in sortableIds)
            {
                ids.AppendFormat(",{0}", id);
            }

            int len = ids.Length;

            // Render tag
            return styles + builder.ToString(TagRenderMode.Normal);
        }

        public static string RenderSortable(this HtmlHelper htmlHelper, string[] sortableIds, SortableTypes sortableType)
        {
            switch (sortableType)
            {
                case SortableTypes.Recommendation:
                    return RenderSortable(htmlHelper, sortableIds, new { });
                case SortableTypes.DefaultFuntionality:
                    return RenderSortable(htmlHelper, sortableIds, new { });
                default:    // Recommendation
                    return RenderSortable(htmlHelper, sortableIds, new { });
            }
        }

        public static string RenderSortableStyle(string id)
        {
            // Create tag builder
            var builder = new TagBuilder("style");

            builder.MergeAttribute("type", "text/css");

            builder.InnerHtml += "\n\t#" + id + " { list-style-type: none; margin: 0; padding: 0; width: 60%; }";
            builder.InnerHtml += "\n\t#" + id + " li { margin: 0 3px 3px 3px; padding: 0.4em; padding-left: 1.5em; font-size: 1.4em; height: 18px; }";
            builder.InnerHtml += "\n\t#" + id + " li span { position: absolute; margin-left: -1.3em; }\n    ";


            return builder.ToString(TagRenderMode.Normal);
        }
    }

    public enum SortableTypes : int
    {
        Recommendation = 0,
        DefaultFuntionality = 1
    }
}
