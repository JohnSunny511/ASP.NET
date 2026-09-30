using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC_MultiUser.Models;

namespace MVC_MultiUser.Controllers
{
    public class UserLoginController : Controller
    {
        MvcMultiDBEntities dbobj = new MvcMultiDBEntities();
        // GET: UserLogin
        public ActionResult Login_PageLoad()
        {
            return View();
        }

        public ActionResult UserHome()
        {
            return View();
        }

        public ActionResult AdminHome()
        {
            return View();
        }

        public ActionResult Login_Click(loginclss objclss)
        {
            if (ModelState.IsValid)
            {
                var val = dbobj.sp_loginCountId(objclss.uname, objclss.password).First();
                if(val == 1)
                {
                    var uid = dbobj.sp_loginId(objclss.uname, objclss.password).FirstOrDefault();
                    Session["uid"] = uid;

                    var it = dbobj.sp_loginType(objclss.uname, objclss.password).FirstOrDefault();
                    if(it == "user")
                    {
                        return RedirectToAction("UserHome");
                    }
                    else if (it == "admin")
                    {
                        return RedirectToAction("AdminHome");

                    }
                }
                else
                {
                    ModelState.Clear();
                    objclss.msg = "Invalid Username and Password";
                    return View("Login_PageLoad", objclss);
                }
            }
            else
            {
                ModelState.Clear();
                objclss.msg = "Invalid Login";
                return View("Login_PageLoad", objclss);

            }
            return View("Login_PageLoad", objclss);

        }
    }
}