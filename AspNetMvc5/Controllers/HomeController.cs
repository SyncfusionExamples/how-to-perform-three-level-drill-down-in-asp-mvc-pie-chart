using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AspNetMvc5.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            List<CategoryData> chartData = new List<CategoryData>
            {
                new CategoryData { x = "SUV", y = 25 },
                new CategoryData { x = "Car", y = 37 },
                new CategoryData { x = "Pickup", y = 15 },
                new CategoryData { x = "Minivan", y = 23 },

             };
            ViewBag.dataSource = chartData;

            return View();
        }
        public class CategoryData
        {
            public string x;
            public double y;
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