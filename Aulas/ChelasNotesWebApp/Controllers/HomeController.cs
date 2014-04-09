using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ChelasNotesWebApp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Welcome to ASP.NET MVC!";
            Response.Cookies.Add(new HttpCookie("mycookie", "SLB"));
            return View();
        }

        public ActionResult About()
        {
            return View();
        }
    }
}
