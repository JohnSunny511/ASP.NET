using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Core_Mvc_Advanced.Models;

namespace Core_Mvc_Advanced.Controllers
{
    public class DisplayAllController : Controller
    {
        StudentDB dbobj = new StudentDB();
        public IActionResult DisplayAll_PageLoad()
        {
            List<InsertClss> getalldata = dbobj.DisplayAll();
            ViewBag.userdetails = getalldata;
            return View();
        }
    }
}
