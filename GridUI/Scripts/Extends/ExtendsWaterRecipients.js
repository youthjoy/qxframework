$(document).ready(function() {

    //根据水票单价和数量自动计算金额

    $("#WR_Count,#WR_Price").bind("change", function() {
        var PRICE = $("#WR_Price").val();
        var COUNT = $("#WR_Count").val();
        if (PRICE != "" && COUNT != "") {
            var product = parseFloat(PRICE) * parseInt(COUNT);
                
            //检查输入的字符串合法性
            if (isNaN(product)) {
                $("#WR_Cost").val(0);
            } else {
                //保留两位小数
                $("#WR_Cost").val(product.toFixed(2));
            }
        } else {
            $("#WR_Cost").val(0);
        }

    });

});