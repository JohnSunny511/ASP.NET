using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApiPractice.API
{
    public class APIController : ApiController
    {
        MVCWebApiEntities dbobj = new MVCWebApiEntities();
        // GET: api/API
        [HttpGet]
        [Route("api/API/getalldata")]
        public IHttpActionResult Get()
        {
            return Ok(dbobj.emps.ToList());
        }

        // GET: api/API/5
        [HttpGet]
        [Route("api/API/getdetailswithid/{id}")]
        public IHttpActionResult Get(int id)
        {
            emp emp = dbobj.emps.Find(id);
            if (emp == null)
            {
                return NotFound();
            }
            return Ok(emp);
        }

        // POST: api/API
        [HttpPost]
        [Route("api/API/postwebapiemptab")]         //api/controller name/method name
        public IHttpActionResult Post(emp emp)
        {
            dbobj.emps.Add(emp);
            dbobj.SaveChanges();
            return Ok(200);
        }

        // PUT: api/API/5
        [HttpPut]
        [Route("api/API/editwithid/{id}")]
        public IHttpActionResult Put(int id,emp emp)
        {
            dbobj.Entry(emp).State = EntityState.Modified;
            dbobj.SaveChanges();
            return Ok(200);
        }

        // DELETE: api/API/5
        [HttpDelete]
        [Route("api/API/deletewithid/{id}")]
        public IHttpActionResult Delete(int id)
        {
            emp emp = dbobj.emps.Find(id);   //find data of corrspoding id
            dbobj.emps.Remove(emp);         //remove that data from table
            dbobj.SaveChanges();           //saved changes
            return Ok(emp);
        }
    }
}
