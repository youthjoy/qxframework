using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;

using QX.Comm;
using QX.HtmlHelperLib.Model;
using QX.HtmlHelperLib.DAL;
using Newtonsoft.Json;
using QX.Config;

namespace QX.HtmlHelperLib
{
    public static class ReferConfig
    {
        /// <summary>
        /// 生成通用参考代码
        /// </summary>
        /// <param name="helper"></param>
        /// <param name="ModuleName"></param>
        /// <param name="NameSpace"></param>
        /// <returns></returns>
        public static string ReferControl(
            this HtmlHelper helper,
            string ModuleName,
            string NameSpace)
        {
            string str = string.Empty;

            ADOSys_Config_Refer ReferInstance = new ADOSys_Config_Refer();
            ADOSys_Config_Field_Refer DListInstance = new ADOSys_Config_Field_Refer();
            if (string.IsNullOrEmpty(ModuleName) || string.IsNullOrEmpty(NameSpace))
            {
                return string.Empty;
            }
            Sys_Config_Refer MRefer = ReferInstance.GetListByWhere(" AND R_ModuleName='" +
                ModuleName + "'")[0];
            List<Sys_Config_Field_Refer> D_List = DListInstance.GetListByWhere(" AND D_ModuleName='" +
                ModuleName + "'");

            #region JqGrid Html 列表显示部分
            string html = @"
            <div class='Comm_Ref' id='{ModuleName}{M_NameSpace}' style='display:none'>
                {ToolBar}   
                <div id='{M_NameSpace}search'>
                </div>
                <table id='{M_NameSpace}grid'' class='scroll' cellpadding='0' cellspacing='0'>
                </table>
                <div id='{M_NameSpace}pager' class='scroll' style='text-align: center;'>
                </div> 
                <div style='float:right;padding-top:20px'> 
                    <span> <input id='btnok_{M_NameSpace}' type='button' value='确定'/> <input type='button' value='关闭' onclick='{M_NameSpace}Close()'/> </span>  
                </div>   
            </div>";
            #endregion

            #region JqGrid Js部分
            string js_header = @"<script type='text/javascript'>";
            string js_footer = @"</script>";
            string jsBody = @"            
            var {M_NameSpace}_{ModuleName}_GridControl = {
                setupGrid: function(grid, pager, search, dataurl) {   
                    grid.jqGrid({
                        url: dataurl,
                        mtype: 'post',
                        rowNum: 10,
                        rowList: [10,20,50],
                        pager: pager,
                        sortorder: 'asc',
                        viewrecords: true,
                        multiselect: false, //多选时出现checkbox
                        width: '{M_Width}',
                        height: '{M_Height}',
                        autowidth: false,
                        rownumbers: true,
                        gridview: true,
                        footerrow: false,
                        colNames: [{M_ColNames_list}],
                        colModel: [{M_ColModel_List}],
                        gridComplete: function() {
                            var ids = grid.jqGrid('getDataIDs');
                            for (var i = 0; i < ids.length; i++) {
                                var cl = ids[i];
                                var ret = grid.jqGrid('getRowData', cl);
                                var operation='';
                                {M_GridComplete}                             
                                grid.jqGrid('setRowData', ids[i], { Edit: operation });
                            }
                        },
                        userDataOnFooter: true
                    })
                },
                Init: function(dataurl, targetPreFix) {
                    var gridobj = targetPreFix + 'grid';
                    var pagerobj = targetPreFix + 'pager';
                    var searchobj = targetPreFix + 'search';        
                    {M_NameSpace}_{ModuleName}_GridControl.setupGrid($('#' + gridobj), $('#' + pagerobj), $('#' + searchobj), dataurl);
                    $('#' + gridobj).navGrid('#'+pagerobj, { refresh: false, edit: false, add: false, del: false, search:false,multipleSearch:false });
                } 
            }
            ";
            #endregion

            #region JqGrid调用部分
            string callJs = @"
            <script type='text/javascript'>
                var {M_NameSpace};
                $(document).ready(function() {
                   {M_NameSpace}_{ModuleName}_GridControl.Init('{M_URL}','{M_NameSpace}');
                   //初始化层
                   $('#{ModuleName}{M_NameSpace}').dialog({ autoOpen: false, width: {Width}, height: {Height},title:'{M_Title}' });    
                   //$('#{M_NameSpace}grid').jqGrid('filterGrid','#{M_NameSpace}grid', { multipleSearch:true } );

                    $('#btnok_{M_NameSpace}').click(function(){
                             var grid = $('#{M_NameSpace}grid');
                             var curid = grid.getGridParam('selrow'); //获取选择行的id 
                             var data = grid.getRowData(curid); //获取行号为curid的数据
                             if(curid==null) return;                             
                             {M_NameSpace}(data);   
                             $('#{ModuleName}{M_NameSpace}').dialog('close');
                    });   
                });
                
                function {ModuleName}{M_NameSpace}OpenRefer(callback){
                    $('#{ModuleName}{M_NameSpace}').dialog('open');       
                    {M_NameSpace}=callback;                
                }
                
                function {ModuleName}{M_NameSpace}OpenRefer(ModuleName,NameSpace,callback){
                    $('#{ModuleName}{M_NameSpace}').dialog('open');       
                    {M_NameSpace}=callback;                
                }
                
                function {ModuleName}{M_NameSpace}OpenReferWithFilter(_filter,callback){                    
                    var _url='/Sys_Config_Refer/GetData/?name={Table}&m={ModuleName}&n={M_NameSpace}&filter='+_filter;
                    $('#{M_NameSpace}grid').setGridParam({ url: _url });
                    $('#{M_NameSpace}grid').trigger('reloadGrid');   
                    {M_NameSpace}=callback;                                   
                }


                function {M_NameSpace}Close(){
                    $('#{ModuleName}{M_NameSpace}').dialog('close');
                }     
                
                function {ModuleName}ToolBarSearch(){
                    $('#{M_NameSpace}grid').jqGrid('searchGrid', { multipleSearch:true } );
                }
                          
            </script>
            ";
            #endregion

            #region 生成列头
            string strColNames = string.Empty;
            D_List = D_List.OrderBy(o => o.D_Order).ToList();
            for (int i = 0; i < D_List.Count; i++)
            {
                if (i != (D_List.Count - 1))
                {
                    strColNames += "'" + D_List[i].D_Name.Trim() + "'" + ",";
                }
                else
                {
                    strColNames += "'" + D_List[i].D_Name.Trim() + "'";
                }
            }

            #endregion

            #region 生成列详细配置
            StringBuilder header = new StringBuilder();
            string header_template = @"{ name: '{D_Index}',index: '{D_Index}', align: 'center', {D_Hidden} searchoptions:{ sopt: ['eq', 'ne', 'cn'] } }";
            string header_template_fix = ",";
            for (var m = 0; m < D_List.Count; m++)
            {
                string tmpFix = m != (D_List.Count - 1) ? header_template_fix : "";
                header.AppendLine(header_template
                    .Replace("{D_Name}", D_List[m].D_Name.Trim())
                    .Replace("{D_Index}", D_List[m].D_Index.Trim())
                    .Replace("{D_Hidden}", !string.IsNullOrEmpty(D_List[m].D_Hidden) ? "hidden:" + D_List[m].D_Hidden + "," : "")
                    + tmpFix);
            }
            #endregion

            string url = string.Empty;
            if (!string.IsNullOrEmpty(MRefer.R_Url))
            {
                url = MRefer.R_Url;
            }
            else
            {
                url = string.Format("/Sys_Config_Refer/GetData/?name={0}&m={1}&n={2}",
                                                   MRefer.R_TableName, ModuleName, NameSpace);
            }

            str += html;
            str += js_header + jsBody + js_footer;
            str += callJs;

            str = str
                .Replace("{ModuleName}", ModuleName)
                .Replace("{M_NameSpace}", NameSpace)
                .Replace("{Width}", MRefer.R_Width.ToString())
                .Replace("{Height}", MRefer.R_Height.ToString())
                .Replace("{M_Width}", (MRefer.R_Width * 0.93).ToString())
                .Replace("{M_Height}", (MRefer.R_Height * 0.4).ToString())
                .Replace("{M_Title}", MRefer.R_Title)
                .Replace("{M_ColNames_list}", strColNames)
                .Replace("{M_ColModel_List}", header.ToString())
                .Replace("{M_GridComplete}", "")
                .Replace("{M_URL}", url)
                .Replace("{Width}", "")
                .Replace("{Height}", "")
                .Replace("{ToolBar}", helper.Common_ToolBarForListPage(ModuleName, "",
                "'add':'hidden','edit':'hidden','del':'hidden','import':'hidden','export':'hidden',view:'hidden'"));

            return str;
        }

