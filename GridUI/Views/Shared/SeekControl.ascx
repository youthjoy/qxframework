<%@ Control Language="C#" Inherits="System.Web.Mvc.ViewUserControl" %>

<div id="finaceOperation" style="display: none">
    <form action="/Document/SeekAdd" id="stuff" method="post" name="stuff">
    <%-- <table>
        <tr>
            <td>
                <label class="form_label" form_label for="DL_Code">
                    借阅编码</label>
                <span class="div_texbox">
                    <input readonly="TRUE" name="DL_Code" type="text" class="form_textbox  TextBoxReadOnly"
                        id="DL_Code" value="" /><div>
                            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span></span></div>
                </span>
            </td>
            <td>
                <label class="form_label" form_label for="DL_DocumentCode">
                    图书编码</label>
                <span class="div_texbox">
                    <input name="DL_DocumentCode" type="text" class="form_textbox" id="DL_DocumentCode"
                        value="" /><div>
                            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span></span></div>
                </span>
            </td>
        </tr>
        <tr>
            <td>
                <label class="form_label" form_label for="DL_LendingNum">
                    借阅份数</label>
                <span class="div_texbox">
                    <input name="DL_LendingNum" type="text" class="form_textbox" id="DL_LendingNum" value="" /><div>
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span></span></div>
                </span>
            </td>
            <td>
                <label class="form_label" form_label for="DL_LendorCompany">
                    借阅人公司</label>
                <span class="div_texbox">
                    <input name="DL_LendorCompany" type="text" class="form_textbox" id="DL_LendorCompany"
                        value="" /><div>
                            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span></span></div>
                </span>
            </td>
        </tr>
        <tr>
            <td>
                <label class="form_label" form_label for="DL_LendorDept">
                    借阅人部门</label>
                <span class="div_texbox">
                    <input name="DL_LendorDept" type="text" class="form_textbox  popup" id="DL_LendorDept"
                        value="" /><div>
                            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span></span></div>
                </span>
            </td>
            <td>
                <label class="form_label" form_label for="DL_Person">
                    借阅人</label>
                <span class="div_texbox">
                    <input name="DL_Person" type="text" class="form_textbox" id="DL_Person" value="" /><div>
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span></span></div>
                </span>
            </td>
        </tr>
        <tr>
            <td>
                <label class="form_label" form_label for="DL_Authorizor">
                    借阅批准人</label>
                <span class="div_texbox">
                    <input name="DL_Authorizor" type="text" class="form_textbox" id="DL_Authorizor" value="" /><div>
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span></span></div>
                </span>
            </td>
            <td>
                <label class="form_label" form_label for="DL_Remark">
                    备注</label>
                <span class="div_texbox">
                    <input name="DL_Remark" type="text" class="form_textbox" id="DL_Remark" value="" /><div>
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span></span></div>
                </span>
            </td>
        </tr>
    </table>--%>
     <table>

            <tr>
             <td><label class='form_label' form_label for='DL_Code'>借阅编码</label>
                                    <span class='div_texbox'>
                                    <input readonly='TRUE' name='DL_Code' type='text' class='form_textbox  TextBoxReadOnly' id='DL_Code' value='' /><div>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span></span></div>                                   
                                </span>
                                </td> <td><label class='form_label' form_label for='DL_DocumentCode'>图书编码</label>
                                    <span class='div_texbox'>
                                    <input  name='DL_DocumentCode' type='text' class='form_textbox' id='DL_DocumentCode' value='' /><div>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span></span></div>                                   
                                </span>

                                </td></tr><tr> <td><label class='form_label' form_label for='DL_DocumentName'>图书名称</label>
                                    <span class='div_texbox'>
                                    <input  name='DL_DocumentName' type='text' class='form_textbox' id='Text17' value='' /><div>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span></span></div>                                   
                                </span>
                                </td> <td><label class='form_label' form_label for='DL_LendingNum'>借阅份数</label>
                                    <span class='div_texbox'>
                                    <input  name='DL_LendingNum' type='text' class='form_textbox' id='DL_LendingNum' value='' /><div>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span></span></div>                                   
                                </span>

                                </td></tr><tr> <td><label class='form_label' form_label for='DL_LendorCompany'>借阅人公司</label>
                                    <span class='div_texbox'>
                                    <input readonly='true' name='DL_LendorCompany' type='text' class='form_textbox  TextBoxReadOnly  popup' id='DL_LendorCompany' value='' /><div>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span></span></div>                                   
                                </span>
                                </td> <td><label class='form_label' form_label for='DL_LendorDept'>借阅人部门</label>
                                    <span class='div_texbox'>
                                    <input readonly='true' name='DL_LendorDept' type='text' class='form_textbox  TextBoxReadOnly  popup' id='DL_LendorDept' value='' /><div>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span></span></div>                                   
                                </span>

                                </td></tr><tr> <td><label class='form_label' form_label for='DL_Person'>借阅人</label>
                                    <span class='div_texbox'>
                                    <input  name='DL_Person' type='text' class='form_textbox' id='DL_Person' value='' /><div>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span></span></div>                                   
                                </span>
                                </td> <td><label class='form_label' form_label for='DL_LendingDate'>借阅时间</label>
                                    <span class='div_texbox'>
                                    <input readonly='true' name='DL_LendingDate' type='text' class='form_textbox  TextBoxReadOnly date_icon' id='DL_LendingDate' value='' /><div>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span></span></div>                                   
                                </span>

                                </td></tr><tr> <td><label class='form_label' form_label for='DL_Operator'>借阅经手人</label>
                                    <span class='div_texbox'>
                                    <input  name='DL_Operator' type='text' class='form_textbox' id='Text19' value='' /><div>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span></span></div>                                   
                                </span>
                                </td> <td><label class='form_label' form_label for='DL_Authorizor'>借阅批准人</label>
                                    <span class='div_texbox'>
                                    <input  name='DL_Authorizor' type='text' class='form_textbox' id='DL_Authorizor' value='' /><div>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span></span></div>                                   
                                </span>

                                </td></tr><tr> <td><label class='form_label' form_label for='DL_LendingReason'>借阅事由</label>
                                    <span class='div_texbox'>
                                    <input  name='DL_LendingReason' type='text' class='form_textbox' id='Text20' value='' /><div>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span></span></div>                                   
                                </span>
                                </td> <td><label class='form_label' form_label for='DL_Remark'>备注</label>
                                    <span class='div_texbox'>
                                    <input  name='DL_Remark' type='text' class='form_textbox' id='DL_Remark' value='' /><div>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span></span></div>                                   
                                </span>

                                </td></tr>
            </table>

    <input name="DL_ID" type="hidden" id="DL_ID" value="" />
    <input name="DL_DocumentName" type="hidden" id="DL_DocumentName" value="" />
    <input name="DL_FileCode" type="hidden" id="DL_FileCode" value="" />
    <input name="DL_LendingDate" type="hidden" id="DL_LendingDate" value="" />
    <input name="DL_Operator" type="hidden" id="DL_Operator" value="" />
    <input name="DL_LendingReason" type="hidden" id="DL_LendingReason" value="" />
    <input name="DL_ReturnNum" type="hidden" id="DL_ReturnNum" value="" />
    <input name="DL_ReturnDate" type="hidden" id="DL_ReturnDate" value="" />
    <input name="DL_ReturnOperator" type="hidden" id="DL_ReturnOperator" value="" />
    <input name="DL_ReturnRemark" type="hidden" id="DL_ReturnRemark" value="" />
    <input name="DL_Stat" type="hidden" id="DL_Stat" value="" />
    <input name="CreateDate" type="hidden" id="CreateDate" value="" />
    <input name="UpdateDate" type="hidden" id="UpdateDate" value="" />
    <input name="DeleteDate" type="hidden" id="DeleteDate" value="" />
    <input type="hidden" name="Document_Lendingseek_Formoper" id="Document_Lendingseek_Formoper"
        value="" />
    <input type="button" name="button" value="提交" onclick="SaveData()" />
    <input type="button" name="cancle" value="取消" onclick="CancelEdit()" />
    </form>
