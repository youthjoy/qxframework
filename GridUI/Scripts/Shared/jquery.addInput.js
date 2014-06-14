; (function($) {
    $.fn.extend({
        "addinput": function(o) {
            o = $.extend({
                clicker: null, //点击开关，可以根据class（或id）选择，默认.next()获取
                labelValue: "",
                wrap: "li", //input的父标签
                name: "i-text", //input的name
                type: "text", //input的type，默认text型
                value: "", //input的value
                maxlength: 20, //input的maxlength，默认20
                className: 'form_textbox', //input的className
                toplimit: 0, //新增input的上限，0表示不限制
                removeCallback: null,
                initValue: null //初始化添加的input的value值，必须是数组。用于修改某资料时显示已有的数据

            }, o || {});
            //定义一个变量存储容器
            var $container = $(this);
            var i, len;

            //name数组化
            var arrName = new Array();
            if ($.isArray(o.name)) {
                arrName = o.name;
            } else {
                arrName.push(o.name);
            }
            var nLen = arrName.length;

            //label
            var lblName = new Array();
            if ($.isArray(o.labelValue)) {
                lblName = o.labelValue;
            } else {
                //补全label数组（根据name数组长度）
                for (i = 0; i < nLen; i++) {
                    lblName.push(o.labelValue);
                }
            }

            var lLen = lblName.length;

            //type数组化
            var arrType = new Array();
            if ($.isArray(o.type)) {
                arrType = o.type;
            } else {
                //补全type数组（根据name数组长度）
                for (i = 0; i < nLen; i++) {
                    arrType.push(o.type);
                }
            }
            var tLen = arrType.length;

            //value数组化
            var arrValue = new Array();
            if ($.isArray(o.value)) {
                arrValue = o.value;
            } else {
                //补全value数组（根据name数组长度）
                for (i = 0; i < nLen; i++) {
                    arrValue.push(o.value);
                }
            }
            var vLen = arrValue.length;

            //maxlength数组化
            var arrMaxlength = new Array();
            if ($.isArray(o.maxlength)) {
                arrMaxlength = o.maxlength;
            } else {
                //补全maxlength数组（根据name数组长度）
                for (i = 0; i < nLen; i++) {
                    arrMaxlength.push(o.maxlength);
                }
            }
            var mLen = arrMaxlength.length;

            //class数组化
            var arrClass = new Array();
            if ($.isArray(o.className)) {
                arrClass = o.className;
            } else {
                //补全class数组（根据name数组长度）
                for (i = 0; i < nLen; i++) {
                    arrClass.push(o.className);
                }
            }
            var cLen = arrClass.length;

            var oo = {
                remove: "<a href=\"#nogo\" class=\"remove\">移除</a>",
                error1: "参数配置错误，数组的长度不一致，请检查。",
                error2: "参数配置错误，每组初始化值都必须是数组，请检查。"
            }

            //定义一个变量，判断各数组长度是否一致（必需的）
            var allowed = nLen != tLen || nLen != vLen || nLen != mLen || nLen != cLen ? false : true
            if (!allowed) {//如果不一致...
                $container.text(oo.error1);
                return false;
            } else {
                //获取点击开关
                var $Clicker = !o.clicker ? $container.next() : $(o.clicker);
                $Clicker.bind("click", function() {
                    //未添加前的组数
                    len = $container.children(o.wrap).length;
                    //定义一个变量，判断是否已经达到上限
                    var isMax = o.toplimit === 0 ? false : (len < o.toplimit ? false : true);
                    if (!isMax) {//没有达到上限才允许添加
                        var $Item = $("<" + o.wrap + ">").appendTo($container);
                        //添加一个div 框
                       // var $div = $("<div style='border:1px solid'></div>");
                        //根据name数组的长度添加input
                        for (i = 0; i < nLen; i++) {
                            // alert(lblName[i]);
                            var lab = $("<label class='form_label'>" + lblName[i] + "</label>")
                            var input = ($("<input>", {//jQuery1.4新增方法
                                name: arrName[i],
                                type: arrType[i],
                                value: arrValue[i],
                                maxlength: arrMaxlength[i],
                                className: arrClass[i]
                            }));


                            //                            $("<div></div>").append(lab).append(input).appendTo($div);
                            $("<div></div>").append(lab).append(input).appendTo($Item);
                        }
                        //$div.appendTo($Item);

                        $Item = $container.children(o.wrap);
                        //新组数
                        len = $Item.length;
                        if (len > 1) {
                            $Item.last().append(oo.remove);
                            if (len === 2) {//超过一组时，为第一组添加“移除”按钮
                                $Item.first().append(oo.remove);
                            }
                        }
                        $Item.find(".remove").click(function() {
                            //移除本组

                            if (o.removeCallback != null) {
                                if (o.removeCallback($(this).parent())) {
                                    $(this).parent().remove();
                                }
                            }
                            else {
                                $(this).parent().remove();
                            }

                            //统计剩下的组数
                            len = $container.children(o.wrap).length;
                            if (len === 1) {//只剩一个的时候，把“移除”按钮干掉
                                $container.find(".remove").remove();
                            }
                            //取消“移除”按钮的默认动作
                            return false;
                        });
                    }
                    //取消点击开关的默认动作
                    return false;
                });
                //初始化
                if ($.isArray(o.initValue)) {//判断是否是数组（必需的）
                    $.each(o.initValue, function(i, n) {
                        if (!$.isArray(n)) {
                            $container.empty().text(oo.error2);
                            return false;
                        }
                        //新增一组默认input
                        $Clicker.click();
                        //获取本次新增的组
                        $Item = $container.children(o.wrap).eq(i);
                        $.each(n, function(j, m) {
                            //循环调整input的value值
                            $Item.children("input").eq(j).attr("value", m);
                        });
                    });
                } else {
                    //没有设置初始化，新增一组默认input
                    $Clicker.click();
                }
            }
        }
    });
})(jQuery);