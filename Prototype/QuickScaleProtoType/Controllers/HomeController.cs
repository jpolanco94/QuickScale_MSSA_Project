using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using QuickScaleProtoType.Models;

namespace QuickScaleProtoType.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View("FrontPage");
        }

        public IActionResult CreateAccountPage()
        {
            return View();
        }
        public IActionResult ScalesPage()
        {
            return View();
        }
        public IActionResult GamePage()
        {

            return View("GamePage");
        }
        public IActionResult Privacy()
        {
            return View();
        }
    }
}
