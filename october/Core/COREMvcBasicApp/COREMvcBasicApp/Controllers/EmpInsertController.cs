using Microsoft.AspNetCore.Mvc;
using COREMvcBasicApp.Models;

namespace COREMvcBasicApp.Controllers
{
    public class EmpInsertController : Controller
    {
        EmpDB dbobj = new EmpDB();
        public IActionResult Index_Pageload()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index_Click(Employee objcls)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    string resp = dbobj.InsertDB(objcls);
                    TempData["msg"] = resp;
                }
            }
            catch (Exception ex)
            {
                TempData["msg"] = ex.Message;
            }
            return View("Index_Pageload");
        }
    }
}
