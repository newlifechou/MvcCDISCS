using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcCDISCS.Models;

namespace MvcCDISCS.Controllers
{
    public class PVController : Controller
    {
        /// <summary>
        ///后面要 给下面这些部分视图添加缓存
        /// </summary>



        CompanyContext db = new CompanyContext();
        /// <summary>
        /// GetContact PartialView
        /// </summary>
        /// <returns></returns>
        public ActionResult GetContact(string show = "no")
        {
            basicinfo bi = db.basicinfo.Single();
            ViewBag.Show = show;
            return PartialView(bi);
        }

        /// <summary>
        /// GetFriendLink
        /// </summary>
        /// <returns></returns>
        public ActionResult GetFriendLink()
        {
            ViewBag.FriendLinkList = new SelectList(db.friendlink, "SiteUrl", "SiteName");
            return PartialView();
        }

    }
}
