using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;

using QX.Comm;
using QX.Model;
using QX.DAL;
using Newtonsoft.Json;
using QX.Config;
using System.Collections;
using System.Web;

using System.Data;

namespace QX.HtmlHelperLib
{
    public static class ChartHelper
    {
        public static string ChartToolBar(this HtmlHelper hepler,string Module)
        {
            string strOutput = "";
            //Bll_ChartToolBar instance=new Bll_ChartToolBar();
            //Bll_Bse_Dict dictInstance = new Bll_Bse_Dict();
            ADOChartToolBar instance = new ADOChartToolBar();
            ADOBse_Dict dictInstance = new ADOBse_Dict();
            StringBuilder strList = new StringBuilder();
            StringBuilder strJsList = new StringBuilder();
            List<ChartToolBar> list = instance.GetListByWhere(" AND CT_Module='"+Module+"' ").OrderBy(o=>o.CT_Order).ToList();

            //form_textbox  TextBoxReadOnly  popup date
            string Bar_Begin = @"<div id='" + Module + "' class='toolbar_chart'> <ul>";
            string Bar_End = @"</ul>
                                    <div style='clear:both'></div> 
                               </div>";
            string Li_Hidden = @"<input type='hidden' name='{CT_Field}' id='{CT_Field}' value='{CT_Default}'>";
            string Li_Input = @"<input type='text' {CT_Attr}  name='{CT_Field}' id='{CT_Field}' value='{CT_Default}'>";
            string Li_Template= @"<li style='float: left'><span>{CT_Name}:</span> {Element} </li>";
            string Li_ButtonDiv = @"<li class='toolbar_btn' style='float: left'>{Element} </li>";
            string Li_Select = @"<select name='{CT_Field}' id='{CT_Field}'>{Option}</select>";
            string Li_Button = @"<a href='#' {CT_Attr} id='{CT_Field}'>{CT_Name}</a>";
            string Document_Js = @" <script> $(function(){ {JsBody}  }); </script> ";
            string defaultStyle = "form_textbox_toolbar  TextBoxReadOnly ";
            string DateStyle="date_icon";

            if (list.Count>0)
            {
               
#region 显示值

                foreach (var item in list.Where(o=>string.IsNullOrEmpty(o.CT_Show) || o.CT_Show=="true"))
                {
                    try
                    {
                        string streElement = "";
                        string strLi = "";
                        string ClickJs = "";
                        item.CT_Default = JqGridSys_Config_ListPage.ParseDefaultValue(item.CT_Default);
                        switch (item.CT_Type)
                        {
                            case "text":

                                streElement = Li_Input.Replace("{CT_Attr}", item.CT_Attr)
                                                   .Replace("{CT_Field}", item.CT_Field)
                                                   .Replace("{CT_Default}",item.CT_Default);

                                strLi = Li_Template.Replace("{CT_Name}", item.CT_Name)
                                                       .Replace("{Element}", streElement);

                                strList.AppendLine(strLi);

                                break;
                            case "button":

                                streElement = Li_Button.Replace("{CT_Attr}", item.CT_Attr)
                                                    .Replace("{CT_Field}", item.CT_Field)
                                                    .Replace("{CT_Name}", item.CT_Name);

                                strLi = Li_ButtonDiv.Replace("{Element}", streElement);

                                strList.AppendLine(strLi);

                                break;

                            case "dict":
                                var strOption = new StringBuilder();
                                if (!string.IsNullOrEmpty(item.CT_DictKey))
                                {                                    
                                    var dictList = dictInstance.GetListByWhere(" AND Dict_Key='" + item.CT_DictKey + "' AND Dict_Key!=Dict_Code").OrderBy(o=>o.Dict_Order).ToList();
                                    if (dictList.Count>0)
                                    {                                        
                                        foreach ( var dictItem in dictList)
                                        {
                                            strOption.AppendLine("<option Value='" + dictItem.Dict_Code + "'>" + dictItem.Dict_Name + "</option>");
                                        }
                                    }
                                }
                                var NewList = Li_Select.Replace("{Option}", strOption.ToString())
                                                     .Replace("{CT_Field}", item.CT_Field)
                                                     .Replace("{CT_Name}", item.CT_Name);

                                streElement = Li_Template.Replace("{CT_Name}", item.CT_Name)
                                                       .Replace("{Element}", NewList);

                                strList.AppendLine(streElement);
                                break;

                            case "date":

                                streElement = Li_Input.Replace("{CT_Attr}", "class='"+defaultStyle+DateStyle+"'" + item.CT_Attr)
                                                   .Replace("{CT_Field}", item.CT_Field)
                                                   .Replace("{CT_Default}", item.CT_Default);

                                strLi = Li_Template.Replace("{CT_Name}", item.CT_Name)
                                                       .Replace("{Element}", streElement);

                                strList.AppendLine(strLi);

                                ClickJs = @" $('#" + Module + "').find('#" + item.CT_Field + "').bind('click',function(){ WdatePicker(); });  ";
                                strJsList.AppendLine(ClickJs);
                                
                                break;

                            case "datetime":

                                streElement = Li_Input.Replace("{CT_Attr}", "class='" + defaultStyle + DateStyle + "'" + item.CT_Attr)
                                                   .Replace("{CT_Field}", item.CT_Field)
                                                   .Replace("{CT_Default}", item.CT_Default);

                                strLi = Li_Template.Replace("{CT_Name}", item.CT_Name)
                                                       .Replace("{Element}", streElement);

                                strList.AppendLine(strLi);

                                ClickJs = @" $('#" + Module + "').find('#"+item.CT_Field+"').bind('click',function(){ WdatePicker({dateFmt:'yyyy-MM-dd HH:mm:ss'}); });  ";
                                strJsList.AppendLine(ClickJs);

                                break;
                            default:
                                break;
                        }

                        //加载JS
                        if (!string.IsNullOrEmpty(item.CT_JS))
                        {
                            strJsList.AppendLine(item.CT_JS);
                        }
                    }
                    catch (System.Exception ex)
                    {
                        continue;
                    }
                }
#endregion

                string hidElement = string.Empty;

                foreach (var item in list.Where(o=>!string.IsNullOrEmpty(o.CT_Show) && o.CT_Show=="false"))
                {
                    hidElement = Li_Hidden.Replace("{CT_Field}", item.CT_Field)
                                                   .Replace("{CT_Default}", item.CT_Default);

                    strList.AppendLine(hidElement);

                }

                Document_Js = Document_Js.Replace("{JsBody}", strJsList.ToString());

            }
            else
            {
                Document_Js = Document_Js.Replace("{JsBody}", "");
            }

            return Bar_Begin+ strList +Bar_End + Document_Js;
        }

        
    }
}
