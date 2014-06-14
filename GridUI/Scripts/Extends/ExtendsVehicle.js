$(document).ready(function() {
    $("#PUD_Udef1").bind("click", function() {
        PCT_InfoModulePCT_InfoOpenReferWithFilter(" PCTI_iType='logistics'  and PCTI_Status<>'15' ", function(data) {
            $("#PUD_Udef1").val(data.PCTI_Code);
            $("#PUD_Udef2").val(data.PCTI_DName);
        });
    });

});