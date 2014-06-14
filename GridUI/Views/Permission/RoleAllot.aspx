<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/BasePage.Master" Inherits="System.Web.Mvc.ViewPage" %>

<%@ Import Namespace="QX.HtmlHelperLib" %>
<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    PerAllot
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <div id="mmenu" style="height: 40px; overflow:auto;">
        <input type="button" id="Save" value="保存" style="display: block; float: left;" />
        <input type="button" id="Refresh" value="刷新" style="display: block; float: left;" />
        <input type="button" id="Back" value="返回" style="display: block; float: left;" />
    </div>
    <div class="left_tree" style="width: 250px; float: left;">
        <%= Html.TreeView<QX.Model.Sys_Function>(
                        "DictList",
                        ViewData["FunList"] as IEnumerable<QX.Model.Sys_Function>,
                        d => d.Childrens,
                        d => "<a id='"+d.Fun_Code+"'>" + d.Fun_Name + "</a>",false,"",false,""
                       )%>
    </div>

    <script type='text/javascript'>
        function GetMenuIds() {
            var ids = "";
            $("#DictList").find(".jstree-checked, .jstree-undetermined ").each(function() {
                var isChild = true;
                if ($(this).length != 0) {
                    ids = ids + ($(this).find("a").attr("id")) + ",";
                    isChild = false;
                }

            });
            return ids;
        }

        $(document).ready(function() {
            $("#Refresh").click(function() {
                window.location.reload();
            });

            $("#Back").click(function() {
                // window.location = "/Permission/Index";
                window.close();
            });
            $("#Save").click(function() {
                $.ajax({
                    type: "post",
                    data: { data: GetMenuIds(), code: '<%=ViewData["RoleCode"] %>' },
                    url: "/Permission/UpdateRolePermission",
                    success: function(re, textStatus) {
                        alert(re.Msg);
                    }
                });    //ajax
            });
            $("#Add_folder").click(function() {
                var ids = GetMenuIds();
            });

            $("#DictList").bind("loaded.jstree", function(e, data) {
                $.ajax({
                    type: "post",
                    url: "/Permission/GetUserPermission",
                    data: { id: '<%=ViewData["RoleCode"] %>' },
                    success: function(re, textStatus) {
                        $.each(re, function(i, item) {

                            //如果存在该权限点则自动勾选
                            if (item.PU_FunCode != '' && item.PU_IsCheck == '1') {

                                $("#" + item.PU_FunCode).parent().removeClass("jstree-unchecked jstree-undetermined").addClass("jstree-checked");
                            }
                            else {
                                $("#" + item.PU_FunCode).parent().removeClass("jstree-checked jstree-undetermined").addClass("jstree-unchecked");
                            }
                        });
                    }
                });
            });

            $('#DictList').jstree({
                'core': { 'animation': 0 },
                'plugins': ['themes', 'html_data', 'checkbox', 'ui', 'crrm', 'cookies', 'dnd', 'search', 'types', 'hotkeys', 'unique'],
                'themes': { 'theme': 'classic', 'url': '/Content/JsTreeThemes/classic/style.css', 'dots': true, 'icons': true },
                'ui': { 'select_limit': 1, 'select_multiple_modifier': 'alt', 'selected_parent_close': 'select_parent' }
            });



        }) //end
    </script>

</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="HeaderExtend" runat="server">
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="TopMenu" runat="server">
</asp:Content>
