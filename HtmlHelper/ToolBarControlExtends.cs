using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using QX.Comm;
using Newtonsoft.Json;
using QX.HtmlHelperLib.Model;
using QX.HtmlHelperLib.DAL;
using QX.HtmlHelperLib.Comm;

namespace QX.HtmlHelperLib
{
    public static class ToolBarControlExtends
    {
        /// <summary>
        /// List中的Toolbar
        /// </summary>
        /// <param name="helper"></param>
        /// <param name="custName">自定义命名前缀</param>
        /// <param name="ToolBarConfig">工具条配置 add:'0',addN:'增加',addFunJs:'ShowMsg('ssss')',addClass:''</param>
        /// <returns></returns>
        //public static string Common_ToolBarForListPage(this HtmlHelper helper, string custName, string ToolBarConfig)
        //{
        //    return Common_ToolBarForListPage(helper,null, custName,true, ToolBarConfig);
        //}

        //public static bool IsHavePermission(this HtmlHelper helper, string funcode)
        //{

        //    ADOSys_UserPermission instance = new ADOSys_UserPermission();
        //    Sys_UserPermission p = instance.GetListByWhere(string.Format("AND PU_UserCode='{0}' AND PU_FunCode='{1}'", QX.Config.SessionConfig.UserId(), funcode)).FirstOrDefault();
        //    if (p == null)
        //    {
        //        return false;
        //    }

        //    return true;

        //}

        public static string GenToolbarHelper(this HtmlHelper helper, string module, string prefix, string ToolBarConfig)
        {
            return GenToolbarHelper(helper, module, prefix, false, ToolBarConfig);
        }