        /// <summary>
        /// 生成通用参考代码
        /// </summary>
        /// <param name="helper"></param>
        /// <param name="ModuleName"></param>
        /// <param name="NameSpace"></param>
        /// <returns></returns>
        public static string ReferControl(
            this HtmlHelper helper,
            string ModuleName,
            string NameSpace, bool Multiselect)
        {
            string str = string.Empty;

            ADOSys_Config_Refer ReferInstance = new ADOSys_Config_Refer();
            ADOSys_Config_Field_Refer DListInstance = new ADOSys_Config_Field_Refer();
            if (string.IsNullOrEmpty(ModuleName) || string.IsNullOrEmpty(NameSpace))
            {
                return string.Empty;
            }

            Sys_Config_Refer MRefer = ReferInstance.GetListByWhere(" AND R_ModuleName='" +
                ModuleName + "'")[0];
            List<Sys_Config_Field_Refer> D_List = DListInstance.GetListByWhere(" AND D_ModuleName='" +
                ModuleName + "'");

            #region JqGrid Html 列表显示部分
            string html = @"
            <div class='Comm_Ref' id='{ModuleName}{M_NameSpace}' style='display:none'>
                {ToolBar}   
                <div id='{M_NameSpace}search'>
                </div>
                <table id='{M_NameSpace}grid'' class='scroll' cellpadding='0' cellspacing='0'>
                </table>
                <div id='{M_NameSpace}pager' class='scroll' style='text-align: center;'>
                </div> 
                <div style='float:right;padding-top:20px'> 
                    <span> <input id='btnok_{M_NameSpace}' type='button' value='确定'/> <input type='button' value='关闭' onclick='{M_NameSpace}Close()'/> </span>  
                </div>   
            </div>";
            #endregion

            #region JqGrid Js部分
            string js_header = @"<script type='text/javascript'>";
            string js_footer = @"</script>";
            string jsBody = @"            
            var {M_NameSpace}_{ModuleName}_GridControl = {
                setupGrid: function(grid, pager, search, dataurl) {   
                    grid.jqGrid({
                        url: dataurl,
                        mtype: 'post',
                        rowNum: 10,
                        rowList: [10,20,50],
                        pager: pager,
                        sortorder: 'asc',
                        viewrecords: true,
                        multiselect: {MultiSelect}, //多选时出现checkbox
                        width: '{M_Width}',
                        height: '{M_Height}',
                        autowidth: false,
                        rownumbers: true,
                        gridview: true,
                        footerrow: false,
                        colNames: [{M_ColNames_list}],
                        colModel: [{M_ColModel_List}],
                        gridComplete: function() {
                            var ids = grid.jqGrid('getDataIDs');
                            for (var i = 0; i < ids.length; i++) {
                                var cl = ids[i];
                                var ret = grid.jqGrid('getRowData', cl);
                                var operation='';
                                {M_GridComplete}                             
                                grid.jqGrid('setRowData', ids[i], { Edit: operation });
                            }
                        },
                        userDataOnFooter: true
                    })
                },
                Init: function(dataurl, targetPreFix) {
                    var gridobj = targetPreFix + 'grid';
                    var pagerobj = targetPreFix + 'pager';
                    var searchobj = targetPreFix + 'search';        
                    {M_NameSpace}_{ModuleName}_GridControl.setupGrid($('#' + gridobj), $('#' + pagerobj), $('#' + searchobj), dataurl);
                    $('#' + gridobj).navGrid('#'+pagerobj, { refresh: false, edit: false, add: false, del: false, search:false,multipleSearch:false });
                } 
            }
            ";
            #endregion


            string btnMJs = @"
                         $('#btnok_{M_NameSpace}').click(function(){
                                var grid = $('#{M_NameSpace}grid');
                                var curids = grid.getGridParam('selarrrow'); //获取选择行的id 
                                if(curids!=''){
                                var ids=new Array();
                                var selectRows=new Array();
                                //selectRows.length=0;
                                ids=curids.toString().split(',');
                                for(var i=0;i<ids.length;i++){
                                        var data = grid.getRowData(ids[i]); //获取行号为curid的数据
                                        if(data!=null){
                                            selectRows.push(data);
                                        }
                                }
                                {M_NameSpace}callback(selectRows);                
                                $('#{ModuleName}{M_NameSpace}').dialog('close');
                        } 
                       });
";
            string btnSJs = @"    
                     $('#btnok_{M_NameSpace}').click(function(){
                             var grid = $('#{M_NameSpace}grid');
                             var curid = grid.getGridParam('selrow'); //获取选择行的id 
                             var data = grid.getRowData(curid); //获取行号为curid的数据
                             if(curid==null) return;                             
                             {M_NameSpace}callback(data);   
                             $('#{ModuleName}{M_NameSpace}').dialog('close');
                    });  
";

            //0131 YSW
            #region JqGrid调用部分
            string callJs = @"
            <script type='text/javascript'>
                var {M_NameSpace}callback;
                $(document).ready(function() {
                   {M_NameSpace}_{ModuleName}_GridControl.Init('{M_URL}','{M_NameSpace}');
                   //初始化层
                   $('#{ModuleName}{M_NameSpace}').dialog({ autoOpen: false, width: {Width}, height: {Height},title:'{M_Title}' });    
                   //$('#{M_NameSpace}grid').jqGrid('filterGrid','#{M_NameSpace}grid', { multipleSearch:true } );
                    
                    {BtnJs}

                });
                function {ModuleName}{M_NameSpace}OpenRefer(callback){
                    $('#{ModuleName}{M_NameSpace}').dialog('open');     
                    {M_NameSpace}callback=callback;                             
                }
                
                function {ModuleName}{M_NameSpace}OpenReferWithFilter(_filter,callback){                    
                    var _url={filterUrl};
                    var refGrid=$('#{M_NameSpace}grid');
                    refGrid.setGridParam({ url: _url });
                    refGrid.trigger('reloadGrid');     
                    $('#{ModuleName}{M_NameSpace}').dialog('open');           
                    {M_NameSpace}callback=callback;                
                }


                function {M_NameSpace}Close(){
                    $('#{ModuleName}{M_NameSpace}').dialog('close');
                }     
                
                function {ModuleName}ToolBarSearch(){
                    $('#{M_NameSpace}grid').jqGrid('searchGrid', { multipleSearch:true } );
                }
                          
            </script>
            ";
            #endregion

            #region 生成列头
            string strColNames = string.Empty;
            D_List = D_List.OrderBy(o => o.D_Order).ToList();
            for (int i = 0; i < D_List.Count; i++)
            {
                if (i != (D_List.Count - 1))
                {
                    strColNames += "'" + D_List[i].D_Name.Trim() + "'" + ",";
                }
                else
                {
                    strColNames += "'" + D_List[i].D_Name.Trim() + "'";
                }
            }
            #endregion

            #region 生成列详细配置
            StringBuilder header = new StringBuilder();
            string header_template = @"{ name: '{D_Index}',width:100,index: '{D_Index}', align: 'center', {D_Hidden} searchoptions:{ sopt: ['eq', 'ne', 'cn'] } }";
            string header_template_fix = ",";
            for (var m = 0; m < D_List.Count; m++)
            {
                string tmpFix = m != (D_List.Count - 1) ? header_template_fix : "";
                header.AppendLine(header_template
                    .Replace("{D_Name}", D_List[m].D_Name.Trim())
                    .Replace("{D_Index}", D_List[m].D_Index.Trim())
                    .Replace("{D_Hidden}", !string.IsNullOrEmpty(D_List[m].D_Hidden) ? "hidden:" + D_List[m].D_Hidden + "," : "")
                    + tmpFix);
            }
            #endregion


            str += html;
            str += js_header + jsBody + js_footer;
            str += callJs;

            string url = string.Empty;
            string filter = string.Empty;
            if (!string.IsNullOrEmpty(MRefer.R_Url))
            {
                url = MRefer.R_Url;
                filter = "'"+MRefer.R_Url+"?filter='+_filter";
            }
            else
            {
                url = string.Format("/Sys_Config_Refer/GetData/?name={0}&m={1}&n={2}", MRefer.R_TableName, MRefer.R_ModuleName, MRefer.R_NameSpace);
                filter="'/Sys_Config_Refer/GetData/?name="+MRefer.R_TableName+"&m="+MRefer.R_ModuleName+"&n="+MRefer.R_NameSpace+"&filter='+_filter"; 
            }

            
            

            str = str
                .Replace("{BtnJs}", Multiselect ? btnMJs : btnSJs)
                .Replace("{ModuleName}", ModuleName)
                .Replace("{M_NameSpace}", NameSpace)
                .Replace("{Width}", MRefer.R_Width.ToString())
                .Replace("{Height}", MRefer.R_Height.ToString())
                .Replace("{M_Width}", (MRefer.R_Width * 0.93).ToString())
                .Replace("{M_Height}", (MRefer.R_Height * 0.4).ToString())
                .Replace("{M_Title}", MRefer.R_Title)
                .Replace("{M_ColNames_list}", strColNames)
                .Replace("{M_ColModel_List}", header.ToString())
                .Replace("{M_GridComplete}", "")
                .Replace("{M_URL}", url)
                .Replace("{filterUrl}",filter)
                .Replace("{Width}", "")
                .Replace("{Height}", "")
                .Replace("{Table}", MRefer.R_TableName)
                .Replace("{MultiSelect}",Multiselect?"true":"false")
                .Replace("{ToolBar}", helper.Common_ToolBarForListPage(ModuleName,"",
                "'add':'hidden','edit':'hidden','del':'hidden','import':'hidden','export':'hidden',view:'hidden'"));
              // .Replace("{ToolBar}", helper.GenToolbarHelper(ModuleName,NameSpace,
               // ""));
          
            return str;
        }


