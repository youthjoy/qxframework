<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/BasePage.Master" Inherits="System.Web.Mvc.ViewPage<QX.Model.Sys_Function>" %>

<%@ Import Namespace="QX.HtmlHelperLib" %>
<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    Index
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <table style="width: 100%">
        <tr>
            <td>
                <div class="left_tree" width="200px">
                    <%= Html.TreeView<QX.Model.HR_Department>(
                        "dept",
                        ViewData["DeptList"] as IEnumerable<QX.Model.HR_Department>,
                        d => d.ChildrenDept,
                        d => "<a id='"+d.Dept_Code+"'>" + d.Dept_Name + "</a>",
                        true,"",false,@"onselect : function(node,tree_obj){//节点单击事件   
                                                 
                  
                                }
         ")%>
                </div>
            </td>
            <td valign="top" style="width: 80%">
                <%=Html.GenNToolbarHelper("HR_StuffModule", "Bse_Employee", QX.Permission.PermissionHelper.CurrentUserPermission(QX.Config.SessionConfig.UserId()))%>
                <%=Html.SysComm_JqGrid("HR_StuffModule", "Bse_Employee", "/Permission/GetEmpList/", true)%>
            </td>
        </tr>
    </table>
    <%=Html.ReferControl("RoleReferModule", "Sys_Role",false)%>

    <script type="text/javascript">
        $(document).ready(function() {


            //数据控件事件绑定
            $("#dept").bind('click.jstree', function(event) {
                var eventNodeName = event.target.nodeName;

                if (eventNodeName == 'INS') {
                    return;
                } else if (eventNodeName == 'A') {
                    var $subject = $(event.target);
                    var deptcode = $subject.attr("id");
                    //读取数据的方法
                    $("#Bse_Employeegrid").setGridParam({ url: '/Permission/GetEmpList/' + deptcode }).trigger("reloadGrid");

                }
            });
        });

        //        function Bse_EmployeeRoleAllot() {
        //            var grid = $('#Bse_Employeegrid');
        //            var curid = grid.getGridParam('selrow'); //获取选择行的id
        //            var data = grid.getRowData(curid); //获取行号为curid的数据
        //            if (data.Emp_Code == undefined) {
        //                ShowMsg("请选中要分配权限的人员!");
        //                return;
        //            }
        //            CurUser = data.Emp_Code;
        //            $("#Sys_RoleRelationgrid").setGridParam({ url: '/Permission/GetRoleRelationList/' + data.Emp_Code }).trigger("reloadGrid");

        //            $("#RoleAllot").dialog('open');
        //        }

        //角色分配
        function Bse_EmployeeToolBarEdit() {

            RoleReferModuleSys_RoleOpenRefer(function(data) {
                var grid = $('#Bse_Employeegrid');
                var curid = grid.getGridParam('selrow'); //获取选择行的id
                if (curid == null) {
                    ShowMsg("请选择要分配权限的人员!");
                    return;
                }
                var d = grid.getRowData(curid);

                $.ajax({
                    url: '/Permission/AllotRole',
                    data: { UCode: d.Stuff_Code, Role: data.SRole_Code },
                    type: 'post',
                    success: function(da) {
                        if (da.result == 'success') {
                            var grid = $('#Bse_Employeegrid');
                            grid.trigger('reloadGrid');
                            ShowMsg("分配完成 ！");
                        }
                    }
                });
            });
        }
        //个人权限分配
        function Bse_EmployeeAllot() {
            var grid = $('#Bse_Employeegrid');
            var curid = grid.getGridParam('selrow'); //获取选择行的id
            var data = grid.getRowData(curid); //获取行号为curid的数据
            if (data.Stuff_Code == undefined) {
                ShowMsg("请选中要分配权限的人员!");
                return;
            }
            Win.Open('/Permission/PerAllot/' + data.Stuff_Code);

        }

        function Bse_EmployeeToolBarSearch() {

            Bse_Employee_HR_StuffModule_GridControl.Search();
        }

        $(document).ready(function() {
//            var a = new Aspects;
//            var bn = $("#Bse_Employee_edit")[0];

//            a.after(bn, "onclick", function() {
//                $("#Stuff_Password").val('');

//            });
        });
        
        function LoadStuff() {
            $("#Bse_Employeegrid").trigger("reloadGrid");
        }
    </script>

</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="HeaderExtend" runat="server">

    <script src="/Scripts/Shared/Dept.js" type="text/javascript"></script>

    <script src="/Scripts/Shared/AOP.js" type="text/javascript"></script>

</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="TopMenu" runat="server">
</asp:Content>
