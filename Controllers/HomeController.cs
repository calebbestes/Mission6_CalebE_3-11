using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Mission6_CalebE_3_11.Models;

namespace Mission6_CalebE_3_11.Controllers
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

        public IActionResult Collection()
        {
            return View();
        }

        public IActionResult AboutJoel()
        {
            return View();
        }

        public IActionResult Form()
        {
            return View();
        }

    }
}
