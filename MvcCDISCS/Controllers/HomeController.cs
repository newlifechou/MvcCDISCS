using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcCDISCS.Models;

using PagedList;

namespace MvcCDISCS.Controllers
{
    public class HomeController : Controller
    {
        CompanyContext db = new CompanyContext();
        //
        // GET: /Home/

        public ActionResult Index()
        {
            HomeIndex hi = new HomeIndex();
            //get the pagetitle
            hi.PageTitle = db.basicinfo.Single().CompanyName;
            //get the slide list
            hi.Slides = db.flash.OrderBy(o => o.Priority).ToList();
            //get notice slide list
            hi.Notices = db.notice.Where(o => o.IsShow == true).OrderBy(o => o.Priority).ToList();
            //get productcategories,5 in count
            hi.ProductCategories = db.productcategory.OrderBy(o=>o.Priority).Take(5).ToList();
            //get the introduction
            hi.Introduction = db.morebasicinfo.Where(o => o.Id == 1).Single().ItemContent;
            return View(hi);
        }

        /// <summary>
        /// About
        /// </summary>
        /// <returns></returns>
        public ActionResult About(int id = 0)
        {
            if (id < 1 || id > 10)
            {
                return HttpNotFound();
            }
            morebasicinfo mbc = db.morebasicinfo.Where(o => o.Id == id).Single();
            return View(mbc);
        }
        /// <summary>
        /// ProductCategory
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public ActionResult ProductCategory(int id = 0,int page=1)
        {
            if (id == 0)
            {
                return HttpNotFound();
            }
            ProductCategoryPage pcp = new ProductCategoryPage();
            //分页的实现
            pcp.pc = db.productcategory.Include("Products").Where(o => o.CategoryId == id).Single();
            pcp.products = pcp.pc.Products.ToPagedList(page, 8);
            //清空pc.Products
            pcp.pc.Products = null;
            return View(pcp);
        }
        /// <summary>
        /// Product
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public ActionResult Product(int id = 0)
        {
            product p = db.product.Where(o => o.ProductId == id).Single();
            return View(p);
        }
        /// <summary>
        /// Feedback
        /// </summary>
        /// <returns></returns>
        public ActionResult Feedback()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Feedback(feedback fb)
        {
            if (fb==null)
            {
                return HttpNotFound();
            }
            fb.FeedbackTime = DateTime.Now;
            if (ModelState.IsValid)
            {
                db.feedback.Add(fb);
                db.SaveChanges();
                return RedirectToAction("FeedbackSuccess", "Home");
            }
            return View(fb);
        }

        /// <summary>
        /// FeedbackSuccess
        /// </summary>
        /// <returns></returns>
        public ActionResult FeedbackSuccess()
        {
            return View();
        }
        /// <summary>
        /// Service
        /// </summary>
        /// <returns></returns>
        public ActionResult Service()
        {
            List<service> ss = db.service.ToList();
            return View(ss);
        }



        /// <summary>
        /// Contact
        /// </summary>
        /// <returns></returns>
        public ActionResult Contact()
        {
            return View();
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}
