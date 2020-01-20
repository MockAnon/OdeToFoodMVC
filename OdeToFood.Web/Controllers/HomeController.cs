using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Ajax;
using OdeToFood.Data.Services;

namespace OdeToFood.Web.Controllers
{
    public class HomeController : Controller
    {
        IRestaurantData db;

        public HomeController(IRestaurantData db)
        {
            this.db = db;
            //db = new InMemoryRestaurantData();
        }

        public ActionResult Index()
        {
            var model = db.GetAll();
            var mvcName = typeof(Controller).Assembly.GetName();
            var isMono = Type.GetType("Mono.Runtime") != null;

            ViewData["Version"] = mvcName.Version.Major + "." + mvcName.Version.Minor;
            ViewData["Runtime"] = isMono ? "Mono" : ".NET";

            //return "Hello, World!";
            return View(model);
        }
        public ActionResult Pepe()
        {
            return View();
        }
    }
}
