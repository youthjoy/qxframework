<%@ Control Language="C#" Inherits="System.Web.Mvc.ViewUserControl" %>

  <div id='Document_Movement_Oper' style='display:none'>
            <form class='FormClass' action='' id='Document_Movement_Form' method='post' name='Document_Movement_Form'>
            <table>

            <tr>
             <td><label class='form_label' form_label for='Mov_Code'>移交编码</label>
                                    <span class='div_texbox'>
                                    <input readonly='true' name='Mov_Code' type='text' class='form_textbox  TextBoxReadOnly' id='Mov_Code' value='' /><div>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span></span></div>                                   
                                </span>
                                </td> <td><label class='form_label' form_label for='Mov_FileCode'>文号</label>
                                    <span class='div_texbox'>
                                    <input  name='Mov_FileCode' type='text' class='form_textbox' id='Mov_FileCode' value='' /><div>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span></span></div>                                   
                                </span>

                                </td></tr><tr> <td><label class='form_label' form_label for='Mov_DocumentCode'>编码</label>
                                    <span class='div_texbox'>
                                    <input readonly='true' name='Mov_DocumentCode' type='text' class='form_textbox  TextBoxReadOnly' id='Mov_DocumentCode' value='' /><div>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span></span></div>                                   
                                </span>
                                </td> <td><label class='form_label' form_label for='Mov_FileName'>档案名称</label>
                                    <span class='div_texbox'>
                                    <input  name='Mov_FileName' type='text' class='form_textbox' id='Mov_FileName' value='' /><div>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span></span></div>                                   
                                </span>

                                </td></tr><tr> <td><label class='form_label' form_label for='Mov_Num'>份数</label>
                                    <span class='div_texbox'>
                                    <input  name='Mov_Num' type='text' class='form_textbox' id='Mov_Num' value='' /><div>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span></span></div>                                   
                                </span>
                                </td> <td><label class='form_label' form_label for='Mov_GMOperator'>总经办经手人</label>
                                    <span class='div_texbox'>
                                    <input  name='Mov_GMOperator' type='text' class='form_textbox  popup' id='Mov_GMOperator' value='' /><div>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span></span></div>                                   
                                </span>

                                </td></tr><tr> <td><label class='form_label' form_label for='Mov_GDOperator'>总务部经手人</label>
                                    <span class='div_texbox'>
                                    <input  name='Mov_GDOperator' type='text' class='form_textbox  popup' id='Mov_GDOperator' value='' /><div>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span></span></div>                                   
                                </span>
                                </td> <td><label class='form_label' form_label for='Mov_Operator'>操作人</label>
                                    <span class='div_texbox'>
                                    <input  name='Mov_Operator' type='text' class='form_textbox  popup' id='Mov_Operator' value='' /><div>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span></span></div>                                   
                                </span>

                                </td></tr><tr> <td><label class='form_label' form_label for='Mov_OperateDate'>操作时间</label>
                                    <span class='div_texbox'>
                                    <input readonly='true' name='Mov_OperateDate' type='text' class='form_textbox  TextBoxReadOnly date_icon' id='Mov_OperateDate' value='' /><div>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span></span></div>                                   
                                </span>
                                </td> <td><label class='form_label' form_label for='Mov_Superintendent'>监交人</label>
                                    <span class='div_texbox'>
                                    <input  name='Mov_Superintendent' type='text' class='form_textbox  popup' id='Mov_Superintendent' value='' /><div>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span></span></div>                                   
                                </span>

                                </td></tr><tr> <td><label class='form_label' form_label for='Mov_Date'>移交时间</label>
                                    <span class='div_texbox'>
                                    <input readonly='true' name='Mov_Date' type='text' class='form_textbox  TextBoxReadOnly date_icon' id='Mov_Date' value='' /><div>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span></span></div>                                   
                                </span>
                                </td></tr>
            </table>
            <input name='Mov_ID' type='hidden' id='Mov_ID' value='' />
