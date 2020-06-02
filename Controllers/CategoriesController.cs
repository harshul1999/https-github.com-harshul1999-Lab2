using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Lab2.Controllers
{
    public class CategoriesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Details(string category)
        {
            // Storing the selected Category in the ViewBag Container
            //ViewBag automatically passes back to the view that loads.
            ViewBag.categories = category;
            return View();
        }
    }
}
