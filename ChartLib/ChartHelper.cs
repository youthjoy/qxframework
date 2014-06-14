using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.UI.DataVisualization.Charting;


using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using QX.ChartLib.DAL;
using QX.ChartLib.Model;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using QX.Comm;

namespace ChartLib.Helper
{
    public class ChartHelper
    {
        private ADOChartMain instance = new ADOChartMain();
        private ADOChartDetail dInstance = new ADOChartDetail();

        //定义一个私有的静态全局变量来保存该类的唯一实例
        private static ChartHelper singleton;

        /// <summary>
        /// 构造函数必须是私有的
        /// 这样在外部便无法使用 new 来创建该类的实例
        /// </summary>
        private ChartHelper()
        {
        }

        /// <summary>
        /// 定义一个全局访问点
        /// 设置为静态方法
        /// 则在类的外部便无需实例化就可以调用该方法
        /// </summary>
        /// <returns></returns>
        public static ChartHelper GetInstance()
        {
            //这里可以保证只实例化一次
            //即在第一次调用时实例化
            //以后调用便不会再实例化
            if (singleton == null)
            {
                singleton = new ChartHelper();
            }
            return singleton;
        }


        public Chart GenChart(string modulecode)
        {
            var list = instance.GetListByWhere(string.Format(" AND CM_Module='{0}'", modulecode));
            if (list.Count == 0)
            {
                return null;
            }
            var charModel = list[0];
            Chart Chart1 = new Chart();
            try
            {
                #region Step1. 設定 Chart Title
                //Title ChartTitle = new Title();
                //System.Drawing.Font font = new System.Drawing.Font("黑体", 20, FontStyle.Bold);


                ////字体设置
                //ChartTitle.Font = font;
                //ChartTitle.ForeColor = System.Drawing.ColorTranslator.FromHtml("#6B8E23");
                ////图表名称
                //ChartTitle.Text = charModel.CM_Title;
                ////新增至Chart Control
                //Chart1.Titles.Add(ChartTitle);
                #endregion


                #region Step2. 產生工作區塊(Area1)
                ChartArea cArea1 = new ChartArea(charModel.CM_ChartAreas);

                Chart1.Width = charModel.CM_Width;
                Chart1.Height = charModel.CM_Height;

                //設定Area1的X,Y軸標題
                // cArea1.AxisX.Title = charModel.CM_XTitle;
                // cArea1.AxisY.Title = charModel.CM_YTitle;
                //X,Y軸刻度區間
                if (!string.IsNullOrEmpty(charModel.CM_XInterval))
                {
                    cArea1.AxisX.Interval = double.Parse(charModel.CM_XInterval);
                }
                if (!string.IsNullOrEmpty(charModel.CM_YInterval))
                {
                    cArea1.AxisY.Interval = double.Parse(charModel.CM_YInterval);
                }


                // Chart1.BackColor = System.Drawing.Color.AliceBlue;
                // Chart1.BackGradientStyle = GradientStyle.TopBottom;
                // Set Border Width
                // Chart1.BorderWidth = 2;

                // Chart Image Mode
                // Chart1.BackImageWrapMode = ChartImageWrapMode.TileFlipX;

                Chart1.ChartAreas.Add(cArea1);
                #endregion

                #region 样式设置

                var c = new BorderSkin();
                c.SkinStyle = BorderSkinStyle.Emboss;
                Chart1.BorderSkin = c;

                cArea1.BorderDashStyle = ChartDashStyle.Solid;

                cArea1.BorderWidth = 1;

                cArea1.BorderColor = colorHx16toRGB("#AAB6C5");

                cArea1.BackColor = colorHx16toRGB("#e3e3e3");
                cArea1.BackSecondaryColor = Color.White;
                cArea1.BackGradientStyle = GradientStyle.TopBottom;

                cArea1.AxisX.TitleFont = new Font("微软雅黑", 12);
                cArea1.AxisY.TitleFont = new Font("微软雅黑", 12);

                cArea1.AxisX.LineColor = colorHx16toRGB("#AAB6C5");
                cArea1.AxisX.LineWidth = 1;

                cArea1.AxisY.LineColor = colorHx16toRGB("#AAB6C5");
                cArea1.AxisY.LineWidth = 1;
                //----

                var l = new LabelStyle();
                l.Font = new Font("微软雅黑", 20, FontStyle.Bold);
                l.ForeColor = colorHx16toRGB("#404040");
                cArea1.AxisX.LabelStyle = l;


                var ly = new LabelStyle();
                ly.Font = new Font("微软雅黑", 20, FontStyle.Bold);
                ly.ForeColor = colorHx16toRGB("#404040");
                cArea1.AxisY.LabelStyle = ly;




                cArea1.AxisX.MajorGrid.LineColor = colorHx16toRGB("#AAB6C5");
                cArea1.AxisY.MajorGrid.LineColor = colorHx16toRGB("#AAB6C5");

                Chart1.BackColor = colorHx16toRGB("#e3e3e3");
                Chart1.BackSecondaryColor = Color.White;
                Chart1.BackGradientStyle = GradientStyle.TopBottom;



                var d = new ChartArea3DStyle();

                d.Rotation = 10;
                d.Perspective = 10;
                d.IsRightAngleAxes = false;
                d.WallWidth = 0;
                d.IsClustered = false;
                d.LightStyle = LightStyle.Realistic;
                cArea1.Area3DStyle = d;
                #endregion
            }
            catch (Exception ex)
            {
                return null;
            }

            return Chart1;
        }

