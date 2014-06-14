<%@ Control Language="C#" Inherits="System.Web.Mvc.ViewUserControl" %>

<div>
   
    <div id="<%=Model.ToString() %>search">
    </div>
    <table id="<%=Model.ToString() %>grid" class="scroll" cellpadding="0" cellspacing="0">
    </table>
    <div id="<%=Model.ToString() %>pager" class="scroll" style="text-align: center;">
    </div>
    
</div>
