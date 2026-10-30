using TokenCoreApiApp.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TokenCoreApiApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmpDetailsController : ControllerBase
    {
        // GET: api/<EmpDetailsController>

        EmpDBclss dbobj = new EmpDBclss();
        [HttpGet]
        [Authorize]
        public List<EmpDetailsclss> Get()
        {
            return dbobj.SelectDB();
        }

        // GET api/<EmpDetailsController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<EmpDetailsController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<EmpDetailsController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<EmpDetailsController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
