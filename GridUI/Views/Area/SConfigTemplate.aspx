<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/BasePage.Master" Inherits="System.Web.Mvc.ViewPage" %>

<%@ Import Namespace="QX.HtmlHelperLib" %>
<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    站点配置模板管理
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <script type="text/javascript">
        $(document).ready(function() {
            $("#tabs").tabs();
        });

        function LoadTemplate() {
            $("#ConfigTemplategrid").trigger("reloadGrid");
        }
    </script>

    <div id="tabs">
        <ul>
            <li><a href="#tabs-1">站点模板配置</a></li>
        </ul>
        <div id="tabs-1">
            <table width="100%">
                <tr>
                    <td valign="top">
                        <div style="min-width: 200px">
                            <%= Html.TreeView<QX.Model.AreaTreeNode>(
                        "DictList",
                                 ViewData["DictList"] as IEnumerable<QX.Model.AreaTreeNode>,
                                    d => d.ChildList,
                        d => "<a id='"+d.Code+"' isLeaf='"+d.State+"'>" + d.Name + "</a>"
                       )%>
                        </div>
                    </td>
                    <td valign="top">
                        <%=Html.GenNToolbarHelper("ConfigTemplateModule", "ConfigTemplate", QX.Permission.PermissionHelper.CurrentUserPermission(QX.Config.SessionConfig.UserId()))%>
                        <%=Html.SysComm_JqGrid("ConfigTemplateModule", "ConfigTemplate", "/Area/GetStConfigTemplateList/", true)%>
                    </td>
                </tr>
            </table>
        </div>
    </div>

    <script type="text/javascript">
        $(document).ready(function() {
            $("#tabs").tabs();

        });

        var CurSelNode = { Code: '', Name: '' };

        $(document).ready(function() {
            //数据控件事件绑定
            $("#DictList").bind('click.jstree', function(event) {
                var eventNodeName = event.target.nodeName;

                if (eventNodeName == 'INS') {
                    return;
                } else if (eventNodeName == 'A') {

                    var $subject = $(event.target);
                    var deptcode = $subject.attr("id");
                    
                    CurSelNode.Code = deptcode;
                    CurSelNode.Name = $.trim($subject.text());

                    //读取数据的方法
                    $("#ConfigTemplategrid").setGridParam({ url: '/Area/GetStConfigTemplateList/' + deptcode }).trigger("reloadGrid");

                }
            });
        });
    </script>
    
    

</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="HeaderExtend" runat="server">

    <script src="/Scripts/Shared/Dict.js" type="text/javascript"></script>

    <script src="/Scripts/Shared/ComOperation.js" type="text/javascript"></script>

</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="TopMenu" runat="server">
</asp:Content>
