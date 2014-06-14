<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/BasePage.Master" Inherits="System.Web.Mvc.ViewPage<QX.Model.Sys_Function>" %>

<%@ Import Namespace="QX.HtmlHelperLib" %>
<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    Role
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <%=Html.GenNToolbarHelper("Sys_RoleModule","Sys_Role", QX.Permission.PermissionHelper.CurrentUserPermission(QX.Config.SessionConfig.UserId()))%>
    <%=Html.SysComm_JqGrid("Sys_RoleModule","Sys_Role","/Permission/GetRole",true )%>
    <script type="text/javascript">
        function Sys_RoleAllot() {
            var grid = $('#Sys_Rolegrid');
            var curid = grid.getGridParam('selrow'); //获取选择行的id
            var data = grid.getRowData(curid); //获取行号为curid的数据
            if (data.SRole_Code == undefined) {
                ShowMsg("请选中要分配权限的角色!");
                return;
            }
            Win.Open('/Permission/RoleAllot/' + data.SRole_Code);
            //window.location = '/Permission/RoleAllot/' + data.SRole_Code;
        }

    </script>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="HeaderExtend" runat="server">
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="TopMenu" runat="server">
</asp:Content>
