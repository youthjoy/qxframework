$(document).ready(function() {
    //金额=单价*数量
$("#PR_Price,#PR_Count,#PR_Amount").focusout(function() {
        var product = parseInt($("#PR_Price").val()) * parseInt($("#PR_Count").val());
        if (product == "NaN") {
            $("#PR_Amount").val("金额");
        } else {
            $("#PR_Amount").val(product);
        }
    });

});