var Rpt_ComFun = {
    ResetForm: function(id) {
        $("#" + id).reset();
    },
    DefaultForm: "FormOP",
    ResetDefaultForm: function(id) {
        var $Form = $("#" + Rpt_ComFun.DefaultForm);
        $Form.each(function() { this.reset(); });
        $Form.find(":hidden").each(function() {
            $(this).val("");
        });
    },
    Excel: function() {
        $("#" + Rpt_ComFun.DefaultForm)[0].action = "/Sys_Config_ListPage/Export/" + Module;
        $("#" + Rpt_ComFun.DefaultForm).submit();
    }
}