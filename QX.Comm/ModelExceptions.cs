using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;

namespace QX.Comm
{
    public class ModelExceptions: Exception
    {
        List<string[]> errors = new List<string[]>();

        /// <summary>
        /// 是否通过验证
        /// </summary>
        public bool IsValid
        {
            get { return errors.Count == 0 ? true : false; }
        }

        /// <summary>
        /// 添加错误信息
        /// </summary>
        /// <param name="name"></param>
        /// <param name="msg"></param>
        public void AddError(string name, string msg)
        {
            this.errors.Add(new string[] { name, msg });
        }
        /// <summary>
        /// 将错误信息填充到ModelState里面
        /// </summary>
        /// <param name="modelstate"></param>
        public void FillModelState(ModelStateDictionary modelstate)
        {
            foreach (var item in this.errors)
            {
                modelstate.AddModelError(item[0], item[1]);
            }
        }
    }
}
