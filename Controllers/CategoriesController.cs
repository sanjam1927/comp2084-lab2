using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace lab2.Controllers
{
    public class CategoriesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Details(String Category)
        {
            ViewBag.Category = Category;
            return View();
        }
    }
}
