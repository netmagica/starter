using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Reflection;

namespace Portal.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            string[] info = Assembly.GetExecutingAssembly().FullName.Split(',');
            string version = info[1].Replace("Version=", "");
            ViewBag.Title = string.Format(info[0]);
            ViewBag.Version = string.Format("Versión {0}", version);
            return View();
        }
    }
}
