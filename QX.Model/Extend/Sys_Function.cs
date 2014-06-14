using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QX.Model
{
    public partial class Sys_Function
    {
        /// <summary>
        /// 用户编码
        /// </summary>
        public string PU_UserCode { get; set; }
        /// <summary>
        /// 是否启用
        /// </summary>
        public string PU_IsCheck { get; set; }
        /// <summary>
        /// 子节点
        /// </summary>
        public IList<Sys_Function> Childrens { get; set; }

    }
}
