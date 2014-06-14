using System.Web.Mvc;
using System.Text;
using System;

namespace QX.HtmlHelperLib.Effects
{
    public static class ToggleClassExtensions
    {
        public static string ToggleClass(this HtmlHelper htmlHelper, string[] targetIds, string evt, string newClass, int delay)
        {
            return ToggleClass(htmlHelper, null/*sourceIds*/, targetIds, evt, newClass, delay);
        }
        public static string ToggleClass(this HtmlHelper htmlHelper, string[] sourceIds, string[] targetIds, string evt, string newClass, int delay)
        {
            if (targetIds == null || targetIds.Length == 0)
                return string.Empty;
            if (sourceIds == null || sourceIds.Length == 0)
                sourceIds = targetIds;

            // Create tag builder
            var builder = new TagBuilder("script");

            builder.MergeAttribute("type", "text/javascript");

            StringBuilder innerHtml = new StringBuilder();
            innerHtml.Append("\n\t$(function(){");

            foreach (var sourceId in sourceIds)
            {
                innerHtml.Append("\n\t    $('#" + sourceId + "')." + evt + "(function() {");

                foreach (var targetId in targetIds)
                {
                    innerHtml.AppendFormat("\n\t\t$('#{0}').toggleClass('{1}', {2});", targetId, newClass, delay);
                    innerHtml.Append("\n\t\treturn false;");
                }

                innerHtml.Append("\n\t    });");
            }

            innerHtml.Append("\n\t});\n    ");

            builder.InnerHtml = innerHtml.ToString();

            // Render tag
            return builder.ToString(TagRenderMode.Normal);
        }
    }
}
