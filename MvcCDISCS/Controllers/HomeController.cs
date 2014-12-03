using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcCDISCS.Models;
using System.Threading;

using PagedList;
using System.Data.Entity;

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
            hi.PageTitle = db.basicinfo.Find(1).CompanyName;
            //get the slide list
            hi.Slides = db.flash.OrderBy(o => o.Priority).ToList();
            //get notice slide list
            hi.Notices = db.notice.Where(o => o.IsShow == true).OrderBy(o => o.Priority).ToList();
            //get productcategories,5 in count
            hi.ProductCategories = db.productcategory.OrderBy(o => o.Priority).Take(5).ToList();
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
            morebasicinfo mbc = db.morebasicinfo.Find(id);
            return View(mbc);
        }
        /// <summary>
        /// ProductCategory
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public ActionResult ProductCategory(int id = 0, int page = 1)
        {
            if (id == 0)
            {
                return HttpNotFound();
            }
            ProductCategoryPage pcp = new ProductCategoryPage();
            //分页的实现
            pcp.pc = db.productcategory.Include("Products").Where(o => o.CategoryId == id).Single();
            pcp.products = pcp.pc.Products.ToPagedList(page, 9);
            //清空pc.Products
            pcp.pc.Products = null;
            return View(pcp);
        }

        /// <summary>
        /// 转到搜索页面
        /// </summary>
        /// <returns></returns>
        public ActionResult SearchPage()
        {
            return View();
        }
        /// <summary>
        /// search product as required  for ajax use
        /// </summary>
        /// <returns></returns>
        public ActionResult SearchProduct(string query, int page = 1)
        {
            ViewBag.QueryString = query;
            //如果查询字符串为null或者空，返回产品类别首页
            if (string.IsNullOrEmpty(query))
            {
                return Content("请输入关键词后再查询");
            }
            //TODO:模拟网络延迟
            Thread.Sleep(1500);
            List<product> products = db.product.Include("Category").Where(o => o.ProductName.Contains(query)).OrderBy(o => o.ProductId).ToList();
            return PartialView(products);
        }

        /// <summary>
        /// Product
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public ActionResult Product(int id = 0)
        {
            product p = db.product.Find(id);
            if (p==null)
            {
                return HttpNotFound();
            }
            //read account +1
            p.ReadCount++;
            db.Entry(p).State = EntityState.Modified;
            db.SaveChanges();

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
            if (fb == null)
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

        /// <summary>
        /// Career
        /// </summary>
        /// <param name="page"></param>
        /// <returns></returns>
        public ActionResult Career(int page = 1)
        {
            //只显示显示标示为true且没有过期的招聘信息
            IPagedList<career> careers = db.career.Where(o => o.IsShow == true&&o.ExpirationTime>DateTime.Now).OrderByDescending(o => o.CreateTime).ToPagedList(page, 10);
            return View(careers);
        }
        public ActionResult CareerDetails(int id)
        {
            career career = db.career.Find(id);
            if (career==null)
            {
                return HttpNotFound();
            }
            return View(career);
        }



        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}
