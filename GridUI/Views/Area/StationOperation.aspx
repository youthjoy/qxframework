 <%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/BasePage.Master" Inherits="System.Web.Mvc.ViewPage" %>

<%@ Import Namespace="QX.HtmlHelperLib" %>
<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    StationOperation
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <div id="tabs">
        <ul>
            <li><a href="#tabs-1">站点列表</a></li>
        </ul>
        <div id="tabs-1">
            <table width="100%">
                <tr>
                    <td valign="top">
                        <div style="min-width:200px">
                            <%= Html.TreeView<QX.Model.AreaTreeNode>(
                        "DictList",
                                 ViewData["DictList"] as IEnumerable<QX.Model.AreaTreeNode>,
                                    d => d.ChildList,
                        d => "<a id='"+d.Code+"' isLeaf='"+d.State+"'>" + d.Name + "</a>"
                       )%>
                        </div>
                    </td>
                    <td valign="top">
                        <%=Html.GenNToolbarHelper("Bse_StationModule", "Bse_Station", QX.Permission.PermissionHelper.CurrentUserPermission(QX.Config.SessionConfig.UserId()))%>
                        <%=Html.SysComm_JqGrid("Bse_StationModule", "Bse_Station", "/Area/GetStationList", true)%>
                    </td>
                </tr>
            </table>
        </div>
    </div>
    
    <div id="Bse_Station_Oper" style="display: none;">
        <form id="Bse_Station_Form" action="/Area/SOperation" method="post">
        <%=Html.AutoBindForm("Bse_StationModule","Bse_Station",false,false,true)%>
        <%=Html.AutoBindValidate("Bse_StationModule", "Bse_Station_Form")%>
        </form>
    </div>

    <script type="text/javascript">
        function LoadStation() {
            $("#Bse_Stationgrid").trigger("reloadGrid");
        }
        $(document).ready(function() {
            $("#tabs").tabs();

            $('#Bse_Station_Oper').dialog({ autoOpen: false, title: '编辑记录', width: 800, minWidth: 750, minHeight: 200, height: 245 });

            //添加按钮
            var bn = $("#Bse_Station_add")[0];
            //结束按钮
            var sv = $("#Bse_Station_FormOK")[0];

            var a = new Aspects;

            a.after(bn, "onclick", function() {
                //alert(CurSelNode.Code);
                $("#SN_AreaCode").val(CurSelNode.Code);
                $("#SN_AreaName").val(CurSelNode.Name)
            });
            
            a.after(sv, "onclick", function() {
                $("#Bse_Stationgrid").trigger("reloadGrid");
            });
        });

        var CurSelNode = { Code: '', Name: '' };

        function Bse_StationMark() {
            var grid = $('#Bse_Stationgrid');
            var curid = grid.getGridParam('selrow'); //获取选择行的id
            var data = grid.getRowData(curid);
            if (data.SN_Code == undefined) {
                ShowMsg("请选中要配置的站点!");
                return;
            }

            Win.Open('/Area/StationMark/' + data.SN_Code);
        }

        function Bse_StationConfig() {
            var grid = $('#Bse_Stationgrid');
            var curid = grid.getGridParam('selrow'); //获取选择行的id
            var data = grid.getRowData(curid);
            if (data.SN_Code == undefined) {
                ShowMsg("请选中要配置的站点!");
                return;
            }

            window.location = '/Area/StationConfig/'+data.SN_Code;
        }

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
                    CurSelNode.Name =$.trim($subject.text());

                    //读取数据的方法
                    $("#Bse_Stationgrid").setGridParam({ url: '/Area/GetStationList/' + deptcode }).trigger("reloadGrid");

                }
            });
        });
    </script>

</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="HeaderExtend" runat="server">

    <script src="/Scripts/Shared/AOP.js" type="text/javascript"></script>
    <script src="/Scripts/Shared/Dict.js" type="text/javascript"></script>

    <script src="/Scripts/Shared/ComOperation.js" type="text/javascript"></script>

</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="TopMenu" runat="server">
</asp:Content>
