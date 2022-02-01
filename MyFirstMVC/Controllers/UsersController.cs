using Microsoft.AspNetCore.Mvc;
using MyFirstMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyFirstMVC.Controllers
{
    public class UsersController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Name = "'Namik'";
            ViewData["Surname"] = "'Heydarov'";
            TempData["Gender"] = "'Male'";
            //return View();
            return RedirectToAction(nameof(Works));
        }

        public IActionResult Works()
        {
            return View();
        }

        public IActionResult Persons()
        {
            var persons = new List<Persons>
            {
                new Persons{Id=1, Name="Namik",Surname="Heydarov",Age=34, Position = "Senior specialist"},
                new Persons{Id = 2, Name="Ali",Surname="Mahmudov",Age=28,Position = "Junior specialist"},
                new Persons{Id = 3, Name="Jale",Surname="Aliyeva",Age=17,Position = "Specialist"}
            };

            return View(persons);
        }

        //public IActionResult Persons(int? id)
        //{
        //    var persons = new List<Persons>
        //    {
        //        new Persons{Id=1, Name="Namik",Surname="Heydarov",Age=34, Position = "Senior specialist"},
        //        new Persons{Id = 2, Name="Ali",Surname="Mahmudov",Age=28,Position = "Junior specialist"},
        //        new Persons{Id = 3, Name="Jale",Surname="Aliyeva",Age=17,Position = "Specialist"}
        //    };

        //    if (id == null)
        //        return NotFound();

        //    var person = persons.Find(x => x.Id == id);
        //    if (person == null)
        //        return NotFound();

        //    return View(person);
        //}

        //public IActionResult PersonsJson()
        //{
        //    var persons = new List<Persons>
        //    {
        //        new Persons{Id=1, Name="Namik",Surname="Heydarov",Age=34, Position = "Senior specialist"},
        //        new Persons{Id = 2, Name="Ali",Surname="Mahmudov",Age=28,Position = "Junior specialist"},
        //        new Persons{Id = 3, Name="Jale",Surname="Aliyeva",Age=17,Position = "Specialist"}
        //    };

        //    return Json(persons);
        //}
    }
}
