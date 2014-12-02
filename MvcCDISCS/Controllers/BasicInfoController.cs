using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcCDISCS.Models;
using System.Data.Entity;

namespace MvcCDISCS.Controllers
{
    [Authorize]
    public class BasicInfoController : Controller
    {
        CompanyContext db = new CompanyContext();
        //
        // GET: /BasicInfo/Edit/5

        public ActionResult Edit(int id = 1)
        {
            basicinfo bi = db.basicinfo.Where(o => o.Id == id).Single();
            ViewBag.PageTitle = "联系方式";
            return View(bi);
        }

        //
        // POST: /BasicInfo/Edit/5

        [HttpPost]
        [ValidateAntiForgeryToken]
        [ValidateInput(false)]
        public ActionResult Edit(basicinfo bi)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    db.Entry(bi).State = EntityState.Modified;
                    db.SaveChanges();
                    return RedirectToAction("EditSuccess", "Admin");
                }
                return View(bi);
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
