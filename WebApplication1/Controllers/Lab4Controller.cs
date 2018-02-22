using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    public class Lab4Controller : Controller
    {
        public IActionResult Index()
        {
            DateTime today = DateTime.Now;
            return View(today);
        }

        public IActionResult Page2(int id)
        {
            return View(id);
        }

        public IActionResult Page3()
        {
            ViewData["Message"] = "Beverages!";
            String[] drinks = new String[] { "Coffee", "Tea", "Soda", "Beer", "Wine" };
            return View(drinks);
        }
    }
}