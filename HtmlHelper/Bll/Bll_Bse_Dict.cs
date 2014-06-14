
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using QX.HtmlHelperLib.DAL;
using QX.HtmlHelperLib.Model;
using QX.Comm;

namespace QX.HtmlHelperLib.BLL
{
    /// <summary>
    /// 数据字典
    /// </summary>
    [Serializable]
    public partial class Bll_Bse_Dict
    {

        private ADOBse_Dict instance = new ADOBse_Dict();

        /// <summary>
        /// 获取所有的信息
        /// </summary>
        /// <returns>list</returns>
        public List<Bse_Dict> GetAll()
        {
            List<Bse_Dict> list = instance.GetAll();
            return list;
        }

        /// <summary>
        /// 根据条件获取List
        /// </summary>
        /// <param name='strCondition'>条件(' AND Code='11'')</param>
        /// <returns>list</returns>
        public List<Bse_Dict> GetListByCode(string strCondition)
        {
            return instance.GetListByWhere(strCondition);
        }

        /// <summary>
        /// 插入数据
        /// </summary>
        /// <param name='model'>实体</param>
        /// <returns>bool</returns>
        public bool Insert(Bse_Dict model)
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
        //public bool Insert(Bse_Dict model, bool IsValid)
        //{
        //    var e = new ModelExceptions();
        //    bool result = false;
        //    if (e.IsValid && IsValid)
        //    {
        //        //完成了验证，开始更新数据库了
        //        int _result = instance.Add(model);
        //        if (_result > 0)
        //        {
        //            result = true;
        //        }
        //    }
        //    return result;
        //}
        /// <summary>
        /// 获取实体数据
        /// </summary>
        /// <param name='strCondition'>条件(AND Code='11')</param>
        /// <returns>model</returns>
        public Bse_Dict GetModel(string strCondition)
        {
            List<Bse_Dict> list = instance.GetListByWhere(strCondition);
            Bse_Dict model = new Bse_Dict();
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
        //public Bse_Dict GetModel(int id)
        //{
        //    Bse_Dict model = instance.GetByKey(id);
        //    return model;
        //}    

        /// <summary>
        /// 更新数据
        /// </summary>
        /// <param name='model'>实体</param>
        /// <returns>bool</returns>
        //public bool Update(Bse_Dict model)
        //{
        //    bool result = false;
        //    var e = new ModelExceptions();
        //    int _rseult = instance.Update(model);
        //    if (_rseult > 0)
        //    {
        //        result = true;
        //    }
        //    return result;
        //}

        /// <summary>
        /// 更新数据
        /// </summary>
        /// <param name='model'>实体</param>
        /// <returns>bool</returns>
        //public bool Update(Bse_Dict model, bool IsValid)
        //{

        //    bool result = false;
        //    var e = new ModelExceptions();
        //    if (e.IsValid && IsValid)
        //    {
        //        int _rseult = instance.Update(model);
        //        if (_rseult > 0)
        //        {
        //            result = true;
        //        }
        //    }
        //    return result;
        //}
        /// <summary>
        /// 逻辑删除数据
        /// </summary>
        /// <param name='model'>model</param>
        /// <returns>bool</returns>
        public bool Delete(string Condition)
        {
            bool result = false;
            List<Bse_Dict> list = instance.GetListByWhere(Condition);
            if (list.Count > 0)
            {
                Bse_Dict model = list[0];
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