        public static string GenToolbarHelper(this HtmlHelper helper, string moduleName, string prefix, bool HiddeOther, string ToolBarConfig)
        {
            ADOComm comInstance = new ADOComm();

            Sys_Config_ListPage M_Model = new Sys_Config_ListPage();

            //第一步：根据传入模块获取Grid配置
            List<Sys_Config_ListPage> _ListPage = new DAL.ADOSys_Config_ListPage().GetListByWhere(" AND M_ModuleCode='" +
            moduleName + "'");

            //工具条配置
            List<Sys_Config_Toolbar> _Config = new List<Sys_Config_Toolbar>();
            DAL.ADOSys_Config_Toolbar tInstance = new ADOSys_Config_Toolbar();
            _Config = tInstance.GetListByWhere(string.Format("AND CT_Module='{0}' and isnull(CT_Show,'true')='true'", moduleName));

            if (_ListPage.Count > 0)
            {
                M_Model = _ListPage[0];
            }
            //工具条各控件前缀
            string strPrefix = "";

            strPrefix = prefix;

            ToolBar bar = new ToolBar();
            if (!string.IsNullOrEmpty(ToolBarConfig))
            {
                bar = JsonConvert.DeserializeObject<ToolBar>("{" + ToolBarConfig + "}");
            }

            var HasAdd = 1;
            var HasEdit = 1;
            var HasView = 1;
            var HasDel = 1;
            var HasImport = 1;
            var HasExport = 1;


            var IS_OPEN_PERMISSION = ConfigHelper.GetApp("IS_OPEN_PERMISSION");
            ///ToDo:暂时屏蔽
            //if (!string.IsNullOrEmpty(IS_OPEN_PERMISSION) && IS_OPEN_PERMISSION == "true")
            //{
            //    var Permission = comInstance.UserPermissionList(QX.Config.SessionConfig.UserId());
            //    HasAdd = Permission.Where(o => o.Fun_UDef1 == strPrefix + "_add").Count();
            //    HasEdit = Permission.Where(o => o.Fun_UDef1 == strPrefix + "_edit").Count();
            //    HasView = Permission.Where(o => o.Fun_UDef1 == strPrefix + "_view").Count();
            //    HasDel = Permission.Where(o => o.Fun_UDef1 == strPrefix + "_delete").Count();
            //    HasImport = Permission.Where(o => o.Fun_UDef1 == strPrefix + "_import").Count();
            //    HasExport = Permission.Where(o => o.Fun_UDef1 == strPrefix + "_export").Count();
            //}

            #region 按钮Html（定义增删改搜索等模板）
            //{add} -->补充属性  prefix-->id前缀 {toolbar_add}--->样式
            string controlTpl = @"<li {attr}  id='{toolbar_id}' class='{toolbar_class}'><a class='hide'  onclick='{toolbar_event}' href='#'>{addN}</a></li>";


            string Li_edit = @"<li {edit} id='{prefix}_toolbar_edit' class='{toolbar_edit}'><a class='hide' id='{prefix}_edit' onclick='{prefix}ToolBar.Edit()' href='#'>{editN}</a></li>";
            string Li_del = @"<li {del} id='{prefix}_toolbar_delete' class='{toolbar_delete}'><a class='hide' id='{prefix}_delete' onclick='{prefix}ToolBar.Delete()' href='#'>{delN}</a></li> ";
            string Li_view = @"<li {view} id='{prefix}_toolbar_view' class='{toolbar_view}'><a class='hide' id='{prefix}_view' onclick='{prefix}ToolBar.View()' href='#'>{viewN}</a></li> ";
            //string Li_import = @"<li {import} id='{prefix}_toolbar_import' class='{toolbar_import}'><a class='hide' id='{prefix}_import' onclick='{prefix}ToolBar.Import()' href='#'>{importN}</a></li>";
            //string Li_export = @"<li {export} id='{prefix}_toolbar_export' class='{toolbar_export}'><a class='hide' id='{prefix}_export' onclick='{prefix}ToolBar.Export()' href='#'>{exportN}</a></li>";
            string Li_search = @"<li {search} id='{prefix}_toolbar_search'  class='{toolbar_search}'><input style='display:none' id='search_txt' type='text' value='' />
                <a id='{prefix}_search' onclick='{prefix}ToolBar.Search()' href='#'>{searchN}</a>
                </li>  ";
            string Li_Custom = @"<li {add} id='{prefix}_toolbar_add' class='{toolbar_add}'><a id='{prefix}_add' onclick='{prefix}ToolBar.Add()' href='#'>{addN}</a></li>";

            #endregion

            bool toolbar = !string.IsNullOrEmpty(bar.toolbar) ? true : false;
            string validatemethod = @" 
                
                if ($.isFunction(window.{prefix}ToolBar{OpType}))
                {  
                    {prefix}ToolBar{OpType}();
                 }
                else
                {
                    {nameSpace}_{moduleName}ToolBar{OpType}();
                }";
            string str = @"
            <div id='{prefix}toolbar' class='toolbar'>
            <ul>
              {Toolbar_Config}
            </ul>
             </div> 
             <script type='text/javascript'>
                 var {prefix}ToolBar = {
                    {Toolbar_Function}
                    HideElement:function(id){
                         $('#id').hide();
                    },
                    ChangeElement:function(id,name){
                         $('#id').find('a').val(name);
                    }
                 }
                //插入菜单项：文本,回调,位置(ID),样式
             </script>
            ";
            StringBuilder configSb = new StringBuilder();
            StringBuilder functionSb = new StringBuilder();
            foreach (var m in _Config)
            {
                switch (m.CT_Type)
                {
                    case "add":
                    case "edit":
                    case "del":
                    case "view":
                        {
                            //控件id
                            string id = prefix + "_toolbar_" + m.CT_Type;
                            string eventjs = string.Format(prefix + "ToolBar.{0}()", m.CT_Type);
                            string classjs = string.Format("toolbar_{0}", m.CT_Type);
                            configSb.Append(controlTpl.Replace("{prefix}", prefix)
                                .Replace("{toolbar_id}", id)
                                .Replace("{addN}", m.CT_Name)
                                .Replace("{toolbar_class}", string.IsNullOrEmpty(m.CT_Class) ? classjs : m.CT_Class)
                                .Replace("{toolbar_event}", eventjs)
                                .Replace("{attr}", m.CT_Attr)
                                );
                            if (string.IsNullOrEmpty(m.CT_Event))
                            {
                                m.CT_Event = validatemethod.Replace("{OpType}", m.CT_Type).Replace("{prefix}", strPrefix).Replace("{nameSpace}", prefix).Replace("{moduleName}", moduleName);
                            }
                            //事件定义
                            //string.IsNullOrEmpty(m.CT_Event)?eventjs:m.CT_Event
                            functionSb.AppendLine();
                            functionSb.AppendLine("              " + m.CT_Type + ":function(){");
                            functionSb.AppendLine("              " + m.CT_Event);
                            functionSb.AppendLine("               },");
                            break;
                        }
                    //case "edit":
                    //    {
                    //        break;
                    //    }
                    //case "del":
                    //    {

                    //        break;
                    //    }
                    //case "view":
                    //    {

                    //        break;
                    //    }
                    case "search":
                        {

                            break;
                        }
                    case "text":
                        {

                            break;
                        }
                    case "btn":
                        {
                            string id = prefix + "_toolbar_" + m.CT_Field;
                            string eventjs = string.Format(prefix + "ToolBar.{0}()", m.CT_Field);
                            string classjs = string.Format("toolbar_{0}", m.CT_Field);
                            configSb.Append(controlTpl.Replace("{prefix}", prefix)
                                .Replace("{toolbar_id}", id)
                                .Replace("{addN}", m.CT_Name)
                                .Replace("{toolbar_class}", string.IsNullOrEmpty(m.CT_Class) ? classjs : m.CT_Class)
                                .Replace("{toolbar_event}", eventjs)
                                .Replace("{attr}", m.CT_Attr)
                                );
                            //事件定义
                            //string.IsNullOrEmpty(m.CT_Event)?eventjs:m.CT_Event
                            functionSb.AppendLine();
                            functionSb.AppendLine("              " + m.CT_Type + ":function(){");
                            functionSb.AppendLine("              " + m.CT_Event);
                            functionSb.AppendLine("               },");
                            break;
                        }
                }

            }//end foreach

            str = str.Replace("{prefix}", prefix).Replace("{Toolbar_Config}", configSb.ToString()).Replace("{Toolbar_Function}", functionSb.ToString());
            //#region 按钮解析（配置生成）

            //string add = !string.IsNullOrEmpty(bar.add) ? "style='display:none'" : "style='display:block'";
            //string addN = !string.IsNullOrEmpty(bar.addN) ? bar.addN : "添加";
            //string addClass = !string.IsNullOrEmpty(bar.addClass) ? bar.addClass : "toolbar_add";
            //string edit = !string.IsNullOrEmpty(bar.edit) ? "style='display:none'" : "style='display:block'";
            //string editN = !string.IsNullOrEmpty(bar.editN) ? bar.editN : "修改";
            //string editClass = !string.IsNullOrEmpty(bar.editClass) ? bar.editClass : "toolbar_edit";
            //string del = !string.IsNullOrEmpty(bar.del) ? "style='display:none'" : "style='display:block'";
            //string delN = !string.IsNullOrEmpty(bar.delN) ? bar.delN : "删除";
            //string delClass = !string.IsNullOrEmpty(bar.delClass) ? bar.delClass : "toolbar_delete";
            //string view = !string.IsNullOrEmpty(bar.view) ? "style='display:none'" : "style='display:block'";
            //string viewN = !string.IsNullOrEmpty(bar.viewN) ? bar.viewN : "查看";
            //string viewClass = !string.IsNullOrEmpty(bar.viewClass) ? bar.viewClass : "toolbar_view";
            ////string import = !string.IsNullOrEmpty(bar.import) ? "style='display:none'" : "style='display:block'";
            ////string importN = !string.IsNullOrEmpty(bar.importN) ? bar.importN : "导入";
            ////string importClass = !string.IsNullOrEmpty(bar.importClass) ? bar.importClass : "toolbar_import";
            ////string export = !string.IsNullOrEmpty(bar.export) ? "style='display:none'" : "style='display:block'";
            ////string exportN = !string.IsNullOrEmpty(bar.exportN) ? bar.exportN : "导出";
            ////string exportClass = !string.IsNullOrEmpty(bar.exportClass) ? bar.exportClass : "toolbar_export";
            //string search = !string.IsNullOrEmpty(bar.search) ? "style='display:none'" : "style='display:block'";
            //string searchN = !string.IsNullOrEmpty(bar.searchN) ? bar.searchN : "搜索";
            //string searchClass = !string.IsNullOrEmpty(bar.searchClass) ? bar.searchClass : "toolbar_search";
            //#endregion

            //#region 事件定义

            //string addJS = !string.IsNullOrEmpty(bar.addFunJs) ? "{prefix}" + bar.addFunJs : validatemethod.Replace("{OpType}", "Add");
            //string editJs = !string.IsNullOrEmpty(bar.editFunJs) ? "{prefix}" + bar.editFunJs : validatemethod.Replace("{OpType}", "Edit");
            //string delJs = !string.IsNullOrEmpty(bar.delFunJs) ? "{prefix}" + bar.delFunJs : validatemethod.Replace("{OpType}", "Del");
            //string viewJs = !string.IsNullOrEmpty(bar.viewFunJs) ? "{prefix}" + bar.viewFunJs : validatemethod.Replace("{OpType}", "View");
            ////string importJs = !string.IsNullOrEmpty(bar.importFunJs) ? "{prefix}" + bar.importFunJs : "{prefix}ToolBarImport()";
            ////string exportJs = !string.IsNullOrEmpty(bar.exportFunJs) ? "{prefix}" + bar.exportFunJs : "{prefix}ToolBarExport()";
            //string searchJs = !string.IsNullOrEmpty(bar.searchFunJs) ? "{prefix}" + bar.searchFunJs : "{prefix}ToolBarSearch()";
            //#endregion

            //            #region HTML生成
            //            string str = @"
            //            <div id='{prefix}toolbar' class='toolbar'>
            //            <ul>
            //                {Li_add}
            //                {Li_edit}
            //                {Li_del}
            //                {Li_view}
            //                {Li_search}
            //            </ul>
            //             </div> 
            //             <script type='text/javascript'>
            //                 var {prefix}ToolBar = {
            //                     Add: function() {
            //                         {addJs};
            //                     },
            //                     Edit: function() {
            //                         {editJs};
            //                     },
            //                     Delete: function() {
            //                         {delJs};
            //                     },
            //                     View: function() {
            //                         {viewJs};
            //                     },
            //                     Search: function() {
            //                         {searchJs};
            //                     },
            //                     Import: function() {
            //                         {importJs};
            //                     },
            //                     Export: function() {
            //                         {exportJs};
            //                     },
            //                    HideElement:function(id){
            //                         $('#id').hide();
            //                    },
            //                    ChangeElement:function(id,name){
            //                         $('#id').find('a').val(name);
            //                    }
            //                 }
            //                //插入菜单项：文本,回调,位置(ID),样式
            //               
            //             
            //             </script>
            //            ";
            //            #endregion

            //            Li_add = HasAdd > 0 ? Li_add : "";
            //            Li_edit = HasEdit > 0 ? Li_edit : "";
            //            Li_del = HasDel > 0 ? Li_del : "";
            //            //Li_import = HasImport > 0 ? Li_import : "";
            //            //Li_export = HasExport > 0 ? Li_export : "";
            //            Li_view = HasView > 0 ? Li_view : "";

            //            bool HasConfig = !string.IsNullOrEmpty(ToolBarConfig) ? true : false;
            //            if (HasConfig)
            //            {
            //                str = str.Replace("{Li_add}", ((!string.IsNullOrEmpty(bar.addN) || !string.IsNullOrEmpty(bar.addFunJs))) ? Li_add : "");
            //                str = str.Replace("{Li_edit}", ((!string.IsNullOrEmpty(bar.editN) || !string.IsNullOrEmpty(bar.editFunJs))) ? Li_edit : "");
            //                str = str.Replace("{Li_del}", ((!string.IsNullOrEmpty(bar.delN) || !string.IsNullOrEmpty(bar.delFunJs))) ? Li_del : "");
            //                str = str.Replace("{Li_view}", ((!string.IsNullOrEmpty(bar.viewN) || !string.IsNullOrEmpty(bar.viewFunJs))) ? Li_view : "");
            //                //str = str.Replace("{Li_import}", ((!string.IsNullOrEmpty(bar.importN) || !string.IsNullOrEmpty(bar.importFunJs))) ? Li_import : "");
            //                //str = str.Replace("{Li_export}", ((!string.IsNullOrEmpty(bar.exportN) || !string.IsNullOrEmpty(bar.exportFunJs))) ? Li_export : "");
            //                //str = str.Replace("{Li_search}", ((!string.IsNullOrEmpty(bar.searchN) || !string.IsNullOrEmpty(bar.searchFunJs))) ? Li_search : "");
            //            }
            //            else//默认生成的话根据配置进行生成
            //            {
            //                if (M_Model.M_IsAdd == 1)
            //                {
            //                    str = str.Replace("{Li_add}", Li_add);
            //                }
            //                else
            //                {
            //                    str = str.Replace("{Li_add}", "");
            //                }
            //                if (M_Model.M_IsEdit == 1)
            //                {
            //                    str = str.Replace("{Li_edit}", Li_edit);
            //                }
            //                else
            //                {
            //                    str = str.Replace("{Li_edit}", "");
            //                }
            //                if (M_Model.M_IsDelete == 1)
            //                {
            //                    str = str.Replace("{Li_del}", Li_del);
            //                }
            //                else
            //                {
            //                    str = str.Replace("{Li_del}", "");
            //                }
            //                if (M_Model.M_IsView == "true")
            //                {
            //                    str = str.Replace("{Li_view}", Li_view);
            //                }
            //                else
            //                {
            //                    str = str.Replace("{Li_view}", "");
            //                }
            //                //str = str.Replace("{Li_import}", Li_import);
            //                //str = str.Replace("{Li_export}", Li_export);

            //            }
            //            //搜索 默认输出
            //            str = str.Replace("{Li_search}", Li_search);
            //            if (M_Model.M_IsAdd == 1)
            //            {
            //                str = str.Replace("{toolbar_add}", addClass);
            //            }
            //            else
            //            {
            //                str = str.Replace("{toolbar_add}", "");
            //            }
            //            if (M_Model.M_IsEdit == 1)
            //            {
            //                str = str.Replace("{toolbar_edit}", editClass);
            //            }
            //            else
            //            {
            //                str = str.Replace("{toolbar_edit}", "");
            //            }
            //            str = str.Replace("{toolbar_delete}", delClass);
            //            if (M_Model.M_IsView == "true")
            //            {
            //                str = str.Replace("{toolbar_view}", viewClass);
            //            }
            //            else
            //            {
            //                str = str.Replace("{toolbar_view}", "");
            //            }
            //            //str = str.Replace("{toolbar_import}", importClass);
            //            //str = str.Replace("{toolbar_export}", exportClass);
            //            str = str.Replace("{toolbar_search}", searchClass);

            //            if (M_Model.M_IsAdd == 1)
            //            {
            //                str = str.Replace("{addJs}", addJS);
            //            }
            //            else
            //            {
            //                str = str.Replace("{addJs}", "");
            //            }
            //            if (M_Model.M_IsEdit == 1)
            //            {
            //                str = str.Replace("{editJs}", editJs);
            //            }
            //            else
            //            {
            //                str = str.Replace("{editJs}", "");
            //            }

            //            if (M_Model.M_IsDelete == 1)
            //            {
            //                str = str.Replace("{delJs}", delJs);
            //            }
            //            else
            //            {
            //                str = str.Replace("{delJs}", "");
            //            }

            //            if (M_Model.M_IsView == "true")
            //            {
            //                str = str.Replace("{viewJs}", viewJs);
            //            }
            //            else
            //            {
            //                str = str.Replace("{viewJs}", "");
            //            }

            //            //str = str.Replace("{viewJs}", viewJs);
            //            str = str.Replace("{searchJs}", searchJs);
            //            //str = str.Replace("{importJs}", importJs);
            //            //str = str.Replace("{exportJs}", exportJs);
            //            str = str.Replace("{searchJs}", searchJs);

            //            str = str.Replace("{prefix}", strPrefix);
            //            str = str.Replace("{newprefix}", prefix);
            //            str = str.Replace("{add}", add);
            //            str = str.Replace("{addN}", addN);
            //            str = str.Replace("{edit}", edit);
            //            str = str.Replace("{editN}", editN);
            //            str = str.Replace("{del}", del);
            //            str = str.Replace("{delN}", delN);

            //            str = str.Replace("{view}", view);

            //            str = str.Replace("{viewN}", viewN);
            //            //str = str.Replace("{import}", import);
            //            //str = str.Replace("{importN}", importN);
            //            //str = str.Replace("{export}", export);
            //            //str = str.Replace("{exportN}", exportN);
            //            str = str.Replace("{search}", search);
            //            str = str.Replace("{searchN}", searchN);

            //            str = str.Replace("{moduleName}", M_Model.M_ModuleCode);
            //            str = str.Replace("{nameSpace}", M_Model.M_NameSpace);
            //            if (toolbar)
            //            {
            //                str = "";
            //            }
            return str;
        }

