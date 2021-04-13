using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SklepInternetowyAK.DAL;

namespace SklepInternetowyAK.Controllers
{
    public class FilmsController : Controller
    {
        private FilmsContext db = new FilmsContext();
        // GET: Films
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult List( string categoryName)
        {
            var categories = db.Categories.Include("Films").Where(c=>c.Name.ToLower()==categoryName.ToLower()).Single();

            return View(categories.Films.ToList());
        }
    }
}