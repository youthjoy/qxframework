using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using System.Web;

namespace QX.Config
{

    /// <summary>
    /// Session配置类型
    /// </summary>
    public static class SessionConfig
    {
        /// <summary>
        /// 用户ID
        /// </summary>
        /// <param name="controller"></param>
        /// <returns></returns>
        public static string UserId()
        {
            string _UserId = "";
            try
            {
                _UserId = GetSession("UserId").ToString();
            }
            catch (System.Exception ex)
            {
                _UserId = "";
            }
            return _UserId;
        }


        /// <summary>
        /// 用户名称 
        /// </summary>
        /// <param name="controller"></param>
        /// <returns></returns>
        public static string UserName()
        {
            string _UserName = string.Empty;
            try
            {
                _UserName = GetSession("UserName").ToString();
            }
            catch (System.Exception ex)
            {
                _UserName = "";
            }
            return _UserName;
        }


        /// <summary>
        /// 登陆角色
        /// </summary>
        /// <returns></returns>
        public static string Stuff_LoginType()
        {
            string _Stuff_LoginType = string.Empty;
            try
            {
                _Stuff_LoginType = GetSession("UserRole").ToString();
            }
            catch (System.Exception ex)
            {
                _Stuff_LoginType = "";
            }
            return _Stuff_LoginType;

        }



        /// <summary>
        /// 部门ID
        /// </summary>
        /// <param name="controller"></param>
        /// <returns></returns>
        public static string DeptId()
        {
            string  _DeptId = "";
            try
            {
                _DeptId = GetSession("DeptId").ToString();
            }
            catch (System.Exception ex)
            {
                _DeptId = "";
            }
            return _DeptId;
        }
        /// <summary>
        /// 部门名称 
        /// </summary>
        /// <param name="controller"></param>
        /// <returns></returns>
        public static string DeptName()
        {
            string _DeptName = string.Empty;
            try
            {
                _DeptName = GetSession("DeptName").ToString();
            }
            catch (System.Exception ex)
            {
                _DeptName = "";
            }
            return _DeptName;
        }

        public static string DeptCode()
        {
            string _DeptName = string.Empty;
            try
            {
                _DeptName = GetSession("DeptCode").ToString();
            }
            catch (System.Exception ex)
            {
                _DeptName = "";
            }
            return _DeptName;
        }

        /// <summary>
        /// 所属公司
        /// </summary>
        /// <param name="controller"></param>
        /// <returns></returns>
        public static string Company()
        {
            string _Company = string.Empty;
            try
            {
                _Company = GetSession("Company").ToString();
            }
            catch (System.Exception ex)
            {
                _Company = "";
            }
            return _Company;
        }

        public static string CompanyCode()
        {
            string _Company = string.Empty;
            try
            {
                _Company = GetSession("CompanyCode").ToString();
            }
            catch (System.Exception ex)
            {
                _Company = "";
            }
            return _Company;
        }

        /// <summary>
        /// 附件存放文件夹
        /// </summary>
        /// <param name="controller"></param>
        /// <returns></returns>
        public static string AttachBaseFolder(this Controller controller)
        {
            controller.SetSession<string>("AttachFolder","/content/Attachment");
            return controller.GetSession<string>("AttachFolder");
        }


        /// <summary>
        /// 检查Sessionb
        /// </summary>
        /// <param name="hepler"></param>
        /// <returns></returns>
        public static string CheckSession(this HtmlHelper hepler)
        {
            var UserId = SessionConfig.UserId();
            string Html = "";
            if (string.IsNullOrEmpty(UserId))
            {
                HttpContext.Current.Session.Clear();
                Html=" <script> alert('登录超时,请重新登录'); window.top.location='/home/login'; </script> ";
            }
            return Html;
        }

        /// <summary>
        /// 当前用户IP
        /// </summary>
        /// <returns></returns>
        public static string CurrentIP()
        {
            string _IP = "";
            try
            {
                _IP = GetSession("IP").ToString();
            }
            catch (System.Exception ex)
            {
                _IP = "";
            }
            return _IP; 
        }

        #region Session操作

        /// <summary>
        /// 获取Sesssion
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="controller"></param>
        /// <param name="field"></param>
        /// <returns></returns>
        public static T GetSession<T>(this Controller controller, string field)
        {
            T val = default(T);
            try
            {
                if (!string.IsNullOrEmpty(field))
                {
                    val = (T)controller.Session[field];
                }
            }
            catch (System.Exception ex)
            {

            }
            return val;
        }

        /// <summary>
        /// 获取Session
        /// </summary>
        /// <param name="field"></param>
        /// <returns></returns>
        public static object GetSession(string field)
        {
            object val = null;
            try
            {
                val = HttpContext.Current.Session[field] != null ? HttpContext.Current.Session[field] : null;
            }
            catch (System.Exception ex)
            {
            	 
            }
            return val;
        }

        /// <summary>
        /// 设置 Session
        /// </summary>
        /// <param name="key"></param>
        /// <param name="val"></param>
        public static void SetSession(string key,object val)
        {
            try
            {
                HttpContext.Current.Session[key] = val;
            }
            catch (System.Exception ex)
            {
            	 
            }            
        }

        /// <summary>
        /// 设置Session
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="controller"></param>
        /// <param name="key"></param>
        /// <param name="value"></param>
        public static void SetSession<T>(this Controller controller, string key, T value)
        {
            try
            {
                if (!string.IsNullOrEmpty(key))
                {
                    controller.Session[key] = value;
                }
            }
            catch (System.Exception ex)
            {

            }
        }

        #endregion

    }
}
