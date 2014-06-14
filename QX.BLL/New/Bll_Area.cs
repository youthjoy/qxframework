using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using QX.Model;
using QX.DAL;
using System.Data;
using QX.Comm.Utils;
using QX.Config;
namespace QX.BLL
{
    public class Bll_Area
    {
        private ADOBse_Area aInstance = new ADOBse_Area();
        private ADOBse_Station sInstance = new ADOBse_Station();
        private Bll_Comm commInstance = new Bll_Comm();
        private ADOBse_CheckValue cInstance = new ADOBse_CheckValue();
        private ADOSys_Function fInstance = new ADOSys_Function();
        private ADOBse_StationMark mInstance = new ADOBse_StationMark();

        #region 区域和站点 树数据源

        public IEnumerable<AreaTreeNode> GetLevelTree()
        {
            var area = aInstance.GetAll();
            var station = sInstance.GetAll();
            IEnumerable<AreaTreeNode> allArea = from p in area select new AreaTreeNode() { Name = p.Area_Name, Code = p.Area_Code, PCode = p.Area_PCode, State = "0" };
            IEnumerable<AreaTreeNode> allStation = from p in station select new AreaTreeNode() { Name = p.SN_Name, Code = p.SN_Code, PCode = p.SN_AreaCode, State = "1" };
            List<AreaTreeNode> allData = allArea.Union(allStation).ToList();
            List<AreaTreeNode> root = allData.Where(o => string.IsNullOrEmpty(o.PCode) || o.PCode == "root").ToList();
            foreach (var a in root)
            {
                GenerateChild(a, allData);
            }

            return root;
        }


        private void GenerateChild(AreaTreeNode dict, List<AreaTreeNode> allData)
        {
            dict.ChildList = allData.Where(o => o.PCode == dict.Code);

            if (dict.ChildList.Count() == 0)
            {
                return;
            }

            foreach (var d in dict.ChildList)
            {
                GenerateChild(d, allData);
            }
        }
        #endregion

        #region 区域  树数据源

        public IEnumerable<AreaTreeNode> GetLevelTreeForArea()
        {
            var area = aInstance.GetAll();
            var station = sInstance.GetAll();
            IEnumerable<AreaTreeNode> allArea = from p in area select new AreaTreeNode() { Name = p.Area_Name, Code = p.Area_Code, PCode = p.Area_PCode, State = "0" };

            //IEnumerable<AreaTreeNode> allStation = from p in station select new AreaTreeNode() { Name = p.SN_Name, Code = p.SN_Code, PCode = p.SN_AreaCode, State = "1" };
            List<AreaTreeNode> allData = allArea.ToList();
            List<AreaTreeNode> root = allData.Where(o => string.IsNullOrEmpty(o.PCode) || o.PCode == "root").ToList();
            foreach (var a in root)
            {
                GenerateChildForArea(a, allData);
            }

            return root;
        }

        public IEnumerable<TheTreeNode> GetAreaTree()
        {
           // var area = aInstance.GetAll();
           //// var station = sInstance.GetAll();
           // IEnumerable<TheTreeNode> allArea = from t in area select new TheTreeNode { data = t.Area_Name, attr = new Attr { id = t.Area_Code } };
            
           // //IEnumerable<AreaTreeNode> allStation = from p in station select new AreaTreeNode() { Name = p.SN_Name, Code = p.SN_Code, PCode = p.SN_AreaCode, State = "1" };
           // List<Bse_Area> allData = area.ToList();
           // List<TheTreeNode> root = allData.Where(o => string.IsNullOrEmpty(o.PCode) || o.PCode == "root").ToList();
           // foreach (var a in root)
           // {
           //     GenerateAreaTree(a, allData);
           // }

           // return root;


           // var key = keyCode.ToUpper();
            List<Bse_Area> allData = aInstance.GetAll();

            //IEnumerable<Bse_Area> temp = allData.Where(o => (string.IsNullOrEmpty(o.Dict_PCode) && o.Dict_Key.ToUpper() == key));
            IEnumerable<TheTreeNode> rootTreeNode = from t in allData where string.IsNullOrEmpty(t.Area_PCode) select new TheTreeNode { data = t.Area_Name, attr = new Attr { id = t.Area_Code } };

            List<TheTreeNode> result = new List<TheTreeNode>();

            foreach (var d in rootTreeNode)
            {

                GenerateAreaTree(d, allData);
                result.Add(d);
            }

            return result.ToList();
        }

