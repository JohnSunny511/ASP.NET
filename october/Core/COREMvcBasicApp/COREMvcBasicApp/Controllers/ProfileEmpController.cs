using Microsoft.AspNetCore.Mvc;
using COREMvcBasicApp.Models;

namespace COREMvcBasicApp.Controllers
{
    public class ProfileEmpController : Controller
    {
        EmpDB dbobj = new EmpDB();
        public IActionResult UserProfile_PageLoad(int id)
        {
            Employee getlist = dbobj.SelectProfileDB(id);
            return View(getlist);
        }
    }
}