        public Chart GenChart(string modulecode, Chart Chart1)
        {
            var list = instance.GetListByWhere(string.Format(" AND CM_Module='{0}'", modulecode));
            if (list.Count == 0)
            {
                return null;
            }
            var charModel = list[0];
            //Chart Chart1 = new Chart();
            try
            {
                #region Step1. 設定 Chart Title
                Title ChartTitle = new Title();
                System.Drawing.Font font = new System.Drawing.Font("宋体", 20);
                //字体设置
                ChartTitle.Font = font;
                ChartTitle.ForeColor = System.Drawing.ColorTranslator.FromHtml("#6B8E23");
                //图表名称
                ChartTitle.Text = charModel.CM_Title;
                //新增至Chart Control
                Chart1.Titles.Add(ChartTitle);
                #endregion


                #region Step2. 產生工作區塊(Area1)
                ChartArea cArea1 = new ChartArea(charModel.CM_ChartAreas);

                Chart1.Width = charModel.CM_Width;
                Chart1.Height = charModel.CM_Height;

                //設定Area1的X,Y軸標題
                cArea1.AxisX.Title = charModel.CM_XTitle;
                cArea1.AxisY.Title = charModel.CM_YTitle;
                //X,Y軸刻度區間
                if (!string.IsNullOrEmpty(charModel.CM_XInterval))
                {
                    cArea1.AxisX.Interval = double.Parse(charModel.CM_XInterval);
                }
                if (!string.IsNullOrEmpty(charModel.CM_YInterval))
                {
                    cArea1.AxisY.Interval = double.Parse(charModel.CM_YInterval);
                }



                Chart1.BackColor = colorHx16toRGB(charModel.CM_UDEF1);
                Chart1.BackGradientStyle = GradientStyle.TopBottom;

                // Chart Image Mode
                Chart1.BackImageWrapMode = ChartImageWrapMode.TileFlipX;

                Chart1.ChartAreas.Add(cArea1);
                #endregion

            }
            catch (Exception ex)
            {
                return null;
            }

            return Chart1;
        }

