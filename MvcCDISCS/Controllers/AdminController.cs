﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcCDISCS.Controllers
{
    public class AdminController : Controller
    {
        //
        // GET: /Admin/

        public ActionResult Index()
        {
            return View();
        }
        /// <summary>
        /// EditSuccess
        /// </summary>
        /// <returns></returns>
        public ActionResult EditSuccess()
        {
            return View();
        }

    }
}