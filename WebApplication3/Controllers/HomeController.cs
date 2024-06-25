using System.Web;
using System;
using System.Web.Mvc;

namespace WebApplication3.Controllers
{

    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewData["Title"] = "Home Page";
            return View();
        }

        public ActionResult ChangeTheme()
        {
            if (Request.Cookies["theme"] == null || string.IsNullOrEmpty(Request.Cookies["theme"].Value))
            {
                HttpCookie cookie = new HttpCookie("theme");
                cookie.Value = "dark";
                cookie.Expires = DateTime.Now.AddYears(5);
                Response.Cookies.Add(cookie);
            }
            else
            {
                if (Request.Cookies["theme"].Value == "dark")
                {
                    HttpCookie cookie = new HttpCookie("theme");
                    cookie.Value = "light";
                    cookie.Expires = DateTime.Now.AddYears(5);
                    Response.Cookies.Add(cookie);
                }
                else if (Request.Cookies["theme"].Value == "light")
                {
                    HttpCookie cookie = new HttpCookie("theme");
                    cookie.Value = "dark";
                    cookie.Expires = DateTime.Now.AddYears(5);
                    Response.Cookies.Add(cookie);
                }
            }

            return Redirect(Request.UrlReferrer.ToString());
        }
    }
}