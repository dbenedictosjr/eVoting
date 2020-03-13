using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using OSPI.Infrastructure.Interfaces;
using OSPI.Voting.Models;

namespace OSPI.Voting.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        //[HttpPost]

        //public IActionResult SendEmail()
        //{
        //    //var toAddress = HttpContext.Request.Form["toAddress"].FirstOrDefault();
        //    //var subject = HttpContext.Request.Form["subject"].FirstOrDefault();
        //    //var body = HttpContext.Request.Form["body"].FirstOrDefault();

        //    //IEmailSender.Send(toAddress, subject, body);

        //    //return RedirectToAction("Index");
        //}
    }
}
