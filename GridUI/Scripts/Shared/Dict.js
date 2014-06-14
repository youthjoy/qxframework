/// <reference path="jquery-1.4.1.min-vsdoc.js" />

var Common_Select_Dict = {
    //target-jquery目标对象 eg:$("#xx")  || dictkey 字典关键字
    Init: function(target, dictkey, dname) {
        var $dname = $("#" + dname);
        target.change(function() {
            if ($dname.length != 0) {
                var checkText = $(this).find("option:selected").text();
                $dname.val(checkText);
            }
        });

        $.ajax({
            type: "post",
            url: "/Dict/GetNoLevelDictList",
            data: { key: dictkey },
            success: function(data, textStatus) {
                var value = target.val();
                target.empty();
                $.each(data, function(i, d) {
                    target.append("<option value='" + d.Dict_Code + "'>" + d.Dict_Name + "</option>");
                });
                if (value != null) {
                    target.val(value);
                    if ($dname.length != 0) {
                        var checkText = target.find("option:selected").text();
                        $dname.val(checkText);
                    }
                }
            },
            error: function() {
                //请求出错处理
            }
        });
    }
}


var Common_Tree_Dict =
{
    CurNode: null,
    //target-目标对象id  || dictkey 字典关键字  || callback 回调函数
    Init: function(obj, dictKey, callback) {

        var bigContainer = obj + "_modalTreeContainer";
        var div_tree = obj + "_div_tree";
        var div_confirm = obj + "_div_confirm";
        $(document.body).append("<div id='" + bigContainer + "'><div id='" + div_tree + "'></div><div style='float:right' id='" + div_confirm + "'></div></div>");

        var container = $("#" + bigContainer);


        container.find("#" + div_confirm).html("<input id='" + obj + "_tree_refresh' type='button' value='刷新'/><input id='" + obj + "_tree_confirm' type='button' value='确定'/><input id='" + obj + "_tree_close' type='button' value='关闭'/>");
        var $obj = $("#" + obj);
        $obj.attr("readonly", true);
        $obj.click(function() {
            container.dialog("open");
        });

        $("#" + obj + "_tree_confirm").click(function() {
            //            if (Common_Tree_Dict.CurNode != null) {
            //debugger;
            if (Common_Tree_Dict.CurNode == null) {
                ShowMsg("请选择节点");
                return;
            }
            var node = $.jstree._focused()._get_node();

            var code = $(node).attr("id");
            //            var name = $(node).attr("textContent");
            var name = treeTarget.jstree("get_text", node);
            container.dialog("close");
            callback(code, name);
            // callback(node);
            //            ShowMsg($(d).attr("id"));
            //            }
        });

        $("#" + obj + "_tree_close").live("click", function() {
            container.dialog('close');
        });


        var treeTarget = container.find("#" + div_tree);

        treeTarget.jstree({
            'core': { 'animation': 0 },
            'plugins': ['themes', 'json_data', 'ui', 'crrm', 'cookies', 'dnd', 'search', 'types', 'hotkeys', 'contextmenu', 'unique'],
            "json_data": {
                "ajax": {
                    "url": "/Dict/GetDictTreeData/" + dictKey
                }
            },
            'themes': { 'theme': 'classic', 'url': '/Content/JsTreeThemes/classic/style.css', 'dots': false, 'icons': true },
            'ui': { 'select_limit': 1, 'select_multiple_modifier': 'alt', 'selected_parent_close': 'select_parent' }

        });
        //数据控件事件绑定
        treeTarget.bind('click.jstree', function(event) {
            var eventNodeName = event.target.nodeName;
            if (eventNodeName == 'INS') {
                return;
            } else if (eventNodeName == 'A') {
                var $subject = $(event.target);
                Common_Tree_Dict.CurNode = $subject;
            }
        });


        //dialog 初始化
        container.dialog({ autoOpen: false, title: '通用类别选择组件' });

    }
}


var Common_Tree_Area =
{
    CurNode: null,
    //target-目标对象id  || dictkey 字典关键字  || callback 回调函数
    Init: function(obj, callback) {

        var bigContainer = obj + "_modalTreeContainer";
        var div_tree = obj + "_div_tree";
        var div_confirm = obj + "_div_confirm";
        $(document.body).append("<div id='" + bigContainer + "'><div id='" + div_tree + "'></div><div style='float:right' id='" + div_confirm + "'></div></div>");

        var container = $("#" + bigContainer);


        container.find("#" + div_confirm).html("<input id='" + obj + "_tree_refresh' type='button' value='刷新'/><input id='" + obj + "_tree_confirm' type='button' value='确定'/><input id='" + obj + "_tree_close' type='button' value='关闭'/>");
        var $obj = $("#" + obj);
        $obj.attr("readonly", true);
        $obj.click(function() {
        
            container.dialog("open");
        });

        $("#" + obj + "_tree_confirm").click(function() {
            //            if (Common_Tree_Dict.CurNode != null) {
            //debugger;
            if (Common_Tree_Dict.CurNode == null) {
                ShowMsg("请选择节点");
                return;
            }
            var node = $.jstree._focused()._get_node();

            var code = $(node).attr("id");
            //            var name = $(node).attr("textContent");
            var name = treeTarget.jstree("get_text", node);
            container.dialog("close");
            callback(code, name);
            // callback(node);
            //            ShowMsg($(d).attr("id"));
            //            }
        });

        $("#" + obj + "_tree_close").live("click", function() {
            container.dialog('close');
        });


        var treeTarget = container.find("#" + div_tree);

        treeTarget.jstree({
            'core': { 'animation': 0 },
            'plugins': ['themes', 'json_data', 'ui', 'crrm', 'cookies', 'dnd', 'search', 'types', 'hotkeys', 'contextmenu', 'unique'],
            "json_data": {
                "ajax": {
                    "url": "/Area/GetAreaTreeData/"
                }
            },
            'themes': { 'theme': 'classic', 'url': '/Content/JsTreeThemes/classic/style.css', 'dots': false, 'icons': true },
            'ui': { 'select_limit': 1, 'select_multiple_modifier': 'alt', 'selected_parent_close': 'select_parent' }

        });
        //数据控件事件绑定
        treeTarget.bind('click.jstree', function(event) {
            var eventNodeName = event.target.nodeName;
            if (eventNodeName == 'INS') {
                return;
            } else if (eventNodeName == 'A') {
                var $subject = $(event.target);
                Common_Tree_Dict.CurNode = $subject;
            }
        });


        //dialog 初始化
        container.dialog({ autoOpen: false, title: '通用类别选择组件' });

    }
}