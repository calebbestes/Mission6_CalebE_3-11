using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Mission6_CalebE_3_11.Models;
using NuGet.Packaging.Signing;

namespace Mission6_CalebE_3_11.Controllers
{
    public class HomeController : Controller
    {
        private MovieCollectionContext _context;
        public HomeController(MovieCollectionContext temp)
        {
            _context = temp;
        }


        [HttpGet]
        public IActionResult Index()
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
            ViewBag.Categories = _context.Categories
                .OrderBy(x => x.CategoryName).ToList();
            return View("Form");
        }


        [HttpPost]
        public IActionResult Form(Movie Response)
        {
            _context.Movies.Add(Response);
            _context.SaveChanges();

            return View("Confirmation", Response);
        }


        [HttpGet]
        public IActionResult Collection()
        {
            var movies = _context.Movies.Include(x=>x.Category).ToList()
                 .OrderBy(x => x.Title).ToList();
            return View(movies);
        }

        [HttpGet]

        public IActionResult Edit(int id)
        {
            var recordToEdit = _context.Movies
                .Single(x => x.MovieId == id);

            ViewBag.Categories = _context.Categories
                .OrderBy(x => x.CategoryName).ToList();

            return View("Form", recordToEdit);
        }

        [HttpPost]
        public IActionResult Edit(Movie updatedInfo)
        {
            _context.Update(updatedInfo);
            _context.SaveChanges();
            return RedirectToAction("Collection");
        }

        [HttpGet]
        public IActionResult Delete(int id) {
            var recordToDelete = _context.Movies
                .Single(x => x.MovieId == id);

            return View("Delete", recordToDelete);
        }

        [HttpPost]
        public IActionResult Delete(Movie record) {
            _context.Remove(record);
            _context.SaveChanges();
            return RedirectToAction("Collection");
        }

    }
}
