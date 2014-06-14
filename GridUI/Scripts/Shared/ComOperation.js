var ComOperation = {
    SaveData: function(module, namespac,callback) {
        var formid = namespac + "_Form";
        var layer = namespac + "_Oper";
        if (!$('#' + formid).validate().form()) {
            return false;
        }
        var FormData = $('#' + formid).serialize();
        FormData = decodeURIComponent(FormData, true);
        var _oper = $('#' + formid + 'oper').val();
        $.ajax({
            type: 'post',
            url: '/Sys_Config_ListPage/GridEdit/?ModuleCode=' + module + '&NameSpace=' + namespac,
            data: { 'form': FormData, 'oper': _oper },
            success: function(data) {
                if (data == "success") {
                    alert("数据更新完成!");
                    callback();
                    ComOperation.Cancel(namespac);
                }
                else {
                    alert("数据更新失败");
                }
            }
        });
    },
    SaveFormData: function(module, namespac, callback) {
        var formid = namespac + "_Form";
        var layer = namespac + "_Oper";
        if (!$('#' + formid).validate().form()) {
            return false;
        }
        var options = {
            beforeSubmit: function() { },  // pre-submit callback
            success: function(data) {
                if (data.result == "success") {
                    alert("数据更新完成!");
                    //ComOperation.Cancel(namespac);
                    callback();
                    ComOperation.Cancel(namespac);
                }
                else {
                    alert(data.Msg);
                }
            }  // post-submit callback 
        };

        $("#" + formid).ajaxSubmit(options);
    },
    AfterSave: function() { },
    Cancel: function(namespac) {
        var formid = namespac + "_Form";
        var layer = namespac + "_Oper";
        $('#' + formid)[0].reset();
        $("#" + layer).dialog('close');
    }
};