using Microsoft.AspNetCore.Mvc;
using Core_Mvc_Advanced.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Core_Mvc_Advanced.Controllers
{
    public class StudentInsertController : Controller
    {
        StudentDB dbobj = new StudentDB();

        private readonly IWebHostEnvironment _hostingEnvironment;

        public StudentInsertController(IWebHostEnvironment hostingEnvironment)
        {
            _hostingEnvironment = hostingEnvironment;
        }

        public IActionResult InsertLoad()
        {
            //DropDown
            List<Stclass> stList = dbobj.Selectstates();
            ViewBag.selstates = new SelectList(stList, "stId", "stName");
            InsertClss user = new InsertClss();
            user.MyFavoriteQual = getQualificationData();
            return View(user);
        }

        public List<CheckBoxListHelper> getQualificationData()
        {
            List<CheckBoxListHelper> sts = new List<CheckBoxListHelper>()
            {
                new CheckBoxListHelper{Value="SSLC",Text="SSLC",IsChecked=true},
                new CheckBoxListHelper{Value="PLUS TWO",Text="PLUS TWO",IsChecked=false},
                new CheckBoxListHelper{Value="BCA",Text="BCA",IsChecked=false},
                new CheckBoxListHelper{Value="MCA",Text="MCA",IsChecked=false },
                new CheckBoxListHelper{Value="BTECH",Text="BTEH",IsChecked=false},
            };
            return sts;
        }

        public IActionResult Insert_Click(InsertClss objclss, IFormFile SingleFile)
        {
            try
            {
                if (SingleFile != null && SingleFile.Length > 0)
                {
                    string uploadFolder = Path.Combine(_hostingEnvironment.WebRootPath, "Photos");
                    //Server.mappath
                    string uniqueFileName = Guid.NewGuid().ToString() + "_" + Path.GetFileName(SingleFile.FileName);
                    //Guid-Globallly Unique Identifier
                    string filePath = Path.Combine(uploadFolder, uniqueFileName);
                    objclss.sphoto = "/Photos/" + uniqueFileName;
                    //image save to folder(in soloution explorer)
                    using (var stream = System.IO.File.Create(filePath))
                    {
                        SingleFile.CopyTo(stream);
                    }
                }
                objclss.MyFavoriteQual = getQualificationData();
                var quid = string.Join(",", objclss.selectedQual ?? Array.Empty<string>());
                objclss.Qual = quid;

                string resp = dbobj.InsertFn(objclss);
                TempData["msg"] = resp;
            }
            catch (Exception ex)
            {
                TempData["msg"] = "Error: " + ex.Message;
            }
            return RedirectToAction("InsertLoad");
        }

        public JsonResult GetDistricts(int stateId)
        {
            var districts = GetDistrictByStateId(stateId);
            return Json(districts); 
        }

        private List<SelectListItem> GetDistrictByStateId(int stateId)
        {
            var dists = dbobj.Selectdistrics(stateId);
            var districtsbystate = dists.Select(a => new SelectListItem()
            { 
                Value = a.dId.ToString(), Text = a.dName 
            }).ToList();
            return districtsbystate;
        }
    }
}