        private void GenerateAreaTree(TheTreeNode node, List<Bse_Area> allData)
        {
            var list = allData.Where(o => !string.IsNullOrEmpty(o.Area_PCode) && o.Area_PCode.ToUpper() == node.attr.id.ToUpper());

            node.children = (from d in list select new TheTreeNode { data = d.Area_Name, attr = new Attr { id = d.Area_Code } }).ToList();


            if (node.children.Count() == 0)
            {
                return;
            }

            foreach (var d in node.children)
            {
                GenerateAreaTree(d, allData);
            }
        }

        BLL.Bll_Sys_UserPermission pInstance = new Bll_Sys_UserPermission();

        /// <summary>
        /// 根据权限过滤可以操作的区域
        /// </summary>
        /// <param name="uCode"></param>
        /// <returns></returns>
        public IEnumerable<AreaTreeNode> GetLevelTreeForAreaWithPermission(string uCode)
        {
            List<Sys_UserPermission> plist = pInstance.GetUserPermissionForArea(uCode);

            var areas = plist.Where(o => o.Fun_iType == "Area");

            IEnumerable<AreaTreeNode> allArea = from p in areas select new AreaTreeNode() { Name = p.PU_FunName, Code = p.PU_FunCode, PCode = p.PU_FunPCode, State = "0" };

            List<AreaTreeNode> allData = allArea.ToList();


            List<AreaTreeNode> root = allData.Where(o => string.IsNullOrEmpty(o.PCode) || o.PCode == "root").ToList();
            foreach (var a in root)
            {
                GenerateChildForArea(a, allData);
            }

            return root;
        }


        private void GenerateChildForArea(AreaTreeNode dict, List<AreaTreeNode> allData)
        {
            dict.ChildList = allData.Where(o => o.PCode == dict.Code);

            if (dict.ChildList.Count() == 0)
            {
                return;
            }

            foreach (var d in dict.ChildList)
            {
                GenerateChild(d, allData);
            }
        }

        #endregion

        #region 站点模板

        public IEnumerable<AreaTreeNode> GetLevelTreeForConfig()
        {
            List<Bse_CheckValue> list = new List<Bse_CheckValue>();
            list = GetTemplateMainList("1=1");
            IEnumerable<AreaTreeNode> allArea = from p in list select new AreaTreeNode() { Name = p.SC_StatName, Code = p.SC_StationCode, PCode = "", State = "0" };

            List<AreaTreeNode> allData = allArea.ToList();

            return allData;
        }

        #endregion

        /// <summary>
        /// 获取站点配置信息
        /// </summary>
        /// <param name="code"></param>
        /// <param name="filter"></param>
        /// <returns></returns>
        public List<Bse_CheckValue> GetConfigByStaion(string code, string filter)
        {
            string where = string.Format("AND SC_StationCode='{0}' AND {1}", code, filter);
            return cInstance.GetListByWhere(where);
        }



        /// <summary>
        /// 获取配置模板
        /// </summary>
        /// <param name="where"></param>
        /// <returns></returns>
        public List<Bse_CheckValue> GetTemplateMainList(string where)
        {
            return cInstance.GetListByWhere(string.Format(" AND SC_iType='{0}' AND {1}", "Main", where));
        }

        /// <summary>
        /// 获取配置模板明细
        /// </summary>
        /// <param name="where"></param>
        /// <returns></returns>
        public List<Bse_CheckValue> GetTemplateFieldLst(string tpl, string where)
        {
            return cInstance.GetListByWhere(string.Format(" AND SC_iType='{0}' AND SC_StationCode='{1}' AND {2}", "Template", tpl, where));
        }

