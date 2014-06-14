///通用备注组件
//使用方法：System_Bak.Init(_CodeObj,_ModuleCode) 参考编码对象，模块名称
//日期：2010-1-5

$(function() {
    $("#baktext").change(function() {
        System_Bak.SaveData();
    });
});

var System_Bak = {
    CodeObj: null,
    txtObj: $("#baktext"),
    ModuleCodeObj: $("#Bak_ModuleCode"),
    //IDObj: $("Bak_ID"),
    ModuleCode: null,

    Init: function(_CodeObj, _ModuleCode) {
        System_Bak.CodeObj = _CodeObj;
        System_Bak.ModuleCode = _ModuleCode;
        System_Bak.ModuleCodeObj.val(_ModuleCode);
        $.ajax({
            type: "post",
            url: "/Bak/Init",
            data: { Code: System_Bak.ModuleCode, Id: System_Bak.CodeObj.val() != "" ? System_Bak.CodeObj.val() : "" },
            dataType: "json",
            success: function(data) {
                if (data.result == "success") {
                    $("#baktext").val(data.content);
                }
            }
        });
    },
    SaveData: function() {
        $.ajax({
            url: '/Bak/Save',
            type: 'post',
            dataType: 'text',
            data: { Code: System_Bak.ModuleCode, RId: System_Bak.CodeObj.val(), Content: $("#baktext").val() },
            success: function(result) {
                if (result != "success") { ShowMsg("提交备注失败"); }
            }
        });

    }
};
