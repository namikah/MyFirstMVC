using Microsoft.AspNetCore.Mvc;
using MyFirstMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyFirstMVC.Controllers
{
    public class HomeController : Controller
    {
        public string Index()
        {
            return "Hello home / Index";
        }

        public string Partnors()
        {
            return "Hello home / partnors";
        }

        public ViewResult Sponsors()
        {
            var viewResult = new ViewResult
            {
                ViewName = "Sponsors"
            };
            return viewResult;
        }

        public IActionResult OurTeam()
        {
            return View();
        }
    }
}
