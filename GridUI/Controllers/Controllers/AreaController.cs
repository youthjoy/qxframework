using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using QX.Model;
using QX.HtmlHelperLib.JqGrid;
using QX.HtmlHelperLib;
using System.Text;
using System.Data;
using QX.Comm;
using Newtonsoft.Json;
using QX.Config;
using System.IO;

namespace QX.Controllers.Controllers
{
    public class AreaController : Controller
    {
        #region 操作句柄
        private BLL.Bll_Area aInstance = new QX.BLL.Bll_Area();
        private BLL.Bll_Comm comInstance = new QX.BLL.Bll_Comm();
        #endregion

        /// <summary>
        /// 监控数据显示列表
        /// </summary>
        /// <param name="id">数据源所属模块（用于显示模板）</param>
        /// <returns></returns>
        public ActionResult Index(string id)
        {
            ViewData["DictList"] = aInstance.GetLevelTreeForAreaWithPermission(SessionConfig.UserId());
            if (string.IsNullOrEmpty(id))
            {
                ViewData["Module"] = "Data_ActModule";
            }
            else
            {
                ViewData["Module"] = id;
            }
            return View();
        }

        /// <summary>
        /// 区域维护
        /// </summary>
        /// <returns></returns>
        public ActionResult Operation()
        {
            // var d=StringCompute.EvaluateSimpleexpression_r("10*10+2.1*10");
            ViewData["DictList"] = aInstance.GetLevelTreeForArea();
            return View();
        }

        /// <summary>
        /// 站点维护
        /// </summary>
        /// <returns></returns>
        public ActionResult StationOperation()
        {
            ViewData["DictList"] = aInstance.GetLevelTreeForArea();
            return View();
        }

        public ActionResult GetAreaTreeData()
        {
            var list = aInstance.GetAreaTree();
            return Json(list, JsonRequestBehavior.AllowGet);
        }

        /// <summary>
        /// 获取站点配置列表
        /// </summary>
        /// <param name="id">站点编码</param>
        /// <param name="page">页数</param>
        /// <param name="rows">所有数据行数</param>
        /// <param name="search"></param>
        /// <param name="sidx"></param>
        /// <param name="sord">排序</param>
        /// <returns></returns>
        public ActionResult GetStationConfigList(string id, int page, int rows, string search, string sidx, string sord)
        {

            string filters = Request["filters"] == null ? "" : Request["filters"].ToString();
            string filtersSql = "";
            if (!string.IsNullOrEmpty(filters))
            {
                filtersSql = BulidJqGridSearch.BuildSearch(filters);
            }

            //string 
            List<Bse_CheckValue> list = new List<Bse_CheckValue>();
            if (string.IsNullOrEmpty(id))
            {

            }
            if (string.IsNullOrEmpty(filtersSql))
            {
                list = aInstance.GetConfigByStaion(id, "1=1");
            }
            else
            {
                list = aInstance.GetConfigByStaion(id, filtersSql);
            }


            var model = list.AsQueryable<Bse_CheckValue>();
            var result = JsonConvert.SerializeObject(model.ToJqGridData(page, rows, null, search, null), new JsonDateConverter("yyyy-MM-dd"));

            return JavaScript(result);
        }

        /// <summary>
        /// 获取模板配置明细
        /// </summary>
        /// <param name="id"></param>
        /// <param name="page"></param>
        /// <param name="rows"></param>
        /// <param name="search"></param>
        /// <param name="sidx"></param>
        /// <param name="sord"></param>
        /// <returns></returns>
        public ActionResult GetStConfigTemplateList(string id, int page, int rows, string search, string sidx, string sord)
        {

            string filters = Request["filters"] == null ? "" : Request["filters"].ToString();
            string filtersSql = "";

            if (!string.IsNullOrEmpty(filters))
            {
                filtersSql = BulidJqGridSearch.BuildSearch(filters);
            }

            //string 
            List<Bse_CheckValue> list = new List<Bse_CheckValue>();
            if (string.IsNullOrEmpty(id))
            {

            }
            else
            {
                if (string.IsNullOrEmpty(filtersSql))
                {
                    list = aInstance.GetTemplateFieldLst(id, "1=1");
                }
                else
                {
                    list = aInstance.GetTemplateFieldLst(id, filtersSql);
                }
            }

            var model = list.AsQueryable<Bse_CheckValue>();
            var result = JsonConvert.SerializeObject(model.ToJqGridData(page, rows, null, search, null), new JsonDateConverter("yyyy-MM-dd"));

            return JavaScript(result);
        }

