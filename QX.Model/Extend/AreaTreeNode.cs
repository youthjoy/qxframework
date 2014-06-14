using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QX.Model
{
    public class AreaTreeNode
    {
        public IEnumerable<AreaTreeNode> ChildList { get; set; }

        public string Code { get; set; }

        public string PCode { get; set; }

        public string Name { get; set; }

        public string State { get; set; }
    }
}
