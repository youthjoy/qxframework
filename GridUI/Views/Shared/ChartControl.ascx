<%@ Control Language="C#" Inherits="System.Web.Mvc.ViewUserControl" %>
<%@ Import Namespace="ChartLib" %>
<%
    try
    {
        ChartHelper helper = ChartHelper.GetInstance();
        helper.GenChart(Model.ToString(), Chart1);
        helper.SetSerial(Model.ToString(), Chart1, null);
    }
    catch (Exception ex)
    {
        //Response.Write(ex.Message.ToString());
    }

%>
<asp:Chart ID="Chart1" runat="server">
</asp:Chart>
