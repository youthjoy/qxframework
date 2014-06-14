using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using System.ComponentModel;

using QX.Comm;
using QX.Model;
using QX.Config;
using QX.DAL;


namespace QX.HtmlHelperLib
{
    public static class MenuHelper
    {
        /// <summary>
        /// 绑定左侧菜单
        /// </summary>
        /// <param name="helper"></param>
        /// <param name="DataSource"></param>
        /// <returns></returns>
        public static string BindLeftMenu(this HtmlHelper helper, List<System_Menu> DataSource)
        {
            ADOComm commInstance = new ADOComm();
            //权限过滤
            var IS_OPEN_PERMISSION=ConfigHelper.GetApp("IS_OPEN_PERMISSION");
            if (!string.IsNullOrEmpty(IS_OPEN_PERMISSION) && IS_OPEN_PERMISSION == "true")
            {
                string[] array=commInstance.UserPermissionArray(SessionConfig.UserId());
                DataSource = DataSource.Where(o => array.Contains(o.Menu_Code)).ToList();
            }            

            StringBuilder sb = new StringBuilder();           
            if (DataSource!=null && DataSource.Count>0)
            {
               sb.Append(LeftMenuMax(helper,DataSource));
            }
            return sb.ToString();
        }

        public static string BindTopMenu(this HtmlHelper helper, List<System_Menu> DataSource)
        {
            ADOComm commInstance = new ADOComm();

            //权限过滤
            var IS_OPEN_PERMISSION = ConfigHelper.GetApp("IS_OPEN_PERMISSION");
            if (!string.IsNullOrEmpty(IS_OPEN_PERMISSION) && IS_OPEN_PERMISSION == "true")
            {
                string[] array=commInstance.UserPermissionArray(SessionConfig.UserId());
                DataSource = DataSource.Where(o => array.Contains(o.Menu_Code)).ToList();
            }  

            StringBuilder sb = new StringBuilder();
            if (DataSource != null && DataSource.Count > 0)
            {
                sb.Append(TopMenuMax(DataSource));
            }
            return sb.ToString();
        }

        #region 
        private static string TopMenuMax(List<System_Menu> data)
        {
            StringBuilder strSql=new StringBuilder();
            if (data!=null && data.Count>0)
            {
                for (int i = 0; i < data.Count; i++)
                {
                    strSql.Append("<td width=\"100\" height=\"26\" style=\"cursor:hand\" onMouseOver=\"this.style.backgroundImage='url(../Content/images/main_18.gif)';this.style.borderStyle='solid';this.style.borderWidth='1';borderColor='#adb9c2'; \" onmouseout=\"this.style.backgroundImage='url()';this.style.borderStyle='none'\"><table width=\"100%\" border=\"0\" cellpadding=\"0\" cellspacing=\"0\"> ");
                    strSql.Append("<tr> ");
                    strSql.AppendFormat("<td><div align=\"center\"><img src=\"../Content/images/{0}\" width=\"16\" height=\"16\" /></div></td> ",data[i].Menu_Icon);
                    strSql.AppendFormat("<td><div align=\"center\"><span class=\"STYLE2\"><a target=\"Main\" href=\"{0}\" class=\"v1\">{1}</a></span></div></td> ",data[i].Menu_Url,data[i].Menu_Title);
                    strSql.Append("</tr> ");
                    strSql.Append("</table></td> ");
                }                
            }
            return strSql.ToString();          
        }
        #endregion