        /// <summary>
        /// 站点配置页面
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public ActionResult StationConfig(string id)
        {
            ViewData["StationCode"] = id;
            var model = aInstance.GetStationByCode(id);
            return View(model);
        }

        /// <summary>
        /// 站点配置模板表
        /// </summary>
        /// <returns></returns>
        public ActionResult SConfigTemplate()
        {
            ViewData["DictList"] = aInstance.GetLevelTreeForConfig();
            return View();
        }


        /// <summary>
        /// 获取区域节点数据
        /// </summary>
        /// <param name="nodeCode">区域编码</param>
        /// <returns></returns>
        public ActionResult GetNode(string nodeCode)
        {
            Bse_Area dict = new Bse_Area();

            if (nodeCode.Contains("temp_"))
            {

                var newNodeCode = nodeCode.Split('_')[1];
                dict = aInstance.GetModel(string.Format("AND Area_Code='{0}'", newNodeCode));
            }
            else
            {
                dict = aInstance.GetModel(string.Format("AND Area_Code='{0}'", nodeCode));
            }

            var result = new JsonResult() { Data = new { result = "success", data = dict } };

            return result;
        }

        /// <summary>
        /// 区域维护（submit）
        /// </summary>
        /// <param name="dict">区域实体数据源</param>
        /// <returns></returns>
        public ActionResult AreaOperation(Bse_Area dict)
        {
            var flag = false;
            //如果Dict_ID 为0，则表示为添加
            if (dict.Area_ID == 0)
            {
                //Bse_Dict PNode = dictInstance.GetModel(" AND Dict_Code='" + dict.Dict_PCode + "' AND Dict_Key='" + dict.Dict_Key + "'");

                //dict.Dict_Code = dictInstance.CreateDictNode(PNode, false, ref order);
                flag = aInstance.Add(dict);

                //权限点插入
                aInstance.SynFunction(dict);
            }
            else
            {
                flag = aInstance.Update(dict);
                //权限点插入
                aInstance.SynFunction(dict);
            }

            if (flag)
            {
                return Json(new { result = "success", target = dict });
            }
            else
            {
                return Json(new { result = "fail" });
            }

            //return View();
        }

        /// <summary>
        /// 站点维护
        /// </summary>
        /// <param name="dict">站点实体数据源</param>
        /// <returns>数据更新结果（失败OR成功）</returns>
        public ActionResult SOperation(Bse_Station dict)
        {
            var flag = false;
            //如果Dict_ID 为0，则表示为添加
            if (dict.SN_ID == 0)
            {
                flag = aInstance.AddStation(dict);
                //权限点插入
                aInstance.SynFunction(dict);
            }
            else
            {
                flag = aInstance.UpdateStation(dict);
                //权限点插入
                aInstance.SynFunction(dict);
            }

            if (flag)
            {
                return Json(new { result = "success", target = dict });
            }
            else
            {
                return Json(new { result = "fail" });
            }

        }

        /// <summary>
        /// 读取模板数据
        /// </summary>
        /// <param name="statcode"></param>
        /// <param name="module"></param>
        /// <returns></returns>
        public ActionResult LoadTemplate(string statcode, string module)
        {
            ///获取该模板相关配置字段
            List<Bse_CheckValue> list = aInstance.GetTemplateFieldLst(module, "1=1");

            var flag = aInstance.ImportConfig(statcode, module, list);

            if (flag)
            {
                return Json(new { result = "success" });
            }
            else
            {
                return Json(new { result = "fail" });
            }
        }

        /// <summary>
        /// 获取站点配置模板
        /// </summary>
        /// <returns></returns>
        public ActionResult GetTemplateList()
        {
            List<Bse_CheckValue> list = new List<Bse_CheckValue>();
            list = aInstance.GetTemplateMainList("1=1");
            return Json(list);
        }

