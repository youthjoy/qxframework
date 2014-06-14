using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QX.Model
{
    public partial class HR_Department
    {
        public IEnumerable<HR_Department> ChildrenDept
        {
            get;
            set;
        }
    }
}
