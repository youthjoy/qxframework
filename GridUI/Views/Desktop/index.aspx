<%@ Page Title="" Language="C#"  Inherits="System.Web.Mvc.ViewPage" %>
<%@ Import Namespace="QX.HtmlHelperLib" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>用户桌面</title>
    <style type="text/css">
    /***********用户桌面样式**********************/
    a
    {
	    outline: none;
    }
    a:hover,a:visited,a:link,a:actived
    {
        color: #000000;
	    font-size: 12px;
	    outline: medium none;
	    text-decoration: none; 
	}

    #Desktop{ font-size:12px !important; }
    #Desktop a:link #Desktop a:active { font-size:12px !important; text-decoration:underline }
    #Desktop_TopArea{ width:100%; height:220px; border:solid 1px #CADCE5;margin-top:10px; overflow-y:auto; overflow-x:hidden;  }
    #Desktop_TopArea  li{ float:left; width:23%; font-size:12px; margin-left:15px; list-style-type:none; line-height:25px; }
    #Desktop_TopArea fieldset{ float:left; width:98%; background:none; margin-top:5px; margin-left:5px; border:dotted 1px #444444 }
    /*#Desktop_TopArea fieldset legend{ background:none ; border-style:dotted}*/

    #Desktop_MainArae{ width:100%; height:300px; border:solid 0px #CADCE5;margin-top:10px; overflow:hidden  }
    #Desktop_LeftArea{ width:49%; float:left; height:99%;border:solid 1px #CADCE5; }
    #Desktop_LeftArea li { float:left; width:45%; font-size:12px; margin-left:15px; list-style-type:none; line-height:25px; }
    #Desktop_RightArea{ width:49%; float:right; height:99%;border:solid 1px #CADCE5; }
    .Desktop_Tool 
    {
        width:100%; 
        height:29px;
        line-height:29px; 
        vertical-align:middle;
        background:#CADCE5 url(/Content/images/right_03.gif) repeat-x scroll 0 0;
        font-size:12px;           
    }
    </style>
</head>
<body>
    <div id="Desktop">
    <%--顶部区域--%>
    <div id="Desktop_TopArea">
        <div class="Desktop_Tool"> &nbsp <img src="/Content/images/top166.png"/> 统计区域 </div>
        <%=Html.DeskTop(DeskTopLocation.TOP)%>
    </div>
    
    <div id="Desktop_MainArae">
    
        <%--左边区域--%>
        <div id="Desktop_LeftArea">            
           <div class="Desktop_Tool"> &nbsp <img src="/Content/images/top159.png"/> 待审区域 </div> 
           <%=Html.DeskTop(DeskTopLocation.LEFT)%>
        </div>
        
        <%--右边区域--%>
        <div id="Desktop_RightArea">
            <div class="Desktop_Tool">&nbsp <img src="/Content/images/top41.png"/> 通知+文档FAQ区域 </div> 
            <%=Html.DeskTop(DeskTopLocation.RIGHT)%>
        </div>
        
    </div>
    </div>
</body>
</html>