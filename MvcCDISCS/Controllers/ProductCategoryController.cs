using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcCDISCS.Models;
using System.Data.Entity;

namespace MvcCDISCS.Controllers
{
    public class ProductCategoryController : Controller
    {
        CompanyContext db = new CompanyContext();
        //
        // GET: /ProductCategory/

        public ActionResult Index()
        {
            List<productcategory> pclist = db.productcategory.ToList();
            return View(pclist);
        }

        //
        // GET: /ProductCategory/Details/5

        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /ProductCategory/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /ProductCategory/Create

        [HttpPost]
        public ActionResult Create(productcategory pc)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    db.productcategory.Add(pc);
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }
                return View(pc);
            }
            catch
            {
                return HttpNotFound();
            }
        }

        //
        // GET: /ProductCategory/Edit/5

        public ActionResult Edit(int id)
        {
            productcategory pc = db.productcategory.Find(id);
            if (pc == null)
            {
                return HttpNotFound();
            }
            return View(pc);
        }

        //
        // POST: /ProductCategory/Edit/5

        [HttpPost]
        public ActionResult Edit(productcategory pc)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    db.Entry(pc).State = EntityState.Modified;
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }

                return View(pc);
            }
            catch
            {
                return HttpNotFound();
            }
        }

        //
        // GET: /ProductCategory/Delete/5

        public ActionResult Delete(int id)
        {
            productcategory pc = db.productcategory.Find(id);
            if (pc == null)
            {
                return HttpNotFound();
            }
            return View(pc);
        }

        //
        // POST: /ProductCategory/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            try
            {
                productcategory pc = db.productcategory.Find(id);
                if (pc == null)
                {
                    return HttpNotFound();
                }
                db.productcategory.Remove(pc);
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
