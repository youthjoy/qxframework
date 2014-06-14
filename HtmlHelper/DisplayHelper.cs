using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using QX.Comm;
using QX.DAL;
using QX.Model;

namespace QX.HtmlHelperLib
{
    public class DisplayHelper
    {
        public static List<DisplayPage_Config> GetDisplayConfig(string moduleName, string className)
        {
            ADODisplayPage_Config configInstance = new ADODisplayPage_Config();

            string where = string.Format(" AND DCP_ModuleName='{0}' AND DCP_Model='{1}' Order by DCP_Order ASC", moduleName, className);

            return configInstance.GetListByWhere(where);
        }


        public static List<Sys_PU_Config> GetPUDisplayConfig(string moduleName, string className)
        {
            ADOSys_PU_Config configInstance = new ADOSys_PU_Config();

            string where = string.Format(" AND DCP_ModuleName='{0}' AND DCP_Model='{1}' AND DCP_IsHidden is null Order by DCP_Order ASC", moduleName, className);

            return configInstance.GetListByWhere(where);
        }




        public static List<Sys_PU_Config> GetHiddenPUDisplayConfig(string moduleName, string className)
        {
            ADOSys_PU_Config configInstance = new ADOSys_PU_Config();

            string where = string.Format(" AND DCP_ModuleName='{0}' AND DCP_Model='{1}' AND DCP_IsHidden=1 Order by DCP_Order ASC", moduleName, className);

            return configInstance.GetListByWhere(where);
        }


        public static List<Sys_PU_Config> GetValidateConfig(string className)
        {
            ADOSys_PU_Config configInstance = new ADOSys_PU_Config();

            string where = string.Format(" AND DCP_Model='{0}' Order by DCP_Order ASC",  className);

            return configInstance.GetListByWhere(where);
        }
    }
 
}
