<%@ Control Language="C#" Inherits="System.Web.Mvc.ViewUserControl<QX.Model.Bse_Dict>" %>
<%@ Import Namespace="QX.HtmlHelperLib" %>
<div style="padding:auto;">
<div id="dictTree" style="width:200px;float:left;background:#EFEFEF;">

</div>
<div style="width:800px; height:400px;float:left;">
 <% using (Html.BeginForm("DictOperation", "Dict"))
       {%>
  
            <fieldset style="width: 800px;">
                <legend>基本信息</legend>
                <input type="hidden" name="Dict_ID" id="Dict_ID" value='' />
                <input type="hidden" name="Dict_Key" id="Dict_Key" value='' />
                <%=Html.BindModelToControl<QX.Model.Bse_Dict>("Bse_Dict", ViewData.Model)%>
                <input type="submit" value="确定" />
                <input type="button" value="返回" />
            </fieldset>
     
      <%}%>
</div>
</div>