using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using QX.DAL;
using QX.Model;
using QX.Comm.Utils;
using System.Data.SqlClient;

namespace QX.BLL
{
    public partial class Bll_HR_Stuff
    {


        //private Bll_DeptEmployee_Relation derInstance;

        //private Bll_DeptEmployee_Relation derInstance = new Bll_DeptEmployee_Relation();
        private ADOHR_Stuff instance = new ADOHR_Stuff();
        private Bll_HR_Department deptInstance = new Bll_HR_Department();

        public bool Add(HR_Stuff model)
        {
            if (instance.Add(model) > 0)
            {
                return true;
            }

            return false;
        }


        public bool Update(HR_Stuff model)
        {
            if (instance.Update(model) > 0)
            {
                return true;
            }

            return false;
        }


        public List<HR_Stuff> GetStuffByDept(string deptCode, string filter)
        {
            List<HR_Department> list = deptInstance.GetLevelDeptListWidthSeft(deptCode).ToList();
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < list.Count; i++)
            {
                var d = list[i];
                sb.AppendFormat("'{0}',", d.Dept_Code);
            }
            string where = string.Empty;
            if (string.IsNullOrEmpty(filter))
            {
                where = string.Format(" and  Stuff_DepCode in ({0})", sb.ToString().Trim().TrimEnd(','));
            }
            else
            {
                where = string.Format(" and  Stuff_DepCode in ({0}) {1}", sb.ToString().Trim().TrimEnd(','), filter);
            }

            return instance.GetListByWhere(where);
        }
        public List<HR_Stuff> GetListByCode(string where)
        {
            return instance.GetListByWhere(where);
        }


        public Bll_HR_Stuff()
        {
            //derInstance = new Bll_DeptEmployee_Relation();
        }

        public HR_Stuff GetModel(string code)
        {
            return instance.GetListByWhere(code).FirstOrDefault();
        }


        public HR_Stuff GetModel(string code,Dictionary<string,string> d)
        {
            return instance.GetListByWhere(code,d).FirstOrDefault();
        }
        /// <summary>
        /// 插入数据
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        



        

        /// <summary>
        /// 更新数据
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        

        
        /// <summary>
        /// 新增或更新对象
        /// </summary>
        /// <param name="Mn"></param>
        /// <returns></returns>
       





    }
}
