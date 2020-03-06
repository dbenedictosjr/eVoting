using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace OSPI.Voting.Controllers
{
    public class VotingController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}