        public void SetSerial(string module, Chart chart, Dictionary<string, object> searchCondition)
        {

            List<ChartDetail> dlist = dInstance.GetListByWhere(string.Format(" AND CD_Module='{0}'", module));

            //var d = dlist[0];


            foreach (var d in dlist)
            {
                DataTable newDt;
                //获取所有的数据列
                List<SqlParameter> list = new List<SqlParameter>();
                #region 数据填充
                if (!string.IsNullOrEmpty(d.CD_Parmas))
                {
                    var paras = d.CD_Parmas.Split(',');
                    foreach (var p in paras)
                    {
                        if (searchCondition.ContainsKey(p))
                        {
                            if (p.ToLower().Contains("date"))
                            {
                                SqlParameter s = new SqlParameter("@" + p, searchCondition[p]);
                                s.DbType = DbType.Date;
                                if (p.ToLower().Contains("edate"))
                                {
                                    var v = DateTime.Parse(searchCondition[p].ToString()).ToString("yyyy-MM-dd 23:59:59");
                                    s.Value = v;
                                    list.Add(s);
                                }
                                else
                                {
                                    s.Value = searchCondition[p];
                                    list.Add(s);
                                }
                            }
                            else
                            {
                                SqlParameter s = new SqlParameter("@" + p, searchCondition[p]);
                                list.Add(s);
                            }
                        }
                        else
                        {
                            SqlParameter s = new SqlParameter("@" + p, "");
                            list.Add(s);
                        }
                    }
                    newDt = instance.idb.RunProcReturnDatatable(d.CD_DataSource, list.ToArray());
                }
                else
                {
                    newDt = instance.idb.RunProcReturnDatatable(d.CD_DataSource);
                }


                List<string> lstX1 = new List<string>();
                List<string> lstY1 = new List<string>();
                foreach (DataRow dr in newDt.Rows)
                {
                    lstX1.Add(dr["X"].ToString());
                    lstY1.Add(dr["Y"].ToString());
                }

                Legend leg = new Legend(d.CD_LegendText);
                leg.Docking = Docking.Right;
                chart.Legends.Add(leg);

                Series series1 = new Series(d.CD_LegendText);
                series1.ShadowColor = colorHx16toRGB("#e3e3e3");
                series1.ShadowOffset = 2;
                series1.XValueType = ChartValueType.DateTimeOffset;
                series1.LabelForeColor = colorHx16toRGB("#333333");

                //填入資料
                series1.Points.DataBindXY(lstX1, lstY1);



                #endregion

                #region 样式设置
                //設定要顯示在哪一個ChartArea
                series1.ChartArea = d.CD_Areas;
                series1.BorderWidth = (int)d.CD_BorderWidth;
                // series1.BorderColor = colorHx16toRGB(d.CD_BorderColor);

                series1.BorderColor = Color.Wheat;



                switch (d.CD_ChartType)
                {
                    case "Spline":
                        //設定圖表種類
                        series1.ChartType = SeriesChartType.Spline;
                        break;
                    case "Point":
                        //設定圖表種類
                        series1.ChartType = SeriesChartType.Point;
                        break;
                    case "Range":
                        series1.ChartType = SeriesChartType.Range;
                        break;
                    case "StackedBar":
                        series1.ChartType = SeriesChartType.StackedBar;
                        break;
                    case "SplineArea":
                        //設定圖表種類
                        series1.ChartType = SeriesChartType.SplineArea;
                        break;
                    case "Line":
                        //設定圖表種類
                        series1.ChartType = SeriesChartType.Line;
                        break;

                }



                //是否將值show在value label上
                series1.IsValueShownAsLabel = true;
                #endregion

                chart.Series.Add(series1);

            }

        }

        public void SetMultiSerial(string module, Chart chart, Dictionary<string, object> searchCondition)
        {

            List<ChartDetail> dlist = dInstance.GetListByWhere(string.Format(" AND CD_Module='{0}'", module));

            //var d = dlist[0];

            foreach (var d in dlist)
            {
                DataTable newDt;
                //获取所有的数据列
                List<SqlParameter> list = new List<SqlParameter>();
                #region 数据填充
                if (!string.IsNullOrEmpty(d.CD_Parmas))
                {
                    var paras = d.CD_Parmas.Split(',');
                    foreach (var p in paras)
                    {
                        if (searchCondition.ContainsKey(p))
                        {
                            if (p.ToLower().Contains("date"))
                            {
                                SqlParameter s = new SqlParameter("@" + p, searchCondition[p]);
                                s.DbType = DbType.Date;
                                if (p.ToLower().Contains("edate"))
                                {
                                    var v = DateTime.Parse(searchCondition[p].ToString()).ToString("yyyy-MM-dd 23:59:59");
                                    s.Value = v;
                                    list.Add(s);
                                }
                                else
                                {
                                    s.Value = searchCondition[p];
                                    list.Add(s);
                                }
                            }
                            else
                            {
                                SqlParameter s = new SqlParameter("@" + p, searchCondition[p]);
                                list.Add(s);
                            }
                        }
                        else
                        {
                            SqlParameter s = new SqlParameter("@" + p, "");
                            list.Add(s);
                        }
                    }
                    newDt = instance.idb.RunProcReturnDatatable(d.CD_DataSource, list.ToArray());
                }
                else
                {
                    newDt = instance.idb.RunProcReturnDatatable(d.CD_DataSource);
                }


                List<string> lstX1 = new List<string>();
                List<string> lstY1 = new List<string>();
                foreach (DataRow dr in newDt.Rows)
                {
                    lstX1.Add(dr[0].ToString());
                    lstY1.Add(dr[1].ToString());
                }

                Legend leg = null;
                Series series1 = null;
                if (searchCondition.ContainsKey("SName"))
                {
                    leg = new Legend(searchCondition["SName"].ToString());
                    series1 = new Series(searchCondition["SName"].ToString());
                }
                else
                {
                    leg = new Legend();
                    series1 = new Series();
                }
                leg.Docking = Docking.Right;
                chart.Legends.Add(leg);


                series1.ShadowColor = colorHx16toRGB("#e3e3e3");
                series1.ShadowOffset = 2;
                series1.XValueType = ChartValueType.DateTimeOffset;
                series1.LabelForeColor = colorHx16toRGB("#333333");

                //填入資料
                series1.Points.DataBindXY(lstX1, lstY1);



                #endregion

                #region 样式设置
                //設定要顯示在哪一個ChartArea
                series1.ChartArea = d.CD_Areas;
                series1.BorderWidth = (int)d.CD_BorderWidth;
                // series1.BorderColor = colorHx16toRGB(d.CD_BorderColor);

                series1.BorderColor = Color.Wheat;



                switch (d.CD_ChartType)
                {
                    case "Spline":
                        //設定圖表種類
                        series1.ChartType = SeriesChartType.Spline;
                        break;
                    case "Point":
                        //設定圖表種類
                        series1.ChartType = SeriesChartType.Point;
                        break;
                    case "Range":
                        series1.ChartType = SeriesChartType.Range;
                        break;
                    case "StackedBar":
                        series1.ChartType = SeriesChartType.StackedBar;
                        break;
                    case "SplineArea":
                        //設定圖表種類
                        series1.ChartType = SeriesChartType.SplineArea;
                        break;
                    case "Line":
                        //設定圖表種類
                        series1.ChartType = SeriesChartType.Line;
                        break;

                }



                //是否將值show在value label上
                series1.IsValueShownAsLabel = true;
                #endregion

                chart.Series.Add(series1);

            }

        }

