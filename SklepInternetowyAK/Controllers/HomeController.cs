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
            var categories = db.Categories.ToList();
            IndexViewModel ivm = new IndexViewModel();
            ivm.Categories = categories;
            return View(ivm);
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

    }
}