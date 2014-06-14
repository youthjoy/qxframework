<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/BasePage.Master" Inherits="System.Web.Mvc.ViewPage" %>

<%@ Import Namespace="QX.Control" %>
<%@ Import Namespace="QX.HtmlHelperLib" %>
<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    StationChart
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <div>
        <form id="FormOP" action="/Chart/GetChart/">
        <%=Html.GenNToolbarHelper("MStationActModule", "Station", true, null)%>
        </form>
    </div>
    <img id='chart' alt="Chart" />

    <script type="text/javascript">

        function SubMitData() {

            var queryString = $('#FormOP').formSerialize();
            queryString = queryString + "&date=" + new Date();
            $("#chart").attr("src", "/Chart/GetMultiChart/Report_Test?" + queryString);

        }

        $(document).ready(function() {
            $("#FormOP").find("#Station").val('<%=ViewData["Stations"] %>');
            $("#FormOP").find("#SName").val('<%=ViewData["SName"] %>');
            SubMitData();

        });
    </script>

</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="HeaderExtend" runat="server">
    
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="TopMenu" runat="server">
</asp:Content>
