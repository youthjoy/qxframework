<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
<meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
<title>无标题文档</title>

    <script src="/Scripts/Shared/WinOpen.js" type="text/javascript"></script>
    <style type="text/css">
        .uiFloat li
        {
            float: left;
            line-height:30px;
            margin-right:15px;
            cursor:pointer;                     
        }
        .TopLink{ margin-top:-18px; margin-left:-35px;  font-size:13px; width:100%; }
        .TopLink  ul
        {
            list-style-type: none;
        }
        .HasMove{ cursor:move}
        .HasBg{ background-image:url('/Content/images/main_18.gif'); border:solid 1px #adb9c2; }
    </style>
    
    <script type="text/javascript">
        //$(function() {
        //    //            $(".uiFloat").sortable({ revert: true, scroll: false, items: 'li', helper: 'clone' });
        //    //$(".uiFloat li").mouseover(function() { $(this).addClass("HasBg"); });
        //    //$(".uiFloat li").mouseout(function() { $(this).removeClass("HasBg"); });

        //    //            $('.uiFloat').bind('sortstop', function(event, ui) {
        //    //                //存入数据库
        //    //                
        //    //            });

        //    //            $('.uiFloat').bind('sortout', function(event, ui) {
        //    //                alert(ui.item.id);
        //    //            })

        //    //            $('.uiFloat').bind('sort', function(event, ui) {
        //    //                //alert(ui.position.top);
        //    //                if (ui.position.top < -150) {
        //    //                    $(ui.item[0]).remove();
        //    //                    $('uiFloat').find('#' + $(ui.item[0]).attr("id")).remove();
        //    //                }
        //    //            })

        //    $("#OpenLink").click(function() {
        //        Win.Open("/Menus/QuickLink", 800, 600);
        //    })

        //})
    </script>
    
<style type="text/css">
<!--
    body {
	    margin-left: 0px;
	    margin-top: 0px;
	    margin-right: 0px;
	    margin-bottom: 0px;
    	
    }
    .STYLE1 {font-size: 12px}
    .STYLE2 {
	    color: #03515d;
	    font-size: 12px;
    }
-->
a:link {font-size:12px; text-decoration:none; color:#000000;}
a:visited {font-size:12px; text-decoration:none; color:#000000;}
a:hover {font-size:12px; text-decoration:none; color:#FF0000;}

a.v1:link {font-size:12px; text-decoration:none; color:#03515d;}
a.v1:visited {font-size:12px; text-decoration:none; color:#03515d;}
</style>

</head>

<body style="cursor: auto; ">
<table width="100%" border="0" cellspacing="0" cellpadding="0">
  <tr>
    <td height="26" background="<%=Url.Content("/Content/images/main_03.gif")%>"><table width="100%" border="0" cellspacing="0" cellpadding="0">
      <tr>
        <td width="227" height="26" background="<%=Url.Content("/Content/images/main_01.gif")%>" >&nbsp;</td>
        <td>&nbsp;</td>
        <td width="60"><img src="<%=Url.Content("/Content/images/main_05.gif")%>" width="60" height="26" /></td>
      </tr>
    </table></td>
  </tr>
  <tr>
    <td height="64"><table width="100%" border="0" cellspacing="0" cellpadding="0" >
      <tr> 
        <td width="227" height="64" background="<%=Url.Content("/Content/images/main_06.gif")%>" nowrap="nowrap" >&nbsp;</td>
        <td><table width="100%" border="0" cellspacing="0" cellpadding="0">
          <tr>
            <td height="26" background="<%=Url.Content("/Content/images/main_07.gif")%>"><table width="100%" border="0" cellspacing="0" cellpadding="0">
              <tr>
                <td height="26"><table width="100%" border="0" cellspacing="0" cellpadding="0">
                  <tr>
                    <td width="640" height="26"><table width="100%" border="0" cellspacing="0" cellpadding="0">
                      <tr>
                        <td width="30"><div align="center"><img src="<%=Url.Content("/Content/images/top_1.gif")%>" width="14" height="14" /></div></td>
                        <td  nowrap="nowrap" class="STYLE1">当前登录用户：<%=ViewData["UserName"].ToString()%> 用户角色：<%=ViewData["UserRole"].ToString()%> IP:<%=ViewData["IP"]%> </td>
                      </tr>
                    </table></td>
                    <td width="19"><img src="<%=Url.Content("/Content/images/main_09.gif")%>" width="19" height="26" /></td>
                    <td width="352"><table width="46%" border="0" align="right" cellpadding="0" cellspacing="0">
                      <tr>
                        <td width="56"><table width="45" border="0" cellspacing="0" cellpadding="0">
                            <tr>
                              <td width="21"><div align="center"><img src="<%=Url.Content("/Content/images/top_2.gif")%>" width="14" height="14" /></div></td>
                              <td width="35"><div align="center" class="STYLE1"><a target="Main" href="/Desktop/index">首页</a></div></td>
                            </tr>
                        </table></td>
                        <td width="10"><img src="<%=Url.Content("/Content/images/main_11.gif")%>" width="6" height="26" /></td>
                        <td width="56"><table width="45" border="0" cellspacing="0" cellpadding="0">
                            <tr>
                              <td width="21"><div align="center"><img src="<%=Url.Content("/Content/images/top_3.gif")%>" width="14" height="14" /></div></td>
                              <td width="24"><div align="center" class="STYLE1"><a target="Main" href="javascript:parent.Main.history.back()">后退</a></div></td>
                            </tr>
                        </table></td>
                        <td width="10"><img src="<%=Url.Content("/Content/images/main_11.gif")%>" width="6" height="26" /></td>
                        <td width="56"><table width="45" border="0" cellspacing="0" cellpadding="0">
                            <tr>
                              <td width="21"><div align="center"><img src="<%=Url.Content("/Content/images/top_4.gif")%>" width="14" height="14" /></div></td>
                              <td width="24"><div align="center" class="STYLE1"><a target="Main" href="javascript:parent.Main.history.forward()">前进</a></div></td>
                            </tr>
                        </table></td>
                        <td width="10"><img src="<%=Url.Content("/Content/images/main_11.gif")%>" width="6" height="26" /></td>
                        <td width="56"><table width="45" border="0" cellspacing="0" cellpadding="0">
                            <tr>
                              <td width="21"><div align="center"><img src="<%=Url.Content("/Content/images/top_5.gif")%>" width="14" height="14" /></div></td>
                              <td width="24"><div align="center" class="STYLE1"><a target="Main"  href="javascript:parent.Main.location.reload();">刷新</a></div></td>
                            </tr>
                        </table></td>
                        <td width="10"><img src="<%=Url.Content("/Content/images/main_11.gif")%>" width="6" height="26" /></td>
                        <td width="102"><table width="102" border="0" cellspacing="0" cellpadding="0">
                            <tr>
                              <td width="22"><div align="center"><img src="<%=Url.Content("/Content/images/top_6.gif")%>" width="14" height="14" /></div></td>
                              <td width="80"><div align="center" class="STYLE1"><a target="Main" href="/HR/UserAlterInfo">个人信息修改</a></div></td>
                            </tr>
                        </table></td>
                        <td width="10"><img src="<%=Url.Content("/Content/images/main_11.gif")%>" width="6" height="26" /></td>
                        <td width="56"><table width="45" border="0" cellspacing="0" cellpadding="0">
                            <tr>
                              <td width="21"><div align="center"><img src="<%=Url.Content("/Content/images/top_7.gif")%>" width="14" height="14" /></div></td>
                              <td width="24"><div align="center" class="STYLE1"><a href="/home/logout">退出</a></div></td>
                            </tr>
                        </table></td>
                        </tr>
                    </table></td>
                  </tr>
                </table></td>
                <td width="12"><img src="<%=Url.Content("/Content/images/main_13.gif")%>" width="12" height="26" /></td>
              </tr>
            </table></td>
          </tr>
          <tr>
            <td height="38" background="<%=Url.Content("/Content/images/main_15.gif")%>">
            <table width="100%" border="0" cellspacing="0" cellpadding="0">
              <tr>
                <td height="38">               
                   
                   <div class="TopLink" >
                            <ul class="uiFloat">
                        	   <%=ViewData["TopList"]%>
                        	   <li><a href='#' id='OpenLink'><img style="margin-top:7px; border:none" alt="管理快捷方式" src="/Content/images/add1.png" /></a></li>
                            </ul>                       
                    </div>
                    
                </td>
                <td width="60" ><div align="right"><img src="/Content/images/main_17.gif" width="60" height="38" /></div></td>
              </tr>
            </table></td>
          </tr>
        </table></td>
      </tr>
    </table></td>
  </tr>
</table>
</body>
</html>
