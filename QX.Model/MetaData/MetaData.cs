using System;
using System.Collections.Generic;
using System.Text;


namespace QX.Model
{

    [AttributeUsage(AttributeTargets.Property, AllowMultiple = true, Inherited = true)]
    public class MetaData : System.Attribute
    {
        private string columKey;
        private string columDes;        

        public string ColumDes
        {
            get { return columDes; }
            set { columDes = value; }
        }

        public string ColumKey
        {
            get { return columKey; }
            set { columKey = value; }
        }

        /// <summary>
        /// 字段名称，字段描述
        /// </summary>
        /// <param name="_columKey"></param>
        /// <param name="_columDes"></param>
        public MetaData(string _columKey, string _columDes)
        {
            this.columDes = _columDes;
            this.columKey = _columKey;
        }
    }
}
