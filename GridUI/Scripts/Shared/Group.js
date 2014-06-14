var Comm_GroupSel = {
    Init: function(obj, callback) {
        var div = $("#" + obj);
        var select = obj + "_select";
        var confirm = obj + "_ConfirmBtn";
        var cancel = obj + "_CancelBtn";
        div.append("<select id='" + select + "'></select>");
        //多选初始化
        var el = $("#" + select);
        el.multiselect({
            checkAllText: "全选",
            uncheckAllText: "取消",
            noneSelectedText: '请选择',
            minWidth: 400,
            selectedList: 100 // 0-based index
        });
        div.append("<input type='button' id='" + confirm + "' value='确认' />");
        div.append("<input type='button' id='" + cancel + "' value='取消' />");

        $("#" + confirm).click(function() {
            callback(1, 2);
        });

        //数据源绑定
        $.ajax({
            type: 'post',
            url: '/Permission/GetGroupList/',
            //data: { id: data.Dat_Code, oper: 'del' },
            success: function(result) {

            }
        });
    }
}