using CoreAPIAngular.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CoreAPIAngular.Controllers
{
    //[Route("api/[controller]")]
    [Route("api/UserManagement")]
    [ApiController]
    public class UserManagementController : ControllerBase
    {

        private readonly string _uploadDir = Path.Combine(Directory.GetCurrentDirectory(), "uploads");

        public UserManagementController()
        {
            _uploadDir = Path.Combine(
                Directory.GetCurrentDirectory(),
                "uploads"
            );

            if (!Directory.Exists(_uploadDir))
            {
                Directory.CreateDirectory(_uploadDir);
            }
        }
            
        DBclss dbobj = new DBclss();


        // GET: api/<UserManagementController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }



        // GET api/<UsermanagmentController>/5
        [HttpGet]
        [Route("gettabwithid/{id}")]
        public async Task<IActionResult> Get(int id)
        {
            Userclss getEmployee = dbobj.SelectProfileDB(id);
            var fileurl = Path.Combine(Directory.GetCurrentDirectory(), "Uploads", getEmployee.photo);
            byte[] imagebytes = await System.IO.File.ReadAllBytesAsync(fileurl);
            string base64string = Convert.ToBase64String(imagebytes);
            getEmployee.photo = base64string;
            var emp = await Task.Run(() => Ok(getEmployee));
            return emp;
        }



        // POST api/<UserManagement>
        [HttpPost]
        [Route("inserttab")]
        public async Task<IActionResult> Post([FromForm] UserCreateDTO createdto)
        {
            Userclss usrcls = new Userclss();

            if (createdto.path == null || createdto.path.Length == 0)
            {
                return BadRequest("No file Uploaded.");
            }

            if (!createdto.path.ContentType.StartsWith("image/"))
            {
                return BadRequest("Only image files are allowed.");
            }

            var filePath = Path.Combine(_uploadDir, createdto.path.FileName);

            using (var stream = new FileStream(filePath, FileMode.Create))
            {
                await createdto.path.CopyToAsync(stream);
            }

            Userclss userVls = new Userclss();
            userVls.name = createdto.name;
            userVls.age = createdto.age;
            userVls.addr = createdto.addr;
            userVls.email = createdto.email;
            userVls.photo = createdto.path.FileName;
            userVls.uname = createdto.uname;
            userVls.password = createdto.password;
            dbobj.InsertDB(userVls);
            return await Task.Run(() => Ok(new { message = "registred succesfully" }));
        }


        [HttpPost]
        [Route("logintab")]
        public async Task<IActionResult> Post([FromBody] UserLoginDTO createdto)
        {
            Userclss uservls = new Userclss();
            uservls.uname = createdto.uname;
            uservls.password = createdto.password;
            string cid = dbobj.LoginDB(uservls);
            if (cid == "1")
            {
                return await Task.Run(() => Ok(new { message = "success!" }));
            }
            else
            {
                return await Task.Run(() => Ok(new { message = "invalid login" }));
            }

        }

        // PUT api/<UserManagementController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<UserManagementController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
