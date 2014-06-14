
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using QX.DAL;
using QX.Model;
using QX.Comm;

namespace QX.BLL
{
    [Serializable]
    public partial class Bll_Sys_UserPermission
    {

        private ADOSys_UserPermission instance = new ADOSys_UserPermission();
        private Bll_Comm comInstance = new Bll_Comm();
        private Bll_HR_Stuff sInstance = new Bll_HR_Stuff();
        /// <summary>
        /// 先判断个人权限在判断角色
        /// </summary>
        /// <param name="userCode"></param>
        /// <param name="FunCode"></param>
        /// <returns></returns>
        //public bool IsHavePermission(string userCode, string FunCode)
        //{
        //    HR_Stuff stuff = sInstance.GetModel(string.Format("AND Stuff_Code='{0}'", userCode));


        //    var model = GetModel(string.Format(" AND PU_UserCode='{0}' AND PU_FunCode='{1}'", userCode, FunCode));

        //    if (model != null)
        //    {
        //        return true;
        //    }

        //    return false;

        //}

        public List<Sys_UserPermission> GetUserPermission(string usercode)
        {
            //HR_Stuff stuff = sInstance.GetModel(usercode);

            var list = GetListByCode(string.Format(" AND PU_UserCode='{0}'", usercode));

            return list;
           
        }

        /// <summary>
        /// 获取用户所拥有的所有权限
        /// </summary>
        /// <param name="usercode"></param>
        /// <returns></returns>
        public List<Sys_UserPermission> GetUserPermissionWithRole(string usercode)
        {
            //HR_Stuff stuff = sInstance.GetModel(string.Format(" AND Stuff_Code='{0}'",usercode));

            var list = instance.GetUserPerimission(usercode);
            //if (!string.IsNullOrEmpty(stuff.Stuff_Role))
            //{
            //    var list2 = instance.GetUserPerimission(usercode);
            //    var result = list.Union(list2);
            //    return result.Distinct(new CommonEqualityComparer<Sys_UserPermission, string>(o => o.PU_FunCode)).ToList();
            //}
            //else
            //{
                return list;
            //}
            //return GetListByCode(string.Format(" AND PU_UserCode='{0}'",usercode));
        }

        

        /// <summary>
        /// 获取用户所拥有的区域权限
        /// </summary>
        /// <param name="usercode"></param>
        /// <returns></returns>
        public List<Sys_UserPermission> GetUserPermissionForArea(string usercode)
        {
            HR_Stuff stuff = sInstance.GetModel(string.Format("AND Stuff_Code='{0}'",usercode));

            var list = instance.GetUserPerimissionEx(string.Format("AND isnull(Fun_iType,'') in ('Area','Station') AND PU_UserCode='{0}'", usercode));
            
            if (stuff == null || string.IsNullOrEmpty(stuff.Stuff_Role))
            {
                return new List<Sys_UserPermission>();
            }

            if (!string.IsNullOrEmpty(stuff.Stuff_Role))
            {
                var list2 = instance.GetUserPerimissionEx(string.Format("AND isnull(Fun_iType,'') in ('Area','Station') AND PU_UserCode='{0}'", stuff.Stuff_Role));

                var result = list.Union(list2);
                return result.Distinct(new CommonEqualityComparer<Sys_UserPermission, string>(o => o.PU_FunCode)).ToList();
            }
            else
            {
                return list;
            }
        }

        /// <summary>
        /// 权限更新
        /// </summary>
        /// <param name="userCode"></param>
        /// <param name="list"></param>
        /// <returns></returns>
        public bool UpdatePermission(string userCode, List<Sys_UserPermission> list)
        {
            List<Sys_UserPermission> oldlist = GetListByCode(string.Format("AND PU_UserCode='{0}'", userCode));

            foreach (var u in oldlist)
            {
                var mo = list.FirstOrDefault(o => o.PU_FunCode == u.PU_FunCode);
                if (mo != null)
                {
                    mo.PU_IsCheck = "1";
                    instance.Update(mo);
                    list.Remove(mo);
                }
                else
                {
                    u.PU_IsCheck = "0";
                    u.Stat = 1;
                    Update(u);
                }


            }
            foreach (var uu in list)
            {
                Sys_UserPermission per = new Sys_UserPermission();
                per.PU_Code = GenereatePermissionCode();
                per.PU_UserCode = userCode;
                per.PU_FunCode = uu.PU_FunCode;
                per.PU_UDef1 = uu.PU_UDef1;
                per.PU_IsCheck = "1";
                Insert(per);
            }
            return true;
        }

