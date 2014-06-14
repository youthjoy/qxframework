using System.Web.Mvc;
using System.Web.Routing;
using System.Text;

namespace QX.HtmlHelperLib.Widgets
{
    public static class DatepickerExtensions
    {
        public static string Datepicker(this HtmlHelper htmlHelper, string id, string value)
        {
            return Datepicker(htmlHelper, id, value, false/*withoutScript*/);
        }

        public static string Datepicker(this HtmlHelper htmlHelper, string id, string value, bool withoutScript)
        {
            return Datepicker(htmlHelper, id, value, null/*datePickerOptions*/, withoutScript);
        }

        public static string Datepicker(this HtmlHelper htmlHelper, string id, string value, object datePickerOptions)
        {
            return Datepicker(htmlHelper, id, value, datePickerOptions, false/*withoutScript*/);
        }

        public static string Datepicker(this HtmlHelper htmlHelper, string id, string value, object datePickerOptions, bool withoutScript)
        {
            return Datepicker(htmlHelper, id, value, datePickerOptions, null/*htmlAttributes*/, withoutScript);
        }

        public static string Datepicker(this HtmlHelper htmlHelper, string id, string value, object dataPickerOptions, object htmlAttributes)
        {
            return Datepicker(htmlHelper, id, value, dataPickerOptions, htmlAttributes, false/*withoutScript*/);
        }

        public static string Datepicker(this HtmlHelper htmlHelper, string id, string value, object dataPickerOptions, object htmlAttributes, bool withoutScript)
        {
            // Create tag builder
            var builder = new TagBuilder("input");

            // Create valid id
            builder.GenerateId(id);

            // Add attributes
            builder.MergeAttribute("type", "text");
            builder.MergeAttribute("value", value);
            builder.MergeAttribute("title", "Date Picker");
            builder.MergeAttributes(new RouteValueDictionary(htmlAttributes));

            // Render tag
            return builder.ToString(TagRenderMode.SelfClosing) + (withoutScript == true ? string.Empty : "\n    " + RenderDatepicker(htmlHelper, new string[] { id }, dataPickerOptions));
        }

        public static string Datepicker(this HtmlHelper htmlHelper, string id, string value, DatepickerTypes datePickerType)
        {
            return Datepicker(htmlHelper, id, value, datePickerType, false/*withoutScript*/);
        }

        public static string Datepicker(this HtmlHelper htmlHelper, string id, string value, DatepickerTypes datePickerType, bool withoutScript)
        {
            return Datepicker(htmlHelper, id, value, datePickerType, null/*htmlAttributes*/, withoutScript);
        }

        public static string Datepicker(this HtmlHelper htmlHelper, string id, string value, DatepickerTypes datePickerType, object htmlAttributes)
        {
            return Datepicker(htmlHelper, id, value, datePickerType, htmlAttributes, false/*withoutScript*/);
        }

        public static string Datepicker(this HtmlHelper htmlHelper, string id, string value, DatepickerTypes datePickerType, object htmlAttributes, bool withoutScript)
        {
            // Create tag builder
            var builder = new TagBuilder((datePickerType == DatepickerTypes.DisplayInline) ? "div" : "input");

            // Create valid id
            builder.GenerateId(id);

            // Add attributes
            builder.MergeAttribute("type", "text");
            builder.MergeAttribute("value", value);
            builder.MergeAttribute("title", "Date Picker");
            builder.MergeAttributes(new RouteValueDictionary(htmlAttributes));

            // Render tag
            return builder.ToString(TagRenderMode.SelfClosing)
                + (withoutScript == true ? string.Empty : "\n    " + RenderDatepicker(htmlHelper, new string[] { id }, datePickerType));
        }

        public static string RenderDatepicker(this HtmlHelper htmlHelper, string[] datePickerIds)
        {
            return RenderDatepicker(htmlHelper, datePickerIds, null/*datePickerOptions*/);
        }

