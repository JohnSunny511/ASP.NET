using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MVC_API.Controllers
{
    public class APIController : ApiController
    {
        MVCWebApiEntities dbobj = new MVCWebApiEntities();
        // GET: api/API
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/API/5
        [HttpGet]
        [Route("api/API/getalldata")]
        public IHttpActionResult Get(int id)
        {
            return Ok(dbobj.emps.ToList());
            //return "value";
        }

        // POST: api/API
        public void Post([FromBody]string value)
        {
        }

        //post: api/API
        [HttpPost]
        [Route("api/API/postwebapiemptab")]
        public IHttpActionResult Post(emp emptab)
        {
            dbobj.emps.Add(emptab);
            dbobj.SaveChanges();
            return Ok(200);
            
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