        /// <summary>
        /// 生成权限编码
        /// </summary>
        /// <returns></returns>
        public string GenereatePermissionCode()
        {
            return comInstance.GetTableKeyCode("Sys_UserPermission");
        }

        /// <summary>
        /// 获取所有的信息
        /// </summary>
        /// <returns>list</returns>
        public List<Sys_UserPermission> GetAll()
        {
            List<Sys_UserPermission> list = instance.GetAll();
            return list;
        }

        /// <summary>
        /// 根据条件获取List
        /// </summary>
        /// <param name='strCondition'>条件(' AND Code='11'')</param>
        /// <returns>list</returns>
        public List<Sys_UserPermission> GetListByCode(string strCondition)
        {
            return instance.GetListByWhere(strCondition);
        }

        /// <summary>
        /// 插入数据
        /// </summary>
        /// <param name='model'>实体</param>
        /// <returns>bool</returns>
        public bool Insert(Sys_UserPermission model)
        {
            bool result = false;
            try
            {
                int _result = instance.Add(model);
                if (_result > 0)
                {
                    result = true;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return result;
        }
        /// <summary>
        /// 插入数据
        /// </summary>
        /// <param name='model'>实体</param>
        /// <param name='model'>是否完成验证</param>
        /// <returns>bool</returns>
        public bool Insert(Sys_UserPermission model, bool IsValid)
        {
            var e = new ModelExceptions();
            bool result = false;
            if (e.IsValid && IsValid)
            {
                //完成了验证，开始更新数据库了
                int _result = instance.Add(model);
                if (_result > 0)
                {
                    result = true;
                }
            }
            return result;
        }
        /// <summary>
        /// 获取实体数据
        /// </summary>
        /// <param name='strCondition'>条件(AND Code='11')</param>
        /// <returns>model</returns>
        public Sys_UserPermission GetModel(string strCondition)
        {
            List<Sys_UserPermission> list = instance.GetListByWhere(strCondition);
            Sys_UserPermission model = new Sys_UserPermission();
            if (list != null && list.Count > 0)
            {
                model = list[0];
            }
            else
            {
                model = null;
            }
            return model;
        }

        /// <summary>
        /// 获取实体数据
        /// </summary>
        /// <param name='strCondition'>条件(AND Code='11')</param>
        /// <returns>model</returns>
        public Sys_UserPermission GetModel(int id)
        {
            Sys_UserPermission model = instance.GetByKey(id);
            return model;
        }

        /// <summary>
        /// 更新数据
        /// </summary>
        /// <param name='model'>实体</param>
        /// <returns>bool</returns>
        public bool Update(Sys_UserPermission model)
        {
            bool result = false;
            var e = new ModelExceptions();
            int _rseult = instance.Update(model);
            if (_rseult > 0)
            {
                result = true;
            }
            return result;
        }

        /// <summary>
        /// 更新数据
        /// </summary>
        /// <param name='model'>实体</param>
        /// <returns>bool</returns>
        public bool Update(Sys_UserPermission model, bool IsValid)
        {

            bool result = false;
            var e = new ModelExceptions();
            if (e.IsValid && IsValid)
            {
                int _rseult = instance.Update(model);
                if (_rseult > 0)
                {
                    result = true;
                }
            }
            return result;
        }
        /// <summary>
        /// 逻辑删除数据
        /// </summary>
        /// <param name='model'>model</param>
        /// <returns>bool</returns>
        public bool Delete(string Condition)
        {
            bool result = false;
            List<Sys_UserPermission> list = instance.GetListByWhere(Condition);
            if (list.Count > 0)
            {
                Sys_UserPermission model = list[0];
                model.Stat = 1;
                int _rseult = instance.Update(model);
                if (_rseult > 0)
                {
                    result = true;
                }
            }
            return result;
        }
    }
}