        /// <summary>
        /// 获取配置实体
        /// </summary>
        /// <param name="code"></param>
        /// <returns></returns>
        public Bse_CheckValue GetSConfigModel(string code)
        {
            return cInstance.GetListByWhere(string.Format("AND SC_Code='{0}'", code)).FirstOrDefault();
        }

        /// <summary>
        /// 获取站点列表
        /// </summary>
        /// <param name="area"></param>
        /// <param name="where"></param>
        /// <returns></returns>
        public List<Bse_Station> GetStationListByWhere(string area, string where)
        {
            StringBuilder sb = new StringBuilder();
            var list = GetLevelAreaListWidthSeft(area, sb);

            List<Bse_Station> slist = new List<Bse_Station>();
            string filter = string.Format("AND SN_AreaCode in({0}) AND {1}", sb.ToString().TrimEnd(','), where);
            slist = sInstance.GetListByWhere(filter);
            return slist;

        }

        /// <summary>
        /// 根据权限获取站点列表
        /// </summary>
        /// <param name="area"></param>
        /// <param name="where"></param>
        /// <returns></returns>
        public List<Bse_Station> GetStationListByPermission(string area, string where)
        {
            List<Sys_UserPermission> plist = pInstance.GetUserPermissionForArea(SessionConfig.UserId());

            StringBuilder sb = new StringBuilder();
            var tlist = GetLevelAreaListWidthSeft(area, sb);
            List<Bse_Station> list = new List<Bse_Station>();
            foreach (var d in list)
            {
                if (plist.Exists(o => o.PU_FunCode == d.SN_Code))
                {
                    list.Add(d);
                }
            }

            List<Bse_Station> slist = new List<Bse_Station>();
            string filter = string.Format("AND SN_AreaCode in({0}) AND {1}", sb.ToString().TrimEnd(','), where);
            slist = sInstance.GetListByWhere(filter);
            return slist;

        }

        /// <summary>
        /// 获取层级区域列表
        /// </summary>
        /// <param name="code"></param>
        /// <param name="sb"></param>
        /// <returns></returns>
        public List<Bse_Area> GetLevelAreaListWidthSeft(string code, StringBuilder sb)
        {
            List<Bse_Area> allArea = aInstance.GetAll();

            List<Bse_Area> list = new List<Bse_Area>();
            var model = allArea.FirstOrDefault(o => o.Area_Code == code);
            list.Add(model);
            sb.AppendFormat("'{0}',", model.Area_Code);
            var temp = allArea.Where(o => o.Area_PCode == code).ToList();
            foreach (var d in temp)
            {
                list.Add(d);
                sb.AppendFormat("'{0}',", d.Area_Code);
                GenerateArea(list, allArea, allArea.Where(o => o.Area_PCode == d.Area_Code), sb);
            }

            return list;
        }