        public static string RenderDatepicker(this HtmlHelper htmlHelper, string[] datePickerIds, object datePickerOptions)
        {
            // Create tag builder
            var builder = new TagBuilder("script");

            builder.MergeAttribute("type", "text/javascript");

            StringBuilder innerHtml = new StringBuilder();
            innerHtml.Append("\n\t$(function(){");

            if (datePickerOptions != null)
            {
                TagBuilder tg = new TagBuilder("a");
                tg.MergeAttributes(new RouteValueDictionary(datePickerOptions));

                // Add attributes
                int length = tg.ToString(TagRenderMode.SelfClosing).Length;
                string atts = "";
                if (length > 5)
                    atts = tg.ToString(TagRenderMode.SelfClosing).Replace('=', ':').Replace('"', '\'').Replace(' ', ',').Substring(3, length - 6);
                else
                    atts = string.Empty;

                foreach (var item in datePickerIds)
                {
                    innerHtml.Append("\n\t    $('#" + item + "').datepicker({" + atts + "});");
                }
            }
            else
            {
                foreach (var item in datePickerIds)
                {
                    innerHtml.Append("\n\t    $('#" + item + "').datepicker();");
                }
            }

            innerHtml.Append("\n\t});\n    ");

            builder.InnerHtml = innerHtml.ToString();

            // Render tag
            return builder.ToString(TagRenderMode.Normal);
        }

        public static string RenderDatepicker(this HtmlHelper htmlHelper, string[] datePickerIds, DatepickerTypes datePickerType)
        {
            switch (datePickerType)
            {
                case DatepickerTypes.Recommendation:
                    return RenderDatepicker(htmlHelper, datePickerIds, new { @dateFormat = "dd/mm/yy", @minDate = "-4", @maxDate = "+2", @changeMonth = true, @changeYear = true, @showOn = "button", @buttonImage = "images/calendar.gif", @buttonImageOnly = true });
                case DatepickerTypes.DefaultFuntionality:
                    return RenderDatepicker(htmlHelper, datePickerIds, new { });
                case DatepickerTypes.FormatDate:
                    return RenderDatepicker(htmlHelper, datePickerIds, new { @dateFormat = "dd/mm/yy" });
                case DatepickerTypes.RestrictDateRange:
                    return RenderDatepicker(htmlHelper, datePickerIds, new { @minDate = "-2", @maxDate = "+2" });
                case DatepickerTypes.LocalizeCalendar:
                    return RenderDatepicker(htmlHelper, datePickerIds, new { });
                case DatepickerTypes.PopulateAlternateField:
                    return RenderDatepicker(htmlHelper, datePickerIds, new { });
                case DatepickerTypes.DisplayInline:
                    return RenderDatepicker(htmlHelper, datePickerIds, new { });
                case DatepickerTypes.DisplayButtonBar:
                    return RenderDatepicker(htmlHelper, datePickerIds, new { @showButtonPanel = true });
                case DatepickerTypes.DisplayMonthAndYearMenus:
                    return RenderDatepicker(htmlHelper, datePickerIds, new { @changeMonth = true, @changeYear = true });
                case DatepickerTypes.DisplayMultipleMonths:
                    return RenderDatepicker(htmlHelper, datePickerIds, new { @numberOfMonths = 3, @showButtonPanel = true });
                case DatepickerTypes.IconTrigger:
                    return RenderDatepicker(htmlHelper, datePickerIds, new { @showOn = "button", @buttonImage = "images/calendar.gif", @buttonImageOnly = true });
                default:    // Recommendation
                    return RenderDatepicker(htmlHelper, datePickerIds, new { });
            }
        }
    }

    public enum DatepickerTypes : int
    {
        Recommendation = 0,
        DefaultFuntionality = 1,
        FormatDate = 2,
        RestrictDateRange = 3,
        LocalizeCalendar = 4,
        PopulateAlternateField = 5,
        DisplayInline = 6,
        DisplayButtonBar = 7,
        DisplayMonthAndYearMenus = 8,
        DisplayMultipleMonths = 9,
        IconTrigger = 10
    }
}
