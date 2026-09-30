using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC2Adv.Models;

namespace MVC2Adv.Controllers
{
    public class ChangePwdController : Controller
    {
        mvc2Entities dbobj = new mvc2Entities();
        // GET: ChangePwd
        public ActionResult pwd_Load()
        {
            int id = Convert.ToInt32(Session["uid"]);
            var getdata = dbobj.sp_getpswd(id).Single();
            return View(new changepwdclss
            {
                oldpassword = getdata
        });
        }

        public ActionResult pwd_click(changepwdclss obj)
        {
            if (ModelState.IsValid)
            {
                int id = Convert.ToInt32(Session["uid"]);
                dbobj.sp_changepwd(id, obj.newpassword);
                obj.msg = "password Changed";
                return View("pwd_Load", obj);
            }
            return View("pwd_Load", obj);
        }
    }

}