        public static string GenNToolbarHelper(this HtmlHelper helper, string moduleName, string prefix, Dictionary<string, string> permisons)
        {
            #region
            //            ADOComm comInstance = new ADOComm();

            //            Sys_Config_ListPage M_Model = new Sys_Config_ListPage();

            //            //第一步：根据传入模块获取Grid配置
            //            List<Sys_Config_ListPage> _ListPage = new DAL.ADOSys_Config_ListPage().GetListByWhere(" AND M_ModuleCode='" +
            //            moduleName + "'");

            //            //工具条配置
            //            List<Sys_Config_Toolbar> _Config = new List<Sys_Config_Toolbar>();
            //            DAL.ADOSys_Config_Toolbar tInstance = new ADOSys_Config_Toolbar();
            //            _Config = tInstance.GetListByWhere(string.Format("AND CT_Module='{0}' and isnull(CT_Show,'true')='true'", moduleName));

            //            if (_ListPage.Count > 0)
            //            {
            //                M_Model = _ListPage[0];
            //            }
            //            //工具条各控件前缀
            //            string strPrefix = "";

            //            strPrefix = prefix;

            //            var IS_OPEN_PERMISSION = ConfigHelper.GetApp("IS_OPEN_PERMISSION");

            //            #region 按钮Html（定义增删改搜索等模板）
            //            //{add} -->补充属性  prefix-->id前缀 {toolbar_add}--->样式
            //            string controlTpl = @"<li {attr}  id='{toolbar_id}' class='{toolbar_class}'><a class='hide'  onclick='{toolbar_event}' href='#'>{addN}</a></li>";
            //            #endregion

            //            string validatemethod = @" 
            //                
            //                if ($.isFunction(window.{prefix}ToolBar{OpType}))
            //                {  
            //                    {prefix}ToolBar{OpType}();
            //                 }
            //                else
            //                {
            //                    {nameSpace}_{moduleName}ToolBar{OpType}();
            //                }";
            //            string str = @"
            //            <div id='{prefix}toolbar' class='toolbar'>
            //            <ul>
            //              {Toolbar_Config}
            //            </ul>
            //             </div> 
            //             <script type='text/javascript'>
            //                 var {prefix}ToolBar = {
            //                    {Toolbar_Function}
            //                    HideElement:function(id){
            //                         $('#id').hide();
            //                    },
            //                    ChangeElement:function(id,name){
            //                         $('#id').find('a').val(name);
            //                    }
            //                 }
            //                //插入菜单项：文本,回调,位置(ID),样式
            //             </script>
            //            ";
            //            StringBuilder configSb = new StringBuilder();
            //            StringBuilder functionSb = new StringBuilder();
            //            foreach (var m in _Config)
            //            {
            //                //控件id
            //                string cid = prefix + "_toolbar_" + m.CT_Type;
            //                //默认事件
            //                string eventjs = string.Format(prefix + "ToolBar.{0}()", m.CT_Type);
            //                //默认样式
            //                string classjs = string.Format("toolbar_{0}", m.CT_Type);
            //                ///如果存在该权限则进行后面的生成操作
            //                if (permisons==null||permisons.Values.FirstOrDefault(o => !string.IsNullOrEmpty(o)&&cid.ToLower().Equals(o.ToLower()))==null)
            //                {
            //                    continue;
            //                }

            //                switch (m.CT_Type)
            //                {
            //                    case "add":
            //                    case "edit":
            //                    case "del":
            //                    case "view":
            //                        {
            //                            configSb.Append(controlTpl.Replace("{prefix}", prefix)
            //                                .Replace("{toolbar_id}", cid)
            //                                .Replace("{addN}", m.CT_Name)
            //                                .Replace("{toolbar_class}", string.IsNullOrEmpty(m.CT_Class) ? classjs : m.CT_Class)
            //                                .Replace("{toolbar_event}", eventjs)
            //                                .Replace("{attr}", m.CT_Attr)
            //                                );
            //                            if (string.IsNullOrEmpty(m.CT_Event))
            //                            {
            //                                m.CT_Event = validatemethod.Replace("{OpType}", m.CT_Type).Replace("{prefix}", strPrefix).Replace("{nameSpace}", prefix).Replace("{moduleName}", moduleName);
            //                            }
            //                            //事件定义
            //                            //string.IsNullOrEmpty(m.CT_Event)?eventjs:m.CT_Event
            //                            functionSb.AppendLine();
            //                            functionSb.AppendLine("              " + m.CT_Type + ":function(){");
            //                            functionSb.AppendLine("              " + m.CT_Event);
            //                            functionSb.AppendLine("               },");
            //                            break;
            //                        }
            //                    case "search":
            //                        {

            //                            break;
            //                        }
            //                    case "text":
            //                        {

            //                            break;
            //                        }
            //                    case "btn":
            //                        {
            //                            string bid = prefix + "_toolbar_" + m.CT_Field;
            //                            string beventjs = string.Format(prefix + "ToolBar.{0}()", m.CT_Field);
            //                            string bclassjs = string.Format("toolbar_{0}", m.CT_Field);
            //                            configSb.Append(controlTpl.Replace("{prefix}", prefix)
            //                                .Replace("{toolbar_id}", bid)
            //                                .Replace("{addN}", m.CT_Name)
            //                                .Replace("{toolbar_class}", string.IsNullOrEmpty(m.CT_Class) ? bclassjs : m.CT_Class)
            //                                .Replace("{toolbar_event}", beventjs)
            //                                .Replace("{attr}", m.CT_Attr)
            //                                );
            //                            //事件定义
            //                            functionSb.AppendLine();
            //                            functionSb.AppendLine("              " + m.CT_Type + ":function(){");
            //                            functionSb.AppendLine("              " + m.CT_Event);
            //                            functionSb.AppendLine("               },");
            //                            break;
            //                        }
            //                }

            //            }//end foreach

            //            str = str.Replace("{prefix}", prefix).Replace("{Toolbar_Config}", configSb.ToString()).Replace("{Toolbar_Function}", functionSb.ToString());

            //            return str;
            #endregion

            return GenNToolbarHelper(helper, moduleName, prefix, false, permisons);
        }

