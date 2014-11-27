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
            return View(hi);
        }

    }
}
