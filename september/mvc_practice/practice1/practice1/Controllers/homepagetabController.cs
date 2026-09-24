using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using practice1.Models;

namespace practice1.Controllers
{
    public class homepagetabController : Controller
    {
        MvctestEntities dbobj = new MvctestEntities();
        // GET: homepagetab
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult insert_click(Class1 clsobj)
        {
            if (ModelState.IsValid)
            {
                dbobj.sp_mvctest(clsobj.name, clsobj.age, clsobj.Email);
                clsobj.msg = "Inserted";
                return View("Insert_pageload", clsobj);
            }
            return View("insert_pageload", clsobj);
        }
    }

}