        public static string GenNToolbarHelper(this HtmlHelper helper, string moduleName, string prefix, bool nopermission, Dictionary<string, string> permisons)
        {
            ADOComm comInstance = new ADOComm();

            Sys_Config_ListPage M_Model = new Sys_Config_ListPage();

            //第一步：根据传入模块获取Grid配置
            List<Sys_Config_ListPage> _ListPage = new DAL.ADOSys_Config_ListPage().GetListByWhere(" AND M_ModuleCode='" +
            moduleName + "'");

            //工具条配置
            List<Sys_Config_Toolbar> _Config = new List<Sys_Config_Toolbar>();
            DAL.ADOSys_Config_Toolbar tInstance = new ADOSys_Config_Toolbar();
            _Config = tInstance.GetListByWhere(string.Format("AND CT_Module='{0}' AND isnull(CT_Show,'true')='true'", moduleName));

            if (_ListPage.Count > 0)
            {
                M_Model = _ListPage[0];
            }
            //工具条各控件前缀
            string strPrefix = "";

            strPrefix = prefix;

            var IS_OPEN_PERMISSION = ConfigHelper.GetApp("IS_OPEN_PERMISSION");

            #region 按钮Html（定义增删改搜索等模板）
            //{add} -->补充属性  prefix-->id前缀 {toolbar_add}--->样式
            string controlTpl = @"<li {attr} {isshow}  id='{toolbar_id}' class='{toolbar_class}'><a class='hide' id={hrefid}  onclick='{toolbar_event}' href='#'>{addN}</a></li>";
            string custTpl = @"<li {isshow} class='{toolbar_class}' style='float:left;'>{content}</li>";
            #endregion

            string validatemethod = @" 
                
                if ($.isFunction(window.{prefix}ToolBar{OpType}))
                {  
                    {prefix}ToolBar{OpType}();
                 }
                else
                {
                    {nameSpace}_{moduleName}ToolBar{OpType}();
                }";
            string str = @"
            <div id='{prefix}toolbar' class='toolbar'>
            <ul>
              {Toolbar_Config}
            </ul>
             </div> 
             <script type='text/javascript'>
                 var {prefix}ToolBar = {
                    {Toolbar_Function}
                    HideElement:function(id){
                         $('#id').hide();
                    },
                    ChangeElement:function(id,name){
                         $('#id').find('a').val(name);
                    }
                 }
                //插入菜单项：文本,回调,位置(ID),样式
             </script>
            ";
            StringBuilder configSb = new StringBuilder();
            StringBuilder functionSb = new StringBuilder();
            StringBuilder extendJsSb = new StringBuilder();
            foreach (var m in _Config)
            {
                //控件id
                string cid = prefix + "_toolbar_" + m.CT_Field;
                string hrefid = prefix + "_" + m.CT_Field;
                //string cid = prefix + "_toolbar_" + m.CT_Type;
                //默认事件
                string eventjs = string.Format(prefix + "ToolBar.{0}()", m.CT_Type);
                //默认样式
                string classjs = string.Format("toolbar_{0}", m.CT_Type);
                ///如果存在该权限则进行后面的生成操作
                if (!nopermission && (permisons == null || permisons.Values.FirstOrDefault(o => !string.IsNullOrEmpty(o) && cid.ToLower().Equals(o.ToLower())) == null))
                {
                    continue;
                }
                var ishow = string.Empty;
                if (m.CT_Show == "false")
                {
                    ishow = "style='display:none;'";
                }
                switch (m.CT_Type)
                {
                    case "add":
                    case "edit":
                    case "del":
                    case "view":
                        {

                            configSb.Append(controlTpl.Replace("{prefix}", prefix)
                                .Replace("{toolbar_id}", cid)
                                .Replace("{addN}", m.CT_Name)
                                .Replace("{toolbar_class}", string.IsNullOrEmpty(m.CT_Class) ? classjs : m.CT_Class)
                                .Replace("{toolbar_event}", eventjs)
                                .Replace("{attr}", m.CT_Attr)
                                .Replace("{hrefid}", hrefid)
                                .Replace("{isshow}",ishow)
                                );
                            if (string.IsNullOrEmpty(m.CT_Event))
                            {
                                m.CT_Event = validatemethod.Replace("{OpType}", m.CT_Type).Replace("{prefix}", strPrefix).Replace("{nameSpace}", prefix).Replace("{moduleName}", moduleName);
                            }
                            //事件定义                            
                            functionSb.AppendLine();
                            functionSb.AppendLine("              " + m.CT_Type + ":function(){");
                            functionSb.AppendLine("              " + m.CT_Event);
                            functionSb.AppendLine("               },");
                            break;
                        }
                    case "search":
                        {
                            configSb.Append(controlTpl.Replace("{prefix}", prefix)
                    .Replace("{toolbar_id}", cid)
                    .Replace("{addN}", m.CT_Name)
                    .Replace("{toolbar_class}", string.IsNullOrEmpty(m.CT_Class) ? classjs : m.CT_Class)
                    .Replace("{toolbar_event}", eventjs)
                    .Replace("{attr}", m.CT_Attr)
                    .Replace("{isshow}", ishow)
                    );
                            if (string.IsNullOrEmpty(m.CT_Event))
                            {
                                m.CT_Event = validatemethod.Replace("{OpType}", m.CT_Type).Replace("{prefix}", strPrefix).Replace("{nameSpace}", prefix).Replace("{moduleName}", moduleName);
                            }
                            //事件定义                            
                            functionSb.AppendLine();
                            functionSb.AppendLine("              " + m.CT_Type + ":function(){");
                            functionSb.AppendLine("              " + m.CT_Event);
                            functionSb.AppendLine("               },");
                            break;
                        }
                    case "text":
                        {
                            string classs = "form_textbox_toolbar";
                            if (!string.IsNullOrEmpty(m.CT_Class))
                            {
                                classs = m.CT_Class;
                            }
                            configSb.Append(custTpl.Replace("{content}", string.Format("<span>{0}:</span><input id='{1}' class='{2}' type='text' value='' name='{1}'>", m.CT_Name, m.CT_Field, classs)));
                            break;
                        }
                    case "date":
                        {
                            //streElement = Li_Input.Replace("{CT_Attr}", "class='" + defaultStyle + DateStyle + "'" + item.CT_Attr)
                            //                   .Replace("{CT_Field}", item.CT_Field)
                            //                   .Replace("{CT_Default}", item.CT_Default);

                            //strLi = Li_Template.Replace("{CT_Name}", item.CT_Name)
                            //                       .Replace("{Element}", streElement);

                            //strList.AppendLine(strLi);

                            var ClickJs = @"<script> $('#" + m.CT_Field + "').bind('click',function(){ WdatePicker(); }); </script> ";
                            //strJsList.AppendLine(ClickJs);
                            configSb.Append(custTpl.Replace("{content}", string.Format("<span>{0}:</span><input id='{1}' class='form_textbox_toolbar TextBoxReadOnly date_icon' type='text' value='2012-03-02' name='{1}'>", m.CT_Name, m.CT_Field)));
                            //configSb.Append(@"<span>开始日期:</span><input id="bDate" class="form_textbox_toolbar TextBoxReadOnly date_icon" type="text" value="2012-03-02" name="bDate">");
                            extendJsSb.AppendLine(ClickJs);
                            break;
                        }
                    case "datetime":
                        {
                            //streElement = Li_Input.Replace("{CT_Attr}", "class='" + defaultStyle + DateStyle + "'" + item.CT_Attr)
                            //                   .Replace("{CT_Field}", item.CT_Field)
                            //                   .Replace("{CT_Default}", item.CT_Default);

                            //strLi = Li_Template.Replace("{CT_Name}", item.CT_Name)
                            //                       .Replace("{Element}", streElement);

                            //strList.AppendLine(strLi);

                            //ClickJs = @" $('#" + Module + "').find('#" + item.CT_Field + "').bind('click',function(){ WdatePicker({dateFmt:'yyyy-MM-dd HH:mm:ss'}); });  ";
                            //strJsList.AppendLine(ClickJs);

                            var ClickJs = @"<script> $('#" + m.CT_Field + "').bind('click',function(){ WdatePicker({dateFmt:'yyyy-MM-dd HH:mm:ss'}); }); </script> ";
                            //strJsList.AppendLine(ClickJs);
                            configSb.Append(custTpl.Replace("{content}", string.Format("<span>{0}:</span><input id='{1}' class='form_textbox_toolbar TextBoxReadOnly date_icon' type='text' value='2012-03-02' name='{1}'>", m.CT_Name, m.CT_Field)).Replace("{isshow}",ishow));
                            //configSb.Append(@"<span>开始日期:</span><input id="bDate" class="form_textbox_toolbar TextBoxReadOnly date_icon" type="text" value="2012-03-02" name="bDate">");
                            extendJsSb.AppendLine(ClickJs);
                            break;
                        }
                    case "btn":
                        {
                            // string hrefid = prefix + m.CT_Field;
                            string beventjs = string.Format(prefix + "ToolBar.{0}()", m.CT_Field);
                            string bclassjs = string.Format("toolbar_{0}", m.CT_Field);
                            configSb.Append(controlTpl.Replace("{prefix}", prefix)
                                .Replace("{toolbar_id}", cid)
                                .Replace("{addN}", m.CT_Name)
                                .Replace("{toolbar_class}", string.IsNullOrEmpty(m.CT_Class) ? bclassjs : m.CT_Class)
                                .Replace("{toolbar_event}", beventjs)
                                .Replace("{attr}", m.CT_Attr)
                                .Replace("{hrefid}", hrefid)
                                );
                            //事件定义
                            functionSb.AppendLine();
                            functionSb.AppendLine("              " + m.CT_Field + ":function(){");
                            functionSb.AppendLine("              " + m.CT_Event);
                            functionSb.AppendLine("               },");
                            break;
                        }
                }

            }//end foreach

            str = str.Replace("{prefix}", prefix).Replace("{Toolbar_Config}", configSb.ToString()).Replace("{Toolbar_Function}", functionSb.ToString());
            str = str + extendJsSb.ToString();
            return str;
        }

