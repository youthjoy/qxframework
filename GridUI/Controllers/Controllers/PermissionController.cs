using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using QX.Config;
using QX.Model;
using QX.Comm;
using QX.HtmlHelperLib;
using QX.HtmlHelperLib.JqGrid;
using Newtonsoft.Json;


namespace QX.Controllers.Controllers
{
    public class PermissionController : Controller
    {
        BLL.Bll_Sys_Role rInstance = new QX.BLL.Bll_Sys_Role();
        BLL.Bll_HR_Stuff hrInstance = new BLL.Bll_HR_Stuff();
        BLL.Bll_HR_Department deptInstance = new QX.BLL.Bll_HR_Department();
        BLL.Bll_Sys_Function fInstance = new QX.BLL.Bll_Sys_Function();
        BLL.Bll_Sys_UserPermission upInstance = new QX.BLL.Bll_Sys_UserPermission();
        // GET: /Permission/

        /// <summary>
        /// 权限分配页面
        /// </summary>
        /// <returns></returns>
        public ActionResult Index()
        {
            string id = Request.QueryString["id"];

            ViewData["DeptList"] = deptInstance.GetChildListDept().ToList();

            return View();
        }

        public ActionResult StuffCate()
        {

            ViewData["DictList"] = deptInstance.GetChildListDept();
            return View();
        }

        /// <summary>
        /// 生成节点
        /// </summary>
        /// <param name="parentCode"></param>
        /// <returns></returns>
        public ActionResult CreateNode(string parentCode, string itype)
        {
            if (parentCode.Contains("temp"))
            {
                parentCode = parentCode.Split('_')[1];
            }
            HR_Department model = new HR_Department();
            model.Dept_PCode = parentCode;
            model.Dept_Code = deptInstance.GenerateDeptCode();
            return new JsonResult() { Data = new { result = "success", data = model } };
        }

        public ActionResult DeleteNode(string code)
        {
            var model = deptInstance.GetModel(string.Format("AND Dept_Code='{0}'", code));
            model.Stat = 1;
            bool s = deptInstance.UpdateDept(model);

            //日志记录
            this.OpLog(this.GetControllerName(), "删除:部门信息,编码:" + code, s.ToString());
            if (s)
            {
                return Json(new { result = "success", msg = "删除成功" });
            }
            return Json(new { result = "fail", msg = "删除异常" });
        }

        public ActionResult StuffOperation(HR_Stuff model)
        {
            var flag = false;
            //如果Dict_ID 为0，则表示为添加
            if (model.Stuff_ID == 0)
            {
                var temp = hrInstance.GetModel(string.Format(" AND Stuff_UserName='{0}'", model.Stuff_UserName));
                if (temp != null)
                {
                    return Json(new { result = "fail",Msg="当前用户名已存在，请确认!" }); 
                }

                model.Stuff_Password = Md5.MD5(model.Stuff_Password);
                flag = hrInstance.Add(model);
            }
            else
            {
                var oldstuff = hrInstance.GetModel(string.Format("AND Stuff_Code='{0}'", model.Stuff_Code));
                var temp = hrInstance.GetModel(string.Format(" AND Stuff_UserName='{0}'", model.Stuff_UserName));
                if (temp != null&&oldstuff.Stuff_UserName!=temp.Stuff_UserName)
                {
                    return Json(new { result = "fail", Msg = "当前用户名已存在，请确认!" });
                }

                if (!string.IsNullOrEmpty(model.Stuff_Password))
                {
                    if (model.Stuff_Password != oldstuff.Stuff_Password)
                    {
                        model.Stuff_Password = Md5.MD5(model.Stuff_Password);
                    }
                }
                else
                {
                    model.Stuff_Password = oldstuff.Stuff_Password;
                }
                flag = hrInstance.Update(model);
            }

            if (flag)
            {
                return Json(new { result = "success", target = model });
            }
            else
            {
                return Json(new { result = "fail" });
            }
        }

