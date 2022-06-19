using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Nick.WebSite.UI.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Nick.WebSite.UI.Controllers
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
            return RedirectToAction("Login","Account");
        }

        public IActionResult Privacy()
        {
            return View();
        }
    }
}