        /// <summary>
        /// 递归
        /// </summary>
        /// <param name="list"></param>
        /// <param name="allData"></param>
        /// <param name="childList"></param>
        /// <param name="sb"></param>
        public void GenerateArea(List<Bse_Area> list, List<Bse_Area> allData, IEnumerable<Bse_Area> childList, StringBuilder sb)
        {

            if (childList.Count() == 0)
            {

                return;
            }

            foreach (var d in childList)
            {
                list.Add(d);
                sb.AppendFormat("'{0}',", d.Area_Code);
                GenerateArea(list, allData, allData.Where(o => o.Area_PCode == d.Area_Code), sb);
            }

        }
        /// <summary>
        /// 获取监控显示数据（进行数据转换）
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public DataTable GetStationTable(string id, string where)
        {
            StringBuilder sb = new StringBuilder();

            List<Bse_Station> slist = GetStationListByWhere(id, "1=1");

            //如果该区域没有任何站点则直接返回空数据集
            if (slist.Count == 0)
            {

                Dictionary<string, object> dict = new Dictionary<string, object>();
                dict.Add("Area", "'NoArea'");
                dict.Add("Filter", where);
                var dt = sInstance.GetStationsData(dict);
                return dt;
            }
            //用户拥有的权限
            List<Sys_UserPermission> plist = pInstance.GetUserPermissionWithRole(SessionConfig.UserId());

            var stlist =  plist.Where(o => o.Fun_iType == "Station");

            //进行权限过滤
            foreach (var s in slist)
            {
                if (stlist.FirstOrDefault(o => o.PU_FunCode == s.SN_Code) != null)
                {
                    sb.AppendFormat("'{0}',", s.SN_Code);
                }
            }

            //如果用户没有权限查看站点则设置默认条件
            if (sb.Length == 0)
            {
                sb.Append("'NoPermission'");
            }

            string stations = sb.ToString().TrimEnd(',');

            Dictionary<string, object> list = new Dictionary<string, object>();
            list.Add("Area", stations);
            list.Add("Filter", where);

            var datatable = sInstance.GetStationsData(list);

            ///站点的配置参数
            List<Bse_CheckValue> clist = new List<Bse_CheckValue>();
            clist = cInstance.GetListByWhere(string.Format(" AND SC_StationCode in({0})", stations));

            foreach (DataRow r in datatable.Rows)
            {

                //对应列的数据显示配置
                var ds = clist.Where(o => o.SC_StationCode == r["Data_StationCode"].ToString());
                //有配置的数据显示
                foreach (var d in ds)
                {
                    if (d != null)
                    {
                        var index = TypeConverter.ObjectToInt(d.SC_Position);
                        if (!string.IsNullOrEmpty(d.SC_Rate))
                        {
                            try
                            {
                                object temp = r["Data_Val" + index];
                                var re = d.SC_Rate.Replace("{val}", temp.ToString());
                                var result = Comm.StringCompute.EvaluateSimpleexpression_r(re);
                                r["Data_Val" + index] = result;
                            }
                            catch (Exception ex)
                            {
                                //日志
                            }
                        }

                        r["Data_W" + index.ToString()] = d.SC_Warn;

                        r["Data_A" + index.ToString()] = d.SC_Alarm;
                    }
                }

            }

            return datatable;
        }

        public List<Bse_Station> GetStationList(string where)
        {
            return sInstance.GetListByWhere(string.Format("And {0}", where));
        }

        /// <summary>
        /// 获取站点环境配置详细列表
        /// </summary>
        /// <param name="id"></param>
        /// <param name="where"></param>
        /// <returns></returns>
        public List<Bse_StationMark> GetStationMark(string id, string where)
        {
            return mInstance.GetListByWhere(string.Format("AND isnull(Sta_Type,'')<>'{2}' And Sta_StationCode='{0}' {1}", id, where, "Main"));

        }

        public bool AddStationMark(Bse_StationMark model)
        {
            if (mInstance.Add(model) > 0)
            {
                return true;
            }

            return false;
        }

        public bool UpdateStationMark(Bse_StationMark model)
        {
            if (mInstance.Update(model) > 0)
            {
                return true;
            }

            return false;
        }

        public Bse_StationMark GetMarkModel(string where)
        {
            return mInstance.GetListByWhere(where).FirstOrDefault();
        }


        public string GenerateConfigCode()
        {
            return commInstance.GetTableKeyCode("Bse_CheckValue");
        }

        public bool ImportConfig(string stationcode, string module, List<Bse_CheckValue> list)
        {
            Bse_Station station = GetStationByCode(stationcode);
            var oldlist = cInstance.GetListByWhere(string.Format("AND SC_StationCode='{0}'", stationcode));
            if (oldlist.Count != 0)
            {
                if (oldlist.FirstOrDefault().SC_RefCode != module)
                {
                   // var temp = oldlist.ToList();
                    foreach (var d in oldlist)
                    {
                        d.Stat = 1;
                        UpdateConfig(d);

                    }
                      
                    oldlist.Clear();
                }
            }

            foreach (var b in list)
            {
                if (oldlist.FirstOrDefault(o => o.SC_Source == b.SC_Source) != null)
                {
                    continue;
                }
                b.SC_StationCode = station.SN_Code;
                b.SC_StatName = station.SN_Name;
                b.SC_RefCode = module;
                b.SC_iType = string.Empty;
                b.SC_Code = GenerateConfigCode();
                AddConfig(b);
            }

            return true;
        }