        /// <summary>
        /// 数据源显示配置模板维护
        /// </summary>
        /// <param name="dict">配置数据实体</param>
        /// <returns></returns>
        public ActionResult TemplateOperation(Bse_CheckValue dict)
        {
            var flag = false;
            //如果Dict_ID 为0，则表示为添加
            if (dict.SC_ID == 0)
            {
                flag = aInstance.AddConfig(dict);
                //if (flag)
                //{
                //    comInstance.UpdateSysConfig(dict.SC_StationCode, dict.SC_Source, dict);
                //}
            }
            else
            {
                flag = aInstance.UpdateConfig(dict);
                try
                {
                    if (flag)
                    {
                        comInstance.UpdateSysConfig(dict.SC_StationCode, dict.SC_Source, dict);
                    }
                }
                catch (Exception ex)
                {
                    return Json(new { result = "fail",Msg="更新失败!" });   
                }
            }

            if (flag)
            {
                return Json(new { result = "success", target = dict });
            }
            else
            {
                return Json(new { result = "fail" });
            }

        }

        /// <summary>
        /// 创建区域节点
        /// </summary>
        /// <param name="parentCode"></param>
        /// <param name="itype"></param>
        /// <returns></returns>
        public ActionResult CreateNode(string parentCode, string itype)
        {

            int order = 0;
            if (parentCode.Contains("temp"))
            {
                parentCode = parentCode.Split('_')[1];
            }
            var dictNode = aInstance.GetModelByCode(parentCode);

            string newCode = string.Empty;


            newCode = aInstance.GenerateCode();


            if (!string.IsNullOrEmpty(newCode))
            {
                var model = new Bse_Area()
                {
                    Area_Code = newCode,
                    Area_PCode = parentCode,
                    Area_PName = dictNode.Area_Name
                };

                return Json(model);
            }
            else
            {
                return Json(new { result = "fail" });
            }
        }

        /// <summary>
        /// 单站点数据显示
        /// </summary>
        /// <param name="id">站点编码</param>
        /// <returns></returns>
        public ActionResult StationAct(string id)
        {
            ViewData["Station"] = id;
            return View();
        }

        /// <summary>
        /// 站点环境配置页面
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public ActionResult StationMark(string id)
        {
            ViewData["Station"] = id;
            return View();
        }

        /// <summary>
        /// 多站点数据对比图表
        /// </summary>
        /// <param name="id">站点列表（,进行多个站点间分隔）</param>
        /// <returns></returns>
        public ActionResult StationChart(string id)
        {
            ViewData["Stations"] = id;
            if (Request["sname"] != null)
            {
                ViewData["SName"] = Request["sname"];
            }
            return View();
        }

        /// <summary>
        /// 获取监控数据
        /// </summary>
        /// <param name="id">区域编码</param>
        /// <param name="page"></param>
        /// <param name="rows"></param>
        /// <param name="search"></param>
        /// <param name="sidx"></param>
        /// <param name="sord"></param>
        /// <returns></returns>
        public ActionResult GetStationDataList(string id, int page, int rows, string search, string sidx, string sord)
        {

            string filter = Request["filters"] != null ? Request["filters"] : "";
            string filterSql = "";
            if (!string.IsNullOrEmpty(filter))
            {
                filterSql = filter.BuildSearch("Data_ActModule");
            }

            //未过滤权限
            if (string.IsNullOrEmpty(filterSql))
            {
                filterSql = "1=1";
            }
            if (string.IsNullOrEmpty(id))
            {
                DataTable dt = aInstance.GetStationTable("area", filterSql);


                var json = SConfigHelper.JsonForJqgridForRpt("Data_ActModule", dt, page, rows, dt.Rows.Count);
                return JavaScript(json);
            }
            else
            {

                DataTable dt = aInstance.GetStationTable(id, filterSql);

                var json =SConfigHelper.JsonForJqgridForRpt("Data_ActModule", dt, page, rows, dt.Rows.Count);
                return JavaScript(json);
            }

        }

