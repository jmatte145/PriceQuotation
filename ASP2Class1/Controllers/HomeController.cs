using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PriceQuotation.Models;

namespace PriceQuotation.Controllers
{
    public class HomeController : Controller
    {
        // Creates the ViewBag variables and sets them to 0 on startup.  // 
        [HttpGet]
        public IActionResult Index()
        {
            ViewBag.Discount = 0;
            ViewBag.Price = 0;
            return View();
        }

        // Takes input from the model and inserts it into the view if the criteria is met. //
        [HttpPost]
        public IActionResult Index(SubtotalModel model)
        {
            if (ModelState.IsValid)
            {
                ViewBag.Discount = model.CalculateDiscount();
                ViewBag.Price = model.CalculatePrice();
            }
            else
            {
                ViewBag.Discount = 0;
                ViewBag.Price = 0;
            }
            return View(model);
        }
    }
}
