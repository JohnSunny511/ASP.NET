using Microsoft.AspNetCore.Mvc;
using COREMvcBasicApp.Models;
using System.Data.SqlClient;
using System.Data;

namespace COREMvcBasicApp.Controllers
{
    public class EmpLoginController : Controller
    {
        EmpDB dbobj = new EmpDB();
        public IActionResult Login_Pageload()
        {
            return View();
        }
        
        public IActionResult login_click(Employee objcls)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    int cid = dbobj.LoginDB(objcls);
                    if (cid == 1)
                    {
                        TempData["msg"] = "Login Success";
                        return RedirectToAction("UserProfile_PageLoad", "ProfileEmp", new { id = objcls.eid });
                    }
                    else
                    {
                        TempData["msg"] = "Login Failed";
                    }
                }
            }
            catch (Exception ex)
            {
                TempData["msg"] = ex.Message;

            }
            return View("login_pageload");
        }


       
    }
}
