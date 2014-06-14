using System.Web.Mvc;
using System.Web.Routing;
using System.Text;

namespace QX.HtmlHelperLib.Widgets
{
    public static class AccordionExtensions
    {
        public static string Accordion(this HtmlHelper htmlHelper, string id, string[] title, string[] content)
        {
            return Accordion(htmlHelper, id, title, content, false/*withoutScript*/);
        }

        public static string Accordion(this HtmlHelper htmlHelper, string id, string[] title, string[] content, bool withoutScript)
        {
            return Accordion(htmlHelper, id, title, content, null/*accordionOptions*/, withoutScript);
        }

        public static string Accordion(this HtmlHelper htmlHelper, string id, string[] title, string[] content, object accordionOptions)
        {
            return Accordion(htmlHelper, id, title, content, accordionOptions, false/*withoutScript*/);
        }

        public static string Accordion(this HtmlHelper htmlHelper, string id, string[] title, string[] content, object accordionOptions, bool withoutScript)
        {
            return Accordion(htmlHelper, id, title, content, accordionOptions, null/*htmlAttributes*/, withoutScript);
        }

        public static string Accordion(this HtmlHelper htmlHelper, string id, string[] title, string[] content, object dataPickerOptions, object htmlAttributes)
        {
            return Accordion(htmlHelper, id, title, content, dataPickerOptions, htmlAttributes, false/*withoutScript*/);
        }

        public static string Accordion(this HtmlHelper htmlHelper, string id, string[] title, string[] content, object dataPickerOptions, object htmlAttributes, bool withoutScript)
        {
            // Create tag builder
            var builder = new TagBuilder("div");

            // Create valid id
            builder.GenerateId(id);

            // Add attributes
            builder.MergeAttributes(new RouteValueDictionary(htmlAttributes));

            // title & content
            int i = 0;
            foreach (var t in title)
            {
                builder.InnerHtml += string.Format("\n\t<h3><a href=\"#\">{0}</a></h3>", t);
                builder.InnerHtml += string.Format("\n    <div>\n\t{0}\n    </div>", content[i++]);
            }

            // Render tag
            return "<!-- " + id + " Accordion Control //-->" + "\n    " + builder.ToString(TagRenderMode.Normal) + (withoutScript == true ? string.Empty : "\n    " + RenderAccordion(htmlHelper, new string[] { id }, dataPickerOptions));
        }

        public static string Accordion(this HtmlHelper htmlHelper, string id, string[] title, string[] content, AccordionTypes accordionType)
        {
            return Accordion(htmlHelper, id, title, content, accordionType, false/*withoutScript*/);
        }

        public static string Accordion(this HtmlHelper htmlHelper, string id, string[] title, string[] content, AccordionTypes accordionType, bool withoutScript)
        {
            return Accordion(htmlHelper, id, title, content, accordionType, null/*htmlAttributes*/, withoutScript);
        }

        public static string Accordion(this HtmlHelper htmlHelper, string id, string[] title, string[] content, AccordionTypes accordionType, object htmlAttributes)
        {
            return Accordion(htmlHelper, id, title, content, accordionType, htmlAttributes, false/*withoutScript*/);
        }

        public static string Accordion(this HtmlHelper htmlHelper, string id, string[] title, string[] content, AccordionTypes accordionType, object htmlAttributes, bool withoutScript)
        {
            // Create tag builder
            var builder = new TagBuilder("div");

            // Create valid id
            builder.GenerateId(id);

            // Add attributes
            builder.MergeAttributes(new RouteValueDictionary(htmlAttributes));

            // title & content
            int i = 0;
            foreach (var t in title)
            {
                builder.InnerHtml += string.Format("\n\t<h3><a href=\"#\">{0}</a></h3>", t);
                builder.InnerHtml += string.Format("\n    <div>\n\t{0}\n    </div>", content[i++]);
            }

            // Render tag
            return "<!-- " + id + " Accordion Control //-->" + "\n    " + builder.ToString(TagRenderMode.Normal)
                + (withoutScript == true ? string.Empty : "\n    " + RenderAccordion(htmlHelper, new string[] { id }, accordionType));
        }

        public static string RenderAccordion(this HtmlHelper htmlHelper, string[] accordionIds)
        {
            return RenderAccordion(htmlHelper, accordionIds, null/*accordionOptions*/);
        }

        public static string RenderAccordion(this HtmlHelper htmlHelper, string[] accordionIds, object accordionOptions)
        {
            // Create tag builder
            var builder = new TagBuilder("script");

            builder.MergeAttribute("type", "text/javascript");

            StringBuilder innerHtml = new StringBuilder();
            innerHtml.Append("\n\t$(function(){");

            if (accordionOptions != null)
            {
                TagBuilder tg = new TagBuilder("a");
                tg.MergeAttributes(new RouteValueDictionary(accordionOptions));

                // Add attributes
                int length = tg.ToString(TagRenderMode.SelfClosing).Length;
                string atts = "";
                if (length > 5)
                    atts = tg.ToString(TagRenderMode.SelfClosing).Replace('=', ':').Replace('"', '\'').Replace(' ', ',').Substring(3, length - 6);
                else
                    atts = string.Empty;

                foreach (var item in accordionIds)
                {
                    innerHtml.Append("\n\t    $('#" + item + "').accordion({" + atts + "});");
                }
            }
            else
            {
                foreach (var item in accordionIds)
                {
                    innerHtml.Append("\n\t    $('#" + item + "').accordion();");
                }
            }

            innerHtml.Append("\n\t});\n    ");

            builder.InnerHtml = innerHtml.ToString();

            StringBuilder ids = new StringBuilder();
            foreach (var id in accordionIds)
            {
                ids.AppendFormat(",{0}", id);
            }

            int len = ids.Length;

            // Render tag
            return "<!-- " + ids.ToString(1, len - 1) + " Accordion Script //-->" + "\n    " + builder.ToString(TagRenderMode.Normal);
        }

        public static string RenderAccordion(this HtmlHelper htmlHelper, string[] accordionIds, AccordionTypes accordionType)
        {
            switch (accordionType)
            {
                case AccordionTypes.Recommendation:
                    return RenderAccordion(htmlHelper, accordionIds, new {  });
                case AccordionTypes.DefaultFuntionality:
                    return RenderAccordion(htmlHelper, accordionIds, new { });
                default:    // Recommendation
                    return RenderAccordion(htmlHelper, accordionIds, new { });
            }
        }
    }

    public enum AccordionTypes : int
    {
        Recommendation = 0,
        DefaultFuntionality = 1
    }
}
