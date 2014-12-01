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
    public class NoticeController : Controller
    {
        CompanyContext db = new CompanyContext();
        //
        // GET: /Notice/

        public ActionResult Index(int page = 1)
        {
            IPagedList<notice> notices = db.notice.OrderBy(o => o.Priority).ToPagedList(page, 10);
            return View(notices);
        }

        //
        // GET: /Notice/Details/5

        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /Notice/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Notice/Create

        [HttpPost]
        [ValidateAntiForgeryToken]
        [ValidateInput(false)]
        public ActionResult Create(notice notice)
        {
            try
            {
                notice.CreateTime = DateTime.Now;
                if (TryUpdateModel(notice))
                {
                    db.notice.Add(notice);
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }
                return View(notice);
            }
            catch
            {
                return HttpNotFound();
            }
        }

        //
        // GET: /Notice/Edit/5

        public ActionResult Edit(int id)
        {
            notice notice = db.notice.Find(id);
            if (notice == null)
            {
                return HttpNotFound();
            }
            return View(notice);
        }

        //
        // POST: /Notice/Edit/5

        [HttpPost]
        [ValidateAntiForgeryToken]
        [ValidateInput(false)]
        public ActionResult Edit(notice notice)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    db.Entry(notice).State = EntityState.Modified;
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }
                return View(notice);

            }
            catch
            {
                return HttpNotFound();
            }
        }

        //
        // GET: /Notice/Delete/5

        public ActionResult Delete(int id)
        {
            notice notice = db.notice.Find(id);
            if (notice == null)
            {
                return HttpNotFound();
            }
            return View(notice);
        }

        //
        // POST: /Notice/Delete/5

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        [ValidateInput(false)]
        public ActionResult DeleteConfirmed(int id)
        {
            try
            {
                notice notice = db.notice.Find(id);
                if (notice == null)
                {
                    return HttpNotFound();
                }
                db.notice.Remove(notice);
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