        public static string GenToolbarNoPermissionHelper(this HtmlHelper helper, string moduleName, string prefix, string ToolBarConfig)
        {
            ADOComm comInstance = new ADOComm();
            Sys_Config_ListPage M_Model = new Sys_Config_ListPage();

            //第一步：根据传入模块获取Grid配置
            List<Sys_Config_ListPage> _ListPage = new DAL.ADOSys_Config_ListPage().GetListByWhere(" AND M_ModuleCode='" +
            moduleName + "'");
            if (_ListPage.Count > 0)
            {
                M_Model = _ListPage[0];
            }

            string strPrefix = "";

            strPrefix = prefix;

            ToolBar bar = new ToolBar();
            if (!string.IsNullOrEmpty(ToolBarConfig))
            {
                bar = JsonConvert.DeserializeObject<ToolBar>("{" + ToolBarConfig + "}");
            }

            var HasAdd = 1;
            var HasEdit = 1;
            var HasView = 1;
            var HasDel = 1;
            var HasImport = 1;
            var HasExport = 1;

            //var IS_OPEN_PERMISSION = ConfigHelper.GetApp("IS_OPEN_PERMISSION");
            //if (!string.IsNullOrEmpty(IS_OPEN_PERMISSION) && IS_OPEN_PERMISSION == "true")
            //{
            //    var Permission = comInstance.UserPermissionList(QX.Config.SessionConfig.UserId());
            //    HasAdd = Permission.Where(o => o.Fun_UDef1 == strPrefix + "_add").Count();
            //    HasEdit = Permission.Where(o => o.Fun_UDef1 == strPrefix + "_edit").Count();
            //    HasView = Permission.Where(o => o.Fun_UDef1 == strPrefix + "_view").Count();
            //    HasDel = Permission.Where(o => o.Fun_UDef1 == strPrefix + "_delete").Count();
            //    HasImport = Permission.Where(o => o.Fun_UDef1 == strPrefix + "_import").Count();
            //    HasExport = Permission.Where(o => o.Fun_UDef1 == strPrefix + "_export").Count();
            //}

            #region 按钮Html
            string Li_add = @"<li {add} id='{prefix}_toolbar_add' class='{toolbar_add}'><a class='hide' id='{prefix}_add' onclick='{prefix}ToolBar.Add()' href='#'>{addN}</a></li>";
            string Li_edit = @"<li {edit} id='{prefix}_toolbar_edit' class='{toolbar_edit}'><a class='hide' id='{prefix}_edit' onclick='{prefix}ToolBar.Edit()' href='#'>{editN}</a></li>";
            string Li_del = @"<li {del} id='{prefix}_toolbar_delete' class='{toolbar_delete}'><a class='hide' id='{prefix}_delete' onclick='{prefix}ToolBar.Delete()' href='#'>{delN}</a></li> ";
            string Li_view = @"<li {view} id='{prefix}_toolbar_view' class='{toolbar_view}'><a class='hide' id='{prefix}_view' onclick='{prefix}ToolBar.View()' href='#'>{viewN}</a></li> ";
            //string Li_import = @"<li {import} id='{prefix}_toolbar_import' class='{toolbar_import}'><a class='hide' id='{prefix}_import' onclick='{prefix}ToolBar.Import()' href='#'>{importN}</a></li>";
            //string Li_export = @"<li {export} id='{prefix}_toolbar_export' class='{toolbar_export}'><a class='hide' id='{prefix}_export' onclick='{prefix}ToolBar.Export()' href='#'>{exportN}</a></li>";
            string Li_search = @"<li {search} id='{prefix}_toolbar_search'  class='{toolbar_search}'><input style='display:none' id='search_txt' type='text' value='' />
                <a id='{prefix}_search' onclick='{prefix}ToolBar.Search()' href='#'>{searchN}</a>
                </li>  ";
            string Li_Custom = @"<li {add} id='{prefix}_toolbar_add' class='{toolbar_add}'><a id='{prefix}_add' onclick='{prefix}ToolBar.Add()' href='#'>{addN}</a></li>";

            #endregion

            #region 按钮解析
            bool toolbar = !string.IsNullOrEmpty(bar.toolbar) ? true : false;
            string add = !string.IsNullOrEmpty(bar.add) ? "style='display:none'" : "style='display:block'";
            string addN = !string.IsNullOrEmpty(bar.addN) ? bar.addN : "添加";
            string addClass = !string.IsNullOrEmpty(bar.addClass) ? bar.addClass : "toolbar_add";
            string edit = !string.IsNullOrEmpty(bar.edit) ? "style='display:none'" : "style='display:block'";
            string editN = !string.IsNullOrEmpty(bar.editN) ? bar.editN : "修改";
            string editClass = !string.IsNullOrEmpty(bar.editClass) ? bar.editClass : "toolbar_edit";
            string del = !string.IsNullOrEmpty(bar.del) ? "style='display:none'" : "style='display:block'";
            string delN = !string.IsNullOrEmpty(bar.delN) ? bar.delN : "删除";
            string delClass = !string.IsNullOrEmpty(bar.delClass) ? bar.delClass : "toolbar_delete";
            string view = !string.IsNullOrEmpty(bar.view) ? "style='display:none'" : "style='display:block'";
            string viewN = !string.IsNullOrEmpty(bar.viewN) ? bar.viewN : "查看";
            string viewClass = !string.IsNullOrEmpty(bar.viewClass) ? bar.viewClass : "toolbar_view";
            //string import = !string.IsNullOrEmpty(bar.import) ? "style='display:none'" : "style='display:block'";
            //string importN = !string.IsNullOrEmpty(bar.importN) ? bar.importN : "导入";
            //string importClass = !string.IsNullOrEmpty(bar.importClass) ? bar.importClass : "toolbar_import";
            //string export = !string.IsNullOrEmpty(bar.export) ? "style='display:none'" : "style='display:block'";
            //string exportN = !string.IsNullOrEmpty(bar.exportN) ? bar.exportN : "导出";
            //string exportClass = !string.IsNullOrEmpty(bar.exportClass) ? bar.exportClass : "toolbar_export";
            string search = !string.IsNullOrEmpty(bar.search) ? "style='display:none'" : "style='display:block'";
            string searchN = !string.IsNullOrEmpty(bar.searchN) ? bar.searchN : "搜索";
            string searchClass = !string.IsNullOrEmpty(bar.searchClass) ? bar.searchClass : "toolbar_search";
            #endregion

            #region 事件定义
            string validatemethod = @" 
    if ($.isFunction(window.{prefix}ToolBar{OpType}))
    {  
      {prefix}ToolBar{OpType}();
    }
    else
    {
        {nameSpace}_{moduleName}ToolBar{OpType}();
    }";
            string addJS = !string.IsNullOrEmpty(bar.addFunJs) ? "{prefix}" + bar.addFunJs : validatemethod.Replace("{OpType}", "Add");
            string editJs = !string.IsNullOrEmpty(bar.editFunJs) ? "{prefix}" + bar.editFunJs : validatemethod.Replace("{OpType}", "Edit");
            string delJs = !string.IsNullOrEmpty(bar.delFunJs) ? "{prefix}" + bar.delFunJs : validatemethod.Replace("{OpType}", "Del");
            string viewJs = !string.IsNullOrEmpty(bar.viewFunJs) ? "{prefix}" + bar.viewFunJs : validatemethod.Replace("{OpType}", "View");
            //string importJs = !string.IsNullOrEmpty(bar.importFunJs) ? "{prefix}" + bar.importFunJs : "{prefix}ToolBarImport()";
            //string exportJs = !string.IsNullOrEmpty(bar.exportFunJs) ? "{prefix}" + bar.exportFunJs : "{prefix}ToolBarExport()";
            string searchJs = !string.IsNullOrEmpty(bar.searchFunJs) ? "{prefix}" + bar.searchFunJs : "{prefix}ToolBarSearch()";
            #endregion

            #region HTML生成
            string str = @"
            <div id='{prefix}toolbar' class='toolbar'>
            <ul>
                {Li_add}
                {Li_edit}
                {Li_del}
                {Li_view}
                {Li_search}
            </ul>
             </div> 
             <script type='text/javascript'>
                 var {prefix}ToolBar = {
                     Add: function() {
                         {addJs};
                     },
                     Edit: function() {
                         {editJs};
                     },
                     Delete: function() {
                         {delJs};
                     },
                     View: function() {
                         {viewJs};
                     },
                     Search: function() {
                         {searchJs};
                     },
                     Import: function() {
                         {importJs};
                     },
                     Export: function() {
                         {exportJs};
                     },
                    HideElement:function(id){
                         $('#id').hide();
                    },
                    ChangeElement:function(id,name){
                         $('#id').find('a').val(name);
                    }
                 }
                //插入菜单项：文本,回调,位置(ID),样式
               
             
             </script>
            ";
            #endregion

            Li_add = HasAdd > 0 ? Li_add : "";
            Li_edit = HasEdit > 0 ? Li_edit : "";
            Li_del = HasDel > 0 ? Li_del : "";
            //Li_import = HasImport > 0 ? Li_import : "";
            //Li_export = HasExport > 0 ? Li_export : "";
            Li_view = HasView > 0 ? Li_view : "";

            bool HasConfig = !string.IsNullOrEmpty(ToolBarConfig) ? true : false;
            if (HasConfig)
            {
                str = str.Replace("{Li_add}", ((!string.IsNullOrEmpty(bar.addN) || !string.IsNullOrEmpty(bar.addFunJs))) ? Li_add : "");
                str = str.Replace("{Li_edit}", ((!string.IsNullOrEmpty(bar.editN) || !string.IsNullOrEmpty(bar.editFunJs))) ? Li_edit : "");
                str = str.Replace("{Li_del}", ((!string.IsNullOrEmpty(bar.delN) || !string.IsNullOrEmpty(bar.delFunJs))) ? Li_del : "");
                str = str.Replace("{Li_view}", ((!string.IsNullOrEmpty(bar.viewN) || !string.IsNullOrEmpty(bar.viewFunJs))) ? Li_view : "");
                //str = str.Replace("{Li_import}", ((!string.IsNullOrEmpty(bar.importN) || !string.IsNullOrEmpty(bar.importFunJs))) ? Li_import : "");
                //str = str.Replace("{Li_export}", ((!string.IsNullOrEmpty(bar.exportN) || !string.IsNullOrEmpty(bar.exportFunJs))) ? Li_export : "");
                //str = str.Replace("{Li_search}", ((!string.IsNullOrEmpty(bar.searchN) || !string.IsNullOrEmpty(bar.searchFunJs))) ? Li_search : "");
            }
            else//默认生成的话根据配置进行生成
            {
                if (M_Model.M_IsAdd == 1)
                {
                    str = str.Replace("{Li_add}", Li_add);
                }
                else
                {
                    str = str.Replace("{Li_add}", "");
                }
                if (M_Model.M_IsEdit == 1)
                {
                    str = str.Replace("{Li_edit}", Li_edit);
                }
                else
                {
                    str = str.Replace("{Li_edit}", "");
                }
                if (M_Model.M_IsDelete == 1)
                {
                    str = str.Replace("{Li_del}", Li_del);
                }
                else
                {
                    str = str.Replace("{Li_del}", "");
                }
                if (M_Model.M_IsView == "true")
                {
                    str = str.Replace("{Li_view}", Li_view);
                }
                else
                {
                    str = str.Replace("{Li_view}", "");
                }
                //str = str.Replace("{Li_import}", Li_import);
                //str = str.Replace("{Li_export}", Li_export);

            }
            //搜索 默认输出
            str = str.Replace("{Li_search}", Li_search);
            if (M_Model.M_IsAdd == 1)
            {
                str = str.Replace("{toolbar_add}", addClass);
            }
            else
            {
                str = str.Replace("{toolbar_add}", "");
            }
            if (M_Model.M_IsEdit == 1)
            {
                str = str.Replace("{toolbar_edit}", editClass);
            }
            else
            {
                str = str.Replace("{toolbar_edit}", "");
            }
            str = str.Replace("{toolbar_delete}", delClass);
            if (M_Model.M_IsView == "true")
            {
                str = str.Replace("{toolbar_view}", viewClass);
            }
            else
            {
                str = str.Replace("{toolbar_view}", "");
            }
            //str = str.Replace("{toolbar_import}", importClass);
            //str = str.Replace("{toolbar_export}", exportClass);
            str = str.Replace("{toolbar_search}", searchClass);

            if (M_Model.M_IsAdd == 1)
            {
                str = str.Replace("{addJs}", addJS);
            }
            else
            {
                str = str.Replace("{addJs}", "");
            }
            if (M_Model.M_IsEdit == 1)
            {
                str = str.Replace("{editJs}", editJs);
            }
            else
            {
                str = str.Replace("{editJs}", "");
            }

            if (M_Model.M_IsDelete == 1)
            {
                str = str.Replace("{delJs}", delJs);
            }
            else
            {
                str = str.Replace("{delJs}", "");
            }

            if (M_Model.M_IsView == "true")
            {
                str = str.Replace("{viewJs}", viewJs);
            }
            else
            {
                str = str.Replace("{viewJs}", "");
            }

            //str = str.Replace("{viewJs}", viewJs);
            str = str.Replace("{searchJs}", searchJs);
            //str = str.Replace("{importJs}", importJs);
            //str = str.Replace("{exportJs}", exportJs);
            str = str.Replace("{searchJs}", searchJs);

            str = str.Replace("{prefix}", strPrefix);
            str = str.Replace("{newprefix}", prefix);
            str = str.Replace("{add}", add);
            str = str.Replace("{addN}", addN);
            str = str.Replace("{edit}", edit);
            str = str.Replace("{editN}", editN);
            str = str.Replace("{del}", del);
            str = str.Replace("{delN}", delN);

            str = str.Replace("{view}", view);

            str = str.Replace("{viewN}", viewN);
            //str = str.Replace("{import}", import);
            //str = str.Replace("{importN}", importN);
            //str = str.Replace("{export}", export);
            //str = str.Replace("{exportN}", exportN);
            str = str.Replace("{search}", search);
            str = str.Replace("{searchN}", searchN);

            str = str.Replace("{moduleName}", M_Model.M_ModuleCode);
            str = str.Replace("{nameSpace}", M_Model.M_NameSpace);
            if (toolbar)
            {
                str = "";
            }
            return str;
        }



