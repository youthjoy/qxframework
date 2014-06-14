$(document).ready(function() {





//档案归还
$("#Document_Lendings_FormOK").hide();
$("#Document_Lendings_FormOK").after("<input type='button' onclick='BookBack()' value='确 定' name='button' id='1'>");

});

//表单默认参数
function Document_Lendings_FormLoadAfter() {
//    var myDate = new Date();
//    $('#Document_Lendings_Form').find('#DL_ReturnDate').val(myDate.toLocaleDateString());
    $('#Document_Lendings_Form').find('#DL_ReturnNum').val($('#DL_LendingNum').val());
    //获取服务器当前日期
    Comm_Session.GetCurrentDate(function(callback) {
    $('#Document_Lendings_Form').find('#DL_ReturnDate').val(callback);
    });
    //处理人默认为登陆者
    Comm_Session.GetValue("UserName", function(callback) {
    $('#Document_Lendings_Form').find('#DL_ReturnOperator').val(callback);
    });

}

 function BookBack() {
     var grid = $('#Document_Lendingsgrid');
     var curid = grid.getGridParam('selrow'); //获取选择行的id
     var data = grid.getRowData(curid); //获取行号为curid的数据
     if (data.DL_Code == undefined) {
         ShowMsg('请选中归还行');
         return;
     } else if (data.DL_LendingNum == data.DL_ReturnNum) {
     ShowMsg('已归还完！操作错误！');
         return;
     }
     else {//
         debugger;
         var borrowNum = parseInt($("#Document_Lendings_Form").find("#DL_LendingNum").val()); //借阅份数
         var backNum = parseInt($("#Document_Lendings_Form").find("#DL_ReturnNum").val());
         //剩余档案份数
         var residueBorrowNum = borrowNum - backNum;
         if (backNum == 0) { ShowMsg("你没有归还!"); }
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
                    url: '/ExtendRecord/ReturnDate',
                    data: $("#Document_Lendings_Form").serialize(),
                    success: function(dispose) {
                    if (dispose == "ok") {
                        $("#Document_Lendings_Form").dialog('close');
                        $("#Document_Lendingsgrid").trigger("reloadGrid");
                    } else if (dispose == "mistakeNum") {
                    ShowMsg("归还份数，操作错误！");
                    }
                    else {
                    ShowMsg("添加归还信息失败！");
                        }
                     }
                 });
                 
                 //修改借阅表里的借阅份数和状态
                 $("#Document_Lendings_Form").find("#DL_LendingNum").val(residueBorrowNum);
                 $("#Document_Lendings_Form").find("#DL_ReturnNum").val(0);
                 $("#Document_Lendings_Form").find("#DL_Stat").val("未归还完");
                 Document_Lendings_Document_LendingModules_GridControl.SaveData();
                
                 
             }
             else {
                 $("#Document_Lendings_Form").dialog('close');
             }
         }
         else {
             //修改借阅表里的借阅份数和状态
             $("#Document_Lendings_Form").find("#DL_Stat").val("已归还完");
             Document_Lendings_Document_LendingModules_GridControl.SaveData();
             //修改基本信息中的在册份数
            
         }
//档案状态
        

         $("#Document_Lendings_Form").find("#DL_LendingNum").val(residueBorrowNum);
        
      }

 }



// function GuiHuan() {
//     if (借阅 == 归还) {
//         Document_Lendings_Document_LendingModules_GridControl.SaveData();
//    }else {
//        ShowMsg("");
//    }
//        
// }