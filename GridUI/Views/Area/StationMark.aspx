<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/BasePage.Master" Inherits="System.Web.Mvc.ViewPage<QX.Model.Bse_StationMark>" %>

<%@ Import Namespace="QX.HtmlHelperLib" %>
<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
   站点参数配置
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <%Html.RenderPartial("AttachmentsControl", "uploadCallback", new ViewDataDictionary { new KeyValuePair<string, object>("UploadUrl", "/Area/Upload/"), new KeyValuePair<string, object>("FileType", "File") }); %>
    
    <%=Html.GenNToolbarHelper("Bse_StationMarkModule", "Bse_StationMark", QX.Permission.PermissionHelper.CurrentUserPermission(QX.Config.SessionConfig.UserId()))%>
    <%=Html.SysComm_JqGrid("Bse_StationMarkModule", "Bse_StationMark", "/Area/GetMarkList/" + ViewData["Station"].ToString(), true)%>

    <script type="text/javascript">
        //上传文件
        function uploadCallback(id, fpath) {
            $("#Sta_Background").val(fpath);

            $.ajax({
                url: '/Area/UploadImgMark',
                data: { code: '<%=ViewData["Station"] %>', path: fpath },
                type:'post',
                success: function(d) {
                    if (d.result == 'success') {
                        ShowMsg("上传成功!");
                    }
                }
            });
        }

        $(document).ready(function() {
            var a = new Aspects;
            var bn = $("#Bse_StationMark_add")[0];
            var sv = $("#Bse_StationMark_FormOK")[0];

            a.after(bn, "onclick", function() {
                $("#Sta_StationCode").val('<%=ViewData["Station"] %>');

            });

            a.after(sv, "onclick", function() {
                $("#Bse_StationMarkgrid").trigger('reloadGrid');
            });
        });
    </script>

</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="HeaderExtend" runat="server">

    <script src="/Scripts/Shared/AOP.js" type="text/javascript"></script>

</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="TopMenu" runat="server">
</asp:Content>
