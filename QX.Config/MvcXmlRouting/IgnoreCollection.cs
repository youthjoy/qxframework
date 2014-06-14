using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;

namespace QX.Config.MvcXmlRouting
{
    public class IgnoreCollection : ConfigurationElementCollection
    {
        public IgnoreItem this[int index]
        {
            get
            {
                return base.BaseGet(index) as IgnoreItem;
            }
        }
        
        protected override ConfigurationElement CreateNewElement()
        {
            return new IgnoreItem();
        }

        protected override object GetElementKey(ConfigurationElement element)
        {
            return ((IgnoreItem)element).Url;
        }
    }
}
