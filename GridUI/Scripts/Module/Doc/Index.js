$(document).ready(function() {
    Doc_Info_GridControl.Init("/Doc/List", "");
});
var Doc_Info_GridControl = {
    setupDoc_InfoGrid: function(grid, pager, search, dataurl) {
        grid.jqGrid({
            url: dataurl,
            mtype: "post",
            rowNum: 10,
            rowList: [10, 20, 50],
            pager: pager,
            sortorder: "asc",
            viewrecords: true,
            multiselect: false,
            width: '100%',
            height: '100%',
            autowidth: true,
            rownumbers: true,
            gridview: true,
            caption: '信息列表',
            footerrow: false,
            colNames: ['操作', '文档信息', '文档编号', '文档名称', '', '文档描述', '文档地址', '文档开始生效时间', '文档失效时间', '文档提醒提前期', '文档当前状态', '文档下一审核节点'],
            colModel: [
            { name: 'Edit', index: 'Edit', width: 100, align: 'center', sortable: false, hidden: false },
            { name: 'Doc_ID', index: 'Doc_ID', width: 100, align: 'center', sortable: false, hidden: false },
            { name: 'Doc_Type', index: 'Doc_Type', width: 100, align: 'center', sortable: false, hidden: false },
            { name: 'Doc_Code', index: 'Doc_Code', width: 100, align: 'center', sortable: false, hidden: false },
            { name: 'Doc_Title', index: 'Doc_Title', width: 100, align: 'center', sortable: false, hidden: false },
            { name: 'Doc_Desp', index: 'Doc_Desp', width: 100, align: 'center', sortable: false, hidden: false },
            { name: 'Doc_Path', index: 'Doc_Path', width: 100, align: 'center', sortable: false, hidden: false },
            { name: 'Doc_StartTime', index: 'Doc_StartTime', width: 100, align: 'center', sortable: false, hidden: false },
            { name: 'Doc_FailureTime', index: 'Doc_FailureTime', width: 100, align: 'center', sortable: false, hidden: false },
            { name: 'Doc_Remind', index: 'Doc_Remind', width: 100, align: 'center', sortable: false, hidden: false },
            { name: 'Doc_Stat', index: 'Doc_Stat', width: 100, align: 'center', sortable: false, hidden: false },
            { name: 'Doc_NextAudit', index: 'Doc_NextAudit', width: 100, align: 'center', sortable: false, hidden: false}],
            gridComplete: function() {
                var ids = grid.jqGrid('getDataIDs');
                for (var i = 0; i < ids.length; i++) {
                    var cl = ids[i];
                    var ret = grid.jqGrid('getRowData', cl);
                    var create = "<a href='Create'>添加</a>&nbsp;";
                    be = "<a href='/Doc/Edit/" + ret.Doc_Code + "'>编辑</a>";
                    grid.jqGrid('setRowData', ids[i], { Edit: create + be });
                }
            },
            userDataOnFooter: true
        });
    },
    Init: function(dataurl, targetPreFix) {
        var gridobj = targetPreFix + 'grid';
        var pagerobj = targetPreFix + 'pager';
        var searchobj = targetPreFix + 'search'
        Doc_Info_GridControl.setupDoc_InfoGrid($('#' + gridobj), $('#' + pagerobj), $('#' + searchobj), dataurl);
    }
}
