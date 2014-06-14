<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/BasePage.Master" Inherits="System.Web.Mvc.ViewPage<QX.Model.Bse_Station>" %>

<%@ Import Namespace="QX.HtmlHelperLib" %>
<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    站点数据配置
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <script type="text/javascript">
        $(document).ready(function() {
            $("#tabs").tabs();
        });
    </script>

    <div id="tabs">
        <ul>
            <li><a href="#tabs-1">
                <%=Model.SN_Name %>站点配置</a> </li>
        </ul>
        <div id="tabs-1">
            <%=Html.GenNToolbarHelper("Bse_CheckValueModule", "Bse_CheckValue", QX.Permission.PermissionHelper.CurrentUserPermission(QX.Config.SessionConfig.UserId()))%>
            <%=Html.SysComm_JqGrid("Bse_CheckValueModule", "Bse_CheckValue", "/Area/GetStationConfigList/" + ViewData["StationCode"], true)%>
        </div>
    </div>
    <div id="templateSel" style="display: none;">
    </div>

    <script type="text/javascript">

        $(document).ready(function() {
            var div = $("#templateSel");
            div.dialog({ autoOpen: false, buttons: {
                "确定": function() {
                    var item = $('input:radio:checked').val();
                   

                    $.ajax({
                        type: "post",
                        url: "/Area/LoadTemplate",
                        dataType: "json",
                        data: { module: item, statcode: '<%=ViewData["StationCode"] %>' },
                        success: function(re, textStatus) {
                            if (re.result = 'success') {
                                $("#templateSel").dialog('close');
                                $('#Bse_CheckValuegrid').trigger('reloadGrid');
                            } else {
                                alert(re.result);
                            }
                        }
                    }); //ajax
                },
                "取消": function() {
                    $("#templateSel").dialog('close');
                }
}//button

            }); //end dialog

            $.ajax({
                type: "post",
                url: "/Area/GetTemplateList",
                dataType: "json",
                //data: { },
                success: function(re, textStatus) {

                    $.each(re, function(i, d) {
                        var te = "<label><input type='radio' id='" + d.SC_Code + "' name='expectedVia' value='" + d.SC_StationCode + "' checked='checked'>" + d.SC_StatName + "</label>";
                        div.append(te);
                    });
                }
            }); //ajax
        });

        function Bse_CheckValueTempLoad() {
            $("#templateSel").dialog('open');

        }

        function GetBack() {
            window.location = '/Area/StationOperation/ <%= ViewData["StationCode"] %>';
        }
    </script>

</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="HeaderExtend" runat="server">

    <script src="/Scripts/Shared/jquery.addInput.js" type="text/javascript"></script>

    <script src="/Scripts/Shared/ComOperation.js" type="text/javascript"></script>

</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="TopMenu" runat="server">
</asp:Content>
