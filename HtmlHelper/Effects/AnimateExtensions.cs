using System.Web.Mvc;
using System.Text;

namespace QX.HtmlHelperLib.Effects
{
    public static class AnimateExtensions
    {
        public static string Animate(this HtmlHelper htmlHelper, string[] sourceIds, string[] targetIds, object animateOptions, int speed)
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
                innerHtml.Append("\n\t    $('#" + sourceId + "').toggle(");

                foreach (var targetId in targetIds)
                {
                    innerHtml.Append("\n\t\tfunction() {");
                    innerHtml.Append("\n\t\t    $('#" + targetId + "').animate({backgroundColor: '#aa0000', color: '#fff', width: 500}, 1000);");
                    innerHtml.Append("\n\t\t}");

                    innerHtml.Append(",");

                    innerHtml.Append("\n\t\tfunction() {");
                    innerHtml.Append("\n\t\t    $('#" + targetId + "').animate({backgroundColor: '#fff', color: '#000', width: 240}, 1000);");
                    innerHtml.Append("\n\t\t}");
                }
                
                innerHtml.Append("\n\t    );");
            }

            innerHtml.Append("\n\t});\n    ");

            builder.InnerHtml = innerHtml.ToString();

            // Render tag
            return builder.ToString(TagRenderMode.Normal);
        }
    }
}
