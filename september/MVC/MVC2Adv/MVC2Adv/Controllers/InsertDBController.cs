using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC2Adv.Models;

namespace MVC2Adv.Controllers
{
    public class InsertDBController : Controller
    {
        mvc2Entities dbobj = new mvc2Entities();
        // GET: InsertDB
        public ActionResult Insert_Pageload()
        {
            List<stclass> stList = new List<stclass>
            {
                new stclass {sId = 1, sName = "Kerala"},
                new stclass {sId = 2, sName = "TN"},
                new stclass {sId = 3, sName = "Karnataka"},
            };
            ViewBag.States = new SelectList(stList, "sId", "sName");

            //Checkboxlist
            InsertClss ob = new InsertClss();
            ob.MyFavQual = getQualificationData();
            return View(ob);
        }

        public List<CheckBoxListHelper> getQualificationData()
        {
            List<CheckBoxListHelper> sts = new List<CheckBoxListHelper>()
            {
                new CheckBoxListHelper {Value = "SSLC",Text="SSLC",IsChecked=true},
                new CheckBoxListHelper {Value = "Plus 2",Text="Plus 2",IsChecked=false},
                new CheckBoxListHelper {Value = "BCA",Text="BCA",IsChecked=false},
                new CheckBoxListHelper {Value = "MCA",Text="MCA",IsChecked=false},
                new CheckBoxListHelper {Value = "BTECH",Text="BTECH",IsChecked=false}
            };
            return sts;
        }

        public ActionResult Insert_click(InsertClss clsobj,HttpPostedFileBase file,FormCollection form)
        {
            if (ModelState.IsValid)
            {
                if(file.ContentLength > 0)
                {
                    //for inserting to project folder
                    string fname = Path.GetFileName(file.FileName);
                    var s = Server.MapPath("~/photos");
                    string pa = Path.Combine(s, fname);
                    file.SaveAs(pa);

                    //for inserting path to table
                    var fullpath = Path.Combine("~\\photos", fname);
                    clsobj.Photo = fullpath;
                }

                List<stclass> stList = new List<stclass>
                {
                    new stclass {sId = 1, sName = "Kerala"},
                    new stclass {sId = 2, sName = "TN"},
                    new stclass {sId = 3, sName = "Karnataka"},
                };
                ViewBag.States = new SelectList(stList, "sId", "sName");

                int selectedId = Convert.ToInt32(form["ddlstate"]);
                stclass selectedItem = stList.FirstOrDefault(c => c.sId == selectedId);
                clsobj.sId = selectedItem.sId;
                clsobj.sName = selectedItem.sName;


                var quid = string.Join(",", clsobj.selectedQual);
                clsobj.Quali = quid;

                clsobj.MyFavQual = getQualificationData();

                dbobj.AdvancedApp(clsobj.Name, clsobj.Age, clsobj.Address, clsobj.Email, clsobj.Photo, clsobj.Gender, clsobj.sName, clsobj.Quali, clsobj.Username, clsobj.pwd);
                clsobj.msg = "Succesfully Inserted";
                return View("Insert_Pageload", clsobj);

            }
            else
            {
                List<stclass> stList = new List<stclass>
                {
                    new stclass {sId = 1, sName = "Kerala"},
                    new stclass {sId = 2, sName = "TN"},
                    new stclass {sId = 3, sName = "Karnataka"},
                };

                ViewBag.states = new SelectList(stList, "sId", "sName");
                clsobj.MyFavQual = getQualificationData();
                return View("Insert_Pageload", clsobj);

            }
        }
    }
}