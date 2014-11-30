using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcCDISCS.Models;
using System.Data.Entity;

namespace MvcCDISCS.Controllers
{
    public class MoreBasicInfoController : Controller
    {
        CompanyContext db = new CompanyContext();
        //
        // GET: /MoreBasicInfo/Edit/5

        public ActionResult Edit(int id = 1)
        {
            morebasicinfo mbi = db.morebasicinfo.Where(o => o.Id == id).Single();
            return View(mbi);
        }

        //
        // POST: /MoreBasicInfo/Edit/5

        [HttpPost]
        [ValidateAntiForgeryToken]
        [ValidateInput(false)]
        public ActionResult Edit(morebasicinfo mbi, FormCollection collection)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    db.Entry(mbi).State = EntityState.Modified;
                    db.SaveChanges();
                    return RedirectToAction("EditSuccess", "Admin");
                }
                return View(mbi);
            }
            catch
            {
                return View(mbi);
            }
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}
