using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Data.SqlClient;

namespace QX.DeskConfig.Comm
{
    public static class AppConfig
    {
        /// <summary>
        /// 所有虚拟路径的基本路径
        /// </summary>
        public static string BaseUrl
        {
            get
            {
                return System.Configuration.ConfigurationManager.AppSettings["BaseUrl"].ToString();
            }
        }
    }

    public abstract class ConfigHelper
    {
        public string GetConfigString(string Key)
        {
            return ConfigurationSettings.AppSettings[Key];
        }

        public static string GetDBHost()
        {
            SqlConnection conn = new SqlConnection(GetApp("ConnectionString"));
            return conn.DataSource;
        }

        /// <summary>
        /// 获取连接字符串
        /// </summary>
        /// <returns>连接字符串</returns>
        public virtual string GetConfigConnectionString()
        {
            return GetApp("ConnectionString");
        }

        /// <summary>
        /// 获取app文件
        /// </summary>
        /// <returns></returns>
        public static string GetApp(string appKey)
        {
            string temp = "";
            try
            {
                temp = ConfigurationManager.AppSettings[appKey];
            }
            catch
            {
                SetApp(appKey, "");
                temp = "";
            }
            return temp;
        }
        /// <summary>
        /// 设置app文件
        /// </summary>
        /// <param name="appKey"></param>
        /// <param name="appValue"></param>
        /// <returns></returns>
        public static bool SetApp(string appKey, string appValue)
        {
            bool flag = false;
            try
            {
                Configuration config = ConfigurationManager.OpenExeConfiguration(System.Configuration.ConfigurationUserLevel.None);
                bool hasKey = false;
                foreach (string k in config.AppSettings.Settings.AllKeys)
                {
                    if (k == appKey)
                    {
                        config.AppSettings.Settings[appKey].Value = appValue;
                        hasKey = true;
                        break;
                    }
                }
                if (!hasKey)
                    config.AppSettings.Settings.Add(appKey, appValue);
                config.Save(ConfigurationSaveMode.Modified);
                ConfigurationManager.RefreshSection("appSettings");
                flag = true;
            }
            catch
            {
                flag = false;
            }
            return flag;
        }
    }
}