</div>
<div id='Document_Lendingseekremand_Oper' style='display: none'>
    <form action='' id='Document_Lendingseekremand_Form' method='post' name='Document_Lendingseekremand_Form'>
    <table>
        <tr>
            <td>
                <label class='form_label' form_label for='DL_Code'>
                    图书借阅编码</label>
                <span class='div_texbox'>
                    <input readonly='TRUE' name='DL_Code' type='text' class='form_textbox  TextBoxReadOnly'
                        id='Text1' value='' /><div>
                            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span></span></div>
                </span>
            </td>
            <td>
                <label class='form_label' form_label for='DL_DocumentCode'>
                    图书编码</label>
                <span class='div_texbox'>
                    <input name='DL_DocumentCode' type='text' class='form_textbox' id='Text2' value='' /><div>
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span></span></div>
                </span>
            </td>
        </tr>
        <tr>
            <td>
                <label class='form_label' form_label for='DL_DocumentName'>
                    图书名称</label>
                <span class='div_texbox'>
                    <input name='DL_DocumentName' type='text' class='form_textbox' id='Text3' value='' /><div>
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span></span></div>
                </span>
            </td>
            <td>
                <label class='form_label' form_label for='DL_FileCode'>
                    图书文号</label>
                <span class='div_texbox'>
                    <input name='DL_FileCode' type='text' class='form_textbox' id='Text4' value='' /><div>
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span></span></div>
                </span>
            </td>
        </tr>
        <tr>
            <td>
                <label class='form_label' form_label for='DL_LendingNum'>
                    借阅份数666</label>
                <span class='div_texbox'>
                    <input name='DL_LendingNum' type='text' class='form_textbox' id='Text5' value="" /><div>
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span></span></div>
                </span>
            </td>
            <td>
                <label class='form_label' form_label for='DL_LendorCompany'>
                    借阅人公司</label>
                <span class='div_texbox'>
                    <input name='DL_LendorCompany' type='text' class='form_textbox' id='Text6' value='' /><div>
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span></span></div>
                </span>
            </td>
        </tr>
        <tr>
            <td>
                <label class='form_label' form_label for='DL_LendorDept'>
                    借阅人部门</label>
                <span class='div_texbox'>
                    <input name='DL_LendorDept' type='text' class='form_textbox  popup' id='Text7' value='' /><div>
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span></span></div>
                </span>
            </td>
            <td>
                <label class='form_label' form_label for='DL_Person'>
                    借阅人</label>
                <span class='div_texbox'>
                    <input name='DL_Person' type='text' class='form_textbox' id='Text8' value='' /><div>
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span></span></div>
                </span>
            </td>
        </tr>
        <tr>
            <td>
                <label class='form_label' form_label for='DL_LendingDate'>
                    借阅时间</label>
                <span class='div_texbox'>
                    <input readonly='true' name='DL_LendingDate' type='text' class='form_textbox  TextBoxReadOnly date_icon'
                        id='Text9' value='' /><div>
                            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span></span></div>
                </span>
            </td>
            <td>
                <label class='form_label' form_label for='DL_Operator'>
                    借阅经手人</label>
                <span class='div_texbox'>
                    <input name='DL_Operator' type='text' class='form_textbox' id='Text10' value='' /><div>
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span></span></div>
                </span>
            </td>
        </tr>
        <tr>
            <td>
                <label class='form_label' form_label for='DL_LendingReason'>
                    借阅事由</label>
                <span class='div_texbox'>
                    <input name='DL_LendingReason' type='text' class='form_textbox' id='Text11' value='' /><div>
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span></span></div>
                </span>
            </td>
            <td>
                <label class='form_label' form_label for='DL_Authorizor'>
                    借阅批准人</label>
                <span class='div_texbox'>
                    <input name='DL_Authorizor' type='text' class='form_textbox' id='Text12' value='' /><div>
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span></span></div>
                </span>
            </td>
        </tr>
        <tr>
            <td>
                <label class='form_label' form_label for='DL_ReturnNum'>
                    归还份数</label>
                <span class='div_texbox'>
                    <input name='DL_ReturnNum' type='text' class='form_textbox' id='Text13' value='' /><div>
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span></span></div>
                </span>
            </td>
            <td>
                <label class='form_label' form_label for='DL_ReturnDate'>
                    归还时间</label>
                <span class='div_texbox'>
                    <input readonly='true' name='DL_ReturnDate' type='text' class='form_textbox  TextBoxReadOnly date_icon'
                        id='Text14' value='' /><div>
                            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span></span></div>
                </span>
            </td>
        </tr>
        <tr>
            <td>
                <label class='form_label' form_label for='DL_ReturnOperator'>
                    归还经手人</label>
                <span class='div_texbox'>
                    <input name='DL_ReturnOperator' type='text' class='form_textbox' id='Text15' value='' /><div>
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span></span></div>
                </span>
            </td>
            <td>
                <label class='form_label' form_label for='DL_Remark'>
                    备注</label>
                <span class='div_texbox'>
                    <input name='DL_Remark' type='text' class='form_textbox' id='Text16' value='' /><div>
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span></span></div>
                </span>
            </td>
        </tr>
    </table>
    <input name='DL_ID' type='hidden' id='Hidden1' value='' />
    <input name='DL_ReturnRemark' type='hidden' id='Hidden2' value='' />
    <input name='DL_Stat' type='hidden' id='Hidden3' value='' />
    <input name='CreateDate' type='hidden' id='Hidden4' value='' />
    <input name='UpdateDate' type='hidden' id='Hidden5' value='' />
    <input name='DeleteDate' type='hidden' id='Hidden6' value='' />
    <input type='hidden' name='Document_Lendingseekremand_Formoper' id='Document_Lendingseekremand_Formoper'
        value=''>
    <input type='button' name='button' value='提交' onclick='Document_Lendingseekremand_Document_LendingseekremandModule_GridControl.SaveData()' />
    <input type='button' name='cancle' value='取消' onclick='Document_Lendingseekremand_Document_LendingseekremandModule_GridControl.CancelEdit()' />
    </form>
