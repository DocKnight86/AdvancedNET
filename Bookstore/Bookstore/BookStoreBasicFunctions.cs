using Bookstore.Models;

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

        public static List<Book> GetAllBooks()
        {
            using (var db = new SE407_BookStoreContext())
            {
                return db.Books.ToList();
            }
        }

        public static List<Book> GetBooksByAuthorLastName(string lastName)
        {
            using (var db = new SE407_BookStoreContext())
            {
                return db.Books.Where(m => m.Author.AuthorLast == lastName).ToList();
            }
        }
    }
}
