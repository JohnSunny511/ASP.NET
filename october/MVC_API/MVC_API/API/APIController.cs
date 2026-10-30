using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MVC_API.API
{
    public class APIController : ApiController
    {
        MVCWebApiEntities dbobj = new MVCWebApiEntities();
        // GET: api/API
        public IEnumerable<string> Get()           //get all data since nothing specified
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/API/5
        public string Get(int id)              //get specific data since id specified
        {
            return "value";
        }

        // POST: api/API
        [HttpPost]
        [Route("api/API/PostWebApi")]
        public IHttpActionResult Post(emp emp)
        {
            dbobj.emps.Add(emp);
            dbobj.SaveChanges();
            return Ok(200);                   //ok   is built in function
        }

        [Route("Login")]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/API/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/API/5
        public void Delete(int id)
        {
        }
    }
}
