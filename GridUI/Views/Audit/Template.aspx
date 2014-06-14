<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/BasePage.Master" Inherits="System.Web.Mvc.ViewPage<QX.Model.Verify_Template>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    Templdate
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <%Html.RenderPartial("GridControl", ""); %>

    <script src="../../Scripts/Module/Audit/Templdate.js" type="text/javascript"></script>

    <script type="text/javascript">
        $(document).ready(function() {
        Audit_Templdate_GridControl.Init("/Audit/TemplateList", "");
        });
    </script>

</asp:Content>