        public ActionResult DeptOperation(HR_Department dict)
        {
            var flag = false;
            //如果Dict_ID 为0，则表示为添加
            if (dict.Dept_ID == 0)
            {
                //Bse_Dict PNode = dictInstance.GetModel(" AND Dict_Code='" + dict.Dict_PCode + "' AND Dict_Key='" + dict.Dict_Key + "'");

                //dict.Dict_Code = dictInstance.CreateDictNode(PNode, false, ref order);
                flag = deptInstance.AddDept(dict);
                // TempDictList = new List<Bse_Dict>();
                //添加日志
                this.OpLog(dict.Dept_Code, "添加:编码:" + dict.Dept_Name + "数据", flag.ToString());
            }
            else
            {
                flag = deptInstance.UpdateDept(dict);
                //添加日志
                this.OpLog(dict.Dept_Code, "修改:编码:" + dict.Dept_Name + "数据", flag.ToString());
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

        //获取节点信息
        public ActionResult GetNode(string nodeCode)
        {
            HR_Department dict = new HR_Department();
            if (nodeCode.Contains("temp_"))
            {

                var newNodeCode = nodeCode.Split('_')[1];
                dict = deptInstance.GetModel(string.Format("AND Dept_Code='{0}'", newNodeCode));
            }
            else
            {
                dict = deptInstance.GetModel(string.Format("AND Dept_Code='{0}'", nodeCode));
            }

            var result = new JsonResult() { Data = new { result = "success", data = dict } };

            return result;
        }



        /// <summary>
        /// 角色权限
        /// </summary>
        /// <returns></returns>
        public ActionResult Role()
        {
            return View();
        }

        /// <summary>
        /// 角色权限分配
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public ActionResult RoleAllot(string id)
        {
            ViewData["RoleCode"] = id;
            //所有的权限列表
            ViewData["FunList"] = fInstance.GetFunctionLevelByKey();
            return View();
        }

        /// <summary>
        /// 人员权限分配
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public ActionResult PerAllot(string id)
        {
            ViewData["UserCode"] = id;
            //所有的权限列表
            ViewData["FunList"] = fInstance.GetFunctionLevelByKey();
            return View();
        }

        /// <summary>
        /// 获取编号相关权限
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public ActionResult GetUserPermission(string id)
        {
            string usercode = id;
            List<Sys_UserPermission> uPer = new List<Sys_UserPermission>();
            // uPer = upInstance.GetListByCode(string.Format(" AND PU_UserCode='{0}'", usercode));
            uPer = upInstance.GetUserPermission(usercode);
            //List<Sys_Function> flist = fInstance.GetListByCode("");
            //foreach (var f in flist)
            //{
            //    if (uPer.Exists(o => o.PU_FunCode == f.Fun_Code))
            //    {
            //        f.PU_IsCheck = "1";
            //    }
            //}
            //  var coutn = flist.Where(o => o.PU_IsCheck == "1").Count();

            return Json(uPer);
        }

        /// <summary>
        /// 更新权限点
        /// </summary>
        /// <param name="code">人员编码</param>
        /// <returns></returns>
        public ActionResult UpdatePermission(string code)
        {
            ///权限点列表
            string ids = Request["data"];

            List<Sys_UserPermission> list = new List<Sys_UserPermission>();
            if (!string.IsNullOrEmpty(ids))
            {
                var array = ids.TrimEnd(',').Split(',');
                foreach (var p in array)
                {
                    Sys_UserPermission s = new Sys_UserPermission();
                    s.PU_FunCode = p;
                    list.Add(s);
                }

                var flag = upInstance.UpdatePermission(code, list);
                return new JsonResult { Data = new { result = "Success", Msg = "数据更新成功！" } };
            }
            else
            {
                List<Sys_UserPermission> list1 = new List<Sys_UserPermission>();
                var flag = upInstance.UpdatePermission(code, list1);
                return new JsonResult { Data = new { result = "Success", Msg = "数据更新成功！" } };
            }
        }

        /// <summary>
        /// 更新角色权限
        /// </summary>
        /// <param name="code">角色编码</param>
        /// <returns></returns>
        public ActionResult UpdateRolePermission(string code)
        {
            ///权限点列表 
            string ids = Request["data"];
            List<Sys_UserPermission> list = new List<Sys_UserPermission>();
            if (!string.IsNullOrEmpty(ids))
            {
                var array = ids.TrimEnd(',').Split(',');
                foreach (var p in array)
                {
                    Sys_UserPermission s = new Sys_UserPermission();
                    s.PU_UDef1 = "Role";
                    s.PU_FunCode = p;
                    list.Add(s);
                }

                var flag = upInstance.UpdatePermission(code, list);
                return new JsonResult { Data = new { result = "Success", Msg = "数据更新成功！" } };
            }
            else
            {
                List<Sys_UserPermission> list1 = new List<Sys_UserPermission>();
                var flag = upInstance.UpdatePermission(code, list1);
                return new JsonResult { Data = new { result = "Success", Msg = "数据更新成功！" } };
            }


            //return new JsonResult { Data = new { result = "Fail", Msg = "数据更新失败！" } };
        }

        /// <summary>
        /// 获取角色列表
        /// </summary>
        /// <param name="page"></param>
        /// <param name="rows"></param>
        /// <param name="search"></param>
        /// <param name="sidx"></param>
        /// <param name="sord"></param>
        /// <returns></returns>
        public ActionResult GetRole(int page, int rows, string search, string sidx, string sord)
        {

            string filter = Request["filters"] != null ? Request["filters"] : "";
            string filterSql = "";
            if (!string.IsNullOrEmpty(filter))
            {
                filterSql = filter.BuildSearch("Doc_AllotModule");
            }

            List<Sys_Role> list = new List<Sys_Role>();

            if (string.IsNullOrEmpty(filterSql))
            {
                list = rInstance.GetListByCode("AND 1=1");
            }
            else
            {
                list = rInstance.GetListByCode(string.Format("AND {0}", filterSql));
            }


            var model = list.AsQueryable<Sys_Role>();
            //var result = model.ToJqGridData(page, rows, null, search, null);
            var jsonResult = JsonConvert.SerializeObject(model.ToJqGridData(page, rows, null, search, null), new JsonDateConverter("yyyy-MM-dd"));
            return JavaScript(jsonResult);
        }

        /// <summary>
        /// 角色权限分配
        /// </summary>
        /// <param name="UCode"></param>
        /// <param name="role"></param>
        /// <returns></returns>
        public ActionResult AllotRole(string UCode, string role)
        {
            HR_Stuff stuff = hrInstance.GetModel(string.Format("AND Stuff_Code='{0}'", UCode));
            Sys_Role rl = rInstance.GetModel(string.Format("AND SRole_Code='{0}'", role));
            stuff.Stuff_Role = rl.SRole_Code;
            stuff.Stuff_RoleName = rl.SRole_Name;
            hrInstance.Update(stuff);
            return new JsonResult { Data = new { result = "success", Msg = "数据更新成功！" } };


        }

        /// <summary>
        /// 获取人员列表
        /// </summary>
        /// <param name="id"></param>
        /// <param name="page"></param>
        /// <param name="rows"></param>
        /// <param name="search"></param>
        /// <param name="sidx"></param>
        /// <param name="sord"></param>
        /// <returns></returns>
        [OutputCache(CacheProfile = "DeptEmp_CacheConfig")]
        public ActionResult GetEmpList(string id, int page, int rows, string search, string sidx, string sord)
        {
            //string id = string.Empty;
            string filters = Request["filters"] == null ? "" : Request["filters"].ToString();
            string filtersSql = "";
            if (!string.IsNullOrEmpty(filters))
            {
                filtersSql = BulidJqGridSearch.BuildSearch(filters);
            }

            //string 
            List<HR_Stuff> list = new List<HR_Stuff>();
            if (string.IsNullOrEmpty(id))
            {
                if (!string.IsNullOrEmpty(filtersSql))
                {
                    list = hrInstance.GetListByCode(" AND " + filtersSql);
                }
                else
                {
                    list = hrInstance.GetListByCode("");
                }

            }
            else
            {
                if (!string.IsNullOrEmpty(filtersSql))
                {
                    list = hrInstance.GetStuffByDept(id, " AND " + filtersSql);
                }
                else
                {
                    list = hrInstance.GetStuffByDept(id, "AND 1=1");
                }

            }



            var model = list.AsQueryable<HR_Stuff>();
            var result = JsonConvert.SerializeObject(model.ToJqGridData(page, rows, null, search, null), new JsonDateConverter("yyyy-MM-dd"));


            return JavaScript(result);
        }


    }
}
