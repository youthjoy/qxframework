using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Web.Mvc;
using System.Web.Mvc.Html;
using System.ComponentModel;

using QX.Comm;
using QX.HtmlHelperLib.Model;
using QX.HtmlHelperLib.DAL;
using Newtonsoft.Json;
using QX.Config;
using System.Collections;
using System.Web;
using System.Data;
using System.Text.RegularExpressions;

namespace QX.HtmlHelperLib
{
    /// <summary>
    /// JqGrid 页面配置类 
    /// </summary>
    public static class JqGridSys_Config_ListPage
    {
        // Modify BY QB 
        // Modify:每个优雅的接口后面都有一个龌龊的实现
        // Modify Date:2011-3-22

        #region 通用附加列表组件

        /// <summary>
        /// 通用附加列表组件
        /// </summary>
        /// <param name="hepler"></param>
        /// <param name="ModuleName">模块名称</param>
        /// <param name="NameSpace">模块命名空间</param>
        /// <param name="RecordID">单据编码</param>
        /// <returns></returns>
        //public static string AttachComponent(this HtmlHelper hepler,
        //                                     string ModuleName, string NameSpace, string Module, string JqueryCodeObj)
        //{
        //    return AttachComponent(hepler, ModuleName, NameSpace, Module, JqueryCodeObj, "", "");
        //}

        //        public static string AttachComponent(this HtmlHelper hepler,
        //                                             string ModuleName, string NameSpace, string Module,
        //            string JqueryCodeObj, string itype, string type)
        //        {
        //            string html = string.Empty;
        //            Sys_Config_ListPage M_Model = new Sys_Config_ListPage();
        //            List<Sys_Config_Fieled> D_List = new List<Sys_Config_Fieled>();
        //            GetListConfig(ModuleName, out M_Model, out D_List);

        //            //html = hepler.JqGridListPage(ModuleName, NameSpace, "", "", ""); 
        //            html += JqGridToolBar(hepler, ModuleName, NameSpace, M_Model.M_ToolBar);
        //            html += hepler.SysComm_JqGridForAttachCompent(ModuleName, NameSpace, "", "", "", itype, type, false);
        //            html += AutoBindForm(M_Model, D_List, true, true, true, "center");
        //            html += FormOperForList(M_Model, D_List);
        //            html += AutoBindValidate(D_List, "");

        //            html += string.Format("<input id='{0}_sys_modulecode' type='hidden' value='{1}' />", NameSpace, Module);
        //            html += string.Format("<input id='{0}_sys_RecordId' type='hidden' value='{1}' />", NameSpace, "");
        //            //html += "<script> var comm_" + ModuleName + "={ SetId:function(id){ $('#" + NameSpace + "_sys_RecordId').val(id); }  } </script>";//添加时设置绑定编码         
        //            string extJs = @"
        //                  <script>
        //                  //通用附加组件
        //                  function {FormId}LoadAfter(oper){
        //                        $('#{FormId}').find('#Module_Code').val('{Module}');
        //                        $('#{FormId}').find('#Record_ID').val({CodeObj}.val());
        //                  }
        //
        //                  var {FormId}_timeId;
        //                    
        //                  function {FormId}_Time() {
        //
        //                    {FormId}_timeId = setInterval({FormId}_Call, 1000);
        //
        //                  }
        //                    
        //                  function {FormId}_Call()
        //                  { 
        //                        var v={CodeObj}.val();
        //                        if(v!=undefined && v!='')
        //                        {
        //                            {FormId}LoadRefresh();
        //                            clearInterval({FormId}_timeId);
        //                        }
        //                  }
        //
        //                  $(function(){
        //                      //{FormId}LoadRefresh(); 
        //                      //{CodeObj}.change(function(){ var self=$(this); LoadRefresh();    });
        //                      //SetTime循环判断是否有值，如果有值，则加载组件
        //                      {FormId}_Time();
        //                  });
        //                  function {FormId}LoadRefresh()
        //                  {
        //                       var grid=$('#{NameSpace}grid');
        //                       $('#{FormId}').find('#Record_ID').val({CodeObj}.val());
        //                       //grid.jqGrid('setPostData',{ record: {CodeObj}.val() });
        //                       //grid.setGridParam({url:'{URL}'}).trigger('reloadGrid');
        //                       {NameSpace}_{ModuleName}_GridControl.Init('{URL}&record='+{CodeObj}.val(),'{NameSpace}');                       
        //                  }
        //                  function {FormId}GridExpand()
        //                  {
        //                       $('#gview_{NameSpace}grid').find('.ui-jqgrid-titlebar-close').trigger('click');
        //                  } 
        //                  function  DoRefresh()
        //                  {
        //                       if(document.readyState == 'complete'){ LoadRefresh(); } 
        //                  }
        //                  //document.onreadystatechange=DoRefresh;                    
        //                  //window.onload=function(){ {FormId}LoadRefresh(); };  
        ////                    var {FormId}tout;
        ////                    $(function() { {FormId}tout = setTimeout('{FormId}init()', 100); });
        ////
        ////                    function {FormId}init() {
        ////                        if ({CodeObj}.val()!='') {
        ////                          {FormId}LoadRefresh();
        ////                          clearTimeout({FormId}tout);
        ////                      }
        ////                    }          
        //
        //             </script>        
        //            ";

        //            string url = "/Sys_Config_ListPage/InitGrid/?ModuleCode=" + ModuleName + "&NameSpace=" + NameSpace
        //                + "&itype=" + itype + "&type=" + type;

        //            extJs = extJs.Replace("{Module}", Module);
        //            extJs = extJs.Replace("{NameSpace}", NameSpace);
        //            extJs = extJs.Replace("{CodeObj}", JqueryCodeObj);
        //            extJs = extJs.Replace("{URL}", url);
        //            extJs = extJs.Replace("{FormId}", NameSpace + "_Form");
        //            extJs = extJs.Replace("{ModuleName}", ModuleName);
        //            html += extJs;

        //            return html;
        //        }


        /// <summary>
        /// 通用附加列表组件
        /// </summary>
        /// <param name="hepler"></param>
        /// <param name="ModuleName">模块名称</param>
        /// <param name="NameSpace">模块命名空间</param>
        /// <param name="RecordID">单据编码</param>
        /// <returns></returns>
        //public static string AttachComponent(this HtmlHelper hepler,
        //                                     string ModuleName, string NameSpace, string Module, string RecordID)
        //{
        //    string html = string.Empty;
        //    string _record = !string.IsNullOrEmpty(RecordID) ? RecordID : "";
        //    html = hepler.JqGridListPage(ModuleName, NameSpace, "", "", _record);
        //    html += string.Format("<input id='{0}_sys_modulecode' type='hidden' value='{1}' />", NameSpace, Module);
        //    html += string.Format("<input id='{0}_sys_RecordId' type='hidden' value='{1}' />", NameSpace, RecordID);
        //    html += "<script> var comm_" + ModuleName + "={ SetId:function(id){ $('#" + NameSpace + "_sys_RecordId').val(id); }  } </script>";//添加时设置绑定编码         
        //    return html;
        //}

        #endregion

        #region 通用页面组件 List :具备增删改查功能

        /// <summary>
        /// 通用页面组件 List :生成列表，以ModuleName为关键字生成ToolBar相关信息， By Ye Fei 2011-01-30
        /// </summary>
        /// <param name="helper"></param>
        /// <param name="ModuleName">模块名称</param>
        /// <param name="NameSpace">命名空间</param>
        /// <returns></returns>
        //public static string JqGridListPageY1OnlyList(this HtmlHelper helper, string ModuleName, string NameSpace, string itype, string type, string record)
        //{
        //    string html = string.Empty;

        //    #region 生成页面代码

        //    try
        //    {
        //        ADOSys_Config_ListPage ListInstance = new ADOSys_Config_ListPage();
        //        ADOSys_Config_Fieled FieledInstance = new ADOSys_Config_Fieled();

        //        Sys_Config_ListPage M_Model = new Sys_Config_ListPage();
        //        List<Sys_Config_Fieled> D_List = new List<Sys_Config_Fieled>();

        //        if (!string.IsNullOrEmpty(ModuleName))
        //        {
        //            //第一步：根据传入模块获取Grid配置
        //            List<Sys_Config_ListPage> _ListPage = ListInstance.GetListByWhere(" AND M_ModuleCode='" +
        //                ModuleName + "'");
        //            if (_ListPage.Count > 0)
        //            {
        //                M_Model = _ListPage[0];
        //            }
        //            //第二步：根据模块获取所有字段
        //            D_List = FieledInstance.GetListByWhere(" AND D_ModuleCode='" + ModuleName + "'");

        //            //第三步：绑定ToolBar
        //            //html += JqGridToolBar(helper, ModuleName, NameSpace, M_Model.M_ToolBar);
        //            html += helper.Common_ToolBarForListPage(NameSpace, "", M_Model.M_ToolBar);

        //            //第四步：绑定JqGrid
        //            html += JqGridY1OnlyList(helper, ModuleName, "", M_Model, D_List, itype, type, record, true);

        //            //第五步：绑定编辑层
        //            //html += AutoBindForm(M_Model, D_List, true, true, true, "center");

        //            //生成表单操作方法
        //            html += FormOperForList(M_Model, D_List);

        //            //生成表单验证方法
        //            //html += AutoBindValidate(D_List, "");

        //            //第六步：绑定扩展JS代码


        //            //第七步:生成扩展ToolBar
        //            html += helper.Common_ToolBar_Extends(ModuleName, M_Model.M_ToolBarExtend);

        //            //第八步:生成扩展编辑层【生成四个按钮层】
        //            //ToolBarExtends bar = new ToolBarExtends();
        //            //bar = JsonConvert.DeserializeObject<ToolBarExtends>("{" + M_Model.M_ToolBarExtend + "}");
        //            //if (!string.IsNullOrEmpty(bar.btn1N))
        //            //{
        //            //    html += AutoBindForm(M_Model, D_List, "btn1Layer", "btn1Form");
        //            //}
        //            //if (!string.IsNullOrEmpty(bar.btn2N))
        //            //{
        //            //    html += AutoBindForm(M_Model, D_List, "btn2Layer", "btn2Form");
        //            //}
        //            //if (!string.IsNullOrEmpty(bar.btn3N))
        //            //{
        //            //    html += AutoBindForm(M_Model, D_List, "btn3Layer", "btn3Form");
        //            //}
        //            //if (!string.IsNullOrEmpty(bar.btn4N))
        //            //{
        //            //    html += AutoBindForm(M_Model, D_List, "btn4Layer", "btn4Form");
        //            //}

        //            //第九步：生成Js代码
        //            html += JqGridExtendsJs(helper, M_Model.M_ExtendsJs, M_Model.M_ExtendsControl);
        //        }
        //    }
        //    catch (System.Exception ex)
        //    {
        //        throw ex;
        //    }

        //    #endregion

        //    return html;
        //}

        /// <summary>
        /// 通用页面组件 List :具备增删改查功能
        /// </summary>
        /// <param name="helper"></param>
        /// <param name="ModuleName">模块名称</param>
        /// <param name="NameSpace">命名空间</param>
        /// <returns></returns>
        //public static string JqGridListPage(this HtmlHelper helper, string ModuleName, string NameSpace, string itype, string type, string record)
        //{
        //    string html = string.Empty;

        //    #region 生成页面代码

        //    try
        //    {
        //        ADOSys_Config_ListPage ListInstance = new ADOSys_Config_ListPage();
        //        ADOSys_Config_Fieled FieledInstance = new ADOSys_Config_Fieled();

        //        Sys_Config_ListPage M_Model = new Sys_Config_ListPage();
        //        List<Sys_Config_Fieled> D_List = new List<Sys_Config_Fieled>();

        //        if (!string.IsNullOrEmpty(ModuleName))
        //        {
        //            //第一步：根据传入模块获取Grid配置
        //            List<Sys_Config_ListPage> _ListPage = ListInstance.GetListByWhere(" AND M_ModuleCode='" +
        //                ModuleName + "'");
        //            if (_ListPage.Count > 0)
        //            {
        //                M_Model = _ListPage[0];
        //            }
        //            //第二步：根据模块获取所有字段
        //            D_List = FieledInstance.GetListByWhere(" AND D_ModuleCode='" + ModuleName + "'");

        //            //第三步：绑定ToolBar
        //            html += JqGridToolBar(helper, ModuleName, NameSpace, M_Model.M_ToolBar);

        //            //第四步：绑定JqGrid
        //            html += JqGrid(helper, ModuleName, "", M_Model, D_List, itype, type, record, true);

        //            //第五步：绑定编辑层
        //            html += AutoBindForm(M_Model, D_List, true, true, true, "center");

        //            //生成表单操作方法
        //            html += FormOperForList(M_Model, D_List);

        //            //生成表单验证方法
        //            html += AutoBindValidate(D_List, "");

        //            //第六步：绑定扩展JS代码


        //            //第七步:生成扩展ToolBar
        //            html += helper.Common_ToolBar_Extends(NameSpace + "_" + ModuleName, M_Model.M_ToolBarExtend);

        //            //第八步:生成扩展编辑层【生成四个按钮层】
        //            ToolBarExtends bar = new ToolBarExtends();
        //            bar = JsonConvert.DeserializeObject<ToolBarExtends>("{" + M_Model.M_ToolBarExtend + "}");
        //            if (!string.IsNullOrEmpty(bar.btn1N))
        //            {
        //                html += AutoBindForm(M_Model, D_List, "btn1Layer", "btn1Form");
        //            }
        //            if (!string.IsNullOrEmpty(bar.btn2N))
        //            {
        //                html += AutoBindForm(M_Model, D_List, "btn2Layer", "btn2Form");
        //            }
        //            if (!string.IsNullOrEmpty(bar.btn3N))
        //            {
        //                html += AutoBindForm(M_Model, D_List, "btn3Layer", "btn3Form");
        //            }
        //            if (!string.IsNullOrEmpty(bar.btn4N))
        //            {
        //                html += AutoBindForm(M_Model, D_List, "btn4Layer", "btn4Form");
        //            }

        //            //第九步：生成Js代码
        //            html += JqGridExtendsJs(helper, M_Model.M_ExtendsJs, M_Model.M_ExtendsControl);
        //        }
        //    }
        //    catch (System.Exception ex)
        //    {
        //        throw ex;
        //    }

        //    #endregion

        //    return html;
        //}

        /// <summary>
        /// 
        /// </summary>
        /// <param name="helper"></param>
        /// <param name="ModuleName"></param>
        /// <param name="NameSpace"></param>
        /// <param name="itype"></param>
        /// <param name="type"></param>
        /// <param name="record"></param>
        /// <param name="flag">是否仅显示工具条</param>
        /// <returns></returns>
        //public static string JqGridListPage(this HtmlHelper helper, string ModuleName, string NameSpace, string itype, string type, string record, bool flag)
        //{
        //    string html = string.Empty;

        //    #region 生成页面代码

        //    try
        //    {
        //        ADOSys_Config_ListPage ListInstance = new ADOSys_Config_ListPage();
        //        ADOSys_Config_Fieled FieledInstance = new ADOSys_Config_Fieled();

        //        Sys_Config_ListPage M_Model = new Sys_Config_ListPage();
        //        List<Sys_Config_Fieled> D_List = new List<Sys_Config_Fieled>();

        //        if (!string.IsNullOrEmpty(ModuleName))
        //        {
        //            //第一步：根据传入模块获取Grid配置
        //            List<Sys_Config_ListPage> _ListPage = ListInstance.GetListByWhere(" AND M_ModuleCode='" +
        //                ModuleName + "'");
        //            if (_ListPage.Count > 0)
        //            {
        //                M_Model = _ListPage[0];
        //            }
        //            //第二步：根据模块获取所有字段
        //            D_List = FieledInstance.GetListByWhere(" AND D_ModuleCode='" + ModuleName + "'");

        //            //第三步：绑定ToolBar
        //            html += JqGridToolBar(helper, ModuleName, NameSpace, M_Model.M_ToolBar);


        //            //第四步：绑定JqGrid
        //            html += JqGrid(helper, ModuleName, "", M_Model, D_List, itype, type, record, true);

        //            if (!flag)
        //            {
        //                //第五步：绑定编辑层
        //                html += AutoBindForm(M_Model, D_List, true, true, true, "center");

        //                //生成表单操作方法
        //                html += FormOperForList(M_Model, D_List);

        //                //生成表单验证方法
        //                html += AutoBindValidate(D_List, "");

        //                //第六步：绑定扩展JS代码


        //                //第七步:生成扩展ToolBar
        //                html += helper.Common_ToolBar_Extends(NameSpace + "_" + ModuleName, M_Model.M_ToolBarExtend);

        //                //第八步:生成扩展编辑层【生成四个按钮层】
        //                ToolBarExtends bar = new ToolBarExtends();
        //                bar = JsonConvert.DeserializeObject<ToolBarExtends>("{" + M_Model.M_ToolBarExtend + "}");
        //                if (!string.IsNullOrEmpty(bar.btn1N))
        //                {
        //                    html += AutoBindForm(M_Model, D_List, "btn1Layer", "btn1Form");
        //                }
        //                if (!string.IsNullOrEmpty(bar.btn2N))
        //                {
        //                    html += AutoBindForm(M_Model, D_List, "btn2Layer", "btn2Form");
        //                }
        //                if (!string.IsNullOrEmpty(bar.btn3N))
        //                {
        //                    html += AutoBindForm(M_Model, D_List, "btn3Layer", "btn3Form");
        //                }
        //                if (!string.IsNullOrEmpty(bar.btn4N))
        //                {
        //                    html += AutoBindForm(M_Model, D_List, "btn4Layer", "btn4Form");
        //                }

        //                //第九步：生成Js代码
        //                html += JqGridExtendsJs(helper, M_Model.M_ExtendsJs, M_Model.M_ExtendsControl);
        //            }
        //        }
        //    }
        //    catch (System.Exception ex)
        //    {
        //        throw ex;
        //    }

        //    #endregion

        //    return html;
        //}


        //       public static string JqGridListPageNoTool(this HtmlHelper helper, string ModuleName, string NameSpace, string itype, string type, string record)
        //       {
        //           string html = string.Empty;

        //           #region 生成页面代码

        //           try
        //           {
        //               ADOSys_Config_ListPage ListInstance = new ADOSys_Config_ListPage();
        //               ADOSys_Config_Fieled FieledInstance = new ADOSys_Config_Fieled();

        //               Sys_Config_ListPage M_Model = new Sys_Config_ListPage();
        //               List<Sys_Config_Fieled> D_List = new List<Sys_Config_Fieled>();

        //               if (!string.IsNullOrEmpty(ModuleName))
        //               {
        //                   //第一步：根据传入模块获取Grid配置
        //                   List<Sys_Config_ListPage> _ListPage = ListInstance.GetListByWhere(" AND M_ModuleCode='" +
        //                       ModuleName + "'");
        //                   if (_ListPage.Count > 0)
        //                   {
        //                       M_Model = _ListPage[0];
        //                   }
        //                   //第二步：根据模块获取所有字段
        //                   D_List = FieledInstance.GetListByWhere(" AND D_ModuleCode='" + ModuleName + "'");

        //                   //第三步：绑定ToolBar
        //                   //html += JqGridToolBar(helper, ModuleName, NameSpace, M_Model.M_ToolBar);


        //                   //第四步：绑定JqGrid
        //                   html += JqGrid(helper, ModuleName, "", M_Model, D_List, itype, type, record, true);


        //                   //第五步：绑定编辑层
        //                   // html += AutoBindForm(M_Model, D_List, true, true, true, "center");

        //                   //生成表单操作方法
        //                   // html += FormOperForList(M_Model, D_List);

        //                   //生成表单验证方法
        //                   // html += AutoBindValidate(D_List, "");

        //                   //第六步：绑定扩展JS代码


        //                   //第七步:生成扩展ToolBar
        //                   // html += helper.Common_ToolBar_Extends(NameSpace + "_" + ModuleName, M_Model.M_ToolBarExtend);

        //                   //第八步:生成扩展编辑层【生成四个按钮层】
        //                   //ToolBarExtends bar = new ToolBarExtends();
        //                   // bar = JsonConvert.DeserializeObject<ToolBarExtends>("{" + M_Model.M_ToolBarExtend + "}");
        //                   /* if (!string.IsNullOrEmpty(bar.btn1N))
        //                    {
        //                        html += AutoBindForm(M_Model, D_List, "btn1Layer", "btn1Form");
        //                    }
        //                    if (!string.IsNullOrEmpty(bar.btn2N))
        //                    {
        //                        html += AutoBindForm(M_Model, D_List, "btn2Layer", "btn2Form");
        //                    }
        //                    if (!string.IsNullOrEmpty(bar.btn3N))
        //                    {
        //                        html += AutoBindForm(M_Model, D_List, "btn3Layer", "btn3Form");
        //                    }
        //                    if (!string.IsNullOrEmpty(bar.btn4N))
        //                    {
        //                        html += AutoBindForm(M_Model, D_List, "btn4Layer", "btn4Form");
        //                    }

        //                    //第九步：生成Js代码
        //                    html += JqGridExtendsJs(helper, M_Model.M_ExtendsJs, M_Model.M_ExtendsControl);
        //*/
        //               }
        //           }
        //           catch (System.Exception ex)
        //           {
        //               throw ex;
        //           }

        //           #endregion

