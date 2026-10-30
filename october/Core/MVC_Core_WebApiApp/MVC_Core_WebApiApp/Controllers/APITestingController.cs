using MVC_Core_WebApiApp.Model;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MVC_Core_WebApiApp.Controllers
{
    //[Route("api/[controller]")]
    [Route("APITesting")]
    [ApiController]
    public class APITestingController : ControllerBase
    {
        DBclss dbobj = new DBclss();
        // GET: api/<APITestingController>
        [HttpGet]
        [Route("GetAllTab")]
        public List<Employeecls> Get()
        {
            return dbobj.displayall();
        }

        // GET api/<APITestingController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<APITestingController>
        [HttpPost]
        [Route("posttab")]
        public void Post([FromBody] Employeecls objcls)
        {
            dbobj.insertdb(objcls);
        }

        [HttpGet]
        [Route("Gettabwithid/{id}")]
        public Employeecls? GetTabWithId(int id)
        {
            var getemployee = dbobj.displayall().Where(x => x.eid == id).FirstOrDefault();
            return getemployee;
        }

        // PUT api/<APITestingController>/5
        //[HttpPut("{id}")]
        //public void Put(int id, [FromBody] string value)
        //{
        //}

        [HttpPut]
        [Route("Updatetab/{id}")]
        public void Put(int id, [FromBody] Employeecls ob)
        {
            var updateEmployee = dbobj.displayall().Where(x => x.eid == id).FirstOrDefault();
            if (updateEmployee != null)
            {
                updateEmployee.eid = ob.eid;
                updateEmployee.ename = ob.ename;
                updateEmployee.eaddr = ob.eaddr;
                updateEmployee.esal = ob.esal;
                dbobj.UpdateDB(updateEmployee);
            }
        }

        // DELETE api/<APITestingController>/5
        //[HttpDelete("{id}")]
        //public void Delete(int id)
        //{
        //} 

        [HttpDelete]
            [Route("deletetab/{id}")]
            public void Delete(int id)
            {
                dbobj.DeleteDB(id);
            }
        }
}
