<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<QX.Model.Verify_Template>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	Templdate
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

      <%Html.RenderPartial("GridControl", ""); %>    
    <script src="../../Scripts/Module/Doc/Index.js" type="text/javascript"></script>

</asp:Content>
