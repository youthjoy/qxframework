// Modify BY YSW 
// Modify:MPPP单独配置 大宗物料计划
// Modify Date:2011-3-25


Aspects = function() { };
Aspects.prototype = {
    before: function(target, method, advice) {
        var original = target[method];
        target[method] = function() {
            (advice)();
            original.apply(target, arguments);
        }
        return target
    },
    after: function(target, method, advice) {

        var original = target[method];
        target[method] = function() {
            original.apply(target, arguments);
            (advice)();
        }
        return target
    },
    around: function(target, method, advice) {
        var original = target[method];
        target[method] = function() {
            (advice)();
            original.apply(target, arguments);
            (advice)();
        }
        return target
    }
}


$(function() {
    var udef4 = $("#WHIOI_Udef4");
    if (udef4.length!=0) {
        $("#WHIOI_Udef1").change(function() {
            var $this = $(this);
            udef4.val($this.find("option:selected").text());
        });

        var Dtoolbar = $("#MPPPOUT__add")[0];
        
        //Modify:QB
        //Modify:增加判断是否存在DOM节点
        
        if (Dtoolbar != undefined) {
            var a = new Aspects();
            //    var a = new Aspects;
            a.after(Dtoolbar, "onclick", function() {
                udef4.val($("#WHIOI_Udef1").find("option:selected").text());
            });
        }      
    }
});