</div>

<script type="text/javascript">
    $(document).ready(function() {
        $("#finaceOperation").dialog({ autoOpen: false, width: 800, minWidth: 810 });
        var options = {
            success: function(data) { AfterSaveEdit(data); },  // post-submit callback
            width: 800,
            timeout: 3000
        };
        $("#stuff").ajaxForm(options);
        $("#Document_Manageseek_Document_ManageseekModule_btn1a").click(function() {
            var grid = $("#Document_Manageseekgrid");
            var curid = grid.getGridParam("selrow"); //获取选择行的id
            var data = grid.getRowData(curid); //获取行号为curid的数据            
            if (data.DM_Code == undefined) {
                ShowMsg("请选中编辑行");
                return;
            }
            else {
                $("#stuff")[0].reset();
                $("#finaceOperation").dialog("open");
                $.ajax(
                        {
                            type: 'post',
                            url: '/Sys_Config_ListPage/GetTableKeyCode',
                            data: { oper: 'add', n: 'Document_Manageseek' },
                            success: function(result) {
                                $('#stuff').find('#DL_Code').val(result);
                                $('#stuff').find('#DL_DocumentCode').val(data.DM_Code);
                                $('#stuff').find('#Text17').val(data.DM_Name);
                                $('#stuff').find('#DL_LendingNum').val("1");
                                Comm_Session.GetValue('Company', function(data) { $('#DL_LendorCompany').val(data); });
                                Common_Tree_Dept.Init("DL_LendorDept", function(code, name) { $("#DL_LendorDept").val(name); });

                            }
                        });
            }
        });
    });