        //           return html;
        //       }

        #endregion

        #region 通用页面组件 List :具备增删改查功能
        /// <summary>
        /// 通用页面组件 List :具备增删改查功能
        /// </summary>
        /// <param name="helper"></param>
        /// <param name="ModuleName">模块名称</param>
        /// <param name="NameSpace">命名空间</param>
        /// <param name="itype">内置类型</param>
        /// <param name="type">普通类型</param>
        /// <param name="AllowToolBar">允许工具条</param>
        /// <param name="AllowToolBarEx">允许扩展</param>
        /// <param name="AllowLayer">允许编辑</param>
        /// <param name="AllowLayerEx">允许扩展按钮层</param>
        /// <param name="AllowJsEx">允许扩展JS</param>
        /// <returns></returns>
        //public static string JqGridListPage(this HtmlHelper helper,
        //    string ModuleName, string NameSpace,
        //    string itype, string type,
        //    bool AllowToolBar, bool AllowToolBarEx,
        //    bool AllowLayer, bool AllowLayerEx,
        //    bool AllowJsEx)
        //{
        //    string html = string.Empty;

        //    #region 生成页面代码

        //    try
        //    {
        //        ADOSys_Config_ListPage ListInstance = new ADOSys_Config_ListPage();
        //        ADOSys_Config_Fieled FieledInstance = new ADOSys_Config_Fieled();

        //        Sys_Config_ListPage M_Model = new Sys_Config_ListPage();
        //        List<Sys_Config_Fieled> D_List = new List<Sys_Config_Fieled>();

        //        if (!string.IsNullOrEmpty(ModuleName))
        //        {
        //            //第一步：根据传入模块获取Grid配置
        //            List<Sys_Config_ListPage> _ListPage = ListInstance.GetListByWhere(" AND M_ModuleCode='" +
        //                ModuleName + "' AND M_NameSpace='" + NameSpace + "'");
        //            if (_ListPage.Count > 0)
        //            {
        //                M_Model = _ListPage[0];
        //            }
        //            //第二步：根据模块获取所有字段
        //            D_List = FieledInstance.GetListByWhere(" AND D_ModuleCode='" + ModuleName + "' AND D_NameSpace='" + NameSpace + "'");
        //            if (AllowToolBar)
        //            {
        //                //第三步：绑定ToolBar
        //                html += JqGridToolBar(helper, ModuleName, NameSpace, M_Model.M_ToolBar);
        //            }

        //            //第四步：绑定JqGrid
        //            html += JqGrid(helper, ModuleName, "", M_Model, D_List, itype, type, "", true);

        //            if (AllowLayer)
        //            {
        //                //第五步：绑定编辑层
        //                html += AutoBindForm(M_Model, D_List, true, true, true, "center");
        //                html += FormOperForList(M_Model, D_List);
        //            }

        //            //第六步：绑定扩展JS代码

        //            if (AllowToolBarEx)
        //            {
        //                //第七步:生成扩展ToolBar
        //                html += helper.Common_ToolBar_Extends(NameSpace + "_" + ModuleName, M_Model.M_ToolBarExtend);
        //            }
        //            if (AllowLayerEx)
        //            {
        //                #region

        //                //第八步:生成扩展编辑层【生成四个按钮层】
        //                ToolBarExtends bar = new ToolBarExtends();
        //                bar = JsonConvert.DeserializeObject<ToolBarExtends>("{" + M_Model.M_ToolBarExtend + "}");
        //                if (!string.IsNullOrEmpty(bar.btn1N))
        //                {
        //                    html += AutoBindForm(M_Model, D_List, "btn1Layer", "btn1Form");
        //                }
        //                if (!string.IsNullOrEmpty(bar.btn2N))
        //                {
        //                    html += AutoBindForm(M_Model, D_List, "btn2Layer", "btn2Form");
        //                }
        //                if (!string.IsNullOrEmpty(bar.btn3N))
        //                {
        //                    html += AutoBindForm(M_Model, D_List, "btn3Layer", "btn3Form");
        //                }
        //                if (!string.IsNullOrEmpty(bar.btn4N))
        //                {
        //                    html += AutoBindForm(M_Model, D_List, "btn4Layer", "btn4Form");
        //                }
        //                #endregion
        //            }
        //            if (AllowJsEx)
        //            {
        //                //第九步：生成Js代码
        //                html += JqGridExtendsJs(helper, M_Model.M_ExtendsJs, M_Model.M_ExtendsControl);
        //            }
        //        }
        //    }
        //    catch (System.Exception ex)
        //    {
        //        throw ex;
        //    }

        //    #endregion

        //    return html;
        //}
        #endregion

        #region 生成Grid的工具条
        /// <summary>
        /// 生成Grid的工具条
        /// </summary>
        /// <returns></returns>
        //public static string JqGridToolBar(this HtmlHelper helper, string ModuleName, string Namespace, string Config)
        //{
        //    //工具条按钮定制
        //    return helper.Common_ToolBarForListPage(Namespace + "_" + ModuleName, "", Config);
        //}
        #endregion

        #region 生成JqGrid

        /// <summary>
        /// 生成JqGrid
        /// </summary>
        /// <returns></returns>
        //public static string JqGrid(this HtmlHelper helper, string ModuleName, string CustNameSpace, string itype, string type)
        //{
        //    ADOSys_Config_ListPage ListInstance = new ADOSys_Config_ListPage();
        //    ADOSys_Config_Fieled FieledInstance = new ADOSys_Config_Fieled();

        //    Sys_Config_ListPage M_Model = new Sys_Config_ListPage();
        //    List<Sys_Config_Fieled> D_List = new List<Sys_Config_Fieled>();

        //    List<Sys_Config_ListPage> _ListPage = ListInstance.GetListByWhere(" AND M_ModuleCode='" + ModuleName + "'");
        //    if (_ListPage.Count > 0)
        //    {
        //        M_Model = _ListPage[0];
        //    }
        //    //第二步：根据模块获取所有字段
        //    D_List = FieledInstance.GetListByWhere(" AND D_ModuleCode='" + ModuleName + "'");

        //    string html = JqGrid(helper, ModuleName, CustNameSpace, M_Model, D_List, itype, type, "", true);

        //    string toolbar = helper.Common_ToolBarForListPage(CustNameSpace + "_" + ModuleName, CustNameSpace, M_Model.M_ToolBar);

        //    string ExtendsJs = helper.JqGridExtendsJs(M_Model.M_ExtendsJs, M_Model.M_ExtendsControl);


        //    return toolbar + html + ExtendsJs;
        //}

        /// <summary>
        /// 生产JqGrid 是否显示工具条
        /// </summary>
        /// <param name="helper"></param>
        /// <param name="ModuleName"></param>
        /// <param name="CustNameSpace"></param>
        /// <param name="itype"></param>
        /// <param name="type"></param>
        /// <param name="isShowTool">是否显示工具条</param>
        /// <returns></returns>
        //public static string JqGrid(this HtmlHelper helper, string ModuleName, string CustNameSpace, string itype, string type, bool isShowTool)
        //{
        //    ADOSys_Config_ListPage ListInstance = new ADOSys_Config_ListPage();
        //    ADOSys_Config_Fieled FieledInstance = new ADOSys_Config_Fieled();

        //    Sys_Config_ListPage M_Model = new Sys_Config_ListPage();
        //    List<Sys_Config_Fieled> D_List = new List<Sys_Config_Fieled>();

        //    List<Sys_Config_ListPage> _ListPage = ListInstance.GetListByWhere(" AND M_ModuleCode='" + ModuleName + "'");
        //    if (_ListPage.Count > 0)
        //    {
        //        M_Model = _ListPage[0];
        //    }
        //    //第二步：根据模块获取所有字段
        //    D_List = FieledInstance.GetListByWhere(" AND D_ModuleCode='" + ModuleName + "'");

        //    string html = JqGrid(helper, ModuleName, CustNameSpace, M_Model, D_List, itype, type, "", true);
        //    string toolbar = string.Empty;
        //    if (isShowTool)
        //    {
        //        toolbar = helper.Common_ToolBarForListPage(CustNameSpace + "_" + ModuleName, CustNameSpace, M_Model.M_ToolBar);
        //    }
        //    string ExtendsJs = helper.JqGridExtendsJs(M_Model.M_ExtendsJs, M_Model.M_ExtendsControl);


        //    return toolbar + html + ExtendsJs;
        //}
        #endregion

        #region 生成JqGrid私有
        /// <summary>
        /// 生成JqGrid
        /// </summary>
        /// <returns></returns>
        private static string JqGrid(this HtmlHelper helper, string ModuleName, string CustNameSpace,
            Sys_Config_ListPage M_Model,
            List<Sys_Config_Fieled> D_List,
            bool IsInit
            )
        {
            var key = Cache.CacheHelper.MakeKey(ModuleName, Cache.CacheKeyEnum.HtmlHelper.ToString());
            var result = Cache.CacheHelper.Get<string>(key);
            if (result != null)
            {
                return result;
            }

            //内置类型解析           
            #region JqGrid Html 列表显示部分
            string html = @"
            <div id='ListContainer_{M_ModuleCode}' style='width:100%'>   
                <div id='{M_NameSpace}search'>
                </div>
                <table id='{M_NameSpace}grid' class='scroll' cellpadding='0' cellspacing='0' style='width:100%'>
                </table>
                <div id='{M_NameSpace}pager' class='scroll' style='text-align: center;'>
                </div>    
            </div>
            ";

            #endregion

            #region JqGrid Js部分
            string js_header = @"<script type='text/javascript'>";
            string js_footer = @"</script>";
            string jsBody = @"            
            var {M_NameSpace}_{M_ModuleCode}_GridControl = {
                setupGrid: function(grid, pager, search, dataurl) {   
                    grid.jqGrid({
                        url: dataurl,
                        mtype: '{M_MType}',
                        rowNum: {M_RowNum},
                        rowList: {M_RowList},
                        pager: pager,
                        sortorder: 'asc',
                        viewrecords: true,
                        {M_MSelect}
                        width: '{M_Width}',
                        {M_Height}
                        autowidth: {M_AutoWidth},
                        rownumbers: true,
                        gridview: true,
                        hiddengrid:{M_GridState},
                        caption: '{M_Title}',
                        footerrow: {M_FooterRow},
                        editurl: '{M_EditUrl}',
                        edit: {M_Edit} ,                                                
                        onSelectRow: function(id) {
                            {M_OnSelectRow}
                        },
                        colNames: [{M_ColNames_list}],
                        colModel: [{M_ColModel_List}],
                        gridComplete: function() {
                           {M_GridAutoWidth}
                           {M_GridComplete}
                           {M_System_Link}
                        },
                        userDataOnFooter: true
                        {M_GroupingView}
                    })   
                },
                Init: function(dataurl, targetPreFix) {
                    var gridobj = targetPreFix + 'grid';
                    var pagerobj = targetPreFix + 'pager';
                    var searchobj = targetPreFix + 'search';        
                    {M_NameSpace}_{M_ModuleCode}_GridControl.setupGrid($('#' + gridobj), $('#' + pagerobj), $('#' + searchobj), dataurl);
                    $('#' + gridobj).navGrid('#'+pagerobj, { refresh: true, edit: false, add: false, del: false, search: false }); 
//                    var parent=$('#ListContainer');
//                    var parentWidth=800;
//                    if(parent==undefined || parent.width==0){ parentWidth=800; }
//                    $('#'+gridobj).setGridWidth(parent.width());//宽度自适当
                },   
                Search:function(){
                    $('#{M_NameSpace}grid').jqGrid('searchGrid', { multipleSearch:true } );
                }
            }
            ";
            #endregion

            #region JqGrid调用部分
            string callJs = @"
            <script type='text/javascript'>
                $(document).ready(function() {
                   {M_NameSpace}_{M_ModuleCode}_GridControl.Init('{M_URL}','{M_NameSpace}');
                });
            </script>
            ";
            #endregion

            #region 未使用
            string Package = @"
            var SysComm_{M_NameSpace}={
                SelectRowData:null,
                Init:function(){  {M_NameSpace}_{M_ModuleCode}_GridControl.Init();  },
                SelectRow:function(callback){ 
                    var grid = $('#{M_NameSpace}grid');
                    var curid = grid.getGridParam('selrow'); //获取选择行的id
                    var data = grid.getRowData(curid); //获取行号为curid的数据
                    SysComm_{M_NameSpace}.SelectRowData=data;
                    callback(data);
                },
                Add:function(){             {M_NameSpace}_{M_ModuleCode}_GridControl.Add();  }  ,
                InitEdit:function(code){    {M_NameSpace}_{M_ModuleCode}_GridControl.InitEdit(code);  },
                InitView:function(code){    {M_NameSpace}_{M_ModuleCode}_GridControl.InitView(code);  },
                SaveData:function(){        {M_NameSpace}_{M_ModuleCode}_GridControl.SaveData();  },
                AfterSave:function(){       {M_NameSpace}_{M_ModuleCode}_GridControl.AfterSave();  },
                CancelEdit:function(){      {M_NameSpace}_{M_ModuleCode}_GridControl.CancelEdit(); },
                Delete:function(code){      {M_NameSpace}_{M_ModuleCode}_GridControl.Delete(code); },
                Search:function(){          {M_NameSpace}_{M_ModuleCode}_GridControl.Search(); },
                Init:function(url){ 
                    var strUrl=url==''?'{M_URL}':url; 
                    {M_NameSpace}_{M_ModuleCode}_GridControl.Init(strUrl,'{M_NameSpace}'); 
                }
            }
            ";

            //jsBody += Package;
            #endregion

            #region 页面Js操作部分
            string HtmlCalljs = @"
        
             ";
            #endregion

            var GridAutoWidth = @"var listContainer=$('#ListContainer_{M_ModuleCode}').width();
                                   if(listContainer>0){
                                   grid.setGridWidth(listContainer);
                                  }
                           ";


            M_Model.M_NameSpace = !string.IsNullOrEmpty(CustNameSpace) ? CustNameSpace : M_Model.M_NameSpace;

            //根据配置替换
            html = html.Replace("{M_NameSpace}", M_Model.M_NameSpace.Trim());

            //参数默认值:
            M_Model.M_GetDataType = !string.IsNullOrEmpty(M_Model.M_GetDataType) ? M_Model.M_GetDataType : "url";

            //string GetDataUrl = M_Model.M_GetDataType.ToLower() == "sql"
            //    ? "/Sys_Config_ListPage/InitGrid/?ModuleCode=" + M_Model.M_ModuleCode + "&NameSpace=" + M_Model.M_NameSpace;
            // + "&itype=" + itype + "&type=" + type + "&record=" + record
            //: M_Model.M_URL.Contains('?') ? M_Model.M_URL + "&itype=" + itype + "&type=" + type + "&record=" + record :
            string GetDataUrl = M_Model.M_URL;
            //    M_Model.M_URL + "?itype=" + itype + "&type=" + type + "&record=" + record;
            //string M_EditUrl = M_Model.M_GetDataType.ToLower() == "sql"
            //    ? "/Sys_Config_ListPage/GridEdit/?ModuleCode=" + M_Model.M_ModuleCode + "&NameSpace=" + M_Model.M_NameSpace + ""
            //    : M_Model.M_EditUrl;

            //FormToJson()
            string SerializeType = M_Model.M_GetDataType.ToLower() == "sql"
                ? "serialize()" : "FormToJson()";
            string decodeURIComponent = M_Model.M_GetDataType.ToLower() == "sql"
                ? " FormData=decodeURIComponent(FormData,true); " : "";

            ////绑定数据方式
            //string InitEditData = M_Model.M_GetDataType.ToLower() == "sql"
            //    ? "data=datas[0];" : "data=datas;";
            //var refModel = BLL.Bll_Comm.CommRefDepend(itype);
            //string MapTitle = refModel != null && !string.IsNullOrEmpty(refModel.RefDepend_ObjectName) ? refModel.RefDepend_ObjectName : "";

            html = html.Replace("{M_ModuleCode}", M_Model.M_ModuleCode);
            GridAutoWidth = GridAutoWidth.Replace("{M_ModuleCode}", M_Model.M_ModuleCode);

            //参数默认值
            M_Model.M_MType = !string.IsNullOrEmpty(M_Model.M_AutoWidth) ? M_Model.M_MType : "true";
            M_Model.M_MType = !string.IsNullOrEmpty(M_Model.M_Width) ? M_Model.M_MType : "100%";
            M_Model.M_MType = !string.IsNullOrEmpty(M_Model.M_MType) ? M_Model.M_MType : "post";
            M_Model.M_MType = !string.IsNullOrEmpty(M_Model.M_RowNum) ? M_Model.M_MType : "10";
            M_Model.M_MType = !string.IsNullOrEmpty(M_Model.M_RowList) ? M_Model.M_MType : "[10,20,50]";
            M_Model.M_MType = !string.IsNullOrEmpty(M_Model.M_FooterRow) ? M_Model.M_MType : "false";
            M_Model.M_MType = !string.IsNullOrEmpty(M_Model.M_IsView) ? M_Model.M_MType : "false";
            //M_Model.M_MType = !string.IsNullOrEmpty(M_Model.M_MType) ? M_Model.M_MType : "";
            //M_Model.M_MType = !string.IsNullOrEmpty(M_Model.M_MType) ? M_Model.M_MType : "";
            //M_Model.M_MType = !string.IsNullOrEmpty(M_Model.M_MType) ? M_Model.M_MType : "";
            //M_Model.M_MType = !string.IsNullOrEmpty(M_Model.M_MType) ? M_Model.M_MType : "";


            //一般配置
            jsBody = jsBody.Replace("{M_NameSpace}", M_Model.M_NameSpace.Trim());
            jsBody = jsBody.Replace("{M_ModuleCode}", M_Model.M_ModuleCode.Trim());
            jsBody = jsBody.Replace("{M_MType}", M_Model.M_MType.Trim());
            jsBody = jsBody.Replace("{M_RowNum}", M_Model.M_RowNum);
            jsBody = jsBody.Replace("{M_RowList}", M_Model.M_RowList);
            jsBody = jsBody.Replace("{M_Width}", M_Model.M_Width.Trim());
            jsBody = jsBody.Replace("{M_Height}", !string.IsNullOrEmpty(M_Model.M_Height) ? "height:'" + M_Model.M_Height.Trim() + "'," : "");
            jsBody = jsBody.Replace("{M_MSelect}", !string.IsNullOrEmpty(M_Model.M_MSelect) && M_Model.M_MSelect == "true" ? "multiselect:true," : "");//是否多选 
            jsBody = jsBody.Replace("{M_AutoWidth}", M_Model.M_AutoWidth.Trim());
            jsBody = jsBody.Replace("{M_Title}", !string.IsNullOrEmpty(M_Model.M_Title) ? M_Model.M_Title : "");
            jsBody = jsBody.Replace("{M_FooterRow}", M_Model.M_FooterRow.Trim());
            //jsBody = jsBody.Replace("{M_EditUrl}", M_EditUrl);//如果为SQL，则地址改为系统地址
            jsBody = jsBody.Replace("{M_Edit}", M_Model.M_Edit);
            jsBody = jsBody.Replace("{M_OnSelectRow}", M_Model.M_OnSelectRow);
            jsBody = jsBody.Replace("{M_GridComplete}", M_Model.M_GridComplete);
            jsBody = jsBody.Replace("{LayerID}", M_Model.M_NameSpace.Trim() + "_Oper");
            jsBody = jsBody.Replace("{FormID}", M_Model.M_NameSpace.Trim() + "_Form");
            jsBody = jsBody.Replace("{SerializeType}", SerializeType);
            jsBody = jsBody.Replace("{decodeURIComponent}", decodeURIComponent);
            //jsBody = jsBody.Replace("{InitEditData}", InitEditData);
            jsBody = jsBody.Replace("{M_GridState}", !string.IsNullOrEmpty(M_Model.M_Gridstate) && M_Model.M_Gridstate == "true" ? "false" : "true");
            jsBody = jsBody.Replace("{M_GridAutoWidth}", GridAutoWidth);
            jsBody = jsBody.Replace("{M_GroupingView}", !string.IsNullOrEmpty(M_Model.M_GroupingView) ? "," + M_Model.M_GroupingView : "");

            //动态配置
            #region 生成列头
            string strColNames = string.Empty;
            D_List = D_List.OrderBy(o => o.D_ShowOrder).ToList();
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
            string KeyCode = D_List.Where(o => o.D_IsKey == 1).Count() > 0 ? D_List.Where(o => o.D_IsKey == 1).FirstOrDefault().D_Index.Trim() : "nokey";

            jsBody = jsBody.Replace("{M_ColNames_list}", strColNames);
            jsBody = jsBody.Replace("{KeyCode}", KeyCode);


            #region 生成列详细配置

            StringBuilder header = new StringBuilder();
            string header_template = @"{ name: '{D_Index}', index: '{D_Index}', width: {D_Width}, align: '{D_Align}', sortable: {D_Sortable}, hidden: {D_Hidden},searchoptions:{ {D_Searchoptions} }  }";
            string header_template_fix = ",";
            //D_List = D_List.OrderBy(o => o.D_ShowOrder).ToList();
            for (var m = 0; m < D_List.Count; m++)
            {
                string tmpFix = m != (D_List.Count - 1) ? header_template_fix : "";
                header.AppendLine(header_template.Replace("{D_Name}", !string.IsNullOrEmpty(D_List[m].D_Name) ? D_List[m].D_Name : "")
                    .Replace("{D_Index}", !string.IsNullOrEmpty(D_List[m].D_Index) ? D_List[m].D_Index.Trim() : "")
                    .Replace("{D_Width}", !string.IsNullOrEmpty(D_List[m].D_Width) ? D_List[m].D_Width : "100")
                    .Replace("{D_Align}", !string.IsNullOrEmpty(D_List[m].D_Align) ? D_List[m].D_Align.Trim() : "center")
                    .Replace("{D_Sortable}", !string.IsNullOrEmpty(D_List[m].D_Sortable) ? D_List[m].D_Sortable.Trim() : "false")
                    .Replace("{D_Hidden}", !string.IsNullOrEmpty(D_List[m].D_Hidden) ? D_List[m].D_Hidden.Trim() : "false")
                    .Replace("{D_Searchoptions}", !string.IsNullOrEmpty(D_List[m].D_Searchoptions) ? D_List[m].D_Searchoptions : "")
                    .Replace("{D_Summary}", !string.IsNullOrEmpty(D_List[m].D_Summary) ? "," + D_List[m].D_Summary : "")
                    + tmpFix);
            }
            #endregion

            jsBody = jsBody.Replace("{M_ColModel_List}", header.ToString());


            #region 获取系统需要跳转的URL配置
            string M_Link_Header = @"
                var s_ids = grid.jqGrid('getDataIDs');
                for (var i = 0; i < s_ids.length; i++) {
                    var s_cl = s_ids[i];
            ";
            string M_Link_Footer = @"
                }
            ";
            StringBuilder M_Link_Body = new StringBuilder();

            var Link_D_List = D_List.Where(o => !string.IsNullOrEmpty(o.D_LinkUrl));

            //List<string> WinOpenFunctionList = new List<string>();
            List<CustFunctionModel> WinOpenFunctionList = new List<CustFunctionModel>();

            foreach (var Litem in Link_D_List)
            {
                //M_Link_Body.AppendFormat("{0}:\"<a class='Sys_Link' href='#' onclick=Win.Open('/SysLink/Index/{1}?code=\"+grid.getRowData(s_cl).{0}+\"&url={2}&params={3}')>\"+ grid.getRowData(s_cl).{0}+\"</a>\",", 
                //    Litem.D_Index, 
                //    HttpContext.Current.Server.UrlEncode(M_Model.M_ModuleCode),  
                //    HttpContext.Current.Server.UrlEncode(Litem.D_LinkUrl),
                //    HttpContext.Current.Server.UrlEncode(Litem.D_LinkParam));               

                //获取所有需要配置的字段列表//获取需要配置的参数列表
                if (!string.IsNullOrEmpty(Litem.D_LinkParam) && !string.IsNullOrEmpty(Litem.D_LinkUrl))
                {
                    //获取参数列表
                    string MatchStrParams = "";
                    var match = Litem.D_LinkParam.Split(',');
                    foreach (var item in match)
                    {
                        MatchStrParams += item.ToString() + ",";
                    }
                    MatchStrParams = MatchStrParams.TrimEnd(',');
                    WinOpenFunctionList.Add(new CustFunctionModel() { Fun_Name = Litem.D_Index, Fun_Args = MatchStrParams, Fun_Body = Litem.D_LinkUrl });

                    var strLink = "[D_Index]:\"<a class='Sys_Link' href='#' onclick=CustOpen[D_Index]([args])>\"+ grid.getRowData(s_cl).[D_Index]+\"</a>\",";
                    string[] args = MatchStrParams.Split(',');
                    string argsVal = "";
                    for (var i = 0; i < args.Length; i++)
                    {
                        argsVal += "'\"+grid.getRowData(s_cl)." + args[i] + "+\"',";
                    }

                    M_Link_Body.Append(strLink.Replace("[D_Index]", Litem.D_Index)
                                              .Replace("[args]", argsVal.TrimEnd(','))
                                              );
                }

            }

            string M_Link = M_Link_Header + " grid.jqGrid('setRowData', s_cl, { " + M_Link_Body.ToString().TrimEnd(',') + "  }); " + M_Link_Footer;

            //Open方法生成            
            TagBuilder OpenBuilder = new TagBuilder("script");
            string StrFunction = "";
            foreach (var item in WinOpenFunctionList)
            {
                StrFunction += "function CustOpen" + item.Fun_Name + "(" + item.Fun_Args + "){  " + item.Fun_Body + "  }";
            }
            OpenBuilder.InnerHtml = StrFunction;

            jsBody = jsBody.Replace("{M_System_Link}", M_Link);
            #endregion


            jsBody = jsBody
                .Replace("{M_NameSpace}", M_Model.M_NameSpace.Trim())
                .Replace("{M_ModuleCode}", M_Model.M_ModuleCode)
                .Replace("{M_URL}", GetDataUrl); //如果为SQL，则地址改为系统地址


            callJs = callJs
                .Replace("{M_NameSpace}", M_Model.M_NameSpace.Trim())
                .Replace("{M_ModuleCode}", M_Model.M_ModuleCode)
                .Replace("{M_URL}", GetDataUrl); //如果为SQL，则地址改为系统地址


            string js = js_header + jsBody + js_footer;

            var re = html + js + (IsInit ? callJs : "") + HtmlCalljs + OpenBuilder.ToString();
            Cache.CacheHelper.SaveTime = 1440;
            Cache.CacheHelper.Insert(key, re);

            return re;
        }

