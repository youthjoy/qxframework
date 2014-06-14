<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage" %>

<html xmlns="http://www.w3.org/1999/xhtml">
<head>
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>重庆多邦科技发展有限公司_用户登录</title>
    <style type="text/css">        
        body
        {
            margin:0px;            
            overflow: hidden;
        }
        .STYLE1
        {
            font-size: 12px;
            color: #a1c8c6;
        }
        .STYLE4
        {
            color: #FFFFFF;
            font-size: 12px;
        }
        </style>

    <script src="/Scripts/Shared/jquery-1.4.2.min.js" type="text/javascript"></script>

</head>
<body>
    <table width="100%" height="100%" border="0" cellpadding="0" cellspacing="0">
        <tr>
            <td bgcolor="18643a">
                &nbsp;
            </td>
        </tr>
        <tr>
            <td height="311" background="../Content/images/login_03.gif">
                <table width="758" border="0" align="center" cellpadding="0" cellspacing="0">
                    <tr>
                        <td height="210" background="../Content/images/login1.jpg">
                            &nbsp;
                        </td>
                    </tr>
                    <tr>
                        <td height="101">
                            <table width="100%" border="0" cellspacing="0" cellpadding="0">
                                <tr>
                                    <td width="446" height="101" background="Content/images/login_06.gif">
                                        &nbsp;
                                    </td>
                                    <td width="156">
                                        <table width="100%" border="0" cellspacing="0" cellpadding="0">
                                            <%--  <tr>
                <td height="22"><span class="STYLE4">公&nbsp;&nbsp;司</span></td>
                <td height="22"><select name="company" id="company" style="width:100px; height:16px; border:solid 1px #000000; color:#666666">
                </select>
                </td>
              </tr>--%>
                                            <tr>
                                                <td width="29%" height="22">
                                                    <span class="STYLE4">用户名</span>
                                                </td>
                                                <td width="71" height="22">
                                                    <input type="text" id="username" name="username" style="width: 100px; height: 16px;
                                                        border: solid 1px #000000; color: #666666">
                                                </td>
                                            </tr>
                                            <tr>
                                                <td height="22">
                                                    <span class="STYLE4">密&nbsp;&nbsp;码</span>
                                                </td>
                                                <td height="22">
                                                    <input type="password" id="pwd" name="pwd" style="width: 100px; height: 16px; border: solid 1px #000000;
                                                        color: #666666">
                                                </td>
                                            </tr>
                                            <%--  <tr>
                <td height="22"><span class="STYLE4">角&nbsp;&nbsp;色</span></td>
                <td height="22"><select name="selRole" id="selRole" style="width:100px; height:16px; border:solid 1px #000000; color:#666666"><option id="selRole1"  value="ROLEUSER1">员工</option><option id="selRole2"  value="ROLEUSER2">管理员</option></select></td>
              </tr>--%>
                                            <tr>
                                                <td height="25">
                                                    &nbsp;
                                                </td>
                                                <td height="25">
                                                    <%--<a href="../home/index">
                <img id="imgLogin" alt="" src="../Content/images/dl.gif" width="37" height="19" border="0"></a>--%>
                                                    <button id="btnLogin" style="background-image: url(../Content/images/dl.gif); width: 37px;
                                                        height: 19px; border: 0px">
                                                    </button>
                                                    <%-- <img src="../Content/images/qx.gif" width="37" height="19">--%>
                                                </td>
                                            </tr>
                                        </table>
                                    </td>
                                    <td width="156" background="Content/images/login_09.gif">
                                        &nbsp;
                                    </td>
                                </tr>
                            </table>
                        </td>
                    </tr>
                </table>
            </td>
        </tr>
        <tr>
            <td bgcolor="318858">
                &nbsp;
            </td>
        </tr>
        <tr>
            <td bgcolor="318858">
                <div align="center">
                    <span class="STYLE1">重庆多邦科技发展有限公司 CopyRight 2010</span></div>
            </td>
        </tr>
    </table>

    <script type="text/javascript">

        $("body").bind('keyup', function(event) {


        });

        $(document).ready(function() {

            $("input").each(function() {
                var $this = $(this);
                $this.bind("keyup", function(event) {

                    if (event.keyCode == 13) {
                        if ($this[0].id == document.activeElement.id) {
                            $("#btnLogin").trigger("click");
                        }
                    }
                });
            });

            $("#btnLogin").click(function() {

                var userName = $("#username");
                var PWD = $("#pwd");

                if (userName.val() == "") {
                    userName.focus();
                    alert("用户名不能为空");
                    return;
                }
                if (PWD.val() == "") {
                    PWD.focus();
                    alert("密码不能为空");
                    return;
                }

                $.ajax({
                    type: 'post',
                    url: '/Home/LoginBtn',
                    dataType: 'json',
                    data: { company: $("#company").val(),
                        userName: userName.val(),
                        pwd: PWD.val(),
                        role: $("#selRole").val()
                    },
                    success: function(data) {
                        if (data.result == "success") {
                            window.location = "/home/index";
                        } else {
                            alert(data.msg);
                        }
                    }
                });
            }
     );
        });
    
    </script>

</body>
</html>
