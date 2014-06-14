
var Common_Material_List = {
    setupGrid: function(grid, pager, search) {
        $(grid).jqGrid({
            url: "/Material/MaterialList",
            mtype: "post",
            datatype: "json",
            colNames: ['所属公司编码', '所属公司', '仓库号', '仓库编码', '仓库', '货位', '物料编码', '物料名称', '库存数量', '计量单位', '单价', '规格型号'],
            colModel: [
{ name: 'Storage_CompanyCode', index: 'Storage_CompanyCode', width: 100, align: 'center', sortable: false, hidden: true },
{ name: 'Storage_Company', index: 'Storage_WarehouseNo', width: 100, align: 'center', sortable: false, hidden: false },
{ name: 'Storage_WarehouseNo', index: 'Storage_WarehouseNo', width: 100, align: 'center', sortable: false, hidden: true },
{ name: 'Storage_Code', index: 'Storage_Code', width: 100, align: 'center', sortable: false, hidden: true },
{ name: 'Storage_Name', index: 'Storage_Name', width: 100, align: 'center', sortable: false, hidden: false },
{ name: 'Storage_WarehouseNoName', index: 'Storage_WarehouseNoName', width: 100, align: 'center', sortable: false, hidden: false },

{ name: 'MD_MCode', index: 'MD_MCode', width: 100, align: 'center', sortable: false, hidden: true },
{ name: 'MD_Name', index: 'MD_Name', width: 100, align: 'center', sortable: false, hidden: false },
{ name: 'Storage_Count', index: 'Storage_Count', width: 100, align: 'center', sortable: false, hidden: false },
{ name: 'MD_Unit', index: 'MD_Unit', width: 100, align: 'center', sortable: false, hidden: false },
{ name: 'MD_PriceList', index: 'MD_PriceList', width: 100, align: 'center', sortable: false, hidden: false },
{ name: 'MD_Spec', index: 'MD_Spec', width: 100, align: 'center', sortable: false, hidden: false}],
            rowNum: 0,
            rowList: [5, 10, 20, 50],
            pager: $(pager),
            sortname: 'PUM_RCode',
            sortorder: "asc",
            width: '750',
            viewrecords: true,
            multiselect: false,
            autowidth: false,
            rownumbers: true,
            gridview: true,
            caption: '物料列表',
            footerrow: false,
            ondblClickRow: function(rowid, iRow, iCol, e) {
                var s = iRow;
                //                s = gridTarget.jqGrid('getGridParam', 'selrow');
                var ret = $(grid).jqGrid('getRowData', s);
                //                ShowMsg(Common_Material_List.CallBack);
                //                container.dialog("close");
                if (Common_Material_List.CallBack != null) {
                    Common_Material_List.CallBack(ret.MD_MCode, ret.MD_Name, ret.MD_Spec, ret.MD_Unit, ret.MD_PriceList, ret);
                }
            },
            userDataOnFooter: true
        }).navGrid(pager, { refresh: true, edit: false, add: false, del: false, search: false });


    },
    CallBack: null,
    //obj 目标控件id
    IndependenceInit: function(obj, callback) {

        var bigContainer = obj + "_modalMaterialContainer";
        //        var div_tree = obj + "_dept_div_tree";
        var div_confirm = obj + "_Material_div_confirm";

        var div_search = obj + "_search";
        var div_grid = obj + "_grid";
        var div_pager = obj + "_pager";

        $(document.body).append("<div id='" + bigContainer + "'><table><tr><td><div style='width:550px;' ><div id='" + div_search + "'></div><table id='" + div_grid + "' class='scroll' cellpadding='0' cellspacing='0'></table><div id='" + div_pager + "' class='scroll' style='text-align: center;'></div></div></td></tr><tr><td colspan='2'><div id='" + div_confirm + "'></div></tr></table></div>");

        var container = $("#" + bigContainer);
        //ShowMsg(container.html());
        //PUD_MCode_Material_Search_btn
        container.find("#" + div_confirm).append("<input id='" + obj + "_Material_confirm' type='button' value='确定'/> <input id='" + obj + "_Material_Close' type='button' value='关闭'/>");

        //目标控件事件
        var $obj = $("#" + obj);
        $obj.attr("readonly", true);
        $obj.click(function() {
            container.dialog("open");
        });


        //Grid初始化
        var gridTarget = container.find("#" + div_grid);
        var pagerTarget = container.find("#" + div_pager);
        var searchTarget = container.find("#" + div_search);
        Common_Material_List.setupGrid("#" + div_grid, "#" + div_pager, "#" + div_search);

        //读取数据的方法
        //        gridTarget.setGridParam({ url: '/PU/PUMainList/'});
        //        gridTarget.trigger("reloadGrid");

        //确定按钮事件
        $("#" + obj + "_Material_confirm").click(function() {
            var s;
            s = gridTarget.jqGrid('getGridParam', 'selrow');
            var ret = gridTarget.jqGrid('getRowData', s);
            container.dialog("close");
            callback(ret.MD_MCode, ret.MD_Name);
        });
        
        $("#" + obj + "_Material_Close").click(function() {
            container.dialog('close');
        });


        //dialog 初始化
        container.dialog({ autoOpen: false, width: 800 });

    },
    GridTarget: null,
    CurRType: '', //对象id  容器   自身类型    回调 公司
    DependInit: function(obj, containerOuter, rtype, callback, company) {


        Common_Material_List.CallBack = callback;

        var bigContainer = obj + "_modalMaterialContainer";

        var div_confirm = obj + "_Material_div_confirm";

        var div_search = obj + "_search";
        var div_grid = obj + "_grid";
        var div_pager = obj + "_pager";


        var txtSearch = obj + "_Material_Search_txt";
        var btnSearch = obj + "_Material_Search_btn";

        $("#" + containerOuter).prepend("<div id='" + bigContainer + "'><table><tr><td colspan='2'><span id='" + div_confirm + "'></span></tr><tr><td><div style='width:550px;' ><div id='" + div_search + "'></div><table id='" + div_grid + "' class='scroll' cellpadding='0' cellspacing='0'></table><div id='" + div_pager + "' class='scroll' style='text-align: center;'></div></div></td></tr></table></div>");

        var container = $("#" + bigContainer);

        container.find("#" + div_confirm).append("<div id='SearchTool'><label class='form_label'>查找关键字:</label><span class='div_texbox'><input type='text' class='form_textbox' id='" + txtSearch + "'/><input type='button' id='" + btnSearch + "' value='查找'/></span></div>");

        //Grid初始化
        var gridTarget = container.find("#" + div_grid);
        var pagerTarget = container.find("#" + div_pager);
        var searchTarget = container.find("#" + div_search);

        //当前单据类型
        Common_Material_List.CurRType = rtype;

        if (typeof (Common_Material_ListBody) != "undefined") {
            Common_Material_ListBody.setupGrid("#" + div_grid, "#" + div_pager, "#" + div_search);
        } else {
            Common_Material_List.setupGrid("#" + div_grid, "#" + div_pager, "#" + div_search);
        }

        Common_Material_List.GridTarget = gridTarget;

        //确定按钮事件
        $("#" + btnSearch).click(function() {
                  
            var key = container.find("#" + txtSearch).val();
            if (key == "" || key == undefined) {
                key = "nokey";
            }
            gridTarget.setGridParam({ url: '/Material/MaterialList/' + key + "-" + Common_Material_List.CurRType + '?compnay=' + company });
            gridTarget.setGridParam({ page: 1 });
            gridTarget.trigger("reloadGrid");
            
        });
    },
    SearchGrid: function(key, company) {
        if (Common_Material_List.GridTarget != null) {
            Common_Material_List.GridTarget.setGridParam({ rowNum: 5 });
            Common_Material_List.GridTarget.setGridParam({ url: '/Material/MaterialList/' + key + "-" + Common_Material_List.CurRType + '?company=' + company });
            Common_Material_List.GridTarget.trigger("reloadGrid");
        }
    }
}
