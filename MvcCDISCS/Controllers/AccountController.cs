using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcCDISCS.Models;
using System.Web.Security;

namespace MvcCDISCS.Controllers
{
    public class AccountController : Controller
    {
        /// <summary>
        /// log in
        /// </summary>
        /// <returns></returns>
        public ActionResult Login()
        {
            if (System.Web.HttpContext.Current.User.Identity.IsAuthenticated)
            {
                return RedirectToAction("Index", "Account");
            }
            return View();
        }
        [HttpPost]
        public ActionResult Login(admin user)
        {
            if (ModelState.IsValid)
            {
                UserRepository ur = new UserRepository();
                if (ur.ValidateUser(user.UserName, user.Password))
                {
                    FormsAuthentication.SetAuthCookie(user.UserName, false);
                    return RedirectToAction("Index", "Account");
                }
                else
                {
                    ModelState.AddModelError("", "用户名或者密码错误");
                    return View(user);
                }
            }
            ModelState.AddModelError("", "请正确填写用户名或者密码");
            return View(user);
        }

        /// <summary>
        /// log out
        /// </summary>
        /// <returns></returns>
        public ActionResult LogOut()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Login", "Account");
        }

        /// <summary>
        /// get the current user name
        /// </summary>
        /// <returns></returns>
        [Authorize]
        public ActionResult CurrentUser()
        {
            ViewBag.CurrentUser = System.Web.HttpContext.Current.User.Identity.Name;
            return PartialView();
        }




        public ActionResult Index()
        {
            return View();
        }
    }
}
