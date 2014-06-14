var Comm_WarehouseList =
{
    HouseType: '',
    CompanyCode: '',
    CurNode: null,
    //根据仓库物料类型进行筛选
    InitFilter: function(obj, _HouseType, callback) {
        Comm_WarehouseList.HouseType = _HouseType;
        Comm_WarehouseList.Init(obj, callback);
    },
    //根据仓库所属公司，物料类型进行筛选
    InitFilterCompany: function(obj, _HouseType, _CompanyCode, callback) {
        Comm_WarehouseList.CompanyCode = _CompanyCode;
        Comm_WarehouseList.HouseType = _HouseType;
        Comm_WarehouseList.Init(obj, callback);
    },
    InitFilterWarehouse: function(obj, callback) {
        //容器
        var bigContainer = obj + "_modalWHTreeContainer";
        //树控件
        var div_tree = obj + "_WH_div_tree";
        //确定按钮
        var div_confirm = obj + "_WH_div_confirm";

        $(document.body).append("<div id='" + bigContainer + "' ><div id='" + div_tree + "' class='CommTree'></div><div style='float:right' id='" + div_confirm + "'></div></div>");

        var container = $("#" + bigContainer);


        container.find("#" + div_confirm).html("<input id='" + obj + "_WH_tree_confirm' type='button' value='确定'/><input id='" + obj + "_WH_tree_close' type='button' value='关闭'/>");
        var $obj = $("#" + obj);

        $obj.attr("readonly", true);
        $obj.click(function() {
            container.dialog("open");
        });

        $("#" + obj + "_WH_tree_confirm").click(function() {

//            if (Comm_WarehouseList.CurNode == null) {
//                ShowMsg("请选择节点");
//                return;
//            }

            var node = $.jstree._focused()._get_node();
            var isExsitChild = $.jstree._focused()._get_children(node);

            if (isExsitChild.length == 0) {
                var parentNode = $.jstree._focused()._get_parent(node);
                var rootNode = $.jstree._focused()._get_parent(parentNode);

                var code = $(node).attr("id");
                //获取所有父极节点ID
                var path = $.jstree._focused().get_path(node, true);
                //alert(path);
                var name = treeTarget.jstree("get_text", node);
                var pcode = $(rootNode).attr("id");
                var pname = treeTarget.jstree("get_text", rootNode);

                //验证本身节点，父节点，是否为公司节点
                $.ajax({ url: '/nStock/nWareHouseCheckForRpt/' + code, type: 'post', dataType: 'json', success: function(data) {
                    if (data.Result == "success") {
                        container.dialog("close");
                        callback(code, name, data.Pcode, data.Pname, data.CompanyCode, data.Company);
                    } else if (data.Result == "fail") {
                        ShowMsg("请选择具体存储的仓库 !");
                    }
                    else {
                        ShowMsg("获取数据失败，请重试");
                    }
                }
                })

            }
            else {
                ShowMsg("请选择具体存储的仓库!");
            }
        });

        $("#" + obj + "_WH_tree_close").click(function() {
            container.dialog("close");
        });


        var treeTarget = container.find("#" + div_tree);

        treeTarget.jstree({
            'core': { 'animation': 0 },
            'plugins': ['themes', 'json_data', 'ui', 'crrm', 'cookies', 'dnd', 'search', 'types', 'hotkeys', 'contextmenu', 'unique'],
            "json_data": {
                "ajax": {
                    "url": "/WH/GetWarehouseTreeForRpt/"
                }
            },
            'themes': { 'theme': 'classic', 'url': '/Content/JsTreeThemes/classic/style.css', 'dots': true, 'icons': true },
            'ui': { 'select_limit': 1, 'select_multiple_modifier': 'alt', 'selected_parent_close': 'select_parent' }

        });
        //数据控件事件绑定
        treeTarget.bind('click.jstree', function(event) {
            var eventNodeName = event.target.nodeName;
            if (eventNodeName == 'INS') {
                return;
            } else if (eventNodeName == 'A') {
                var $subject = $(event.target);
                Comm_WarehouseList.CurNode = $subject;
            }
        });

        treeTarget.bind("loaded.jstree", function(event, data) {
            //treeTarget.jstree("open_all");
        });



        //dialog 初始化
        container.dialog({ autoOpen: false, title: '通用仓库选择' });

    },
    Init: function(obj, callback) {
        //容器
        var bigContainer = obj + "_modalWHTreeContainer";
        //树控件
        var div_tree = obj + "_WH_div_tree";
        //确定按钮
        var div_confirm = obj + "_WH_div_confirm";

        $(document.body).append("<div id='" + bigContainer + "' ><div id='" + div_tree + "' class='CommTree'></div><div style='float:right' id='" + div_confirm + "'></div></div>");

        var container = $("#" + bigContainer);


        container.find("#" + div_confirm).html("<input id='" + obj + "_WH_tree_confirm' type='button' value='确定'/><input id='" + obj + "_WH_tree_close' type='button' value='关闭'/>");
        var $obj = $("#" + obj);

        $obj.attr("readonly", true);
        $obj.click(function() {
            container.dialog("open");
        });

        $("#" + obj + "_WH_tree_confirm").click(function() {

            if (Comm_WarehouseList.CurNode == null) {
                ShowMsg("请选择节点");
                return;
            }

            var node = $.jstree._focused()._get_node();
            var isExsitChild = $.jstree._focused()._get_children(node);

            if (isExsitChild.length == 0) {
                var parentNode = $.jstree._focused()._get_parent(node);
                var rootNode = $.jstree._focused()._get_parent(parentNode);

                var code = $(node).attr("id");
                //获取所有父极节点ID
                var path = $.jstree._focused().get_path(node, true);
                //alert(path);
                var name = treeTarget.jstree("get_text", node);
                var pcode = $(rootNode).attr("id");
                var pname = treeTarget.jstree("get_text", rootNode);

                //验证本身节点，父节点，是否为公司节点
                $.ajax({ url: '/nStock/nWareHouseCheck/' + code, type: 'post', dataType: 'json', success: function(data) {
                    if (data.Result == "success") {
                        container.dialog("close");
                        callback(code, name, data.Pcode, data.Pname, data.CompanyCode, data.Company);
                    } else if (data.Result == "fail") {
                        ShowMsg("请选择具体存储的仓号!");
                    }
                    else {
                        ShowMsg("获取数据失败，请重试");
                    }
                }
                })

            }
            else {
                ShowMsg("请选择具体存储的仓号!");
            }
        });

        $("#" + obj + "_WH_tree_close").click(function() {
            container.dialog("close");
        });


        var treeTarget = container.find("#" + div_tree);

        treeTarget.jstree({
            'core': { 'animation': 0 },
            'plugins': ['themes', 'json_data', 'ui', 'crrm', 'cookies', 'dnd', 'search', 'types', 'hotkeys', 'contextmenu', 'unique'],
            "json_data": {
                "ajax": {
                    "url": "/WH/GetWarehouseTree/?company=" + Comm_WarehouseList.CompanyCode
                }
            },
            'themes': { 'theme': 'classic', 'url': '/Content/JsTreeThemes/classic/style.css', 'dots': true, 'icons': true },
            'ui': { 'select_limit': 1, 'select_multiple_modifier': 'alt', 'selected_parent_close': 'select_parent' }

        });
        //数据控件事件绑定
        treeTarget.bind('click.jstree', function(event) {
            var eventNodeName = event.target.nodeName;
            if (eventNodeName == 'INS') {
                return;
            } else if (eventNodeName == 'A') {
                var $subject = $(event.target);
                Comm_WarehouseList.CurNode = $subject;
            }
        });

        treeTarget.bind("loaded.jstree", function(event, data) {
            //treeTarget.jstree("open_all");
        });



        //dialog 初始化
        container.dialog({ autoOpen: false, title: '通用仓库选择' });

    },
    //弹出选择OPEN obj 控件ID，filterobj过滤  callback 回调
    Open: function(obj, filterobj, company, callback) {
        //容器
        var bigContainer = obj + "_modalWHTreeContainer";
        //树控件
        var div_tree = obj + "_WH_div_tree";
        //确定按钮
        var div_confirm = obj + "_WH_div_confirm";

        $(document.body).append("<div id='" + bigContainer + "' ><div id='" + div_tree + "' class='CommTree'></div><div id='" + div_confirm + "'></div></div>");

        var container = $("#" + bigContainer);


        container.find("#" + div_confirm).html("<input id='" + obj + "_WH_tree_confirm' type='button' value='确定'/><input id='" + obj + "_WH_tree_close' type='button' value='关闭'/>");
        var $obj = $("#" + obj);

        $obj.attr("readonly", true);
        //        $obj.click(function() {
        //            container.dialog("open");
        //        });


        $("#" + obj + "_WH_tree_confirm").click(function() {

            var node = $.jstree._focused()._get_node();
            var isExsitChild = $.jstree._focused()._get_children(node);

            if (isExsitChild.length == 0) {
                var parentNode = $.jstree._focused()._get_parent(node);
                var rootNode = $.jstree._focused()._get_parent(parentNode);

                var code = $(node).attr("id");
                //var path = treeTarget.jstree("get_path",node,true);
                //alert(path);
                var name = treeTarget.jstree("get_text", node);
                var pcode = $(rootNode).attr("id");
                var pname = treeTarget.jstree("get_text", rootNode);

                //验证本身节点，父节点，是否为公司节点
                $.ajax({ url: '/nStock/nWareHouseCheck/' + code, type: 'post', dataType: 'json', success: function(data) {
                    if (data.Result == "success") {
                        container.dialog("close");
                        callback(code, name, data.Pcode, data.Pname, data.CompanyCode, data.Company);
                    } else if (data.Result == "fail") {
                        ShowMsg("请选择具体存储的仓号!");
                    }
                    else {
                        ShowMsg("获取数据失败，请重试");
                    }
                }
                })

            }
            else {
                ShowMsg("请选择具体存储的仓号!");
            }
        });

        $("#" + obj + "_WH_tree_close").click(function() {
            container.dialog("close");
        });

        var treeTarget = container.find("#" + div_tree);

        treeTarget.jstree({
            'core': { 'animation': 0 },
            'plugins': ['themes', 'json_data', 'ui', 'crrm', 'cookies', 'dnd', 'search', 'types', 'hotkeys', 'contextmenu', 'unique'],
            "json_data": {
                "ajax": {
                    "url": "/WH/GetWarehouseTree/?company=" + company
                }
            },
            'themes': { 'theme': 'classic', 'url': '/Content/JsTreeThemes/classic/style.css', 'dots': true, 'icons': true },
            'ui': { 'select_limit': 1, 'select_multiple_modifier': 'alt', 'selected_parent_close': 'select_parent' }

        });
        //数据控件事件绑定
        treeTarget.bind('click.jstree', function(event) {
            var eventNodeName = event.target.nodeName;
            if (eventNodeName == 'INS') {
                return;
            } else if (eventNodeName == 'A') {
                var $subject = $(event.target);
                //                Common_Tree_Dict.CurNode = $subject;
            }
        });

        treeTarget.bind("loaded.jstree", function(event, data) {
            //treeTarget.jstree("open_all");
        });

        //dialog 初始化
        container.dialog({ autoOpen: false, title: '通用仓库选择' });
        container.dialog("open");
    },

    //弹出选择OPEN obj 控件ID，filterobj过滤  callback 回调
    OpenNode: function(obj, filterobj, node, callback) {
        //容器
        var bigContainer = obj + "_modalWHTreeContainer";
        //树控件
        var div_tree = obj + "_WH_div_tree";
        //确定按钮
        var div_confirm = obj + "_WH_div_confirm";

        $(document.body).append("<div id='" + bigContainer + "' ><div id='" + div_tree + "' class='CommTree'></div><div id='" + div_confirm + "'></div></div>");

        var container = $("#" + bigContainer);


        container.find("#" + div_confirm).html("<input id='" + obj + "_WH_tree_confirm' type='button' value='确定'/><input id='" + obj + "_WH_tree_close' type='button' value='关闭'/>");
        var $obj = $("#" + obj);

        $obj.attr("readonly", true);
        //        $obj.click(function() {
        //            container.dialog("open");
        //        });


        $("#" + obj + "_WH_tree_confirm").click(function() {

            var node = $.jstree._focused()._get_node();
            var isExsitChild = $.jstree._focused()._get_children(node);

            if (isExsitChild.length == 0) {
                var parentNode = $.jstree._focused()._get_parent(node);
                var rootNode = $.jstree._focused()._get_parent(parentNode);

                var code = $(node).attr("id");
                //var path = treeTarget.jstree("get_path",node,true);
                //alert(path);
                var name = treeTarget.jstree("get_text", node);
                var pcode = $(rootNode).attr("id");
                var pname = treeTarget.jstree("get_text", rootNode);

                //验证本身节点，父节点，是否为公司节点
                $.ajax({ url: '/nStock/nWareHouseCheck/' + code, type: 'post', dataType: 'json', success: function(data) {
                    if (data.Result == "success") {
                        container.dialog("close");
                        callback(code, name, data.Pcode, data.Pname, data.CompanyCode, data.Company);
                    } else if (data.Result == "fail") {
                        ShowMsg("请选择具体存储的仓号!");
                    }
                    else {
                        ShowMsg("获取数据失败，请重试");
                    }
                }
                })

            }
            else {
                ShowMsg("请选择具体存储的仓号!");
            }
        });

        $("#" + obj + "_WH_tree_close").click(function() {
            container.dialog("close");
        });

        var treeTarget = container.find("#" + div_tree);

        treeTarget.jstree({
            'core': { 'animation': 0 },
            'plugins': ['themes', 'json_data', 'ui', 'crrm', 'cookies', 'dnd', 'search', 'types', 'hotkeys', 'contextmenu', 'unique'],
            "json_data": {
                "ajax": {
                    "url": "/WH/GetWarehouseTreeByNode/?node=" + node
                }
            },
            'themes': { 'theme': 'classic', 'url': '/Content/JsTreeThemes/classic/style.css', 'dots': true, 'icons': true },
            'ui': { 'select_limit': 1, 'select_multiple_modifier': 'alt', 'selected_parent_close': 'select_parent' }

        });
        //数据控件事件绑定
        treeTarget.bind('click.jstree', function(event) {
            var eventNodeName = event.target.nodeName;
            if (eventNodeName == 'INS') {
                return;
            } else if (eventNodeName == 'A') {
                var $subject = $(event.target);
                //                Common_Tree_Dict.CurNode = $subject;
            }
        });

        treeTarget.bind("loaded.jstree", function(event, data) {
            //treeTarget.jstree("open_all");
        });

        //dialog 初始化
        container.dialog({ autoOpen: false, title: '通用仓库选择' });
        container.dialog("open");
    }


}