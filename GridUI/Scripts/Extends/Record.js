$(document).ready(function() {
$('#Document_Lending_Form').dialog({ autoOpen: false, width: 800, minWidth: 810 });
    $("#Document_Manage_Document_ManageModule_btn1a").unbind();
    $("#Document_Manage_Document_ManageModule_btn1a").click(function() {

        var grid = $('#Document_Managegrid');
        var curid = grid.getGridParam('selrow'); //获取选择行的id
        var data = grid.getRowData(curid); //获取行号为curid的数据            
        if (data.DM_Code == undefined) {
            ShowMsg('请选中借阅行');
            return;
        } else {
            $.ajax(
                        {
                            type: 'post',
                            url: '/Sys_Config_ListPage/GetTableKeyCode',
                            data: { oper: 'add', n: 'Document_Lending' },
                            success: function(result) {
                                $('#Document_Lending_Form').find('#DL_DocumentName').val(data.DM_Name);
                                $('#Document_Lending_Form').find('#DL_DocumentCode').val(data.DM_Code);
                                $('#Document_Lending_Form').find('#DL_Code').val(result);
                                $('#Document_Lending_Form').dialog('open');
                            }
                        });
        }
    }),

    //提交
$("#btnSaveData").click(function() {
    $('#Document_Lending_Form').submit();

}
),


    //取消
$("#btnCancle").click(function() {

    $('#Document_Lending_Form').dialog('close');
})
})



