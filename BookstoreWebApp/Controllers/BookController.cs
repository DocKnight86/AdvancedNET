using Bookstore;
using Bookstore.Models;
using BookstoreWebApp.Helpers;
using Microsoft.AspNetCore.Mvc;

namespace BookstoreWebApp.Controllers
{
    public class BookController : Controller
    {
        // GET: BookController/Details/5
        public ActionResult Details(int id)
        {
            var book = BookStoreBasicFunctions.GetBookById(id);
            return View(book);
        }

        // GET: BookController/Create
        public ActionResult Create()
        {
            ViewBag.GenreId = DropDownFormatter.FormatGenres();
            ViewBag.AuthorId = DropDownFormatter.FormatAuthors();
            return View();
        }

        // POST: BookController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Book bookToCreate)
        {
            try
            {
                BookStoreBasicFunctions.AddBook(bookToCreate);
                return RedirectToAction("Books", "Home");
            }
            catch
            {
                return View();
            }
        }

        // GET: BookController/Edit/5
        public ActionResult Edit(int id)
        {
            var book = BookStoreBasicFunctions.GetBookById(id);
            ViewBag.GenreId = DropDownFormatter.FormatGenres();
            ViewBag.AuthorId = DropDownFormatter.FormatAuthors();
            return View(book);
        }

        // POST: BookController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Book bookToEdit)
        {
            try
            {
                BookStoreBasicFunctions.EditBook(bookToEdit);
                return RedirectToAction("Books", "Home");
            }
            catch
            {
                return View();
            }
        }

        // GET: BookController/Delete/5
        public ActionResult Delete(int id)
        {
            var book = BookStoreBasicFunctions.GetBookById(id);
            return View(book);
        }

        // POST: BookController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(Book book)
        {
            try
            {
                BookStoreBasicFunctions.DeleteBook(book.BookId);
                return RedirectToAction("Books", "Home");
            }
            catch
            {
                return View();
            }
        }
    }
}
