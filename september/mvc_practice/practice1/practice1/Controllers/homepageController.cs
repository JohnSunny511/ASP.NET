using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace practice1.Controllers
{
    public class homepageController : Controller
    {
        // GET: homepage
        public ActionResult home()
        {
            return View();
        }

        
    }
}