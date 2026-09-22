using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC.Models;

namespace MVC.Controllers
{
    public class InsertDBtabController : Controller
    {
        MVCdbEntities dbobj = new MVCdbEntities();  //object of DB
        // GET: InsertDBtab
        public ActionResult Insert_Pageload()  //load -- view
        {
            return View();
        }

        public ActionResult InsertClick(InsertCls clsobj)         // object of class      we get properties of that class
        {
            if (ModelState.IsValid)
            {
                dbobj.spBasicInsert(clsobj.Name, clsobj.Age, clsobj.Email);
                clsobj.msg = "inserted";
                return View("Insert_Pageload", clsobj);
            }
            return View("Insert_Pageload",clsobj);
        }
    }
}