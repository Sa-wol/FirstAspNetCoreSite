using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace AlmostEmpty3_1StarterCode.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            //ViewBag.Title = "Home";
            ViewData["Title"] = "Home";
            return View();
        }

        public IActionResult About()
        {
            //ViewBag.Title = "About";
            ViewData["Title"] = "About";
            return View();
        }
    }
}
