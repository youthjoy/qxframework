
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using QX.HtmlHelperLib.DAL;
using QX.HtmlHelperLib.Model;
using QX.HtmlHelperLib.Comm;

namespace QX.HtmlHelperLib.BLL
{
    /// <summary>
    /// 字段配置表
    /// </summary>
    [Serializable]
    public partial class Bll_Sys_Config_Fieled
    {

        private ADOSys_Config_Fieled instance = new ADOSys_Config_Fieled();

        /// <summary>
        /// 获取所有的信息
        /// </summary>
        /// <returns>list</returns>
        public List<Sys_Config_Fieled> GetAll()
        {
            List<Sys_Config_Fieled> list = instance.GetAll();
            return list;
        }

        /// <summary>
        /// 根据条件获取List
        /// </summary>
        /// <param name='strCondition'>条件(' AND Code='11'')</param>
        /// <returns>list</returns>
        public List<Sys_Config_Fieled> GetListByCode(string strCondition)
        {
            return instance.GetListByWhere(strCondition);
        }

        /// <summary>
        /// 插入数据
        /// </summary>
        /// <param name='model'>实体</param>
        /// <returns>bool</returns>
        public bool Insert(Sys_Config_Fieled model)
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
        /// 获取实体数据
        /// </summary>
        /// <param name='strCondition'>条件(AND Code='11')</param>
        /// <returns>model</returns>
        public Sys_Config_Fieled GetModel(string strCondition)
        {
            List<Sys_Config_Fieled> list = instance.GetListByWhere(strCondition);
            Sys_Config_Fieled model = new Sys_Config_Fieled();
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
        public Sys_Config_Fieled GetModel(int id)
        {
            Sys_Config_Fieled model = instance.GetByKey(id);
            return model;
        }

        /// <summary>
        /// 更新数据
        /// </summary>
        /// <param name='model'>实体</param>
        /// <returns>bool</returns>
     
        /// <summary>
        /// 更新数据
        /// </summary>
        /// <param name='model'>实体</param>
        /// <returns>bool</returns>
   
        /// <summary>
        /// 逻辑删除数据
        /// </summary>
        /// <param name='model'>model</param>
        /// <returns>bool</returns>
        public bool Delete(string Condition)
        {
            bool result = false;
            List<Sys_Config_Fieled> list = instance.GetListByWhere(Condition);
            if (list.Count > 0)
            {
                Sys_Config_Fieled model = list[0];
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