        /// <summary>
        /// 获取站点列表
        /// </summary>
        /// <param name="id"></param>
        /// <param name="page"></param>
        /// <param name="rows"></param>
        /// <param name="search"></param>
        /// <param name="sidx"></param>
        /// <param name="sord"></param>
        /// <returns></returns>
        public ActionResult GetStationList(string id, int page, int rows, string search, string sidx, string sord)
        {
            string filter = Request["filters"] != null ? Request["filters"] : "";
            string filterSql = "";
            if (!string.IsNullOrEmpty(filter))
            {
                filterSql = filter.BuildSearch("Bse_StationModule");
                //filterSql = BulidJqGridSearch.BuildSearch(filter);
            }
            List<Bse_Station> list = new List<Bse_Station>();
            if (string.IsNullOrEmpty(id))
            {
                if (string.IsNullOrEmpty(filterSql))
                {
                    list = aInstance.GetStationList("1=1");
                }
                else
                {
                    list = aInstance.GetStationList(filterSql);
                }
            }
            else
            {
                if (string.IsNullOrEmpty(filterSql))
                {
                    list = aInstance.GetStationListByWhere(id, "1=1");
                }
                else
                {
                    list = aInstance.GetStationListByWhere(id, filterSql);
                }
            }

            var model = list.AsQueryable<Bse_Station>();
            var result = model.ToJqGridData(page, rows, null, search, null);
            return Json(result, JsonRequestBehavior.AllowGet);
        }

        /// <summary>
        /// 图片上传
        /// </summary>
        /// <param name="qqfile"></param>
        /// <returns></returns>
        public ActionResult Upload(string qqfile)
        {
           // var fileType = Request["typeParam"];
            //string cate = Request["Cate"];
            //string key = Request["DictKey"];

            var path = string.Empty;
            string catepath = string.Empty;
            string finalPath = string.Empty;


          

            //switch (fileType)
            //{
            //    case "File":
            //        path = System.Configuration.ConfigurationSettings.AppSettings["File"];

            //        break;
            //    case "Comp":
            //        path = System.Configuration.ConfigurationSettings.AppSettings["Comp"];
            //        break;
            //    case "Doc":
            //    default:
            //        path = System.Configuration.ConfigurationSettings.AppSettings["Doc"];
            //        break;
            //}
            path = Server.MapPath("~/Upload/");
            finalPath = path ;

            string file = FileUpload.UploadFile(qqfile, finalPath, System.Web.HttpContext.Current);

            if (string.IsNullOrEmpty(file))
            {
                return Json(new { result = "fail", message = "上传失败!" }, "text/html");
            }

            return Json(new { result = "success", path = file, message = "成功" }, "text/html");

        }

        /// <summary>
        /// 上传站点配置图片回调函数（处理上传后的处理逻辑）
        /// </summary>
        /// <param name="code">站点编码</param>
        /// <param name="path">路径</param>
        /// <returns></returns>
        public ActionResult UploadImgMark(string code, string path)
        {
            if (!string.IsNullOrEmpty(code))
            {
                Bse_StationMark model = aInstance.GetMarkModel(string.Format("AND Sta_StationCode='{0}' AND Sta_Type='Main'", code));
                model.Sta_Background = path;
                aInstance.UpdateStationMark(model);
                return Json(new { result = "success", message = "成功" }, "text/html");
            }
            else
            {
                return Json(new { result = "fail", message = "失败" }, "text/html");
            }
        }

        /// <summary>
        /// 获取环境配置列表
        /// </summary>
        /// <param name="id">站点编码</param>
        /// <param name="page"></param>
        /// <param name="rows"></param>
        /// <param name="search"></param>
        /// <param name="sidx"></param>
        /// <param name="sord"></param>
        /// <returns></returns>
        public ActionResult GetMarkList(string id, int page, int rows, string search, string sidx, string sord)
        {
            string filter = Request["filters"] != null ? Request["filters"] : "";
            string filterSql = "";
            if (!string.IsNullOrEmpty(filter))
            {
                filterSql = filter.BuildSearch("Bse_StationMarkModule");
                //filterSql = BulidJqGridSearch.BuildSearch(filter);
            }
            List<Bse_StationMark> list = new List<Bse_StationMark>();

            if (string.IsNullOrEmpty(filterSql))
            {
                list = aInstance.GetStationMark(id, "AND 1=1");
            }
            else
            {
                list = aInstance.GetStationMark(id, "AND " + filterSql);
            }


            var model = list.AsQueryable<Bse_StationMark>();
            var result = model.ToJqGridData(page, rows, null, search, null);
            return Json(result, JsonRequestBehavior.AllowGet);
        }

    }
}
