<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/BasePage.Master" Inherits="System.Web.Mvc.ViewPage<QX.Model.Bse_Area>" %>

<%@ Import Namespace="QX.HtmlHelperLib" %>
<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    字典信息
</asp:Content>
<asp:Content ID="Head" ContentPlaceHolderID="HeaderExtend" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <script type="text/javascript">
        $(document).ready(function() {
            Area_Operation.Init();
        });
        var Itype = '';
    </script>

    <div id="mmenu" style="height: 30px; overflow: auto;">
        <input type="button" id="Add_folder" value="添加" style="display: block; float: left;" />
        <input type="button" id="Edit_folder" value="修改" style="display: block; float: left;" />
        <input type="button" id="Del_folder" value="删除" />
    </div>
    <div class="left_tree" style="width: 250px; float: left;">
        <%= Html.TreeView<QX.Model.AreaTreeNode>(
                        "DictList",
                                 ViewData["DictList"] as IEnumerable<QX.Model.AreaTreeNode>,
                                    d => d.ChildList,
                        d => "<a id='"+d.Code+"' isLeaf='"+d.State+"'>" + d.Name + "</a>"
                       )%>
    </div>
    <div id="dictDiv" style="height: 400px;">
        <form id="dictform" action="/Area/AreaOperation" method="post">
        <%=Html.AutoBindForm("Bse_AreaModule", "Bse_Area", false, false, false)%>
        <%=Html.AutoBindValidate("Bse_AreaModule","dictform")%>
        <div class="FormToolBar">
            <p style="line-height: 80px;">
                <input type="button" value="提交" onclick="Area_Operation.Save()" />
                <input type="button" value="取消" onclick="Area_Operation.Cancel()" />
            </p>
        </div>
        </form>
    </div>
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="TopMenu" runat="server">
</asp:Content>