        /// <summary>
        /// List中的Toolbar
        /// </summary>
        /// <param name="helper"></param>
        /// <param name="ModuleName">模块名字（模块名字+命名空间能与列表编辑整合）</param>
        /// <param name="custName">自定义命名前缀</param>
        /// <param name="ToolBarConfig">工具条配置 add:'0',addN:'增加',addFunJs:'ShowMsg('ssss')',addClass:''</param>
        /// <returns></returns>



        /// <summary>
        /// List中的Toolbar
        /// </summary>
        /// <param name="helper"></param>
        /// <param name="ModuleName">模块名字（模块名字+命名空间能与列表编辑整合）</param>
        /// <param name="custName">自定义命名前缀</param>
        /// <param name="ToolBarConfig">工具条配置 add:'0',addN:'增加',addFunJs:'ShowMsg('ssss')',addClass:''</param>
        /// <returns></returns>
        public static string Common_ToolBarForListPage(this HtmlHelper helper, object ModuleName, string custName, string ToolBarConfig)
        {
            ADOComm comInstance = new ADOComm();
            string strPrefix = "";
            //strPrefix = ModuleName == null ? custName : ModuleName.ToString();
            //strPrefix = ModuleName != null ? ModuleName.ToString() : "";
            //strPrefix = (ModuleName != null && !string.IsNullOrEmpty(custName)) ? custName+"_" + ModuleName.ToString() : "";

            strPrefix = string.IsNullOrEmpty(custName) ? ModuleName.ToString() : custName + "_";
            if ((ModuleName != null && !string.IsNullOrEmpty(custName)))
            {
                strPrefix = (ModuleName != null && !string.IsNullOrEmpty(custName)) ? custName + "_" + ModuleName.ToString() : "";
            }

            ToolBar bar = new ToolBar();
            if (!string.IsNullOrEmpty(ToolBarConfig))
            {
                bar = JsonConvert.DeserializeObject<ToolBar>("{" + ToolBarConfig + "}");
            }

            var HasAdd = 1;
            var HasEdit = 1;
            var HasView = 1;
            var HasDel = 1;
            var HasImport = 1;
            var HasExport = 1;

            var IS_OPEN_PERMISSION = ConfigHelper.GetApp("IS_OPEN_PERMISSION");
            if (!string.IsNullOrEmpty(IS_OPEN_PERMISSION) && IS_OPEN_PERMISSION == "true")
            {
                //var Permission = comInstance.UserPermissionList(QX.Config.SessionConfig.UserId());
                //HasAdd = Permission.Where(o => o.Fun_UDef1 == strPrefix + "_add").Count();
                //HasEdit = Permission.Where(o => o.Fun_UDef1 == strPrefix + "_edit").Count();
                //HasView = Permission.Where(o => o.Fun_UDef1 == strPrefix + "_view").Count();
                //HasDel = Permission.Where(o => o.Fun_UDef1 == strPrefix + "_delete").Count();
                //HasImport = Permission.Where(o => o.Fun_UDef1 == strPrefix + "_import").Count();
                //HasExport = Permission.Where(o => o.Fun_UDef1 == strPrefix + "_export").Count();
            }

            #region 按钮Html
            string Li_add = @"<li {add} id='{prefix}_toolbar_add' class='{toolbar_add}'><a class='hide' id='{prefix}_add' onclick='{prefix}ToolBar.Add()' href='javascript:void(0);'>{addN}</a></li>";
            string Li_edit = @"<li {edit} id='{prefix}_toolbar_edit' class='{toolbar_edit}'><a class='hide' id='{prefix}_edit' onclick='{prefix}ToolBar.Edit()' href='javascript:void(0);'>{editN}</a></li>";
            string Li_del = @"<li {del} id='{prefix}_toolbar_delete' class='{toolbar_delete}'><a class='hide' id='{prefix}_delete' onclick='{prefix}ToolBar.Delete()' href='javascript:void(0);'>{delN}</a></li> ";
            string Li_view = @"<li {view} id='{prefix}_toolbar_view' class='{toolbar_view}'><a class='hide' id='{prefix}_view' onclick='{prefix}ToolBar.View()' href='javascript:void(0);'>{viewN}</a></li> ";
            string Li_import = @"<li {import} id='{prefix}_toolbar_import' class='{toolbar_import}'><a class='hide' id='{prefix}_import' onclick='{prefix}ToolBar.Import()' href='javascript:void(0);'>{importN}</a></li>";
            string Li_export = @"<li {export} id='{prefix}_toolbar_export' class='{toolbar_export}'><a class='hide' id='{prefix}_export' onclick='{prefix}ToolBar.Export()' href='javascript:void(0);'>{exportN}</a></li>";
            string Li_search = @"<li {search} id='{prefix}_toolbar_search'  class='{toolbar_search}'><input style='display:none' id='search_txt' type='text' value='' />
                <a  id='{prefix}_search' onclick='{prefix}ToolBar.Search()' href='#'>{searchN}</a>
                </li>  ";

            #endregion

            #region 按钮解析
            bool toolbar = !string.IsNullOrEmpty(bar.toolbar) ? true : false;
            string add = !string.IsNullOrEmpty(bar.add) ? "style='display:none'" : "style='display:block'";
            string addN = !string.IsNullOrEmpty(bar.addN) ? bar.addN : "添加";
            string addClass = !string.IsNullOrEmpty(bar.addClass) ? bar.addClass : "toolbar_add";
            string edit = !string.IsNullOrEmpty(bar.edit) ? "style='display:none'" : "style='display:block'";
            string editN = !string.IsNullOrEmpty(bar.editN) ? bar.editN : "修改";
            string editClass = !string.IsNullOrEmpty(bar.editClass) ? bar.editClass : "toolbar_edit";
            string del = !string.IsNullOrEmpty(bar.del) ? "style='display:none'" : "style='display:block'";
            string delN = !string.IsNullOrEmpty(bar.delN) ? bar.delN : "删除";
            string delClass = !string.IsNullOrEmpty(bar.delClass) ? bar.delClass : "toolbar_delete";
            string view = !string.IsNullOrEmpty(bar.view) ? "style='display:none'" : "style='display:block'";
            string viewN = !string.IsNullOrEmpty(bar.viewN) ? bar.delN : "查看";
            string viewClass = !string.IsNullOrEmpty(bar.viewClass) ? bar.viewClass : "toolbar_view";
            string import = !string.IsNullOrEmpty(bar.import) ? "style='display:none'" : "style='display:block'";
            string importN = !string.IsNullOrEmpty(bar.importN) ? bar.importN : "导入";
            string importClass = !string.IsNullOrEmpty(bar.importClass) ? bar.importClass : "toolbar_import";
            string export = !string.IsNullOrEmpty(bar.export) ? "style='display:none'" : "style='display:block'";
            string exportN = !string.IsNullOrEmpty(bar.exportN) ? bar.exportN : "导出";
            string exportClass = !string.IsNullOrEmpty(bar.exportClass) ? bar.exportClass : "toolbar_export";
            string search = !string.IsNullOrEmpty(bar.search) ? "style='display:none'" : "style='display:block'";
            string searchN = !string.IsNullOrEmpty(bar.searchN) ? bar.searchN : "搜索";
            string searchClass = !string.IsNullOrEmpty(bar.searchClass) ? bar.searchClass : "toolbar_search";
            #endregion

            #region 事件定义
            string addJS = !string.IsNullOrEmpty(bar.addFunJs) ? "{prefix}" + bar.addFunJs : "{prefix}ToolBarAdd()";
            string editJs = !string.IsNullOrEmpty(bar.editFunJs) ? "{prefix}" + bar.editFunJs : "{prefix}ToolBarEdit()";
            string delJs = !string.IsNullOrEmpty(bar.delFunJs) ? "{prefix}" + bar.delFunJs : "{prefix}ToolBarDelete()";
            string viewJs = !string.IsNullOrEmpty(bar.viewFunJs) ? "{prefix}" + bar.viewFunJs : "{prefix}ToolBarView()";
            string importJs = !string.IsNullOrEmpty(bar.importFunJs) ? "{prefix}" + bar.importFunJs : "{prefix}ToolBarImport()";
            string exportJs = !string.IsNullOrEmpty(bar.exportFunJs) ? "{prefix}" + bar.exportFunJs : "{prefix}ToolBarExport()";
            string searchJs = !string.IsNullOrEmpty(bar.searchFunJs) ? "{prefix}" + bar.searchFunJs : "{prefix}ToolBarSearch()";
            #endregion

            #region HTML生成
            string str = @"
            <div id='{prefix}toolbar' class='toolbar'>
            <ul>
                {Li_add}
                {Li_edit}
                {Li_del}
                {Li_view}
                {Li_import}
                {Li_export}
                {Li_search}
            </ul>
             </div> 
             <script type='text/javascript'>
                 var {prefix}ToolBar = {
                     Add: function() {
                         {addJs};
                     },
                     Edit: function() {
                         {editJs};
                     },
                     Delete: function() {
                         {delJs};
                     },                     
                     View: function() {
                         {viewJs};
                     },
                     Search: function() {
                         {searchJs};
                     },
                     Import: function() {
                         {importJs};
                     },
                     Export: function() {
                         {exportJs};
                     },
                    HideElement:function(id){
                         $('#id').hide();
                    },
                    ChangeElement:function(id,name){
                         $('#id').find('a').val(name);
                    }
                 }  
                //插入菜单项 ：id, 文本,回调,位置(ID),样式
                var SysToolBar_{newprefix}={  
                    Insert:function(id,text,funjs,postion,objClass){ 
                        var toolbar = $('#{prefix}toolbar'); 
                        var InsertItem;
                        var InsertClass;
                        if(postion=='' || postion==undefined){
                            InsertItem=toolbar.find('#{prefix}_toolbar_search');
                        }else{
                            InsertItem=toolbar.find('#'+postion);
                        }
                        if(objClass=='' || objClass==undefined){
                            InsertClass='toolbar_btn1';
                        }else{
                            InsertClass=objClass;
                        }
                        var InsertHtml='<li id={prefix}_toolbar_'+id+' class='+InsertClass+'><a id={prefix}_'+id+' onclick='+funjs+' href=#>'+text+'</a></li>';
                        InsertItem.after(InsertHtml);
                     }  
                }
             
             </script>
            ";
            #endregion

            Li_add = HasAdd > 0 ? Li_add : "";
            Li_edit = HasEdit > 0 ? Li_edit : "";
            Li_del = HasDel > 0 ? Li_del : "";
            Li_import = HasImport > 0 ? Li_import : "";
            Li_export = HasExport > 0 ? Li_export : "";
            //Li_view = HasView > 0 ? Li_view : "";

            bool HasConfig = !string.IsNullOrEmpty(ToolBarConfig) ? true : false;
            if (HasConfig)
            {
                str = str.Replace("{Li_add}", ((!string.IsNullOrEmpty(bar.addN) || !string.IsNullOrEmpty(bar.addFunJs))) ? Li_add : !string.IsNullOrEmpty(bar.add) ? "" : Li_add);
                str = str.Replace("{Li_edit}", ((!string.IsNullOrEmpty(bar.editN) || !string.IsNullOrEmpty(bar.editFunJs))) ? Li_edit : !string.IsNullOrEmpty(bar.edit) ? "" : Li_edit);
                str = str.Replace("{Li_del}", ((!string.IsNullOrEmpty(bar.delN) || !string.IsNullOrEmpty(bar.delFunJs))) ? Li_del : !string.IsNullOrEmpty(bar.del) ? "" : Li_del);
                str = str.Replace("{Li_view}", ((!string.IsNullOrEmpty(bar.viewN) || !string.IsNullOrEmpty(bar.viewFunJs))) ? Li_view : !string.IsNullOrEmpty(bar.view) ? "" : Li_view);
                str = str.Replace("{Li_import}", ((!string.IsNullOrEmpty(bar.importN) || !string.IsNullOrEmpty(bar.importFunJs))) ? Li_import : !string.IsNullOrEmpty(bar.import) ? "" : Li_import);
                str = str.Replace("{Li_export}", ((!string.IsNullOrEmpty(bar.exportN) || !string.IsNullOrEmpty(bar.exportFunJs))) ? Li_export : !string.IsNullOrEmpty(bar.export) ? "" : Li_export);
                str = str.Replace("{Li_search}", ((!string.IsNullOrEmpty(bar.searchN) || !string.IsNullOrEmpty(bar.searchFunJs))) ? Li_search : !string.IsNullOrEmpty(bar.search) ? "" : Li_search);
            }
            else
            {
                str = str.Replace("{Li_add}", Li_add);
                str = str.Replace("{Li_edit}", Li_edit);
                str = str.Replace("{Li_del}", Li_del);
                str = str.Replace("{Li_view}", Li_view);
                str = str.Replace("{Li_import}", Li_import);
                str = str.Replace("{Li_export}", Li_export);
                str = str.Replace("{Li_search}", Li_search);
            }

            str = str.Replace("{toolbar_add}", addClass);
            str = str.Replace("{toolbar_edit}", editClass);
            str = str.Replace("{toolbar_delete}", delClass);
            str = str.Replace("{toolbar_view}", viewClass);
            str = str.Replace("{toolbar_import}", importClass);
            str = str.Replace("{toolbar_export}", exportClass);
            str = str.Replace("{toolbar_search}", searchClass);


            str = str.Replace("{addJs}", addJS);
            str = str.Replace("{editJs}", editJs);
            str = str.Replace("{delJs}", delJs);
            str = str.Replace("{viewJs}", viewJs);
            str = str.Replace("{searchJs}", searchJs);
            str = str.Replace("{importJs}", importJs);
            str = str.Replace("{exportJs}", exportJs);
            str = str.Replace("{searchJs}", searchJs);

            str = str.Replace("{prefix}", strPrefix);
            str = str.Replace("{newprefix}", custName);
            str = str.Replace("{add}", add);
            str = str.Replace("{addN}", addN);
            str = str.Replace("{edit}", edit);
            str = str.Replace("{editN}", editN);
            str = str.Replace("{del}", del);
            str = str.Replace("{delN}", delN);
            str = str.Replace("{view}", view);
            str = str.Replace("{viewN}", viewN);
            str = str.Replace("{import}", import);
            str = str.Replace("{importN}", importN);
            str = str.Replace("{export}", export);
            str = str.Replace("{exportN}", exportN);
            str = str.Replace("{search}", search);
            str = str.Replace("{searchN}", searchN);
            if (toolbar)
            {
                str = "";
            }
            return str;
        }

