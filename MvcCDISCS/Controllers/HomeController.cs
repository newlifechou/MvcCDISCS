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
            return View();
        }

    }
}
