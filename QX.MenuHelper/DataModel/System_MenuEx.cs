using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QX.MenuHelper.Model
{
    public partial class System_Menu
    {
        /// <summary>
        /// child节点
        /// </summary>
        public IEnumerable<System_Menu> ChildrenMenus
        {
            get;
            set;
        }
    }
}
