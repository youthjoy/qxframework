using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using QX.DAL;
using QX.Model;
namespace QX.BLL
{
   public class Bll_Menus
    {
       ADOSystem_Menu instance = new ADOSystem_Menu();
        public IEnumerable<System_Menu> GetChildListDept()
        {
            List<System_Menu> allMenus = instance.GetAll();
            IEnumerable<System_Menu> root = allMenus.Where(o => string.IsNullOrEmpty(o.Menu_PCode));
            foreach (var d in root)
            {
                GenerateChild(d, allMenus);
            }

            return root;
        }
        private void GenerateChild(System_Menu Menu, List<System_Menu> allMenu)
        {

            //Menu = allMenu.Where(o => o.Menu_PCode == Menu.Menu_Code)

            //if (Menu.ChildrenMenus.Count() == 0)
            //{
            //    return;
            //}

            //foreach (var d in Menu.ChildrenMenus)
            //{
            //    GenerateChild(d, allMenu);
            //}
        }

    }
}
