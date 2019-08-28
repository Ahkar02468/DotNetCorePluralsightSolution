using DotNetCorePluralsight.Services;
using DotNetCorePluralsight.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotNetCorePluralsight.Controllers
{
    public class AppController : Controller
    {
        public readonly IMailService _mailService;

        public AppController(IMailService mailService)
        {
            _mailService = mailService;
        }
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
                _mailService.SendMessage("arkarshwebaw@gmail.com",model.Subject, $"From: {model.Name} - {model.Email}, Message: {model.Message}");
               ViewBag.UserMessage("Mail Sent");
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
