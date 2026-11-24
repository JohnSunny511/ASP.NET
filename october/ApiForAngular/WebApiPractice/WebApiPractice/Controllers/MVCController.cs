using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WebApiPractice;

using System.Net.Http;

namespace WebApiPractice.Controllers
{
    public class MVCController : Controller
    {
        private MVCWebApiEntities db = new MVCWebApiEntities();

        // GET: MVC
        public ActionResult Index()
        {
            //return View(db.emps.ToList());
            IEnumerable<emp> employee = null;
            using(var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:61454/api/API/");
                var responseTask = client.GetAsync("getalldata");
                responseTask.Wait();
                var result = responseTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    var readTask = result.Content.ReadAsAsync<IList<emp>>();
                    readTask.Wait();
                    employee = readTask.Result;
                }
                else
                {
                    employee = Enumerable.Empty<emp>();
                }
            }
            return View(employee);
        }

        // GET: MVC/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            else
            {
                emp employee = null;
                using (var client = new HttpClient())
                {
                    client.BaseAddress = new Uri("http://localhost:61454/api/API/");
                    var responseTask = client.GetAsync($"getdetailswithid/{id}");
                    responseTask.Wait();
                    var result = responseTask.Result;
                    if (result.IsSuccessStatusCode)
                    {
                        var readTask = result.Content.ReadAsAsync<emp>();
                        readTask.Wait();
                        employee = readTask.Result;
                    }
                    else
                    {
                        employee = new emp();
                    }
                }
                return View(employee);
            }
            //emp emp = db.emps.Find(id);
            //if (emp == null)
            //{
            //    return HttpNotFound();
            //}
            //return View(emp);
        }

        // GET: MVC/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: MVC/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "empId,empName,empAge,empSalary,empAddr")] emp emp)
        {
            if (ModelState.IsValid)
            {
                //db.emps.Add(emp);
                //db.SaveChanges();
                //return RedirectToAction("Index");
                using(var client = new HttpClient())
                {
                    client.BaseAddress = new Uri("http://localhost:61454/api/API/");
                    var postTask = client.PostAsJsonAsync<emp>("postwebapiemptab", emp);
                    postTask.Wait();
                    var result = postTask.Result;
                    if (result.IsSuccessStatusCode)
                    {
                        return RedirectToAction("Index");
                    }
                }
                return View(emp);
            }

            return View(emp);
        }

        // GET: MVC/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            emp employee = null;
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:61454/api/API/");
                var responseTask = client.GetAsync($"getdetailswithid/{id}");
                responseTask.Wait();
                var result = responseTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    var readTask = result.Content.ReadAsAsync<emp>();
                    readTask.Wait();
                    employee = readTask.Result;
                }
                else
                {
                    employee = new emp();
                }
            }
            return View(employee);

            //emp emp = db.emps.Find(id);
            //if (emp == null)
            //{
            //    return HttpNotFound();
            //}
            //return View(emp);
        }

        // POST: MVC/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "empId,empName,empAge,empSalary,empAddr")] emp emp)
        {
            if (ModelState.IsValid)
            {

                using (var client = new HttpClient())
                {
                    client.BaseAddress = new Uri("http://localhost:61454/api/API/");
                    var postTask = client.PutAsJsonAsync<emp>($"editwithid/{emp.empId}", emp);
                    postTask.Wait();
                    var result = postTask.Result;
                    if (result.IsSuccessStatusCode)
                    {
                        return RedirectToAction("Index");

                    }
                }
                return View(emp);
                //db.Entry(emp).State = EntityState.Modified;
                //db.SaveChanges();
                //return RedirectToAction("Index");
            }
            return View(emp);
        }

        // GET: MVC/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            emp employee = null;
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:61454/api/API/");
                var responseTask = client.GetAsync($"getdetailswithid/{id}");
                responseTask.Wait();
                var result = responseTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    var readTask = result.Content.ReadAsAsync<emp>();
                    readTask.Wait();
                    employee = readTask.Result;
                }
                else
                {
                    employee = new emp();
                }
            }
            return View(employee);
        }

        // POST: MVC/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            using(var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:61454/api/API/");
                var PostTask = client.DeleteAsync($"deletewithid/{id}");
                PostTask.Wait();
                var result = PostTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    return RedirectToAction("Index");
                }
            }
            return RedirectToAction("Delete");


            //emp emp = db.emps.Find(id);
            //db.emps.Remove(emp);
            //db.SaveChanges();

        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
