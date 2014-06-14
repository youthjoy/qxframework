using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using QX.BLL;
using QX.Model;
using QX.Comm;
using QX.AOP;

namespace QX.Controllers.Controllers
{
    [ExceptionFillters]
    [ActionFillters]
    [ResultFillters]
    [QX.Cache.CompressFilter]
    [QX.Cache.CacheFilter(Duration = 120)]
    public class DictController : Controller
    {

        private Bll_Comm commInstance = new Bll_Comm();
        private Bll_Bse_Dict dictInstance = new Bll_Bse_Dict();
        //private Bll_WH_Material materialInstance = new Bll_WH_Material();

        private List<Bse_Dict> _TempDictList;
        private List<Bse_Dict> TempDictList
        {
            get
            {
                if (HttpContext.Session["TempDictList"] != null)
                {
                    _TempDictList = HttpContext.Session["TempDictList"] as List<Bse_Dict>;
                }
                else
                {
                    _TempDictList = new List<Bse_Dict>();

                }
                return _TempDictList;
            }
            set
            {
                _TempDictList = value;

                HttpContext.Session["TempDictList"] = TempDictList;
            }
        }

        //
        // GET: /Dict/

        /// <summary>
        /// 字典关键字
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public ActionResult Index(string id)
        {
            TempDictList = new List<Bse_Dict>();
            //字典信息列表
            ViewData["DictList"] = dictInstance.GetDictLevelByKey(id);
            ViewData["itype"] = !string.IsNullOrEmpty(id) ? id : "";
            //ViewData["IsLevel"] = model.Dict_Level;
            return View();
        }




        /// <summary>
        ///  //获取树节点信息列表
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        //[OutputCache(CacheProfile = "Dict_CacheConfig")]
        public ActionResult GetDictTreeData(string id)
        {
            var list = dictInstance.GetDictTreeByKey(id);
            return Json(list, JsonRequestBehavior.AllowGet);
        }

        /// <summary>
        /// 生成节点
        /// </summary>
        /// <param name="parentCode"></param>
        /// <returns></returns>
        public ActionResult CreateNode(string parentCode, string itype)
        {

            int order = 0;
            if (parentCode.Contains("temp"))
            {
                parentCode = parentCode.Split('_')[1];
            }
            var dictNode = dictInstance.GetModelByCode(parentCode, itype);

            string newCode = string.Empty;

            bool IsChildNode = false;
            //如果是根节点则可以添加
            if (dictNode.Dict_Order == 0)
            {
                IsChildNode = false;
                newCode = dictInstance.CreateDictNode(dictNode, IsChildNode, ref order);
            }//不是根节点则判断是否允许层级
            else
            {
                bool isLevel = dictInstance.IsAllowLevel(dictNode.Dict_Key);
                if (isLevel)
                {
                    IsChildNode = true;
                    newCode = dictInstance.CreateDictNode(dictNode, IsChildNode, ref order);
                }

            }

            if (!string.IsNullOrEmpty(newCode))
            {
                var model = new Bse_Dict()
                {
                    Dict_Code = newCode,
                    Dict_Key = dictNode.Dict_Key,
                    Dict_Order = order,
                    Dict_PCode = parentCode.ToUpper()
                };

                TempDictList.Add(model);
                return Json(new { Dict_Code = newCode, Dict_Key = dictNode.Dict_Key, Dict_Order = order, Dict_PCode = parentCode.ToUpper(), result = "success" });
            }
            else
            {
                return Json(new { result = "fail" });
            }
        }

        //获取节点信息
        public ActionResult GetNode(string nodeCode, string nodeKey)
        {
            Bse_Dict dict = new Bse_Dict();
            if (nodeCode.Contains("temp_"))
            {
                //var tmp = TempDictList.Where(o => o.Dict_Code == nodeCode.Split('_')[1]);
                //if (tmp.Count() > 0)
                //{
                //    dict = tmp.First();
                //}
                //else
                //{

                //}
                var newNodeCode = nodeCode.Split('_')[1];
                dict = dictInstance.GetModelByCode(newNodeCode, nodeKey);
            }
            else
            {
                dict = dictInstance.GetModelByCode(nodeCode, nodeKey);
            }

            var result = new JsonResult() { Data = new { result = "success", data = dict } };

            return result;
        }


