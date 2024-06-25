using System;
using System.Text;
using System.Web.Mvc;


namespace testASP.Controllers
{
    public class LinkController : Controller
    {

        [HttpGet]
        public ActionResult Index()
        {
            ViewData["Title"] = "Generator";
            return View();
        }


        [HttpPost]
        public ActionResult Index(string link) => RedirectToAction("Result", new { link });
       

        public ActionResult Result(string link)
        {
            
            ViewData["Title"] = "Generator Result";
            ViewBag.a = null;
            byte[] byteText = null;
            try
            {
                byteText = Encoding.UTF8.GetBytes(link);
                if (Request.Url.Port == 443) 
                    ViewBag.a = "https://" + Request.Url.Host + @"/link/link?a=" + Convert.ToBase64String(byteText);
                else
                     ViewBag.a = "https://" + Request.Url.Host + ":" + Request.Url.Port + @"/link/link?a=" + Convert.ToBase64String(byteText); 
            }
            catch
            {

            }

            return View();
        }

        public ActionResult linkError(string link, string errorCode)
        {
            ViewData["Title"] = "Error";
            ViewBag.a = link;
            ViewBag.errorCode = errorCode;
            Console.WriteLine("linkError");
            return View();
        }
        public ActionResult link(string a)
        {
            
            if (a != null)
            {
                try
                {
                    byte[] byteEncryptedText = Convert.FromBase64String(a);
                    a = Encoding.UTF8.GetString(byteEncryptedText);
                }
                catch
                {
                    return Redirect("/link/linkError?errorCode=1");
                }

                if (a.StartsWith("http"))
                {
                    return Redirect(a);
                }

                else
                {
                    return Redirect($"/link/linkError?link={a}");
                }
            }
            return Redirect("https://youtu.be/dQw4w9WgXcQ?si=ejj_EoL8tDQzlUTE");
        }
    }
}


