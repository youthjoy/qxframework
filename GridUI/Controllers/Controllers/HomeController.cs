using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using QX.BLL;
using QX.Model;
using QX.Config;
using QX.Comm;
using QX.AOP;
using System.Web.Caching;

namespace QX.Controllers
{
    [HandleError]
    [ExceptionFillters]
    [ActionFillters]
    [ResultFillters][QX.Cache.CompressFilter]
    public class HomeController:Controller
    {
       // Bll_System_Menu instance = new Bll_System_Menu();
        QX.MenuHelper.Bll_Menu instance = new QX.MenuHelper.Bll_Menu();
        Bll_HR_Stuff instanceHR_Stuff = new Bll_HR_Stuff();
        Bll_HR_Department instanceDepartment = new Bll_HR_Department();
      //  Bll_System_TopMenu TopInsatance = new Bll_System_TopMenu();

        //员工
        HR_Stuff HR_Stuff = new HR_Stuff();
        //部门
        HR_Department Department = new HR_Department();

        //字典
        BLL.Bll_Bse_Dict instanceD = new Bll_Bse_Dict();
       
        Bll_HR_Department instanceHR_Department = new Bll_HR_Department();
        HR_Department HR_Department = new HR_Department();
        
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Login()
        {
            return View();
        }

        public ActionResult logout()
        {
            Session.Clear();
            return Content(" <script> window.parent.location='/home/login'; </script> ");
        }

        //全部公司
        [HttpPost]
        public ActionResult DepartmentAll()
        {
            List<HR_Department> list = instanceDepartment.GetListByCode(" AND ISNULL(Dept_PCode,'')=''").OrderBy(o=>o.Dept_ID).ToList();
            return Json(list);
        }
        
        //登陆
        public ActionResult LoginBtn()
        {
            //TODO:corporation
            string result = "fail";
            string msg = string.Empty;
            string company = Request["company"];
            string userName = Request["userName"];
            string userPwd = Request["pwd"];
            //string userRole = Request["role"];
            //string result = "";
            if (!Net.CheckConn())
            {
                return Json(new { result = result, msg = "无法连接到服务器！请检查网络情况。" });
            }
            
            try
            {
               
                if (userName == null || userPwd == null)
                {
                    result = "fail";
                    msg = "用户名或密码不能为空";
                    //return Content("Null");
                }
                else
                {
                    //TODO:1.4
                    //得到公司
                    string pwd = Md5.MD5(userPwd);
                    //角色Stuff_LoginType and Stuff_LoginType='" + userRole + "'
                    //HR_Stuff = instanceHR_Stuff.GetModel(string.Format(" and Stuff_UserName='{0}' and Stuff_Password='{1}'",userName,pwd));
                    
                    Dictionary<string, string> dic = new Dictionary<string, string>();
                    dic.Add("Stuff_UserName", userName);
                    dic.Add("Stuff_Password", pwd);
                    HR_Stuff = instanceHR_Stuff.GetModel(string.Format("AND Stuff_UserName=@Stuff_UserName AND Stuff_Password=@Stuff_Password"),dic);
                    if (HR_Stuff == null)
                    {
                        result = "fail";
                        msg = "用户名或密码不正确 ";
                    }
                    else
                    {
                        //用户名
                        this.SetSession<string>("UserName", HR_Stuff.Stuff_Name);
                        //员工编码
                        this.SetSession<string>("UserId", HR_Stuff.Stuff_Code);
                        //员工登录名
                        this.SetSession<string>("LoginName", HR_Stuff.Stuff_UserName);
                        //登录IP
                        this.SetSession<string>("IP", HttpContext.Request.UserHostAddress);
                        
                        //部门信息
                        HR_Department = instanceHR_Department.GetModel(" and Dept_Code='" + HR_Stuff.Stuff_DepCode + "'");
                        if (HR_Department != null)
                        {

                            //部门id
                            this.SetSession<string>("DeptId", HR_Department.Dept_Code.ToString());
                            //部门名称
                            this.SetSession<string>("DeptName", HR_Department.Dept_Name);
                            //用户角色
                            this.SetSession<string>("UserRole", HR_Stuff.Stuff_LoginType);
                            //DODO：hao


                            HR_Department fagTemp = instanceHR_Department.GetModel(" and Dept_Code='" + HR_Department.Dept_PCode.ToString() + "'");
                            while (!string.IsNullOrEmpty(fagTemp.Dept_PCode))
                            {
                                fagTemp = instanceHR_Department.GetModel(" and Dept_Code='" + fagTemp.Dept_PCode + "'");
                            }
                            string companyUser = fagTemp.Dept_Name.ToString();
                            //公司编码
                            string companyCode = fagTemp.Dept_Code.ToString();
                            //this.SetSession<string>("Company", company);
                            this.SetSession<string>("CompanyCode", companyCode);
                            //部门编码
                            this.SetSession<string>("DeptCode", HR_Department.Dept_Code);

                            //TODO:得到公司问题
                            //companyCode=new BLL.Bll_HR_Department().GetCompanyName("" + HR_Department.Dept_Code + "");

                            this.SetSession<string>("Company", companyUser);
                          
                            result ="success";

                            msg = "";                            

                        }
                        else
                        {
                            result ="fail";
                            msg = "用户信息配置错误";
                        }
                    }
                }               

            }
            catch (System.Exception ex)
            {
                result = "fail";
                msg = "网络连接不通，请重试";
                //CommLog.Error(ex.Message);
                //PlateLog.Write("连接异常:", PlateLog.LogMessageType.Error,ex);
            }

            //写入登录日志
            //Bll_Comm.LoginLog(userName,msg);

            return Json(new { result = result, msg = msg });
        }
        

        
        public ActionResult top()
        {
            //Bll_System_Menu Menu = new Bll_System_Menu();
            //QX.Comm.MenuLocation local = QX.Comm.MenuLocation.TOP;
            //List<System_Menu> MenuList = Menu.GetMenu(local);
            //var model = TopInsatance.GetModel(" AND Menu_User='" + SessionConfig.UserId() + "' ");
           // ViewData["TopList"] = model != null ? model.Menu_Links : "";
            
            //登录人信息
            ViewData["UserName"] = !string.IsNullOrEmpty(SessionConfig.UserName()) ? SessionConfig.UserName() : "1";
            ViewData["UserRole"] = !string.IsNullOrEmpty(SessionConfig.Stuff_LoginType()) ? instanceD.GetModel(" and Dict_Code='" + SessionConfig.Stuff_LoginType() + "'") .Dict_Name: "2";
            ViewData["IP"] = SessionConfig.CurrentIP();

            return View();
           
        }

        public ActionResult center()
        {
            return View();
        }

        public ActionResult down()
        {
            return View();
        }

        public ActionResult mid()
        {
            return View();
        }

        //[OutputCache(CacheProfile = "LeftMenu_CacheConfig")]
        public ActionResult left()
        {
            QX.Comm.MenuLocation local=QX.Comm.MenuLocation.LEFT;
            List<QX.MenuHelper.Model.System_Menu> MenuList = instance.GetMenu(local.ToString());
            return View(MenuList);
        }

        public ActionResult right()
        {
            return View();
        }

        public ActionResult tab()
        {
            return View();
        }



    }
}
