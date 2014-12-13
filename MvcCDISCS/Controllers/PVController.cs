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
        [OutputCache(Duration = 600, VaryByParam = "id")]
        public ActionResult GetContact(string show = "no")
        {
            Response.Cache.SetOmitVaryStar(true);

            basicinfo bi = db.basicinfo.Single();
            ViewBag.Show = show;
            return PartialView(bi);
        }

        /// <summary>
        /// GetFriendLink
        /// </summary>
        /// <returns></returns>
        [OutputCache(Duration = 600, VaryByParam = "id")]
        public ActionResult GetFriendLink()
        {
            Response.Cache.SetOmitVaryStar(true);

            ViewBag.FriendLinkList = new SelectList(db.friendlink, "SiteUrl", "SiteName");
            return PartialView();
        }
        /// <summary>
        /// GetProductCategoryMenu
        /// </summary>
        /// <returns></returns>
        [OutputCache(Duration = 600, VaryByParam = "id")]
        public ActionResult GetProductCategoryMenu()
        {
            Response.Cache.SetOmitVaryStar(true);

            List<productcategory> pc = db.productcategory.OrderBy(o => o.Priority).ToList();
            return PartialView(pc);
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}
