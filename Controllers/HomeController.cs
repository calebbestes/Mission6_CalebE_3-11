using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Mission6_CalebE_3_11.Models;

namespace Mission6_CalebE_3_11.Controllers
{
    public class HomeController : Controller
    {
        private MovieCollectionContext _context;
        public HomeController(MovieCollectionContext temp)
        {
            _context = temp;
        }

        //private readonly ILogger<HomeController> _logger;

        //public HomeController(ILogger<HomeController> logger)
        //{
        //    _logger = logger;
        //}

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Collection()
        {
            return View();
        }

        [HttpGet]
        public IActionResult AboutJoel()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Form()
        {
            return View();
        }

        [HttpPost]
        public IActionResult MovieCollection(Movies Response)
        {
            _context.Movies.Add(Response);
            _context.SaveChanges();

            return View("Confirmation", Response);
        }


    }
}