</script>

<script type="text/javascript">
    $(document).ready(function() {
        $("#Document_Lendingseekremand_Oper").dialog({ autoOpen: false, width: 800, minWidth: 810 });
        var options = {
            success: function(data) { AfterSaveEdit(data); },  // post-submit callback
            width: 800,
            timeout: 3000
        };
        $("#Document_Lendingseekremand_Form").ajaxForm(options);
        $("#Document_Manageseek_Document_ManageseekModule_btn2a").click(function() {
            ShowMsg("aa");
        });
    });
</script>

<script type="text/javascript">
    function CancelEdit() {
        $("#finaceOperation").dialog("close");
    }
    function SaveData() {
        if (!$('#stuff').validate().form()) {
            return false;
        }
        else {
            $("#stuff").submit();
        }
    }
    function AfterSaveEdit(data) {
        if (data == "success") {
            $("#finaceOperation").dialog("close");
            $("#Document_Manageseekgrid").trigger("reloadGrid");
        }
        else {
            ShowMsg('提交失败!');
        }
    }
</script>

<script type="text/javascript">
    function CancelEdits() {
        $("#Document_Lendingseekremand_Oper").dialog("close");
    }
    function SaveDatas() {
        $("#Document_Lendingseekremand_Form").submit();
    }
</script>

