using Microsoft.AspNetCore.Mvc;
using COREMvcBasicApp.Models;

namespace COREMvcBasicApp.Controllers
{
    public class DisplayAllController : Controller
    {
        EmpDB dbobj = new EmpDB();
        public IActionResult DisplayAll_Pageload()
        {
            List<Employee> getlist = dbobj.SelectAll();
            ViewBag.userdetails = getlist;
            return View();
        }
    }
}
