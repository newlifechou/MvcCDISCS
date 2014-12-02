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
    public class ServiceController : Controller
    {
        CompanyContext db = new CompanyContext();
        //
        // GET: /Service/

        public ActionResult Index()
        {
            List<service> services = db.service.ToList();
            return View(services);
        }

        //
        // GET: /Service/Details/5

        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /Service/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Service/Create

        [HttpPost]
        public ActionResult Create(service service)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    db.service.Add(service);
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }
                return View(service);
            }
            catch
            {
                return HttpNotFound();
            }
        }

        //
        // GET: /Service/Edit/5

        public ActionResult Edit(int id)
        {
            service service = db.service.Find(id);
            if (service == null)
            {
                return HttpNotFound();
            }
            return View(service);
        }

        //
        // POST: /Service/Edit/5

        [HttpPost]
        public ActionResult Edit(service service)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    db.Entry(service).State = EntityState.Modified;
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }

                return View(service);
            }
            catch
            {
                return HttpNotFound();
            }
        }

        //
        // GET: /Service/Delete/5

        public ActionResult Delete(int id)
        {
            service service = db.service.Find(id);
            if (service == null)
            {
                return HttpNotFound();
            }
            return View(service);
        }

        //
        // POST: /Service/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            service service = db.service.Find(id);
            db.service.Remove(service);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}