        public static string ReferControlEx(
        this HtmlHelper helper,
        string ModuleName,
        string NameSpace, bool Multiselect)
        {
            string str = string.Empty;

            ADOSys_Config_Refer ReferInstance = new ADOSys_Config_Refer();
            ADOSys_Config_Field_Refer DListInstance = new ADOSys_Config_Field_Refer();
            if (string.IsNullOrEmpty(ModuleName) || string.IsNullOrEmpty(NameSpace))
            {
                return string.Empty;
            }

            Sys_Config_Refer MRefer = ReferInstance.GetListByWhere(" AND R_ModuleName='" +
                ModuleName + "'")[0];
            List<Sys_Config_Field_Refer> D_List = DListInstance.GetListByWhere(" AND D_ModuleName='" +
                ModuleName + "'");

            #region JqGrid Html 列表显示部分
            string html = @"
            <div class='Comm_Ref' id='{ModuleName}{M_NameSpace}' style='display:none'>
                {ToolBar}   
                <div id='{M_NameSpace}search'>
                </div>
                <table id='{M_NameSpace}grid'' class='scroll' cellpadding='0' cellspacing='0'>
                </table>
                <div id='{M_NameSpace}pager' class='scroll' style='text-align: center;'>
                </div> 
                <div style='float:right;padding-top:20px'> 
                    <span> <input id='btnok_{M_NameSpace}' type='button' value='确定'/> <input type='button' value='关闭' onclick='{M_NameSpace}Close()'/> </span>  
                </div>   
            </div>";
            #endregion

            #region JqGrid Js部分
            string js_header = @"<script type='text/javascript'>";
            string js_footer = @"</script>";
            string jsBody = @"            
            var {M_NameSpace}_{ModuleName}_GridControl = {
                setupGrid: function(grid, pager, search, dataurl) {   
                    grid.jqGrid({
                        url: dataurl,
                        mtype: 'post',
                        rowNum: 10,
                        rowList: [10,20,50],
                        pager: pager,
                        sortorder: 'asc',
                        viewrecords: true,
                        multiselect: {MultiSelect}, //多选时出现checkbox
                        width: '{M_Width}',
                        height: '{M_Height}',
                        autowidth: false,
                        rownumbers: true,
                        gridview: true,
                        footerrow: false,
                        colNames: [{M_ColNames_list}],
                        colModel: [{M_ColModel_List}],
                        gridComplete: function() {
                            var ids = grid.jqGrid('getDataIDs');
                            for (var i = 0; i < ids.length; i++) {
                                var cl = ids[i];
                                var ret = grid.jqGrid('getRowData', cl);
                                var operation='';
                                {M_GridComplete}                             
                                grid.jqGrid('setRowData', ids[i], { Edit: operation });
                            }
                        },
                        userDataOnFooter: true
                    })
                },
                Init: function(dataurl, targetPreFix) {
                    var gridobj = targetPreFix + 'grid';
                    var pagerobj = targetPreFix + 'pager';
                    var searchobj = targetPreFix + 'search';        
                    {M_NameSpace}_{ModuleName}_GridControl.setupGrid($('#' + gridobj), $('#' + pagerobj), $('#' + searchobj), dataurl);
                    $('#' + gridobj).navGrid('#'+pagerobj, { refresh: false, edit: false, add: false, del: false, search:false,multipleSearch:false });
                } 
            }
            ";
            #endregion


            string btnMJs = @"
                         $('#btnok_{M_NameSpace}').click(function(){
                                var grid = $('#{M_NameSpace}grid');
                                var curids = grid.getGridParam('selarrrow'); //获取选择行的id 
                                if(curids!=''){
                                var ids=new Array();
                                var selectRows=new Array();
                                //selectRows.length=0;
                                ids=curids.toString().split(',');
                                for(var i=0;i<ids.length;i++){
                                        var data = grid.getRowData(ids[i]); //获取行号为curid的数据
                                        if(data!=null){
                                            selectRows.push(data);
                                        }
                                }
                                {M_NameSpace}callback(selectRows);                
                                $('#{ModuleName}{M_NameSpace}').dialog('close');
                        } 
                       });
";
            string btnSJs = @"    
                     $('#btnok_{M_NameSpace}').click(function(){
                             var grid = $('#{M_NameSpace}grid');
                             var curid = grid.getGridParam('selrow'); //获取选择行的id 
                             var data = grid.getRowData(curid); //获取行号为curid的数据
                             if(curid==null) return;                             
                             {M_NameSpace}callback(data);   
                             $('#{ModuleName}{M_NameSpace}').dialog('close');
                    });  
";

            //0131 YSW
            #region JqGrid调用部分
            string callJs = @"
            <script type='text/javascript'>
                var {M_NameSpace}callback;
                $(document).ready(function() {
                   {M_NameSpace}_{ModuleName}_GridControl.Init('{M_URL}','{M_NameSpace}');
                   //初始化层
                   $('#{ModuleName}{M_NameSpace}').dialog({ autoOpen: false, width: {Width}, height: {Height},title:'{M_Title}' });    
                   //$('#{M_NameSpace}grid').jqGrid('filterGrid','#{M_NameSpace}grid', { multipleSearch:true } );
                    
                    {BtnJs}

                });
                function {ModuleName}{M_NameSpace}OpenRefer(callback){
                    $('#{ModuleName}{M_NameSpace}').dialog('open');     
                    {M_NameSpace}callback=callback;                             
                }
                
                function {ModuleName}{M_NameSpace}OpenReferWithFilter(_filter,callback){                    
                    var _url={filterUrl};
                    var refGrid=$('#{M_NameSpace}grid');
                    refGrid.setGridParam({ url: _url });
                    refGrid.trigger('reloadGrid');     
                    $('#{ModuleName}{M_NameSpace}').dialog('open');           
                    {M_NameSpace}callback=callback;                
                }


                function {M_NameSpace}Close(){
                    $('#{ModuleName}{M_NameSpace}').dialog('close');
                }     
                
                function {M_NameSpace}ToolBarSearch(){
                    $('#{M_NameSpace}grid').jqGrid('searchGrid', { multipleSearch:true } );
                }
                          
            </script>
            ";
            #endregion

            #region 生成列头
            string strColNames = string.Empty;
            D_List = D_List.OrderBy(o => o.D_Order).ToList();
            for (int i = 0; i < D_List.Count; i++)
            {
                if (i != (D_List.Count - 1))
                {
                    strColNames += "'" + D_List[i].D_Name.Trim() + "'" + ",";
                }
                else
                {
                    strColNames += "'" + D_List[i].D_Name.Trim() + "'";
                }
            }
            #endregion

            #region 生成列详细配置
            StringBuilder header = new StringBuilder();
            string header_template = @"{ name: '{D_Index}',width:100,index: '{D_Index}', align: 'center', {D_Hidden} searchoptions:{ sopt: ['eq', 'ne', 'cn'] } }";
            string header_template_fix = ",";
            for (var m = 0; m < D_List.Count; m++)
            {
                string tmpFix = m != (D_List.Count - 1) ? header_template_fix : "";
                header.AppendLine(header_template
                    .Replace("{D_Name}", D_List[m].D_Name.Trim())
                    .Replace("{D_Index}", D_List[m].D_Index.Trim())
                    .Replace("{D_Hidden}", !string.IsNullOrEmpty(D_List[m].D_Hidden) ? "hidden:" + D_List[m].D_Hidden + "," : "")
                    + tmpFix);
            }
            #endregion


            str += html;
            str += js_header + jsBody + js_footer;
            str += callJs;

            string url = string.Empty;
            string filter = string.Empty;
            if (!string.IsNullOrEmpty(MRefer.R_Url))
            {
                url = MRefer.R_Url;
                filter = "'" + MRefer.R_Url + "?filter='+_filter";
            }
            else
            {
                url = string.Format("/Sys_Config_Refer/GetData/?name={0}&m={1}&n={2}", MRefer.R_TableName, MRefer.R_ModuleName, MRefer.R_NameSpace);
                filter = "'/Sys_Config_Refer/GetData/?name=" + MRefer.R_TableName + "&m=" + MRefer.R_ModuleName + "&n=" + MRefer.R_NameSpace + "&filter='+_filter";
            }

            string tool = string.Empty;
            if (string.IsNullOrEmpty(MRefer.R_Tool))
            {
                tool = "";
            }
            else
            {
                tool = MRefer.R_Tool;
            }

            str = str
                .Replace("{BtnJs}", Multiselect ? btnMJs : btnSJs)
                .Replace("{ModuleName}", ModuleName)
                .Replace("{M_NameSpace}", NameSpace)
                .Replace("{Width}", MRefer.R_Width.ToString())
                .Replace("{Height}", MRefer.R_Height.ToString())
                .Replace("{M_Width}", (MRefer.R_Width * 0.93).ToString())
                .Replace("{M_Height}", (MRefer.R_Height * 0.4).ToString())
                .Replace("{M_Title}", MRefer.R_Title)
                .Replace("{M_ColNames_list}", strColNames)
                .Replace("{M_ColModel_List}", header.ToString())
                .Replace("{M_GridComplete}", "")
                .Replace("{M_URL}", url)
                .Replace("{filterUrl}", filter)
                .Replace("{Width}", "")
                .Replace("{Height}", "")
                .Replace("{Table}", MRefer.R_TableName)
                .Replace("{MultiSelect}", Multiselect ? "true" : "false")
                //.Replace("{ToolBar}", helper.Common_ToolBarForListPage(ModuleName, "",
                //"'add':'hidden','edit':'hidden','del':'hidden','import':'hidden','export':'hidden',view:'hidden'"));
             .Replace("{ToolBar}", helper.GenToolbarNoPermissionHelper(ModuleName,NameSpace,
             tool));

            return str;
        }
    }



}
