using System.Web.Mvc;
using System.Web.Routing;
using System.Text;

namespace QX.HtmlHelperLib.Widgets
{
    public static class SliderExtensions
    {
        public static string Slider(this HtmlHelper htmlHelper, string id, string value)
        {
            return Slider(htmlHelper, id, value, false/*withoutScript*/);
        }

        public static string Slider(this HtmlHelper htmlHelper, string id, string value, bool withoutScript)
        {
            return Slider(htmlHelper, id, value, null/*sliderOptions*/, withoutScript);
        }

        public static string Slider(this HtmlHelper htmlHelper, string id, string value, object sliderOptions)
        {
            return Slider(htmlHelper, id, value, sliderOptions, false/*withoutScript*/);
        }

        public static string Slider(this HtmlHelper htmlHelper, string id, string value, object sliderOptions, bool withoutScript)
        {
            return Slider(htmlHelper, id, value, sliderOptions, null/*htmlAttributes*/, withoutScript);
        }

        public static string Slider(this HtmlHelper htmlHelper, string id, string value, object dataPickerOptions, object htmlAttributes)
        {
            return Slider(htmlHelper, id, value, dataPickerOptions, htmlAttributes, false/*withoutScript*/);
        }

        public static string Slider(this HtmlHelper htmlHelper, string id, string value, object dataPickerOptions, object htmlAttributes, bool withoutScript)
        {
            // style
            var style = new TagBuilder("style");
            style.MergeAttribute("type", "text/css");
            style.InnerHtml += "#demo-frame > div.demo { padding: 10px !important; };";

            // Create tag builder
            var builder = new TagBuilder("div");

            // Create valid id
            builder.GenerateId(id);

            // Add attributes
            builder.MergeAttributes(new RouteValueDictionary(htmlAttributes));

            // Render tag
            return style.ToString(TagRenderMode.Normal) + "\n    " + builder.ToString(TagRenderMode.Normal) + (withoutScript == true ? string.Empty : "\n    " + RenderSlider(htmlHelper, new string[] { id }, dataPickerOptions));
        }

        public static string Slider(this HtmlHelper htmlHelper, string id, string value, SliderTypes sliderType)
        {
            return Slider(htmlHelper, id, value, sliderType, false/*withoutScript*/);
        }

        public static string Slider(this HtmlHelper htmlHelper, string id, string value, SliderTypes sliderType, bool withoutScript)
        {
            return Slider(htmlHelper, id, value, sliderType, null/*htmlAttributes*/, withoutScript);
        }

        public static string Slider(this HtmlHelper htmlHelper, string id, string value, SliderTypes sliderType, object htmlAttributes)
        {
            return Slider(htmlHelper, id, value, sliderType, htmlAttributes, false/*withoutScript*/);
        }

        public static string Slider(this HtmlHelper htmlHelper, string id, string value, SliderTypes sliderType, object htmlAttributes, bool withoutScript)
        {
            // Create tag builder
            var builder = new TagBuilder("div");

            // Create valid id
            builder.GenerateId(id);

            // Add attributes
            builder.MergeAttributes(new RouteValueDictionary(htmlAttributes));

            // Render tag
            return builder.ToString(TagRenderMode.Normal)
                + (withoutScript == true ? string.Empty : "\n    " + RenderSlider(htmlHelper, new string[] { id }, sliderType));
        }

        public static string RenderSlider(this HtmlHelper htmlHelper, string[] sliderIds)
        {
            return RenderSlider(htmlHelper, sliderIds, null/*sliderOptions*/);
        }

        public static string RenderSlider(this HtmlHelper htmlHelper, string[] sliderIds, object sliderOptions)
        {
            // Create tag builder
            var builder = new TagBuilder("script");

            builder.MergeAttribute("type", "text/javascript");

            StringBuilder innerHtml = new StringBuilder();
            innerHtml.Append("\n\t$(function(){");

            if (sliderOptions != null)
            {
                TagBuilder tg = new TagBuilder("a");
                tg.MergeAttributes(new RouteValueDictionary(sliderOptions));

                // Add attributes
                int length = tg.ToString(TagRenderMode.SelfClosing).Length;
                string atts = "";
                if (length > 5)
                    atts = tg.ToString(TagRenderMode.SelfClosing).Replace('=', ':').Replace('"', '\0').Replace(' ', ',').Substring(3, length - 6);
                else
                    atts = string.Empty;

                foreach (var item in sliderIds)
                {
                    innerHtml.Append("\n\t    $('#" + item + "').slider({" + atts + "});");
                }
            }
            else
            {
                foreach (var item in sliderIds)
                {
                    innerHtml.Append("\n\t    $('#" + item + "').slider();");
                }
            }

            innerHtml.Append("\n\t});\n    ");

            builder.InnerHtml = innerHtml.ToString();

            StringBuilder ids = new StringBuilder();
            foreach (var id in sliderIds)
            {
                ids.AppendFormat(",{0}", id);
            }

            int len = ids.Length;

            // Render tag
            return builder.ToString(TagRenderMode.Normal);
        }

        public static string RenderSlider(this HtmlHelper htmlHelper, string[] sliderIds, SliderTypes sliderType)
        {
            switch (sliderType)
            {
                case SliderTypes.Recommendation:
                    return RenderSlider(htmlHelper, sliderIds, new { });
                case SliderTypes.DefaultFuntionality:
                    return RenderSlider(htmlHelper, sliderIds, new { });
                default:    // Recommendation
                    return RenderSlider(htmlHelper, sliderIds, new { });
            }
        }
    }

    public enum SliderTypes : int
    {
        Recommendation = 0,
        DefaultFuntionality = 1
    }
}