        #endregion


        #region 生成JqGrid私有   By Ye Fei 2011-01-30  修改部分JS生成规则
        /// <summary> 
        /// 生成JqGrid  废弃不用
        /// </summary>
        /// <returns></returns>
        //        [Obsolete] 
        //        private static string JqGridY1OnlyList(this HtmlHelper helper, string ModuleName, string CustNameSpace,
        //            Sys_Config_ListPage M_Model,
        //            List<Sys_Config_Fieled> D_List,
        //            string itype,
        //            string type,
        //            string record,
        //            bool IsInit
        //            )
        //        {
        //            //内置类型解析           

        //            #region JqGrid Html 列表显示部分
        //            string html = @"
        //            <div id='ListContainer' style='width:100%'>   
        //                <div id='{M_NameSpace}search'>
        //                </div>
        //                <table id='{M_NameSpace}grid' class='scroll' cellpadding='0' cellspacing='0' style='width:100%'>
        //                </table>
        //                <div id='{M_NameSpace}pager' class='scroll' style='text-align: center;'>
        //                </div>    
        //            </div>
        //            ";
        //            #endregion

        //            #region JqGrid Js部分
        //            string js_header = @"<script type='text/javascript'>";
        //            string js_footer = @"</script>";
        //            string jsBody = @"            
        //            var {M_NameSpace}_{M_ModuleCode}_GridControl = {
        //                setupGrid: function(grid, pager, search, dataurl) {   
        //                    grid.jqGrid({
        //                        url: dataurl,
        //                        mtype: '{M_MType}',
        //                        rowNum: {M_RowNum},
        //                        rowList: {M_RowList},
        //                        pager: pager,
        //                        sortorder: 'asc',
        //                        viewrecords: true,
        //                        multiselect: false, //多选时出现checkbox
        //                        width: '{M_Width}',
        //                        height: '{M_Height}',
        //                        autowidth: {M_AutoWidth},
        //                        rownumbers: true,
        //                        gridview: true,
        //                        hiddengrid:{M_GridState},
        //                        caption: '{M_Title}',
        //                        footerrow: {M_FooterRow},
        //                        editurl: '{M_EditUrl}',
        //                        edit: {M_Edit} ,                                                
        //                        onSelectRow: function(id) {
        //                            {M_OnSelectRow}
        //                        },
        //                        colNames: [{M_ColNames_list}],
        //                        colModel: [{M_ColModel_List}],
        //                        gridComplete: function() {
        //                           {M_GridComplete}
        //                        },
        //                        loadComplete:function(){
        //                            //var parent=$('#ListContainer');
        ////                            var parentWidth=800;
        ////                            if(parent==undefined || parent.width==0){ parentWidth=800; }
        //                            //grid.setGridWidth(parent.width());//宽度自适当
        //                                                 
        //                        },
        //                        userDataOnFooter: true
        //                    })   
        //                },
        //                Init: function(dataurl, targetPreFix) {
        //                    var gridobj = targetPreFix + 'grid';
        //                    var pagerobj = targetPreFix + 'pager';
        //                    var searchobj = targetPreFix + 'search';        
        //                    {M_NameSpace}_{M_ModuleCode}_GridControl.setupGrid($('#' + gridobj), $('#' + pagerobj), $('#' + searchobj), dataurl);
        //                    $('#' + gridobj).navGrid('#'+pagerobj, { refresh: true, edit: false, add: false, del: false, search: false }); 
        ////                    var parent=$('#ListContainer');
        ////                    var parentWidth=800;
        ////                    if(parent==undefined || parent.width==0){ parentWidth=800; }
        ////                    $('#'+gridobj).setGridWidth(parent.width());//宽度自适当
        //                },   
        //
        //                Add: function() {
        //                    $('#{FormID}')[0].reset();
        //                    var _oper=$('#{FormID}oper').val('add');
        //                    $('#{LayerID}').dialog('open');
        //                    $.ajax({
        //                        type:'post',
        //                        url:'/Sys_Config_ListPage/GetTableKeyCode',
        //                        data:{oper:'add',n:'{M_NameSpace}' },
        //                        success:function(result){
        //                            //$('#{KeyCode}').val(result);
        //                            $('#{FormID}').find('#{KeyCode}').val(result);
        //                        }
        //                    });
        //                    if(typeof({FormID}LoadAddEx)!='undefined'){
        //                        {FormID}LoadAddEx();
        //                    }
        //                    if(typeof({FormID}LoadAllEx)!='undefined'){
        //                        {FormID}LoadAllEx();
        //                    }
        //                    if(typeof({FormID}LoadAfter)!='undefined'){
        //                        {FormID}LoadAfter('add');
        //                    }
        //                },
        //                InitEdit: function({KeyCode}) {
        //                    var _oper=$('#{FormID}oper').val('edit');
        //                    $.ajax(
        //                    {
        //                        type: 'post',
        //                        url: '{M_EditUrl}',
        //                        data: { id: {KeyCode},oper:'view'},
        //                        dataType: 'json',
        //                        success: function(datas) {
        //                            {InitEditData}
        //                            $('#{FormID}')[0].reset();
        //                            $('#{FormID}').find('input,select,textarea').each(function(key, element) {
        //                                   for (var p in data) {
        //                                        if (p == element.id) {
        //                                            if (element.type == 'checkbox') {//页面上的复选框
        //                                                element.checked = data[p];
        //                                            } else if (element.type == 'text') {
        //                                                element.value = data[p];
        //
        //                                            } else if (element.type == 'select-one') { //页面上的下拉菜单
        //                                                var e = $(element);
        //                                                e.val(data[p]);
        //                                            }else{
        //                                                $(element).val(data[p]);
        //                                            }
        //                                       }
        //                                    }  
        //                                if(typeof({FormID}LoadAfter)!='undefined'){
        //                                    {FormID}LoadAfter('edit');
        //                                }                              
        //                            });
        //
        //                        }
        //                    });
        //                    if(typeof({FormID}LoadAllEx)!='undefined'){
        //                        {FormID}LoadAllEx();
        //                    }                    
        //                    $('#{LayerID}').dialog('open');
        //                },
        //                //扩展编辑层,判断是否存在ListPage ToolBar扩展
        //                InitEditExtends: function({KeyCode},btn) {
        //                    var _oper=$('#'+btn+'Formoper').val('edit');
        //                    $.ajax(
        //                    {
        //                        type: 'post',
        //                        url: '{M_EditUrl}',
        //                        data: { id: {KeyCode},oper:'view'},
        //                        dataType: 'json',
        //                        success: function(datas) {
        //                            {InitEditData}
        //                            $('#'+btn+'Form')[0].reset();
        //                            $('#'+btn+'Form').find('input,select,textarea').each(function(key, element) {
        //                             if(element.type=='checkbox' || element.type=='text' || element.type=='select-one'){
        //                                    for (var p in data) {
        //                                        if (p == element.id) {
        //                                            if (element.type == 'checkbox') {//页面上的复选框
        //                                                element.checked = data[p];
        //                                            } else if (element.type == 'text') {
        //                                                element.value = data[p];
        //
        //                                            } else if (element.type == 'select-one') { //页面上的下拉菜单
        //                                                var e = $(element);
        //                                                e.val(data[p]);
        //                                            } else{
        //                                                $(element).val(data[p]);
        //                                            }
        //                                        }
        //                                    }
        //                             }                                 
        //                            });
        //
        //                        }
        //                    });
        //                    $('#'+btn+'Layer').dialog('open');
        //                },
        //
        //                SaveData: function() {
        //                    //$('#{FormID}').submit();
        //                    //表单提交前验证
        //                    //debugger;
        //                    if(!$('#{FormID}').validate().form())
        //                    {
        //                       return false;
        //                    }
        //                    var FormData=$('#{FormID}').{SerializeType};
        //                    {decodeURIComponent}
        //                    var _oper=$('#{FormID}oper').val();
        //                    $.ajax({
        //                        type:'post',
        //                        url:'{M_EditUrl}',
        //                        data:{'form':FormData,'oper':_oper},
        //                        success:{M_NameSpace}_{M_ModuleCode}_GridControl.AfterSave                       
        //                    });
        //                },
        //                SaveDataApply: function() {
        //                    //$('#{FormID}').submit();
        //                    //表单提交前验证
        //                    //debugger;
        //                    if(!$('#{FormID}').validate().form())
        //                    {
        //                       return false;
        //                    }
        //                    var FormData=$('#{FormID}').{SerializeType};
        //                    {decodeURIComponent}
        //                    var _oper=$('#{FormID}oper').val();
        //                    $.ajax({
        //                        type:'post',
        //                        url:'{M_EditUrl}',
        //                        data:{form:FormData,oper:_oper},
        //                        success:{M_NameSpace}_{M_ModuleCode}_GridControl.AfterSaveApply                       
        //                    });
        //                },
        //                SaveDataExtends: function(layer,form) {
        //                    //$('#{FormID}').submit();
        //                    //表单提交前验证
        //                    //debugger;
        //                    if(!$('#'+form+'').validate().form())
        //                    {
        //                       return false;
        //                    }
        //                    var FormData=$('#'+form+'').{SerializeType};
        //                    {decodeURIComponent}
        //                    var _oper=$('#'+form+'oper').val();
        //                    $.ajax({
        //                        type:'post',
        //                        url:'{M_EditUrl}',
        //                        data:{form:FormData,oper:_oper,btn:form},
        //                        success:function(data){{M_NameSpace}_{M_ModuleCode}_GridControl.AfterSaveExtends(layer,data);}                   
        //                    });
        //                },
        //                AfterSave: function(data) {
        //                    if (data == 'success') {
        //                        $('#{LayerID}').dialog('close');
        //                        $('#{M_NameSpace}grid').trigger('reloadGrid');
        //                        if(typeof({LayerID}AfterSave)!='undefined'){ {LayerID}AfterSave();  }
        //                    }
        //                    else {
        //                        ShowMsg('保存失败!');
        //                    }
        //                },
        //                AfterSaveApply: function(data) {
        //                    if (data == 'success') {
        //                        $('#{M_NameSpace}grid').trigger('reloadGrid');
        //                    }
        //                    else {
        //                        ShowMsg('保存失败!');
        //                    }
        //                },
        //                AfterSaveExtends: function(layer,data) {
        //                    if (data == 'success') {
        //                        $('#'+layer+'').dialog('close');
        //                        $('#{M_NameSpace}grid').trigger('reloadGrid');
        //                    }
        //                    else {
        //                        ShowMsg('保存失败!');
        //                    }
        //                },
        //
        //                CancelEdit: function() {
        //                    $('#{FormID}')[0].reset();
        //                    $('#{LayerID}').dialog('close');
        //                },
        //                CancelEditExtends: function(layer,form) {
        //                    $('#'+form+'')[0].reset();
        //                    $('#'+layer+'').dialog('close');
        //                },
        //                Search:function(){
        //                    $('#{M_NameSpace}grid').jqGrid('searchGrid', { multipleSearch:true } );
        //                },
        //                Delete:function({KeyCode}){
        //                    //var _oper=$('#{FormID}oper').val('del');
        //                    $.ajax({
        //                        type: 'post',
        //                        url: '{M_EditUrl}',
        //                        data: { id: {KeyCode},oper:'del'},
        //                        success: function(result) {                     
        //                            if(result=='success'){
        //                                $('#{M_NameSpace}grid').trigger('reloadGrid');
        //                            }else{
        //                                ShowMsg('删除失败');
        //                            }
        //                        }
        //                    });
        //                }
        //            }
        //            ";
        //            #endregion

        //            #region JqGrid调用部分
        //            string callJs = @"
        //            <script type='text/javascript'>
        //                $(document).ready(function() {
        //                   {M_NameSpace}_{M_ModuleCode}_GridControl.Init('{M_URL}','{M_NameSpace}');
        //                });
        //            </script>
        //            ";
        //            #endregion


        //            #region 工具栏搜索方法  2011-01-30
        //            string searchJS = @"
        //                function {M_NameSpace}ToolBarSearch()
        //                {
        //                    {M_NameSpace}_{M_ModuleCode}_GridControl.Search();
        //                }
        //
        //                ";
        //            jsBody += searchJS;
        //            #endregion


        //            string Package = @"
        //            var SysComm_{M_NameSpace}={
        //                SelectRowData:null,
        //                Init:function(){  {M_NameSpace}_{M_ModuleCode}_GridControl.Init();  },
        //                SelectRow:function(callback){ 
        //                    var grid = $('#{M_NameSpace}grid');
        //                    var curid = grid.getGridParam('selrow'); //获取选择行的id
        //                    var data = grid.getRowData(curid); //获取行号为curid的数据
        //                    SysComm_{M_NameSpace}.SelectRowData=data;
        //                    callback(data);
        //                },
        //                Add:function(){             {M_NameSpace}_{M_ModuleCode}_GridControl.Add();  }  ,
        //                InitEdit:function(code){    {M_NameSpace}_{M_ModuleCode}_GridControl.InitEdit(code);  },
        //                SaveData:function(){        {M_NameSpace}_{M_ModuleCode}_GridControl.SaveData();  },
        //                AfterSave:function(){       {M_NameSpace}_{M_ModuleCode}_GridControl.AfterSave();  },
        //                CancelEdit:function(){      {M_NameSpace}_{M_ModuleCode}_GridControl.CancelEdit(); },
        //                Delete:function(code){      {M_NameSpace}_{M_ModuleCode}_GridControl.Delete(code); },
        //                Search:function(){          {M_NameSpace}_{M_ModuleCode}_GridControl.Search(); },
        //                Init:function(url){ 
        //                    var strUrl=url==''?'{M_URL}':url; 
        //                    {M_NameSpace}_{M_ModuleCode}_GridControl.Init(strUrl,'{M_NameSpace}'); 
        //                }
        //            }
        //            ";

        //            jsBody += Package;


        //            #region 页面Js操作部分
        //            string HtmlCalljs = @"
        //            <script type='text/javascript'>
        //                $(document).ready(function() {
        //                    
        //                });
        //            </script>
        //             ";
        //            #endregion

        //            M_Model.M_NameSpace = !string.IsNullOrEmpty(CustNameSpace) ? CustNameSpace : M_Model.M_NameSpace;

        //            //根据配置替换
        //            html = html.Replace("{M_NameSpace}", M_Model.M_NameSpace.Trim());

        //            string GetDataUrl = M_Model.M_GetDataType.ToLower() == "sql"
        //                ? "/Sys_Config_ListPage/InitGrid/?ModuleCode=" + M_Model.M_ModuleCode + "&NameSpace=" + M_Model.M_NameSpace
        //                + "&itype=" + itype + "&type=" + type + "&record=" + record
        //                : M_Model.M_URL.Contains('?') ? M_Model.M_URL + "&itype=" + itype + "&type=" + type + "&record=" + record :
        //                                                M_Model.M_URL + "?itype=" + itype + "&type=" + type + "&record=" + record;
        //            string M_EditUrl = M_Model.M_GetDataType.ToLower() == "sql"
        //                ? "/Sys_Config_ListPage/GridEdit/?ModuleCode=" + M_Model.M_ModuleCode + "&NameSpace=" + M_Model.M_NameSpace + ""
        //                : M_Model.M_EditUrl;

        //            //FormToJson()
        //            string SerializeType = M_Model.M_GetDataType.ToLower() == "sql"
        //                ? "serialize()" : "FormToJson()";
        //            string decodeURIComponent = M_Model.M_GetDataType.ToLower() == "sql"
        //                ? " FormData=decodeURIComponent(FormData,true); " : "";

        //            //绑定数据方式
        //            string InitEditData = M_Model.M_GetDataType.ToLower() == "sql"
        //                ? "data=datas[0];" : "data=datas;";
        //            var refModel = BLL.Bll_Comm.CommRefDepend(itype);
        //            string MapTitle = refModel != null && !string.IsNullOrEmpty(refModel.RefDepend_ObjectName) ? refModel.RefDepend_ObjectName : "";

