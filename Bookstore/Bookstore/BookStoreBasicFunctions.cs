using Bookstore.Models;
using Microsoft.EntityFrameworkCore;

namespace Bookstore
{
    public class BookStoreBasicFunctions
    {
        public static Book GetBookByTitle(string title)
        {
            using (var db = new SE407_BookStoreContext())
            {
                return db.Books.FirstOrDefault(m => m.BookTitle == title);
            }
        }

        public static Book GetBookById(int id)
        {
            using (var db = new SE407_BookStoreContext())
            {
                var books = db.Books
                    .Include(books => books.Author)
                    .Include(books => books.Genre)
                    .Where(books => books.BookId == id)
                    .FirstOrDefault();

                return books;
            }
        }

        public static List<Book> GetAllBooks()
        {
            using (var db = new SE407_BookStoreContext())
            {
                return db.Books.ToList();
            }
        }

        public static List<Book> GetAllBooksFull()
        {
            using (var db = new SE407_BookStoreContext())
            {
                var books = db.Books
                    .Include(books => books.Author)
                    .Include(books => books.Genre)
                    .ToList();

                return books;
            }
        }

        public static List<Author> GetAllAuthors()
        {
            using (var db = new SE407_BookStoreContext())
            {
                return db.Authors.ToList();
            }
        }

        public static List<Book> GetBooksByAuthorLastName(string lastName)
        {
            using (var db = new SE407_BookStoreContext())
            {
                return db.Books.Where(m => m.Author.AuthorLast == lastName).ToList();
            }
        }

        public static Author GetAuthorById(int id)
        {
            using (var db = new SE407_BookStoreContext())
            {
                var author = db.Authors
                    .Where(author => author.AuthorId == id)
                    .FirstOrDefault();

                return author;
            }
        }

        public static Genre GetGenreById(int id)
        {
            using (var db = new SE407_BookStoreContext())
            {
                var genre = db.Genres
                    .Where(genre => genre.GenreId == id)
                    .FirstOrDefault();

                return genre;
            }
        }

        public static List<Genre> GetAllGenres()
        {
            using (var db = new SE407_BookStoreContext())
            {
                return db.Genres.ToList();
            }
        }

        public static void AddBook(Book book)
        {
            try
            {
                using (var db = new SE407_BookStoreContext())
                {
                    db.Books.Add(book);
                    db.SaveChanges();
                }
            }
            catch (Exception e)
            {

            }
        }

        public static void DeleteBook(int id)
        {
            try
            {
                using (var db = new SE407_BookStoreContext())
                {
                    var bookToDelete = db.Books.Find(id);
                    db.Books.Remove(bookToDelete);
                    db.SaveChanges();

                }
            }
            catch (Exception e)
            {

            }
        }

        public static void EditBook(Book book)
        {
            try
            {
                using (var db = new SE407_BookStoreContext())
                {
                    db.Books.Update(book);
                    db.SaveChanges();
                }
            }
            catch (Exception e)
            {

            }
        }

        public static void AddAuthor(Author author)
        {
            try
            {
                using (var db = new SE407_BookStoreContext())
                {
                    db.Authors.Add(author);
                    db.SaveChanges();

                }
            }
            catch (Exception e)
            {

            }
        }

        public static void DeleteAuthor(int id)
        {
            try
            {
                using (var db = new SE407_BookStoreContext())
                {
                    var authorToDelete = db.Authors.Find(id);
                    db.Authors.Remove(authorToDelete);
                    db.SaveChanges();

                }
            }
            catch (Exception e)
            {

            }
        }

        public static void EditAuthor(Author author)
        {
            try
            {
                using (var db = new SE407_BookStoreContext())
                {
                    db.Authors.Update(author);
                    db.SaveChanges();
                }
            }
            catch (Exception e)
            {

            }
        }

        public static void AddGenre(Genre genre)
        {
            try
            {
                using (var db = new SE407_BookStoreContext())
                {
                    db.Genres.Add(genre);
                    db.SaveChanges();

                }
            }
            catch (Exception e)
            {

            }
        }

        public static void DeleteGenre(int id)
        {
            try
            {
                using (var db = new SE407_BookStoreContext())
                {
                    var genreToDelete = db.Genres.Find(id);
                    db.Genres.Remove(genreToDelete);
                    db.SaveChanges();

                }
            }
            catch (Exception e)
            {

            }
        }

        public static void EditGenre(Genre genre)
        {
            try
            {
                using (var db = new SE407_BookStoreContext())
                {
                    db.Genres.Update(genre);
                    db.SaveChanges();
                }
            }
            catch (Exception e)
            {

            }
        }
    }
}
