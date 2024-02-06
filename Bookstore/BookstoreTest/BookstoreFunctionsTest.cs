using Bookstore;

namespace BookstoreTest
{
    public class BookstoreFunctionsTest
    {
        [Fact]
        public void GetBookByTitleTest()
        {
            var result = BookStoreBasicFunctions.GetBookByTitle("Cthulu Mythos");
            Assert.True(result.BookTitle == "Cthulu Mythos");
        }

        [Fact]
        public void GetAllBooksTest()
        {
            var result = BookStoreBasicFunctions.GetAllBooks();
            Assert.True(result.Count == 4);
        }

        [Fact]
        public void GetMoviesByDirectorLastName()
        {
            var expectedLastName = "Geoffrey Chaucer";

            var result = BookStoreBasicFunctions.GetBooksByAuthorLastName(expectedLastName);

            Assert.All(result, m => Assert.Equal(expectedLastName, m.Author.AuthorLast));
        }
    }
}
