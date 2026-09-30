using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC2Adv.Models;

namespace MVC2Adv.Controllers
{
    public class UserProfileController : Controller
    {
        mvc2Entities dbobj = new mvc2Entities();
        // GET: UserProfile
        public ActionResult Profile_Load()
        {
            int id = Convert.ToInt32(Session["uid"]);
            var getdata = dbobj.sp_pview(id).FirstOrDefault();
            return View(new profileclss
            {
                name = getdata.Name,
                age = getdata.Age,
                address = getdata.Address,
                email = getdata.Email,
                photo = getdata.Photo
            });
        }

        public ActionResult Profile_Update(profileclss obj)
        {
            int id = Convert.ToInt32(Session["uid"]);
            dbobj.sp_pupdate(id, obj.age, obj.address);
            var getdata = dbobj.sp_pview(id).FirstOrDefault();
            return View("Profile_Load", new profileclss
            {
                name = getdata.Name,
                age = getdata.Age,
                address = getdata.Address,
                email = getdata.Email,
                photo = getdata.Photo,
                msg = "Profile updated"
            });
        }
    }
}