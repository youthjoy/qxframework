

/*
#   Function:全局只读设置
#   Date:2011-3-1
#   Author:QB
#   只读设置:PageReadOnly(toolbar,formName,btnOK):可选参数,设有默认值
#   编辑设置:PageEdit(toolbar,formName,btnOK):可选参数,设有默认值
#   Version:1.0
*/

var GLOBAL = {

    ///只读设置    
    PageReadOnly: function(toolbar, formName, btnOK) {
        var nToolBar = toolbar == undefined ? $(".toolbar") : $(toolbar);
        var nFormName = formName == undefined ? $(document) : $(formName);
        var nBtnOK = btnOK == undefined ? $(".hide") : $(btnOK);
        if (nToolBar != undefined) {
            nToolBar.hide();
        }
        if (nBtnOK != undefined) {
            nBtnOK.hide();
        }
        if (nFormName != undefined) {
            nFormName.find('input,select,textarea').each(function(key, element) {
                if ($(element).attr("type") != "button") {
                    $(element).attr("disabled", "disabled");
                }
            });
        }
    },
    
    ///编辑设置
    PageEdit: function(toolbar,formName,btnOK) {
        var nBtnOK = btnOK == undefined ? $(".hide") : $( btnOK);
        var nToolBar = toolbar == undefined ? $(".toolbar") : $(toolbar);
        var nFormName = formName == undefined ? $(document) : $(formName);
        if (nToolBar != undefined) {
            nToolBar.show();
        }
        if (nBtnOK != undefined) {
            nBtnOK.show();
        }
        if (nFormName != undefined) {
            nFormName.find('input,select,textarea').each(function(key, element) {
                if ($(element).attr("type") != "button") {
                    $(element).attr("disabled", false);
                }
            });
        }
    }

}