        /// <summary>
        /// 获取区域实体
        /// </summary>
        /// <param name="where"></param>
        /// <returns></returns>
        public Bse_Area GetModel(string where)
        {
            return aInstance.GetListByWhere(where).FirstOrDefault();
        }

        public Bse_Station GetStation(string where)
        {
            return sInstance.GetListByWhere(where).FirstOrDefault();
        }

        public Bse_Station GetStationByCode(string code)
        {
            return GetStation(string.Format("AND SN_Code='{0}'", code));
        }
        #region bse_checkvalue 增删改
        public bool AddConfig(Bse_CheckValue model)
        {
            if (cInstance.Add(model) > 0)
            {
                return true;
            }

            return false;
        }



        public bool UpdateConfig(Bse_CheckValue model)
        {
            if (cInstance.Update(model) > 0)
            {
                return true;
            }

            return false;
        }

        public bool DeleteConfig(Bse_CheckValue model)
        {
            model.Stat = 1;
            if (cInstance.Update(model) > 0)
            {
                return true;
            }

            return false;
        }
        #endregion

        #region area 增删改
        public bool Add(Bse_Area model)
        {
            if (aInstance.Add(model) > 0)
            {
                return true;
            }

            return false;
        }



        public bool Update(Bse_Area model)
        {
            if (aInstance.Update(model) > 0)
            {
                return true;
            }

            return false;
        }

        public bool Delete(Bse_Area model)
        {
            model.Stat = 1;
            if (aInstance.Update(model) > 0)
            {
                return true;
            }

            return false;
        }
        #endregion

        #region station 增删改
        public bool AddStation(Bse_Station model)
        {
            if (sInstance.Add(model) > 0)
            {
                return true;
            }

            return false;
        }


        public bool UpdateStation(Bse_Station model)
        {
            if (sInstance.Update(model) > 0)
            {
                return true;
            }

            return false;
        }
        #endregion


        /// <summary>
        /// 权限点同步
        /// </summary>
        public void SynFunction(Bse_Station station)
        {
            var model = fInstance.GetListByWhere(string.Format("AND Fun_Code='{0}' AND Fun_PCode='{1}'", station.SN_Code, station.SN_AreaCode)).FirstOrDefault();
            if (model == null)
            {
                Sys_Function function = new Sys_Function();
                function.Fun_Code = station.SN_Code;
                function.Fun_Name = station.SN_Name;
                function.Fun_PCode = station.SN_AreaCode;
                function.Fun_PName = station.SN_AreaName;
                function.Fun_iType = "Station";
                fInstance.Add(function);
            }
            else
            {
                model.Fun_Name = station.SN_Name;
                fInstance.Update(model);
            }
        }

        public void SynFunction(Bse_Area area)
        {

            var model = fInstance.GetListByWhere(string.Format("AND Fun_Code='{0}' AND Fun_PCode='{1}'", area.Area_Code, area.Area_PCode)).FirstOrDefault();
            if (model == null)
            {
                Sys_Function fun = new Sys_Function();
                fun.Fun_Code = area.Area_Code;
                fun.Fun_Name = area.Area_Name;
                fun.Fun_PCode = area.Area_PCode;
                fun.Fun_PName = area.Area_PName;
                fun.Fun_iType = "Area";
                fInstance.Add(fun);
            }
            else
            {
                model.Fun_Name = area.Area_Name;
                fInstance.Update(model);
            }

        }



        public string GenerateCode()
        {
            return commInstance.GetTableKeyCode("Bse_Area");
        }

        public Bse_Area GetModelByCode(string code)
        {
            return GetModel(string.Format("AND Area_Code='{0}'", code));
        }
    }
}
