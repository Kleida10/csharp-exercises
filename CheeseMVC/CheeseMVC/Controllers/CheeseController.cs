﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace CheeseMVC.Controllers
{
    public class CheeseController : Controller
    {
        static private Dictionary<string, string> Cheeses = new Dictionary<string, string>();
        public IActionResult Index()
        {
            ViewBag.cheeses = Cheeses;
           
            return View();
        }

        public IActionResult Add()
        {
            return View();
        }
        
        [HttpPost]
        [Route("/Cheese/Add")]
       
        public IActionResult NewCheese(string name, string descr)
        {
            Cheeses.Add(name, descr);


            return Redirect("/Cheese");
        }

    }
}