        //            //一般配置
        //            jsBody = jsBody.Replace("{M_NameSpace}", M_Model.M_NameSpace.Trim());
        //            jsBody = jsBody.Replace("{M_ModuleCode}", M_Model.M_ModuleCode.Trim());
        //            jsBody = jsBody.Replace("{M_MType}", M_Model.M_MType.Trim());
        //            jsBody = jsBody.Replace("{M_RowNum}", M_Model.M_RowNum);
        //            jsBody = jsBody.Replace("{M_RowList}", M_Model.M_RowList);
        //            jsBody = jsBody.Replace("{M_Width}", M_Model.M_Width.Trim());
        //            jsBody = jsBody.Replace("{M_Height}", M_Model.M_Height.Trim());
        //            jsBody = jsBody.Replace("{M_AutoWidth}", M_Model.M_AutoWidth.Trim());
        //            jsBody = jsBody.Replace("{M_Title}", !string.IsNullOrEmpty(MapTitle) ? MapTitle : !string.IsNullOrEmpty(M_Model.M_Title) ? M_Model.M_Title : "");
        //            jsBody = jsBody.Replace("{M_FooterRow}", M_Model.M_FooterRow.Trim());
        //            jsBody = jsBody.Replace("{M_EditUrl}", M_EditUrl);//如果为SQL，则地址改为系统地址
        //            jsBody = jsBody.Replace("{M_Edit}", M_Model.M_Edit);
        //            jsBody = jsBody.Replace("{M_OnSelectRow}", M_Model.M_OnSelectRow);
        //            jsBody = jsBody.Replace("{M_GridComplete}", M_Model.M_GridComplete);
        //            jsBody = jsBody.Replace("{LayerID}", M_Model.M_NameSpace.Trim() + "_Oper");
        //            jsBody = jsBody.Replace("{FormID}", M_Model.M_NameSpace.Trim() + "_Form");
        //            jsBody = jsBody.Replace("{SerializeType}", SerializeType);
        //            jsBody = jsBody.Replace("{decodeURIComponent}", decodeURIComponent);
        //            jsBody = jsBody.Replace("{InitEditData}", InitEditData);
        //            jsBody = jsBody.Replace("{M_GridState}", !string.IsNullOrEmpty(M_Model.M_Gridstate) && M_Model.M_Gridstate == "true" ? "false" : "true");


        //            //动态配置
        //            #region 生成列头
        //            string strColNames = string.Empty;
        //            D_List = D_List.OrderBy(o => o.D_ShowOrder).ToList();
        //            for (int i = 0; i < D_List.Count; i++)
        //            {
        //                if (i != (D_List.Count - 1))
        //                {
        //                    strColNames += "'" + D_List[i].D_Name.Trim() + "'" + ",";
        //                }
        //                else
        //                {
        //                    strColNames += "'" + D_List[i].D_Name.Trim() + "'";
        //                }
        //            }
        //            #endregion
        //            string KeyCode = D_List.Where(o => o.D_IsKey == 1).Count() > 0 ? D_List.Where(o => o.D_IsKey == 1).FirstOrDefault().D_Index.Trim() : "nokey";

        //            jsBody = jsBody.Replace("{M_ColNames_list}", strColNames);
        //            jsBody = jsBody.Replace("{KeyCode}", KeyCode);


        //            #region 生成列详细配置

        //            StringBuilder header = new StringBuilder();
        //            string header_template = @"{ name: '{D_Index}', index: '{D_Index}', width: {D_Width}, align: '{D_Align}', sortable: {D_Sortable}, hidden: {D_Hidden},searchoptions:{ {D_Searchoptions} } {D_Summary} }";
        //            string header_template_fix = ",";
        //            //D_List = D_List.OrderBy(o => o.D_ShowOrder).ToList();
        //            for (var m = 0; m < D_List.Count; m++)
        //            {
        //                string tmpFix = m != (D_List.Count - 1) ? header_template_fix : "";
        //                header.AppendLine(header_template.Replace("{D_Name}", !string.IsNullOrEmpty(D_List[m].D_Name) ? D_List[m].D_Name : "")
        //                    .Replace("{D_Index}", !string.IsNullOrEmpty(D_List[m].D_Index) ? D_List[m].D_Index.Trim() : "")
        //                    .Replace("{D_Width}", !string.IsNullOrEmpty(D_List[m].D_Width) ? D_List[m].D_Width : "100")
        //                    .Replace("{D_Align}", !string.IsNullOrEmpty(D_List[m].D_Align) ? D_List[m].D_Align.Trim() : "center")
        //                    .Replace("{D_Sortable}", !string.IsNullOrEmpty(D_List[m].D_Sortable) ? D_List[m].D_Sortable.Trim() : "false")
        //                    .Replace("{D_Hidden}", !string.IsNullOrEmpty(D_List[m].D_Hidden) ? D_List[m].D_Hidden.Trim() : "false")
        //                    .Replace("{D_Searchoptions}", !string.IsNullOrEmpty(D_List[m].D_Searchoptions) ? D_List[m].D_Searchoptions : "")
        //                    .Replace("{D_Summary}",!string.IsNullOrEmpty(D_List[m].D_Summary)?","+D_List[m].D_Summary:"")
        //                    + tmpFix);
        //            }
        //            #endregion

        //            jsBody = jsBody.Replace("{M_ColModel_List}", header.ToString());


        //            jsBody = jsBody
        //                .Replace("{M_NameSpace}", M_Model.M_NameSpace.Trim())
        //                .Replace("{M_ModuleCode}", M_Model.M_ModuleCode)
        //                .Replace("{M_URL}", GetDataUrl); //如果为SQL，则地址改为系统地址

        //            callJs = callJs
        //                .Replace("{M_NameSpace}", M_Model.M_NameSpace.Trim())
        //                .Replace("{M_ModuleCode}", M_Model.M_ModuleCode)
        //                .Replace("{M_URL}", GetDataUrl); //如果为SQL，则地址改为系统地址


        //            //动态生成获取数据的Action，判断是URL还是SQL方式


        //            string js = js_header + jsBody + js_footer;

        //            return html + js + (IsInit ? callJs : "") + HtmlCalljs;
        //        }

        #endregion


        #region 生成JqGrid 扩展Js
        /// <summary>
        /// 生成JqGrid 扩展Js
        /// </summary>
        /// <returns></returns>
        private static string JqGridExtendsJs(this HtmlHelper helper,
            string ExtendsJs, string ExtendsControl)
        {
            StringBuilder str = new StringBuilder();
            if (!string.IsNullOrEmpty(ExtendsJs))
            {
                if (ExtendsJs.Contains(","))
                {
                    string[] jsList = ExtendsJs.Split(',');
                    for (var i = 0; i < jsList.Length; i++)
                    {
                        str.AppendLine("<script src='/Scripts/Extends/" + jsList[i] + "'></script>");
                    }
                }
                else
                {
                    str.AppendLine("<script src='/Scripts/Extends/" + ExtendsJs + "'></script>");
                }
            }
            if (!string.IsNullOrEmpty(ExtendsControl))
            {
                helper.RenderPartial(ExtendsControl);
            }

            return str.ToString();
        }

        #endregion

