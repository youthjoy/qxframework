$(document).ready(function() {
    //ShowMsg("ooo")
    //window.setInterval("NowTime()",3000);
    NowTime();
});
function NowTime() {
    Comm_Session.GetCurrentDate(function(callback) {
        //ShowMsg(callback);
        var NowTime = callback.toString().split("-");
        //日期
        $("#timeY")[0].innerHTML = NowTime[0];
        $("#timeM")[0].innerHTML = NowTime[1];
        $("#timeT")[0].innerHTML = NowTime[2];
        //星期
        getDay();
        function getDay() {
            var week;
            if (new Date().getDay() == 0) week = "日"
            if (new Date().getDay() == 1) week = "一"
            if (new Date().getDay() == 2) week = "二"
            if (new Date().getDay() == 3) week = "三"
            if (new Date().getDay() == 4) week = "四"
            if (new Date().getDay() == 5) week = "五"
            if (new Date().getDay() == 6) week = "六"
            $("#weekDay").html(week);
        };


        //        var x = document.getElementById("id");

        //        var j = $(x);
        //        
        //j.attr("id")
        //$("#timeY").html(NowTime[0]);

    });
};


