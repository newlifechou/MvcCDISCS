using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcCDISCS.Models;
using System.Data.Entity;
using PagedList;

namespace MvcCDISCS.Controllers
{
    public class CareerController : Controller
    {
        CompanyContext db = new CompanyContext();
        //
        // GET: /Career/

        public ActionResult Index(int page=1)
        {
            IPagedList<career> careers = db.career.OrderByDescending(o => o.CreateTime).ToPagedList(page,10);
            return View(careers);
        }

        //
        // GET: /Career/Details/5

        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /Career/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Career/Create

        [HttpPost]
        [ValidateAntiForgeryToken]
        [ValidateInput(false)]
        public ActionResult Create(career career)
        {
            try
            {
                career.CreateTime = DateTime.Now;
                if (TryUpdateModel(career))
                {
                    db.career.Add(career);
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }
                return View(career);
            }
            catch
            {
                return HttpNotFound();
            }
        }

        //
        // GET: /Career/Edit/5

        public ActionResult Edit(int id)
        {
            career career = db.career.Find(id);
            if (career==null)
            {
                return HttpNotFound();
            }
            return View(career);
        }

        //
        // POST: /Career/Edit/5

        [HttpPost]
        [ValidateAntiForgeryToken]
        [ValidateInput(false)]
        public ActionResult Edit(career career)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    db.Entry(career).State = EntityState.Modified;
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }
                return View(career);
            }
            catch
            {
                return HttpNotFound();
            }
        }

        //
        // GET: /Career/Delete/5

        public ActionResult Delete(int id)
        {
            career career = db.career.Find(id);
            if (career == null)
            {
                return HttpNotFound();
            }
            return View(career);
        }

        //
        // POST: /Career/Delete/5

        [HttpPost,ActionName("Delete")]
        [ValidateAntiForgeryToken]
        [ValidateInput(false)]
        public ActionResult DeleteConfirmed(int id)
        {
            try
            {
                career career = db.career.Find(id);
                if (career==null)
                {
                    return HttpNotFound();
                }
                db.career.Remove(career);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return HttpNotFound();
            }
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}
