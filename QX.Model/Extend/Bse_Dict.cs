using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QX.Model
{
    public partial class Bse_Dict
    {
        public IEnumerable<Bse_Dict> ChildDictList { get; set; }

        public IList<Bse_Dict> Childrens{get;set;}

    }
}
