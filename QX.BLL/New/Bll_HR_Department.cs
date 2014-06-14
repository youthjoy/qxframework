using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using QX.DAL;
using QX.Model;

namespace QX.BLL
{
    public partial class Bll_HR_Department
    {

        private ADOHR_Department instance = new ADOHR_Department();
        private ADOComm com = new ADOComm();
        public List<HR_Department> GetListByCode(string where)
        {
            return instance.GetListByWhere(where);
        }

        public IEnumerable<HR_Department> GetChildListDept()
        {
            List<HR_Department> allDept = instance.GetAll();
            IEnumerable<HR_Department> root = allDept.Where(o => string.IsNullOrEmpty(o.Dept_PCode));
            foreach (var d in root)
            {
                GenerateChild(d, allDept);
            }

            return root;

        }
        private void GenerateChild(HR_Department dept, List<HR_Department> allDept)
        {
            dept.ChildrenDept = allDept.Where(o => o.Dept_PCode == dept.Dept_Code);

            if (dept.ChildrenDept.Count() == 0)
            {
                return;
            }

            foreach (var d in dept.ChildrenDept)
            {
                GenerateChild(d, allDept);
            }
        }
        

        public HR_Department GetModel(string where)
        {
            return instance.GetListByWhere(where).FirstOrDefault();
        }
        /// <summary>
        /// 获取部门列表
        /// </summary>
        /// <returns></returns>
        public List<HR_Department> GetDeptList()
        {
            string where = " AND Dept_PCode IS NULL";

            return instance.GetListByWhere(where);
        }

        public string GetCompanyName(string deptCode)
        {
            string deptName = "";
            List<HR_Department> list = instance.GetAll();
            for (var i = 0; i < list.Count;i++ )
            {
                var _dept = list.Where(o => o.Dept_Code == deptCode)
                   .FirstOrDefault();
                HR_Department dept = new HR_Department();
                if (_dept != null && !string.IsNullOrEmpty(_dept.Dept_PCode))
                {
                    deptName = _dept.Dept_Name;
                    break;
                }
                else
                {
                    GetCompanyName(list[i].Dept_PCode);
                }
            }
            return deptName;
        }


        //获取下一级节点(未使用)
        public List<HR_Department> GetDeptByParent(string parentCode)
        {
            string where = string.Format(" AND Dept_PCode='{0}'", parentCode);
            return instance.GetListByWhere(where);
        }


        /// <summary>
        /// 获取树控件节点列表
        /// </summary>
        /// <param name="keyCode"></param>
        /// <returns></returns>
        public List<TheTreeNode> GetDeptTree()
        {

            List<HR_Department> allData = instance.GetAll();

            IEnumerable<HR_Department> temp = allData.Where(o => (string.IsNullOrEmpty(o.Dept_PCode)));
            List<TheTreeNode> rootTreeNode = (from t in temp select new TheTreeNode { data = t.Dept_Name, attr = new Attr { id = t.Dept_Code } }).ToList();

            //List<TheTreeNode> result = new List<TheTreeNode>();

            foreach (var d in rootTreeNode)
            {

                GenerateTree(d, allData);
                //rootTreeNode.Add(d);
            }

            return rootTreeNode;
        }

        public List<HR_Department> GetDeptTreeForPermission()
        {

            List<HR_Department> allData = instance.GetAll();

            IEnumerable<HR_Department> temp = allData.Where(o => (string.IsNullOrEmpty(o.Dept_PCode)));
            List<HR_Department> rootTreeNode = temp.ToList();

            //List<TheTreeNode> result = new List<TheTreeNode>();

            foreach (var d in rootTreeNode)
            {

                GenerateTree(d, allData);
                //rootTreeNode.Add(d);
            }

            return rootTreeNode;
        }

        private void GenerateTree(TheTreeNode node, List<HR_Department> allData)
        {
            var list = allData.Where(o => o.Dept_PCode == node.attr.id);

            node.children = (from d in list select new TheTreeNode { data = d.Dept_Name, attr = new Attr { id = d.Dept_Code } }).ToList();


            if (node.children.Count == 0)
            {
                return;
            }

            foreach (var d in node.children)
            {
                GenerateTree(d, allData);
            }
        }

        private void GenerateTree(HR_Department node, List<HR_Department> allData)
        {
            var list = allData.Where(o => o.Dept_PCode == node.Dept_Code);

           // node.children = (from d in list select new TheTreeNode { data = d.Dept_Name, attr = new Attr { id = d.Dept_Code } }).ToList();


            if (list.Count() == 0)
            {
                return;
            }

            foreach (var d in list)
            {
                GenerateTree(d, allData);
            }
        }



        /// <summary>
        /// 获取某节点下面所有子节点(有误)
        /// </summary>
        /// <param name="code"></param>
        /// <returns></returns>
        public List<HR_Department> GetLevelDeptList(string code)
        {
            List<HR_Department> allDept = instance.GetAll();
            List<HR_Department> list = new List<HR_Department>();
            //foreach (var d in allDept)
            //{

            //    list.Add(d);
            //    GenerateDept(list, allDept, allDept.Where(o => o.Dept_PCode == d.Dept_Code));
            //}

            return list;
        }


        #region 获取层级部门节点列表

        /// <summary>
        /// 获取某节点下面所有子节点
        /// </summary>
        /// <param name="code"></param>
        /// <returns></returns>
        public List<HR_Department> GetLevelDeptListWidthSeft(string code)
        {
            List<HR_Department> allDept = instance.GetAll();
            List<HR_Department> list = new List<HR_Department>();
            list.Add(allDept.FirstOrDefault(o => o.Dept_Code == code));
            foreach (var d in allDept.Where(o => o.Dept_PCode == code))
            {

                list.Add(d);
                GenerateDept(list, allDept, allDept.Where(o => o.Dept_PCode == d.Dept_Code));
            }

            return list;
        }

        public bool UpdateDept(HR_Department model)
        {
            if (instance.Update(model) > 0)
            {
                return true;
            }

            return false;
        }

        public string GenerateDeptCode()
        {
            return com.GetTableKeyCode("HR_Department");
        }

        public bool AddDept(HR_Department model)
        {
            if (instance.Add(model) > 0)
            {
                return true;
            }

            return false;
        }

        private void GenerateDept(List<HR_Department> list, List<HR_Department> allData, IEnumerable<HR_Department> parentNodes)
        {
            if (parentNodes.Count() == 0)
            {
                return;
            }
            foreach (var d in parentNodes)
            {
                
                list.Add(d);
                GenerateDept(list, allData, allData.Where(o => o.Dept_PCode == d.Dept_Code));
            }
        }

        /// <summary>
        /// 生成包含层级关系的子节点列表
        /// </summary>
        /// <returns></returns>
     
        /// <summary>
        /// 新增或更新对象
        /// </summary>
        /// <param name="Mn"></param>
        /// <returns></returns>
        public bool AddUpdatePlanObject(HR_Department dep)
        {
            if (dep.Dept_ID.Equals(0))
            {
                return instance.Add(dep).Equals(1);
            }
            else
            {
                return instance.Update(dep).Equals(1);
            }
        }
        #endregion

    }
}
