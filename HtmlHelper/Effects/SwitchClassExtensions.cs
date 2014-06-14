using System.Web.Mvc;
using System.Text;

namespace QX.HtmlHelperLib.Effects
{
    public static class SwitchClassExtensions
    {
        public static string SwitchClass(this HtmlHelper htmlHelper, string[] sourceIds, string[] targetIds, string evt, string newClass, string anotherNewClass, int delay)
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
                    innerHtml.AppendFormat("\n\t\t$('.{0}').switchClass('{0}', '{1}', {2});", newClass, anotherNewClass, delay);
                    innerHtml.AppendFormat("\n\t\t$('.{0}').switchClass('{0}', '{1}', {2});", anotherNewClass, newClass, delay);
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