        #region 左侧一级菜单生成
        private static string LeftMenuMax(this HtmlHelper helper, List<System_Menu> data)
        {
            StringBuilder strSql=new StringBuilder();
            List<System_Menu> _data = data.Where(o => o.Menu_PCode == "root").ToList();
            if (_data.Count > 0)
            {
                strSql.Append("<tr> ");
                strSql.Append("<td valign=\"top\"><table width=\"155\" border=\"0\" align=\"center\" cellpadding=\"0\" cellspacing=\"0\"> ");             
               

                for (int i = 0; i < _data.Count; i++)
                {
                    strSql.Append("<tr> ");
                    strSql.Append("<td><table width=\"100%\" border=\"0\" cellspacing=\"0\" cellpadding=\"0\"> ");
                    strSql.Append("  <tr> ");
                    strSql.AppendFormat("    <td height=\"23\" background=\"/Content/images/main_36.gif\" id=\"imgmenu{0}\" class=\"menu_title\" onMouseOver=\"this.className='menu_title2';\" onClick=\"showsubmenu('{1}')\" onMouseOut=\"this.className='menu_title';\" style=\"cursor:hand\"><table width=\"100%\" border=\"0\" cellspacing=\"0\" cellpadding=\"0\"> ", _data[i].Menu_Code.ToString(), _data[i].Menu_Code.ToString());
                    strSql.Append("      <tr> ");
                    strSql.AppendFormat("        <td width=\"18%\"> <div align=\"center\"><img src=\"../../Content/images/{0}\" width=\"16\" height=\"16\"></div></td> ",_data[i].Menu_Icon);
                    strSql.AppendFormat("        <td width=\"82%\" class=\"STYLE1\">{0}</td> ",_data[i].Menu_Title);
                    strSql.Append("      </tr> ");
                    strSql.Append("    </table></td> ");
                    strSql.Append("  </tr> ");

                    var MinList = data.Where(o => o.Menu_PCode == _data[i].Menu_Code);
                    if (MinList!=null && MinList.Count()>0)
                    {
                        strSql.Append(LeftMenuMin(helper, data, _data[i].Menu_Code.ToString()));
                    }
                }

                strSql.Append("</table></td> ");
                strSql.Append("</tr> ");
                strSql.Append("</table></td> ");
                strSql.Append("</tr>       ");
            }            
            return strSql.ToString();
        }
        #endregion

        #region  左侧菜单二级分类生成
        /// <summary>
        /// 二级分类生成
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        private static string LeftMenuMin(this HtmlHelper helper, List<System_Menu> data,string id)
        {
            StringBuilder strSql=new StringBuilder();
            strSql.Append("<tr> ");
            strSql.AppendFormat("<td style='display:none' id=\"submenu{0}\"> ", id);
            strSql.Append(" <div class=\"sec_menu\" >   ");
            strSql.Append("<table width=\"100%\" border=\"0\" cellspacing=\"0\" cellpadding=\"0\"> ");
            strSql.Append("  <tr> ");
            strSql.Append("<td>");

            string NewTree = helper.Dtree<System_Menu>("tree" + id, GetChildListMenu(data, id), o => o.ChildrenMenus,
                d => string.Format(" {0},{1},'{2}','{3}','','Main','/Content/images/{4}' ",
                    d.Menu_Code,
                    d.Menu_PCode==id?"-1":d.Menu_PCode
                    ,
                    d.Menu_Title,
                    d.Menu_Url,
                    d.Menu_Icon
                    ));

            strSql.Append(NewTree);

            strSql.Append("</td>");
            strSql.Append("  </tr> ");
            strSql.Append("  <tr> ");
            strSql.Append("    <td height=\"5\"><img src=\"../../Content/images/main_52.gif\" width=\"151\" height=\"5\" /></td> ");
            strSql.Append("  </tr> ");
            strSql.Append("</table></div></td> ");
            strSql.Append("</tr> ");
           
            return strSql.ToString();
        }

        /// <summary>
        /// 生成包含层级关系的子节点列表
        /// </summary>
        /// <returns></returns>
        public static IEnumerable<System_Menu> GetChildListMenu(List<System_Menu> dataSource, string PCode)
        {
            IEnumerable<System_Menu> root = dataSource.Where(o => o.Menu_PCode == PCode);
            foreach (var d in root)
            {
                GenerateChild(d, dataSource);
            }
            return root;
        }

        private static void GenerateChild(System_Menu Menu, List<System_Menu> allMenu)
        {
            var child=allMenu.Where(o => o.Menu_PCode == Menu.Menu_Code);
            if (child.Count()>0)
            {
                Menu.ChildrenMenus = child;
            }
            else
            {
                Menu.ChildrenMenus = null;
            }            

            if (Menu.ChildrenMenus == null)
            {
                return;
            }
            foreach (var d in Menu.ChildrenMenus)
            {
                GenerateChild(d, allMenu);
            }
        }

        #endregion
     
    }
}
