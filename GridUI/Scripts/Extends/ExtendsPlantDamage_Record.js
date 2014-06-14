$(document).ready(function() {

    $("#PlantDamage_Record_FormOK").remove();
    $("#PlantDamage_Record_FormCancle").before("<input type='button' class='hide' onclick='PlantDamage_Record()' value='确 定' name='button' id='1'>");

});


//添加植物损坏信息的方法 PlantDamage_Record_PlantDamage_RecordModule_GridControl.SaveData()
//植物损坏的确认
function PlantDamage_Record() {
    if (!$('#PlantDamage_Record_Form').validate().form()) {
        return false;
    } else {
        //得到 植物编码、数量
    var plantsCode = $("#PDR_PlantCode").val();
        var newPNum = $("#PDR_Count").val();
        //将新的传到后台（后台更新植物列表的实体）
        $.ajax({
            type: 'post',
            url: '/ExtendsPlantChanged/DamagePlant/',
            data: { plantsCode: plantsCode, newPNum: newPNum },
            success: function(fag) {

                if (fag == "ok") {
                    ShowMsg("植物损坏信息操作成功！");
                    PlantDamage_Record_PlantDamage_RecordModule_GridControl.SaveData();
                }
                else if (fag == "fainePNumMistake") {
                ShowMsg("损坏的数量大于存量，请重新填写!");
                }
                else {
                    ShowMsg("植物损坏信息操作失败！");
                }

            }
        })
    }
    //添加或修改更换信息

};