

var Common_Supplier_List = {
    setupGrid: function(grid, pager, search) {
        $(grid).jqGrid({
            url: "/Supply/GetSupplierList",
            mtype: "post",
            datatype: "json",
            colNames: ['供应商编码', '供应商名称', '联系人', '座机', '手机', '电子邮件'],
            colModel: [{ name: 'WHS_CustCode', index: 'WHS_CustCode', width: 100, align: 'center', sortable: false, hidden: false },
{ name: 'WHS_CustName', index: 'WHS_CustName', width: 100, align: 'center', sortable: false, hidden: false },
{ name: 'WHS_ContactPerson', index: 'WHS_ContactPerson', width: 100, align: 'center', sortable: false, hidden: false },
{ name: 'WHS_Telphone', index: 'WHS_Telphone', width: 100, align: 'center', sortable: false, hidden: false },
{ name: 'WHS_MobilePhone', index: 'WHS_MobilePhone', width: 100, align: 'center', sortable: false, hidden: false },
{ name: 'WHS_Email', index: 'WHS_Email', width: 100, align: 'center', sortable: false, hidden: false}],
            rowNum: 10,
            rowList: [10, 20, 50],
            pager: $(pager),
            sortname: 'PUM_RCode',
            sortorder: "asc",
            width: '800',
            viewrecords: true,
            multiselect: false,
            autowidth: false,
            rownumbers: true,
            gridview: true,
            caption: '供应商列表',
            footerrow: false,
            userDataOnFooter: true
        }).navGrid(pager, { refresh: true, edit: false, add: false, del: false, search: true });


    }, //obj 目标控件id
    Init: function(obj, callback) {

        var bigContainer = obj + "_modalSupContainer";
        //        var div_tree = obj + "_dept_div_tree";
        var div_confirm = obj + "_sup_div_confirm";

        var div_search = obj + "_search";
        var div_grid = obj + "_grid";
        var div_pager = obj + "_pager";

        $(document.body).append("<div id='" + bigContainer + "'><table width='100%'><tr><td><div style='width:550px;' ><div id='" + div_search + "'></div><table id='" + div_grid + "' class='scroll' cellpadding='0' cellspacing='0'></table><div id='" + div_pager + "' class='scroll' style='text-align: center;'></div></div></td></tr><tr><td colspan='2' align='right'><div id='" + div_confirm + "'></div></tr></table></div>");

        var container = $("#" + bigContainer);
        //ShowMsg(container.html());

        container.find("#" + div_confirm).append("<input id='" + obj + "_sup_confirm' type='button' value='确定'/>");

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
        
        Common_Supplier_List.setupGrid("#" + div_grid, "#" + div_pager, "#" + div_search);

        //读取数据的方法
        //        gridTarget.setGridParam({ url: '/PU/PUMainList/'});
        gridTarget.trigger("reloadGrid");

        //确定按钮事件
        $("#" + obj + "_sup_confirm").click(function() {
            var s;
            s = gridTarget.jqGrid('getGridParam', 'selrow');
            var ret = gridTarget.jqGrid('getRowData', s);
            container.dialog("close");
            callback(ret.WHS_CustCode, ret.WHS_CustName, ret.WHS_ContactPerson, ret.WHS_MobilePhone);
        });


        //dialog 初始化
        container.dialog({ autoOpen: false, width: 830 });

    }
}
