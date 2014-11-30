using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcCDISCS.Models;

namespace MvcCDISCS.Controllers
{
    public class FeedbackController : Controller
    {
        CompanyContext db = new CompanyContext();
        //
        // GET: /Feedback/

        public ActionResult Index()
        {
            List<feedback> fbs = db.feedback.OrderByDescending(o => o.FeedbackTime).ToList();
            return View(fbs);
        }

        //
        // GET: /Feedback/Details/5

        public ActionResult Details(int id)
        {
            feedback fb = db.feedback.Find(id);
            if (fb==null)
            {
                return HttpNotFound();
            }
            return View(fb);
        }


        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /Feedback/Edit/5

        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Feedback/Delete/5

        public ActionResult Delete(int id=0)
        {
            feedback fb = db.feedback.Find(id);
            if (fb == null)
            {
                return HttpNotFound();
            }
            return View(fb);
        }

        //
        // POST: /Feedback/Delete/5

        [HttpPost,ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            try
            {
                feedback fb = db.feedback.Find(id);
                if (ModelState.IsValid)
                {
                    db.feedback.Remove(fb);
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }
                return View(fb);
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
