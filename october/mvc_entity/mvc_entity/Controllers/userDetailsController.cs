using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using mvc_entity;

namespace mvc_entity.Controllers
{
    public class userDetailsController : Controller
    {
        private mvc_entityEntities db = new mvc_entityEntities();

        // GET: userDetails
        public ActionResult Index()
        {
            return View(db.tb1.ToList());
        }

        // GET: userDetails/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tb1 tb1 = db.tb1.Find(id);
            if (tb1 == null)
            {
                return HttpNotFound();
            }
            return View(tb1);
        }

        // GET: userDetails/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: userDetails/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,name,addr,email,phone")] tb1 tb1)
        {
            if (ModelState.IsValid)
            {
                db.tb1.Add(tb1);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tb1);
        }

        // GET: userDetails/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tb1 tb1 = db.tb1.Find(id);
            if (tb1 == null)
            {
                return HttpNotFound();
            }
            return View(tb1);
        }

        // POST: userDetails/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,name,addr,email,phone")] tb1 tb1)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tb1).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tb1);
        }

        // GET: userDetails/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tb1 tb1 = db.tb1.Find(id);
            if (tb1 == null)
            {
                return HttpNotFound();
            }
            return View(tb1);
        }

        // POST: userDetails/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            tb1 tb1 = db.tb1.Find(id);
            db.tb1.Remove(tb1);
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
