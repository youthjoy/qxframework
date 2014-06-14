
///////////////////////////////////
////LastAudit界面相关函数  销售合同： 添加、查看、失效
function LastAudit_Add(itype) {
    location = "/Sales/QAddPreContract/" + itype;
}
function LastAudit_View() {
    var grid = $('#LastAuditgrid');
    var curid = grid.getGridParam('selrow'); //获取选择行的id
    var data = grid.getRowData(curid); //获取行号为curid的数据
    if (data.SDC_Code == undefined) {
        ShowMsg('请选中需要查看的数据行');
        return;
    }
    location = "/Sales/QEditPreContract/PreCust/?code=" + data.SDC_Code + "&view=view&tab=1";
}

function LastAudit_Edit() {
    var grid = $('#LastAuditgrid');
    var curid = grid.getGridParam('selrow'); //获取选择行的id
    var data = grid.getRowData(curid); //获取行号为curid的数据
    if (data.SDC_Code == undefined) {
        ShowMsg('请选中需要编辑的数据行');
        return;
    }
    location = "/Sales/QEditPreContract/PreCust/?code=" + data.SDC_Code;
}


//预审合同失效
function LastAudit_Delete() {
    var grid = $('#LastAuditgrid');
    var curid = grid.getGridParam('selrow'); //获取选择行的id
    var data = grid.getRowData(curid); //获取行号为curid的数据
    if (data.SDC_Code == undefined) {
        ShowMsg('请选中需要失效的数据行');
        return;
    }
    ShowMsg('你确定要失效该合同吗?', function(yes) {
        if (yes) {
            $.ajax({
                type: 'post',
                url: '/Sales/InvalidContract',
                data: { code: data.SDC_Code },
                success: function(data) {
                    if (data.result == "success") {
                        grid.trigger('reloadGrid');
                        ShowMsg("操作成功!");
                    }
                    else {
                        ShowMsg(data.msg);
                    }
                }
            });
        }
    })
}

///////////////////////////////////
////OnAudit界面相关函数 审核中合同：添加、查看、失效、审核
function OnAudit_Add(itype) {
    location = "/Sales/QAddPreContract/" + itype;
}
function OnAudit_View() {
    var grid = $('#OnAuditgrid');
    var curid = grid.getGridParam('selrow'); //获取选择行的id
    var data = grid.getRowData(curid); //获取行号为curid的数据
    if (data.SDC_Code == undefined) {
        ShowMsg('请选中需要查看的数据行');
        return;
    }
    location = "/Sales/QEditPreContract/PreCust/?code=" + data.SDC_Code + "&view=view&tab=2";
}
function OnAudit_Delete() {
    var grid = $('#OnAuditgrid');
    var curid = grid.getGridParam('selrow'); //获取选择行的id
    var data = grid.getRowData(curid); //获取行号为curid的数据
    if (data.SDC_Code == undefined) {
        ShowMsg('请选中需要删除的数据行');
        return;
    }
    ShowMsg('你确定要删除选中的数据吗?', function(yes) {
        if (yes) {
            $.ajax({
                type: 'post',
                url: '/Sales/DeleteContract',
                data: { code: data.SDC_Code },
                success: function(data) {
                    if (data == "success") {
                        grid.trigger('reloadGrid');
                    }
                    else {
                        ShowMsg("删除失败!");
                    }
                }
            });
        }
    })
}
//审核
function OnAudit_Audit() {
    var grid = $('#OnAuditgrid');
    var curid = grid.getGridParam('selrow'); //获取选择行的id
    var data = grid.getRowData(curid); //获取行号为curid的数据
    if (data.SDC_Code == undefined) {
        ShowMsg('请选中需要审核的数据行');
        return;
    }

    //审核前检查，是否已经存在合同
    $.post("/Sales/CheckContractIsExist/" + data.SDC_Code, null, function(result) {
        if (result == "false") {
            $('#AuditLayer').dialog('open');
            AuditInstance.Init("ContractAudit", data.AuditCurAudit, data.SDC_Code, function(AuditResult) {
                //预审通过后，直接进入合同草稿中
                if (AuditResult == "LastAudit") {
                    $.post("/Sales/PreContractToContract/" + data.SDC_Code, null, function(jResult) {
                        if (jResult != undefined && jResult.result == "success") {
                            grid.trigger('reloadGrid');
                            $("#LastAuditgrid").trigger('reloadGrid');
                            
                        } else {
                            ShowMsg(jResult.msg);
                        }
                    })
                }

            });
        } else {
            ShowMsg("正式合同已经存在");
        }
       
    })
    $("#Allgrid").trigger('reloadGrid');
}


///////////////////////////////////
////All界面相关函数 审核中合同：查看、搜索
function All_View() {
    var grid = $('#Allgrid');
    var curid = grid.getGridParam('selrow'); //获取选择行的id
    var data = grid.getRowData(curid); //获取行号为curid的数据
    if (data.SDC_Code == undefined) {
        ShowMsg('请选中需要查看的数据行');
        return;
    }
    location = "/Sales/QEditPreContract/PreCust/?code=" + data.SDC_Code + "&view=view&tab=3";
}

////Draft界面相关函数 草稿：添加、编辑、删除
function Draft_Add(itype) {
    location = "/Sales/QAddPreContract/" + itype;
}
function Draft_View() {
    var grid = $('#Draftgrid');
    var curid = grid.getGridParam('selrow'); //获取选择行的id
    var data = grid.getRowData(curid); //获取行号为curid的数据
    if (data.SDC_Code == undefined) {
        ShowMsg('请选中需要查看的数据行');
        return;
    }
    location = "/Sales/QEditPreContract/PreCust/?code=" + data.SDC_Code + "&view=view&tab=4";
}

function Draft_Edit() {
    var grid = $('#Draftgrid');
    var curid = grid.getGridParam('selrow'); //获取选择行的id
    var data = grid.getRowData(curid); //获取行号为curid的数据
    if (data.SDC_Code == undefined) {
        ShowMsg('请选中需要编辑的数据行');
        return;
    }
    location = "/Sales/QEditPreContract/PreCust/?code=" + data.SDC_Code;
}

function Draft_Delete() {
    var grid = $('#Draftgrid');
    var curid = grid.getGridParam('selrow'); //获取选择行的id
    var data = grid.getRowData(curid); //获取行号为curid的数据
    if (data.SDC_Code == undefined) {
        ShowMsg('请选中需要删除的数据行');
        return;
    }
    ShowMsg('你确定要删除选中的数据吗?', function(yes) {
        if (yes) {
            $.ajax({
                type: 'post',
                url: '/Sales/DeleteContract',
                data: { code: data.SDC_Code },
                success: function(data) {
                    if (data == "success") {
                        grid.trigger('reloadGrid');
                    }
                    else {
                        ShowMsg("删除失败!");
                    }
                }
            });
        }
    })
}