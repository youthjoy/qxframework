<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/BasePage.Master" Inherits="System.Web.Mvc.ViewPage" %>

<%@ Import Namespace="QX.HtmlHelperLib" %>
<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    Index
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <div>
        <form id="FormOP" action="/Chart/GetChart/">
        <%=Html.ChartToolBar("Rpt_MMPI")%>
        </form>
    </div>
    <img id='chart' alt="Chart" />

    <script type="text/javascript">

        function SubMitData() {
            
            var queryString = $('#FormOP').formSerialize();
            queryString = queryString + "&date=" + new Date();
            $("#chart").attr("src", "/Chart/GetChart/Report_Test?" + queryString);

        }
        $(document).ready(function() {
//            var ooptions = {
//                success: function(data) {
//                    if (data.result == "success") {
//                        alert(data.Msg);
//                    }
//                    else {
//                        alert("更新完成");
//                    }
//                },  // post-submit callback
//                width: 800,
//                timeout: 3000
//            };

//            //采购主表表单
//            $("#FormOP").ajaxForm(ooptions);
//        var queryString = $('#FormOP').formSerialize(); 
//            $("#chart").attr("src", "/Chart/GetChart/Report_Test?"+queryString);

        });
    </script>

    
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="HeaderExtend" runat="server">
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="TopMenu" runat="server">
</asp:Content>
