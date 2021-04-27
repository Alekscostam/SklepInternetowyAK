using SklepInternetowyAK.DAL;
using SklepInternetowyAK.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SklepInternetowyAK.ViewModels;


namespace SklepInternetowyAK.Controllers
{
    public class HomeController : Controller
    {
        FilmsContext db = new FilmsContext();
        public ActionResult Index()
        {
            var longest = db.Films.OrderByDescending(f => f.Length).Take(3);

            return View(longest);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult StaticSite(string name)
        {
            return View(name);
        }

        public ActionResult Contact(string name)
        {
            ViewBag.Message = "Your contact page.";

            return View(name);
        }
        public ActionResult PaymentMethods(string name)
        {
            ViewBag.Message = "Your contact page.";

            return View(name);
        }
        public ActionResult Regulations(string name)
        {
            ViewBag.Message = "Your contact page.";

            return View(name);
        }

        public ActionResult Test()
        {
            return View();
        }
    }
}