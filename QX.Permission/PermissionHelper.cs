using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using QX.Permission.DAL;
using QX.Permission.Model;

namespace QX.Permission
{
    public partial class PermissionHelper
    {
        ADOSys_UserPermission pInstance = new ADOSys_UserPermission();
        ADOSys_UserPermission_Method pmInstance = new ADOSys_UserPermission_Method();

        public static Dictionary<string,string> CurrentUserPermission(string userid)
        {

            var key = QX.Cache.CacheHelper.MakeKey(userid, Cache.CacheKeyEnum.Permission.ToString());
            var result = QX.Cache.CacheHelper.Get<Dictionary<string,string>>(key);
            if (result != null)
            {
                return result;
            }
            var dict = new Dictionary<string, string>();
            var list = new ADOSys_UserPermission().GetUserPerimission(userid);
            foreach (var d in list)
            {
                if (!dict.Keys.Contains(d.PU_FunCode))
                {
                    dict.Add(d.PU_FunCode, d.Fun_UDef1);
                }
            }
            Cache.CacheHelper.SaveTime = 1440;
            Cache.CacheHelper.Insert(key, dict);

            return dict;

        }

        private static PermissionHelper _instance;
        public static PermissionHelper Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new PermissionHelper();
                    return _instance;
                }
                return _instance;
            }
        }
        /// <summary>
        /// 获取用户相关的权限列表
        /// </summary>
        /// <param name="uid"></param>
        /// <returns></returns>
        public List<Sys_UserPermission> GetUserPermissionListByUser(string uid)
        {
            List<Sys_UserPermission> list = pInstance.GetUserPerimission(uid);
            return list;
        }

        public List<Sys_UserPermission_Method> GetFunRefMethod(string funcode)
        {
            List<Sys_UserPermission_Method> list = pmInstance.GetListByWhere(string.Format("AND FP_FunCode='{0}'", funcode));
            return list;
        }

        /// <summary>
        /// 获取用户相关的权限点列表
        /// </summary>
        /// <returns></returns>
        public Dictionary<string, string> GetUserPermissionMapByUser(string uid)
        {
            Dictionary<string, string> dic = new Dictionary<string, string>();
            List<Sys_UserPermission> list = pInstance.GetUserPerimission(uid);
            foreach (var p in list)
            {
                if (dic.Keys.Contains(p.PU_FunCode))
                {
                    continue;
                }
                dic.Add(p.PU_FunCode, p.Fun_UDef1);
            }
            return dic;
        }

        /// <summary>
        /// 判断用户是否拥有某个功能的权限
        /// </summary>
        /// <param name="uid"></param>
        /// <param name="fcode"></param>
        /// <returns></returns>
        public bool IsHavePermission(string uid, string fcode)
        {
            var list = GetUserPermissionListByUser(uid);
            var model = list.FirstOrDefault(o => o.PU_FunCode == fcode);
            if (model == null)
            {
                return false;
            }

            return true;
        }

        #region  Controller方面-权限维护


        #endregion
    }
}