        public string GenGChartData(string modulecode, Dictionary<string, object> searchCondition)
        {

            List<ChartDetail> dlist = dInstance.GetListByWhere(string.Format(" AND CD_Module='{0}'", modulecode));

            List<SqlParameter> list = new List<SqlParameter>();

            var d = dlist[0];
            DataTable newDt;
            #region 数据填充
            if (!string.IsNullOrEmpty(d.CD_Parmas))
            {
                var paras = d.CD_Parmas.Split(',');
                foreach (var p in paras)
                {
                    if (searchCondition.ContainsKey(p))
                    {
                        if (p.ToLower().Contains("date"))
                        {
                            SqlParameter s = new SqlParameter("@" + p, searchCondition[p]);
                            s.DbType = DbType.Date;
                            if (p.ToLower().Contains("edate"))
                            {
                                var v = DateTime.Parse(searchCondition[p].ToString()).ToString("yyyy-MM-dd 23:59:59");
                                s.Value = v;
                                list.Add(s);
                            }
                            else
                            {
                                s.Value = searchCondition[p];
                                list.Add(s);
                            }
                        }
                        else
                        {
                            SqlParameter s = new SqlParameter("@" + p, searchCondition[p]);
                            list.Add(s);
                        }
                    }
                    else
                    {
                        SqlParameter s = new SqlParameter("@" + p, "");
                        list.Add(s);
                    }
                }
                newDt = instance.idb.RunProcReturnDatatable(d.CD_DataSource, list.ToArray());
            }
            else
            {
                newDt = instance.idb.RunProcReturnDatatable(d.CD_DataSource);
            }

            string template = "{{\"cols\": [{0}],\"rows\": [{1}]}}";
            string colTpl = "{{ \"id\": \"{0}\",\"label\": \"{0}\", \"type\": \"{1}\" }},";
            string rowTpl = "{{ \"c\": [{0}] }},";
            string rowValTpl = "{{ \"v\":\"{0}\" }},";
            string rowNValTpl = "{{ \"v\":{0} }},";
            StringBuilder col = new StringBuilder();
            StringBuilder row = new StringBuilder();
            foreach (DataColumn c in newDt.Columns)
            {
                string datatype = GetDataType(c.DataType);
                col.AppendFormat(colTpl, c.ColumnName, datatype);
            }

            foreach (DataRow r in newDt.Rows)
            {
                string temp = string.Empty;
                foreach (DataColumn c in newDt.Columns)
                {
                    if (c.DataType == typeof(DateTime))
                    {

                        temp = temp + string.Format(rowValTpl, r[c.ColumnName]);
                    }
                    else if (c.DataType == typeof(Single)||c.DataType==typeof(Decimal) || c.DataType == typeof(Double) || c.DataType == typeof(Int32))
                    {
                        temp = temp + string.Format(rowNValTpl, r[c.ColumnName]);
                    }
                    else
                    {
                        temp = temp + string.Format(rowValTpl, r[c.ColumnName]);

                    }

                }

                row.AppendFormat(rowTpl, temp.TrimEnd(','));
            }
            string result = string.Format(template, col.ToString().TrimEnd(','), row.ToString().TrimEnd(','));

            return result;
            #endregion

        }


