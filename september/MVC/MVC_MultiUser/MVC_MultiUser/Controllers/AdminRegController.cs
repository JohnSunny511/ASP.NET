using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC_MultiUser.Models;

namespace MVC_MultiUser.Controllers
{
    public class AdminRegController : Controller
    {
        MvcMultiDBEntities dbobj = new MvcMultiDBEntities();
        // GET: AdminReg
        public ActionResult InsertAdminPageLoad()
        {
            return View();
        }

        public ActionResult Insertadmin_click(AdminInsertClsscs clsobj)
        {
            if (ModelState.IsValid)
            {
                var getmaxid = dbobj.sp_maxLogId().FirstOrDefault();
                int mid = Convert.ToInt32(getmaxid);
                int regid = 0;
                if(mid == 0)
                {
                    regid = 1;
                }
                else
                {
                    regid = mid + 1;
                }

                dbobj.sp_adminReg(regid, clsobj.name, clsobj.address, clsobj.phone, clsobj.email);
                dbobj.sp_login(regid, clsobj.username, clsobj.pass, "admin");
                clsobj.adminmsg = "Succesfully inserted";
                return View("InsertAdminPageLoad", clsobj);
            }
            return View("InsertAdminPageLoad", clsobj);
        }
    }
}