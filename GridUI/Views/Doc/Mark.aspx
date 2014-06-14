<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/BasePage.Master" Inherits="System.Web.Mvc.ViewPage" %>

<%@ Import Namespace="QX.Control" %>
<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    标注
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <script src="/Scripts/Shared/jquery.popup.js" type="text/javascript"></script>
<link href="/Content/css/jquery.popup.css" rel="stylesheet" type="text/css" />
   
    <%=Html.GenMarkContent("Station1")%>
    <!-- elements with tooltips -->

   <div style="margin-left:10px;">这里显示备注信息</div>

</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="HeaderExtend" runat="server">
    <link href="/Content/css/jquery.popup.css" rel="stylesheet" type="text/css" />
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="TopMenu" runat="server">
</asp:Content>
