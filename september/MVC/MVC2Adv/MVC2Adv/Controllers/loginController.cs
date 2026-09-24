using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Objects;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC2Adv.Models;

namespace MVC2Adv.Controllers
{
    public class loginController : Controller
    {
        mvc2Entities dbobj = new mvc2Entities();
        // GET: login
        public ActionResult Login_PageLoad()
        {
            return View();
        }

        public ActionResult Login_Click(loginclss objclss)
        {
            if (ModelState.IsValid)
            {
                ObjectParameter op = new ObjectParameter("status", typeof(int));
                dbobj.sp_login(objclss.Username, objclss.pwd, op);
                int val = Convert.ToInt32(op.Value);
                if (val == 1)
                {
                    return RedirectToAction("Home");
                }
                else
                {
                    ModelState.Clear();
                    objclss.msg = "Invalid login";
                    return View("Login_PageLoad", objclss);
                };
            }
            return View("Login_PageLoad", objclss);

        }
        

        public ActionResult Home()
        {
            return View();
        }
    }
}