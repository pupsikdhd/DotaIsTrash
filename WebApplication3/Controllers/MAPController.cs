using System.Web.Mvc;

namespace WebApplication3.Controllers
{
    public class MAPController : Controller
    {
        public ActionResult Index()
        {
            ViewData["Title"] = "MAP";
            return View();
        }
        public ActionResult docs()
        {
            ViewData["Title"] = "Docs";
            return View();
        }
        public ActionResult scheme()
        {
            ViewData["Title"] = "Scheme";
            return View();
        }

        }
    }

