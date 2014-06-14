<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/BasePage.Master" Inherits="System.Web.Mvc.ViewPage" %>

<%@ Import Namespace="QX.HtmlHelperLib" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	通用报表
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    

    <form id="formOP" name="formOp" action="/ChartReport/MMPPTrend/Report_MMPP">
    <div id="Div1" class="toolbar">
        <ul>
            <%=Html.ChartToolBar(ViewData["Module"].ToString())%></ul>
    </div>
    </form>

    <DIV style=" clear:both; float: left">
        <%Html.RenderPartial("QXChart", (QX.Model.ChartConfig)Model);%>
        </DIV>
        
    <script type="text/javascript">

        var FilterType = '<%=ViewData["Xit"]%>';

        $(function() {
            var dept = $("#Dept");
            var deptCode = $("#DeptCode");
            var company = $("#Company");
            var companyCode = $("#CompanyCode");
            var Start = $("#StartDate");
            var End = $("#EndDate");
            
            
            Common_Tree_Dept.Init("Dept", function(code, name, rootCode, rootName) {
                dept.val(name);
                deptCode.val(code);
                company.val(rootCode);
                companyCode.val(rootName);
            });
            
            
            $("#btnSubmit").click(function() {
                if (dept.val() == "" || company.val() == "" || Start.val() == "" || End.val() == "") {
                    alert("请将选择条件填定完整");
                } else {
                    $("#formOP").submit();
                }
            });

            $("#Xit").val(FilterType);
        })
    </script>

</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="HeaderExtend" runat="server">



</asp:Content>

<asp:Content ID="Content4" ContentPlaceHolderID="TopMenu" runat="server">
</asp:Content>
