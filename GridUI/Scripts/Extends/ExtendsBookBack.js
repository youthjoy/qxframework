






$(document).ready(function() {

   
    //归还本数默认为借阅本数
//    var grid = $('#Document_Lendingseekremandgrid');
//    var curid = grid.getGridParam('selrow'); //获取选择行的id
//    var dataReturn = grid.getRowData(curid); //获取行号为curid的数据
//    $("#Document_Lendingseekremand_Form").find("#DL_ReturnNum").val(dataReturn.DL_ReturnNum);
//    ShowMsg($("#Document_Lendingseekremand_Form").find("#DL_ReturnNum").val(dataReturn.DL_LendingNum));
//    ShowMsg(dataReturn.DL_LendingNum);

    //提交借阅信息
    
    $('#DL_ReturnNum').val($('#DL_LendingNum').val());

});
Document_Lendingseekremand_Document_LendingseekremandModule_GridControl.SaveData = function() {
    BookBack();
}
//$('#DL_ReturnNum').val($('#DL_LendingNum').val()); 
//$('#Document_Lendingseekremand_Form').find('#DL_ReturnNum').val('xxx');

function Document_Lendingseekremand_FormLoadAfter() {
//    var myDate = new Date();
//    $('#Document_Lendingseekremand_Form').find('#DL_ReturnDate').val(myDate.toLocaleDateString());
    $('#Document_Lendingseekremand_Form').find('#DL_ReturnNum').val($('#DL_LendingNum').val());

    //    $('#Document_Lendingseekremand_Form').find('#DL_ReturnOperator').val();
    //获取服务器当前日期
    Comm_Session.GetCurrentDate(function(callback) {
    $('#Document_Lendingseekremand_Form').find('#DL_ReturnDate').val(callback);
    });
    //处理人默认为登陆者
    Comm_Session.GetValue("UserName", function(callback) {
    $('#Document_Lendingseekremand_Form').find('#DL_ReturnOperator').val(callback);
    });
    
}

function BookBack() {
    if (!$('#Document_Lendingseekremand_Form').validate().form()) {
        return false;
    }
    var grid = $('#Document_Lendingseekremandgrid');
    var curid = grid.getGridParam('selrow'); //获取选择行的id
    var data = grid.getRowData(curid); //获取行号为curid的数据
    if (data.DL_Code == undefined) {
        ShowMsg('请选中归还行');
        return;
    }
    else if (parseInt(data.DL_LendingNum) == parseInt(data.DL_ReturnNum)) {
        ShowMsg('已归还完！操作错误');
        return;
    }
    else {//
        var borrowNum = parseInt($("#Document_Lendingseekremand_Form").find("#DL_LendingNum").val()); //借阅份数
        var backNum = parseInt($("#Document_Lendingseekremand_Form").find("#DL_ReturnNum").val());
        //剩余份数
        var residueBorrowNum = borrowNum - backNum;
        if (backNum == 0) {
            ShowMsg("你没有归还!");
        }
        else if (borrowNum < backNum) {

            ShowMsg("你只借了" + borrowNum + "份，归还份数错误！");
            return;
        }
        else if (borrowNum > backNum) {
            //确认不
            var r = confirm("确认不一次性还完!");
            if (r == true) {

                $.ajax({
                type: 'post',
                dataType:'text',
                    url: '/ExtendRecord/ReturnDate',
                    data: $("#Document_Lendingseekremand_Form").serialize()
//                    success: function(dispose) {
//                        if (dispose == "ok") {
//                            $("#Document_Lendingseekremand_Form").dialog('close');
//                            $("#Document_Lendingseekremandgrid").trigger("reloadGrid");
//                        }

//                        else if (dispose == "mistakeNum") {
//                            ShowMsg("归还份数，操作错误！");
//                        }
//                        else {
//                            ShowMsg("添加归还信息失败！");
//                        }
//                    }
                });
                //修改借阅表里的借阅份数和状态
                $("#Document_Lendingseekremand_Form").find("#DL_LendingNum").val(residueBorrowNum);
                $("#Document_Lendingseekremand_Form").find("#DL_ReturnNum").val(0);
                $("#Document_Lendingseekremand_Form").find("#DL_Stat").val("未归还完");
                var FormData = $('#Document_Lendingseekremand_Form').serialize();
                FormData = decodeURIComponent(FormData, true);
                var _oper = $('#Document_Lendingseekremand_Formoper').val();
                $.ajax({
                    type: 'post',
                    url: '/Sys_Config_ListPage/GridEdit/?ModuleCode=Document_LendingseekremandModule&NameSpace=Document_Lendingseekremand',
                    data: { 'form': FormData, 'oper': _oper },
                    success: Document_Lendingseekremand_Document_LendingseekremandModule_GridControl.AfterSave
                });


            }
            else {
                $("#Document_Lendingseekremand_Form").dialog('close');
            }
        }
        else {
            //修改借阅表里的借阅份数和状态
            $("#Document_Lendingseekremand_Form").find("#DL_Stat").val("已归还完");
            var FormData = $('#Document_Lendingseekremand_Form').serialize();
            FormData = decodeURIComponent(FormData, true);
            var _oper = $('#Document_Lendingseekremand_Formoper').val();
            $.ajax({
                type: 'post',
                url: '/Sys_Config_ListPage/GridEdit/?ModuleCode=Document_LendingseekremandModule&NameSpace=Document_Lendingseekremand',
                data: { 'form': FormData, 'oper': _oper },
                success: Document_Lendingseekremand_Document_LendingseekremandModule_GridControl.AfterSave
            });
            //修改基本信息中的在册份数

        }
        //档案状态


        $("#Document_Lendingseekremand_Form").find("#DL_LendingNum").val(residueBorrowNum);

    }

}

