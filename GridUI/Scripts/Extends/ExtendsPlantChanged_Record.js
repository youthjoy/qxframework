$(document).ready(function() {
    //金额=单价*数量
$("#PCR_Count,#PCR_Price,#PCR_NewName").focusout(function() {
var product = parseInt($("#PCR_Count").val()) * parseInt($("#PCR_Price").val());
        if (product =="NaN") {
            $("#PCR_Cost").val("金额");
        } else {
        $("#PCR_Cost").val(product);
        }
    });
});

PlantChanged_Record_PlantChanged_RecordModule_GridControl.SaveData = function() {
    Changed_Record();
}
//添加植物更换信息的方法 PlantChanged_Record_PlantChanged_RecordModule_GridControl.SaveData()
//PlantChanged_Record_PlantChanged_RecordModule_GridControl.SaveData()
//植物更换的确认
function Changed_Record() {
    if (!$('#PlantChanged_Record_Form').validate().form()) {
        return false;
    }
    //得到 植物编码、新名、数量、单价、金额
    var plantsCode = $("#tempCode").val();
    var newPName = $("#PCR_NewName").val();
    var newPNum = $("#PCR_Count").val();
    var newPPrice = $("#PCR_Price").val();
    var newPCost = $("#PCR_Cost").val();
    //将新的传到后台（后台更新植物列表的实体）
    $.ajax({
        type: 'post',
        url: '/ExtendsPlantChanged/ChangPlant/',
        data: { plantsCode: plantsCode, newPName: newPName, newPNum: newPNum, newPPrice: newPPrice, newPCost: newPCost },
        success: function(fag) {
        if (fag == "ok") {
            //$('#PlantChanged_Record_Form').submit();
            //表单提交前验证
            //debugger;
            var FormData = $('#PlantChanged_Record_Form').serialize();
            FormData = decodeURIComponent(FormData, true);
            var _oper = $('#PlantChanged_Record_Formoper').val();
            $.ajax({
                type: 'post',
                url: '/Sys_Config_ListPage/GridEdit/?ModuleCode=PlantChanged_RecordModule&NameSpace=PlantChanged_Record',
                data: { 'form': FormData, 'oper': _oper },
                success: PlantChanged_Record_PlantChanged_RecordModule_GridControl.AfterSave
            });
            ShowMsg("更换植物成功！");
            }
            else {
                ShowMsg("植物更换失败！");
            }

        }
    })
   //添加或修改更换信息

};