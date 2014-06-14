<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/BasePage.Master" Inherits="System.Web.Mvc.ViewPage" %>

<%@ Import Namespace="QX.Control" %>
<%@ Import Namespace="QX.HtmlHelperLib" %>
<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    单站实时数据显示
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <%--<script type="text/javascript">

        // Load the Visualization API and the piechart package.
        google.load('visualization', '1.0', { 'packages': ['corechart'] });

        // Set a callback to run when the Google Visualization API is loaded.
        google.setOnLoadCallback(drawChart);

        //        // Callback that creates and populates a data table, 
        //        // instantiates the pie chart, passes in the data and
        //        // draws it.
        function drawChart() {

            //            // Create the data table.
            //         
            var data = new google.visualization.DataTable({
                cols: [{ id: "X", label: "X", type: "string" },
{ id: "Y", label: "Y", type: "number" }
],
                rows: [
{ c: [{ v: "2011/12/6 17:16:04" }, { v: 1}] },
{ c: [{ v: "2011/12/6 17:16:12" }, { v: 2}] },
{ c: [{ v: "2011/12/6 17:16:13" }, { v: 3}] },
{ c: [{ v: "2011/12/6 17:16:14" }, { v: 4}] },
{ c: [{ v: "2011/12/6 17:16:15" }, { v: 5}] },
{ c: [{ v: "2011/12/6 17:16:16" }, { v: 6}] },
{ c: [{ v: "2011/12/6 17:16:17" }, { v: 7}] },
{ c: [{ v: "2011/12/6 17:16:17" }, { v: 8}] },
{ c: [{ v: "2011/12/6 17:16:18" }, { v: 9}] },
{ c: [{ v: "2011/12/6 17:16:19" }, { v: 10}] },
{ c: [{ v: "2011/12/6 17:16:20" }, { v: 11}] },
{ c: [{ v: "2011/12/6 17:16:21" }, { v: 12}] },
{ c: [{ v: "2011/12/6 17:16:21" }, { v: 13}] },
{ c: [{ v: "2011/12/6 17:16:22" }, { v: 14}] },
{ c: [{ v: "2011/12/6 17:16:23" }, { v: 15}] },
{ c: [{ v: "2011/12/6 17:16:24" }, { v: 16}] },
{ c: [{ v: "2011/12/6 17:16:28" }, { v: 17}] },
{ c: [{ v: "2011/12/6 17:16:32" }, { v: 18}]}]
            });



            //        // Set chart options
            var options = { 'title': 'ddddd',
                'width': 1000,
                'height': 300
            };

            //        // Instantiate and draw our chart, passing in some options.
            var chart = new google.visualization.LineChart(document.getElementById('chart_div'));
            chart.draw(data, options);
        }
    </script>--%>
    <div id="tabs" style="width: 1000px;">
        <ul>
            <li><a href="#tabs-1">站点信息</a></li>
            <li><a href="#tabs-2">站点环境配置</a></li>
        </ul>
        <div id="tabs-1">
            <%Html.RenderPartial("GChartControl", new ViewDataDictionary { new KeyValuePair<string, object>("Station", ViewData["Station"]), new KeyValuePair<string, object>("ToolBar", "Rpt_MMPI") }); %>
            <div style="padding-left: 200px;">

                <script type="text/javascript">

                    google.load('visualization', '1', { packages: ['gauge'] });

                    $(document).ready(function() {
                        var queryString = $('#FormOP').formSerialize();
                        queryString = queryString + "&date=" + new Date();
                        var url = '/Chart/GetGChartData/Report_Test1?' + queryString;
                        $.ajax({
                            url: url,
                            type: 'get',
                            dataType: 'json',
                            success: function(da) {
                                var data = new google.visualization.DataTable(da);
                                var options = {
                                    width: 400, height: 120,
                                    redFrom: 90, redTo: 100,
                                    yellowFrom: 75, yellowTo: 90,
                                    minorTicks: 5
                                };
                                var chart = new google.visualization.Gauge(document.getElementById('ddd'));
                                chart.draw(data, options);
                                //drawChart(data, options);
                            }
                        });
                    });

                    function drawChart(da, options) {
                        //                        var data = new google.visualization.DataTable();
                        //                        data.addColumn('string', 'Label');
                        //                        data.addColumn('number', 'Value');
                        //                        data.addRows([
                        //          ['温度', 44],
                        //          ['浓度', 55],
                        //          ['电力', 68]
                        //        ]);

                        //                        var options = {
                        //                            width: 400, height: 120,
                        //                            redFrom: 90, redTo: 100,
                        //                            yellowFrom: 75, yellowTo: 90,
                        //                            minorTicks: 5
                        //                        };

                        //var chart = new google.visualization.Gauge(document.getElementById('ddd'));
                        //chart.draw(da, options);
                    }
                </script>

                <div id="ddd">
                </div>
            </div>
        </div>
        <div id="tabs-2">
            <%=Html.GenMarkContent(ViewData["Station"].ToString())%>
            <!-- elements with tooltips -->
            
        </div>
    </div>

    <script type="text/javascript">
        $(document).ready(function() {
            //            SubMitData();
            SubMitBarData(CurType);
            $("#tabs").tabs();
        });
    </script>

</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="HeaderExtend" runat="server">
    <%--<script src="/Scripts/Shared/Dict.js" type="text/javascript"></script>--%>

    <script src="/Scripts/Shared/jquery.popup.js" type="text/javascript"></script>

    <link href="/Content/css/jquery.popup.css" rel="stylesheet" type="text/css" />
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="TopMenu" runat="server">
</asp:Content>
