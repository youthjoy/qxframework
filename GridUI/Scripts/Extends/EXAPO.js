
// Modify BY QB 
// Modify:APO单独配置，参考不可选   大宗物料
// Modify Date:2011-3-22

$(function() {

    //如果是直接生成订单 则供应类型不允许修改
    if (MRTOPO != "") {
        $("#PUD_Udef9").attr("disabled", true);
    }
    // Modify BY QB 
    // Modify:绑定供应商
    // Modify Date:2011-3-22
    $("#PUD_Udef6").bind("click", function() {
        WH_SupplierModuleWH_SupplierOpenReferWithFilter("", function(data) {
            $("#PUD_Udef6").val(data.WHS_CustCode);
            $("#PUD_Udef7").val(data.WHS_CustName);
        })
    })

    // Modify BY QB
    // Modify:运输类型 根据甲供选择车辆
    // Modify Date:2011-3-22
    // 用于大宗订单（MPPO），大宗甲供订单 （MPPOForPartyA）



    //运输车辆
    $("#PUD_Udef8").unbind("click");
    $("#PUD_Udef8").attr("class", "form_textbox  TextBoxReadOnly");

    $("#PUD_Udef4").change(function() {
        
        if ($(this).val() == "brewtype1") {
            //驾驶员
            $("#PUD_Udef2").attr("class", "form_textbox  TextBoxReadOnly  popup");
            Common_EmpTree_Dept.Init('PUD_Udef2', function(code, name) { $('#PUD_Udef2').val(name); });

            $("#PUD_Udef8").attr("class", "form_textbox  TextBoxReadOnly  popup");
            $("#PUD_Udef8").bind("click", function() {

                //选择所有车辆
                PCT_InfoModulePCT_InfoOpenReferWithFilter(" PCTI_Status<>'15' ", function(data) {
                    $("#PUD_Udef8").val(data.PCTI_NO);
                    $("#PUD_Udef2").val(data.PCTI_DName);
                });

            });

        }
        else {
            $("#PUD_Udef2").attr("class", "form_textbox  TextBoxReadOnly");
            $("#PUD_Udef2").unbind("click");
            $("#PUD_Udef8").unbind("click");
            
            $("#PUD_Udef8").attr("class", "form_textbox  TextBoxReadOnly");
            $("#PUD_Udef8").val("");
            $("#PUD_Udef2").val("");

        }

    });

})
