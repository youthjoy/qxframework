<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/BasePage.Master" Inherits="System.Web.Mvc.ViewPage" %>

<%@ Import Namespace="QX.HtmlHelperLib" %>
<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    Index
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <script type="text/javascript">
        $(document).ready(function() {
            $("#tabs").tabs();
        });


        $(document).ready(function() {
    
           
            //数据控件事件绑定
            $("#DictList").bind('click.jstree', function(event) {
                var eventNodeName = event.target.nodeName;

                if (eventNodeName == 'INS') {
                    return;
                } else if (eventNodeName == 'A') {
                    var $subject = $(event.target);
                    var deptcode = $subject.attr("id");
                    //读取数据的方法
                    $("#Data_Actgrid").setGridParam({ url: '/Area/GetStationDataList/' + deptcode }).trigger("reloadGrid");

                }
            });
        });


        function Data_ActToolBarSearch() {

            Data_Act_Data_ActModule_GridControl.Search();
        }   

        function Data_ActToolBarView() {
            var grid = $('#Data_Actgrid');
            var curid = grid.getGridParam('selrow'); //获取选择行的id
            var data = grid.getRowData(curid);
            if (data.Data_StationCode == undefined) {
                ShowMsg("请选择要查看的站点!");
                return;
            }

            //Win.Open('http://www.163.com');
        }
        
    </script>

    <div id="tabs">
        <ul>
            <li><a href="#tabs-1">站点列表</a></li>
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
                        <%=Html.GenNToolbarHelper(ViewData["Module"].ToString(), "Data_Act",true, QX.Permission.PermissionHelper.CurrentUserPermission(QX.Config.SessionConfig.UserId()))%>
                        <%=Html.SysComm_JqGrid(ViewData["Module"].ToString(), "Data_Act", "/Area/GetStationDataList", true)%>
                    </td>
                </tr>
            </table>
        </div>
    </div>
    
    <script type="text/javascript">
        function Data_ActQuery() {
            var grid = $('#Data_Actgrid');
            var curid = grid.getGridParam('selrow'); //获取选择行的id
            if (curid == null) { 
               alert("请选中要查看的站点!");
                return;
            }
            var data = grid.getRowData(curid);
            window.location ="/Area/StationAct/"+data.Data_StationCode;
        }
        
        function Data_ActToolBarView() {
            var grid = $('#Data_Actgrid');
            var arr = grid.getGridParam('selarrrow'); //获取选择行的id
            var selarr = new Array();
            var namearr = new Array();
            for (var d in arr) {
                var data = grid.getRowData(arr[d]);
                selarr.push(data.Data_StationCode);
                namearr.push(data.Data_SName);
            }

            window.location = '/Area/StationChart/' + selarr.join(',')+"?sname="+namearr.join(',');
        }
    </script>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="HeaderExtend" runat="server">

    
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="TopMenu" runat="server">
</asp:Content>
