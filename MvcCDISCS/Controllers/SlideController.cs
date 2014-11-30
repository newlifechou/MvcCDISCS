using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcCDISCS.Models;
using System.Data.Entity;

namespace MvcCDISCS.Controllers
{
    public class SlideController : Controller
    {
        CompanyContext db = new CompanyContext();
        //
        // GET: /Slide/

        public ActionResult Index()
        {
            List<flash> slides = db.flash.ToList();
            return View(slides);
        }

        //
        // GET: /Slide/Details/5

        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /Slide/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Slide/Create

        [HttpPost]
        [ValidateInput(false)]
        [ValidateAntiForgeryToken]
        public ActionResult Create(flash flash)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    db.flash.Add(flash);
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }

                return View(flash);
            }
            catch
            {
                return HttpNotFound();
            }
        }

        //
        // GET: /Slide/Edit/5

        public ActionResult Edit(int id)
        {
            flash flash = db.flash.Find(id);
            if (flash==null)
            {
                  return HttpNotFound();
            }
            return View(flash);
        }

        //
        // POST: /Slide/Edit/5

        [HttpPost]
        [ValidateInput(false)]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(flash flash)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    db.Entry(flash).State = EntityState.Modified;
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }
                return View(flash);
            }
            catch
            {
                return HttpNotFound();
            }
        }

        //
        // GET: /Slide/Delete/5

        public ActionResult Delete(int id)
        {
            flash flash = db.flash.Find(id);
            if (flash == null)
            {
                return HttpNotFound();
            }
            return View(flash);
        }

        //
        // POST: /Slide/Delete/5

        [HttpPost,ActionName("Delete")]
        [ValidateInput(false)]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            try
            {
                flash flash=db.flash.Find(id);
                db.flash.Remove(flash);
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
