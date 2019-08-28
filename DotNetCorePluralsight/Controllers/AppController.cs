﻿using DotNetCorePluralsight.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotNetCorePluralsight.Controllers
{
    public class AppController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet("contact")]
        public IActionResult Contact()
        {
            //ViewBag.Title("Contact Us");
            return View();
        }

        [HttpPost("contact")]
        public IActionResult Contact(ContactViewModel model)
        {
            if (ModelState.IsValid)
            {
                //send email
            }
            else
            {
                //show error
            }
            //ViewBag.Title("Contact Us");
            return View();
        }

        public IActionResult About()
        {
           // ViewBag.Title("About");
            return View();
        }
    }
}
