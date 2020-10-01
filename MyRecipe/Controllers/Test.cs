using System;
using Microsoft.AspNetCore.Mvc;

namespace MyRecipe.Controllers
{
    public class Test : Controller
    {
        // GET: /<controller>/
        public ActionResult Index()
        {
            
            return Content("Hello From test index");
        }

        public String About()
        {
            return "Hello from test About";
        }

        public ActionResult Contact()
        {
            return View();
        }

    }
}
