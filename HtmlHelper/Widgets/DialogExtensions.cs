using System.Web.Mvc;
using System.Web.Routing;
using System.Text;

namespace QX.HtmlHelperLib.Widgets
{
    public static class DialogExtensions
    {
        public static string Dialog(this HtmlHelper htmlHelper, string id, string title, string content)
        {
            return Dialog(htmlHelper, id, title, content, false/*withoutScript*/);
        }

        public static string Dialog(this HtmlHelper htmlHelper, string id, string title, string content, bool withoutScript)
        {
            return Dialog(htmlHelper, id, title, content, null/*dialogOptions*/, withoutScript);
        }

        public static string Dialog(this HtmlHelper htmlHelper, string id, string title, string content, object dialogOptions)
        {
            return Dialog(htmlHelper, id, title, content, dialogOptions, false/*withoutScript*/);
        }

        public static string Dialog(this HtmlHelper htmlHelper, string id, string title, string content, object dialogOptions, bool withoutScript)
        {
            return Dialog(htmlHelper, id, title, content, dialogOptions, null/*htmlAttributes*/, withoutScript);
        }

        public static string Dialog(this HtmlHelper htmlHelper, string id, string title, string content, object dataPickerOptions, object htmlAttributes)
        {
            return Dialog(htmlHelper, id, title, content, dataPickerOptions, htmlAttributes, false/*withoutScript*/);
        }

        public static string Dialog(this HtmlHelper htmlHelper, string id, string title, string content, object dataPickerOptions, object htmlAttributes, bool withoutScript)
        {
            // Create tag builder
            var builder = new TagBuilder("div");

            // Create valid id
            builder.GenerateId(id);

            // Add attributes
            builder.MergeAttribute("title", title);
            builder.MergeAttributes(new RouteValueDictionary(htmlAttributes));

            builder.InnerHtml = content;

            // Render tag
            return "<!-- " + id + " Dialog Control //-->" + "\n    " + builder.ToString(TagRenderMode.Normal) + (withoutScript == true ? string.Empty : "\n    " + RenderDialog(htmlHelper, new string[] { id }, dataPickerOptions));
        }

        public static string Dialog(this HtmlHelper htmlHelper, string id, string title, string content, DialogTypes dialogType)
        {
            return Dialog(htmlHelper, id, title, content, dialogType, false/*withoutScript*/);
        }

        public static string Dialog(this HtmlHelper htmlHelper, string id, string title, string content, DialogTypes dialogType, bool withoutScript)
        {
            return Dialog(htmlHelper, id, title, content, dialogType, null/*htmlAttributes*/, withoutScript);
        }

        public static string Dialog(this HtmlHelper htmlHelper, string id, string title, string content, DialogTypes dialogType, object htmlAttributes)
        {
            return Dialog(htmlHelper, id, title, content, dialogType, htmlAttributes, false/*withoutScript*/);
        }

        public static string Dialog(this HtmlHelper htmlHelper, string id, string title, string content, DialogTypes dialogType, object htmlAttributes, bool withoutScript)
        {
            // Create tag builder
            var builder = new TagBuilder("div");

            // Create valid id
            builder.GenerateId(id);

            // Add attributes
            builder.MergeAttribute("title", title);
            builder.MergeAttributes(new RouteValueDictionary(htmlAttributes));

            builder.InnerHtml = content;

            // Render tag
            return "<!-- " + id + " Dialog Control //-->" + "\n    " + builder.ToString(TagRenderMode.Normal)
                + (withoutScript == true ? string.Empty : "\n    " + RenderDialog(htmlHelper, new string[] { id }, dialogType));
        }

        public static string RenderDialog(this HtmlHelper htmlHelper, string[] dialogIds)
        {
            return RenderDialog(htmlHelper, dialogIds, null/*dialogOptions*/);
        }

        public static string RenderDialog(this HtmlHelper htmlHelper, string[] dialogIds, object dialogOptions)
        {
            // Create tag builder
            var builder = new TagBuilder("script");

            builder.MergeAttribute("type", "text/javascript");

            StringBuilder innerHtml = new StringBuilder();
            innerHtml.Append("\n\t$(function(){");

            if (dialogOptions != null)
            {
                TagBuilder tg = new TagBuilder("a");
                tg.MergeAttributes(new RouteValueDictionary(dialogOptions));

                // Add attributes
                int length = tg.ToString(TagRenderMode.SelfClosing).Length;
                string atts = "";
                if (length > 5)
                    atts = tg.ToString(TagRenderMode.SelfClosing).Replace('=', ':').Replace('"', '\0').Replace(' ', ',').Substring(3, length - 6);
                else
                    atts = string.Empty;

                foreach (var item in dialogIds)
                {
                    innerHtml.Append("\n\t    $('#" + item + "').dialog({" + atts + "});");
                }
            }
            else
            {
                foreach (var item in dialogIds)
                {
                    innerHtml.Append("\n\t    $('#" + item + "').dialog();");
                }
            }

            innerHtml.Append("\n\t});\n    ");

            builder.InnerHtml = innerHtml.ToString();

            StringBuilder ids = new StringBuilder();
            foreach (var id in dialogIds)
            {
                ids.AppendFormat(",{0}", id);
            }

            int len = ids.Length;

            // Render tag
            return "<!-- " + ids.ToString(1, len - 1) + " Dialog Script //-->" + "\n    " + builder.ToString(TagRenderMode.Normal);
        }

        public static string RenderDialog(this HtmlHelper htmlHelper, string[] dialogIds, DialogTypes dialogType)
        {
            switch (dialogType)
            {
                case DialogTypes.Recommendation:
                    return RenderDialog(htmlHelper, dialogIds, new {  });
                case DialogTypes.DefaultFuntionality:
                    return RenderDialog(htmlHelper, dialogIds, new { });
                case DialogTypes.ModalDialog:
                    return RenderDialog(htmlHelper, dialogIds, new { @modal=true });
                case DialogTypes.ModalMessage:
                    return RenderDialog(htmlHelper, dialogIds, new { @buttons = "{Ok:function(){$(this).dialog('close');}}" });
                case DialogTypes.ModalConfirmation:
                    return RenderDialog(htmlHelper, dialogIds, new { @modal = "true", @overlay = "{backgroundColor:'#000',opacity:0.5}", @buttons = "{'Ok':function(){$(this).dialog('close');},Cancel:function(){$(this).dialog('close');}}" });
                case DialogTypes.ModalForm:
                    return RenderDialog(htmlHelper, dialogIds, new { });
                default:    // Recommendation
                    return RenderDialog(htmlHelper, dialogIds, new { });
            }
        }
    }

    public enum DialogTypes : int
    {
        Recommendation = 0,
        DefaultFuntionality = 1,
        ModalDialog = 2,
        ModalMessage = 3,
        ModalConfirmation = 4,
        ModalForm = 5
    }
}