<script type='text/javascript'>
    $(document).ready(function() {
    $('#DL_LendingDate').datepicker();
    $('DL_LendingDate').datepicker('option', 'dateFormat', 'yyyy-mm-dd');
    var validator = $('#stuff').validate({
//            debug: false,       //调试模式取消submit的默认提交功能
            errorClass: 'err_display', //默认为错误的样式类为：error
            focusInvalid: false,
            onkeyup: false,
            rules: {           //定义验证规则,其中属性名为表单的name属性
                DL_Code: { required: true },
                DL_DocumentCode: { required: true },
                DL_DocumentName: { required: true },
                DL_LendingNum: { required: true, digits: true },
                DL_LendorCompany: { required: true },
                DL_LendorDept: { required: true },
                DL_LendingDate: { required: true },
                DL_Operator: { required: true },
                DL_Authorizor: { required: true }
            },
            messages: {       //自定义验证消息
                DL_Code: { required: '档案借阅编码必需的' },
                DL_DocumentCode: { required: '档案编码必需的' },
                DL_DocumentName: { required: '档案文件名称必需的' },
                DL_LendingNum: { required: '信息必需填写', digits: '必须为数字' },
                DL_LendorCompany: { required: '借阅人公司必需的' },
                DL_LendorDept: { required: '借阅人部门必需的' },
                DL_Person: { required: '借阅人必需的' },
                DL_LendingDate: { required: '借阅时间必需的' },
                DL_Operator: { required: '借阅经手人必需的' },
                DL_Authorizor: { required: '借阅批准人必需的' },
                DL_LendingReason: { required: '借阅事由必需的' },
                DL_Remark: { required: '备注必需的' }

            },
            errorPlacement: function(error, element) {  //验证消息放置的地方
                //error.appendTo(element.next().addClass('err_display'));

                if (error.html() != '') {
                    //ShowMsg(error.html());
                    element.next().addClass('err_display');
                    element.next().find('span').html(error.html());
                } else {
                    element.next().find('span').html(error.html());
                    element.next().removeClass('err_display');
                }
            },
            highlight: function(element, errorClass) {  //针对验证的表单设置高亮
                //$(element).addClass(errorClass);
            },
            success: function(label) {
                //label.addClass('valid').text('Ok!');
            }
        });
    });
</script>

