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
using QX.BLL;
using System.Data;

namespace QX.HtmlHelperLib
{
    public static class SysRole
    {
        static string bigClassHeader = "<div><ul>";
        static string bigClassFooter = "</ul></div>";
        static string bigClassBodyTemplate = "<li>{ShowElement}{SmallClass}</li>";
        static string bigClassBody = "";

        static string smallClassHeader = "<div></ul>";
        static string smallClassFooter = "</ul></div>";
        static string smallClassTemplate = "<li>{ShowElement}{SmallClass}</li>";
        static string smallClassBody = "";

        static string CheckTemplate = "{0}<input type=\"checkbox\" name=\"{1}\" id=\"{1}\" checked=\"{2}\"  />";
        
        /// <summary>
        /// 系统权限管理界面
        /// </summary>
        /// <param name="hepler">扩展Hepler</param>
        /// <param name="ds">权限源数据</param>
        /// <returns>返回权限管理组件</returns>
        public static string RoleManage(this HtmlHelper hepler,IList<Sys_Function> ds)
        {
            string html = "";           
            
            StringBuilder OutHtml = new StringBuilder();
            StringBuilder SmallClassBuilder = new StringBuilder();
            OutHtml.AppendLine(bigClassHeader);

            foreach (var item in ds)
            {
                if (string.IsNullOrEmpty(item.Fun_PCode))
                {
                    SmallClassBuilder.Remove(0, SmallClassBuilder.Length);
                    if (item.Childrens != null && item.Childrens.Count > 0)
                    {
                        CreateSmallClass(item.Childrens, ref SmallClassBuilder);
                    }
                    OutHtml.AppendLine(bigClassBodyTemplate
                        .Replace("{ShowElement}",string.Format(CheckTemplate, item.Fun_Name, item.Fun_Code, item.PU_IsCheck))
                        .Replace("{SmallClass}" ,SmallClassBuilder.ToString())
                       );
                }                
            }
            OutHtml.AppendLine(bigClassFooter);
            return OutHtml.ToString();
        }

        private static StringBuilder CreateSmallClass(IList<Sys_Function> smallDs, ref StringBuilder OutHtml)
        {
            OutHtml.AppendLine(smallClassHeader);
            foreach (var item in smallDs)
            {
                OutHtml.AppendLine(bigClassBodyTemplate.Replace("{ShowElement}",
                        string.Format(CheckTemplate, item.Fun_Name, item.Fun_Code, item.PU_IsCheck)));
                if (item.Childrens!=null && item.Childrens.Count>0)
                {
                    CreateSmallClass(item.Childrens, ref OutHtml);
                }
            }
            OutHtml.AppendLine(smallClassFooter);
            return OutHtml;
        }

        /// <summary>
        /// 系统权限控制
        /// </summary>
        /// <param name="Module">模块编码</param>
        /// <returns>页面权限控制JavaScript</returns>
        public static string SysRoleIoc(this HtmlHelper hepler, string Module)
        {
            var IS_OPEN_PERMISSION = ConfigHelper.GetApp("IS_OPEN_PERMISSION");
            TagBuilder builder = new TagBuilder("script");            
            if (!string.IsNullOrEmpty(IS_OPEN_PERMISSION) && IS_OPEN_PERMISSION == "true")
            {
                string UserId = SessionConfig.UserId();

                builder.MergeAttribute("type", "text/javascript");
                List<Sys_UserPermission> list = BLL.Bll_Comm.UserNotPermisionnList(UserId).Where(o=>o.PU_FunPCode==null 
                    || (o.PU_FunPCode!=null && !o.PU_FunPCode.StartsWith("C"))).ToList();
                StringBuilder JSBuilder = new StringBuilder();
                foreach (var item in list)
                {
                    JSBuilder.AppendFormat(" $('#{0}').remove();", item.Fun_UDef1);
                }
                builder.InnerHtml = " $(function(){ " + JSBuilder.ToString() + "});";
            }
            return builder.ToString(TagRenderMode.Normal);
            //return "";
        }

    }
}
