
using System.Web.Mvc;

namespace testASP.Controllers
{
    public class VideoController : Controller
    {
        public VideoController()
        {
        }
        public ActionResult Index()
        {
            ViewData["Title"] = "Video";
            return View();
        }

        [HttpPost]
        public ActionResult Index(string ind, int height, int width, string background, string image,string isHide)
        {
            return RedirectToAction("Result", new { ind, height, width, background, image,isHide });
        }


        public ActionResult Result(string ind, int height, int width, string background, string image,string isHide)
        {
            ViewData["Title"] = "Result";
            ViewBag.height = height;
            ViewBag.width = width;
            ViewBag.ind = ind;
            ViewBag.background = background;
            ViewBag.image = image;
            ViewBag.isHide = isHide;
            return View();
        }

    }
}
