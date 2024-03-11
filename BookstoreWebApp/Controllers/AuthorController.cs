using Bookstore.Models;
using Bookstore;
using Microsoft.AspNetCore.Mvc;

namespace BookstoreWebApp.Controllers
{
    public class AuthorController : Controller
    {
        // GET: AuthorController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: AuthorController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Author authorToAdd)
        {
            try
            {
                BookStoreBasicFunctions.AddAuthor(authorToAdd);
                return RedirectToAction("Authors", "Home");
            }
            catch
            {
                return View();
            }
        }

        // GET: AuthorController/Edit/5
        public ActionResult Edit(int id)
        {
            var author = BookStoreBasicFunctions.GetAuthorById(id);
            return View(author);
        }

        // POST: AuthorController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Author authorToEdit)
        {
            try
            {
                BookStoreBasicFunctions.EditAuthor(authorToEdit);
                return RedirectToAction("Authors", "Home");
            }
            catch
            {
                return View();
            }
        }

        // GET: AuthorController/Delete/5
        public ActionResult Delete(int id)
        {
            var author = BookStoreBasicFunctions.GetAuthorById(id);
            return View(author);
        }

        // POST: AuthorController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(Author author)
        {
            try
            {
                BookStoreBasicFunctions.DeleteAuthor(author.AuthorId);
                return RedirectToAction("Authors", "Home");
            }
            catch
            {
                return View();
            }
        }
    }
}
