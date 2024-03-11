using BookstoreWebApp.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Bookstore;

namespace BookstoreWebApp.Controllers
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
            var bookList = BookStoreBasicFunctions.GetAllBooksFull();
            return View(bookList);
        }

        public IActionResult Books()
        {
            var bookList = BookStoreBasicFunctions.GetAllBooksFull();
            return View(bookList);
        }

        public IActionResult Authors()
        {
            var authorList = BookStoreBasicFunctions.GetAllAuthors();
            return View(authorList);
        }

        public IActionResult Genres()
        {
            var genreList = BookStoreBasicFunctions.GetAllGenres();
            return View(genreList);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
