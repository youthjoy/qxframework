<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/BasePage.Master" Inherits="System.Web.Mvc.ViewPage<QX.Model.Bse_Dict>" %>

<%@ Import Namespace="QX.HtmlHelperLib" %>
<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    字典信息
</asp:Content>
<asp:Content ID="Head" ContentPlaceHolderID="HeaderExtend" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
 
    <script type="text/javascript">
        $(document).ready(function() {
        Dict_DictHandler.Init();
    });
    var Itype = '<%=ViewData["itype"].ToString()%>';
    </script>

    <div id="mmenu" style="height: 30px; overflow: auto;">
        <input type="button" id="Add_folder" value="添加" style="display: block; float: left;" />
        <input type="button" id="Edit_folder" value="修改" style="display: block; float: left;" />
        <input type="button" id="Del_folder" value="删除" />
    </div>
    <div class="left_tree" style="width: 250px;float: left;">
        <%= Html.TreeView<QX.Model.Bse_Dict>(
                        "DictList",
                        ViewData["DictList"] as IEnumerable<QX.Model.Bse_Dict>,
                        d => d.ChildDictList,
                        d => "<a id='"+d.Dict_Code+"'>" + d.Dict_Name + "</a>"
                       )%>
    </div>
    <div id="dictDiv" style="height: 400px; ">
        <form id="dictform" action="/Dict/DictOperation" method="post">
            
            <%=Html.AutoBindForm("Bse_DictModule","Bse_Dict",false,false,false)%>
            <%=Html.AutoBindValidate("Bse_DictModule", "dictform")%>
            
        <%--<input type="hidden" name="Dict_ID" id="Dict_ID" />
        <input type="hidden" name="Dict_Order" id="Dict_Order" />
        <input type="hidden" name="Dict_PCode" id="Dict_PCode" />
        <input type="hidden" name="Dict_Key" id="Dict_Key" />
        <table>
            <tr>
                <td>
                    <label class="form_label" for='Dict_Code'>
                        编码</label><span ><input class='TextBoxReadOnly form_textbox' readonly="readonly" name='Dict_Code' type='text' class='textbox'
                            id='Dict_Code' /><div>
                                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span></span></div>
                        </span>
                </td>
                <td>
                    <label class="form_label" for='Dict_Name'>
                        名称</label><span class='div_texbox'><input class='form_textbox' name='Dict_Name' type='text' class='textbox'
                            id='Dict_Name' value='' /><div>
                                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span></span></div>
                        </span>
                </td>
            </tr>
            <tr>
                <td>
                    <label class="form_label" for='Dict_Desp'>
                        说明</label><span class='div_texbox'><input class='form_textbox' name='Dict_Desp' type='text' class='textbox'
                            id='Dict_Desp' value='' /><div>
                                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span></span></div>
                        </span>
                </td>
                <td>
                    <label class="form_label" for='Dict_Bak'>
                        备注</label><span class='div_texbox'><input class='form_textbox' name='Dict_Bak' type='text' class='textbox'
                            id='Dict_Bak' /><div>
                                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span></span></div>
                        </span>
                </td>
            </tr>
        </table>--%>
           <div class="FormToolBar">
        <p style="line-height:80px;">
        <input type="button" value="提交" onclick="Dict_DictHandler.Save()" />
        <input type="button" value="取消" onclick="Dict_DictHandler.Cancel()"/>
        </p>
        </div>
        </form>
    </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="TopMenu" runat="server">
</asp:Content>
