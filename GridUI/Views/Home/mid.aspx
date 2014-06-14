<%@ Page Title="" Language="C#" Inherits="System.Web.Mvc.ViewPage" %>

<html xmlns="http://www.w3.org/1999/xhtml">
<head>
<meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
<title>系统框架</title>
<style type="text/css">
body 
{
    margin:0 0 0 0;
}
.navPoint { 
    COLOR: white; CURSOR: hand; FONT-FAMILY: Webdings; FONT-SIZE: 9pt 
} 
.LeftStyle
{
    overflow-x:hidden;
}
</style>

<script type="text/javascript">
function switchSysBar(){
    var ssrc = document.all("img1").title;
    if (ssrc=="打开")
    { 
        document.all("img1").src="/Content/images/main_30_1.gif";
        document.all("frmTitle").style.display = "none";
        document.all("img1").title = "关闭";
    } 
    else
    { 
        document.all("img1").src="/Content/images/main_30.gif";
        document.all("frmTitle").style.display = "";
        document.all("img1").title = "打开";
    } 
} 
</script>

</head>

<body>
<table width="100%" height="100%" border="0" cellpadding="0" cellspacing="0">
    <tr>
        <td width="157" id="frmTitle" nowrap name="fmTitle" align="center" valign="top">
            <iframe class="LeftStyle" id="I1" name="I1" height="100%" width="100%" src="left"
                border="0" frameborder="0" scrolling="auto">浏览器不支持嵌入式框架，或被配置为不显示嵌入式框架。</iframe>
        </td>
        <td width="4" valign="middle" background="/Content/images/main_27.gif" onclick="switchSysBar()">
            <span class="navPoint" id="switchPoint" title="关闭/打开左栏">
                <img title="打开" src="/Content/images/main_30.gif" name="img1" width="4" height="47" id="img1"></span>
        </td>
        <td align="center" valign="top">
            <iframe id="Main" name="Main" height="100%" width="100%" border="0" frameborder="0"
                src="right">浏览器不支持嵌入式框架，或被配置为不显示嵌入式框架。</iframe>
        </td>
    </tr>
</table>
</body>
</html>
