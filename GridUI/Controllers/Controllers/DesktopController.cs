using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using QX.BLL;
using QX.Model;
using QX.Comm;
using QX.Config;

namespace QX.Controllers
{
    public class DesktopController : Controller
    {

     //   List<WaitAuditEx> waitAuditList = new List<WaitAuditEx>(); 

        //
        // GET: /Destop/

        public ActionResult Index()
        {
            return View();
        }
        
        /// <summary>
        /// 待审清单
        /// </summary>
        /// <returns></returns>
        public ActionResult WaitAuditList()
        {
            //获取PU待审            

            //获取nStock待审

            //获取Equs待审

            //获取Reprot待审
            
            
                                  

            return new EmptyResult();
        }

    }
}
