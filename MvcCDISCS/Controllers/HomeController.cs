using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcCDISCS.Models;

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
            hi.ProductCategories = db.productcategory.Take(5).ToList();
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
        public ActionResult ProductCategory(int id=0)
        {
            if (id==0)
            {
                return HttpNotFound();
            }
            productcategory pc = db.productcategory.Include("Products").Where(o=>o.CategoryId==id).Single();
            return View(pc);
        }
    }
}
