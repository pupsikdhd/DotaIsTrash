using System.Web.Mvc;

namespace WebApplication3.Controllers
{
    public class presentationController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            ViewData["Title"] = "Presentation";
            return View();
        }
        [HttpPost]
        public ActionResult Index(string link, int width,int height,string color,string title)
        {
            return RedirectToAction("Result", new { link, height, width,color,title});
        }
        public ActionResult Result(string link, int width, int height,string color,string title)
        {
            ViewData["Title"] = title;
            ViewBag.height = height;
            ViewBag.width = width;
            ViewBag.link = link;
            ViewBag.color = color;
            return View();
        }
    }
}