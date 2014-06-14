using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using QX.DAL;
using QX.Model;
using QX.Comm;
using QX.Comm.Utils;
using System.Data;
using System.Data.SqlClient;

namespace QX.BLL
{
    public partial class Bll_Bse_Dict
    {
        private ADOBse_Dict instance = new ADOBse_Dict();

        public string CreateDictNode(Bse_Dict Node, bool IsChildNode, ref int order)
        {
            //获取关键字
            string codeKey = Node.Dict_Key;

            //获取父编码
            string parentCode = Node.Dict_Code;

            if (codeKey == parentCode)//如果是最顶级，即其父编码为空
                parentCode = "";

            //throw new NotImplementedException();
            //var dict = GetModelByCode(parentCode,);
            order = 0;
            //var newCode = GenerateDictCode(dict.Dict_Key,IsChildNode, ref order);
            string Code = "";
            // var newCode = Bll_Comm.GetTableKey("", codeKey, parentCode, Code);
            string newCode = new Bll_Comm().GetTableKeyCode("");
            return newCode;

        }

        /// <summary>
        /// 是否允许多层级
        /// </summary>
        /// <param name="dictKey"></param>
        /// <returns></returns>
        public bool IsAllowLevel(string dictKey)
        {
            var model = GetModelByCode("", dictKey);
            if (model.Dict_Level == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public Bse_Dict GetModelByCode(string code, string key)
        {
            string filter = "";
            if (!string.IsNullOrEmpty(code))
            {
                filter += " AND Dict_Code='" + code + "' ";
            }
            if (!string.IsNullOrEmpty(key))
            {
                filter += " AND Dict_Key='" + key + "'";
            }

            return GetModel(filter);
        }

        public Bse_Dict GetModel(string filter)
        {
            return instance.GetListByWhere(filter).FirstOrDefault();
        }

        /// <summary>
        /// 根据关键字生成字典编码
        /// </summary>
        /// <param name="key"></param>
        /// <param name="order">该字典顺序号</param>
        /// <returns></returns>
        public string GenerateDictCode(string key, bool IsChildNode, string pCode, ref int order)
        {
            //Dictionary<string, int> dic = new Dictionary<string, int>();
            //int maxNum = TypeConverter.ObjectToInt(instance.GetMax("Dict_ID", key)) + 1;
            int maxNum = 0;
            //DataTable dt = instance.idb.RunProcReturnDatatable("qx_find_dictkeycode", new List<SqlParameter>() { new SqlParameter("sTable", key) }.ToArray());
            //Modify By QB            

            string code = string.Empty;
            if (pCode == "root" || pCode == "")
                pCode = "";

            //code = Bll_Comm.GetTableKey("", key, pCode, code);
            code = "";
            return code;
        }

        /// <summary>
        /// 根据字典关键字获取其相关字典数据(与关键字相关)
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public List<Bse_Dict> GetDictByKey(string key)
        {
            string sql = string.Format(" AND Dict_Key='{0}' AND Dict_Code!='{0}'", key);
            return instance.GetListByWhere(sql);
        }


        public List<Bse_Dict> GetDictListByKeyCode(string key)
        {
            string sql = string.Format(" AND Dict_Key='{0}'", key);
            return instance.GetListByWhere(sql);
        }

        public List<Bse_Dict> GetDictListByKeyCodeNoRoot(string key)
        {
            string sql = string.Format(" AND Dict_Key='{0}' AND Dict_Code!='{0}'", key);
            return instance.GetListByWhere(sql);
        }

        /// <summary>
        /// 获取树控件节点列表
        /// </summary>
        /// <param name="keyCode"></param>
        /// <returns></returns>
        public List<TheTreeNode> GetDictTreeByKey(string keyCode)
        {
            var key = keyCode.ToUpper();
            List<Bse_Dict> allData = GetDictListByKeyCode(key);

            IEnumerable<Bse_Dict> temp = allData.Where(o => (string.IsNullOrEmpty(o.Dict_PCode) && o.Dict_Key.ToUpper() == key));
            IEnumerable<TheTreeNode> rootTreeNode = from t in temp select new TheTreeNode { data = t.Dict_Name, attr = new Attr { id = t.Dict_Code } };

            List<TheTreeNode> result = new List<TheTreeNode>();

            foreach (var d in rootTreeNode)
            {

                GenerateTree(d, allData);
                result.Add(d);
            }

            return result.ToList();
        }

        private void GenerateTree(TheTreeNode node, List<Bse_Dict> allData)
        {
            var list = allData.Where(o => !string.IsNullOrEmpty(o.Dict_PCode) && o.Dict_PCode.ToUpper() == node.attr.id.ToUpper());

            node.children = (from d in list select new TheTreeNode { data = d.Dict_Name, attr = new Attr { id = d.Dict_Code } }).ToList();


            if (node.children.Count() == 0)
            {
                return;
            }

            foreach (var d in node.children)
            {
                GenerateTree(d, allData);
            }
        }


        /// <summary>
        /// 根据字典关键字获取其相关字典数据(层级与非层级)---添加编辑页面使用
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public IEnumerable<Bse_Dict> GetDictLevelByKey(string keyCode)
        {
            var key = keyCode.ToUpper();
            List<Bse_Dict> allData = GetDictListByKeyCodeNoRoot(key);
            List<Bse_Dict> root = instance.GetListByWhere(string.Format(" AND  Dict_Key='{0}' AND Dict_PCode is null", key));
            //IEnumerable<Bse_Dict> root = allData.Where(o => (string.IsNullOrEmpty(o.Dict_PCode) && o.Dict_Key.ToUpper() == key));
            foreach (var d in root)
            {
                GenerateChild(d, allData);
            }

            return root;
        }

        public bool Add(Bse_Dict model)
        {
            if (instance.Add(model) > 0)
            {
                return true;
            }

            return false;
        }

        public bool Update(Bse_Dict model)
        {
            if (instance.Update(model) > 0)
            {
                return true;
            }

            return false;
        }
        private void GenerateChild(Bse_Dict dict, List<Bse_Dict> allData)
        {
            dict.ChildDictList = allData.Where(o => o.Dict_PCode.ToUpper() == dict.Dict_Code.ToUpper());

            if (dict.ChildDictList.Count() == 0)
            {
                return;
            }

            foreach (var d in dict.ChildDictList)
            {
                GenerateChild(d, allData);
            }
        }


        //private void GenerateDictTree(List<Bse_Dict> list, List<Bse_Dict> allData, IEnumerable<Bse_Dict> parentNodes)
        //{
        //    if (parentNodes.Count() == 0)
        //    {
        //        return;
        //    }
        //    foreach (var d in parentNodes)
        //    {

        //        list.Add(d);
        //        GenerateDictTree(list, allData, allData.Where(o => o.Dict_PCode == d.Dict_Code));
        //    }
        //}  
    }
}
