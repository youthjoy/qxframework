$(document).ready(function() {
    $("#Document_LendingRF_FormOK").hide();
    $("#Document_LendingRF_FormOK").after("<input type='button' onclick='BookBack()' value='确 定' name='button' id='1'>");

});




function Document_LendingRF_FormLoadAfter() {
//    var myDate = new Date();
    //    $('#Document_LendingRF_Form').find('#DL_ReturnDate').val(myDate.toLocaleDateString());
    
    //归还默认为借阅
    $('#Document_LendingRF_Form').find('#DL_ReturnNum').val($('#DL_LendingNum').val());
    //获取服务器当前日期
    Comm_Session.GetCurrentDate(function(callback) {
        $('#Document_LendingRF_Form').find('#DL_ReturnDate').val(callback);
    });
    //处理人默认为登陆者
    Comm_Session.GetValue("UserName", function(callback) {
    $('#Document_LendingRF_Form').find('#DL_ReturnOperator').val(callback);
    });
  
}

function BookBack() {

    var grid = $('#Document_LendingRFgrid');
    var curid = grid.getGridParam('selrow'); //获取选择行的id

//    if (data.DL_Code == undefined) {
//        ShowMsg('请选中归还行');
//        return;
//    }

    if (data.DL_LendingNum == data.DL_ReturnNum) {
        ShowMsg('已归还完！操作错误！');
        return;
    }
    else {//
        debugger;
        var borrowNum = parseInt($("#Document_LendingRF_Form").find("#DL_LendingNum").val()); //借阅份数
        var backNum = parseInt($("#Document_LendingRF_Form").find("#DL_ReturnNum").val()); //归还份数

       debugger;
       //ShowMsg(borrowNum < backNum?"归还份数错误":"归还份数正确");
        if (backNum == 0) {
            ShowMsg("你没有归还!");
        }
        else if (borrowNum < backNum) {
            //归还大于借阅
            ShowMsg("你只借了" + borrowNum + "份，归还份数错误！");
            return;
        }
        else if (borrowNum > backNum) {
            var r = confirm("确认不一次性还完!");
            if (r == true) {

                $.ajax({
                    type: 'post',
                    url: '/ExtendRecord/ReturnDate',
                    data: $("#Document_LendingRF_Form").serialize(),
                    success: function(dispose) {
                        if (dispose == "ok") {
                            $("#Document_LendingRF_Form").dialog('close');
                            $("#Document_LendingRFgrid").trigger("reloadGrid");
                        } 
                        else if (dispose == "mistakeNum") {
                            ShowMsg("归还份数，操作错误！");
                        }
                        else {
                            ShowMsg("添加归还信息失败！");
                        }
                    }
                });


                //剩余份数
                var residueBorrowNum = borrowNum - backNum;
                //修改借阅表里的借阅份数和状态
                $("#Document_LendingRF_Form").find("#DL_LendingNum").val(residueBorrowNum);
                $("#Document_LendingRF_Form").find("#DL_ReturnNum").val(0);
                $("#Document_LendingRF_Form").find("#DL_Stat").val("未归还完");
                Document_LendingRF_Document_LendingModuleReturnF_GridControl.SaveData();
            }
            
            
            else {
                $("#Document_LendingRF_Form").dialog('close');
            }
        }
        else {
            //修改借阅表里的借阅份数和状态
            $("#Document_LendingRF_Form").find("#DL_Stat").val("已归还完");
            Document_LendingRF_Document_LendingModuleReturnF_GridControl.SaveData();
            //修改基本信息中的在册份数

        }
        //档案状态


        $("#Document_LendingRF_Form").find("#DL_LendingNum").val(residueBorrowNum);

    }

}

