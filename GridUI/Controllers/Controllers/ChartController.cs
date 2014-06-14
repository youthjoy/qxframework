using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using QX.Model;
using QX.BLL;
using QX.HtmlHelperLib;
using QX.HtmlHelperLib.JqGrid;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using QX.Comm;
using QX.Config;
using System.IO;
using System.Web.UI.DataVisualization.Charting;
using ChartLib.Helper;
namespace QX.Controllers.Controllers
{
    public class ChartController : Controller
    {

        public QX.Controllers.Base.FileResult GetChart(string id)
        {
            //Chart chart2 = new Chart();
            //chart2.Width = 412;
            //chart2.Height = 296;
            //chart2.RenderType = RenderType.ImageTag;
            //chart2.Palette = ChartColorPalette.BrightPastel;
            //Title T = new Title("测试图片");

            //chart2.Legends.Add("Legend1");
            //chart2.BackColor = System.Drawing.Color.AliceBlue;
            //chart2.BackGradientStyle = GradientStyle.TopBottom;


            //// Set Border Width
            //chart2.BorderWidth = 2;

            //// Chart Image Mode
            //chart2.BackImageWrapMode = ChartImageWrapMode.TileFlipX;


            //ChartArea cArea1 = new ChartArea("Area1");
            ////設定Area1的X,Y軸標題
            //cArea1.AxisX.Title = "時刻";
            //cArea1.AxisY.Title = "數量";
            ////X,Y軸刻度區間
            //cArea1.AxisX.Interval = 2;
            //cArea1.AxisY.Interval = 10;


            //#region Series1填入資料
            //List<string> lstX1 = new List<string>();
            //List<string> lstY1 = new List<string>();
            //Random r1 = new Random((int)DateTime.Now.Ticks);
            //for (int i = 1; i < 50; i++)
            //{
            //    lstX1.Add(i.ToString());
            //}
            //for (int i = 1; i < 50; i++)
            //{
            //    int x = r1.Next(0, 100);
            //    lstY1.Add(x.ToString());
            //}

            //#endregion


            //Series series1 = new Series("種類A");
            ////設定要顯示在哪一個ChartArea
            //series1.ChartArea = "Area1";
            ////設定圖表種類
            //series1.ChartType = SeriesChartType.Spline;
            ////是否將值show在value label上
            //series1.IsValueShownAsLabel = true;
            ////填入資料
            //series1.Points.DataBindXY(lstX1, lstY1);


            //chart2.ChartAreas.Add(cArea1);
            //chart2.Series.Add(series1);

            Chart chart2;

            var helper = ChartHelper.GetInstance();

            chart2 = helper.GenChart(id);

            Dictionary<string, object> paraVal = new Dictionary<string, object>();

            foreach (var r in Request.QueryString.AllKeys)
            {
                paraVal.Add(r, Request[r]);
            }

            if (chart2 != null)
            {
                helper.SetSerial(id, chart2, paraVal);
            }

            MemoryStream imageStream = new MemoryStream();
            chart2.SaveImage(imageStream, ChartImageFormat.Png);

            return new QX.Controllers.Base.FileResult("Yo.png", "image/png", imageStream.ToArray());
        }

        /// <summary>
        /// 获取多图表对比数据源
        /// </summary>
        /// <param name="id"></param>
        /// <param name="station"></param>
        /// <returns></returns>
        public QX.Controllers.Base.FileResult GetMultiChart(string id, string station)
        {
            if (string.IsNullOrEmpty(station))
            {
                return null;
            }

            string[] stations = station.Split(',');
            string[] snames = Request["SName"].Split(',');

            Chart chart2;

            var helper = ChartHelper.GetInstance();

            chart2 = helper.GenChart(id);

            if (chart2 != null)
            {
                for (int i = 0; i < stations.Length;i++ )
                {
                    Dictionary<string, object> paraVal = new Dictionary<string, object>();

                    foreach (var r in Request.QueryString.AllKeys)
                    {
                        paraVal.Add(r, Request[r]);
                    }

                    if (paraVal.Keys.Contains("Station"))
                    {
                        paraVal["Station"] = stations[i];
                    }

                    if (paraVal.Keys.Contains("SName"))
                    {
                        paraVal["SName"] = snames[i];
                    }

                    helper.SetMultiSerial(id, chart2, paraVal);
                }
            }

            MemoryStream imageStream = new MemoryStream();
            chart2.SaveImage(imageStream, ChartImageFormat.Png);

            return new QX.Controllers.Base.FileResult("Yo.png", "image/png", imageStream.ToArray());

        }

        /// <summary>
        /// 获取google chart 多数据
        /// </summary>
        /// <param name="id"></param>
        /// <param name="station"></param>
        /// <returns></returns>
        public QX.Controllers.Base.FileResult GetMultiGChart(string id, string station)
        {
            if (string.IsNullOrEmpty(station))
            {
                return null;
            }

            string[] stations = station.Split(',');
            string[] snames = Request["SName"].Split(',');

            Chart chart2;

            var helper = ChartHelper.GetInstance();

            chart2 = helper.GenChart(id);

            if (chart2 != null)
            {
                for (int i = 0; i < stations.Length; i++)
                {
                    Dictionary<string, object> paraVal = new Dictionary<string, object>();

                    foreach (var r in Request.QueryString.AllKeys)
                    {
                        paraVal.Add(r, Request[r]);
                    }

                    if (paraVal.Keys.Contains("Station"))
                    {
                        paraVal["Station"] = stations[i];
                    }

                    if (paraVal.Keys.Contains("SName"))
                    {
                        paraVal["SName"] = snames[i];
                    }

                    helper.SetMultiSerial(id, chart2, paraVal);
                }
            }

            MemoryStream imageStream = new MemoryStream();
            chart2.SaveImage(imageStream, ChartImageFormat.Png);

            return new QX.Controllers.Base.FileResult("Yo.png", "image/png", imageStream.ToArray());

        }

        /// <summary>
        /// 获取google chart 数据
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public ActionResult GetGChartData(string id)
        {
            Dictionary<string, object> paraVal = new Dictionary<string, object>();

            foreach (var r in Request.QueryString.AllKeys)
            {
                paraVal.Add(r, Request[r]);
            }

            var helper =ChartHelper.GetInstance();

            string result=helper.GenGChartData(id,paraVal);

            return Content(result);


        }

    }
}
