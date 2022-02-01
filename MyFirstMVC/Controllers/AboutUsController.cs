using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyFirstMVC.Controllers
{
    public class AboutUsController : Controller
    {
        public string Index(int? id)
        {
            return $"Hello AboutUs / Index: {id}";
        }

        public ViewResult about()
        {
            var viewResult = new ViewResult();
            viewResult.ViewName = "about";
            return viewResult;
        }

        public IActionResult Address()
        {
            return View("about");
        }

        public IActionResult Sponsors()
        {
            return RedirectToAction("Sponsors","Home");
        }
    }
}
