<%@ Control Language="C#" Inherits="System.Web.Mvc.ViewUserControl" %>
<%@ Import Namespace="QX.Control" %>
<%@ Import Namespace="QX.HtmlHelperLib" %>

<script type="text/javascript" src="https://www.google.com/jsapi"></script>

<script src="/Scripts/Shared/Dict.js" type="text/javascript"></script>

<div>
    <form id="FormOP" action="/Chart/GetChart/">
    <%=Html.GenNToolbarHelper("StationActModule","Station",true,null)%>
    </form>
</div>

<script type="text/javascript">

    google.load('visualization', '1.0', { 'packages': ['corechart'] });
    $(document).ready(function() {

        Common_Tree_Dict.Init('SType', 'ChartType', function(code, name) {
            CurType = code;
            $("#SType").val(name);
            SubMitBarData(code);
        })

        $("#Station").val('<%=ViewData["Station"]%>');
    });

    function SubMitData() {
        var queryString = $('#FormOP').formSerialize();
        queryString = queryString + "&date=" + new Date();

        $.ajax({
            url: '/Chart/GetGChartData/Report_Test?' + queryString,
            type: 'get',
            dataType: 'json',
            success: function(da) {

                var data = new google.visualization.DataTable(da);
                var options = {
                   // 'title': '',
                    'width': 1000,
                    'height': 300

                };

                DrawLine(data, options);
            },
            error: function(d1, d2) {
                //                    alert(d1);
                //                    alert(d2);
            },
            complete: function() {
                //alert(222);
            }
        })//end ajax

    } //end function

    var CurType = 'Line';

    function SubMitBarData(type) {
        var queryString = $('#FormOP').formSerialize();
        queryString = queryString + "&date=" + new Date();
        var url = '/Chart/GetGChartData/Report_Test?' + queryString;
        //不同类型 不同的数据url
        switch (type) {
            case 'Line': break;
            case 'Area': break;
            case 'Column': break;
        }

        $.ajax({
            url: url,
            type: 'get',
            dataType: 'json',
            success: function(da) {
                var data = new google.visualization.DataTable(da);
                var options = {
                   // 'title': '',
                    'width': 1000,
                    'height': 300

                };
                switch (type) {
                    case 'Line': DrawLine(data, options); break;
                    case 'Area': DrawArea(data, options); break;
                    case 'Column': DrawColumnChart(data, options); break;
                }
            },
            error: function(d1, d2) {
                //                    alert(d1);
                //                    alert(d2);
            },
            complete: function() {
                //alert(222);
            }
        })//end ajax

    } //end function
    var ChartControl_chart;

    function DrawLine(data, options) {
        if (ChartControl_chart != undefined || ChartControl_chart != null) {
            ChartControl_chart.clearChart();
        }
        ChartControl_chart = new google.visualization.LineChart(document.getElementById('chart_div'));
        ChartControl_chart.draw(data, options);
    }

    function DrawArea(data, options) {
        if (ChartControl_chart != undefined || ChartControl_chart != null) {
            ChartControl_chart.clearChart();
        }
        ChartControl_chart = new google.visualization.AreaChart(document.getElementById('chart_div'));
        ChartControl_chart.draw(data, options);
    }

    function DrawColumnChart(data, options) {
        if (ChartControl_chart != undefined || ChartControl_chart != null) {
            ChartControl_chart.clearChart();
        }
        ChartControl_chart = new google.visualization.ColumnChart(document.getElementById('chart_div'));
        ChartControl_chart.draw(data, options);
    }

</script>

<!--Div that will hold the pie chart-->
<div id="chart_div">
</div>
