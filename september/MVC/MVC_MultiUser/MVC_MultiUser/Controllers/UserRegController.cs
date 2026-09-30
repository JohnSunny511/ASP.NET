using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC_MultiUser.Models;
using System.IO;

namespace MVC_MultiUser.Controllers
{
    public class UserRegController : Controller
    {
        MvcMultiDBEntities dbobj = new MvcMultiDBEntities();
        // GET: UserReg
        public ActionResult Insert_PageLoad()
        {
            return View();
        }

        public ActionResult Insert_Click(UserInsertClss clsobj,HttpPostedFileBase file)
        {
            if (ModelState.IsValid)
            {
                if(file.ContentLength > 0)
                {
                    string fname = Path.GetFileName(file.FileName);
                    var s = Server.MapPath("~/Photos");
                    string pa = Path.Combine(s, fname);
                    file.SaveAs(pa);
                    var fullpath = Path.Combine("~\\Photos", fname);
                    clsobj.photo = fullpath;    
                }

                var getmaxid = dbobj.sp_maxLogId().FirstOrDefault();
                int mid = Convert.ToInt32(getmaxid);
                int regid = 0;
                if (mid == 0)
                {
                    regid = 1;
                }
                else
                {
                    regid = mid + 1;
                }
                dbobj.sp_userReg(regid, clsobj.name, clsobj.age, clsobj.address, clsobj.email, clsobj.photo);
                dbobj.sp_login(regid, clsobj.username, clsobj.pass, "user");
                clsobj.usermsg = "Succesfully Inserted";
                return View("Insert_PageLoad", clsobj);
            }
            return View("Insert_PageLoad", clsobj);
        }
    }
}