using Bookstore;
using Bookstore.Models;
using Microsoft.AspNetCore.Mvc;

namespace BookstoreWebApp.Controllers
{
    public class GenreController : Controller
    {
        // GET: GenreController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: GenreController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Genre genreToAdd)
        {
            try
            {
                BookStoreBasicFunctions.AddGenre(genreToAdd);
                return RedirectToAction("Genres", "Home");
            }
            catch
            {
                return View();
            }
        }

        // GET: GenreController/Edit/5
        public ActionResult Edit(int id)
        {
            var genre = BookStoreBasicFunctions.GetGenreById(id);
            return View(genre);
        }

        // POST: GenreController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Genre genreToEdit)
        {
            try
            {
                BookStoreBasicFunctions.EditGenre(genreToEdit);
                return RedirectToAction("Genres", "Home");
            }
            catch
            {
                return View();
            }
        }

        // GET: GenreController/Delete/5
        public ActionResult Delete(int id)
        {
            var genre = BookStoreBasicFunctions.GetGenreById(id);
            return View(genre);
        }

        // POST: GenreController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(Genre genreToDelete)
        {
            try
            {
                BookStoreBasicFunctions.DeleteGenre(genreToDelete.GenreId);
                return RedirectToAction("Genres", "Home");
            }
            catch
            {
                return View();
            }
        }
    }
}