        public string GenGMultiChartData(string modulecode, Dictionary<string, object> searchCondition)
        {

            List<ChartDetail> dlist = dInstance.GetListByWhere(string.Format(" AND CD_Module='{0}'", modulecode));

            List<SqlParameter> list = new List<SqlParameter>();

            var d = dlist[0];
            DataTable newDt;
            #region 数据填充
            if (!string.IsNullOrEmpty(d.CD_Parmas))
            {
                var paras = d.CD_Parmas.Split(',');
                foreach (var p in paras)
                {
                    if (searchCondition.ContainsKey(p))
                    {
                        if (p.ToLower().Contains("date"))
                        {
                            SqlParameter s = new SqlParameter("@" + p, searchCondition[p]);
                            s.DbType = DbType.Date;
                            if (p.ToLower().Contains("edate"))
                            {
                                var v = DateTime.Parse(searchCondition[p].ToString()).ToString("yyyy-MM-dd 23:59:59");
                                s.Value = v;
                                list.Add(s);
                            }
                            else
                            {
                                s.Value = searchCondition[p];
                                list.Add(s);
                            }
                        }
                        else
                        {
                            SqlParameter s = new SqlParameter("@" + p, searchCondition[p]);
                            list.Add(s);
                        }
                    }
                    else
                    {
                        SqlParameter s = new SqlParameter("@" + p, "");
                        list.Add(s);
                    }
                }
                newDt = instance.idb.RunProcReturnDatatable(d.CD_DataSource, list.ToArray());
            }
            else
            {
                newDt = instance.idb.RunProcReturnDatatable(d.CD_DataSource);
            }

            string template = "{{\"cols\": [{0}],\"rows\": [{1}]}}";
            string colTpl = "{{ \"id\": \"{0}\",\"label\": \"{0}\", \"type\": \"{1}\" }},";
            string rowTpl = "{{ \"c\": [{0}] }},";
            string rowValTpl = "{{ \"v\":\"{0}\" }},";
            string rowNValTpl = "{{ \"v\":{0} }},";
            StringBuilder col = new StringBuilder();
            StringBuilder row = new StringBuilder();
            foreach (DataColumn c in newDt.Columns)
            {
                string datatype = GetDataType(c.DataType);
                col.AppendFormat(colTpl, c.ColumnName, datatype);
            }

            foreach (DataRow r in newDt.Rows)
            {
                string temp = string.Empty;
                foreach (DataColumn c in newDt.Columns)
                {
                    if (c.DataType == typeof(DateTime))
                    {

                        temp = temp + string.Format(rowValTpl, r[c.ColumnName]);
                    }
                    else if (c.DataType == typeof(Single) || c.DataType == typeof(Decimal) || c.DataType == typeof(Double) || c.DataType == typeof(Int32))
                    {
                        temp = temp + string.Format(rowNValTpl, r[c.ColumnName]);
                    }
                    else
                    {
                        temp = temp + string.Format(rowValTpl, r[c.ColumnName]);

                    }

                }

                row.AppendFormat(rowTpl, temp.TrimEnd(','));
            }
            string result = string.Format(template, col.ToString().TrimEnd(','), row.ToString().TrimEnd(','));

            return result;
            #endregion

        }

        public string GetDataType(Type type)
        {
            if (type == typeof(DateTime))
            {
                return "string";
            }
            else
            {
                return "number";
            }
        }


        /// <summary>
        /// [颜色：16进制转成RGB]
        /// </summary>
        /// <param name="strColor">设置16进制颜色 [返回RGB]</param>
        /// <returns></returns>
        public static System.Drawing.Color colorHx16toRGB(string strHxColor)
        {
            try
            {
                if (strHxColor.Length == 0)
                {//如果为空
                    return System.Drawing.Color.FromArgb(0, 0, 0);//设为黑色
                }
                else
                {//转换颜色
                    return System.Drawing.Color.FromArgb(System.Int32.Parse(strHxColor.Substring(1, 2), System.Globalization.NumberStyles.AllowHexSpecifier), System.Int32.Parse(strHxColor.Substring(3, 2), System.Globalization.NumberStyles.AllowHexSpecifier), System.Int32.Parse(strHxColor.Substring(5, 2), System.Globalization.NumberStyles.AllowHexSpecifier));
                }
            }
            catch
            {//设为黑色
                return System.Drawing.Color.FromArgb(0, 0, 0);
            }
        }
    }


}
