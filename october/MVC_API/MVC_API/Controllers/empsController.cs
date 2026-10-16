using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MVC_API;
using System.Net.Http;

namespace MVC_API.Controllers
{
    public class empsController : Controller
    {
        private MVCWebApiEntities db = new MVCWebApiEntities();

        // GET: emps
        public ActionResult Index()
        {
            //return View(db.emps.ToList());
            IEnumerable<emp> employees = null;
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:55225/api/API/");
                var responseTask = client.GetAsync("getalldata");
                responseTask.Wait();
                var result = responseTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    var readTask = result.Content.ReadAsAsync<IList<emp>>();
                    readTask.Wait();
                    employees = readTask.Result;
                }
                else
                {
                    employees = Enumerable.Empty<emp>();
                }
            }
            return View(employees);
        }

        // GET: emps/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            emp emp = db.emps.Find(id);
            if (emp == null)
            {
                return HttpNotFound();
            }
            return View(emp);
        }

        // GET: emps/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: emps/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "empId,empName,empAge,empSalary,empAddr")] emp emp)
        {
            if (ModelState.IsValid)
            {
                using (var client = new HttpClient())
                {
                    client.BaseAddress = new Uri("http://localhost:55225/api/API/");

                    var postTask = client.PostAsJsonAsync<emp>("postwebapiemptab", emp);

                    postTask.Wait();

                    var result = postTask.Result;

                    if (result.IsSuccessStatusCode)
                    {
                        return RedirectToAction("Index");
                    }

                    return View(emp);
                }
            }

            return View(emp);
        }

        // GET: emps/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            emp emp = db.emps.Find(id);
            if (emp == null)
            {
                return HttpNotFound();
            }
            return View(emp);
        }

        // POST: emps/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "empId,empName,empAge,empSalary,empAddr")] emp emp)
        {
            if (ModelState.IsValid)
            {
                db.Entry(emp).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(emp);
        }

        // GET: emps/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            emp emp = db.emps.Find(id);
            if (emp == null)
            {
                return HttpNotFound();
            }
            return View(emp);
        }

        // POST: emps/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            emp emp = db.emps.Find(id);
            db.emps.Remove(emp);
            db.SaveChanges();
            return RedirectToAction("Index");
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
