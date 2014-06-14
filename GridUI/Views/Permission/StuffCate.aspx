<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/BasePage.Master" Inherits="System.Web.Mvc.ViewPage<QX.Model.HR_Department>" %>

<%@ Import Namespace="QX.HtmlHelperLib" %>
<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    ViewPage1
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
   <script type="text/javascript">
       $(document).ready(function() {
           Permission_Handler.Init();
       });
       var Itype = '';
    </script>
    <div id="mmenu" style="height: 30px; overflow: auto;">
        <input type="button" id="Add_folder" value="添加" style="display: block; float: left;" />
        <input type="button" id="Edit_folder" value="修改" style="display: block; float: left;" />
        <input type="button" id="Del_folder" value="删除" />
    </div>
    <div class="left_tree" style="width: 250px;float: left;">
        <%= Html.TreeView<QX.Model.HR_Department>(
                                                     "DictList",
                                                     ViewData["DictList"] as IEnumerable<QX.Model.HR_Department>,
                        d => d.ChildrenDept,
                        d => "<a id='"+d.Dept_Code+"'>" + d.Dept_Name + "</a>"
         )%>
    </div>
    <div id="Div1" style="height: 400px; ">
        <form id="dictform" action="/Permission/DeptOperation" method="post">
            
            <%=Html.AutoBindForm<QX.Model.HR_Department>("HR_DepartmentModule", "HR_Department", Model, false, false, false)%>
            <%=Html.AutoBindValidate("HR_DepartmentModule", "dictform")%>
           <div class="FormToolBar">
        <p style="line-height:80px;">
        <input type="button" value="提交" onclick="Permission_Handler.Save()" />
        <input type="button" value="取消" onclick="Permission_Handler.Cancel()"/>
        </p>
        </div>
        </form>
    </div>

</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="HeaderExtend" runat="server">

    <script src="/Scripts/Module/Permission/PermissionHandler.js" type="text/javascript"></script>
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="TopMenu" runat="server">
</asp:Content>
