using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Xml;

namespace QX.Config.MvcXmlRouting
{
    public class MvcRouteConfigurationSection : ConfigurationSection
    {
        [ConfigurationProperty("ignore", IsRequired=false)]
        public IgnoreCollection Ignore
        {
            get
            {
                return (IgnoreCollection)(this["ignore"]);
            }
        }

        [ConfigurationProperty("map", IsRequired=false)]
        public RoutingCollection Map
        {
            get
            {
                return (RoutingCollection)(this["map"]);
            }
        }
    }
}