        //public ActionResult DeleteNode(string code,string type)
        //{
        //    if (code.Contains("temp"))
        //    {
        //        code = code.Split('_')[1];
        //        TempDictList.Remove(TempDictList.Where(o => o.Dict_Code == code).First());
        //        return Json(new { result = "success" });
        //    }
        //    else
        //    {
        //        if (type == SPECDICT.MMTYPE.ToString())
        //        {
        //            var dictList=dictInstance.GetListByCode(" AND Dict_Key='"+type+"'");
        //            List<Bse_Dict> list = commInstance.DictTreeNoDepth(dictList, code);
        //            if (list.Count>1)
        //            {
        //                return Json(new { result = "fail", msg = "存在子类别，不能删除" });
        //            }

        //            var strCheck = "";
        //            foreach (var item in list)
        //            {
        //                strCheck += "'"+item.Dict_Code + "',";
        //            }
        //            strCheck = strCheck.TrimEnd(',');
        //            var CheckResult = materialInstance.GetListByCode(" AND MD_Group in (" + strCheck + ") ");
        //            if (CheckResult.Count>0)
        //            {
        //                return Json(new { result = "fail",msg="类别下存在物料，不能删除" });
        //            }
        //        }

        //        var Re=dictInstance.Delete(string.Format(" AND Dict_Code='{0}'", code));

        //        //添加日志
        //        this.OpLog(type, "删除:字典" + type + "中编码:" + code + "的数据", Re.ToString());

        //        if (Re)
        //        {
        //            return Json(new { result = "success" });
        //        }
        //        else
        //        {
        //            return Json(new { result = "fail" });
        //        }
        //    }              

        //}

        /// <summary>
        /// 添加和更新操作
        /// </summary>
        /// <param name="dict"></param>
        /// <returns></returns>
        public ActionResult DictOperation(Bse_Dict dict)
        {
            var flag = false;
            //如果Dict_ID 为0，则表示为添加
            if (dict.Dict_ID == 0)
            {
                //Bse_Dict PNode = dictInstance.GetModel(" AND Dict_Code='" + dict.Dict_PCode + "' AND Dict_Key='" + dict.Dict_Key + "'");
                var order = 0;
                //dict.Dict_Code = dictInstance.CreateDictNode(PNode, false, ref order);
                flag = dictInstance.Add(dict);
                TempDictList = new List<Bse_Dict>();
                //添加日志
                this.OpLog(dict.Dict_Key, "添加:编码:" + dict.Dict_Name + "数据", flag.ToString());
            }
            else
            {
                flag = dictInstance.Update(dict);
                //添加日志
                this.OpLog(dict.Dict_Key, "修改:编码:" + dict.Dict_Name + "数据", flag.ToString());
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

        public ActionResult DictList(string keyCode)
        {

            return View();
        }

        /// <summary>
        /// 获取字典节点信息列表
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        [OutputCache(CacheProfile = "Dict_CacheConfig")]
        public ActionResult GetNoLevelDictList(string key)
        {
            List<Bse_Dict> list = dictInstance.GetDictByKey(key).OrderBy(o => o.Dict_Order).ToList();
            var data = from d in list select new { Dict_Code = d.Dict_Code, Dict_Name = d.Dict_Name };
            var result = new JsonResult { Data = data, JsonRequestBehavior = JsonRequestBehavior.AllowGet };


            return result;
        }


        public ActionResult GetLevelDictList(string key)
        {
            //List<Bse_Dict> list = dictInstance.get(key);
            //var data = from d in list select new { Dict_Code = d.Dict_Code, Dict_Name = d.Dict_Name };
            //var result = new JsonResult { Data = data, JsonRequestBehavior = JsonRequestBehavior.AllowGet };
            //return result;
            return View();
        }

    }
}
