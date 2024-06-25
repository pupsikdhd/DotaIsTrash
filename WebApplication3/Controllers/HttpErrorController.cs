using System.Web.Mvc;

namespace WebApplication3.Controllers
{
    public class HttpErrorController : Controller
    {
        public ActionResult NotFound()
        {
            ViewData["Title"] = "404";
            return View();
        }
        public ActionResult ISE()
        {
            ViewBag.isThis = Request.UrlReferrer != null && Request.UrlReferrer.ToString().Contains(Request.Url.Host);
            ViewData["Title"] = "500";
            return View();
        }
    }
}