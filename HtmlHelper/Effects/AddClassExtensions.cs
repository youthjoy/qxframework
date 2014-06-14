using System.Web.Mvc;
using System.Text;

namespace QX.HtmlHelperLib.Effects
{
    public static class AddClassExtensions
    {
        public static string AddClass(this HtmlHelper htmlHelper, string[] targetIds, string evt, string newClass, int delay)
        {
            return AddClass(htmlHelper, null, targetIds, evt, newClass, delay);
        }

        public static string AddClass(this HtmlHelper htmlHelper, string[] sourceIds, string[] targetIds, string evt, string newClass, int delay)
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
                    innerHtml.Append("\n\t\t$('#" + targetId + "').addClass('" + newClass + "', " + delay + ", callback);");
                    innerHtml.Append("\n\t\treturn false;");
                    innerHtml.Append("\n\t    });");

                    innerHtml.Append("\n");

                    innerHtml.Append("\n\t    function callback() {");
                    innerHtml.Append("\n\t\tsetTimeout(function() {");
                    innerHtml.Append("\n\t\t    $('#" + targetId + "').removeClass('" + newClass + "');");
                    innerHtml.Append("\n\t\t}, 1500);");
                    innerHtml.Append("\n\t    }");
                }
            }

            innerHtml.Append("\n\t});\n    ");

            builder.InnerHtml = innerHtml.ToString();

            // Render tag
            return builder.ToString(TagRenderMode.Normal);
        }
    }
}
