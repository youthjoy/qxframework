var Common_Tree_Dept = {
    //obj  目标控件ID   || callback 回调函数
    Init: function(obj, callback) {
        //容器
        var bigContainer = obj + "_modalDeptTreeContainer";
        //树控件
        var div_tree = obj + "_dept_div_tree";
        //确定按钮
        var div_confirm = obj + "_dept_div_confirm";

        $(document.body).append("<div class='comm_dept_container' id='" + bigContainer + "'><div class='comm_dept_tree' id='" + div_tree + "'></div><div class='comm_dept_confirm' id='" + div_confirm + "'></div></div>");

        var container = $("#" + bigContainer);

        //        container.find("#" + div_confirm).append("<input id='" + obj + "_dept_tree_confirm' type='button' value='确定'/>");
        container.find("#" + div_confirm).html("<input id='" + obj + "_dept_tree_close' type='button' value='关闭'/><input id='" + obj + "_dept_tree_confirm' type='button' value='确定'/>");
        var $obj = $("#" + obj);

        $obj.attr("readonly", true);
        $obj.click(function() {
            container.dialog("open");
        });

        $("#" + obj + "_dept_tree_confirm").click(function() {
            var node = $.jstree._focused()._get_node();

            var code = $(node).attr("id");

            //            var parentNode = $.jstree._focused()._get_parent(node);

            var name = treeTarget.jstree("get_text", node);

            var rootName = $.jstree._focused().get_path(node)[0];

            var rootCode = $.jstree._focused().get_path(node, true)[0];

            container.dialog("close");

//            if (rootName != name) {
                callback(code, name, rootName, rootCode);
//            }



        });

        $("#" + obj + "_dept_tree_close").click(function() {
            container.dialog('close');
        });


        var treeTarget = container.find("#" + div_tree);

        treeTarget.jstree({
            'core': { 'animation': 0 },
            'plugins': ['themes', 'json_data', 'ui', 'crrm', 'cookies', 'dnd', 'search', 'types', 'hotkeys', 'contextmenu', 'unique'],
            "json_data": {
                "ajax": {
                    "url": "/HR/GetDeptTree"
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


        //dialog 初始化
        container.dialog({ autoOpen: false, title: '通用部门选择组件' });

    },

    //obj  目标控件ID   || callback 回调函数
    InitForEqu: function(id, $obj, ext, callback) {


        var obj = id + ext;
        //容器
        var bigContainer = obj + "_modalDeptTreeContainer";
        //树控件
        var div_tree = obj + "_dept_div_tree";
        //确定按钮
        var div_confirm = obj + "_dept_div_confirm";

        $(document.body).append("<div class='comm_dept_container' id='" + bigContainer + "'><div class='comm_dept_tree' id='" + div_tree + "'></div><div class='comm_dept_confirm' id='" + div_confirm + "'></div></div>");

        var container = $("#" + bigContainer);

        //        container.find("#" + div_confirm).append("<input id='" + obj + "_dept_tree_confirm' type='button' value='确定'/>");
        container.find("#" + div_confirm).html("<input id='" + obj + "_dept_tree_close' type='button' value='关闭'/><input id='" + obj + "_dept_tree_confirm' type='button' value='确定'/>");
        //        var $obj = $("#" + obj);

        $obj.attr("readonly", true);
        $obj.click(function() {
            container.dialog("open");
        });

        $("#" + obj + "_dept_tree_confirm").click(function() {
            var node = $.jstree._focused()._get_node();
            
            var code = $(node).attr("id");

            var parentNode = $.jstree._focused()._get_parent(node);

            var name = treeTarget.jstree("get_text", node);

            var rootName = $.jstree._focused().get_path(node)[0];

            var rootCode = $(parentNode).attr("id");

            container.dialog("close");

            callback(code, name, rootName, rootCode);

        });

        $("#" + obj + "_dept_tree_close").click(function() {
            container.dialog('close');
        });


        var treeTarget = container.find("#" + div_tree);

        treeTarget.jstree({
            'core': { 'animation': 0 },
            'plugins': ['themes', 'json_data', 'ui', 'crrm', 'cookies', 'dnd', 'search', 'types', 'hotkeys', 'contextmenu', 'unique'],
            "json_data": {
                "ajax": {
                    "url": "/HR/GetDeptTree"
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


        //dialog 初始化
        container.dialog({ autoOpen: false, title: '通用选择组件' });

    }
}



var Common_EmpTree_Dept = {

    setupGrid: function(grid, pager, search) {
        $(grid).jqGrid({
            url: "/HR/List/",
            mtype: "post",
            datatype: "json",
            colNames: ['员工编码', '员工名称', '英文名', '职务', '职称'],
            colModel: [

                        { name: 'Stuff_Code', index: 'Stuff_Code', width: 100, align: 'center', sortable: false, hidden: false, searchoptions: { sopt: ['cn', 'ne', 'eq']} },
                        { name: 'Stuff_Name', index: 'Stuff_Name', width: 120, align: 'center', sortable: false, hidden: false, searchoptions: { sopt: ['cn', 'ne', 'eq']} },
                        { name: 'Stuff_ENName', index: 'Stuff_ENName', width: 100, align: 'center', sortable: false, hidden: false, searchoptions: { sopt: ['cn', 'ne', 'eq']} },
                        { name: 'Stuff_Duty', index: 'Stuff_Duty', width: 100, align: 'center', sortable: false, hidden: false, searchoptions: { sopt: ['cn', 'ne', 'eq']} },
                        { name: 'Stuff_Title', index: 'Stuff_Title', width: 120, align: 'center', searchoptions: { sopt: ['cn', 'ne', 'eq']} }
                      ],
            rowNum: 10,
            rowList: [10, 20, 50],
            pager: $(pager),
            sortname: 'StuffName',
            sortorder: "asc",
            width: '600',
            viewrecords: true,
            multiselect: false,
            autowidth: false,
            rownumbers: true,
            gridview: true,
            caption: '员工信息列表',
            footerrow: false,
            userDataOnFooter: true
        }).navGrid(pager, { refresh: false, edit: false, add: false, del: false, search: false });


    },
    //$('#Auditinggrid').jqGrid('searchGrid', { multipleSearch:true } );
    //obj  目标控件ID   || callback 回调函数
    Init: function(obj, callback) {
        var bigContainer = obj + "_modalDeptTreeContainer";
        var div_tree = obj + "_dept_div_tree";
        var div_confirm = obj + "_dept_div_confirm";

        var div_search = obj + "_search";
        var div_grid = obj + "_grid";
        var div_pager = obj + "_pager";

        var tool_search = obj + "_Comm_User_Search";
        var tool_refresh = obj + "_Comm_User_Refresh";

        // Modify BY QB
        // Modify:修改Div加载方式 解决页面元素查找不到的情况 
        // Modify Date:2011-3-22
        //var _container = document.createElement("div");
        //_container.setAttribute("id", bigContainer);
        var _container = "<div id='" + bigContainer + "'></div>";
        $(document.body).append(_container);
        $("#" + bigContainer).html("<table><tr><td valign='top'><div id='" + div_tree + "' style='width:150px;float:left;'></div></td><td><div style='width:600px;' ><div class='toolbar'> <ul><li class='toolbar_search' id='' style='display: block;'><a href='#' id='" + tool_search + "'>搜索</a></li><li class='toolbar_edit' id='' style='display: block;'><a href='#' id='" + tool_refresh + "'>刷新</a></li></ul></div><div id='" + div_search + "'></div><table id='" + div_grid + "' class='scroll' cellpadding='0' cellspacing='0'></table><div id='" + div_pager + "' class='scroll' style='text-align: center;'></div></div></td></tr><tr><td colspan='2'><div class='comm_emp_confirm' id='" + div_confirm + "'></div></tr></table>");
        var container = $("#" + bigContainer);
        //$(document.body).append("<div id='" + bigContainer + "'><table><tr><td valign='top'><div id='" + div_tree + "' style='width:150px;float:left;'></div></td><td><div style='width:600px;' ><div class='toolbar'> <ul><li class='toolbar_search' id='' style='display: block;'><a href='#' id='" + tool_search + "'>搜索</a></li><li class='toolbar_edit' id='' style='display: block;'><a href='#' id='" + tool_refresh + "'>刷新</a></li></ul></div><div id='" + div_search + "'></div><table id='" + div_grid + "' class='scroll' cellpadding='0' cellspacing='0'></table><div id='" + div_pager + "' class='scroll' style='text-align: center;'></div></div></td></tr><tr><td colspan='2'><div class='comm_emp_confirm' id='" + div_confirm + "'></div></tr></table></div>");

        //var container = $("#" + bigContainer);

        //        container.find("#" + div_confirm).append("<input id='" + obj + "_dept_tree_confirm' type='button' value='确定'/>");
        container.find("#" + div_confirm).html("<input id='" + obj + "_dept_tree_confirm' type='button' value='确定'/><input id='" + obj + "_dept_tree_close' type='button' value='关闭'/>");
        //目标控件事件
        var $obj = $("#" + obj);
        $obj.attr("readonly", true);
        $obj.bind("click", function() {
            container.dialog("open");
        });

        $("#" + obj + "_dept_tree_close").bind("click", function() {
            container.dialog("close");
        });

        $("#" + tool_search).click(function() {
            $("#" + div_grid).jqGrid('searchGrid', { multipleSearch: true });

        });
        $("#" + tool_refresh).click(function() {
            $("#" + div_grid).trigger("reloadGrid");
        });

        var treeTarget = container.find("#" + div_tree);

        //树控件初始化
        treeTarget.jstree({
            'plugins': ['themes', 'json_data', 'ui', 'crrm', 'cookies', 'dnd', 'search', 'types', 'hotkeys', 'contextmenu', 'unique'],
            "json_data": {
                "ajax": {
                    "url": "/HR/GetDeptTree"
                }
            },
            'themes': { 'theme': 'classic', 'url': '/Content/JsTreeThemes/classic/style.css', 'dots': false, 'icons': true },
            'ui': { 'select_limit': 1, 'select_multiple_modifier': 'alt', 'selected_parent_close': 'select_parent' }

        });



        //Grid初始化
        var gridTarget = container.find("#" + div_grid);
        var pagerTarget = container.find("#" + div_pager);
        var searchTarget = container.find("#" + div_search);

        //判断是否已经初始化
        Common_EmpTree_Dept.setupGrid("#" + div_grid, "#" + div_pager, "#" + div_search);

        //数据控件事件绑定
        treeTarget.bind('click.jstree', function(event) {
            var eventNodeName = event.target.nodeName;
            if (eventNodeName == 'INS') {
                return;
            } else if (eventNodeName == 'A') {
                var node = $.jstree._focused()._get_node();
                var deptcode = $(node).attr("id");

                //读取数据的方法
                gridTarget.setGridParam({ url: '/HR/List/' + deptcode });
                //                gridTarget.setPostData({});
                gridTarget.setGridParam({ page: 1 });
                gridTarget.trigger("reloadGrid");

            }
        });

        //确定按钮事件
        $("#" + obj + "_dept_tree_confirm").click(function() {
            var s;
            s = gridTarget.jqGrid('getGridParam', 'selrow');
            var ret = gridTarget.jqGrid('getRowData', s);
            container.dialog("close");
            callback(ret.Stuff_Code, ret.Stuff_Name);
        });


        //dialog 初始化
        container.dialog({ autoOpen: false, width: 800, title: '通用人员选择组件' });

    }
}


//备份方法

//var Common_Tree_Dept = {
//    Init: function(obj, callback) {
//        var bigContainer = obj + "_modalDeptTreeContainer";
//        var div_tree = obj + "_dept_div_tree";
//        var div_confirm = obj + "_dept_div_confirm";
//        $(document.body).append("<div id='" + bigContainer + "'><div id='" + div_confirm + "'></div><div id='" + div_tree + "'></div></div>");

//        var container = $("#" + bigContainer);


//        container.find("#" + div_confirm).append("<input id='" + obj + "_dept_tree_confirm' type='button' value='确定'/>");
//        var $obj = $("#" + obj);
//        $obj.attr("readonly", true);
//        $obj.click(function() {
//            container.dialog("open");
//        });

//        $("#" + obj + "_dept_tree_confirm").click(function() {
//            var node = $.jstree._focused()._get_node();
//            var code = $(node).attr("id");
//            var name = treeTarget.jstree("get_text", node);
//            container.dialog("close");
//            callback(code, name);
//        });

//        var treeTarget = container.find("#" + div_tree);

//        treeTarget.jstree({
//            'plugins': ['themes', 'json_data', 'ui', 'crrm', 'cookies', 'dnd', 'search', 'types', 'hotkeys', 'contextmenu', 'unique'],
//            "json_data": {
//                "ajax": {
//                    "url": "/HR/GetDeptTree"
//                }
//            },
//            'themes': { 'theme': 'classic', 'url': '/Content/JsTreeThemes/classic/style.css', 'dots': false, 'icons': true },
//            'ui': { 'select_limit': 1, 'select_multiple_modifier': 'alt', 'selected_parent_close': 'select_parent' }

//        });
//        //数据控件事件绑定
//        treeTarget.bind('click.jstree', function(event) {
//            var eventNodeName = event.target.nodeName;
//            if (eventNodeName == 'INS') {
//                return;
//            } else if (eventNodeName == 'A') {
//                var $subject = $(event.target);
//                Common_Tree_Dict.CurNode = $subject;
//            }
//        });


//        //dialog 初始化
//        container.dialog({ autoOpen: false });

//    }
//}



//var Common_EmpTree_Dept = {
//    setupGrid: function(grid, pager, search) {
//        $(grid).jqGrid({
//            url: "/HR/List/",
//            mtype: "post",
//            datatype: "json",
//            colNames: ['员工编码', '员工名称', '英文名', '职务', '职称'],
//            colModel: [

//                        { name: 'Stuff_Code', index: 'Stuff_Code', width: 100, align: 'center', sortable: false, hidden: false },
//                        { name: 'Stuff_Name', index: 'StuffName', width: 100, align: 'center', sortable: false, hidden: false },
//                        { name: 'Stuff_ENName', index: 'StuffENName', width: 100, align: 'center', sortable: false, hidden: false },
//                        { name: 'Stuff_Duty', index: 'StuffDuty', width: 100, align: 'center', sortable: false, hidden: false },
//                        { name: 'Stuff_Title', index: 'Stuff_Title', width: 100, sortable: true, hidden: false }
//            //                        ,{ name: 'Stuff_Director', index: 'Stuf_Director', width: 40, align: 'center', sortable: false, hidden: false },
//            //                        { name: 'Stuff_DepName', index: 'Stuff_DepName', width: 50, align: 'center', sortable: false, hidden: false },
//            //                        { name: 'Stuff_Mobile', index: 'Stuff_Mobile', width: 50, align: 'center', sortable: false, hidden: false },
//            //                        { name: 'Stuff_Email', index: 'Stuff_Email', width: 50, align: 'center', sortable: false, hidden: false }
//                      ],
//            rowNum: 10,
//            rowList: [10, 20, 50],
//            pager: $(pager),
//            sortname: 'StuffName',
//            sortorder: "asc",
//            viewrecords: true,
//            multiselect: false,
//            autowidth: false,
//            rownumbers: true,
//            gridview: true,
//            caption: '员工信息列表',
//            footerrow: false,
//            userDataOnFooter: true
//        }).navGrid(pager, { refresh: true, edit: false, add: false, del: false, search: true });


//    },
//    Init: function(obj, callback) {
//        var bigContainer = obj + "_modalDeptTreeContainer";
//        var div_tree = obj + "_dept_div_tree";
//        var div_confirm = obj + "_dept_div_confirm";

//        var div_search = obj + "_search";
//        var div_grid = obj + "_grid";
//        var div_pager = obj + "_pager";

//        $(document.body).append("<div id='" + bigContainer + "'><div id='" + div_confirm + "'></div><div id='" + div_tree + "' style='width:150px;float:left;'></div><div style='margin-left:155px;'><div id='" + div_search + "'></div><table id='" + div_grid + "' class='scroll' cellpadding='0' cellspacing='0'></table><div id='" + div_pager + "' class='scroll' style='text-align: center;'></div></div></div>");

//        var container = $("#" + bigContainer);
//        //ShowMsg(container.html());

//        container.find("#" + div_confirm).append("<input id='" + obj + "_dept_tree_confirm' type='button' value='确定'/>");

//        //目标控件事件
//        var $obj = $("#" + obj);
//        $obj.attr("readonly", true);
//        $obj.click(function() {
//            container.dialog("open");
//        });


//        var treeTarget = container.find("#" + div_tree);
//        //树控件初始化
//        treeTarget.jstree({
//            'plugins': ['themes', 'json_data', 'ui', 'crrm', 'cookies', 'dnd', 'search', 'types', 'hotkeys', 'contextmenu', 'unique'],
//            "json_data": {
//                "ajax": {
//                    "url": "/HR/GetDeptTree"
//                }
//            },
//            'themes': { 'theme': 'classic', 'url': '/Content/JsTreeThemes/classic/style.css', 'dots': false, 'icons': true },
//            'ui': { 'select_limit': 1, 'select_multiple_modifier': 'alt', 'selected_parent_close': 'select_parent' }

//        });



//        //Grid初始化
//        var gridTarget = container.find("#" + div_grid);
//        var pagerTarget = container.find("#" + div_pager);
//        var searchTarget = container.find("#" + div_search);
//        Common_EmpTree_Dept.setupGrid("#" + div_grid, "#" + div_pager, "#" + div_search);


//        //数据控件事件绑定
//        treeTarget.bind('click.jstree', function(event) {
//            var eventNodeName = event.target.nodeName;
//            if (eventNodeName == 'INS') {
//                return;
//            } else if (eventNodeName == 'A') {
//                var node = $.jstree._focused()._get_node();
//                var deptcode = $(node).attr("id");

//                //读取数据的方法
//                gridTarget.setGridParam({ url: '/HR/List/' + deptcode });
//                gridTarget.trigger("reloadGrid");

//            }
//        });

//        //确定按钮事件
//        $("#" + obj + "_dept_tree_confirm").click(function() {
//            var s;
//            s = gridTarget.jqGrid('getGridParam', 'selrow');
//            var ret = gridTarget.jqGrid('getRowData', s);
//            callback(ret.Stuff_Code, ret.Stuff_Name);
//        });


//        //dialog 初始化
//        container.dialog({ autoOpen: false, width: 800 });

//    }
//}