        /// <summary>
        /// ToolBar扩展
        /// </summary>
        /// <param name="helper"></param>
        /// <param name="prefix"></param>
        /// <param name="ToolBarConfigExtends"></param>
        /// <returns></returns>
        public static string Common_ToolBar_Extends(this HtmlHelper helper, object prefix, string ToolBarConfigExtends)
        {
            ADOComm comInstance = new ADOComm();
            var HasBtn1 = 1;
            var HasBtn2 = 1;
            var HasBtn3 = 1;
            var HasBtn4 = 1;

            var IS_OPEN_PERMISSION = ConfigHelper.GetApp("IS_OPEN_PERMISSION");
            if (!string.IsNullOrEmpty(IS_OPEN_PERMISSION) && IS_OPEN_PERMISSION == "true")
            {
                //var Permission = comInstance.UserPermissionList(QX.Config.SessionConfig.UserId());
                //HasBtn1 = Permission.Where(o => o.Fun_UDef1 == prefix + "_btn1a").Count();
                //HasBtn2 = Permission.Where(o => o.Fun_UDef1 == prefix + "_btn2a").Count();
                //HasBtn3 = Permission.Where(o => o.Fun_UDef1 == prefix + "_btn3a").Count();
                //HasBtn4 = Permission.Where(o => o.Fun_UDef1 == prefix + "_btn4a").Count();
            }

            if (string.IsNullOrEmpty(ToolBarConfigExtends))
            {
                return string.Empty;
            }

            string html = string.Empty;
            html = @"
            <script type='text/javascript'> 
                var {prefix}ToolBarExtends = {
                     Btn1: function() {
                         if (typeof ({prefix}Btn1) != 'undefined') {
                             {prefix}Btn1();
                         }
                     },
                     Btn2: function() {
                         if (typeof ({prefix}Btn2) != 'undefined') {
                             {prefix}Btn2();
                         }
                     },
                     Btn3: function() {
                         if (typeof ({prefix}Btn3) != 'undefined') {
                             {prefix}Btn3();
                         }
                     },
                     Btn4: function() {
                         if (typeof ({prefix}Btn4) != 'undefined') {
                             {prefix}Btn4();
                         }
                     }
                }
                $('ul li:last-child').after({'}{strHtml}{'});
            </script>
            ";
            StringBuilder strHtml = new StringBuilder();
            ToolBarExtends bar = new ToolBarExtends();
            if (!string.IsNullOrEmpty(ToolBarConfigExtends))
            {
                bar = JsonConvert.DeserializeObject<ToolBarExtends>("{" + ToolBarConfigExtends + "}");

                if (!string.IsNullOrEmpty(bar.btn1N))
                {
                    string str1 = "<li id='{prefix}_btn1' class='toolbar_btn1'><a class='hide' id='{prefix}_btn1a' onclick='{prefix}ToolBarExtends.Btn1()' href='#'>" +
                        bar.btn1N + "</a></li>";
                    if (HasBtn1 > 0)
                    {
                        strHtml.AppendLine(str1);
                    }

                }
                if (!string.IsNullOrEmpty(bar.btn2N))
                {
                    string str2 = "<li id='{prefix}_btn2' class='toolbar_btn2'><a class='hide' id='{prefix}_btn2a' onclick='{prefix}ToolBarExtends.Btn2()' href='#'>" +
                        bar.btn2N + "</a></li>";
                    if (HasBtn2 > 0)
                    {
                        strHtml.AppendLine(str2);
                    }

                }
                if (!string.IsNullOrEmpty(bar.btn3N))
                {
                    string str3 = "<li id='{prefix}_btn3' class='toolbar_btn3'><a class='hide' id='{prefix}_btn3a' onclick='{prefix}ToolBarExtends.Btn3()' href='#'>" +
                        bar.btn3N + "</a></li>";
                    if (HasBtn3 > 0)
                    {
                        strHtml.AppendLine(str3);
                    }

                }
                if (!string.IsNullOrEmpty(bar.btn4N))
                {
                    string str4 = "<li id='{prefix}_btn4' class='toolbar_btn4'><a class='hide' id='{prefix}_btn4a' onclick='{prefix}ToolBarExtends.Btn4()' href='#'>" +
                        bar.btn3N + "</a></li>";
                    if (HasBtn4 > 0)
                    {
                        strHtml.AppendLine(str4);
                    }

                }

                strHtml = strHtml.Replace("{prefix}", prefix.ToString());
                html = html.Replace("{prefix}", prefix.ToString())
                           .Replace("{strHtml}", strHtml.ToString().Trim().Replace("\r", "").Replace("\n", ""))
                           .Replace("{'}", "\"");
            }
            return html;
        }