<input name='CreateDate' type='hidden' id='CreateDate' value='' />
<input name='UpdateDate' type='hidden' id='UpdateDate' value='' />

<input name='DeleteDate' type='hidden' id='DeleteDate' value='' />

            <div class='FormToolBar'>
            <input type='hidden' name='Document_Movement_Formoper' id='Document_Movement_Formoper' value=''>
             <input id='btnSaveData' type='submit' name='button'  value='提交' />
            <input id='btnCancle' type='button' name='cancle' value='取消'/>           
       <%--     <input type='button' name='button'  value='应 用' onclick='Document_Movement_Document_MovementModule_GridControl.SaveDataApply()' />            --%>
            </div>
            </form>  
</div>



        <script type="text/javascript">
            $(document).ready(function() {
                $('#Document_Movement_Form').dialog({ autoOpen: false, width: 800, minWidth: 810 });
                $("#Document_Manage_Document_ManageModule_btn2a").unbind();
                $("#Document_Manage_Document_ManageModule_btn2a").click(function() {

                    ShowMsg(ok);

                })
            })



            </script>  






<script type="text/javascript">
   $(document).ready(function() {        
                    
                 
                    var validator = $('#Document_Movement_Form').validate({
                        debug: false,       //调试模式取消submit的默认提交功能
                        errorClass: 'err_display', //默认为错误的样式类为：error
                        focusInvalid: false,
                        onkeyup: false,
                        rules: {           //定义验证规则,其中属性名为表单的name属性
                            Mov_Code:{ required:true },
Mov_FileCode:{ required:true },
Mov_DocumentCode:{ required:true },
Mov_FileName:{ required:true },
Mov_Num:{ required:true,digits:true },
Mov_GMOperator:{ required:true },
Mov_GDOperator:{ required:true },
Mov_Operator:{ required:true },
Mov_OperateDate:{ required:true },
Mov_Superintendent:{ required:true },
Mov_Date:{ required:true }
                        },
                        messages: {       //自定义验证消息
                            Mov_Code:{ required:'档案移交编码必需的' },
Mov_FileCode:{ required:'档案文号必需的' },
Mov_DocumentCode:{ required:'档案编码必需的' },
Mov_FileName:{ required:'档案文件名称必需的' },
Mov_Num:{ required:'信息必需填写',digits:'必须为数字' },
Mov_GMOperator:{ required:'总经办经手人必需的' },
Mov_GDOperator:{ required:'总务部经手人必需的' },
Mov_Operator:{ required:'操作人必需的' },
Mov_OperateDate:{ required:'操作时间必需的' },
Mov_Superintendent:{ required:'监交人必需的' },
Mov_Date:{ required:'移交时间必需的' }
                        },
                        errorPlacement: function(error, element) {  //验证消息放置的地方
                            //error.appendTo(element.next().addClass('err_display'));
                            
                            if(error.html()!=''){
                                //ShowMsg(error.html());
                                element.next().addClass('err_display');                            
                                element.next().find('span').html(error.html());
                            }else{
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

            Common_EmpTree_Dept.Init('Mov_GMOperator', function(code, name) { $('#Mov_GMOperator').val(name); });
            Common_EmpTree_Dept.Init('Mov_GDOperator', function(code, name) { $('#Mov_GDOperator').val(name); });
            Common_EmpTree_Dept.Init('Mov_Operator', function(code, name) { $('#Mov_Operator').val(name); });
            $('#Mov_OperateDate').datepicker();
            $('Mov_OperateDate').datepicker('option', 'dateFormat', 'yyyy-mm-dd');
            Common_EmpTree_Dept.Init('Mov_Superintendent', function(code, name) { $('#Mov_Superintendent').val(name); });
            $('#Mov_Date').datepicker();
            $('Mov_Date').datepicker('option', 'dateFormat', 'yyyy-mm-dd');
            $('#Document_Movement_Oper').dialog({ autoOpen: false, width: 800, minWidth: 500 });

        });

</script>