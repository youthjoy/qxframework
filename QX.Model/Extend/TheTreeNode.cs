using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QX.Model
{
    [Serializable]
    public class TheTreeNode
    {
        public string data { get; set; }
        public string state { get; set; }
        public Attr attr{get;set;}
        public List<TheTreeNode> children { get; set; }
    }

    public class Attr
    {
        public string id { get; set; }
        public string rel { get; set; }
    }
}
