using System.Web.Mvc;
using System.Web.Routing;
using System.Text;

namespace QX.HtmlHelperLib.Widgets
{
    public static class ProgressbarExtensions
    {
        public static string Progressbar(this HtmlHelper htmlHelper, string id, string value)
        {
            return Progressbar(htmlHelper, id, value, false/*withoutScript*/);
        }

        public static string Progressbar(this HtmlHelper htmlHelper, string id, string value, bool withoutScript)
        {
            return Progressbar(htmlHelper, id, value, null/*progressbarOptions*/, withoutScript);
        }

        public static string Progressbar(this HtmlHelper htmlHelper, string id, string value, object progressbarOptions)
        {
            return Progressbar(htmlHelper, id, value, progressbarOptions, false/*withoutScript*/);
        }

        public static string Progressbar(this HtmlHelper htmlHelper, string id, string value, object progressbarOptions, bool withoutScript)
        {
            return Progressbar(htmlHelper, id, value, progressbarOptions, null/*htmlAttributes*/, withoutScript);
        }

        public static string Progressbar(this HtmlHelper htmlHelper, string id, string value, object dataPickerOptions, object htmlAttributes)
        {
            return Progressbar(htmlHelper, id, value, dataPickerOptions, htmlAttributes, false/*withoutScript*/);
        }

        public static string Progressbar(this HtmlHelper htmlHelper, string id, string value, object dataPickerOptions, object htmlAttributes, bool withoutScript)
        {
            // Create tag builder
            var builder = new TagBuilder("div");

            // Create valid id
            builder.GenerateId(id);

            // Add attributes
            builder.MergeAttributes(new RouteValueDictionary(htmlAttributes));

            // Render tag
            return "<!-- " + id + " Progressbar Control //-->" + "\n    " + builder.ToString(TagRenderMode.Normal) + (withoutScript == true ? string.Empty : "\n    " + RenderProgressbar(htmlHelper, new string[] { id }, dataPickerOptions));
        }

        public static string Progressbar(this HtmlHelper htmlHelper, string id, string value, ProgressbarTypes progressbarType)
        {
            return Progressbar(htmlHelper, id, value, progressbarType, false/*withoutScript*/);
        }

        public static string Progressbar(this HtmlHelper htmlHelper, string id, string value, ProgressbarTypes progressbarType, bool withoutScript)
        {
            return Progressbar(htmlHelper, id, value, progressbarType, null/*htmlAttributes*/, withoutScript);
        }

        public static string Progressbar(this HtmlHelper htmlHelper, string id, string value, ProgressbarTypes progressbarType, object htmlAttributes)
        {
            return Progressbar(htmlHelper, id, value, progressbarType, htmlAttributes, false/*withoutScript*/);
        }

        public static string Progressbar(this HtmlHelper htmlHelper, string id, string value, ProgressbarTypes progressbarType, object htmlAttributes, bool withoutScript)
        {
            // Create tag builder
            var builder = new TagBuilder("div");

            // Create valid id
            builder.GenerateId(id);

            // Add attributes
            builder.MergeAttributes(new RouteValueDictionary(htmlAttributes));

            // Render tag
            return "<!-- " + id + " Progressbar Control //-->" + "\n    " + builder.ToString(TagRenderMode.Normal)
                + (withoutScript == true ? string.Empty : "\n    " + RenderProgressbar(htmlHelper, new string[] { id }, progressbarType));
        }

        public static string RenderProgressbar(this HtmlHelper htmlHelper, string[] progressbarIds)
        {
            return RenderProgressbar(htmlHelper, progressbarIds, null/*progressbarOptions*/);
        }

        public static string RenderProgressbar(this HtmlHelper htmlHelper, string[] progressbarIds, object progressbarOptions)
        {
            // Create tag builder
            var builder = new TagBuilder("script");

            builder.MergeAttribute("type", "text/javascript");

            StringBuilder innerHtml = new StringBuilder();
            innerHtml.Append("\n\t$(function(){");

            if (progressbarOptions != null)
            {
                TagBuilder tg = new TagBuilder("a");
                tg.MergeAttributes(new RouteValueDictionary(progressbarOptions));

                // Add attributes
                int length = tg.ToString(TagRenderMode.SelfClosing).Length;
                string atts = "";
                if (length > 5)
                    atts = tg.ToString(TagRenderMode.SelfClosing).Replace('=', ':').Replace('"', '\0').Replace(' ', ',').Substring(3, length - 6);
                else
                    atts = string.Empty;

                foreach (var item in progressbarIds)
                {
                    innerHtml.Append("\n\t    $('#" + item + "').progressbar({" + atts + "});");
                }
            }
            else
            {
                foreach (var item in progressbarIds)
                {
                    innerHtml.Append("\n\t    $('#" + item + "').progressbar();");
                }
            }

            innerHtml.Append("\n\t});\n    ");

            builder.InnerHtml = innerHtml.ToString();

            StringBuilder ids = new StringBuilder();
            foreach (var id in progressbarIds)
            {
                ids.AppendFormat(",{0}", id);
            }

            int len = ids.Length;

            // Render tag
            return "<!-- " + ids.ToString(1, len - 1) + " Progressbar Script //-->" + "\n    " + builder.ToString(TagRenderMode.Normal);
        }

        public static string RenderProgressbar(this HtmlHelper htmlHelper, string[] progressbarIds, ProgressbarTypes progressbarType)
        {
            switch (progressbarType)
            {
                case ProgressbarTypes.Recommendation:
                    return RenderProgressbar(htmlHelper, progressbarIds, new {  });
                case ProgressbarTypes.DefaultFuntionality:
                    return RenderProgressbar(htmlHelper, progressbarIds, new { });
                default:    // Recommendation
                    return RenderProgressbar(htmlHelper, progressbarIds, new { });
            }
        }
    }

    public enum ProgressbarTypes : int
    {
        Recommendation = 0,
        DefaultFuntionality = 1
    }
}
