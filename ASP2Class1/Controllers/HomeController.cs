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
        [HttpGet]
        public IActionResult Index()
        {
            ViewBag.Discount = 0;
            ViewBag.Price = 0;
            return View();
        }

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
