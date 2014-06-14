<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage" %>
<%@ Import Namespace="QX.HtmlHelperLib" %>
<%@ Import Namespace="QX.MenuHelper" %>
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
<meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
<title>无标题文档</title>
<style type="text/css">
html,body
{    
scrollbar-face-color : #fafafa;  
scrollbar-3dlight-color : #c0c0c0;  
scrollbar-base-color : #fff;  
scrollbar-arrow-color : #c0c0c0;  
scrollbar-shadow-color : #c0c0c0;  
scrollbar-darkshadow-color :#fff;  
margin-left: 0px;
margin-top: 0px;
margin-right: 0px;
margin-bottom: 0px;
}   
    
.STYLE1
{
    color: #FFFFFF;
    font-weight: bold;
    font-size: 12px;
    cursor:pointer;
}
.STYLE2
{
    font-size: 12px;
    color: #03515d;
}
.STYLE3 {
	font-size: 12px;
	color: #033d61;
}
a:link
{
    font-size: 12px;
    text-decoration: none;
    color: #03515d;
}
a:visited
{
    font-size: 12px;
    text-decoration: none;
    color: #03515d;
}
.menu_title SPAN {
	FONT-WEIGHT: bold; LEFT: 3px; COLOR: #ffffff; POSITION: relative; TOP: 2px 
}
.menu_title2 SPAN {
	FONT-WEIGHT: bold; LEFT: 3px; COLOR: #FFCC00; POSITION: relative; TOP: 2px
}
</style>
   
    <link href="/Content/Dtree/dtree.css" rel="stylesheet" type="text/css" />
    <script src="/Scripts/Shared/dtree.js" type="text/javascript"></script>
    
</head>
<body>
    <table width="156" height="100%" border="0" cellpadding="0" cellspacing="0">
        <tr>
            <td align="center" valign="top">
                <table width="100%" height="100%" border="0" cellpadding="0" cellspacing="0">
                    <tr>
                        <td height="33" background="<%=Url.Content("../Content/images/main_21.gif")%>" style=" background-repeat:no-repeat" >
                            &nbsp;
                        </td>
                    </tr>
                    
                    <%=Html.BindLeftMenu(Model as List<QX.MenuHelper.Model.System_Menu>, QX.Permission.PermissionHelper.CurrentUserPermission(QX.Config.SessionConfig.UserId()))%>
                     
                    <tr style="display:none">
                        <td valign="bottom" height="39" background="<%=Url.Content("../../Content/images/main_37.gif")%>">
                            &nbsp;
                        </td>
                    </tr>
                </table>
            </td>
        </tr>
    </table>
    
   <script type="text/javascript" src="<%=Url.Content("../../Scripts/Module/Menu/LeftMenu.js")%>"></script>
</body>
</html>