        /// <summary>
        /// 工具条生成
        /// </summary>
        /// <param name="helper"></param>
        /// <param name="prefix"></param>
        /// <returns></returns>
        //[Obsolete("废弃不用",true)]
        public static string Common_ToolBar(this HtmlHelper helper, object prefix)
        {

            #region HTML生成
            string str = @"
            <div id='{prefix}toolbar' class='toolbar'>
            <ul>
                <li id='{prefix}_toolbar_add' class='toolbar_add'><a id='{prefix}_add' class='hide' onclick='{prefix}ToolBar.Add()' href='javascript:void(0);'>添加</a></li>
                <li id='{prefix}_toolbar_edit' class='toolbar_edit'><a id='{prefix}_edit' class='hide' onclick='{prefix}ToolBar.Edit()' href='javascript:void(0);'>修改</a></li>
                <li id='{prefix}_toolbar_delete' class='toolbar_delete'><a id='{prefix}_delete' class='hide' onclick='{prefix}ToolBar.Delete()' href='javascript:void(0);'>删除</a></li> 
                <li id='{prefix}_toolbar_view' class='toolbar_view'><a id='{prefix}_view' class='hide' onclick='{prefix}ToolBar.View()' href='javascript:void(0);'>查看</a></li>    
                <li id='{prefix}_toolbar_import' class='toolbar_import'><a id='{prefix}_import' class='hide' onclick='{prefix}ToolBar.Import()' href='javascript:void(0);'>导入</a></li>
                <li id='{prefix}_toolbar_export' class='toolbar_export'><a id='{prefix}_export' class='hide' onclick='{prefix}ToolBar.Export()' href='javascript:void(0);'>导出</a></li>
                <li id='{prefix}_toolbar_search'  class='toolbar_search'><input style='display:none' id='search_txt' type='text' value='' /><a id='{prefix}_search' onclick='{prefix}ToolBar.Search()' href='#'>查找</a></li>    
            </ul>
             </div> 
             <script type='text/javascript'>
                 var {prefix}ToolBar = {
                     Add: function() {
                         if (typeof ({prefix}ToolBarAdd) !='undefined') {
                             {prefix}ToolBarAdd();
                         }
                     },
                     Edit: function() {
                         if (typeof ({prefix}ToolBarEdit) !='undefined') {                 
                             {prefix}ToolBarEdit();
                         }
                     },
                     Delete: function() {
                         if (typeof ({prefix}ToolBarDelete) != 'undefined') {
                             {prefix}ToolBarDelete();
                         }
                     },
                     View: function() {
                         if (typeof ({prefix}ToolBarView) != 'undefined') {
                             {prefix}ToolBarView();
                         }
                     },
                     Search: function() {
                         if (typeof ({prefix}ToolBarSearch) !='undefined') {
                             {prefix}ToolBarSearch();
                         }
                     },
                     Import: function() {
                         if (typeof ({prefix}ToolBarImport) != 'undefined') {
                             {prefix}ToolBarImport();
                         }
                     },
                     Export: function() {
                         if (typeof ({prefix}ToolBarExport) != 'undefined') {
                             {prefix}ToolBarExport();
                         }
                     },
                     HideElement:function(id){
                         $('#id').hide();
                     },
                     ChangeElement:function(id,name){
                         $('#id').find('a').val(name);
                     }
                 }  

                //插入菜单项：文本,回调,位置(ID),样式
                var SysToolBar_{prefix}={  
                    Insert:function(id,text,funjs,postion,objClass){ 
                        var toolbar = $('#{prefix}toolbar'); 
                        var InsertItem;
                        var InsertClass;
                        if(postion=='' || postion==undefined){
                            InsertItem=toolbar.find('#{prefix}_toolbar_search');
                        }else{
                            InsertItem=toolbar.find('#'+postion);
                        }
                        if(objClass=='' || objClass==undefined){
                            InsertClass='toolbar_btn1';
                        }else{
                            InsertClass=objClass;
                        }
                        var InsertHtml='<li id={prefix}_toolbar_'+id+' class='+InsertClass+'><a id={prefix}_'+id+' onclick='+funjs+' href=#>'+text+'</a></li>';
                        InsertItem.after(InsertHtml);
                     }  
                }
             
             </script>
            ";
            #endregion
            string strPrefix = "";
            if (prefix == null)
            {
                strPrefix = "";
            }
            else
            {
                strPrefix = prefix.ToString();
            }
            str = str.Replace("{prefix}", strPrefix);
            return str;
        }

    }
}
