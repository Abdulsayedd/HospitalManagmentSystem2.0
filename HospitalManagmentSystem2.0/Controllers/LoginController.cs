using HospitalManagmentSystem2._0.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using Type = HospitalManagmentSystem2._0.Models.Type;

namespace HospitalManagmentSystem2._0.Controllers
{
    public class LoginController : Controller
    {
        AccountEntities AccountConnection = new AccountEntities();
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(Account user)
        {
            var IsRegistered = AccountConnection.Accounts.Where(a => a.username == user.username && a.password == user.password).FirstOrDefault();
            if (IsRegistered == null)
            {
                ModelState.AddModelError("", "Wrong Username/Password");
            }
            else
            {
                SetCookie(IsRegistered.type);
                FormsAuthentication.SetAuthCookie(user.username, false);
                Type.typ = IsRegistered.type.ToString();
                Session["UserId"] = IsRegistered.id.ToString();
                Session["UserType"] = IsRegistered.type.ToString();
                return RedirectToAction("Home","Home");
            }
            return View();
        }
        public ActionResult SetCookie(String x)
        {
            HttpCookie cookie = new HttpCookie("CookieType");
            cookie.Value = x;
            Response.Cookies.Add(cookie);
            return View();
        }
        public ActionResult Logout()
        {
            HttpCookie cookie = new HttpCookie("CookieType");
            cookie.Expires = DateTime.Now.AddDays(-1);
            Response.Cookies.Add(cookie);
            FormsAuthentication.SignOut();
            Session.Clear();
            Session.Abandon();

            HttpCookie rFormsCookie = new HttpCookie(FormsAuthentication.FormsCookieName, "");
            rFormsCookie.Expires = DateTime.Now.AddYears(-1);
            Response.Cookies.Add(rFormsCookie);

            HttpCookie rSessionCookie = new HttpCookie("ASP.NET_SessionId", "");
            rSessionCookie.Expires = DateTime.Now.AddYears(-1);
            Response.Cookies.Add(rSessionCookie);
            Response.Cache.SetCacheability(HttpCacheability.NoCache);
            Response.Cache.SetNoStore();
            return RedirectToAction("Index","Home");
        }

    }
}