        #region 页面操作方法
        /// <summary>
        /// 页面操作方法
        /// </summary>
        /// <param name="M_Model"></param>
        /// <param name="D_List"></param>
        /// <returns></returns>
        private static string FormOperForList(Sys_Config_ListPage M_Model, List<Sys_Config_Fieled> D_List)
        {
            string js = @"<script>
                            {JsFunction}
                        </script>";


            #region
            StringBuilder jsFunsb = new StringBuilder();
            if (M_Model.M_IsAdd == 1)
            {
                jsFunsb.AppendLine(@"    
    function {preFix}ToolBaradd() {
                   $('#{FormID}')[0].reset();
                    var _oper=$('#{FormID}oper').val('add');
                    $('#{LayerID}').dialog('open');
                    $.ajax({
                        type:'post',
                        url:'/Sys_Config_ListPage/GetTableKeyCode',
                        data:{oper:'add',n:'{M_NameSpace}' },
                        success:function(result){
                            //$('#{KeyCode}').val(result);
                            $('#{FormID}').find('#{KeyCode}').val(result);
                        }
                    });
            }
");
            }

            if (M_Model.M_IsEdit == 1)
            {
                jsFunsb.AppendLine(@"    
    function {preFix}ToolBaredit() {            
                var grid = $('#{GridID}');
                var curid = grid.getGridParam('selrow'); //获取选择行的id
                var gdata = grid.getRowData(curid); //获取行号为curid的数据            
                if (gdata.{KeyCode} == undefined) {
                    ShowMsg('请选中编辑行');
                    return;
                }
                  var _oper=$('#{FormID}oper').val('edit');
                    $.ajax(
                    {
                        type: 'post',
                        url: '{M_EditUrl}',
                        data: { id: gdata.{KeyCode},oper:'view'},
                        dataType: 'json',
                        success: function(datas) {
                            var data=datas[0];
                            $('#{FormID}')[0].reset();
                            $('#{FormID}').find('input,select,textarea').each(function(key, element) {
                                   for (var p in data) {
                                        if (p == element.id) {
                                            if (element.type == 'checkbox') {//页面上的复选框
                                                element.checked = data[p];
                                            } else if (element.type == 'text') {
                                                element.value = data[p];

                                            } else if (element.type == 'select-one') { //页面上的下拉菜单
                                                var e = $(element);
                                                e.val(data[p]);
                                            }else{
                                                $(element).val(data[p]);
                                            }
                                       }
                                    }  
                                                      
                            });

                        }
                    });
                                    
                    $('#{LayerID}').dialog('open');
            }
");
            }

            if (M_Model.M_IsDelete == 1)
            {
                jsFunsb.AppendLine(@"  
    function {preFix}ToolBardel() {
                var grid = $('#{GridID}');
                var curid = grid.getGridParam('selrow'); //获取选择行的id
                var data = grid.getRowData(curid); //获取行号为curid的数据            
                if (data.{KeyCode} == undefined) {
                    ShowMsg('请选中编辑行');
                    return;
                }
                ShowMsg('你确定要删除选中的数据吗?', function(yes) {
                    if (yes) {
                       $.ajax({
                        type: 'post',
                        url: '{M_EditUrl}',
                        data: { id: data.{KeyCode},oper:'del'},
                        success: function(result) {                     
                            if(result=='success'){
                                $('#{GridID}').trigger('reloadGrid');
                            }else{
                                ShowMsg('删除失败');
                            }
                        }
                    });
                    }
                });
            }  
          ");
            }

            if (M_Model.M_IsView == "true")
            {
                jsFunsb.AppendLine(@"  
        function {preFix}ToolBarview() {  
                var grid = $('#{GridID}');
                var curid = grid.getGridParam('selrow'); //获取选择行的id
                var gdata = grid.getRowData(curid); //获取行号为curid的数据            
                if (gdata.{KeyCode} == undefined) {
                    ShowMsg('请选中编辑行');
                    return;
                }          
                var _oper=$('#{FormID}oper').val('edit');
                    $.ajax(
                    {
                        type: 'post',
                        url: '{M_EditUrl}',
                        data: { id: gdata.{KeyCode},oper:'view'},
                        dataType: 'json',
                        success: function(datas) {
                            var data=datas[0];
                            $('#{FormID}')[0].reset();
                            $('#{FormID}').find('input,select,textarea').each(function(key, element) {
                                   for (var p in data) {
                                        if (p == element.id) {
                                            if (element.type == 'checkbox') {//页面上的复选框
                                                element.checked = data[p];
                                            } else if (element.type == 'text') {
                                                element.value = data[p];

                                            } else if (element.type == 'select-one') { //页面上的下拉菜单
                                                var e = $(element);
                                                e.val(data[p]);
                                            }else{
                                                $(element).val(data[p]);
                                            }
                                       }
                                    }                                            
                            });

                        }
                    });         
                    $('#{LayerID}').dialog('open');
                    GLOBAL.PageReadOnly('','#{LayerID}');//只读
            }
    ");
            }

            string jsFunction = jsFunsb.ToString();
            #endregion.
            string editUrl = string.Empty;
            if (string.IsNullOrEmpty(M_Model.M_EditUrl))
            {
                editUrl = "/Sys_Config_ListPage/GridEdit/?ModuleCode={moduleName}&NameSpace={M_NameSpace}";
            }
            else
            {
                editUrl = M_Model.M_EditUrl;
            }
            string KeyCode = D_List.Where(o => o.D_IsKey == 1).Count() > 0 ? D_List.Where(o => o.D_IsKey == 1).FirstOrDefault().D_Index.Trim() : "nokey";
            js = js.Replace("{JsFunction}",
                           jsFunction.Replace("{preFix}", M_Model.M_NameSpace.Trim() + "_" + M_Model.M_ModuleCode.Trim())
                           .Replace("{GridID}", M_Model.M_NameSpace.Trim() + "grid")
                           .Replace("{KeyCode}", KeyCode).Replace("{FormID}", M_Model.M_NameSpace + "_Form")
                           .Replace("{LayerID}", M_Model.M_NameSpace + "_Oper").Replace("{M_EditUrl}", editUrl).Replace("{M_NameSpace}", M_Model.M_NameSpace)
                           .Replace("{moduleName}", M_Model.M_ModuleCode)
                        );
            return js;
        }
        #endregion

        #region 自动生成表单验证信息
        /// <summary>
        /// 自动生成表单验证信息
        /// </summary>
        /// <param name="hepler"></param>
        /// <param name="ModuleName"></param>
        /// <param name="NameSpace"></param>
        /// <returns></returns>
        public static string AutoBindValidate(this HtmlHelper hepler, string ModuleName)
        {
            ADOSys_Config_Fieled FieledInstance = new ADOSys_Config_Fieled();
            List<Sys_Config_Fieled> D_List = new List<Sys_Config_Fieled>();
            D_List = FieledInstance.GetListByWhere(" AND D_ModuleCode='" + ModuleName + "'");
            return AutoBindValidate(D_List, "");
        }

        public static string AutoBindValidate(this HtmlHelper hepler, string ModuleName, string FormName)
        {
            ADOSys_Config_Fieled FieledInstance = new ADOSys_Config_Fieled();
            List<Sys_Config_Fieled> D_List = new List<Sys_Config_Fieled>();
            D_List = FieledInstance.GetListByWhere(" AND D_ModuleCode='" + ModuleName + "'");
            return AutoBindValidate(D_List, FormName);
        }
        #endregion

        #region 生成表单验证
        /// <summary>
        /// 生成表单验证
        /// </summary>
        /// <param name="D_List"></param>
        /// <returns></returns>
        private static string AutoBindValidate(List<Sys_Config_Fieled> D_List, string FormName)
        {
            
            StringBuilder tmpValidatinRules = new StringBuilder();
            StringBuilder tmpValidationMsg = new StringBuilder();
            string ValidationJs = "";
            var newD_List = D_List.Where(o => o.D_EditHidden == "false"
                || string.IsNullOrEmpty(o.D_EditHidden)).OrderBy(o => o.D_EditOrder).ToList();//对List重新排序
            for (int i = 0; i < newD_List.Count; i++)
            {

                #region 生成验证规则
                if (!string.IsNullOrEmpty(newD_List[i].D_EditRules))
                {
                    tmpValidatinRules.AppendLine(newD_List[i].D_Index.Trim() + ":{ " + newD_List[i].D_EditRules.Trim() + " }" + ",");
                }
                #endregion
                #region 生成验证消息
                if (!string.IsNullOrEmpty(newD_List[i].D_EditMessage))
                {
                    tmpValidationMsg.AppendLine(newD_List[i].D_Index.Trim() + ":{ " + newD_List[i].D_EditMessage.Trim() + " }" + ",");
                }
                #endregion

                //生成验证JS
                string ValidationJs_template = @"
                    <script type='text/javascript'>
                    $(document).ready(function(){
                    var validator = $('#{FormID}').validate({
                        debug: false,       //调试模式取消submit的默认提交功能
                        errorClass: 'err_display', //默认为错误的样式类为：error
                        focusInvalid: false,
                        onkeyup: false,
                        rules: {           //定义验证规则,其中属性名为表单的name属性
                            {D_EditRules}
                        },
                        messages: {       //自定义验证消息
                            {D_EditMessage}
                        },
                        errorPlacement: function(error, element) {  //验证消息放置的地方
                            //error.appendTo(element.next().addClass('err_display'));
                            
                            if(error.html()!=''){
                                //ShowMsg(error.html());
                                element.next().addClass('err_display');                            
                                element.next().find('span').html(error.html());
                            }else{
                                element.next().find('span').html(error.html());
                                element.next().removeClass('err_display');
                            }                            
                        },
                        highlight: function(element, errorClass) {  //针对验证的表单设置高亮
                            //$(element).addClass(errorClass);
                        },
                        success: function(label) {
                            //label.addClass('valid').text('Ok!');
                        }     
                  });
                  $('#{FormID}').validate().form();
            });
            </script>
            ";
                string FormId = !string.IsNullOrEmpty(FormName) ? FormName : D_List[0].D_NameSpace + "_Form";

                //生成验证JS
                ValidationJs = ValidationJs_template.Replace("{D_EditRules}", tmpValidatinRules.ToString().Trim().TrimEnd(','))
                                                           .Replace("{D_EditMessage}",
                                                           tmpValidationMsg.ToString().Trim().TrimEnd(','))
                                                           .Replace("{FormID}", FormId);

            }
            return ValidationJs;
        }
        #endregion

        #region 生成空白表单私有
        /// <summary>
        /// 生成空白表单
        /// </summary>
        /// <param name="M_Model"></param>
        /// <param name="D_List"></param>
        /// <returns></returns>
        private static string AutoBindForm(Sys_Config_ListPage M_Model, List<Sys_Config_Fieled> D_List,
            bool IsOpenLayer, bool AllowFormButton, bool AllowForm, string location)
        {

            var key = Cache.CacheHelper.MakeKey(M_Model.M_ModuleCode, Cache.CacheKeyEnum.FormHtmlHelper.ToString());
            var result = Cache.CacheHelper.Get<string>(key);
            if (result != null)
            {
                return result;
            }

            ADOComm comInstance = new ADOComm();
            //解析Tab
            bool HasTab = false;
            Dictionary<string, string> Tabs = TabParse.Parse(M_Model.M_Type);
            if (Tabs != null && Tabs.Count > 0)
            {
                HasTab = true;
            }
            //表单隐藏元素
            string strLoopHiden = @"<input name='{D_Index}' type='hidden' id='{D_Index}' value='{D_DefaultValue}' />";

            #region JqGrid Html表单编辑Html层

            string FormHeader = "<form class='FormClass' action='{EditURL}' id='{FormID}' method='post' name='{FormID}'>";
            string FormFooter = "</form>";
            string FormButton = string.Empty;
            //如果M_EditUrl为空，则用默认增删改方法，否则根据配置的url进行表单提交
            if (string.IsNullOrEmpty(M_Model.M_EditSubmitUrl))
            {

                FormButton = @"<div class='FormToolBar'>
                                <input type='hidden' name='{FormID}oper' id='{FormID}oper' value=''>
                                <input id='{FormID}OK' type='button' class='hide' name='button'  value='提 交' 
                                        onclick=ComOperation.SaveData('{ModuleName}','{NameSpace}',{CallBack}) />
                                <input id='{FormID}Cancle' type='button' name='cancle' value='取 消' 
                                        onclick=ComOperation.Cancel('{NameSpace}') />
                                <input style='display:none' id='{FormID}Apply' type='button' name='button'  value='应 用' 
                                        onclick='{preFix}_GridControl.SaveDataApply()' />  
                                </div>          
                                ";
            }
            else
            {
                FormButton = @"<div class='FormToolBar'>
                                <input type='hidden' name='{FormID}oper' id='{FormID}oper' value=''>
                                <input id='{FormID}OK' type='button' class='hide' name='button'  value='提 交' 
                                        onclick=ComOperation.SaveFormData('{ModuleName}','{NameSpace}',{CallBack}) />
                                <input id='{FormID}Cancle' type='button' name='cancle' value='取 消' 
                                        onclick=ComOperation.Cancel('{NameSpace}') />
                                <input style='display:none' id='{FormID}Apply' type='button' name='button'  value='应 用' 
                                        onclick='{preFix}_GridControl.SaveDataApply()' />  
                                </div>          
                                ";
            }
            string callback="null";
            if (!string.IsNullOrEmpty(M_Model.M_ToolBarExtend))
            {
                callback = M_Model.M_ToolBarExtend;
            }
            FormButton = FormButton.Replace("{ModuleName}", M_Model.M_ModuleCode).Replace("{NameSpace}", M_Model.M_NameSpace).Replace("{CallBack}",callback);
            string LayerHeader = "<div class='list_openlayer' id='{LayerID}' style='display:{Is_Show}'>";
            string LayerFooter = "</div>";

            string editHtml = @"
            {LayerHeader}
            {FormHeader}
            {MainFormTable}
            {DetailTabForm}
            {HiddenField}
            {FormButton}           
            {FormFooter}
            {MainFormJs}  
            {LayerFooter}
            ";
            #endregion

            StringBuilder tmpHiddenLoop = new StringBuilder();

            //生成Hidden元素
            foreach (var m in D_List.Where(o => o.D_EditHidden == "true"))
            {
                if (m.D_IsKey == 1)
                {
                    m.D_DefaultValue = comInstance.GenTableKeyCode(M_Model.M_ModuleCode);
                }
                string DefaultValue = !string.IsNullOrEmpty(m.D_DefaultValue) ? m.D_DefaultValue : "";
                tmpHiddenLoop.AppendLine(strLoopHiden.Replace("{D_DefaultValue}", ParseDefaultValue(DefaultValue)).Replace("{D_Index}", m.D_Index.Trim()));
            }

            string LayerId = M_Model.M_NameSpace.Trim() + "_Oper";
            string FormId = M_Model.M_NameSpace.Trim() + "_Form";

            //所有可见表单元素
            List<Sys_Config_Fieled> newD_List = new List<Sys_Config_Fieled>();
            newD_List = D_List.Where(o => o.D_EditHidden == "false" || string.IsNullOrEmpty(o.D_EditHidden))
                                  .OrderBy(o => o.D_EditOrder).ToList();


            string MainFormTable = "";
            string DetailFormTab = "";
            int MainLineNum = 0;
            int TabMaxNum = 0;
            string strLineNum = ",height:{DialogHeight}";
            if (HasTab)
            {
                MainFormTable = CreateFormElement(M_Model,
                    newD_List.Where(o => string.IsNullOrEmpty(o.D_EditTab)).ToList(), location, ref MainLineNum);
                DetailFormTab = CreateDetailTab(M_Model, newD_List, Tabs, ref TabMaxNum);
            }
            else
            {
                MainFormTable = CreateFormElement(M_Model, newD_List, location, ref MainLineNum);
            }
            strLineNum = strLineNum.Replace("{DialogHeight}", (MainLineNum + TabMaxNum + 170).ToString());

            //生成表单内所有元素的Js
            string MainFormJs = CreateFormScript(M_Model, D_List, LayerId, IsOpenLayer, strLineNum, FormId);


            #region //生成JS
            //弹出层
            if (IsOpenLayer)
            {
                LayerHeader = LayerHeader.Replace("{Is_Show}", "none");
                editHtml = editHtml.Replace("{LayerHeader}", LayerHeader);
                editHtml = editHtml.Replace("{LayerFooter}", LayerFooter);
            }
            else
            {
                editHtml = editHtml.Replace("{LayerHeader}", "");
                editHtml = editHtml.Replace("{LayerFooter}", "");
            }
            #endregion

            #region 表单控制选项
            if (AllowForm)
            {
                editHtml = editHtml.Replace("{FormHeader}", FormHeader)
                                  .Replace("{FormFooter}", FormFooter);
            }
            else
            {
                editHtml = editHtml.Replace("{FormHeader}", "")
                                  .Replace("{FormFooter}", "");
            }
            if (AllowFormButton)
            {
                editHtml = editHtml.Replace("{FormButton}", FormButton);
            }
            else
            {
                editHtml = editHtml.Replace("{FormButton}", "");
            }
            #endregion
            editHtml = editHtml.Replace("{MainFormTable}", MainFormTable)
                .Replace("{DetailTabForm}", DetailFormTab)
                .Replace("{MainFormJs}", MainFormJs)
                .Replace("{HiddenField}", tmpHiddenLoop.ToString())
                .Replace("{preFix}", M_Model.M_NameSpace.Trim() + "_" + M_Model.M_ModuleCode.Trim())
                .Replace("{LayerID}", LayerId)
                .Replace("{FormID}", FormId)
                .Replace("{EditURL}", M_Model.M_EditSubmitUrl)
                .Replace("{M_EditColumNo}", M_Model.M_EditCloumNum.ToString());
            
            result=editHtml;
            Cache.CacheHelper.SaveTime = 1440;
            Cache.CacheHelper.Insert(key, result);
            
            return editHtml;
        }
        #endregion

        #region 绑定表单私有
        /// <summary>
        /// 生成空白表单
        /// </summary>
        /// <param name="M_Model"></param>
        /// <param name="D_List"></param>
        /// <returns></returns>
        private static string AutoBindForm<T>(Sys_Config_ListPage M_Model, List<Sys_Config_Fieled> D_List, T obj,
            bool IsOpenLayer, bool AllowFormButton, bool AllowForm, string location)
        {
            //解析Tab
            bool HasTab = false;
            Dictionary<string, string> Tabs = TabParse.Parse(M_Model.M_Type);
            if (Tabs != null && Tabs.Count > 0)
            {
                HasTab = true;
            }
            //表单隐藏元素
            string strLoopHiden = @"<input name='{D_Index}' type='hidden' id='{D_Index}' value='{D_DefaultValue}' />";

            #region JqGrid Html表单编辑Html层

            string FormHeader = "<form class='FormClass' action='{EditURL}' id='{FormID}' method='post' name='{FormID}'>";
            string FormFooter = "</form>";

            string FormButton = @"<div class='FormToolBar'>
                                <input type='hidden' name='{FormID}oper' id='{FormID}oper' value=''>
                                <input id='{FormID}OK' type='button' name='button'  value='提 交' 
                                        onclick='{preFix}_GridControl.SaveData()' />
                                <input id='{FormID}Cancle' type='button' name='cancle' value='取 消' 
                                        onclick='{preFix}_GridControl.CancelEdit()' />
                                <input style='display:none' id='{FormID}Apply' type='button' name='button'  value='应 用' 
                                        onclick='{preFix}_GridControl.SaveDataApply()' />  
                                </div>          
                                ";

            string LayerHeader = "<div class='list_openlayer' id='{LayerID}' style='display:{Is_Show}'>";
            string LayerFooter = "</div>";

            string editHtml = @"
            {LayerHeader}
            {FormHeader}
            {MainFormTable}
            {DetailTabForm}
            {HiddenField}
            {FormButton}           
            {FormFooter}
            {MainFormJs}  
            {LayerFooter}
            ";
            #endregion
            StringBuilder tmpHiddenLoop = new StringBuilder();
            PropertyDescriptorCollection pList = TypeDescriptor.GetProperties(typeof(T));
            //生成Hidden元素
            foreach (var m in D_List.Where(o => o.D_EditHidden == "true"))
            {
                string ReadValue = pList[m.D_Index] != null && pList[m.D_Index].GetValue(obj) != null
                        ? pList[m.D_Index].GetValue(obj).ToString() : "";
                string DefaultValue = !string.IsNullOrEmpty(m.D_DefaultValue) ? m.D_DefaultValue : "";
                tmpHiddenLoop.AppendLine(strLoopHiden.Replace("{D_DefaultValue}", ReadValue).Replace("{D_Index}", m.D_Index.Trim()));
            }

            string LayerId = M_Model.M_NameSpace.Trim() + "_Oper";
            string FormId = M_Model.M_NameSpace.Trim() + "_Form";

            //所有可见表单元素
            List<Sys_Config_Fieled> newD_List = new List<Sys_Config_Fieled>();
            newD_List = D_List.Where(o => o.D_EditHidden == "false" || string.IsNullOrEmpty(o.D_EditHidden))
                                  .OrderBy(o => o.D_EditOrder).ToList();

            //#region YF 0130
            //newD_List = D_List.OrderBy(o => o.D_EditOrder).ToList();
            //#endregion

            string MainFormTable = "";
            string DetailFormTab = "";
            int MainLineNum = 0;
            int TabMaxNum = 0;
            string strLineNum = ",height:{DialogHeight}";
            if (HasTab)
            {
                MainFormTable = CreateFormElement(M_Model,
                    newD_List.Where(o => string.IsNullOrEmpty(o.D_EditTab)).ToList(), obj, location, ref MainLineNum, pList);
                DetailFormTab = CreateDetailTab(M_Model, newD_List, Tabs, ref TabMaxNum);
            }
            else
            {
                MainFormTable = CreateFormElement(M_Model, newD_List, obj, location, ref MainLineNum, pList);
            }
            strLineNum = strLineNum.Replace("{DialogHeight}", (MainLineNum + TabMaxNum + 170).ToString());

            //生成表单内所有元素的Js
            string MainFormJs = CreateFormScript(M_Model, D_List, LayerId, IsOpenLayer, strLineNum, FormId);


            #region //生成JS
            //弹出层
            if (IsOpenLayer)
            {
                LayerHeader = LayerHeader.Replace("{Is_Show}", "none");
                editHtml = editHtml.Replace("{LayerHeader}", LayerHeader);
                editHtml = editHtml.Replace("{LayerFooter}", LayerFooter);
            }
            else
            {
                editHtml = editHtml.Replace("{LayerHeader}", "");
                editHtml = editHtml.Replace("{LayerFooter}", "");
            }
            #endregion

            #region 表单控制选项
            if (AllowForm)
            {
                editHtml = editHtml.Replace("{FormHeader}", FormHeader)
                                  .Replace("{FormFooter}", FormFooter);
            }
            else
            {
                editHtml = editHtml.Replace("{FormHeader}", "")
                                  .Replace("{FormFooter}", "");
            }
            if (AllowFormButton)
            {
                editHtml = editHtml.Replace("{FormButton}", FormButton);
            }
            else
            {
                editHtml = editHtml.Replace("{FormButton}", "");
            }
            #endregion
            editHtml = editHtml.Replace("{MainFormTable}", MainFormTable)
                .Replace("{DetailTabForm}", DetailFormTab)
                .Replace("{MainFormJs}", MainFormJs)
                .Replace("{HiddenField}", tmpHiddenLoop.ToString())
                .Replace("{preFix}", M_Model.M_NameSpace.Trim() + "_" + M_Model.M_ModuleCode.Trim())
                .Replace("{LayerID}", LayerId)
                .Replace("{FormID}", FormId)
                .Replace("{EditURL}", M_Model.M_EditUrl)
                .Replace("{M_EditColumNo}", M_Model.M_EditCloumNum.ToString());

            return editHtml;
        }
        #endregion

        #region 生成表单分组
        /// <summary>
        /// 生成表单分组Tab
        /// </summary>
        /// <param name="M_Model"></param>
        /// <param name="newD_List"></param>
        /// <returns></returns>
        private static string CreateDetailTab(Sys_Config_ListPage M_Model,
            List<Sys_Config_Fieled> newD_List, Dictionary<string, string> Tabs, ref int TabMaxNum)
        {
            string Li = @"<li><a href='#{Id}'>{Name}</a></li>";
            string Tab = "<div id='{Id}'> {Content} </div>";
            StringBuilder strLi = new StringBuilder();
            StringBuilder strTab = new StringBuilder();
            string html = @"<div id='{tabs}'>
                            <ul>
                                {LIList}
                            </ul>                         
                            {TABList}
                        </div>
                         <script type='text/javascript'>
                                $(document).ready(function() {
                                    $('#{tabs}').tabs();
                                })
                            </script>
            ";
            if (Tabs != null && Tabs.Count > 0)
            {
                List<int> tabsLineNum = new List<int>();
                foreach (KeyValuePair<string, string> kvp in Tabs)
                {
                    int LineNum = 0;
                    strLi.AppendLine(Li.Replace("{Id}", M_Model.M_NameSpace + "_" + kvp.Key).Replace("{Name}", kvp.Value));
                    strTab.AppendLine(Tab.Replace("{Id}", M_Model.M_NameSpace + "_" + kvp.Key).Replace("{Content}",
                        CreateFormElement(M_Model, newD_List.Where(o => o.D_EditTab == kvp.Key).ToList(), "center"
                        , ref LineNum)));
                    tabsLineNum.Add(LineNum);
                }
                TabMaxNum = tabsLineNum.Max();
            }
            html = html.Replace("{tabs}", M_Model.M_NameSpace)
                .Replace("{LIList}", strLi.ToString())
                .Replace("{TABList}", strTab.ToString());

            return html;
        }

        #endregion

        #region 生成空白表单
        /// <summary>
        /// 生成Form表单元素
        /// </summary>
        /// <param name="M_Model"></param>
        /// <param name="newD_List"></param>
        /// <returns></returns>
        private static string CreateFormElement(Sys_Config_ListPage M_Model,
            List<Sys_Config_Fieled> newD_List,
            string Location,
            ref int LineNum)
        {
            ADOComm comInstance = new ADOComm();

            string html = @" <table {Location}>
            <tr>
            {StrLoop}
            </table>";

            StringBuilder tmpStrLoop = new StringBuilder();

            //表单隐藏元素
            string strLoopHiden = @"<input name='{D_Index}' type='hidden' id='{D_Index}' value='{D_DefaultValue}' />";
            string strLoopLine = @"</tr><tr {LineHeight}>";
            string strLoopLast = @"</tr>";

            string strLoop = @"<td ><label class='form_label' form_label for='{D_Index}'>{D_Name}</label>
                                    <span class='div_texbox'>
                                        {strLoopX}                                   
                                    </span>
                               </td>";

            string strLoopColSpan = @" <td >
                                        <label class='form_label' form_label for='{D_Index}'>{D_Name}</label>
                                        <span class='div_texbox'>
                                            {strLoopX}                                   
                                        </span>
                                       </td>";

            string strLoopText = @"<input {D_EditReadOnly} name='{D_Index}' type='text' 
                                    class='form_textbox{AttachClass}' id='{D_Index}' value='{D_DefaultValue}' />
                                    <div>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span></span></div>";

            string strLoopSelect = @"<select {D_EditReadOnly} name='{D_Index}' class='select{AttachClass}' id='{D_Index}'></select>                                       <span></span>";

            string strLoopTextArea = @"<div class='div_textarea'><textarea rows=3 clos=2 {D_EditReadOnly} id='{D_Index}' name='{D_Index}' style='width:100%;'></textarea><div>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span></span></div></div>";

            string strFileText = @"<div class='div_textarea'><input type='text' name='{D_Index}' id='{D_Index}'> <input name='f_{D_Index}' id='f_{D_Index}' type='file'></div>";


            for (int i = 0; i < newD_List.Count; i++)
            {
                #region 生成,号
                string tmpLine = string.Empty;

                if ((i + 1) < newD_List.Count && newD_List[(i + 1)].D_EditType.ToLower() == "textarea")
                {
                    //tmpStrLoop = tmpStrLoop.Replace("{M_EditColumNo}", M_Model.M_EditCloumNum.ToString());
                    tmpLine = strLoopLine;
                }
                else
                {
                    if ((i + 1) > 1 && (i + 1) % M_Model.M_EditCloumNum == 0 && (i + 1) != newD_List.Count)
                    {
                        tmpLine = strLoopLine;
                    }
                    else if ((i + 1) == newD_List.Count)
                    {
                        tmpLine = strLoopLast;
                    }
                }

                if ((i + 1) < newD_List.Count && newD_List[i + 1].D_EditType == "textarea")
                {
                    tmpLine = tmpLine.Replace("{LineHeight}", " height='82px'");
                }
                else
                {
                    tmpLine = tmpLine.Replace("{LineHeight}", "");
                }


                #endregion

                string ReadOnly = !string.IsNullOrEmpty(newD_List[i].D_EditReadOnly) ? "readonly='" + newD_List[i].D_EditReadOnly + "'" : "";
                string DefaultValue = !string.IsNullOrEmpty(newD_List[i].D_DefaultValue) ? ParseDefaultValue(newD_List[i].D_DefaultValue) : "";
                string AttachClass = !string.IsNullOrEmpty(newD_List[i].D_EditReadOnly) ? "  TextBoxReadOnly" : "";


                switch (newD_List[i].D_EditType.Trim())
                {

                    case "text":
                        tmpStrLoop.Append(strLoop.Replace("{strLoopX}",
                            strLoopText
                            //.Replace("{err_display}", !string.IsNullOrEmpty(newD_List[i].D_EditRules) && newD_List[i].D_EditRules.Contains("required:true") ? "err_display" : "")
                            .Replace("{D_DefaultValue}", newD_List[i].D_IsKey != 1 ? DefaultValue : comInstance.GenTableKeyCode(M_Model.M_ModuleCode))
                            .Replace("{AttachClass}", AttachClass)
                            .Replace("{D_EditReadOnly}", ReadOnly)
                            .Replace("{D_Index}",
                            newD_List[i].D_Index.Trim())).Replace("{D_Name}",
                            newD_List[i].D_Name.Trim()) + tmpLine).Replace("{D_Index}", newD_List[i].D_Index.Trim());


                        break;
                    case "textarea":
                        tmpStrLoop.Append(strLoopColSpan.Replace("{M_EditColumNo}", M_Model.M_EditCloumNum.ToString())
                            .Replace("{strLoopX}",
                            strLoopTextArea.Replace("{D_DefaultValue}", DefaultValue)
                            .Replace("{AttachClass}", AttachClass)
                            .Replace("{D_EditReadOnly}", ReadOnly)
                            .Replace("{D_Index}",
                            newD_List[i].D_Index.Trim())).Replace("{D_Name}",
                            newD_List[i].D_Name.Trim()) + tmpLine).Replace("{D_Index}", newD_List[i].D_Index.Trim());
                        break;
                    case "dict":
                        tmpStrLoop.Append(strLoop.Replace("{strLoopX}", strLoopSelect
                            .Replace("{AttachClass}", AttachClass)
                            .Replace("{D_EditReadOnly}", ReadOnly)
                            .Replace("{D_Index}", newD_List[i].D_Index.Trim())).Replace("{D_Name}",
                                                                           newD_List[i].D_Name.Trim()) + tmpLine);
                        break;
                    case "date":
                        AttachClass = AttachClass + " date_icon";
                        tmpStrLoop.Append(strLoop.Replace("{strLoopX}", strLoopText
                            .Replace("{D_DefaultValue}", DefaultValue)
                            .Replace("{AttachClass}", AttachClass)
                            .Replace("{D_EditReadOnly}", ReadOnly)
                            .Replace("{D_Index}", newD_List[i].D_Index.Trim()))
                                                 .Replace("{D_Name}", newD_List[i].D_Name.Trim())
                                                 .Replace("{D_Index}", newD_List[i].D_Index.Trim()) + tmpLine);
                        break;
                    case "datetime":
                        AttachClass = AttachClass + " date_icon";
                        tmpStrLoop.Append(strLoop.Replace("{strLoopX}", strLoopText
                            .Replace("{D_DefaultValue}", DefaultValue)
                            .Replace("{AttachClass}", AttachClass)
                            .Replace("{D_EditReadOnly}", ReadOnly)
                            .Replace("{D_Index}", newD_List[i].D_Index.Trim()))
                                                 .Replace("{D_Name}", newD_List[i].D_Name.Trim())
                                                 .Replace("{D_Index}", newD_List[i].D_Index.Trim()) + tmpLine);
                        break;
                    case "layer":
                        AttachClass = AttachClass + "  popup";
                        tmpStrLoop.Append(strLoop.Replace("{strLoopX}", strLoopText
                            .Replace("{D_DefaultValue}", DefaultValue)
                            .Replace("{AttachClass}", AttachClass)
                            .Replace("{D_EditReadOnly}", ReadOnly)
                            .Replace("{D_Index}", newD_List[i].D_Index.Trim()))
                            .Replace("{D_Name}", newD_List[i].D_Name)
                            .Replace("{D_Index}", newD_List[i].D_Index.Trim()) + tmpLine);

                        break;
                    case "loadadd":
                        AttachClass = AttachClass + "  popup";
                        tmpStrLoop.Append(strLoop.Replace("{strLoopX}", strLoopText
                            .Replace("{D_DefaultValue}", DefaultValue)
                            .Replace("{AttachClass}", AttachClass)
                            .Replace("{D_EditReadOnly}", ReadOnly)
                            .Replace("{D_Index}", newD_List[i].D_Index.Trim()))
                            .Replace("{D_Name}", newD_List[i].D_Name)
                            .Replace("{D_Index}", newD_List[i].D_Index.Trim()) + tmpLine);

                        break;
                    case "loadall":
                        AttachClass = AttachClass + "  popup";
                        tmpStrLoop.Append(strLoop.Replace("{strLoopX}", strLoopText
                            .Replace("{D_DefaultValue}", DefaultValue)
                            .Replace("{AttachClass}", AttachClass)
                            .Replace("{D_EditReadOnly}", ReadOnly)
                            .Replace("{D_Index}", newD_List[i].D_Index.Trim()))
                            .Replace("{D_Name}", newD_List[i].D_Name)
                            .Replace("{D_Index}", newD_List[i].D_Index.Trim()) + tmpLine);

                        break;
                    case "file":
                        tmpStrLoop.Append(strLoop.Replace("{strLoopX}",
                            strFileText).Replace("{D_Name}",
                            newD_List[i].D_Name.Trim()) + tmpLine).Replace("{D_Index}", newD_List[i].D_Index.Trim());
                        break;

                    case "code":

                        AttachClass = AttachClass + "  popup";
                        tmpStrLoop.Append(strLoop.Replace("{strLoopX}", strLoopText
                            .Replace("{D_DefaultValue}", DefaultValue)
                            .Replace("{AttachClass}", AttachClass)
                            .Replace("{D_EditReadOnly}", ReadOnly)
                            .Replace("{D_Index}", newD_List[i].D_Index.Trim() + "_N"))
                            .Replace("{D_Name}", newD_List[i].D_Name)
                            .Replace("{D_Index}", newD_List[i].D_Index.Trim()) + tmpLine);

                        //string strLoopHiden = @"<input name='{D_Index}' type='hidden' id='{D_Index}' value='{D_DefaultValue}' />";
                        tmpStrLoop.Append(
                            strLoopHiden.Replace("{D_Index}", newD_List[i].D_Index.Trim())
                                        .Replace("{D_DefaultValue}", DefaultValue)
                            );

                        break;
                }

                if ((i + 1) < newD_List.Count && newD_List[(i + 1)].D_EditType.ToLower() == "textarea")
                {
                    tmpStrLoop.Replace("{M_EditColumNo}", M_Model.M_EditCloumNum.ToString());
                }
                else
                {
                    tmpStrLoop.Replace("{M_EditColumNo}", "1");
                }
            }

            //计算行高 一行25px
            try
            {
                var textResult = newD_List.Where(o => o.D_EditType != "textarea");
                var areaResult = newD_List.Where(o => o.D_EditType == "textarea");
                LineNum = (textResult.Count() / 2) * 25 + areaResult.Count() * 72;
            }
            catch (System.Exception ex)
            {
                LineNum = 0;
            }

            html = html.Replace("{StrLoop}",
                tmpStrLoop.ToString()).Replace("{Location}", string.IsNullOrEmpty(Location) ? "" : "align='" + Location + "'");


            return html;
        }
        #endregion

        #region 生成From表单，并绑定值
        /// <summary>
        /// 生成Form表单元素
        /// </summary>
        /// <param name="M_Model"></param>
        /// <param name="newD_List"></param>
        /// <returns></returns>
        private static string CreateFormElement<T>(Sys_Config_ListPage M_Model,
            List<Sys_Config_Fieled> newD_List, T obj,
            string Location,
            ref int LineNum, PropertyDescriptorCollection pList)
        {
            ADOComm comInstance = new ADOComm();

            string html = @" <table {Location}>
            <tr>
            {StrLoop}
            </table>";

            //PropertyDescriptorCollection pList = TypeDescriptor.GetProperties(typeof(T));

            StringBuilder tmpStrLoop = new StringBuilder();

            string strLoopHiden = @"<input name='{D_Index}' type='hidden' id='{D_Index}' value='{D_DefaultValue}' />";
            string strLoopLine = @"</tr><tr {LineHeight}>";
            string strLoopLast = @"</tr>";

            string strLoop = @"<td ><label class='form_label' form_label for='{D_Index}'>{D_Name}</label>
                                    <span class='div_texbox'>
                                        {strLoopX}                                   
                                    </span>
                               </td>";

            string strLoopColSpan = @" <td >
                                        <label class='form_label' form_label for='{D_Index}'>{D_Name}</label>
                                        <span class='div_texbox'>
                                            {strLoopX}                                   
                                        </span>
                                       </td>";

            string strLoopText = @"<input {D_EditReadOnly} name='{D_Index}' type='text' 
                                    class='form_textbox{AttachClass}' id='{D_Index}' value='{D_DefaultValue}' />
                                    <div>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span></span></div>";

            string strLoopSelect = @"<select {D_EditReadOnly} name='{D_Index}' class='select{AttachClass}' id='{D_Index}'><option>{D_DefaultValue}</option></select>                                       <span></span>";

            string strLoopTextArea = @"<div class='div_textarea'><textarea rows=3 clos=2 {D_EditReadOnly} id='{D_Index}' name='{D_Index}' style='width:100%;'>{D_DefaultValue}</textarea><div>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span></span></div></div>";
            //表单隐藏元素

            string strFileText = @"<div class='div_textarea'><input type='text' name='{D_Index}' id='{D_Index}'> <input name='f_{D_Index}' id='f_{D_Index}' type='file'></div>";


            for (int i = 0; i < newD_List.Count; i++)
            {


                #region 生成,号
                string tmpLine = string.Empty;

                if ((i + 1) < newD_List.Count && newD_List[(i + 1)].D_EditType.ToLower() == "textarea")
                {
                    //tmpStrLoop = tmpStrLoop.Replace("{M_EditColumNo}", M_Model.M_EditCloumNum.ToString());
                    tmpLine = strLoopLine;
                }
                else
                {
                    if ((i + 1) > 1 && (i + 1) % M_Model.M_EditCloumNum == 0 && (i + 1) != newD_List.Count)
                    {
                        tmpLine = strLoopLine;
                    }
                    else if ((i + 1) == newD_List.Count)
                    {
                        tmpLine = strLoopLast;
                    }
                }

                if ((i + 1) < newD_List.Count && newD_List[i + 1].D_EditType == "textarea")
                {
                    tmpLine = tmpLine.Replace("{LineHeight}", " height='82px'");
                }
                else
                {
                    tmpLine = tmpLine.Replace("{LineHeight}", "");
                }


                #endregion

                string ReadOnly = !string.IsNullOrEmpty(newD_List[i].D_EditReadOnly) ? "readonly='" + newD_List[i].D_EditReadOnly + "'" : "";
                string DefaultValue = !string.IsNullOrEmpty(newD_List[i].D_DefaultValue) ? newD_List[i].D_DefaultValue : "";
                string AttachClass = !string.IsNullOrEmpty(newD_List[i].D_EditReadOnly) ? "  TextBoxReadOnly" : "";

                string ReadValue = "";
                if (pList[newD_List[i].D_Index] != null && pList[newD_List[i].D_Index].GetValue(obj) != null)
                {
                    if (newD_List[i].D_EditType == "date")
                    {
                        //ReadValue = DateTime.Parse(pList[newD_List[i].D_Index].GetValue(obj).ToString()).ToString("yyyy-MM-dd");
                        ReadValue = string.Format("{0:d}", DateTime.Parse(pList[newD_List[i].D_Index].GetValue(obj).ToString()));
                    }
                    else if (newD_List[i].D_EditType == "datetime")
                    {
                        ReadValue = string.Format("{0:G}", DateTime.Parse(pList[newD_List[i].D_Index].GetValue(obj).ToString()));
                    }
                    else
                    {
                        ReadValue = pList[newD_List[i].D_Index].GetValue(obj).ToString();
                    }
                }

                //if (newD_List[i].D_EditHidden == "true")
                //{
                //    hiddenHtml += strLoopHiden.Replace("{D_DefaultValue}", ReadValue).Replace("{D_Index}", newD_List[i].D_Index);
                //    continue;
                //}
                //tmpStrLoop.AppendLine(strLoopHiden.Replace("{D_DefaultValue}", ParseDefaultValue(DefaultValue)).Replace("{D_Index}", m.D_Index.Trim()));

                switch (newD_List[i].D_EditType.Trim())
                {

                    case "text":
                        tmpStrLoop.Append(strLoop.Replace("{strLoopX}",
                            strLoopText.Replace("{D_DefaultValue}", ReadValue)
                            .Replace("{AttachClass}", AttachClass)
                            .Replace("{D_EditReadOnly}", ReadOnly)
                            .Replace("{D_Index}",
                            newD_List[i].D_Index.Trim())).Replace("{D_Name}",
                            newD_List[i].D_Name.Trim()) + tmpLine).Replace("{D_Index}", newD_List[i].D_Index.Trim());


                        break;
                    case "textarea":
                        tmpStrLoop.Append(strLoopColSpan.Replace("{M_EditColumNo}", M_Model.M_EditCloumNum.ToString())
                            .Replace("{strLoopX}",
                            strLoopTextArea.Replace("{D_DefaultValue}", ReadValue)
                            .Replace("{AttachClass}", AttachClass)
                            .Replace("{D_EditReadOnly}", ReadOnly)
                            .Replace("{D_Index}",
                            newD_List[i].D_Index.Trim())).Replace("{D_Name}",
                            newD_List[i].D_Name.Trim()) + tmpLine).Replace("{D_Index}", newD_List[i].D_Index.Trim());
                        break;
                    case "dict":
                        tmpStrLoop.Append(strLoop.Replace("{strLoopX}", strLoopSelect
                            .Replace("{D_DefaultValue}", ReadValue)
                            .Replace("{AttachClass}", AttachClass)
                            .Replace("{D_EditReadOnly}", ReadOnly)
                            .Replace("{D_Index}", newD_List[i].D_Index.Trim())).Replace("{D_Name}",
                                                                           newD_List[i].D_Name.Trim()) + tmpLine);
                        break;
                    case "date":
                        AttachClass = AttachClass + " date_icon";
                        tmpStrLoop.Append(strLoop.Replace("{strLoopX}", strLoopText
                            .Replace("{D_DefaultValue}", ReadValue)
                            .Replace("{AttachClass}", AttachClass)
                            .Replace("{D_EditReadOnly}", ReadOnly)
                            .Replace("{D_Index}", newD_List[i].D_Index.Trim()))
                                                 .Replace("{D_Name}", newD_List[i].D_Name.Trim())
                                                 .Replace("{D_Index}", newD_List[i].D_Index.Trim()) + tmpLine);
                        break;
                    case "datetime":
                        AttachClass = AttachClass + " date_icon";
                        tmpStrLoop.Append(strLoop.Replace("{strLoopX}", strLoopText
                            .Replace("{D_DefaultValue}", DefaultValue)
                            .Replace("{AttachClass}", AttachClass)
                            .Replace("{D_EditReadOnly}", ReadOnly)
                            .Replace("{D_Index}", newD_List[i].D_Index.Trim()))
                                                 .Replace("{D_Name}", newD_List[i].D_Name.Trim())
                                                 .Replace("{D_Index}", newD_List[i].D_Index.Trim()) + tmpLine);
                        break;
                    case "layer":
                        AttachClass = AttachClass + "  popup";
                        tmpStrLoop.Append(strLoop.Replace("{strLoopX}", strLoopText
                            .Replace("{D_DefaultValue}", ReadValue)
                            .Replace("{AttachClass}", AttachClass)
                            .Replace("{D_EditReadOnly}", ReadOnly)
                            .Replace("{D_Index}", newD_List[i].D_Index.Trim()))
                            .Replace("{D_Name}", newD_List[i].D_Name)
                            .Replace("{D_Index}", newD_List[i].D_Index.Trim()) + tmpLine);

                        break;
                    case "loadadd":
                        AttachClass = AttachClass + "  popup";
                        tmpStrLoop.Append(strLoop.Replace("{strLoopX}", strLoopText
                            .Replace("{D_DefaultValue}", ReadValue)
                            .Replace("{AttachClass}", AttachClass)
                            .Replace("{D_EditReadOnly}", ReadOnly)
                            .Replace("{D_Index}", newD_List[i].D_Index.Trim()))
                            .Replace("{D_Name}", newD_List[i].D_Name)
                            .Replace("{D_Index}", newD_List[i].D_Index.Trim()) + tmpLine);

                        break;
                    case "loadall":
                        AttachClass = AttachClass + "  popup";
                        tmpStrLoop.Append(strLoop.Replace("{strLoopX}", strLoopText
                            .Replace("{D_DefaultValue}", ReadValue)
                            .Replace("{AttachClass}", AttachClass)
                            .Replace("{D_EditReadOnly}", ReadOnly)
                            .Replace("{D_Index}", newD_List[i].D_Index.Trim()))
                            .Replace("{D_Name}", newD_List[i].D_Name)
                            .Replace("{D_Index}", newD_List[i].D_Index.Trim()) + tmpLine);

                        break;
                    case "file":
                        tmpStrLoop.Append(strLoop.Replace("{strLoopX}",
                            strFileText).Replace("{D_Name}",
                            newD_List[i].D_Name.Trim()) + tmpLine).Replace("{D_Index}", newD_List[i].D_Index.Trim());
                        break;

                    case "code":

                        string ReadValueName = "";
                        if (!string.IsNullOrEmpty(newD_List[i].D_UDEF1))
                        {
                            string[] Converts = newD_List[i].D_UDEF1.Split(',');
                            if (Converts.Count() == 3)
                            {
                                if (!string.IsNullOrEmpty(ReadValue))
                                {

                                    var data = ADOComm.ListDataByCode(Converts[0], Converts[1] + "='" + ReadValue + "'");
                                    if (data.Rows.Count > 0)
                                    {
                                        ReadValueName = data.Rows[0][Converts[2]].ToString();
                                    }
                                }
                            }
                        }
                        AttachClass = AttachClass + "  popup";
                        tmpStrLoop.Append(strLoop.Replace("{strLoopX}", strLoopText
                            .Replace("{D_DefaultValue}", ReadValueName)
                            .Replace("{AttachClass}", AttachClass)
                            .Replace("{D_EditReadOnly}", ReadOnly)
                            .Replace("{D_Index}", newD_List[i].D_Index.Trim() + "_N"))
                            .Replace("{D_Name}", newD_List[i].D_Name)
                            .Replace("{D_Index}", newD_List[i].D_Index.Trim()) + tmpLine);

                        //string strLoopHiden = @"<input name='{D_Index}' type='hidden' id='{D_Index}' value='{D_DefaultValue}' />";
                        tmpStrLoop.Append(
                            strLoopHiden.Replace("{D_Index}", newD_List[i].D_Index.Trim())
                                        .Replace("{D_DefaultValue}", ReadValue)
                            );

                        break;

                }

                if ((i + 1) < newD_List.Count && newD_List[(i + 1)].D_EditType.ToLower() == "textarea")
                {
                    tmpStrLoop.Replace("{M_EditColumNo}", M_Model.M_EditCloumNum.ToString());
                }
                else
                {
                    tmpStrLoop.Replace("{M_EditColumNo}", "1");
                }
            }

            //计算行高 一行25px
            try
            {
                var textResult = newD_List.Where(o => o.D_EditType != "textarea");
                var areaResult = newD_List.Where(o => o.D_EditType == "textarea");
                LineNum = (textResult.Count() / 2) * 25 + areaResult.Count() * 72;
            }
            catch (System.Exception ex)
            {
                LineNum = 0;
            }

            html = html.Replace("{StrLoop}", tmpStrLoop.ToString()).Replace("{Location}", string.IsNullOrEmpty(Location) ? "" : "align='" + Location
+ "'");
            return html;
        }
        #endregion

        #region 生成表单元素的绑定Javascript
        /// <summary>
        /// 生成表单元素的绑定Javascript
        /// </summary>
        /// <param name="M_Model"></param>
        /// <param name="newD_List"></param>
        /// <returns></returns>
        private static string CreateFormScript(Sys_Config_ListPage M_Model, List<Sys_Config_Fieled> newD_List,
            string LayerId, bool IsOpenLayer, string strLineNum, string FormId)
        {
            string html = @"<script type='text/javascript'>
                $(document).ready(function() {        
                    {CallJs}
                });
                function {FormID}LoadAddEx(){
                    {tmpScriptLoadAdd}
                }
                function {FormID}LoadAllEx(){
                    {tmpScriptLoadAll}
                }
            </script>  ";

            StringBuilder tmpScriptLoop = new StringBuilder();
            StringBuilder tmpScriptLoadAdd = new StringBuilder();
            StringBuilder tmpScriptLoadAll = new StringBuilder();
            for (int i = 0; i < newD_List.Count; i++)
            {
                switch (newD_List[i].D_EditType.Trim())
                {

                    case "dict":
                        //绑定Dict js控件
                        if (!string.IsNullOrEmpty(newD_List[i].D_DictKey))
                        {
                            //Yaosongwen {D_CName} 
                            string Comm_Dict = "Common_Select_Dict.Init($('#{D_Index}'), '{Dict_Key}','{D_CName}');";
                            tmpScriptLoop.AppendLine(Comm_Dict.Replace("{Dict_Key}",
                                newD_List[i].D_DictKey.Trim()).Replace("{D_Index}",
                                newD_List[i].D_Index.Trim()).Replace("{D_CName}", newD_List[i].D_UDEF2));
                        }

                        break;
                    case "date":
                        tmpScriptLoop.AppendLine("$('#" + newD_List[i].D_Index.Trim() + "').click(function(){ WdatePicker(); });");
                        //tmpScriptLoop.AppendLine(string.Format("$('#{0}').datepicker();", newD_List[i].D_Index.Trim()));
                        //tmpScriptLoop.AppendLine("$('" + newD_List[i].D_Index.Trim() + "').datepicker( 'option', 'dateFormat', 'yyyy-mm-dd');");
                        break;
                    case "datetime":
                        tmpScriptLoop.AppendLine("$('#" + newD_List[i].D_Index.Trim() + "').click(function(){ WdatePicker({dateFmt:'yyyy-MM-dd HH:mm:ss'}); });");
                        //tmpScriptLoop.AppendLine("$('#" + newD_List[i].D_Index.Trim() + "').datetimepicker({ showSecond:true,timeFormat:'hh:mm:ss' });");                       
                        break;
                    case "layer":
                        tmpScriptLoop.AppendLine(newD_List[i].D_OpenLayer);
                        break;
                    case "loadadd":
                        tmpScriptLoadAdd.AppendLine(newD_List[i].D_OpenLayer);
                        break;
                    case "loadall":
                        tmpScriptLoadAll.AppendLine(newD_List[i].D_OpenLayer);
                        break;
                    case "file":
                        string strFile = @" $('#f_{D_Index}').change(function(){
                                                $(this).upload('/Attachments/FileUP',function(result){
                                                    if(result!=''){ $('#{D_Index}').val(result); }
                                                    $('#{D_Index}').after('<input type=file id=f_{D_Index} name=f_{D_Index}>');
                                                },'html');
                                         }); ";
                        tmpScriptLoop.AppendLine(strFile.Replace("{D_Index}", newD_List[i].D_Index));
                        break;
                }
                //.Replace("{M_EditColumNo}",M_Model.M_EditCloumNum.ToString())
            }

            if (IsOpenLayer)
            {
                string strDialog = "$('#{LayerId}').dialog({ autoOpen: false,title:'{Title}',width: 800, minWidth: 750,minHeight:200" + strLineNum + " });";
                strDialog = strDialog.Replace("{LayerId}", LayerId);
                if (!string.IsNullOrEmpty(M_Model.M_EditTitle))
                {
                    strDialog = strDialog.Replace("{Title}", M_Model.M_EditTitle);
                    //string[] titles = M_Model.M_EditTitle.Split(',');
                    //if (titles.Length>0)
                    //{
                    //    strDialog = strDialog.Replace("{Title}", titles[0]);
                    //}
                }
                else
                {
                    strDialog = strDialog.Replace("{Title}", "编辑记录");
                }
                tmpScriptLoop.AppendLine(strDialog);
            }

            //生成Hidden元素
            foreach (var m in newD_List.Where(o => o.D_EditHidden == "true"))
            {
                switch (m.D_EditType.Trim())
                {
                    case "loadadd":
                        tmpScriptLoadAdd.AppendLine(m.D_OpenLayer);
                        break;
                    case "loadall":
                        tmpScriptLoadAll.AppendLine(m.D_OpenLayer);
                        break;
                }
            }

            html = html.Replace("{CallJs}", tmpScriptLoop.ToString())
                .Replace("{tmpScriptLoadAdd}", tmpScriptLoadAdd.ToString())
                .Replace("{tmpScriptLoadAll}", tmpScriptLoadAll.ToString());

            return html;
        }

        #endregion

        #region List扩展表单

        /// <summary>
        /// 生成空白表单(扩展）
        /// </summary>
        /// <param name="M_Model"></param>
        /// <param name="D_List"></param>
        /// <returns></returns>
        public static string AutoBindForm(Sys_Config_ListPage M_Model, List<Sys_Config_Fieled> D_List, string LayerId, string FormId)
        {
            if (string.IsNullOrEmpty(M_Model.M_ToolBarExtend))
            {
                return string.Empty;
            }

            ADOBse_Dict DictInstance = new ADOBse_Dict();

            string strLoopLine = @"</tr><tr>";
            string strLoopLast = @"</tr>";

            string strLoop = @" <td><label class='form_label' form_label for='{D_Index}'>{D_Name}</label>
                                    <span class='div_texbox'>
                                    {strLoopX}                                   
                                </span>
                                </td>";
            string strLoopText = @"<input {D_EditReadOnly} name='{D_Index}' type='text' class='form_textbox{AttachClass}' id='{D_Index}' value='{D_DefaultValue}' /><div>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span></span></div>";
            string strLoopSelect = @"<select {D_EditReadOnly} name='{D_Index}' class='select{AttachClass}' id='{D_Index}'></select><span></span>";
            string strLoopHiden = @"<input name='{D_Index}' type='hidden' id='{D_Index}' value='{D_DefaultValue}' />";

            #region JqGrid Html表单编辑Html层
            string editHtml = @"
            <style>
                #{FormID} label.error {
                    width: auto;
                    display:none;
                    color: red;
                .errorClass {
                    border:solid 1px red;
                }
            }
            </style>
            <div id='{LayerID}' style='display:none'>
            <form action='{EditURL}' id='{FormID}' method='post' name='{FormID}'>
            <table>
            <tr>
            {StrLoop}
            </table>
            {HiddenField}
            <input type='hidden' name='{FormID}oper' id='{FormID}oper' value=''>
            <input id=btnSave{FormID} type='button' name=btnSave{FormID}  value='保存' onclick={'}{preFix}_GridControl.SaveDataExtends('{LayerID}' ,'{FormID}'){'} />
            <input id=btnCancle{FormID} type='button' name=btnCancle{FormID} value='取消' onclick={'}{preFix}_GridControl.CancelEditExtends( '{LayerID}' ,'{FormID}'){'} />
            </form> 
            <script type='text/javascript'>
                $(document).ready(function() {        
                    {ValidationJs}   
                    {CallJs}
                });
                {JsFunction}
                function {FormID}LoadAddEx(){
                    {tmpScriptLoadAdd}
                }
                function {FormID}LoadAllEx(){
                    {tmpScriptLoadAll}
                }

            </script>  
            </div>
            ";
            #endregion
            StringBuilder tmpStrLoop = new StringBuilder();
            StringBuilder tmpScriptLoop = new StringBuilder();
            StringBuilder tmpScriptLoadAdd = new StringBuilder();
            StringBuilder tmpScriptLoadAll = new StringBuilder();
            StringBuilder tmpHiddenLoop = new StringBuilder();
            StringBuilder tmpValidatinRules = new StringBuilder();
            StringBuilder tmpValidationMsg = new StringBuilder();

            //var newD_List = D_List.Where(o => o.D_EditHidden == "false"
            //    || string.IsNullOrEmpty(o.D_EditHidden)).OrderBy(o => o.D_EditOrder).ToList();//对List重新排序
            List<Sys_Config_Fieled> newD_List = new List<Sys_Config_Fieled>();
            if (FormId.Contains("btn1"))
            {
                newD_List = D_List.Where(o => !string.IsNullOrEmpty(o.D_UDEF1)
                && JsonConvert.DeserializeObject<FormEdit>(o.D_UDEF1).Show.ToLower() == "true")
                .OrderBy(o => JsonConvert.DeserializeObject<FormEdit>(o.D_UDEF1).Order).ToList();
            }
            else if (FormId.Contains("btn2"))
            {
                newD_List = D_List.Where(o => !string.IsNullOrEmpty(o.D_UDEF2)
                && JsonConvert.DeserializeObject<FormEdit>(o.D_UDEF2).Show.ToLower() == "true")
                .OrderBy(o => JsonConvert.DeserializeObject<FormEdit>(o.D_UDEF2).Order).ToList();
            }
            else if (FormId.Contains("btn3"))
            {
                newD_List = D_List.Where(o => !string.IsNullOrEmpty(o.D_UDEF3)
                && JsonConvert.DeserializeObject<FormEdit>(o.D_UDEF3).Show.ToLower() == "true")
                .OrderBy(o => JsonConvert.DeserializeObject<FormEdit>(o.D_UDEF3).Order).ToList();
            }
            else if (FormId.Contains("btn4"))
            {
                newD_List = D_List.Where(o => !string.IsNullOrEmpty(o.D_UDEF4)
                  && JsonConvert.DeserializeObject<FormEdit>(o.D_UDEF4).Show.ToLower() == "true")
                  .OrderBy(o => JsonConvert.DeserializeObject<FormEdit>(o.D_UDEF4).Order).ToList();
            }

            if (newD_List.Count == 0)
            {
                return string.Empty;
            }

            for (int i = 0; i < newD_List.Count; i++)
            {

                #region 生成,号
                string tmpLine = string.Empty;

                if ((i + 1) > 1 && (i + 1) % M_Model.M_EditCloumNum == 0 && (i + 1) != newD_List.Count)
                {
                    tmpLine = strLoopLine;
                }
                else if ((i + 1) == newD_List.Count)
                {
                    tmpLine = strLoopLast;
                }
                #endregion
                #region 生成验证规则
                if (!string.IsNullOrEmpty(newD_List[i].D_EditRules))
                {
                    tmpValidatinRules.AppendLine(newD_List[i].D_Index.Trim() + ":{ " + newD_List[i].D_EditRules.Trim() + " }" + ",");
                }
                #endregion
                #region 生成验证消息
                if (!string.IsNullOrEmpty(newD_List[i].D_EditMessage))
                {
                    tmpValidationMsg.AppendLine(newD_List[i].D_Index.Trim() + ":{ " + newD_List[i].D_EditMessage.Trim() + " }" + ",");
                }
                #endregion

                //string ReadOnly = !string.IsNullOrEmpty(newD_List[i].D_EditReadOnly) ? "readonly='" + newD_List[i].D_EditReadOnly + "'" : "";
                string DefaultValue = !string.IsNullOrEmpty(newD_List[i].D_DefaultValue) ? newD_List[i].D_DefaultValue : "";
                //string AttachClass = !string.IsNullOrEmpty(newD_List[i].D_EditReadOnly) ? "  TextBoxReadOnly" : "";

                string ReadOnly = string.Empty;
                string AttachClass = string.Empty;
                if (FormId.Contains("btn1"))
                {
                    ReadOnly = !string.IsNullOrEmpty(newD_List[i].D_UDEF1)
                        && (JsonConvert.DeserializeObject<FormEdit>(newD_List[i].D_UDEF1).ReadOnly.ToLower() == "true")
                        ? "readonly=true" : "";
                    AttachClass = !string.IsNullOrEmpty(newD_List[i].D_UDEF1)
                        && (JsonConvert.DeserializeObject<FormEdit>(newD_List[i].D_UDEF1).ReadOnly.ToLower() == "true")
                        ? "  TextBoxReadOnly" : "";
                }
                else if (FormId.Contains("btn2"))
                {
                    ReadOnly = !string.IsNullOrEmpty(newD_List[i].D_UDEF2)
                        && (JsonConvert.DeserializeObject<FormEdit>(newD_List[i].D_UDEF2).ReadOnly.ToLower() == "true")
                        ? "readonly=true" : "";
                    AttachClass = !string.IsNullOrEmpty(newD_List[i].D_UDEF2)
                        && (JsonConvert.DeserializeObject<FormEdit>(newD_List[i].D_UDEF2).ReadOnly.ToLower() == "true")
                        ? "  TextBoxReadOnly" : "";
                }
                else
                    if (FormId.Contains("btn3"))
                    {
                        ReadOnly = !string.IsNullOrEmpty(newD_List[i].D_UDEF3)
                            && (JsonConvert.DeserializeObject<FormEdit>(newD_List[i].D_UDEF3).ReadOnly.ToLower() == "true")
                            ? "readonly=true" : "";
                        AttachClass = !string.IsNullOrEmpty(newD_List[i].D_UDEF3)
                            && (JsonConvert.DeserializeObject<FormEdit>(newD_List[i].D_UDEF3).ReadOnly.ToLower() == "true")
                            ? "  TextBoxReadOnly" : "";
                    }
                    else
                        if (FormId.Contains("btn4"))
                        {
                            ReadOnly = !string.IsNullOrEmpty(newD_List[i].D_UDEF4)
                                && (JsonConvert.DeserializeObject<FormEdit>(newD_List[i].D_UDEF4).ReadOnly.ToLower() == "true")
                                ? "readonly=true" : "";
                            AttachClass = !string.IsNullOrEmpty(newD_List[i].D_UDEF4)
                                && (JsonConvert.DeserializeObject<FormEdit>(newD_List[i].D_UDEF4).ReadOnly.ToLower() == "true")
                                ? "  TextBoxReadOnly" : "";
                        }

                switch (newD_List[i].D_EditType.Trim())
                {
                    case "text":
                        tmpStrLoop.Append(strLoop.Replace("{strLoopX}",
                            strLoopText.Replace("{D_DefaultValue}", DefaultValue)
                            .Replace("{AttachClass}", AttachClass)
                            .Replace("{D_EditReadOnly}", ReadOnly)
                            .Replace("{D_Index}",
                            newD_List[i].D_Index.Trim())).Replace("{D_Name}",
                            newD_List[i].D_Name.Trim()) + tmpLine).Replace("{D_Index}", newD_List[i].D_Index.Trim());
                        break;
                    case "dict":
                        tmpStrLoop.Append(strLoop.Replace("{strLoopX}", strLoopSelect
                            .Replace("{AttachClass}", AttachClass)
                            .Replace("{D_EditReadOnly}", ReadOnly)
                            .Replace("{D_Index}", newD_List[i].D_Index.Trim())).Replace("{D_Name}", newD_List[i].D_Name.Trim()) + tmpLine);
                        //绑定Dict js控件
                        string Comm_Dict = "Common_Select_Dict.Init($('#{D_Index}'), '{Dict_Key}');";
                        tmpScriptLoop.AppendLine(Comm_Dict.Replace("{Dict_Key}",
                            newD_List[i].D_DictKey.Trim()).Replace("{D_Index}",
                            newD_List[i].D_Index.Trim()));

                        break;
                    case "select":
                        //string sql = string.Format(" AND Dict_Key='{0}' AND Dict_Code!='{0}'", newD_List[i].D_DictKey);
                        //var DicList = DictInstance.GetListByWhere(sql);                     

                        #region 原自动生成Dict
                        //StringBuilder tmpSelect = new StringBuilder();
                        //if (DicList.Count > 0)
                        //{
                        //    foreach (var select in DicList)
                        //    {
                        //        tmpSelect.AppendFormat("<option value='{0}'>{1}</option>", select.Dict_Code.Trim(), select.Dict_Name.Trim());
                        //    }
                        //}
                        #endregion
                        //tmpStrLoop.Append(strLoopSelect.Replace("{D_Index}", newD_List[i].D_Index.Trim()).Replace("{ItemList}", tmpSelect.ToString() + tmpLine));
                        break;
                    case "date":
                        AttachClass = AttachClass + " date_icon";
                        tmpStrLoop.Append(strLoop.Replace("{strLoopX}", strLoopText
                            .Replace("{D_DefaultValue}", DefaultValue)
                            .Replace("{AttachClass}", AttachClass)
                            .Replace("{D_EditReadOnly}", ReadOnly)
                            .Replace("{D_Index}", newD_List[i].D_Index.Trim()))
                                                 .Replace("{D_Name}", newD_List[i].D_Name.Trim())
                                                 .Replace("{D_Index}", newD_List[i].D_Index.Trim()) + tmpLine);

                        tmpScriptLoop.AppendLine(string.Format("$( '#{0}' ).datepicker();", newD_List[i].D_Index.Trim()));
                        tmpScriptLoop.AppendLine("$('" + newD_List[i].D_Index.Trim() + "').datepicker( 'option', 'dateFormat', 'yyyy-mm-dd');");
                        break;
                    case "layer":
                        AttachClass = AttachClass + "  popup";
                        tmpStrLoop.Append(strLoop.Replace("{strLoopX}", strLoopText
                            .Replace("{D_DefaultValue}", DefaultValue)
                            .Replace("{AttachClass}", AttachClass)
                            .Replace("{D_EditReadOnly}", ReadOnly)
                            .Replace("{D_Index}", newD_List[i].D_Index.Trim()))
                            .Replace("{D_Name}", newD_List[i].D_Name)
                            .Replace("{D_Index}", newD_List[i].D_Index.Trim()) + tmpLine);

                        tmpScriptLoop.AppendLine(newD_List[i].D_OpenLayer);
                        break;
                    case "loadadd":
                        AttachClass = AttachClass + "  popup";
                        tmpStrLoop.Append(strLoop.Replace("{strLoopX}", strLoopText
                            .Replace("{D_DefaultValue}", DefaultValue)
                            .Replace("{AttachClass}", AttachClass)
                            .Replace("{D_EditReadOnly}", ReadOnly)
                            .Replace("{D_Index}", newD_List[i].D_Index.Trim()))
                            .Replace("{D_Name}", newD_List[i].D_Name)
                            .Replace("{D_Index}", newD_List[i].D_Index.Trim()) + tmpLine);

                        tmpScriptLoadAdd.AppendLine(newD_List[i].D_OpenLayer);
                        break;
                    case "loadall":
                        AttachClass = AttachClass + "  popup";
                        tmpStrLoop.Append(strLoop.Replace("{strLoopX}", strLoopText
                            .Replace("{D_DefaultValue}", DefaultValue)
                            .Replace("{AttachClass}", AttachClass)
                            .Replace("{D_EditReadOnly}", ReadOnly)
                            .Replace("{D_Index}", newD_List[i].D_Index.Trim()))
                            .Replace("{D_Name}", newD_List[i].D_Name)
                            .Replace("{D_Index}", newD_List[i].D_Index.Trim()) + tmpLine);

                        tmpScriptLoadAll.AppendLine(newD_List[i].D_OpenLayer);
                        break;
                }
            }

            foreach (var m in D_List.Where(o => o.D_EditHidden == "true"))
            {
                string DefaultValue = !string.IsNullOrEmpty(m.D_DefaultValue) ? m.D_DefaultValue : "";
                tmpHiddenLoop.AppendLine(strLoopHiden.Replace("{D_DefaultValue}", DefaultValue).Replace("{D_Index}", m.D_Index.Trim()));
            }

            //string LayerId = M_Model.M_NameSpace.Trim() + "_Oper";
            //string FormId = M_Model.M_NameSpace.Trim() + "_Form";

            //生成JS
            //弹出层
            string strDialog = "$('#{LayerId}').dialog({ autoOpen: false, width: 800, minWidth: 810 });";
            tmpScriptLoop.AppendLine(strDialog.Replace("{LayerId}", LayerId));

            //Js函数,工具条事件

            string KeyCode = D_List.Where(o => o.D_IsKey == 1).FirstOrDefault().D_Index.Trim();

            #region Js函数
            string jsFunction = @" 

            function {preFix}Btn1() {
                var grid = $('#{GridID}');
                var curid = grid.getGridParam('selrow'); //获取选择行的id
                var data = grid.getRowData(curid); //获取行号为curid的数据            
                if (data.{KeyCode} == undefined) {
                    ShowMsg('请选中编辑行');
                    return;
                }
                {preFix}_GridControl.InitEditExtends(data.{KeyCode},'btn1');            
            }
            function {preFix}Btn2() {            
                var grid = $('#{GridID}');
                var curid = grid.getGridParam('selrow'); //获取选择行的id
                var data = grid.getRowData(curid); //获取行号为curid的数据            
                if (data.{KeyCode} == undefined) {
                    ShowMsg('请选中编辑行');
                    return;
                }
                {preFix}_GridControl.InitEditExtends(data.{KeyCode},'btn2');            
            }
            function {preFix}Btn3() {
                 var grid = $('#{GridID}');
                var curid = grid.getGridParam('selrow'); //获取选择行的id
                var data = grid.getRowData(curid); //获取行号为curid的数据            
                if (data.{KeyCode} == undefined) {
                    ShowMsg('请选中编辑行');
                    return;
                }
                {preFix}_GridControl.InitEditExtends(data.{KeyCode},'btn3');
            }
            function {preFix}Btn4() {
                 var grid = $('#{GridID}');
                var curid = grid.getGridParam('selrow'); //获取选择行的id
                var data = grid.getRowData(curid); //获取行号为curid的数据            
                if (data.{KeyCode} == undefined) {
                    ShowMsg('请选中编辑行');
                    return;
                }
                {preFix}_GridControl.InitEditExtends(data.{KeyCode},'btn4');
            }
          ";

            //生成验证JS
            string ValidationJs_template = @"
                 
                    var validator = $('#{FormID}').validate({
                        debug: false,       //调试模式取消submit的默认提交功能
                        errorClass: 'err_display', //默认为错误的样式类为：error
                        focusInvalid: false,
                        onkeyup: false,
                        rules: {           //定义验证规则,其中属性名为表单的name属性
                            {D_EditRules}
                        },
                        messages: {       //自定义验证消息
                            {D_EditMessage}
                        },
                        errorPlacement: function(error, element) {  //验证消息放置的地方
                            //error.appendTo(element.next().addClass('err_display'));
                            
                            if(error.html()!=''){
                                //ShowMsg(error.html());
                                element.next().addClass('err_display');                            
                                element.next().find('span').html(error.html());
                            }else{
                                element.next().find('span').html(error.html());
                                element.next().removeClass('err_display');
                            }                            
                        },
                        highlight: function(element, errorClass) {  //针对验证的表单设置高亮
                            //$(element).addClass(errorClass);
                        },
                        success: function(label) {
                            //label.addClass('valid').text('Ok!');
                        }     
            });
  
            ";
            #endregion

            //生成验证JS
            string ValidationJs = ValidationJs_template.Replace("{D_EditRules}", tmpValidatinRules.ToString().Trim().TrimEnd(','))
                                                       .Replace("{D_EditMessage}", tmpValidationMsg.ToString().Trim().TrimEnd(','))
                                                       .Replace("{FormID}", FormId);

            editHtml = editHtml.Replace("{StrLoop}", tmpStrLoop.ToString())
                .Replace("{CallJs}", tmpScriptLoop.ToString())
                .Replace("{tmpScriptLoadAdd}", tmpScriptLoadAdd.ToString())
                .Replace("{tmpScriptLoadAll}", tmpScriptLoadAll.ToString())
                .Replace("{HiddenField}", tmpHiddenLoop.ToString())
                .Replace("{preFix}", M_Model.M_NameSpace.Trim() + "_" + M_Model.M_ModuleCode.Trim())
                .Replace("{LayerID}", LayerId)
                .Replace("{FormID}", FormId)
                .Replace("{EditURL}", M_Model.M_EditUrl.Trim())
                .Replace("{JsFunction}",
                           jsFunction.Replace("{preFix}", M_Model.M_NameSpace.Trim() + "_" + M_Model.M_ModuleCode.Trim())
                           .Replace("{GridID}", M_Model.M_NameSpace.Trim() + "grid")
                           .Replace("{KeyCode}", KeyCode)
                        )
                .Replace("{ValidationJs}", ValidationJs)
                .Replace("{'}", "\"");

            return editHtml;
        }
        #endregion

        #region 生成表单

        /// <summary>
        /// 生成表单
        /// </summary>
        /// <param name="helper"></param>
        /// <param name="ModuleName">模块名称</param>
        /// <param name="NameSpace">命名空间</param>
        /// <param name="IsOpenLayer">是否为弹出层模式</param>
        /// <param name="AllowForm">是否生成表单</param>
        /// <param name="AllowFormButton">是否生成表单按钮</param>
        /// <returns></returns>
        public static string AutoBindForm(this HtmlHelper helper,
            string ModuleName, string NameSpace, bool IsOpenLayer,
            bool AllowForm, bool AllowFormButton)
        {

            //读出所有的字段信息
            List<Sys_Config_Fieled> D_List = new List<Sys_Config_Fieled>();
            Sys_Config_ListPage M_Model = new Sys_Config_ListPage();
            ADOSys_Config_Fieled FieledInstance = new ADOSys_Config_Fieled();
            ADOSys_Config_ListPage ListInstance = new ADOSys_Config_ListPage();

            D_List = FieledInstance.GetListByWhere(" AND D_ModuleCode='" + ModuleName + "' AND D_NameSpace='" + NameSpace + "'");
            List<Sys_Config_ListPage> _ListPage =
                ListInstance.GetListByWhere(" AND M_ModuleCode='" + ModuleName + "'");
            if (_ListPage.Count > 0)
            {
                M_Model = _ListPage[0];
            }
            string result = AutoBindForm(M_Model, D_List, IsOpenLayer, AllowFormButton, AllowForm, "");
            if (!string.IsNullOrEmpty(M_Model.M_ExtendsJs))
            {
                result += JqGridExtendsJs(helper, M_Model.M_ExtendsJs, M_Model.M_ExtendsControl);
            }
            return result;
        }

        /// <summary>
        /// 生成表单  0206
        /// </summary>
        /// <param name="helper"></param>
        /// <param name="ModuleName">模块名称</param>
        /// <param name="NameSpace">命名空间</param>
        /// <param name="IsOpenLayer">是否为弹出层模式</param>
        /// <param name="AllowForm">是否生成表单</param>
        /// <param name="AllowFormButton">是否生成表单按钮</param>
        /// <param name="location">对齐位置</param>
        /// <returns></returns>
        public static string AutoBindForm(this HtmlHelper helper,
           string ModuleName, string NameSpace, bool IsOpenLayer,
           bool AllowForm, bool AllowFormButton, string location)
        {

            //读出所有的字段信息
            List<Sys_Config_Fieled> D_List = new List<Sys_Config_Fieled>();
            Sys_Config_ListPage M_Model = new Sys_Config_ListPage();
            ADOSys_Config_Fieled FieledInstance = new ADOSys_Config_Fieled();
            ADOSys_Config_ListPage ListInstance = new ADOSys_Config_ListPage();

            D_List = FieledInstance.GetListByWhere(" AND D_ModuleCode='" + ModuleName + "' AND D_NameSpace='" + NameSpace + "'");
            List<Sys_Config_ListPage> _ListPage =
                ListInstance.GetListByWhere(" AND M_ModuleCode='" + ModuleName + "'");
            if (_ListPage.Count > 0)
            {
                M_Model = _ListPage[0];
            }
            string result = AutoBindForm(M_Model, D_List, IsOpenLayer, AllowFormButton, AllowForm, location);
            if (!string.IsNullOrEmpty(M_Model.M_ExtendsJs))
            {
                result += JqGridExtendsJs(helper, M_Model.M_ExtendsJs, M_Model.M_ExtendsControl);
            }
            return result;
        }

        #endregion

        #region 绑定表单值

        /// <summary>
        /// 绑定表单值
        /// </summary>
        /// <param name="helper"></param>
        /// <param name="ModuleName"></param>
        /// <param name="NameSpace"></param>
        /// <param name="obj"></param>
        /// <param name="IsOpenLayer"></param>
        /// <param name="AllowForm"></param>
        /// <param name="AllowFormButton"></param>
        /// <returns></returns>
        public static string AutoBindForm<T>(this HtmlHelper helper,
            string ModuleName, string NameSpace, T obj, bool IsOpenLayer,
            bool AllowForm, bool AllowFormButton) where T : new()
        {

            //读出所有的字段信息
            List<Sys_Config_Fieled> D_List = new List<Sys_Config_Fieled>();
            Sys_Config_ListPage M_Model = new Sys_Config_ListPage();
            ADOSys_Config_Fieled FieledInstance = new ADOSys_Config_Fieled();
            ADOSys_Config_ListPage ListInstance = new ADOSys_Config_ListPage();

            D_List = FieledInstance.GetListByWhere(" AND D_ModuleCode='" + ModuleName + "' AND D_NameSpace='" + NameSpace + "'");
            List<Sys_Config_ListPage> _ListPage =
                ListInstance.GetListByWhere(" AND M_ModuleCode='" + ModuleName + "'");
            if (_ListPage.Count > 0)
            {
                M_Model = _ListPage[0];
            }
            string result = AutoBindForm(M_Model, D_List, obj, IsOpenLayer, AllowFormButton, AllowForm, "");
            if (!string.IsNullOrEmpty(M_Model.M_ExtendsJs))
            {
                result += JqGridExtendsJs(helper, M_Model.M_ExtendsJs, M_Model.M_ExtendsControl);
            }
            return result;
        }
        #endregion

        #region 解析默认值
        /// <summary>
        /// 默认值解析
        /// </summary>
        /// <param name="template"></param>
        /// <returns></returns>
        public static string ParseDefaultValue(string template)
        {
            string value = "";
            if (!string.IsNullOrEmpty(template))
            {
                string temp = template.ToLower();
                if (temp.Contains("date"))
                {
                    value = DateTime.Now.ToString("yyyy-MM-dd");
                }
                if (temp.Contains("datetime"))
                {
                    value = DateTime.Now.ToString("yyyy-MM-dd H:m:s");
                }
                if (temp.Contains("session"))
                {
                    string[] str = temp.Split(':');
                    if (str.Length > 0)
                    {
                        value = SessionConfig.GetSession(str[1]) != null ? SessionConfig.GetSession(str[1]).ToString() : "";
                    }
                }
                if (temp.Contains("date") && temp.Contains("+"))
                {
                    string[] str = temp.Split('+');
                    if (str.Length > 0)
                    {
                        value = DateTime.Now.AddDays(Double.Parse(str[1])).ToString("yyyy-MM-dd");
                    }
                }
                if (temp.Contains("date") && temp.Contains("-"))
                {
                    string[] str = temp.Split('-');
                    if (str.Length > 0)
                    {
                        TimeSpan span = new TimeSpan(int.Parse(str[1]), 0, 0, 0);
                        value = DateTime.Now.Subtract(span).ToString("yyyy-MM-dd");
                    }
                }
                else
                {
                    if (string.IsNullOrEmpty(value))
                    {
                        value = template;
                    }
                }
            }
            return value;
        }
        #endregion

        #region 新的封装方法

        /// <summary>
        /// 系统通用GRID生成
        /// </summary>
        /// <param name="helper"></param>
        /// <param name="ModuleName">模块名称</param>
        /// <param name="CustNameSpace">自定义命名空间</param>
        /// <param name="GetDataURL">获取数据URL</param>
        /// <param name="EditURL">编辑数据URL</param>
        /// <param name="ToolBarConfig">工具条配置</param>
        /// <param name="itype">内置类型</param>
        /// <param name="type">普通类型</param>
        /// <param name="IsInit">是否初始化</param>
        /// <returns></returns>
        public static string SysComm_JqGrid(this HtmlHelper helper, string ModuleName, string CustNameSpace,
            string GetDataURL,
            bool IsInit
            )
        {
            string html = "";
            Sys_Config_ListPage M_Model = new Sys_Config_ListPage();
            List<Sys_Config_Fieled> D_List = new List<Sys_Config_Fieled>();
            GetListConfig(ModuleName, out M_Model, out D_List);
            if (!string.IsNullOrEmpty(GetDataURL))
            {
                M_Model.M_URL = GetDataURL;
            }

            html += helper.JqGrid(ModuleName, CustNameSpace, M_Model, D_List, IsInit);

            if (M_Model.M_FormEditing == "true")
            {
                //第五步：绑定编辑层
                html += AutoBindForm(M_Model, D_List, true, true, true, "center");

                html += AutoBindValidate(D_List, M_Model.M_NameSpace + "_Form");
            }

            if (M_Model.M_FormMethod == "true")
            {
                html += FormOperForList(M_Model, D_List);
            }

            return html;
        }

        /// <summary>
        /// 通用单据物料选择Grid
        /// </summary>
        /// <param name="hepler"></param>
        /// <param name="IType"></param>
        /// <returns></returns>
        //public static string Sys_Materail(this HtmlHelper hepler,string IType)
        //        {
        //            string html = "";
        //            ADOSys_Rec_RefDepend instance=new ADOSys_Rec_RefDepend();
        //            Sys_Rec_RefDepend model = new Sys_Rec_RefDepend();
        //            List<Sys_Rec_RefDepend> list = instance.GetListByWhere(" AND RefDepend_Code=RefDepend_Object AND RefDepend_Code='" + IType + "'");
        //            if (list.Count>0)
        //            {
        //                model = list[0];
        //                Sys_Config_ListPage M_Model = new Sys_Config_ListPage();
        //                List<Sys_Config_Fieled> D_List = new List<Sys_Config_Fieled>();
        //                GetListConfig(model.RefDepend_UDEF11, out M_Model, out D_List);
        //                if (M_Model==null || D_List==null)
        //                {
        //                    return "";                    
        //                }
        //                string js_header = @"<script type='text/javascript'>";
        //                string js_footer = @"</script>";
        //                string jsBody = @"            
        //                var Common_Material_ListBody = {
        //                    setupGrid: function(grid, pager, search) {   
        //                        $(grid).jqGrid({
        //                            url: '/Material/MaterialList',
        //                            mtype: '{M_MType}',
        //                            rowNum: {M_RowNum},
        //                            rowList: {M_RowList},
        //                            pager: pager,
        //                            sortorder: 'asc',
        //                            viewrecords: true,
        //                            multiselect: false, //多选时出现checkbox                           
        //                            rownumbers: true,
        //                            gridview: true,
        //                            hiddengrid:{M_GridState},
        //                            caption: '{M_Title}',
        //                            footerrow: {M_FooterRow},
        //                            editurl: '{M_EditUrl}',
        //                            edit: {M_Edit} ,                                                
        //                            onSelectRow: function(id) {
        //                                
        //                            },
        //                            ondblClickRow: function(rowid, iRow, iCol, e) {
        //                                var s = iRow;
        //                                var ret = $(grid).jqGrid('getRowData', s);
        //                                if (Common_Material_List.CallBack != null) {
        //                                    Common_Material_List.CallBack(ret.MD_MCode, ret.MD_Name, ret.MD_Spec, ret.MD_Unit,ret.MD_PriceList,ret);
        //                                }
        //                            },
        //                            colNames: [{M_ColNames_list}],
        //                            colModel: [{M_ColModel_List}],
        //                            gridComplete: function() {
        //                               {M_GridComplete}
        //                            },
        //                            userDataOnFooter: true
        //                        })   
        //                    }}
        //                    ";

        //                //一般配置
        //                jsBody = jsBody.Replace("{M_NameSpace}", M_Model.M_NameSpace.Trim());
        //                jsBody = jsBody.Replace("{M_ModuleCode}", M_Model.M_ModuleCode.Trim());
        //                jsBody = jsBody.Replace("{M_MType}", M_Model.M_MType.Trim());
        //                jsBody = jsBody.Replace("{M_RowNum}", M_Model.M_RowNum);
        //                jsBody = jsBody.Replace("{M_RowList}", M_Model.M_RowList);
        //                jsBody = jsBody.Replace("{M_Width}", M_Model.M_Width.Trim());
        //                jsBody = jsBody.Replace("{M_Height}", M_Model.M_Height.Trim());
        //                jsBody = jsBody.Replace("{M_AutoWidth}", M_Model.M_AutoWidth.Trim());
        //                jsBody = jsBody.Replace("{M_Title}", M_Model.M_Title);
        //                jsBody = jsBody.Replace("{M_FooterRow}", M_Model.M_FooterRow.Trim());
        //                jsBody = jsBody.Replace("{M_EditUrl}", M_Model.M_EditUrl);//如果为SQL，则地址改为系统地址
        //                jsBody = jsBody.Replace("{M_Edit}", M_Model.M_Edit);
        //                jsBody = jsBody.Replace("{M_OnSelectRow}", M_Model.M_OnSelectRow);
        //                jsBody = jsBody.Replace("{M_GridComplete}", M_Model.M_GridComplete);
        //                jsBody = jsBody.Replace("{LayerID}", M_Model.M_NameSpace.Trim() + "_Oper");
        //                jsBody = jsBody.Replace("{FormID}", M_Model.M_NameSpace.Trim() + "_Form");               
        //                jsBody = jsBody.Replace("{M_GridState}", !string.IsNullOrEmpty(M_Model.M_Gridstate) && M_Model.M_Gridstate == "true" ? "false" : "true");

        //                //动态配置
        //                #region 生成列头
        //                string strColNames = string.Empty;
        //                D_List = D_List.OrderBy(o => o.D_ShowOrder).ToList();
        //                for (int i = 0; i < D_List.Count; i++)
        //                {
        //                    if (i != (D_List.Count - 1))
        //                    {
        //                        strColNames += "'" + D_List[i].D_Name.Trim() + "'" + ",";
        //                    }
        //                    else
        //                    {
        //                        strColNames += "'" + D_List[i].D_Name.Trim() + "'";
        //                    }
        //                }
        //                #endregion
        //                string KeyCode = D_List.Where(o => o.D_IsKey == 1).Count() > 0 ? D_List.Where(o => o.D_IsKey == 1).FirstOrDefault().D_Index.Trim() : "nokey";

        //                jsBody = jsBody.Replace("{M_ColNames_list}", strColNames);
        //                jsBody = jsBody.Replace("{KeyCode}", KeyCode);


        //                #region 生成列详细配置

        //                StringBuilder header = new StringBuilder();
        //                string header_template = @"{ name: '{D_Index}', index: '{D_Index}', width: {D_Width}, align: '{D_Align}', sortable: {D_Sortable}, hidden: {D_Hidden},searchoptions:{ {D_Searchoptions} } }";
        //                string header_template_fix = ",";
        //                //D_List = D_List.OrderBy(o => o.D_ShowOrder).ToList();
        //                for (var m = 0; m < D_List.Count; m++)
        //                {
        //                    string tmpFix = m != (D_List.Count - 1) ? header_template_fix : "";
        //                    header.AppendLine(header_template.Replace("{D_Name}", !string.IsNullOrEmpty(D_List[m].D_Name) ? D_List[m].D_Name : "")
        //                        .Replace("{D_Index}", !string.IsNullOrEmpty(D_List[m].D_Index) ? D_List[m].D_Index.Trim() : "")
        //                        .Replace("{D_Width}", !string.IsNullOrEmpty(D_List[m].D_Width) ? D_List[m].D_Width : "100")
        //                        .Replace("{D_Align}", !string.IsNullOrEmpty(D_List[m].D_Align) ? D_List[m].D_Align.Trim() : "center")
        //                        .Replace("{D_Sortable}", !string.IsNullOrEmpty(D_List[m].D_Sortable) ? D_List[m].D_Sortable.Trim() : "false")
        //                        .Replace("{D_Hidden}", !string.IsNullOrEmpty(D_List[m].D_Hidden) ? D_List[m].D_Hidden.Trim() : "false")
        //                        .Replace("{D_Searchoptions}", !string.IsNullOrEmpty(D_List[m].D_Searchoptions) ? D_List[m].D_Searchoptions : "")
        //                        + tmpFix);
        //                }
        //                #endregion

        //                jsBody = jsBody.Replace("{M_ColModel_List}", header.ToString());

        //                html = js_header + jsBody + js_footer;
        //            }
        //            return html;
        //        }

        /// <summary>
        /// 通用单据参考选择Grid
        /// </summary>
        /// <param name="hepler"></param>
        /// <param name="IType">参考单据类型</param>
        /// <returns></returns>
        //        public static string Sys_PUIORef(this HtmlHelper hepler, string IType)
        //        {
        //            string html = "";
        //            ADOSys_Rec_RefDepend instance = new ADOSys_Rec_RefDepend();
        //            Sys_Rec_RefDepend model = new Sys_Rec_RefDepend();
        //            List<Sys_Rec_RefDepend> list = instance.GetListByWhere(" AND RefDepend_Code=RefDepend_Object AND RefDepend_Code='" + IType + "'");
        //            if (list.Count > 0)
        //            {
        //                model = list[0];
        //                Sys_Config_ListPage M_Model = new Sys_Config_ListPage();
        //                List<Sys_Config_Fieled> D_List = new List<Sys_Config_Fieled>();
        //                GetListConfig(model.RefDepend_UDEF17, out M_Model, out D_List);
        //                if (M_Model == null || D_List == null)
        //                {
        //                    return "";
        //                }
        //                string js_header = @"<script type='text/javascript'>";
        //                string js_footer = @"</script>";
        //                string jsBody = @"            
        //                var Common_RefPUIO = {   
        //                      setupGrid:function(grid, pager, search){
        //                          $(grid).jqGrid({
        //                            url: '/nStock/RefPUMainList/',
        //                            mtype: '{M_MType}',
        //                            rowNum: {M_RowNum},
        //                            rowList: {M_RowList},
        //                            pager: pager,
        //                            sortorder: 'asc',
        //                            viewrecords: true,
        //                            multiselect: false, //多选时出现checkbox                           
        //                            rownumbers: true,
        //                            gridview: true,
        //                            hiddengrid:{M_GridState},
        //                            caption: '{M_Title}',
        //                            footerrow: {M_FooterRow},
        //                            editurl: '{M_EditUrl}',
        //                            edit: {M_Edit} ,                                                
        //                            onSelectRow: function(id) {
        //                                
        //                            },
        //                            ondblClickRow: function(rowid, iRow, iCol, e) {
        //                                var s = iRow;
        //                                var ret = $(grid).jqGrid('getRowData', s);
        //                                Common_RefPU.btnConfirm.trigger('click');
        //                            },
        //                            colNames: [{M_ColNames_list}],
        //                            colModel: [{M_ColModel_List}],
        //                            gridComplete: function() {
        //                               {M_GridComplete}
        //                            },
        //                            userDataOnFooter: true
        //                        });   
        //                    }}
        //                    ";

        //                //一般配置
        //                jsBody = jsBody.Replace("{M_NameSpace}", M_Model.M_NameSpace.Trim());
        //                jsBody = jsBody.Replace("{M_ModuleCode}", M_Model.M_ModuleCode.Trim());
        //                jsBody = jsBody.Replace("{M_MType}", M_Model.M_MType.Trim());
        //                jsBody = jsBody.Replace("{M_RowNum}", M_Model.M_RowNum);
        //                jsBody = jsBody.Replace("{M_RowList}", M_Model.M_RowList);
        //                jsBody = jsBody.Replace("{M_Width}", M_Model.M_Width.Trim());
        //                jsBody = jsBody.Replace("{M_Height}", M_Model.M_Height.Trim());
        //                jsBody = jsBody.Replace("{M_AutoWidth}", M_Model.M_AutoWidth.Trim());
        //                jsBody = jsBody.Replace("{M_Title}", M_Model.M_Title);
        //                jsBody = jsBody.Replace("{M_FooterRow}", M_Model.M_FooterRow.Trim());
        //                jsBody = jsBody.Replace("{M_EditUrl}", M_Model.M_EditUrl);//如果为SQL，则地址改为系统地址
        //                jsBody = jsBody.Replace("{M_Edit}", M_Model.M_Edit);
        //                jsBody = jsBody.Replace("{M_OnSelectRow}", M_Model.M_OnSelectRow);
        //                jsBody = jsBody.Replace("{M_GridComplete}", M_Model.M_GridComplete);
        //                jsBody = jsBody.Replace("{LayerID}", M_Model.M_NameSpace.Trim() + "_Oper");
        //                jsBody = jsBody.Replace("{FormID}", M_Model.M_NameSpace.Trim() + "_Form");
        //                jsBody = jsBody.Replace("{M_GridState}", !string.IsNullOrEmpty(M_Model.M_Gridstate) && M_Model.M_Gridstate == "true" ? "false" : "true");

        //                //动态配置
        //                #region 生成列头
        //                string strColNames = string.Empty;
        //                D_List = D_List.OrderBy(o => o.D_ShowOrder).ToList();
        //                for (int i = 0; i < D_List.Count; i++)
        //                {
        //                    if (i != (D_List.Count - 1))
        //                    {
        //                        strColNames += "'" + D_List[i].D_Name.Trim() + "'" + ",";
        //                    }
        //                    else
        //                    {
        //                        strColNames += "'" + D_List[i].D_Name.Trim() + "'";
        //                    }
        //                }
        //                #endregion
        //                string KeyCode = D_List.Where(o => o.D_IsKey == 1).Count() > 0 ? D_List.Where(o => o.D_IsKey == 1).FirstOrDefault().D_Index.Trim() : "nokey";

        //                jsBody = jsBody.Replace("{M_ColNames_list}", strColNames);
        //                jsBody = jsBody.Replace("{KeyCode}", KeyCode);


        //                #region 生成列详细配置

        //                StringBuilder header = new StringBuilder();
        //                string header_template = @"{ name: '{D_Index}', index: '{D_Index}', width: {D_Width}, align: '{D_Align}', sortable: {D_Sortable}, hidden: {D_Hidden},searchoptions:{ {D_Searchoptions} } }";
        //                string header_template_fix = ",";
        //                //D_List = D_List.OrderBy(o => o.D_ShowOrder).ToList();
        //                for (var m = 0; m < D_List.Count; m++)
        //                {
        //                    string tmpFix = m != (D_List.Count - 1) ? header_template_fix : "";
        //                    header.AppendLine(header_template.Replace("{D_Name}", !string.IsNullOrEmpty(D_List[m].D_Name) ? D_List[m].D_Name : "")
        //                        .Replace("{D_Index}", !string.IsNullOrEmpty(D_List[m].D_Index) ? D_List[m].D_Index.Trim() : "")
        //                        .Replace("{D_Width}", !string.IsNullOrEmpty(D_List[m].D_Width) ? D_List[m].D_Width : "100")
        //                        .Replace("{D_Align}", !string.IsNullOrEmpty(D_List[m].D_Align) ? D_List[m].D_Align.Trim() : "center")
        //                        .Replace("{D_Sortable}", !string.IsNullOrEmpty(D_List[m].D_Sortable) ? D_List[m].D_Sortable.Trim() : "false")
        //                        .Replace("{D_Hidden}", !string.IsNullOrEmpty(D_List[m].D_Hidden) ? D_List[m].D_Hidden.Trim() : "false")
        //                        .Replace("{D_Searchoptions}", !string.IsNullOrEmpty(D_List[m].D_Searchoptions) ? D_List[m].D_Searchoptions : "")
        //                        + tmpFix);
        //                }
        //                #endregion

        //                jsBody = jsBody.Replace("{M_ColModel_List}", header.ToString());

        //                html = js_header + jsBody + js_footer;
        //            }
        //            return html;
        //        }

        //private static string SysComm_JqGridForAttachCompent(this HtmlHelper helper, string ModuleName, string CustNameSpace,
        //    string GetDataURL, string EditURL,
        //    string ToolBarConfig,
        //    string itype, string type,
        //    bool IsInit
        //    )
        //{
        //    string html = "";
        //    Sys_Config_ListPage M_Model = new Sys_Config_ListPage();
        //    List<Sys_Config_Fieled> D_List = new List<Sys_Config_Fieled>();
        //    GetListConfig(ModuleName, out M_Model, out D_List);
        //    if (!string.IsNullOrEmpty(GetDataURL))
        //    {
        //        M_Model.M_URL = GetDataURL;
        //    }
        //    if (!string.IsNullOrEmpty(EditURL))
        //    {
        //        M_Model.M_EditUrl = EditURL;
        //    }

        //    html += helper.JqGrid(ModuleName, CustNameSpace, M_Model, D_List, itype, type, "", IsInit);

        //    return html;
        //}



        #endregion

        #region 获取配置信息
        /// <summary>
        /// 获取所有的字段
        /// </summary>
        /// <param name="moduleName"></param>
        /// <param name="M_Model"></param>
        /// <param name="D_List"></param>
        /// <returns></returns>
        private static Sys_Config_ListPage GetListConfig(string moduleName, out Sys_Config_ListPage M_Model, out List<Sys_Config_Fieled> D_List)
        {
            ADOSys_Config_ListPage ListInstance = new ADOSys_Config_ListPage();
            ADOSys_Config_Fieled FieledInstance = new ADOSys_Config_Fieled();
            M_Model = null;
            D_List = null;
            try
            {
                if (!string.IsNullOrEmpty(moduleName))
                {
                    //第一步：根据传入模块获取Grid配置
                    List<Sys_Config_ListPage> _ListPage = ListInstance.GetListByWhere(" AND M_ModuleCode='" +
                    moduleName + "'");
                    if (_ListPage.Count > 0)
                    {
                        M_Model = _ListPage[0];
                    }
                    //第二步：根据模块获取所有字段
                    D_List = FieledInstance.GetListByWhere(" AND D_ModuleCode='" + moduleName + "'");
                }
                else
                {
                    M_Model = null;
                    D_List = null;
                }
            }
            catch (System.Exception ex)
            {
                M_Model = null;
                D_List = null;
            }

            return M_Model;
        }

        #endregion


    }
}
