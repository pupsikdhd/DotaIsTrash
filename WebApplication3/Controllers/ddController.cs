using System.IO;
using System.Net;
using System.Web.Mvc;

namespace WebApplication3.Controllers
{
    public class ddController : Controller
    {
        public ActionResult poshalka() => View(); 
        public ActionResult Index(int u) 
        {
            string path = "dd.txt";
            if (!System.IO.File.Exists(path)) { System.IO.File.Create(path);}
            return Redirect(System.IO.File.ReadAllText(path));
        }
    }
}