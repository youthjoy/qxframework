// Modify BY YSW 
// Modify:MPPP单独配置 大宗物料计划
// Modify Date:2011-3-25

$(function() {
    var udef10 = $("#PUD_Udef10");
    $("#PUD_Udef9").change(function() {
        var $this = $(this);
        udef10.val($this.find("option:selected").text());
    });
});