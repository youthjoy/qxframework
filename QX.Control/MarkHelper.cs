using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using QX.Comm;

using QX.Model;
using QX.DAL;
using System.IO;

namespace QX.Control
{
    public static class MarkHelper
    {
        public static string GenMarkContent(this HtmlHelper helper, string sCode)
        {
            ADOBse_StationMark markInstance = new ADOBse_StationMark();
            var main = markInstance.GetListByWhere(string.Format(" AND Sta_StationCode='{0}' AND Sta_Type='Main'", sCode)).FirstOrDefault();
            var mList = markInstance.GetListByWhere(string.Format(" AND Sta_StationCode='{0}' AND isnull(Sta_Type,'')<>'Main'", sCode));

            string backGround = @" <div style='background: url({Url}) no-repeat; width: {width}px;
        height: {height}px;left:{X}px;top:{Y}px; display: block;'>
    </div>";
            string template = @"<div style='position: absolute; top: {Y}px; left: {X}px;
        width: 30px; height: 30px'>
            <div class='pop' style='width: {width}px; height:{height}px'>
                {Content}
            </div>
        </div>";
            if (main != null)
            {
                string path = main.Sta_Background;
                string url = "/Upload/" + Path.GetFileName(path);
                backGround = backGround.Replace("{Url}", url).Replace("{X}", main.Sta_X.ToString())
                     .Replace("{Y}", main.Sta_Y.ToString()).Replace("{width}", main.Sta_Width.ToString())
                     .Replace("{height}", main.Sta_Height.ToString());
            }
            StringBuilder Content = new StringBuilder();
            StringBuilder JavaScript = new StringBuilder();

            Content.AppendLine(backGround);

            foreach (var m in mList)
            {
                Content.AppendLine(template.Replace("{width}", m.Sta_Width.ToString())
                     .Replace("{height}", m.Sta_Height.ToString())
                     .Replace("{X}", m.Sta_X.ToString()).Replace("{Y}", m.Sta_Y.ToString())
                     .Replace("{Content}", m.Sta_Bak));
            }

            JavaScript.AppendLine(@"
        <script type='text/javascript'>
        $(document).ready(function() {
            $.pop();
        });
       </script>");

            Content.AppendLine(JavaScript.ToString());
            return Content.ToString();
        }
    }
}
