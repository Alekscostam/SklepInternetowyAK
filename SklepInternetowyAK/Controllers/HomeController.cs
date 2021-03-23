using SklepInternetowyAK.DAL;
using SklepInternetowyAK.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SklepInternetowyAK.Controllers
{
    public class HomeController : Controller
    {
        FilmsContext db = new FilmsContext();
        public ActionResult Index()
        {
            Category category = new Category()
            {
                CategoryId = 1,
                Name = "Horror",
                Desc = "Filmy od lat 16"
            };
            db.Categories.Add(category);
            db.SaveChanges();
           
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}